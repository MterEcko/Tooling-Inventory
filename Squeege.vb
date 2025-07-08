Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO


Public Class Squeege
    Private TextBoxResizers As New List(Of ClassFormToolingsResizer)
    Dim bdconexion As New Db()
    Dim RowActual As Int16
    Dim SelectActual As String = 0
    Public Sub hideStencil()
        PanelF.Visible = False
    End Sub
    Public Sub showStencil()

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
                TextBoxResizers.Add(New ClassFormToolingsResizer(Me, control))

            ElseIf TypeOf control Is Panel OrElse TypeOf control Is GroupBox Then
                InitializeTextBoxResizers(control)

            End If
        Next

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
        PanelForm.BringToFront()
        PanelForm.Show()
    End Sub

    Private Sub textBoxFindStencil_Enter(sender As Object, e As EventArgs) Handles textBoxFindSqueegee.Enter
        If textBoxFindSqueegee.Text = "Find Stencil" Then
            textBoxFindSqueegee.Text = ""
            textBoxFindSqueegee.ForeColor = Color.ForestGreen
        End If
    End Sub

    Private Sub textBoxFindStencil_Leave(sender As Object, e As EventArgs) Handles textBoxFindSqueegee.Leave
        If textBoxFindSqueegee.Text = "" Then
            textBoxFindSqueegee.Text = "Find Stencil"
            textBoxFindSqueegee.ForeColor = Color.ForestGreen
        End If
    End Sub

    Private Sub addStencilBtnForm_Click(sender As Object, e As EventArgs) Handles addStencilBtnForm.Click
        'openPanel(New Addstencilform)

        Dim WidthSqueegee As String
        Dim NameSqueegee As String
        Dim ComentsSqueegee As String
        'Entrada de datos mediante un inputbox
        WidthSqueegee = InputBox("Ingrese ancho del squeegee ",
                         "Registro de anchon de squeege",
                         "Ancho", 100, 0)


        If (WidthSqueegee <> "") Then

            NameSqueegee = InputBox("Ingrese Nombre de squeegee ",
                         "Registro de nombre del squeegee",
                         "Nombre", 100, 0)
            'MessageBox.Show("Prueba")
            If (WidthSqueegee <> "") Then
                ComentsSqueegee = InputBox("Ingrese comentario de squeegee ",
                         "Registro de comentario del squeegee",
                         "Comentario", 100, 0)
                If (ComentsSqueegee <> "") Then
                    bdconexion.InsertarSqueegee(WidthSqueegee, NameSqueegee, ComentsSqueegee)
                    DataGridSqueegeeDate.DataSource = bdconexion.ConsultaSquegeeDataGridViewer()

                End If

            Else
                MessageBox.Show("El Nombre esta vacio")
            End If
        Else
            MessageBox.Show("El ancho esta vacio")
        End If

    End Sub
    Private Sub editStencilBtnForm_Click(sender As Object, e As EventArgs) Handles editStencilBtnForm.Click

        Dim ComentsSqueegee = DataGridSqueegeeDate.Item(3, RowActual).Value.ToString()
        Dim WidthSqueegeeEdit = DataGridSqueegeeDate.Item(2, RowActual).Value.ToString()
        Dim NameSqueegeeEdit = DataGridSqueegeeDate.Item(1, RowActual).Value.ToString()
        Dim IdSqueegeeEdit = DataGridSqueegeeDate.Item(0, RowActual).Value.ToString()
        If (SelectActual <> "") Then
            WidthSqueegeeEdit = InputBox("Edite el ancho del squeegee ",
                         "Editar de anchon de squeege",
                         WidthSqueegeeEdit, 100, 0)
            If (WidthSqueegeeEdit <> "") Then
                NameSqueegeeEdit = InputBox("Edite el nombre del squeegee ",
                             "Registro de nombre de squeege",
                             NameSqueegeeEdit, 100, 0)
                If (NameSqueegeeEdit <> "") Then
                    ComentsSqueegee = InputBox("Ingrese comentario de squeegee ",
                         "Registro de comentario del squeegee",
                         "Comentario", 100, 0)
                    If (ComentsSqueegee <> "") Then
                        bdconexion.ActualizarSqueegee(WidthSqueegeeEdit, NameSqueegeeEdit, IdSqueegeeEdit, ComentsSqueegee)
                        DataGridSqueegeeDate.DataSource = bdconexion.ConsultaSquegeeDataGridViewer()

                    End If


                End If

            End If


            'bdconexion.ConsultarStencil(DataGridSqueegee.IdSqueegee)
            'txtStencilNameEdit
            ' openPanel(New editstencilform)
        Else
            MsgBox("Por favor seleccione un stencil")
        End If

    End Sub

    Private Sub viewLogStencilBtn_Click(sender As Object, e As EventArgs) Handles viewLogStencilBtn.Click
        openPanel(New logsqueegeform)
    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        openPanel(New dashboardPanel)
    End Sub

    Private Sub ToolingBtn_Click(sender As Object, e As EventArgs) Handles Tooling1Btn.Click
        openPanel(New Tooling)
    End Sub

    Private Sub StencilToolBtn_Click(sender As Object, e As EventArgs) Handles StencilToolBtn.Click
        openPanel(New Squeege)
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
        'TODO: esta línea de código carga datos en la tabla 'GPVDataSet.Stencil' Puede moverla o quitarla según sea necesario.
        DataGridSqueegeeDate.DataSource = bdconexion.ConsultaSquegeeDataGridViewer()


    End Sub
    Public Sub DataGridStencil_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridSqueegeeDate.CellEnter
        DataGridSqueegeeDate.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Public Sub DataGridStencilDate_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridSqueegeeDate.CellContentClick

        RowActual = DataGridSqueegeeDate.CurrentRow.Index()



        SelectActual = DataGridSqueegeeDate.Item(0, RowActual).Value.ToString

        DataGridSqueegee.IdSqueegee = SelectActual
    End Sub
    ' DESACTIVADO TEMPORALMENTE, DESACTIVAR EN DATAGRID VIEW
    Private Sub PanelF_load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub findStencilBtn_Click(sender As Object, e As EventArgs) Handles findStencilBtn.Click
        If (textBoxFindSqueegee.Text = "Find Stencil") Then
            MsgBox("Ingrese algun dato, Porfavor")
            DataGridSqueegeeDate.DataSource = bdconexion.ConsultaSquegeeDataGridViewer()
        Else
            DataGridSqueegeeDate.DataSource = bdconexion.FindSqueegeeDataGridViewer(textBoxFindSqueegee.Text)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub deleteStencilBtnForm_Click(sender As Object, e As EventArgs) Handles deleteStencilBtnForm.Click
        Dim Resultado As DialogResult

        Resultado = MessageBox.Show("Eliminar Squegue?", "Eliminar Squegue", MessageBoxButtons.OKCancel)

        If Resultado = DialogResult.OK Then
            ' Código para el caso de aceptar
            'bdconexion.DeleteUser(DataGridUser.IdUser, Orden)
            Dim Resultado2 As DialogResult

            Resultado2 = MessageBox.Show("Seguro que quiere continuar?", "Desea continuar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Resultado2 = DialogResult.Yes Then

                bdconexion.DeleteSqueege(DataGridSqueegee.IdSqueegee)
                DataGridSqueegeeDate.DataSource = bdconexion.ConsultaSquegeeDataGridViewer()
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
End Class