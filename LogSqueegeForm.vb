Public Class logsqueegeform

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
                TypeOf control Is RadioButton OrElse
                TypeOf control Is DataGridView Then
                TextBoxResizers.Add(New ClassFormToolingsResizer(Me, control))

            ElseIf TypeOf control Is Panel OrElse TypeOf control Is GroupBox Then
                InitializeTextBoxResizers(control)

            End If
        Next

    End Sub
    Private Sub hideForm()
        PanelF.Visible = False
    End Sub
    Private Sub showForm()

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

    Private Sub ToolingBtn_Click(sender As Object, e As EventArgs) Handles toolingBtn.Click
        openPanel(New Tooling)
    End Sub

    Private Sub StencilToolBtn_Click(sender As Object, e As EventArgs) Handles StencilTool1Btn.Click, StencilToolBtn.Click
        openPanel(New Squeege)
    End Sub

    Private Sub logStencilBtn_Click(sender As Object, e As EventArgs) Handles logStencilBtn.Click
        openPanel(New logsqueegeform)
    End Sub

    Private Sub textBoxLogStencil_Enter(sender As Object, e As EventArgs) Handles textBoxLogStencil.Enter
        If textBoxLogStencil.Text = "Find stencil log" Then
            textBoxLogStencil.Text = ""
            textBoxLogStencil.ForeColor = Color.ForestGreen
        End If
    End Sub
    Private Sub textBoxLogStencil_Leave(sender As Object, e As EventArgs) Handles textBoxLogStencil.Leave
        If textBoxLogStencil.Text = "" Then
            textBoxLogStencil.Text = "Find stencil log"
            textBoxLogStencil.ForeColor = Color.ForestGreen
        End If
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub PanelF_Paint(sender As Object, e As PaintEventArgs) Handles PanelF.Paint
        If (DataGridStencil.IdStencil <> "") Then
            DataGridView2.DataSource = bdconexion.LogConsultaStencilDataGridViewer(DataGridStencil.StencilNameEdit)
        End If

    End Sub

    Private Sub ButtonFindLogStencil_Click(sender As Object, e As EventArgs) Handles ButtonFindLogStencil.Click
        If (textBoxLogStencil.Text = "Find Pallet") Then
            MsgBox("Ingrese algun dato, Porfavor")

            DataGridView2.DataSource = bdconexion.LogConsultaStencilDataGridViewer(DataGridStencil.StencilNameEdit)
        Else
            MsgBox(ButtonFindLogStencil.Text)
            DataGridView2.DataSource = bdconexion.FindLogStencilDataGridViewer(textBoxLogStencil.Text, "")
        End If
    End Sub

    Private Sub logsqueegeform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeTextBoxResizers(Me)
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, PanelF))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel1))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel3))
        DataGridView2.DataSource = bdconexion.LogConsultaStencilDataGridViewer(DataGridStencil.StencilNameEdit)
    End Sub
End Class