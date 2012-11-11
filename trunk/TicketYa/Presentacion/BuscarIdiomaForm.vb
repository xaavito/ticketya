Public Class BuscarIdiomaForm

    Private Sub BuscarIdiomaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarIdiomaButton.Click
        buscarIdiomas()
    End Sub

    Private Sub EliminarIdiomaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarIdiomaButton.Click
        Dim idioma As BE.IdiomaBE
        If IdiomasDataGrid.hasSelectedObject = True Then
            idioma = DirectCast(IdiomasDataGrid.myObject, BE.IdiomaBE)
            Try
                If (BLL.GestorIdiomaBLL.eliminarIdioma(idioma) = 1) Then
                    buscarIdiomas()
                    BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, idioma.descripcion, Utilitarios.Enumeradores.Bitacora.IdiomaEliminado)
                    Throw New Excepciones.IdiomaEliminadoExistosamenteExcepcion
                Else
                    Throw New Excepciones.IdiomaTieneUsuariosAsociadosExcepcion
                End If
            Catch ex As Excepciones.IdiomaEliminadoExistosamenteExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Excepciones.IdiomaTieneUsuariosAsociadosExcepcion
            My.Application.manejarExcepcion(ex)
        End Try
        End If
        
    End Sub

    Private Sub ModificarIdiomaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarIdiomaButton.Click
        Dim idioma As BE.IdiomaBE
        If IdiomasDataGrid.hasSelectedObject = True Then
            idioma = DirectCast(IdiomasDataGrid.myObject, BE.IdiomaBE)
            Dim form As ModificarIdiomaForm

            If (Not idioma Is Nothing) Then
                form = New ModificarIdiomaForm
                form.addIdioma(idioma)
                form.ShowDialog()
            End If
        End If
    End Sub

    Private Sub buscarIdiomas()
        IdiomasDataGrid.DataSource = BLL.GestorIdiomaBLL.listarIdiomas(IdiomaTextBox.Text)
    End Sub
End Class
