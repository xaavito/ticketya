Public MustInherit Class IRepositorioDecorator
    Implements IRepositorio

    Protected repo As IRepositorio

    Public Sub New(ByVal repo As IRepositorio)
        Me.repo = repo
    End Sub

    Public Sub addParam(ByVal nombre As String, ByVal parametro As Object) Implements IRepositorio.addParam
        repo.addParam(nombre, parametro)
    End Sub

    Public Sub clearParams() Implements IRepositorio.clearParams
        repo.clearParams()
    End Sub

    Public MustOverride Sub crearComando(ByVal nombre As String) Implements IRepositorio.crearComando

    Public Function executeSearch() As Integer Implements IRepositorio.executeSearch
        Return repo.executeSearch()
    End Function

    Public Function executeSearchWithAdapter() As System.Data.DataTable Implements IRepositorio.executeSearchWithAdapter
        Return repo.executeSearchWithAdapter
    End Function

    Public Function executeSearchWithReturnValue() As Integer Implements IRepositorio.executeSearchWithReturnValue
        Return repo.executeSearchWithReturnValue
    End Function

    Public Function executeSearchWithStatus() As Integer Implements IRepositorio.executeSearchWithStatus
        Return repo.executeSearchWithStatus
    End Function

    Public Sub transactionCancel() Implements IRepositorio.transactionCancel
        repo.transactionCancel()
    End Sub

    Public Sub transactionOK() Implements IRepositorio.transactionOK
        repo.transactionOK()
    End Sub

    Public Sub transactionON() Implements IRepositorio.transactionON
        repo.transactionON()
    End Sub

    Public Sub conectar() Implements IRepositorio.conectar
        repo.conectar()
    End Sub

    Public Sub desconectar() Implements IRepositorio.desconectar
        repo.desconectar()
    End Sub
End Class
