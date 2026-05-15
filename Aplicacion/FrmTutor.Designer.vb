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
        Me.btnVerCalendario = New System.Windows.Forms.Button()
        Me.lblBuscarAlumno = New System.Windows.Forms.Label()
        Me.txtBuscarAlumno = New System.Windows.Forms.TextBox()
        Me.btnSeleccionarAlumno = New System.Windows.Forms.Button()
        Me.lstAlumnos = New System.Windows.Forms.ListBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.SuspendLayout()
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnCerrarSesion.Location = New System.Drawing.Point(485, 310)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(220, 54)
        Me.btnCerrarSesion.TabIndex = 60
        Me.btnCerrarSesion.Text = "Cerrar Sesion"
        Me.btnCerrarSesion.UseVisualStyleBackColor = False
        '
        'btnVerCalendario
        '
        Me.btnVerCalendario.Location = New System.Drawing.Point(485, 18)
        Me.btnVerCalendario.Name = "btnVerCalendario"
        Me.btnVerCalendario.Size = New System.Drawing.Size(220, 49)
        Me.btnVerCalendario.TabIndex = 59
        Me.btnVerCalendario.Text = "Ver Caledario"
        Me.btnVerCalendario.UseVisualStyleBackColor = True
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
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(485, 91)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 54
        '
        'FrmTutor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.btnVerCalendario)
        Me.Controls.Add(Me.lblBuscarAlumno)
        Me.Controls.Add(Me.txtBuscarAlumno)
        Me.Controls.Add(Me.btnSeleccionarAlumno)
        Me.Controls.Add(Me.lstAlumnos)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Name = "FrmTutor"
        Me.Text = "FrmTutor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents btnVerCalendario As Button
    Friend WithEvents lblBuscarAlumno As Label
    Friend WithEvents txtBuscarAlumno As TextBox
    Friend WithEvents btnSeleccionarAlumno As Button
    Friend WithEvents lstAlumnos As ListBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
End Class
