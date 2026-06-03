Imports Entidades

Public Class FrmAnadirTarea
    Private listaModulosDinamicos As New List(Of ComboBox)
    Private listaRAsDinamicos As New List(Of ListBox)
    Private contadorModulos As Integer = 0
    Private alumnoActual As Alumno

    Private Sub ResetControlesDinamicos()
        grbControlesDinamicos.Controls.Clear()
        listaModulosDinamicos.Clear()
        listaRAsDinamicos.Clear()
        contadorModulos = 0
    End Sub

    Private Sub CrearModuloYRA()
        Dim anchoComboBox As Integer = 220
        Dim alturaComboBox As Integer = 28
        Dim anchoLista As Integer = 220
        Dim alturaLista As Integer = 120
        Dim alturaEtiqueta As Integer = 18
        Dim espacioALoAncho As Integer = 20
        Dim espacioALoAlto As Integer = 16

        Dim anchoBloque As Integer = Math.Max(anchoComboBox, anchoLista)
        Dim altoBloque As Integer = alturaEtiqueta + alturaComboBox + alturaEtiqueta + alturaLista + (espacioALoAlto)

        Dim leftPadding As Integer = 10
        Dim topPadding As Integer = 10

        Dim anchoDisponible As Integer = Math.Max(1, grbControlesDinamicos.ClientSize.Width - leftPadding)
        Dim columnas As Integer = Math.Max(1, (anchoDisponible + espacioALoAncho) \ (anchoBloque + espacioALoAncho))

        Dim col As Integer = contadorModulos
        Dim fil As Integer = contadorModulos \ columnas

        Dim posX As Integer = leftPadding + col * (anchoBloque + espacioALoAncho)
        Dim posY As Integer = topPadding + fil * (altoBloque + espacioALoAlto)

        If posY + altoBloque > grbControlesDinamicos.ClientSize.Height - topPadding Then
            MessageBox.Show("No queda espacio para añadir más módulos.", "Espacio insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim lblModulo As New Label
        lblModulo.Name = "lblModulo" & contadorModulos
        lblModulo.Text = "Módulo"
        lblModulo.Location = New Point(posX, posY)
        lblModulo.AutoSize = False
        lblModulo.Size = New Size(anchoBloque, alturaEtiqueta)
        lblModulo.TextAlign = ContentAlignment.MiddleLeft

        Dim cmbModulo As New ComboBox
        cmbModulo.Name = "cmbModulo" & contadorModulos
        cmbModulo.Location = New Point(posX, posY + alturaEtiqueta)
        cmbModulo.Width = anchoComboBox
        cmbModulo.Height = alturaComboBox
        cmbModulo.DropDownStyle = ComboBoxStyle.DropDownList
        cmbModulo.DisplayMember = "NombreModulo"
        cmbModulo.ValueMember = "CodigoModulo"

        Dim lblRA As New Label
        lblRA.Name = "lblRA" & contadorModulos
        lblRA.Text = "RAs"
        lblRA.Location = New Point(posX, posY + alturaEtiqueta + alturaComboBox)
        lblRA.AutoSize = False
        lblRA.Size = New Size(anchoBloque, alturaEtiqueta)
        lblRA.TextAlign = ContentAlignment.MiddleLeft

        Dim lstRA As New ListBox
        lstRA.Name = "lstRA" & contadorModulos
        lstRA.Location = New Point(posX, posY + alturaEtiqueta + alturaComboBox + alturaEtiqueta)
        lstRA.Width = anchoLista
        lstRA.Height = alturaLista
        lstRA.SelectionMode = SelectionMode.MultiExtended
        lstRA.DisplayMember = "DescripcionRA"

        Dim listaModulos As List(Of Modulo) = Nothing
        Try
            listaModulos = gestionfrm.DevolverModulosDeUnCurso(alumnoActual.Ciclo, alumnoActual.AliasCurso)
        Catch ex As Exception
            MessageBox.Show("Error al cargar módulos: " & ex.Message)
            Return
        End Try

        If listaModulos Is Nothing OrElse listaModulos.Count = 0 Then
            MessageBox.Show("No hay módulos disponibles para el curso del alumno.")
            Return
        End If

        cmbModulo.DataSource = listaModulos

        Dim moduloInicial As Modulo = listaModulos(0)
        Dim listaRAs As List(Of RA) = Nothing
        Try
            listaRAs = gestionfrm.DevolverRAsDeModulo(moduloInicial.CodigoModulo, moduloInicial.Ciclo, moduloInicial.AliasCurso)
        Catch ex As Exception
            MessageBox.Show("Error al cargar RAs: " & ex.Message)
        End Try

        If listaRAs Is Nothing Then listaRAs = New List(Of RA)
        lstRA.DataSource = listaRAs

        AddHandler cmbModulo.SelectedIndexChanged, Sub(obj As Object, args As EventArgs)
                                                       Dim combo As ComboBox = TryCast(obj, ComboBox)
                                                       Dim moduloSeleccionado As Modulo = TryCast(combo.SelectedItem, Modulo)
                                                       If moduloSeleccionado Is Nothing Then
                                                           lstRA.DataSource = Nothing
                                                           Return
                                                       End If
                                                       Dim nuevosRAs As List(Of RA) = gestionfrm.DevolverRAsDeModulo(moduloSeleccionado.CodigoModulo, moduloSeleccionado.Ciclo, moduloSeleccionado.AliasCurso)
                                                       lstRA.DataSource = Nothing
                                                       lstRA.DisplayMember = "DescripcionRA"
                                                       If nuevosRAs IsNot Nothing Then
                                                           lstRA.DataSource = nuevosRAs
                                                       End If
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
        ResetControlesDinamicos()
        txtDescripcion.Clear()
        txtDuracion.Clear()

        alumnoActual = gestionfrm.DevolverAlumnoPorDni(FrmLogin.txtDNI.Text)
        If alumnoActual Is Nothing Then
            MessageBox.Show("No se pudo recuperar el alumno actual. Comprueba el DNI de sesión.")
            Me.Close()
            Return
        End If

        CrearModuloYRA()
    End Sub

    Private Sub FrmAnadirTarea_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        ResetControlesDinamicos()
    End Sub

    Private Sub BtnAnyadirModulo_Click(sender As Object, e As EventArgs) Handles btnAnyadirModulo.Click
        CrearModuloYRA()
    End Sub

    Private Sub btnQuitarModulo_Click(sender As Object, e As EventArgs) Handles btnQuitarModulo.Click
        If contadorModulos <= 1 Then
            Exit Sub
        End If

        Dim ultimoIndice As Integer = contadorModulos - 1

        Dim nombresAQuitar As String() = {"lblModulo" & ultimoIndice, "cmbModulo" & ultimoIndice, "lblRA" & ultimoIndice, "lstRA" & ultimoIndice}
        For Each nq In nombresAQuitar
            Dim controles() As Control = grbControlesDinamicos.Controls.Find(nq, True)
            If controles IsNot Nothing AndAlso controles.Length > 0 Then
                For Each contr In controles
                    grbControlesDinamicos.Controls.Remove(contr)
                Next
            End If
        Next

        If listaModulosDinamicos.Count > ultimoIndice Then
            listaModulosDinamicos.RemoveAt(ultimoIndice)
        End If
        If listaRAsDinamicos.Count > ultimoIndice Then
            listaRAsDinamicos.RemoveAt(ultimoIndice)
        End If

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

        Dim nuevoCodigoTarea As Integer = gestionfrm.ObtenerCodigoTareaPorValores(fecha, alumnoActual.DNI)
        If nuevoCodigoTarea <= 0 Then
            MessageBox.Show("No se pudo obtener el código de la tarea recién insertada.")
            Exit Sub
        End If

        For i As Integer = 0 To listaModulosDinamicos.Count - 1
            Dim cmbModulo As ComboBox = listaModulosDinamicos(i)
            Dim lstRA As ListBox = listaRAsDinamicos(i)

            If cmbModulo.SelectedItem Is Nothing Then
                Continue For
            End If
            Dim modulo As Modulo = TryCast(cmbModulo.SelectedItem, Modulo)

            Dim listaRAsSeleccionados As New List(Of Integer)
            For Each item In lstRA.SelectedItems
                Dim ra As RA = TryCast(item, RA)
                If ra IsNot Nothing Then
                    listaRAsSeleccionados.Add(ra.RA)
                End If
            Next

            Dim respuesta As String = gestionfrm.AñadirRAsYModulosALaTarea(nuevoCodigoTarea, modulo.Ciclo, modulo.AliasCurso, modulo.NombreModulo, listaRAsSeleccionados, fecha, alumnoActual.DNI)
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