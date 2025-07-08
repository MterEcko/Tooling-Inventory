

Public Class inicio
    Private TextBoxResizers As New List(Of ClassFormToolingsResizer)
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    Private Sub customizeDesing()
        panelMenuTooling.Visible = False

    End Sub
    Private Sub hideSubMenu()
        panelMenuTooling.Visible = False


    End Sub

    Private Sub showSubMenu(subMenu As Panel)
        If subMenu.Visible = False Then
            hideSubMenu()
            subMenu.Visible = True
        Else
            subMenu.Visible = False
        End If
    End Sub
    Public currentForm As Form = Nothing
    Public Sub openChildForm(childForm As Form)
        If currentForm IsNot Nothing Then currentForm.Close()
        currentForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        panelChildForm.Controls.Add(childForm)
        panelChildForm.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub BtnTooling_Click(sender As Object, e As EventArgs) Handles BtnTooling.Click
        showSubMenu(panelMenuTooling)
    End Sub

    Private Sub BtnStencilPanel_Click(sender As Object, e As EventArgs) Handles BtnStencilPanel.Click
        openChildForm(New Stencil)
    End Sub

    Private Sub BtnPalletPanel_Click(sender As Object, e As EventArgs) Handles BtnPalletPanel.Click
        DataGridPallet.Machine = ""
        openChildForm(New pallet)
    End Sub

    Private Sub BtnPlateRouterPanel_Click(sender As Object, e As EventArgs) Handles BtnPlateRouterPanel.Click

        openChildForm(New routerdish)

    End Sub
    
    Private Sub BtnManagerUser_Click(sender As Object, e As EventArgs) Handles BtnManagerUser.Click
        If panelMenuTooling.Visible = False Then
            showSubMenu(PanelMenuManagerUser)
            panelMenuTooling.Visible = False
        Else
            showSubMenu(PanelMenuManagerUser)
            panelMenuTooling.Visible = True
        End If
    End Sub

    Private Sub allUser_Click(sender As Object, e As EventArgs) Handles allUser.Click
        openChildForm(New alluser)
    End Sub

    Private Sub addUser_Click(sender As Object, e As EventArgs) Handles addUser.Click
        openChildForm(New adduserform)
    End Sub

    Private Sub Profile_Click(sender As Object, e As EventArgs) Handles dashboard.Click
        openChildForm(New dashboardPanel)
    End Sub

    Private Sub panelChildForm_Paint(sender As Object, e As PaintEventArgs) Handles panelChildForm.Click
        openChildForm(New dashboardPanel)

    End Sub

    Private Sub InitializeTextBoxResizers(container As Control)
        For Each control As Control In container.Controls
            If TypeOf control Is TextBox OrElse
               TypeOf control Is Label OrElse
               TypeOf control Is DateTimePicker OrElse
               TypeOf control Is ComboBox OrElse
               TypeOf control Is RichTextBox OrElse
               TypeOf control Is Button OrElse
               TypeOf control Is RadioButton OrElse
               TypeOf control Is DataGridView Then
                'TypeOf control Is Button
                'Then
                TextBoxResizers.Add(New ClassFormToolingsResizer(Me, control))

            ElseIf TypeOf control Is Panel OrElse TypeOf control Is GroupBox Then
                InitializeTextBoxResizers(control)

            End If
        Next

    End Sub

    Private Sub inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'openChildForm(New dashboardPanel)
        'Me.Close()
        Me.WindowState = FormWindowState.Maximized
        'Me.FormBorderStyle = FormBorderStyle.None
        Me.MinimizeBox = False
        openChildForm(New dashboardPanel)
        'Dim Login As New FormLogin()
        'FormLogin.Close()
        InitializeTextBoxResizers(Me)
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, PanelSideMenu))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, PanelMenuSetup))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, PanelSetup))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, panelMenuTooling))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, panelTooling))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, PanelMenuManagerUser))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, PanelManagerUser))


        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, panelChildForm))
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        openChildForm(New Asemblye)
    End Sub

    Private Sub SupliersBtnForm_Click(sender As Object, e As EventArgs) Handles SupliersBtnForm.Click
        DataGridPallet.IdSetup = "0"
        openChildForm(New SetupMenu)
    End Sub

    Private Sub ProyectsBtnForm_Click(sender As Object, e As EventArgs) Handles ProyectsBtnForm.Click
        DataGridPallet.IdSetup = "1"
        openChildForm(New SetupMenu)
    End Sub

    Private Sub ExtrasBtnForm_Click_1(sender As Object, e As EventArgs) Handles ExtrasBtnForm.Click
        DataGridPallet.IdSetup = "2"
        openChildForm(New SetupMenu)
    End Sub

    Private Sub BtnSetup_Click(sender As Object, e As EventArgs) Handles BtnSetup.Click
        showSubMenu(PanelMenuSetup)
    End Sub

    Private Sub ProfilePicturePanel_Paint(sender As Object, e As PaintEventArgs) Handles ProfilePicturePanel.Paint

    End Sub
End Class