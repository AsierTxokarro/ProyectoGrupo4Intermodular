<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCrearCuentaTutor = New System.Windows.Forms.Button()
        Me.btnCrearCuentaAlumn = New System.Windows.Forms.Button()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCorreoElectronico = New System.Windows.Forms.TextBox()
        Me.btnIniciarSesion = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox1.Controls.Add(Me.btnCrearCuentaTutor)
        Me.GroupBox1.Controls.Add(Me.btnCrearCuentaAlumn)
        Me.GroupBox1.Controls.Add(Me.txtContraseña)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCorreoElectronico)
        Me.GroupBox1.Controls.Add(Me.btnIniciarSesion)
        Me.GroupBox1.Location = New System.Drawing.Point(167, 133)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GroupBox1.Size = New System.Drawing.Size(470, 224)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'btnCrearCuentaTutor
        '
        Me.btnCrearCuentaTutor.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCrearCuentaTutor.Location = New System.Drawing.Point(29, 186)
        Me.btnCrearCuentaTutor.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCrearCuentaTutor.Name = "btnCrearCuentaTutor"
        Me.btnCrearCuentaTutor.Size = New System.Drawing.Size(415, 26)
        Me.btnCrearCuentaTutor.TabIndex = 7
        Me.btnCrearCuentaTutor.Text = "Crear cuenta nueva como Tutor"
        Me.btnCrearCuentaTutor.UseVisualStyleBackColor = False
        '
        'btnCrearCuentaAlumn
        '
        Me.btnCrearCuentaAlumn.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCrearCuentaAlumn.Location = New System.Drawing.Point(29, 154)
        Me.btnCrearCuentaAlumn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCrearCuentaAlumn.Name = "btnCrearCuentaAlumn"
        Me.btnCrearCuentaAlumn.Size = New System.Drawing.Size(415, 26)
        Me.btnCrearCuentaAlumn.TabIndex = 6
        Me.btnCrearCuentaAlumn.Text = "Crear cuenta nueva como Alumn@"
        Me.btnCrearCuentaAlumn.UseVisualStyleBackColor = False
        '
        'txtContraseña
        '
        Me.txtContraseña.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtContraseña.Location = New System.Drawing.Point(30, 90)
        Me.txtContraseña.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(414, 22)
        Me.txtContraseña.TabIndex = 5
        Me.txtContraseña.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(26, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(285, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Iniciar sesión en Fichajes para Empresa"
        '
        'txtCorreoElectronico
        '
        Me.txtCorreoElectronico.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtCorreoElectronico.Location = New System.Drawing.Point(30, 58)
        Me.txtCorreoElectronico.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtCorreoElectronico.Name = "txtCorreoElectronico"
        Me.txtCorreoElectronico.Size = New System.Drawing.Size(414, 22)
        Me.txtCorreoElectronico.TabIndex = 2
        Me.txtCorreoElectronico.Text = "Correo Electrónico"
        '
        'btnIniciarSesion
        '
        Me.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnIniciarSesion.Location = New System.Drawing.Point(30, 122)
        Me.btnIniciarSesion.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnIniciarSesion.Name = "btnIniciarSesion"
        Me.btnIniciarSesion.Size = New System.Drawing.Size(415, 26)
        Me.btnIniciarSesion.TabIndex = 1
        Me.btnIniciarSesion.Text = "Iniciar Sesión"
        Me.btnIniciarSesion.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(163, 93)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Log In"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCrearCuentaTutor As Button
    Friend WithEvents btnCrearCuentaAlumn As Button
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCorreoElectronico As TextBox
    Friend WithEvents btnIniciarSesion As Button
    Friend WithEvents Label1 As Label
End Class
