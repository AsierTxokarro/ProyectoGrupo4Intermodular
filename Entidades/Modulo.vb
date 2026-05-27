Public Class Modulo
    Public Property CodigoModulo As Integer
    Public Property Ciclo As Integer
    Public Property AliasCurso As String
    Public Property NombreModulo As String

    Public Sub New(codigoModulo As Integer, ciclo As Integer, aliasCurso As String, nombreModulo As String)
        Me.CodigoModulo = codigoModulo
        Me.Ciclo = ciclo
        Me.AliasCurso = aliasCurso
        Me.NombreModulo = nombreModulo
    End Sub
End Class
