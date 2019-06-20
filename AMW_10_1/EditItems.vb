Public Class EditItems

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

    Private Sub EditItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadList()
    End Sub

    Private Sub loadList()
        Try
            Dim cmdcls As New cmdClass
            gridList.Columns.Clear()
            gridList.DataSource = cmdcls.returnDataSet("getAllItems", True).Tables(0)
            If (gridList.Rows(gridList.Rows.Count - 1).Cells(1).Value = "") Then
                gridList.Rows.RemoveAt(gridList.Rows.Count - 1)
            End If
        Catch ex As Exception
            MsgBox("No Items Exists")
        End Try
    End Sub

  

    Private Sub griditem_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridList.CellClick
        If e.RowIndex <> -1 Or e.RowIndex <> 0 Then
            Dim seeItems As New SeeAndEditItems
            Dim cmdcls As New cmdClass
            seeItems.initialize(cmdcls.returnSimpleScalerQuery("select id from itemtable where name='" + gridList.Rows(e.RowIndex).Cells(1).Value + "' and type='" + gridList.Rows(e.RowIndex).Cells(2).Value + "'"))
            seeItems.ShowDialog()
            seeItems.Dispose()
            loadList()
        End If
    End Sub
  


    Private Sub loadOnFocus(s As Object, e As EventArgs) Handles btnRefresh.Click
        loadList()
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        AddItems.Show()

    End Sub
    Private Sub gridList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridList.CellClick
        If Not e.RowIndex = -1 Then
            Dim seeItems As New SeeAndEditItems
            Dim cmdcls As New cmdClass
            seeItems.initialize(cmdcls.returnSimpleScalerQuery("select id from itemtable where name='" + gridList.Rows(e.RowIndex).Cells(1).Value + "' and type='" + gridList.Rows(e.RowIndex).Cells(2).Value + "'"))
        End If
    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim print As New PrintGridView(gridList.DataSource, "ITEMS LIST")
        print.ShowDialog()
    End Sub
End Class