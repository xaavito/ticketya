Public Class Contexto
    Dim estrategia As Estrategia

    Public Sub New(ByVal tipo As Integer)
        If tipo = 1 Then
            estrategia = New EstrategiaConcretaA
        Else
            estrategia = New EstrategiaConcretaB
        End If
    End Sub

    Public Sub dibujar()
        estrategia.hacerHalgo()
    End Sub

End Class
