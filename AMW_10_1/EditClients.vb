Imports System.Data.SqlClient
Public Class EditClients

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
    Private Sub onlyNumeric(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhone.KeyPress, txtMob.KeyPress, txtFAX.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Not Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub AddNewClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Dim previousName, previousMob As String

    Public Sub loadForm(ByVal name As String, mobile As String)
        Dim cmdcls As New cmdClass
        Dim dRow As DataRow
        dRow = cmdcls.returnDataSet("select isnull(MailingAddress,'Not available'),isnull(ShippingAddress,'Not available'),isnull(EMail,'Not available'),isnull(Phone,'Not available'),isnull(Fax,'Not available'),isnull(UIN,'Not available'),isnull(PAN_IT,'Not available'),Description from ClientlDtlsTable where name='" + name + "' and Mobile='" + mobile + "'", False).Tables(0).Rows(0)
        txtName.Text = name.ToString
        txtMail.Text = dRow.Item(0).ToString
        txtShipping.Text = dRow.Item(1).ToString
        txtEmail.Text = dRow.Item(2).ToString
        txtPhone.Text = dRow.Item(3).ToString
        txtMob.Text = mobile

        previousMob = mobile
        previousName = name

        txtFAX.Text = dRow.Item(4).ToString
        txtUIN.Text = dRow.Item(5).ToString
        txtPAN.Text = dRow.Item(6).ToString
        txtDescription.Text = dRow.Item(7).ToString
    End Sub
    Dim errmsg As New messager

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim cmd As New SqlClient.SqlCommand()
        cmd.CommandText = "update ClientlDtlsTable set name='" + txtName.Text + "', MailingAddress='" + txtMail.Text + "',ShippingAddress='" + txtShipping.Text + "',EMail='" + txtEmail.Text + "', phone='" + txtPhone.Text + "',Mobile='" + txtMob.Text + "',Fax='" + txtFAX.Text + "',UIN='" + txtUIN.Text + "', PAN_IT='" + txtPAN.Text + "',Description='" + txtDescription.Text + "' where (name='" + previousName + "' and mobile='" + previousMob + "')"
        Dim connection As New SqlClient.SqlConnection(ConstantClass.connectionString)
        cmd.Connection = connection
        Try
            connection.Open()
            cmd.ExecuteNonQuery()
            connection.Close()
            errmsg.msggetter("Successfully Updated", True)
        Catch ex As Exception
            errmsg.msggetter("An error has occured", False)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub manageVisiblityOfBtnEdit(sender As Object, e As EventArgs) Handles btnEdit.VisibleChanged
        If btnEdit.Visible = True Then
            btnAdd.Visible = False
        Else
            btnAdd.Visible = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim cmdClas As New cmdClass        
        If Not cmdClas.returnSimpleScalerQuery("select isnull(id,0) from ClientlDtlsTable where Name='" + txtName.Text + "'  and mobile='" + txtMob.Text + "'") = 0 Then
            errmsg.msggetter("Same name with same mobile already exists", False)
        Else
            cmdClas.addNewCustomer(Me)
            errmsg.msggetter("Client successfully added!", True)
        End If
    End Sub
End Class