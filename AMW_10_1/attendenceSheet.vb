Imports System.Data.SqlClient

Public Class attendenceSheet

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


    Private Sub btnLoginOut_Click(sender As Object, e As EventArgs) Handles btnLoginOut.Click
        Dim CMD As New cmdClass
        Dim command As New SqlCommand
        command.Parameters.Add("@fromDate", SqlDbType.Date).Value = dtpFromDate.Value
        command.Parameters.Add("@toDate", SqlDbType.Date).Value = dtpToDate.Value
        command.CommandText = "getAttendenceList"
        command.CommandType = CommandType.StoredProcedure
        gridList.DataSource = CMD.returnDataSet(command).Tables(0)
        If (gridList.Rows(gridList.Rows.Count - 1).Cells(1).Value = "") Then
            gridList.Rows.RemoveAt(gridList.Rows.Count - 1)
        End If
    End Sub
    Private Sub btnPrintClient_Click(sender As Object, e As EventArgs) Handles btnPrintClient.Click
        Dim print As New PrintGridView(gridList.DataSource, "ATTENDENCE SHEET")
        print.ShowDialog()
    End Sub
End Class