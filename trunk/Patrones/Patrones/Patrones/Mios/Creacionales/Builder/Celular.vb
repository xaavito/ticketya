Public Class Celular

    Private _pantalla As Integer
    Public Property pantalla() As Integer
        Get
            Return _pantalla
        End Get
        Set(ByVal value As Integer)
            _pantalla = value
        End Set
    End Property


    Private _tamanio As Integer
    Public Property tamanio() As Integer
        Get
            Return _tamanio
        End Get
        Set(ByVal value As Integer)
            _tamanio = value
        End Set
    End Property


    Private _color As String
    Public Property color() As String
        Get
            Return _color
        End Get
        Set(ByVal value As String)
            _color = value
        End Set
    End Property
End Class
