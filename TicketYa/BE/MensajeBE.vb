Public Class MensajeBE
    Inherits PersistibleBE


    Private _descripcion As String
    Public Property descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property


    Private _controles As ControlBE
    Public Property controles() As ControlBE
        Get
            Return _controles
        End Get
        Set(ByVal value As ControlBE)
            _controles = value
        End Set
    End Property



End Class
