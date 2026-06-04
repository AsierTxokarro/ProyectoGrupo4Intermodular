Imports System.Data.SqlClient
Imports System.Security.AccessControl
Imports System.Text.RegularExpressions
Imports BuscarServer
Imports Entidades

Public Class GestionFunciones
    Private cadenaConexion As String
    Public Sub New(ByRef errorConexion As String)
        Dim servidor As String = MiServidor.Servidor(errorConexion)
        Dim NombreDeBaseDeDatos = "Grupo4"
        cadenaConexion = $"Data Source={servidor};Initial Catalog={NombreDeBaseDeDatos};Integrated Security=True"
    End Sub

    Public Function AñadirAlumno(dni As String, horasTotales As Integer, nombre As String, apellido1 As String, apellido2 As String, ciclo As Integer, aliasCurso As String) As String

        Dim mensajeError As String = ""

        If Existe(dni, mensajeError) Then
            If Not String.IsNullOrWhiteSpace(mensajeError) Then
                Return mensajeError
            Else
                Return $"Ya hay un alumno con ese DNI {dni}"
            End If
        End If

        Dim conexion As New SqlConnection(cadenaConexion)

        Dim lineaComando As String = "INSERT INTO ALUMNOS (DNI, HORASTOTALES, NOMBRE, [APELLIDO 1], [APELLIDO 2], CICLO, ALIAS) VALUES (@dni, @horasTotales, @nombre, @apellido1, @apellido2, @ciclo, @alias)"

        Dim crear As New SqlCommand(lineaComando, conexion)

        crear.Parameters.AddWithValue("@dni", dni)
        crear.Parameters.AddWithValue("@horasTotales", horasTotales)
        crear.Parameters.AddWithValue("@nombre", nombre)
        crear.Parameters.AddWithValue("@apellido1", apellido1)
        crear.Parameters.AddWithValue("@apellido2", apellido2)
        crear.Parameters.AddWithValue("@ciclo", ciclo)
        crear.Parameters.AddWithValue("@alias", aliasCurso)

        Try
            conexion.Open()
            crear.ExecuteNonQuery()
        Catch ex As Exception
            Return "Error: algo salio mal al intentar insertar el alumno a la base de datos."
        Finally
            conexion.Close()
        End Try
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
    End Function

    Public Function MostrarHorasDeAlumnosPorCicloYAliasDelCurso(ciclo As Integer, curso As String) As List(Of Alumno)
        Dim listaAlumnos As New List(Of Alumno)
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim cicloAPasar As Integer = ciclo
        Dim cursoAPasar As String = curso
        Dim sql As String = "SELECT NOMBRE, HORASTOTALES FROM ALUMNOS WHERE CICLO = @CICLO AND ALIAS = @ALIAS"
        Dim cmdHorasPorCicloYAlias As New SqlCommand(sql, conexion)
        cmdHorasPorCicloYAlias.Parameters.AddWithValue("@CICLO", ciclo)
        cmdHorasPorCicloYAlias.Parameters.AddWithValue("@ALIAS", curso)
        Try
            conexion.Open()
            Dim drHorasPorCicloYAlias As SqlDataReader = cmdHorasPorCicloYAlias.ExecuteReader
            While drHorasPorCicloYAlias.Read()
                Dim alumno As New Alumno
                alumno.Nombre = drHorasPorCicloYAlias("NOMBRE").ToString()
                alumno.HorasTotales = Convert.ToInt32(drHorasPorCicloYAlias("HORASTOTALES"))
                listaAlumnos.Add(alumno)
            End While
            drHorasPorCicloYAlias.Close()
        Catch ex As Exception
            Return New List(Of Alumno)
        Finally
            conexion.Close()
        End Try
        Return listaAlumnos
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
            Dim numFilas As Integer = crear.ExecuteNonQuery()
            If numFilas = 0 Then
                Return "Error: no se ha podido añadir la jornada"
            End If
            Return "Insertado"
        Catch ex As Exception
            Return "Error: algo salio mal al intentar insertar una jornada en la base de datos."
        Finally
            conexion.Close()
        End Try
    End Function
    Public Function EliminarJornada(fecha As Date, dni As String) As String
        If Not ComprobarJornadaRepetida(fecha, dni) = True Then
            Return "No hay una jornada en ese dia con ese DNI"
        End If
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim fechaAPasar As Date = fecha
        Dim dniAPasar As String = dni
        Dim lineaComando As String = "DELETE FROM JORNADAS WHERE DNI = @dni AND FECHA = @fecha"
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
        Dim duracionAPasar As Decimal = duracion
        Dim lineaComando As String = "UPDATE JORNADAS SET DURACION = @duracion WHERE DNI = @dni AND FECHA = @fecha"
        Dim actualizar As New SqlCommand(lineaComando, conexion)

        actualizar.Parameters.AddWithValue("@dni", dniAPasar)
        actualizar.Parameters.AddWithValue("@fecha", fechaAPasar)
        actualizar.Parameters.AddWithValue("@duracion", duracionAPasar)

        Try
            conexion.Open()
            actualizar.ExecuteNonQuery()
        Catch ex As Exception
            Return "Error: algo salio mal al intentar cambiar una jornada de la base de datos."
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
            Return False
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function NumeroJornadasRealizadas(DniAlumno As String) As Integer
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim dni As String = DniAlumno
        Dim lineaComando As String = "SELECT COUNT(*) FROM JORNADAS WHERE DNI = @DNI"
        Dim comprobar As New SqlCommand(lineaComando, conexion)

        comprobar.Parameters.AddWithValue("@DNI", dni)
        Try
            conexion.Open()

            Return Convert.ToInt32(comprobar.ExecuteScalar)

        Catch ex As Exception
            Return -1
        Finally
            conexion.Close()
        End Try
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
            Return "Error: algo salio mal en la base de datos al intentar mostrar las horas de un alumno."
        Finally
            conexion.Close()
        End Try

    End Function

    Public Function EliminarAlumno(dni As String) As String
        Dim lineaComando As String = "DELETE FROM ALUMNOS WHERE DNI = @dni"

        Try
            Using conexion As New SqlConnection(cadenaConexion)
                Using eliminar As New SqlCommand(lineaComando, conexion)
                    eliminar.Parameters.AddWithValue("@dni", dni)

                    conexion.Open()
                    eliminar.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            Return "Algo salio mal al intentar borrar un alumno de la base de datos"
        End Try

        Return ""
    End Function

    Public Function AñadirTarea(fecha As Date, dni As String, descripcion As String, duracion As Decimal) As String
        If (duracion > 8) Then
            Return "Error: no puedes realizar mas de 8 horas"
        End If

        Dim conexion As New SqlConnection(cadenaConexion)
        Dim cmdTareasRealizadas As New SqlCommand("AUTOINDEXADO_TAREASREALIZADAS", conexion)
        cmdTareasRealizadas.CommandType = CommandType.StoredProcedure
        cmdTareasRealizadas.Parameters.AddWithValue("@FECHAJORNADA", fecha)
        cmdTareasRealizadas.Parameters.AddWithValue("@DNI", dni)
        cmdTareasRealizadas.Parameters.AddWithValue("@DESCRIPCION", descripcion)
        cmdTareasRealizadas.Parameters.AddWithValue("@DURACION", duracion)

        Try
            conexion.Open()
            Dim numFilas As Integer = cmdTareasRealizadas.ExecuteNonQuery()
            If numFilas = 0 Then
                Return "Error: no se ha podido insertar la tarea"
            End If
            Return "Tarea insertada correctamente"
        Catch ex As Exception
            Return "Error: algo salio mal en la base de datos al intentar añadir la tarea."
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function ObtenerCodigoTareaPorValores(fecha As Date, dni As String) As Integer
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim sql As String = "SELECT Max(CodigoTarea) FROM TAREASREALIZADAS WHERE FECHAJORNADA = @fecha AND DNI = @dni"
        Dim cmd As New SqlCommand(sql, conexion)
        cmd.Parameters.AddWithValue("@fecha", fecha)
        cmd.Parameters.AddWithValue("@dni", dni)
        Try
            conexion.Open()
            Dim result = cmd.ExecuteScalar()
            If result Is Nothing OrElse IsDBNull(result) Then
                Return -1
            End If
            Return Convert.ToInt32(result)
        Catch ex As Exception
            Return -1
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function AñadirRAsYModulosALaTarea(codigoTarea As Integer, ciclo As Integer, aliasCiclo As String, nombreModulo As String, rAs As List(Of Integer), fechaJornada As Date, dniAlumno As String) As String
        If codigoTarea <= 0 Then
            Return "Error: código de tarea inválido"
        End If
        If aliasCiclo Is Nothing OrElse nombreModulo Is Nothing OrElse rAs Is Nothing OrElse dniAlumno Is Nothing Then
            Return "Error: el formato de los datos dados son incorrectos"
        End If
        If rAs.Count = 0 Then
            Return "Error: la lista de RAs está vacía"
        End If

        Dim codigoModulo As Integer = ObtenerCodigoModuloPorSuNombreYCiclo(ciclo, aliasCiclo, nombreModulo)
        If codigoModulo = -1 Then
            Return "Error: no se pudo conectar con la base de datos"
        End If

        Dim sqlInsertIncluyen As String = "INSERT INTO Incluyen(CODIGOTAREA, FECHAJORNADA, DNI, RA, CODIGOMODULO, CICLO, ALIAS) VALUES (@codTarea, @fecha, @dni, @rA, @codModulo, @ciclo, @alias)"
        Try
            Using conexion As New SqlConnection(cadenaConexion)
                Using cmdIncluyen As New SqlCommand(sqlInsertIncluyen, conexion)
                    conexion.Open()
                    For contadorRAs As Integer = 0 To rAs.Count - 1
                        cmdIncluyen.Parameters.Clear()
                        cmdIncluyen.Parameters.AddWithValue("@codTarea", codigoTarea)
                        cmdIncluyen.Parameters.AddWithValue("@fecha", fechaJornada)
                        cmdIncluyen.Parameters.AddWithValue("@dni", dniAlumno)
                        cmdIncluyen.Parameters.AddWithValue("@codModulo", codigoModulo)
                        cmdIncluyen.Parameters.AddWithValue("@rA", rAs(contadorRAs))
                        cmdIncluyen.Parameters.AddWithValue("@ciclo", ciclo)
                        cmdIncluyen.Parameters.AddWithValue("@alias", aliasCiclo)
                        Dim numFilas As Integer = cmdIncluyen.ExecuteNonQuery()
                        If numFilas = 0 Then
                            Return "Error desconocido en la base de datos"
                        End If
                    Next
                End Using
            End Using
            Return "Se ha añadido el módulo y/o los RAs correctamente"
        Catch ex As Exception
            Return "Error en la base de datos relacionado con la inserción del módulo o de los RAs o con la conexion con esta: " & ex.Message
        End Try
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
            Dim numFilas1 As Integer = cmdDeleteIncluyen.ExecuteNonQuery()
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
                Return "Error en la base de datos al eliminar la tarea o no existe la tarea"
            End If
            Return "Se ha eliminado la tarea correctamente"
        Catch ex As Exception
            Return "Error en la base de datos"
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
            Dim numFilas As Integer = cmdUpdateTareas.ExecuteNonQuery()
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
            Dim numFilas As Integer = cmdUpdateTareas.ExecuteNonQuery()
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

    Public Function ModificarModulosYRAsTarea(tareaAModificar As TareasCompletas, moduloAModificar As String, nuevoModulo As String, rAsNuevos As List(Of Integer), ciclo As Integer, aliasCiclo As String) As String
        If tareaAModificar Is Nothing Then
            Return "Error: la tarea no puede estar vacía"
        End If
        If String.IsNullOrWhiteSpace(nuevoModulo) OrElse String.IsNullOrWhiteSpace(moduloAModificar) OrElse rAsNuevos Is Nothing OrElse ciclo < 1 OrElse ciclo > 2 Then
            Return "Error: el nuevo valor del modulo y/o de los RAs a modificar tienen un formato invalido o están vacíos o el curso no es valido"
        End If
        Dim codigoNuevoModulo As Integer = ObtenerCodigoModuloPorSuNombreYCiclo(ciclo, aliasCiclo, nuevoModulo)
        If codigoNuevoModulo = -1 Then
            Return "Error: no se pudo conectar con la base de datos"
        End If
        Dim codigoModuloAModificar As Integer
        codigoModuloAModificar = ObtenerCodigoModuloPorSuNombreYCiclo(ciclo, aliasCiclo, moduloAModificar)
        If codigoModuloAModificar = -1 Then
            Return "Error: no se pudo conectar con la base de datos"
        End If
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim sql As String = "Update INCLUYEN Set CodigoModulo = @codigoNuevoModulo, RA = @nuevoRA  Where CodigoTarea = @codigoTarea And FechaJornada = @fechaJornada And DNI = @dniAlumno And CodigoModulo = @codigoModulo And RA = @rA"
        Dim cmdUpdateIncluyen As New SqlCommand(sql, conexion)
        Try
            conexion.Open()
            For contadorRAs As Integer = 0 To rAsNuevos.Count - 1
                If contadorRAs >= tareaAModificar.RAs.Count Then
                    Return "Error: el número de RAs nuevos no coincide con los RAs originales"
                End If
                cmdUpdateIncluyen.Parameters.Clear()
                cmdUpdateIncluyen.Parameters.AddWithValue("@codigoTarea", tareaAModificar.CodigoTarea)
                cmdUpdateIncluyen.Parameters.AddWithValue("@fechaJornada", tareaAModificar.FechaJornada)
                cmdUpdateIncluyen.Parameters.AddWithValue("@dniAlumno", tareaAModificar.DniAlumno)
                cmdUpdateIncluyen.Parameters.AddWithValue("@codigoModulo", codigoModuloAModificar)
                cmdUpdateIncluyen.Parameters.AddWithValue("@rA", tareaAModificar.RAs(contadorRAs))
                cmdUpdateIncluyen.Parameters.AddWithValue("@nuevoRA", rAsNuevos(contadorRAs))
                cmdUpdateIncluyen.Parameters.AddWithValue("@codigoNuevoModulo", codigoNuevoModulo)
                Dim numFilas As Integer = cmdUpdateIncluyen.ExecuteNonQuery()
                If numFilas = 0 Then
                    Return "Error desconocido en la base de datos o la tarea no existe"
                End If
            Next
            Return "Se ha modificado el módulo y/o los RAs correctamente"
        Catch ex As Exception
            Return "Error en la base de datos relacionado con la modificación del módulo o del RA o con la conexion con esta: " & ex.Message
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function ObtenerCodigoModuloPorSuNombreYCiclo(ciclo As Integer, aliasCiclo As String, nombreModulo As String) As Integer
        If ciclo < 1 OrElse ciclo > 2 OrElse String.IsNullOrWhiteSpace(aliasCiclo) OrElse String.IsNullOrWhiteSpace(nombreModulo) Then
            Return 0
        End If
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim sql As String = "Select codigoModulo From MODULOS Where Ciclo = @ciclo And Alias = @aliasCiclo And NombreM = @nombreModulo"
        Dim cmdObtenerCodigoModulo As New SqlCommand(sql, conexion)
        Try
            conexion.Open()
            cmdObtenerCodigoModulo.Parameters.AddWithValue("@ciclo", ciclo)
            cmdObtenerCodigoModulo.Parameters.AddWithValue("@aliasCiclo", aliasCiclo)
            cmdObtenerCodigoModulo.Parameters.AddWithValue("@nombreModulo", nombreModulo)
            Dim result = cmdObtenerCodigoModulo.ExecuteScalar()
            If result Is Nothing OrElse IsDBNull(result) Then
                Return -1
            End If
            Return Convert.ToInt32(result)
        Catch ex As Exception
            Return -1
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function MostrarTareasAlumno(dniAlumno As String) As List(Of TareasCompletas)
        Dim listaTareasMostrar As New List(Of TareasCompletas)

        If String.IsNullOrWhiteSpace(dniAlumno) Then
            Return listaTareasMostrar
        End If

        Dim sql As String = "SELECT TAREASREALIZADAS.Dni, TAREASREALIZADAS.CodigoTarea, " &
                        "TAREASREALIZADAS.Descripcion As DescripcionTarea, TAREASREALIZADAS.Duracion, " &
                        "INCLUYEN.CodigoModulo, MODULOS.NombreM As Modulo, RAS.Ra, " &
                        "RAS.Descripcion As DescripcionRA, TAREASREALIZADAS.FechaJornada " &
                        "FROM TAREASREALIZADAS " &
                        "INNER JOIN INCLUYEN ON TAREASREALIZADAS.CodigoTarea = INCLUYEN.CodigoTarea AND TAREASREALIZADAS.FechaJornada = INCLUYEN.FechaJornada AND TAREASREALIZADAS.Dni = INCLUYEN.Dni " &
                        "INNER JOIN RAS ON INCLUYEN.CodigoModulo = RAS.CodigoModulo AND INCLUYEN.Ciclo = RAS.Ciclo AND INCLUYEN.Alias = RAS.Alias AND INCLUYEN.RA = RAS.RA " &
                        "INNER JOIN MODULOS ON RAS.CodigoModulo = MODULOS.CodigoModulo AND RAS.Ciclo = MODULOS.Ciclo AND RAS.Alias = MODULOS.Alias " &
                        "WHERE TAREASREALIZADAS.Dni = @dniAlumno"

        Using conexion As New SqlConnection(cadenaConexion)
            Using cmdMostrar As New SqlCommand(sql, conexion)
                cmdMostrar.Parameters.AddWithValue("@dniAlumno", dniAlumno.Trim())

                Try
                    conexion.Open()
                    Using drMostrarTareas As SqlDataReader = cmdMostrar.ExecuteReader()
                        While drMostrarTareas.Read()
                            Dim seEncuentra As Boolean = False
                            For Each tareaAMostrar As TareasCompletas In listaTareasMostrar
                                If tareaAMostrar.CodigoTarea = Convert.ToInt32(drMostrarTareas("CodigoTarea")) AndAlso Not tareaAMostrar.CodigosModulos.Contains(Convert.ToInt32(drMostrarTareas("CodigoModulo"))) Then
                                    seEncuentra = True
                                    tareaAMostrar.CodigosModulos.Add(Convert.ToInt32(drMostrarTareas("CodigoModulo")))
                                    tareaAMostrar.Modulos.Add(drMostrarTareas("Modulo").ToString())
                                    tareaAMostrar.RAs.Add(Convert.ToInt32(drMostrarTareas("Ra")))
                                    tareaAMostrar.DescripcionesRAs.Add(drMostrarTareas("DescripcionRA").ToString())
                                    Exit For
                                ElseIf tareaAMostrar.CodigoTarea = Convert.ToInt32(drMostrarTareas("CodigoTarea")) AndAlso tareaAMostrar.CodigosModulos.Contains(Convert.ToInt32(drMostrarTareas("CodigoModulo"))) Then
                                    seEncuentra = True
                                    tareaAMostrar.RAs.Add(Convert.ToInt32(drMostrarTareas("Ra")))
                                    tareaAMostrar.DescripcionesRAs.Add(drMostrarTareas("DescripcionRA").ToString())
                                    Exit For
                                End If
                            Next
                            If seEncuentra = False Then
                                listaTareasMostrar.Add(New TareasCompletas(
                                    drMostrarTareas("Dni").ToString(),
                                    Convert.ToInt32(drMostrarTareas("CodigoTarea")),
                                    New List(Of Integer) From {Convert.ToInt32(drMostrarTareas("Ra"))},
                                    New List(Of String) From {drMostrarTareas("DescripcionRA").ToString()},
                                    New List(Of Integer) From {Convert.ToInt32(drMostrarTareas("CodigoModulo"))},
                                    New List(Of String) From {drMostrarTareas("Modulo").ToString()},
                                    Convert.ToDateTime(drMostrarTareas("FechaJornada")),
                                    drMostrarTareas("DescripcionTarea").ToString(),
                                    Convert.ToInt32(drMostrarTareas("Duracion"))
                                ))
                            End If
                        End While
                    End Using
                Catch ex As Exception

                    Return Nothing
                End Try
            End Using
        End Using

        Return listaTareasMostrar
    End Function


    Public Function MostrarTareasAlumnoDeUnaFecha(dniAlumno As String, fechaJornada As Date) As List(Of TareasCompletas)
        Dim listaTareasMostrar As New List(Of TareasCompletas)
        If dniAlumno Is Nothing OrElse String.IsNullOrWhiteSpace(dniAlumno) Then
            Return Nothing
        End If
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim sql As String = "Select TAREASREALIZADAS.Dni, TAREASREALIZADAS.CodigoTarea, TAREASREALIZADAS.Descripcion As DescripcionTarea, TAREASREALIZADAS.Duracion, INCLUYEN.CodigoModulo, MODULOS.NombreM As Modulo, RAS.Ra, RAS.Descripcion As DescripcionRA, TAREASREALIZADAS.FechaJornada From TAREASREALIZADAS Inner Join (INCLUYEN Inner Join (RAS Inner Join MODULOS On RAS.CodigoModulo = MODULOS.CodigoModulo And RAS.Ciclo = MODULOS.Ciclo And RAS.Alias = MODULOS.Alias) On INCLUYEN.CodigoModulo = RAS.CodigoModulo And INCLUYEN.Ciclo = RAS.Ciclo And INCLUYEN.Alias = RAS.Alias And INCLUYEN.RA = RAS.RA) On TAREASREALIZADAS.CodigoTarea = INCLUYEN.CodigoTarea And TAREASREALIZADAS.FechaJornada = INCLUYEN.FechaJornada And TAREASREALIZADAS.Dni = INCLUYEN.Dni Where TAREASREALIZADAS.Dni = @dniAlumno And TAREASREALIZADAS.FechaJornada = @fechaJornada"
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
                Dim seEncuentra As Boolean = False
                For Each tareaAMostrar As TareasCompletas In listaTareasMostrar
                    If tareaAMostrar.CodigoTarea = Convert.ToInt32(drMostrarTareas("CodigoTarea")) AndAlso Not tareaAMostrar.CodigosModulos.Contains(Convert.ToInt32(drMostrarTareas("CodigoModulo"))) Then
                        seEncuentra = True
                        tareaAMostrar.CodigosModulos.Add(Convert.ToInt32(drMostrarTareas("CodigoModulo")))
                        tareaAMostrar.Modulos.Add(drMostrarTareas("Modulo").ToString())
                        tareaAMostrar.RAs.Add(Convert.ToInt32(drMostrarTareas("Ra")))
                        tareaAMostrar.DescripcionesRAs.Add(drMostrarTareas("DescripcionRA").ToString())
                        Exit For
                    ElseIf tareaAMostrar.CodigoTarea = Convert.ToInt32(drMostrarTareas("CodigoTarea")) AndAlso tareaAMostrar.CodigosModulos.Contains(Convert.ToInt32(drMostrarTareas("CodigoModulo"))) Then
                        seEncuentra = True
                        tareaAMostrar.RAs.Add(Convert.ToInt32(drMostrarTareas("Ra")))
                        tareaAMostrar.DescripcionesRAs.Add(drMostrarTareas("DescripcionRA").ToString())
                        Exit For
                    End If
                Next
                If seEncuentra = False Then
                    listaTareasMostrar.Add(New TareasCompletas(
                                    drMostrarTareas("Dni").ToString(),
                                    Convert.ToInt32(drMostrarTareas("CodigoTarea")),
                                    New List(Of Integer) From {Convert.ToInt32(drMostrarTareas("Ra"))},
                                    New List(Of String) From {drMostrarTareas("DescripcionRA").ToString()},
                                    New List(Of Integer) From {Convert.ToInt32(drMostrarTareas("CodigoModulo"))},
                                    New List(Of String) From {drMostrarTareas("Modulo").ToString()},
                                    Convert.ToDateTime(drMostrarTareas("FechaJornada")),
                                    drMostrarTareas("DescripcionTarea").ToString(),
                                    Convert.ToInt32(drMostrarTareas("Duracion"))
                                ))
                End If
            End While
            Return listaTareasMostrar
        Catch ex As Exception
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function


    Public Function DevolverAlumnosFiltrados(curso As String, ciclo As Integer) As List(Of Alumno)
        Dim lista As New List(Of Alumno)()
        Dim conexion As New SqlConnection(cadenaConexion)


        Dim sql As String = "SELECT DNI, NOMBRE, [APELLIDO 1], [APELLIDO 2], HORASTOTALES, CICLO, ALIAS FROM ALUMNOS WHERE ALIAS = @ALIAS AND CICLO = @CICLO"

        Dim cmd As New SqlCommand(sql, conexion)


        cmd.Parameters.AddWithValue("@ALIAS", curso)
        cmd.Parameters.AddWithValue("@CICLO", ciclo)

        Try
            conexion.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader()

            While dr.Read()
                Dim a As New Alumno(
                dr("DNI").ToString(),
                dr("NOMBRE").ToString(),
                dr("APELLIDO 1").ToString(),
                dr("APELLIDO 2").ToString(),
                Convert.ToInt32(dr("HORASTOTALES")),
                Convert.ToInt32(dr("CICLO")),
                dr("ALIAS").ToString())

                lista.Add(a)
            End While
            dr.Close()
        Catch ex As Exception

            Throw ex
        Finally
            conexion.Close()
        End Try

        Return lista
    End Function

    Public Function DevolverCursos() As List(Of Curso)
        Dim listaCursos As New List(Of Curso)
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim sql As String = "SELECT DISTINCT ALIAS FROM CURSOS"
        Dim cmdCursos As New SqlCommand(sql, conexion)

        Try
            conexion.Open()
            Dim drCursos As SqlDataReader = cmdCursos.ExecuteReader()
            While drCursos.Read()
                Dim curso As New Curso

                curso.AliasCurso = drCursos("ALIAS").ToString()
                listaCursos.Add(curso)
            End While
            drCursos.Close()
        Catch ex As Exception
            Return New List(Of Curso)
        Finally
            conexion.Close()
        End Try
        Return listaCursos
    End Function

    Public Function DevolverCiclosPorCurso(curso As String) As List(Of Curso)
        Dim listaCiclos As New List(Of Curso)()
        Dim conexion As New SqlConnection(cadenaConexion)

        Dim sql As String = "SELECT CICLO FROM CURSOS WHERE ALIAS = @ALIAS"
        Dim cmdCiclos As New SqlCommand(sql, conexion)
        cmdCiclos.Parameters.AddWithValue("@ALIAS", curso)

        Try
            conexion.Open()
            Dim drCursos As SqlDataReader = cmdCiclos.ExecuteReader()
            While drCursos.Read()
                Dim cicloCurso As New Curso
                cicloCurso.Ciclo = Convert.ToInt32(drCursos("CICLO"))
                listaCiclos.Add(cicloCurso)
            End While
            drCursos.Close()
        Catch ex As Exception
            Return New List(Of Curso)()
        Finally
            conexion.Close()
        End Try
        Return listaCiclos
    End Function

    Public Function DevolverAlumnos() As List(Of Alumno)
        Dim lista As New List(Of Alumno)
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim sql As String = "SELECT DNI, NOMBRE, [APELLIDO 1], [APELLIDO 2], HORASTOTALES, CICLO, ALIAS FROM ALUMNOS"
        Dim cmd As New SqlCommand(sql, conexion)

        Try
            conexion.Open()
            Dim dr As SqlDataReader = cmd.ExecuteReader()
            While dr.Read()
                Dim a As New Alumno(
                dr("DNI").ToString(),
                dr("NOMBRE").ToString(),
                dr("APELLIDO 1").ToString(),
                dr("APELLIDO 2").ToString(),
                Convert.ToInt32(dr("HORASTOTALES")),
                Convert.ToInt32(dr("CICLO")),
                dr("ALIAS").ToString())
                lista.Add(a)
            End While
            dr.Close()
        Catch ex As Exception
            Return New List(Of Alumno)()
        Finally
            conexion.Close()
        End Try
        Return lista
    End Function

    Public Function AlumnosOrdenadosPorNombre(trozoNombre As String) As List(Of Alumno)
        Dim listaAlumnos As New List(Of Alumno)
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim sql As String = "SELECT DNI, NOMBRE, [APELLIDO 1], [APELLIDO 2], HORASTOTALES, CICLO, ALIAS FROM ALUMNOS WHERE NOMBRE like @TROZONOMBRE + '%' ORDER BY NOMBRE"
        Dim cmdAlumnos As New SqlCommand(sql, conexion)
        cmdAlumnos.Parameters.AddWithValue("@TROZONOMBRE", trozoNombre)
        Try
            conexion.Open()
            Dim drAlumnos As SqlDataReader = cmdAlumnos.ExecuteReader
            While drAlumnos.Read()
                Dim a As New Alumno(
                drAlumnos("DNI").ToString(),
                drAlumnos("NOMBRE").ToString(),
                drAlumnos("APELLIDO 1").ToString(),
                drAlumnos("APELLIDO 2").ToString(),
                Convert.ToInt32(drAlumnos("HORASTOTALES")),
                Convert.ToInt32(drAlumnos("CICLO")),
                drAlumnos("ALIAS").ToString())
                listaAlumnos.Add(a)
            End While
            drAlumnos.Close()
        Catch ex As Exception
            Return Nothing
        End Try
        Return listaAlumnos
    End Function

    Public Function DevolverAlumnoPorDni(dni As String) As Alumno
        Dim alumnoAux As Alumno
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim sql As String = "SELECT DNI, HORASTOTALES, NOMBRE, [APELLIDO 1], [APELLIDO 2], CICLO, ALIAS FROM ALUMNOS WHERE DNI = @DNI"
        Dim cmdAlumno As New SqlCommand(sql, conexion)
        cmdAlumno.Parameters.AddWithValue("@DNI", dni)
        Try
            conexion.Open()
            Dim drAlumno As SqlDataReader = cmdAlumno.ExecuteReader
            If drAlumno.Read() Then
                alumnoAux = New Alumno(drAlumno("DNI"), drAlumno("NOMBRE"), drAlumno("APELLIDO 1"), drAlumno("APELLIDO 2"), drAlumno("HORASTOTALES"), drAlumno("CICLO"), drAlumno("ALIAS"))
                Return alumnoAux
            End If
            Return Nothing
        Catch ex As Exception
            Return Nothing
        Finally
            conexion.Close()
        End Try
    End Function

    Public Shared Function ValidarFormatoDNI(dni As String) As Boolean
        If String.IsNullOrWhiteSpace(dni) Then
            Return False
        End If
        If dni.Length <> 9 Then
            Return False
        End If
        For i As Integer = 0 To 7
            If Not Char.IsDigit(dni(i)) Then
                Return False
            End If
        Next

        Dim numeros As Integer = Integer.Parse(dni.Substring(0, 8))
        Dim letrasDNI As String = "TRWAGMYFPDXBNJZSQVHLCKE"
        Dim letraCorrecta As Char = letrasDNI(numeros Mod 23)

        Return Char.ToUpper(dni(8)) = letraCorrecta
    End Function

    Public Function EsCorreoValido(correo As String) As Boolean
        If Not correo.Contains("@") Then Return False

        If Not correo.Contains(".") Then Return False

        Dim partes As String() = correo.Split("@")
        If partes.Length <> 2 Then Return False
        If String.IsNullOrWhiteSpace(partes(0)) Or String.IsNullOrWhiteSpace(partes(1)) Then Return False

        If Not partes(1).Contains(".") Then Return False

        If correo.Contains(" ") Then Return False

        Return True
    End Function

    Public Function DevolverModulosDeUnCurso(ciclo As Integer, aliasCiclo As String) As List(Of Modulo)
        Dim listaModulos As New List(Of Modulo)
        Dim sqlModulos As String = "SELECT * FROM MODULOS Where Ciclo = @ciclo And Alias = @aliasCiclo"

        Using conexion As New SqlConnection(cadenaConexion)
            Using cmdModulos As New SqlCommand(sqlModulos, conexion)
                Try
                    conexion.Open()
                    cmdModulos.Parameters.AddWithValue("@ciclo", ciclo)
                    cmdModulos.Parameters.AddWithValue("@aliasCiclo", aliasCiclo)
                    Dim drModulos As SqlDataReader = cmdModulos.ExecuteReader()
                    While drModulos.Read()
                        listaModulos.Add(New Modulo(Convert.ToInt32(drModulos("CodigoModulo")), Convert.ToInt32(drModulos("Ciclo")), drModulos("Alias").ToString(), drModulos("NombreM").ToString()))
                    End While
                Catch ex As Exception
                    Return Nothing
                End Try
            End Using
        End Using
        Return listaModulos
    End Function

    Public Function DevolverRAsDeModulo(codigoModulo As Integer, ciclo As Integer, aliasCurso As String) As List(Of RA)
        Dim lista As New List(Of RA)
        Dim sqlRAs As String = "SELECT CodigoModulo, Ciclo, Alias, RA, Descripcion FROM RAS WHERE CodigoModulo = @codigoModulo AND Ciclo = @ciclo AND Alias = @alias"

        Using conexion As New SqlConnection(cadenaConexion)
            Using cmdRAs As New SqlCommand(sqlRAs, conexion)
                cmdRAs.Parameters.AddWithValue("@codigoModulo", codigoModulo)
                cmdRAs.Parameters.AddWithValue("@ciclo", ciclo)
                cmdRAs.Parameters.AddWithValue("@alias", aliasCurso)
                Try
                    conexion.Open()
                    Dim dr As SqlDataReader = cmdRAs.ExecuteReader()
                    While dr.Read()
                        Dim ra As New RA(Convert.ToInt32(dr("CodigoModulo")), Convert.ToInt32(dr("Ciclo")), dr("Alias").ToString(), Convert.ToInt32(dr("RA")), dr("Descripcion").ToString())
                        lista.Add(ra)
                    End While
                Catch ex As Exception
                    Return Nothing
                End Try
            End Using
        End Using
        Return lista
    End Function

    Public Function ComprobarCapacidadJornada(fecha As Date, dni As String, nuevaDuracion As Decimal) As Boolean
        Dim conexion As New SqlConnection(cadenaConexion)
        Dim sqlJornada As String = "SELECT DURACION FROM JORNADAS WHERE FECHA = @fecha AND DNI = @dni"
        Dim sqlSumTareas As String = "SELECT ISNULL(SUM(Duracion), 0) FROM TAREASREALIZADAS WHERE FechaJornada = @fecha AND Dni = @dni"

        Try
            conexion.Open()
            Dim cmdJ As New SqlCommand(sqlJornada, conexion)
            cmdJ.Parameters.AddWithValue("@fecha", fecha)
            cmdJ.Parameters.AddWithValue("@dni", dni)
            Dim jornadaObj = cmdJ.ExecuteScalar()
            If jornadaObj Is Nothing OrElse IsDBNull(jornadaObj) Then
                Return False
            End If
            Dim duracionJornada As Decimal = Convert.ToDecimal(jornadaObj)

            Dim cmdSum As New SqlCommand(sqlSumTareas, conexion)
            cmdSum.Parameters.AddWithValue("@fecha", fecha)
            cmdSum.Parameters.AddWithValue("@dni", dni)
            Dim sumaObj = cmdSum.ExecuteScalar()
            Dim sumaTareas As Decimal = 0
            If Not (sumaObj Is Nothing OrElse IsDBNull(sumaObj)) Then
                sumaTareas = Convert.ToDecimal(sumaObj)
            End If
            If sumaTareas + nuevaDuracion <= duracionJornada Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        Finally
            conexion.Close()
        End Try
    End Function
End Class