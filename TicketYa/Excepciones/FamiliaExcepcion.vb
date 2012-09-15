Public Class FamiliaNoEncontradaExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("Familia No encontrada")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.FamiliaNoEncontrada
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = "Familia No encontrada"
    End Sub
End Class
