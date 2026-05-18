Imports Entidades
Imports Gestion

Public Class FrmTutor

    Private Sub FrmTutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim alumn As List(Of Alumno) = gestionfrm.DevolverAlumnos()

        If alumn IsNot Nothing AndAlso alumn.Count > 0 Then

            lstAlumnos.DisplayMember = "Nombre"
            lstAlumnos.Items.AddRange(alumn.ToArray())
        Else
            MessageBox.Show("No tenemos ningún alumno registrado en la base de datos.")
        End If


    End Sub


    Private Sub cmbCurso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCurso.SelectedIndexChanged

        cmbCiclo.Items.Clear()


        Dim cursoSeleccionado As String = cmbCurso.SelectedItem.ToString()


        Dim listaCiclos As List(Of Curso) = gestionfrm.DevolverCiclosPorCurso(cursoSeleccionado)

        If listaCiclos IsNot Nothing AndAlso listaCiclos.Count > 0 Then

            cmbCiclo.DisplayMember = "Ciclo"

            cmbCiclo.Items.AddRange(listaCiclos.ToArray())
        End If
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Me.Close()
    End Sub

    Private Sub btnSeleccionarAlumno_Click(sender As Object, e As EventArgs) Handles btnSeleccionarAlumno.Click
        frmVerAlumno.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cmbCurso.SelectedItem AndAlso cmbCiclo.SelectedItem Then
            Dim cursoSeleccionado = cmbCurso.SelectedItem
            Dim cicloSeleccionado = cmbCiclo.SelectedItem
            Dim listaAlumnosFiltrado As List(Of Alumno) = gestionfrm.DevolverAlumnosFiltrados(cursoSeleccionado, cicloSeleccionado)
            lstAlumnos.Items.Clear()
            lstAlumnos.Items.AddRange(listaAlumnosFiltrado.ToArray)
        End If
    End Sub
End Class
