Imports System.Data.SqlClient

Public Class addNewItem

    Public Sub initialize(itemOrType As Boolean)
        If (itemOrType) Then
            txtName.Visible = True
        Else
            Dim cmd As New cmdClass
            Dim data As DataTable = cmd.returnDataSet("select name from ItemTable", False).Tables(0)
            comboItem.Items.Clear()
            For Each i As DataRow In data.Rows
                comboItem.Items.Add(i.Item(0))
            Next
            comboItem.Visible = True
        End If

    End Sub

    Private Sub comboItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboItem.SelectedIndexChanged
        Dim cmdCls As New cmdClass
        txtType.AutoCompleteCustomSource = cmdCls.returnAutocomplete("select type from Itemtable where name='" + comboItem.SelectedText + "'", False)
    End Sub


    Private Sub onlyNumeric(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        If (Not IsNumeric(e.KeyChar)) And (Not Asc(e.KeyChar) = 8) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If ValidateInput() Then
            Dim cmdcls As New cmdClass
            If cmdcls.addNewitemCMD(Me) Then
                errmsg.msggetter("Item saved successfully", True)
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
        If comboItem.Visible = True Then
            tab = cmd.returnDataSet("select type from ItemTable where name='" + comboItem.SelectedText + "'", False).Tables(0)
            For Each i As DataRow In tab.Rows
                If (txtType.Text = i.Item(0)) Then
                    errmsg.msggetter("Same type name already exists.", False)
                    Return True
                End If
            Next
            Return False
        ElseIf txtName.Visible = True Then
            tab = cmd.returnDataSet("select name from ItemTable", False).Tables(0)
            For Each i As DataRow In tab.Rows
                If (txtType.Text = i.Item(0)) Then
                    errmsg.msggetter("Same item name already exists.", False)
                    Return True
                End If
            Next
            Return False
        End If
        Return True
    End Function

    Private Sub txtCP_ValueChanged(sender As Object, e As EventArgs) Handles txtCP.ValueChanged
        txtSP.Minimum = txtCP.Value
        txtSP.Value = txtCP.Value + 1
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtName.Text = ""
        txtType.Text = ""
        txtHSN.Text = ""
        txtQty.Text = 0
        txtDescription.Text = ""
        txtCP.Value = 0
        txtWtPerPc.Text = ""
    End Sub


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

    
End Class