Public Class BuscarFamiliaForm

    Private Sub BuscarFamiliasButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarFamiliasButton.Click
        FamiliasDataGrid.AutoGenerateColumns = False
        FamiliasDataGrid.DataSource = BLL.GestorFamiliaBLL.buscarFamilia(FamiliaTextBox.Text)
    End Sub

    Private Sub ModificarFamiliaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarFamiliaButton.Click

    End Sub

    Private Sub EliminarFamiliaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarFamiliaButton.Click

    End Sub
End Class
