<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCrearCuentaTutor
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
        Me.btnCrearCuentaNueva = New System.Windows.Forms.Button()
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
        Me.SuspendLayout()
        '
        'btnCrearCuentaNueva
        '
        Me.btnCrearCuentaNueva.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCrearCuentaNueva.Location = New System.Drawing.Point(207, 322)
        Me.btnCrearCuentaNueva.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnCrearCuentaNueva.Name = "btnCrearCuentaNueva"
        Me.btnCrearCuentaNueva.Size = New System.Drawing.Size(415, 26)
        Me.btnCrearCuentaNueva.TabIndex = 41
        Me.btnCrearCuentaNueva.Text = "Crear cuenta nueva"
        Me.btnCrearCuentaNueva.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(395, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 16)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Fecha de nacimiento :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFechaNac
        '
        Me.txtFechaNac.Location = New System.Drawing.Point(548, 140)
        Me.txtFechaNac.Name = "txtFechaNac"
        Me.txtFechaNac.Size = New System.Drawing.Size(206, 22)
        Me.txtFechaNac.TabIndex = 52
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(378, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 16)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "DNI :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(420, 103)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(219, 22)
        Me.txtDNI.TabIndex = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 16)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Primer Apellido : "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApellidoUno
        '
        Me.txtApellidoUno.Location = New System.Drawing.Point(165, 141)
        Me.txtApellidoUno.Name = "txtApellidoUno"
        Me.txtApellidoUno.Size = New System.Drawing.Size(219, 22)
        Me.txtApellidoUno.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 16)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Segundo Apellido :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApellidoDos
        '
        Me.txtApellidoDos.Location = New System.Drawing.Point(179, 181)
        Me.txtApellidoDos.Name = "txtApellidoDos"
        Me.txtApellidoDos.Size = New System.Drawing.Size(219, 22)
        Me.txtApellidoDos.TabIndex = 46
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 221)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Correo electrónico:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCorreoElec
        '
        Me.txtCorreoElec.Location = New System.Drawing.Point(179, 221)
        Me.txtCorreoElec.Name = "txtCorreoElec"
        Me.txtCorreoElec.Size = New System.Drawing.Size(205, 22)
        Me.txtCorreoElec.TabIndex = 44
        '
        'lblBuscarAlumno
        '
        Me.lblBuscarAlumno.AutoSize = True
        Me.lblBuscarAlumno.Location = New System.Drawing.Point(46, 103)
        Me.lblBuscarAlumno.Name = "lblBuscarAlumno"
        Me.lblBuscarAlumno.Size = New System.Drawing.Size(62, 16)
        Me.lblBuscarAlumno.TabIndex = 43
        Me.lblBuscarAlumno.Text = "Nombre :"
        Me.lblBuscarAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(123, 104)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(219, 22)
        Me.txtNombre.TabIndex = 42
        '
        'FrmCrearCuentaTutor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCrearCuentaNueva)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtFechaNac)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDNI)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtApellidoUno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtApellidoDos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCorreoElec)
        Me.Controls.Add(Me.lblBuscarAlumno)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "FrmCrearCuentaTutor"
        Me.Text = "FrmCrearCuenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCrearCuentaNueva As Button
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
