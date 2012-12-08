Public Class ModificarFamiliaForm
    Dim familia As BE.FamiliaBE


    Private Sub ModificarFamiliaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarFamiliaButton.Click
        Try
            If (BLL.GestorFamiliaBLL.modificarFamilia(familia.identificador,
                                                      FamiliaTextBox.Text)) Then
                Throw New Excepciones.FamiliaModificadaExitosamenteExcepcion
                BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, FamiliaTextBox.Text, Utilitarios.Enumeradores.Bitacora.ModificacionDeFamilia)
                Me.Close()
            End If

        Catch ex As Excepciones.FamiliaModificadaExitosamenteExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Excepciones.InsertExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Exception
            My.Application.manejarExcepcion(ex)
        End Try
    End Sub

    Sub addFamilia(ByVal fam As BE.FamiliaBE)
        familia = fam
        FamiliaTextBox.Text = familia.descripcion
    End Sub

    Private Sub ModificarFamiliaForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Normal
    End Sub
End Class
