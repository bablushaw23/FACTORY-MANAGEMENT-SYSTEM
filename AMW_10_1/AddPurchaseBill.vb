Public Class AddPurchaseBill

#Region "Design"
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            'Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If
    End Sub
    Private Sub lblCross_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs)
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub

    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            'Me.Cursor = Cursors.Default
        End If
    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub lblmaximizeMinimize_Click(sender As Object, e As EventArgs)
        If Me.WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        ElseIf WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        End If
    End Sub
#End Region

    Private Sub AddPurchaseBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New cmdClass
        txtCustName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtCustName.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtCustName.AutoCompleteCustomSource = cmd.returnAutocomplete("select name from PurchaseClientlDtlsTable", False)
        dtpIssueDate.Value = Today.Date
        txtCustName.Focus()
        dtpDeliveryDate.MaxDate = Today.Date
        dtpDeliveryDate.Value = Today.Date
        assignItems()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        resetSetter()
    End Sub

    Private Sub resetSetter()

        txtHSN.Text = ""
        txtItemDesc.Text = ""
        txtCGSTRate.Text = 9
        txtSGSTRate.Text = 9
        txtRate.Text = 0
        txtQty.Text = 0
        lblEachAmt.Text = "0."
        txtUnit.Text = 0
    End Sub

    Private errmsg As New messager
    Private Sub comboGST_GotFocus(sender As Object, e As EventArgs) Handles comboGST.GotFocus
        If Not validName() Then
            errmsg.msggetter("Invalid Client name", False)
            txtCustName.Focus()
        End If
        Dim cmd As New cmdClass
        Dim collection As AutoCompleteStringCollection = cmd.returnAutocomplete("select GSTIN from PurchaseClientlDtlsTable where name='" + txtCustName.Text + "'", False)
        For Each element As String In collection
            comboGST.Items.Add(element)
        Next
    End Sub

    Private Function validName() As Boolean
        If txtCustName.Text.Length < 1 Then
            Return False
        End If
        Dim collection As AutoCompleteStringCollection
        collection = txtCustName.AutoCompleteCustomSource
        For Each element As String In collection
            If txtCustName.Text = element Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub assignItems()
        Dim collection As New AutoCompleteStringCollection
        Dim cmd As New cmdClass
        txtItemDesc.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtItemDesc.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtItemDesc.AutoCompleteCustomSource = cmd.returnAutocomplete("select ItemDescription from PurchaseInvoiceIItemTable", False)
        
    End Sub

    Private Sub setAmount(sender As Object, e As EventArgs) Handles txtQty.LostFocus, txtRate.LostFocus, txtSGSTRate.LostFocus, txtCGSTRate.LostFocus
        Try
            Dim taxAmt = txtQty.Text * txtRate.Text
            lblEachAmt.Text = taxAmt * txtCGSTRate.Text / 100 + taxAmt * txtSGSTRate.Text / 100 + taxAmt
        Catch ex As Exception
            lblEachAmt.Text = "0."
        End Try
    End Sub

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        Try
            addIntoGridView()
            resetSetter()            
        Catch
            errmsg.msggetter("Data error", False)
        End Try
    End Sub



    Private Sub txtRate_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtRate.KeyPress, txtSGSTRate.KeyPress, txtQty.KeyPress, txtCGSTRate.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Not Asc(e.KeyChar) = 8) And (Not Asc(e.KeyChar) = 46) Then
            e.Handled = True
        End If
    End Sub
    Private Sub addIntoGridView()
        Dim taxableAmt As Double = (txtRate.Text * txtQty.Text)
        Dim cgstAmt, sgstAmt As Double
        cgstAmt = (taxableAmt * txtCGSTRate.Text / 100)
        sgstAmt = (taxableAmt * txtSGSTRate.Text / 100)

        Dim row As String() = New String() {
            (itemGRID.Rows.Count + 1).ToString(),
            txtHSN.Text,
            txtItemDesc.Text,
            txtQty.Text,
            txtUnit.Text,
            txtRate.Text,
            taxableAmt,
            txtCGSTRate.Text,
            cgstAmt,
            txtSGSTRate.Text,
            sgstAmt,
            (taxableAmt + cgstAmt + sgstAmt)
        }
        itemGRID.Rows.Add(row)
    End Sub

    Private Sub itemGRID_RowsAdded() Handles itemGRID.RowsAdded, itemGRID.RowsRemoved
        calculateTotal()
    End Sub

    Private Sub calculateTotal()
        Try
            Dim totalAmt, totalQty, totalTaxable, totalTax As Double            
            For Each row As DataGridViewRow In itemGRID.Rows
                totalQty += row.Cells(3).Value
                totalTaxable += row.Cells(6).Value
                totalTax += Double.Parse(row.Cells(8).Value) + row.Cells(10).Value
                totalAmt += row.Cells(11).Value
            Next
            lblTotalPayable.Text = totalAmt + nmMantainance.Value + nmOther.Value + nmShipping.Value
            lblTotalQty.Text = totalQty
            lblTotalTax.Text = totalTax
            lblTotalTaxable.Text = totalTaxable
        Catch
            errmsg.msggetter("An error has occured during calculating total", False)
        End Try
    End Sub

    Private Sub dtpIssueDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpIssueDate.ValueChanged
        dtpDeliveryDate.MinDate = dtpIssueDate.Value
    End Sub

    Private Function validation() As Boolean
        If txtBillNO.Text.Length < 2 Then
            errmsg.msggetter("Invalid Bill No", False)
            Return False
        End If
        If itemGRID.RowCount = 0 Then
            errmsg.msggetter("No item selected", False)
            Return False
        End If
        If txtCustName.Text.Length < 2 Then
            errmsg.msggetter("Invalid Merchant name", False)
            Return False
        End If
        If comboGST.Text.Length < 1 Then
            errmsg.msggetter("Invalid GST No", False)
            Return False
        End If
        Return True
    End Function
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If validation() Then
            Dim cmd As New cmdClass
            Dim transection As SqlClient.SqlTransaction

            Dim connection As New SqlClient.SqlConnection(ConstantClass.connectionString)
            connection.Open()
            transection = connection.BeginTransaction("purchaseEntryTransection")
            Try
                Dim invID As Integer = cmd.addNewPurchaseCMD(Me, transection, connection)
                cmd.addNewPurchaseItemCMD(invID, createItmTable(), transection, connection)
                transection.Commit()
                connection.Close()
                errmsg.msggetter("Entry successfully saved", True)
            Catch ex As Exception
                MsgBox("!!NOT SAVED AS :" + ex.Message)

                transection.Rollback()
                connection.Close()
            End Try


            connection.Dispose()
            transection.Dispose()
        End If
    End Sub

    Private Sub nmShipping_ValueChanged(sender As Object, e As EventArgs) Handles nmShipping.ValueChanged, nmMantainance.ValueChanged, nmOther.ValueChanged
        calculateTotal()
    End Sub



    Private Function createItmTable() As DataTable
        Dim dt = New DataTable
        For Each col As DataGridViewColumn In itemGRID.Columns

            dt.Columns.Add(col.Name)
        Next

        For Each row As DataGridViewRow In itemGRID.Rows

            Dim dRow As DataRow = dt.NewRow()
            For Each cell As DataGridViewCell In row.Cells

                dRow.Item(cell.ColumnIndex) = cell.Value
            Next
            dt.Rows.Add(dRow)
        Next
        Return dt
    End Function

   
End Class