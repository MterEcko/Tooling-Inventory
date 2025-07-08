<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.Login = New System.Windows.Forms.Button()
        Me.Register = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PwdForget = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.maxlogin = New System.Windows.Forms.PictureBox()
        Me.restlogin = New System.Windows.Forms.PictureBox()
        Me.minuslogin = New System.Windows.Forms.PictureBox()
        Me.closelogin = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FormTooling = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maxlogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.restlogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minuslogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closelogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Login
        '
        Me.Login.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Magenta
        Me.Login.Location = New System.Drawing.Point(180, 457)
        Me.Login.Margin = New System.Windows.Forms.Padding(4)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(103, 47)
        Me.Login.TabIndex = 4
        Me.Login.Text = "LogIn"
        Me.Login.UseVisualStyleBackColor = True
        '
        'Register
        '
        Me.Register.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Register.Location = New System.Drawing.Point(37, 570)
        Me.Register.Margin = New System.Windows.Forms.Padding(4)
        Me.Register.Name = "Register"
        Me.Register.Size = New System.Drawing.Size(103, 47)
        Me.Register.TabIndex = 5
        Me.Register.Text = "Register"
        Me.Register.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 537)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Aun no tienes usuario?"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(353, 537)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Olvidastes tus datos"
        '
        'PwdForget
        '
        Me.PwdForget.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PwdForget.Location = New System.Drawing.Point(347, 570)
        Me.PwdForget.Margin = New System.Windows.Forms.Padding(4)
        Me.PwdForget.Name = "PwdForget"
        Me.PwdForget.Size = New System.Drawing.Size(135, 47)
        Me.PwdForget.TabIndex = 8
        Me.PwdForget.Text = "Pasword forget"
        Me.PwdForget.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.maxlogin)
        Me.Panel1.Controls.Add(Me.restlogin)
        Me.Panel1.Controls.Add(Me.minuslogin)
        Me.Panel1.Controls.Add(Me.closelogin)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(505, 39)
        Me.Panel1.TabIndex = 16
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.GPV.My.Resources.Resources.logo
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(149, 35)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 34
        Me.PictureBox2.TabStop = False
        '
        'maxlogin
        '
        Me.maxlogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.maxlogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.maxlogin.Image = Global.GPV.My.Resources.Resources.maximize
        Me.maxlogin.Location = New System.Drawing.Point(433, 4)
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
        Me.restlogin.Image = CType(resources.GetObject("restlogin.Image"), System.Drawing.Image)
        Me.restlogin.Location = New System.Drawing.Point(433, 1)
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
        Me.minuslogin.Location = New System.Drawing.Point(396, 4)
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
        Me.closelogin.Location = New System.Drawing.Point(469, 4)
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
        Me.Label4.Location = New System.Drawing.Point(177, 318)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 16)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "______________________"
        '
        'txtUsername
        '
        Me.txtUsername.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtUsername.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtUsername.Location = New System.Drawing.Point(181, 311)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(152, 15)
        Me.txtUsername.TabIndex = 30
        Me.txtUsername.Text = "Username"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(177, 386)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 16)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "______________________"
        '
        'txtPassword
        '
        Me.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtPassword.BackColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer), CType(CType(225, Byte), Integer))
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtPassword.Location = New System.Drawing.Point(180, 377)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(152, 15)
        Me.txtPassword.TabIndex = 32
        Me.txtPassword.Text = "Password"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(180, 68)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 162)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'FormTooling
        '
        Me.FormTooling.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FormTooling.Location = New System.Drawing.Point(180, 570)
        Me.FormTooling.Margin = New System.Windows.Forms.Padding(4)
        Me.FormTooling.Name = "FormTooling"
        Me.FormTooling.Size = New System.Drawing.Size(135, 47)
        Me.FormTooling.TabIndex = 33
        Me.FormTooling.Text = "Buscar Herramental"
        Me.FormTooling.UseVisualStyleBackColor = True
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(505, 684)
        Me.Controls.Add(Me.FormTooling)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PwdForget)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Register)
        Me.Controls.Add(Me.Login)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.ForestGreen
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maxlogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.restlogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minuslogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closelogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Login As System.Windows.Forms.Button
    Friend WithEvents Register As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PwdForget As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents maxlogin As System.Windows.Forms.PictureBox
    Friend WithEvents minuslogin As System.Windows.Forms.PictureBox
    Friend WithEvents closelogin As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents restlogin As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents FormTooling As System.Windows.Forms.Button
End Class
