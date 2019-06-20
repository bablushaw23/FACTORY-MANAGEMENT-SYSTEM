Imports System.Data.SqlClient

Public Class LOGIN
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim errmsg As New messager
        If loginValidation() Then
            Dim cmdcls As New cmdClass
            Dim pass As String = cmdcls.returnSimpleScalerQuery("select top 1 password from EmployeeProfessionalDetails where UserName='" + txtUserName.Text + "'")
            'If (txtPass.Text = ConstantClass.SimpleCrypt(pass)) Then
            If txtPass.Text = pass Then
                ConstantClass.userName = txtUserName.Text
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

    Private Sub btnForgot_Click(sender As Object, e As EventArgs) Handles btnForgot.Click

        MsgBox("Tell Admin to reset password...")
    End Sub

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



    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.Click, lblUserName.Click
        If txtUserName.ReadOnly = True Then
            txtUserName.ReadOnly = False
            If lblUserName.Location.X > 55 Then
                While lblUserName.Location.X > 51
                    Threading.Thread.Sleep(10)
                    lblUserName.Location = New Point(lblUserName.Location.X - 10, 297)
                End While
            End If
        End If
        If txtPass.ReadOnly = True Then
            lblPass_clicked(sender, e)
        End If
    End Sub

    Private Sub lblPass_clicked(sender As Object, e As EventArgs) Handles txtPass.Click, lblPass.Click
        If txtPass.ReadOnly = True Then
            txtPass.ReadOnly = False
            If lblPass.Location.X > 55 Then
                While lblPass.Location.X > 51
                    Threading.Thread.Sleep(10)
                    lblPass.Location = New Point(lblPass.Location.X - 10, 348)
                End While
            End If
        End If
        If txtUserName.ReadOnly = True Then
            txtUserName_TextChanged(sender, e)            
        End If
    End Sub

    Private Sub lblCross_Click(sender As Object, e As EventArgs) Handles lblCross.Click
        Me.Close()
    End Sub

    


    Private Sub lblAbt_Click(sender As Object, e As EventArgs) Handles lblAbt.Click
        AboutBox.ShowDialog()
    End Sub

   
End Class
