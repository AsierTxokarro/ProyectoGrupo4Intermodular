Public Class Alumno
    Public Property DNI As String
    Public Property Nombre As String
    Public Property Apellido1 As String
    Public Property Apellido2 As String
    Public Property HorasTotales As Integer
    Public Property Ciclo As Integer
    Public Property AliasCurso As String
    Public Sub New()
    End Sub
    Public Sub New(dNI As String, nombre As String, apellido1 As String, apellido2 As String, horasTotales As Integer, ciclo As Integer, aliasCurso As String)
        Me.DNI = dNI
        Me.Nombre = nombre
        Me.Apellido1 = apellido1
        Me.Apellido2 = apellido2
        Me.HorasTotales = horasTotales
        Me.Ciclo = ciclo
        Me.AliasCurso = aliasCurso
    End Sub
End Class
