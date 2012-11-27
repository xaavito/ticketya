Public Class SillaBE
    Inherits PersistibleBE


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


    Private _estado As BE.EstadoSillaBE
    Public Property estado() As BE.EstadoSillaBE
        Get
            Return _estado
        End Get
        Set(ByVal value As BE.EstadoSillaBE)
            _estado = value
        End Set
    End Property

End Class
