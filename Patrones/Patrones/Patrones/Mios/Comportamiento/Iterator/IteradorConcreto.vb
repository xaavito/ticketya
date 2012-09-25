Public Class IteradorConcreto(Of P)
    Implements IteradorAbstracto(Of P)



    Property it As ListaConcreta(Of P)
    Private _actual As Integer = 0

    Public Sub New(ByVal list As ListaConcreta(Of P))
        it = list
    End Sub

    Public Function actual() As P Implements IteradorAbstracto(Of P).actual
        Return it.obtenerIndice(_actual)
    End Function

    Public Function primero() As P Implements IteradorAbstracto(Of P).primero
        Return it.obtenerIndice(0)
    End Function

    Public Function proximo() As P Implements IteradorAbstracto(Of P).proximo
        _actual = _actual + 1
        Return it.obtenerIndice(_actual)
    End Function

    Public Function tieneMas() As Boolean Implements IteradorAbstracto(Of P).tieneMas
        If (it.obtenerIndice(_actual + 1) Is Nothing) Then
            Return False
        Else
            Return True
        End If
    End Function
End Class
