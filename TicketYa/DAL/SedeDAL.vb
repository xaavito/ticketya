﻿Public Class SedeDAL

    Shared Function buscarSede(ByVal p1 As String) As Object
        Dim table As DataTable

        Dim lista As New List(Of BE.SedeBE)

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("LISTAR_SEDES_SP")
            repository.addParam("@desc", p1)
            table = New DataTable
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.SedesNoEncontradasExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim sede As New BE.SedeBE
                'SELECT s.identificador,s.descripcion,s.capacidad,s.direccion,s.numero,s.telefono 
                sede.identificador = pepe.Item(0)
                sede.descripcion = pepe.Item(1)
                sede.capacidad = pepe.Item(2)
                sede.direccion = pepe.Item(3)
                sede.numero = pepe.Item(4)
                sede.telefono = pepe.Item(5)
                
                lista.Add(sede)
            Next

        Catch ex As Exception
            Throw New Excepciones.SedesNoEncontradasExcepcion
        End Try

        Return lista
    End Function

    Shared Function eliminarSede(ByVal p1 As Integer) As Integer
        Dim result As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("ELIMINAR_SEDE_SP")
            repository.addParam("@idSede", p1)
            result = repository.executeSearchWithStatus
            If (result <= 0) Then
                Throw New Excepciones.EliminarSedeExcepcion
            End If
        Catch ex As Exception
            Throw New Excepciones.EliminarSedeExcepcion
        End Try

        Return result
    End Function

    Shared Function checkVentasAsignadas(ByVal p1 As Integer) As Integer
        Dim result As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("CHEKEAR_SEDE_CON_SHOWS_SP")
            repository.addParam("@idSede", p1)
            result = repository.executeSearch
            If (result > 0) Then
                Throw New Excepciones.SedeTieneShowsAsociadosExcepcion
            End If
        Catch ex As Exception
            Throw New Excepciones.SedeTieneShowsAsociadosExcepcion
        End Try

        Return result
    End Function

End Class
