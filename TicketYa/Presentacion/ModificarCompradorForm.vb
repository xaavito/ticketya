Public Class ModificarCompradorForm

    Dim listaPreferencias As List(Of BE.TipoShowBE)
    Dim usuario As BE.UsuarioBE

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Dim preferencias As List(Of BE.TipoShowBE) = Nothing
        preferencias = BLL.GestorPreferenciaBLL.listarPreferencias
        PreferenciaComboBox.DataSource = preferencias
        PreferenciaComboBox.DisplayMember = "descripcion"
        PreferenciaComboBox.ValueMember = "identificador"

    End Sub
    Sub addComprador(ByVal usr As BE.UsuarioBE)
        usuario = usr
        NombreTextBox.Text = usr.nombre
        ApellidoTextBox.Text = usr.apellido
        MailTextBox.Text = usr.mail
        DireccionTextBox.Text = usr.direccion
        NumeroTextBox.Text = usr.numero
        PisoTextBox.Text = usr.piso
        DptoTextBox.Text = usr.dpto
        CodPostTextBox.Text = usr.codPost
        TelefonoTextBox.Text = usr.telefono
        setPreferencias()
    End Sub

    Private Sub GenerarCompradorButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            BLL.GestorUsuarioBLL.modificarComprador(usuario.identificador,
                                                   NombreTextBox.Text,
                                                   ApellidoTextBox.Text,
                                                   MailTextBox.Text,
                                                   DireccionTextBox.Text,
                                                   NumeroTextBox.Text,
                                                   PisoTextBox.Text,
                                                   DptoTextBox.Text,
                                                   CodPostTextBox.Text,
                                                   TelefonoTextBox.Text,
                                                   getPreferencias())

        Catch ex As Excepciones.UsuarioModificadoExitosamenteExcepcion
            BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, NombreTextBox.Text, Utilitarios.Enumeradores.Bitacora.ModificacionDeUsuario)
            Me.limpiarForm()
            Me.Close()
            My.Application.manejarExcepcion(ex)
        Catch ex As Excepciones.InsertExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Exception
            My.Application.manejarExcepcion(ex)
        End Try
    End Sub

    Private Sub setPreferencias()
        Try
            listaPreferencias = BLL.GestorPreferenciaBLL.buscarPreferencias(usuario.identificador)

            For Each pref As BE.TipoShowBE In listaPreferencias
                Dim row As String() = New String() {pref.identificador, pref.descripcion}
                PreferenciaDataGrid.Rows.Add(row)
            Next
        Catch ex As Excepciones.PreferenciasNoEncontradasExcepcion
            My.Application.manejarExcepcion(ex)
        End Try

    End Sub
    Private Function getPreferencias() As List(Of BE.TipoShowBE)
        listaPreferencias = New List(Of BE.TipoShowBE)
        Dim fam As BE.TipoShowBE
        For Each row As DataGridViewRow In PreferenciaDataGrid.Rows
            fam = New BE.TipoShowBE
            fam.identificador = row.Cells(0).Value
            fam.descripcion = row.Cells(1).Value
            listaPreferencias.Add(fam)
        Next
        Return listaPreferencias
    End Function

    Private Sub ModificarCompradorForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub AgregarPreferenciaButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarPreferenciaButton.Click
        Dim preferenciaExistente As Boolean = False

        Dim tipo As BE.TipoShowBE = DirectCast(PreferenciaComboBox.SelectedItem, BE.TipoShowBE)
        Dim row As String() = New String() {tipo.identificador, tipo.descripcion}

        If PreferenciaDataGrid.tamanio > 0 Then
            For Each elem As DataGridViewRow In PreferenciaDataGrid.Rows
                If (elem.Cells.Item(0).Value = tipo.identificador) Then
                    preferenciaExistente = True
                    Exit For
                End If
            Next
            If (preferenciaExistente = False) Then
                PreferenciaDataGrid.Rows.Add(row)
            End If
        Else
            PreferenciaDataGrid.Rows.Add(row)
        End If
    End Sub

    Private Sub QuitarPreferenciaButton_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarPreferenciaButton.Click
        If (PreferenciaDataGrid.SelectedRows.Count > 0) Then
            PreferenciaDataGrid.Rows.Remove(PreferenciaDataGrid.SelectedRows(0))
        End If
    End Sub
End Class
