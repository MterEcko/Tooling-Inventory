<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Squeege
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelF = New System.Windows.Forms.Panel()
        Me.StencilToolBtn = New System.Windows.Forms.Button()
        Me.Home = New System.Windows.Forms.Button()
        Me.toolingBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Tooling1Btn = New System.Windows.Forms.Button()
        Me.User = New System.Windows.Forms.Label()
        Me.deleteStencilBtnForm = New System.Windows.Forms.Button()
        Me.viewLogStencilBtn = New System.Windows.Forms.Button()
        Me.editStencilBtnForm = New System.Windows.Forms.Button()
        Me.addStencilBtnForm = New System.Windows.Forms.Button()
        Me.textBoxFindSqueegee = New System.Windows.Forms.TextBox()
        Me.DataGridSqueegeeDate = New System.Windows.Forms.DataGridView()
        Me.findStencilBtn = New System.Windows.Forms.Button()
        Me.viewDetailsBtnForm = New System.Windows.Forms.Button()
        Me.SelecStencil = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PanelF.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridSqueegeeDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelF
        '
        Me.PanelF.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelF.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelF.Controls.Add(Me.StencilToolBtn)
        Me.PanelF.Controls.Add(Me.Home)
        Me.PanelF.Controls.Add(Me.toolingBtn)
        Me.PanelF.Controls.Add(Me.Panel1)
        Me.PanelF.Controls.Add(Me.viewDetailsBtnForm)
        Me.PanelF.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelF.Location = New System.Drawing.Point(0, 0)
        Me.PanelF.Name = "PanelF"
        Me.PanelF.Size = New System.Drawing.Size(611, 627)
        Me.PanelF.TabIndex = 38
        '
        'StencilToolBtn
        '
        Me.StencilToolBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.StencilToolBtn.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.StencilToolBtn.FlatAppearance.BorderSize = 3
        Me.StencilToolBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.StencilToolBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.StencilToolBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StencilToolBtn.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.StencilToolBtn.ForeColor = System.Drawing.Color.ForestGreen
        Me.StencilToolBtn.Location = New System.Drawing.Point(231, 12)
        Me.StencilToolBtn.Name = "StencilToolBtn"
        Me.StencilToolBtn.Size = New System.Drawing.Size(103, 38)
        Me.StencilToolBtn.TabIndex = 116
        Me.StencilToolBtn.Text = "Squegue"
        Me.StencilToolBtn.UseVisualStyleBackColor = False
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
        Me.Home.TabIndex = 115
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
        Me.toolingBtn.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toolingBtn.ForeColor = System.Drawing.Color.ForestGreen
        Me.toolingBtn.Location = New System.Drawing.Point(122, 12)
        Me.toolingBtn.Name = "toolingBtn"
        Me.toolingBtn.Size = New System.Drawing.Size(103, 38)
        Me.toolingBtn.TabIndex = 114
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
        Me.Panel1.Controls.Add(Me.deleteStencilBtnForm)
        Me.Panel1.Controls.Add(Me.viewLogStencilBtn)
        Me.Panel1.Controls.Add(Me.editStencilBtnForm)
        Me.Panel1.Controls.Add(Me.addStencilBtnForm)
        Me.Panel1.Controls.Add(Me.textBoxFindSqueegee)
        Me.Panel1.Controls.Add(Me.DataGridSqueegeeDate)
        Me.Panel1.Controls.Add(Me.findStencilBtn)
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
        Me.Panel3.Controls.Add(Me.User)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(599, 47)
        Me.Panel3.TabIndex = 65
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
        'User
        '
        Me.User.AutoSize = True
        Me.User.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User.ForeColor = System.Drawing.Color.White
        Me.User.Location = New System.Drawing.Point(31, 14)
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(78, 19)
        Me.User.TabIndex = 109
        Me.User.Text = "Searchs..."
        '
        'deleteStencilBtnForm
        '
        Me.deleteStencilBtnForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.deleteStencilBtnForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.deleteStencilBtnForm.FlatAppearance.BorderSize = 0
        Me.deleteStencilBtnForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.deleteStencilBtnForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.deleteStencilBtnForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.deleteStencilBtnForm.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteStencilBtnForm.ForeColor = System.Drawing.Color.White
        Me.deleteStencilBtnForm.Location = New System.Drawing.Point(472, 288)
        Me.deleteStencilBtnForm.Margin = New System.Windows.Forms.Padding(0)
        Me.deleteStencilBtnForm.Name = "deleteStencilBtnForm"
        Me.deleteStencilBtnForm.Size = New System.Drawing.Size(123, 51)
        Me.deleteStencilBtnForm.TabIndex = 63
        Me.deleteStencilBtnForm.Text = "Delete Squeegee"
        Me.deleteStencilBtnForm.UseVisualStyleBackColor = False
        '
        'viewLogStencilBtn
        '
        Me.viewLogStencilBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.viewLogStencilBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.viewLogStencilBtn.FlatAppearance.BorderSize = 0
        Me.viewLogStencilBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.viewLogStencilBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.viewLogStencilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.viewLogStencilBtn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.viewLogStencilBtn.ForeColor = System.Drawing.Color.White
        Me.viewLogStencilBtn.Location = New System.Drawing.Point(472, 365)
        Me.viewLogStencilBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.viewLogStencilBtn.Name = "viewLogStencilBtn"
        Me.viewLogStencilBtn.Size = New System.Drawing.Size(123, 51)
        Me.viewLogStencilBtn.TabIndex = 62
        Me.viewLogStencilBtn.Text = "Log Stencil"
        Me.viewLogStencilBtn.UseVisualStyleBackColor = False
        '
        'editStencilBtnForm
        '
        Me.editStencilBtnForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editStencilBtnForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.editStencilBtnForm.FlatAppearance.BorderSize = 0
        Me.editStencilBtnForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.editStencilBtnForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.editStencilBtnForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editStencilBtnForm.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editStencilBtnForm.ForeColor = System.Drawing.Color.White
        Me.editStencilBtnForm.Location = New System.Drawing.Point(472, 211)
        Me.editStencilBtnForm.Margin = New System.Windows.Forms.Padding(0)
        Me.editStencilBtnForm.Name = "editStencilBtnForm"
        Me.editStencilBtnForm.Size = New System.Drawing.Size(123, 51)
        Me.editStencilBtnForm.TabIndex = 61
        Me.editStencilBtnForm.Text = "Editar Squeegee"
        Me.editStencilBtnForm.UseVisualStyleBackColor = False
        '
        'addStencilBtnForm
        '
        Me.addStencilBtnForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.addStencilBtnForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.addStencilBtnForm.FlatAppearance.BorderSize = 0
        Me.addStencilBtnForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.addStencilBtnForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.addStencilBtnForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addStencilBtnForm.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addStencilBtnForm.ForeColor = System.Drawing.Color.White
        Me.addStencilBtnForm.Location = New System.Drawing.Point(472, 134)
        Me.addStencilBtnForm.Margin = New System.Windows.Forms.Padding(0)
        Me.addStencilBtnForm.Name = "addStencilBtnForm"
        Me.addStencilBtnForm.Size = New System.Drawing.Size(123, 51)
        Me.addStencilBtnForm.TabIndex = 60
        Me.addStencilBtnForm.Text = "Add Squeegee"
        Me.addStencilBtnForm.UseVisualStyleBackColor = False
        '
        'textBoxFindSqueegee
        '
        Me.textBoxFindSqueegee.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBoxFindSqueegee.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.textBoxFindSqueegee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBoxFindSqueegee.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxFindSqueegee.ForeColor = System.Drawing.Color.ForestGreen
        Me.textBoxFindSqueegee.Location = New System.Drawing.Point(12, 64)
        Me.textBoxFindSqueegee.Margin = New System.Windows.Forms.Padding(4)
        Me.textBoxFindSqueegee.MaximumSize = New System.Drawing.Size(300, 30)
        Me.textBoxFindSqueegee.MinimumSize = New System.Drawing.Size(200, 15)
        Me.textBoxFindSqueegee.Name = "textBoxFindSqueegee"
        Me.textBoxFindSqueegee.Size = New System.Drawing.Size(208, 26)
        Me.textBoxFindSqueegee.TabIndex = 57
        Me.textBoxFindSqueegee.Text = "Find Squeegee"
        '
        'DataGridSqueegeeDate
        '
        Me.DataGridSqueegeeDate.AllowUserToAddRows = False
        Me.DataGridSqueegeeDate.AllowUserToDeleteRows = False
        Me.DataGridSqueegeeDate.AllowUserToOrderColumns = True
        Me.DataGridSqueegeeDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridSqueegeeDate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridSqueegeeDate.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.DataGridSqueegeeDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridSqueegeeDate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridSqueegeeDate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridSqueegeeDate.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridSqueegeeDate.EnableHeadersVisualStyles = False
        Me.DataGridSqueegeeDate.Location = New System.Drawing.Point(7, 123)
        Me.DataGridSqueegeeDate.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridSqueegeeDate.Name = "DataGridSqueegeeDate"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridSqueegeeDate.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridSqueegeeDate.RowHeadersVisible = False
        Me.DataGridSqueegeeDate.ShowEditingIcon = False
        Me.DataGridSqueegeeDate.Size = New System.Drawing.Size(457, 361)
        Me.DataGridSqueegeeDate.TabIndex = 59
        '
        'findStencilBtn
        '
        Me.findStencilBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.findStencilBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.findStencilBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.findStencilBtn.FlatAppearance.BorderSize = 0
        Me.findStencilBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.findStencilBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.findStencilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.findStencilBtn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.findStencilBtn.ForeColor = System.Drawing.Color.White
        Me.findStencilBtn.Location = New System.Drawing.Point(341, 58)
        Me.findStencilBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.findStencilBtn.Name = "findStencilBtn"
        Me.findStencilBtn.Size = New System.Drawing.Size(123, 51)
        Me.findStencilBtn.TabIndex = 58
        Me.findStencilBtn.Text = "Find squeegee"
        Me.findStencilBtn.UseVisualStyleBackColor = False
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
        Me.viewDetailsBtnForm.Location = New System.Drawing.Point(967, 395)
        Me.viewDetailsBtnForm.Margin = New System.Windows.Forms.Padding(0)
        Me.viewDetailsBtnForm.Name = "viewDetailsBtnForm"
        Me.viewDetailsBtnForm.Size = New System.Drawing.Size(123, 51)
        Me.viewDetailsBtnForm.TabIndex = 57
        Me.viewDetailsBtnForm.Text = "View details"
        Me.viewDetailsBtnForm.UseVisualStyleBackColor = False
        '
        'SelecStencil
        '
        Me.SelecStencil.FillWeight = 52.61037!
        Me.SelecStencil.HeaderText = "Select"
        Me.SelecStencil.Name = "SelecStencil"
        '
        'Squeege
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
        Me.Name = "Squeege"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stencil"
        Me.PanelF.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridSqueegeeDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelF As System.Windows.Forms.Panel
    Friend WithEvents viewDetailsBtnForm As System.Windows.Forms.Button
    Friend WithEvents SelecStencil As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents deleteStencilBtnForm As System.Windows.Forms.Button
    Friend WithEvents viewLogStencilBtn As System.Windows.Forms.Button
    Friend WithEvents editStencilBtnForm As System.Windows.Forms.Button
    Friend WithEvents addStencilBtnForm As System.Windows.Forms.Button
    Friend WithEvents textBoxFindSqueegee As System.Windows.Forms.TextBox
    Friend WithEvents findStencilBtn As System.Windows.Forms.Button
    Friend WithEvents Home As System.Windows.Forms.Button
    Friend WithEvents toolingBtn As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Tooling1Btn As System.Windows.Forms.Button
    Friend WithEvents User As System.Windows.Forms.Label
    Friend WithEvents StencilToolBtn As System.Windows.Forms.Button
    'Friend WithEvents StencilTableAdapter As GPV.GPVDataSetTableAdapters.StencilTableAdapter
    Friend WithEvents DataGridSqueegeeDate As DataGridView
End Class