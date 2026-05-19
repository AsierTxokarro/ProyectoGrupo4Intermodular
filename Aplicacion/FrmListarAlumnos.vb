Imports Entidades
Imports Gestion.GestionFunciones

Public Class FrmListarAlumnos

    Private Sub FrmTutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim alumn As List(Of Alumno) = gestionfrm.DevolverAlumnos()
        Dim curso As List(Of Curso) = gestionfrm.DevolverCursos()


        If alumn IsNot Nothing AndAlso alumn.Count > 0 Then
            lstAlumnos.DataSource = Nothing
            lstAlumnos.DisplayMember = "Nombre"
            lstAlumnos.DataSource = alumn
        Else
            MessageBox.Show("No tenemos ningún alumno registrado en la base de datos.")
        End If


        If curso IsNot Nothing AndAlso curso.Count > 0 Then
            cmbCurso.DataSource = Nothing
            cmbCurso.DisplayMember = "AliasCurso"

            cmbCurso.ValueMember = "AliasCurso"
            cmbCurso.DataSource = curso
        End If
    End Sub


    Private Sub cmbCurso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCurso.SelectedIndexChanged

        If cmbCurso.SelectedValue IsNot Nothing AndAlso TypeOf cmbCurso.SelectedValue Is String Then
            Dim cursoTexto As String = cmbCurso.SelectedValue.ToString()


            Dim listaCiclos As List(Of Curso) = gestionfrm.DevolverCiclosPorCurso(cursoTexto)


            cmbCiclo.DataSource = Nothing
            cmbCiclo.DisplayMember = "Ciclo"
            cmbCiclo.ValueMember = "Ciclo"
            cmbCiclo.DataSource = listaCiclos
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If cmbCurso.SelectedValue IsNot Nothing AndAlso cmbCiclo.SelectedValue IsNot Nothing Then
            Dim cursoSeleccionado As String = cmbCurso.SelectedValue.ToString()

            Dim cicloSeleccionado As Integer = Convert.ToInt32(cmbCiclo.SelectedValue)


            Dim listaAlumnosFiltrado As List(Of Alumno) = gestionfrm.DevolverAlumnosFiltrados(cursoSeleccionado, cicloSeleccionado)


            lstAlumnos.DataSource = Nothing
            lstAlumnos.DisplayMember = "Nombre"
            lstAlumnos.DataSource = listaAlumnosFiltrado
        End If
    End Sub

    Private Sub btnCerrarSesion_Click(sender As Object, e As EventArgs) Handles btnCerrarSesion.Click
        Me.Close()
    End Sub

    Private Sub btnSeleccionarAlumno_Click(sender As Object, e As EventArgs) Handles btnSeleccionarAlumno.Click
        If lstAlumnos.SelectedItem Is Nothing Then
            MessageBox.Show("Debes seleccionar un alumno antes")
            Return
        End If
        frmVerAlumno.ShowDialog()
    End Sub
End Class
