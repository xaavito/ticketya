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

End Class
