Public Class EstadoSillaBE
    Inherits PersistibleBE


    Private _descripcion As Estado
    Public Property descripcion() As Estado
        Get
            Return _descripcion
        End Get
        Set(ByVal value As Estado)
            _descripcion = value
        End Set
    End Property


    Enum Estado
        Libre = 1
        Reservado = 2
        Vendido = 3
    End Enum


End Class
