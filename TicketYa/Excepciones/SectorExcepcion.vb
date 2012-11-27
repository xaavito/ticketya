Public Class SectorTieneVentasAsociadasExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.SectorTieneVentasAsignadas
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = ""
    End Sub
End Class

Public Class SectorEliminadoExistosamenteExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.SectorEliminadoExitosamente
        Me.tipo = MsgBoxStyle.Information
        Me.mensaje = ""
    End Sub
End Class


Public Class SectoresNoEncontradosExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.SectoresNoEncontrados
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = ""
    End Sub
End Class

Public Class EliminarSectorExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.EliminarSectorExcepcion
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = ""
    End Sub
End Class

Public Class SectorCreadoExistosamenteExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.SectorCreadoExitosamenteExcepcion
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = ""
    End Sub
End Class

Public Class TipoSectorNoEncontradoExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.TipoSectorNoEncontradoExcepcion
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = ""
    End Sub
End Class

Public Class SectorNoEncontradoExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.SectorNoEncontradoExcepcion
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = ""
    End Sub
End Class