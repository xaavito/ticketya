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

Public Class FamiliaCreadaExistosamenteExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("Familia No encontrada")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.FamiliasCreadaExitosamente
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = "Familia No encontrada"
    End Sub

End Class

Public Class FamiliaEliminadaExitosamenteExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("Familia No encontrada")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.FamiliasEliminadaExitosamente
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = "Familia No encontrada"
    End Sub

End Class

Public Class FamiliaTieneUsuariosAsociadosExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("Familia No encontrada")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.FamiliaTieneUsuariosAsociados
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = "Familia No encontrada"
    End Sub

End Class

Public Class FamiliaModificadaExitosamenteExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("Familia No encontrada")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.FamiliaModificadaExitosamente
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = "Familia No encontrada"
    End Sub

End Class
