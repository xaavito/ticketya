Public Class Memento

    Private _estado As String

    Public Property estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property

    Public Sub New(ByVal status As String)
        Me.estado = status
    End Sub
End Class
