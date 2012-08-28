
Public Class IdiomaBE
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


    Private _fechaAlta As Date
    Public Property fechaAlta() As Date
        Get
            Return _fechaAlta
        End Get
        Set(ByVal value As Date)
            _fechaAlta = value
        End Set
    End Property


    Private _mensajes As List(Of MensajeBE)
    Public Property mensajes() As List(Of MensajeBE)
        Get
            Return _mensajes
        End Get
        Set(ByVal value As List(Of MensajeBE))
            _mensajes = value
        End Set
    End Property


End Class
