Public Class FamiliaNoEncontradaExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("Usuario No encontrado")
        Me.codigo = 1
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = "Usuario No encontrado"
    End Sub
End Class
