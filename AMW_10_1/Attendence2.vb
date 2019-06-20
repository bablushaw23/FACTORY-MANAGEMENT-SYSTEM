Imports System.Data.SqlClient

Public Class Attendence2

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
    Private Sub Attendence2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        startTime.Time = "09:00:00"
        dtpOnDate.MaxDate = Today
        dtpOnDate.Value = Today
        endTime.Time = startTime.Time.AddHours(Integer.Parse(txtOverTime.Text) + 9)

        Dim setEmpName As New cmdClass
        Dim coll As AutoCompleteStringCollection = setEmpName.returnAutocomplete("select Name from EmployeePersonalTable", False)
        comboEmpName.Items.Clear()
        For Each item In coll
            comboEmpName.Items.Add(item)
        Next
        comboEmpName.SelectedIndex = 0
        checkForVacation()
    End Sub
    Private Property isHoliday As Integer = 0       '0: not, 1: yes
    Private Sub checkForVacation()
        Dim cmd As New cmdClass
        If Today.DayOfWeek = DayOfWeek.Sunday Or cmd.returnSimpleScalerQuery("select count(*) from EmployeeVacation where GETDATE() between FromDate and ToDate") > 0 Then
            btnVacation.Text = "WORKING ON VACATION !.."
            btnVacation.BackColor = Color.FromArgb(229, 73, 72)
            isHoliday = 1
        End If
    End Sub

    Private Sub txtOverTime_MaskInputRejected(sender As Object, e As EventArgs) Handles txtOverTime.LostFocus
        endTime.Time = startTime.Time.AddHours(Integer.Parse(txtOverTime.Text) + 9)
    End Sub

    Private Sub btnSET_Click(sender As Object, e As EventArgs) Handles btnSET.Click
       
        Dim cmd As New SqlCommand
        cmd.Parameters.AddWithValue("@startTime", Format(startTime.Time, "HH:mm:ss"))
        cmd.Parameters.AddWithValue("@endTime", Format(endTime.Time, "HH:mm:ss"))
        cmd.Parameters.AddWithValue("@date", dtpOnDate.Value)
        cmd.Parameters.AddWithValue("@inAttend", ConstantClass.UserID)
        cmd.Parameters.AddWithValue("@outAttend", ConstantClass.UserID)
        cmd.Parameters.AddWithValue("@empName", comboEmpName.SelectedItem)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.CommandText = "addAttendence2"
        Dim cmdCls As New cmdClass
        Try
            cmdCls.executeCMDNonQuery(cmd)
            errmsg.msggetter("SAVED!", True)
        Catch ex As Exception
            MsgBox("An error has ocured : " + ex.Message)
        Finally
            cmd.Dispose()
        End Try
    End Sub

    Dim errmsg As New messager

    

    Private Sub btnVacation_Click(sender As Object, e As EventArgs) Handles btnVacation.Click
        If isHoliday Then
            MsgBox("You are already in vacation..If time really over, then you should restart this form again")
        Else
            Dim form As New VacationForm
            form.ShowDialog()
            form.Dispose()
        End If
    End Sub
End Class