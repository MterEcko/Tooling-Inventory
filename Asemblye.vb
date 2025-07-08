Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO


Public Class Asemblye
    Private TextBoxResizers As New List(Of ClassFormToolingsResizer)

    Private WithEvents FormResizer As ClassFormToolingsResizer

    Dim bdconexion As New Db()

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

    Private Sub textBoxFindStencil_Enter(sender As Object, e As EventArgs) Handles textBoxFindAsembly.Enter
        If textBoxFindAsembly.Text = "Find Stencil" Then
            textBoxFindAsembly.Text = ""
            textBoxFindAsembly.ForeColor = Color.ForestGreen
        End If
    End Sub

    Private Sub textBoxFindStencil_Leave(sender As Object, e As EventArgs) Handles textBoxFindAsembly.Leave
        If textBoxFindAsembly.Text = "" Then
            textBoxFindAsembly.Text = "Find Stencil"
            textBoxFindAsembly.ForeColor = Color.ForestGreen
        End If
    End Sub

    Private Sub addStencilBtnForm_Click(sender As Object, e As EventArgs)
        openPanel(New Addstencilform)
    End Sub
    Private Sub editStencilBtnForm_Click(sender As Object, e As EventArgs)

        If (DataGridStencil.IdStencil <> "") Then
            bdconexion.ConsultarStencil(DataGridStencil.IdStencil)
            'txtStencilNameEdit
            openPanel(New editstencilform)
        Else
            MsgBox("Por favor seleccione un stencil")
        End If

    End Sub

    Private Sub viewLogStencilBtn_Click(sender As Object, e As EventArgs)
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
        'Dim screenSize As Size = Screen.PrimaryScreen.WorkingArea.Size

        ' Definir los porcentajes para el ancho y el alto del formulario
        'Dim widthPercentage As Double = 0.8 ' Porcentaje del ancho de la pantalla
        'Dim heightPercentage As Double = 0.8 ' Porcentaje del alto de la pantalla

        ' Calcular el tamaño del formulario en función de los porcentajes
        'Dim newWidth As Integer = CInt(screenSize.Width * widthPercentage)
        'Dim newHeight As Integer = CInt(screenSize.Height * heightPercentage)

        ' Establecer el nuevo tamaño del formulario
        'Me.Size = New Size(newWidth, newHeight)
        'InitializeTextBoxResizers(Me)

        'TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel1))
        'Panel1.Size = New Size((Panel1.Size.Width / 100) * 98, Panel1.Size.Height)
        'TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel3))
        'TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel4))
        'TODO: esta línea de código carga datos en la tabla 'GPVDataSet.Stencil' Puede moverla o quitarla según sea necesario.
        'DataGridStencilDate.DataSource = bdconexion.ConsultaStencilDataGridViewer()


    End Sub
    Public Sub DataGridStencil_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridAsemblys.CellEnter
        DataGridAsemblys.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Public Sub DataGridAsembly_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridAsemblys.CellContentClick

        Dim RowActual As Int16
        Dim SelectActual As String = 0
        RowActual = DataGridAsemblys.CurrentRow.Index()



        SelectActual = DataGridAsemblys.Item(0, RowActual).Value.ToString

        DataGridAsembly.IdAsembly = SelectActual
    End Sub
    ' DESACTIVADO TEMPORALMENTE, DESACTIVAR EN DATAGRID VIEW
    Private Sub PanelF_load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeTextBoxResizers(Me)

        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel1))
        'Panel1.Size = New Size((Panel1.Size.Width / 100) * 98, Panel1.Size.Height)
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel3))
        'TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel4))
        'TODO: esta línea de código carga datos en la tabla 'GPVDataSet.Stencil' Puede moverla o quitarla según sea necesario.
        DataGridAsemblys.DataSource = bdconexion.ConsultaAsemblyDataGridViewer()
    End Sub

    Private Sub findStencilBtn_Click(sender As Object, e As EventArgs) Handles findStencilBtn.Click
        If (textBoxFindAsembly.Text = "Find Stencil") Then
            MsgBox("Ingrese algun dato, Porfavor")
            DataGridAsemblys.DataSource = bdconexion.ConsultaAsemblyDataGridViewer()
        Else
            DataGridAsemblys.DataSource = bdconexion.FindAssemblyDataGridViewer(textBoxFindAsembly.Text)
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub textBoxFindStencil_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textBoxFindAsembly.KeyPress

        If Asc(e.KeyChar) = 13 Then
            If (textBoxFindAsembly.Text = "Find Stencil") Then
                MsgBox("Ingrese algun dato, Porfavor")
                DataGridAsemblys.DataSource = bdconexion.ConsultaAsemblyDataGridViewer()
            Else
                DataGridAsemblys.DataSource = bdconexion.FindAssemblyDataGridViewer(textBoxFindAsembly.Text)
            End If
        End If

    End Sub

    Private Sub textBoxFindStencil_TextChanged(sender As Object, e As EventArgs) Handles textBoxFindAsembly.TextChanged

    End Sub

    Private Sub PanelF_Paint(sender As Object, e As PaintEventArgs) Handles PanelF.Paint

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        openPanel(New palletsearch)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        openPanel(New Addstencilform)
    End Sub

    Private Sub DeleteStencilBtnForm_Click(sender As Object, e As EventArgs)
        If (DataGridAsembly.IdAsembly <> "") Then

            'txtStencilNameEdit
            Eliminar()
            DataGridAsembly.IdAsembly = ""
        Else
            MsgBox("Por favor seleccione un ensamble")
        End If



    End Sub
    Sub Eliminar()
        Dim Resultado As DialogResult

        Resultado = MessageBox.Show("Eliminar Ensamble?", "Eliminar Ensamble", MessageBoxButtons.OKCancel)

        If Resultado = DialogResult.OK Then
            ' Código para el caso de aceptar
            'bdconexion.DeleteUser(DataGridUser.IdUser, Orden)
            Dim Resultado2 As DialogResult

            Resultado2 = MessageBox.Show("Seguro que quiere continuar?", "Desea continuar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Resultado2 = DialogResult.Yes Then

                bdconexion.DeleteStencil(DataGridAsembly.IdAsembly)
                DataGridAsemblys.DataSource = bdconexion.ConsultaAsemblyDataGridViewer()
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (DataGridStencil.IdStencil <> "") Then
            bdconexion.ConsultarStencil(DataGridStencil.IdStencil)
            'txtStencilNameEdit
            openPanel(New editstencilform)
        Else
            MsgBox("Por favor seleccione un stencil")
        End If
    End Sub
End Class