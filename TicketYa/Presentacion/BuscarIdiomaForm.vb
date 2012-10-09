Public Class BuscarIdiomaForm

    Private Sub BuscarIdiomaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarIdiomaButton.Click
        IdiomasDataGrid.DataSource = BLL.GestorIdiomaBLL.listarIdiomas(IdiomaTextBox.Text)
    End Sub

    Private Sub EliminarIdiomaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarIdiomaButton.Click

    End Sub

    Private Sub ModificarIdiomaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarIdiomaButton.Click

    End Sub
End Class
