Public Class GestorUsuarioBLL

    Public Shared Function buscarUsuario(ByVal usr As String, ByVal pass As String) As BE.UsuarioBE
        Dim usuario As New BE.UsuarioBE
        usuario.nombre = "Pepe"

        Dim idioma As New BE.IdiomaBE
        idioma.identificador = 1
        idioma.descripcion = "Español"

        usuario.idioma = idioma

        Dim listaPermisos As New List(Of BE.PermisoBE)
        Dim permiso As New BE.PermisoBE
        permiso.identificador = 1
        permiso.descripcion = "Buscar_Bitacora"

        listaPermisos.Add(permiso)

        usuario.permisos = listaPermisos

        Dim listaFamilia As New List(Of BE.FamiliaBE)
        Dim familia As New BE.FamiliaBE
        familia.descripcion = "Administrador"
        Dim permisoFamilia As New BE.PermisoBE
        permiso.descripcion = "Bitacora"
        familia.permisos.Add(permiso)
        listaFamilia.Add(familia)

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

    Public Function crearUsuario(ByVal usr As String,
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