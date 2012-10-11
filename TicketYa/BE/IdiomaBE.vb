
Public Class IdiomaBE
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


    Private _listaExcepciones As List(Of Excepciones.ExceptionManager)
    Public Property listaExcepciones() As List(Of Excepciones.ExceptionManager)
        Get
            Return _listaExcepciones
        End Get
        Set(ByVal value As List(Of Excepciones.ExceptionManager))
            _listaExcepciones = value
        End Set
    End Property


    Private _bitacorasBase As List(Of BE.BitacoraBE)
    Public Property bitacorasBase() As List(Of BE.BitacoraBE)
        Get
            Return _bitacorasBase
        End Get
        Set(ByVal value As List(Of BE.BitacoraBE))
            _bitacorasBase = value
        End Set
    End Property


End Class
