Public Class ClientDtls

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
        EditClients.btnAdd.Visible = True
        EditClients.btnEdit.Visible = False
        EditClients.ShowDialog()
    End Sub

    Private Sub ClientDtls_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadList()
    End Sub

    Private Sub loadList()
        Dim cmdcls As New cmdClass
        gridList.Columns.Clear()
        gridList.DataSource = cmdcls.returnDataSet("viewClients", True).Tables(0)
        If (gridList.Rows(gridList.Rows.Count - 1).Cells(0).Value = "") Then
            gridList.Rows.RemoveAt(gridList.Rows.Count - 1)
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        loadList()
    End Sub

    Private Sub gridList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridList.CellClick
        If Not e.RowIndex = -1 Then
            Dim seeClients As New EditClients
            seeClients.loadForm(gridList.Rows(e.RowIndex).Cells(0).Value, gridList.Rows(e.RowIndex).Cells(2).Value)
            seeClients.btnEdit.Visible = True
            seeClients.ShowDialog()
        End If
    End Sub

    Private Sub btnPrintClient_Click(sender As Object, e As EventArgs) Handles btnPrintClient.Click
        Dim print As New PrintGridView(gridList.DataSource, "CLIENT LIST")
        print.ShowDialog()
    End Sub
End Class