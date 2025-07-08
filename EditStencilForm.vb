Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.IO
Imports System.Drawing
Imports GerberLibrary
Imports GerberLibrary.Core.Primitives
Imports System.Diagnostics

Imports GPV.Db

Public Class editstencilform

    Private TextBoxResizers As New List(Of ClassFormToolingsResizer)

    Private WithEvents FormResizer As ClassFormToolingsResizer
    'Dim Gerber As New GerberLibrary.
    'Dim Dwr As New Drawing.Graphics
    Dim bdconexion As New Db()
    WithEvents ProyectosBinding As New BindingSource
    Dim Dano As Integer
    Dim Condicion As Integer
    Dim Cadena As String
    Dim LogProyecto As String
    Private originalPictureBoxWidth As Integer
    Private originalPictureBoxHeight As Integer

    Private _formTextBoxResizer As ClassFormToolingsResizer

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
        openPanel(New Stencil)
    End Sub

    Private Sub EditStencilBtn_Click(sender As Object, e As EventArgs) Handles EditStencilBtn.Click
        openPanel(New editstencilform)
    End Sub
    Private Sub txtStencilName_Enter(sender As Object, e As EventArgs)
        'If txtStencilNameEdit.Text = "Stencil Name" Then
        'txtStencilNameEdit.Text = ""
        'txtStencilNameEdit.ForeColor = Color.ForestGreen
        'End If
    End Sub

    Private Sub txtStencilName_Leave(sender As Object, e As EventArgs)
        'If txtStencilNameEdit.Text = "" Then
        'txtStencilNameEdit.Text = "Stencil Name"
        'txtStencilNameEdit.ForeColor = Color.ForestGreen
        'End If
    End Sub
    Private Sub txtNumberPartPCB_Enter(sender As Object, e As EventArgs)
        If txtNumberPartPCBEdit.Text = "Number Part of PCB" Then
            txtNumberPartPCBEdit.Text = ""
            txtNumberPartPCBEdit.ForeColor = Color.ForestGreen
        End If
    End Sub
    Private Sub txtNumberPartPCB_Leave(sender As Object, e As EventArgs)
        If txtNumberPartPCBEdit.Text = "" Then
            txtNumberPartPCBEdit.Text = "Number Part of PCB"
            txtNumberPartPCBEdit.ForeColor = Color.ForestGreen
        End If
    End Sub
    Private Sub txtXPCB_Enter(sender As Object, e As EventArgs)
        If txtXPCBEdit.Text = "X Lengh" Then
            txtXPCBEdit.Text = ""
            txtXPCBEdit.ForeColor = Color.ForestGreen
        End If
    End Sub
    Private Sub txtXPCB_Leave(sender As Object, e As EventArgs)
        If txtXPCBEdit.Text = "" Then
            txtXPCBEdit.Text = "X Lengh"
            txtXPCBEdit.ForeColor = Color.ForestGreen
        End If
    End Sub

    Private Sub txtYPCB_Enter(sender As Object, e As EventArgs)
        If txtYPCBEdit.Text = "Y Width" Then
            txtYPCBEdit.Text = ""
            txtYPCBEdit.ForeColor = Color.ForestGreen
        End If
    End Sub

    Private Sub txtYPCB_Leave(sender As Object, e As EventArgs)
        If txtYPCBEdit.Text = "" Then
            txtYPCBEdit.Text = "Y Width"
            txtYPCBEdit.ForeColor = Color.ForestGreen
        End If
    End Sub

    Private Sub txtRevStencil_Enter(sender As Object, e As EventArgs)
        If txtRevStencilEdit.Text = "Revision" Then
            txtRevStencilEdit.Text = ""
            txtRevStencilEdit.ForeColor = Color.ForestGreen
        End If
    End Sub

    Private Sub txtRevStencil_Leave(sender As Object, e As EventArgs)
        If txtRevStencilEdit.Text = "" Then
            txtRevStencilEdit.Text = "Revision"
            txtRevStencilEdit.ForeColor = Color.ForestGreen
        End If
    End Sub

    Private Sub txtJobStencil_Enter(sender As Object, e As EventArgs)
        If txtJobStencilEdit.Text = "Job" Then
            txtJobStencilEdit.Text = ""
            txtJobStencilEdit.ForeColor = Color.ForestGreen
        End If
    End Sub

    Private Sub txtJobStencil_Leave(sender As Object, e As EventArgs)
        If txtJobStencilEdit.Text = "" Then
            txtJobStencilEdit.Text = "Job"
            txtJobStencilEdit.ForeColor = Color.ForestGreen
        End If
    End Sub

    Private Sub txtCommentsStencil_Enter(sender As Object, e As EventArgs)
        If txtCommentsStencilEdit.Text = "Ingrese comentarios" Then
            txtCommentsStencilEdit.Text = ""
            txtCommentsStencilEdit.ForeColor = Color.ForestGreen
        End If
    End Sub

    Private Sub txtCommentsStencil_Leave(sender As Object, e As EventArgs)
        If txtCommentsStencilEdit.Text = "" Then
            txtCommentsStencilEdit.Text = "Ingrese comentarios"
            txtCommentsStencilEdit.ForeColor = Color.ForestGreen
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
                'TypeOf control Is Button
                'Then
                TextBoxResizers.Add(New ClassFormToolingsResizer(Me, control))

            ElseIf TypeOf control Is Panel OrElse TypeOf control Is GroupBox Then
                InitializeTextBoxResizers(control)

            End If
        Next

    End Sub


    Private Sub editstencilform_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        InitializeTextBoxResizers(Me)
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel1))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel3))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel4))

        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, PictureBox1))



        bdconexion.Conectar()

        'ComboBoxProyectosList.DataSource = bdconexion.ConsultaComboBoxProyectos
        If (DataGridStencil.IdStencil <> "") Then
            'txtEnsambleEdit.Text = DataGridStencil.IdStencil

            txtStencilNameEdit.Text = DataGridStencil.StencilNameEdit
            txtEnsambleEdit.Text = DataGridStencil.EnsambleEdit
            txtNumberPartPCBEdit.Text = DataGridStencil.NumberPartStencilEdit

            txtRevStencilEdit.Text = DataGridStencil.RevisionEdit
            txtJobStencilEdit.Text = DataGridStencil.JobEdit
            txtLocalidadStencilEdit.Text = DataGridStencil.LocalidadEdit
            txtNum1TensionEdit.Text = DataGridStencil.Num1TensionEdit

            txtNum2TensionEdit.Text = DataGridStencil.Num2TensionEdit
            txtNum3TensionEdit.Text = DataGridStencil.Num3TensionEdit
            txtNum4TensionEdit.Text = DataGridStencil.Num4TensionEdit
            txtNum5TensionEdit.Text = DataGridStencil.Num5TensionEdit
            txtCommentsStencilEdit.Text = DataGridStencil.ComentariosStencilEdit


            'ComboBoxProyectosList.DataSource = bdconexion.ConsultaComboBoxProyectos()
            'Dim IntProyecto As Integer = Convert.ToInt32(DataGridStencil.ListProyectos)
            'ComboBoxProyectosList.SelectedIndex = IntProyecto
            DateMakeJob.Value = DataGridStencil.FechaFabricanteEdit
            DateOfAdmission.Value = DataGridStencil.FechaRegistroEdit
            txtXPCBEdit.Text = DataGridStencil.XEdit
            txtYPCBEdit.Text = DataGridStencil.YEdit
            ComboBoxProyectosList.DataSource = bdconexion.ConsultaComboBoxProyectos()
            Dim IntProyecto As Integer = Convert.ToInt32(DataGridStencil.ListProyectos)
            ComboBoxProyectosList.SelectedIndex = IntProyecto
            LogProyecto = Convert.ToString(IntProyecto)
            ComboBoxProvedoresList.DataSource = bdconexion.ConsultaComboBoxProvedores()
            Dim IntProvedor As Integer = Convert.ToInt32(DataGridStencil.ListProvedores)
            If (IntProvedor <> 0) Then

            End If
            txtCycleStencilEdit.Text = DataGridStencil.Cycles

            If DataGridStencil.DanoEdit = 0 Then
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



            ' MsgBox("Dano es " + Yes.Checked.ToString)


        End If

        bdconexion.Desconectar()



    End Sub

    Private Sub ComboBoxProyect_GotFocus(sender As Object, e As EventArgs) Handles ComboBoxProyectosList.GotFocus
        'LlenarComboProyectos()
        'ComboBoxProyect.DataSource = bdconexion.Proyectos()
    End Sub

    Private Sub UpdateStencilButton_Click(sender As Object, e As EventArgs) Handles UpdateStencilButton.Click
        'bdconexion.Conectar()

        bdconexion.ActualizarStencil(txtLocalidadStencilEdit.Text, txtStencilNameEdit.Text, txtEnsambleEdit.Text, txtNumberPartPCBEdit.Text,
        txtJobStencilEdit.Text, txtCommentsStencilEdit.Text, Condicion, Dano, ComboBoxProyectosList.SelectedIndex, DateMakeJob.Value, DateOfAdmission.Value,
        txtXPCBEdit.Text, txtYPCBEdit.Text, txtRevStencilEdit.Text, txtNum1TensionEdit.Text, txtNum2TensionEdit.Text,
        txtNum3TensionEdit.Text, txtNum4TensionEdit.Text, txtNum5TensionEdit.Text,
        ComboBoxProvedoresList.SelectedIndex, txtCycleStencilEdit.Text)


        Cadena = "Edit stencil with Localidad: " + txtLocalidadStencilEdit.Text + ", Nombre Stencil: " + txtStencilNameEdit.Text +
            ", Ensamble: " + txtEnsambleEdit.Text + ",Numero de parte PCB: " + txtNumberPartPCBEdit.Text + ", Job: " + txtJobStencilEdit.Text +
            ", Comentarios: " + txtCommentsStencilEdit.Text + ", Condicion: " + "Convert.ToString(Condicion)" + ", Dano: " + "Convert.ToString(Dano)" +
            ", Proyecto: " + "Convert.ToString(ComboBoxProyectosList.SelectedIndex)" + ", Fecha provedor: " + DateMakeJob.Value +
            ", Fecha de registro: " + DateOfAdmission.Value + " Medida X: " + txtXPCBEdit.Text + ", Medida Y: " + txtYPCBEdit.Text +
            ", Rev Stencil: " + txtRevStencilEdit.Text + ", Tension 1: " + txtNum1TensionEdit.Text + ", Tension 2: " + txtNum2TensionEdit.Text +
            ", Tension 3: " + txtNum3TensionEdit.Text + ", Tension 4: " + txtNum4TensionEdit.Text + ", Tension 5: " + txtNum5TensionEdit.Text +
            ", Provedor: " + LogProyecto


        bdconexion.LogAdd(Cadena, "000001")


    End Sub

    Private Sub DateMakeJob_ValueChanged(sender As Object, e As EventArgs) Handles DateMakeJob.ValueChanged
        DateMakeJob.CustomFormat = "yyyy-MM-dd"
    End Sub

    Private Sub DateOfAdmission_ValueChanged(sender As Object, e As EventArgs) Handles DateOfAdmission.ValueChanged
        DateOfAdmission.CustomFormat = "yyyy-MM-dd"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        openPanel(New Stencil)
    End Sub


    Private Sub Yes_CheckedChanged(sender As Object, e As EventArgs) Handles Yes.CheckedChanged

        If Yes.Checked = True Then
            Dano = "1"
            Condicion = "0"

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

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub PanelFormEditStencil_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub txtStencilNameEdit_TextChanged(sender As Object, e As EventArgs) Handles txtStencilNameEdit.TextChanged

    End Sub

    Private Sub txtNumberPartPCBEdit_TextChanged(sender As Object, e As EventArgs) Handles txtNumberPartPCBEdit.TextChanged

    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click

    End Sub

    Private Sub ComboBoxProyectosList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxProyectosList.SelectedIndexChanged

    End Sub

    Private Sub BtnAddPadFile_Click(sender As Object, e As EventArgs) Handles BtnAddPadFile.Click
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
                Dim saveFolderPath As String = "C:\PADS\" ' Ruta de la carpeta destino
                Dim fileName As String = Path.GetFileName(filePath) ' Obtiene el nombre del archivo
                Dim destinationPath As String = Path.Combine(saveFolderPath, fileName) ' Combina la ruta de la carpeta destino con el nombre del archivo
                'File.Copy(filePath, destinationPath) ' Copia el archivo a la carpeta destino

                MessageBox.Show("Archivo cargado y guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error al cargar o guardar el archivo: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub BtnAddWG_Click(sender As Object, e As EventArgs) Handles BtnAddWG.Click
        ' Crear y configurar el cuadro de diálogo de abrir archivo
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Gerber Files|*.gbr;*.gerber"
        openFileDialog.Title = "Select a Gerber File"

        ' Mostrar el cuadro de diálogo y obtener el archivo seleccionado
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName
            OpenGerberFile(filePath)
        End If
    End Sub

    Private Sub OpenGerberFile(filePath As String)
        ' Configurar el proceso para abrir gerbv con el archivo seleccionado
        Dim process As New Process()
        process.StartInfo.FileName = "C:\Users\JesusAnchondo\Desktop\GerberVS-master\GerberView\bin\Debug\GerberView.exe" ' Ruta al ejecutable de gerbv
        process.StartInfo.Arguments = filePath ' Archivo Gerber como argumento
        process.StartInfo.UseShellExecute = True
        process.StartInfo.CreateNoWindow = False

        ' Iniciar el proceso
        Try
            process.Start()
        Catch ex As Exception
            MessageBox.Show("Error al abrir el archivo Gerber: " & ex.Message)
        End Try
    End Sub
End Class