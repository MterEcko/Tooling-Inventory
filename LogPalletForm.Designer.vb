<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class logpalletform
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelF = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PalletsTool1Btn = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.SelecStencil = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TakeMask = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.generateGrafic = New System.Windows.Forms.Button()
        Me.textBoxLogPallet = New System.Windows.Forms.TextBox()
        Me.downloadLog = New System.Windows.Forms.Button()
        Me.LogPalletsBtn = New System.Windows.Forms.Button()
        Me.PalletsToolBtn = New System.Windows.Forms.Button()
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
        Me.PanelF.Controls.Add(Me.LogPalletsBtn)
        Me.PanelF.Controls.Add(Me.PalletsToolBtn)
        Me.PanelF.Controls.Add(Me.Home)
        Me.PanelF.Controls.Add(Me.toolingBtn)
        Me.PanelF.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelF.Location = New System.Drawing.Point(0, 0)
        Me.PanelF.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelF.Name = "PanelF"
        Me.PanelF.Size = New System.Drawing.Size(611, 627)
        Me.PanelF.TabIndex = 40
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.DataGridView2)
        Me.Panel1.Controls.Add(Me.generateGrafic)
        Me.Panel1.Controls.Add(Me.textBoxLogPallet)
        Me.Panel1.Controls.Add(Me.downloadLog)
        Me.Panel1.Location = New System.Drawing.Point(5, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(601, 504)
        Me.Panel1.TabIndex = 129
        '
        'Panel3
        '
        Me.Panel3.AutoSize = True
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Panel3.Controls.Add(Me.PalletsTool1Btn)
        Me.Panel3.Controls.Add(Me.edit)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(10, 3, 10, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(599, 47)
        Me.Panel3.TabIndex = 138
        '
        'PalletsTool1Btn
        '
        Me.PalletsTool1Btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PalletsTool1Btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PalletsTool1Btn.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.PalletsTool1Btn.FlatAppearance.BorderSize = 3
        Me.PalletsTool1Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PalletsTool1Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.PalletsTool1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PalletsTool1Btn.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.PalletsTool1Btn.ForeColor = System.Drawing.Color.ForestGreen
        Me.PalletsTool1Btn.Location = New System.Drawing.Point(439, 6)
        Me.PalletsTool1Btn.Name = "PalletsTool1Btn"
        Me.PalletsTool1Btn.Size = New System.Drawing.Size(156, 38)
        Me.PalletsTool1Btn.TabIndex = 111
        Me.PalletsTool1Btn.Text = "Pallets"
        Me.PalletsTool1Btn.UseVisualStyleBackColor = False
        '
        'edit
        '
        Me.edit.AutoSize = True
        Me.edit.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edit.ForeColor = System.Drawing.Color.White
        Me.edit.Location = New System.Drawing.Point(31, 14)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(85, 19)
        Me.edit.TabIndex = 109
        Me.edit.Text = "Log Pallets"
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(62, Byte), Integer), CType(CType(42, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SelecStencil, Me.TakeMask})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.ForestGreen
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(30, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Location = New System.Drawing.Point(16, 108)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(0)
        Me.DataGridView2.Name = "DataGridView2"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(74, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(82, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView2.Size = New System.Drawing.Size(566, 373)
        Me.DataGridView2.TabIndex = 58
        '
        'SelecStencil
        '
        Me.SelecStencil.FillWeight = 45.47475!
        Me.SelecStencil.HeaderText = "Check"
        Me.SelecStencil.Name = "SelecStencil"
        '
        'TakeMask
        '
        Me.TakeMask.HeaderText = "Seleccionar"
        Me.TakeMask.Name = "TakeMask"
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
        'textBoxLogPallet
        '
        Me.textBoxLogPallet.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textBoxLogPallet.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.textBoxLogPallet.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.textBoxLogPallet.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.textBoxLogPallet.ForeColor = System.Drawing.Color.ForestGreen
        Me.textBoxLogPallet.Location = New System.Drawing.Point(16, 61)
        Me.textBoxLogPallet.Margin = New System.Windows.Forms.Padding(5)
        Me.textBoxLogPallet.MaximumSize = New System.Drawing.Size(400, 30)
        Me.textBoxLogPallet.MinimumSize = New System.Drawing.Size(267, 15)
        Me.textBoxLogPallet.Name = "textBoxLogPallet"
        Me.textBoxLogPallet.Size = New System.Drawing.Size(267, 26)
        Me.textBoxLogPallet.TabIndex = 55
        Me.textBoxLogPallet.Text = "Find pallet log"
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
        Me.downloadLog.Location = New System.Drawing.Point(292, 58)
        Me.downloadLog.Margin = New System.Windows.Forms.Padding(5)
        Me.downloadLog.Name = "downloadLog"
        Me.downloadLog.Size = New System.Drawing.Size(114, 34)
        Me.downloadLog.TabIndex = 56
        Me.downloadLog.Text = "Descargar LOG"
        Me.downloadLog.UseVisualStyleBackColor = False
        '
        'LogPalletsBtn
        '
        Me.LogPalletsBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.LogPalletsBtn.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen
        Me.LogPalletsBtn.FlatAppearance.BorderSize = 3
        Me.LogPalletsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.LogPalletsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(67, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.LogPalletsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogPalletsBtn.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.LogPalletsBtn.ForeColor = System.Drawing.Color.ForestGreen
        Me.LogPalletsBtn.Location = New System.Drawing.Point(340, 12)
        Me.LogPalletsBtn.Name = "LogPalletsBtn"
        Me.LogPalletsBtn.Size = New System.Drawing.Size(122, 38)
        Me.LogPalletsBtn.TabIndex = 128
        Me.LogPalletsBtn.Text = "Log Pallets"
        Me.LogPalletsBtn.UseVisualStyleBackColor = False
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
        Me.PalletsToolBtn.TabIndex = 127
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
        'logpalletform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(611, 627)
        Me.Controls.Add(Me.PanelF)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.ForeColor = System.Drawing.Color.ForestGreen
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "logpalletform"
        Me.Text = "logrouterform"
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
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents SelecStencil As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents TakeMask As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents generateGrafic As System.Windows.Forms.Button
    Friend WithEvents textBoxLogPallet As System.Windows.Forms.TextBox
    Friend WithEvents downloadLog As System.Windows.Forms.Button
    Friend WithEvents LogPalletsBtn As System.Windows.Forms.Button
    Friend WithEvents PalletsToolBtn As System.Windows.Forms.Button
    Friend WithEvents Home As System.Windows.Forms.Button
    Friend WithEvents toolingBtn As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PalletsTool1Btn As System.Windows.Forms.Button
    Friend WithEvents edit As System.Windows.Forms.Label
End Class
