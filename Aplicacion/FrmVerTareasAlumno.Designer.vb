<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVerTareasAlumno
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
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.lstTareas = New System.Windows.Forms.ListBox()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnFichajesRealizados = New System.Windows.Forms.Button()
        Me.lblAlumno = New System.Windows.Forms.Label()
        Me.lblNombreAlumno = New System.Windows.Forms.Label()
        Me.btnEliminarTarea = New System.Windows.Forms.Button()
        Me.btnModificarTarea = New System.Windows.Forms.Button()
        Me.btnAnadirTarea = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(89, 361)
        Me.MonthCalendar1.MaxSelectionCount = 1
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 66
        '
        'lstTareas
        '
        Me.lstTareas.FormattingEnabled = True
        Me.lstTareas.ItemHeight = 20
        Me.lstTareas.Location = New System.Drawing.Point(473, 41)
        Me.lstTareas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstTareas.Name = "lstTareas"
        Me.lstTareas.Size = New System.Drawing.Size(632, 524)
        Me.lstTareas.TabIndex = 65
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnCerrarSesion.Location = New System.Drawing.Point(106, 286)
        Me.btnCerrarSesion.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(231, 55)
        Me.btnCerrarSesion.TabIndex = 64
        Me.btnCerrarSesion.Text = "Cerrar Sesión"
        Me.btnCerrarSesion.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnFichajesRealizados)
        Me.GroupBox2.Controls.Add(Me.lblAlumno)
        Me.GroupBox2.Controls.Add(Me.lblNombreAlumno)
        Me.GroupBox2.Location = New System.Drawing.Point(74, 59)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(299, 209)
        Me.GroupBox2.TabIndex = 63
        Me.GroupBox2.TabStop = False
        '
        'btnFichajesRealizados
        '
        Me.btnFichajesRealizados.Location = New System.Drawing.Point(32, 114)
        Me.btnFichajesRealizados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnFichajesRealizados.Name = "btnFichajesRealizados"
        Me.btnFichajesRealizados.Size = New System.Drawing.Size(243, 61)
        Me.btnFichajesRealizados.TabIndex = 45
        Me.btnFichajesRealizados.Text = "Ver Tareas"
        Me.btnFichajesRealizados.UseVisualStyleBackColor = True
        '
        'lblAlumno
        '
        Me.lblAlumno.AutoSize = True
        Me.lblAlumno.Location = New System.Drawing.Point(32, 42)
        Me.lblAlumno.Name = "lblAlumno"
        Me.lblAlumno.Size = New System.Drawing.Size(74, 20)
        Me.lblAlumno.TabIndex = 43
        Me.lblAlumno.Text = "Alumn@:"
        '
        'lblNombreAlumno
        '
        Me.lblNombreAlumno.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblNombreAlumno.Location = New System.Drawing.Point(107, 33)
        Me.lblNombreAlumno.Name = "lblNombreAlumno"
        Me.lblNombreAlumno.Size = New System.Drawing.Size(168, 36)
        Me.lblNombreAlumno.TabIndex = 44
        '
        'btnEliminarTarea
        '
        Me.btnEliminarTarea.Location = New System.Drawing.Point(509, 571)
        Me.btnEliminarTarea.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnEliminarTarea.Name = "btnEliminarTarea"
        Me.btnEliminarTarea.Size = New System.Drawing.Size(169, 49)
        Me.btnEliminarTarea.TabIndex = 46
        Me.btnEliminarTarea.Text = "Eliminar Tarea"
        Me.btnEliminarTarea.UseVisualStyleBackColor = True
        '
        'btnModificarTarea
        '
        Me.btnModificarTarea.Location = New System.Drawing.Point(712, 571)
        Me.btnModificarTarea.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnModificarTarea.Name = "btnModificarTarea"
        Me.btnModificarTarea.Size = New System.Drawing.Size(158, 49)
        Me.btnModificarTarea.TabIndex = 67
        Me.btnModificarTarea.Text = "Modificar Tarea"
        Me.btnModificarTarea.UseVisualStyleBackColor = True
        '
        'btnAnadirTarea
        '
        Me.btnAnadirTarea.Location = New System.Drawing.Point(900, 571)
        Me.btnAnadirTarea.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAnadirTarea.Name = "btnAnadirTarea"
        Me.btnAnadirTarea.Size = New System.Drawing.Size(166, 49)
        Me.btnAnadirTarea.TabIndex = 68
        Me.btnAnadirTarea.Text = "Añadir Tarea"
        Me.btnAnadirTarea.UseVisualStyleBackColor = True
        '
        'FrmVerTareasAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1200, 633)
        Me.Controls.Add(Me.btnAnadirTarea)
        Me.Controls.Add(Me.btnModificarTarea)
        Me.Controls.Add(Me.btnEliminarTarea)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.lstTareas)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FrmVerTareasAlumno"
        Me.Text = "Form1"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents lstTareas As ListBox
    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnFichajesRealizados As Button
    Friend WithEvents lblAlumno As Label
    Friend WithEvents lblNombreAlumno As Label
    Friend WithEvents btnEliminarTarea As Button
    Friend WithEvents btnModificarTarea As Button
    Friend WithEvents btnAnadirTarea As Button
End Class
