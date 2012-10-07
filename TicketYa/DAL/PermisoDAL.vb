Public Class PermisoDAL


    Shared Function buscarPermisoFamilia(ByVal p1 As Integer) As List(Of BE.PermisoBE)
        Dim table As DataTable

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Dim permisos As New List(Of BE.PermisoBE)
        Try
            repository.crearComando("BUSCAR_PERMISO_FAMILIA_SP")
            table = New DataTable
            repository.addParam("@idFamilia", p1)
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.PermisoNoEncontradoExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim permiso As New BE.PermisoBE
                permiso.identificador = pepe.Item(0)
                permiso.descripcion = pepe.Item(1)
                permiso.componente = pepe.Item(2)
                permiso.formulario = pepe.Item(3)
                permisos.Add(permiso)
            Next

        Catch ex As Exception
            Throw New Excepciones.PermisoNoEncontradoExcepcion
        End Try

        Return permisos
    End Function

    Shared Function listarPermisos() As List(Of BE.PermisoBE)
        Dim table As DataTable

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Dim permisos As New List(Of BE.PermisoBE)
        Try
            repository.crearComando("LISTAR_PERMISOS_SP")
            table = New DataTable
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.PermisoNoEncontradoExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim permiso As New BE.PermisoBE
                permiso.identificador = pepe.Item(0)
                permiso.componente = pepe.Item(1)
                permiso.descripcion = pepe.Item(2)
                permisos.Add(permiso)
            Next

        Catch ex As Exception
            Throw New Excepciones.PermisoNoEncontradoExcepcion
        End Try

        Return permisos
    End Function

    Shared Function altaPermisoFamilia(ByVal fam As BE.FamiliaBE, ByVal list As List(Of BE.PermisoBE)) As Integer
        Dim resultado As Integer
        
        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            For Each perm As BE.PermisoBE In list
                repository.crearComando("INSERTAR_PERMISOS_FAMILIA_SP")
                repository.addParam("@idFamilia", fam.identificador)
                repository.addParam("@idPermiso", perm.identificador)
                resultado = repository.executeSearchWithStatus
                If (resultado <= 0) Then
                    Throw New Excepciones.InsertExcepcion
                End If
            Next
        Catch ex As Exception
            Throw New Excepciones.InsertExcepcion
        End Try

        Return resultado
    End Function

    Shared Function buscarPermisoUsuario(ByVal p1 As Integer) As List(Of BE.PermisoBE)
        Dim table As DataTable

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Dim permisos As New List(Of BE.PermisoBE)
        Try
            repository.crearComando("BUSCAR_PERMISO_PERSONA_SP")
            table = New DataTable
            repository.addParam("@idUsuario", p1)
            table = repository.executeSearchWithAdapter()
            If (table.Rows.Count <= 0) Then
                Throw New Excepciones.PermisoNoEncontradoExcepcion
            End If
            For Each pepe As DataRow In table.Rows
                Dim permiso As New BE.PermisoBE
                permiso.identificador = pepe.Item(0)
                permiso.descripcion = pepe.Item(1)
                permiso.componente = pepe.Item(2)
                permiso.formulario = pepe.Item(3)
                permisos.Add(permiso)
            Next

        Catch ex As Exception
            Throw New Excepciones.PermisoNoEncontradoExcepcion
        End Try

        Return permisos
    End Function

    Shared Function altaPermisoUsuario(ByVal usuarioBE As BE.UsuarioBE, ByVal list As List(Of BE.PermisoBE)) As Integer
        Dim resultado As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try
            For Each perm As BE.PermisoBE In list
                repository.crearComando("INSERTAR_PERMISOS_USUARIO_SP")
                repository.addParam("@idUsuario", usuarioBE.identificador)
                repository.addParam("@idPermiso", perm.identificador)
                resultado = repository.executeSearchWithStatus
                If (resultado <= 0) Then
                    Throw New Excepciones.InsertExcepcion
                End If
            Next
        Catch ex As Exception
            Throw New Excepciones.InsertExcepcion
        End Try

        Return resultado
    End Function

    Shared Function bajaPermisoUsuario(ByVal usuarioBE As BE.UsuarioBE) As Integer
        Dim resultado As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try

            repository.crearComando("ELIMINAR_PERMISOS_USUARIO_SP")
            repository.addParam("@idUsuario", usuarioBE.identificador)
            resultado = repository.executeSearchWithStatus
            If (resultado <= 0) Then
                Throw New Excepciones.DeleteExcepcion
            End If
        Catch ex As Exception
            Throw New Excepciones.DeleteExcepcion
        End Try

        Return resultado
    End Function

    Shared Function bajaPermisoFamilia(ByVal familia As BE.FamiliaBE) As Integer
        Dim resultado As Integer

        Dim repository As IRepositorio = RepositorioFactory.Create()
        Try

            repository.crearComando("ELIMINAR_PERMISOS_FAMILIA_SP")
            repository.addParam("@idFamilia", familia.identificador)
            resultado = repository.executeSearchWithStatus
            If (resultado <= 0) Then
                Throw New Excepciones.DeleteExcepcion
            End If
        Catch ex As Exception
            Throw New Excepciones.DeleteExcepcion
        End Try

        Return resultado
    End Function
End Class
