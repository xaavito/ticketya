Public Class BuscarBitacoraForm
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        BitacorasDataGrid.AutoGenerateColumns = False
        Dim usuarios As List(Of BE.UsuarioBE)
        usuarios = BLL.GestorUsuarioBLL.listarUsuarios()
        UsuarioComboBox.DataSource = usuarios
        UsuarioComboBox.DisplayMember = "nombre"
        UsuarioComboBox.ValueMember = "identificador"

        Dim bitacoras As List(Of BE.BitacoraBE)
        bitacoras = BLL.GestorBitacoraBLL.listarTipoBitacoras()
        TipoBitacoraComboBox.DataSource = bitacoras
        TipoBitacoraComboBox.DisplayMember = "mensaje"
        TipoBitacoraComboBox.ValueMember = "identificador"

    End Sub

    Private Sub BuscarBitacoraButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarBitacoraButton.Click
        Try
            BitacorasDataGrid.DataSource = BLL.GestorBitacoraBLL.buscarBitacora(DirectCast(UsuarioComboBox.SelectedItem, BE.UsuarioBE),
                                                                                DirectCast(TipoBitacoraComboBox.SelectedItem, BE.BitacoraBE).identificador)
        Catch ex As Excepciones.BitacoraNoEncontradaExcepcion
            My.Application.HandlerException(ex)
        End Try
    End Sub
    
End Class