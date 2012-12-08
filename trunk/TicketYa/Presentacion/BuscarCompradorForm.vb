Public Class BuscarCompradorForm

    Private Sub BuscarCompradorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarCompradorButton.Click
        buscarComprador(CompradorTextBox.Text)
    End Sub

    Private Sub ModificarCompradorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarCompradorButton.Click
        If CompradoresDataGrid.hasSelectedObject = True Then
            Dim pepe As String = CompradoresDataGrid.SelectedRows.Item(0).Cells.Item(0).Value
            Dim usr As BE.UsuarioBE = DirectCast(CompradoresDataGrid.myObject, BE.UsuarioBE)
            Dim form As ModificarCompradorForm

            If (Not usr Is Nothing) Then
                form = New ModificarCompradorForm
                form.addComprador(usr)
                form.Show()
            End If
        End If
    End Sub

    Private Sub EliminarCompradorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarCompradorButton.Click
        Dim usr As BE.UsuarioBE
        If CompradoresDataGrid.hasSelectedObject = True Then
            usr = DirectCast(CompradoresDataGrid.CurrentRow.DataBoundItem, BE.UsuarioBE)
            If (Not usr Is Nothing) Then
                Try
                    BLL.GestorUsuarioBLL.eliminarComprador(usr)
                Catch ex As Excepciones.CompradorEliminadoExistosamenteExcepcion
                    BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, usr.numero, Utilitarios.Enumeradores.Bitacora.CompradorEliminado)
                    buscarComprador(CompradorTextBox.Text)
                    My.Application.manejarExcepcion(ex)
                Catch ex As Exception
                    My.Application.manejarExcepcion(ex)
                End Try
            End If
        End If
    End Sub

    Private Sub buscarComprador(ByVal p1 As String)
        Try
            CompradoresDataGrid.DataSource = BLL.GestorUsuarioBLL.buscarComprador(CompradorTextBox.Text)
        Catch ex As Excepciones.UsuariosNoEncontradosExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Exception
            My.Application.manejarExcepcion(ex)
        End Try

    End Sub
End Class
