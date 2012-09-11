Public Class UsuarioDAL
    'Dim repo As RepositorioFactory
    Public Shared Function buscarUsuario(ByVal usr As String,
                                         ByVal pass As String) As BE.UsuarioBE

        Dim table As DataTable

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("LOGIN_SP")
            repository.addParam("@usr", usr)
            repository.addParam("@pass", pass)
            table = New DataTable
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <> 1) Then
                Throw New Excepciones.UsuarioNoEncontradoExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim usuario As New BE.UsuarioBE
                usuario.nombre = pepe.Item(0)
                usuario.apellido = pepe.Item(1)
                usuario.usuario = usr
                usuario.password = pass
                Return usuario
            Next

        Catch ex As Exception
            Throw New Excepciones.UsuarioNoEncontradoExcepcion
        End Try

        Return Nothing
    End Function

End Class
