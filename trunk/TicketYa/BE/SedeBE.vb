Public Class SedeBE
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


    Private _capacidad As Long
    Public Property capacidad() As Long
        Get
            Return _capacidad
        End Get
        Set(ByVal value As Long)
            _capacidad = value
        End Set
    End Property


    Private _tel As String
    Public Property telefono() As String
        Get
            Return _tel
        End Get
        Set(ByVal value As String)
            _tel = value
        End Set
    End Property


    Private _direccion As String
    Public Property direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property



    Private _numero As Integer
    Public Property numero() As Integer
        Get
            Return _numero
        End Get
        Set(ByVal value As Integer)
            _numero = value
        End Set
    End Property


End Class
