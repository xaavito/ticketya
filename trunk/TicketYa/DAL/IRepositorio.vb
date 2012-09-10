Public Interface IRepositorio

    Sub crearComando(ByVal nombre As String)
    Sub addParam(ByVal p1 As String, ByVal p2 As Object)
    Sub transactionON()
    
    Sub transactionCancel()
    
    Sub transactionOK()
    
    Sub clearParams()
    
    Function executeSearchWithAdapter() As DataTable
    
    Function executeSearch() As Integer
    
    Function executeSearchWithStatus() As Integer
    
End Interface
