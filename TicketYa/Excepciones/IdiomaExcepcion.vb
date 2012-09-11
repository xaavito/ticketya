Public Class NoHayIdiomasExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("Idiomas no encontrados")
        Me.codigo = 1
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = "Idiomas no encontrados"
    End Sub
End Class
