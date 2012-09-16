Public Class GenerarUsuarioForm
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'Dim usuarios As List(Of BE.UsuarioBE)
        'usuarios = BLL.GestorUsuarioBLL.listarUsuarios()
        'UsuarioComboBox.DataSource = usuarios
        'UsuarioComboBox.DisplayMember = "nombre"
        'UsuarioComboBox.ValueMember = "identificador"

        'Dim bitacoras As List(Of BE.BitacoraBE)
        'bitacoras = BLL.GestorBitacoraBLL.listarTipoBitacoras()
        'TipoBitacoraComboBox.DataSource = bitacoras
        'TipoBitacoraComboBox.DisplayMember = "mensaje"
        'TipoBitacoraComboBox.ValueMember = "identificador"
    End Sub
End Class
