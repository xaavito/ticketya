Public Class Creador
    Private estado As String

    Public Sub establecerMemento(ByVal memento As Memento)
        estado = memento.estado
        Debug.Print(estado)
    End Sub

    Public Function crearMemento()
        Return New Memento(estado)
    End Function

    Public Sub setEstado(ByVal est As String)
        estado = est
        Debug.Print(estado)
    End Sub
End Class
