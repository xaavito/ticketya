Public Class GestorReportesBLL

    Shared Function buscarSectores(ByVal Fecha As BE.FechaBE)
        Return DAL.ShowDAL.buscarSectoresPorFecha(Fecha)
    End Function

    Shared Function buscarSectorReporte(ByVal sector As BE.SectorBE)
        Return DAL.ShowDAL.buscarSectorReporte(sector)
    End Function

End Class
