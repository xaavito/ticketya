Public Class Singleton
    Private Shared singleton As Singleton = Nothing

    Private id As Integer

    Private Sub New()
        id = 0
    End Sub

    Public Shared Function getInstance() As Singleton
        If (singleton Is Nothing) Then
            singleton = New Singleton
        End If
        Return singleton
    End Function

    Public Sub setId(ByVal i As Integer)
        id = i
    End Sub

    Public Function getId() As Integer
        Return id
    End Function
End Class
