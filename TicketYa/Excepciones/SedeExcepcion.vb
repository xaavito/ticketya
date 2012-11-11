Public Class SedeTieneShowsAsociadosExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("No hay Idiomas")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.SedeTieneShowsAsociados
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = "No hay Idiomas"
    End Sub
End Class

Public Class SedeEliminadaExistosamenteExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("No hay Idiomas")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.SedeEliminadaExitosamente
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = "No hay Idiomas"
    End Sub
End Class


Public Class SedesNoEncontradasExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("No hay Idiomas")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.SedeEliminadaExitosamente
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = "No hay Idiomas"
    End Sub
End Class