Public Class CreadorConcretoA
    Implements CreadorAbstracto


    Public Function crearProducto() As ProductoAbstracto Implements CreadorAbstracto.crearProducto
        Return New ProductoConcretoA
    End Function
End Class
