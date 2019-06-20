Public Class purchaseList

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


    Private Sub Label1_Click(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub lblmaximizeMinimize_Click(sender As Object, e As EventArgs)
        If Me.WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        ElseIf WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        End If
    End Sub
#End Region

    Private Sub purchaseList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadList()
    End Sub

    Private Sub loadList()
        Dim cmdcls As New cmdClass
        gridList.Columns.Clear()
        gridList.DataSource = cmdcls.returnDataSet("getAllpurchase", True).Tables(0)
        If gridList.RowCount > 0 Then
            If (gridList.Rows(gridList.Rows.Count - 1).Cells(1).Value = "") Then
                gridList.Rows.RemoveAt(gridList.Rows.Count - 1)
            End If
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim addEdit As New AddEditVendors
        addEdit.ShowDialog()
        addEdit.Dispose()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim print As New PrintGridView(gridList.DataSource, "ITEMS LIST")
        print.ShowDialog()
    End Sub
End Class