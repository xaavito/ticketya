Public Class GestorUsuarioBLL

    Shared Function modificarUsuario(ByVal id As Integer,
                                     ByVal usr As String,
                                     ByVal pass As String,
                                     ByVal nom As String,
                                     ByVal ape As String,
                                     ByVal act As Integer,
                                     ByVal idiomaBE As BE.IdiomaBE,
                                     ByVal list As List(Of BE.FamiliaBE)) As Integer
        Return DAL.UsuarioDAL.modificarUsuario(id, usr, Utilitarios.Encrypter.EncryptPasswordMD5(pass), nom, ape, act, idiomaBE.identificador, list)
    End Function

    Public Shared Function buscarUsuario(ByVal usr As String, ByVal pass As String) As BE.UsuarioBE
        Dim usuario As BE.UsuarioBE
        usuario = DAL.UsuarioDAL.buscarUsuario(usr, pass)

        Dim idioma As BE.IdiomaBE
        idioma = DAL.IdiomaDAL.buscarIdioma(usuario.idioma.identificador)

        usuario.idioma = idioma

        Dim listaPermisos As List(Of BE.PermisoBE)
        listaPermisos = DAL.PermisoDAL.buscarPermisoPersona(usuario.identificador)

        usuario.permisos = listaPermisos

        Dim listaFamilia As List(Of BE.FamiliaBE)


        listaFamilia = DAL.FamiliaDAL.buscarFamilias(usuario.identificador)

        For Each familia As BE.FamiliaBE In listaFamilia
            familia.permisos = DAL.PermisoDAL.buscarPermisoFamilia(familia.identificador)
        Next

        usuario.familias = listaFamilia

        Return usuario
    End Function

    Public Shared Function buscarUsuario(ByVal usr As String) As List(Of BE.UsuarioBE)
        Return DAL.UsuarioDAL.buscarUsuario(usr)
    End Function

    Public Function crearUsuario(ByVal usr As String,
                                 ByVal pass As String,
                                 ByVal nom As String,
                                 ByVal ape As String,
                                 ByVal mail As String,
                                 ByVal dni As Long) As BE.UsuarioBE
        Return Nothing
    End Function

    Public Shared Function eliminarUsuario(ByVal usr As BE.UsuarioBE) As Integer
        Return DAL.UsuarioDAL.eliminarUsuario(usr.identificador)
    End Function

    Public Function getPermisoUsuario(ByVal usr As BE.UsuarioBE) As List(Of BE.PermisoBE)
        Return Nothing
    End Function

    Public Function obtenerEstadoUsuario(ByVal usr As BE.UsuarioBE) As Integer
        Return Nothing
    End Function

    Shared Function listarUsuarios() As List(Of BE.UsuarioBE)
        Return DAL.UsuarioDAL.listarUsuarios()
    End Function

    Shared Function altaUsuario(ByVal p1 As String, ByVal p2 As String, ByVal p3 As String, ByVal p4 As String, ByVal idiomaBE As BE.IdiomaBE, ByVal list As List(Of BE.FamiliaBE))
        Return DAL.UsuarioDAL.altaUsuario(p1, Utilitarios.Encrypter.EncryptPasswordMD5(p2), p3, p4, idiomaBE, list)
    End Function

End Class