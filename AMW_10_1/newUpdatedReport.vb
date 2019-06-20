Public Class newUpdatedReport

    Public Sub addItems(data As DataTable)

        Dim itemRow As New DevExpress.XtraReports.UI.XRTableRow
        For Each DataRow As DataRow In data.Rows
            Dim row As New DevExpress.XtraReports.UI.XRTableRow
            For cellNo As Integer = 0 To 7
                Dim cell As New DevExpress.XtraReports.UI.XRTableCell
                cell.Value = DataRow.Item(cellNo)
                row.Cells.Add(cell)
            Next
            detailTable.Rows.Add(row)
        Next

    End Sub

End Class