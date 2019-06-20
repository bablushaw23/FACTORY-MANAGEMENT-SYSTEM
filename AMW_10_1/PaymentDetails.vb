Public Class PaymentDetails
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
    Private Sub PaymentDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadLists()
    End Sub

    Private Sub loadLists()
        Dim cmd As New cmdClass
        gridList.DataSource = cmd.returnDataSet("duePayList", True).Tables(0)
        gridCleared.DataSource = cmd.returnDataSet("clearedPayList", True).Tables(0)
    End Sub


    Private Sub gridList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridList.CellClick
        If e.RowIndex <> -1 Then
            Dim obj As New PaymentDescription
            obj.initialize(gridList(7, e.RowIndex).Value, gridList(9, e.RowIndex).Value, gridList(0, e.RowIndex).Value, False)
            obj.ShowDialog()
            obj.Dispose()
            loadLists()
        End If
    End Sub

    Private Sub gridCleared_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridCleared.CellClick
        If e.RowIndex <> -1 Then
            Dim obj As New PaymentDescription
            obj.initialize(Today.Date, 0, gridCleared(0, e.RowIndex).Value, True)
            obj.ShowDialog()
            obj.Dispose()
            loadLists()
        End If
    End Sub

   
    
    Private Sub DELETEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DELETEToolStripMenuItem.Click
        Dim billRef As String
        If selectedGrid = 1 Then
            billRef = gridList.Rows(selectedRowIndex).Cells(0).Value
        Else
            billRef = gridCleared.Rows(selectedRowIndex).Cells(0).Value
        End If
        Dim cmd As New cmdClass
        Try
            cmd.returnSimpleScalerQuery("exec PROC_deleteExistingInvoioceOrChallan '" + billRef + "'")
        Catch ex As Exception
            errmsg.msggetter("Permission denied", False)
            Return
        End Try
        errmsg.msggetter("Task completed", True)
    End Sub

    Dim errmsg As New messager
    Private selectedGrid, selectedRowIndex As Int16

    Private Sub gridList_CellContentClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gridList.CellMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            selectedGrid = 1
            selectedRowIndex = e.RowIndex
            gridList.Rows(selectedRowIndex).Selected = True
            gridContext.Show(Cursor.Position)
        End If
    End Sub

    Private Sub gridCleared_CellContentClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles gridCleared.CellMouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            selectedGrid = 2
            selectedRowIndex = e.RowIndex
            gridCleared.Rows(selectedRowIndex).Selected = True
            gridContext.Show(Cursor.Position)
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim print As New PrintGridView(gridList.DataSource, "DUE PAYMENT")
        print.ShowDialog()
    End Sub

    Private Sub btnCleared_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim print As New PrintGridView(gridCleared.DataSource, "Cleared PAYMENT")
        print.ShowDialog()
    End Sub
End Class