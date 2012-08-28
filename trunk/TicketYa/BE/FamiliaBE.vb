Public Class FamiliaBE
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


    Private _permisos As List(Of PermisoBE)
    Public Property permisos() As List(Of PermisoBE)
        Get
            Return _permisos
        End Get
        Set(ByVal value As List(Of PermisoBE))
            _permisos = value
        End Set
    End Property


End Class
