<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class logstencilform
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelF = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonFindLogStencil = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.StencilTool1Btn = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.generateGrafic = New System.Windows.Forms.Button()
        Me.textBoxLogStencil = New System.Windows.Forms.TextBox()
        Me.downloadLog = New System.Windows.Forms.Button()
        Me.logStencilBtn = New System.Windows.Forms.Button()
        Me.StencilToolBtn = New System.Windows.Forms.Button()
        Me.Home = New System.Windows.Forms.Button()
        Me.toolingBtn = New System.Windows.Forms.Button()
        Me.PanelF.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelF
        '
        Me.PanelF.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PanelF.Controls.Add(Me.Panel1)
        Me.PanelF.Controls.Add(Me.logStencilBtn)
        Me.PanelF.Controls.Add(Me.StencilToolBtn)
        Me.PanelF.Controls.Add(Me.Home)
        Me.PanelF.Controls.Add(Me.toolingBtn)
        Me.PanelF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelF.Location = New System.Drawing.Point(0, 0)
        Me.PanelF.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelF.Name = "PanelF"
        Me.PanelF.Size = New System.Drawing.Size(611, 627)
        Me.PanelF.TabIndex = 42
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ButtonFindLogStencil)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.DataGridView2)
        Me.Panel1.Controls.Add(Me.generateGrafic)
        Me.Panel1.Controls.Add(Me.textBoxLogStencil)
        Me.Panel1.Controls.Add(Me.downloadLog)
        Me.Panel1.Location = New System.Drawing.Point(5, 58)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(20)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(601, 557)
        Me.Panel1.TabIndex = 129
        '
        'ButtonFindLogStencil
        '
        Me.ButtonFindLogStencil.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonFindLogStencil.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ButtonFindLogStencil.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ButtonFindLogStencil.FlatAppearance.BorderSize = 0
        Me.ButtonFindLogStencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.ButtonFindLogStencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.ButtonFindLogStencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonFindLogStencil.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFindLogStencil.ForeColor = System.Drawing.Color.White
        Me.ButtonFindLogStencil.Location = New System.Drawing.Point(221, 58)
        Me.ButtonFindLogStencil.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtonFindLogStencil.Name = "ButtonFindLogStencil"
        Me.ButtonFindLogStencil.Size = New System.Drawing.Size(114, 34)
        Me.ButtonFindLogStencil.TabIndex = 139
        Me.ButtonFindLogStencil.Text = "Find"
        Me.ButtonFindLogStencil.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.AutoSize = True
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Panel3.Controls.Add(Me.StencilTool1Btn)
        Me.Panel3.Controls.Add(Me.edit)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(599, 47)
        Me.Panel3.TabIndex = 138
        '
        'StencilTool1Btn
        '
        Me.StencilTool1Btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StencilTool1Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.StencilTool1Btn.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.StencilTool1Btn.FlatAppearance.BorderSize = 3
        Me.StencilTool1Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.StencilTool1Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.StencilTool1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StencilTool1Btn.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.StencilTool1Btn.ForeColor = System.Drawing.Color.ForestGreen
        Me.StencilTool1Btn.Location = New System.Drawing.Point(439, 6)
        Me.StencilTool1Btn.Name = "StencilTool1Btn"
        Me.StencilTool1Btn.Size = New System.Drawing.Size(156, 38)
        Me.StencilTool1Btn.TabIndex = 111
        Me.StencilTool1Btn.Text = "Stencil"
        Me.StencilTool1Btn.UseVisualStyleBackColor = False
        '
        'edit
        '
        Me.edit.AutoSize = True
        Me.edit.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit.ForeColor = System.Drawing.Color.White
        Me.edit.Location = New System.Drawing.Point(31, 14)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(86, 19)
        Me.edit.TabIndex = 109
        Me.edit.Text = "Log Stencil"
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(42, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Location = New System.Drawing.Point(16, 108)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridView2.Name = "DataGridView2"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.Size = New System.Drawing.Size(566, 426)
        Me.DataGridView2.TabIndex = 58
        '
        'generateGrafic
        '
        Me.generateGrafic.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.generateGrafic.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.generateGrafic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.generateGrafic.FlatAppearance.BorderSize = 0
        Me.generateGrafic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.generateGrafic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.generateGrafic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.generateGrafic.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.generateGrafic.ForeColor = System.Drawing.Color.White
        Me.generateGrafic.Location = New System.Drawing.Point(468, 58)
        Me.generateGrafic.Margin = New System.Windows.Forms.Padding(5)
        Me.generateGrafic.Name = "generateGrafic"
        Me.generateGrafic.Size = New System.Drawing.Size(114, 34)
        Me.generateGrafic.TabIndex = 57
        Me.generateGrafic.Text = "Graficar"
        Me.generateGrafic.UseVisualStyleBackColor = False
        '
        'textBoxLogStencil
        '
        Me.textBoxLogStencil.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBoxLogStencil.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.textBoxLogStencil.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBoxLogStencil.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxLogStencil.ForeColor = System.Drawing.Color.ForestGreen
        Me.textBoxLogStencil.Location = New System.Drawing.Point(16, 61)
        Me.textBoxLogStencil.Margin = New System.Windows.Forms.Padding(5)
        Me.textBoxLogStencil.MaximumSize = New System.Drawing.Size(400, 30)
        Me.textBoxLogStencil.MinimumSize = New System.Drawing.Size(267, 15)
        Me.textBoxLogStencil.Name = "textBoxLogStencil"
        Me.textBoxLogStencil.Size = New System.Drawing.Size(267, 26)
        Me.textBoxLogStencil.TabIndex = 55
        Me.textBoxLogStencil.Text = "Find stencil log"
        '
        'downloadLog
        '
        Me.downloadLog.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.downloadLog.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.downloadLog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.downloadLog.FlatAppearance.BorderSize = 0
        Me.downloadLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.downloadLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.downloadLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.downloadLog.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.downloadLog.ForeColor = System.Drawing.Color.White
        Me.downloadLog.Location = New System.Drawing.Point(344, 58)
        Me.downloadLog.Margin = New System.Windows.Forms.Padding(5)
        Me.downloadLog.Name = "downloadLog"
        Me.downloadLog.Size = New System.Drawing.Size(114, 34)
        Me.downloadLog.TabIndex = 56
        Me.downloadLog.Text = "Descargar LOG"
        Me.downloadLog.UseVisualStyleBackColor = False
        '
        'logStencilBtn
        '
        Me.logStencilBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.logStencilBtn.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.logStencilBtn.FlatAppearance.BorderSize = 3
        Me.logStencilBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.logStencilBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.logStencilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logStencilBtn.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.logStencilBtn.ForeColor = System.Drawing.Color.ForestGreen
        Me.logStencilBtn.Location = New System.Drawing.Point(340, 12)
        Me.logStencilBtn.Name = "logStencilBtn"
        Me.logStencilBtn.Size = New System.Drawing.Size(122, 38)
        Me.logStencilBtn.TabIndex = 128
        Me.logStencilBtn.Text = "Log Stencil"
        Me.logStencilBtn.UseVisualStyleBackColor = False
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
        Me.StencilToolBtn.TabIndex = 127
        Me.StencilToolBtn.Text = "Stencils"
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
        Me.Home.TabIndex = 126
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
        Me.toolingBtn.TabIndex = 125
        Me.toolingBtn.Text = "Tooling"
        Me.toolingBtn.UseVisualStyleBackColor = False
        '
        'logstencilform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 627)
        Me.Controls.Add(Me.PanelF)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.ForestGreen
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "logstencilform"
        Me.Text = "logstencil"
        Me.PanelF.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelF As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents StencilTool1Btn As System.Windows.Forms.Button
    Friend WithEvents edit As System.Windows.Forms.Label
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents generateGrafic As System.Windows.Forms.Button
    Friend WithEvents textBoxLogStencil As System.Windows.Forms.TextBox
    Friend WithEvents downloadLog As System.Windows.Forms.Button
    Friend WithEvents logStencilBtn As System.Windows.Forms.Button
    Friend WithEvents StencilToolBtn As System.Windows.Forms.Button
    Friend WithEvents Home As System.Windows.Forms.Button
    Friend WithEvents toolingBtn As System.Windows.Forms.Button
    Friend WithEvents ButtonFindLogStencil As Button
End Class
