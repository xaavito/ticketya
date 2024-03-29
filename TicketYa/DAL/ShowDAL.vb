﻿Public Class ShowDAL

    Shared Function buscarShow(ByVal p1 As String) As Object
        Dim table As DataTable

        Dim lista As New List(Of BE.ShowBE)

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("LISTAR_SHOWS_SP")
            repository.addParam("@desc", p1)
            table = New DataTable
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.ShowsNoEncontradosExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim show As New BE.ShowBE
                show.identificador = pepe.Item(0)
                show.descripcion = pepe.Item(1)
                Dim tipo As New BE.TipoShowBE
                tipo.identificador = pepe.Item(2)
                tipo.descripcion = pepe.Item(3)
                show.tipoShow = tipo
                Dim sede As New BE.SedeBE
                sede.identificador = pepe.Item(4)
                sede.descripcion = pepe.Item(5)
                show.sede = sede

                lista.Add(show)
            Next

        Catch ex As Excepciones.ShowsNoEncontradosExcepcion
            Throw New Excepciones.ShowsNoEncontradosExcepcion
        End Try

        Return lista
    End Function

    Shared Function altaShow(ByVal p1 As String, ByVal p2 As Integer, ByVal p3 As Integer) As Boolean
        Dim result As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("GENERAR_SHOW_SP")
            repository.addParam("@nom", p1)
            repository.addParam("@tipo", p2)
            repository.addParam("@sede", p3)
            result = repository.executeSearchWithStatus
            If (result <= 0) Then
                Throw New Excepciones.GenerarShowExcepcion
            Else
                Throw New Excepciones.ShowCreadoExistosamenteExcepcion
            End If
        Catch ex As Excepciones.GenerarShowExcepcion
            Throw New Excepciones.GenerarShowExcepcion
        End Try

        Return result
    End Function

    Shared Function eliminarShow(ByVal p1 As Integer) As Object
        Dim result As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("ELIMINAR_SHOW_SP")
            repository.addParam("@idShow", p1)
            result = repository.executeSearchWithStatus
            If (result <= 0) Then
                Throw New Excepciones.EliminarShowExcepcion
            Else
                Throw New Excepciones.ShowEliminadoExistosamenteExcepcion
            End If
        Catch ex As Excepciones.EliminarShowExcepcion
            Throw New Excepciones.EliminarShowExcepcion
        End Try

        Return result
    End Function

    Shared Function buscarTipoShow(ByVal p1 As String) As Object
        Dim table As DataTable

        Dim lista As New List(Of BE.TipoShowBE)

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("LISTAR_TIPO_SHOW_SP")
            repository.addParam("@desc", p1)
            table = New DataTable
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.TipoShowsNoEncontradosExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim show As New BE.TipoShowBE
                show.identificador = pepe.Item(0)
                show.descripcion = pepe.Item(1)

                lista.Add(show)
            Next

        Catch ex As Excepciones.TipoShowsNoEncontradosExcepcion
            Throw New Excepciones.TipoShowsNoEncontradosExcepcion
        End Try

        Return lista
    End Function

    Shared Function modificarShow(ByVal p1 As Integer, ByVal p2 As String, ByVal p3 As Integer, ByVal p4 As Integer) As Object
        Dim result As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("MODIFICAR_SHOW_SP")
            repository.addParam("@idShow", p1)
            repository.addParam("@desc", p2)
            repository.addParam("@tipo", p3)
            repository.addParam("@sede", p4)
            result = repository.executeSearchWithStatus
            If (result <= 0) Then
                Throw New Excepciones.ModificarShowExcepcion
            Else
                Throw New Excepciones.ShowModificadoExistosamenteExcepcion
            End If
        Catch ex As Excepciones.ModificarShowExcepcion
            Throw New Excepciones.ModificarShowExcepcion
        End Try

        Return result
    End Function

    Shared Function buscarFecha(ByVal p1 As String,
                                ByVal p2 As Date,
                                ByVal p3 As Date) As List(Of BE.FechaBE)
        Dim table As DataTable

        Dim lista As New List(Of BE.FechaBE)

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("LISTAR_FECHA_SP")
            repository.addParam("@desc", p1)
            repository.addParam("@fechaDesde", p2)
            repository.addParam("@fechaHasta", p3)
            table = New DataTable
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.FechasNoEncontradasExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim fecha As New BE.FechaBE
                fecha.identificador = pepe.Item(0)
                fecha.descripcion = pepe.Item(1)
                fecha.fecha = pepe.Item(2)
                Dim show As New BE.ShowBE
                show.identificador = pepe.Item(3)
                fecha.show = show

                lista.Add(fecha)
            Next

        Catch ex As Excepciones.FechasNoEncontradasExcepcion
            Throw New Excepciones.FechasNoEncontradasExcepcion
        End Try

        Return lista
    End Function

    Shared Function eliminarFecha(ByVal p1 As Integer) As Object
        Dim result As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("ELIMINAR_FECHA_SP")
            repository.addParam("@idFecha", p1)
            result = repository.executeSearchWithStatus
            If (result <= 0) Then
                Throw New Excepciones.EliminarFechaExcepcion
            Else
                Throw New Excepciones.FechaEliminadaExistosamenteExcepcion
            End If
        Catch ex As Excepciones.EliminarFechaExcepcion
            Throw New Excepciones.EliminarFechaExcepcion
        End Try

        Return result
    End Function

    Shared Function altaFecha(ByVal p1 As String, ByVal p2 As Date, ByVal p3 As Integer) As Boolean
        Dim result As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("GENERAR_FECHA_SP")
            repository.addParam("@nom", p1)
            repository.addParam("@fecha", p2)
            repository.addParam("@idShow", p3)
            result = repository.executeSearchWithStatus
            If (result <= 0) Then
                Throw New Excepciones.GenerarFechaExcepcion
            Else
                Throw New Excepciones.FechaCreadaExistosamenteExcepcion
            End If
        Catch ex As Excepciones.GenerarFechaExcepcion
            Throw New Excepciones.GenerarFechaExcepcion
        End Try

        Return result
    End Function

    Shared Function modificarFecha(ByVal p1 As Integer, ByVal p2 As String, ByVal p3 As Integer, ByVal p4 As Date) As Object
        Dim result As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("MODIFICAR_FECHA_SP")
            repository.addParam("@idFecha", p1)
            repository.addParam("@desc", p2)
            repository.addParam("@show", p3)
            repository.addParam("@fecha", p4)
            result = repository.executeSearchWithStatus
            If (result <= 0) Then
                Throw New Excepciones.ModificarFechaExcepcion
            Else
                Throw New Excepciones.FechaModificadaExistosamenteExcepcion
            End If
        Catch ex As Excepciones.ModificarFechaExcepcion
            Throw New Excepciones.ModificarFechaExcepcion
        End Try

        Return result
    End Function

    Shared Function buscarFecha(ByVal p1 As Integer) As Object
        Dim table As DataTable

        Dim lista As New List(Of BE.FechaBE)

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("BUSCAR_FECHA_SP")
            repository.addParam("@idShow", p1)
            table = New DataTable
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.FechasNoEncontradasExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim fecha As New BE.FechaBE
                fecha.identificador = pepe.Item(0)
                fecha.descripcion = pepe.Item(1)
                fecha.fecha = pepe.Item(2)
                fecha.forLista = pepe.Item(1) + ", " + pepe.Item(2)
                
                lista.Add(fecha)
            Next

        Catch ex As Excepciones.FechasNoEncontradasExcepcion
            Throw New Excepciones.FechasNoEncontradasExcepcion
        End Try

        Return lista
    End Function

    Shared Function buscarSectoresPorFecha(ByVal Fecha As BE.FechaBE) As Object
        Dim table As DataTable

        Dim lista As New List(Of BE.FechaReporte)

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("BUSCAR_SECTORES_POR_FECHA_SP")
            repository.addParam("@idFecha", Fecha.identificador)
            table = New DataTable
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.SectoresNoEncontradosExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim sec As New BE.FechaReporte
                sec.descFecha = pepe.Item(0)
                sec.fecha = pepe.Item(1)
                sec.descripcion = pepe.Item(2)
                sec.estado = pepe.Item(3)
                sec.cantidad = pepe.Item(4)
                lista.Add(sec)
            Next

        Catch ex As Excepciones.SectoresNoEncontradosExcepcion
            Throw New Excepciones.SectoresNoEncontradosExcepcion
        End Try

        Return lista
    End Function

    Shared Function buscarSectorReporte(ByVal sector As BE.SectorBE) As Object
        Dim table As DataTable

        Dim lista As New List(Of BE.SectorReporte)

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("BUSCAR_SECTOR_REPORTE_SP")
            repository.addParam("@idSector", sector.identificador)
            repository.addParam("@idFecha", sector.fecha.identificador)
            table = New DataTable
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.SectoresNoEncontradosExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim sec As New BE.SectorReporte
                sec.descripcion = pepe.Item(0)
                sec.cantidad = pepe.Item(1)
                lista.Add(sec)
            Next

        Catch ex As Excepciones.SectoresNoEncontradosExcepcion
            Throw New Excepciones.SectoresNoEncontradosExcepcion
        End Try

        Return lista
    End Function

    Shared Function buscarShowReporte(ByVal show As BE.ShowBE) As Object
        Dim table As DataTable

        Dim lista As New List(Of BE.ShowReporte)

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("BUSCAR_SHOW_REPORTE_SP")
            repository.addParam("@idShow", show.identificador)
            table = New DataTable
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.ShowsNoEncontradosExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim sec As New BE.ShowReporte
                sec.show = pepe.Item(0)
                sec.descFecha = pepe.Item(1)
                sec.fecha = pepe.Item(2)
                sec.descripcion = pepe.Item(3)
                sec.estado = pepe.Item(4)
                sec.cantidad = pepe.Item(5)
                lista.Add(sec)
            Next

        Catch ex As Excepciones.ShowsNoEncontradosExcepcion
            Throw New Excepciones.ShowsNoEncontradosExcepcion
        End Try

        Return lista
    End Function

    Shared Function checkFechasAsignadas(ByVal show As BE.ShowBE)
        Dim result As Integer = 0

        Dim lista As New List(Of BE.ShowReporte)

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("BUSCAR_FECHAS_ASIGNADAS_SP")
            repository.addParam("@idShow", show.identificador)
            result = repository.executeSearch
            If (result > 0) Then
                Throw New Excepciones.ShowTieneFechasAsociadosExcepcion
            End If

        Catch ex As Excepciones.ShowTieneFechasAsociadosExcepcion
            Throw New Excepciones.ShowTieneFechasAsociadosExcepcion
        End Try

        Return result
    End Function

    Shared Function checkSectoresAsociadasFecha(ByVal fecha As BE.FechaBE)
        Dim result As Integer = 0

        Dim lista As New List(Of BE.ShowReporte)

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("BUSCAR_SECTORES_ASIGNADOS_SP")
            repository.addParam("@idShow", fecha.identificador)
            result = repository.executeSearch
            If (result > 0) Then
                Throw New Excepciones.FechaTieneSectoresAsociadasExcepcion
            End If

        Catch ex As Excepciones.FechaTieneSectoresAsociadasExcepcion
            Throw New Excepciones.FechaTieneSectoresAsociadasExcepcion
        End Try

        Return result
    End Function

End Class
