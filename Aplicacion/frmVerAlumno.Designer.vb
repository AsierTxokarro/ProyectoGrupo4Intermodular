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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblV = New System.Windows.Forms.Label()
        Me.lblR = New System.Windows.Forms.Label()
        Me.lblP = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.txtHorasRestantes = New System.Windows.Forms.TextBox()
        Me.lblHorasrestantes = New System.Windows.Forms.Label()
        Me.txtHorasTotales = New System.Windows.Forms.TextBox()
        Me.lblHorasTotales = New System.Windows.Forms.Label()
        Me.txtHorasTrabajadas = New System.Windows.Forms.TextBox()
        Me.lblHorasTrabajadas = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.btnVerCalendario = New System.Windows.Forms.Button()
        Me.MonthCalendar2 = New System.Windows.Forms.MonthCalendar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEliminarAlumno = New System.Windows.Forms.Button()
        Me.btnNumeroAlertas = New System.Windows.Forms.Button()
        Me.btnPartesSemanales = New System.Windows.Forms.Button()
        Me.btnVerAlarmas = New System.Windows.Forms.Button()
        Me.btnVerDatosAlumno = New System.Windows.Forms.Button()
        Me.btnCambiarAlumno = New System.Windows.Forms.Button()
        Me.btnFichajesRealizados = New System.Windows.Forms.Button()
        Me.lblAlumno = New System.Windows.Forms.Label()
        Me.lblNombreAlumno = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnCerrarSesion.Location = New System.Drawing.Point(149, 462)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(247, 33)
        Me.btnCerrarSesion.TabIndex = 58
        Me.btnCerrarSesion.Text = "Cerrar Sesion"
        Me.btnCerrarSesion.UseVisualStyleBackColor = False
        '
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
        Me.GroupBox1.Location = New System.Drawing.Point(408, 291)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(244, 207)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        '
        'lblV
        '
        Me.lblV.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblV.Location = New System.Drawing.Point(110, 38)
        Me.lblV.Name = "lblV"
        Me.lblV.Size = New System.Drawing.Size(19, 16)
        Me.lblV.TabIndex = 50
        '
        'lblR
        '
        Me.lblR.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblR.Location = New System.Drawing.Point(110, 58)
        Me.lblR.Name = "lblR"
        Me.lblR.Size = New System.Drawing.Size(19, 16)
        Me.lblR.TabIndex = 49
        '
        'lblP
        '
        Me.lblP.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblP.Location = New System.Drawing.Point(110, 78)
        Me.lblP.Name = "lblP"
        Me.lblP.Size = New System.Drawing.Size(19, 16)
        Me.lblP.TabIndex = 48
        '
        'lblA
        '
        Me.lblA.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblA.Location = New System.Drawing.Point(110, 18)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(19, 16)
        Me.lblA.TabIndex = 47
        '
        'txtHorasRestantes
        '
        Me.txtHorasRestantes.Enabled = False
        Me.txtHorasRestantes.Location = New System.Drawing.Point(136, 167)
        Me.txtHorasRestantes.Name = "txtHorasRestantes"
        Me.txtHorasRestantes.Size = New System.Drawing.Size(93, 22)
        Me.txtHorasRestantes.TabIndex = 46
        '
        'lblHorasrestantes
        '
        Me.lblHorasrestantes.AutoSize = True
        Me.lblHorasrestantes.Location = New System.Drawing.Point(6, 171)
        Me.lblHorasrestantes.Name = "lblHorasrestantes"
        Me.lblHorasrestantes.Size = New System.Drawing.Size(114, 16)
        Me.lblHorasrestantes.TabIndex = 45
        Me.lblHorasrestantes.Text = "Horas Restantes :"
        '
        'txtHorasTotales
        '
        Me.txtHorasTotales.Enabled = False
        Me.txtHorasTotales.Location = New System.Drawing.Point(136, 139)
        Me.txtHorasTotales.Name = "txtHorasTotales"
        Me.txtHorasTotales.Size = New System.Drawing.Size(93, 22)
        Me.txtHorasTotales.TabIndex = 44
        '
        'lblHorasTotales
        '
        Me.lblHorasTotales.AutoSize = True
        Me.lblHorasTotales.Location = New System.Drawing.Point(6, 142)
        Me.lblHorasTotales.Name = "lblHorasTotales"
        Me.lblHorasTotales.Size = New System.Drawing.Size(99, 16)
        Me.lblHorasTotales.TabIndex = 43
        Me.lblHorasTotales.Text = "Horas Totales :"
        '
        'txtHorasTrabajadas
        '
        Me.txtHorasTrabajadas.Enabled = False
        Me.txtHorasTrabajadas.Location = New System.Drawing.Point(136, 110)
        Me.txtHorasTrabajadas.Name = "txtHorasTrabajadas"
        Me.txtHorasTrabajadas.Size = New System.Drawing.Size(93, 22)
        Me.txtHorasTrabajadas.TabIndex = 42
        '
        'lblHorasTrabajadas
        '
        Me.lblHorasTrabajadas.AutoSize = True
        Me.lblHorasTrabajadas.Location = New System.Drawing.Point(6, 113)
        Me.lblHorasTrabajadas.Name = "lblHorasTrabajadas"
        Me.lblHorasTrabajadas.Size = New System.Drawing.Size(124, 16)
        Me.lblHorasTrabajadas.TabIndex = 41
        Me.lblHorasTrabajadas.Text = "Horas Trabajadas :"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(6, 78)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(87, 16)
        Me.lbl4.TabIndex = 40
        Me.lbl4.Text = "Fecha Salida"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(6, 38)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(93, 16)
        Me.lbl2.TabIndex = 39
        Me.lbl2.Text = "Dias Asistidos"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(6, 58)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(91, 16)
        Me.lbl3.TabIndex = 38
        Me.lbl3.Text = "Dias Faltados"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(6, 18)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(98, 16)
        Me.lbl1.TabIndex = 37
        Me.lbl1.Text = "Fecha de Inicio"
        '
        'btnVerCalendario
        '
        Me.btnVerCalendario.Location = New System.Drawing.Point(408, 26)
        Me.btnVerCalendario.Name = "btnVerCalendario"
        Me.btnVerCalendario.Size = New System.Drawing.Size(220, 49)
        Me.btnVerCalendario.TabIndex = 56
        Me.btnVerCalendario.Text = "Ver Caledario"
        Me.btnVerCalendario.UseVisualStyleBackColor = True
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(408, 85)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 55
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnEliminarAlumno)
        Me.GroupBox2.Controls.Add(Me.btnNumeroAlertas)
        Me.GroupBox2.Controls.Add(Me.btnPartesSemanales)
        Me.GroupBox2.Controls.Add(Me.btnVerAlarmas)
        Me.GroupBox2.Controls.Add(Me.btnVerDatosAlumno)
        Me.GroupBox2.Controls.Add(Me.btnCambiarAlumno)
        Me.GroupBox2.Controls.Add(Me.btnFichajesRealizados)
        Me.GroupBox2.Controls.Add(Me.lblAlumno)
        Me.GroupBox2.Controls.Add(Me.lblNombreAlumno)
        Me.GroupBox2.Location = New System.Drawing.Point(152, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(244, 427)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        '
        'btnEliminarAlumno
        '
        Me.btnEliminarAlumno.Location = New System.Drawing.Point(9, 344)
        Me.btnEliminarAlumno.Name = "btnEliminarAlumno"
        Me.btnEliminarAlumno.Size = New System.Drawing.Size(216, 49)
        Me.btnEliminarAlumno.TabIndex = 51
        Me.btnEliminarAlumno.Text = "Eliminar Alumno"
        Me.btnEliminarAlumno.UseVisualStyleBackColor = True
        '
        'btnNumeroAlertas
        '
        Me.btnNumeroAlertas.ForeColor = System.Drawing.Color.Red
        Me.btnNumeroAlertas.Location = New System.Drawing.Point(160, 179)
        Me.btnNumeroAlertas.Name = "btnNumeroAlertas"
        Me.btnNumeroAlertas.Size = New System.Drawing.Size(62, 49)
        Me.btnNumeroAlertas.TabIndex = 50
        Me.btnNumeroAlertas.UseVisualStyleBackColor = True
        '
        'btnPartesSemanales
        '
        Me.btnPartesSemanales.Location = New System.Drawing.Point(6, 124)
        Me.btnPartesSemanales.Name = "btnPartesSemanales"
        Me.btnPartesSemanales.Size = New System.Drawing.Size(216, 49)
        Me.btnPartesSemanales.TabIndex = 49
        Me.btnPartesSemanales.Text = "Partes Semanales"
        Me.btnPartesSemanales.UseVisualStyleBackColor = True
        '
        'btnVerAlarmas
        '
        Me.btnVerAlarmas.Location = New System.Drawing.Point(9, 179)
        Me.btnVerAlarmas.Name = "btnVerAlarmas"
        Me.btnVerAlarmas.Size = New System.Drawing.Size(158, 49)
        Me.btnVerAlarmas.TabIndex = 48
        Me.btnVerAlarmas.Text = "Ver Alertas"
        Me.btnVerAlarmas.UseVisualStyleBackColor = True
        '
        'btnVerDatosAlumno
        '
        Me.btnVerDatosAlumno.Location = New System.Drawing.Point(6, 234)
        Me.btnVerDatosAlumno.Name = "btnVerDatosAlumno"
        Me.btnVerDatosAlumno.Size = New System.Drawing.Size(216, 49)
        Me.btnVerDatosAlumno.TabIndex = 47
        Me.btnVerDatosAlumno.Text = "Datos del Alumno"
        Me.btnVerDatosAlumno.UseVisualStyleBackColor = True
        '
        'btnCambiarAlumno
        '
        Me.btnCambiarAlumno.Location = New System.Drawing.Point(6, 289)
        Me.btnCambiarAlumno.Name = "btnCambiarAlumno"
        Me.btnCambiarAlumno.Size = New System.Drawing.Size(216, 49)
        Me.btnCambiarAlumno.TabIndex = 46
        Me.btnCambiarAlumno.Text = "Cambiar Alumno"
        Me.btnCambiarAlumno.UseVisualStyleBackColor = True
        '
        'btnFichajesRealizados
        '
        Me.btnFichajesRealizados.Location = New System.Drawing.Point(6, 69)
        Me.btnFichajesRealizados.Name = "btnFichajesRealizados"
        Me.btnFichajesRealizados.Size = New System.Drawing.Size(216, 49)
        Me.btnFichajesRealizados.TabIndex = 45
        Me.btnFichajesRealizados.Text = "Fichajes Realizados"
        Me.btnFichajesRealizados.UseVisualStyleBackColor = True
        '
        'lblAlumno
        '
        Me.lblAlumno.AutoSize = True
        Me.lblAlumno.Location = New System.Drawing.Point(6, 25)
        Me.lblAlumno.Name = "lblAlumno"
        Me.lblAlumno.Size = New System.Drawing.Size(61, 16)
        Me.lblAlumno.TabIndex = 43
        Me.lblAlumno.Text = "Alumn@:"
        '
        'lblNombreAlumno
        '
        Me.lblNombreAlumno.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblNombreAlumno.Location = New System.Drawing.Point(73, 18)
        Me.lblNombreAlumno.Name = "lblNombreAlumno"
        Me.lblNombreAlumno.Size = New System.Drawing.Size(149, 29)
        Me.lblNombreAlumno.TabIndex = 44
        '
        'FrmTutor2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 625)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnVerCalendario)
        Me.Controls.Add(Me.MonthCalendar2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FrmTutor2"
        Me.Text = "FrmTutor2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblV As Label
    Friend WithEvents lblR As Label
    Friend WithEvents lblP As Label
    Friend WithEvents lblA As Label
    Friend WithEvents txtHorasRestantes As TextBox
    Friend WithEvents lblHorasrestantes As Label
    Friend WithEvents txtHorasTotales As TextBox
    Friend WithEvents lblHorasTotales As Label
    Friend WithEvents txtHorasTrabajadas As TextBox
    Friend WithEvents lblHorasTrabajadas As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents btnVerCalendario As Button
    Friend WithEvents MonthCalendar2 As MonthCalendar
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnEliminarAlumno As Button
    Friend WithEvents btnNumeroAlertas As Button
    Friend WithEvents btnPartesSemanales As Button
    Friend WithEvents btnVerAlarmas As Button
    Friend WithEvents btnVerDatosAlumno As Button
    Friend WithEvents btnCambiarAlumno As Button
    Friend WithEvents btnFichajesRealizados As Button
    Friend WithEvents lblAlumno As Label
    Friend WithEvents lblNombreAlumno As Label
End Class
