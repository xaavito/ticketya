Public Class InforReservacion

    'SELECT u.nombre,u.apellido,u.mail,sh.descripcion, fe.descripcion,fe.fecha,se.descripcion,si.columna,si.fila

    Private _nombre As String
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property


    Private _apellido As String
    Public Property apellido() As String
        Get
            Return _apellido
        End Get
        Set(ByVal value As String)
            _apellido = value
        End Set
    End Property


    Private _mail As String
    Public Property mail() As String
        Get
            Return _mail
        End Get
        Set(ByVal value As String)
            _mail = value
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


    Private _fechaFecha As Date
    Public Property fechaFecha() As Date
        Get
            Return _fechaFecha
        End Get
        Set(ByVal value As Date)
            _fechaFecha = value
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

End Class
