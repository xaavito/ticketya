Public Class ModificarIdiomaForm

    Dim idioma As BE.IdiomaBE
    Dim control As BE.MensajeControlBE
    Dim men As BE.MensajeBitacoraBE
    Dim exc As BE.ExcepcionBE

    Private Sub GuardarIdiomaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarIdiomaButton.Click
        idioma.descripcion = IdiomaTextBox.Text
        Try
            If (BLL.GestorIdiomaBLL.modificarIdioma(idioma)) Then
                Throw New Excepciones.IdiomaModificadoExistosamente
                BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, IdiomaTextBox.Text, Utilitarios.Enumeradores.Bitacora.ModificacionDeIdioma)
                Me.Close()
            End If

        Catch ex As Excepciones.IdiomaModificadoExistosamente
            My.Application.manejarExcepcion(ex)
        Catch ex As Excepciones.InsertExcepcion
            My.Application.manejarExcepcion(ex)
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
        exc = DirectCast(ExcepcionesDataGrid.myObject, BE.ExcepcionBE)
        ExcepcionTextBox.Text = exc.mensaje
    End Sub

    Private Sub MensajesDataGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MensajesDataGrid.CellContentClick
        men = DirectCast(MensajesDataGrid.myObject, BE.MensajeBitacoraBE)
        BitacoraTextBox.Text = men.mensaje
    End Sub

    Private Sub ControlesDataGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ControlesDataGrid.CellContentClick
        control = DirectCast(ControlesDataGrid.myObject, BE.MensajeControlBE)
        ControlTextBox.Text = control.mensaje
    End Sub

    Private Sub AceptarExcepcionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarExcepcionButton.Click
        If Not String.IsNullOrWhiteSpace(ExcepcionTextBox.Text) Then
            exc.mensaje = ExcepcionTextBox.Text
        End If
    End Sub

    Private Sub AceptarBitacoraButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarBitacoraButton.Click
        If Not String.IsNullOrWhiteSpace(BitacoraTextBox.Text) Then
            men.mensaje = BitacoraTextBox.Text
        End If
    End Sub

    Private Sub AceptarControlesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarControlesButton.Click
        If Not String.IsNullOrWhiteSpace(ControlTextBox.Text) Then
            control.mensaje = ControlTextBox.Text
        End If
    End Sub
End Class
