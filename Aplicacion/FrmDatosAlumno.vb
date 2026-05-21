Imports Gestion
Public Class FrmDatosAlumno
    Private Sub BtnAnadir_Click(sender As Object, e As EventArgs) Handles BtnAnadir.Click
        Dim horasTotales As Integer
        Dim usadoParaGestion As Gestion.Gestion
        usadoParaGestion = New Gestion.Gestion("")
        If String.IsNullOrWhiteSpace(txtNombre.Text) Then
            MessageBox.Show("El nombre no debe estar en blanco.")
        ElseIf String.IsNullOrWhiteSpace(txtDNI.Text) Then
            MessageBox.Show("El DNI no debe estar en blanco.")
        ElseIf String.IsNullOrWhiteSpace(txtApellidoUno.Text) Then
            MessageBox.Show("El primer apellido no debe estar en blanco.")
        ElseIf String.IsNullOrWhiteSpace(txtApellidoDos.Text) Then
            MessageBox.Show("El segundo apellido no debe estar en blanco.")
        ElseIf Ciclos.SelectedIndex < 0 Then
            MessageBox.Show("Un ciclo debe haber sido seleccionado.")
        ElseIf String.IsNullOrWhiteSpace(txtCorreoElec.Text) Then
            MessageBox.Show("El correo electronico no debe estar en blanco.")
        ElseIf Cursos.SelectedIndex < 0 Then
            MessageBox.Show("Un curso debe haber sido seleccionado.")
        ElseIf String.IsNullOrWhiteSpace(txtHorasTotales.Text) Then
            MessageBox.Show("Las horas totales no deben estar en blanco.")
        ElseIf Integer.TryParse(txtHorasTotales.Text, horasTotales) = 0 Then
            MessageBox.Show("Las horas totales deben ser un numero.")
        Else
            MessageBox.Show(usadoParaGestion.AñadirAlumno(txtDNI.Text, txtHorasTotales.Text, txtNombre.Text, txtApellidoUno.Text, txtApellidoDos.Text, Ciclos.SelectedIndex + 1, Cursos.Text))
        End If

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
    End Sub
End Class