Public Class FrmAlumno
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnVerMisDatos_Click(sender As Object, e As EventArgs) Handles btnVerMisDatos.Click
        FrmDatosAlumno.Show()
    End Sub
End Class
