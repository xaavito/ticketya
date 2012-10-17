Public Class LoginForm
    Inherits BaseForm

    Public Sub Start()
        Me.StartPosition = FormStartPosition.CenterScreen
        Dim idiomas As List(Of BE.IdiomaBE)
        idiomas = BLL.GestorIdiomaBLL.listarIdiomas("")
        IdiomaComboBox.DataSource = idiomas
        IdiomaComboBox.DisplayMember = "descripcion"
        IdiomaComboBox.ValueMember = "identificador"

        UserTextBox.sinEspacio = True
        UserTextBox.alfanumerico = True
        UserTextBox.boton = AceptarButton
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

    'Private Sub loginform_load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Me.StartPosition = FormStartPosition.CenterScreen
    'End Sub
End Class
