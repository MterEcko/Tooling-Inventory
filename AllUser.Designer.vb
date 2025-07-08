<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class alluser
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
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelF = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.textBoxFindUser = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.HomeBtn = New System.Windows.Forms.Button()
        Me.User = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.allUserTable = New System.Windows.Forms.TabPage()
        Me.aplicar = New System.Windows.Forms.Button()
        Me.EjectOptionAllComboBox = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AddUserBtnForm = New System.Windows.Forms.Button()
        Me.superUserTable = New System.Windows.Forms.TabPage()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Home = New System.Windows.Forms.Button()
        Me.allUserBtn = New System.Windows.Forms.Button()
        Me.viewDetailsBtnForm = New System.Windows.Forms.Button()
        Me.PanelF.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.allUserTable.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.superUserTable.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelF
        '
        Me.PanelF.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelF.Controls.Add(Me.Panel1)
        Me.PanelF.Controls.Add(Me.Home)
        Me.PanelF.Controls.Add(Me.allUserBtn)
        Me.PanelF.Controls.Add(Me.viewDetailsBtnForm)
        Me.PanelF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelF.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelF.Location = New System.Drawing.Point(0, 0)
        Me.PanelF.Margin = New System.Windows.Forms.Padding(4)
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
        Me.Panel1.Controls.Add(Me.textBoxFindUser)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Panel1.Location = New System.Drawing.Point(5, 58)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(601, 557)
        Me.Panel1.TabIndex = 131
        '
        'textBoxFindUser
        '
        Me.textBoxFindUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBoxFindUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.textBoxFindUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBoxFindUser.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxFindUser.ForeColor = System.Drawing.Color.ForestGreen
        Me.textBoxFindUser.Location = New System.Drawing.Point(373, 57)
        Me.textBoxFindUser.Margin = New System.Windows.Forms.Padding(4)
        Me.textBoxFindUser.MaximumSize = New System.Drawing.Size(300, 30)
        Me.textBoxFindUser.MinimumSize = New System.Drawing.Size(200, 15)
        Me.textBoxFindUser.Name = "textBoxFindUser"
        Me.textBoxFindUser.Size = New System.Drawing.Size(224, 26)
        Me.textBoxFindUser.TabIndex = 135
        Me.textBoxFindUser.Text = "Find User"
        '
        'Panel3
        '
        Me.Panel3.AutoSize = True
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Panel3.Controls.Add(Me.HomeBtn)
        Me.Panel3.Controls.Add(Me.User)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(599, 47)
        Me.Panel3.TabIndex = 133
        '
        'HomeBtn
        '
        Me.HomeBtn.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HomeBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.HomeBtn.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.HomeBtn.FlatAppearance.BorderSize = 3
        Me.HomeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.HomeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.HomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.HomeBtn.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.HomeBtn.ForeColor = System.Drawing.Color.ForestGreen
        Me.HomeBtn.Location = New System.Drawing.Point(436, 6)
        Me.HomeBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.HomeBtn.Name = "HomeBtn"
        Me.HomeBtn.Size = New System.Drawing.Size(156, 38)
        Me.HomeBtn.TabIndex = 111
        Me.HomeBtn.Text = "Home"
        Me.HomeBtn.UseVisualStyleBackColor = False
        '
        'User
        '
        Me.User.AutoSize = True
        Me.User.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.User.ForeColor = System.Drawing.Color.White
        Me.User.Location = New System.Drawing.Point(31, 17)
        Me.User.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.User.Name = "User"
        Me.User.Size = New System.Drawing.Size(66, 19)
        Me.User.TabIndex = 109
        Me.User.Text = "Medidas"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.allUserTable)
        Me.TabControl1.Controls.Add(Me.superUserTable)
        Me.TabControl1.Location = New System.Drawing.Point(4, 68)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(595, 476)
        Me.TabControl1.TabIndex = 134
        '
        'allUserTable
        '
        Me.allUserTable.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.allUserTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.allUserTable.Controls.Add(Me.aplicar)
        Me.allUserTable.Controls.Add(Me.EjectOptionAllComboBox)
        Me.allUserTable.Controls.Add(Me.DataGridView1)
        Me.allUserTable.Controls.Add(Me.AddUserBtnForm)
        Me.allUserTable.ForeColor = System.Drawing.Color.ForestGreen
        Me.allUserTable.Location = New System.Drawing.Point(4, 28)
        Me.allUserTable.Margin = New System.Windows.Forms.Padding(4)
        Me.allUserTable.Name = "allUserTable"
        Me.allUserTable.Padding = New System.Windows.Forms.Padding(4)
        Me.allUserTable.Size = New System.Drawing.Size(587, 444)
        Me.allUserTable.TabIndex = 0
        Me.allUserTable.Text = "All"
        '
        'aplicar
        '
        Me.aplicar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.aplicar.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.aplicar.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.aplicar.FlatAppearance.BorderSize = 3
        Me.aplicar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.aplicar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.aplicar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.aplicar.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.aplicar.ForeColor = System.Drawing.Color.ForestGreen
        Me.aplicar.Location = New System.Drawing.Point(106, 397)
        Me.aplicar.Name = "aplicar"
        Me.aplicar.Size = New System.Drawing.Size(122, 38)
        Me.aplicar.TabIndex = 105
        Me.aplicar.Text = "Aplicar"
        Me.aplicar.UseVisualStyleBackColor = False
        '
        'EjectOptionAllComboBox
        '
        Me.EjectOptionAllComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.EjectOptionAllComboBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.EjectOptionAllComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.EjectOptionAllComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EjectOptionAllComboBox.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.EjectOptionAllComboBox.ForeColor = System.Drawing.Color.ForestGreen
        Me.EjectOptionAllComboBox.FormattingEnabled = True
        Me.EjectOptionAllComboBox.Items.AddRange(New Object() {"Seleccione accion", "Delete user", "Log user"})
        Me.EjectOptionAllComboBox.Location = New System.Drawing.Point(4, 361)
        Me.EjectOptionAllComboBox.Margin = New System.Windows.Forms.Padding(0)
        Me.EjectOptionAllComboBox.MaximumSize = New System.Drawing.Size(224, 0)
        Me.EjectOptionAllComboBox.MinimumSize = New System.Drawing.Size(224, 0)
        Me.EjectOptionAllComboBox.Name = "EjectOptionAllComboBox"
        Me.EjectOptionAllComboBox.Size = New System.Drawing.Size(224, 27)
        Me.EjectOptionAllComboBox.TabIndex = 104
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Tahoma", 12.0!)
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(4, 19)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Tahoma", 12.0!)
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.Size = New System.Drawing.Size(577, 323)
        Me.DataGridView1.TabIndex = 46
        '
        'AddUserBtnForm
        '
        Me.AddUserBtnForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddUserBtnForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.AddUserBtnForm.FlatAppearance.BorderSize = 0
        Me.AddUserBtnForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.AddUserBtnForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.AddUserBtnForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddUserBtnForm.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddUserBtnForm.ForeColor = System.Drawing.Color.White
        Me.AddUserBtnForm.Location = New System.Drawing.Point(370, 396)
        Me.AddUserBtnForm.Margin = New System.Windows.Forms.Padding(5)
        Me.AddUserBtnForm.MaximumSize = New System.Drawing.Size(440, 78)
        Me.AddUserBtnForm.Name = "AddUserBtnForm"
        Me.AddUserBtnForm.Size = New System.Drawing.Size(206, 42)
        Me.AddUserBtnForm.TabIndex = 54
        Me.AddUserBtnForm.Text = "Editar user"
        Me.AddUserBtnForm.UseVisualStyleBackColor = False
        '
        'superUserTable
        '
        Me.superUserTable.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.superUserTable.Controls.Add(Me.Button2)
        Me.superUserTable.Controls.Add(Me.Button1)
        Me.superUserTable.Controls.Add(Me.ComboBox1)
        Me.superUserTable.Controls.Add(Me.DataGridView2)
        Me.superUserTable.ForeColor = System.Drawing.Color.ForestGreen
        Me.superUserTable.Location = New System.Drawing.Point(4, 28)
        Me.superUserTable.Margin = New System.Windows.Forms.Padding(4)
        Me.superUserTable.Name = "superUserTable"
        Me.superUserTable.Padding = New System.Windows.Forms.Padding(4)
        Me.superUserTable.Size = New System.Drawing.Size(587, 444)
        Me.superUserTable.TabIndex = 1
        Me.superUserTable.Text = "Super User"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(413, 389)
        Me.Button2.Margin = New System.Windows.Forms.Padding(0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(159, 41)
        Me.Button2.TabIndex = 109
        Me.Button2.Text = "Editar user"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.Button1.FlatAppearance.BorderSize = 3
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.Button1.ForeColor = System.Drawing.Color.ForestGreen
        Me.Button1.Location = New System.Drawing.Point(280, 386)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 44)
        Me.Button1.TabIndex = 108
        Me.Button1.Text = "Aplicar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.ComboBox1.ForeColor = System.Drawing.Color.ForestGreen
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Seleccione accion", "Delete user", "Log user"})
        Me.ComboBox1.Location = New System.Drawing.Point(16, 403)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.ComboBox1.MaximumSize = New System.Drawing.Size(224, 0)
        Me.ComboBox1.MinimumSize = New System.Drawing.Size(224, 0)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(224, 27)
        Me.ComboBox1.TabIndex = 107
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Tahoma", 12.0!)
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Location = New System.Drawing.Point(4, 19)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridView2.Name = "DataGridView2"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Tahoma", 12.0!)
        DataGridViewCellStyle20.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridView2.RowHeadersVisible = False
        Me.DataGridView2.ShowEditingIcon = False
        Me.DataGridView2.Size = New System.Drawing.Size(577, 346)
        Me.DataGridView2.TabIndex = 47
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
        Me.Home.TabIndex = 129
        Me.Home.Text = "Home"
        Me.Home.UseVisualStyleBackColor = False
        '
        'allUserBtn
        '
        Me.allUserBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.allUserBtn.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.allUserBtn.FlatAppearance.BorderSize = 3
        Me.allUserBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.allUserBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.allUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.allUserBtn.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.allUserBtn.ForeColor = System.Drawing.Color.ForestGreen
        Me.allUserBtn.Location = New System.Drawing.Point(122, 12)
        Me.allUserBtn.Name = "allUserBtn"
        Me.allUserBtn.Size = New System.Drawing.Size(103, 38)
        Me.allUserBtn.TabIndex = 128
        Me.allUserBtn.Text = "All users"
        Me.allUserBtn.UseVisualStyleBackColor = False
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
        'alluser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 627)
        Me.Controls.Add(Me.PanelF)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.ForeColor = System.Drawing.Color.ForestGreen
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "alluser"
        Me.Text = "panelmanageruser"
        Me.PanelF.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.allUserTable.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.superUserTable.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelF As System.Windows.Forms.Panel
    Friend WithEvents viewDetailsBtnForm As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents allUserTable As System.Windows.Forms.TabPage
    Friend WithEvents aplicar As System.Windows.Forms.Button
    Friend WithEvents EjectOptionAllComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents AddUserBtnForm As System.Windows.Forms.Button
    Friend WithEvents superUserTable As System.Windows.Forms.TabPage
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents HomeBtn As System.Windows.Forms.Button
    Friend WithEvents User As System.Windows.Forms.Label
    Friend WithEvents Home As System.Windows.Forms.Button
    Friend WithEvents allUserBtn As System.Windows.Forms.Button
    Friend WithEvents textBoxFindUser As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox1 As ComboBox
End Class
