<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarTarea
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
        Me.lblFechaJornada = New System.Windows.Forms.Label()
        Me.txtDuracion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grbControlesDinamicos = New System.Windows.Forms.GroupBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.grbControlesNoDinamicos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbControlesNoDinamicos
        '
        Me.grbControlesNoDinamicos.Controls.Add(Me.lblFechaJornada)
        Me.grbControlesNoDinamicos.Controls.Add(Me.txtDuracion)
        Me.grbControlesNoDinamicos.Controls.Add(Me.Label3)
        Me.grbControlesNoDinamicos.Controls.Add(Me.txtDescripcion)
        Me.grbControlesNoDinamicos.Controls.Add(Me.Label2)
        Me.grbControlesNoDinamicos.Controls.Add(Me.Label1)
        Me.grbControlesNoDinamicos.Location = New System.Drawing.Point(72, 12)
        Me.grbControlesNoDinamicos.Name = "grbControlesNoDinamicos"
        Me.grbControlesNoDinamicos.Size = New System.Drawing.Size(1178, 131)
        Me.grbControlesNoDinamicos.TabIndex = 0
        Me.grbControlesNoDinamicos.TabStop = False
        '
        'lblFechaJornada
        '
        Me.lblFechaJornada.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblFechaJornada.Location = New System.Drawing.Point(155, 59)
        Me.lblFechaJornada.Name = "lblFechaJornada"
        Me.lblFechaJornada.Size = New System.Drawing.Size(162, 25)
        Me.lblFechaJornada.TabIndex = 72
        '
        'txtDuracion
        '
        Me.txtDuracion.Location = New System.Drawing.Point(997, 59)
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Size = New System.Drawing.Size(137, 26)
        Me.txtDuracion.TabIndex = 71
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(914, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Duración:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(559, 59)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(280, 26)
        Me.txtDescripcion.TabIndex = 69
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(457, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Jornada:"
        '
        'grbControlesDinamicos
        '
        Me.grbControlesDinamicos.Location = New System.Drawing.Point(72, 159)
        Me.grbControlesDinamicos.Name = "grbControlesDinamicos"
        Me.grbControlesDinamicos.Size = New System.Drawing.Size(1178, 534)
        Me.grbControlesDinamicos.TabIndex = 1
        Me.grbControlesDinamicos.TabStop = False
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(196, 699)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(223, 43)
        Me.btnModificar.TabIndex = 0
        Me.btnModificar.Text = "Confirmar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(858, 699)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(224, 43)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'FrmModificarTarea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1327, 754)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.grbControlesDinamicos)
        Me.Controls.Add(Me.grbControlesNoDinamicos)
        Me.Name = "FrmModificarTarea"
        Me.Text = "FrmModificarTarea"
        Me.grbControlesNoDinamicos.ResumeLayout(False)
        Me.grbControlesNoDinamicos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbControlesNoDinamicos As GroupBox
    Friend WithEvents grbControlesDinamicos As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDuracion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents lblFechaJornada As Label
End Class
