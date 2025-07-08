
Imports System.Data.SqlClient

Public Class FormLogin

    Dim bdconexion As New Db()
    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        Dim username As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        If bdconexion.AuthenticateUser(username, password) Then
            ' Inicio de sesión exitoso
            MessageBox.Show("Inicio de sesión exitoso", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Abre el nuevo formulario
            Dim Inicio As New inicio()
            Inicio.Show()

            ' Cierra el formulario actual después de mostrar el MessageBox y abrir el nuevo formulario
            'Me.Close()
            Me.Hide()


            ' Abre el nuevo formulario

            ' Aquí puedes abrir tu formulario principal
        Else
            ' Credenciales incorrectas
            MessageBox.Show("Nombre de usuario o contraseña incorrectos")
        End If

    End Sub



    Private Sub closelogin_Click(sender As Object, e As EventArgs) Handles closelogin.Click
        Application.Exit()
    End Sub

    Private Sub maxlogin_Click(sender As Object, e As EventArgs) Handles maxlogin.Click

        WindowState = FormWindowState.Maximized
        maxlogin.Visible = False
        restlogin.Visible = True
    End Sub

    Private Sub restlogin_Click(sender As Object, e As EventArgs) Handles restlogin.Click
        WindowState = FormWindowState.Normal
        restlogin.Visible = False
        maxlogin.Visible = True

    End Sub

    Private Sub minuslogin_Click(sender As Object, e As EventArgs) Handles minuslogin.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class