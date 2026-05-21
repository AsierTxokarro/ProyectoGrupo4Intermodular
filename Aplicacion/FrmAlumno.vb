Imports Entidades

Public Class FrmAlumno
    Dim alumnoSeleccionado As Alumno = FrmListarAlumnos.lstAlumnos.SelectedItem
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnVerMisDatos_Click(sender As Object, e As EventArgs) Handles btnVerMisDatos.Click
        FrmDatosAlumno.Show()
    End Sub

    Private Sub FrmAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNombreAlumno.Text = alumnoSeleccionado.Nombre
    End Sub

    Private Sub btnJornadasRealizadas_Click(sender As Object, e As EventArgs) Handles btnJornadasRealizadas.Click
        txtJornadasRealizadas.Text = gestionfrm.NumeroJornadasRealizadas(alumnoSeleccionado.DNI)
    End Sub

    Private Sub btnPartesSemanales_Click(sender As Object, e As EventArgs) Handles btnPartesSemanales.Click
        txtHorasTrabajadas.Text = gestionfrm.MostrarHorasDeAlumno(alumnoSeleccionado.DNI)
    End Sub
End Class
