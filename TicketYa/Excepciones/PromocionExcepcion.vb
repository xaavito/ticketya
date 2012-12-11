Public Class PromocionTieneVentasAsociadasExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.PromocionTieneVentasAsignadas
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = ""
    End Sub
End Class

Public Class PromocionEliminadaExistosamenteExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.PromocionEliminadaExitosamente
        Me.tipo = MsgBoxStyle.Information
        Me.mensaje = ""
    End Sub
End Class

Public Class PromocionNoGeneradaExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.PromocionNoGeneradaExcepcion
        Me.tipo = MsgBoxStyle.Information
        Me.mensaje = ""
    End Sub
End Class



Public Class PromocionesNoEncontradasExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.PromocionNoEncontradaExcepcion
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = ""
    End Sub
End Class

Public Class GenerarPromocionExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.GenerarPromocionExcepcion
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = ""
    End Sub
End Class

Public Class PromocionCreadaExistosamenteExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.PromocionCreadaExistosamenteExcepcion
        Me.tipo = MsgBoxStyle.Information
        Me.mensaje = ""
    End Sub
End Class

Public Class EliminarShowExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.EliminarShowExcepcion
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = ""
    End Sub
End Class