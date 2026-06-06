Imports Entidades

Public Class FrmModificarTarea
    Dim tareaAModificar As TareasCompletas
    Dim alumno As Alumno
    Private Sub FrmModificarTarea_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tareaAModificar = TryCast(FrmVerTareasAlumno.lstTareas.SelectedItem, TareasCompletas)
        If tareaAModificar Is Nothing Then
            MessageBox.Show("No hay ninguna tarea seleccionada.")
            Me.Close()
            Return
        End If

        alumno = gestionfrm.DevolverAlumnoPorDni(FrmLogin.txtDNI.Text)
        If alumno Is Nothing Then
            MessageBox.Show("No se ha podido recuperar el alumno.")
            Me.Close()
            Return
        End If

        For i As Integer = grbControlesDinamicos.Controls.Count - 1 To 0 Step -1
            grbControlesDinamicos.Controls.Remove(grbControlesDinamicos.Controls(i))
        Next

        lblFechaJornada.Text = tareaAModificar.FechaJornada
        txtDescripcion.Text = tareaAModificar.DescripcionTarea
        txtDuracion.Text = tareaAModificar.Duracion

        Dim listaModulos As List(Of Modulo) = gestionfrm.DevolverModulosDeUnCurso(alumno.Ciclo, alumno.AliasCurso)

        Dim posX As Integer = 20
        Dim posY As Integer = 10
        Dim controlWidthModulo As Integer = 200
        Dim controlWidthLista As Integer = 250
        Dim controlHeight As Integer = 120
        Dim spaceBetweenColumns As Integer = 40
        Dim stepY As Integer = controlHeight + 20
        Dim columnWidth As Integer = controlWidthModulo + controlWidthLista + spaceBetweenColumns

        For i As Integer = 0 To tareaAModificar.Modulos.Count - 1
            Dim cmbModulo As New ComboBox
            cmbModulo.Name = "cmbModulo" & i
            cmbModulo.Location = New Point(posX, posY)
            cmbModulo.Width = controlWidthModulo
            cmbModulo.DropDownStyle = ComboBoxStyle.DropDownList
            cmbModulo.DisplayMember = "NombreModulo"
            cmbModulo.ValueMember = "CodigoModulo"

            Dim modulosCopia As New List(Of Modulo)(listaModulos)
            cmbModulo.BindingContext = New BindingContext()
            cmbModulo.DataSource = modulosCopia

            Dim selectedIndex As Integer = -1
            For idx As Integer = 0 To modulosCopia.Count - 1
                If modulosCopia(idx).NombreModulo = tareaAModificar.Modulos(i) Then
                    selectedIndex = idx
                    Exit For
                End If
            Next

            Dim moduloSeleccionado As Modulo = Nothing
            If selectedIndex >= 0 Then
                cmbModulo.SelectedIndex = selectedIndex
                moduloSeleccionado = modulosCopia(selectedIndex)
            Else
                cmbModulo.SelectedIndex = -1
            End If

            If moduloSeleccionado IsNot Nothing Then
                Dim rAsDelModulo As List(Of RA) = gestionfrm.DevolverRAsDeModulo(moduloSeleccionado.CodigoModulo, moduloSeleccionado.Ciclo, moduloSeleccionado.AliasCurso)

                Dim lstRA As New ListBox
                lstRA.Name = "lstRA" & i
                lstRA.Location = New Point(posX + controlWidthModulo + 30, posY)
                lstRA.Width = controlWidthLista
                lstRA.Height = controlHeight
                lstRA.SelectionMode = SelectionMode.MultiExtended
                lstRA.DisplayMember = "DescripcionRA"

                For Each ra As RA In rAsDelModulo
                    lstRA.Items.Add(ra)
                Next

                For Each ra As RA In rAsDelModulo
                    If tareaAModificar.DescripcionesRAs.Contains(ra.DescripcionRA) Then
                        Dim index As Integer = rAsDelModulo.IndexOf(ra)
                        If index >= 0 AndAlso index < lstRA.Items.Count Then
                            lstRA.SetSelected(index, True)
                        End If
                    End If
                Next

                Dim lstRALocal As ListBox = lstRA
                Dim cmbModuloLocal As ComboBox = cmbModulo

                AddHandler cmbModuloLocal.SelectedIndexChanged,
                Sub(objSender As Object, argE As EventArgs)
                    Dim combo As ComboBox = TryCast(objSender, ComboBox)
                    Dim modulo As Modulo = TryCast(combo.SelectedItem, Modulo)
                    If modulo Is Nothing Then
                        lstRALocal.DataSource = Nothing
                        lstRALocal.Items.Clear()
                        Return
                    End If
                    Dim nuevosRAs As List(Of RA) = gestionfrm.DevolverRAsDeModulo(modulo.CodigoModulo, modulo.Ciclo, modulo.AliasCurso)

                    lstRALocal.DataSource = Nothing
                    lstRALocal.DisplayMember = "DescripcionRA"
                    lstRALocal.Items.Clear()
                    For Each ra As RA In nuevosRAs
                        lstRALocal.Items.Add(ra)
                    Next
                End Sub

                grbControlesDinamicos.Controls.Add(cmbModulo)
                grbControlesDinamicos.Controls.Add(lstRA)

                posY += stepY
                If posY + controlHeight > grbControlesDinamicos.ClientSize.Height - 10 Then
                    posY = 10
                    posX += columnWidth
                End If
            End If
        Next
    End Sub

    Private Sub txtDuracion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDuracion.KeyPress
        Dim separador As Char = "."c

        If e.KeyChar = ChrW(Keys.Back) Then
            Exit Sub
        End If

        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> separador Then
            e.Handled = True
            Exit Sub
        End If

        If e.KeyChar = separador AndAlso txtDuracion.Text = "" Then
            txtDuracion.Text = "0" & separador
            txtDuracion.SelectionStart = txtDuracion.Text.Length
            e.Handled = True
            Exit Sub
        End If

        If e.KeyChar = separador AndAlso txtDuracion.Text.Contains(separador) Then
            e.Handled = True
            Exit Sub
        End If

        If e.KeyChar = "0"c AndAlso txtDuracion.Text = "0" Then
            e.Handled = True
            Exit Sub
        End If

        If Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "0"c AndAlso txtDuracion.Text = "0" Then
            txtDuracion.Text = ""
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim resultadoDescripcion As String = gestionfrm.ModificarDescripcionTarea(tareaAModificar, txtDescripcion.Text.Trim())
        If resultadoDescripcion.StartsWith("Error") Then
            MessageBox.Show(resultadoDescripcion)
            Exit Sub
        End If

        Dim duracionNueva As Decimal
        If Not Decimal.TryParse(txtDuracion.Text, duracionNueva) Then
            MessageBox.Show("La duración no es válida")
            Exit Sub
        End If

        Dim diferenciaDuracion As Decimal = duracionNueva - tareaAModificar.Duracion
        If diferenciaDuracion > 0 Then
            Dim comprobarDuracionJornada As Boolean = gestionfrm.ComprobarCapacidadJornada(tareaAModificar.FechaJornada, tareaAModificar.DniAlumno, diferenciaDuracion)
            If Not comprobarDuracionJornada Then
                MessageBox.Show("No se puede aumentar la duración: la suma de las tareas de la jornada superaría la duración de la jornada.")
                Exit Sub
            End If
        End If

        Dim resultadoDuracion As String = gestionfrm.ModificarDuracionTarea(tareaAModificar, duracionNueva)
        If resultadoDuracion.StartsWith("Error") Then
            MessageBox.Show(resultadoDuracion)
            Exit Sub
        End If

        For Each control As Control In grbControlesDinamicos.Controls
            If TypeOf control Is ComboBox Then
                Dim cmbModulo As ComboBox = TryCast(control, ComboBox)
                Dim indice As String = cmbModulo.Name.Replace("cmbModulo", "")
                If String.IsNullOrWhiteSpace(indice) Then
                    Continue For
                End If

                Dim lstRA As ListBox = TryCast(grbControlesDinamicos.Controls("lstRA" & indice), ListBox)
                If cmbModulo.SelectedItem Is Nothing Then
                    Continue For
                End If

                If lstRA Is Nothing Then
                    Continue For
                End If

                Dim moduloSeleccionado As Modulo = TryCast(cmbModulo.SelectedItem, Modulo)
                If moduloSeleccionado Is Nothing Then
                    Continue For
                End If

                Dim nuevosRAs As New List(Of Integer)

                For Each itemSeleccionado In lstRA.SelectedItems
                    Dim raSeleccionado As RA = TryCast(itemSeleccionado, RA)
                    If raSeleccionado IsNot Nothing Then
                        nuevosRAs.Add(raSeleccionado.RA)
                    End If
                Next

                Dim moduloOriginal As String = tareaAModificar.Modulos(Convert.ToInt32(indice))
                Dim resultado As String =
                gestionfrm.ModificarModulosYRAsTarea(tareaAModificar, moduloOriginal, moduloSeleccionado.NombreModulo, nuevosRAs, moduloSeleccionado.Ciclo, moduloSeleccionado.AliasCurso)
                If resultado.StartsWith("Error") Then
                    MessageBox.Show(resultado)
                    Exit Sub
                End If
            End If
        Next
        MessageBox.Show("La tarea se ha modificado correctamente")
        Me.Close()
    End Sub
End Class