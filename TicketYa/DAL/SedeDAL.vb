Public Class SedeDAL

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
            Else
                Throw New Excepciones.SedeEliminadaExistosamenteExcepcion
            End If
        Catch ex As Excepciones.EliminarSedeExcepcion
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
        Catch ex As Excepciones.SedeTieneShowsAsociadosExcepcion
            Throw New Excepciones.SedeTieneShowsAsociadosExcepcion
        End Try

        Return result
    End Function

    Shared Function altaSede(ByVal nombre As String, ByVal capacidad As String, ByVal direccion As String, ByVal numero As String, ByVal telefono As String) As Boolean
        Dim result As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("GENERAR_SEDE_SP")
            repository.addParam("@nom", nombre)
            repository.addParam("@capacidad", capacidad)
            repository.addParam("@dir", direccion)
            repository.addParam("@num", numero)
            repository.addParam("@tel", telefono)
            result = repository.executeSearchWithStatus
            If (result <= 0) Then
                Throw New Excepciones.GenerarSedeExcepcion
            Else
                Throw New Excepciones.SedeCreadaExistosamenteExcepcion
            End If
        Catch ex As Excepciones.GenerarSedeExcepcion
            Throw New Excepciones.GenerarSedeExcepcion
        End Try

        Return result
    End Function

    Shared Function modificarSede(ByVal identificador As Integer,
                                  ByVal nombre As String,
                                  ByVal capacidad As String,
                                  ByVal direccion As String,
                                  ByVal numero As String,
                                  ByVal telefono As String) As Object
        Dim result As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("MODIFICAR_SEDE_SP")
            repository.addParam("@idSede", identificador)
            repository.addParam("@nom", nombre)
            repository.addParam("@capacidad", capacidad)
            repository.addParam("@dir", direccion)
            repository.addParam("@num", numero)
            repository.addParam("@tel", telefono)
            result = repository.executeSearchWithStatus
            If (result <= 0) Then
                Throw New Excepciones.ModificarSedeExcepcion
            Else
                Throw New Excepciones.SedeModificadaExistosamenteExcepcion
            End If
        Catch ex As Excepciones.ModificarSedeExcepcion
            Throw New Excepciones.ModificarSedeExcepcion
        End Try

        Return result
    End Function

End Class
