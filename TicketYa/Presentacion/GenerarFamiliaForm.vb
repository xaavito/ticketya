Public Class GenerarFamiliaForm


    Private Sub AltaFamiliaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaFamiliaButton.Click
        Try
            If (BLL.GestorFamiliaBLL.altaFamilia(FamiliaTextBox.Text)) Then
                Throw New Excepciones.FamiliaCreadaExistosamenteExcepcion
                BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, FamiliaTextBox.Text, Utilitarios.Enumeradores.Bitacora.FamiliaCreada)
                limpiarParametros()
            End If
        Catch ex As Excepciones.FamiliaCreadaExistosamenteExcepcion
            My.Application.HandlerException(ex)
        Catch ex As Excepciones.InsertExcepcion
            My.Application.HandlerException(ex)
        End Try
    End Sub

    Private Sub limpiarParametros()
        FamiliaTextBox.Text = ""
    End Sub
End Class
