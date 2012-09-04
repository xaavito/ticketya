Public Class GestorIdiomaBLL

    Public Shared Function crearIdioma(ByVal desc As String) As Boolean
        Return Nothing
    End Function

    Public Shared Function eliminarIdioma(ByVal idioma As BE.IdiomaBE) As Boolean
        Return Nothing
    End Function

    Public Shared Function listarIdiomas(ByVal desc As String) As List(Of BE.IdiomaBE)
        Dim listaIdiomas As New List(Of BE.IdiomaBE)
        Dim idioma1 As New BE.IdiomaBE
        idioma1.descripcion = "Español"
        idioma1.identificador = 1

        Dim idioma2 As New BE.IdiomaBE
        idioma2.descripcion = "Ingles"
        idioma2.identificador = 2

        listaIdiomas.Add(idioma1)
        listaIdiomas.Add(idioma2)
        Return listaIdiomas

    End Function

    Public Shared Function modificarIdioma(ByVal desc As String,
                                           ByVal idioma As BE.IdiomaBE) As Boolean
        Return Nothing
    End Function
End Class
