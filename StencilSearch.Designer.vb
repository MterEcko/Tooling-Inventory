<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stencilsearch
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
        Me.FindStencil = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtFind = New System.Windows.Forms.TextBox()
        Me.ResultStencil = New System.Windows.Forms.DataGridView()
        Me.take = New System.Windows.Forms.Button()
        Me.EmployerNumber = New System.Windows.Forms.TextBox()
        Me.Roperator = New System.Windows.Forms.Button()
        Me.ReturnTooling = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.ResultStencil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FindStencil
        '
        Me.FindStencil.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FindStencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FindStencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta
        Me.FindStencil.Location = New System.Drawing.Point(636, 88)
        Me.FindStencil.Margin = New System.Windows.Forms.Padding(4)
        Me.FindStencil.Name = "FindStencil"
        Me.FindStencil.Size = New System.Drawing.Size(103, 47)
        Me.FindStencil.TabIndex = 4
        Me.FindStencil.Text = "find"
        Me.FindStencil.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(270, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(225, 16)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "_______________________________"
        '
        'TxtFind
        '
        Me.TxtFind.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TxtFind.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtFind.ForeColor = System.Drawing.Color.ForestGreen
        Me.TxtFind.Location = New System.Drawing.Point(274, 103)
        Me.TxtFind.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtFind.Name = "TxtFind"
        Me.TxtFind.Size = New System.Drawing.Size(225, 15)
        Me.TxtFind.TabIndex = 30
        Me.TxtFind.Text = "Assembly"
        '
        'ResultStencil
        '
        Me.ResultStencil.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ResultStencil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.ResultStencil.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.ResultStencil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ResultStencil.Location = New System.Drawing.Point(13, 142)
        Me.ResultStencil.Name = "ResultStencil"
        Me.ResultStencil.Size = New System.Drawing.Size(852, 321)
        Me.ResultStencil.TabIndex = 31
        '
        'take
        '
        Me.take.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.take.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.take.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta
        Me.take.Location = New System.Drawing.Point(141, 482)
        Me.take.Margin = New System.Windows.Forms.Padding(4)
        Me.take.Name = "take"
        Me.take.Size = New System.Drawing.Size(103, 47)
        Me.take.TabIndex = 32
        Me.take.Text = "take"
        Me.take.UseVisualStyleBackColor = True
        '
        'EmployerNumber
        '
        Me.EmployerNumber.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmployerNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.EmployerNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmployerNumber.ForeColor = System.Drawing.Color.ForestGreen
        Me.EmployerNumber.Location = New System.Drawing.Point(274, 103)
        Me.EmployerNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.EmployerNumber.Name = "EmployerNumber"
        Me.EmployerNumber.Size = New System.Drawing.Size(225, 15)
        Me.EmployerNumber.TabIndex = 33
        Me.EmployerNumber.Text = "Employer Number"
        '
        'Roperator
        '
        Me.Roperator.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Roperator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Roperator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta
        Me.Roperator.Location = New System.Drawing.Point(636, 88)
        Me.Roperator.Margin = New System.Windows.Forms.Padding(4)
        Me.Roperator.Name = "Roperator"
        Me.Roperator.Size = New System.Drawing.Size(103, 47)
        Me.Roperator.TabIndex = 34
        Me.Roperator.Text = "OKEY"
        Me.Roperator.UseVisualStyleBackColor = True
        '
        'ReturnTooling
        '
        Me.ReturnTooling.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ReturnTooling.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ReturnTooling.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta
        Me.ReturnTooling.Location = New System.Drawing.Point(458, 482)
        Me.ReturnTooling.Margin = New System.Windows.Forms.Padding(4)
        Me.ReturnTooling.Name = "ReturnTooling"
        Me.ReturnTooling.Size = New System.Drawing.Size(103, 47)
        Me.ReturnTooling.TabIndex = 35
        Me.ReturnTooling.Text = "Return Toling"
        Me.ReturnTooling.UseVisualStyleBackColor = True
        '
        'Back
        '
        Me.Back.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta
        Me.Back.Location = New System.Drawing.Point(635, 482)
        Me.Back.Margin = New System.Windows.Forms.Padding(4)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(103, 47)
        Me.Back.TabIndex = 36
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = Global.GPV.My.Resources.Resources.pcb_stencil
        Me.PictureBox1.Location = New System.Drawing.Point(13, 19)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'stencilsearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(877, 560)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.ReturnTooling)
        Me.Controls.Add(Me.Roperator)
        Me.Controls.Add(Me.EmployerNumber)
        Me.Controls.Add(Me.take)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ResultStencil)
        Me.Controls.Add(Me.TxtFind)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.FindStencil)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.ForestGreen
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "stencilsearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        CType(Me.ResultStencil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FindStencil As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtFind As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ResultStencil As System.Windows.Forms.DataGridView
    Friend WithEvents take As System.Windows.Forms.Button
    Friend WithEvents EmployerNumber As System.Windows.Forms.TextBox
    Friend WithEvents Roperator As System.Windows.Forms.Button
    Friend WithEvents ReturnTooling As System.Windows.Forms.Button
    Friend WithEvents Back As System.Windows.Forms.Button
End Class
