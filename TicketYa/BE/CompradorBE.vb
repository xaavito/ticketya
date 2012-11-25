Public Class CompradorBE
    Inherits PersistibleBE


    Private _numeroUsuario As Integer
    Public Property numero() As Integer
        Get
            Return _numeroUsuario
        End Get
        Set(ByVal value As Integer)
            _numeroUsuario = value
        End Set
    End Property


End Class
