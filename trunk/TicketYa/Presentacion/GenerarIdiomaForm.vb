Public Class GenerarIdiomaForm

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        Dim idiomas As List(Of BE.IdiomaBE)
        idiomas = BLL.GestorIdiomaBLL.listarIdiomas("")
        IdiomaComboBox.DataSource = idiomas
        IdiomaComboBox.DisplayMember = "descripcion"
        IdiomaComboBox.ValueMember = "identificador"

    End Sub

    Private Sub IdiomaComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdiomaComboBox.SelectedIndexChanged

    End Sub

    Private Sub GenerarIdiomaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarIdiomaButton.Click
        Try
            If (BLL.GestorIdiomaBLL.generarIdioma(IdiomaComboBox.SelectedValue, IdiomaTextBox.Text) <= 0) Then
                Throw New Excepciones.GeneracionDeIdiomaExcepcion
            End If

        Catch ex As Excepciones.InsertExcepcion
            My.Application.HandlerException(ex)
        Catch ex As Excepciones.GeneracionDeIdiomaExcepcion
            My.Application.HandlerException(ex)
        End Try
    End Sub
End Class
