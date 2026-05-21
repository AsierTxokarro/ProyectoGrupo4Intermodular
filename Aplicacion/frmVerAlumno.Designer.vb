<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVerAlumno
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEliminarAlumno = New System.Windows.Forms.Button()
<<<<<<< Updated upstream
=======
        Me.btnPartesSemanales = New System.Windows.Forms.Button()
        Me.btnVerAlarmas = New System.Windows.Forms.Button()
>>>>>>> Stashed changes
        Me.btnVerDatosAlumno = New System.Windows.Forms.Button()
        Me.btnFichajesRealizados = New System.Windows.Forms.Button()
        Me.lblAlumno = New System.Windows.Forms.Label()
        Me.lblNombreAlumno = New System.Windows.Forms.Label()
        Me.lstTareas = New System.Windows.Forms.ListBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.BackColor = System.Drawing.SystemColors.InactiveCaption
<<<<<<< Updated upstream
        Me.btnCerrarSesion.Location = New System.Drawing.Point(152, 334)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(244, 33)
=======
        Me.btnCerrarSesion.Location = New System.Drawing.Point(168, 578)
        Me.btnCerrarSesion.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(278, 41)
>>>>>>> Stashed changes
        Me.btnCerrarSesion.TabIndex = 58
        Me.btnCerrarSesion.Text = "Cerrar Sesion"
        Me.btnCerrarSesion.UseVisualStyleBackColor = False
        '
<<<<<<< Updated upstream
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnEliminarAlumno)
=======
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblV)
        Me.GroupBox1.Controls.Add(Me.lblR)
        Me.GroupBox1.Controls.Add(Me.lblP)
        Me.GroupBox1.Controls.Add(Me.lblA)
        Me.GroupBox1.Controls.Add(Me.txtHorasRestantes)
        Me.GroupBox1.Controls.Add(Me.lblHorasrestantes)
        Me.GroupBox1.Controls.Add(Me.txtHorasTotales)
        Me.GroupBox1.Controls.Add(Me.lblHorasTotales)
        Me.GroupBox1.Controls.Add(Me.txtHorasTrabajadas)
        Me.GroupBox1.Controls.Add(Me.lblHorasTrabajadas)
        Me.GroupBox1.Controls.Add(Me.lbl4)
        Me.GroupBox1.Controls.Add(Me.lbl2)
        Me.GroupBox1.Controls.Add(Me.lbl3)
        Me.GroupBox1.Controls.Add(Me.lbl1)
        Me.GroupBox1.Location = New System.Drawing.Point(459, 364)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(274, 259)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        '
        'lblV
        '
        Me.lblV.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblV.Location = New System.Drawing.Point(124, 48)
        Me.lblV.Name = "lblV"
        Me.lblV.Size = New System.Drawing.Size(21, 20)
        Me.lblV.TabIndex = 50
        '
        'lblR
        '
        Me.lblR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblR.Location = New System.Drawing.Point(124, 72)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(21, 20)
        Me.lblR.TabIndex = 49
        '
        'lblP
        '
        Me.lblP.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblP.Location = New System.Drawing.Point(124, 98)
        Me.lblP.Name = "lblP"
        Me.lblP.Size = New System.Drawing.Size(21, 20)
        Me.lblP.TabIndex = 48
        '
        'lblA
        '
        Me.lblA.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblA.Location = New System.Drawing.Point(124, 22)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(21, 20)
        Me.lblA.TabIndex = 47
        '
        'txtHorasRestantes
        '
        Me.txtHorasRestantes.Enabled = False
        Me.txtHorasRestantes.Location = New System.Drawing.Point(153, 209)
        Me.txtHorasRestantes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHorasRestantes.Name = "txtHorasRestantes"
        Me.txtHorasRestantes.Size = New System.Drawing.Size(104, 26)
        Me.txtHorasRestantes.TabIndex = 46
        '
        'lblHorasrestantes
        '
        Me.lblHorasrestantes.AutoSize = True
        Me.lblHorasrestantes.Location = New System.Drawing.Point(7, 214)
        Me.lblHorasrestantes.Name = "lblHorasrestantes"
        Me.lblHorasrestantes.Size = New System.Drawing.Size(138, 20)
        Me.lblHorasrestantes.TabIndex = 45
        Me.lblHorasrestantes.Text = "Horas Restantes :"
        '
        'txtHorasTotales
        '
        Me.txtHorasTotales.Enabled = False
        Me.txtHorasTotales.Location = New System.Drawing.Point(153, 174)
        Me.txtHorasTotales.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHorasTotales.Name = "txtHorasTotales"
        Me.txtHorasTotales.Size = New System.Drawing.Size(104, 26)
        Me.txtHorasTotales.TabIndex = 44
        '
        'lblHorasTotales
        '
        Me.lblHorasTotales.AutoSize = True
        Me.lblHorasTotales.Location = New System.Drawing.Point(7, 178)
        Me.lblHorasTotales.Name = "lblHorasTotales"
        Me.lblHorasTotales.Size = New System.Drawing.Size(116, 20)
        Me.lblHorasTotales.TabIndex = 43
        Me.lblHorasTotales.Text = "Horas Totales :"
        '
        'txtHorasTrabajadas
        '
        Me.txtHorasTrabajadas.Enabled = False
        Me.txtHorasTrabajadas.Location = New System.Drawing.Point(153, 138)
        Me.txtHorasTrabajadas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHorasTrabajadas.Name = "txtHorasTrabajadas"
        Me.txtHorasTrabajadas.Size = New System.Drawing.Size(104, 26)
        Me.txtHorasTrabajadas.TabIndex = 42
        '
        'lblHorasTrabajadas
        '
        Me.lblHorasTrabajadas.AutoSize = True
        Me.lblHorasTrabajadas.Location = New System.Drawing.Point(7, 141)
        Me.lblHorasTrabajadas.Name = "lblHorasTrabajadas"
        Me.lblHorasTrabajadas.Size = New System.Drawing.Size(143, 20)
        Me.lblHorasTrabajadas.TabIndex = 41
        Me.lblHorasTrabajadas.Text = "Horas Trabajadas :"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(7, 98)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(102, 20)
        Me.lbl4.TabIndex = 40
        Me.lbl4.Text = "Fecha Salida"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(7, 48)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(109, 20)
        Me.lbl2.TabIndex = 39
        Me.lbl2.Text = "Dias Asistidos"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(7, 72)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(107, 20)
        Me.lbl3.TabIndex = 38
        Me.lbl3.Text = "Dias Faltados"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(7, 22)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(117, 20)
        Me.lbl1.TabIndex = 37
        Me.lbl1.Text = "Fecha de Inicio"
        '
        'btnVerCalendario
        '
        Me.btnVerCalendario.Location = New System.Drawing.Point(459, 32)
        Me.btnVerCalendario.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnVerCalendario.Name = "btnVerCalendario"
        Me.btnVerCalendario.Size = New System.Drawing.Size(248, 61)
        Me.btnVerCalendario.TabIndex = 56
        Me.btnVerCalendario.Text = "Ver Caledario"
        Me.btnVerCalendario.UseVisualStyleBackColor = True
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(459, 106)
        Me.MonthCalendar2.Margin = New System.Windows.Forms.Padding(10, 11, 10, 11)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 55
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnEliminarAlumno)
        Me.GroupBox2.Controls.Add(Me.btnPartesSemanales)
        Me.GroupBox2.Controls.Add(Me.btnVerAlarmas)
>>>>>>> Stashed changes
        Me.GroupBox2.Controls.Add(Me.btnVerDatosAlumno)
        Me.GroupBox2.Controls.Add(Me.btnFichajesRealizados)
        Me.GroupBox2.Controls.Add(Me.lblAlumno)
        Me.GroupBox2.Controls.Add(Me.lblNombreAlumno)
        Me.GroupBox2.Location = New System.Drawing.Point(171, 39)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
<<<<<<< Updated upstream
        Me.GroupBox2.Size = New System.Drawing.Size(244, 286)
=======
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(262, 534)
>>>>>>> Stashed changes
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        '
        'btnEliminarAlumno
        '
<<<<<<< Updated upstream
        Me.btnEliminarAlumno.Location = New System.Drawing.Point(9, 208)
=======
        Me.btnEliminarAlumno.Location = New System.Drawing.Point(7, 430)
        Me.btnEliminarAlumno.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
>>>>>>> Stashed changes
        Me.btnEliminarAlumno.Name = "btnEliminarAlumno"
        Me.btnEliminarAlumno.Size = New System.Drawing.Size(243, 61)
        Me.btnEliminarAlumno.TabIndex = 51
        Me.btnEliminarAlumno.Text = "Eliminar Alumno"
        Me.btnEliminarAlumno.UseVisualStyleBackColor = True
        '
<<<<<<< Updated upstream
        'btnVerDatosAlumno
        '
        Me.btnVerDatosAlumno.Location = New System.Drawing.Point(9, 137)
=======
        'btnPartesSemanales
        '
        Me.btnPartesSemanales.Location = New System.Drawing.Point(7, 155)
        Me.btnPartesSemanales.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPartesSemanales.Name = "btnPartesSemanales"
        Me.btnPartesSemanales.Size = New System.Drawing.Size(243, 61)
        Me.btnPartesSemanales.TabIndex = 49
        Me.btnPartesSemanales.Text = "Partes Semanales"
        Me.btnPartesSemanales.UseVisualStyleBackColor = True
        '
        'btnVerAlarmas
        '
        Me.btnVerAlarmas.Location = New System.Drawing.Point(7, 224)
        Me.btnVerAlarmas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnVerAlarmas.Name = "btnVerAlarmas"
        Me.btnVerAlarmas.Size = New System.Drawing.Size(243, 61)
        Me.btnVerAlarmas.TabIndex = 48
        Me.btnVerAlarmas.Text = "Ver Alertas"
        Me.btnVerAlarmas.UseVisualStyleBackColor = True
        '
        'btnVerDatosAlumno
        '
        Me.btnVerDatosAlumno.Location = New System.Drawing.Point(7, 292)
        Me.btnVerDatosAlumno.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
>>>>>>> Stashed changes
        Me.btnVerDatosAlumno.Name = "btnVerDatosAlumno"
        Me.btnVerDatosAlumno.Size = New System.Drawing.Size(243, 61)
        Me.btnVerDatosAlumno.TabIndex = 47
        Me.btnVerDatosAlumno.Text = "Datos del Alumno"
        Me.btnVerDatosAlumno.UseVisualStyleBackColor = True
        '
<<<<<<< Updated upstream
=======
        'btnCambiarAlumno
        '
        Me.btnCambiarAlumno.Location = New System.Drawing.Point(7, 361)
        Me.btnCambiarAlumno.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnCambiarAlumno.Name = "btnCambiarAlumno"
        Me.btnCambiarAlumno.Size = New System.Drawing.Size(243, 61)
        Me.btnCambiarAlumno.TabIndex = 46
        Me.btnCambiarAlumno.Text = "Cambiar Alumno"
        Me.btnCambiarAlumno.UseVisualStyleBackColor = True
        '
>>>>>>> Stashed changes
        'btnFichajesRealizados
        '
        Me.btnFichajesRealizados.Location = New System.Drawing.Point(7, 86)
        Me.btnFichajesRealizados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnFichajesRealizados.Name = "btnFichajesRealizados"
        Me.btnFichajesRealizados.Size = New System.Drawing.Size(243, 61)
        Me.btnFichajesRealizados.TabIndex = 45
        Me.btnFichajesRealizados.Text = "Tareas"
        Me.btnFichajesRealizados.UseVisualStyleBackColor = True
        '
        'lblAlumno
        '
        Me.lblAlumno.AutoSize = True
        Me.lblAlumno.Location = New System.Drawing.Point(7, 31)
        Me.lblAlumno.Name = "lblAlumno"
        Me.lblAlumno.Size = New System.Drawing.Size(74, 20)
        Me.lblAlumno.TabIndex = 43
        Me.lblAlumno.Text = "Alumn@:"
        '
        'lblNombreAlumno
        '
        Me.lblNombreAlumno.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblNombreAlumno.Location = New System.Drawing.Point(82, 22)
        Me.lblNombreAlumno.Name = "lblNombreAlumno"
        Me.lblNombreAlumno.Size = New System.Drawing.Size(168, 36)
        Me.lblNombreAlumno.TabIndex = 44
        '
<<<<<<< Updated upstream
        'lstTareas
        '
        Me.lstTareas.FormattingEnabled = True
        Me.lstTareas.ItemHeight = 16
        Me.lstTareas.Location = New System.Drawing.Point(515, 43)
        Me.lstTareas.Name = "lstTareas"
        Me.lstTareas.Size = New System.Drawing.Size(336, 532)
        Me.lstTareas.TabIndex = 59
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(161, 379)
        Me.MonthCalendar1.MaxSelectionCount = 1
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 62
        '
=======
>>>>>>> Stashed changes
        'frmVerAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
<<<<<<< Updated upstream
        Me.ClientSize = New System.Drawing.Size(995, 625)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.lstTareas)
=======
        Me.ClientSize = New System.Drawing.Size(1119, 781)
>>>>>>> Stashed changes
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.GroupBox2)
<<<<<<< Updated upstream
=======
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
>>>>>>> Stashed changes
        Me.Name = "frmVerAlumno"
        Me.Text = "FrmTutor2"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnEliminarAlumno As Button
<<<<<<< Updated upstream
=======
    Friend WithEvents btnPartesSemanales As Button
    Friend WithEvents btnVerAlarmas As Button
>>>>>>> Stashed changes
    Friend WithEvents btnVerDatosAlumno As Button
    Friend WithEvents btnFichajesRealizados As Button
    Friend WithEvents lblAlumno As Label
    Friend WithEvents lblNombreAlumno As Label
    Friend WithEvents lstTareas As ListBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
End Class
