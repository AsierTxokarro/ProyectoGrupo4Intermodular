<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTutor
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
        Me.lblBuscarAlumno = New System.Windows.Forms.Label()
        Me.txtBuscarAlumno = New System.Windows.Forms.TextBox()
        Me.btnSeleccionarAlumno = New System.Windows.Forms.Button()
        Me.lstAlumnos = New System.Windows.Forms.ListBox()
        Me.lblFiltrar = New System.Windows.Forms.Label()
        Me.lblCurso = New System.Windows.Forms.Label()
        Me.lblCiclo = New System.Windows.Forms.Label()
        Me.cmbCurso = New System.Windows.Forms.ComboBox()
        Me.cmbCiclo = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnCerrarSesion.Location = New System.Drawing.Point(522, 312)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(220, 54)
        Me.btnCerrarSesion.TabIndex = 60
        Me.btnCerrarSesion.Text = "Cerrar Sesion"
        Me.btnCerrarSesion.UseVisualStyleBackColor = False
        '
        'lblBuscarAlumno
        '
        Me.lblBuscarAlumno.Location = New System.Drawing.Point(96, 18)
        Me.lblBuscarAlumno.Name = "lblBuscarAlumno"
        Me.lblBuscarAlumno.Size = New System.Drawing.Size(141, 23)
        Me.lblBuscarAlumno.TabIndex = 58
        Me.lblBuscarAlumno.Text = "🔍 Buscar Alumno :"
        Me.lblBuscarAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBuscarAlumno
        '
        Me.txtBuscarAlumno.Location = New System.Drawing.Point(243, 19)
        Me.txtBuscarAlumno.Name = "txtBuscarAlumno"
        Me.txtBuscarAlumno.Size = New System.Drawing.Size(219, 22)
        Me.txtBuscarAlumno.TabIndex = 57
        '
        'btnSeleccionarAlumno
        '
        Me.btnSeleccionarAlumno.Location = New System.Drawing.Point(96, 395)
        Me.btnSeleccionarAlumno.Name = "btnSeleccionarAlumno"
        Me.btnSeleccionarAlumno.Size = New System.Drawing.Size(366, 37)
        Me.btnSeleccionarAlumno.TabIndex = 56
        Me.btnSeleccionarAlumno.Text = "Seleccionar Alumno"
        Me.btnSeleccionarAlumno.UseVisualStyleBackColor = True
        '
        'lstAlumnos
        '
        Me.lstAlumnos.FormattingEnabled = True
        Me.lstAlumnos.ItemHeight = 16
        Me.lstAlumnos.Location = New System.Drawing.Point(96, 65)
        Me.lstAlumnos.Name = "lstAlumnos"
        Me.lstAlumnos.Size = New System.Drawing.Size(366, 324)
        Me.lstAlumnos.TabIndex = 55
        '
        'lblFiltrar
        '
        Me.lblFiltrar.AutoSize = True
        Me.lblFiltrar.Location = New System.Drawing.Point(567, 81)
        Me.lblFiltrar.Name = "lblFiltrar"
        Me.lblFiltrar.Size = New System.Drawing.Size(95, 16)
        Me.lblFiltrar.TabIndex = 61
        Me.lblFiltrar.Text = "Filtrar Alumnos"
        '
        'lblCurso
        '
        Me.lblCurso.AutoSize = True
        Me.lblCurso.Location = New System.Drawing.Point(503, 128)
        Me.lblCurso.Name = "lblCurso"
        Me.lblCurso.Size = New System.Drawing.Size(42, 16)
        Me.lblCurso.TabIndex = 62
        Me.lblCurso.Text = "Curso"
        '
        'lblCiclo
        '
        Me.lblCiclo.AutoSize = True
        Me.lblCiclo.Location = New System.Drawing.Point(503, 181)
        Me.lblCiclo.Name = "lblCiclo"
        Me.lblCiclo.Size = New System.Drawing.Size(37, 16)
        Me.lblCiclo.TabIndex = 63
        Me.lblCiclo.Text = "Ciclo"
        '
        'cmbCurso
        '
        Me.cmbCurso.FormattingEnabled = True
        Me.cmbCurso.Location = New System.Drawing.Point(570, 120)
        Me.cmbCurso.Name = "cmbCurso"
        Me.cmbCurso.Size = New System.Drawing.Size(141, 24)
        Me.cmbCurso.TabIndex = 64
        '
        'cmbCiclo
        '
        Me.cmbCiclo.FormattingEnabled = True
        Me.cmbCiclo.Location = New System.Drawing.Point(570, 173)
        Me.cmbCiclo.Name = "cmbCiclo"
        Me.cmbCiclo.Size = New System.Drawing.Size(141, 24)
        Me.cmbCiclo.TabIndex = 65
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gold
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(570, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 46)
        Me.Button1.TabIndex = 66
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'FrmTutor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmbCiclo)
        Me.Controls.Add(Me.cmbCurso)
        Me.Controls.Add(Me.lblCiclo)
        Me.Controls.Add(Me.lblCurso)
        Me.Controls.Add(Me.lblFiltrar)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.lblBuscarAlumno)
        Me.Controls.Add(Me.txtBuscarAlumno)
        Me.Controls.Add(Me.btnSeleccionarAlumno)
        Me.Controls.Add(Me.lstAlumnos)
        Me.Name = "FrmTutor"
        Me.Text = "Lista de alumnos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents lblBuscarAlumno As Label
    Friend WithEvents txtBuscarAlumno As TextBox
    Friend WithEvents btnSeleccionarAlumno As Button
    Friend WithEvents lstAlumnos As ListBox
    Friend WithEvents lblFiltrar As Label
    Friend WithEvents lblCurso As Label
    Friend WithEvents lblCiclo As Label
    Friend WithEvents cmbCurso As ComboBox
    Friend WithEvents cmbCiclo As ComboBox
    Friend WithEvents Button1 As Button
End Class
