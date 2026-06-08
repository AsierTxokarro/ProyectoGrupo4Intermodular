<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAnadirTarea
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
        Me.grbControlesNoDinamicos = New System.Windows.Forms.GroupBox()
        Me.txtDuracion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grbControlesDinamicos = New System.Windows.Forms.GroupBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnAnyadirModulo = New System.Windows.Forms.Button()
        Me.btnQuitarModulo = New System.Windows.Forms.Button()
        Me.grbControlesNoDinamicos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbControlesNoDinamicos
        '
        Me.grbControlesNoDinamicos.Controls.Add(Me.txtDuracion)
        Me.grbControlesNoDinamicos.Controls.Add(Me.Label3)
        Me.grbControlesNoDinamicos.Controls.Add(Me.txtDescripcion)
        Me.grbControlesNoDinamicos.Controls.Add(Me.Label2)
        Me.grbControlesNoDinamicos.Controls.Add(Me.MonthCalendar1)
        Me.grbControlesNoDinamicos.Controls.Add(Me.Label1)
        Me.grbControlesNoDinamicos.Location = New System.Drawing.Point(100, 22)
        Me.grbControlesNoDinamicos.Name = "grbControlesNoDinamicos"
        Me.grbControlesNoDinamicos.Size = New System.Drawing.Size(1178, 282)
        Me.grbControlesNoDinamicos.TabIndex = 1
        Me.grbControlesNoDinamicos.TabStop = False
        '
        'txtDuracion
        '
        Me.txtDuracion.Location = New System.Drawing.Point(997, 73)
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(137, 26)
        Me.txtDuracion.TabIndex = 71
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(914, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Duración:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(559, 73)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(280, 26)
        Me.txtDescripcion.TabIndex = 69
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(457, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Descripción:"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(153, 17)
        Me.MonthCalendar1.MaxSelectionCount = 1
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Jornada:"
        '
        'grbControlesDinamicos
        '
        Me.grbControlesDinamicos.Location = New System.Drawing.Point(100, 324)
        Me.grbControlesDinamicos.Name = "grbControlesDinamicos"
        Me.grbControlesDinamicos.Size = New System.Drawing.Size(1178, 673)
        Me.grbControlesDinamicos.TabIndex = 2
        Me.grbControlesDinamicos.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(1299, 879)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(224, 43)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(1299, 795)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(223, 43)
        Me.btnConfirmar.TabIndex = 3
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btnAnyadirModulo
        '
        Me.btnAnyadirModulo.Location = New System.Drawing.Point(1299, 392)
        Me.btnAnyadirModulo.Name = "btnAnyadirModulo"
        Me.btnAnyadirModulo.Size = New System.Drawing.Size(167, 41)
        Me.btnAnyadirModulo.TabIndex = 5
        Me.btnAnyadirModulo.Text = "Añadir Módulo"
        Me.btnAnyadirModulo.UseVisualStyleBackColor = True
        '
        'btnQuitarModulo
        '
        Me.btnQuitarModulo.Location = New System.Drawing.Point(1299, 477)
        Me.btnQuitarModulo.Name = "btnQuitarModulo"
        Me.btnQuitarModulo.Size = New System.Drawing.Size(167, 41)
        Me.btnQuitarModulo.TabIndex = 6
        Me.btnQuitarModulo.Text = "Quitar Modulo"
        Me.btnQuitarModulo.UseVisualStyleBackColor = True
        '
        'FrmAnadirTarea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1487, 1009)
        Me.Controls.Add(Me.btnQuitarModulo)
        Me.Controls.Add(Me.btnAnyadirModulo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.grbControlesDinamicos)
        Me.Controls.Add(Me.grbControlesNoDinamicos)
        Me.Name = "FrmAnadirTarea"
        Me.Text = "Añadir Tarea"
        Me.grbControlesNoDinamicos.ResumeLayout(False)
        Me.grbControlesNoDinamicos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbControlesNoDinamicos As GroupBox
    Friend WithEvents txtDuracion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label1 As Label
    Friend WithEvents grbControlesDinamicos As GroupBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnConfirmar As Button
    Friend WithEvents btnAnyadirModulo As Button
    Friend WithEvents btnQuitarModulo As Button
End Class
