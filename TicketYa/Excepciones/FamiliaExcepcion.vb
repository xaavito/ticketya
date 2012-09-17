Public Class FamiliaNoEncontradaExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("Familia No encontrada")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.FamiliaNoEncontrada
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = "Familia No encontrada"
    End Sub


End Class

Public Class FamiliasNoEncontradasExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("Familia No encontrada")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.FamiliasNoEncontradas
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = "Familia No encontrada"
    End Sub

End Class