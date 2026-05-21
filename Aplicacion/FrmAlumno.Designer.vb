<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAlumno
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnVerMisDatos = New System.Windows.Forms.Button()
        Me.btnPartesSemanales = New System.Windows.Forms.Button()
        Me.btnFichajesRealizados = New System.Windows.Forms.Button()
        Me.lblNombreAlumno = New System.Windows.Forms.Label()
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
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.btnVerMisDatos)
        Me.GroupBox2.Controls.Add(Me.btnPartesSemanales)
        Me.GroupBox2.Controls.Add(Me.btnFichajesRealizados)
        Me.GroupBox2.Controls.Add(Me.lblNombreAlumno)
        Me.GroupBox2.Location = New System.Drawing.Point(116, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(568, 480)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button1.Location = New System.Drawing.Point(12, 409)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(328, 54)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "Cerrar Sesion"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnVerMisDatos
        '
        Me.btnVerMisDatos.Location = New System.Drawing.Point(14, 293)
        Me.btnVerMisDatos.Name = "btnVerMisDatos"
        Me.btnVerMisDatos.Size = New System.Drawing.Size(326, 49)
        Me.btnVerMisDatos.TabIndex = 55
        Me.btnVerMisDatos.Text = "Mis Datos"
        Me.btnVerMisDatos.UseVisualStyleBackColor = True
        '
        'btnPartesSemanales
        '
        Me.btnPartesSemanales.Location = New System.Drawing.Point(12, 238)
        Me.btnPartesSemanales.Name = "btnPartesSemanales"
        Me.btnPartesSemanales.Size = New System.Drawing.Size(326, 49)
        Me.btnPartesSemanales.TabIndex = 56
        Me.btnPartesSemanales.Text = "Partes Semanales"
        Me.btnPartesSemanales.UseVisualStyleBackColor = True
        '
        'btnFichajesRealizados
        '
        Me.btnFichajesRealizados.Location = New System.Drawing.Point(14, 179)
        Me.btnFichajesRealizados.Name = "btnFichajesRealizados"
        Me.btnFichajesRealizados.Size = New System.Drawing.Size(326, 49)
        Me.btnFichajesRealizados.TabIndex = 54
        Me.btnFichajesRealizados.Text = "Fichajes Realizados "
        Me.btnFichajesRealizados.UseVisualStyleBackColor = True
        '
        'lblNombreAlumno
        '
        Me.lblNombreAlumno.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblNombreAlumno.Location = New System.Drawing.Point(12, 18)
        Me.lblNombreAlumno.Name = "lblNombreAlumno"
        Me.lblNombreAlumno.Size = New System.Drawing.Size(328, 29)
        Me.lblNombreAlumno.TabIndex = 53
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
        Me.GroupBox1.Location = New System.Drawing.Point(684, 327)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(226, 207)
        Me.GroupBox1.TabIndex = 56
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
        Me.btnVerCalendario.Location = New System.Drawing.Point(684, 60)
        Me.btnVerCalendario.Name = "btnVerCalendario"
        Me.btnVerCalendario.Size = New System.Drawing.Size(220, 49)
        Me.btnVerCalendario.TabIndex = 55
        Me.btnVerCalendario.Text = "Ver Caledario"
        Me.btnVerCalendario.UseVisualStyleBackColor = True
        '
        'MonthCalendar2
        '
        Me.MonthCalendar2.Location = New System.Drawing.Point(684, 119)
        Me.MonthCalendar2.Name = "MonthCalendar2"
        Me.MonthCalendar2.TabIndex = 54
        '
        'FrmAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1027, 588)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnVerCalendario)
        Me.Controls.Add(Me.MonthCalendar2)
        Me.Name = "FrmAlumno"
        Me.Text = "Form1"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnVerMisDatos As Button
    Friend WithEvents btnPartesSemanales As Button
    Friend WithEvents btnFichajesRealizados As Button
    Friend WithEvents lblNombreAlumno As Label
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
End Class
