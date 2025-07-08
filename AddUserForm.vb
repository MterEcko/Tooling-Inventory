Public Class adduserform

    Dim bdconexion As New Db()
    Private TextBoxResizers As New List(Of ClassFormToolingsResizer)
    Private Sub InitializeTextBoxResizers(container As Control)
        For Each control As Control In container.Controls
            If TypeOf control Is TextBox OrElse
                TypeOf control Is Label OrElse
                TypeOf control Is DateTimePicker OrElse
                TypeOf control Is ComboBox OrElse
                TypeOf control Is RichTextBox OrElse
                TypeOf control Is Button OrElse
                TypeOf control Is RadioButton Then
                TextBoxResizers.Add(New ClassFormToolingsResizer(Me, control))

            ElseIf TypeOf control Is Panel OrElse TypeOf control Is GroupBox Then
                InitializeTextBoxResizers(control)

            End If
        Next

    End Sub
    Private Sub hideStencil()
        PanelF.Visible = False
    End Sub
    Private Sub showStencil()

    End Sub
    Private PFormu As Form = Nothing
    Private Sub openPanel(PanelForm As Form)
        If PFormu IsNot Nothing Then PFormu.Close()
        PFormu = PanelForm
        PanelForm.TopLevel = False
        PanelForm.FormBorderStyle = FormBorderStyle.None
        PanelForm.Dock = DockStyle.Fill
        PanelF.Controls.Add(PanelForm)
        PanelF.Tag = PanelForm
        PanelForm.BringToFront()
        PanelForm.Show()
    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        openPanel(New dashboardPanel)
    End Sub

    Private Sub allUserBtn_Click(sender As Object, e As EventArgs) Handles allUserBtn.Click, allUser1Btn.Click
        openPanel(New alluser)
    End Sub

    Private Sub AddUserBtn_Click(sender As Object, e As EventArgs) Handles AddUserBtn.Click
        openPanel(New adduserform)
    End Sub

    Private Sub AddStencilButton_Click(sender As Object, e As EventArgs) Handles AddStencilButton.Click

        bdconexion.InsertarUser(numberEmployer.Text, txtFirstName.Text, txtLastName.Text, txtEmail.Text, lvlUserComboBox.SelectedIndex, txtPassword.Text)
    End Sub

    Private Sub adduserform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeTextBoxResizers(Me)
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, PanelF))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel1))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel3))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel4))
    End Sub
End Class