Public Class MensajeControlDAL

    Shared Function guardarMensaje(ByVal men As BE.MensajeControlBE, ByVal newIdiomaId As Integer) As Integer
        Dim result As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Dim bitacoras As New List(Of BE.BitacoraBE)
        Try
            repository.crearComando("GUARDAR_TRADUCCIONES_SP")
            repository.addParam("@idIdioma", newIdiomaId)
            repository.addParam("@idControl", men.idControl)
            repository.addParam("@mensaje", men.mensaje)
            result = repository.executeSearchWithStatus()
            If (result <= 0) Then
                Throw New Excepciones.InsertExcepcion
            End If

        Catch ex As Exception
            Throw New Excepciones.InsertExcepcion
        End Try

        Return result
    End Function

    Shared Function eliminarMensaje(ByVal men As BE.MensajeControlBE, ByVal p2 As Integer)
        Dim result As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("ELIMINAR_MENSAJE_CONTROL_SP")
            repository.addParam("@idIdioma", p2)
            repository.addParam("@idMensajeControl", men.identificador)
            result = repository.executeSearchWithStatus
            If (result <= 0) Then
                Throw New Excepciones.EliminarMensajeControlExcepcion
            End If
        Catch ex As Exception
            Throw New Excepciones.EliminarMensajeControlExcepcion
        End Try

        Return result
    End Function

    Shared Function modificarMensaje(ByVal men As BE.MensajeControlBE, ByVal newIdiomaId As Integer) As Integer
        Dim result As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("MODIFICAR_MENSAJE_CONTROL_SP")
            repository.addParam("@idIdioma", newIdiomaId)
            repository.addParam("@idMensajeControl", men.identificador)
            repository.addParam("@controlMensaje", men.mensaje)
            result = repository.executeSearchWithStatus
            If (result <= 0) Then
                Throw New Excepciones.ModificacionDeMensajeControlExcepcion
            End If
        Catch ex As Exception
            Throw New Excepciones.ModificacionDeMensajeControlExcepcion
        End Try

        Return result
    End Function

End Class
