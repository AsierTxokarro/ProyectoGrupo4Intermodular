<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVerAlumno
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
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnEliminarAlumno = New System.Windows.Forms.Button()
        Me.btnVerDatosAlumno = New System.Windows.Forms.Button()
        Me.btnFichajesRealizados = New System.Windows.Forms.Button()
        Me.lblAlumno = New System.Windows.Forms.Label()
        Me.lblNombreAlumno = New System.Windows.Forms.Label()
        Me.lstTareas = New System.Windows.Forms.ListBox()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()

        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()

        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnCerrarSesion.Location = New System.Drawing.Point(152, 334)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(244, 33)
        Me.btnCerrarSesion.TabIndex = 58
        Me.btnCerrarSesion.Text = "Cerrar Sesion"
        Me.btnCerrarSesion.UseVisualStyleBackColor = False

        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnEliminarAlumno)
        Me.GroupBox2.Controls.Add(Me.btnVerDatosAlumno)
        Me.GroupBox2.Controls.Add(Me.btnFichajesRealizados)
        Me.GroupBox2.Controls.Add(Me.lblAlumno)
        Me.GroupBox2.Controls.Add(Me.lblNombreAlumno)
        Me.GroupBox2.Location = New System.Drawing.Point(171, 39)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(244, 286)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False

        '
        'btnEliminarAlumno
        '
        Me.btnEliminarAlumno.Location = New System.Drawing.Point(9, 208)
        Me.btnEliminarAlumno.Name = "btnEliminarAlumno"
        Me.btnEliminarAlumno.Size = New System.Drawing.Size(243, 61)
        Me.btnEliminarAlumno.TabIndex = 51
        Me.btnEliminarAlumno.Text = "Eliminar Alumno"
        Me.btnEliminarAlumno.UseVisualStyleBackColor = True

        '
        'btnVerDatosAlumno
        '
        Me.btnVerDatosAlumno.Location = New System.Drawing.Point(9, 137)
        Me.btnVerDatosAlumno.Name = "btnVerDatosAlumno"
        Me.btnVerDatosAlumno.Size = New System.Drawing.Size(243, 61)
        Me.btnVerDatosAlumno.TabIndex = 47
        Me.btnVerDatosAlumno.Text = "Datos del Alumno"
        Me.btnVerDatosAlumno.UseVisualStyleBackColor = True

        '
        'btnFichajesRealizados
        '
        Me.btnFichajesRealizados.Location = New System.Drawing.Point(7, 86)
        Me.btnFichajesRealizados.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnFichajesRealizados.Name = "btnFichajesRealizados"
        Me.btnFichajesRealizados.Size = New System.Drawing.Size(243, 61)
        Me.btnFichajesRealizados.TabIndex = 45
        Me.btnFichajesRealizados.Text = "Tareas"
        Me.btnFichajesRealizados.UseVisualStyleBackColor = True

        '
        'lblAlumno
        '
        Me.lblAlumno.AutoSize = True
        Me.lblAlumno.Location = New System.Drawing.Point(7, 31)
        Me.lblAlumno.Name = "lblAlumno"
        Me.lblAlumno.Size = New System.Drawing.Size(74, 20)
        Me.lblAlumno.TabIndex = 43
        Me.lblAlumno.Text = "Alumn@:"

        '
        'lblNombreAlumno
        '
        Me.lblNombreAlumno.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblNombreAlumno.Location = New System.Drawing.Point(82, 22)
        Me.lblNombreAlumno.Name = "lblNombreAlumno"
        Me.lblNombreAlumno.Size = New System.Drawing.Size(168, 36)
        Me.lblNombreAlumno.TabIndex = 44

        '
        'lstTareas
        '
        Me.lstTareas.FormattingEnabled = True
        Me.lstTareas.ItemHeight = 16
        Me.lstTareas.Location = New System.Drawing.Point(515, 43)
        Me.lstTareas.Name = "lstTareas"
        Me.lstTareas.Size = New System.Drawing.Size(336, 532)
        Me.lstTareas.TabIndex = 59

        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(161, 379)
        Me.MonthCalendar1.MaxSelectionCount = 1
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 62

        '
        'frmVerAlumno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(995, 625)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.lstTareas)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmVerAlumno"
        Me.Text = "FrmTutor2"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCerrarSesion As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnEliminarAlumno As Button
    Friend WithEvents btnVerDatosAlumno As Button
    Friend WithEvents btnFichajesRealizados As Button
    Friend WithEvents lblAlumno As Label
    Friend WithEvents lblNombreAlumno As Label
    Friend WithEvents lstTareas As ListBox
    Friend WithEvents MonthCalendar1 As MonthCalendar

End Class