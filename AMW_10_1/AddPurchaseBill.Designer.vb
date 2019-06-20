<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPurchaseBill
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddPurchaseBill))
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.comboGST = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.taDescription = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EDITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gridContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTotalTaxable = New System.Windows.Forms.Label()
        Me.lblTotalPayable = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblTotalTax = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.itemGRID = New System.Windows.Forms.DataGridView()
        Me.srno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.batch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.taxValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cgstRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cgstAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sgstRate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sgstAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtHSN = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCGSTRate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSGSTRate = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblTotalQty = New System.Windows.Forms.Label()
        Me.lblEachAmt = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBillNO = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.dtpIssueDate = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.nmShipping = New System.Windows.Forms.NumericUpDown()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.nmMantainance = New System.Windows.Forms.NumericUpDown()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.nmOther = New System.Windows.Forms.NumericUpDown()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpDeliveryDate = New System.Windows.Forms.DateTimePicker()
        Me.txtItemDesc = New System.Windows.Forms.TextBox()
        Me.gridContext.SuspendLayout()
        CType(Me.itemGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmShipping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmMantainance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nmOther, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUnit
        '
        Me.txtUnit.Location = New System.Drawing.Point(393, 231)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(96, 20)
        Me.txtUnit.TabIndex = 202
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(495, 230)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(123, 20)
        Me.txtRate.TabIndex = 201
        Me.txtRate.Text = "0"
        '
        'comboGST
        '
        Me.comboGST.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboGST.FormattingEnabled = True
        Me.comboGST.Location = New System.Drawing.Point(341, 104)
        Me.comboGST.Name = "comboGST"
        Me.comboGST.Size = New System.Drawing.Size(195, 21)
        Me.comboGST.TabIndex = 157
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label7.Location = New System.Drawing.Point(22, 449)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 18)
        Me.Label7.TabIndex = 197
        Me.Label7.Text = "Description" & Global.Microsoft.VisualBasic.ChrW(13)
        '
        'taDescription
        '
        Me.taDescription.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.taDescription.Location = New System.Drawing.Point(111, 450)
        Me.taDescription.Multiline = True
        Me.taDescription.Name = "taDescription"
        Me.taDescription.Size = New System.Drawing.Size(187, 41)
        Me.taDescription.TabIndex = 195
        Me.taDescription.Text = "Ex: Transportation cost, vehicle number etc."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(466, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(329, 31)
        Me.Label6.TabIndex = 191
        Me.Label6.Text = "PURCHASE BILL ENTRY"
        '
        'DELETEToolStripMenuItem
        '
        Me.DELETEToolStripMenuItem.Name = "DELETEToolStripMenuItem"
        Me.DELETEToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.DELETEToolStripMenuItem.Text = "DELETE"
        '
        'EDITToolStripMenuItem
        '
        Me.EDITToolStripMenuItem.Name = "EDITToolStripMenuItem"
        Me.EDITToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.EDITToolStripMenuItem.Text = "EDIT"
        '
        'gridContext
        '
        Me.gridContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EDITToolStripMenuItem, Me.DELETEToolStripMenuItem})
        Me.gridContext.Name = "gridContext"
        Me.gridContext.Size = New System.Drawing.Size(114, 48)
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 505)
        Me.Panel3.TabIndex = 190
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1260, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(11, 505)
        Me.Panel2.TabIndex = 189
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 505)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1271, 11)
        Me.Panel4.TabIndex = 188
        '
        'btnSet
        '
        Me.btnSet.Location = New System.Drawing.Point(1085, 227)
        Me.btnSet.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(74, 23)
        Me.btnSet.TabIndex = 173
        Me.btnSet.Text = "NEXT"
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(1175, 225)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(74, 25)
        Me.btnReset.TabIndex = 175
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(289, 231)
        Me.txtQty.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(99, 20)
        Me.txtQty.TabIndex = 171
        Me.txtQty.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(423, 209)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 18)
        Me.Label13.TabIndex = 182
        Me.Label13.Text = "UNIT"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(309, 209)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 18)
        Me.Label12.TabIndex = 180
        Me.Label12.Text = "QTY"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(535, 209)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 18)
        Me.Label15.TabIndex = 172
        Me.Label15.Text = "RATE"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(121, 210)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(148, 18)
        Me.Label10.TabIndex = 179
        Me.Label10.Text = "ITEM DESCRIPTION"
        '
        'lblTotalTaxable
        '
        Me.lblTotalTaxable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalTaxable.AutoSize = True
        Me.lblTotalTaxable.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTaxable.Location = New System.Drawing.Point(637, 393)
        Me.lblTotalTaxable.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalTaxable.Name = "lblTotalTaxable"
        Me.lblTotalTaxable.Size = New System.Drawing.Size(16, 18)
        Me.lblTotalTaxable.TabIndex = 161
        Me.lblTotalTaxable.Text = "0"
        '
        'lblTotalPayable
        '
        Me.lblTotalPayable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalPayable.AutoSize = True
        Me.lblTotalPayable.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPayable.Location = New System.Drawing.Point(1123, 392)
        Me.lblTotalPayable.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalPayable.Name = "lblTotalPayable"
        Me.lblTotalPayable.Size = New System.Drawing.Size(16, 18)
        Me.lblTotalPayable.TabIndex = 159
        Me.lblTotalPayable.Text = "0"
        Me.lblTotalPayable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(114, 393)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(55, 18)
        Me.Label23.TabIndex = 164
        Me.Label23.Text = "TOTAL"
        '
        'Label27
        '
        Me.Label27.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(1047, 393)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(63, 18)
        Me.Label27.TabIndex = 160
        Me.Label27.Text = "TOTAL :"
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(541, 393)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(77, 18)
        Me.Label25.TabIndex = 163
        Me.Label25.Text = "TAXABLE:"
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(731, 393)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(127, 18)
        Me.Label24.TabIndex = 166
        Me.Label24.Text = "+(CGST+SGST ):"
        '
        'lblTotalTax
        '
        Me.lblTotalTax.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalTax.AutoSize = True
        Me.lblTotalTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTax.Location = New System.Drawing.Point(885, 393)
        Me.lblTotalTax.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalTax.Name = "lblTotalTax"
        Me.lblTotalTax.Size = New System.Drawing.Size(16, 18)
        Me.lblTotalTax.TabIndex = 167
        Me.lblTotalTax.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(268, 103)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 168
        Me.Label2.Text = "GSTIN:"
        '
        'txtCustName
        '
        Me.txtCustName.Location = New System.Drawing.Point(102, 105)
        Me.txtCustName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(155, 20)
        Me.txtCustName.TabIndex = 156
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 103)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 18)
        Me.Label1.TabIndex = 165
        Me.Label1.Text = "Merchant"
        '
        'itemGRID
        '
        Me.itemGRID.AllowUserToAddRows = False
        Me.itemGRID.AllowUserToDeleteRows = False
        Me.itemGRID.AllowUserToResizeColumns = False
        Me.itemGRID.AllowUserToResizeRows = False
        Me.itemGRID.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.itemGRID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.itemGRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.itemGRID.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.srno, Me.batch, Me.itemName, Me.qty, Me.unit, Me.rate, Me.taxValue, Me.cgstRate, Me.cgstAmt, Me.sgstRate, Me.sgstAmt, Me.totalAmt})
        Me.itemGRID.Enabled = False
        Me.itemGRID.EnableHeadersVisualStyles = False
        Me.itemGRID.Location = New System.Drawing.Point(13, 257)
        Me.itemGRID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.itemGRID.MultiSelect = False
        Me.itemGRID.Name = "itemGRID"
        Me.itemGRID.ReadOnly = True
        Me.itemGRID.RowHeadersVisible = False
        Me.itemGRID.Size = New System.Drawing.Size(1247, 132)
        Me.itemGRID.TabIndex = 184
        '
        'srno
        '
        Me.srno.FillWeight = 25.38071!
        Me.srno.HeaderText = "SR"
        Me.srno.Name = "srno"
        Me.srno.ReadOnly = True
        '
        'batch
        '
        Me.batch.FillWeight = 60.0!
        Me.batch.HeaderText = "HSN"
        Me.batch.Name = "batch"
        Me.batch.ReadOnly = True
        '
        'itemName
        '
        Me.itemName.FillWeight = 140.0!
        Me.itemName.HeaderText = "DESCRIPTION OF GOODS"
        Me.itemName.Name = "itemName"
        Me.itemName.ReadOnly = True
        '
        'qty
        '
        Me.qty.FillWeight = 90.0!
        Me.qty.HeaderText = "QTY"
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        '
        'unit
        '
        Me.unit.FillWeight = 80.0!
        Me.unit.HeaderText = "UNIT"
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = True
        '
        'rate
        '
        Me.rate.FillWeight = 108.291!
        Me.rate.HeaderText = "RATE"
        Me.rate.Name = "rate"
        Me.rate.ReadOnly = True
        '
        'taxValue
        '
        Me.taxValue.HeaderText = "TAXABLE VALUE"
        Me.taxValue.Name = "taxValue"
        Me.taxValue.ReadOnly = True
        '
        'cgstRate
        '
        Me.cgstRate.FillWeight = 60.0!
        Me.cgstRate.HeaderText = "CGST %"
        Me.cgstRate.Name = "cgstRate"
        Me.cgstRate.ReadOnly = True
        '
        'cgstAmt
        '
        Me.cgstAmt.HeaderText = "CGST AMOUNT"
        Me.cgstAmt.Name = "cgstAmt"
        Me.cgstAmt.ReadOnly = True
        '
        'sgstRate
        '
        Me.sgstRate.FillWeight = 60.0!
        Me.sgstRate.HeaderText = "SGST %"
        Me.sgstRate.Name = "sgstRate"
        Me.sgstRate.ReadOnly = True
        '
        'sgstAmt
        '
        Me.sgstAmt.HeaderText = "SGST AMOUNT"
        Me.sgstAmt.Name = "sgstAmt"
        Me.sgstAmt.ReadOnly = True
        '
        'totalAmt
        '
        Me.totalAmt.FillWeight = 108.291!
        Me.totalAmt.HeaderText = "AMOUNT"
        Me.totalAmt.Name = "totalAmt"
        Me.totalAmt.ReadOnly = True
        '
        'txtHSN
        '
        Me.txtHSN.Location = New System.Drawing.Point(48, 231)
        Me.txtHSN.Name = "txtHSN"
        Me.txtHSN.Size = New System.Drawing.Size(68, 20)
        Me.txtHSN.TabIndex = 204
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 210)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 18)
        Me.Label3.TabIndex = 180
        Me.Label3.Text = "HSN"
        '
        'txtCGSTRate
        '
        Me.txtCGSTRate.Location = New System.Drawing.Point(751, 231)
        Me.txtCGSTRate.Name = "txtCGSTRate"
        Me.txtCGSTRate.Size = New System.Drawing.Size(60, 20)
        Me.txtCGSTRate.TabIndex = 205
        Me.txtCGSTRate.Text = "9"
        Me.txtCGSTRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(748, 209)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 18)
        Me.Label4.TabIndex = 172
        Me.Label4.Text = "CGST %"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(838, 209)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 18)
        Me.Label8.TabIndex = 172
        Me.Label8.Text = "SGST %"
        '
        'txtSGSTRate
        '
        Me.txtSGSTRate.Location = New System.Drawing.Point(841, 231)
        Me.txtSGSTRate.Name = "txtSGSTRate"
        Me.txtSGSTRate.Size = New System.Drawing.Size(60, 20)
        Me.txtSGSTRate.TabIndex = 205
        Me.txtSGSTRate.Text = "9"
        Me.txtSGSTRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(215, 393)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 18)
        Me.Label9.TabIndex = 163
        Me.Label9.Text = "QUANTITY :"
        '
        'lblTotalQty
        '
        Me.lblTotalQty.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalQty.AutoSize = True
        Me.lblTotalQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalQty.Location = New System.Drawing.Point(309, 393)
        Me.lblTotalQty.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalQty.Name = "lblTotalQty"
        Me.lblTotalQty.Size = New System.Drawing.Size(16, 18)
        Me.lblTotalQty.TabIndex = 161
        Me.lblTotalQty.Text = "0"
        '
        'lblEachAmt
        '
        Me.lblEachAmt.AutoSize = True
        Me.lblEachAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEachAmt.Location = New System.Drawing.Point(940, 233)
        Me.lblEachAmt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEachAmt.Name = "lblEachAmt"
        Me.lblEachAmt.Size = New System.Drawing.Size(20, 18)
        Me.lblEachAmt.TabIndex = 168
        Me.lblEachAmt.Text = "0."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(940, 210)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 18)
        Me.Label14.TabIndex = 168
        Me.Label14.Text = "AMOUNT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(568, 101)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 18)
        Me.Label5.TabIndex = 165
        Me.Label5.Text = "Bill NO."
        '
        'txtBillNO
        '
        Me.txtBillNO.Location = New System.Drawing.Point(640, 104)
        Me.txtBillNO.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtBillNO.Name = "txtBillNO"
        Me.txtBillNO.Size = New System.Drawing.Size(155, 20)
        Me.txtBillNO.TabIndex = 156
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(821, 103)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(78, 18)
        Me.Label16.TabIndex = 165
        Me.Label16.Text = "Issue Date"
        '
        'dtpIssueDate
        '
        Me.dtpIssueDate.Location = New System.Drawing.Point(904, 101)
        Me.dtpIssueDate.Name = "dtpIssueDate"
        Me.dtpIssueDate.Size = New System.Drawing.Size(206, 20)
        Me.dtpIssueDate.TabIndex = 206
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(330, 450)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(113, 18)
        Me.Label17.TabIndex = 165
        Me.Label17.Text = "Shipping charge"
        '
        'nmShipping
        '
        Me.nmShipping.Location = New System.Drawing.Point(448, 448)
        Me.nmShipping.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.nmShipping.Name = "nmShipping"
        Me.nmShipping.Size = New System.Drawing.Size(79, 20)
        Me.nmShipping.TabIndex = 207
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(541, 450)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(141, 18)
        Me.Label18.TabIndex = 165
        Me.Label18.Text = "Mantainance charge"
        '
        'nmMantainance
        '
        Me.nmMantainance.Location = New System.Drawing.Point(687, 452)
        Me.nmMantainance.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.nmMantainance.Name = "nmMantainance"
        Me.nmMantainance.Size = New System.Drawing.Size(77, 20)
        Me.nmMantainance.TabIndex = 207
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(779, 454)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(102, 18)
        Me.Label19.TabIndex = 165
        Me.Label19.Text = "Other charges"
        '
        'nmOther
        '
        Me.nmOther.Location = New System.Drawing.Point(888, 451)
        Me.nmOther.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.nmOther.Name = "nmOther"
        Me.nmOther.Size = New System.Drawing.Size(77, 20)
        Me.nmOther.TabIndex = 207
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAdd.Location = New System.Drawing.Point(1137, 430)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(99, 52)
        Me.btnAdd.TabIndex = 208
        Me.btnAdd.Text = "ADD FINALLY!"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(804, 140)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 18)
        Me.Label11.TabIndex = 165
        Me.Label11.Text = "Delivery Date"
        '
        'dtpDeliveryDate
        '
        Me.dtpDeliveryDate.Location = New System.Drawing.Point(904, 138)
        Me.dtpDeliveryDate.Name = "dtpDeliveryDate"
        Me.dtpDeliveryDate.Size = New System.Drawing.Size(206, 20)
        Me.dtpDeliveryDate.TabIndex = 206
        '
        'txtItemDesc
        '
        Me.txtItemDesc.Location = New System.Drawing.Point(123, 230)
        Me.txtItemDesc.Name = "txtItemDesc"
        Me.txtItemDesc.Size = New System.Drawing.Size(158, 20)
        Me.txtItemDesc.TabIndex = 209
        '
        'AddPurchaseBill
        '
        Me.AcceptButton = Me.btnSet
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1271, 516)
        Me.Controls.Add(Me.txtItemDesc)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.nmOther)
        Me.Controls.Add(Me.nmMantainance)
        Me.Controls.Add(Me.nmShipping)
        Me.Controls.Add(Me.dtpDeliveryDate)
        Me.Controls.Add(Me.dtpIssueDate)
        Me.Controls.Add(Me.txtSGSTRate)
        Me.Controls.Add(Me.txtCGSTRate)
        Me.Controls.Add(Me.txtHSN)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.comboGST)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.taDescription)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.btnSet)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblTotalQty)
        Me.Controls.Add(Me.lblTotalTaxable)
        Me.Controls.Add(Me.lblTotalPayable)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.lblTotalTax)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblEachAmt)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtBillNO)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCustName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.itemGRID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1287, 555)
        Me.Name = "AddPurchaseBill"
        Me.Text = "ENTRY NEW BILL"
        Me.gridContext.ResumeLayout(False)
        CType(Me.itemGRID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmShipping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmMantainance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nmOther, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUnit As System.Windows.Forms.TextBox
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents comboGST As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents taDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DELETEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EDITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents gridContext As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents btnSet As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblTotalTaxable As System.Windows.Forms.Label
    Friend WithEvents lblTotalPayable As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lblTotalTax As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCustName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents itemGRID As System.Windows.Forms.DataGridView
    Friend WithEvents srno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents batch As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents taxValue As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cgstRate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cgstAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sgstRate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sgstAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totalAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtHSN As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCGSTRate As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSGSTRate As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblTotalQty As System.Windows.Forms.Label
    Friend WithEvents lblEachAmt As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBillNO As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents dtpIssueDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents nmShipping As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents nmMantainance As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents nmOther As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpDeliveryDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtItemDesc As System.Windows.Forms.TextBox
End Class
