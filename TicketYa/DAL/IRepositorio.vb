Public Interface IRepositorio

    Sub Conectar()
    Sub Desconectar()
    Property Nombre() As String
    Property Timeout() As Integer
    Sub AddParameter(ByVal name As String, ByVal value As Object)
    Function ExecuteNonQuery() As Integer
    Function ExecuteScalar() As Object
    Function ExecuteDataTable() As DataTable
    Function ExecuteDataSet() As DataSet
    Function ExecuteReturnValue() As Object
    Sub Commit()
    Sub Rollback()

End Interface
