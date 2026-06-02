Public Class FrmLogin
    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        If gestionfrm.ValidarFormatoDNI(txtDNI.Text) Then
            FrmVerTareasAlumno.Show()
        Else
            MessageBox.Show("No se ha encontrado un usuario con ese DNI")
        End If
    End Sub

    Private Sub txtDNI_QuitarPlaceHolder(sender As Object, e As EventArgs) Handles txtDNI.GotFocus
        If txtDNI.Text = "DNI" Then
            txtDNI.Text = ""
            txtDNI.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtDNI_AñadirPlaceHolder(sender As Object, e As EventArgs) Handles txtDNI.LostFocus
        If String.IsNullOrWhiteSpace(txtDNI.Text) Then
            txtDNI.Text = "DNI"
            txtDNI.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtContraseña_QuitarPlaceHolder(sender As Object, e As EventArgs) Handles txtContraseña.GotFocus
        If txtContraseña.Text = "Contraseña" Then
            txtContraseña.Text = ""
            txtContraseña.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtContraseña_AñadirPlaceHolder(sender As Object, e As EventArgs) Handles txtContraseña.LostFocus
        If String.IsNullOrWhiteSpace(txtContraseña.Text) Then
            txtContraseña.Text = "Contraseña"
            txtContraseña.ForeColor = Color.Gray
        End If
    End Sub
End Class