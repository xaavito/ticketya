Public Class Conserje
    Dim listaMemento As New List(Of Memento)

    Public Sub add(ByVal memento As Memento)
        listaMemento.Add(memento)
    End Sub

    Public Function obtener(ByVal index As Integer) As Memento
        Return listaMemento.Item(index)
    End Function
End Class
