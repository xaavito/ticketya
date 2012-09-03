Imports System.Windows.Forms

Public Class Principal
    Inherits MainForm

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        'MessageBox.Show("Inicializacion Hijo")

        getPermisos()
    End Sub

    

    Private Sub BuscarPermisosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarPermisosToolStripMenuItem.Click
        
    End Sub
End Class
