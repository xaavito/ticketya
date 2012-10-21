Public Class ModificarIdiomaForm
    Dim idioma As BE.IdiomaBE

    Private Sub GuardarIdiomaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarIdiomaButton.Click
        idioma.descripcion = IdiomaTextBox.Text
        Try
            If (BLL.GestorIdiomaBLL.modificarIdioma(idioma)) Then
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

    Private Sub ModificarIdiomaForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub ExcepcionesDataGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ExcepcionesDataGrid.CellContentClick
        Dim exc As BE.ExcepcionBE
        exc = DirectCast(ExcepcionesDataGrid.CurrentRow.DataBoundItem, BE.ExcepcionBE)
        ExcepcionTextBox.Text = exc.mensaje
    End Sub

    Private Sub MensajesDataGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MensajesDataGrid.CellContentClick
        Dim men As BE.MensajeBitacoraBE
        men = DirectCast(MensajesDataGrid.CurrentRow.DataBoundItem, BE.MensajeBitacoraBE)
        BitacoraTextBox.Text = men.mensaje
    End Sub

    Private Sub ControlesDataGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ControlesDataGrid.CellContentClick
        Dim control As BE.MensajeControlBE
        control = DirectCast(ControlesDataGrid.CurrentRow.DataBoundItem, BE.MensajeControlBE)
        ControlTextBox.Text = control.mensaje
    End Sub
End Class
