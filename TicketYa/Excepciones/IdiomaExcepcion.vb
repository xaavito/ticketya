Public Class NoHayIdiomasExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("No hay Idiomas")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.NoHayIdioma
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = "No hay Idiomas"
    End Sub
End Class

Public Class IdiomaNoEncontradoExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("Idioma No encontrado")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.IdiomaNoEncontrado
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = "Idioma No encontrado"
    End Sub
End Class

Public Class GeneracionDeIdiomaExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("Idioma No encontrado")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.IdiomaNoCreado
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = "Idioma No encontrado"
    End Sub
End Class

Public Class IdiomaModificadoExistosamente
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("Idioma No encontrado")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.IdiomaGeneradoExistosamente
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = "Idioma No encontrado"
    End Sub
End Class