Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO


Public Class Assemble
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
        PanelForm.BringToFront()
        PanelForm.Show()
    End Sub

    Private Sub textBoxFindStencil_Enter(sender As Object, e As EventArgs)
        If textBoxFindAssembly.Text = "Find Assembly" Then
            textBoxFindAssembly.Text = ""
            textBoxFindAssembly.ForeColor = Color.ForestGreen
        End If
    End Sub

    Private Sub textBoxFindStencil_Leave(sender As Object, e As EventArgs)
        If textBoxFindAssembly.Text = "" Then
            textBoxFindAssembly.Text = "Find Assembly"
            textBoxFindAssembly.ForeColor = Color.ForestGreen
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

    Private Sub ToolingBtn_Click(sender As Object, e As EventArgs)
        openPanel(New Tooling)
    End Sub

    Private Sub StencilToolBtn_Click(sender As Object, e As EventArgs) Handles StencilToolBtn.Click
        openPanel(New Stencil)
    End Sub


    Private Sub toolingRouterBtn_Click(sender As Object, e As EventArgs) Handles toolingBtn.Click
        openPanel(New Tooling)
    End Sub


    Public Sub DataGridStencil_CellEnter(sender As Object, e As DataGridViewCellEventArgs)
        DataGridStencilDate.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Public Sub DataGridStencilDate_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

        Dim RowActual As Int16
        Dim SelectActual As String = 0
        RowActual = DataGridStencilDate.CurrentRow.Index()



        SelectActual = DataGridStencilDate.Item(0, RowActual).Value.ToString

        DataGridStencil.IdStencil = SelectActual
    End Sub
    ' DESACTIVADO TEMPORALMENTE, DESACTIVAR EN DATAGRID VIEW
    Private Sub PanelF_load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        InitializeTextBoxResizers(Me)

        'TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel1))
        'Panel1.Size = New Size((Panel1.Size.Width / 100) * 98, Panel1.Size.Height)
        'TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel3))
        'TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel4))
        'TODO: esta línea de código carga datos en la tabla 'GPVDataSet.Stencil' Puede moverla o quitarla según sea necesario.
        DataGridStencilDate.DataSource = bdconexion.ConsultaStencilDataGridViewer()


    End Sub

    Private Sub findAssemblyBtn_Click(sender As Object, e As EventArgs)
        If (textBoxFindAssembly.Text = "Find Stencil") Then
            MsgBox("Ingrese algun dato, Porfavor")
            DataGridStencilDate.DataSource = bdconexion.ConsultaStencilDataGridViewer()
        Else
            DataGridStencilDate.DataSource = bdconexion.FindStencilDataGridViewer(textBoxFindAssembly.Text)
        End If

    End Sub

    Private Sub textBoxFindAssembly_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

        If Asc(e.KeyChar) = 13 Then
            If (textBoxFindAssembly.Text = "Find Stencil") Then
                MsgBox("Ingrese algun dato, Porfavor")
                DataGridStencilDate.DataSource = bdconexion.ConsultaStencilDataGridViewer()
            Else
                DataGridStencilDate.DataSource = bdconexion.FindStencilDataGridViewer(textBoxFindAssembly.Text)
            End If
        End If

    End Sub

End Class