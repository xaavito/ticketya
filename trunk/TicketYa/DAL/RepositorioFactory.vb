Public Class RepositorioFactory
    Private Shared _connectionstring As String

    Public Shared Function Create() As IRepositorio
        Dim repo As New RepositorioSQL()
        Return repo
    End Function

    Public Shared Property ConnectionString() As String
        Get
            Return _connectionstring
        End Get
        Set(ByVal value As String)
            _connectionstring = value
        End Set
    End Property
End Class
