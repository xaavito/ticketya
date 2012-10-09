Public Class IdiomaDAL
    Public Shared Function listarIdiomas(ByVal nombre As String) As List(Of BE.IdiomaBE)
        Dim table As DataTable

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Dim listaIdiomas As New List(Of BE.IdiomaBE)
        Try
            repository.crearComando("LISTAR_IDIOMAS_SP")
            repository.addParam("@nom", nombre)
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

    Shared Function buscarIdioma(ByVal p1 As Integer) As BE.IdiomaBE
        Dim table As DataTable

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Dim idioma As New BE.IdiomaBE
        Try
            repository.crearComando("BUSCAR_IDIOMA_SP")
            table = New DataTable
            repository.addParam("@idIdioma", p1)
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.IdiomaNoEncontradoExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                idioma.identificador = pepe.Item(0)
                idioma.descripcion = pepe.Item(1)
            Next

        Catch ex As Exception
            Throw New Excepciones.IdiomaNoEncontradoExcepcion
        End Try

        Return idioma
    End Function

    Public Shared Function generarIdioma(ByVal p1 As Integer,
                                         ByVal p2 As String) As Integer
        Dim result As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("GENERAR_IDIOMA_SP")
            repository.addParam("@nom", p2)
            repository.addParam("@base", p1)
            result = repository.executeSearchWithStatus()
            If (result <= 0) Then
                Throw New Excepciones.GeneracionDeIdiomaExcepcion
            End If
        Catch ex As Exception
            Throw New Excepciones.GeneracionDeIdiomaExcepcion
        End Try

        Return result
    End Function

End Class
