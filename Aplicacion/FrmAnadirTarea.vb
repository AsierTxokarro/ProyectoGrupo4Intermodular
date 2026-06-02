Imports Entidades

Public Class FrmAnadirTarea
    Private listaModulosDinamicos As New List(Of ComboBox)
    Private listaRAsDinamicos As New List(Of ListBox)
    Private contadorModulos As Integer = 0
    Private alumnoActual As Alumno = gestionfrm.DevolverAlumnoPorDni(FrmLogin.txtDNI.Text)
    Private Sub CrearModuloYRA()
        Dim posY As Integer = 20 + (contadorModulos * 170)
        Dim lblModulo As New Label
        lblModulo.Text = "Modulo"
        lblModulo.Location = New Point(40, posY)
        lblModulo.AutoSize = True

        Dim cmbModulo As New ComboBox
        cmbModulo.Name = "cmbModulo" & contadorModulos
        cmbModulo.Location = New Point(40, posY + 30)
        cmbModulo.Width = 250
        cmbModulo.DropDownStyle = ComboBoxStyle.DropDownList
        cmbModulo.DisplayMember = "NombreModulo"
        cmbModulo.ValueMember = "CodigoModulo"

        Dim listaModulos As List(Of Modulo) = gestionfrm.DevolverModulosDeUnCurso(alumnoActual.Ciclo, alumnoActual.AliasCurso)
        cmbModulo.DataSource = listaModulos

        Dim lblRA As New Label
        lblRA.Text = "RAs"
        lblRA.Location = New Point(40, posY + 75)
        lblRA.AutoSize = True

        Dim lstRA As New ListBox
        lstRA.Name = "lstRA" & contadorModulos
        lstRA.Location = New Point(40, posY + 105)
        lstRA.Width = 250
        lstRA.Height = 120
        lstRA.SelectionMode = SelectionMode.MultiExtended

        Dim moduloInicial As Modulo = listaModulos(0)

        Dim listaRAs As List(Of RA) = gestionfrm.DevolverRAsDeModulo(moduloInicial.CodigoModulo, moduloInicial.Ciclo, moduloInicial.AliasCurso)
        lstRA.DisplayMember = "DescripcionRA"
        lstRA.DataSource = listaRAs

        AddHandler cmbModulo.SelectedIndexChanged, Sub(obj As Object, args As EventArgs)
                                                       Dim combo As ComboBox = TryCast(obj, ComboBox)
                                                       Dim moduloSeleccionado As Modulo = TryCast(combo.SelectedItem, Modulo)
                                                       Dim nuevosRAs As List(Of RA) = gestionfrm.DevolverRAsDeModulo(moduloSeleccionado.CodigoModulo, moduloSeleccionado.Ciclo, moduloSeleccionado.AliasCurso)

                                                       lstRA.DataSource = Nothing
                                                       lstRA.DisplayMember = "DescripcionRA"
                                                       lstRA.DataSource = nuevosRAs
                                                   End Sub
        grbControlesDinamicos.Controls.Add(lblModulo)
        grbControlesDinamicos.Controls.Add(cmbModulo)
        grbControlesDinamicos.Controls.Add(lblRA)
        grbControlesDinamicos.Controls.Add(lstRA)
        listaModulosDinamicos.Add(cmbModulo)
        listaRAsDinamicos.Add(lstRA)
        contadorModulos += 1
    End Sub

    Private Sub FrmAnadirTarea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CrearModuloYRA()
    End Sub

    Private Sub BtnAnyadirModulo_Click(sender As Object, e As EventArgs) Handles btnAnyadirModulo.Click
        CrearModuloYRA()
    End Sub

    Private Sub btnQuitarModulo_Click(sender As Object, e As EventArgs) Handles btnQuitarModulo.Click
        If contadorModulos <= 1 Then
            Exit Sub
        End If

        Dim ultimoCombo As ComboBox = listaModulosDinamicos.Last()
        Dim ultimaLista As ListBox = listaRAsDinamicos.Last()
        Dim controlesAEliminar As New List(Of Control)

        For Each control As Control In grbControlesDinamicos.Controls
            If control.Top >= ultimoCombo.Top - 30 Then
                controlesAEliminar.Add(control)
            End If
        Next

        For Each controlEliminar In controlesAEliminar
            grbControlesDinamicos.Controls.Remove(controlEliminar)
        Next

        listaModulosDinamicos.RemoveAt(listaModulosDinamicos.Count - 1)
        listaRAsDinamicos.RemoveAt(listaRAsDinamicos.Count - 1)
        contadorModulos -= 1
    End Sub

    Private Sub btnConfirmar_Click(sender As Object, e As EventArgs) Handles btnConfirmar.Click
        If String.IsNullOrWhiteSpace(txtDescripcion.Text) Then
            MessageBox.Show("Introduce una descripción")
            Exit Sub
        End If

        Dim duracion As Decimal
        If Not Decimal.TryParse(txtDuracion.Text, duracion) Then
            MessageBox.Show("Duración inválida")
            Exit Sub
        End If

        Dim fecha As Date = MonthCalendar1.SelectionStart
        If Not gestionfrm.ComprobarJornadaRepetida(fecha, alumnoActual.DNI) Then
            MessageBox.Show("No existe una jornada para ese día")
            Exit Sub
        End If

        Dim resultado As String = gestionfrm.AñadirTarea(fecha, alumnoActual.DNI, txtDescripcion.Text.Trim(), duracion)
        If resultado.StartsWith("Error") Then
            MessageBox.Show(resultado)
            Exit Sub
        End If

        For i As Integer = 0 To listaModulosDinamicos.Count - 1
            Dim cmbModulo As ComboBox =
                listaModulosDinamicos(i)
            Dim lstRA As ListBox =
                listaRAsDinamicos(i)

            If cmbModulo.SelectedItem Is Nothing Then
                Continue For
            End If
            Dim modulo As Modulo = TryCast(cmbModulo.SelectedItem, Modulo)

            Dim listaRAsSeleccionados As New List(Of Integer)
            For Each item In lstRA.SelectedItems
                Dim ra As RA = TryCast(item, RA)
                listaRAsSeleccionados.Add(ra.RA)
            Next

            Dim respuesta As String = gestionfrm.AñadirRAsYModulosALaTarea(modulo.Ciclo, modulo.AliasCurso, modulo.NombreModulo, listaRAsSeleccionados, fecha, alumnoActual.DNI)
            If respuesta.StartsWith("Error") Then
                MessageBox.Show(respuesta)
                Exit Sub
            End If
        Next

        MessageBox.Show("Tarea añadida correctamente")
        Me.Close()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class