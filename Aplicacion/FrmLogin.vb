Public Class FrmLogin
    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        If gestionfrm.ValidarFormatoDNI(txtDNI.Text) Then
            FrmMenu.Show()
        Else
            MessageBox.Show("No se ha encontrado un usuario con ese DNI")
        End If
    End Sub

End Class