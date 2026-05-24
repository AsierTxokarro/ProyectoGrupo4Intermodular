Imports NUnit.Framework
Imports System.Data.SqlClient
Imports Gestion
Imports Entidades

Namespace Tests


    Public Class TestsUnitarios


        Private Const DNI_TEST As String = "00000001T"
        Private Const CICLO_TEST As Integer = 1
        Private Const ALIAS_TEST As String = "DAM"


        <Test>
        <Category("AccesoDNI")>
        Public Sub ValidarDNI_FormatoCorrecto_DebeRetornarTrue()

            Dim dniValido As String = "12345678A"


            Dim resultado As Boolean = GestionFunciones.ValidarFormatoDNI(dniValido)

            Assert.IsTrue(resultado, $"El DNI '{dniValido}' debería ser válido.")
        End Sub


        <Test>
        <Category("AccesoDNI")>
        Public Sub ValidarDNI_DemasiadoCorto_DebeRetornarFalse()
            Dim dniCorto As String = "1234567A"
            Dim resultado As Boolean = GestionFunciones.ValidarFormatoDNI(dniCorto)
            Assert.IsFalse(resultado, $"El DNI '{dniCorto}' no debería ser válido (demasiado corto).")
        End Sub

        <Test>
        <Category("AccesoDNI")>
        Public Sub ValidarDNI_SinLetraFinal_DebeRetornarFalse()
            Dim dniSinLetra As String = "123456789"
            Dim resultado As Boolean = GestionFunciones.ValidarFormatoDNI(dniSinLetra)
            Assert.IsFalse(resultado, $"El DNI '{dniSinLetra}' no debería ser válido (termina en número).")
        End Sub


        <Test>
        <Category("AccesoDNI")>
        Public Sub ValidarDNI_LetraMinuscula_DebeRetornarFalse()
            Dim dniMinuscula As String = "12345678a"
            Dim resultado As Boolean = GestionFunciones.ValidarFormatoDNI(dniMinuscula)
            Assert.IsFalse(resultado, $"El DNI '{dniMinuscula}' no debería ser válido (letra en minúscula).")
        End Sub


        <Test>
        <Category("AccesoDNI")>
        Public Sub ValidarDNI_CadenaVacia_DebeRetornarFalse()
            Dim resultado As Boolean = GestionFunciones.ValidarFormatoDNI(String.Empty)
            Assert.IsFalse(resultado, "Un DNI vacío no debería ser válido.")
        End Sub


        <Test>
        <Category("AccesoDNI")>
        Public Sub ValidarDNI_ConLetrasEnLaParte_Numerica_DebeRetornarFalse()
            Dim dniMalFormato As String = "ABCDEFGHZ"
            Dim resultado As Boolean = GestionFunciones.ValidarFormatoDNI(dniMalFormato)
            Assert.IsFalse(resultado, $"El DNI '{dniMalFormato}' no debería ser válido (letras en posición numérica).")
        End Sub

        <Test>
        <Category("ConexionBD")>
        Public Sub ConexionBD_AbrirYCerrar_DebeConectarSinErrores()

            Dim errorConexion As String = String.Empty
            Dim servidor As String = BuscarServer.MiServidor.Servidor(errorConexion)

            Assert.IsTrue(String.IsNullOrEmpty(errorConexion),
                $"Error al buscar el servidor: {errorConexion}")

            Dim cadenaConexion As String =
                $"Data Source={servidor};Initial Catalog=Grupo4;Integrated Security=True"


            Dim conexion As New SqlConnection(cadenaConexion)
            Dim excepcion As Exception = Nothing
            Try
                conexion.Open()
            Catch ex As Exception
                excepcion = ex
            Finally
                conexion.Close()
            End Try


            Assert.IsNull(excepcion,
                $"No se pudo conectar a la base de datos Grupo4. Error: {excepcion?.Message}")
            Assert.AreEqual(System.Data.ConnectionState.Closed, conexion.State,
                "La conexión debería haberse cerrado correctamente en el Finally.")
        End Sub


        <Test>
        <Category("ConexionBD")>
        Public Sub GestionFunciones_Constructor_NoDebeProducirErrorDeConexion()

            Dim errorConexion As String = String.Empty
            Dim gestion As GestionFunciones = Nothing
            Dim excepcion As Exception = Nothing

            Try
                gestion = New GestionFunciones(errorConexion)
            Catch ex As Exception
                excepcion = ex
            End Try


            Assert.IsNull(excepcion,
                $"El constructor de GestionFunciones lanzó una excepción: {excepcion?.Message}")
            Assert.IsNotNull(gestion,
                "GestionFunciones no debería ser Nothing tras el constructor.")
            Assert.IsTrue(String.IsNullOrEmpty(errorConexion),
                $"El constructor reportó error de conexión: {errorConexion}")
        End Sub


        <SetUp>
        Public Sub LimpiarAlumnoTest()
            ' Nos aseguramos de que el DNI de prueba no exista antes de cada test
            EliminarAlumnoSiExiste(DNI_TEST)
        End Sub

        <TearDown>
        Public Sub LimpiarDespues()
            ' Limpiamos también al terminar
            EliminarAlumnoSiExiste(DNI_TEST)
        End Sub


        <Test>
        <Category("EstructuraBD")>
        Public Sub AñadirAlumno_DatosCorrectos_DebeRetornarInsertado()

            Dim errorConexion As String = String.Empty
            Dim gestion As New GestionFunciones(errorConexion)


            Dim resultado As String = gestion.AñadirAlumno(
                dni:=DNI_TEST,
                horasTotales:=400,
                nombre:="AlumnoTest",
                apellido1:="ApellidoUno",
                apellido2:="ApellidoDos",
                ciclo:=CICLO_TEST,
                aliasCurso:=ALIAS_TEST
            )


            Assert.AreEqual("Insertado", resultado,
                $"AñadirAlumno debería retornar 'Insertado' con datos correctos. Retornó: '{resultado}'")
        End Sub


        <Test>
        <Category("EstructuraBD")>
        Public Sub AñadirAlumno_DespuesDeInsertar_ExisteDebeRetornarTrue()

            Dim errorConexion As String = String.Empty
            Dim gestion As New GestionFunciones(errorConexion)
            gestion.AñadirAlumno(DNI_TEST, 400, "AlumnoTest", "ApellidoUno", "ApellidoDos",
                                 CICLO_TEST, ALIAS_TEST)


            Dim mensajeExiste As String = String.Empty
            Dim existe As Boolean = gestion.Existe(DNI_TEST, mensajeExiste)


            Assert.IsTrue(existe,
                "Después de insertar el alumno, Existe() debería devolver True.")
            Assert.IsTrue(String.IsNullOrEmpty(mensajeExiste),
                $"Existe() no debería reportar error: {mensajeExiste}")
        End Sub


        <Test>
        <Category("EstructuraBD")>
        Public Sub AñadirAlumno_DNIDuplicado_DebeRetornarMensajeDeError()

            Dim errorConexion As String = String.Empty
            Dim gestion As New GestionFunciones(errorConexion)
            gestion.AñadirAlumno(DNI_TEST, 400, "AlumnoTest", "Uno", "Dos", CICLO_TEST, ALIAS_TEST)


            Dim resultado As String = gestion.AñadirAlumno(
                DNI_TEST, 200, "Otro", "Apellido", "Segundo", CICLO_TEST, ALIAS_TEST)


            Assert.IsTrue(resultado.Contains(DNI_TEST) OrElse resultado.ToLower().Contains("ya hay"),
                $"Insertar un DNI duplicado debería devolver aviso. Retornó: '{resultado}'")
        End Sub





        <Test>
        <Category("ReglasNegocio")>
        Public Sub AñadirTarea_DuracionMayorDeOchoHoras_DebeRetornarMensajeDeError()

            Dim errorConexion As String = String.Empty
            Dim gestion As New GestionFunciones(errorConexion)


            Dim resultado As String = gestion.AñadirTarea(
                codigo:=1,
                fecha:=Date.Today,
                dni:=DNI_TEST,
                descripcion:="Tarea de prueba",
                duracion:=9   ' Supera el límite de 8 horas
            )


            Assert.IsTrue(resultado.ToLower().Contains("8") OrElse resultado.ToLower().Contains("mas de"),
                $"Debería rechazar duraciones > 8h. Retornó: '{resultado}'")
        End Sub


        <Test>
        <Category("ReglasNegocio")>
        Public Sub AñadirTarea_DuracionOchoHoras_NoDebeRechazarsePorLimite()

            Dim errorConexion As String = String.Empty
            Dim gestion As New GestionFunciones(errorConexion)

            Dim resultado As String = gestion.AñadirTarea(
                codigo:=1,
                fecha:=Date.Today,
                dni:=DNI_TEST,
                descripcion:="Tarea límite",
                duracion:=8
            )


            Assert.IsFalse(resultado.ToLower().Contains("mas de") AndAlso resultado.Contains("8"),
                $"Una tarea de 8h exactas no debería rechazarse por el límite de duración. Retornó: '{resultado}'")
        End Sub


        Private Sub EliminarAlumnoSiExiste(dni As String)
            Try
                Dim errorConexion As String = String.Empty
                Dim gestion As New GestionFunciones(errorConexion)
                Dim mensaje As String = String.Empty
                If gestion.Existe(dni, mensaje) Then
                    gestion.EliminarAlumno(dni)
                End If
            Catch

            End Try
        End Sub

    End Class

End Namespace
