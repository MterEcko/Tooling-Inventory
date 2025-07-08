<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class toolingFindOperator
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.maxlogin = New System.Windows.Forms.PictureBox()
        Me.restlogin = New System.Windows.Forms.PictureBox()
        Me.minuslogin = New System.Windows.Forms.PictureBox()
        Me.closelogin = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtFind = New System.Windows.Forms.TextBox()
        Me.ResultStencil = New System.Windows.Forms.DataGridView()
        Me.take = New System.Windows.Forms.Button()
        Me.EmployerNumber = New System.Windows.Forms.TextBox()
        Me.Roperator = New System.Windows.Forms.Button()
        Me.ReturnTooling = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maxlogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.restlogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minuslogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closelogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResultStencil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FindStencil
        '
        Me.FindStencil.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FindStencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.FindStencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta
        Me.FindStencil.Location = New System.Drawing.Point(539, 88)
        Me.FindStencil.Margin = New System.Windows.Forms.Padding(4)
        Me.FindStencil.Name = "FindStencil"
        Me.FindStencil.Size = New System.Drawing.Size(103, 47)
        Me.FindStencil.TabIndex = 4
        Me.FindStencil.Text = "find"
        Me.FindStencil.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.maxlogin)
        Me.Panel1.Controls.Add(Me.restlogin)
        Me.Panel1.Controls.Add(Me.minuslogin)
        Me.Panel1.Controls.Add(Me.closelogin)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(683, 39)
        Me.Panel1.TabIndex = 16
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox3.Image = Global.GPV.My.Resources.Resources.logo
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(149, 39)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 35
        Me.PictureBox3.TabStop = False
        '
        'maxlogin
        '
        Me.maxlogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maxlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.maxlogin.Image = Global.GPV.My.Resources.Resources.maximize
        Me.maxlogin.Location = New System.Drawing.Point(611, 4)
        Me.maxlogin.Margin = New System.Windows.Forms.Padding(4)
        Me.maxlogin.Name = "maxlogin"
        Me.maxlogin.Size = New System.Drawing.Size(33, 31)
        Me.maxlogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.maxlogin.TabIndex = 18
        Me.maxlogin.TabStop = False
        '
        'restlogin
        '
        Me.restlogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.restlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.restlogin.Location = New System.Drawing.Point(611, 1)
        Me.restlogin.Margin = New System.Windows.Forms.Padding(4)
        Me.restlogin.Name = "restlogin"
        Me.restlogin.Size = New System.Drawing.Size(36, 39)
        Me.restlogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.restlogin.TabIndex = 19
        Me.restlogin.TabStop = False
        '
        'minuslogin
        '
        Me.minuslogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.minuslogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minuslogin.Image = Global.GPV.My.Resources.Resources.minus
        Me.minuslogin.Location = New System.Drawing.Point(574, 4)
        Me.minuslogin.Margin = New System.Windows.Forms.Padding(4)
        Me.minuslogin.Name = "minuslogin"
        Me.minuslogin.Size = New System.Drawing.Size(33, 31)
        Me.minuslogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.minuslogin.TabIndex = 17
        Me.minuslogin.TabStop = False
        '
        'closelogin
        '
        Me.closelogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.closelogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closelogin.Image = Global.GPV.My.Resources.Resources.close
        Me.closelogin.Location = New System.Drawing.Point(647, 4)
        Me.closelogin.Margin = New System.Windows.Forms.Padding(4)
        Me.closelogin.Name = "closelogin"
        Me.closelogin.Size = New System.Drawing.Size(33, 31)
        Me.closelogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.closelogin.TabIndex = 16
        Me.closelogin.TabStop = False
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(173, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(225, 16)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "_______________________________"
        '
        'TxtFind
        '
        Me.TxtFind.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtFind.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.TxtFind.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtFind.ForeColor = System.Drawing.Color.ForestGreen
        Me.TxtFind.Location = New System.Drawing.Point(177, 103)
        Me.TxtFind.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtFind.Name = "TxtFind"
        Me.TxtFind.Size = New System.Drawing.Size(225, 15)
        Me.TxtFind.TabIndex = 30
        Me.TxtFind.Text = "WO or Assembly"
        '
        'ResultStencil
        '
        Me.ResultStencil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ResultStencil.Location = New System.Drawing.Point(177, 175)
        Me.ResultStencil.Name = "ResultStencil"
        Me.ResultStencil.Size = New System.Drawing.Size(464, 258)
        Me.ResultStencil.TabIndex = 31
        '
        'take
        '
        Me.take.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.take.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.take.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta
        Me.take.Location = New System.Drawing.Point(177, 482)
        Me.take.Margin = New System.Windows.Forms.Padding(4)
        Me.take.Name = "take"
        Me.take.Size = New System.Drawing.Size(103, 47)
        Me.take.TabIndex = 32
        Me.take.Text = "Tomar"
        Me.take.UseVisualStyleBackColor = True
        '
        'EmployerNumber
        '
        Me.EmployerNumber.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.EmployerNumber.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.EmployerNumber.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmployerNumber.ForeColor = System.Drawing.Color.ForestGreen
        Me.EmployerNumber.Location = New System.Drawing.Point(177, 103)
        Me.EmployerNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.EmployerNumber.Name = "EmployerNumber"
        Me.EmployerNumber.Size = New System.Drawing.Size(225, 15)
        Me.EmployerNumber.TabIndex = 33
        Me.EmployerNumber.Text = "Employe Number"
        '
        'Roperator
        '
        Me.Roperator.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Roperator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Roperator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta
        Me.Roperator.Location = New System.Drawing.Point(538, 88)
        Me.Roperator.Margin = New System.Windows.Forms.Padding(4)
        Me.Roperator.Name = "Roperator"
        Me.Roperator.Size = New System.Drawing.Size(103, 47)
        Me.Roperator.TabIndex = 34
        Me.Roperator.Text = "OKEY"
        Me.Roperator.UseVisualStyleBackColor = True
        '
        'ReturnTooling
        '
        Me.ReturnTooling.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ReturnTooling.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ReturnTooling.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta
        Me.ReturnTooling.Location = New System.Drawing.Point(361, 482)
        Me.ReturnTooling.Margin = New System.Windows.Forms.Padding(4)
        Me.ReturnTooling.Name = "ReturnTooling"
        Me.ReturnTooling.Size = New System.Drawing.Size(103, 47)
        Me.ReturnTooling.TabIndex = 35
        Me.ReturnTooling.Text = "Return Toling"
        Me.ReturnTooling.UseVisualStyleBackColor = True
        '
        'Back
        '
        Me.Back.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta
        Me.Back.Location = New System.Drawing.Point(538, 482)
        Me.Back.Margin = New System.Windows.Forms.Padding(4)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(103, 47)
        Me.Back.TabIndex = 36
        Me.Back.Text = "Back"
        Me.Back.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = Global.GPV.My.Resources.Resources.pcb_stencil
        Me.PictureBox1.Location = New System.Drawing.Point(11, 97)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(683, 560)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.ReturnTooling)
        Me.Controls.Add(Me.Roperator)
        Me.Controls.Add(Me.EmployerNumber)
        Me.Controls.Add(Me.take)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ResultStencil)
        Me.Controls.Add(Me.TxtFind)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FindStencil)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.ForestGreen
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maxlogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.restlogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minuslogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closelogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResultStencil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FindStencil As System.Windows.Forms.Button
    Friend WithEvents maxlogin As System.Windows.Forms.PictureBox
    Friend WithEvents minuslogin As System.Windows.Forms.PictureBox
    Friend WithEvents closelogin As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtFind As System.Windows.Forms.TextBox
    Friend WithEvents restlogin As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ResultStencil As System.Windows.Forms.DataGridView
    Friend WithEvents take As System.Windows.Forms.Button
    Friend WithEvents EmployerNumber As System.Windows.Forms.TextBox
    Friend WithEvents Roperator As System.Windows.Forms.Button
    Friend WithEvents ReturnTooling As System.Windows.Forms.Button
    Friend WithEvents Back As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
End Class
