Public Class Apple
    Inherits Constructor


    Public Overrides Sub construirPantalla()
        celular.pantalla = 7
        Debug.Print("Pantalla de 7")
    End Sub

    Public Overrides Sub construirTamanio()
        celular.tamanio = 5
        Debug.Print("Tamanio de 5")
    End Sub

    Public Overrides Sub pintarCarcaza()
        celular.color = "Negro"
        Debug.Print("Carcaza negra")
    End Sub
End Class
