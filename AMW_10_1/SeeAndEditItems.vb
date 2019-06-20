Public Class SeeAndEditItems
#Region "Design"
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs) Handles panalTitle.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            'Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If
    End Sub
    Private Sub lblCross_Click(sender As Object, e As EventArgs) Handles lblCross.Click
        Me.Close()
    End Sub
    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles panalTitle.MouseMove
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub

    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs) Handles panalTitle.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            'Me.Cursor = Cursors.Default
        End If
    End Sub


  
#End Region

    Public Sub initialize(ByVal id As Integer)
        Me.id = id
        Dim cmdcls As New cmdClass
        Dim dt As New DataTable
        dt = cmdcls.getItems(id)
        txtName.Text = dt.Rows(0).Item(1)
        txtType.Text = dt.Rows(0).Item(2)
        txtQty.Text = dt.Rows(0).Item(3)
        txtCP.Value = dt.Rows(0).Item(4)
        txtSP.Value = dt.Rows(0).Item(5)
        txtHSN.Text = dt.Rows(0).Item(7)
        If Not IsDBNull(dt.Rows(0).Item(8)) Then
            txtWtPerPcs.Text = dt.Rows(0).Item(8)
        End If
        If Not IsDBNull(dt.Rows(0).Item(12)) Then
            txtDescription.Text = dt.Rows(0).Item(12)
        End If
    End Sub

    Public id As Integer
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    

    Private Sub onlyNumeric(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Not Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If ValidateInput() Then
            Dim cmdcls As New cmdClass
            If cmdcls.editItemCMD(Me) Then
                errmsg.msggetter("Item Updated successfully", True)
            Else
                errmsg.msggetter("An error has occured", False)
            End If
        End If
    End Sub

    Private errmsg As New messager
    Private Function ValidateInput() As Boolean
        If IsNothing(txtQty.Text) Then
            txtQty.Text = 0
        ElseIf txtName.Text.Length < 1 And txtName.Visible = True Then
            errmsg.msggetter("Item name not valid", False)
            Return False
        ElseIf txtName.Text.Length + txtType.Text.Length > 26 Then
            errmsg.msggetter("Item name+ type max word: 26", False)
            Return False
        ElseIf txtType.Text.Length < 1 Then
            errmsg.msggetter("Item type name not valid", False)
            Return False        
        ElseIf txtHSN.Text.Length < 1 Then
            errmsg.msggetter("HSN cann't be null", False)
            Return False
        End If
        If checkNames() Then
            Return False
        End If
        Return True
    End Function

    Private Function checkNames() As Boolean
        Dim cmd As New cmdClass
        Dim tab As New DataTable       
        tab = cmd.returnDataSet("select name from ItemTable", False).Tables(0)
        For Each i As DataRow In tab.Rows
            If (txtType.Text = i.Item(0)) Then
                errmsg.msggetter("Same item name already exists.", False)
                Return True
            End If
        Next
        Return False
        Return True
    End Function

    Private Sub txtCP_ValueChanged(sender As Object, e As EventArgs) Handles txtCP.ValueChanged

        txtSP.Value = txtCP.Value + 1
    End Sub
End Class