Interface ListaAbstracta(Of T)

    Function crearIterador() As IteradorConcreto(Of T)
    Function tamanio() As Integer
    Function obtenerIndice(ByVal indice As Integer) As T
    Sub add(ByVal item As T)


End Interface
