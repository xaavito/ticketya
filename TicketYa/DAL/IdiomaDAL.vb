Public Class IdiomaDAL
    Public Shared Function listarIdiomas() As List(Of BE.IdiomaBE)
        Dim table As DataTable

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Dim listaIdiomas As New List(Of BE.IdiomaBE)
        Try
            repository.crearComando("LISTAR_USUARIOS_SP")
            table = New DataTable
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.NoHayIdiomasExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim idioma As New BE.IdiomaBE
                idioma.identificador = pepe.Item(0)
                idioma.descripcion = pepe.Item(1)
                listaIdiomas.Add(idioma)
            Next

        Catch ex As Exception
            Throw New Excepciones.NoHayIdiomasExcepcion
        End Try

        Return listaIdiomas
    End Function
End Class
