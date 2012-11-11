Public Class IdiomaDAL
    Public Shared Function listarIdiomas(ByVal nombre As String) As List(Of BE.IdiomaBE)
        Dim table As DataTable

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Dim listaIdiomas As New List(Of BE.IdiomaBE)
        Try
            repository.crearComando("LISTAR_IDIOMAS_SP")
            repository.addParam("@nom", nombre)
            table = New DataTable
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.NoHayIdiomasExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim idioma As New BE.IdiomaBE
                idioma.identificador = pepe.Item(0)
                idioma.descripcion = pepe.Item(1)
                listaIdiomas.Add(idioma)
            Next

        Catch ex As Exception
            Throw New Excepciones.NoHayIdiomasExcepcion
        End Try

        Return listaIdiomas
    End Function

    Shared Function buscarIdioma(ByVal p1 As Integer) As BE.IdiomaBE
        Dim table As DataTable

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Dim idioma As New BE.IdiomaBE
        Try
            repository.crearComando("BUSCAR_IDIOMA_SP")
            table = New DataTable
            repository.addParam("@idIdioma", p1)
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.IdiomaNoEncontradoExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                idioma.identificador = pepe.Item(0)
                idioma.descripcion = pepe.Item(1)
            Next

        Catch ex As Exception
            Throw New Excepciones.IdiomaNoEncontradoExcepcion
        End Try

        Return idioma
    End Function

    Shared Function guardarIdioma(ByVal idioma As BE.IdiomaBE) As Integer
        Dim result As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Dim tranRepo As New RepositorioTransaccional(repository)
        Try
            tranRepo.crearComando("GENERAR_IDIOMA_SP")
            tranRepo.addParam("@nom", idioma.descripcion)
            result = tranRepo.executeSearch
            If (result <= 0) Then
                Throw New Excepciones.GeneracionDeIdiomaExcepcion
            End If
        Catch ex As Excepciones.ConexionImposibleExcepcion
            Throw New Excepciones.ConexionImposibleExcepcion
        Catch ex As Excepciones.InsertExcepcion
            Throw New Excepciones.InsertExcepcion
        End Try

        Dim newIdiomaId As Integer = result

        If newIdiomaId > 0 Then
            'tranRepo.clearParams()
            tranRepo.crearComando("GUARDAR_BITACORAS_BASE_SP")
            For Each bit As BE.MensajeBitacoraBE In idioma.bitacorasBase
                tranRepo.addParam("@idIdioma", newIdiomaId)
                tranRepo.addParam("@bitBase", bit.idBase)
                tranRepo.addParam("@bitMensaje", bit.mensaje)
                result = tranRepo.executeSearchWithStatus()
                If (result <= 0) Then
                    Throw New Excepciones.ModificacionDeBitacoraExcepcion
                End If
                'tranRepo.clearParams()
            Next

            tranRepo.crearComando("GUARDAR_EXCEPCIONES_SP")
            For Each exc As BE.ExcepcionBE In idioma.listaExcepciones
                tranRepo.addParam("@idIdioma", newIdiomaId)
                tranRepo.addParam("@excBase", exc.codigo)
                tranRepo.addParam("@excMensaje", exc.mensaje)
                result = tranRepo.executeSearchWithStatus()
                If (result <= 0) Then
                    Throw New Excepciones.ModificacionDeExcepcionExcepcion
                End If
                'DAL.ExcepcionDAL.guardarExcepecion(exc, result)
                'tranRepo.clearParams()
            Next

            tranRepo.crearComando("GUARDAR_TRADUCCIONES_SP")
            For Each men As BE.MensajeControlBE In idioma.mensaje

                tranRepo.addParam("@idIdioma", newIdiomaId)
                tranRepo.addParam("@idControl", men.idControl)
                tranRepo.addParam("@mensaje", men.mensaje)
                result = tranRepo.executeSearchWithStatus()
                If (result <= 0) Then
                    Throw New Excepciones.ModificacionDeMensajeControlExcepcion
                End If
                'tranRepo.clearParams()
                'DAL.MensajeControlDAL.guardarMensaje(men, result)
            Next
            tranRepo.transactionOK()
        End If

        Return newIdiomaId
    End Function

    Shared Function eliminarIdioma(ByVal p1 As Integer) As Integer
        Dim result As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("ELIMINAR_IDIOMA_SP")
            repository.addParam("@idIdioma", p1)
            result = repository.executeSearchWithStatus
            If (result <= 0) Then
                Throw New Excepciones.EliminarIdiomaExcepcion
            End If
        Catch ex As Exception
            Throw New Excepciones.EliminarIdiomaExcepcion
        End Try

        Return result
    End Function

    Shared Function modificarIdioma(ByVal idioma As BE.IdiomaBE) As Integer
        Dim result As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("MODIFICAR_IDIOMA_SP")
            repository.addParam("@idIdioma", idioma.identificador)
            repository.addParam("@descIdioma", idioma.descripcion)
            result = repository.executeSearchWithStatus
            If (result <= 0) Then
                Throw New Excepciones.ModificacionDeIdiomaExcepcion
            End If
        Catch ex As Exception
            Throw New Excepciones.ModificacionDeIdiomaExcepcion
        End Try

        Return result
    End Function

    Shared Function checkIdiomasAsignados(ByVal p1 As Integer) As Integer
        Dim result As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("CHEKEAR_IDIOMA_ASIGNADO_SP")
            repository.addParam("@idIdioma", p1)
            result = repository.executeSearch
            If (result > 0) Then
                Throw New Excepciones.IdiomaTieneUsuariosAsociadosExcepcion
            End If
        Catch ex As Exception
            Throw New Excepciones.IdiomaTieneUsuariosAsociadosExcepcion
        End Try

        Return result
    End Function

End Class
