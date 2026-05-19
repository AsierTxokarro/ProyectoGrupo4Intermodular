Imports Entidades

Public Class FrmDatosAlumno
    Private Sub FrmDatosAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim alumnoSeleccionado As Alumno = FrmListarAlumnos.lstAlumnos.SelectedItem
        txtDni.Text = alumnoSeleccionado.DNI
        txtHoras.Text = alumnoSeleccionado.HorasTotales
        txtNombre.Text = alumnoSeleccionado.Nombre
        txtApellido1.Text = alumnoSeleccionado.Apellido1
        txtApellido2.Text = alumnoSeleccionado.Apellido2
        txtCiclo.Text = alumnoSeleccionado.Ciclo
        txtCurso.Text = alumnoSeleccionado.AliasCurso

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class