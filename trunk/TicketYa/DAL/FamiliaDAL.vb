Public Class FamiliaDAL

    Shared Function buscarFamilias(ByVal p1 As Integer) As List(Of BE.FamiliaBE)
        Dim table As DataTable

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Dim familias As New List(Of BE.FamiliaBE)
        Try
            repository.crearComando("BUSCAR_FAMILIAS_SP")
            table = New DataTable
            repository.addParam("@idUsuario", p1)
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.FamiliaNoEncontradaExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim familia As New BE.FamiliaBE
                familia.identificador = pepe.Item(0)
                familia.descripcion = pepe.Item(1)
                familias.Add(familia)
            Next

        Catch ex As Exception
            Throw New Excepciones.FamiliaNoEncontradaExcepcion
        End Try

        Return familias
    End Function

    Shared Function buscarFamilias(ByVal p1 As String) As List(Of BE.FamiliaBE)
        Dim table As DataTable

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Dim familias As New List(Of BE.FamiliaBE)
        Try
            repository.crearComando("BUSCAR_FAMILIAS_DESC_SP")
            table = New DataTable
            repository.addParam("@descripcion", p1)
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.FamiliaNoEncontradaExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim familia As New BE.FamiliaBE
                familia.identificador = pepe.Item(0)
                familia.descripcion = pepe.Item(1)
                familias.Add(familia)
            Next

        Catch ex As Exception
            Throw New Excepciones.FamiliaNoEncontradaExcepcion
        End Try

        Return familias
    End Function

    Shared Function listarFamilias() As List(Of BE.FamiliaBE)
        Dim table As DataTable

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Dim familias As New List(Of BE.FamiliaBE)
        Try
            repository.crearComando("LISTAR_FAMILIAS_SP")
            table = New DataTable
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.FamiliasNoEncontradasExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim familia As New BE.FamiliaBE
                familia.identificador = pepe.Item(0)
                familia.descripcion = pepe.Item(1)
                familias.Add(familia)
            Next

        Catch ex As Exception
            Throw New Excepciones.FamiliasNoEncontradasExcepcion
        End Try

        Return familias
    End Function

    Shared Function altaFamilia(ByVal p1 As String) As Boolean
        Dim result As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("INSERTAR_FAMILIA_SP")
            'repository.transactionON()
            repository.addParam("@descripcion", p1)

            result = repository.executeSearchWithStatus
            If (result <= 0) Then
                Throw New Excepciones.InsertExcepcion
            End If

        Catch ex As Exception
            Throw New Excepciones.InsertExcepcion
        End Try

        Return result
    End Function

    Shared Function modificarFamilia(ByVal fam As Integer, ByVal desc As String) As Integer
        Dim result As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("MODIFICAR_FAMILIA_SP")
            repository.addParam("@descripcion", desc)
            repository.addParam("@idFamilia", fam)

            result = repository.executeSearchWithStatus
            If (result <= 0) Then
                Throw New Excepciones.InsertExcepcion
            End If

        Catch ex As Exception
            Throw New Excepciones.InsertExcepcion
        End Try

        Return result
    End Function

    Shared Function eliminarFamilia(ByVal fam As BE.FamiliaBE) As Boolean
        Dim result As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("CHECK_FAMILIA_ASOCIACION_SP")
            repository.addParam("@idFamilia", fam.identificador)

            result = repository.executeSearch
            If (result <= 0) Then
                repository.crearComando("ELIMINAR_FAMILIA_SP")
                repository.addParam("@idFamilia", fam.identificador)

                result = repository.executeSearchWithStatus
                If (result <= 0) Then
                    Throw New Excepciones.InsertExcepcion
                End If
            End If

        Catch ex As Exception
            Throw New Excepciones.InsertExcepcion
        End Try

        Return result
    End Function

End Class
