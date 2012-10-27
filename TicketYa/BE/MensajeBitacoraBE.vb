Public Class MensajeBitacoraBE
    Inherits PersistibleBE
    Implements IClonable

    Private _idBase As Integer
    Public Property idBase() As Integer
        Get
            Return _idBase
        End Get
        Set(ByVal value As Integer)
            _idBase = value
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
        Dim newObj As New MensajeBitacoraBE
        newObj.idBase = Me.idBase
        newObj.mensaje = Me.mensaje
        Return newObj
    End Function
End Class
