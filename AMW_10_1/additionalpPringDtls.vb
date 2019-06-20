Imports System.Data.SqlClient

Public Class additionalpPringDtls

#Region "Design"
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles panalTitle.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            'Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If
    End Sub
    Private Sub lblCross_Click(sender As Object, e As EventArgs) Handles lblCross.Click
        Me.Close()
    End Sub
    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles panalTitle.MouseMove
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub

    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles panalTitle.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            'Me.Cursor = Cursors.Default
        End If
    End Sub



#End Region
    Private Sub additionalpPringDtls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dpIssueDate.Value = Today
        dpDueDate.MinDate = Today
        dpDueDate.Value = Today.AddMonths(6)
        dpNID.MinDate = Today
        dpNID.Value = Today.AddMonths(1)
    End Sub

    Private Sub TxtPia_keyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPIA.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Not e.KeyChar = ".") And (Not Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If
        If (e.KeyChar = ".") Then
            If txtPIA.Text.Contains(".") Then
                e.Handled = True
            End If
        End If
    End Sub

    Private ClienName As String, destin As String, isueDate As Date, pan As String, gstNo As String, address As String,
                        delnote As String, regard As String, itemTable As New DataTable, dclaration As String, invn As String, amt As Decimal, description As String, itemNO As Integer, isChallan As Integer, billNo As String

    Private Max_Payment As Decimal

    Public Sub init(ClinName As String, dstin As String, pn As String, gtNo As String, adress As String,
                        dlnote As String, rgard As String, iemTable As DataTable, dlaration As String, aamt As Decimal, description As String, itemNO As Integer, isChallan As Integer, billNo As String)
        ClienName = ClinName
        destin = dstin
        If isChallan Then
            VAT = 0
        Else
            VAT = ConstantClass.VAT
        End If
        Me.isChallan = isChallan
        amt = aamt
        Max_Payment = amt + amt * VAT / 100
        gstNo = gtNo
        pan = pn
        address = adress
        delnote = dlnote
        regard = rgard
        ' itemTable.Clear()
        itemTable = iemTable
        dclaration = dlaration
        Me.description = description
        Me.itemNO = itemNO
        Me.billNo = billNo
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If saveList() Then
            Dim printNumber As Integer = 1
            If isChallan Then
                printNumber = 3            
            End If
            For printNumber = printNumber To 3
                Dim fp As New PrintInitializer
                fp.printInvoice(ClienName, destin, invn, isueDate, dpDueDate.Value, comboPaymentType.SelectedItem, pan, gstNo, address, delnote, regard, txtSC.Text, txtPOS.Text, itemTable, dclaration, printNumber, amt)
            Next
            If isChallan Then
                errmsg.msggetter("Bill successfully saved. Invoice No: " + invn, True)
            Else
                errmsg.msggetter("Printing done. Invoice No: " + invn, True)
            End If

            Me.Close()
        Else
            errmsg.msggetter("An unknown error has occured", False)
        End If
    End Sub

    Private errmsg As New messager
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Function saveList() As Boolean
        If txtPIA.Text > Max_Payment Then            
            errmsg.msggetter("Payment exceeds from " + Max_Payment.ToString, False)
            Return 0
        End If
        Dim inv_ref As String
        isueDate = dpIssueDate.Value
        inv_ref = createInvoice()
        If String.Equals(inv_ref, "error") Then
            Return 0
        Else
            invn = inv_ref
            Return 1
        End If

    End Function
    Dim VAT As Decimal

    Private Function createInvoice() As String
        Dim con As New SqlConnection(ConstantClass.connectionString)
        Dim trans As SqlTransaction
        Dim cmdcls As New cmdClass
        con.Open()
        trans = con.BeginTransaction
        Dim invID As New Integer
        Dim inv_ref As String = "error"
        Try
            Dim cmd As New SqlCommand("addNewInvoice", con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@ClientName", SqlDbType.NVarChar).Value = ClienName
            cmd.Parameters.Add("@BillAmt", SqlDbType.Decimal).Value = amt
            cmd.Parameters.Add("@SGST", SqlDbType.Decimal).Value = amt * VAT / 200
            cmd.Parameters.Add("@CGST", SqlDbType.Decimal).Value = amt * VAT / 200
            cmd.Parameters.Add("@DeliveryAddress", SqlDbType.NVarChar).Value = destin
            cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = description
            cmd.Parameters.Add("@BilledBy", SqlDbType.Int).Value = ConstantClass.UserID
            cmd.Parameters.Add("@StateCode", SqlDbType.NVarChar).Value = txtSC.Text
            cmd.Parameters.Add("@PlaceOfSupply", SqlDbType.NVarChar).Value = txtPOS.Text
            cmd.Parameters.Add("@Discount", SqlDbType.Decimal).Value = 0.0
            cmd.Parameters.Add("@ShippingCharges", SqlDbType.Decimal).Value = 0.0
            cmd.Parameters.Add("@MantainanceCharges", SqlDbType.Decimal).Value = 0.0
            cmd.Parameters.Add("@AdditionalCharges", SqlDbType.Decimal).Value = 0.0
            cmd.Parameters.Add("@IsChallan", SqlDbType.Int).Value = isChallan
            cmd.Parameters.Add("@IssueDate", SqlDbType.Date).Value = isueDate
            cmd.Parameters.Add("@invNO", SqlDbType.NVarChar).Value = billNo
            cmd.Transaction = trans
            invID = cmd.ExecuteScalar()

            Dim cmdAddInvoiceItems As New SqlCommand
            cmdAddInvoiceItems.CommandType = CommandType.StoredProcedure
            cmdAddInvoiceItems.Connection = con
            cmdAddInvoiceItems.Transaction = trans
            cmdAddInvoiceItems.CommandText = "addInvoiceItems"
            For i As Integer = 0 To itemNO - 1
                cmdAddInvoiceItems.Parameters.Clear()
                cmdAddInvoiceItems.Parameters.Add("@invID", SqlDbType.Int).Value = invID
                cmdAddInvoiceItems.Parameters.Add("@itemName", SqlDbType.NVarChar).Value = itemTable.Rows(i).Item(1)
                cmdAddInvoiceItems.Parameters.Add("@itemType", SqlDbType.NVarChar).Value = itemTable.Rows(i).Item(2)
                cmdAddInvoiceItems.Parameters.Add("@QTY", SqlDbType.Decimal).Value = itemTable.Rows(i).Item(3)
                cmdAddInvoiceItems.Parameters.Add("@rate", SqlDbType.Decimal).Value = itemTable.Rows(i).Item(6)
                cmdAddInvoiceItems.ExecuteNonQuery()
            Next

            Dim cmdPayDtls As New SqlCommand
            cmdPayDtls.CommandType = CommandType.StoredProcedure
            cmdPayDtls.Connection = con
            cmdPayDtls.Transaction = trans
            cmdPayDtls.CommandText = "addPayDtls"
            cmdPayDtls.Parameters.Add("@InvoiceID", SqlDbType.Int).Value = invID
            cmdPayDtls.Parameters.Add("@TotalAmt", SqlDbType.Decimal).Value = amt + (amt * VAT / 100)
            cmdPayDtls.Parameters.Add("@Paid", SqlDbType.Decimal).Value = txtPIA.Text
            cmdPayDtls.Parameters.Add("@DueDate", SqlDbType.Date).Value = dpDueDate.Value
            cmdPayDtls.Parameters.Add("@Discount", SqlDbType.Decimal).Value = 0
            cmdPayDtls.Parameters.Add("@NextInstallmentDate", SqlDbType.Date).Value = dpNID.Value
            cmdPayDtls.Parameters.Add("@NextInstallmentSaidAmt", SqlDbType.Decimal).Value = 0
            Dim payID As Integer = cmdPayDtls.ExecuteScalar()

            Dim cmdPaydesc As New SqlCommand
            cmdPaydesc.CommandText = "addNewpayDesc"
            cmdPaydesc.CommandType = CommandType.StoredProcedure
            cmdPaydesc.Connection = con
            cmdPaydesc.Transaction = trans
            cmdPaydesc.Parameters.Add("@PayDtlsID", SqlDbType.Int).Value = payID
            cmdPaydesc.Parameters.Add("@PaymentTaken", SqlDbType.Decimal).Value = txtPIA.Text
            cmdPaydesc.Parameters.Add("@AcceptedBy", SqlDbType.Int).Value = ConstantClass.UserID
            cmdPaydesc.Parameters.Add("@PayMode", SqlDbType.NVarChar).Value = comboPaymentType.SelectedText
            cmdPaydesc.Parameters.Add("@ChequeNo", SqlDbType.NVarChar).Value = txtCN.Text
            cmdPaydesc.ExecuteNonQuery()
            trans.Commit()
            inv_ref = cmdcls.returnSimpleScalerQuery("select Inv_refNo from InvoiceTable where id=" + invID.ToString)
            Return inv_ref
        Catch ex As Exception
            trans.Rollback()
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
        Return inv_ref
    End Function

    Private Sub comboPaymentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboPaymentType.SelectedIndexChanged
        If comboPaymentType.SelectedIndex = 0 Then
            lblCN.Text = "Cheque No"
        ElseIf comboPaymentType.SelectedIndex = 1 Then
            lblCN.Text = "Cash description"
        ElseIf comboPaymentType.SelectedIndex = 2 Then
            lblCN.Text = "CARD NUMBER"
        ElseIf comboPaymentType.SelectedIndex = 3 Then
            lblCN.Text = "Transection ID"
        Else
            lblCN.Text = "Transection details"
        End If
    End Sub

    Private Sub onlyNumeric(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPIA.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Not Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If
    End Sub

End Class