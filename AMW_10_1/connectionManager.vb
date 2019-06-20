Imports System.Data.SqlClient

Public Class connectionManager

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If validator() Then
            Dim connectionString As String = "Data Source=" + txtSrs.Text + ";Initial Catalog=" + txtCatalog.Text + ";Integrated Security=" + ComboSecurity.SelectedItem
            If testConnection(connectionString) Then
                createXML(connectionString)
                MsgBox("Done! connection properly Established..Restarting..")
                Me.Close()
            Else
                errmsg.msggetter("Connection not defined..Try again", 0)
            End If
        End If
    End Sub
    Private errmsg As New messager
    Private Sub createXML(concStr As String)
        Dim xm As New xmlManager
        xm.createXML(concStr)
    End Sub
    Public Shared Function testConnection(connection As String) As Boolean
        Dim result As Boolean
        Dim cmd As New SqlCommand
        cmd.CommandText = "select 1"
        Dim con As New SqlConnection(connection)
        cmd.Connection = con
        Try
            con.Open()
            If Not cmd.ExecuteScalar() = 1 Then
                result = False
                Throw New Exception
            End If
            result = True
        Catch ex As Exception
            MsgBox("Connection not established as " + ex.Message)
        Finally
            con.Close()
        End Try
        Return result
    End Function

    Private Function validator() As Boolean
        If txtCatalog.Text.Trim().Length < 1 Then
            errmsg.msggetter("Catalog value too short", 0)
            Return False
        ElseIf txtSrs.Text.Trim().Length < 2 Then
            errmsg.msggetter("Data-source value too short", 0)
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class

