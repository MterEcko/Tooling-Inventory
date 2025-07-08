<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pallet
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelF = New System.Windows.Forms.Panel()
        Me.PalletsToolBtn = New System.Windows.Forms.Button()
        Me.Home = New System.Windows.Forms.Button()
        Me.toolingBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Tooling1Btn = New System.Windows.Forms.Button()
        Me.SearchPallet = New System.Windows.Forms.Label()
        Me.deletePalletBtnForm = New System.Windows.Forms.Button()
        Me.viewLogPalletBtn = New System.Windows.Forms.Button()
        Me.editPalletBtnForm = New System.Windows.Forms.Button()
        Me.addPalletBtnForm = New System.Windows.Forms.Button()
        Me.TextBoxFindPallet = New System.Windows.Forms.TextBox()
        Me.DataGridPalletDate = New System.Windows.Forms.DataGridView()
        Me.findPalletBtn = New System.Windows.Forms.Button()
        Me.viewDetailsBtnForm = New System.Windows.Forms.Button()
        Me.PanelF.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridPalletDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelF
        '
        Me.PanelF.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelF.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelF.Controls.Add(Me.PalletsToolBtn)
        Me.PanelF.Controls.Add(Me.Home)
        Me.PanelF.Controls.Add(Me.toolingBtn)
        Me.PanelF.Controls.Add(Me.Panel1)
        Me.PanelF.Controls.Add(Me.viewDetailsBtnForm)
        Me.PanelF.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelF.Location = New System.Drawing.Point(0, 0)
        Me.PanelF.Name = "PanelF"
        Me.PanelF.Size = New System.Drawing.Size(611, 627)
        Me.PanelF.TabIndex = 40
        '
        'PalletsToolBtn
        '
        Me.PalletsToolBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PalletsToolBtn.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.PalletsToolBtn.FlatAppearance.BorderSize = 3
        Me.PalletsToolBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PalletsToolBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PalletsToolBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PalletsToolBtn.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.PalletsToolBtn.ForeColor = System.Drawing.Color.ForestGreen
        Me.PalletsToolBtn.Location = New System.Drawing.Point(231, 12)
        Me.PalletsToolBtn.Name = "PalletsToolBtn"
        Me.PalletsToolBtn.Size = New System.Drawing.Size(103, 38)
        Me.PalletsToolBtn.TabIndex = 117
        Me.PalletsToolBtn.Text = "Pallets"
        Me.PalletsToolBtn.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.Home.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Home.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.Home.FlatAppearance.BorderSize = 3
        Me.Home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Home.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.Home.ForeColor = System.Drawing.Color.ForestGreen
        Me.Home.Location = New System.Drawing.Point(13, 12)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(103, 38)
        Me.Home.TabIndex = 116
        Me.Home.Text = "Home"
        Me.Home.UseVisualStyleBackColor = False
        '
        'toolingBtn
        '
        Me.toolingBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.toolingBtn.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.toolingBtn.FlatAppearance.BorderSize = 3
        Me.toolingBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.toolingBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.toolingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.toolingBtn.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.toolingBtn.ForeColor = System.Drawing.Color.ForestGreen
        Me.toolingBtn.Location = New System.Drawing.Point(122, 12)
        Me.toolingBtn.Name = "toolingBtn"
        Me.toolingBtn.Size = New System.Drawing.Size(103, 38)
        Me.toolingBtn.TabIndex = 115
        Me.toolingBtn.Text = "Tooling"
        Me.toolingBtn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.deletePalletBtnForm)
        Me.Panel1.Controls.Add(Me.viewLogPalletBtn)
        Me.Panel1.Controls.Add(Me.editPalletBtnForm)
        Me.Panel1.Controls.Add(Me.addPalletBtnForm)
        Me.Panel1.Controls.Add(Me.TextBoxFindPallet)
        Me.Panel1.Controls.Add(Me.DataGridPalletDate)
        Me.Panel1.Controls.Add(Me.findPalletBtn)
        Me.Panel1.Location = New System.Drawing.Point(5, 58)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(601, 557)
        Me.Panel1.TabIndex = 58
        '
        'Panel3
        '
        Me.Panel3.AutoSize = True
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Tooling1Btn)
        Me.Panel3.Controls.Add(Me.SearchPallet)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(599, 47)
        Me.Panel3.TabIndex = 67
        '
        'Tooling1Btn
        '
        Me.Tooling1Btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tooling1Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Tooling1Btn.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.Tooling1Btn.FlatAppearance.BorderSize = 3
        Me.Tooling1Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Tooling1Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Tooling1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tooling1Btn.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.Tooling1Btn.ForeColor = System.Drawing.Color.ForestGreen
        Me.Tooling1Btn.Location = New System.Drawing.Point(439, 6)
        Me.Tooling1Btn.Name = "Tooling1Btn"
        Me.Tooling1Btn.Size = New System.Drawing.Size(156, 38)
        Me.Tooling1Btn.TabIndex = 111
        Me.Tooling1Btn.Text = "Tooling"
        Me.Tooling1Btn.UseVisualStyleBackColor = False
        '
        'SearchPallet
        '
        Me.SearchPallet.AutoSize = True
        Me.SearchPallet.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchPallet.ForeColor = System.Drawing.Color.White
        Me.SearchPallet.Location = New System.Drawing.Point(31, 14)
        Me.SearchPallet.Name = "SearchPallet"
        Me.SearchPallet.Size = New System.Drawing.Size(78, 19)
        Me.SearchPallet.TabIndex = 109
        Me.SearchPallet.Text = "Searchs..."
        '
        'deletePalletBtnForm
        '
        Me.deletePalletBtnForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.deletePalletBtnForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.deletePalletBtnForm.FlatAppearance.BorderSize = 0
        Me.deletePalletBtnForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.deletePalletBtnForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.deletePalletBtnForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deletePalletBtnForm.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deletePalletBtnForm.ForeColor = System.Drawing.Color.White
        Me.deletePalletBtnForm.Location = New System.Drawing.Point(472, 212)
        Me.deletePalletBtnForm.Margin = New System.Windows.Forms.Padding(0)
        Me.deletePalletBtnForm.Name = "deletePalletBtnForm"
        Me.deletePalletBtnForm.Size = New System.Drawing.Size(123, 51)
        Me.deletePalletBtnForm.TabIndex = 63
        Me.deletePalletBtnForm.Text = "Delete Pallet"
        Me.deletePalletBtnForm.UseVisualStyleBackColor = False
        '
        'viewLogPalletBtn
        '
        Me.viewLogPalletBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewLogPalletBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.viewLogPalletBtn.FlatAppearance.BorderSize = 0
        Me.viewLogPalletBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.viewLogPalletBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.viewLogPalletBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.viewLogPalletBtn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewLogPalletBtn.ForeColor = System.Drawing.Color.White
        Me.viewLogPalletBtn.Location = New System.Drawing.Point(472, 289)
        Me.viewLogPalletBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.viewLogPalletBtn.Name = "viewLogPalletBtn"
        Me.viewLogPalletBtn.Size = New System.Drawing.Size(123, 51)
        Me.viewLogPalletBtn.TabIndex = 62
        Me.viewLogPalletBtn.Text = "Log Pallet"
        Me.viewLogPalletBtn.UseVisualStyleBackColor = False
        '
        'editPalletBtnForm
        '
        Me.editPalletBtnForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editPalletBtnForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.editPalletBtnForm.FlatAppearance.BorderSize = 0
        Me.editPalletBtnForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.editPalletBtnForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.editPalletBtnForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editPalletBtnForm.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editPalletBtnForm.ForeColor = System.Drawing.Color.White
        Me.editPalletBtnForm.Location = New System.Drawing.Point(472, 135)
        Me.editPalletBtnForm.Margin = New System.Windows.Forms.Padding(0)
        Me.editPalletBtnForm.Name = "editPalletBtnForm"
        Me.editPalletBtnForm.Size = New System.Drawing.Size(123, 51)
        Me.editPalletBtnForm.TabIndex = 61
        Me.editPalletBtnForm.Text = "Editar Pallet"
        Me.editPalletBtnForm.UseVisualStyleBackColor = False
        '
        'addPalletBtnForm
        '
        Me.addPalletBtnForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addPalletBtnForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.addPalletBtnForm.FlatAppearance.BorderSize = 0
        Me.addPalletBtnForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.addPalletBtnForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.addPalletBtnForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addPalletBtnForm.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addPalletBtnForm.ForeColor = System.Drawing.Color.White
        Me.addPalletBtnForm.Location = New System.Drawing.Point(472, 58)
        Me.addPalletBtnForm.Margin = New System.Windows.Forms.Padding(0)
        Me.addPalletBtnForm.Name = "addPalletBtnForm"
        Me.addPalletBtnForm.Size = New System.Drawing.Size(123, 51)
        Me.addPalletBtnForm.TabIndex = 60
        Me.addPalletBtnForm.Text = "Add Pallet"
        Me.addPalletBtnForm.UseVisualStyleBackColor = False
        '
        'TextBoxFindPallet
        '
        Me.TextBoxFindPallet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxFindPallet.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.TextBoxFindPallet.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxFindPallet.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxFindPallet.ForeColor = System.Drawing.Color.ForestGreen
        Me.TextBoxFindPallet.Location = New System.Drawing.Point(12, 64)
        Me.TextBoxFindPallet.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxFindPallet.MaximumSize = New System.Drawing.Size(400, 30)
        Me.TextBoxFindPallet.MinimumSize = New System.Drawing.Size(280, 15)
        Me.TextBoxFindPallet.Name = "TextBoxFindPallet"
        Me.TextBoxFindPallet.Size = New System.Drawing.Size(280, 26)
        Me.TextBoxFindPallet.TabIndex = 57
        Me.TextBoxFindPallet.Text = "Find Pallet"
        '
        'DataGridPalletDate
        '
        Me.DataGridPalletDate.AllowUserToAddRows = False
        Me.DataGridPalletDate.AllowUserToDeleteRows = False
        Me.DataGridPalletDate.AllowUserToOrderColumns = True
        Me.DataGridPalletDate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridPalletDate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridPalletDate.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.DataGridPalletDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridPalletDate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridPalletDate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridPalletDate.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridPalletDate.EnableHeadersVisualStyles = False
        Me.DataGridPalletDate.Location = New System.Drawing.Point(7, 123)
        Me.DataGridPalletDate.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridPalletDate.Name = "DataGridPalletDate"
        Me.DataGridPalletDate.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridPalletDate.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridPalletDate.RowHeadersVisible = False
        Me.DataGridPalletDate.ShowEditingIcon = False
        Me.DataGridPalletDate.Size = New System.Drawing.Size(457, 414)
        Me.DataGridPalletDate.TabIndex = 59
        '
        'findPalletBtn
        '
        Me.findPalletBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.findPalletBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.findPalletBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.findPalletBtn.FlatAppearance.BorderSize = 0
        Me.findPalletBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.findPalletBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.findPalletBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.findPalletBtn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.findPalletBtn.ForeColor = System.Drawing.Color.White
        Me.findPalletBtn.Location = New System.Drawing.Point(341, 58)
        Me.findPalletBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.findPalletBtn.Name = "findPalletBtn"
        Me.findPalletBtn.Size = New System.Drawing.Size(123, 51)
        Me.findPalletBtn.TabIndex = 58
        Me.findPalletBtn.Text = "Find pallet"
        Me.findPalletBtn.UseVisualStyleBackColor = False
        '
        'viewDetailsBtnForm
        '
        Me.viewDetailsBtnForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewDetailsBtnForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.viewDetailsBtnForm.FlatAppearance.BorderSize = 0
        Me.viewDetailsBtnForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.viewDetailsBtnForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.viewDetailsBtnForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.viewDetailsBtnForm.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewDetailsBtnForm.ForeColor = System.Drawing.Color.White
        Me.viewDetailsBtnForm.Location = New System.Drawing.Point(1085, 486)
        Me.viewDetailsBtnForm.Margin = New System.Windows.Forms.Padding(0)
        Me.viewDetailsBtnForm.Name = "viewDetailsBtnForm"
        Me.viewDetailsBtnForm.Size = New System.Drawing.Size(164, 63)
        Me.viewDetailsBtnForm.TabIndex = 57
        Me.viewDetailsBtnForm.Text = "View details"
        Me.viewDetailsBtnForm.UseVisualStyleBackColor = False
        '
        'pallet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(611, 627)
        Me.Controls.Add(Me.PanelF)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.ForestGreen
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "pallet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "a"
        Me.PanelF.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridPalletDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelF As System.Windows.Forms.Panel
    Friend WithEvents viewDetailsBtnForm As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents deletePalletBtnForm As System.Windows.Forms.Button
    Friend WithEvents viewLogPalletBtn As System.Windows.Forms.Button
    Friend WithEvents editPalletBtnForm As System.Windows.Forms.Button
    Friend WithEvents addPalletBtnForm As System.Windows.Forms.Button
    Friend WithEvents TextBoxFindPallet As System.Windows.Forms.TextBox
    Friend WithEvents DataGridPalletDate As System.Windows.Forms.DataGridView
    Friend WithEvents findPalletBtn As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Tooling1Btn As System.Windows.Forms.Button
    Friend WithEvents SearchPallet As System.Windows.Forms.Label
    Friend WithEvents PalletsToolBtn As System.Windows.Forms.Button
    Friend WithEvents Home As System.Windows.Forms.Button
    Friend WithEvents toolingBtn As System.Windows.Forms.Button
End Class
