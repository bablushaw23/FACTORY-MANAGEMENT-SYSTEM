<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentDescription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentDescription))
        Me.lblInvNo = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnAddNewPayment = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblClientName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblAmt = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbldDue = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNxtDate = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblNextAmt = New System.Windows.Forms.Label()
        Me.lnkLblShowInvoice = New System.Windows.Forms.LinkLabel()
        Me.gridPayDesc = New System.Windows.Forms.DataGridView()
        Me.panelNextDtl = New System.Windows.Forms.Panel()
        Me.panelDue = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnEditBill = New System.Windows.Forms.Button()
        CType(Me.gridPayDesc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelNextDtl.SuspendLayout()
        Me.panelDue.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblInvNo
        '
        Me.lblInvNo.AutoSize = True
        Me.lblInvNo.BackColor = System.Drawing.SystemColors.Control
        Me.lblInvNo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblInvNo.Location = New System.Drawing.Point(94, 9)
        Me.lblInvNo.Name = "lblInvNo"
        Me.lblInvNo.Size = New System.Drawing.Size(72, 13)
        Me.lblInvNo.TabIndex = 1
        Me.lblInvNo.Text = "INVOICE NO-"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.SystemColors.Control
        Me.Label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label20.Location = New System.Drawing.Point(16, 9)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(72, 13)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "INVOICE NO-"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 459)
        Me.Panel3.TabIndex = 162
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(992, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(11, 459)
        Me.Panel2.TabIndex = 161
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 459)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1003, 11)
        Me.Panel4.TabIndex = 160
        '
        'btnAddNewPayment
        '
        Me.btnAddNewPayment.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddNewPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnAddNewPayment.Font = New System.Drawing.Font("Lucida Sans Typewriter", 9.75!)
        Me.btnAddNewPayment.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAddNewPayment.Location = New System.Drawing.Point(10, 404)
        Me.btnAddNewPayment.Name = "btnAddNewPayment"
        Me.btnAddNewPayment.Size = New System.Drawing.Size(982, 42)
        Me.btnAddNewPayment.TabIndex = 164
        Me.btnAddNewPayment.Text = "ADD NEW PAYMENT"
        Me.btnAddNewPayment.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(16, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 165
        Me.Label1.Text = "CLIENT NAME:"
        '
        'lblClientName
        '
        Me.lblClientName.AutoSize = True
        Me.lblClientName.Font = New System.Drawing.Font("Calisto MT", 9.75!)
        Me.lblClientName.Location = New System.Drawing.Point(115, 47)
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Size = New System.Drawing.Size(46, 15)
        Me.lblClientName.TabIndex = 166
        Me.lblClientName.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(16, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 165
        Me.Label2.Text = "CLIENT'S ADDRESS:"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Font = New System.Drawing.Font("Calisto MT", 9.75!)
        Me.lblAddress.Location = New System.Drawing.Point(16, 111)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(46, 15)
        Me.lblAddress.TabIndex = 166
        Me.lblAddress.Text = "Label2"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(279, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 165
        Me.Label4.Text = "MOBILE:"
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.Font = New System.Drawing.Font("Calisto MT", 9.75!)
        Me.lblMobile.Location = New System.Drawing.Point(342, 49)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(46, 15)
        Me.lblMobile.TabIndex = 166
        Me.lblMobile.Text = "Label2"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(279, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 165
        Me.Label6.Text = "PHONE:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Calisto MT", 9.75!)
        Me.lblPhone.Location = New System.Drawing.Point(342, 88)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(46, 15)
        Me.lblPhone.TabIndex = 166
        Me.lblPhone.Text = "Label2"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.Location = New System.Drawing.Point(485, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 13)
        Me.Label8.TabIndex = 165
        Me.Label8.Text = "BILL AMOUNT:  ₹"
        '
        'lblAmt
        '
        Me.lblAmt.AutoSize = True
        Me.lblAmt.Font = New System.Drawing.Font("Calisto MT", 9.75!)
        Me.lblAmt.Location = New System.Drawing.Point(582, 51)
        Me.lblAmt.Name = "lblAmt"
        Me.lblAmt.Size = New System.Drawing.Size(46, 15)
        Me.lblAmt.TabIndex = 166
        Me.lblAmt.Text = "Label2"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.Location = New System.Drawing.Point(8, 2)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 165
        Me.Label10.Text = "DUE:  ₹"
        '
        'lbldDue
        '
        Me.lbldDue.AutoSize = True
        Me.lbldDue.Font = New System.Drawing.Font("Calisto MT", 9.75!)
        Me.lbldDue.Location = New System.Drawing.Point(56, 2)
        Me.lbldDue.Name = "lbldDue"
        Me.lbldDue.Size = New System.Drawing.Size(14, 15)
        Me.lbldDue.TabIndex = 166
        Me.lbldDue.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(11, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 165
        Me.Label3.Text = "NEXT INST. DATE: "
        '
        'lblNxtDate
        '
        Me.lblNxtDate.AutoSize = True
        Me.lblNxtDate.Font = New System.Drawing.Font("Calisto MT", 9.75!)
        Me.lblNxtDate.Location = New System.Drawing.Point(126, 5)
        Me.lblNxtDate.Name = "lblNxtDate"
        Me.lblNxtDate.Size = New System.Drawing.Size(46, 15)
        Me.lblNxtDate.TabIndex = 166
        Me.lblNxtDate.Text = "Label2"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.Location = New System.Drawing.Point(17, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 13)
        Me.Label7.TabIndex = 165
        Me.Label7.Text = "NEXT INST. AMT:  ₹"
        '
        'lblNextAmt
        '
        Me.lblNextAmt.AutoSize = True
        Me.lblNextAmt.Font = New System.Drawing.Font("Calisto MT", 9.75!)
        Me.lblNextAmt.Location = New System.Drawing.Point(126, 43)
        Me.lblNextAmt.Name = "lblNextAmt"
        Me.lblNextAmt.Size = New System.Drawing.Size(46, 15)
        Me.lblNextAmt.TabIndex = 166
        Me.lblNextAmt.Text = "Label2"
        '
        'lnkLblShowInvoice
        '
        Me.lnkLblShowInvoice.AutoSize = True
        Me.lnkLblShowInvoice.LinkVisited = True
        Me.lnkLblShowInvoice.Location = New System.Drawing.Point(445, 147)
        Me.lnkLblShowInvoice.Name = "lnkLblShowInvoice"
        Me.lnkLblShowInvoice.Size = New System.Drawing.Size(87, 13)
        Me.lnkLblShowInvoice.TabIndex = 167
        Me.lnkLblShowInvoice.TabStop = True
        Me.lnkLblShowInvoice.Text = "SHOW INVOICE"
        '
        'gridPayDesc
        '
        Me.gridPayDesc.AllowUserToAddRows = False
        Me.gridPayDesc.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridPayDesc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gridPayDesc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.gridPayDesc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridPayDesc.Location = New System.Drawing.Point(16, 163)
        Me.gridPayDesc.Name = "gridPayDesc"
        Me.gridPayDesc.ReadOnly = True
        Me.gridPayDesc.RowHeadersVisible = False
        Me.gridPayDesc.ShowEditingIcon = False
        Me.gridPayDesc.Size = New System.Drawing.Size(970, 235)
        Me.gridPayDesc.TabIndex = 168
        '
        'panelNextDtl
        '
        Me.panelNextDtl.Controls.Add(Me.lblNextAmt)
        Me.panelNextDtl.Controls.Add(Me.Label7)
        Me.panelNextDtl.Controls.Add(Me.lblNxtDate)
        Me.panelNextDtl.Controls.Add(Me.Label3)
        Me.panelNextDtl.Location = New System.Drawing.Point(746, 46)
        Me.panelNextDtl.Name = "panelNextDtl"
        Me.panelNextDtl.Size = New System.Drawing.Size(199, 64)
        Me.panelNextDtl.TabIndex = 169
        '
        'panelDue
        '
        Me.panelDue.Controls.Add(Me.lbldDue)
        Me.panelDue.Controls.Add(Me.Label10)
        Me.panelDue.Location = New System.Drawing.Point(526, 88)
        Me.panelDue.Name = "panelDue"
        Me.panelDue.Size = New System.Drawing.Size(178, 22)
        Me.panelDue.TabIndex = 170
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.Location = New System.Drawing.Point(911, 134)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 171
        Me.btnPrint.Text = "PRINT"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'btnEditBill
        '
        Me.btnEditBill.Location = New System.Drawing.Point(817, 134)
        Me.btnEditBill.Name = "btnEditBill"
        Me.btnEditBill.Size = New System.Drawing.Size(75, 23)
        Me.btnEditBill.TabIndex = 172
        Me.btnEditBill.Text = "EDIT BILL"
        Me.btnEditBill.UseVisualStyleBackColor = True
        '
        'PaymentDescription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1003, 470)
        Me.Controls.Add(Me.lblInvNo)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.btnEditBill)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.panelDue)
        Me.Controls.Add(Me.panelNextDtl)
        Me.Controls.Add(Me.gridPayDesc)
        Me.Controls.Add(Me.lnkLblShowInvoice)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblAmt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblMobile)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblClientName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnAddNewPayment)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1019, 509)
        Me.Name = "PaymentDescription"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment Description"
        CType(Me.gridPayDesc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelNextDtl.ResumeLayout(False)
        Me.panelNextDtl.PerformLayout()
        Me.panelDue.ResumeLayout(False)
        Me.panelDue.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnAddNewPayment As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblClientName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblMobile As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblAmt As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbldDue As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblNxtDate As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblNextAmt As System.Windows.Forms.Label
    Friend WithEvents lnkLblShowInvoice As System.Windows.Forms.LinkLabel
    Friend WithEvents gridPayDesc As System.Windows.Forms.DataGridView
    Friend WithEvents lblInvNo As System.Windows.Forms.Label
    Friend WithEvents panelNextDtl As System.Windows.Forms.Panel
    Friend WithEvents panelDue As System.Windows.Forms.Panel
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnEditBill As System.Windows.Forms.Button
End Class
