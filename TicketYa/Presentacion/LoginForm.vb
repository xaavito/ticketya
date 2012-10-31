Public Class LoginForm
    Inherits BaseForm

    Public Sub Start()
        Me.StartPosition = FormStartPosition.CenterScreen
        Dim idiomas As List(Of BE.IdiomaBE)

        Try
            idiomas = BLL.GestorIdiomaBLL.listarIdiomas("")
        Catch ex As Excepciones.BitacoraNoEncontradaExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Excepciones.NoHayMensajesExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Excepciones.ExcepcionNoEncontradaExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Excepciones.ConexionImposibleExcepcion
            My.Application.manejarExcepcion(ex)
            Environment.Exit(1)
        Catch ex As Exception
            My.Application.manejarExcepcion(ex)
        End Try

        IdiomaComboBox.DataSource = idiomas
        IdiomaComboBox.DisplayMember = "descripcion"
        IdiomaComboBox.ValueMember = "identificador"

        UserTextBox.sinEspacio = True
        UserTextBox.alfanumerico = True
        UserTextBox.nada = False
        UserTextBox.boton = AceptarButton

        PassTextBox.sinEspacio = True
        PassTextBox.alfanumerico = True
        PassTextBox.nada = false
        PassTextBox.boton = AceptarButton
    End Sub

    Private Sub AceptarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarButton.Click
        If (Not String.IsNullOrEmpty(UserTextBox.Text) And Not String.IsNullOrEmpty(PassTextBox.Text)) Then
            Me.Close()
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub CancelarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarButton.Click
        Me.Close()
    End Sub

    Private Sub IdiomaComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdiomaComboBox.SelectedIndexChanged
        BLL.Actual.idioma = DirectCast(IdiomaComboBox.SelectedItem, BE.IdiomaBE)
        Me.setIdioma()
    End Sub

    Private Sub Login_FormClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.FormClosing
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class
