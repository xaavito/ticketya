Public Class Apagar
    Implements Orden

    Dim tel As Televisor

    Public Sub New(ByVal com As Televisor)
        tel = com
    End Sub

    Public Sub ejecutar() Implements Orden.ejecutar
        tel.apagar()
    End Sub
End Class
