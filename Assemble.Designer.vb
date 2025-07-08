<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Assemble
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelF = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TakeAndReturnStencilBtnForm = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Tooling1Btn = New System.Windows.Forms.Button()
        Me.User = New System.Windows.Forms.Label()
        Me.deleteStencilBtnForm = New System.Windows.Forms.Button()
        Me.viewLogStencilBtn = New System.Windows.Forms.Button()
        Me.editStencilBtnForm = New System.Windows.Forms.Button()
        Me.addStencilBtnForm = New System.Windows.Forms.Button()
        Me.textBoxFindAssembly = New System.Windows.Forms.TextBox()
        Me.DataGridStencilDate = New System.Windows.Forms.DataGridView()
        Me.findAssemblyBtn = New System.Windows.Forms.Button()
        Me.StencilToolBtn = New System.Windows.Forms.Button()
        Me.Home = New System.Windows.Forms.Button()
        Me.toolingBtn = New System.Windows.Forms.Button()
        Me.viewDetailsBtnForm = New System.Windows.Forms.Button()
        Me.PanelF.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridStencilDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelF
        '
        Me.PanelF.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelF.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelF.Controls.Add(Me.Panel1)
        Me.PanelF.Controls.Add(Me.StencilToolBtn)
        Me.PanelF.Controls.Add(Me.Home)
        Me.PanelF.Controls.Add(Me.toolingBtn)
        Me.PanelF.Controls.Add(Me.viewDetailsBtnForm)
        Me.PanelF.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelF.ForeColor = System.Drawing.Color.ForestGreen
        Me.PanelF.Location = New System.Drawing.Point(0, 0)
        Me.PanelF.Name = "PanelF"
        Me.PanelF.Size = New System.Drawing.Size(611, 627)
        Me.PanelF.TabIndex = 39
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TakeAndReturnStencilBtnForm)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.deleteStencilBtnForm)
        Me.Panel1.Controls.Add(Me.viewLogStencilBtn)
        Me.Panel1.Controls.Add(Me.editStencilBtnForm)
        Me.Panel1.Controls.Add(Me.addStencilBtnForm)
        Me.Panel1.Controls.Add(Me.textBoxFindAssembly)
        Me.Panel1.Controls.Add(Me.DataGridStencilDate)
        Me.Panel1.Controls.Add(Me.findAssemblyBtn)
        Me.Panel1.Location = New System.Drawing.Point(5, 58)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(601, 557)
        Me.Panel1.TabIndex = 117
        '
        'TakeAndReturnStencilBtnForm
        '
        Me.TakeAndReturnStencilBtnForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TakeAndReturnStencilBtnForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.TakeAndReturnStencilBtnForm.FlatAppearance.BorderSize = 0
        Me.TakeAndReturnStencilBtnForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.TakeAndReturnStencilBtnForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.TakeAndReturnStencilBtnForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TakeAndReturnStencilBtnForm.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TakeAndReturnStencilBtnForm.ForeColor = System.Drawing.Color.White
        Me.TakeAndReturnStencilBtnForm.Location = New System.Drawing.Point(471, 68)
        Me.TakeAndReturnStencilBtnForm.Margin = New System.Windows.Forms.Padding(0)
        Me.TakeAndReturnStencilBtnForm.Name = "TakeAndReturnStencilBtnForm"
        Me.TakeAndReturnStencilBtnForm.Size = New System.Drawing.Size(123, 51)
        Me.TakeAndReturnStencilBtnForm.TabIndex = 66
        Me.TakeAndReturnStencilBtnForm.Text = "View Assembly"
        Me.TakeAndReturnStencilBtnForm.UseVisualStyleBackColor = False
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
        Me.Panel3.Size = New System.Drawing.Size(599, 58)
        Me.Panel3.TabIndex = 65
        '
        'Tooling1Btn
        '
        Me.Tooling1Btn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tooling1Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Tooling1Btn.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.Tooling1Btn.FlatAppearance.BorderSize = 3
        Me.Tooling1Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Tooling1Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Tooling1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tooling1Btn.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.Tooling1Btn.ForeColor = System.Drawing.Color.ForestGreen
        Me.Tooling1Btn.Location = New System.Drawing.Point(437, 11)
        Me.Tooling1Btn.Margin = New System.Windows.Forms.Padding(0)
        Me.Tooling1Btn.Name = "Tooling1Btn"
        Me.Tooling1Btn.Size = New System.Drawing.Size(156, 38)
        Me.Tooling1Btn.TabIndex = 111
        Me.Tooling1Btn.Text = "Assemblys"
        Me.Tooling1Btn.UseVisualStyleBackColor = False
        '
        'User
        '
        Me.User.AutoSize = True
        Me.User.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User.ForeColor = System.Drawing.Color.White
        Me.User.Location = New System.Drawing.Point(31, 17)
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
        Me.deleteStencilBtnForm.Location = New System.Drawing.Point(470, 298)
        Me.deleteStencilBtnForm.Margin = New System.Windows.Forms.Padding(0)
        Me.deleteStencilBtnForm.Name = "deleteStencilBtnForm"
        Me.deleteStencilBtnForm.Size = New System.Drawing.Size(123, 51)
        Me.deleteStencilBtnForm.TabIndex = 63
        Me.deleteStencilBtnForm.Text = "View Pallet Regular"
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
        Me.viewLogStencilBtn.Location = New System.Drawing.Point(470, 375)
        Me.viewLogStencilBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.viewLogStencilBtn.Name = "viewLogStencilBtn"
        Me.viewLogStencilBtn.Size = New System.Drawing.Size(123, 51)
        Me.viewLogStencilBtn.TabIndex = 62
        Me.viewLogStencilBtn.Text = "View Pallet Conformal"
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
        Me.editStencilBtnForm.Location = New System.Drawing.Point(470, 221)
        Me.editStencilBtnForm.Margin = New System.Windows.Forms.Padding(0)
        Me.editStencilBtnForm.Name = "editStencilBtnForm"
        Me.editStencilBtnForm.Size = New System.Drawing.Size(123, 51)
        Me.editStencilBtnForm.TabIndex = 61
        Me.editStencilBtnForm.Text = "View Pallet Selectiva"
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
        Me.addStencilBtnForm.Location = New System.Drawing.Point(470, 144)
        Me.addStencilBtnForm.Margin = New System.Windows.Forms.Padding(0)
        Me.addStencilBtnForm.Name = "addStencilBtnForm"
        Me.addStencilBtnForm.Size = New System.Drawing.Size(123, 51)
        Me.addStencilBtnForm.TabIndex = 60
        Me.addStencilBtnForm.Text = "View Stencil"
        Me.addStencilBtnForm.UseVisualStyleBackColor = False
        '
        'textBoxFindAssembly
        '
        Me.textBoxFindAssembly.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBoxFindAssembly.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.textBoxFindAssembly.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBoxFindAssembly.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxFindAssembly.ForeColor = System.Drawing.Color.ForestGreen
        Me.textBoxFindAssembly.Location = New System.Drawing.Point(10, 74)
        Me.textBoxFindAssembly.Margin = New System.Windows.Forms.Padding(4)
        Me.textBoxFindAssembly.MaximumSize = New System.Drawing.Size(300, 30)
        Me.textBoxFindAssembly.MinimumSize = New System.Drawing.Size(200, 15)
        Me.textBoxFindAssembly.Name = "textBoxFindAssembly"
        Me.textBoxFindAssembly.Size = New System.Drawing.Size(208, 26)
        Me.textBoxFindAssembly.TabIndex = 57
        Me.textBoxFindAssembly.Text = "Find Assembly"
        '
        'DataGridStencilDate
        '
        Me.DataGridStencilDate.AllowUserToAddRows = False
        Me.DataGridStencilDate.AllowUserToDeleteRows = False
        Me.DataGridStencilDate.AllowUserToOrderColumns = True
        Me.DataGridStencilDate.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridStencilDate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridStencilDate.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.DataGridStencilDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridStencilDate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridStencilDate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridStencilDate.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridStencilDate.EnableHeadersVisualStyles = False
        Me.DataGridStencilDate.Location = New System.Drawing.Point(5, 133)
        Me.DataGridStencilDate.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridStencilDate.Name = "DataGridStencilDate"
        Me.DataGridStencilDate.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridStencilDate.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridStencilDate.RowHeadersVisible = False
        Me.DataGridStencilDate.ShowEditingIcon = False
        Me.DataGridStencilDate.Size = New System.Drawing.Size(457, 414)
        Me.DataGridStencilDate.TabIndex = 59
        '
        'findAssemblyBtn
        '
        Me.findAssemblyBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.findAssemblyBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.findAssemblyBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.findAssemblyBtn.FlatAppearance.BorderSize = 0
        Me.findAssemblyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.findAssemblyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.findAssemblyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.findAssemblyBtn.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.findAssemblyBtn.ForeColor = System.Drawing.Color.White
        Me.findAssemblyBtn.Location = New System.Drawing.Point(339, 68)
        Me.findAssemblyBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.findAssemblyBtn.Name = "findAssemblyBtn"
        Me.findAssemblyBtn.Size = New System.Drawing.Size(123, 51)
        Me.findAssemblyBtn.TabIndex = 58
        Me.findAssemblyBtn.Text = "Find Assembly"
        Me.findAssemblyBtn.UseVisualStyleBackColor = False
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
        Me.StencilToolBtn.Text = "Assemblies"
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
        Me.toolingBtn.Text = "Setup"
        Me.toolingBtn.UseVisualStyleBackColor = False
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
        'Assemble
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 627)
        Me.Controls.Add(Me.PanelF)
        Me.Name = "Assemble"
        Me.Text = "Assemble"
        Me.PanelF.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridStencilDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelF As Panel
    Friend WithEvents StencilToolBtn As Button
    Friend WithEvents Home As Button
    Friend WithEvents toolingBtn As Button
    Friend WithEvents viewDetailsBtnForm As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TakeAndReturnStencilBtnForm As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Tooling1Btn As Button
    Friend WithEvents User As Label
    Friend WithEvents deleteStencilBtnForm As Button
    Friend WithEvents viewLogStencilBtn As Button
    Friend WithEvents editStencilBtnForm As Button
    Friend WithEvents addStencilBtnForm As Button
    Friend WithEvents textBoxFindAssembly As TextBox
    Friend WithEvents DataGridStencilDate As DataGridView
    Friend WithEvents findAssemblyBtn As Button
End Class
