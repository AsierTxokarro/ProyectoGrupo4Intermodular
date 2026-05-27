Public Class TareasCompletas
    Public Property DniAlumno As String
    Public Property CodigoTarea As Integer
    Public Property RAs As List(Of Integer)
    Public Property DescripcionesRAs As List(Of String)
    Public Property CodigosModulos As List(Of Integer)
    Public Property Modulos As List(Of String)
    Public Property FechaJornada As Date
    Public Property DescripcionTarea As String
    Public Property Duracion As Decimal

    Public Sub New(dniAlumno As String, codigoTarea As Integer, rAs As List(Of Integer), descripcionesRAs As List(Of String), codigosModulos As List(Of Integer), modulos As List(Of String), fechaJornada As Date, descripcionTarea As String, duracion As Decimal)
        Me.DniAlumno = dniAlumno
        Me.CodigoTarea = codigoTarea
        Me.RAs = rAs
        Me.DescripcionesRAs = descripcionesRAs
        Me.CodigosModulos = codigosModulos
        Me.Modulos = modulos
        Me.FechaJornada = fechaJornada
        Me.DescripcionTarea = descripcionTarea
        Me.Duracion = duracion
    End Sub
End Class
