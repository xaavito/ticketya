Public Class PagoMisCuentasSinVencer
    Implements Observador

    Public Sub actualizar() Implements Observador.actualizar
        Debug.Print("Factura proxima a vencer!!!")
    End Sub
End Class
