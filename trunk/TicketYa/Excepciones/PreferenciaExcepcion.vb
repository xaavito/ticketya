Public Class PreferenciasNoEncontradasExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("Conexion a la BD de datos no lograda!")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.PreferenciasNoEncontradas
        Me.tipo = MsgBoxStyle.Information
        Me.mensaje = "Conexion a la BD de datos no lograda!"
    End Sub
End Class

Public Class GeneracionPreferenciasExitosaExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("Conexion a la BD de datos no lograda!")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.PreferenciasNoEncontradas
        Me.tipo = MsgBoxStyle.Information
        Me.mensaje = "Conexion a la BD de datos no lograda!"
    End Sub
End Class

Public Class FalloGeneracionPreferenciasExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("Conexion a la BD de datos no lograda!")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.PreferenciasNoEncontradas
        Me.tipo = MsgBoxStyle.Information
        Me.mensaje = "Conexion a la BD de datos no lograda!"
    End Sub
End Class




