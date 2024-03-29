﻿Public Class GenerarUsuarioForm
    Dim listaFamilias As List(Of BE.FamiliaBE)

    Public Sub New()
        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        'FamiliaDataGrid.AutoGenerateColumns = False
        Try
            Dim idiomas As List(Of BE.IdiomaBE)
            idiomas = BLL.GestorIdiomaBLL.listarIdiomas("")
            IdiomaComboBox.DataSource = idiomas
            IdiomaComboBox.DisplayMember = "descripcion"
            IdiomaComboBox.ValueMember = "identificador"

            Dim familias As List(Of BE.FamiliaBE)
            familias = BLL.GestorFamiliaBLL.listarFamilias()
            FamiliaComboBox.DataSource = familias
            FamiliaComboBox.DisplayMember = "descripcion"
            FamiliaComboBox.ValueMember = "identificador"

            UsuarioTextBox.sinEspacio = True
            UsuarioTextBox.boton = GenerarUsuarioButton
            PassTextBox.sinEspacio = True
            PassTextBox.boton = GenerarUsuarioButton
            NombreTextBox.texto = True
            NombreTextBox.boton = GenerarUsuarioButton
            ApellidoTextBox.texto = True
            ApellidoTextBox.boton = GenerarUsuarioButton
        Catch ex As Exception
            My.Application.manejarExcepcion(ex)
        End Try

        UsuarioTextBox.sinEspacio = True
        UsuarioTextBox.alfanumerico = True
        UsuarioTextBox.boton = GenerarUsuarioButton

        PassTextBox.sinEspacio = True
        PassTextBox.alfanumerico = True
        PassTextBox.boton = GenerarUsuarioButton

        NombreTextBox.texto = True
        NombreTextBox.boton = GenerarUsuarioButton

        ApellidoTextBox.texto = True
        ApellidoTextBox.boton = GenerarUsuarioButton

    End Sub

    Private Sub AgregarFamiliaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarFamiliaButton.Click
        Dim familia As BE.FamiliaBE = DirectCast(FamiliaComboBox.SelectedItem, BE.FamiliaBE)

        Dim row As String() = New String() {familia.identificador, familia.descripcion}
        FamiliaDataGrid.Rows.Add(row)
    End Sub

    Private Sub AltaUsuariosButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerarUsuarioButton.Click
        If (Not UsuarioTextBox.esVacio And
            Not PassTextBox.esVacio And
            Not NombreTextBox.esVacio And
            Not ApellidoTextBox.esVacio) Then

            Try
                If (BLL.GestorUsuarioBLL.altaUsuario(UsuarioTextBox.Text,
                                                    PassTextBox.Text,
                                                    NombreTextBox.Text,
                                                    ApellidoTextBox.Text,
                                                    DirectCast(IdiomaComboBox.SelectedItem, BE.IdiomaBE),
                                                    getFamilias())) Then
                    Throw New Excepciones.UsuarioCreadoExistosamente
                    BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, UsuarioTextBox.Text, Utilitarios.Enumeradores.Bitacora.CreacionDeUsuario)
                    Me.limpiarForm()
                End If

            Catch ex As Excepciones.InsertExcepcion
                My.Application.manejarExcepcion(ex)
            Catch ex As Excepciones.UsuarioCreadoExistosamente
                My.Application.manejarExcepcion(ex)
            Catch ex As Exception
                My.Application.manejarExcepcion(ex)
            End Try
        End If
        

    End Sub

    Private Function getFamilias() As List(Of BE.FamiliaBE)
        listaFamilias = New List(Of BE.FamiliaBE)
        Dim fam As BE.FamiliaBE
        For Each row As DataGridViewRow In FamiliaDataGrid.Rows
            fam = New BE.FamiliaBE
            fam.identificador = row.Cells(0).Value
            fam.descripcion = row.Cells(1).Value
            listaFamilias.Add(fam)
        Next
        Return listaFamilias
    End Function

    Private Sub QuitarFamiliaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarFamiliaButton.Click
        If (FamiliaDataGrid.hasSelectedObject = True) Then
            FamiliaDataGrid.Rows.Remove(FamiliaDataGrid.SelectedRows(0))
        End If
    End Sub
End Class
