﻿Public Class Enumeradores
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

        BackupEliminadoExitosamente = 40
        FalloAlCrearBackup = 41
        FalloAlRealizarRestore = 42
        FalloBuscar = 43
        FalloUpdate = 44
        SedeTieneShowsAsociados = 45
        SedeEliminadaExitosamente = 46
        SedesNoEncontradas = 47
        EliminarSedeExcepcion = 48
        ShowTieneVentasAsignadas = 49
        ShowEliminadoExitosamente = 50
        ShowsNoEncontrados = 51
        EliminarShowExcepcion = 52
        FechaTieneVentasAsignadas = 53
        FechaEliminadaExitosamente = 54
        FechasNoEncontradas = 55
        EliminarFechaExcepcion = 56
        SectorTieneVentasAsignadas = 57
        SectorEliminadoExitosamente = 58
        SectoresNoEncontrados = 59
        EliminarSectorExcepcion = 60
        PromocionTieneVentasAsignadas = 61
        PromocionEliminadaExitosamente = 62
        EliminarPromocionExcepcion = 63
        SedeCreadaExitosamenteExcepcion = 64
        ShowCreadoExistosamente = 65
        FechaCreadaExcepcion = 66
        SectorCreadoExitosamenteExcepcion = 67
        VentasNoEncontradas = 68
        VentaCreadaExistosamente = 69
        CompradorNoEncontrado = 70
        CompradorsNoEncontrados = 71
        CompradorCreadoExitosamente = 72
        CompradorEliminadoExitosamente = 73
        CompradorModificadoExitosamente = 74
        PreferenciasNoEncontradas = 75
        ModificarSedeExcepcion = 76
        SedeModificadaExistosamenteExcepcion = 77
        GeneracionDeShowFallidaExistosamente = 78
        TipoShowsNoEncontrados = 79
        ShowModificadoExistosamente = 80
        ModificacionShowExcepcion = 81
        GenerarFechaExcepcion = 82
        ModificarFechaExcepcion = 83
        FechaModificadaExistosamenteExcepcion = 84
        TipoSectorNoEncontradoExcepcion = 85
        SectorNoEncontradoExcepcion = 86
        SillasNoEncontradasExcepcion = 87
        SillaYaReservadaExcepcion = 88
        SillaYaVendidaExcepcion = 89
        GenerarDetalleVentaExcepcion = 90
        GenerarVentaExcepcion = 91
        GenerarPagoVentaExcepcion = 92
        VentaGeneradaExitosamente = 93
        PromocionNoGeneradaExcepcion = 94
        GenerarPromocionExcepcion = 95
        PromocionCreadaExistosamenteExcepcion = 96
        ReservasCaidasExcepcion = 97
        SinReservasExcepcion = 98
        ReservasPreviaExcepcion = 99
        GeneracionSectorExcepcion = 100
        RellenarSectorExcepcion = 101

        PromocionNoEncontradaExcepcion = 102

        ShowTieneFechasAsociadosExcepcion

        FechaTieneSectoresAsociadasExcepcion

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
        SedeEliminada = 15
        ShowEliminado = 16
        FechaEliminada = 17
        SectorEliminado = 18
        PromocionEliminada = 19
        SedeCreada = 20
        ShowCreadoExistosamente = 21
        FechaCreada = 22
        SectorCreadoExitosamente = 23
        CompradorEliminado = 24
        SedeModificadaExistosamente = 25
        ShowModificadoExistosamente = 26
        FechaModificadoExistosamente = 27
    End Enum

    Enum Excepcion
        INFO = MsgBoxStyle.Information
        WARNING = MsgBoxStyle.Exclamation
        FATAL = MsgBoxStyle.Critical
    End Enum
End Class
