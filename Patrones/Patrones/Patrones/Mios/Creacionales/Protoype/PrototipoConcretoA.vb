Public Class PrototipoConcretoA
    Implements PrototipoAbstracto


    Public Function clonar() As PrototipoAbstracto Implements PrototipoAbstracto.clonar
        Debug.Print("Clonando A")
        Return Me.MemberwiseClone
    End Function
End Class
