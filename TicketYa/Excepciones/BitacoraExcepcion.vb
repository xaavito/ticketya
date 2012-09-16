﻿Public Class BitacoraNoEncontradaExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("Conexion a la BD de datos no lograda!")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.BitacoraNoEncontrada
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = "Conexion a la BD de datos no lograda!"
    End Sub
End Class
