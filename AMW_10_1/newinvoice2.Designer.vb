<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newinvoice2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newinvoice2))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.gridContext = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EDITToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DELETEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ITEMSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ITEMLISTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TOOLSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CALCULATORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NOTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.comboType = New System.Windows.Forms.ComboBox()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblPayable = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblAmt = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTotalDisc = New System.Windows.Forms.Label()
        Me.lblTotalAmt = New System.Windows.Forms.Label()
        Me.lblTotalPayable = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblTotalTax = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.itemGRID = New System.Windows.Forms.DataGridView()
        Me.srno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.itemType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.batch = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalAmt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.payable = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nudDiscount = New System.Windows.Forms.NumericUpDown()
        Me.taDescription = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.taDisclaimer = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.taNotes = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.taCompliments = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.comboCustAddress = New System.Windows.Forms.ComboBox()
        Me.lblRate = New System.Windows.Forms.TextBox()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.comboItemName = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblInvNo = New System.Windows.Forms.Label()
        Me.gridContext.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.itemGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(453, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(197, 31)
        Me.Label6.TabIndex = 149
        Me.Label6.Text = "NEW INVOICE"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 505)
        Me.Panel3.TabIndex = 148
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1260, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(11, 505)
        Me.Panel2.TabIndex = 147
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 505)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1271, 11)
        Me.Panel4.TabIndex = 146
        '
        'gridContext
        '
        Me.gridContext.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EDITToolStripMenuItem, Me.DELETEToolStripMenuItem})
        Me.gridContext.Name = "gridContext"
        Me.gridContext.Size = New System.Drawing.Size(114, 48)
        '
        'EDITToolStripMenuItem
        '
        Me.EDITToolStripMenuItem.Name = "EDITToolStripMenuItem"
        Me.EDITToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.EDITToolStripMenuItem.Text = "EDIT"
        '
        'DELETEToolStripMenuItem
        '
        Me.DELETEToolStripMenuItem.Name = "DELETEToolStripMenuItem"
        Me.DELETEToolStripMenuItem.Size = New System.Drawing.Size(113, 22)
        Me.DELETEToolStripMenuItem.Text = "DELETE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(2, 6)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(203, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "F9 : Save and Print bill when done"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ITEMSToolStripMenuItem, Me.TOOLSToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(12, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(160, 24)
        Me.MenuStrip1.TabIndex = 144
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BillToolStripMenuItem})
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
        Me.NewToolStripMenuItem.Text = "NEW"
        '
        'BillToolStripMenuItem
        '
        Me.BillToolStripMenuItem.Name = "BillToolStripMenuItem"
        Me.BillToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.BillToolStripMenuItem.Text = "BILL"
        '
        'ITEMSToolStripMenuItem
        '
        Me.ITEMSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ITEMLISTToolStripMenuItem})
        Me.ITEMSToolStripMenuItem.Name = "ITEMSToolStripMenuItem"
        Me.ITEMSToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.ITEMSToolStripMenuItem.Text = "ITEMS"
        '
        'ITEMLISTToolStripMenuItem
        '
        Me.ITEMLISTToolStripMenuItem.Name = "ITEMLISTToolStripMenuItem"
        Me.ITEMLISTToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ITEMLISTToolStripMenuItem.Text = "ITEM LIST"
        '
        'TOOLSToolStripMenuItem
        '
        Me.TOOLSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULATORToolStripMenuItem, Me.NOTESToolStripMenuItem})
        Me.TOOLSToolStripMenuItem.Name = "TOOLSToolStripMenuItem"
        Me.TOOLSToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.TOOLSToolStripMenuItem.Text = "TOOLS"
        '
        'CALCULATORToolStripMenuItem
        '
        Me.CALCULATORToolStripMenuItem.Name = "CALCULATORToolStripMenuItem"
        Me.CALCULATORToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.CALCULATORToolStripMenuItem.Text = "CALCULATOR"
        '
        'NOTESToolStripMenuItem
        '
        Me.NOTESToolStripMenuItem.Name = "NOTESToolStripMenuItem"
        Me.NOTESToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.NOTESToolStripMenuItem.Text = "NOTES"
        '
        'btnSet
        '
        Me.btnSet.Enabled = False
        Me.btnSet.Location = New System.Drawing.Point(1053, 161)
        Me.btnSet.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(74, 23)
        Me.btnSet.TabIndex = 127
        Me.btnSet.Text = "NEXT"
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Location = New System.Drawing.Point(1045, 12)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(210, 42)
        Me.Panel1.TabIndex = 143
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(1152, 162)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(74, 25)
        Me.btnReset.TabIndex = 130
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'comboType
        '
        Me.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboType.FormattingEnabled = True
        Me.comboType.Location = New System.Drawing.Point(416, 164)
        Me.comboType.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.comboType.Name = "comboType"
        Me.comboType.Size = New System.Drawing.Size(154, 21)
        Me.comboType.TabIndex = 122
        '
        'txtQty
        '
        Me.txtQty.Enabled = False
        Me.txtQty.Location = New System.Drawing.Point(663, 165)
        Me.txtQty.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(114, 20)
        Me.txtQty.TabIndex = 124
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(799, 169)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 18)
        Me.Label13.TabIndex = 138
        Me.Label13.Text = "UNIT"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(333, 167)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 18)
        Me.Label11.TabIndex = 137
        Me.Label11.Text = "TYPE"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(609, 167)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(38, 18)
        Me.Label12.TabIndex = 136
        Me.Label12.Text = "QTY"
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(995, 216)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(73, 18)
        Me.Label18.TabIndex = 139
        Me.Label18.Text = "PAYABLE"
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(635, 219)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(165, 18)
        Me.Label17.TabIndex = 123
        Me.Label17.Text = "DISCOUNT(max 100%)"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(445, 217)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 18)
        Me.Label16.TabIndex = 133
        Me.Label16.Text = "AMOUNT"
        '
        'lblPayable
        '
        Me.lblPayable.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPayable.AutoSize = True
        Me.lblPayable.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayable.Location = New System.Drawing.Point(1074, 216)
        Me.lblPayable.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPayable.Name = "lblPayable"
        Me.lblPayable.Size = New System.Drawing.Size(16, 18)
        Me.lblPayable.TabIndex = 132
        Me.lblPayable.Text = "0"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(211, 216)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(47, 18)
        Me.Label15.TabIndex = 126
        Me.Label15.Text = "RATE"
        '
        'lblAmt
        '
        Me.lblAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAmt.AutoSize = True
        Me.lblAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmt.Location = New System.Drawing.Point(524, 217)
        Me.lblAmt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAmt.Name = "lblAmt"
        Me.lblAmt.Size = New System.Drawing.Size(20, 18)
        Me.lblAmt.TabIndex = 129
        Me.lblAmt.Text = "0."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(27, 217)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(105, 18)
        Me.Label14.TabIndex = 134
        Me.Label14.Text = "CALCULATED"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(27, 169)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 18)
        Me.Label10.TabIndex = 135
        Me.Label10.Text = "ITEM NAME"
        '
        'lblTotalDisc
        '
        Me.lblTotalDisc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalDisc.AutoSize = True
        Me.lblTotalDisc.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalDisc.Location = New System.Drawing.Point(636, 392)
        Me.lblTotalDisc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalDisc.Name = "lblTotalDisc"
        Me.lblTotalDisc.Size = New System.Drawing.Size(16, 18)
        Me.lblTotalDisc.TabIndex = 110
        Me.lblTotalDisc.Text = "0"
        '
        'lblTotalAmt
        '
        Me.lblTotalAmt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalAmt.AutoSize = True
        Me.lblTotalAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalAmt.Location = New System.Drawing.Point(350, 393)
        Me.lblTotalAmt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalAmt.Name = "lblTotalAmt"
        Me.lblTotalAmt.Size = New System.Drawing.Size(16, 18)
        Me.lblTotalAmt.TabIndex = 109
        Me.lblTotalAmt.Text = "0"
        '
        'lblTotalPayable
        '
        Me.lblTotalPayable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalPayable.AutoSize = True
        Me.lblTotalPayable.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPayable.Location = New System.Drawing.Point(1082, 392)
        Me.lblTotalPayable.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalPayable.Name = "lblTotalPayable"
        Me.lblTotalPayable.Size = New System.Drawing.Size(16, 18)
        Me.lblTotalPayable.TabIndex = 107
        Me.lblTotalPayable.Text = "0"
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
        Me.Label23.TabIndex = 113
        Me.Label23.Text = "TOTAL"
        '
        'Label27
        '
        Me.Label27.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(991, 392)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(81, 18)
        Me.Label27.TabIndex = 108
        Me.Label27.Text = "PAYABLE :"
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(501, 393)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(117, 18)
        Me.Label26.TabIndex = 106
        Me.Label26.Text = "(-)  DISCOUNT :"
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(254, 393)
        Me.Label25.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(81, 18)
        Me.Label25.TabIndex = 111
        Me.Label25.Text = "AMOUNT :"
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(731, 393)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(130, 18)
        Me.Label24.TabIndex = 115
        Me.Label24.Text = "(+) TAX(@9+9)% :"
        '
        'lblTotalTax
        '
        Me.lblTotalTax.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalTax.AutoSize = True
        Me.lblTotalTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTax.Location = New System.Drawing.Point(865, 393)
        Me.lblTotalTax.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalTax.Name = "lblTotalTax"
        Me.lblTotalTax.Size = New System.Drawing.Size(16, 18)
        Me.lblTotalTax.TabIndex = 116
        Me.lblTotalTax.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(359, 99)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 18)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "DESTINATION"
        '
        'txtCustName
        '
        Me.txtCustName.Location = New System.Drawing.Point(84, 101)
        Me.txtCustName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.Size = New System.Drawing.Size(155, 20)
        Me.txtCustName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 103)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 18)
        Me.Label1.TabIndex = 114
        Me.Label1.Text = "Client"
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
        Me.itemGRID.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.srno, Me.itemName, Me.itemType, Me.qty, Me.unit, Me.batch, Me.rate, Me.totalAmt, Me.discount, Me.payable})
        Me.itemGRID.EnableHeadersVisualStyles = False
        Me.itemGRID.Location = New System.Drawing.Point(13, 257)
        Me.itemGRID.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.itemGRID.MultiSelect = False
        Me.itemGRID.Name = "itemGRID"
        Me.itemGRID.ReadOnly = True
        Me.itemGRID.RowHeadersVisible = False
        Me.itemGRID.Size = New System.Drawing.Size(1247, 132)
        Me.itemGRID.TabIndex = 142
        '
        'srno
        '
        Me.srno.FillWeight = 25.38071!
        Me.srno.HeaderText = "SR"
        Me.srno.Name = "srno"
        Me.srno.ReadOnly = True
        '
        'itemName
        '
        Me.itemName.FillWeight = 108.291!
        Me.itemName.HeaderText = "NAME"
        Me.itemName.Name = "itemName"
        Me.itemName.ReadOnly = True
        '
        'itemType
        '
        Me.itemType.FillWeight = 108.291!
        Me.itemType.HeaderText = "TYPE"
        Me.itemType.Name = "itemType"
        Me.itemType.ReadOnly = True
        '
        'qty
        '
        Me.qty.FillWeight = 108.291!
        Me.qty.HeaderText = "QTY"
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        '
        'unit
        '
        Me.unit.FillWeight = 108.291!
        Me.unit.HeaderText = "UNIT"
        Me.unit.Name = "unit"
        Me.unit.ReadOnly = True
        '
        'batch
        '
        Me.batch.FillWeight = 108.291!
        Me.batch.HeaderText = "HSN"
        Me.batch.Name = "batch"
        Me.batch.ReadOnly = True
        '
        'rate
        '
        Me.rate.FillWeight = 108.291!
        Me.rate.HeaderText = "RATE"
        Me.rate.Name = "rate"
        Me.rate.ReadOnly = True
        '
        'totalAmt
        '
        Me.totalAmt.FillWeight = 108.291!
        Me.totalAmt.HeaderText = "AMOUNT"
        Me.totalAmt.Name = "totalAmt"
        Me.totalAmt.ReadOnly = True
        '
        'discount
        '
        Me.discount.FillWeight = 108.291!
        Me.discount.HeaderText = "DISCOUNT"
        Me.discount.Name = "discount"
        Me.discount.ReadOnly = True
        '
        'payable
        '
        Me.payable.FillWeight = 108.291!
        Me.payable.HeaderText = "PAYABLE"
        Me.payable.Name = "payable"
        Me.payable.ReadOnly = True
        '
        'nudDiscount
        '
        Me.nudDiscount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nudDiscount.DecimalPlaces = 2
        Me.nudDiscount.Enabled = False
        Me.nudDiscount.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.nudDiscount.Location = New System.Drawing.Point(812, 217)
        Me.nudDiscount.Name = "nudDiscount"
        Me.nudDiscount.ReadOnly = True
        Me.nudDiscount.Size = New System.Drawing.Size(102, 20)
        Me.nudDiscount.TabIndex = 150
        '
        'taDescription
        '
        Me.taDescription.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.taDescription.Location = New System.Drawing.Point(136, 448)
        Me.taDescription.Multiline = True
        Me.taDescription.Name = "taDescription"
        Me.taDescription.Size = New System.Drawing.Size(187, 41)
        Me.taDescription.TabIndex = 151
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label7.Location = New System.Drawing.Point(22, 449)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 36)
        Me.Label7.TabIndex = 152
        Me.Label7.Text = "Description" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(not seen in bill)"
        '
        'taDisclaimer
        '
        Me.taDisclaimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.taDisclaimer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.taDisclaimer.Location = New System.Drawing.Point(433, 449)
        Me.taDisclaimer.Multiline = True
        Me.taDisclaimer.Name = "taDisclaimer"
        Me.taDisclaimer.Size = New System.Drawing.Size(187, 40)
        Me.taDisclaimer.TabIndex = 151
        Me.taDisclaimer.Text = "We declare that this invoice shows the actual price of the goods described and th" & _
    "at all particulars are true and correct.                1.goods once sold cannot" & _
    " be taken ack or exchanged."
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label8.Location = New System.Drawing.Point(349, 449)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 18)
        Me.Label8.TabIndex = 152
        Me.Label8.Text = "Disclaimer"
        '
        'taNotes
        '
        Me.taNotes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.taNotes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.taNotes.Location = New System.Drawing.Point(732, 450)
        Me.taNotes.Multiline = True
        Me.taNotes.Name = "taNotes"
        Me.taNotes.Size = New System.Drawing.Size(187, 39)
        Me.taNotes.TabIndex = 151
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label9.Location = New System.Drawing.Point(672, 450)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 18)
        Me.Label9.TabIndex = 152
        Me.Label9.Text = "Note"
        '
        'taCompliments
        '
        Me.taCompliments.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.taCompliments.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.taCompliments.Location = New System.Drawing.Point(1008, 448)
        Me.taCompliments.Multiline = True
        Me.taCompliments.Name = "taCompliments"
        Me.taCompliments.Size = New System.Drawing.Size(187, 41)
        Me.taCompliments.TabIndex = 151
        Me.taCompliments.Text = "THANK YOU FOR BUSINESS"
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.Label19.Location = New System.Drawing.Point(938, 448)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 18)
        Me.Label19.TabIndex = 152
        Me.Label19.Text = "Regards"
        '
        'comboCustAddress
        '
        Me.comboCustAddress.FormattingEnabled = True
        Me.comboCustAddress.Location = New System.Drawing.Point(481, 100)
        Me.comboCustAddress.Name = "comboCustAddress"
        Me.comboCustAddress.Size = New System.Drawing.Size(195, 21)
        Me.comboCustAddress.TabIndex = 2
        '
        'lblRate
        '
        Me.lblRate.Location = New System.Drawing.Point(294, 214)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(133, 20)
        Me.lblRate.TabIndex = 153
        '
        'txtUnit
        '
        Me.txtUnit.Location = New System.Drawing.Point(883, 165)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(137, 20)
        Me.txtUnit.TabIndex = 154
        '
        'comboItemName
        '
        Me.comboItemName.FormattingEnabled = True
        Me.comboItemName.Location = New System.Drawing.Point(136, 166)
        Me.comboItemName.Name = "comboItemName"
        Me.comboItemName.Size = New System.Drawing.Size(167, 21)
        Me.comboItemName.TabIndex = 155
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(845, 99)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 18)
        Me.Label3.TabIndex = 117
        Me.Label3.Text = "NEXT INVOICE NO: "
        '
        'lblInvNo
        '
        Me.lblInvNo.AutoSize = True
        Me.lblInvNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvNo.Location = New System.Drawing.Point(995, 99)
        Me.lblInvNo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInvNo.Name = "lblInvNo"
        Me.lblInvNo.Size = New System.Drawing.Size(138, 18)
        Me.lblInvNo.TabIndex = 117
        Me.lblInvNo.Text = "(inv No. fetch Error)"
        '
        'newinvoice2
        '
        Me.AcceptButton = Me.btnSet
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(1271, 516)
        Me.Controls.Add(Me.comboItemName)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.comboCustAddress)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.taCompliments)
        Me.Controls.Add(Me.taNotes)
        Me.Controls.Add(Me.taDisclaimer)
        Me.Controls.Add(Me.taDescription)
        Me.Controls.Add(Me.nudDiscount)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btnSet)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.comboType)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblPayable)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lblAmt)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblTotalDisc)
        Me.Controls.Add(Me.lblTotalAmt)
        Me.Controls.Add(Me.lblTotalPayable)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.lblTotalTax)
        Me.Controls.Add(Me.lblInvNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCustName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.itemGRID)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(1271, 516)
        Me.Name = "newinvoice2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NEW INVOICE GENERATION"
        Me.gridContext.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.itemGRID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents gridContext As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EDITToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DELETEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BillToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ITEMSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ITEMLISTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TOOLSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CALCULATORToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NOTESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSet As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents comboType As System.Windows.Forms.ComboBox
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblPayable As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblAmt As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblTotalDisc As System.Windows.Forms.Label
    Friend WithEvents lblTotalAmt As System.Windows.Forms.Label
    Friend WithEvents lblTotalPayable As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lblTotalTax As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCustName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents itemGRID As System.Windows.Forms.DataGridView
    Friend WithEvents nudDiscount As System.Windows.Forms.NumericUpDown
    Friend WithEvents taDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents taDisclaimer As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents taNotes As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents taCompliments As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents srno As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itemName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents itemType As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents qty As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents batch As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents rate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents totalAmt As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents discount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents payable As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comboCustAddress As System.Windows.Forms.ComboBox
    Friend WithEvents lblRate As System.Windows.Forms.TextBox
    Friend WithEvents txtUnit As System.Windows.Forms.TextBox
    Friend WithEvents comboItemName As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblInvNo As System.Windows.Forms.Label
End Class
