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

End Class