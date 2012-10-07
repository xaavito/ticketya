Public Class PermisoNoEncontradoExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("Permiso/s no encontrados")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.PermisoNoEncontrado
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = "Permiso/s no encontrados"
    End Sub
End Class


Public Class AsociacionDePermisosExcepcion
    Inherits ExceptionManager

    Public Sub New()
        MyBase.new("Permiso/s no encontrados")
        Me.codigo = Utilitarios.Enumeradores.Excepeciones.PermisoNoAsociado
        Me.tipo = MsgBoxStyle.Exclamation
        Me.mensaje = "Permiso/s no encontrados"
    End Sub
End Class