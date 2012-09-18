Public Class GestorFamiliaBLL

    Public Function crearFamilia(ByVal desc As String) As Boolean
        Return Nothing
    End Function

    Public Function eliminarFamilia(ByVal fam As BE.FamiliaBE) As Boolean
        Return Nothing
    End Function

    Public Function getPermisoFamilia(ByVal fam As BE.FamiliaBE) As List(Of BE.PermisoBE)
        Return Nothing
    End Function

    Public Shared Function listarFamilias() As List(Of BE.FamiliaBE)
        Return DAL.FamiliaDAL.listarFamilias()
    End Function

    Public Function modificarFamilia(ByVal fam As BE.FamiliaBE,
                                     ByVal desc As String) As Boolean
        Return Nothing
    End Function

    Shared Function buscarFamilia(ByVal p1 As String) As Object
        Return DAL.FamiliaDAL.buscarFamilias(p1)
    End Function

    Shared Function buscarFamilias(ByVal p1 As Integer) As List(Of BE.FamiliaBE)
        Return DAL.FamiliaDAL.buscarFamilias(p1)
    End Function

    Shared Function altaFamilia(ByVal p1 As String) As Integer
        Return DAL.FamiliaDAL.altaFamilia(p1)
    End Function

End Class