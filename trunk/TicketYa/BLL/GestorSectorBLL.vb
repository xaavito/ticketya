Public Class GestorSectorBLL

    Shared Function buscarSector(ByVal p1 As String) As Object
        Return DAL.SectorDAL.buscarSector(p1)
    End Function

    Shared Function buscarSectorPorFecha(ByVal p1 As Integer) As Object
        Return DAL.SectorDAL.buscarSectorPorFecha(p1)
    End Function

    Shared Sub eliminarSector(ByVal Sector As BE.SectorBE)
        Throw New NotImplementedException
    End Sub

    Shared Function altaSector(ByVal p1 As String, ByVal p2 As Integer, ByVal p3 As Integer, ByVal p4 As Integer, ByVal p5 As String, ByVal p6 As String, ByVal p7 As String) As Boolean
        Return DAL.SectorDAL.altaSector(p1, p2, p3, p4, p5, p6, p7)
    End Function

    Shared Function listarTipoSector() As Object
        Return DAL.SectorDAL.listarTipoSector
    End Function

End Class
