Imports System.Data.SqlClient

Public Class PaymentDescription

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


    Public Sub initialize(nextDate As Date, nextAmt As Double, invRef As String, disableAddPayment As Boolean)
        If disableAddPayment Then
            btnAddNewPayment.Visible = False
            panelNextDtl.Visible = False
            panelDue.Visible = False        
        else
            lblNextAmt.Text = nextAmt
            lblNxtDate.Text = nextDate
        End If
        invNo = invRef
        refreshGrid()
    End Sub

    Private Property invNo As String
    Private Property payID As Integer
    Private Sub refreshGrid()
        Dim cmd As New SqlCommand
        cmd.CommandText = "viewPayDtls"
        cmd.CommandType = CommandType.StoredProcedure        
        cmd.Parameters.Add("@invNO", SqlDbType.NVarChar).Value = invNo
        cmd.Connection = New SqlConnection(ConstantClass.connectionString)
        Dim da As New SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)

        gridPayDesc.DataSource = ds.Tables(0)
        lblAddress.Text = ds.Tables(1).Rows(0).Item(2)
        lblAmt.Text = ds.Tables(1).Rows(0).Item(4)
        lblClientName.Text = ds.Tables(1).Rows(0).Item(0)
        lblMobile.Text = ds.Tables(1).Rows(0).Item(1)
        lblPhone.Text = ds.Tables(1).Rows(0).Item(3)
        payID = ds.Tables(2).Rows(0).Item(0)
        setDue()
        da.Dispose()
        ds.Dispose()



    End Sub

    Private Sub PaymentDescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblInvNo.Text = invNo
        refreshGrid()
    End Sub

    Private Sub setDue()
        Dim sum As Double = 0
        For i As Integer = 0 To gridPayDesc.Rows.Count - 1
            sum += Double.Parse(gridPayDesc(1, i).Value)
        Next i
        Dim due As Double = Math.Round(Double.Parse(lblAmt.Text) - sum, 2)
        If due < 0 Then
            due = 0
        End If
        lbldDue.Text = due
        If lbldDue.Text = 0 Then
            btnAddNewPayment.Visible = False
        End If
    End Sub

    Private Sub lnkLblShowInvoice_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkLblShowInvoice.LinkClicked
        Try
            Process.Start(ConstantClass.getPDFLocation(invNo))
        Catch ex As Exception
            MsgBox("Invoice not found at desired location. Maybe it is deleted")
        End Try
    End Sub

    Private Sub btnAddNewPayment_Click(sender As Object, e As EventArgs) Handles btnAddNewPayment.Click
        Dim addNewPayment As New AddNewPayment
        addNewPayment.initializer(invNo, payID, lbldDue.Text, lblAmt.Text)
        addNewPayment.ShowDialog()
        refreshGrid()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim print As New PrintGridView(gridPayDesc.DataSource, "Payments of Invoice ID:" + invNo)
        print.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEditBill.Click
        Dim result As Integer = MessageBox.Show("YOU ARE GOING TO TRUNCATE RECORDS OF INVOICE. THIS CANNOT BE UNDONE." & vbNewLine & "ARE YOU SURE ?", "CONFIRM", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            Dim connection As New SqlConnection(ConstantClass.connectionString)            
            Dim cmd As New SqlCommand

            cmd.Connection = connection
            Dim invRef = lblInvNo.Text.ToString
            cmd.CommandText = "PROC_deleteExistingInvoioceOrChallan"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@BillRef", invRef)

            Try
                connection.Open()
                cmd.ExecuteNonQuery()
                connection.Close()
                Dim invoice As New newinvoice2
                invoice.replaceBillNo(invRef)
                invoice.ShowDialog()
            Catch ex As Exception
                MsgBox("An error has occured :" + ex.Message)
            Finally               
                connection.Dispose()
                cmd.Dispose()
            End Try
        End If
    End Sub
    ' ''/*
    ' ''    Private Function EditSequence(oldSeqNo As Integer) As Integer
    ' ''        Dim con As New SqlConnection(ConstantClass.connectionString)
    ' ''        Dim cmd As New SqlCommand()
    ' ''        cmd.Connection = con        
    ' ''        Dim newSeq As Integer
    ' ''        Try
    ' ''            con.Open()
    ' ''            cmd.CommandText = "select next value for invoiceSequence"
    ' ''            newSeq = cmd.ExecuteScalar()
    ' ''            cmd.CommandText = ("alter sequence invoiceSequence restart with " + oldSeqNo.ToString)
    ' ''            cmd.ExecuteNonQuery()
    ' ''        Catch ex As Exception
    ' ''            MsgBox(ex.Message)
    ' ''        Finally
    ' ''            con.Close()
    ' ''            cmd.Dispose()
    ' ''            con.Dispose()
    ' ''        End Try
    ' ''        Return newSeq
    ' ''    End Function

    ' ''    Private Sub resetSeq(seqNow As Integer)
    ' ''        Dim conn As New SqlConnection(ConstantClass.connectionString)
    ' ''        Dim cmd As New SqlCommand("alter sequence invoiceSequence restart with " + seqNow.ToString, conn)
    ' ''        Try
    ' ''            conn.Open()
    ' ''            cmd.ExecuteNonQuery()
    ' ''        Catch ex As Exception
    ' ''            MsgBox(ex.Message)
    ' ''        Finally
    ' ''            conn.Close()
    ' ''            cmd.Dispose()
    ' ''        End Try
    ' ''    End Sub

End Class