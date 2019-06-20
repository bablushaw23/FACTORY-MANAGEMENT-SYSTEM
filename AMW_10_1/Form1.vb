Public Class form1
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

    Private Sub btnBkp_Click(sender As Object, e As EventArgs) Handles btnBkpRcvr.Click
        MsgBox("Not Implemented Yet")
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles btnCalculator.Click
        System.Diagnostics.Process.Start("calc")
    End Sub

    Private Sub purchaseDemand(sender As Object, e As EventArgs) Handles btnPurchase.Click
        Dim addNewPurchase As New AddPurchaseBill
        addNewPurchase.ShowDialog()
        addNewPurchase.Dispose()
    End Sub

    Private Sub expensesList(sender As Object, e As EventArgs) Handles btnExpenses.Click
        Dim form As New formExpenses
        form.ShowDialog()
    End Sub
    Private Sub purchaseList(sender As Object, e As EventArgs) Handles btnPurchaseList.Click
        Dim purchase As New purchaseList
        purchase.ShowDialog()
        purchase.Dispose()
    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles btnNotes.Click
        Dim locasun As String = "myFile" + ConstantClass.UserID.ToString() + ".txt"
        Process.Start("notepad.exe", locasun)
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


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnStock.Click, picStock.Click
        EditItems.Show()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click, picAbout.Click
        AboutBox.ShowDialog()
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click, picPayment.Click
        Dim payDtls As New PaymentDetails
        payDtls.ShowDialog()
        payDtls.Dispose()
    End Sub

    Private Sub addNewClient(s As Object, e As EventArgs) Handles btnClient.Click, picClient.Click
        ClientDtls.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles btnSettings.Click, picSettings.Click
        changeUserPass.ShowDialog()
    End Sub

    
    Private Sub btnNewInvoice_Click(sender As Object, e As EventArgs) Handles btnNewInvoice.Click, picNewInvoice.Click
        newinvoice2.Show()
    End Sub

    Private Sub btnNewChallan_Click(sender As Object, e As EventArgs) Handles btnNewChallan.Click, ppicNewChallan.Click
        'newChallan.Show()
        MsgBox("THIS FEATURE IS NOT ALLOWED TO USE")
    End Sub

    Private Sub btnTools_Click(sender As Object, e As EventArgs) Handles btnTools.Click, picTools.Click
        If panelNotes.Visible Or panelCalc.Visible Or panelBckpRcv.Visible Then
            panelCalc.Visible = False
            panelNotes.Visible = False
            panelBckpRcv.Visible = False
        Else
            panelCalc.Visible = True
            panelBckpRcv.Visible = True
            panelNotes.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAttendence.Click
        If panelAttendence.Visible = False Then
            panelAttendence.Visible = True
        Else
            panelAttendence.Visible = False
        End If
    End Sub

    Private Sub addAttendence_Click(sender As Object, e As EventArgs) Handles addAttendence.Click
        Dim form As New Attendence2
        form.ShowDialog()
        form.Dispose()
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Dim sheetForm As New attendenceSheet
        sheetForm.ShowDialog()
        sheetForm.Dispose()
    End Sub

    Private Sub btnEmpManagement_Click(sender As Object, e As EventArgs) Handles btnEmpManagement.Click
        Dim form As New EmployeeManagement
        form.ShowDialog()
        form.Dispose()
    End Sub

End Class
