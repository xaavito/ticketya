﻿Public Class GestorIdiomaBLL

    Public Shared Function crearIdioma(ByVal desc As String) As Boolean
        Return Nothing
    End Function

    Public Shared Function eliminarIdioma(ByVal idioma As BE.IdiomaBE) As Boolean
        Return Nothing
    End Function

    Public Shared Function listarIdiomas(ByVal desc As String) As List(Of BE.IdiomaBE)
        Dim listaIdiomas As List(Of BE.IdiomaBE)
        listaIdiomas = DAL.IdiomaDAL.listarIdiomas(desc)

        For Each idioma As BE.IdiomaBE In listaIdiomas
            idioma.mensaje = DAL.MensajeDAL.buscarMensajes(idioma.identificador)
            idioma.listaExcepciones = BLL.ExcepcionBLL.buscarExcepciones(idioma.identificador)
            idioma.bitacorasBase = BLL.BitacoraBLL.getBitacoras(idioma.identificador)
        Next

        Return listaIdiomas

    End Function

    Public Shared Function modificarIdioma(ByVal desc As String,
                                           ByVal idioma As BE.IdiomaBE) As Boolean
        Return Nothing
    End Function

    Public Shared Function buscarIdioma(ByVal usr As BE.UsuarioBE) As BE.IdiomaBE
        Return DAL.IdiomaDAL.buscarIdioma(usr.idioma.identificador)
    End Function

    Public Shared Function generarIdioma(ByVal p1 As Integer,
                                         ByVal p2 As String) As Integer
        Return DAL.IdiomaDAL.generarIdioma(p1, p2)
    End Function

End Class
