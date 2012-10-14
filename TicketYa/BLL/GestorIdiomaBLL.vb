Public Class GestorIdiomaBLL

    Public Shared Function crearIdioma(ByVal desc As String) As Boolean
        Return Nothing
    End Function

    Public Shared Function eliminarIdioma(ByVal idioma As BE.IdiomaBE) As Integer

        For Each bit As BE.MensajeBitacoraBE In idioma.bitacorasBase
            DAL.BitacoraDAL.eliminarBitacora(bit, idioma.identificador)
            'TODO: Generar

        Next
        For Each exc As BE.ExcepcionBE In idioma.listaExcepciones
            DAL.ExcepcionDAL.eliminarExcepecion(exc, idioma.identificador)
        Next
        For Each men As BE.MensajeControlBE In idioma.mensaje
            DAL.MensajeControlDAL.eliminarMensaje(men, idioma.identificador)
        Next
        Return DAL.IdiomaDAL.eliminarIdioma(idioma.identificador)

    End Function

    Public Shared Function listarIdiomas(ByVal desc As String) As List(Of BE.IdiomaBE)
        Dim listaIdiomas As List(Of BE.IdiomaBE)
        listaIdiomas = DAL.IdiomaDAL.listarIdiomas(desc)

        For Each idioma As BE.IdiomaBE In listaIdiomas
            idioma.mensaje = DAL.MensajeDAL.buscarMensajes(idioma.identificador)
            idioma.listaExcepciones = BLL.ExcepcionBLL.buscarExcepciones(idioma.identificador)
            idioma.bitacorasBase = BLL.BitacoraBLL.getBitacorasBase(idioma.identificador)
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

    Shared Function buscarIdioma(ByVal idiomaId As Integer) As BE.IdiomaBE
        Return DAL.IdiomaDAL.buscarIdioma(idiomaId)
    End Function

    Shared Function clonarIdioma(ByVal idiomaBase As BE.IdiomaBE) As BE.IdiomaBE
        Return idiomaBase.clonar()
    End Function

    Shared Function guardarIdioma(ByVal idioma As BE.IdiomaBE) As Integer
        Dim newIdiomaId As Integer = DAL.IdiomaDAL.guardarIdioma(idioma)

        If newIdiomaId > 0 Then
            For Each bit As BE.MensajeBitacoraBE In idioma.bitacorasBase
                DAL.BitacoraDAL.guardarBitacora(bit, newIdiomaId)
            Next
            For Each exc As BE.ExcepcionBE In idioma.listaExcepciones
                DAL.ExcepcionDAL.guardarExcepecion(exc, newIdiomaId)
            Next
            For Each men As BE.MensajeControlBE In idioma.mensaje
                DAL.MensajeControlDAL.guardarMensaje(men, newIdiomaId)
            Next
        End If

        Return newIdiomaId
    End Function

    Shared Function modificarIdioma(ByVal idioma As BE.IdiomaBE) As Boolean
        Dim newIdiomaId As Integer = DAL.IdiomaDAL.modificarIdioma(idioma)

        If newIdiomaId > 0 Then
            For Each bit As BE.MensajeBitacoraBE In idioma.bitacorasBase
                DAL.BitacoraDAL.modificarBitacora(bit, newIdiomaId)
            Next
            For Each exc As BE.ExcepcionBE In idioma.listaExcepciones
                DAL.ExcepcionDAL.modificarExcepecion(exc, newIdiomaId)
            Next
            For Each men As BE.MensajeControlBE In idioma.mensaje
                DAL.MensajeControlDAL.modificarMensaje(men, newIdiomaId)
            Next
        End If

        Return newIdiomaId
    End Function

End Class
