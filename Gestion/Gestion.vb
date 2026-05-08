Imports System.Data.SqlClient
Imports BuscarServer
Imports Entidades

Public Class Gestion
    Private cadenaConexion As String
    Public Sub New(ByRef errorConexion As String)
        Dim servidor As String = MiServidor.Servidor(errorConexion)
        Dim NombreDeBaseDeDatos = "Grupo4"
        cadenaConexion = $"Data Source={servidor};Initial Catalog={NombreDeBaseDeDatos};Integrated Security=True"
    End Sub

    Public Function AñadirAlumno(dni As String, horasTotales As Integer, nombre As String, apellido1 As String, apellido2 As String, ciclo As Integer, aliasCurso As String, realizaPracticas As Boolean, motivoNoPracticas As String) As String

        Dim mensaje As String = ""

        If ComprobarNoAlumnoRepetido(dni, mensaje) Then
            If Not String.IsNullOrWhiteSpace(mensaje) Then
                Return mensaje
            Else
                Return "Ya hay un alumno con ese DNI"
            End If
        End If

        Dim conexion As New SqlConnection(cadenaConexion)

        Dim lineaComando As String =
        "INSERT INTO ALUMNOS (DNI, HORASTOTALES, NOMBRE, [APELLIDO 1], [APELLIDO 2], CICLO, ALIAS, REALIZA_PRACTICAS, MOTIVO_NO_PRACTICAS) 
         VALUES (@dni, @horasTotales, @nombre, @apellido1, @apellido2, @ciclo, @alias, @realizaPracticas, @motivo)"

        Dim crear As New SqlCommand(lineaComando, conexion)

        crear.Parameters.AddWithValue("@dni", dni)
        crear.Parameters.AddWithValue("@horasTotales", horasTotales)
        crear.Parameters.AddWithValue("@nombre", nombre)
        crear.Parameters.AddWithValue("@apellido1", apellido1)
        crear.Parameters.AddWithValue("@apellido2", apellido2)
        crear.Parameters.AddWithValue("@ciclo", ciclo)
        crear.Parameters.AddWithValue("@alias", aliasCurso)
        crear.Parameters.AddWithValue("@realizaPracticas", realizaPracticas)

        If String.IsNullOrWhiteSpace(motivoNoPracticas) Then
            crear.Parameters.AddWithValue("@motivo", DBNull.Value)
        Else
            crear.Parameters.AddWithValue("@motivo", motivoNoPracticas)
        End If

        Return "Insertado"
    End Function
    Public Function ComprobarNoAlumnoRepetido(dni As String, ByRef mensaje As String) As Boolean
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim dniAPasar As String = dni
        Dim lineaComando As String = "SELECT DNI FROM ALUMNOS WHERE DNI = @dni"
        Dim personasConEseDNI As SqlDataReader

        Dim comprobar As New SqlCommand(lineaComando, conexion)

        comprobar.Parameters.AddWithValue("@dni", dniAPasar)

        Try
            conexion.Open()
            personasConEseDNI = comprobar.ExecuteReader()
            Return personasConEseDNI.HasRows
        Catch ex As Exception
            mensaje = "Error del comprobar alumno repetido: " & ex.Message
        Finally
            conexion.Close()
        End Try

        Return True

    End Function

    Public Function MostrarHorasDeAlumnosPorCicloYAliasDelCurso(ciclo As Integer, curso As String) As List(Of Alumno)
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim cicloAPasar As Integer = ciclo
        Dim cursoAPasar As String = curso
        Dim sql As String = "SELECT NOMBRE, HORASTOTALES FROM ALUMNOS WHERE CICLO = @CICLO AND ALIAS = @ALIAS"
        Dim cmdHorasPorCicloYAlias As New SqlCommand(sql, conexion)
        cmdHorasPorCicloYAlias.Parameters.AddWithValue("@CICLO", ciclo)
        cmdHorasPorCicloYAlias.Parameters.AddWithValue("@ALIAS", curso)
    End Function


    Public Function AñadirJornada(fecha As Date, dni As String, duracion As Integer) As String
        Dim mensaje As String = ""
        If ComprobarJornadaRepetida(fecha, dni, mensaje) = True Then
            If String.IsNullOrWhiteSpace(mensaje) = False Then
                Return mensaje
            Else
                Return "Ya hay una jornada en ese dia con ese DNI"
            End If
        End If

        Dim conexion As New SqlConnection(cadenaConexion)
        Dim fechaAPasar As Date = fecha
        Dim dniAPasar As String = dni
        Dim duracionAPasar As Integer = duracion
        Dim lineaComando As String = "INSERT INTO JORNADAS(FECHA, DNI, DURACION) VALUES (@fecha, @dni, @duracion)"
        Dim crear As New SqlCommand(lineaComando, conexion)

        crear.Parameters.AddWithValue("@fecha", fechaAPasar)
        crear.Parameters.AddWithValue("@dni", dniAPasar)
        crear.Parameters.AddWithValue("@duracion", duracionAPasar)

        Try
            conexion.Open()
            crear.ExecuteNonQuery()
        Catch ex As Exception
            Return "Error del añadir jornada: " & ex.Message
        Finally
            conexion.Close()
        End Try

        Return "Insertado"
    End Function

    Public Function ComprobarJornadaRepetida(fecha As Date, dni As String, ByRef mensaje As String) As Boolean
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim fechaAPasar As Date = fecha
        Dim dniAPasar As String = dni
        Dim lineaComando As String = "SELECT FECHA, DNI FROM JORNADAS WHERE FECHA = @fecha AND DNI = @dni"
        Dim comprobar As New SqlCommand(lineaComando, conexion)
        Dim tareasConEseDNIYFecha As SqlDataReader

        comprobar.Parameters.AddWithValue("@fecha", fechaAPasar)
        comprobar.Parameters.AddWithValue("@dni", dniAPasar)

        Try
            conexion.Open()
            tareasConEseDNIYFecha = comprobar.ExecuteReader()
            Return tareasConEseDNIYFecha.HasRows
        Catch ex As Exception
            mensaje = "Error del comprobar jornada repetida: " & ex.Message
        Finally
            conexion.Close()
        End Try

        Return True
    End Function

    Public Function MostrarHorasDeAlumno(nombreAlumno As String) As String
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim alumnoAPasar As String = nombreAlumno
        Dim lineaComando As String = "SELECT ALUMNOS.HORASTOTALES FROM ALUMNOS WHERE NOMBRE = @nombre"
        Dim buscarAlumno As New SqlCommand(lineaComando, conexion)

        buscarAlumno.Parameters.AddWithValue("@nombre", alumnoAPasar)

        Try
            conexion.Open()
            Dim resultado As Integer = buscarAlumno.ExecuteScalar()
            Return resultado.ToString
        Catch ex As Exception
            Return "Error al mirar las horas de un alumno: " & ex.Message
        Finally
            conexion.Close()
        End Try

    End Function
    Public Function EliminarAlumno(dni As String) As String
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim dniAPasar As String = dni
        Dim lineaComando As String = "DELETE ALUMNOS.* FROM ALUMNOS WHERE DNI = @dni"
        Dim eliminar As New SqlCommand(lineaComando, conexion)

        eliminar.Parameters.AddWithValue("@dni", dniAPasar)

        Try
            conexion.Open()
            eliminar.ExecuteNonQuery()
        Catch ex As Exception
            Return "Error al intentar borrar un alumno: " & ex.Message
        Finally
            conexion.Close()
        End Try

        Return "Alumno eliminado"
    End Function


    ''Ahora esto es sobre añadir la tarea
    Public Function AñadirTarea(codigo As Integer, fecha As Date, dni As String, descripcion As String, duracion As Decimal) As String
        ''Chequear que no se pase de horas
        If (duracion > 8) Then
            Return "¡No puedes realizar mas de 8 horas!"
        End If

        Dim conexion As New SqlConnection(cadenaConexion)
        Dim codigoAPasar = codigo
        Dim fechaAPasar = fecha
        Dim dniAPasar = dni
        Dim descripcionAPasar = descripcion
        Dim duracionAPasar = duracion


        Dim lineaComando As String = "INSERT INTO TAREASREALIZADAS(CODIGOTAREA, FECHAJORNADA, DNI, DESCRIPCION, DURACION) VALUES (@codTarea, @fecha, @dni, @descripcion, @duracion)"
        Dim crear As New SqlCommand(lineaComando, conexion)

        crear.Parameters.AddWithValue("@codTarea", codigoAPasar)
        crear.Parameters.AddWithValue("@fecha", fechaAPasar)
        crear.Parameters.AddWithValue("@dni", dniAPasar)
        crear.Parameters.AddWithValue("@descripcion", descripcionAPasar)
        crear.Parameters.AddWithValue("@duracion", duracionAPasar)



        Try
            conexion.Open()
            crear.ExecuteNonQuery()
        Catch ex As Exception
            Return "Error del añadir tarea: " & ex.Message
        Finally
            conexion.Close()
        End Try

        Return "Tarea insertada"
    End Function

End Class
