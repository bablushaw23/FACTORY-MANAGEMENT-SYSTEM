<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attendence2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Attendence2))
        Me.lblCross = New System.Windows.Forms.Label()
        Me.lblmaximizeMinimize = New System.Windows.Forms.Label()
        Me.lblMinimize = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.panalTitle = New System.Windows.Forms.Panel()
        Me.comboEmpName = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVacation = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labelInOut = New System.Windows.Forms.Label()
        Me.startTime = New DevExpress.XtraEditors.TimeEdit()
        Me.btnSET = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.endTime = New DevExpress.XtraEditors.TimeEdit()
        Me.dtpOnDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtOverTime = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.panalTitle.SuspendLayout()
        CType(Me.startTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.endTime.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCross
        '
        Me.lblCross.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCross.AutoSize = True
        Me.lblCross.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCross.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCross.Location = New System.Drawing.Point(336, 3)
        Me.lblCross.Name = "lblCross"
        Me.lblCross.Size = New System.Drawing.Size(26, 25)
        Me.lblCross.TabIndex = 0
        Me.lblCross.Text = "X"
        '
        'lblmaximizeMinimize
        '
        Me.lblmaximizeMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblmaximizeMinimize.AutoSize = True
        Me.lblmaximizeMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmaximizeMinimize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblmaximizeMinimize.Location = New System.Drawing.Point(300, -3)
        Me.lblmaximizeMinimize.Name = "lblmaximizeMinimize"
        Me.lblmaximizeMinimize.Size = New System.Drawing.Size(30, 31)
        Me.lblmaximizeMinimize.TabIndex = 0
        Me.lblmaximizeMinimize.Text = "□"
        '
        'lblMinimize
        '
        Me.lblMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMinimize.AutoSize = True
        Me.lblMinimize.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinimize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblMinimize.Location = New System.Drawing.Point(264, -3)
        Me.lblMinimize.Name = "lblMinimize"
        Me.lblMinimize.Size = New System.Drawing.Size(24, 25)
        Me.lblMinimize.TabIndex = 0
        Me.lblMinimize.Text = "_"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label20.Location = New System.Drawing.Point(3, 6)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(106, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "ADD ATTENDENCE"
        '
        'panalTitle
        '
        Me.panalTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.panalTitle.Controls.Add(Me.Label20)
        Me.panalTitle.Controls.Add(Me.lblMinimize)
        Me.panalTitle.Controls.Add(Me.lblmaximizeMinimize)
        Me.panalTitle.Controls.Add(Me.lblCross)
        Me.panalTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.panalTitle.Location = New System.Drawing.Point(0, 0)
        Me.panalTitle.Name = "panalTitle"
        Me.panalTitle.Size = New System.Drawing.Size(365, 28)
        Me.panalTitle.TabIndex = 176
        '
        'comboEmpName
        '
        Me.comboEmpName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboEmpName.FormattingEnabled = True
        Me.comboEmpName.Location = New System.Drawing.Point(190, 125)
        Me.comboEmpName.Name = "comboEmpName"
        Me.comboEmpName.Size = New System.Drawing.Size(124, 21)
        Me.comboEmpName.TabIndex = 180
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 371)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(365, 11)
        Me.Panel4.TabIndex = 177
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(354, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(11, 343)
        Me.Panel2.TabIndex = 178
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 28)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 343)
        Me.Panel3.TabIndex = 179
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(96, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(218, 25)
        Me.Label1.TabIndex = 187
        Me.Label1.Text = "ADD ATTENDENCE"
        '
        'btnVacation
        '
        Me.btnVacation.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnVacation.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnVacation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVacation.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVacation.Location = New System.Drawing.Point(10, 330)
        Me.btnVacation.Name = "btnVacation"
        Me.btnVacation.Size = New System.Drawing.Size(344, 41)
        Me.btnVacation.TabIndex = 190
        Me.btnVacation.Text = "BOOK A VACATION"
        Me.btnVacation.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 185
        Me.Label2.Text = "NAME"
        '
        'labelInOut
        '
        Me.labelInOut.AutoSize = True
        Me.labelInOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelInOut.Location = New System.Drawing.Point(20, 170)
        Me.labelInOut.Name = "labelInOut"
        Me.labelInOut.Size = New System.Drawing.Size(89, 16)
        Me.labelInOut.TabIndex = 184
        Me.labelInOut.Text = "START TIME"
        '
        'startTime
        '
        Me.startTime.EditValue = New Date(2018, 9, 15, 0, 0, 0, 0)
        Me.startTime.Location = New System.Drawing.Point(190, 166)
        Me.startTime.Name = "startTime"
        Me.startTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.startTime.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI
        Me.startTime.Size = New System.Drawing.Size(124, 20)
        Me.startTime.TabIndex = 188
        '
        'btnSET
        '
        Me.btnSET.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnSET.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSET.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSET.Location = New System.Drawing.Point(126, 279)
        Me.btnSET.Name = "btnSET"
        Me.btnSET.Size = New System.Drawing.Size(114, 40)
        Me.btnSET.TabIndex = 189
        Me.btnSET.Text = "SAVE"
        Me.btnSET.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(37, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 184
        Me.Label4.Text = "END TIME"
        '
        'endTime
        '
        Me.endTime.EditValue = New Date(2018, 9, 15, 0, 0, 0, 0)
        Me.endTime.Location = New System.Drawing.Point(190, 224)
        Me.endTime.Name = "endTime"
        Me.endTime.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.endTime.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI
        Me.endTime.Size = New System.Drawing.Size(124, 20)
        Me.endTime.TabIndex = 188
        '
        'dtpOnDate
        '
        Me.dtpOnDate.Location = New System.Drawing.Point(134, 87)
        Me.dtpOnDate.Name = "dtpOnDate"
        Me.dtpOnDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpOnDate.TabIndex = 191
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 16)
        Me.Label3.TabIndex = 185
        Me.Label3.Text = "FOR DATE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 16)
        Me.Label5.TabIndex = 184
        Me.Label5.Text = "OVER TIME"
        '
        'txtOverTime
        '
        Me.txtOverTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOverTime.Location = New System.Drawing.Point(190, 197)
        Me.txtOverTime.Mask = "0"
        Me.txtOverTime.Name = "txtOverTime"
        Me.txtOverTime.Size = New System.Drawing.Size(21, 24)
        Me.txtOverTime.TabIndex = 192
        Me.txtOverTime.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(217, 197)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 16)
        Me.Label6.TabIndex = 184
        Me.Label6.Text = "HRS."
        '
        'Attendence2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(365, 382)
        Me.Controls.Add(Me.txtOverTime)
        Me.Controls.Add(Me.dtpOnDate)
        Me.Controls.Add(Me.btnVacation)
        Me.Controls.Add(Me.btnSET)
        Me.Controls.Add(Me.endTime)
        Me.Controls.Add(Me.startTime)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.labelInOut)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.comboEmpName)
        Me.Controls.Add(Me.panalTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Attendence2"
        Me.Text = "Attendence2"
        Me.panalTitle.ResumeLayout(False)
        Me.panalTitle.PerformLayout()
        CType(Me.startTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.endTime.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblCross As System.Windows.Forms.Label
    Friend WithEvents lblmaximizeMinimize As System.Windows.Forms.Label
    Friend WithEvents lblMinimize As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents panalTitle As System.Windows.Forms.Panel
    Friend WithEvents comboEmpName As System.Windows.Forms.ComboBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnVacation As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents labelInOut As System.Windows.Forms.Label
    Friend WithEvents startTime As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents btnSET As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents endTime As DevExpress.XtraEditors.TimeEdit
    Friend WithEvents dtpOnDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtOverTime As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
