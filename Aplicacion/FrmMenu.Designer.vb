<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
        Me.btnAlumno = New System.Windows.Forms.Button()
        Me.BtnCrearAlumno = New System.Windows.Forms.Button()
        Me.BtnTutor = New System.Windows.Forms.Button()
        Me.BtnCerrarSesion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAlumno
        '
        Me.btnAlumno.Location = New System.Drawing.Point(293, 146)
        Me.btnAlumno.Name = "btnAlumno"
        Me.btnAlumno.Size = New System.Drawing.Size(216, 49)
        Me.btnAlumno.TabIndex = 46
        Me.btnAlumno.Text = "Alumno"
        Me.btnAlumno.UseVisualStyleBackColor = True
        '
        'BtnCrearAlumno
        '
        Me.BtnCrearAlumno.Location = New System.Drawing.Point(29, 146)
        Me.BtnCrearAlumno.Name = "BtnCrearAlumno"
        Me.BtnCrearAlumno.Size = New System.Drawing.Size(216, 49)
        Me.BtnCrearAlumno.TabIndex = 47
        Me.BtnCrearAlumno.Text = "Crear alumno"
        Me.BtnCrearAlumno.UseVisualStyleBackColor = True
        '
        'BtnTutor
        '
        Me.BtnTutor.Location = New System.Drawing.Point(562, 146)
        Me.BtnTutor.Name = "BtnTutor"
        Me.BtnTutor.Size = New System.Drawing.Size(216, 49)
        Me.BtnTutor.TabIndex = 48
        Me.BtnTutor.Text = "Tutor"
        Me.BtnTutor.UseVisualStyleBackColor = True
        '
        'BtnCerrarSesion
        '
        Me.BtnCerrarSesion.Location = New System.Drawing.Point(293, 328)
        Me.BtnCerrarSesion.Name = "BtnCerrarSesion"
        Me.BtnCerrarSesion.Size = New System.Drawing.Size(216, 49)
        Me.BtnCerrarSesion.TabIndex = 49
        Me.BtnCerrarSesion.Text = "Cerrar sesion"
        Me.BtnCerrarSesion.UseVisualStyleBackColor = True
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnCerrarSesion)
        Me.Controls.Add(Me.BtnTutor)
        Me.Controls.Add(Me.BtnCrearAlumno)
        Me.Controls.Add(Me.btnAlumno)
        Me.Name = "FrmMenu"
        Me.Text = "FrmMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAlumno As Button
    Friend WithEvents BtnCrearAlumno As Button
    Friend WithEvents BtnTutor As Button
    Friend WithEvents BtnCerrarSesion As Button
End Class
