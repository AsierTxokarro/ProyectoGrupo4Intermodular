Public Class FrmCrearAlumno
<<<<<<< HEAD
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
=======

    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click
        Dim horasTotales As Integer
        Dim usadoParaGestion As Gestion.GestionFunciones
        usadoParaGestion = New Gestion.GestionFunciones("")
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
        ElseIf Integer.TryParse(txtHorasTotales.Text, horasTotales) = False Then
            MessageBox.Show("Las horas totales deben ser un numero.")
        ElseIf horasTotales <= 0 Then
            MessageBox.Show("Las horas totales deben ser un numero positivo.")
        ElseIf txtDNI.TextLength < 9 Or txtDNI.TextLength > 9 Then
            MessageBox.Show("El DNI debe ser 9 caracteres de largo.")
        Else
            If Char.IsLetter(txtDNI.Text(0)) Or Char.IsLetter(txtDNI.Text(1)) Or Char.IsLetter(txtDNI.Text(2)) Or Char.IsLetter(txtDNI.Text(3)) Or Char.IsLetter(txtDNI.Text(4)) Or Char.IsLetter(txtDNI.Text(5)) Or Char.IsLetter(txtDNI.Text(6)) Or Char.IsLetter(txtDNI.Text(7)) Or Char.IsDigit(txtDNI.Text(8)) Then
                MessageBox.Show("El DNI debe ser valido, los 8 primeros tienen que ser numeros y el ultimo tiene que ser una letra.")
            Else
                MessageBox.Show(usadoParaGestion.AñadirAlumno(txtDNI.Text, txtHorasTotales.Text, txtNombre.Text, txtApellidoUno.Text, txtApellidoDos.Text, Ciclos.SelectedIndex + 1, Cursos.Text))
            End If
        End If
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Close()
>>>>>>> 2eb5a01fd7685ea2386c957d72e83bee42f05cd0
    End Sub
End Class