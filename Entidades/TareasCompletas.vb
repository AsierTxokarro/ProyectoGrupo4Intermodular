Public Class TareasCompletas
    Public Property CodigoTarea As Integer
    Public Property DescripcionRA
    Public Property Modulo As String
    Public Property FechaJornada As Date
    Public Property DescripcionTarea As String
    Public Property Duracion As Decimal

    Public Sub New(codigoTarea As Integer, descripcionRA As Object, modulo As String, fechaJornada As Date, descripcionTarea As String, duracion As Decimal)
        Me.CodigoTarea = codigoTarea
        Me.DescripcionRA = descripcionRA
        Me.Modulo = modulo
        Me.FechaJornada = fechaJornada
        Me.DescripcionTarea = descripcionTarea
        Me.Duracion = duracion
    End Sub
End Class
