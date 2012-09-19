Public Class GenerarPermisoFamiliaForm
    Dim fam As BE.FamiliaBE
    Dim perm As BE.PermisoBE

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        PermisoDataGrid.AutoGenerateColumns = False
        FamiliaDataGrid.AutoGenerateColumns = False
        PermisosFamiliaDataGrid.AutoGenerateColumns = False
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

        Dim permisos As List(Of BE.PermisoBE)
        permisos = BLL.GestorPermisoBLL.listarPermisos()
        PermisoDataGrid.DataSource = permisos

        Dim familias As List(Of BE.FamiliaBE)
        familias = BLL.GestorFamiliaBLL.listarFamilias()
        FamiliaDataGrid.DataSource = familias
    End Sub

    Private Sub FamiliaDataGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles FamiliaDataGrid.CellMouseClick

        fam = DirectCast(FamiliaDataGrid.CurrentRow.DataBoundItem, BE.FamiliaBE)
        Dim listaPermisos As List(Of BE.PermisoBE)
        Try
            listaPermisos = BLL.GestorPermisoBLL.buscarPermisoFamilia(fam.identificador)
            PermisosFamiliaDataGrid.Rows.Clear()
            For Each perm As BE.PermisoBE In listaPermisos
                Dim row As String() = New String() {perm.identificador, perm.descripcion}
                PermisosFamiliaDataGrid.Rows.Add(row)
            Next
        Catch ex As Excepciones.PermisoNoEncontradoExcepcion
            My.Application.HandlerException(ex)
        End Try
    End Sub

    Private Sub AgregarPermisoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgregarPermisoButton.Click
        perm = DirectCast(PermisoDataGrid.CurrentRow.DataBoundItem, BE.PermisoBE)
        If Not (perm Is Nothing And fam Is Nothing) Then
            Dim row As String() = New String() {perm.identificador, perm.descripcion}
            PermisosFamiliaDataGrid.Rows.Add(row)
        End If
    End Sub

    Private Sub QuitarPermisoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitarPermisoButton.Click
        If (PermisosFamiliaDataGrid.SelectedRows.Count > 0) Then
            PermisosFamiliaDataGrid.Rows.Remove(PermisosFamiliaDataGrid.SelectedRows(0))
        End If
    End Sub

    Private Sub GuardarPermisoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarPermisoButton.Click
        Try
            If (BLL.GestorPermisoBLL.altaPermisoFamilia(getPermisosFamilia)) Then
                Throw New Excepciones.PermisosAsociadosExitosamente
            End If

        Catch ex As Excepciones.InsertExcepcion
            My.Application.HandlerException(ex)
        Catch ex As Excepciones.PermisosAsociadosExitosamente
            My.Application.HandlerException(ex)
        End Try
    End Sub

    Private Sub CancelarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarButton.Click
        Me.Close()
    End Sub

    Private Function getPermisosFamilia() As List(Of BE.PermisoBE)
        Dim listaPermisos = New List(Of BE.PermisoBE)
        Dim p As BE.PermisoBE
        For Each row As DataGridViewRow In FamiliaDataGrid.Rows
            p = New BE.PermisoBE
            p.identificador = row.Cells(0).Value
            p.descripcion = row.Cells(1).Value
            listaPermisos.Add(p)
        Next
        Return listaPermisos
    End Function
End Class
