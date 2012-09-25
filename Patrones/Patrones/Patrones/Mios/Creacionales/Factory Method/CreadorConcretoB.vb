Public Class CreadorConcretoB
    Implements CreadorAbstracto


    Public Function crearProducto() As ProductoAbstracto Implements CreadorAbstracto.crearProducto
        Return New ProductoConcretoB
    End Function
End Class
