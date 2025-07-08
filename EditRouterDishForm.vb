Public Class editrouterdishform
    Dim bdconexion As New Db()
    Dim Dano As Integer
    Dim Condicion As Integer

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

    Private Sub DishToolBtn_Click(sender As Object, e As EventArgs) Handles DishToolBtn.Click, DishTool1Btn.Click
        openPanel(New routerdish)
    End Sub

    Private Sub EditDishBtn_Click(sender As Object, e As EventArgs) Handles EditDishBtn.Click
        openPanel(New editrouterdishform)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub editrouterdishform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        InitializeTextBoxResizers(Me)
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, PanelF))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel1))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel3))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel4))
        bdconexion.Conectar()

        If (DataGridPallet.IdPallet <> "") Then
            'MsgBox(DataGridPallet.PalletNameEdit)

            'txtEnsambleEdit.Text = DataGridStencil.IdStencil
            txtRouterDishModelEdit.Text = DataGridPallet.PalletNameEdit
            txtRouterDishEnsambleEdit.Text = DataGridPallet.PalletEnsambleEdit
            txtRouterDishNumberPartEdit.Text = DataGridPallet.PalletNumberPartEdit
            DateMakeJob.Value = DataGridPallet.PalletFechaFabricanteEdit
            txtRouterDishXPCBEdit.Text = DataGridPallet.PalletXEdit
            txtRouterDishYPCBEdit.Text = DataGridPallet.PalletYEdit
            txtRouterDishRevEdit.Text = DataGridPallet.PalletRevisionEdit
            txtRouterDishJobEdit.Text = DataGridPallet.PalletJobEdit
            txtRouterDishLocalidadEdit.Text = DataGridPallet.PalletLocalidadEdit
            txtRouterDishCyclesEdit.Text = DataGridPallet.PalletCyclesEdit
            txtRouterDishXArrayEdit.Text = DataGridPallet.PalletXArrayEdit
            txtRouterDishYArrayEdit.Text = DataGridPallet.PalletYArrayEdit
            txtRouterDishQtyEdit.Text = DataGridPallet.PalletQtyEdit

            txtRouterDishComentariosEdit.Text = DataGridPallet.PalletComentariosEdit

            RouterDishComboBoxProyectosList.DataSource = bdconexion.ConsultaComboBoxProyectos()
            Dim IntProyecto As Integer = Convert.ToInt32(DataGridPallet.ListProyectos)
            RouterDishComboBoxProyectosList.SelectedIndex = IntProyecto

            'RouterDishComboBoxProyectosList.DataSource = bdconexion.ConsultaComboBoxProyectos()
            'Dim IntProyecto As Integer = Convert.ToInt32(DataGridPallet.ListProyectos)
            'RouterDishComboBoxProyectosList.SelectedIndex = IntProyecto
            'LogProyecto = Convert.ToString(IntProyecto)
            RouterDishComboBoxProvedoresList.DataSource = bdconexion.ConsultaComboBoxProvedores()
            Dim IntProvedor As Integer = Convert.ToInt32(DataGridPallet.ListProvedores)
            If (IntProvedor <> 0) Then

            End If

            'PalletComboBoxMachinesList.DataSource = bdconexion.ConsultaComboBoxMachines()
            'Dim IntMachine As Integer = Convert.ToInt32(DataGridPallet.ListMachines)
            'PalletComboBoxMachinesList.SelectedIndex = IntMachine

            'MsgBox(DataGridPallet.ListMachines)
            RouterDishComboBoxMachinesList.DataSource = bdconexion.ConsultaComboBoxMachines()
            Dim IntMachine As Integer = Convert.ToInt32(DataGridPallet.ListMachines)
            RouterDishComboBoxMachinesList.SelectedIndex = IntMachine
            'MsgBox(IntMachine)
            If DataGridPallet.PalletDanoEdit = 0 Then
                Yes.Checked = False
                No.Checked = True
                'MsgBox("Dano es " + Yes.Checked.ToString)
                Dano = "0"
            Else
                Yes.Checked = True
                No.Checked = False
                Dano = "1"
                'MsgBox("Dano es  en 0" + Yes.Checked.ToString)
            End If


        End If

        bdconexion.Desconectar()
    End Sub

    Private Sub Roperator_Click(sender As Object, e As EventArgs) Handles Roperator.Click
        bdconexion.ActualizarPallet(txtRouterDishModelEdit.Text, txtRouterDishEnsambleEdit.Text, txtRouterDishNumberPartEdit.Text, DateMakeJob.Value,
                txtRouterDishXPCBEdit.Text, txtRouterDishYPCBEdit.Text, txtRouterDishRevEdit.Text,
                txtRouterDishJobEdit.Text, txtRouterDishLocalidadEdit.Text, txtRouterDishCyclesEdit.Text,
                txtRouterDishXArrayEdit.Text, txtRouterDishYArrayEdit.Text, txtRouterDishQtyEdit.Text,
                RouterDishComboBoxMachinesList.SelectedIndex, RouterDishComboBoxProyectosList.SelectedIndex,
                RouterDishComboBoxProvedoresList.SelectedIndex, txtRouterDishComentariosEdit.Text, DataGridPallet.IdPallet, Dano)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RouterDishComboBoxMachinesList.SelectedIndexChanged

    End Sub

    Private Sub Yes_CheckedChanged(sender As Object, e As EventArgs) Handles Yes.CheckedChanged
        If Yes.Checked = True Then
            Dano = "1"
            Condicion = "1"

            'MsgBox("Dano es " + Yes.Checked.ToString)
        End If
    End Sub
    Private Sub No_CheckedChanged(sender As Object, e As EventArgs) Handles No.CheckedChanged
        If Yes.Checked = False Then
            Dano = "0"
            Condicion = "0"
            'MsgBox("Dano es " + Yes.Checked.ToString)
        End If
    End Sub
End Class