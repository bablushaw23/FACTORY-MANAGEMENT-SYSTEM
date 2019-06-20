Imports System.Data.SqlClient
Public Class changeUserPass

    Private Sub buttonReset_Click(sender As Object, e As EventArgs) Handles btnResetSeq.Click
        Try
            Dim cmdcls As New cmdClass
            Dim query = "update additionalInfo set prefix='" + txtPrefix.Text + "', suffix='" + txtSuffix.Text + "', billCounter=" + nmCounter.Value.ToString()
            cmdcls.returnSimpleScalerQuery(query)
            errmsg.msggetter("DONE!", True)
        Catch ex As Exception
            MsgBox("An error has occured: " + ex.Message)
        End Try        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtConfPass.Text = txtNewPass.Text And txtNewPass.Text.Length > 3 Then
            If changePass(ConstantClass.userName, txtNewPass.Text) Then
                errmsg.msggetter("successfully changed", True)
            End If
        Else
            errmsg.msggetter("confirm password not same or username or password too short", False)
        End If
    End Sub
    Private Property errmsg As New messager
    Public Function changePass(oldUserName As String, newPass As String) As Boolean
        Try
            Dim cmd As New SqlCommand
            Dim con As New SqlConnection(ConstantClass.connectionString)
            cmd.Connection = con
            cmd.CommandText = "changeUserPass"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@newPass", SqlDbType.NVarChar).Value = ConstantClass.SimpleCrypt(newPass)
            cmd.Parameters.Add("@oldUser", SqlDbType.NVarChar).Value = oldUserName
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            con.Dispose()
            Return True
        Catch ex As Exception
            errmsg.msggetter("An error has occured", False)
            Return False
        End Try
    End Function


    Private Sub changeUserPass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmdcls As New cmdClass
        Dim query = "select prefix, billCounter, suffix from additionalInfo"
        Dim res As DataRow = cmdcls.returnDataSet(query, False).Tables(0).Rows(0)

        txtPrefix.Text = res.Item(0)
        nmCounter.Value = Integer.Parse(res.Item(1))
        txtSuffix.Text = res.Item(2)

    End Sub
End Class