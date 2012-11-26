Public Class GestorPreferenciaBLL

    Shared Function buscarPreferencias(ByVal p1 As Integer) As List(Of BE.TipoShowBE)
        Return DAL.PreferenciaDAL.buscarPreferencias(p1)
    End Function

    Shared Function listarPreferencias() As List(Of BE.TipoShowBE)
        Return DAL.PreferenciaDAL.listarPreferencias()
    End Function

End Class
