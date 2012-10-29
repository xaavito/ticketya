Public Class BackupsNoEncontrados
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("Conexion a la BD de datos no lograda!")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.BackupsNoEncontrados
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = "Conexion a la BD de datos no lograda!"
    End Sub
End Class

Public Class FalloAlEliminarBackup
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("Conexion a la BD de datos no lograda!")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.FalloAlEliminarBackup
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = "Conexion a la BD de datos no lograda!"
    End Sub
End Class
