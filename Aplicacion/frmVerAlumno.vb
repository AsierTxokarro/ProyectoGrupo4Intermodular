Imports Entidades

Public Class frmVerAlumno
    Dim alumnoSeleccionado As Alumno = FrmListarAlumnos.lstAlumnos.SelectedItem
    Private Sub frmVerAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblNombreAlumno.Text = alumnoSeleccionado.Nombre
    End Sub

    Private Sub btnVerDatosAlumno_Click(sender As Object, e As EventArgs) Handles btnVerDatosAlumno.Click
        FrmDatosAlumno.ShowDialog()
    End Sub

    Private Sub btnFichajesRealizados_Click(sender As Object, e As EventArgs) Handles btnFichajesRealizados.Click
        Dim tareas As List(Of TareasCompletas)
        Dim dni As String = alumnoSeleccionado.DNI
        tareas = gestionfrm.MostrarTareasAlumno(dni)
        If tareas IsNot Nothing AndAlso tareas.Count > 0 Then
            lstTareas.DataSource = Nothing
            lstTareas.DisplayMember = "DescripcionTarea"
            lstTareas.DataSource = tareas
        Else
            MessageBox.Show("Este alumno no ha realizado ninguna tarea")
        End If
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Me.Close()
    End Sub

    Private Sub btnEliminarAlumno_Click(sender As Object, e As EventArgs) Handles btnEliminarAlumno.Click
        Dim mensaje = gestionfrm.EliminarAlumno(alumnoSeleccionado.DNI)
        If mensaje = "" Then
            MessageBox.Show("Alumno eliminado con exito")
            Return
        End If

    End Sub
End Class