Imports System.Data.SqlClient

Public Class AddNewPayment
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
    Private Sub AddNewPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dpNID.MinDate = Today
        dpNID.Value = Today.AddMonths(1)
        comboPaymentType.SelectedIndex = 0
    End Sub

    Public Sub initializer(invID As String, payDtlsID As Integer, due As Decimal, amount As Decimal)
        lblInvRef.Text = invID
        lblAmt.Text = amount
        lblDue.Text = due
        numPay.Value = due
        numPay.Maximum = due + 1
        numPay.Minimum = 1
        Me.invID = invID
        Me.payDtlsID = payDtlsID
    End Sub

    Private Property invID As String
    Private Property payDtlsID As Integer

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

    '   Private Sub numPay_ValueChanged(sender As Object, e As EventArgs) Handles numPay.LostFocus
    '   If numPay.Value <= lblDue.Text Then
    '      If numPay.Value >= lblDue.Text Then
    '         dpNID.Enabled = False
    '        numNIA.Enabled = False
    '   Else
    '      dpNID.Enabled = True
    '     numNIA.Enabled = True
    'End If
    'Else
    '   errmsg.msggetter("Amount greater than due", False)
    'End If
    'End Sub

    Dim errmsg As New messager

    Private Sub btnReceivePay_Click(sender As Object, e As EventArgs) Handles btnReceivePay.Click
        '  If validatePayment() Then
        If savePayment() Then
            errmsg.msggetter("Payment successfully added", True)
            Me.Close()
        Else
            errmsg.msggetter("An error has occured. Payment doesn't added", False)
            Me.Close()
        End If
        ' End If
    End Sub

    Private Function validatePayment() As Boolean
        If numPay.Value < 1 Or numPay.Value > lblDue.Text Then
            errmsg.msggetter("Accepting amount not valid", False)
            Return False
        End If
        Return True
    End Function

    Private Function savePayment() As Boolean
        Dim con As New SqlConnection(ConstantClass.connectionString)
        Dim txn As SqlTransaction

        Dim cmdPaydesc As New SqlCommand
        cmdPaydesc.CommandText = "addPaymentDesc"
        cmdPaydesc.CommandType = CommandType.StoredProcedure
        cmdPaydesc.Connection = con

        cmdPaydesc.Parameters.Add("@payDtlsID", SqlDbType.Int).Value = payDtlsID
        cmdPaydesc.Parameters.Add("@amtReceived", SqlDbType.Decimal).Value = numPay.Value
        cmdPaydesc.Parameters.Add("@acceptedBy", SqlDbType.Int).Value = ConstantClass.UserID
        cmdPaydesc.Parameters.Add("@payMode", SqlDbType.NVarChar).Value = comboPaymentType.SelectedText
        If txtCN.Text.Length <> 0 Then
            cmdPaydesc.Parameters.Add("@ChequeNo", SqlDbType.NVarChar).Value = txtCN.Text
        Else
            cmdPaydesc.Parameters.Add("@ChequeNo", SqlDbType.NVarChar).Value = DBNull.Value
        End If
        If txtDesc.Text.Length <> 0 Then
            cmdPaydesc.Parameters.Add("@description", SqlDbType.NVarChar).Value = txtDesc.Text
        Else
            cmdPaydesc.Parameters.Add("@description", SqlDbType.NVarChar).Value = DBNull.Value
        End If

        If numPay.Value >= lblDue.Text Then
            cmdPaydesc.Parameters.Add("@nextPayAmt", SqlDbType.NVarChar).Value = DBNull.Value
            cmdPaydesc.Parameters.Add("@nextDate", SqlDbType.NVarChar).Value = DBNull.Value
        Else
            cmdPaydesc.Parameters.Add("@nextPayAmt", SqlDbType.NVarChar).Value = numNIA.Value
            cmdPaydesc.Parameters.Add("@nextDate", SqlDbType.NVarChar).Value = dpNID.Value
        End If
        Try
            con.Open()
            txn = con.BeginTransaction()
            cmdPaydesc.Transaction = txn
            cmdPaydesc.ExecuteNonQuery()
            txn.Commit()
            Return True
        Catch
            Return False
            txn.Rollback()
        Finally
            con.Close()
            txn.Dispose()
            cmdPaydesc.Dispose()

        End Try
    End Function


End Class