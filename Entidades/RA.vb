Public Class RA
    Public Property CodigoModulo As Integer
    Public Property Ciclo As Integer
    Public Property AliasCurso As String
    Public Property RA As Integer
    Public Property DescripcionRA As String

    Public Sub New(codigoModulo As Integer, ciclo As Integer, aliasCurso As String, rA As Integer, descripcionRA As String)
        Me.CodigoModulo = codigoModulo
        Me.Ciclo = ciclo
        Me.AliasCurso = aliasCurso
        Me.RA = rA
        Me.DescripcionRA = descripcionRA
    End Sub
End Class
