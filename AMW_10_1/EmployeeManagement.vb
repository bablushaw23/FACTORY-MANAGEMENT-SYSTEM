Public Class EmployeeManagement
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


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim form As New AddNewEmployee
        form.ShowDialog()
        form.Dispose()
    End Sub

    Private Sub EmployeeManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New cmdClass
        Try
            gridList.DataSource = cmd.returnDataSet("select Name,Mobile,Address,UIN,DocType from EmployeePersonalTable", False).Tables(0)
        Catch
        End Try
    End Sub

    Private Sub btnPrintClient_Click(sender As Object, e As EventArgs) Handles btnPrintClient.Click
        Dim print As New PrintGridView(gridList.DataSource, "EMPLOYEE LIST")
        print.ShowDialog()
    End Sub
End Class