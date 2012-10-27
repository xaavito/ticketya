Public Class ExcepcionBE
    Inherits PersistibleBE
    Implements IClonable


    Private _codigo As Integer
    Public Property codigo() As Integer
        Get
            Return _codigo
        End Get
        Set(ByVal value As Integer)
            _codigo = value
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

    Public Function clonar() As Object Implements IClonable.clonar
        Dim newObj As New ExcepcionBE
        newObj.mensaje = Me.mensaje
        newObj.codigo = Me.codigo
        Return newObj
    End Function
End Class
