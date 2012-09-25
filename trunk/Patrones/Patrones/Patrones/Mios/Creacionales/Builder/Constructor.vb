Public MustInherit Class Constructor
    Protected celular As Celular

    Public Sub crearNuevoCelular()
        celular = New Celular
    End Sub

    Public Function getCelular() As Celular
        Return celular
    End Function

    MustOverride Sub construirPantalla()
    MustOverride Sub pintarCarcaza()
    MustOverride Sub construirTamanio()

End Class
