
Public Class BitacoraDAL
    Shared Function agregarBitacora(ByVal usr As BE.UsuarioBE, ByVal mensaje As String, ByVal codigo As Integer) As String
        Dim result As Integer
        Dim excep As String = ""

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("INSERTAR_BITACORA_SP")
            If Not usr Is Nothing Then
                repository.addParam("@idUsuario", usr.identificador)
            Else
                repository.addParam("@idUsuario", 0)
            End If

            repository.addParam("@mensaje", mensaje)
            repository.addParam("@codigo", codigo)
            result = repository.executeSearchWithStatus()
            If (result <= 0) Then
                Throw New Excepciones.InsertExcepcion
            End If

        Catch ex As Exception
            Throw New Excepciones.InsertExcepcion
        End Try

        Return result
    End Function

    Public Shared Function buscarBitacora(ByVal usr As BE.UsuarioBE,
                                          ByVal codigo As Integer,
                                          ByVal fecha As DateTime,
                                          ByVal idioma As BE.IdiomaBE) As List(Of BE.BitacoraBE)

        Dim table As DataTable

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Dim bitacoras As New List(Of BE.BitacoraBE)
        Try
            repository.crearComando("BUSCAR_BITACORAS_SP")
            table = New DataTable
            repository.addParam("@idUsuario", usr.identificador)
            repository.addParam("@idIdioma", idioma.identificador)
            repository.addParam("@codigo", codigo)
            repository.addParam("@fecha", fecha)
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.BitacoraNoEncontradaExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim bit As String = ""
                Dim men As String = ""

                Dim bitacora As New BE.BitacoraBE
                bitacora.identificador = pepe.Item(0)
                men = pepe.Item(1)
                bit = pepe.Item(2)
                bitacora.fecha = pepe.Item(3)
                Dim info As String

                Dim index As Integer
                For index = 0 To Split(bit, ",").Length - 1
                    info = Split(bit, ",")(index)
                    men = Replace(men, "{" + (index + 1).ToString + "}", info)
                Next
                bitacora.mensaje = men
                bitacoras.Add(bitacora)
            Next

        Catch ex As Exception
            Throw New Excepciones.BitacoraNoEncontradaExcepcion
        End Try

        Return bitacoras
    End Function

    Shared Function listarTipoBitacoras() As List(Of BE.BitacoraBE)
        Dim table As DataTable

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Dim bitacoras As New List(Of BE.BitacoraBE)
        Try
            repository.crearComando("LISTAR_TIPO_BITACORAS_SP")
            table = New DataTable

            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.BitacoraNoEncontradaExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim bit As String = ""
                Dim men As String = ""

                Dim bitacora As New BE.BitacoraBE
                bitacora.identificador = pepe.Item(0)
                bitacora.mensaje = pepe.Item(1)
                bitacoras.Add(bitacora)
            Next

        Catch ex As Exception
            Throw New Excepciones.BitacoraNoEncontradaExcepcion
        End Try

        Return bitacoras
    End Function

    Shared Function buscarBitacorasBase(ByVal idIdioma As Integer) As List(Of BE.MensajeBitacoraBE)
        Dim table As DataTable

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Dim bitacoras As New List(Of BE.MensajeBitacoraBE)
        Try
            repository.crearComando("BUSCAR_BITACORAS_BASE_SP")
            repository.addParam("@idIdioma", idIdioma)

            table = New DataTable

            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.BitacoraNoEncontradaExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim bitacora As New BE.MensajeBitacoraBE
                bitacora.idBase = pepe.Item(0)
                bitacora.mensaje = pepe.Item(1)
                bitacoras.Add(bitacora)
            Next

        Catch ex As Exception
            Throw New Excepciones.BitacoraNoEncontradaExcepcion
        End Try

        Return bitacoras
    End Function

    Shared Function listarBitacoras(ByVal idioma As Integer) As List(Of BE.BitacoraBE)
        Dim table As DataTable

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Dim bitacoras As New List(Of BE.BitacoraBE)
        Try
            repository.crearComando("LISTAR_BITACORAS_SP")
            table = New DataTable
            repository.addParam("@idIdioma", idioma)
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.BitacoraNoEncontradaExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim bitacora As New BE.BitacoraBE
                bitacora.identificador = pepe.Item(0)
                bitacora.mensaje = pepe.Item(1)

                bitacoras.Add(bitacora)
            Next

        Catch ex As Exception
            Throw New Excepciones.BitacoraNoEncontradaExcepcion
        End Try

        Return bitacoras
    End Function

    Shared Function guardarBitacora(ByVal bit As BE.MensajeBitacoraBE, ByVal newIdiomaId As Integer) As Integer
        Dim result As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Dim bitacoras As New List(Of BE.BitacoraBE)
        Try
            repository.crearComando("GUARDAR_BITACORAS_BASE_SP")
            repository.addParam("@idIdioma", newIdiomaId)
            repository.addParam("@bitBase", bit.idBase)
            repository.addParam("@bitMensaje", bit.mensaje)
            result = repository.executeSearchWithStatus()
            If (result <= 0) Then
                Throw New Excepciones.InsertExcepcion
            End If

        Catch ex As Exception
            Throw New Excepciones.InsertExcepcion
        End Try

        Return result

    End Function

    Shared Sub eliminarBitacora(ByVal bit As BE.MensajeBitacoraBE, ByVal p2 As Integer)
        Throw New NotImplementedException
    End Sub

    Shared Function modificarBitacora(ByVal bit As BE.MensajeBitacoraBE, ByVal newIdiomaId As Integer) As Integer
        Dim result As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("MODIFICAR_BITACORA_SP")
            repository.addParam("@idIdioma", newIdiomaId)
            repository.addParam("@idBitBase", bit.idBase)
            repository.addParam("@bitMensaje", bit.mensaje)
            result = repository.executeSearchWithStatus
            If (result <= 0) Then
                Throw New Excepciones.ModificacionDeBitacoraExcepcion
            End If
        Catch ex As Exception
            Throw New Excepciones.ModificacionDeBitacoraExcepcion
        End Try

        Return result
    End Function

End Class
