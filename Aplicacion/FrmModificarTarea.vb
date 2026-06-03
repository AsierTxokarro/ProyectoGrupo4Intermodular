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
        Dim posY As Integer = 10

        For i As Integer = 0 To tareaAModificar.Modulos.Count - 1
            Dim cmbModulo As New ComboBox
            cmbModulo.Name = "cmbModulo" & i
            cmbModulo.Location = New Point(20, posY)
            cmbModulo.Width = 250
            cmbModulo.DropDownStyle = ComboBoxStyle.DropDownList
            cmbModulo.DisplayMember = "NombreModulo"
            cmbModulo.ValueMember = "CodigoModulo"
            cmbModulo.DataSource = listaModulos

            Dim moduloSeleccionado As Modulo = Nothing

            For Each modulo In listaModulos
                If modulo.NombreModulo = tareaAModificar.Modulos(i) Then
                    moduloSeleccionado = modulo
                    cmbModulo.SelectedItem = modulo
                    Exit For
                End If
            Next

            If moduloSeleccionado IsNot Nothing Then
                Dim listaRAs As List(Of RA) = gestionfrm.DevolverRAsDeModulo(moduloSeleccionado.CodigoModulo, moduloSeleccionado.Ciclo, moduloSeleccionado.AliasCurso)

                Dim lstRA As New ListBox
                lstRA.Name = "lstRA" & i
                lstRA.Location = New Point(300, posY)
                lstRA.Width = 400
                lstRA.Height = 120
                lstRA.SelectionMode = SelectionMode.MultiExtended
                lstRA.DisplayMember = "DescripcionRA"

                For Each ra As RA In listaRAs
                    lstRA.Items.Add(ra)
                Next

                For Each ra As RA In listaRAs
                    If tareaAModificar.RAs.Contains(ra.RA) Then
                        Dim index As Integer = listaRAs.IndexOf(ra)
                        If index >= 0 AndAlso index < lstRA.Items.Count Then
                            lstRA.SetSelected(index, True)
                        End If
                    End If
                Next

                AddHandler cmbModulo.SelectedIndexChanged,
                Sub(objSender As Object, argE As EventArgs)
                    Dim combo As ComboBox = TryCast(objSender, ComboBox)
                    Dim modulo As Modulo = TryCast(combo.SelectedItem, Modulo)
                    If modulo Is Nothing Then
                        lstRA.DataSource = Nothing
                        lstRA.Items.Clear()
                        Return
                    End If
                    Dim nuevosRAs As List(Of RA) = gestionfrm.DevolverRAsDeModulo(modulo.CodigoModulo, modulo.Ciclo, modulo.AliasCurso)

                    lstRA.DataSource = Nothing
                    lstRA.DisplayMember = "DescripcionRA"
                    lstRA.Items.Clear()
                    For Each r As RA In nuevosRAs
                        lstRA.Items.Add(r)
                    Next
                End Sub
                grbControlesDinamicos.Controls.Add(cmbModulo)
                grbControlesDinamicos.Controls.Add(lstRA)
                posY += 140
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