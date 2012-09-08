Public Class BitacoraBE
    Inherits PersistibleBE


    Enum tipoError
        Critico
        ErrorTipico
        Exito
    End Enum

    Private _mensaje As String
    Public Property mensaje() As String
        Get
            Return _mensaje
        End Get
        Set(ByVal value As String)
            _mensaje = value
        End Set
    End Property

    Private _usuario As UsuarioBE
    Public Property usuario() As UsuarioBE
        Get
            Return _usuario
        End Get
        Set(ByVal value As UsuarioBE)
            _usuario = value
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

    Private _tipo As tipoError
    Public Property tipo() As tipoError
        Get
            Return _tipo
        End Get
        Set(ByVal value As tipoError)
            _tipo = value
        End Set
    End Property
End Class
