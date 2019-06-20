<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddAttendence
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddAttendence))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.comboEmpName = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.timerWork = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.timePicker = New DevExpress.XtraEditors.TimeEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.labelInOut = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.btnLoginOut = New System.Windows.Forms.Button()
        Me.lblTodayDate = New System.Windows.Forms.Label()
        Me.btnVacation = New System.Windows.Forms.Button()
        CType(Me.timePicker.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 398)
        Me.Panel3.TabIndex = 169
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(404, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(11, 398)
        Me.Panel2.TabIndex = 168
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 398)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(415, 11)
        Me.Panel4.TabIndex = 167
        '
        'comboEmpName
        '
        Me.comboEmpName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboEmpName.FormattingEnabled = True
        Me.comboEmpName.Location = New System.Drawing.Point(201, 116)
        Me.comboEmpName.Name = "comboEmpName"
        Me.comboEmpName.Size = New System.Drawing.Size(124, 21)
        Me.comboEmpName.TabIndex = 170
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 25)
        Me.Label1.TabIndex = 171
        Me.Label1.Text = "ADD ATTENDENCE"
        '
        'timerWork
        '
        Me.timerWork.Interval = 1000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(104, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 171
        Me.Label2.Text = "NAME"
        '
        'timePicker
        '
        Me.timePicker.EditValue = New Date(2018, 9, 15, 0, 0, 0, 0)
        Me.timePicker.Location = New System.Drawing.Point(201, 166)
        Me.timePicker.Name = "timePicker"
        Me.timePicker.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.timePicker.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI
        Me.timePicker.Size = New System.Drawing.Size(124, 20)
        Me.timePicker.TabIndex = 172
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(213, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 171
        Me.Label3.Text = "FOR TODAY: "
        '
        'labelInOut
        '
        Me.labelInOut.AutoSize = True
        Me.labelInOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelInOut.Location = New System.Drawing.Point(62, 170)
        Me.labelInOut.Name = "labelInOut"
        Me.labelInOut.Size = New System.Drawing.Size(89, 16)
        Me.labelInOut.TabIndex = 171
        Me.labelInOut.Text = "START TIME"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(52, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 16)
        Me.Label4.TabIndex = 171
        Me.Label4.Text = "WORKED FOR"
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(197, 216)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(71, 20)
        Me.lblTimer.TabIndex = 171
        Me.lblTimer.Text = "00:00:00"
        '
        'btnLoginOut
        '
        Me.btnLoginOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnLoginOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoginOut.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLoginOut.Location = New System.Drawing.Point(137, 279)
        Me.btnLoginOut.Name = "btnLoginOut"
        Me.btnLoginOut.Size = New System.Drawing.Size(114, 40)
        Me.btnLoginOut.TabIndex = 174
        Me.btnLoginOut.Text = "START"
        Me.btnLoginOut.UseVisualStyleBackColor = False
        '
        'lblTodayDate
        '
        Me.lblTodayDate.AutoSize = True
        Me.lblTodayDate.Location = New System.Drawing.Point(294, 77)
        Me.lblTodayDate.Name = "lblTodayDate"
        Me.lblTodayDate.Size = New System.Drawing.Size(75, 13)
        Me.lblTodayDate.TabIndex = 171
        Me.lblTodayDate.Text = "FOR TODAY: "
        '
        'btnVacation
        '
        Me.btnVacation.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVacation.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnVacation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVacation.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVacation.Location = New System.Drawing.Point(10, 357)
        Me.btnVacation.MinimumSize = New System.Drawing.Size(394, 41)
        Me.btnVacation.Name = "btnVacation"
        Me.btnVacation.Size = New System.Drawing.Size(394, 41)
        Me.btnVacation.TabIndex = 175
        Me.btnVacation.Text = "BOOK A VACATION"
        Me.btnVacation.UseVisualStyleBackColor = False
        '
        'AddAttendence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 409)
        Me.Controls.Add(Me.btnVacation)
        Me.Controls.Add(Me.btnLoginOut)
        Me.Controls.Add(Me.timePicker)
        Me.Controls.Add(Me.lblTodayDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.labelInOut)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comboEmpName)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(346, 372)
        Me.Name = "AddAttendence"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ADD ATTENDENCE"
        CType(Me.timePicker.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents comboEmpName As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents timerWork As System.Windows.Forms.Timer
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents timePicker As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents labelInOut As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTimer As System.Windows.Forms.Label
    Friend WithEvents btnLoginOut As System.Windows.Forms.Button
    Friend WithEvents lblTodayDate As System.Windows.Forms.Label
    Friend WithEvents btnVacation As System.Windows.Forms.Button
End Class
