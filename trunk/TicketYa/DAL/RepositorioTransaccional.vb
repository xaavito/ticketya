Public Class RepositorioTransaccional
    Inherits IRepositorioDecorator

    Public Sub New(ByVal repo As IRepositorio)
        MyBase.New(repo)
    End Sub

    Public Overrides Sub crearComando(ByVal nombre As String)
        MyBase.repo.crearComando(nombre)
        MyBase.repo.transactionON()
    End Sub

    Public Sub destroy()
        MyBase.transactionOK()
    End Sub
End Class
