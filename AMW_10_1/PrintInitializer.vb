Imports DevExpress.XtraReports.UI

Public Class PrintInitializer
    Public Sub printInvoice(ClienName As String, destin As String, invNo As String, isueDate As Date, duDate As Date, payMode As String, pan As String, gstNo As String, address As String,
                       delnote As String, regard As String, stateCodde As String, plcOfSply As String, itemTable As DataTable, dclaration As String, printNo As Integer, aamt As Decimal)
        Dim report As New invoiceReport
        report.initData(ClienName, destin, invNo, isueDate, duDate, payMode, pan, gstNo, address, delnote, regard, stateCodde, plcOfSply, itemTable, dclaration, printNo, aamt)

        'Dim updatedReport As New newUpdatedReport
        'updatedReport.addItems(itemTable)
        'updatedReport.PaperKind = Printing.PaperKind.A4
        'Dim tempTool As New ReportPrintTool(updatedReport)
        'tempTool.Print()

        report.RequestParameters = False
        report.PaperKind = Printing.PaperKind.A4

        Dim tool As New ReportPrintTool(report)
        If printNo < 3 Then
            tool.ShowPreview()
        Else
            report.ExportToPdf(ConstantClass.getPDFLocation(invNo))
        End If
    End Sub
End Class
