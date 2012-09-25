Public Class PagoMisCuentasVencidas
    Implements Observador

    Public Sub actualizar() Implements Observador.actualizar
        Debug.Print("Factura Vencida")
    End Sub
End Class
