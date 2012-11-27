Public Class SectorBE
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
    ''s.identificador,s.descripcion,s.columnas,s.filas,s.valor,s.idTipoSector,fs.idFecha

    Private _columnas As Integer
    Public Property columnas() As Integer
        Get
            Return _columnas
        End Get
        Set(ByVal value As Integer)
            _columnas = value
        End Set
    End Property


    Private _filas As Integer
    Public Property filas() As Integer
        Get
            Return _filas
        End Get
        Set(ByVal value As Integer)
            _filas = value
        End Set
    End Property


    Private _valor As Decimal
    Public Property valor() As String
        Get
            Return _valor
        End Get
        Set(ByVal value As String)
            _valor = value
        End Set
    End Property


    Private _tipoSector As BE.TipoSectorBE
    Public Property tipoSector() As BE.TipoSectorBE
        Get
            Return _tipoSector
        End Get
        Set(ByVal value As BE.TipoSectorBE)
            _tipoSector = value
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

End Class
