Public Class editpalletform
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
    Dim Dano As Integer
    Dim Condicion As Integer
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

    Private Sub PalletsToolBtn_Click(sender As Object, e As EventArgs) Handles PalletsToolBtn.Click, PalletsTool1Btn.Click
        openPanel(New pallet)
    End Sub

    Private Sub EditPalletsBtn_Click(sender As Object, e As EventArgs) Handles EditPalletsBtn.Click
        openPanel(New editpalletform)
    End Sub

    Private Sub editpalletform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeTextBoxResizers(Me)
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, PanelF))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel1))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel3))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel4))
        bdconexion.Conectar()

        If (DataGridPallet.IdPallet <> "") Then


            'txtEnsambleEdit.Text = DataGridStencil.IdStencil
            txtPalletModelEdit.Text = DataGridPallet.PalletNameEdit
            txtPalletEnsambleEdit.Text = DataGridPallet.PalletEnsambleEdit
            txtPalletNumberPartEdit.Text = DataGridPallet.PalletNumberPartEdit
            DateMakeJob.Value = DataGridPallet.PalletFechaFabricanteEdit
            txtPalletXPCBEdit.Text = DataGridPallet.PalletXEdit
            txtPalletYPCBEdit.Text = DataGridPallet.PalletYEdit
            txtPalletRevEdit.Text = DataGridPallet.PalletRevisionEdit
            txtPalletJobEdit.Text = DataGridPallet.PalletJobEdit
            txtPalletLocalidadEdit.Text = DataGridPallet.PalletLocalidadEdit
            txtPalletCyclesEdit.Text = DataGridPallet.PalletCyclesEdit
            txtPalletXArrayEdit.Text = DataGridPallet.PalletXArrayEdit
            txtPalletYArrayEdit.Text = DataGridPallet.PalletYArrayEdit
            txtPalletQtyEdit.Text = DataGridPallet.PalletQtyEdit

            txtPalletComentariosEdit.Text = DataGridPallet.PalletComentariosEdit


            PalletComboBoxProyectosList.DataSource = bdconexion.ConsultaComboBoxProyectos()
            Dim IntProyecto As Integer = Convert.ToInt32(DataGridPallet.ListProyectos)
            PalletComboBoxProyectosList.SelectedIndex = IntProyecto
            'LogProyecto = Convert.ToString(IntProyecto)
            PalletComboBoxProvedoresList.DataSource = bdconexion.ConsultaComboBoxProvedores()
            Dim IntProvedor As Integer = Convert.ToInt32(DataGridPallet.ListProvedores)
            If (IntProvedor <> 0) Then

            End If
            PalletComboBoxMachinesList.DataSource = bdconexion.ConsultaComboBoxMachines()
            Dim IntMachine As Integer = Convert.ToInt32(DataGridPallet.ListMachines)
            PalletComboBoxMachinesList.SelectedIndex = IntMachine

            If DataGridPallet.PalletDanoEdit = 0 Then
                Yes.Checked = False
                No.Checked = True
                'MsgBox("Dano es " + Yes.Checked.ToString)
                Dano = "0"
            Else
                Yes.Checked = True
                No.Checked = False
                Dano = "1"
                'ElseIf DataGridStencil.DanoEdit <> "0" Then
                '   Yes.Checked = True
                '  No.Checked = False
                ' Dano = "1"
                'MsgBox("Dano es  en 0" + Yes.Checked.ToString)
            End If

        End If

        bdconexion.Desconectar()
    End Sub

    Private Sub UpdatePalletButton_Click(sender As Object, e As EventArgs) Handles UpdatePalletButton.Click

        bdconexion.ActualizarPallet(txtPalletModelEdit.Text, txtPalletEnsambleEdit.Text, txtPalletNumberPartEdit.Text, DateMakeJob.Value,
                txtPalletXPCBEdit.Text, txtPalletYPCBEdit.Text, txtPalletRevEdit.Text,
                txtPalletJobEdit.Text, txtPalletLocalidadEdit.Text, txtPalletCyclesEdit.Text,
                txtPalletXArrayEdit.Text, txtPalletYArrayEdit.Text, txtPalletQtyEdit.Text,
                PalletComboBoxMachinesList.SelectedIndex, PalletComboBoxProyectosList.SelectedIndex,
                PalletComboBoxProvedoresList.SelectedIndex, txtPalletComentariosEdit.Text, DataGridPallet.IdPallet, Dano)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

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