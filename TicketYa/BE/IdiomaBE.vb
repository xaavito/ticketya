
Public Class IdiomaBE
    Inherits PersistibleBE
    Implements IClonable


    Private _descripcion As String
    Public Property descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
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



    Private _mensaje As List(Of MensajeControlBE)

    Public Property mensaje() As List(Of MensajeControlBE)
        Get
            Return _mensaje
        End Get
        Set(ByVal value As List(Of MensajeControlBE))
            _mensaje = value
        End Set
    End Property


    Private _listaExcepciones As List(Of ExcepcionBE)
    Public Property listaExcepciones() As List(Of ExcepcionBE)
        Get
            Return _listaExcepciones
        End Get
        Set(ByVal value As List(Of ExcepcionBE))
            _listaExcepciones = value
        End Set
    End Property


    Private _bitacorasBase As List(Of BE.MensajeBitacoraBE)
    Public Property bitacorasBase() As List(Of BE.MensajeBitacoraBE)
        Get
            Return _bitacorasBase
        End Get
        Set(ByVal value As List(Of BE.MensajeBitacoraBE))
            _bitacorasBase = value
        End Set
    End Property

    Public Function clonar() As Object Implements IClonable.clonar
        Dim idiomaNuevo As New IdiomaBE
        idiomaNuevo.descripcion = Me.descripcion
        idiomaNuevo.fechaAlta = DateTime.Today

        Dim mensajes As New List(Of BE.MensajeControlBE)
        For Each men As BE.MensajeControlBE In Me.mensaje
            mensajes.Add(men.clonar())
        Next

        idiomaNuevo.mensaje = mensajes

        Dim listaExcepciones As New List(Of BE.ExcepcionBE)
        For Each exc As BE.ExcepcionBE In Me.listaExcepciones
            listaExcepciones.Add(exc.clonar())
        Next

        idiomaNuevo.listaExcepciones = listaExcepciones

        Dim menBit As New List(Of BE.MensajeBitacoraBE)
        For Each bit As BE.MensajeBitacoraBE In Me.bitacorasBase
            menBit.Add(bit.clonar())
        Next

        idiomaNuevo.bitacorasBase = menBit
        Return idiomaNuevo
    End Function
End Class
