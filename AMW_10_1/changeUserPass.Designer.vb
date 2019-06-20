<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class changeUserPass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(changeUserPass))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtConfPass = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnResetSeq = New System.Windows.Forms.Button()
        Me.txtSuffix = New System.Windows.Forms.TextBox()
        Me.txtPrefix = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nmCounter = New System.Windows.Forms.NumericUpDown()
        CType(Me.nmCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "New password"
        '
        'txtNewPass
        '
        Me.txtNewPass.Location = New System.Drawing.Point(170, 25)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.Size = New System.Drawing.Size(130, 20)
        Me.txtNewPass.TabIndex = 2
        Me.txtNewPass.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Confirm password"
        '
        'txtConfPass
        '
        Me.txtConfPass.Location = New System.Drawing.Point(170, 69)
        Me.txtConfPass.Name = "txtConfPass"
        Me.txtConfPass.Size = New System.Drawing.Size(130, 20)
        Me.txtConfPass.TabIndex = 3
        Me.txtConfPass.UseSystemPasswordChar = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(89, 105)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(170, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "CHANGE USER, PASS"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnResetSeq
        '
        Me.btnResetSeq.Location = New System.Drawing.Point(89, 226)
        Me.btnResetSeq.Name = "btnResetSeq"
        Me.btnResetSeq.Size = New System.Drawing.Size(170, 23)
        Me.btnResetSeq.TabIndex = 4
        Me.btnResetSeq.Text = "RESET BILL SEQUENCE"
        Me.btnResetSeq.UseVisualStyleBackColor = True
        '
        'txtSuffix
        '
        Me.txtSuffix.Location = New System.Drawing.Point(215, 157)
        Me.txtSuffix.Name = "txtSuffix"
        Me.txtSuffix.Size = New System.Drawing.Size(100, 20)
        Me.txtSuffix.TabIndex = 5
        '
        'txtPrefix
        '
        Me.txtPrefix.Location = New System.Drawing.Point(3, 157)
        Me.txtPrefix.Name = "txtPrefix"
        Me.txtPrefix.Size = New System.Drawing.Size(100, 20)
        Me.txtPrefix.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "PREFIX"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(106, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "COUNTER"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(212, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "SUFFIX"
        '
        'nmCounter
        '
        Me.nmCounter.Location = New System.Drawing.Point(109, 157)
        Me.nmCounter.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.nmCounter.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nmCounter.Name = "nmCounter"
        Me.nmCounter.Size = New System.Drawing.Size(100, 20)
        Me.nmCounter.TabIndex = 7
        Me.nmCounter.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'changeUserPass
        '
        Me.AcceptButton = Me.btnResetSeq
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 261)
        Me.Controls.Add(Me.nmCounter)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPrefix)
        Me.Controls.Add(Me.txtSuffix)
        Me.Controls.Add(Me.btnResetSeq)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtConfPass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNewPass)
        Me.Controls.Add(Me.Label2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "changeUserPass"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "APP SETTINGS"
        CType(Me.nmCounter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNewPass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtConfPass As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnResetSeq As System.Windows.Forms.Button
    Friend WithEvents txtSuffix As System.Windows.Forms.TextBox
    Friend WithEvents txtPrefix As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nmCounter As System.Windows.Forms.NumericUpDown
End Class
