Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class PrintGridView
    'Create DataGridViewPrinter type variable  
    Dim MyDataGridViewPrinter As DataGridViewPrinter

    ' Retrieve data from database and display on DataGridView. 

    Public Sub New(Data As DataTable)
        InitializeComponent()
        DataGridView1.DataSource = Data
    End Sub

    Private heading As String
    Sub New(Data As DataTable, heading As String)
        InitializeComponent()
        DataGridView1.DataSource = Data
        txtHeading.Text = heading
        Me.heading = heading
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load    
    End Sub

    'The Print button  
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If SetupThePrinting() Then
            PrintDocument1.Print()
        End If
    End Sub

    'The PrintPage action for the PrintDocument control  
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim more As Boolean = MyDataGridViewPrinter.DrawDataGridView(e.Graphics)
        If more = True Then
            e.HasMorePages = True
        End If
    End Sub

    'The PrintView button  
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If SetupThePrinting() Then
            Dim MyPrintPreviewDialog As PrintPreviewDialog = New PrintPreviewDialog()
            MyPrintPreviewDialog.Document = PrintDocument1
            MyPrintPreviewDialog.ShowDialog()
        End If
    End Sub

    Private Function SetupThePrinting() As Boolean
        Dim MyPrintDialog As PrintDialog = New PrintDialog()
        MyPrintDialog.AllowCurrentPage = True
        MyPrintDialog.AllowPrintToFile = True
        MyPrintDialog.AllowSelection = True
        MyPrintDialog.AllowSomePages = True
        MyPrintDialog.PrintToFile = True
        MyPrintDialog.ShowHelp = True
        MyPrintDialog.ShowNetwork = True

        If MyPrintDialog.ShowDialog() <> DialogResult.OK Then
            Return False
        End If

        PrintDocument1.DocumentName = "Report"
        PrintDocument1.PrinterSettings = MyPrintDialog.PrinterSettings
        PrintDocument1.DefaultPageSettings = MyPrintDialog.PrinterSettings.DefaultPageSettings
        PrintDocument1.DefaultPageSettings.Margins = New Margins(40, 40, 40, 40)

        If MessageBox.Show("Do you want the report to be centered on the page or left align", "InvoiceManager - Center on Page", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            MyDataGridViewPrinter = New DataGridViewPrinter(DataGridView1, PrintDocument1, True, True, heading, New Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, True, "Anita metal works")
        Else
            MyDataGridViewPrinter = New DataGridViewPrinter(DataGridView1, PrintDocument1, False, True, heading, New Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point), Color.Black, True, "Anita metal works")
        End If

        Return True
    End Function

    Private Sub txtHeading_TextChanged(sender As Object, e As EventArgs) Handles txtHeading.TextChanged
        heading = txtHeading.Text
    End Sub
End Class


