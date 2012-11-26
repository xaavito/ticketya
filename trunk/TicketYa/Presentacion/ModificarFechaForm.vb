Public Class ModificarFechaForm
    Dim baseFecha As BE.FechaBE

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ShowComboBox.DataSource = BLL.GestorShowBLL.buscarShow("")
        ShowComboBox.ValueMember = "identificador"
        ShowComboBox.DisplayMember = "descripcion"

    End Sub
    Sub addFecha(ByVal Fecha As BE.FechaBE)
        baseFecha = Fecha
        NombreTextBox.Text = baseFecha.descripcion
        ShowComboBox.SelectedValue = baseFecha.show.identificador
        FechaTextBox.Text = baseFecha.fecha
    End Sub

    Private Sub ModificarFechaForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Normal
    End Sub
End Class