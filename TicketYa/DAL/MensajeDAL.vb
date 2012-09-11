Public Class MensajeDAL
    Public Shared Function buscarMensajes(ByVal idIdioma As Integer) As List(Of BE.MensajeControlBE)
        Dim table As DataTable

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Dim listaMensajes As New List(Of BE.MensajeControlBE)
        Try
            repository.crearComando("BUSCAR_MENSAJES_SP")
            table = New DataTable
            repository.addParam("@idIdioma", idIdioma)
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.NoHayMensajesExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim mensaje As New BE.MensajeControlBE
                mensaje.identificador = pepe.Item(0)
                mensaje.formulario = pepe.Item(1)
                mensaje.control = pepe.Item(2)
                mensaje.mensaje = pepe.Item(3)
                listaMensajes.Add(mensaje)
            Next

        Catch ex As Exception
            Throw New Excepciones.NoHayMensajesExcepcion
        End Try

        Return listaMensajes
    End Function
End Class
