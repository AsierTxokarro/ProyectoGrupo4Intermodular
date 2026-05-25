<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCrearAlumno
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblHoras = New System.Windows.Forms.Label()
        Me.txtHorasTotales = New System.Windows.Forms.TextBox()
        Me.Cursos = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Ciclos = New System.Windows.Forms.ListBox()
        Me.lblCiclos = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.lblApellido1 = New System.Windows.Forms.Label()
        Me.txtApellidoUno = New System.Windows.Forms.TextBox()
        Me.lblApellido2 = New System.Windows.Forms.Label()
        Me.txtApellidoDos = New System.Windows.Forms.TextBox()
        Me.lblCorreo = New System.Windows.Forms.Label()
        Me.txtCorreoElec = New System.Windows.Forms.TextBox()
        Me.lblBuscarAlumno = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSalir.Location = New System.Drawing.Point(24, 342)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(175, 29)
        Me.btnSalir.TabIndex = 34
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.lblHoras)
        Me.GroupBox1.Controls.Add(Me.txtHorasTotales)
        Me.GroupBox1.Controls.Add(Me.Cursos)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Ciclos)
        Me.GroupBox1.Controls.Add(Me.lblCiclos)
        Me.GroupBox1.Controls.Add(Me.lblDNI)
        Me.GroupBox1.Controls.Add(Me.txtDNI)
        Me.GroupBox1.Controls.Add(Me.lblApellido1)
        Me.GroupBox1.Controls.Add(Me.txtApellidoUno)
        Me.GroupBox1.Controls.Add(Me.lblApellido2)
        Me.GroupBox1.Controls.Add(Me.txtApellidoDos)
        Me.GroupBox1.Controls.Add(Me.lblCorreo)
        Me.GroupBox1.Controls.Add(Me.txtCorreoElec)
        Me.GroupBox1.Controls.Add(Me.lblBuscarAlumno)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(753, 250)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'lblHoras
        '
        Me.lblHoras.AutoSize = True
        Me.lblHoras.Location = New System.Drawing.Point(345, 182)
        Me.lblHoras.Name = "lblHoras"
        Me.lblHoras.Size = New System.Drawing.Size(99, 16)
        Me.lblHoras.TabIndex = 46
        Me.lblHoras.Text = "Horas Totales :"
        Me.lblHoras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtHorasTotales
        '
        Me.txtHorasTotales.Location = New System.Drawing.Point(450, 179)
        Me.txtHorasTotales.Name = "txtHorasTotales"
        Me.txtHorasTotales.Size = New System.Drawing.Size(94, 22)
        Me.txtHorasTotales.TabIndex = 45
        '
        'Cursos
        '
        Me.Cursos.FormattingEnabled = True
        Me.Cursos.ItemHeight = 16
        Me.Cursos.Items.AddRange(New Object() {"DES", "DAM", "ASIR", "SMR"})
        Me.Cursos.Location = New System.Drawing.Point(76, 182)
        Me.Cursos.Name = "Cursos"
        Me.Cursos.Size = New System.Drawing.Size(139, 20)
        Me.Cursos.TabIndex = 44
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 16)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Cursos :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ciclos
        '
        Me.Ciclos.FormattingEnabled = True
        Me.Ciclos.ItemHeight = 16
        Me.Ciclos.Items.AddRange(New Object() {"1", "2"})
        Me.Ciclos.Location = New System.Drawing.Point(76, 133)
        Me.Ciclos.Name = "Ciclos"
        Me.Ciclos.Size = New System.Drawing.Size(139, 20)
        Me.Ciclos.TabIndex = 42
        '
        'lblCiclos
        '
        Me.lblCiclos.AutoSize = True
        Me.lblCiclos.Location = New System.Drawing.Point(20, 137)
        Me.lblCiclos.Name = "lblCiclos"
        Me.lblCiclos.Size = New System.Drawing.Size(50, 16)
        Me.lblCiclos.TabIndex = 41
        Me.lblCiclos.Text = "Ciclos :"
        Me.lblCiclos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(352, 51)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(36, 16)
        Me.lblDNI.TabIndex = 38
        Me.lblDNI.Text = "DNI :"
        Me.lblDNI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(394, 48)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(219, 22)
        Me.txtDNI.TabIndex = 37
        '
        'lblApellido1
        '
        Me.lblApellido1.AutoSize = True
        Me.lblApellido1.Location = New System.Drawing.Point(19, 93)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(108, 16)
        Me.lblApellido1.TabIndex = 36
        Me.lblApellido1.Text = "Primer Apellido : "
        Me.lblApellido1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApellidoUno
        '
        Me.txtApellidoUno.Location = New System.Drawing.Point(138, 94)
        Me.txtApellidoUno.Name = "txtApellidoUno"
        Me.txtApellidoUno.Size = New System.Drawing.Size(219, 22)
        Me.txtApellidoUno.TabIndex = 35
        '
        'lblApellido2
        '
        Me.lblApellido2.AutoSize = True
        Me.lblApellido2.Location = New System.Drawing.Point(374, 93)
        Me.lblApellido2.Name = "lblApellido2"
        Me.lblApellido2.Size = New System.Drawing.Size(121, 16)
        Me.lblApellido2.TabIndex = 34
        Me.lblApellido2.Text = "Segundo Apellido :"
        Me.lblApellido2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApellidoDos
        '
        Me.txtApellidoDos.Location = New System.Drawing.Point(507, 94)
        Me.txtApellidoDos.Name = "txtApellidoDos"
        Me.txtApellidoDos.Size = New System.Drawing.Size(219, 22)
        Me.txtApellidoDos.TabIndex = 33
        '
        'lblCorreo
        '
        Me.lblCorreo.AutoSize = True
        Me.lblCorreo.Location = New System.Drawing.Point(342, 137)
        Me.lblCorreo.Name = "lblCorreo"
        Me.lblCorreo.Size = New System.Drawing.Size(120, 16)
        Me.lblCorreo.TabIndex = 32
        Me.lblCorreo.Text = "Correo electrónico:"
        Me.lblCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCorreoElec
        '
        Me.txtCorreoElec.Location = New System.Drawing.Point(475, 137)
        Me.txtCorreoElec.Name = "txtCorreoElec"
        Me.txtCorreoElec.Size = New System.Drawing.Size(205, 22)
        Me.txtCorreoElec.TabIndex = 31
        '
        'lblBuscarAlumno
        '
        Me.lblBuscarAlumno.AutoSize = True
        Me.lblBuscarAlumno.Location = New System.Drawing.Point(20, 48)
        Me.lblBuscarAlumno.Name = "lblBuscarAlumno"
        Me.lblBuscarAlumno.Size = New System.Drawing.Size(62, 16)
        Me.lblBuscarAlumno.TabIndex = 30
        Me.lblBuscarAlumno.Text = "Nombre :"
        Me.lblBuscarAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(97, 49)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(219, 22)
        Me.txtNombre.TabIndex = 29
        '
        'btnAnadir
        '
        Me.btnAnadir.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAnadir.Location = New System.Drawing.Point(602, 342)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(175, 29)
        Me.btnAnadir.TabIndex = 35
        Me.btnAnadir.Text = "Añadir"
        Me.btnAnadir.UseVisualStyleBackColor = False
        '
        'FrmCrearAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnAnadir)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmCrearAlumno"
        Me.Text = "FrmDatosAlumno"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblHoras As Label
    Friend WithEvents txtHorasTotales As TextBox
    Friend WithEvents Cursos As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Ciclos As ListBox
    Friend WithEvents lblCiclos As Label
    Friend WithEvents lblDNI As Label
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents lblApellido1 As Label
    Friend WithEvents txtApellidoUno As TextBox
    Friend WithEvents lblApellido2 As Label
    Friend WithEvents txtApellidoDos As TextBox
    Friend WithEvents lblCorreo As Label
    Friend WithEvents txtCorreoElec As TextBox
    Friend WithEvents lblBuscarAlumno As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnAnadir As Button
End Class
