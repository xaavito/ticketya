Public Class MensajeControlBE
    Inherits PersistibleBE
    Implements IClonable


    Private _formulario As String
    Public Property formulario() As String
        Get
            Return _formulario
        End Get
        Set(ByVal value As String)
            _formulario = value
        End Set
    End Property

    Private _idFormulario As Integer
    Public Property idFormulario() As Integer
        Get
            Return _idFormulario
        End Get
        Set(ByVal value As Integer)
            _idFormulario = value
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

    Private _idControl As Integer
    Public Property idControl() As Integer
        Get
            Return _idControl
        End Get
        Set(ByVal value As Integer)
            _idControl = value
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
        Dim newObj As New MensajeControlBE
        newObj.formulario = Me.formulario
        newObj.idFormulario = Me.idFormulario
        newObj.control = Me.control
        newObj.idControl = Me.idControl
        newObj.mensaje = Me.mensaje
        Return newObj
    End Function
End Class
