
Public Class BitacoraDAL
    Shared Function agregarBitacora(ByVal usr As BE.UsuarioBE, ByVal mensaje As String, ByVal codigo As Integer) As String
        Dim table As DataTable
        Dim excep As String = ""

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("INSERTAR_BITACORA_SP")
            table = New DataTable
            repository.addParam("@idIdioma", idIdioma)
            repository.addParam("@codigoExcepcion", codigoExcepcion)
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.ExcepcionNoEncontradaExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                excep = pepe.Item(0)
            Next

        Catch ex As Exception
            Throw New Excepciones.ExcepcionNoEncontradaExcepcion
        End Try

        Return excep
    End Function
End Class
