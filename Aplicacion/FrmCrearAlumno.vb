Public Class FrmCrearAlumno

    Private Sub btnAnadir_Click(sender As Object, e As EventArgs) Handles btnAnadir.Click
        Dim horasTotales As Integer

        If String.IsNullOrWhiteSpace(txtNombre.Text) Then
            MessageBox.Show("El nombre no debe estar en blanco.")
        ElseIf String.IsNullOrWhiteSpace(txtDNI.Text) Then
            MessageBox.Show("El DNI no debe estar en blanco.")
        ElseIf Not gestionfrm.ValidarFormatoDNI(txtDNI.Text) Then
            MessageBox.Show("El DNI no es válido. Debe tener 8 números y la letra correcta.")
        ElseIf String.IsNullOrWhiteSpace(txtApellidoUno.Text) Then
            MessageBox.Show("El primer apellido no debe estar en blanco.")
        ElseIf String.IsNullOrWhiteSpace(txtApellidoDos.Text) Then
            MessageBox.Show("El segundo apellido no debe estar en blanco.")
        ElseIf lstCiclos.SelectedIndex < 0 Then
            MessageBox.Show("Un ciclo debe haber sido seleccionado.")
        ElseIf String.IsNullOrWhiteSpace(txtCorreoElec.Text) Then
            MessageBox.Show("El correo electrónico no debe estar en blanco.")
        ElseIf Not gestionfrm.EsCorreoValido(txtCorreoElec.Text) Then
            MessageBox.Show("El correo electrónico no es válido. Debe contener @ y un dominio (ej: ejemplo@correo.com)")
        ElseIf lstCursos.SelectedIndex < 0 Then
            MessageBox.Show("Un curso debe haber sido seleccionado.")
        ElseIf String.IsNullOrWhiteSpace(txtHorasTotales.Text) Then
            MessageBox.Show("Las horas totales no deben estar en blanco.")
        ElseIf Not Integer.TryParse(txtHorasTotales.Text, horasTotales) Then
            MessageBox.Show("Las horas totales deben ser un número.")
        ElseIf horasTotales <= 0 Then
            MessageBox.Show("Las horas totales deben ser un número positivo.")
        Else
            MessageBox.Show(gestionfrm.AñadirAlumno(txtDNI.Text, txtHorasTotales.Text, txtNombre.Text, txtApellidoUno.Text, txtApellidoDos.Text, lstCiclos.SelectedIndex + 1, lstCursos.SelectedValue))
        End If
    End Sub
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub FrmCrearAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstCursos.DataSource = gestionfrm.DevolverCursos()
        lstCursos.DisplayMember = "AliasCurso"
        lstCursos.ValueMember = "AliasCurso"
    End Sub
End Class