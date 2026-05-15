Imports Gestion

Module Module1
    Public gestion As Gestion




    ' Correo → contraseña
    Public TutoresPass As New Dictionary(Of String, String) From {
            {"tutor1@empresa.com", "1234"},
            {"tutor2@empresa.com", "1234"}
        }

    ' Correo → lista de DNIs de sus alumnos
    Public TutoresDNIs As New Dictionary(Of String, List(Of String)) From {
            {"tutor1@empresa.com", New List(Of String) From {"12345678A", "87654321B"}},
            {"tutor2@empresa.com", New List(Of String) From {"11111111C"}}
        }

End Module
