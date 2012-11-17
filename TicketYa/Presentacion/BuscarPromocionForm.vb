Public Class BuscarPromocionForm

    Private Sub BuscarPromocionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarPromocionButton.Click
        buscarPromocion()
    End Sub

    Private Sub ModificarPromocionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarPromocionButton.Click
        Dim Promocion As BE.PromocionBE
        If PromocionesDataGrid.hasSelectedObject = True Then
            Promocion = DirectCast(PromocionesDataGrid.myObject, BE.PromocionBE)
            Dim form As ModificarPromocionForm

            If (Not Promocion Is Nothing) Then
                form = New ModificarPromocionForm
                form.addPromocion(Promocion)
                form.ShowDialog()
            End If
        End If
    End Sub

    Private Sub EliminarPromocionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarPromocionButton.Click
        Dim Promocion As BE.PromocionBE
        If PromocionesDataGrid.hasSelectedObject = True Then
            Promocion = DirectCast(PromocionesDataGrid.myObject, BE.PromocionBE)
            Try
                BLL.GestorPromocionBLL.eliminarPromocion(Promocion)
                buscarPromocion()
                BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, Promocion.descripcion, Utilitarios.Enumeradores.Bitacora.PromocionEliminada)
                Throw New Excepciones.PromocionEliminadaExistosamenteExcepcion
            Catch ex As Excepciones.PromocionEliminadaExistosamenteExcepcion
                My.Application.manejarExcepcion(ex)
            Catch ex As Excepciones.PromocionTieneVentasAsociadasExcepcion
                My.Application.manejarExcepcion(ex)
            End Try
        End If
    End Sub

    Public Sub buscarPromocion()
        Try
            PromocionesDataGrid.DataSource = BLL.GestorPromocionBLL.buscarPromocion(ShowTextBox.Text)
        Catch ex As Excepciones.PromocionesNoEncontradasExcepcion
            My.Application.manejarExcepcion(ex)
        End Try
    End Sub
End Class
