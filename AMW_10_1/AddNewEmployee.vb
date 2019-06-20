Imports System.Data.SqlClient

Public Class AddNewEmployee

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



#End Region
    Private Sub txtQty_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtMobile.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Not Asc(e.KeyChar) = 8) Then            
            e.Handled = True
        ElseIf txtMobile.Text.Length > 10 Then
            e.Handled = True
        End If
    End Sub

    Dim errmsg As New messager
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim cmd As New SqlCommand
        Dim con As New SqlConnection(ConstantClass.connectionString)
        cmd.Connection = con
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "addNewEmployee"

        cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = txtName.Text
        cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = txtAddress.Text
        cmd.Parameters.Add("@mobile", SqlDbType.NChar).Value = txtMobile.Text
        cmd.Parameters.Add("@docType", SqlDbType.NVarChar).Value = comboDoc.SelectedItem
        cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = txtUID.Text
        Try
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            errmsg.msggetter("SUCCESS", True)
        Catch ex As Exception
            MsgBox("Error : " + ex.Message)    
        End Try
    End Sub
End Class