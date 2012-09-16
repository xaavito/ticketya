Public Class GestorBitacoraBLL
    Public Function agregarBitacora(ByVal desc As String,
                                    ByVal usr As BE.UsuarioBE,
                                    ByVal hora As DateTime) As Boolean
        Return Nothing
    End Function

    'Public Shared Function buscarBitacora(ByVal desc As String,
    '                                ByVal usr As BE.UsuarioBE,
    '                                ByVal hora As DateTime) As List(Of BE.BitacoraBE)
    '    Return Nothing

    'End Function

    Public Shared Function buscarBitacora(ByVal usr As BE.UsuarioBE,
                                   ByVal idTipo As Integer) As List(Of BE.BitacoraBE)
        Return DAL.BitacoraDAL.buscarBitacora(usr, idTipo, New DateTime(2012, 9, 21), Actual.idioma)

    End Function

    Public Function eliminarBitacora(ByVal usr As BE.BitacoraBE) As Boolean
        Return Nothing
    End Function

    Shared Function listarTipoBitacoras() As List(Of BE.BitacoraBE)
        Return DAL.BitacoraDAL.listarTipoBitacoras()
    End Function

End Class
