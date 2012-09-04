Public Class Actual


    Private Shared Property _usuario As BE.UsuarioBE
    Public Shared Property usuario() As BE.UsuarioBE
        Get
            Return _usuario
        End Get
        Set(ByVal value As BE.UsuarioBE)
            _usuario = value
        End Set
    End Property


    Private Shared _idioma As BE.IdiomaBE
    Public Shared Property idioma() As BE.IdiomaBE
        Get
            Return _idioma
        End Get
        Set(ByVal value As BE.IdiomaBE)
            _idioma = value
        End Set
    End Property


End Class
