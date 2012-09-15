Public Class PermisoDAL

    Shared Function buscarPermisoPersona(ByVal p1 As Integer) As List(Of BE.PermisoBE)
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

End Class
