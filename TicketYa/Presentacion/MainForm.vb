Imports System.ComponentModel

Public Class MainForm

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().


    End Sub

    Protected Sub getPermisos()
        If (Me.HasChildren) Then
            For Each ctrl As Control In Me.Controls
                'MenuStrip
                If TypeOf ctrl Is MenuStrip Then
                    Dim menu As MenuStrip
                    menu = DirectCast(ctrl, MenuStrip)
                    For Each cabeceraMenu As ToolStripMenuItem In menu.Items
                        For Each itemMenu As ToolStripItem In cabeceraMenu.DropDownItems
                            If itemMenu.Tag.Equals("Buscar") Then
                                itemMenu.Enabled = False
                            End If
                        Next
                    Next cabeceraMenu
                End If
                'ctrl.Enabled = False
            Next ctrl
        End If
    End Sub

    Protected Sub setIdioma()
        If (Me.HasChildren) Then
            For Each ctrl As Control In Me.Controls
                'MenuStrip
                If TypeOf ctrl Is MenuStrip Then
                    Dim menu As MenuStrip
                    menu = DirectCast(ctrl, MenuStrip)
                    For Each cabeceraMenu As ToolStripMenuItem In menu.Items
                        For Each itemMenu As ToolStripItem In cabeceraMenu.DropDownItems
                            If itemMenu.Tag.Equals("Buscar") Then
                                itemMenu.Enabled = False
                            End If
                        Next
                    Next cabeceraMenu
                End If
                If TypeOf ctrl Is Label Or
                   TypeOf ctrl Is Button Then
                    ctrl.Text = "Pepe"
                End If

                'ctrl.Enabled = False
            Next ctrl
        End If
    End Sub
End Class