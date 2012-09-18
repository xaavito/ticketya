Public Class ModificarFamiliaForm
    Dim familia As BE.FamiliaBE

    Private Sub ModificarFamiliaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarFamiliaButton.Click
        Try
            If (BLL.GestorFamiliaBLL.modificarFamilia(familia.identificador,
                                                      FamiliaTextBox.Text)) Then
                MsgBox("Familia Modificado Existosamente")
                'limpiarParametros()
                Me.Close()
            End If

        Catch ex As Excepciones.InsertExcepcion
            My.Application.HandlerException(ex)
        End Try
    End Sub

    Sub addFamilia(ByVal fam As BE.FamiliaBE)
        familia = fam
        FamiliaTextBox.Text = familia.descripcion
    End Sub

End Class
