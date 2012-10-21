﻿Public Class BuscarIdiomaForm

    Private Sub BuscarIdiomaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarIdiomaButton.Click
        buscarIdiomas()
    End Sub

    Private Sub EliminarIdiomaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarIdiomaButton.Click
        Dim idioma As BE.IdiomaBE
        idioma = DirectCast(IdiomasDataGrid.CurrentRow.DataBoundItem, BE.IdiomaBE)
        If (Not idioma Is Nothing) Then
            If (BLL.GestorIdiomaBLL.eliminarIdioma(idioma) = 0) Then
                MsgBox(New Excepciones.IdiomaEliminadoExistosamenteExcepcion)
                buscarIdiomas()
            Else
                MsgBox(New Excepciones.IdiomaTieneUsuariosAsociadosExcepcion)
            End If
        End If

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
