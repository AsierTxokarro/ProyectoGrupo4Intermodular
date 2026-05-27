Imports Entidades

Public Class frmVerAlumno
    Dim alumnoSeleccionado As Alumno
    Private Sub frmVerAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alumnoSeleccionado = FrmListarAlumnos.lstAlumnos.SelectedItem
        lblNombreAlumno.Text = ""
        lstTareas.DataSource = Nothing
        lstTareas.Items.Clear()
        lblNombreAlumno.Text = alumnoSeleccionado.Nombre
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
            MessageBox.Show("Alumno eliminado con éxito")

            FrmListarAlumnos.CargarAlumnos()

            Me.Close()
        Else
            MessageBox.Show($"No se ha podido eliminar a {alumnoSeleccionado.Nombre}...")
        End If
    End Sub


    Private Sub MonthCalendar1_DateSelected(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        Dim tareasPorfecha As List(Of TareasCompletas)
        Dim dni As String = alumnoSeleccionado.DNI
        Dim fecha As Date = MonthCalendar1.SelectionStart
        tareasPorfecha = gestionfrm.MostrarTareasAlumnoDeUnaFecha(dni, fecha)

        If tareasPorfecha IsNot Nothing AndAlso tareasPorfecha.Count > 0 Then
            lstTareas.DataSource = Nothing
            lstTareas.DisplayMember = "DescripcionTarea"
            lstTareas.DataSource = tareasPorfecha
        Else
            MessageBox.Show("Este alumno no ha realizado ninguna tarea en esta fecha")
        End If
    End Sub


End Class