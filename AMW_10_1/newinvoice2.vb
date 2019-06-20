Imports System.Data.SqlClient

Public Class newinvoice2
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

    Private Sub Billing2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        keyEvent(e)
    End Sub




    Private Sub Billing2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        setCustomers()
        nextInvoiceNo()
        itemNameInitializer()
        VAT = ConstantClass.VAT
    End Sub
    Private Property VAT As Decimal

    Dim cmdCls As New cmdClass
    Private Sub keyEvent(e As KeyEventArgs)
        If e.KeyCode = Keys.F9 Then
            proceed()
        End If
    End Sub




    Private Sub DELETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem.Click
        Try
            itemGRID.Rows.RemoveAt(currentMouseRowIndex)
            srNoResetter()
        Catch ex As Exception
        End Try
    End Sub


    Private Sub setCustomers()
        txtCustName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        txtCustName.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtCustName.AutoCompleteCustomSource = cmdCls.returnAutocomplete("select Name from ClientlDtlsTable", False)
    End Sub
    Private Sub itemNameInitializer()
        'txtItemName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ' txtItemName.AutoCompleteSource = AutoCompleteSource.CustomSource
        Dim query As String = "select distinct Name from ItemTable where status=1 and Qty>0"
        comboItemName.DataSource = cmdCls.returnAutocomplete(query, False)

        'txtItemName.AutoCompleteCustomSource = cmdCls.returnAutocomplete(query, False)
    End Sub

#Region "waste"

    'Private Function initializeSavingBill() As Integer
    '    Throw New NotImplementedException
    '    Dim cmd As New SqlCommand
    '    Dim con As New SqlConnection(ConstantClass.connectionString)
    '    Dim transAction As SqlTransaction
    '    cmd.Connection = con
    '    cmd.CommandText = "insertIntoBillDtls"
    '    cmd.CommandType = CommandType.StoredProcedure
    '    cmd.Parameters.Add("@lastEditedBy", SqlDbType.Int).Value = ConstantClass.UserID
    '    cmd.Parameters.Add("@CustName", SqlDbType.NVarChar).Value = txtCustName.Text
    '    cmd.Parameters.Add("@CustAdd", SqlDbType.NVarChar).Value = txtCustAddress.Text
    '    cmd.Parameters.Add("@PaidAmt", SqlDbType.Decimal).Value = Decimal.Parse(lblTotalPayable.Text)
    '    cmd.Parameters.Add("@DiscountGiven", SqlDbType.Decimal).Value = Decimal.Parse(lblTotalDisc.Text)
    '    Dim pay = Decimal.Parse(lblTotalAmt.Text) - Decimal.Parse(lblTotalDisc.Text)
    '    cmd.Parameters.Add("@tax", SqlDbType.Decimal).Value = (pay * VAT / 100)
    '    con.Open()
    '    transAction = con.BeginTransaction()
    '    Try
    '        cmd.Transaction = transAction
    '        Dim billID As Integer = cmd.ExecuteScalar()
    '        For Each row As DataGridViewRow In itemGRID.Rows
    '            Dim cmdN As New SqlCommand()
    '            cmdN.Connection = con
    '            cmdN.Transaction = transAction
    '            cmdN.CommandText = "insertBillDescription"
    '            cmdN.CommandType = CommandType.StoredProcedure
    '            cmdN.Parameters.Add("@BillID", SqlDbType.Int).Value = billID
    '            cmdN.Parameters.Add("@ItemName", SqlDbType.NVarChar).Value = row.Cells(1).Value
    '            cmdN.Parameters.Add("@ItemType", SqlDbType.NVarChar).Value = row.Cells(2).Value
    '            'Dim table1 = getSets(row.Cells(1).Value, row.Cells(2).Value).Tables(1).Copy()
    '            Dim cmdSet As New SqlCommand
    '            cmdSet.CommandText = "getqty"
    '            cmdSet.CommandType = CommandType.StoredProcedure
    '            cmdSet.Transaction = transAction
    '            cmdSet.Connection = con
    '            cmdSet.Parameters.Add("@itemName", SqlDbType.NVarChar).Value = row.Cells(1).Value
    '            cmdSet.Parameters.Add("@itemType", SqlDbType.NVarChar).Value = row.Cells(2).Value
    '            Dim da As New SqlDataAdapter(cmdSet)
    '            Dim DS As New DataSet
    '            da.Fill(DS)
    '            Dim unit = AddNewItem.findUnitQty(biller.formatTable(DS.Tables(1)), row.Cells(4).Value) * row.Cells(3).Value
    '            'Dim unit As Decimal = (AddNewItem.findUnitQty(biller.formatTable(getSets(row.Cells(1).Value, row.Cells(2).Value).Tables(1).Copy()), row.Cells(4).Value)) * row.Cells(3).Value
    '            cmdN.Parameters.Add("@Quantity", SqlDbType.Decimal).Value = unit
    '            cmdN.Parameters.Add("@Amount", SqlDbType.Decimal).Value = row.Cells(9).Value
    '            cmdN.ExecuteNonQuery()
    '        Next
    '        transAction.Commit()
    '        'MsgBox("Bill Saved Successfully")
    '        Return billID
    '    Catch ex As Exception
    '        transAction.Rollback()
    '        MsgBox(ex.Message)
    '        Return 0
    '    Finally
    '        con.Close()
    '    End Try
    'End Function



#End Region
    Private Sub txtItemName_LostFocus(sender As Object, e As EventArgs) Handles comboType.GotFocus
        Try
            'Dim itemNames As New AutoCompleteStringCollection
            'itemNames = txtItemName.AutoCompleteCustomSource
            Dim itemValid As Boolean = False
            'For Each elem As String In itemNames
            For Each elem As String In comboItemName.DataSource
                'If txtItemName.Text = elem Then
                If comboItemName.SelectedValue = elem Then
                    itemValid = True
                    Exit For
                End If
            Next
            If itemValid Then
                Dim query As String = "select Type from ItemTable where Name='" + comboItemName.SelectedValue + "'"  'txtItemName.Text + "'"
                Dim table As New DataTable
                table = cmdCls.returnDataSet(query, False).Tables(0)
                comboType.Items.Clear()
                For Each row As DataRow In table.Rows
                    comboType.Items.Add(row.Item(0))
                Next
                comboType.SelectedIndex = 0
                txtQty.Enabled = True
                txtUnit.Enabled = True
                btnSet.Enabled = True
            Else
                errmsg.msggetter("Item not valid", 0)
                comboItemName.Focus()
            End If
        Catch
        End Try
    End Sub

    Dim errmsg As New messager

    Private Sub comboType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboType.SelectedIndexChanged
        If comboType.Items.Count > 0 Then
            setQty()
        End If
    End Sub

    Private maxQyt As Decimal

    Private Sub setQty()
        Dim cmd As New SqlCommand
        Dim dset As New DataSet
        cmd.CommandText = "ReurnItemQtyRate"
        cmd.CommandType = CommandType.StoredProcedure
        'cmd.Parameters.Add("@item", SqlDbType.NVarChar).Value = txtItemName.Text
        cmd.Parameters.Add("@item", SqlDbType.NVarChar).Value = comboItemName.SelectedValue
        cmd.Parameters.Add("@type", SqlDbType.NVarChar).Value = comboType.Text
        Dim con = New SqlConnection(ConstantClass.connectionString)
        Try
            cmd.Connection = con
            con.Open()
            Dim adapter As New SqlDataAdapter(cmd)
            adapter.Fill(dset)
        Catch ex As Exception
            MsgBox("Error from setQty...")
        Finally
            con.Close()
        End Try
        Dim totalUnit As Decimal = dset.Tables(0).Rows(0).Item(0)
        maxQyt = totalUnit
        Dim rate = dset.Tables(0).Rows(0).Item(1)
        lblRate.Text = String.Format("{0:n2}", rate)
        txtQty.Text = totalUnit
        txtUnit.Text = "PCS."
        showPrices()
    End Sub

    Private Sub showPrices()
        Try
            Dim totalUnit As Decimal = txtQty.Text
            Dim rate = lblRate.Text
            Dim amt = rate * totalUnit
            lblAmt.Text = String.Format("{0:n2}", amt)
            Dim ItemTotalDisc As Decimal = (nudDiscount.Value / 100) * amt
            lblPayable.Text = String.Format("{0:n2}", (amt - ItemTotalDisc))
        Catch
        End Try
    End Sub


    Private currentMouseRowIndex As Integer
    Private Sub CALCULATORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULATORToolStripMenuItem.Click
        System.Diagnostics.Process.Start("calc")
    End Sub

    Private Sub NOTESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NOTESToolStripMenuItem.Click
        Dim locasun As String = "..\temp\myFile" + ConstantClass.UserID.ToString() + ".txt"
        Process.Start("notepad.exe", locasun)
    End Sub

    'Private Sub newBill() Handles BillToolStripMenuItem.Click
    '    Dim newBill As New newinvoice2
    '    newBill.Show()
    'End Sub

    Private Sub txtCustName_TextChanged(sender As Object, e As EventArgs) Handles txtCustName.LostFocus
        If (txtCustName.Text.Trim().Length > 0) And (Not txtCustName.Text = "General") Then
            Dim validCust As Boolean
            Dim custList = txtCustName.AutoCompleteCustomSource
            For Each elem As String In custList
                If elem.ToLower().TrimEnd() = txtCustName.Text.ToLower().TrimEnd() Then
                    validCust = True
                    Exit For
                End If
            Next
            If Not validCust Then
                errmsg.msggetter("Enter Valid Client's Name or Leave Blank", 0)
                txtCustName.Focus()
                Return
            End If

            Dim query As String = "select MailingAddress,ShippingAddress from ClientlDtlsTable where Name='" + txtCustName.Text + "'"
            comboCustAddress.Items.Clear()
            Dim row As DataRow = cmdCls.returnDataSet(query, False).Tables(0).Rows(0)
            For item As Integer = 0 To 1
                comboCustAddress.Items.Add(row.Item(item))
            Next
            comboCustAddress.SelectedIndex = 0
        Else
            txtCustName.Text = "General"
            comboCustAddress.Text = "General"
        End If

    End Sub

    Private Sub itemGRID_RowsAdded() Handles itemGRID.RowsAdded, itemGRID.RowsRemoved
        Try
            Dim totalAmt = 0, totalDisc = 0, totalPayable = 0
            For Each row As DataGridViewRow In itemGRID.Rows
                totalDisc += row.Cells(8).Value
                totalAmt += row.Cells(7).Value
                totalPayable += row.Cells(9).Value
            Next
            lblTotalAmt.Text = totalAmt
            lblTotalDisc.Text = totalDisc
            lblTotalTax.Text = (totalPayable * VAT / 100)
            lblTotalPayable.Text = totalPayable + lblTotalTax.Text
        Catch
        End Try
    End Sub

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click
        If lastValidation() Then
            addIntoGrid()
            resetSeter()
        End If
    End Sub
    Private Sub resetSeter() Handles btnReset.Click
        Try
            lblAmt.Text = 0
            nudDiscount.Value = 0.0
            lblPayable.Text = 0
            lblRate.Text = 0
            txtQty.Enabled = False
            txtUnit.Enabled = False
            btnSet.Enabled = False
            comboType.Items.Clear()
            txtQty.Text = ""
            'txtItemName.Text = ""
            'txtItemName.Focus()
            comboItemName.SelectedIndex = 0
            comboItemName.Focus()
        Catch
        End Try
    End Sub
    Private Sub addIntoGrid()
        Try
            Dim row As String() = New String() {(itemGRID.Rows.Count + 1).ToString(),
            comboItemName.SelectedValue,
            comboType.SelectedItem,
            txtQty.Text,
            txtUnit.Text,
            cmdCls.returnSimpleScalerQuery("select HSN from ItemTable where Name='" + comboItemName.SelectedValue + "' and Type='" + comboType.Text + "'"),
            lblRate.Text,
            lblAmt.Text,
            lblAmt.Text - lblPayable.Text,
            lblPayable.Text
            }
            itemGRID.Rows.Add(row)
        Catch
        End Try
    End Sub
    Private Function lastValidation() As Boolean
        Try
            Dim searchResult = searchSameItem()
            If searchResult > 0 Then
                errmsg.msggetter("Same item already entered at row no." + searchResult.ToString(), 0)
                Return False
            ElseIf Not (txtQty.Text > 0 And txtQty.Text <= maxQyt) Then
                errmsg.msggetter("Stock not available.Quantity resetting to max", 0)
                txtQty.Text = maxQyt
                txtQty.Focus()
                Return False
            ElseIf itemGRID.Rows.Count = 6 Then
                errmsg.msggetter("Maximum 6 items can be added", 0)
                Return False
            Else
                Return True
            End If
        Catch
            Return False
        End Try
        Return True
    End Function
    Private Function searchSameItem() As Integer
        For Each row As DataGridViewRow In itemGRID.Rows
            If comboItemName.SelectedValue.TrimEnd().ToLower() = row.Cells(1).Value.ToString().TrimEnd().ToLower() And comboType.SelectedItem = row.Cells(2).Value Then
                Return row.Cells(0).Value
            End If
        Next
        Return 0

    End Function
    Private Sub itemGRID_CellClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles itemGRID.CellMouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            currentMouseRowIndex = e.RowIndex
            itemGRID.Rows(e.RowIndex).Selected = True
            gridContext.Show(Cursor.Position)
        End If
    End Sub
    Private Sub srNoResetter()
        For Each row As DataGridViewRow In itemGRID.Rows
            row.Cells(0).Value = row.Index() + 1
        Next
    End Sub



    Private Sub EDITToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EDITToolStripMenuItem.Click
        Try
            Dim row As DataGridViewRow = itemGRID.Rows(currentMouseRowIndex)
            lblRate.Text = row.Cells(6).Value
            lblAmt.Text = row.Cells(7).Value
            nudDiscount.Value = (row.Cells(8).Value * 100) / lblAmt.Text
            lblPayable.Text = row.Cells(9).Value
            comboItemName.SelectedValue = row.Cells(1).Value
            comboType.Focus()
            comboType.SelectedItem = row.Cells(2).Value
            txtQty.Text = row.Cells(3).Value
            txtUnit.Text = row.Cells(4).Value
            itemGRID.Rows.RemoveAt(currentMouseRowIndex)
            srNoResetter()
        Catch
        End Try
    End Sub


    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged, lblRate.TextChanged
        showPrices()
    End Sub

    'Private Sub txtQty_LostFocus(sender As Object, e As EventArgs) Handles txtQty.LostFocus
    '    If txtQty.Text > maxQyt Then
    '        errmsg.msggetter("Quantity not available", False)
    '        txtQty.Focus()
    '    End If
    'End Sub

    Private Sub nudDiscount_ValueChanged(sender As Object, e As EventArgs) Handles nudDiscount.KeyUp, nudDiscount.ValueChanged
        showPrices()
    End Sub

    Dim replaceBill As Boolean = False
    Dim billNO As String = ""

    Public Sub replaceBillNo(billNo As String)
        replaceBill = True
        Me.billNO = billNo
    End Sub

    Private Sub proceed()
        If itemGRID.Rows.Count > 0 Then
            Dim print As New additionalpPringDtls
            Dim itemTable As New DataTable
            itemTable = createItmTable()
            Dim query As String = "select UIN,PAN_IT,MailingAddress from ClientlDtlsTable where Name='" + txtCustName.Text + "'"
            Dim row As DataRow = cmdCls.returnDataSet(query, False).Tables(0).Rows(0)
            If Not replaceBill Then
                print.init(txtCustName.Text, comboCustAddress.SelectedText, row.Item(1).ToString, row.Item(0).ToString, row.Item(2).ToString,
                            taNotes.Text, taCompliments.Text, itemTable, taDisclaimer.Text, lblTotalAmt.Text, taDescription.Text, itemGRID.Rows.Count, 0, billNO)
            Else
                print.init(txtCustName.Text, comboCustAddress.SelectedText, row.Item(1).ToString, row.Item(0), row.Item(2),
                            taNotes.Text, taCompliments.Text, itemTable, taDisclaimer.Text, lblTotalAmt.Text, taDescription.Text, itemGRID.Rows.Count, -1, billNO)
            End If
            print.ShowDialog()
        Else
            errmsg.msggetter("No item selected to print", 0)
        End If
    End Sub

    Private Function createItmTable() As DataTable
        Dim table As New DataTable
        Dim rowCount As Integer = itemGRID.Rows.Count
        For i As Integer = 1 To 8
            table.Rows.Add()
            table.Columns.Add()
        Next
        table.Rows.Add()
        For i As Integer = 0 To rowCount - 1
            table.Rows(i).Item(0) = itemGRID.Rows(i).Cells(0).Value
            table.Rows(i).Item(1) = itemGRID.Rows(i).Cells(1).Value
            table.Rows(i).Item(2) = itemGRID.Rows(i).Cells(2).Value
            table.Rows(i).Item(3) = itemGRID.Rows(i).Cells(3).Value
            table.Rows(i).Item(4) = itemGRID.Rows(i).Cells(4).Value
            table.Rows(i).Item(5) = itemGRID.Rows(i).Cells(5).Value
            table.Rows(i).Item(6) = itemGRID.Rows(i).Cells(6).Value
            table.Rows(i).Item(7) = itemGRID.Rows(i).Cells(7).Value
        Next
        For i As Integer = rowCount To 8
            table.Rows(i).Item(0) = " "
            table.Rows(i).Item(1) = " "
            table.Rows(i).Item(2) = " "
            table.Rows(i).Item(3) = " "
            table.Rows(i).Item(4) = " "
            table.Rows(i).Item(5) = " "
            table.Rows(i).Item(6) = " "
            table.Rows(i).Item(7) = " "
        Next
        Return table
    End Function
    Private Sub onlyNumeric(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress, lblRate.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Not Asc(e.KeyChar) = 8) And (Not Asc(e.KeyChar) = Asc(".")) Then
            e.Handled = True
        End If
    End Sub

    Private Sub nextInvoiceNo()
        If Not replaceBill Then
            Dim query = "select top 1 concat(prefix,billCounter,suffix) from additionalInfo"
            Dim cmdcls As New cmdClass
            billNO = cmdcls.returnSimpleScalerQuery(query)
        End If
        lblInvNo.Text = billNO.ToString
    End Sub

End Class