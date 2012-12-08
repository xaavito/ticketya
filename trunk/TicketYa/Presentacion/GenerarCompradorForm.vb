Public Class GenerarCompradorForm
    Dim listaPreferencias As List(Of BE.TipoShowBE)
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        Try
            Dim preferencias As List(Of BE.TipoShowBE) = Nothing
            preferencias = BLL.GestorPreferenciaBLL.listarPreferencias
            PreferenciaComboBox.DataSource = preferencias
            PreferenciaComboBox.DisplayMember = "descripcion"
            PreferenciaComboBox.ValueMember = "identificador"
        Catch ex As Exception
            My.Application.manejarExcepcion(ex)
        End Try
        

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        NombreTextBox.sinEspacio = True
        NombreTextBox.boton = GenerarCompradorButton
        ApellidoTextBox.sinEspacio = True
        ApellidoTextBox.boton = GenerarCompradorButton
        MailTextBox.mail = True
        MailTextBox.boton = GenerarCompradorButton
        DireccionTextBox.texto = True
        DireccionTextBox.boton = GenerarCompradorButton
    End Sub
    Private Sub GenerarUsuarioButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarCompradorButton.Click
        If (Not String.IsNullOrEmpty(NombreTextBox.Text) And Not String.IsNullOrEmpty(ApellidoTextBox.Text) And
            Not String.IsNullOrEmpty(MailTextBox.Text) And Not String.IsNullOrEmpty(DireccionTextBox.Text) And
            Not String.IsNullOrEmpty(TelefonoTextBox.Text)) Then

            Try
                BLL.GestorUsuarioBLL.altaComprador(NombreTextBox.Text,
                                                       ApellidoTextBox.Text,
                                                       MailTextBox.Text,
                                                       DireccionTextBox.Text,
                                                       NumeroTextBox.Text,
                                                       PisoTextBox.Text,
                                                       DptoTextBox.Text,
                                                       CodPostTextBox.Text,
                                                       TelefonoTextBox.Text,
                                                       getPreferencias())

                'Throw New Excepciones.UsuarioCreadoExistosamente


            Catch ex As Excepciones.InsertExcepcion
                My.Application.manejarExcepcion(ex)
            Catch ex As Excepciones.UsuarioCreadoExistosamente
                BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, NombreTextBox.Text, Utilitarios.Enumeradores.Bitacora.CreacionDeUsuario)
                Me.limpiarForm()
                My.Application.manejarExcepcion(ex)
            Catch ex As Exception
                My.Application.manejarExcepcion(ex)
            End Try
        End If
        
    End Sub

    Private Sub AgregarPreferenciaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarPreferenciaButton.Click
        Dim tipo As BE.TipoShowBE = DirectCast(PreferenciaComboBox.SelectedItem, BE.TipoShowBE)

        Dim preferenciaExistente As Boolean = False

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

    Private Sub QuitarPreferenciaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarPreferenciaButton.Click
        If (PreferenciaDataGrid.SelectedRows.Count > 0) Then
            PreferenciaDataGrid.Rows.Remove(PreferenciaDataGrid.SelectedRows(0))
        End If
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
End Class
