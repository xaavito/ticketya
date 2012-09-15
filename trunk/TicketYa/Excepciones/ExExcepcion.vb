Public Class ExcepcionNoEncontradaExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("Excepcion no encontrada")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.MensajeExcepcion
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = "Excepcion no encontrada"
    End Sub
End Class
