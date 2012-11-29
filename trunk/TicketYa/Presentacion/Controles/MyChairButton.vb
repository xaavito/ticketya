Public Class MyChairButton
    Inherits Button

    Public Sub New(ByVal estado As Integer)
        Me.Text = ""
        If estado = 1 Then
            Me.Image = TicketYa.My.Resources.Resources.chair_icon_libre
        ElseIf estado = 2 Then
            Me.Image = TicketYa.My.Resources.Resources.chair_icon_resevada
        ElseIf estado = 3 Then
            Me.Image = TicketYa.My.Resources.Resources.chair_icon_ocupada
        End If
    End Sub



    Private Sub MyChairButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Me.Image = TicketYa.My.Resources.Resources.chair_icon_resevada
    End Sub
End Class
