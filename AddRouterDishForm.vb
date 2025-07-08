Public Class addrouterdishform
    Private TextBoxResizers As New List(Of ClassFormToolingsResizer)
    Dim bdconexion As New Db()
    Dim Cadena As String
    Dim LogProyecto As String
    Dim Dano As Integer
    Dim Condicion As Integer

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

    Private Sub AddDishBtn_Click(sender As Object, e As EventArgs) Handles AddDishBtn.Click
        openPanel(New addrouterdishform)
    End Sub

    Private Sub addrouterdishform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeTextBoxResizers(Me)
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel1))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel3))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel4))
        DateMakeJobAdd.Value = Date.Today
        bdconexion.Conectar()
        ComboBoxProyectosListAdd.DataSource = bdconexion.ConsultaComboBoxProyectos()
        Dim IntProyecto As Integer = Convert.ToInt32(DataGridPallet.ListProyectos)
        ComboBoxProyectosListAdd.SelectedIndex = 0

        LogProyecto = Convert.ToString(IntProyecto)
        ComboBoxProvedoresListAdd.DataSource = bdconexion.ConsultaComboBoxProvedores()
        Dim IntProvedor As Integer = Convert.ToInt32(DataGridPallet.ListProvedores)
        ComboBoxProvedoresListAdd.SelectedIndex = 0


        ComboBoxMachinesListAdd.DataSource = bdconexion.ConsultaComboBoxMachines()
        Dim IntMachine As Integer = Convert.ToInt32(DataGridPallet.ListMachines)
        ComboBoxProyectosListAdd.SelectedIndex = 0
        'TODO: This line of code loads data into the 'GPVGROUPDataSet1.Proyects' table. You can move, or remove it, as needed.
        bdconexion.Desconectar()
    End Sub

    Private Sub Roperator_Click(sender As Object, e As EventArgs) Handles Roperator.Click
        bdconexion.InsertarPallet(txtPalletNameAdd.Text, txtPalletEnsambleAdd.Text, txtPartPCBAdd.Text, ComboBoxProyectosListAdd.SelectedIndex, DateMakeJobAdd.Value, txtXLenghAdd.Text, txtYLenghAdd.Text,
        ComboBoxProvedoresListAdd.SelectedIndex, txtRevPalletAdd.Text, txtJobPalletAdd.Text, txtLocalidadPalletAdd.Text,
        txtCyclesPalletAdd.Text, txtXArrayAdd.Text, txtYArrayAdd.Text, txtQtyPalletAdd.Text, ComboBoxMachinesListAdd.SelectedIndex, txtIdPalletAdd.Text,
        txtCommentsPalletAdd.Text, Dano)
    End Sub

    Private Sub Yes_CheckedChanged(sender As Object, e As EventArgs) Handles Yes.CheckedChanged

    End Sub
    Private Sub No_CheckedChanged(sender As Object, e As EventArgs) Handles No.CheckedChanged

    End Sub
End Class