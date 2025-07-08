

Public Class toolingFindOperator
    Private Sub Login_Click(sender As Object, e As EventArgs) Handles FindStencil.Click
        ResultStencil.Visible = False

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

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub take_Click(sender As Object, e As EventArgs) Handles take.Click

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

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ResultStencil.CellContentClick

    End Sub

    Private Sub EmployerNumber_TextChanged(sender As Object, e As EventArgs) Handles EmployerNumber.TextChanged

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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class