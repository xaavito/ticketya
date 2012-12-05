Public Class PromocionBE
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


    Private _tipoDescuento As String
    Public Property tipoDescuento() As String
        Get
            Return _tipoDescuento
        End Get
        Set(ByVal value As String)
            _tipoDescuento = value
        End Set
    End Property


    Private _descuento As Decimal
    Public Property descuento() As Decimal
        Get
            Return _descuento
        End Get
        Set(ByVal value As Decimal)
            _descuento = value
        End Set
    End Property


    Private _desde As Date
    Public Property desde() As Date
        Get
            Return _desde
        End Get
        Set(ByVal value As Date)
            _desde = value
        End Set
    End Property


    Private _hasta As Date
    Public Property hasta() As Date
        Get
            Return _hasta
        End Get
        Set(ByVal value As Date)
            _hasta = value
        End Set
    End Property

    Private _fecha As BE.FechaBE
    Public Property fecha() As BE.FechaBE
        Get
            Return _fecha
        End Get
        Set(ByVal value As BE.FechaBE)
            _fecha = value
        End Set
    End Property

    Private _sector As BE.SectorBE
    Public Property sector() As BE.SectorBE
        Get
            Return _sector
        End Get
        Set(ByVal value As BE.SectorBE)
            _sector = value
        End Set
    End Property

End Class
