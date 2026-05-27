Imports Entidades

Public Class FrmVerTareasAlumno
    Dim alumnoSeleccionado As Alumno
    Private Sub frmVerAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alumnoSeleccionado = gestionfrm.DevolverAlumnoPorDni(FrmLogin.txtDNI.Text)
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

    Private Sub btnEliminarTarea_Click(sender As Object, e As EventArgs) Handles btnEliminarTarea.Click
        If lstTareas.SelectedIndex = -1 Then
            MessageBox.Show("Debes seleccionar una tarea")
            Exit Sub
        End If

        MessageBox.Show("¿Estás seguro que quieres eliminar la tarea/s?", "Eliminar tarea", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If DialogResult.Yes Then
            Dim resultado As String = ""
            For Each tareaAEliminar As TareasCompletas In lstTareas.SelectedItems
                resultado = gestionfrm.EliminarTarea(New Tarea(tareaAEliminar.CodigoTarea, tareaAEliminar.DniAlumno, tareaAEliminar.FechaJornada, tareaAEliminar.DescripcionTarea, tareaAEliminar.Duracion))
                If resultado.Contains("Error") Then
                    MessageBox.Show(resultado & $" , el fallo ocurrió con la tarea {tareaAEliminar.DescripcionTarea}")
                    Exit Sub
                End If
            Next
            MessageBox.Show(resultado)
        End If
        Dim tareas As List(Of TareasCompletas)
        Dim dni As String = alumnoSeleccionado.DNI
        tareas = gestionfrm.MostrarTareasAlumno(dni)
        lstTareas.DataSource = Nothing
        lstTareas.DisplayMember = "DescripcionTarea"
        lstTareas.DataSource = tareas
    End Sub

    Private Sub btnModificarTarea_Click(sender As Object, e As EventArgs) Handles btnModificarTarea.Click
        If lstTareas.SelectedIndex = -1 Then
            MessageBox.Show("Debes seleccionar una tarea")
            Exit Sub
        End If
        If lstTareas.SelectedIndices.Count > 1 Then
            MessageBox.Show("Debes seleccionar una sola tarea")
            Exit Sub
        End If
        FrmModificarTarea.ShowDialog()
    End Sub

    Private Sub btnAnadirTarea_Click(sender As Object, e As EventArgs) Handles btnAnadirTarea.Click
        FrmAnadirTarea.ShowDialog()
    End Sub
End Class