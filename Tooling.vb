Public Class Tooling
    Private TextBoxResizers As New List(Of ClassFormToolingsResizer)
    Private Sub HideStencil()
        PanelF.Visible = False
    End Sub
    Private Sub ShowStencil()

    End Sub
    Private PFormu As Form = Nothing
    Private Sub OpenPanel(PanelForm As Form)
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

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click, Home1Btn.Click
        openPanel(New dashboardPanel)
    End Sub

    Private Sub StencilBtn_Click(sender As Object, e As EventArgs) Handles StencilBtn.Click
        openPanel(New Stencil)
    End Sub

    Private Sub RouterDishBtn_Click(sender As Object, e As EventArgs) Handles RouterDishBtn.Click
        DataGridPallet.Machine = "2"
        openPanel(New routerdish)
    End Sub

    Private Sub PalletsSelectiveBtn_Click(sender As Object, e As EventArgs) Handles PalletsSelectiveBtn.Click
        DataGridPallet.Machine = "0"
        openPanel(New pallet)
    End Sub

    Private Sub SquegueBtn_Click(sender As Object, e As EventArgs) Handles SquegueBtn.Click
        openPanel(New Squeege)
    End Sub

    Private Sub PalletsRegularBtn_Click(sender As Object, e As EventArgs) Handles PalletsRegularBtn.Click
        DataGridPallet.Machine = "1"
        openPanel(New pallet)
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
    Private Sub Tooling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeTextBoxResizers(Me)
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, PanelF))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel1))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel3))
        'TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel4))

        'TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel1))
        'TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel3))
    End Sub
End Class