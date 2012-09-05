Public Class MensajeControlBE

    Private _formulario As String
    Public Property formulario() As String
        Get
            Return _formulario
        End Get
        Set(ByVal value As String)
            _formulario = value
        End Set
    End Property


    Private _control As String
    Public Property control() As String
        Get
            Return _control
        End Get
        Set(ByVal value As String)
            _control = value
        End Set
    End Property


    Private _mensaje As String
    Public Property mensaje() As String
        Get
            Return _mensaje
        End Get
        Set(ByVal value As String)
            _mensaje = value
        End Set
    End Property



End Class
