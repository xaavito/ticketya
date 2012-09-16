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
    End Enum

    Enum Bitacora
        LogueoFallido = 1
        LogueoExitoso = 2
    End Enum

    Enum Excepcion
        INFO = MsgBoxStyle.Information
        WARNING = MsgBoxStyle.Exclamation
        FATAL = MsgBoxStyle.Critical
    End Enum
End Class
