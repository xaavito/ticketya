Public Class PermisoBE
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


    Private _componente As String
    Public Property componente() As String
        Get
            Return _componente
        End Get
        Set(ByVal value As String)
            _componente = value
        End Set
    End Property


    Private _formulario As String
    Public Property formulario() As String
        Get
            Return _formulario
        End Get
        Set(ByVal value As String)
            _formulario = value
        End Set
    End Property



End Class
