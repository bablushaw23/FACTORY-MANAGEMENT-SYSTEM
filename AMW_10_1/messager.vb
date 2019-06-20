Public Class messager
    Public Sub msggetter(ByVal msg As String, ByVal Sccs As Boolean)
        Try
            If Sccs Then
                lblHead.Text = "SUCCESS"
            End If

            lblmsg.Text = msg
            Me.ShowDialog()
            Timer1.Enabled = True
            If Timer1.Enabled = False Then
                Me.Hide()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If lblmsg.Visible Then
            lblmsg.Visible = False
        Else
            lblmsg.Visible = True
        End If
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click, Button2.Click
        Timer1.Enabled = False
        'msggetter("")
        Me.Hide()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
    Private Sub Label20_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub panalTitle_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    Private Sub lblCross_Click(sender As Object, e As EventArgs)
        Timer1.Enabled = False
        Me.Close()
    End Sub
End Class