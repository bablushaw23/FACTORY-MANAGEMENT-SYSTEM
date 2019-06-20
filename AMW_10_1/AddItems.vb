Public Class AddItems

    Private Sub btnItem_Click(sender As Object, e As EventArgs) Handles btnItem.Click
        callAddNewItem(True)
    End Sub

    Private Sub callAddNewItem(itemOrType As Boolean)
        Dim item As New addNewItem
        item.initialize(itemOrType)
        Me.Hide()
        item.ShowDialog()
        item.Dispose()
    End Sub

    Private Sub lblCross_Click(sender As Object, e As EventArgs) Handles lblCross.Click
        Me.Close()

    End Sub

    Private Sub btnType_Click(sender As Object, e As EventArgs) Handles btnType.Click
        callAddNewItem(False)
    End Sub
End Class