Public Class FrmMenu
    Private Sub btnAlumno_Click(sender As Object, e As EventArgs) Handles btnAlumno.Click
        FrmLogin.Show()
    End Sub

    Private Sub BtnCerrarSesion_Click(sender As Object, e As EventArgs) Handles BtnCerrarSesion.Click
        Me.Close()
    End Sub

    Private Sub BtnCrearAlumno_Click(sender As Object, e As EventArgs) Handles BtnCrearAlumno.Click
        FrmCrearAlumno.Show()
    End Sub

    Private Sub BtnTutor_Click(sender As Object, e As EventArgs) Handles BtnTutor.Click
        FrmListarAlumnos.Show()
    End Sub
End Class
