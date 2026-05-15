Imports Entidades

Public Class FrmTutor
    Private _alumnos As List(Of Alumno)

    Public Sub New(alumnos As List(Of Alumno))
        InitializeComponent()
        _alumnos = alumnos
    End Sub

    Private Sub FrmTutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstAlumnos.DataSource = _alumnos
    End Sub
End Class