Public Class GestorUsuarioBLL

    Public Shared Function buscarUsuario(ByVal usr As String, ByVal pass As String) As BE.UsuarioBE
        Dim usuario As BE.UsuarioBE
        usuario = DAL.UsuarioDAL.buscarUsuario(usr, pass)
        
        Dim idioma As BE.IdiomaBE
        idioma = DAL.IdiomaDAL.buscarIdioma(usuario.idioma.identificador)

        usuario.idioma = idioma

        Dim listaPermisos As List(Of BE.PermisoBE)
        listaPermisos = DAL.PermisoDAL.buscarPermisoPersona(usuario.identificador)

        'Dim permiso As New BE.PermisoBE
        'permiso.identificador = 1
        'permiso.descripcion = "BuscarBitacora"

        'listaPermisos.Add(permiso)

        usuario.permisos = listaPermisos

        Dim listaFamilia As List(Of BE.FamiliaBE)

        listaFamilia = DAL.FamiliaDAL.buscarFamilias(usuario.identificador)

        For Each familia As BE.FamiliaBE In listaFamilia
            familia.permisos = DAL.PermisoDAL.buscarPermisoFamilia(familia.identificador)
        Next

        'Dim familia As New BE.FamiliaBE
        'familia.descripcion = "Administrador"
        'Dim listaPermisosFamilia As New List(Of BE.PermisoBE)
        'Dim permisoFamilia As New BE.PermisoBE
        'permisoFamilia.descripcion = "Bitacora"
        'listaPermisosFamilia.Add(permisoFamilia)
        'Dim permisoFamilia2 As New BE.PermisoBE
        'permisoFamilia2.descripcion = "Permisos"
        'listaPermisosFamilia.Add(permisoFamilia2)
        'familia.permisos = listaPermisosFamilia
        'listaFamilia.Add(familia)

        usuario.familias = listaFamilia

        Return usuario
    End Function

    Public Function crearUsuario(ByVal usr As String,
                                 ByVal pass As String,
                                 ByVal nom As String,
                                 ByVal ape As String,
                                 ByVal mail As String,
                                 ByVal dni As Long) As BE.UsuarioBE
        Return Nothing
    End Function

    Public Function eliminarUsuario(ByVal usr As BE.UsuarioBE) As Boolean
        Return Nothing
    End Function

    Public Function getPermisoUsuario(ByVal usr As BE.UsuarioBE) As List(Of BE.PermisoBE)
        Return Nothing
    End Function

    Public Function modificarUsuario(ByVal usr As String,
                                     ByVal pass As String,
                                     ByVal nom As String,
                                     ByVal ape As String,
                                     ByVal mail As String,
                                     ByVal dni As Long,
                                     ByVal usuario As BE.UsuarioBE) As Boolean
        Return Nothing
    End Function

    Public Function obtenerEstadoUsuario(ByVal usr As BE.UsuarioBE) As Integer
        Return Nothing
    End Function

End Class