Public Class Tarea
    Public Property CodigoTarea As Integer
    Public Property DNI As String
    Public Property Fecha As Date
    Public Property Descripcion As String
    Public Property Duracion As Integer

    Public Sub New(codigoTarea As Integer, dNI As String, fecha As Date, descripcion As String, duracion As Integer)
        Me.CodigoTarea = codigoTarea
        Me.DNI = dNI
        Me.Fecha = fecha
        Me.Descripcion = descripcion
        Me.Duracion = duracion
    End Sub
End Class
