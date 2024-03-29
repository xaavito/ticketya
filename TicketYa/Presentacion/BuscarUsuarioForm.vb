﻿Public Class BuscarUsuarioForm

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    End Sub

    Private Sub BuscarUsuariosButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarUsuariosButton.Click
        buscarUsuario(UsuarioTextBox.Text)
    End Sub

    Private Sub ModificarUsuarioButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarUsuarioButton.Click
        If UsuariosDataGrid.hasSelectedObject = True Then
            Dim pepe As String = UsuariosDataGrid.SelectedRows.Item(0).Cells.Item(0).Value
            Dim usr As BE.UsuarioBE = DirectCast(UsuariosDataGrid.myObject, BE.UsuarioBE)
            Dim form As ModificarUsuarioForm

            If (Not usr Is Nothing) Then
                form = New ModificarUsuarioForm
                'form.MdiParent = Me.Parent
                form.addUsuario(usr)
                form.Show()
            End If
        End If
        
    End Sub

    Private Sub EliminarUsuarioButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarUsuarioButton.Click
        Dim usr As BE.UsuarioBE
        If UsuariosDataGrid.hasSelectedObject = True Then
            usr = DirectCast(UsuariosDataGrid.CurrentRow.DataBoundItem, BE.UsuarioBE)
            If (Not usr Is Nothing) Then
                Try
                    If (BLL.GestorUsuarioBLL.eliminarUsuario(usr) = 1) Then
                        BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, usr.usuario, Utilitarios.Enumeradores.Bitacora.UsuarioEliminado)
                        buscarUsuario(UsuarioTextBox.Text)
                        Throw New Excepciones.UsuarioEliminadoExistosamenteExcepcion
                    End If
                Catch ex As Excepciones.UsuarioEliminadoExistosamenteExcepcion
                    My.Application.manejarExcepcion(ex)
                Catch ex As Exception
                    My.Application.manejarExcepcion(ex)
                End Try
            End If
        End If
        
    End Sub

    Private Sub buscarUsuario(ByVal p1 As String)
        Try
            UsuariosDataGrid.DataSource = BLL.GestorUsuarioBLL.buscarUsuario(UsuarioTextBox.Text)
        Catch ex As Exception
            My.Application.manejarExcepcion(ex)
        End Try

    End Sub

End Class
