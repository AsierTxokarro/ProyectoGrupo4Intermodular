<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDatosAlumno
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
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lblHoras = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido1 = New System.Windows.Forms.Label()
        Me.lblApellido2 = New System.Windows.Forms.Label()
        Me.lblCiclo = New System.Windows.Forms.Label()
        Me.lblCurso = New System.Windows.Forms.Label()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.txtCiclo = New System.Windows.Forms.TextBox()
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        Me.txtApellido1 = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtHoras = New System.Windows.Forms.TextBox()
        Me.txtCurso = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Location = New System.Drawing.Point(38, 44)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(37, 20)
        Me.lblDNI.TabIndex = 0
        Me.lblDNI.Text = "DNI"
        '
        'lblHoras
        '
        Me.lblHoras.AutoSize = True
        Me.lblHoras.Location = New System.Drawing.Point(38, 96)
        Me.lblHoras.Name = "lblHoras"
        Me.lblHoras.Size = New System.Drawing.Size(108, 20)
        Me.lblHoras.TabIndex = 1
        Me.lblHoras.Text = "Horas Totales"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(38, 155)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(65, 20)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre"
        '
        'lblApellido1
        '
        Me.lblApellido1.AutoSize = True
        Me.lblApellido1.Location = New System.Drawing.Point(38, 218)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(78, 20)
        Me.lblApellido1.TabIndex = 3
        Me.lblApellido1.Text = "Apellido 1"
        '
        'lblApellido2
        '
        Me.lblApellido2.AutoSize = True
        Me.lblApellido2.Location = New System.Drawing.Point(38, 282)
        Me.lblApellido2.Name = "lblApellido2"
        Me.lblApellido2.Size = New System.Drawing.Size(78, 20)
        Me.lblApellido2.TabIndex = 4
        Me.lblApellido2.Text = "Apellido 2"
        '
        'lblCiclo
        '
        Me.lblCiclo.AutoSize = True
        Me.lblCiclo.Location = New System.Drawing.Point(38, 340)
        Me.lblCiclo.Name = "lblCiclo"
        Me.lblCiclo.Size = New System.Drawing.Size(43, 20)
        Me.lblCiclo.TabIndex = 5
        Me.lblCiclo.Text = "Ciclo"
        '
        'lblCurso
        '
        Me.lblCurso.AutoSize = True
        Me.lblCurso.Location = New System.Drawing.Point(38, 392)
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Size = New System.Drawing.Size(51, 20)
        Me.lblCurso.TabIndex = 6
        Me.lblCurso.Text = "Curso"
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(210, 40)
        Me.txtDni.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.ReadOnly = True
        Me.txtDni.Size = New System.Drawing.Size(159, 26)
        Me.txtDni.TabIndex = 7
        '
        'txtCiclo
        '
        Me.txtCiclo.Location = New System.Drawing.Point(210, 340)
        Me.txtCiclo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCiclo.Name = "txtCiclo"
        Me.txtCiclo.ReadOnly = True
        Me.txtCiclo.Size = New System.Drawing.Size(159, 26)
        Me.txtCiclo.TabIndex = 8
        '
        'txtApellido2
        '
        Me.txtApellido2.Location = New System.Drawing.Point(210, 279)
        Me.txtApellido2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.ReadOnly = True
        Me.txtApellido2.Size = New System.Drawing.Size(159, 26)
        Me.txtApellido2.TabIndex = 9
        '
        'txtApellido1
        '
        Me.txtApellido1.Location = New System.Drawing.Point(210, 218)
        Me.txtApellido1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.ReadOnly = True
        Me.txtApellido1.Size = New System.Drawing.Size(159, 26)
        Me.txtApellido1.TabIndex = 10
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(210, 148)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(159, 26)
        Me.txtNombre.TabIndex = 11
        '
        'txtHoras
        '
        Me.txtHoras.Location = New System.Drawing.Point(210, 89)
        Me.txtHoras.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHoras.Name = "txtHoras"
        Me.txtHoras.ReadOnly = True
        Me.txtHoras.Size = New System.Drawing.Size(159, 26)
        Me.txtHoras.TabIndex = 12
        '
        'txtCurso
        '
        Me.txtCurso.Location = New System.Drawing.Point(210, 392)
        Me.txtCurso.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtCurso.Name = "txtCurso"
        Me.txtCurso.ReadOnly = True
        Me.txtCurso.Size = New System.Drawing.Size(159, 26)
        Me.txtCurso.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(569, 414)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 65)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Atras"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmDatosAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 562)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCurso)
        Me.Controls.Add(Me.txtHoras)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtApellido1)
        Me.Controls.Add(Me.txtApellido2)
        Me.Controls.Add(Me.txtCiclo)
        Me.Controls.Add(Me.txtDni)
        Me.Controls.Add(Me.lblCurso)
        Me.Controls.Add(Me.lblCiclo)
        Me.Controls.Add(Me.lblApellido2)
        Me.Controls.Add(Me.lblApellido1)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.lblHoras)
        Me.Controls.Add(Me.lblDNI)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmDatosAlumno"
        Me.Text = "Datos Alumno"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDNI As Label
    Friend WithEvents lblHoras As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellido1 As Label
    Friend WithEvents lblApellido2 As Label
    Friend WithEvents lblCiclo As Label
    Friend WithEvents lblCurso As Label
    Friend WithEvents txtDni As TextBox
    Friend WithEvents txtCiclo As TextBox
    Friend WithEvents txtApellido2 As TextBox
    Friend WithEvents txtApellido1 As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtHoras As TextBox
    Friend WithEvents txtCurso As TextBox
    Friend WithEvents Button1 As Button
End Class
