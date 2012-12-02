Public Class VentaBE
    Inherits PersistibleBE

    Private _comprador As BE.UsuarioBE
    Public Property comprador() As BE.UsuarioBE
        Get
            Return _comprador
        End Get
        Set(ByVal value As BE.UsuarioBE)
            _comprador = value
        End Set
    End Property

    Private _vendedor As BE.UsuarioBE
    Public Property vendedor() As BE.UsuarioBE
        Get
            Return _vendedor
        End Get
        Set(ByVal value As BE.UsuarioBE)
            _vendedor = value
        End Set
    End Property

    Private _promocion As BE.PromocionBE
    Public Property promocion() As BE.PromocionBE
        Get
            Return _promocion
        End Get
        Set(ByVal value As BE.PromocionBE)
            _promocion = value
        End Set
    End Property

    Private _fecha As DateTime
    Public Property fecha() As DateTime
        Get
            Return _fecha
        End Get
        Set(ByVal value As DateTime)
            _fecha = value
        End Set
    End Property


    Private _total As Decimal
    Public Property total() As Decimal
        Get
            Return _total
        End Get
        Set(ByVal value As Decimal)
            _total = value
        End Set
    End Property

End Class
