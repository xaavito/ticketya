Public MustInherit Class Automovil

    Public Sub New()
        acelerar()
        pasarCambios()
        frenar()
    End Sub

    Private Sub acelerar()
        Debug.Print("acelerando....")
    End Sub

    Public MustOverride Sub pasarCambios()

    Private Sub frenar()
        Debug.Print("frenando....")
    End Sub

End Class
