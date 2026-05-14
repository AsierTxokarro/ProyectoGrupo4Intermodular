Public Class TareasCompletas
    Public Property DniAlumno As String
    Public Property CodigoTarea As Integer
    Public Property RA As Integer
    Public Property DescripcionRA As String
    Public Property CodigoModulo As Integer
    Public Property Modulo As String
    Public Property FechaJornada As Date
    Public Property DescripcionTarea As String
    Public Property Duracion As Decimal

    Public Sub New(dniAlumno As String, codigoTarea As Integer, rA As Integer, descripcionRA As String, codigoModulo As Integer, modulo As String, fechaJornada As Date, descripcionTarea As String, duracion As Decimal)
        Me.DniAlumno = dniAlumno
        Me.CodigoTarea = codigoTarea
        Me.RA = rA
        Me.DescripcionRA = descripcionRA
        Me.CodigoModulo = codigoModulo
        Me.Modulo = modulo
        Me.FechaJornada = fechaJornada
        Me.DescripcionTarea = descripcionTarea
        Me.Duracion = duracion
    End Sub
End Class
