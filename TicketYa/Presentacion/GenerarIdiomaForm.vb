Public Class GenerarIdiomaForm

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        Try
            Dim idiomas As List(Of BE.IdiomaBE)
            idiomas = BLL.GestorIdiomaBLL.listarIdiomas("")
            IdiomaComboBox.DataSource = idiomas
            IdiomaComboBox.DisplayMember = "descripcion"
            IdiomaComboBox.ValueMember = "identificador"
        Catch ex As Exception
            My.Application.manejarExcepcion(ex)
        End Try

        IdiomaTextBox.texto = True
        IdiomaTextBox.sinEspacio = True
        IdiomaTextBox.boton = GenerarIdiomaButton

    End Sub

    Private Sub GenerarIdiomaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarIdiomaButton.Click
        If Not IdiomaTextBox.esVacio Then
            Dim idioma As BE.IdiomaBE = Nothing
            Try
                idioma = BLL.GestorIdiomaBLL.clonarIdioma(DirectCast(IdiomaComboBox.SelectedItem, BE.IdiomaBE))
                idioma.descripcion = IdiomaTextBox.Text
            Catch ex As Exception
                My.Application.manejarExcepcion(ex)
            End Try


            Try
                idioma.identificador = BLL.GestorIdiomaBLL.guardarIdioma(idioma)
                If (idioma.identificador <= 0) Then
                    Throw New Excepciones.GeneracionDeIdiomaExcepcion
                Else
                    BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, IdiomaTextBox.Text, Utilitarios.Enumeradores.Bitacora.IdiomaCreado)
                    limpiarForm()
                    Throw New Excepciones.GeneracionDeIdiomaExitosa
                End If

            Catch ex As Excepciones.GeneracionDeIdiomaExitosa
                My.Application.manejarExcepcion(ex)
            Catch ex As Excepciones.InsertExcepcion
                My.Application.manejarExcepcion(ex)
            Catch ex As Excepciones.GeneracionDeIdiomaExcepcion
                My.Application.manejarExcepcion(ex)
            Catch ex As Exception
                My.Application.manejarExcepcion(ex)
            End Try
        End If
    End Sub
End Class
