Public Class ShowBE
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


    Private _tipoShow As TipoShowBE
    Public Property tipoShow() As TipoShowBE
        Get
            Return _tipoShow
        End Get
        Set(ByVal value As TipoShowBE)
            _tipoShow = value
        End Set
    End Property


    Private _sede As BE.SedeBE
    Public Property sede() As BE.SedeBE
        Get
            Return _sede
        End Get
        Set(ByVal value As BE.SedeBE)
            _sede = value
        End Set
    End Property


End Class
