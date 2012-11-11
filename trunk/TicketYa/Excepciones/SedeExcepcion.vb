Public Class SedeTieneShowsAsociadosExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.SedeTieneShowsAsociados
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = ""
    End Sub
End Class

Public Class SedeEliminadaExistosamenteExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.SedeEliminadaExitosamente
        Me.tipo = MsgBoxStyle.Information
        Me.mensaje = ""
    End Sub
End Class


Public Class SedesNoEncontradasExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.SedesNoEncontradas
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = ""
    End Sub
End Class

Public Class EliminarSedeExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.EliminarSedeExcepcion
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = ""
    End Sub
End Class