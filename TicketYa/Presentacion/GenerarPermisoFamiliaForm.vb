Public Class GenerarPermisoFamiliaForm
    Dim fam As BE.FamiliaBE
    Dim perm As BE.PermisoBE

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Dim permisos As List(Of BE.PermisoBE)
        permisos = BLL.GestorPermisoBLL.listarPermisos()
        PermisoDataGrid.DataSource = permisos

        Dim familias As List(Of BE.FamiliaBE)
        familias = BLL.GestorFamiliaBLL.listarFamilias()
        FamiliaDataGrid.DataSource = familias
    End Sub

    Private Sub FamiliaDataGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles FamiliaDataGrid.CellMouseClick
        PermisosFamiliaDataGrid.Rows.Clear()

        If FamiliaDataGrid.hasSelectedObject = True Then
            fam = DirectCast(FamiliaDataGrid.myObject, BE.FamiliaBE)
            Dim listaPermisos As List(Of BE.PermisoBE)
            Try
                listaPermisos = BLL.GestorPermisoBLL.buscarPermisoFamilia(fam.identificador)
                fam.permisos = listaPermisos
                'PermisosFamiliaDataGrid.Rows.Clear()
                For Each perm As BE.PermisoBE In listaPermisos
                    Dim row As String() = New String() {perm.identificador, perm.descripcion}
                    PermisosFamiliaDataGrid.Rows.Add(row)
                Next
            Catch ex As Excepciones.PermisoNoEncontradoExcepcion
                My.Application.HandlerException(ex)
            End Try
        End If
    End Sub

    Private Sub AgregarPermisoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarPermisoButton.Click, AgregarPermisoFamiliaButton.Click
        Dim permisoExistente As Boolean = False
        If PermisoDataGrid.hasSelectedObject = True Then
            perm = DirectCast(PermisoDataGrid.myObject, BE.PermisoBE)
            If Not (perm Is Nothing And fam Is Nothing) Then
                Dim row As String() = New String() {perm.identificador, perm.descripcion}

                For Each elem As DataGridViewRow In PermisosFamiliaDataGrid.Rows
                    If (elem.Cells.Item(0).Value = perm.identificador) Then
                        permisoExistente = True
                        Exit For
                    End If
                Next
                If (permisoExistente = False) Then
                    PermisosFamiliaDataGrid.Rows.Add(row)
                End If
            End If
        End If
    End Sub

    Private Sub QuitarPermisoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarPermisoButton.Click, QuitarPermisoFamiliaButton.Click
        If (PermisosFamiliaDataGrid.SelectedRows.Count > 0) Then
            PermisosFamiliaDataGrid.Rows.Remove(PermisosFamiliaDataGrid.myObject)
        End If
    End Sub

    Private Sub GuardarPermisoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarPermisoButton.Click, GuardarPermisoFamiliaButton.Click
        Try
            If (BLL.GestorPermisoBLL.altaPermisoFamilia(fam, getPermisosFamilia) <= 0) Then
                Throw New Excepciones.AsociacionDePermisosExcepcion
            Else
                Throw New Excepciones.AsociacionDePermisosExitosa
            End If

        Catch ex As Excepciones.InsertExcepcion
            My.Application.HandlerException(ex)
        Catch ex As Excepciones.AsociacionDePermisosExcepcion
            My.Application.HandlerException(ex)
        Catch ex As Excepciones.AsociacionDePermisosExitosa
            My.Application.HandlerException(ex)
        End Try
    End Sub

    Private Sub CancelarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarButton.Click
        Me.Close()
    End Sub

    Private Function getPermisosFamilia() As List(Of BE.PermisoBE)
        Dim listaPermisos = New List(Of BE.PermisoBE)
        Dim p As BE.PermisoBE
        For Each row As DataGridViewRow In PermisosFamiliaDataGrid.Rows
            p = New BE.PermisoBE
            p.identificador = row.Cells(0).Value
            p.descripcion = row.Cells(1).Value
            listaPermisos.Add(p)
        Next
        Return listaPermisos
    End Function
End Class
