Public Class FechaTieneVentasAsociadasExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.FechaTieneVentasAsignadas
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = ""
    End Sub
End Class

Public Class FechaEliminadaExistosamenteExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.FechaEliminadaExitosamente
        Me.tipo = MsgBoxStyle.Information
        Me.mensaje = ""
    End Sub
End Class


Public Class FechasNoEncontradasExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.FechasNoEncontradas
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = ""
    End Sub
End Class

Public Class EliminarFechaExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.EliminarFechaExcepcion
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = ""
    End Sub
End Class

Public Class FechaCreadaExistosamenteExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.FechaCreadaExcepcion
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = ""
    End Sub
End Class

Public Class GenerarFechaExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.GenerarFechaExcepcion
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = ""
    End Sub
End Class

Public Class FechaModificadaExistosamenteExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.FechaModificadaExistosamenteExcepcion
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = ""
    End Sub
End Class


Public Class ModificarFechaExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.ModificarFechaExcepcion
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = ""
    End Sub
End Class

Public Class FechaTieneSectoresAsociadasExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.FechaTieneSectoresAsociadasExcepcion
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = ""
    End Sub
End Class

