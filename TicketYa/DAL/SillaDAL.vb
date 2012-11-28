Public Class SillaDAL

    Shared Function getSillas(ByVal p1 As Integer, ByVal p2 As Integer) As List(Of BE.SillaBE)
        Dim table As DataTable

        Dim lista As New List(Of BE.SillaBE)

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("BUSCAR_SILLAS_SP")
            repository.addParam("@idSector", p1)
            repository.addParam("@idFecha", p2)
            table = New DataTable
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.SillasNoEncontradasExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim silla As New BE.SillaBE
                's.identificador,s.descripcion,s.columnas,s.filas,s.valor,s.idTipoSector,fs.idFecha
                silla.identificador = pepe.Item(0)
                silla.fila = pepe.Item(1)
                silla.columna = pepe.Item(2)
                Dim estado As New BE.EstadoSillaBE
                If pepe.Item(3) = 1 Then
                    estado.descripcion = BE.EstadoSillaBE.Estado.Libre
                ElseIf pepe.Item(3) = 2 Then
                    estado.descripcion = BE.EstadoSillaBE.Estado.Reservado
                ElseIf pepe.Item(3) = 3 Then
                    estado.descripcion = BE.EstadoSillaBE.Estado.Vendido
                End If

                silla.estado = estado
                lista.Add(silla)
            Next

        Catch ex As Excepciones.SillasNoEncontradasExcepcion
            Throw New Excepciones.SillasNoEncontradasExcepcion
        End Try

        Return lista
    End Function

End Class
