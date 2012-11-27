Public Class SectorDAL

    Shared Function listarTipoSector() As Object
        Dim table As DataTable

        Dim lista As New List(Of BE.TipoSectorBE)

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("BUSCAR_TIPO_SECTOR_SP")
            table = New DataTable
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.TipoSectorNoEncontradoExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim fecha As New BE.TipoSectorBE
                fecha.identificador = pepe.Item(0)
                fecha.descripcion = pepe.Item(1)

                lista.Add(fecha)
            Next

        Catch ex As Excepciones.TipoSectorNoEncontradoExcepcion
            Throw New Excepciones.TipoSectorNoEncontradoExcepcion
        End Try

        Return lista
    End Function

    Shared Function buscarSector(ByVal p1 As String) As Object
        Dim table As DataTable

        Dim lista As New List(Of BE.SectorBE)

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("BUSCAR_SECTOR_POR_DESCRIPCION_SP")
            repository.addParam("@idFecha", p1)
            table = New DataTable
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.SectorNoEncontradoExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim sector As New BE.SectorBE
                's.identificador,s.descripcion,s.columnas,s.filas,s.valor,s.idTipoSector,fs.idFecha
                sector.identificador = pepe.Item(0)
                sector.descripcion = pepe.Item(1)
                sector.columnas = pepe.Item(2)
                sector.filas = pepe.Item(3)
                sector.valor = pepe.Item(4)
                Dim tipo As New BE.TipoSectorBE
                tipo.identificador = pepe.Item(5)
                sector.tipoSector = tipo
                Dim fecha As New BE.FechaBE
                fecha.identificador = pepe.Item(6)
                sector.fecha = fecha

                lista.Add(sector)
            Next

        Catch ex As Excepciones.SectorNoEncontradoExcepcion
            Throw New Excepciones.SectorNoEncontradoExcepcion
        End Try

        Return lista
    End Function

    Shared Function buscarSectorPorFecha(ByVal p1 As Integer) As Object
        Dim table As DataTable

        Dim lista As New List(Of BE.SectorBE)

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("BUSCAR_SECTOR_POR_FECHA_SP")
            repository.addParam("@idFecha", p1)
            table = New DataTable
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.TipoSectorNoEncontradoExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim sector As New BE.SectorBE
                's.identificador,s.descripcion,s.columnas,s.filas,s.valor,s.idTipoSector,fs.idFecha
                sector.identificador = pepe.Item(0)
                sector.descripcion = pepe.Item(1)
                sector.columnas = pepe.Item(2)
                sector.filas = pepe.Item(3)
                sector.valor = pepe.Item(4)
                Dim tipo As New BE.TipoSectorBE
                tipo.identificador = pepe.Item(5)
                sector.tipoSector = tipo
                Dim fecha As New BE.FechaBE
                fecha.identificador = pepe.Item(6)
                sector.fecha = fecha
                lista.Add(sector)
            Next

        Catch ex As Excepciones.TipoSectorNoEncontradoExcepcion
            Throw New Excepciones.TipoSectorNoEncontradoExcepcion
        End Try

        Return lista
    End Function

End Class
