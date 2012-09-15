Public Class UsuarioNoEncontradoExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("Usuario No encontrado")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.UsuarioNoEncontrado
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = "Usuario No encontrado"
    End Sub
End Class
