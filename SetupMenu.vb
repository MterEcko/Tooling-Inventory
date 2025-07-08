Public Class SetupMenu
    Private TextBoxResizers As New List(Of ClassFormToolingsResizer)
    Dim bdconexion As New Db()
    Dim RowActual As Int16
    Dim SelectActual As String = 0
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
    Private Sub hideStencil()
        PanelF.Visible = False
    End Sub
    Private Sub showStencil()

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


    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click, HomeBtn.Click
        openPanel(New dashboardPanel)
    End Sub

    Private Sub allUserBtn_Click(sender As Object, e As EventArgs) Handles allUserBtn.Click
        openPanel(New alluser)
    End Sub


    Public Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewSupplier.CellEnter
        DataGridViewSupplier.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'MsgBox(DataGridUser.IdUser)

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewSupplier.CellClick
        If e.RowIndex >= 0 Then ' Asegúrate de que se hizo clic en una fila, no en los encabezados de columna
            Dim RowActual As Int16
            Dim SelectActual As String = ""
            RowActual = e.RowIndex

            SelectActual = DataGridViewSupplier.Item(0, RowActual).Value.ToString()

            DataGridUser.IdUser = SelectActual

        End If
    End Sub


    Private Sub alluser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridViewSupplier.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewProyect.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridViewExtra.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        InitializeTextBoxResizers(Me)
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, PanelF))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel1))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel3))

        DataGridViewSupplier.DataSource = bdconexion.ConsultaSupplierDataGridView()
        DataGridViewProyect.DataSource = bdconexion.ConsultaProyectsDataGridView()
        DataGridViewExtra.DataSource = bdconexion.ConsultaExtraDataGridView()
        TabControlSetup.SelectedIndex = DataGridPallet.IdSetup
        'DataGridUser.IdUser = vbEmpty
    End Sub

    Private Sub textBoxFindUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textBoxFindUser.KeyPress
        If (textBoxFindUser.Text = "Find Stencil") Then
            MsgBox("Ingrese algun dato, Porfavor")
            DataGridViewSupplier.DataSource = bdconexion.ConsultaSupplierDataGridView()
        ElseIf (TabControlSetup.SelectedIndex = "0") Then
            DataGridViewSupplier.DataSource = bdconexion.FindSupplierDataGridView(textBoxFindUser.Text)
        ElseIf (TabControlSetup.SelectedIndex = "1") Then
            DataGridViewProyect.DataSource = bdconexion.FindProyectsDataGridView(textBoxFindUser.Text)
        ElseIf (TabControlSetup.SelectedIndex = "2") Then
            DataGridViewExtra.DataSource = bdconexion.FindExtraDataGridViewer(textBoxFindUser.Text)
        End If
    End Sub


    Private Sub AddSupplierBtnForm_Click(sender As Object, e As EventArgs) Handles AddSupplierBtnForm.Click
        Dim Supplier As String
        Dim PhoneNumber As String
        Dim Address As String
        Dim SuplierContact As String
        'Entrada de datos mediante un inputbox
        Supplier = InputBox("Ingrese Provedor ",
                         "Registro de Provedor",
                         "Provedor", 100, 0)

        If (Supplier <> "") Then

            PhoneNumber = InputBox("Ingrese numero telefonico ",
                         "Registro de contacto",
                         "Numero", 100, 0)
            If (PhoneNumber <> "") Then
                Address = InputBox("Ingrese Direccion ",
                         "Registro de direccion",
                         "Direccion", 100, 0)
                If (Address <> "") Then
                    SuplierContact = InputBox("Ingrese Contacto del Provedor(Nombre)",
                         "Registro de Nombre de provedor",
                         "Nombre", 100, 0)
                    If (SuplierContact <> "") Then
                        bdconexion.InsertarProvedor(Supplier, PhoneNumber, Address, SuplierContact)
                        DataGridViewSupplier.DataSource = bdconexion.ConsultaSupplierDataGridView()
                    Else
                        MessageBox.Show("El nombre del provedor esta vacio")
                    End If
                Else
                    MessageBox.Show("La dirrecion esta vacia")
                End If

            Else
                MessageBox.Show("El contacto esta vacio")
            End If



        Else
            MessageBox.Show("El Provedor esta vacio")
        End If

    End Sub


    Private Sub AddProyectBtnForm_Click(sender As Object, e As EventArgs) Handles AddProyectBtnForm.Click
        Dim Proyect As String
        'Entrada de datos mediante un inputbox
        Proyect = InputBox("Ingrese proyecto ",
                         "Registro del nombre del proyecto",
                         "Proyecto", 100, 0)

        If (Proyect <> "") Then
            bdconexion.InsertarProyecto(Proyect)
            DataGridViewProyect.DataSource = bdconexion.ConsultaProyectsDataGridView()

        Else
            MessageBox.Show("El Nombre esta vacio")
        End If
    End Sub
    Public Sub DataGridViewSupplier_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewSupplier.CellEnter
        DataGridViewSupplier.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub

    Public Sub DataGridViewProyect_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewProyect.CellEnter
        DataGridViewProyect.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub
    Public Sub DataGridViewExtra_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewExtra.CellEnter
        DataGridViewExtra.SelectionMode = DataGridViewSelectionMode.FullRowSelect

    End Sub
    Public Sub DataGridViewSupplier_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewSupplier.CellContentClick

        'Dim RowActual As Int16
        'Dim SelectActual As String '= 0
        RowActual = DataGridViewSupplier.CurrentRow.Index()



        SelectActual = DataGridViewSupplier.Item(0, RowActual).Value.ToString

        DataGridSuplier.IdSuplier = SelectActual
        'MsgBox(SelectActual)
    End Sub

    Public Sub DataGridViewProyect_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewProyect.CellContentClick

        'Dim RowActual As Int16
        'Dim SelectActual As String '= 0
        RowActual = DataGridViewProyect.CurrentRow.Index()



        SelectActual = DataGridViewProyect.Item(0, RowActual).Value.ToString

        DataGridProyect.IdProyecto = SelectActual
        'MsgBox(SelectActual)
    End Sub

    Public Sub DataGridViewExtra_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewExtra.CellContentClick

        'Dim RowActual As Int16
        'Dim SelectActual As String '= 0
        RowActual = DataGridViewExtra.CurrentRow.Index()



        SelectActual = DataGridViewExtra.Item(0, RowActual).Value.ToString

        DataGridExtra.IdExtra = SelectActual
        'MsgBox(SelectActual)
    End Sub
    Private Sub DeleteSuplier_Click(sender As Object, e As EventArgs) Handles DeleteSuplierBtnForm.Click
        If (DataGridSuplier.IdSuplier <> "") Then

            'txtStencilNameEdit
            EliminarProvedor()
            DataGridSuplier.IdSuplier = ""
        Else
            MsgBox("Por favor seleccione un provedor")
        End If
    End Sub
    Private Sub DeleteProyectBtnForm_Click(sender As Object, e As EventArgs) Handles DeleteProyectBtnForm.Click
        If (DataGridProyect.IdProyecto <> "") Then

            'txtStencilNameEdit
            EliminarProyecto()
            DataGridProyect.IdProyecto = ""
        Else
            MsgBox("Por favor seleccione un proyecto")
        End If
    End Sub
    Private Sub EditSuplier_Click(sender As Object, e As EventArgs) Handles EditSuplierBtnForm.Click

        If (DataGridSuplier.IdSuplier <> "") Then

            'txtStencilNameEdit
            EditarProvedor()
            'DataGridSuplier.IdSuplier = ""
        Else
            MsgBox("Por favor seleccione un provedor")
        End If
    End Sub
    Private Sub EditProyectBtnForm_Click(sender As Object, e As EventArgs) Handles EditProyectBtnForm.Click

        If (DataGridProyect.IdProyecto <> "") Then

            'txtStencilNameEdit
            EditarProyecto()
            'DataGridSuplier.IdSuplier = ""
        Else
            MsgBox("Por favor seleccione un provedor")
        End If
    End Sub
    Sub EliminarProvedor()
        Dim Resultado As DialogResult

        Resultado = MessageBox.Show("Eliminar provedor?", "Eliminar provedor", MessageBoxButtons.OKCancel)

        If Resultado = DialogResult.OK Then
            ' Código para el caso de aceptar
            'bdconexion.DeleteUser(DataGridUser.IdUser, Orden)
            Dim Resultado2 As DialogResult

            Resultado2 = MessageBox.Show("Seguro que quiere continuar?", "Desea continuar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Resultado2 = DialogResult.Yes Then

                bdconexion.DeleteProvedor(DataGridSuplier.IdSuplier)
                DataGridViewSupplier.DataSource = bdconexion.ConsultaSupplierDataGridView()
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

    Sub EliminarProyecto()
        Dim Resultado As DialogResult

        Resultado = MessageBox.Show("Eliminar proyecto?", "Eliminar proyecto", MessageBoxButtons.OKCancel)

        If Resultado = DialogResult.OK Then
            ' Código para el caso de aceptar
            'bdconexion.DeleteUser(DataGridUser.IdUser, Orden)
            Dim Resultado2 As DialogResult

            Resultado2 = MessageBox.Show("Seguro que quiere continuar?", "Desea continuar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Resultado2 = DialogResult.Yes Then

                bdconexion.DeleteProyecto(DataGridProyect.IdProyecto)
                DataGridViewProyect.DataSource = bdconexion.ConsultaProyectsDataGridView()
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

    Sub EliminarExtra()
        Dim Resultado As DialogResult

        Resultado = MessageBox.Show("Eliminar partNumber?", "Eliminar PN", MessageBoxButtons.OKCancel)

        If Resultado = DialogResult.OK Then
            ' Código para el caso de aceptar
            'bdconexion.DeleteUser(DataGridUser.IdUser, Orden)
            Dim Resultado2 As DialogResult

            Resultado2 = MessageBox.Show("Seguro que quiere continuar?", "Desea continuar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Resultado2 = DialogResult.Yes Then

                bdconexion.DeleteExtra(DataGridExtra.IdExtra)
                DataGridViewExtra.DataSource = bdconexion.ConsultaExtraDataGridView()
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
    Sub EditarProvedor()

        Dim NameSuplier = DataGridViewSupplier.Item(4, RowActual).Value.ToString()
        Dim Address = DataGridViewSupplier.Item(3, RowActual).Value.ToString()
        Dim PhoneNumber = DataGridViewSupplier.Item(2, RowActual).Value.ToString()
        Dim Suplier = DataGridViewSupplier.Item(1, RowActual).Value.ToString()
        Dim IdSuplier = DataGridViewSupplier.Item(0, RowActual).Value.ToString()

        If (DataGridSuplier.IdSuplier <> "") Then
            Suplier = InputBox("Edite el nombre del provedor",
                         "Editar nombre del Provedor" + SelectActual,
                         Suplier, 100, 0)
            If (Suplier <> "") Then
                PhoneNumber = InputBox("Edite el numero del Provedor",
                             "Editar numero del Provedor",
                             PhoneNumber, 100, 0)
                If (PhoneNumber <> "") Then
                    Address = InputBox("Ingrese la direccion del Provedor",
                         "Registro de comentario del squeegee",
                         Address, 100, 0)
                    If (Address <> "") Then
                        NameSuplier = InputBox("Edite el nombre del squeegee ",
                             "Registro de nombre de squeege",
                             NameSuplier, 100, 0)
                        If (NameSuplier <> "") Then
                            bdconexion.ActualizarProvedor(Suplier, PhoneNumber, Address, NameSuplier, IdSuplier)
                            DataGridViewSupplier.DataSource = bdconexion.ConsultaSupplierDataGridView()
                        End If


                    End If


                End If

            End If
        End If
    End Sub

    Sub EditarProyecto()

        Dim Proyect = DataGridViewProyect.Item(1, RowActual).Value.ToString()
        Dim IdProyect = DataGridViewProyect.Item(0, RowActual).Value.ToString()

        If (DataGridProyect.IdProyecto <> "") Then
            Proyect = InputBox("Edite el nombre del proyecto",
                         "Editar nombre del proyecto",
                         Proyect, 100, 0)
            If (Proyect <> "") Then
                bdconexion.ActualizarProyecto(Proyect, IdProyect)
                DataGridViewProyect.DataSource = bdconexion.ConsultaProyectsDataGridView()


            End If
        End If
    End Sub

    Sub EditarExtra()

        Dim Type = DataGridViewExtra.Item(4, RowActual).Value.ToString()
        Dim Qty = DataGridViewExtra.Item(3, RowActual).Value.ToString()
        Dim Description = DataGridViewExtra.Item(2, RowActual).Value.ToString()
        Dim PartNumber = DataGridViewExtra.Item(1, RowActual).Value.ToString()
        Dim IdExtra = DataGridViewExtra.Item(0, RowActual).Value.ToString()

        If (DataGridExtra.IdExtra <> "") Then
            PartNumber = InputBox("Edite el numero de parte",
                         "Editar numero de parte",
                         PartNumber, 100, 0)
            If (PartNumber <> "") Then
                Description = InputBox("Edite ela descripcion",
                             "Editar Descripcion",
                             Description, 100, 0)
                If (Description <> "") Then
                    Qty = InputBox("Ingrese la cantidad actual",
                         "Registro de inventario",
                         Qty, 100, 0)
                    If (Qty <> "") Then
                        Type = InputBox("Edite el tipo de material",
                             "Registro de tipo de material",
                             Type, 100, 0)
                        If (Type <> "") Then
                            bdconexion.ActualizarExtra(PartNumber, Description, Qty, Type, IdExtra)
                            DataGridViewExtra.DataSource = bdconexion.ConsultaExtraDataGridView()
                        End If


                    End If


                End If

            End If
        End If
    End Sub

    Private Sub AddExtraBtnForm_Click(sender As Object, e As EventArgs) Handles AddExtraBtnForm.Click
        Dim PartNumber As String
        Dim Description As String
        Dim Qty As String
        Dim Type As String
        'Entrada de datos mediante un inputbox
        PartNumber = InputBox("Ingrese Numero de parte ",
                         "Registro de NP",
                         "Provedor", 100, 0)

        If (PartNumber <> "") Then

            Description = InputBox("Ingrese la descripcion",
                         "Registro de descripcion",
                         "Numero", 100, 0)
            If (Description <> "") Then
                Qty = InputBox("Ingrese Cantidad ",
                         "Registro de cantidad",
                         "Direccion", 100, 0)
                If (Qty <> "") Then
                    Type = InputBox("Ingrese el tipo de material",
                         "Registro de tipo de material",
                         "Nombre", 100, 0)
                    If (Type <> "") Then
                        bdconexion.InsertarExtra(PartNumber, Description, Qty, Type)
                        DataGridViewExtra.DataSource = bdconexion.ConsultaExtraDataGridView()
                    Else
                        MessageBox.Show("El nombre del numero de parte esta vacio")
                    End If
                Else
                    MessageBox.Show("La descripcion esta vacia")
                End If

            Else
                MessageBox.Show("La cantidad esta vacia")
            End If

        Else
            MessageBox.Show("El tipo de material esta vacio")
        End If
    End Sub

    Private Sub EditExtraBtnForm_Click(sender As Object, e As EventArgs) Handles EditExtraBtnForm.Click
        If (DataGridExtra.IdExtra <> "") Then

            'txtStencilNameEdit
            EditarExtra()
            'DataGridSuplier.IdSuplier = ""
        Else
            MsgBox("Por favor seleccione un Numero de Parte")
        End If
    End Sub

    Private Sub DeleteExtraBtnForm_Click(sender As Object, e As EventArgs) Handles DeleteExtraBtnForm.Click
        If (DataGridExtra.IdExtra <> "") Then

            'txtStencilNameEdit
            EliminarExtra()
            DataGridExtra.IdExtra = ""
        Else
            MsgBox("Por favor seleccione un numero de parte")
        End If
    End Sub

    Private Sub textBoxFindUser_TextChanged(sender As Object, e As EventArgs) Handles textBoxFindUser.TextChanged

    End Sub
End Class