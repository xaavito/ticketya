Public Class ControlRemoto
    Dim list As New List(Of Orden)

    Public Sub guardarYEjecutar(ByVal com As Orden)
        list.Add(com)
        com.ejecutar()
    End Sub

End Class
