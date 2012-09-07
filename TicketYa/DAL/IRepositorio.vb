Public Interface IRepositorio

    Sub generarAcceso(ByVal p1 As String)
    Function ejecutarConTabla() As DataTable
    Function ejecutarConEstado() As Integer
    Sub addStringParam(ByVal p1 As String, ByVal p2 As String)
    Sub addIntegerParam(ByVal p1 As String, ByVal p2 As Integer)

End Interface
