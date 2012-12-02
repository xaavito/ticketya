Public Class DetalleVentaBE
    Inherits PersistibleBE


    Private _idSilla As Integer
    Public Property idSilla() As Integer
        Get
            Return _idSilla
        End Get
        Set(ByVal value As Integer)
            _idSilla = value
        End Set
    End Property


    Private _idSector As Integer
    Public Property idSector() As Integer
        Get
            Return _idSector
        End Get
        Set(ByVal value As Integer)
            _idSector = value
        End Set
    End Property


    Private _idFecha As Integer
    Public Property idFecha() As Integer
        Get
            Return _idFecha
        End Get
        Set(ByVal value As Integer)
            _idFecha = value
        End Set
    End Property


    Private _idShow As Integer
    Public Property idShow() As Integer
        Get
            Return _idShow
        End Get
        Set(ByVal value As Integer)
            _idShow = value
        End Set
    End Property


    Private _show As String
    Public Property show() As String
        Get
            Return _show
        End Get
        Set(ByVal value As String)
            _show = value
        End Set
    End Property


    Private _fecha As String
    Public Property fecha() As String
        Get
            Return _fecha
        End Get
        Set(ByVal value As String)
            _fecha = value
        End Set
    End Property



    Private _fila As Integer
    Public Property fila() As Integer
        Get
            Return _fila
        End Get
        Set(ByVal value As Integer)
            _fila = value
        End Set
    End Property


    Private _columna As Integer
    Public Property columna() As Integer
        Get
            Return _columna
        End Get
        Set(ByVal value As Integer)
            _columna = value
        End Set
    End Property



    Private _valor As Decimal
    Public Property valor() As Decimal
        Get
            Return _valor
        End Get
        Set(ByVal value As Decimal)
            _valor = value
        End Set
    End Property



    Private _sector As String
    Public Property sector() As String
        Get
            Return _sector
        End Get
        Set(ByVal value As String)
            _sector = value
        End Set
    End Property


End Class
