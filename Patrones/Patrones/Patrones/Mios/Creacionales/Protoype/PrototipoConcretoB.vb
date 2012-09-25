Public Class PrototipoConcretoB
    Implements PrototipoAbstracto


    Public Function clonar() As PrototipoAbstracto Implements PrototipoAbstracto.clonar
        Debug.Print("Clonando B")
        Return Me.MemberwiseClone()
    End Function
End Class
