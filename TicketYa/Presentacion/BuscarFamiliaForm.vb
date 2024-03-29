﻿Public Class BuscarFamiliaForm

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        'FamiliasDataGrid.AutoGenerateColumns = False
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub BuscarFamiliasButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarFamiliasButton.Click
        buscarFamilia(FamiliaTextBox.Text)
    End Sub

    Private Sub ModificarFamiliaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarFamiliaButton.Click
        If Not FamiliasDataGrid.CurrentRow.DataBoundItem Is Nothing Then
            Dim fam As BE.FamiliaBE = DirectCast(FamiliasDataGrid.CurrentRow.DataBoundItem, BE.FamiliaBE)
            Dim form As ModificarFamiliaForm

            If (Not fam Is Nothing) Then
                form = New ModificarFamiliaForm
                form.addFamilia(fam)
                form.ShowDialog()
            End If
        End If
    End Sub

    Private Sub EliminarFamiliaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarFamiliaButton.Click
        Dim fam As BE.FamiliaBE
        If Not FamiliasDataGrid.CurrentRow.DataBoundItem Is Nothing Then
            fam = DirectCast(FamiliasDataGrid.CurrentRow.DataBoundItem, BE.FamiliaBE)
            If (Not fam Is Nothing) Then
                Try
                    BLL.GestorFamiliaBLL.eliminarFamilia(fam)
                Catch ex As Excepciones.FamiliaEliminadaExitosamenteExcepcion
                    buscarFamilia(FamiliaTextBox.Text)
                    BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, FamiliaTextBox.Text, Utilitarios.Enumeradores.Bitacora.FamiliaEliminada)
                    My.Application.manejarExcepcion(ex)
                Catch ex As Excepciones.FamiliaTieneUsuariosAsociadosExcepcion
                    My.Application.manejarExcepcion(ex)
                Catch ex As Exception
                    My.Application.manejarExcepcion(ex)
                End Try
            End If
        End If
    End Sub

    Private Sub buscarFamilia(ByVal p1 As String)
        Try
            FamiliasDataGrid.DataSource = BLL.GestorFamiliaBLL.buscarFamilia(p1)
        Catch ex As Excepciones.FamiliaNoEncontradaExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Exception
            My.Application.manejarExcepcion(ex)
        End Try

    End Sub

End Class
