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

    Shared Sub eliminarMensaje(ByVal men As BE.MensajeControlBE, ByVal p2 As Integer)
        Throw New NotImplementedException
    End Sub

    Shared Sub modificarMensaje(ByVal men As BE.MensajeControlBE, ByVal newIdiomaId As Integer)
        Throw New NotImplementedException
    End Sub

End Class
