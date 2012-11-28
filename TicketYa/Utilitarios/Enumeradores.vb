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
        ModificacionDeIdiomaExcepcion = 26
        EliminarMensajeControl = 27
        ModificacionDeMensajeControl = 28
        EliminarBitacora = 29
        ModificacionDeBitacora = 30
        EliminarExcepcion = 31
        ModificacionDeExcepcion = 32
        EliminarIdiomaExcepcion = 33
        IdiomaModificadoExistosamente = 34
        PermisoAsociadoExitosamente = 35
        FalloAlEliminarBackup = 36
        BackupsNoEncontrados = 37
        RestoreRealizadoExitosamente = 38
        BackupRealizadoExitosamente = 39

        BackupEliminadoExitosamente

        FalloAlCrearBackup

        FalloAlRealizarRestore

        FalloBuscar

        FalloUpdate

        SedeTieneShowsAsociados

        SedeEliminadaExitosamente

        SedesNoEncontradas

        EliminarSedeExcepcion

        ShowTieneVentasAsignadas

        ShowEliminadoExitosamente

        ShowsNoEncontrados

        EliminarShowExcepcion

        FechaTieneVentasAsignadas

        FechaEliminadaExitosamente

        FechasNoEncontradas

        EliminarFechaExcepcion

        SectorTieneVentasAsignadas

        SectorEliminadoExitosamente

        SectoresNoEncontrados

        EliminarSectorExcepcion

        PromocionTieneVentasAsignadas

        PromocionEliminadaExitosamente

        EliminarPromocionExcepcion

        SedeCreadaExitosamenteExcepcion

        ShowCreadoExistosamente

        FechaCreadaExcepcion

        SectorCreadoExitosamenteExcepcion

        VentasNoEncontradas

        VentaCreadaExistosamente

        CompradorNoEncontrado

        CompradorsNoEncontrados

        CompradorCreadoExitosamente

        CompradorEliminadoExitosamente

        CompradorModificadoExitosamente

        PreferenciasNoEncontradas

        ModificarSedeExcepcion

        SedeModificadaExistosamenteExcepcion

        GeneracionDeShowFallidaExistosamente

        TipoShowsNoEncontrados

        ShowModificadoExistosamente

        ModificacionShowExcepcion

        GenerarFechaExcepcion

        ModificarFechaExcepcion

        FechaModificadaExistosamenteExcepcion

        TipoSectorNoEncontradoExcepcion

        SectorNoEncontradoExcepcion

        SillasNoEncontradasExcepcion

    End Enum

    Enum Bitacora
        LogueoFallido = 1
        LogueoExitoso = 2
        LogoutExitoso = 3
        BackupEliminado = 4
        BackupGenerado = 5
        CreacionDeUsuario = 6
        FamiliaCreada = 7
        FamiliaEliminada = 8
        IdiomaCreado = 9
        IdiomaEliminado = 10
        ModificacionDeFamilia = 11
        UsuarioEliminado = 12
        ModificacionDeIdioma = 13
        ModificacionDeUsuario = 14

        SedeEliminada

        ShowEliminado

        FechaEliminada

        SectorEliminado

        PromocionEliminada

        SedeCreada

        ShowCreadoExistosamente

        FechaCreada

        SectorCreadoExitosamente

        CompradorEliminado

        SedeModificadaExistosamente

        ShowModificadoExistosamente

        FechaModificadoExistosamente

    End Enum

    Enum Excepcion
        INFO = MsgBoxStyle.Information
        WARNING = MsgBoxStyle.Exclamation
        FATAL = MsgBoxStyle.Critical
    End Enum
End Class
