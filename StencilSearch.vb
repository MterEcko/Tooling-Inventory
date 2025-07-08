Public Class stencilsearch
    Dim bdconexion As New Db()
    Dim Cadena As String
    Dim RowActual As Int16
    Dim SelectActual As String = 0
    Dim IdUser As String
    Private Sub tooling(sender As Object, e As EventArgs) Handles MyBase.Load
        ResultStencil.DataSource = bdconexion.ConsultaStencilDataGridViewer()
        AjustarColumnasDataGridView()
        ResultStencil.ReadOnly = True
        'Dim totalPorcentaje As Integer = 100
        'Dim porcentajes() As Integer = {10, 30, 15, 15, 30} ' Ajusta los porcentajes según tus necesidades

        'For i As Integer = 0 To ResultStencil.Columns.Count - 1
        'ResultStencil.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        'ResultStencil.Columns(i).Width = CInt(ResultStencil.Width * (porcentajes(i) / totalPorcentaje))
        'Next
    End Sub


    Private Sub tooling_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        AjustarColumnasDataGridView()
    End Sub

    Private Sub AjustarColumnasDataGridView()
        ' Supongamos que tu DataGridView se llama dgvDatos y tienes 5 columnas
        Dim totalPorcentaje As Integer = 100
        Dim porcentajes() As Integer = {5, 5, 20, 15, 20, 32} ' Ajusta los porcentajes según tus necesidades

        For i As Integer = 0 To ResultStencil.Columns.Count - 1
            ResultStencil.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.None
            ResultStencil.Columns(i).Width = CInt(ResultStencil.Width * (porcentajes(i) / totalPorcentaje))
        Next
    End Sub

    Private Sub ResultStencil_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ResultStencil.CellFormatting
        ' Supongamos que la columna que deseas ocultar se encuentra en el índice 1
        If e.ColumnIndex = 1 Then
            ' Asignamos el valor de la celda como un espacio en blanco para ocultarlo
            e.Value = "***"
            e.FormattingApplied = True
        End If
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles FindStencil.Click
        'ResultStencil.Visible = False
        'If (DataGridStencil.IdStencil <> "") Then
        'bdconexion.ConsultarStencil(DataGridStencil.IdStencil)

        'txtStencilNameEdit
        'Else
        'MsgBox("Por favor seleccione un stencil")
        'End If
        If (TxtFind.Text = "Find Stencil") Then
            MsgBox("Ingrese algun dato, Porfavor")
            ResultStencil.DataSource = bdconexion.ConsultaStencilDataGridViewer()
        Else
            ResultStencil.DataSource = bdconexion.FindStencilDataGridViewer(TxtFind.Text)
        End If


    End Sub


    Private Sub minuslogin_Click(sender As Object, e As EventArgs)
        WindowState = FormWindowState.Minimized
    End Sub


    Public Sub take_Click(sender As Object, e As EventArgs) Handles take.Click

        MsgBox("Tomar stencil de localidad" + ResultStencil.Item(1, RowActual).Value.ToString)

        Cadena = "Take stencil with Localidad: " + DataGridStencil.LocalidadEdit + ", Nombre Stencil: " + ResultStencil.Item(1, RowActual).Value.ToString


        bdconexion.LogAdd(Cadena, EmployerNumber.Text)

        TxtFind.Visible = False
        FindStencil.Visible = False
        ResultStencil.Visible = False
        take.Visible = False
        ReturnTooling.Visible = False
        Back.Visible = False
        EmployerNumber.Visible = True
        Roperator.Visible = True
        EmployerNumber.Text = "Employer Number"
    End Sub
    Private Sub textBoxFindStencil_Enter(sender As Object, e As EventArgs) Handles EmployerNumber.Enter
        If EmployerNumber.Text = "Employer Number" Then
            EmployerNumber.Text = ""
            EmployerNumber.ForeColor = Color.ForestGreen
        End If
    End Sub

    Private Sub textBoxFindStencil_Leave(sender As Object, e As EventArgs) Handles EmployerNumber.Leave
        If EmployerNumber.Text = "" Then
            EmployerNumber.Text = "Employer Number"
            EmployerNumber.ForeColor = Color.ForestGreen
        End If
    End Sub
    Private Sub TxtFind_TextChanged(sender As Object, e As EventArgs) Handles TxtFind.TextChanged

    End Sub

    Private Sub Roperator_Click(sender As Object, e As EventArgs) Handles Roperator.Click
        TxtFind.Visible = True
        FindStencil.Visible = True
        ResultStencil.Visible = True
        take.Visible = True
        ReturnTooling.Visible = True
        Back.Visible = True
        EmployerNumber.Visible = False
        Roperator.Visible = False
        IdUser = EmployerNumber.Text

    End Sub


    Private Sub EmployerNumber_TextChanged(sender As Object, e As EventArgs) Handles EmployerNumber.TextChanged

    End Sub
    Private Sub EmployerNumber_KeyDown(sender As Object, e As KeyEventArgs) Handles EmployerNumber.KeyDown
        ' Verifica si la tecla presionada es Enter
        If e.KeyCode = Keys.Enter Then
            ' Ejecuta el código que desees al presionar Enter
            Roperator_Click(sender, e)
        End If
    End Sub

    Private Sub Formfind_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResultStencil.Visible = False
        TxtFind.Visible = False
        FindStencil.Visible = False
        take.Visible = False
        ReturnTooling.Visible = False
        Back.Visible = False

    End Sub

    Private Sub ReturnTooling_Click(sender As Object, e As EventArgs) Handles ReturnTooling.Click



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
                MessageBox.Show("Cargando la informacion del stencil " & DataGridStencil.StencilNameEdit)
                'Cadena = "Return stencil with Localidad: " + StencilName + ", Nombre Stencil: " + ResultStencil.Item(1, RowActual).Value.ToString
                returnstencilform.Show()
                TxtFind.Visible = False
                FindStencil.Visible = False
                ResultStencil.Visible = False
                take.Visible = False
                ReturnTooling.Visible = False
                Back.Visible = False
                EmployerNumber.Visible = True
                Roperator.Visible = True
                EmployerNumber.Text = "Employer Number"

            Else
                MessageBox.Show("El stencil no se pudo encontrar, valide su nombre")

            End If
            bdconexion.Desconectar()
        Else
                MessageBox.Show("Prueba            2 validar")
        End If
        'MessageBox.Show("Stencil devuelto: " + StencilName,
        '               "Registro de Datos Personales",
        'MessageBoxButtons.OK,
        'MessageBoxIcon.Information)
        'Cadena = "Return stencil with Localidad: " + StencilName + ", Nombre Stencil: " + ResultStencil.Item(1, RowActual).Value.ToString


        'bdconexion.LogAdd(Cadena, Id_User)
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        TxtFind.Visible = False
        FindStencil.Visible = False
        ResultStencil.Visible = False
        take.Visible = False
        ReturnTooling.Visible = False
        Back.Visible = False
        EmployerNumber.Visible = True
        Roperator.Visible = True
    End Sub

    Private Sub ResultStencil_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles ResultStencil.CellEnter
        ResultStencil.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Public Sub ResultStencil_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ResultStencil.CellContentClick

        RowActual = ResultStencil.CurrentRow.Index()



        SelectActual = ResultStencil.Item(1, RowActual).Value.ToString

        DataGridStencil.IdStencil = SelectActual
    End Sub


End Class