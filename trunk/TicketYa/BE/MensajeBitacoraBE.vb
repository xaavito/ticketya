Public Class MensajeBitacoraBE
    Inherits PersistibleBE


    Private _idBase As Integer
    Public Property idBase() As Integer
        Get
            Return _idBase
        End Get
        Set(ByVal value As Integer)
            _idBase = value
        End Set
    End Property


    Private _mensaje As String
    Public Property mensaje() As String
        Get
            Return _mensaje
        End Get
        Set(ByVal value As String)
            _mensaje = value
        End Set
    End Property


End Class
