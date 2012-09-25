Public Class ListaConcreta(Of P)
    Implements ListaAbstracta(Of P)

    Dim listaGenerica As New List(Of P)

    Public Function crearIterador() As IteradorConcreto(Of P) Implements ListaAbstracta(Of P).crearIterador
        Return New IteradorConcreto(Of P)(Me)
    End Function

    Public Function obtenerIndice(ByVal indice As Integer) As P Implements ListaAbstracta(Of P).obtenerIndice
        Return listaGenerica.Item(indice)
    End Function

    Public Sub add(ByVal item As P) Implements ListaAbstracta(Of P).add
        listaGenerica.Add(item)
    End Sub

    Public Function tamanio() As Integer Implements ListaAbstracta(Of P).tamanio
        Return listaGenerica.Count
    End Function
End Class

