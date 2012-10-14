Public Class ModificarIdiomaForm
    Dim idioma As BE.IdiomaBE

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub GuardarIdiomaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarIdiomaButton.Click
        idioma.descripcion = IdiomaTextBox.Text
        Try
            If (BLL.GestorIdiomaBLL.modificarIdioma(idioma)) Then
                'MsgBox("Idioma Modificado Existosamente")
                Throw New Excepciones.IdiomaModificadoExistosamente
                Me.Close()
            End If

        Catch ex As Excepciones.InsertExcepcion
            My.Application.HandlerException(ex)
        End Try
    End Sub

    Sub addIdioma(ByVal idioma As BE.IdiomaBE)
        Me.idioma = idioma
        IdiomaTextBox.Text = Me.idioma.descripcion
        ExcepcionesDataGrid.DataSource = Me.idioma.listaExcepciones
        MensajesDataGrid.DataSource = Me.idioma.bitacorasBase
        ControlesDataGrid.DataSource = Me.idioma.mensaje
    End Sub

    Private Sub CancelarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarButton.Click
        Me.Close()
    End Sub
End Class
