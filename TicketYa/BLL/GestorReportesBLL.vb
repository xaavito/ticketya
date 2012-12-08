Public Class GestorReportesBLL

    Shared Function buscarSectores(ByVal Fecha As BE.FechaBE)
        Return DAL.ShowDAL.buscarSectoresPorFecha(Fecha)
    End Function

    Shared Function buscarSectorReporte(ByVal sector As BE.SectorBE)
        Return DAL.ShowDAL.buscarSectorReporte(sector)
    End Function

    Shared Function buscarShowReporte(ByVal show As BE.ShowBE)
        Return DAL.ShowDAL.buscarShowReporte(show)
    End Function

End Class
