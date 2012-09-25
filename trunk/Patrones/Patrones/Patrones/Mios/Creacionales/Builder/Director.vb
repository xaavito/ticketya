Public Class Director
    Dim constructor As Constructor

    Public Sub setConstructor(ByVal con As Constructor)
        constructor = con
    End Sub

    Public Function getConstructor() As Constructor
        Return constructor
    End Function

    Public Sub construirCelular()
        constructor.crearNuevoCelular()
        constructor.construirPantalla()
        constructor.construirTamanio()
        constructor.pintarCarcaza()
    End Sub

End Class
