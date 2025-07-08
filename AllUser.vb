Public Class alluser
    Private TextBoxResizers As New List(Of ClassFormToolingsResizer)
    Dim bdconexion As New Db()
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

    Private Sub EjectOptionComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles EjectOptionAllComboBox.SelectedIndexChanged

    End Sub

    Private Sub aplicar_Click(sender As Object, e As EventArgs) Handles aplicar.Click
        If EjectOptionAllComboBox.SelectedIndex = 1 Then
            'openPanel(New adduserform)
            Dim resultado As DialogResult

            resultado = MessageBox.Show("Eliminar usuario?", "Eliminar Usuario", MessageBoxButtons.OKCancel)

            If resultado = DialogResult.OK Then
                ' Código para el caso de aceptar
                'bdconexion.DeleteUser(DataGridUser.IdUser, Orden)
                Dim resultado2 As DialogResult

                resultado2 = MessageBox.Show("Seguro que quiere continuar?", "Desea continuar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If resultado2 = DialogResult.Yes Then

                    bdconexion.DeleteUser(DataGridUser.IdUser)
                    DataGridView1.DataSource = bdconexion.ConsultaUserDataGridViewer()
                    'Console.WriteLine("Aceptado")
                ElseIf resultado2 = DialogResult.No Then
                    MsgBox("No")
                End If
            ElseIf resultado = DialogResult.Cancel Then
                ' Código para el caso de cancelar
                MsgBox(" Cancelado")
                Console.WriteLine("Cancelado")
            End If

            'aplicar.Text = "Prueba"
            'MsgBox(EjectOptionAllComboBox.SelectedItem.ToString)
        ElseIf EjectOptionAllComboBox.SelectedIndex = 2 Then

        End If
        'MsgBox(EjectOptionAllComboBox.SelectedIndex.ToString)
        'aplicar.Text = EjectOptionAllComboBox.SelectedItem
    End Sub

    Private Sub AddUserBtnForm_Click(sender As Object, e As EventArgs) Handles AddUserBtnForm.Click
        'MsgBox(DataGridUser.IdUser)

        If (DataGridUser.IdUser <> "") Then
            bdconexion.ConsultarUser(DataGridUser.IdUser)
            'txtStencilNameEdit
            openPanel(New edituserform)
        Else
            MsgBox("Por favor seleccione un usuario")
        End If
        'openPanel(New edituserform)
    End Sub

    Public Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'MsgBox(DataGridUser.IdUser)

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then ' Asegúrate de que se hizo clic en una fila, no en los encabezados de columna
            Dim RowActual As Int16
            Dim SelectActual As String = ""
            RowActual = e.RowIndex

            SelectActual = DataGridView1.Item(0, RowActual).Value.ToString()

            DataGridUser.IdUser = SelectActual

        End If
    End Sub


    Private Sub alluser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        InitializeTextBoxResizers(Me)
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, PanelF))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel1))
        TextBoxResizers.Add(New ClassFormToolingsResizer(Me, Panel3))
        DataGridView1.DataSource = bdconexion.ConsultaUserDataGridViewer()
        DataGridView2.DataSource = bdconexion.ConsultaUserAdminDataGridViewer()
        'DataGridUser.IdUser = vbEmpty
    End Sub

    Private Sub textBoxFindUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles textBoxFindUser.KeyPress
        If (textBoxFindUser.Text = "Find Stencil") Then
            MsgBox("Ingrese algun dato, Porfavor")
            DataGridView1.DataSource = bdconexion.ConsultaUserDataGridViewer()
        Else
            DataGridView1.DataSource = bdconexion.FindUserDataGridViewer(textBoxFindUser.Text)
        End If
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class