Imports System.Data.SqlClient

Public Class AddAttendence
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



#End Region

    Private Sub AddAttendence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblTodayDate.Text = Today.Date
        Dim setEmpName As New cmdClass
        Dim coll As AutoCompleteStringCollection = setEmpName.returnAutocomplete("select Name from EmployeePersonalTable", False)
        comboEmpName.Items.Clear()
        For Each item In coll
            comboEmpName.Items.Add(item)
        Next
        checkForVacation()
    End Sub

    Private Sub comboEmpName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboEmpName.SelectedIndexChanged
        btnLoginOut.Visible = True
        timePicker.ReadOnly = False
        timerWork.Enabled = False
        lblTimer.Text = "00:00:00"
        If comboEmpName.SelectedItem.Length > 0 Then
            Dim connection As New SqlConnection(ConstantClass.connectionString)
            Dim cmd As New SqlCommand("ReportAttendence", connection)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("@empName", comboEmpName.SelectedItem.ToString)
            Dim dataAdapter As New SqlDataAdapter(cmd)
            Dim reportSet As New DataSet
            dataAdapter.Fill(reportSet)
            Dim report = reportSet.Tables(0)
            If report.Rows.Count > 0 Then
                If report.Rows(0).Item(1).ToString = "00:00:00" Then
                    GlobalinTime = report.Rows(0).Item(0)
                    timePicker.Time = Format(Now, "HH:mm:ss tt")
                    timerWork.Enabled = True
                    labelInOut.Text = "SET END TIME"
                    btnLoginOut.Text = "END"
                    inOutFlag = 1
                Else
                    labelInOut.Text = "START TIME WAS"
                    timePicker.ReadOnly = True
                    GlobalinTime = report.Rows(0).Item(0)
                    Dim outTime As TimeSpan = report.Rows(0).Item(1)
                    Dim tD As DateTime = Today.Date
                    timePicker.Time = tD + GlobalinTime
                    inOutFlag = 2
                    lblTimer.Text = (outTime - GlobalinTime).ToString
                    btnLoginOut.Visible = False
                End If
            Else
                btnLoginOut.Visible = True
                inOutFlag = 0                
                btnLoginOut.Text = "START"
                labelInOut.Text = "START TIME"
                timePicker.Time = Format(Now, "HH:mm:ss tt")
            End If
        End If
    End Sub

    Private Property inOutFlag As Integer       '0 : Not IN, 1: In But not out, 2: Out
    Private Property GlobalinTime As TimeSpan
    Private Property isHoliday As Integer = 0       '0: not, 1: yes
    Private Sub timerWork_Tick(sender As Object, e As EventArgs) Handles timerWork.Tick
        lblTimer.Text = (TimeSpan.Parse(Format(Now, "HH:mm:ss")) - GlobalinTime).ToString
    End Sub

    Private Sub btnLoginOut_Click(sender As Object, e As EventArgs) Handles btnLoginOut.Click
        Dim connection As New SqlConnection(ConstantClass.connectionString)
        Dim cmd As New SqlCommand("AddAttendence", connection)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@empName", SqlDbType.NVarChar).Value = comboEmpName.SelectedItem
        cmd.Parameters.Add("@date", SqlDbType.Date).Value = Today
        cmd.Parameters.Add("@time", SqlDbType.Time).Value = Format(timePicker.Time, "HH:mm:ss")
        cmd.Parameters.Add("@attendBy", SqlDbType.Int).Value = ConstantClass.UserID
        connection.Open()
        cmd.ExecuteNonQuery()
        connection.Close()
        If inOutFlag = 0 Then
            GlobalinTime = TimeSpan.Parse(Format(timePicker.Time, "HH:mm:ss"))
            btnLoginOut.Text = "END"
            labelInOut.Text = "SET END TIME"
            inOutFlag = 1
            timerWork.Enabled = True
        Else
            btnLoginOut.Visible = False
            inOutFlag = 2
            timerWork.Enabled = False
        End If
    End Sub

    Private Sub btnVacation_Click(sender As Object, e As EventArgs) Handles btnVacation.Click
        If isHoliday Then
            MsgBox("You are already in vacation..If time really over, then you should restart this form again")            
        Else
            Dim form As New VacationForm
            form.ShowDialog()
            form.Dispose()
        End If
    End Sub

    Private Sub checkForVacation()
        Dim cmd As New cmdClass
        If Today.DayOfWeek = DayOfWeek.Sunday Or cmd.returnSimpleScalerQuery("select count(*) from EmployeeVacation where GETDATE() between FromDate and ToDate") > 0 Then
            btnVacation.Text = "WORKING ON VACATION !.."
            btnVacation.BackColor = Color.FromArgb(229, 73, 72)
            isHoliday = 1
        End If
    End Sub

End Class