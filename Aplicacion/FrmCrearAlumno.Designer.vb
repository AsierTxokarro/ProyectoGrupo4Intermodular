<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCrearAlumno
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHorasTotales = New System.Windows.Forms.TextBox()
        Me.Cursos = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Ciclos = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFechaNac = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtApellidoUno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtApellidoDos = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCorreoElec = New System.Windows.Forms.TextBox()
        Me.lblBuscarAlumno = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnSalir.Location = New System.Drawing.Point(24, 342)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(163, 23)
        Me.btnSalir.TabIndex = 34
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtHorasTotales)
        Me.GroupBox1.Controls.Add(Me.Cursos)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Ciclos)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtFechaNac)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtDNI)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtApellidoUno)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtApellidoDos)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCorreoElec)
        Me.GroupBox1.Controls.Add(Me.lblBuscarAlumno)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(753, 250)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 16)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Horas Totales :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtHorasTotales
        '
        Me.txtHorasTotales.Location = New System.Drawing.Point(121, 198)
        Me.txtHorasTotales.Name = "txtHorasTotales"
        Me.txtHorasTotales.Size = New System.Drawing.Size(94, 22)
        Me.txtHorasTotales.TabIndex = 45
        '
        'Cursos
        '
        Me.Cursos.FormattingEnabled = True
        Me.Cursos.ItemHeight = 16
        Me.Cursos.Location = New System.Drawing.Point(440, 159)
        Me.Cursos.Name = "Cursos"
        Me.Cursos.Size = New System.Drawing.Size(139, 20)
        Me.Cursos.TabIndex = 44
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(384, 163)
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
        Me.Ciclos.Location = New System.Drawing.Point(440, 118)
        Me.Ciclos.Name = "Ciclos"
        Me.Ciclos.Size = New System.Drawing.Size(139, 20)
        Me.Ciclos.TabIndex = 42
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(384, 122)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 16)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Ciclos :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(362, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 16)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Fecha de nacimiento :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFechaNac
        '
        Me.txtFechaNac.Location = New System.Drawing.Point(515, 78)
        Me.txtFechaNac.Name = "txtFechaNac"
        Me.txtFechaNac.Size = New System.Drawing.Size(206, 22)
        Me.txtFechaNac.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(345, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 16)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "DNI :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(387, 41)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(219, 22)
        Me.txtDNI.TabIndex = 37
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 16)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Primer Apellido : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApellidoUno
        '
        Me.txtApellidoUno.Location = New System.Drawing.Point(132, 79)
        Me.txtApellidoUno.Name = "txtApellidoUno"
        Me.txtApellidoUno.Size = New System.Drawing.Size(219, 22)
        Me.txtApellidoUno.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 16)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Segundo Apellido :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApellidoDos
        '
        Me.txtApellidoDos.Location = New System.Drawing.Point(146, 119)
        Me.txtApellidoDos.Name = "txtApellidoDos"
        Me.txtApellidoDos.Size = New System.Drawing.Size(219, 22)
        Me.txtApellidoDos.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Correo electrónico:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCorreoElec
        '
        Me.txtCorreoElec.Location = New System.Drawing.Point(146, 159)
        Me.txtCorreoElec.Name = "txtCorreoElec"
        Me.txtCorreoElec.Size = New System.Drawing.Size(205, 22)
        Me.txtCorreoElec.TabIndex = 31
        '
        'lblBuscarAlumno
        '
        Me.lblBuscarAlumno.AutoSize = True
        Me.lblBuscarAlumno.Location = New System.Drawing.Point(13, 41)
        Me.lblBuscarAlumno.Name = "lblBuscarAlumno"
        Me.lblBuscarAlumno.Size = New System.Drawing.Size(62, 16)
        Me.lblBuscarAlumno.TabIndex = 30
        Me.lblBuscarAlumno.Text = "Nombre :"
        Me.lblBuscarAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(90, 42)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(219, 22)
        Me.txtNombre.TabIndex = 29
        '
        'FrmCrearAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
    Friend WithEvents Label4 As Label
    Friend WithEvents txtHorasTotales As TextBox
    Friend WithEvents Cursos As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Ciclos As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFechaNac As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtDNI As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtApellidoUno As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtApellidoDos As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCorreoElec As TextBox
    Friend WithEvents lblBuscarAlumno As Label
    Friend WithEvents txtNombre As TextBox
End Class
