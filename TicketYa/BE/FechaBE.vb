Public Class FechaBE
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


    Private _fecha As Date
    Public Property fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property


    Private _forLista As String
    Public Property forLista() As String
        Get
            Return _forLista
        End Get
        Set(ByVal value As String)
            _forLista = value
        End Set
    End Property


    Private _show As BE.ShowBE
    Public Property show() As BE.ShowBE
        Get
            Return _show
        End Get
        Set(ByVal value As BE.ShowBE)
            _show = value
        End Set
    End Property

End Class
