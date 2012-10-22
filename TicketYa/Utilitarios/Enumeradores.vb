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
        IdiomaGeneradoExistosamente = 17
        FamiliasCreadaExitosamente = 18
        FamiliasEliminadaExitosamente = 19
        FamiliaTieneUsuariosAsociados = 20
        FamiliaModificadaExitosamente = 21
        IdiomaEliminadoExitosamente = 22
        IdiomaTieneUsuariosAsociados = 23
        UsuarioEliminadoExitosamente = 24
        UsuarioModificadoExitosamente = 25
        ModificacionDeIdioma = 26
        EliminarMensajeControl = 27
        ModificacionDeMensajeControl = 28
        EliminarBitacora = 29
        ModificacionDeBitacora = 30
        EliminarExcepcion = 31
        ModificacionDeExcepcion = 32
        EliminarIdioma = 33
        IdiomaModificadoExistosamente = 34
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
