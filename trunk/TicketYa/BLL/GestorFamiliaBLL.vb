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

End Class