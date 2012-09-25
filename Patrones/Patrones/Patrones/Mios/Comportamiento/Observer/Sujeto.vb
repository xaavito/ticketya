Public Class Sujeto

    Property list As List(Of Observador)

    Public Sub New()
        list = New List(Of Observador)
    End Sub

    Public Sub agregar(ByVal ob As Observador)
        list.Add(ob)
    End Sub

    Public Sub remover(ByVal ob As Observador)
        list.Remove(ob)
    End Sub

    Public Sub Notificar()
        For Each ob As Observador In list
            ob.actualizar()
        Next
    End Sub

End Class
