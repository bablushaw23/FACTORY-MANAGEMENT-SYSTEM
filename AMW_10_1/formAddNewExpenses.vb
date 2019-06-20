Public Class formAddNewExpenses

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
    Private Sub formAddNewExpenses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpDate.MaxDate = Today.Date
        dtpDate.Value = Today.Date
        txtAmt.Minimum = 0
    End Sub

    Private errmsg As New messager

    Private Function validator() As Boolean
        If txtDesc.Text.Length < 2 Then
            errmsg.msggetter("Description not valid", False)
            Return False
        End If
        If txtAmt.Value < 1 Then
            errmsg.msggetter("Not valid amount", False)
            Return False
        End If
        Return True
    End Function


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If validator() Then
            Dim cmd As New cmdClass
            If cmd.addNewExpenses(Me) Then
                errmsg.msggetter("SUCCESSFULLY ADDED!", True)
            Else
                errmsg.msggetter("SOME ERROR OCCURED", False)
            End If
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtAmt.Value = 0
        txtDesc.Text = ""
        dtpDate.Value = Today.Date
    End Sub
End Class