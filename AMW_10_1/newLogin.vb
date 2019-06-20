Imports System.Data.SqlClient

Public Class newLogin
#Region "look"
    Private Sub Panel2_Paint(sender As Object, e As EventArgs) Handles Panel2.Click, Label5.Click, Panel2.GotFocus, Label5.GotFocus
        txtPass.Visible = True
        txtPass.Location = New Point(14, 18)

        txtPass.Focus()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As EventArgs) Handles Panel1.Click, Label4.Click, Label4.GotFocus, Panel1.GotFocus
        txtUserName.Visible = True
        txtUserName.Location = New Point(15, 18)
        txtUserName.Focus()
    End Sub

#End Region

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim errmsg As New messager
        If loginValidation() Then
            Dim cmdcls As New cmdClass
            'Dim userID As Integer = cmdcls.returnSimpleScalerQuery("select ISNULL(id,0) as ids from EmployeeProfessionalDetails where UserName='" + txtUserName.Text + "' and Password='" + ConstantClass.SimpleCrypt(txtPass.Text) + "'")
            Dim userID As Integer = cmdcls.returnSimpleScalerQuery("select ISNULL(id,0) as ids from EmployeeProfessionalDetails where UserName='" + txtUserName.Text + "' and Password='" + txtPass.Text + "'")
            If (userID <> 0) Then
                'If txtPass.Text = pass Then
                ConstantClass.userName = txtUserName.Text
                ConstantClass.UserID = userID
                Me.Hide()
                form1.ShowDialog()
                Me.Close()
            End If
        End If
        errmsg.msggetter("Please enter correct Credentials", 0)
        errmsg.Focus()

    End Sub

    Private Function loginValidation() As Boolean
        If txtUserName.Text.ToString.Length < 5 Or txtPass.Text.Length < 3 Then
            Return False
        End If
        Return True
    End Function
    Private Sub LOGIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeEvertthing()
        checkConnection()
    End Sub

    Private Sub InitializeEvertthing()
        Dim constantcls As New ConstantClass
        constantcls.getCS()
    End Sub

    Private Sub checkConnection()
        Dim cmd As New SqlCommand
        cmd.CommandText = "select 1"
        Dim con As New SqlConnection(ConstantClass.connectionString)
        cmd.Connection = con
        Try
            con.Open()
            If Not cmd.ExecuteScalar() = 1 Then
                Throw New Exception
            End If
        Catch ex As Exception
            If MsgBox("Connection not established as " + ex.Message + " ...IF YOU DON'T KNOW WHAT IS THIS? SELECT NO AND CALL SYSTEM ADMINISTRATOR ELSE TO RE-DEFINE CONNECTION SELECT YES", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                connectionManager.ShowDialog()
            Else
                Me.Close()
            End If
        End Try
    End Sub

    Private Sub lblAbt_Click(sender As Object, e As EventArgs) Handles lblAbt.Click
        AboutBox.ShowDialog()
    End Sub

End Class