Public Class GenerarFamiliaForm

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        FamiliaTextBox.texto = True
        FamiliaTextBox.sinEspacio = True
        FamiliaTextBox.boton = Me.AltaFamiliaButton
    End Sub

    Private Sub AltaFamiliaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AltaFamiliaButton.Click
        Try
            BLL.GestorFamiliaBLL.altaFamilia(FamiliaTextBox.Text)
        Catch ex As Excepciones.FamiliaCreadaExistosamenteExcepcion
            BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, FamiliaTextBox.Text, Utilitarios.Enumeradores.Bitacora.FamiliaCreada)
            limpiarForm()
            My.Application.manejarExcepcion(ex)
        Catch ex As Excepciones.InsertExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Excepciones.ConexionImposibleExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Exception
            My.Application.manejarExcepcion(ex)
        End Try
    End Sub
End Class
