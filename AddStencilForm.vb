Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO


Public Class Addstencilform

    Private TextBoxResizers As New List(Of ClassFormToolingsResizer)

    'Private WithEvents FormResizer As ClassFormToolingsResizer
    'Private originalPictureBoxHeight As Integer
    'Private _formTextBoxResizer As ClassFormToolingsResizer

    Dim bdconexion As New Db()
    Dim Cadena As String
    Dim LogProyecto As String
    Dim Dano As Integer
    Dim Condicion As Integer

    Public Sub HideForm()
        PanelF.Visible = False
    End Sub
    Public Sub ShowForm()

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

    Private Sub txtStencilName_Enter(sender As Object, e As EventArgs)
        If txtStencilName.Text = "Stencil Name" Then
            txtStencilName.Text = ""
            txtStencilName.ForeColor = Color.ForestGreen
        End If
    End Sub

    Private Sub txtStencilName_Leave(sender As Object, e As EventArgs)
        If txtStencilName.Text = "" Then
            txtStencilName.Text = "Stencil Name"
            txtStencilName.ForeColor = Color.ForestGreen
        End If
    End Sub
    Private Sub txtNumberPartPCB_Enter(sender As Object, e As EventArgs)
        If txtNumberPartPCB.Text = "Number Part of PCB" Then
            txtNumberPartPCB.Text = ""
            txtNumberPartPCB.ForeColor = Color.ForestGreen
        End If
    End Sub
    Private Sub txtNumberPartPCB_Leave(sender As Object, e As EventArgs)
        If txtNumberPartPCB.Text = "" Then
            txtNumberPartPCB.Text = "Number Part of PCB"
            txtNumberPartPCB.ForeColor = Color.ForestGreen
        End If
    End Sub
    Private Sub txtXPCB_Enter(sender As Object, e As EventArgs)
        If txtXPCB.Text = "X Lengh" Then
            txtXPCB.Text = ""
            txtXPCB.ForeColor = Color.ForestGreen
        End If
    End Sub
    Private Sub txtXPCB_Leave(sender As Object, e As EventArgs)
        If txtXPCB.Text = "" Then
            txtXPCB.Text = "X Lengh"
            txtXPCB.ForeColor = Color.ForestGreen
        End If
    End Sub

    Private Sub txtYPCB_Enter(sender As Object, e As EventArgs)
        If txtYPCB.Text = "Y Width" Then
            txtYPCB.Text = ""
            txtYPCB.ForeColor = Color.ForestGreen
        End If
    End Sub

    Private Sub txtYPCB_Leave(sender As Object, e As EventArgs)
        If txtYPCB.Text = "" Then
            txtYPCB.Text = "Y Width"
            txtYPCB.ForeColor = Color.ForestGreen
        End If
    End Sub

    Private Sub txtRevStencil_Enter(sender As Object, e As EventArgs)
        If txtRevStencil.Text = "Revision" Then
            txtRevStencil.Text = ""
            txtRevStencil.ForeColor = Color.ForestGreen
        End If
    End Sub

    Private Sub txtRevStencil_Leave(sender As Object, e As EventArgs)
        If txtRevStencil.Text = "" Then
            txtRevStencil.Text = "Revision"
            txtRevStencil.ForeColor = Color.ForestGreen
        End If
    End Sub

    Private Sub txtJobStencil_Enter(sender As Object, e As EventArgs)
        If txtJobStencil.Text = "Job" Then
            txtJobStencil.Text = ""
            txtJobStencil.ForeColor = Color.ForestGreen
        End If
    End Sub

    Private Sub txtJobStencil_Leave(sender As Object, e As EventArgs)
        If txtJobStencil.Text = "" Then
            txtJobStencil.Text = "Job"
            txtJobStencil.ForeColor = Color.ForestGreen
        End If
    End Sub

    Private Sub txtCommentsStencil_Enter(sender As Object, e As EventArgs)
        If txtCommentsStencil.Text = "Ingrese comentarios" Then
            txtCommentsStencil.Text = ""
            txtCommentsStencil.ForeColor = Color.ForestGreen
        End If
    End Sub

    Private Sub txtCommentsStencil_Leave(sender As Object, e As EventArgs)
        If txtCommentsStencil.Text = "" Then
            txtCommentsStencil.Text = "Ingrese comentarios"
            txtCommentsStencil.ForeColor = Color.ForestGreen
        End If
    End Sub

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
    Private Sub CallAdd()
        bdconexion.Conectar()
        DataGridStencil.FechaFabricanteEdit = "2023-01-01"
        DataGridStencil.FechaRegistroEdit = Date.Today
        'DateOfAdmissionAdd.Value.Date.ToString()
        'MsgBox(DataGridStencil.FechaRegistroEdit)
        DateMakeJobAdd.Value = DataGridStencil.FechaFabricanteEdit
        DateOfAdmissionAdd.Value = DataGridStencil.FechaRegistroEdit
        ComboBoxProyectosListAdd.DataSource = bdconexion.ConsultaComboBoxProyectos()
        Dim IntProyecto As Integer = Convert.ToInt32(DataGridStencil.ListProyectos)
        ComboBoxProyectosListAdd.SelectedIndex = 0
        LogProyecto = Convert.ToString(IntProyecto)
        ComboBoxProvedoresListAdd.DataSource = bdconexion.ConsultaComboBoxProvedores()
        Dim IntProvedor As Integer = Convert.ToInt32(DataGridStencil.ListProvedores)
        'TODO: This line of code loads data into the 'GPVGROUPDataSet1.Proyects' table. You can move, or remove it, as needed.
        bdconexion.Desconectar()
        Dim Fecha = Date.Today()
    End Sub
    Private Sub addstencilform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeTextBoxResizers(Me)
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel1))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel3))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel4))
        'TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel1))
        'Panel1.Size = New Size((Panel1.Size.Width / 100) * 98, Panel1.Size.Height)
        'TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel3))
        'TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel4))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, PictureBox1))

        'Dim di As New DirectoryInfo(Directorio)
        'Dim fics() As FileInfo
        'fics = di.GetFiles(Filtro, SearchOption.AllDirectories)
        'MsgBox(Panel1.Size.Width.ToString + " el width y el heigh:" + Panel1.Size.Height.ToString)
        'MsgBox("dd")

        'CallAdd()
        'TODO: esta línea de código carga datos en la tabla 'GPVDataSet.Stencil' Puede moverla o quitarla según sea necesario.
        bdconexion.Conectar()
        ComboBoxProyectosListAdd.DataSource = bdconexion.ConsultaComboBoxProyectos()
        Dim IntProyecto As Integer = Convert.ToInt32(DataGridStencil.ListProyectos)
        ComboBoxProyectosListAdd.SelectedIndex = 0
        bdconexion.Desconectar()
        'LogProyecto = Convert.ToString(IntProyecto)
        bdconexion.Conectar()
        ComboBoxProvedoresListAdd.DataSource = bdconexion.ConsultaComboBoxProvedores()
        Dim IntProvedor As Integer = Convert.ToInt32(DataGridStencil.ListProvedores)
        ComboBoxProvedoresListAdd.SelectedIndex = 0
        bdconexion.Desconectar()
        If (IntProvedor <> 0) Then

        End If

        Yes.Checked = False

        No.Checked = True
        'MsgBox("Yes esta activado" + Yes.Checked.ToString)


    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click
        OpenPanel(New dashboardPanel)
    End Sub

    Private Sub ToolingBtn_Click(sender As Object, e As EventArgs) Handles toolingBtn.Click
        OpenPanel(New Tooling)
    End Sub

    Private Sub StencilToolBtn_Click(sender As Object, e As EventArgs) Handles StencilTool1Btn.Click, StencilToolBtn.Click
        OpenPanel(New Stencil)
    End Sub

    Private Sub NewStencilBtn_Click(sender As Object, e As EventArgs) Handles NewStencilBtn.Click
        OpenPanel(New Addstencilform)
    End Sub

    Private Sub PanelF_Paint(sender As Object, e As PaintEventArgs) Handles PanelF.Paint

    End Sub

    Private Sub AddStencilButton_Click_1(sender As Object, e As EventArgs) Handles AddStencilButton.Click
        'bdconexion.Conectar()
        bdconexion.InsertarStencil(txtlocalidadStencil.Text, txtStencilName.Text, txtEnsamble.Text, txtNumberPartPCB.Text,
        txtJobStencil.Text, txtCommentsStencil.Text, ComboBoxProyectosListAdd.SelectedIndex, DateMakeJobAdd.Value, DateOfAdmissionAdd.Value,
        txtXPCB.Text, txtYPCB.Text, txtRevStencil.Text, txtNum1Tension.Text, txtNum2Tension.Text, txtNum3Tension.Text,
        txtNum4Tension.Text, txtNum5Tension.Text, ComboBoxProvedoresListAdd.SelectedIndex, txtCycleStencil.Text)

        Cadena = "Add Stencil with Localidad: " + txtlocalidadStencil.Text + ", Nombre Stencil: " + txtStencilName.Text +
           ", Ensamble: " + txtEnsamble.Text + ",Numero de parte PCB: " + txtNumberPartPCB.Text + ", Job: " + txtJobStencil.Text +
           ", Comentarios: " + txtCommentsStencil.Text + ", Condicion: " + "Convert.ToString(Condicion)" + ", Dano: " + "Convert.ToString(Dano)" +
           ", Proyecto: " + "Convert.ToString(ComboBoxProyectosList.SelectedIndex)" + ", Fecha provedor: " + DateMakeJobAdd.Value +
           ", Fecha de registro: " + DateOfAdmissionAdd.Value + " Medida X: " + txtXPCB.Text + ", Medida Y: " + txtYPCB.Text +
           ", Rev Stencil: " + txtRevStencil.Text + ", Tension 1: " + txtNum1Tension.Text + ", Tension 2: " + txtNum2Tension.Text +
           ", Tension 3: " + txtNum3Tension.Text + ", Tension 4: " + txtNum4Tension.Text + ", Tension 5: " + txtNum5Tension.Text +
           ", Provedor: " + LogProyecto + ", Ciclo: " + txtCycleStencil.Text


        bdconexion.LogAdd(Cadena, "000001")


    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub DateMakeJobAdd_ValueChanged(sender As Object, e As EventArgs) Handles DateMakeJobAdd.ValueChanged
        DateMakeJobAdd.CustomFormat = "yyyy-MM-dd"
    End Sub

    Private Sub DateOfAdmissionAdd_ValueChanged(sender As Object, e As EventArgs) Handles DateOfAdmissionAdd.ValueChanged
        DateOfAdmissionAdd.CustomFormat = "yyyy-MM-dd"
    End Sub

    Private Sub ReturnButton_Click(sender As Object, e As EventArgs) Handles ReturnButton.Click
        OpenPanel(New Stencil)
    End Sub

    Private Sub ComboBoxProyectosListAdd_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxProyectosListAdd.SelectedIndexChanged

    End Sub

    Private Sub No_CheckedChanged(sender As Object, e As EventArgs) Handles No.CheckedChanged
        If Yes.Checked = True Then
            Dano = "1"
            Condicion = "0"

            'MsgBox("Dano es " + Yes.Checked.ToString)
        End If
    End Sub

    Private Sub Yes_CheckedChanged(sender As Object, e As EventArgs) Handles Yes.CheckedChanged
        'MsgBox("Yes esta activado" + Yes.Checked.ToString)
        If Yes.Checked = False Then
            Dano = "0"
            Condicion = "0"
            'MsgBox("Dano es " + Yes.Checked.ToString)
        Else
            Dano = "1"
            Condicion = "1"
        End If
    End Sub

    Private Sub localidadStencil_TextChanged(sender As Object, e As EventArgs) Handles txtlocalidadStencil.TextChanged

    End Sub

    Private Sub Addstencilform_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        'InitializeTextBoxResizers(Me)
        'TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel1))
        'TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel3))
        'TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel4))
        'TextBoxResizers.Add(New ClassFormToolingsResizer(Me, PictureBox1))
        Dim Prueba = Panel1.Size.Width
        'Panel1.Size = New Size((Panel1.Size.Width / 100) * 98, Panel1.Size.Height)
        'MsgBox(Prueba.ToString + " el width sin 1% y el width en resize:" + Panel1.Size.Width.ToString)
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    Private Sub ButtonAddPadFile_Click(sender As Object, e As EventArgs) Handles BtnAddPadFile.Click
        ' Configura y muestra el cuadro de diálogo para abrir archivo
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Archivos PADXS (*.PADX)|*.gbr|Archivos PADS (*.pad)|*.pad|Todos los archivos (*.*)|*.*"
        openFileDialog.FilterIndex = 1
        openFileDialog.RestoreDirectory = True

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                ' Obtiene la ruta del archivo seleccionado por el usuario
                Dim filePath As String = openFileDialog.FileName

                ' Realiza alguna operación con el archivo cargado (por ejemplo, mostrar su contenido)
                ' Aquí puedes agregar tu lógica para manejar el archivo cargado
                ' Por ejemplo, puedes mostrar su contenido en un control TextBox:
                Dim fileContent As String = File.ReadAllText(filePath)
                Dim Ruta As String = Path.GetDirectoryName(filePath) + "\" + Path.GetFileName(filePath)
                TextBox1.Text = Ruta

                ' También puedes guardar el archivo en una ubicación específica
                ' Por ejemplo, para copiarlo a una carpeta seleccionada por el usuario:
                Dim saveFolderPath As String = "C:\Pruebas\" ' Ruta de la carpeta destino
                Dim fileName As String = Path.GetFileName(filePath) ' Obtiene el nombre del archivo
                Dim destinationPath As String = Path.Combine(saveFolderPath, fileName) ' Combina la ruta de la carpeta destino con el nombre del archivo
                'File.Copy(filePath, destinationPath) ' Copia el archivo a la carpeta destino

                MessageBox.Show("Archivo cargado y guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al cargar o guardar el archivo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub BtnAddWG_Click(sender As Object, e As EventArgs) Handles BtnAddWG.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Archivos PADXS (*.PADX)|*.gbr|Archivos PADS (*.pad)|*.pad|Todos los archivos (*.*)|*.*"
        openFileDialog.FilterIndex = 1
        openFileDialog.RestoreDirectory = True

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                ' Obtiene la ruta del archivo seleccionado por el usuario
                Dim filePath As String = openFileDialog.FileName

                ' Realiza alguna operación con el archivo cargado (por ejemplo, mostrar su contenido)
                ' Aquí puedes agregar tu lógica para manejar el archivo cargado
                ' Por ejemplo, puedes mostrar su contenido en un control TextBox:
                Dim fileContent As String = File.ReadAllText(filePath)
                Dim Ruta As String = Path.GetDirectoryName(filePath) + "\" + Path.GetFileName(filePath)
                TextBox2.Text = Ruta

                ' También puedes guardar el archivo en una ubicación específica
                ' Por ejemplo, para copiarlo a una carpeta seleccionada por el usuario:
                Dim saveFolderPath As String = "C:\Pruebas\" ' Ruta de la carpeta destino
                Dim fileName As String = Path.GetFileName(filePath) ' Obtiene el nombre del archivo
                Dim destinationPath As String = Path.Combine(saveFolderPath, fileName) ' Combina la ruta de la carpeta destino con el nombre del archivo
                'File.Copy(filePath, destinationPath) ' Copia el archivo a la carpeta destino

                MessageBox.Show("Archivo cargado y guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al cargar o guardar el archivo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class