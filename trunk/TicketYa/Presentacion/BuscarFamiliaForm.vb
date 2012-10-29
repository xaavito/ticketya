Public Class BuscarFamiliaForm

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        FamiliasDataGrid.AutoGenerateColumns = False
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub BuscarFamiliasButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarFamiliasButton.Click
        buscarFamilia(FamiliaTextBox.Text)
    End Sub

    Private Sub ModificarFamiliaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarFamiliaButton.Click
        Dim fam As BE.FamiliaBE = DirectCast(FamiliasDataGrid.CurrentRow.DataBoundItem, BE.FamiliaBE)
        Dim form As ModificarFamiliaForm

        If (Not fam Is Nothing) Then
            form = New ModificarFamiliaForm
            form.addFamilia(fam)
            form.ShowDialog()
        End If
    End Sub

    Private Sub EliminarFamiliaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarFamiliaButton.Click
        Dim fam As BE.FamiliaBE
        fam = DirectCast(FamiliasDataGrid.CurrentRow.DataBoundItem, BE.FamiliaBE)
        If (Not fam Is Nothing) Then
            If (BLL.GestorFamiliaBLL.eliminarFamilia(fam) = 1) Then
                buscarFamilia(FamiliaTextBox.Text)
                Throw New Excepciones.FamiliaEliminadaExitosamenteExcepcion
                BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, FamiliaTextBox.Text, Utilitarios.Enumeradores.Bitacora.FamiliaEliminada)
            Else
                Throw New Excepciones.FamiliaTieneUsuariosAsociadosExcepcion
            End If
        End If
    End Sub

    Private Sub buscarFamilia(ByVal p1 As String)
        FamiliasDataGrid.DataSource = BLL.GestorFamiliaBLL.buscarFamilia(p1)
    End Sub

End Class
