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

        Dim mensajeError As String = ""

        If Not Existe(dni, mensajeError) Then
            If Not String.IsNullOrWhiteSpace(mensajeError) Then
                Return mensajeError
            Else
                Return $"Ya hay un alumno con ese DNI {dni}"
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

        crear.ExecuteNonQuery()

        If String.IsNullOrWhiteSpace(motivoNoPracticas) Then
            crear.Parameters.AddWithValue("@motivo", DBNull.Value)
        Else
            crear.Parameters.AddWithValue("@motivo", motivoNoPracticas)
        End If

        Return "Insertado"
    End Function
    Public Function Existe(dni As String, ByRef mensaje As String) As Boolean
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
            Return True
        Finally
            conexion.Close()
        End Try

        Return False

    End Function


    Public Function AñadirJornada(fecha As Date, dni As String, duracion As Decimal) As String
        If ComprobarJornadaRepetida(fecha, dni) = True Then
            Return "Ya hay una jornada en ese dia con ese DNI"
        End If

        Dim conexion As New SqlConnection(cadenaConexion)
        Dim fechaAPasar As Date = fecha
        Dim dniAPasar As String = dni
        Dim duracionAPasar As Decimal = duracion
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
    Public Function EliminarJornada(fecha As Date, dni As String) As String
        If Not ComprobarJornadaRepetida(fecha, dni) = True Then
            Return "No hay una jornada en ese dia con ese DNI"
        End If
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim fechaAPasar As Date = fecha
        Dim dniAPasar As String = dni
        Dim lineaComando As String = "DELETE JORNADAS.* FROM JORNADAS WHERE DNI = @dni AND FECHA = @fecha"
        Dim eliminar As New SqlCommand(lineaComando, conexion)

        eliminar.Parameters.AddWithValue("@dni", dniAPasar)
        eliminar.Parameters.AddWithValue("@fecha", fechaAPasar)

        Try
            conexion.Open()
            eliminar.ExecuteNonQuery()
        Catch ex As Exception
            Return "Error al intentar borrar una jornada: " & ex.Message
        Finally
            conexion.Close()
        End Try

        Return "Jornada eliminado"
    End Function
    Public Function ModificarJornada(fecha As Date, dni As String, duracion As Decimal) As String
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim fechaAPasar As Date = fecha
        Dim dniAPasar As String = dni
        Dim duracionAPasar As String = duracion
        Dim lineaComando As String = "UPDATE JORNADAS SET DURACION = @duracion WHERE DNI = @dni AND FECHA = @fecha"
        Dim actualizar As New SqlCommand(lineaComando, conexion)

        actualizar.Parameters.AddWithValue("@dni", dniAPasar)
        actualizar.Parameters.AddWithValue("@fecha", fechaAPasar)
        actualizar.Parameters.AddWithValue("@duracion", duracionAPasar)

        Try
            conexion.Open()
            actualizar.ExecuteNonQuery()
        Catch ex As Exception
            Return "Error al intentar cambiar una jornada: " & ex.Message
        Finally
            conexion.Close()
        End Try

        Return "Cambio completado"
    End Function


    Public Function ComprobarJornadaRepetida(fecha As Date, dni As String) As Boolean
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
            '"Error del comprobar jornada repetida: " & ex.Message
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

    Public Function EliminarTarea(tarea As Tarea) As String
        If tarea Is Nothing Then
            Return "Error: la tarea no puede estar vacía"
        End If
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim sqlIncluyen As String = "Delete From INCLUYEN Where CodigoTarea = @codigoTarea And FechaJornada = @fechaJornada And DNI = @dniAlumno"
        Dim cmdDeleteIncluyen As New SqlCommand(sqlIncluyen, conexion)
        Try
            conexion.Open()
            cmdDeleteIncluyen.Parameters.AddWithValue("@codigoTarea", tarea.CodigoTarea)
            cmdDeleteIncluyen.Parameters.AddWithValue("@fechaJornada", tarea.Fecha)
            cmdDeleteIncluyen.Parameters.AddWithValue("@dniAlumno", tarea.DNI)
            Dim numFilas1 As String = cmdDeleteIncluyen.ExecuteNonQuery()
            If numFilas1 = 0 Then
                Return "Error desconocido en la base de datos o la tarea no existe"
            End If
            Dim sqlTareas As String = "Delete From TAREASREALIZADAS Where CodigoTarea = @codigoTarea And FechaJornada = @fechaJornada And DNI = @dniAlumno"
            Dim cmdDeleteTareas As New SqlCommand(sqlTareas, conexion)
            cmdDeleteTareas.Parameters.AddWithValue("@codigoTarea", tarea.CodigoTarea)
            cmdDeleteTareas.Parameters.AddWithValue("@fechaJornada", tarea.Fecha)
            cmdDeleteTareas.Parameters.AddWithValue("@dniAlumno", tarea.DNI)
            Dim numFilas2 As Integer = cmdDeleteTareas.ExecuteNonQuery()
            If numFilas2 = 0 Then
                Return "Error desconocido en la base de datos o la tarea no existe"
            End If
            Return "Se ha modificado la tarea correctamente"
        Catch ex As Exception
            Return "Error en la base de datos: " & ex.Message
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function ModificarRaTarea(tareaAModificar As TareasCompletas, rANuevo As Integer) As String
        If tareaAModificar Is Nothing Then
            Return "Error: la tarea no puede estar vacía"
        End If
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim sql As String = "Update INCLUYEN Set RA = @rANuevo Where CodigoTarea = @codigoTarea And FechaJornada = @fechaJornada And DNI = @dniAlumno And RA = @rA And CodigoModulo = @codigoModulo"
        Dim cmdUpdateIncluyen As New SqlCommand(sql, conexion)
        Try
            conexion.Open()
            cmdUpdateIncluyen.Parameters.AddWithValue("@codigoTarea", tareaAModificar.CodigoTarea)
            cmdUpdateIncluyen.Parameters.AddWithValue("@fechaJornada", tareaAModificar.FechaJornada)
            cmdUpdateIncluyen.Parameters.AddWithValue("@dniAlumno", tareaAModificar.DniAlumno)
            cmdUpdateIncluyen.Parameters.AddWithValue("@rA", tareaAModificar.RA)
            cmdUpdateIncluyen.Parameters.AddWithValue("@rANuevo", rANuevo)
            cmdUpdateIncluyen.Parameters.AddWithValue("@codigoModulo", tareaAModificar.CodigoModulo)
            Dim numFilas As String = cmdUpdateIncluyen.ExecuteNonQuery()
            If numFilas = 0 Then
                Return "Error desconocido en la base de datos o la tarea no existe"
            End If
            Return "Se ha modificado el RA correctamente"
        Catch ex As Exception
            Return "Error en la base de datos: " & ex.Message
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function ModificarDescripcionTarea(tareaAModificar As TareasCompletas, descripcionNueva As String) As String
        If tareaAModificar Is Nothing Then
            Return "Error: la tarea no puede estar vacía"
        End If
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim sql As String = "Update TAREASREALIZADAS Set Descripcion = @descripcion Where CodigoTarea = @codigoTarea And FechaJornada = @fechaJornada And DNI = @dniAlumno"
        Dim cmdUpdateTareas As New SqlCommand(sql, conexion)
        Try
            conexion.Open()
            cmdUpdateTareas.Parameters.AddWithValue("@codigoTarea", tareaAModificar.CodigoTarea)
            cmdUpdateTareas.Parameters.AddWithValue("@fechaJornada", tareaAModificar.FechaJornada)
            cmdUpdateTareas.Parameters.AddWithValue("@dniAlumno", tareaAModificar.DniAlumno)
            cmdUpdateTareas.Parameters.AddWithValue("@descripcion", descripcionNueva)
            Dim numFilas As String = cmdUpdateTareas.ExecuteNonQuery()
            If numFilas = 0 Then
                Return "Error desconocido en la base de datos o la tarea no existe"
            End If
            Return "Se ha modificado la descripcion correctamente"
        Catch ex As Exception
            Return "Error en la base de datos: " & ex.Message
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function ModificarDuracionTarea(tareaAModificar As TareasCompletas, duracionNueva As Decimal) As String
        If tareaAModificar Is Nothing Then
            Return "Error: la tarea no puede estar vacía"
        End If
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim sql As String = "Update TAREASREALIZADAS Set Duracion = @duracion Where CodigoTarea = @codigoTarea And FechaJornada = @fechaJornada And DNI = @dniAlumno"
        Dim cmdUpdateTareas As New SqlCommand(sql, conexion)
        Try
            conexion.Open()
            cmdUpdateTareas.Parameters.AddWithValue("@codigoTarea", tareaAModificar.CodigoTarea)
            cmdUpdateTareas.Parameters.AddWithValue("@fechaJornada", tareaAModificar.FechaJornada)
            cmdUpdateTareas.Parameters.AddWithValue("@dniAlumno", tareaAModificar.DniAlumno)
            cmdUpdateTareas.Parameters.AddWithValue("@duracion", duracionNueva)
            Dim numFilas As String = cmdUpdateTareas.ExecuteNonQuery()
            If numFilas = 0 Then
                Return "Error desconocido en la base de datos o la tarea no existe"
            End If
            Return "Se ha modificado la duración correctamente"
        Catch ex As Exception
            Return "Error en la base de datos: " & ex.Message
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function ModificarFechaJornada(tareaAModificar As TareasCompletas, fechaNueva As Date) As String
        If tareaAModificar Is Nothing Then
            Return "Error: la tarea no puede estar vacía"
        End If
        If Not ComprobarJornadaRepetida(tareaAModificar.FechaJornada, tareaAModificar.DniAlumno) Then
            Return "Error: debes cambiar la fecha a una jornada existente"
        End If
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim sqlIncluyen As String = "Update INCLUYEN Set FechaJornada = @fechaNueva Where CodigoTarea = @codigoTarea And DNI = @dniAlumno And FechaJornada = @fechaJornada"
        Dim cmdUpdateIncluyen As New SqlCommand(sqlIncluyen, conexion)
        Try
            conexion.Open()
            cmdUpdateIncluyen.Parameters.AddWithValue("@codigoTarea", tareaAModificar.CodigoTarea)
            cmdUpdateIncluyen.Parameters.AddWithValue("@fechaJornada", tareaAModificar.FechaJornada)
            cmdUpdateIncluyen.Parameters.AddWithValue("@fechaNueva", fechaNueva)
            cmdUpdateIncluyen.Parameters.AddWithValue("@dniAlumno", tareaAModificar.DniAlumno)
            Dim numFilas1 As String = cmdUpdateIncluyen.ExecuteNonQuery()
            If numFilas1 = 0 Then
                Return "Error desconocido en la base de datos o la tarea no existe"
            End If
            Dim sqlTareas As String = "Update TAREASREALIZADAS Set FechaJornada = @fechaNueva Where CodigoTarea = @codigoTarea And FechaJornada = @fechaJornada And DNI = @dniAlumno"
            Dim cmdUpdateTareas As New SqlCommand(sqlTareas, conexion)
            cmdUpdateTareas.Parameters.AddWithValue("@codigoTarea", tareaAModificar.CodigoTarea)
            cmdUpdateTareas.Parameters.AddWithValue("@fechaJornada", tareaAModificar.FechaJornada)
            cmdUpdateIncluyen.Parameters.AddWithValue("@fechaNueva", fechaNueva)
            cmdUpdateTareas.Parameters.AddWithValue("@dniAlumno", tareaAModificar.DniAlumno)
            Dim numFilas As String = cmdUpdateTareas.ExecuteNonQuery()
            If numFilas = 0 Then
                Return "Error desconocido en la base de datos o la tarea no existe"
            End If
            Return "Se ha modificado la fecha correctamente"
        Catch ex As Exception
            Return "Error en la base de datos relacionado con la modificación de la fecha: " & ex.Message
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function ModificarModuloYRAsTarea(tareaAModificar As TareasCompletas, nuevoModulo As Integer) As String
        If tareaAModificar Is Nothing Then
            Return "Error: la tarea no puede estar vacía"
        End If
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim sql As String = "Update INCLUYEN Set CodigoModulo = @nuevoModulo Where CodigoTarea = @codigoTarea And FechaJornada = @fechaJornada And DNI = @dniAlumno And CodigoModulo = @codigoModulo"
        Dim cmdUpdateIncluyen As New SqlCommand(sql, conexion)
        Try
            conexion.Open()
            cmdUpdateIncluyen.Parameters.AddWithValue("@codigoTarea", tareaAModificar.CodigoTarea)
            cmdUpdateIncluyen.Parameters.AddWithValue("@fechaJornada", tareaAModificar.FechaJornada)
            cmdUpdateIncluyen.Parameters.AddWithValue("@dniAlumno", tareaAModificar.DniAlumno)
            cmdUpdateIncluyen.Parameters.AddWithValue("@codigoModulo", tareaAModificar.CodigoModulo)
            cmdUpdateIncluyen.Parameters.AddWithValue("@nuevoModulo", nuevoModulo)
            Dim numFilas As String = cmdUpdateIncluyen.ExecuteNonQuery()
            If numFilas = 0 Then
                Return "Error desconocido en la base de datos o la tarea no existe"
            End If
            Return "Se ha modificado el módulo correctamente"
        Catch ex As Exception
            Return "Error en la base de datos relacionado con la modificación del módulo: " & ex.Message
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function MostrarTareasAlumno(dniAlumno As String) As List(Of TareasCompletas)
        Dim listaTareasMostrar As New List(Of TareasCompletas)
        If dniAlumno Is Nothing OrElse String.IsNullOrWhiteSpace(dniAlumno) Then
            Return Nothing
        End If
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim sql As String = "Select TAREASREALIZADAS.Dni, TAREASREALIZADAS.CodigoTarea, TAREASREALIZADAS.Descripcion As DescripcionTarea, TAREASREALIZADAS.Duracion, INCLUYEN.CodigoModulo, MODULOS.NombreM As Modulo, RAS.Ra, RAS.Descripcion As DescripcionRA, TAREASREALIZADAS.FechaJornada From TAREASREALIZADAS Inner Join (INCLUYEN Inner Join (RAS Inner Join MODULOS On RAS.CodigoModulo = MODULOS.CodigoModulo And RAS.Ciclo = MODULOS.Ciclo And RAS.Alias = MODULOS.Alias) On INCLUYEN.CodigoModulo = RAS.CodigoModulo And INCLUYEN.Ciclo = RAS.Ciclo And INCLUYEN.Alias = RAS.Alias And INCLUYEN.RA = RAS.RA) On TAREASREALIZADAS.CodigoTarea = INCLUYEN.CodigoTarea And TAREASREALIZADAS.FechaJornada = INCLUYEN.FechaJornada And TAREASREALIZADAS.Dni = INCLUYEN.Dni Where TAREASREALIZADAS.Dni = @dniAlumno Group By TAREASREALIZADAS.CodigoTarea"
        Dim cmdMostrar As New SqlCommand(sql, conexion)
        Try
            conexion.Open()
            cmdMostrar.Parameters.AddWithValue("@dniAlumno", dniAlumno)
            Dim drMostrarTareas As SqlDataReader = cmdMostrar.ExecuteReader()
            If Not drMostrarTareas.HasRows Then
                Return Nothing
            End If
            While drMostrarTareas.Read()
                listaTareasMostrar.Add(New TareasCompletas(drMostrarTareas("Dni"), drMostrarTareas("CodigoTarea"), drMostrarTareas("RA"), drMostrarTareas("DescripcionRA"), drMostrarTareas("CodigoModulo"), drMostrarTareas("Modulo"), drMostrarTareas("FechaJornada"), drMostrarTareas("DescripcionTarea"), drMostrarTareas("Duracion")))
            End While
            Return listaTareasMostrar
        Catch ex As Exception
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function MostrarTareasAlumnoDeUnaFecha(dniAlumno As String, fechaJornada As Date) As List(Of TareasCompletas)
        Dim listaTareasMostrar As New List(Of TareasCompletas)
        If dniAlumno Is Nothing OrElse String.IsNullOrWhiteSpace(dniAlumno) Then
            Return Nothing
        End If
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim sql As String = "Select TAREASREALIZADAS.Dni, TAREASREALIZADAS.CodigoTarea, TAREASREALIZADAS.Descripcion As DescripcionTarea, TAREASREALIZADAS.Duracion, INCLUYEN.CodigoModulo, MODULOS.NombreM As Modulo, RAS.Ra, RAS.Descripcion As DescripcionRA, TAREASREALIZADAS.FechaJornada From TAREASREALIZADAS Inner Join (INCLUYEN Inner Join (RAS Inner Join MODULOS On RAS.CodigoModulo = MODULOS.CodigoModulo And RAS.Ciclo = MODULOS.Ciclo And RAS.Alias = MODULOS.Alias) On INCLUYEN.CodigoModulo = RAS.CodigoModulo And INCLUYEN.Ciclo = RAS.Ciclo And INCLUYEN.Alias = RAS.Alias And INCLUYEN.RA = RAS.RA) On TAREASREALIZADAS.CodigoTarea = INCLUYEN.CodigoTarea And TAREASREALIZADAS.FechaJornada = INCLUYEN.FechaJornada And TAREASREALIZADAS.Dni = INCLUYEN.Dni Where TAREASREALIZADAS.Dni = @dniAlumno And TAREASREALIZADAS.FechaJornada = @fechaJornada Group By TAREASREALIZADAS.CodigoTarea"
        Dim cmdMostrar As New SqlCommand(sql, conexion)
        Try
            conexion.Open()
            cmdMostrar.Parameters.AddWithValue("@dniAlumno", dniAlumno)
            cmdMostrar.Parameters.AddWithValue("@fechaJornada", fechaJornada)
            Dim drMostrarTareas As SqlDataReader = cmdMostrar.ExecuteReader()
            If Not drMostrarTareas.HasRows Then
                Return Nothing
            End If
            While drMostrarTareas.Read()
                listaTareasMostrar.Add(New TareasCompletas(drMostrarTareas("Dni"), drMostrarTareas("CodigoTarea"), drMostrarTareas("RA"), drMostrarTareas("DescripcionRA"), drMostrarTareas("CodigoModulo"), drMostrarTareas("Modulo"), drMostrarTareas("FechaJornada"), drMostrarTareas("DescripcionTarea"), drMostrarTareas("Duracion")))
            End While
            Return listaTareasMostrar
        Catch ex As Exception
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function DevolverAlumnos() As List(Of Alumno)
        Dim lista As New List(Of Alumno)

        Dim conexion As New SqlConnection(cadenaConexion)
        Dim sql As String = "SELECT DNI, NOMBRE, [APELLIDO 1], [APELLIDO 2], HORASTOTALES, CICLO, ALIAS FROM ALUMNOS"
        Dim cmd As New SqlCommand(sql, conexion)

        Try
            conexion.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            If dr.Read() Then
                Dim a As New Alumno
                a.DNI = dr("DNI").ToString()
                a.Nombre = dr("NOMBRE").ToString()
                a.Apellido1 = dr("APELLIDO 1").ToString()
                a.Apellido2 = dr("APELLIDO 2").ToString()
                a.HorasTotales = Convert.ToInt32(dr("HORASTOTALES"))
                a.Ciclo = Convert.ToInt32(dr("CICLO"))
                a.AliasCurso = dr("ALIAS").ToString()
                lista.Add(a)
            End If
        Catch ex As Exception

        Finally
            conexion.Close()
        End Try

        Return lista
    End Function
    Public Function DevolverAlumnosFiltrados(Optional curso As String = "", Optional ciclo As Integer = 0) As List(Of Alumno)
        Dim lista As New List(Of Alumno)()
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim cicloAPasar As Integer = ciclo
        Dim cursoAPasar As String = curso

        Dim sql As String = "SELECT DNI, NOMBRE, [APELLIDO 1], [APELLIDO 2], HORASTOTALES, CICLO, ALIAS FROM ALUMNOS WHERE CICLO = @CICLO AND ALIAS = @ALIAS"

        Dim cmd As New SqlCommand(sql, conexion)
        cmd.Parameters.AddWithValue("@CICLO", cicloAPasar)
        cmd.Parameters.AddWithValue("@ALIAS", cursoAPasar)


        If Not String.IsNullOrEmpty(curso) Then cmd.Parameters.AddWithValue("@CURSO", curso)
        If ciclo > 0 Then cmd.Parameters.AddWithValue("@CICLO", ciclo)

        Try
            conexion.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader()


            While dr.Read()
                Dim a As New Alumno()
                a.DNI = dr("DNI").ToString()
                a.Nombre = dr("NOMBRE").ToString()
                a.Apellido1 = dr("APELLIDO 1").ToString()
                a.Apellido2 = dr("APELLIDO 2").ToString()
                a.HorasTotales = Convert.ToInt32(dr("HORASTOTALES"))
                a.Ciclo = Convert.ToInt32(dr("CICLO"))
                a.AliasCurso = dr("ALIAS").ToString()

                lista.Add(a)
            End While
            dr.Close()
        Catch ex As Exception

        Finally
            conexion.Close()
        End Try

        Return lista
    End Function

    Public Function MostrarHorasDeAlumnosPorCicloYAliasDelCurso(ciclo As Integer, curso As String) As List(Of Alumno)
        Dim listaAlumnos As New List(Of Alumno)
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim cicloAPasar As Integer = ciclo
        Dim cursoAPasar As String = curso
        Dim sql As String = "SELECT NOMBRE, HORASTOTALES FROM ALUMNOS WHERE CICLO = @CICLO AND ALIAS = @ALIAS"
        Dim cmdHorasPorCicloYAlias As New SqlCommand(sql, conexion)
        cmdHorasPorCicloYAlias.Parameters.AddWithValue("@CICLO", cicloAPasar)
        cmdHorasPorCicloYAlias.Parameters.AddWithValue("@ALIAS", cursoAPasar)
        Try
            conexion.Open()
            Dim drHorasPorCicloYAlias As SqlDataReader = cmdHorasPorCicloYAlias.ExecuteReader
            While drHorasPorCicloYAlias.Read()
                Dim alumno As New Alumno
                alumno.Nombre = drHorasPorCicloYAlias("CICLO").ToString
                alumno.HorasTotales = Convert.ToInt32(drHorasPorCicloYAlias("HORASTOTALES"))
                listaAlumnos.Add(alumno)
            End While
            drHorasPorCicloYAlias.Close()
        Catch ex As Exception
            Return New List(Of Alumno)
        End Try
        Return listaAlumnos
    End Function


    Public Function DevolverCursos() As List(Of Curso)
        Dim listaCursos As New List(Of Curso)
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim sql As String = "SELECT ALIAS FROM CURSOS"
        Dim cmdCursos As New SqlCommand(sql, conexion)
        Try
            conexion.Open()
            Dim drCursos As SqlDataReader = cmdCursos.ExecuteReader
            While drCursos.Read()
                Dim curso As New Curso
                curso.AliasCurso = drCursos("ALIAS")
                listaCursos.Add(curso)
            End While
            drCursos.Close()
        Catch ex As Exception
            Return New List(Of Curso)
        End Try
        Return listaCursos
    End Function

    Public Function DevolverCiclosPorCurso(curso As String) As List(Of Curso)
        Dim listaCiclos As New List(Of Curso)()
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim sql As String = "SELECT CICLO FROM CURSOS"
        Dim cmdCiclos As New SqlCommand(sql, conexion)
        Try
            conexion.Open()
            Dim drCursos As SqlDataReader = cmdCiclos.ExecuteReader
            While drCursos.Read()
                Dim cicloCurso As New Curso
                cicloCurso.Ciclo = drCursos("CICLO").ToString()
                listaCiclos.Add(cicloCurso)
            End While
            drCursos.Close()
        Catch ex As Exception
            Return New List(Of Curso)()
        End Try
        Return listaCiclos
    End Function


End Class
