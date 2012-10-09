Public Class Enumeradores
    Enum Excepeciones
        ConexionBDFallida = 1
        MensajeExcepcion = 2
        FamiliaNoEncontrada = 3
        NoHayIdioma = 4
        IdiomaNoEncontrado = 5
        MensajeNoEncontrado = 6
        PermisoNoEncontrado = 7
        UsuarioNoEncontrado = 8
        FalloInsert = 9
        UsuariosNoEncontrados = 10
        BitacoraNoEncontrada = 11
        FamiliasNoEncontradas = 12
        FalloDelete = 13
        UsuarioCreadoExitosamente = 14
        PermisoNoAsociado = 15
        IdiomaNoCreado = 16
    End Enum

    Enum Bitacora
        LogueoFallido = 1
        LogueoExitoso = 2
        LogoutExitoso = 3
    End Enum

    Enum Excepcion
        INFO = MsgBoxStyle.Information
        WARNING = MsgBoxStyle.Exclamation
        FATAL = MsgBoxStyle.Critical
    End Enum
End Class
