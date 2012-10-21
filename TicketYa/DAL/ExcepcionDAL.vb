Public Class ExcepcionDAL

    Shared Function buscarExcepcion(ByVal idIdioma As Integer, ByVal codigoExcepcion As Integer) As String
        Dim table As DataTable
        Dim excep As String = ""

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("BUSCAR_EXCEPCION_SP")
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

    Shared Function buscarExcepciones(ByVal idioma As Integer) As List(Of BE.ExcepcionBE)
        Dim table As DataTable
        Dim excep As BE.ExcepcionBE
        Dim listExcep As New List(Of BE.ExcepcionBE)

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("BUSCAR_EXCEPCIONES_SP")
            table = New DataTable
            repository.addParam("@idIdioma", idioma)
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.ExcepcionNoEncontradaExcepcion
            End If
            For Each row As DataRow In table.Rows
                excep = New BE.ExcepcionBE
                excep.codigo = row.Item(0)
                excep.mensaje = row.Item(1)
                listExcep.Add(excep)
            Next

        Catch ex As Exception
            Throw New Excepciones.ExcepcionNoEncontradaExcepcion
        End Try

        Return listExcep
    End Function

    Shared Function guardarExcepecion(ByVal exc As BE.ExcepcionBE, ByVal newIdiomaId As Integer) As Integer
        Dim result As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Dim bitacoras As New List(Of BE.BitacoraBE)
        Try
            repository.crearComando("GUARDAR_EXCEPCIONES_SP")
            repository.addParam("@idIdioma", newIdiomaId)
            repository.addParam("@excBase", exc.codigo)
            repository.addParam("@excMensaje", exc.mensaje)
            result = repository.executeSearchWithStatus()
            If (result <= 0) Then
                Throw New Excepciones.InsertExcepcion
            End If

        Catch ex As Exception
            Throw New Excepciones.InsertExcepcion
        End Try

        Return result
    End Function

    Shared Function eliminarExcepecion(ByVal exc As BE.ExcepcionBE, ByVal p2 As Integer)
        Dim result As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("ELIMINAR_EXCEPCION_SP")
            repository.addParam("@idIdioma", p2)
            repository.addParam("@idExcBase", exc.codigo)
            result = repository.executeSearchWithStatus
            If (result <= 0) Then
                Throw New Excepciones.EliminarExcepcionExcepcion
            End If
        Catch ex As Exception
            Throw New Excepciones.EliminarExcepcionExcepcion
        End Try

        Return result
    End Function

    Shared Function modificarExcepecion(ByVal exc As BE.ExcepcionBE, ByVal newIdiomaId As Integer) As Integer
        Dim result As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("MODIFICAR_EXCEPCION_SP")
            repository.addParam("@idIdioma", newIdiomaId)
            repository.addParam("@idExcBase", exc.codigo)
            repository.addParam("@excMensaje", exc.mensaje)
            result = repository.executeSearchWithStatus
            If (result <= 0) Then
                Throw New Excepciones.ModificacionDeExcepcionExcepcion
            End If
        Catch ex As Exception
            Throw New Excepciones.ModificacionDeExcepcionExcepcion
        End Try

        Return result
    End Function

End Class
