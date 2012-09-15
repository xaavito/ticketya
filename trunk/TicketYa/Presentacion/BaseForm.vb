Imports System.ComponentModel

Public Class BaseForm


    Protected Sub getPermisos(ByVal permisos As List(Of BE.PermisoBE))
        For Each f As Form In My.Application.OpenForms
            If (Me.HasChildren) Then
                For Each permiso As BE.PermisoBE In permisos
                    For Each ctrl As Control In f.Controls
                        'MenuStrip
                        If TypeOf ctrl Is MenuStrip Then
                            Dim menu As MenuStrip
                            menu = DirectCast(ctrl, MenuStrip)
                            For Each cabeceraMenu As ToolStripMenuItem In menu.Items
                                If cabeceraMenu.Name.Equals(permiso.componente) Then
                                    cabeceraMenu.Enabled = True
                                End If
                                For Each itemMenu As ToolStripItem In cabeceraMenu.DropDownItems
                                    If itemMenu.Name.Equals(permiso.componente) Then
                                        itemMenu.Enabled = True
                                    End If
                                Next
                            Next cabeceraMenu
                        End If
                        If TypeOf ctrl Is Button Then
                            If ctrl.Name.Equals(permiso.componente) Then
                                ctrl.Enabled = True
                            End If
                        End If
                    Next ctrl
                Next permiso
            End If
        Next f
    End Sub

    Protected Sub setIdioma()
        If (Me.HasChildren) Then
            For Each mens As BE.MensajeControlBE In BLL.Actual.idioma.mensaje
                For Each ctrl As Control In Me.Controls
                    'MenuStrip
                    If TypeOf ctrl Is MenuStrip Then
                        Dim menu As MenuStrip
                        menu = DirectCast(ctrl, MenuStrip)
                        For Each cabeceraMenu As ToolStripMenuItem In menu.Items
                            For Each itemMenu As ToolStripItem In cabeceraMenu.DropDownItems
                                If itemMenu.Name.Equals(mens.control) Then
                                    itemMenu.Text = mens.mensaje
                                End If
                            Next
                        Next cabeceraMenu
                    End If
                    If (TypeOf ctrl Is Label Or
                        TypeOf ctrl Is Button) And
                        ctrl.Name.Equals(mens.control) Then
                        ctrl.Text = mens.mensaje
                    End If
                Next ctrl
            Next mens
        End If
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim login As LoginForm
        If Not Me.Name.Equals("LoginForm") Then
            'eliminarPermisos()
            '' SI REVIENTA LA APLICACION COMENTAR TODO ESTO Y LIMPIAR Y LUEGO RE COMPILAR.
            'getPermisos(BLL.Actual.usuario.getPermisos)
            '' HASTA ACA
            setIdioma()
        Else
            login = DirectCast(Me, LoginForm)
            login.Start()
        End If
    End Sub

    Private Sub eliminarPermisos()
        For Each f As Form In My.Application.OpenForms
            If (Me.HasChildren) Then
                For Each ctrl As Control In f.Controls
                    ' MenuStrip
                    If TypeOf ctrl Is MenuStrip Then
                        Dim menu As MenuStrip
                        menu = DirectCast(ctrl, MenuStrip)
                        For Each cabeceraMenu As ToolStripMenuItem In menu.Items
                            cabeceraMenu.Enabled = False
                            For Each itemMenu As ToolStripItem In cabeceraMenu.DropDownItems
                                itemMenu.Enabled = False
                            Next
                        Next cabeceraMenu
                    End If
                    ' Buttons
                    If TypeOf ctrl Is Button Then
                        ctrl.Enabled = False
                    End If
                Next ctrl
            End If
        Next f
    End Sub

End Class