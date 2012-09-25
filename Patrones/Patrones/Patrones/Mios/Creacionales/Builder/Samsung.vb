Public Class Samsung
    Inherits Constructor


    Public Overrides Sub construirPantalla()
        celular.pantalla = 6
        Debug.Print("Pantalla de 6")
    End Sub

    Public Overrides Sub construirTamanio()
        celular.tamanio = 6
        Debug.Print("Tamanio de 6")
    End Sub

    Public Overrides Sub pintarCarcaza()
        celular.color = "Blanco"
        Debug.Print("Carcaza Blanca")
    End Sub
End Class
