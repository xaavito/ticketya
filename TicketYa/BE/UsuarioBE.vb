Public Class UsuarioBE
    Inherits PersistibleBE


    Private _activo As Boolean

    Public Property activo() As Boolean
        Get
            Return _activo
        End Get
        Set(ByVal value As Boolean)
            _activo = value
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


    Private _nombre As String
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property


    Private _documento As Long
    Public Property documento() As Long
        Get
            Return _documento
        End Get
        Set(ByVal value As Long)
            _documento = value
        End Set
    End Property


    Private _fechaBaja As Date
    Public Property fechaBaja() As Date
        Get
            Return _fechaBaja
        End Get
        Set(ByVal value As Date)
            _fechaBaja = value
        End Set
    End Property


    Private _fechaAlta As Date
    Public Property fechaAlta() As Date
        Get
            Return _fechaAlta
        End Get
        Set(ByVal value As Date)
            _fechaAlta = value
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


    Private _password As String
    Public Property password() As String
        Get
            Return _password
        End Get
        Set(ByVal value As String)
            _password = value
        End Set
    End Property


    Private _usuario As String
    Public Property usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property



    Private _permisos As List(Of PermisoBE)
    Public Property permisos() As List(Of PermisoBE)
        Get
            Return _permisos
        End Get
        Set(ByVal value As List(Of PermisoBE))
            _permisos = value
        End Set
    End Property


    Private _idioma As IdiomaBE

    Public Property idioma() As IdiomaBE
        Get
            Return _idioma
        End Get
        Set(ByVal value As IdiomaBE)
            _idioma = value
        End Set
    End Property


    Private _familias As List(Of FamiliaBE)
    Public Property familias() As List(Of FamiliaBE)
        Get
            Return _familias
        End Get
        Set(ByVal value As List(Of FamiliaBE))
            _familias = value
        End Set
    End Property

    Public Function getPermisos() As List(Of PermisoBE)
        Dim listaPermisos As New List(Of PermisoBE)
        listaPermisos.AddRange(Me.permisos)

        For Each familias As BE.FamiliaBE In Me.familias
            listaPermisos.AddRange(familias.permisos)
        Next familias

        Return listaPermisos
    End Function


    Private _direccion As String
    Public Property direccion() As String
        Get
            Return _direccion
        End Get
        Set(ByVal value As String)
            _direccion = value
        End Set
    End Property


    Private _numero As Integer
    Public Property numero() As Integer
        Get
            Return _numero
        End Get
        Set(ByVal value As Integer)
            _numero = value
        End Set
    End Property


    Private _numCliente As Integer
    Public Property numeroCliente() As Integer
        Get
            Return _numCliente
        End Get
        Set(ByVal value As Integer)
            _numCliente = value
        End Set
    End Property



    Private _codPost As Integer
    Public Property codPost() As Integer
        Get
            Return _codPost
        End Get
        Set(ByVal value As Integer)
            _codPost = value
        End Set
    End Property



    Private _tel As String
    Public Property telefono() As String
        Get
            Return _tel
        End Get
        Set(ByVal value As String)
            _tel = value
        End Set
    End Property

End Class
