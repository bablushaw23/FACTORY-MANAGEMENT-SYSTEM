Imports System.Data.SqlClient

Public Class VacationForm

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAppove.Click
        Dim conn As New SqlConnection(ConstantClass.connectionString)
        Dim cmd As New SqlCommand("addvacation", conn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@startDate", SqlDbType.Date).Value = dateFrom.Value
        cmd.Parameters.Add("@endDate", SqlDbType.Date).Value = dateTo.Value
        cmd.Parameters.Add("@reason", SqlDbType.NVarChar).Value = txtReason.Text
        Dim result As Integer = MessageBox.Show("YOU ARE ASSIGNING A " + (Integer.Parse((dateTo.Value.Subtract(dateFrom.Value)).ToString.Substring(0, 1)) + 1).ToString + " Days LEAVE. RIGHT ?", "Confirm", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            conn.Open()
            cmd.ExecuteNonQuery()
            conn.Close()
            MsgBox("APPROVED SUCCESSFULLY....HAVE FUN")
            Me.Close()
        End If
    End Sub

    Private Sub dateFrom_ValueChanged(sender As Object, e As EventArgs) Handles dateFrom.ValueChanged
        dateTo.MinDate = dateFrom.Value
    End Sub

    Private Sub dateTo_ValueChanged(sender As Object, e As EventArgs) Handles dateTo.ValueChanged
        dateFrom.MaxDate = dateTo.Value
    End Sub
End Class