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

        Dim listaMensajes As New List(Of BE.MensajeControlBE)

        Dim mensaje As New BE.MensajeControlBE
        mensaje.formulario = "Login"
        mensaje.control = "AceptarButton"
        mensaje.mensaje = "Accept"
        listaMensajes.Add(mensaje)

        Dim mensaje1 As New BE.MensajeControlBE
        mensaje1.formulario = "Login"
        mensaje1.control = "CancelarButton"
        mensaje1.mensaje = "Cancel"
        listaMensajes.Add(mensaje1)

        Dim mensaje4 As New BE.MensajeControlBE
        mensaje4.formulario = "Login"
        mensaje4.control = "UsuarioLabel"
        mensaje4.mensaje = "User"
        listaMensajes.Add(mensaje4)

        Dim mensaje5 As New BE.MensajeControlBE
        mensaje5.formulario = "Login"
        mensaje5.control = "PassLabel"
        mensaje5.mensaje = "Password"
        listaMensajes.Add(mensaje5)

        Dim mensaje6 As New BE.MensajeControlBE
        mensaje6.formulario = "Login"
        mensaje6.control = "CambiarIdiomaLabel"
        mensaje6.mensaje = "Change Language"
        listaMensajes.Add(mensaje6)

        idioma2.mensaje = listaMensajes

        Dim listaMensajes2 As New List(Of BE.MensajeControlBE)

        Dim mensaje2 As New BE.MensajeControlBE
        mensaje2.formulario = "Login"
        mensaje2.control = "AceptarButton"
        mensaje2.mensaje = "Aceptar"
        listaMensajes2.Add(mensaje2)

        Dim mensaje3 As New BE.MensajeControlBE
        mensaje3.formulario = "Login"
        mensaje3.control = "CancelarButton"
        mensaje3.mensaje = "Cancelar"
        listaMensajes2.Add(mensaje3)

        idioma1.mensaje = listaMensajes2

        listaIdiomas.Add(idioma1)
        listaIdiomas.Add(idioma2)

        Return listaIdiomas

    End Function

    Public Shared Function modificarIdioma(ByVal desc As String,
                                           ByVal idioma As BE.IdiomaBE) As Boolean
        Return Nothing
    End Function
End Class
