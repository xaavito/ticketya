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
                usuario.identificador = pepe.Item(0)
                usuario.nombre = pepe.Item(1)
                usuario.apellido = pepe.Item(2)
                usuario.usuario = usr
                usuario.password = pass
                Dim idioma As New BE.IdiomaBE
                idioma.identificador = pepe.Item(3)
                usuario.idioma = idioma
                Return usuario
            Next

        Catch ex As Exception
            Throw New Excepciones.UsuarioNoEncontradoExcepcion
        End Try

        Return Nothing
    End Function

    Public Shared Function listarUsuarios()
        Dim table As DataTable

        Dim lista As New List(Of BE.UsuarioBE)

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("LISTAR_USUARIOS_SP")

            table = New DataTable
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <> 1) Then
                Throw New Excepciones.UsuariosNoEncontradosExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim usuario As New BE.UsuarioBE
                usuario.identificador = pepe.Item(0)
                usuario.nombre = pepe.Item(1)

                lista.Add(usuario)
            Next

        Catch ex As Exception
            Throw New Excepciones.UsuariosNoEncontradosExcepcion
        End Try

        Return lista
    End Function

    Shared Function buscarUsuario(ByVal usr As String) As List(Of BE.UsuarioBE)
        Dim table As DataTable
        Dim listaUsuarios As New List(Of BE.UsuarioBE)
        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("BUSCAR_USUARIO_SP")
            repository.addParam("@usr", usr)
            table = New DataTable
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.UsuariosNoEncontradosExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim usuario As New BE.UsuarioBE
                usuario.identificador = pepe.Item(0)
                usuario.nombre = pepe.Item(1)
                usuario.apellido = pepe.Item(2)
                usuario.usuario = pepe.Item(3)
                listaUsuarios.add(usuario)
            Next

        Catch ex As Exception
            Throw New Excepciones.UsuariosNoEncontradosExcepcion
        End Try

        Return listaUsuarios
    End Function

    Shared Function altaUsuario(ByVal p1 As String, ByVal p2 As String, ByVal p3 As String, ByVal p4 As String, ByVal idiomaBE As BE.IdiomaBE, ByVal list As List(Of BE.FamiliaBE)) As Integer
        Dim result As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            repository.crearComando("INSERTAR_USUARIO_SP")
            'repository.transactionON()
            repository.addParam("@usr", p1)
            repository.addParam("@pass", p2)
            repository.addParam("@nom", p3)
            repository.addParam("@ape", p4)
            repository.addParam("@idioma", idiomaBE.identificador)

            result = repository.executeSearchWithReturnValue
            If (result <= 0) Then
                Throw New Excepciones.InsertExcepcion
            End If

            If (list.Count > 0) Then
                repository.crearComando("INSERTAR_USUARIO_FAMILIA_SP")
                For Each fam As BE.FamiliaBE In list
                    repository.addParam("@idUsuario", result)
                    repository.addParam("@idFamilia", fam.identificador)
                    result = repository.executeSearchWithStatus
                    If (result <= 0) Then
                        Throw New Excepciones.InsertExcepcion
                    End If
                Next
            End If
            'repository.transactionOK()

        Catch ex As Exception
            Throw New Excepciones.InsertExcepcion
        End Try

        Return result
    End Function

End Class
