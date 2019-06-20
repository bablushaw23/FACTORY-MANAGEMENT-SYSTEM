Public Class AddEditVendors

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


    Private Sub txtGSTIN_TextChanged(sender As Object, e As EventArgs) Handles txtGSTIN.TextChanged, txtAdd.TextChanged

    End Sub

    Private Sub onlyNumeric(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMobile.KeyPress, txtPhone.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Not Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub AddEditVendors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cmd As New cmdClass
        Dim table As New DataTable
        table = cmd.returnDataSet("select GSTIN from PurchaseClientlDtlsTable", False).Tables(0)
        comboGSTIN.Items.Clear()
        For Each row As DataRow In table.Rows
            comboGSTIN.Items.Add(row.Item(0))
        Next
        If comboGSTIN.Items.Count > 0 Then
            comboGSTIN.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim cmd As New cmdClass
        Dim dt As DataTable = cmd.returnDataSet("select * from PurchaseClientlDtlsTable where uin=" + comboGSTIN.SelectedItem, False).Tables(0)
        txtAdd.Text = dt.Rows(0).Item(2)
        txtEMail.Text = dt.Rows(0).Item(3)
        txtGSTIN.Text = dt.Rows(0).Item(7)
        txtMobile.Text = dt.Rows(0).Item(5)
        txtName.Text = dt.Rows(0).Item(1)
        txtPhone.Text = dt.Rows(0).Item(4)
        btnAdd.Visible = False
        btnStartAdd.Visible = False
        btnStartEdit.Visible = True
        Label1.Visible = False
        Me.Size = New System.Drawing.Size(Me.Size.Width, 378)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        btnAdd.Visible = True
        Label1.Visible = True
        btnEdit.Visible = True
        comboGSTIN.Visible=True
        Me.Size = New System.Drawing.Size(Me.Size.Width, 122)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        btnEdit.Visible = False
        btnStartEdit.Visible = False
        Label1.Visible = False
        comboGSTIN.Visible = False
        Me.Size = New System.Drawing.Size(Me.Size.Width, 378)
    End Sub

    Private Sub btnStartAdd_Click(sender As Object, e As EventArgs) Handles btnStartAdd.Click
        Dim cmd As New cmdClass
        Try
            cmd.returnSimpleScalerQuery("insert into PurchaseClientlDtlsTable(name,MailingAddress,EMail,Phone,Mobile,GSTIN,AddedBy) values('" + txtName.Text + "','" + txtAdd.Text + "','" + txtEMail.Text + "','" + txtPhone.Text + "','" + txtMobile.Text + "','" + txtGSTIN.Text + "'," + ConstantClass.UserID.ToString + ")")
            MsgBox("Successfully Added")
            Me.Close()
        Catch ex As Exception
            MsgBox("!Failed as :" + ex.Message)
        End Try
    End Sub

    Private Sub btnStartEdit_Click(sender As Object, e As EventArgs) Handles btnStartEdit.Click
        MsgBox("Not yet completed")
        Me.Close()
    End Sub
End Class