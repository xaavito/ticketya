Public Class VentasNoEncontradasExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.VentasNoEncontradas
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = ""
    End Sub
End Class

Public Class VentaCreadaExistosamenteExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.VentaCreadaExistosamente
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = ""
    End Sub
End Class