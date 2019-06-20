<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddNewPayment))
        Me.txtCN = New System.Windows.Forms.TextBox()
        Me.comboPaymentType = New System.Windows.Forms.ComboBox()
        Me.numNIA = New System.Windows.Forms.NumericUpDown()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnReceivePay = New System.Windows.Forms.Button()
        Me.lbl = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblCN = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dpNID = New System.Windows.Forms.DateTimePicker()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblCross = New System.Windows.Forms.Label()
        Me.panalTitle = New System.Windows.Forms.Panel()
        Me.lblInvRef = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAmt = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblDue = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numPay = New System.Windows.Forms.NumericUpDown()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.numNIA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panalTitle.SuspendLayout()
        CType(Me.numPay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCN
        '
        Me.txtCN.Location = New System.Drawing.Point(620, 171)
        Me.txtCN.Name = "txtCN"
        Me.txtCN.Size = New System.Drawing.Size(200, 20)
        Me.txtCN.TabIndex = 3
        '
        'comboPaymentType
        '
        Me.comboPaymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboPaymentType.FormattingEnabled = True
        Me.comboPaymentType.Items.AddRange(New Object() {"CHEQUE", "CASH", "CARD", "PAYPAL", "OTHER"})
        Me.comboPaymentType.Location = New System.Drawing.Point(620, 128)
        Me.comboPaymentType.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.comboPaymentType.Name = "comboPaymentType"
        Me.comboPaymentType.Size = New System.Drawing.Size(200, 21)
        Me.comboPaymentType.TabIndex = 2
        '
        'numNIA
        '
        Me.numNIA.Enabled = False
        Me.numNIA.Location = New System.Drawing.Point(195, 133)
        Me.numNIA.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.numNIA.Name = "numNIA"
        Me.numNIA.Size = New System.Drawing.Size(200, 20)
        Me.numNIA.TabIndex = 5
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCancel.Location = New System.Drawing.Point(442, 273)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(125, 41)
        Me.btnCancel.TabIndex = 168
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnReceivePay
        '
        Me.btnReceivePay.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnReceivePay.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReceivePay.Location = New System.Drawing.Point(271, 273)
        Me.btnReceivePay.Name = "btnReceivePay"
        Me.btnReceivePay.Size = New System.Drawing.Size(125, 41)
        Me.btnReceivePay.TabIndex = 167
        Me.btnReceivePay.Text = "RECEIVE PAYMENT"
        Me.btnReceivePay.UseVisualStyleBackColor = False
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(53, 137)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(89, 16)
        Me.lbl.TabIndex = 178
        Me.lbl.Text = "Next amt said"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(477, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 16)
        Me.Label6.TabIndex = 179
        Me.Label6.Text = "Payment type"
        '
        'lblCN
        '
        Me.lblCN.AutoSize = True
        Me.lblCN.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCN.Location = New System.Drawing.Point(491, 175)
        Me.lblCN.Name = "lblCN"
        Me.lblCN.Size = New System.Drawing.Size(76, 16)
        Me.lblCN.TabIndex = 180
        Me.lblCN.Text = "Cheque No"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 16)
        Me.Label5.TabIndex = 175
        Me.Label5.Text = "Next installment date"
        '
        'dpNID
        '
        Me.dpNID.Enabled = False
        Me.dpNID.Location = New System.Drawing.Point(195, 86)
        Me.dpNID.Name = "dpNID"
        Me.dpNID.Size = New System.Drawing.Size(200, 20)
        Me.dpNID.TabIndex = 4
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 28)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 292)
        Me.Panel3.TabIndex = 172
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(848, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(11, 292)
        Me.Panel2.TabIndex = 171
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 320)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(859, 11)
        Me.Panel4.TabIndex = 170
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label20.Location = New System.Drawing.Point(3, 4)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(201, 18)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Payment against Invoice :"
        '
        'lblCross
        '
        Me.lblCross.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCross.AutoSize = True
        Me.lblCross.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCross.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCross.Location = New System.Drawing.Point(830, 3)
        Me.lblCross.Name = "lblCross"
        Me.lblCross.Size = New System.Drawing.Size(26, 25)
        Me.lblCross.TabIndex = 0
        Me.lblCross.Text = "X"
        '
        'panalTitle
        '
        Me.panalTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.panalTitle.Controls.Add(Me.lblInvRef)
        Me.panalTitle.Controls.Add(Me.Label20)
        Me.panalTitle.Controls.Add(Me.lblCross)
        Me.panalTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.panalTitle.Location = New System.Drawing.Point(0, 0)
        Me.panalTitle.Name = "panalTitle"
        Me.panalTitle.Size = New System.Drawing.Size(859, 28)
        Me.panalTitle.TabIndex = 169
        '
        'lblInvRef
        '
        Me.lblInvRef.AutoSize = True
        Me.lblInvRef.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvRef.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblInvRef.Location = New System.Drawing.Point(210, 4)
        Me.lblInvRef.Name = "lblInvRef"
        Me.lblInvRef.Size = New System.Drawing.Size(18, 18)
        Me.lblInvRef.TabIndex = 1
        Me.lblInvRef.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 16)
        Me.Label1.TabIndex = 173
        Me.Label1.Text = "TOTAL AMOUNT:                 ₹"
        '
        'lblAmt
        '
        Me.lblAmt.AutoSize = True
        Me.lblAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmt.Location = New System.Drawing.Point(192, 41)
        Me.lblAmt.Name = "lblAmt"
        Me.lblAmt.Size = New System.Drawing.Size(15, 16)
        Me.lblAmt.TabIndex = 173
        Me.lblAmt.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(511, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 16)
        Me.Label2.TabIndex = 173
        Me.Label2.Text = "DUE:                    ₹"
        '
        'lblDue
        '
        Me.lblDue.AutoSize = True
        Me.lblDue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDue.Location = New System.Drawing.Point(630, 41)
        Me.lblDue.Name = "lblDue"
        Me.lblDue.Size = New System.Drawing.Size(15, 16)
        Me.lblDue.TabIndex = 173
        Me.lblDue.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(487, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 16)
        Me.Label3.TabIndex = 180
        Me.Label3.Text = "Paying Now              ₹"
        '
        'numPay
        '
        Me.numPay.DecimalPlaces = 2
        Me.numPay.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.numPay.Location = New System.Drawing.Point(620, 86)
        Me.numPay.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.numPay.Name = "numPay"
        Me.numPay.Size = New System.Drawing.Size(200, 20)
        Me.numPay.TabIndex = 5
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(195, 171)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(200, 50)
        Me.txtDesc.TabIndex = 181
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(53, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 178
        Me.Label4.Text = "Description"
        '
        'AddNewPayment
        '
        Me.AcceptButton = Me.btnReceivePay
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(859, 331)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.txtCN)
        Me.Controls.Add(Me.comboPaymentType)
        Me.Controls.Add(Me.numPay)
        Me.Controls.Add(Me.numNIA)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnReceivePay)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblCN)
        Me.Controls.Add(Me.lblDue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblAmt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dpNID)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.panalTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddNewPayment"
        Me.Text = "AddNewPayment"
        CType(Me.numNIA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panalTitle.ResumeLayout(False)
        Me.panalTitle.PerformLayout()
        CType(Me.numPay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCN As System.Windows.Forms.TextBox
    Friend WithEvents comboPaymentType As System.Windows.Forms.ComboBox
    Friend WithEvents numNIA As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnReceivePay As System.Windows.Forms.Button
    Friend WithEvents lbl As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblCN As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dpNID As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblCross As System.Windows.Forms.Label
    Friend WithEvents panalTitle As System.Windows.Forms.Panel
    Friend WithEvents lblInvRef As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAmt As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblDue As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents numPay As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
