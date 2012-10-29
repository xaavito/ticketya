Public Class BuscarIdiomaForm

    Private Sub BuscarIdiomaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarIdiomaButton.Click
        buscarIdiomas()
    End Sub

    Private Sub EliminarIdiomaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarIdiomaButton.Click
        Dim idioma As BE.IdiomaBE
        idioma = DirectCast(IdiomasDataGrid.CurrentRow.DataBoundItem, BE.IdiomaBE)
        Try
            If (Not idioma Is Nothing) Then
                If (BLL.GestorIdiomaBLL.eliminarIdioma(idioma) = 1) Then
                    buscarIdiomas()
                    BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, idioma.descripcion, Utilitarios.Enumeradores.Bitacora.IdiomaEliminado)
                    Throw New Excepciones.IdiomaEliminadoExistosamenteExcepcion
                Else
                    Throw New Excepciones.IdiomaTieneUsuariosAsociadosExcepcion
                End If
            End If
        Catch ex As Excepciones.IdiomaEliminadoExistosamenteExcepcion
            My.Application.HandlerException(ex)
        Catch ex As Excepciones.IdiomaTieneUsuariosAsociadosExcepcion
            My.Application.HandlerException(ex)
        End Try
    End Sub

    Private Sub ModificarIdiomaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarIdiomaButton.Click
        Dim idioma As BE.IdiomaBE
        idioma = DirectCast(IdiomasDataGrid.CurrentRow.DataBoundItem, BE.IdiomaBE)
        Dim form As ModificarIdiomaForm

        If (Not idioma Is Nothing) Then
            form = New ModificarIdiomaForm
            form.addIdioma(idioma)
            form.ShowDialog()
        End If
    End Sub

    Private Sub buscarIdiomas()
        IdiomasDataGrid.DataSource = BLL.GestorIdiomaBLL.listarIdiomas(IdiomaTextBox.Text)
    End Sub
End Class
