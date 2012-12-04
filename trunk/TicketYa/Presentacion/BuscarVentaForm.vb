Public Class BuscarVentaForm

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim usuarios As List(Of BE.UsuarioBE)
        usuarios = BLL.GestorUsuarioBLL.listarUsuarios()
        Dim usrTodos As New BE.UsuarioBE
        usrTodos.identificador = 0
        usrTodos.nombre = ""
        VendedorComboBox.Items.Add(usrTodos)

        VendedorComboBox.Items.AddRange(usuarios.ToArray)
        VendedorComboBox.SelectedIndex = 0
        VendedorComboBox.DisplayMember = "nombre"
        VendedorComboBox.ValueMember = "identificador"
    End Sub

    Private Sub BuscarSedeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarVentaButton.Click
        buscarVentas()
    End Sub

    Public Sub buscarVentas()
        Try
            VentasDataGrid.DataSource = BLL.GestorVentasBLL.buscarVenta(FechaDesdeTextBox.getDateTime,
                                                                       FechaHastaTextBox.getDateTime,
                                                                       VendedorComboBox.SelectedIndex)
        Catch ex As Excepciones.VentasNoEncontradasExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Exception
            My.Application.manejarExcepcion(ex)
        End Try
    End Sub
End Class
