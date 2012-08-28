
Public Class ControlBE
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


    Private _formularios As List(Of FormularioBE)
    Public Property formularios() As List(Of FormularioBE)
        Get
            Return _formularios
        End Get
        Set(ByVal value As List(Of FormularioBE))
            _formularios = value
        End Set
    End Property



End Class
