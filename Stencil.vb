Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO


Public Class Stencil
    Private TextBoxResizers As New List(Of ClassFormToolingsResizer)

    Private WithEvents FormResizer As ClassFormToolingsResizer

    Dim bdconexion As New Db()
    Dim RowActual As Int16

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
    Public Sub hideStencil()
        PanelF.Visible = False
    End Sub
    Public Sub showStencil()

    End Sub
    Public PFormu As Form = Nothing
    Public Sub openPanel(PanelForm As Form)
        If PFormu IsNot Nothing Then PFormu.Close()
        PFormu = PanelForm
        PanelForm.TopLevel = False
        PanelForm.FormBorderStyle = FormBorderStyle.None
        PanelForm.Dock = DockStyle.Fill
        PanelF.Controls.Add(PanelForm)
        PanelF.Tag = PanelForm
        PanelF.Enabled = True
        PanelForm.BringToFront()
        PanelForm.Show()
    End Sub

    Private Sub textBoxFindStencil_Enter(sender As Object, e As EventArgs) Handles textBoxFindStencil.Enter
        If textBoxFindStencil.Text = "Find Stencil" Then
            textBoxFindStencil.Text = ""
            textBoxFindStencil.ForeColor = Color.ForestGreen
        End If
    End Sub

    Private Sub textBoxFindStencil_Leave(sender As Object, e As EventArgs) Handles textBoxFindStencil.Leave
        If textBoxFindStencil.Text = "" Then
            textBoxFindStencil.Text = "Find Stencil"
            textBoxFindStencil.ForeColor = Color.ForestGreen
        End If
    End Sub

    Private Sub addStencilBtnForm_Click(sender As Object, e As EventArgs) Handles addStencilBtnForm.Click
        openPanel(New Addstencilform)
    End Sub
    Private Sub editStencilBtnForm_Click(sender As Object, e As EventArgs) Handles editStencilBtnForm.Click

        If (DataGridStencil.IdStencil <> "") Then
            bdconexion.ConsultarStencil(DataGridStencil.IdStencil)
            'txtStencilNameEdit
            openPanel(New editstencilform)
        Else
            MsgBox("Por favor seleccione un stencil")
        End If

    End Sub

    Private Sub viewLogStencilBtn_Click(sender As Object, e As EventArgs) Handles viewLogStencilBtn.Click
        If (DataGridStencil.IdStencil <> "") Then
            bdconexion.ConsultarStencil(DataGridStencil.IdStencil)
            'txtStencilNameEdit
            openPanel(New logstencilform)
        Else
            MsgBox("Por favor seleccione un stencil")
        End If

    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        openPanel(New dashboardPanel)
    End Sub

    Private Sub ToolingBtn_Click(sender As Object, e As EventArgs) Handles Tooling1Btn.Click
        openPanel(New Tooling)
    End Sub

    Private Sub StencilToolBtn_Click(sender As Object, e As EventArgs) Handles StencilToolBtn.Click
        openPanel(New Stencil)
    End Sub


    Private Sub toolingRouterBtn_Click(sender As Object, e As EventArgs) Handles toolingBtn.Click
        openPanel(New Tooling)
    End Sub

    Private Sub Stencil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeTextBoxResizers(Me)
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, PanelF))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel1))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel3))
        'TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel4))
    End Sub
    Public Sub DataGridStencil_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridStencilDate.CellEnter
        DataGridStencilDate.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Public Sub DataGridStencilDate_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridStencilDate.CellContentClick


        Dim SelectActual As String = 0
        Dim StencilName As String
        RowActual = DataGridStencilDate.CurrentRow.Index()



        SelectActual = DataGridStencilDate.Item(0, RowActual).Value.ToString
        StencilName = DataGridStencilDate.Item(1, RowActual).Value.ToString

        DataGridStencil.IdStencil = SelectActual
        DataGridStencil.StencilNameEdit = StencilName

    End Sub
    ' DESACTIVADO TEMPORALMENTE, DESACTIVAR EN DATAGRID VIEW
    Private Sub PanelF_load(sender As Object, e As EventArgs) Handles MyBase.Load


        'TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel1))
        'Panel1.Size = New Size((Panel1.Size.Width / 100) * 98, Panel1.Size.Height)
        'TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel3))
        'TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel4))
        'TODO: esta línea de código carga datos en la tabla 'GPVDataSet.Stencil' Puede moverla o quitarla según sea necesario.
        DataGridStencilDate.DataSource = bdconexion.ConsultaStencilDataGridViewer()
    End Sub

    Private Sub findStencilBtn_Click(sender As Object, e As EventArgs) Handles findStencilBtn.Click
        If (textBoxFindStencil.Text = "Find Stencil") Then
            MsgBox("Ingrese algun dato, Porfavor")
            DataGridStencilDate.DataSource = bdconexion.ConsultaStencilDataGridViewer()
        Else
            DataGridStencilDate.DataSource = bdconexion.FindStencilDataGridViewer(textBoxFindStencil.Text)
        End If

    End Sub


    Private Sub textBoxFindStencil_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textBoxFindStencil.KeyPress

        If Asc(e.KeyChar) = 13 Then
            If (textBoxFindStencil.Text = "Find Stencil") Then
                MsgBox("Ingrese algun dato, Porfavor")
                DataGridStencilDate.DataSource = bdconexion.ConsultaStencilDataGridViewer()
            Else
                DataGridStencilDate.DataSource = bdconexion.FindStencilDataGridViewer(textBoxFindStencil.Text)
            End If
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        openPanel(New palletsearch)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        openPanel(New Addstencilform)
    End Sub

    Private Sub DeleteStencilBtnForm_Click(sender As Object, e As EventArgs) Handles deleteStencilBtnForm.Click
        If (DataGridStencil.IdStencil <> "") Then

            'txtStencilNameEdit
            Eliminar()
            DataGridStencil.IdStencil = ""
        Else
            MsgBox("Por favor seleccione un stencil")
        End If



    End Sub
    Sub Eliminar()
        Dim Resultado As DialogResult

        Resultado = MessageBox.Show("Eliminar Stencil?", "Eliminar Stencil", MessageBoxButtons.OKCancel)

        If Resultado = DialogResult.OK Then
            ' Código para el caso de aceptar
            'bdconexion.DeleteUser(DataGridUser.IdUser, Orden)
            Dim Resultado2 As DialogResult

            Resultado2 = MessageBox.Show("Seguro que quiere continuar?", "Desea continuar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Resultado2 = DialogResult.Yes Then

                bdconexion.DeleteStencil(DataGridStencil.IdStencil)
                DataGridStencilDate.DataSource = bdconexion.ConsultaStencilDataGridViewer()
                'Console.WriteLine("Aceptado")
            ElseIf Resultado2 = DialogResult.No Then
                MsgBox("No")
            End If
        ElseIf Resultado = DialogResult.Cancel Then
            ' Código para el caso de cancelar
            MsgBox(" Cancelado")
            Console.WriteLine("Cancelado")
        End If
    End Sub

    Private Sub PanelF_Paint(sender As Object, e As PaintEventArgs) Handles PanelF.Paint

    End Sub

    Private Sub TakeAndReturnStencilBtnForm_Click(sender As Object, e As EventArgs) Handles TakeAndReturnStencilBtnForm.Click
        ShowCustomDialog()

        'MessageBox.Show("Stencil devuelto: " + StencilName,
        '               "Registro de Datos Personales",
        'MessageBoxButtons.OK,
        'MessageBoxIcon.Information)
        'Cadena = "Return stencil with Localidad: " + StencilName + ", Nombre Stencil: " + ResultStencil.Item(1, RowActual).Value.ToString


        'bdconexion.LogAdd(Cadena, Id_User)
    End Sub

    Public Function ShowCustomDialog() As String
        Dim customForm As New Form()
        customForm.Text = "Selecciona una opción"
        customForm.FormBorderStyle = FormBorderStyle.FixedDialog
        customForm.StartPosition = FormStartPosition.CenterScreen
        customForm.ClientSize = New Size(300, 150)
        customForm.MaximizeBox = False
        customForm.MinimizeBox = False

        Dim radioTomar As New RadioButton()
        radioTomar.Text = "Tomar"
        radioTomar.Location = New Point(10, 10)
        customForm.Controls.Add(radioTomar)

        Dim radioDevolver As New RadioButton()
        radioDevolver.Text = "Devolver"
        radioDevolver.Location = New Point(10, 40)
        customForm.Controls.Add(radioDevolver)

        Dim radioCancelar As New RadioButton()
        radioCancelar.Text = "Cancelar"
        radioCancelar.Location = New Point(10, 70)
        customForm.Controls.Add(radioCancelar)

        Dim btnConfirmar As New Button()
        btnConfirmar.Text = "Confirmar"
        btnConfirmar.Location = New Point(200, 110)
        AddHandler btnConfirmar.Click, Sub(sender, e)
                                           customForm.DialogResult = DialogResult.OK
                                           customForm.Close()
                                       End Sub
        customForm.Controls.Add(btnConfirmar)

        If customForm.ShowDialog() = DialogResult.OK Then
            If radioTomar.Checked Then
                MsgBox("Tomar stencil de localidad; " + DataGridStencilDate.Item(1, RowActual).Value.ToString)
                'SelectActual = DataGridStencilDate.Item(0, RowActual).Value.ToString
                'StencilName = DataGridStencilDate.Item(1, RowActual).Value.ToString
                'DataGridStencilDate.Item(0, RowActual).Value.ToString
                'Cadena = "Take stencil with Localidad: " + DataGridStencil.LocalidadEdit + ", Nombre Stencil: " + ResultStencil.Item(1, RowActual).Value.ToString


                'bdconexion.LogAdd(Cadena, EmployerNumber.Text)
                Return "Tomar"
            ElseIf radioDevolver.Checked Then
                Dim Id_User As String
                Dim StencilName As String
                Dim TotalPCB As String
                'Entrada de datos mediante un inputbox


                Id_User = InputBox("Ingrese ID operador ",
                         "Registro de ID",
                         "Id_User", 100, 0)
                StencilName = InputBox("Ingrese Nombre de stencil ",
                         "Registro de nombre del stencil",
                         "StencilName", 100, 0)

                TotalPCB = InputBox("Ingrese Tarjetas procesadas ",
                         "Registro de tarjetas procesadas",
                         "Total PCBS", 100, 0)
                If (StencilName <> "") Then
                    'MessageBox.Show("Prueba")


                    bdconexion.ReturnStencil(StencilName.ToString)
                    MsgBox(StencilName.ToString)
                    bdconexion.Conectar()
                    If (DataGridStencil.StencilNameEdit <> "") Then

                        DataGridStencil.User = Id_User
                        DataGridStencil.TotalCycle = TotalPCB
                        MessageBox.Show("El stencil si se encontro" & DataGridStencil.StencilNameEdit)
                        'Cadena = "Return stencil with Localidad: " + StencilName + ", Nombre Stencil: " + ResultStencil.Item(1, RowActual).Value.ToString
                        returnstencilform.Show()

                    Else
                        MessageBox.Show("El stencil no encontro", DataGridStencil.StencilNameEdit)

                    End If
                    bdconexion.Desconectar()
                Else
                    MessageBox.Show("Valide los datos")
                End If
                Return "Devolver"
            ElseIf radioCancelar.Checked Then
                Return "Cancelar"
            Else
                Return String.Empty
            End If
        Else
            Return String.Empty
        End If
    End Function

    Private Sub textBoxFindStencil_TextChanged(sender As Object, e As EventArgs) Handles textBoxFindStencil.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        openPanel(New Squeege)
    End Sub
End Class