<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAlumno
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtJornadasRealizadas = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnVerMisDatos = New System.Windows.Forms.Button()
        Me.btnPartesSemanales = New System.Windows.Forms.Button()
        Me.btnJornadasRealizadas = New System.Windows.Forms.Button()
        Me.lblNombreAlumno = New System.Windows.Forms.Label()
        Me.txtHorasTrabajadas = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.txtHorasTrabajadas)
        Me.GroupBox2.Controls.Add(Me.txtJornadasRealizadas)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.btnVerMisDatos)
        Me.GroupBox2.Controls.Add(Me.btnPartesSemanales)
        Me.GroupBox2.Controls.Add(Me.btnJornadasRealizadas)
        Me.GroupBox2.Controls.Add(Me.lblNombreAlumno)
        Me.GroupBox2.Location = New System.Drawing.Point(130, 68)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(503, 615)
        Me.GroupBox2.TabIndex = 57
        Me.GroupBox2.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(15, 439)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(368, 66)
        Me.Button2.TabIndex = 60
        Me.Button2.Text = "Sus tareas"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtJornadasRealizadas
        '
        Me.txtJornadasRealizadas.Location = New System.Drawing.Point(390, 142)
        Me.txtJornadasRealizadas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtJornadasRealizadas.Name = "txtJornadasRealizadas"
        Me.txtJornadasRealizadas.ReadOnly = True
        Me.txtJornadasRealizadas.Size = New System.Drawing.Size(107, 26)
        Me.txtJornadasRealizadas.TabIndex = 58
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Button1.Location = New System.Drawing.Point(119, 529)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 68)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "Atras"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnVerMisDatos
        '
        Me.btnVerMisDatos.Location = New System.Drawing.Point(17, 341)
        Me.btnVerMisDatos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnVerMisDatos.Name = "btnVerMisDatos"
        Me.btnVerMisDatos.Size = New System.Drawing.Size(367, 61)
        Me.btnVerMisDatos.TabIndex = 55
        Me.btnVerMisDatos.Text = "Sus Datos"
        Me.btnVerMisDatos.UseVisualStyleBackColor = True
        '
        'btnPartesSemanales
        '
        Me.btnPartesSemanales.Location = New System.Drawing.Point(17, 230)
        Me.btnPartesSemanales.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPartesSemanales.Name = "btnPartesSemanales"
        Me.btnPartesSemanales.Size = New System.Drawing.Size(367, 61)
        Me.btnPartesSemanales.TabIndex = 56
        Me.btnPartesSemanales.Text = "Horas trabajadas"
        Me.btnPartesSemanales.UseVisualStyleBackColor = True
        '
        'btnJornadasRealizadas
        '
        Me.btnJornadasRealizadas.Location = New System.Drawing.Point(17, 125)
        Me.btnJornadasRealizadas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnJornadasRealizadas.Name = "btnJornadasRealizadas"
        Me.btnJornadasRealizadas.Size = New System.Drawing.Size(367, 61)
        Me.btnJornadasRealizadas.TabIndex = 54
        Me.btnJornadasRealizadas.Text = "Jornadas Realizadas "
        Me.btnJornadasRealizadas.UseVisualStyleBackColor = True
        '
        'lblNombreAlumno
        '
        Me.lblNombreAlumno.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblNombreAlumno.Location = New System.Drawing.Point(14, 22)
        Me.lblNombreAlumno.Name = "lblNombreAlumno"
        Me.lblNombreAlumno.Size = New System.Drawing.Size(369, 36)
        Me.lblNombreAlumno.TabIndex = 53
        '
        'txtHorasTrabajadas
        '
        Me.txtHorasTrabajadas.Location = New System.Drawing.Point(390, 246)
        Me.txtHorasTrabajadas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtHorasTrabajadas.Name = "txtHorasTrabajadas"
        Me.txtHorasTrabajadas.ReadOnly = True
        Me.txtHorasTrabajadas.Size = New System.Drawing.Size(107, 26)
        Me.txtHorasTrabajadas.TabIndex = 59
        '
        'FrmAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1155, 735)
        Me.Controls.Add(Me.GroupBox2)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmAlumno"
        Me.Text = "Alumno"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents btnVerMisDatos As Button
    Friend WithEvents btnPartesSemanales As Button
    Friend WithEvents btnJornadasRealizadas As Button
    Friend WithEvents lblNombreAlumno As Label
    Friend WithEvents txtJornadasRealizadas As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents txtHorasTrabajadas As TextBox
End Class
