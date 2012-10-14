﻿Public Class ModificarUsuarioForm
    Dim listaFamilias As List(Of BE.FamiliaBE)
    Dim usuario As BE.UsuarioBE

    ' candidato a refactorizacion de una... heredad de un base y este y alta hacen lo mismo
    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        FamiliaDataGrid.AutoGenerateColumns = False
        'initializeFamiliaDataGrid()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'listaFamilias = New List(Of BE.FamiliaBE)

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
    End Sub

    Sub addUsuario(ByVal usr As BE.UsuarioBE)
        usuario = usr
        UsuarioTextBox.Text = usr.usuario
        'PassTextBox.Text = usr.password
        NombreTextBox.Text = usr.nombre
        ApellidoTextBox.Text = usr.apellido
        ActivoCheckBox.Checked = usr.activo
        BLL.GestorIdiomaBLL.buscarIdioma(usr)
        IdiomaComboBox.SelectedValue = usr.idioma.identificador
        setFamilias()
    End Sub

    'Private Sub initializeFamiliaDataGrid()
    '    FamiliaDataGrid.ColumnCount = 2
    '    FamiliaDataGrid.Columns(0).Name = "Identificador"
    '    FamiliaDataGrid.Columns(1).Name = "Nombre"
    'End Sub

    Private Sub setFamilias()
        Try
            listaFamilias = BLL.GestorFamiliaBLL.buscarFamilias(usuario.identificador)

            For Each fam As BE.FamiliaBE In listaFamilias
                Dim row As String() = New String() {fam.identificador, fam.descripcion}
                FamiliaDataGrid.Rows.Add(row)
            Next
        Catch ex As Excepciones.FamiliaNoEncontradaExcepcion
            My.Application.HandlerException(ex)
        End Try


    End Sub
    Private Sub AgregarFamiliaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarFamiliaButton.Click
        Dim familia As BE.FamiliaBE = DirectCast(FamiliaComboBox.SelectedItem, BE.FamiliaBE)
        Dim row As String() = New String() {familia.identificador, familia.descripcion}
        FamiliaDataGrid.Rows.Add(row)
    End Sub

    Private Sub QuitarFamiliaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarFamiliaButton.Click
        If (FamiliaDataGrid.SelectedRows.Count > 0) Then
            FamiliaDataGrid.Rows.Remove(FamiliaDataGrid.SelectedRows(0))
        End If
    End Sub

    Private Sub ModificarUsuariosButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarUsuariosButton.Click
        Try
            If (BLL.GestorUsuarioBLL.modificarUsuario(usuario.identificador,
                                                      UsuarioTextBox.Text,
                                                      PassTextBox.Text,
                                                      NombreTextBox.Text,
                                                      ApellidoTextBox.Text,
                                                      ActivoCheckBox.Checked,
                                                      DirectCast(IdiomaComboBox.SelectedItem, BE.IdiomaBE),
                                                      getFamilias())) Then
                MsgBox("Usuario Modificado Existosamente")
                BLL.Actual.idioma = DirectCast(IdiomaComboBox.SelectedItem, BE.IdiomaBE)
                My.Application.cambiarIdioma()
                limpiarParametros()
                Me.Close()
            End If

        Catch ex As Excepciones.InsertExcepcion
            My.Application.HandlerException(ex)
        End Try
    End Sub

    Private Sub limpiarParametros()
        UsuarioTextBox.Text = ""
        PassTextBox.Text = ""
        NombreTextBox.Text = ""
        ApellidoTextBox.Text = ""
        FamiliaDataGrid.Rows.Clear()
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
End Class