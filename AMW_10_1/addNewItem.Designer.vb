<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addNewItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addNewItem))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.panalTitle = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblCross = New System.Windows.Forms.Label()
        Me.comboItem = New System.Windows.Forms.ComboBox()
        Me.lblItem = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblHead = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHSN = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCP = New System.Windows.Forms.NumericUpDown()
        Me.txtSP = New System.Windows.Forms.NumericUpDown()
        Me.txtWtPerPc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.panalTitle.SuspendLayout()
        CType(Me.txtCP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 28)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 271)
        Me.Panel3.TabIndex = 164
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(616, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(11, 271)
        Me.Panel2.TabIndex = 163
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 299)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(627, 11)
        Me.Panel4.TabIndex = 162
        '
        'panalTitle
        '
        Me.panalTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.panalTitle.Controls.Add(Me.Label8)
        Me.panalTitle.Controls.Add(Me.lblCross)
        Me.panalTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.panalTitle.Location = New System.Drawing.Point(0, 0)
        Me.panalTitle.Name = "panalTitle"
        Me.panalTitle.Size = New System.Drawing.Size(627, 28)
        Me.panalTitle.TabIndex = 161
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(9, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "ADD NEW ITEM"
        '
        'lblCross
        '
        Me.lblCross.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCross.AutoSize = True
        Me.lblCross.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCross.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblCross.Location = New System.Drawing.Point(598, 3)
        Me.lblCross.Name = "lblCross"
        Me.lblCross.Size = New System.Drawing.Size(26, 25)
        Me.lblCross.TabIndex = 0
        Me.lblCross.Text = "X"
        '
        'comboItem
        '
        Me.comboItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboItem.FormattingEnabled = True
        Me.comboItem.Location = New System.Drawing.Point(110, 87)
        Me.comboItem.Name = "comboItem"
        Me.comboItem.Size = New System.Drawing.Size(166, 21)
        Me.comboItem.TabIndex = 165
        Me.comboItem.Visible = False
        '
        'lblItem
        '
        Me.lblItem.AutoSize = True
        Me.lblItem.Location = New System.Drawing.Point(30, 91)
        Me.lblItem.Name = "lblItem"
        Me.lblItem.Size = New System.Drawing.Size(67, 13)
        Me.lblItem.TabIndex = 166
        Me.lblItem.Text = "ITEM NAME"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(110, 88)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(166, 20)
        Me.txtName.TabIndex = 1
        Me.txtName.Visible = False
        '
        'txtType
        '
        Me.txtType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtType.Location = New System.Drawing.Point(435, 87)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(155, 20)
        Me.txtType.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(342, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 166
        Me.Label1.Text = "ITEM TYPE"
        '
        'lblHead
        '
        Me.lblHead.AutoSize = True
        Me.lblHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHead.Location = New System.Drawing.Point(229, 43)
        Me.lblHead.Name = "lblHead"
        Me.lblHead.Size = New System.Drawing.Size(127, 20)
        Me.lblHead.TabIndex = 166
        Me.lblHead.Text = "ADD NEW ITEM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 166
        Me.Label2.Text = "Quantity"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(110, 125)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(166, 20)
        Me.txtQty.TabIndex = 3
        Me.txtQty.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(376, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 166
        Me.Label3.Text = "HSN"
        '
        'txtHSN
        '
        Me.txtHSN.Location = New System.Drawing.Point(435, 124)
        Me.txtHSN.Name = "txtHSN"
        Me.txtHSN.Size = New System.Drawing.Size(155, 20)
        Me.txtHSN.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 166
        Me.Label4.Text = "C/P PER PIECE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(321, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 166
        Me.Label5.Text = "S/P PER PIECE"
        '
        'txtCP
        '
        Me.txtCP.DecimalPlaces = 2
        Me.txtCP.Location = New System.Drawing.Point(110, 161)
        Me.txtCP.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(166, 20)
        Me.txtCP.TabIndex = 5
        '
        'txtSP
        '
        Me.txtSP.DecimalPlaces = 2
        Me.txtSP.Location = New System.Drawing.Point(435, 160)
        Me.txtSP.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.txtSP.Name = "txtSP"
        Me.txtSP.Size = New System.Drawing.Size(155, 20)
        Me.txtSP.TabIndex = 6
        Me.txtSP.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtWtPerPc
        '
        Me.txtWtPerPc.Location = New System.Drawing.Point(110, 205)
        Me.txtWtPerPc.Name = "txtWtPerPc"
        Me.txtWtPerPc.Size = New System.Drawing.Size(166, 20)
        Me.txtWtPerPc.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 166
        Me.Label6.Text = "KG PER PC"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(326, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 166
        Me.Label7.Text = "DESCRIPTION"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(435, 205)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(155, 40)
        Me.txtDescription.TabIndex = 8
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAdd.Location = New System.Drawing.Point(217, 247)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 34)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnReset.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnReset.Location = New System.Drawing.Point(324, 247)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 34)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "RESET"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'addNewItem
        '
        Me.AcceptButton = Me.btnAdd
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 310)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.txtWtPerPc)
        Me.Controls.Add(Me.txtSP)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtHSN)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblHead)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblItem)
        Me.Controls.Add(Me.comboItem)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.panalTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "addNewItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addNewItem"
        Me.panalTitle.ResumeLayout(False)
        Me.panalTitle.PerformLayout()
        CType(Me.txtCP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents panalTitle As System.Windows.Forms.Panel
    Friend WithEvents lblCross As System.Windows.Forms.Label
    Friend WithEvents comboItem As System.Windows.Forms.ComboBox
    Friend WithEvents lblItem As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblHead As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtHSN As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCP As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtSP As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtWtPerPc As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
