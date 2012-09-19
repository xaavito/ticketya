Public Class GestorPermisoBLL

    Public Function borrarPermiso(ByVal desc As BE.PermisoBE) As Boolean
        Return Nothing
    End Function

    Public Function buscarFamilia(ByVal desc As String) As List(Of BE.PermisoBE)
        Return Nothing
    End Function

    Public Function crearPermiso(ByVal desc As String) As Boolean
        Return Nothing
    End Function

    Public Function modificarFamilia(ByVal desc As String,
                                     ByVal perm As BE.PermisoBE) As Boolean
        Return Nothing
    End Function

    Shared Function listarPermisos() As List(Of BE.PermisoBE)
        Return DAL.PermisoDAL.listarPermisos()
    End Function

    Shared Function buscarPermisoFamilia(ByVal p1 As Integer) As List(Of BE.PermisoBE)
        Return DAL.PermisoDAL.buscarPermisoFamilia(p1)
    End Function

    Shared Function altaPermisoFamilia(ByVal list As List(Of BE.PermisoBE)) As Boolean
        Throw New NotImplementedException
    End Function

    Shared Function buscarPermisoUsuario(ByVal p1 As Integer) As List(Of BE.PermisoBE)
        Throw New NotImplementedException
    End Function


End Class
