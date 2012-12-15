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
                                For Each itemMenu As ToolStripMenuItem In cabeceraMenu.DropDownItems
                                    If itemMenu.Name.Equals(permiso.componente) Then
                                        itemMenu.Enabled = True
                                    End If
                                    For Each subItemMenu As ToolStripMenuItem In itemMenu.DropDownItems
                                        If subItemMenu.Name.Equals(permiso.componente) Then
                                            subItemMenu.Enabled = True
                                        End If
                                    Next
                                Next
                            Next cabeceraMenu
                        End If
                        If TypeOf ctrl Is GroupBox Then
                            For Each c As Control In ctrl.Controls
                                If ctrl.Name.Equals(permiso.componente) Then
                                    ctrl.Enabled = True
                                End If
                            Next
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

    Public Sub setIdioma()
        If (Me.HasChildren) Then
            For Each mens As BE.MensajeControlBE In BLL.Actual.idioma.mensaje
                For Each ctrl As Control In Me.Controls
                    'MenuStrip
                    If TypeOf ctrl Is MenuStrip Then
                        Dim menu As MenuStrip
                        menu = DirectCast(ctrl, MenuStrip)
                        For Each cabeceraMenu As ToolStripMenuItem In menu.Items
                            For Each itemMenu As ToolStripMenuItem In cabeceraMenu.DropDownItems
                                If itemMenu.Name.Equals(mens.control) Then
                                    itemMenu.Text = mens.mensaje
                                End If
                                For Each subItemMenu As ToolStripMenuItem In itemMenu.DropDownItems
                                    If subItemMenu.Name.Equals(mens.control) Then
                                        subItemMenu.Text = mens.mensaje
                                    End If
                                Next
                            Next
                            If cabeceraMenu.Name.Equals(mens.control) Then
                                cabeceraMenu.Text = mens.mensaje
                            End If
                        Next cabeceraMenu
                    End If
                    If (TypeOf ctrl Is Label Or
                        TypeOf ctrl Is Button) And
                        ctrl.Name.Equals(mens.control) Then
                        ctrl.Text = mens.mensaje
                    End If
                    If TypeOf ctrl Is GroupBox Then
                        For Each c As Control In ctrl.Controls
                            If c.Name.Equals(mens.control) Then
                                c.Text = mens.mensaje
                            End If
                        Next
                    End If
                    If (TypeOf ctrl Is DataGridView) Then
                        Dim dataGrid As DataGridView
                        dataGrid = DirectCast(ctrl, DataGridView)
                        For Each col As DataGridViewColumn In dataGrid.Columns
                            'Debug.Print(col.Name)
                            If col.Name.Equals(mens.control) Then
                                col.HeaderText = mens.mensaje
                            End If
                        Next
                    End If
                Next ctrl
                If (TypeOf Me Is Form) Then
                    Dim form As Form
                    form = DirectCast(Me, Form)
                    If form.Name.Equals(mens.control) Then
                        form.Text = mens.mensaje
                    End If
                End If
            Next mens
        End If
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.DesignMode Then Exit Sub
        Dim login As LoginForm
        If Not Me.Name.Equals("LoginForm") Then
            eliminarPermisos()
            '' SI REVIENTA LA APLICACION COMENTAR TODO ESTO Y LIMPIAR Y LUEGO RE COMPILAR.
            getPermisos(BLL.Actual.usuario.getPermisos)
            '' HASTA ACA
            setIdioma()
            'Me.WindowState = FormWindowState.Maximized
        Else
            login = DirectCast(Me, LoginForm)
            login.Start()
        End If

        Me.StartPosition = FormStartPosition.CenterScreen
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
                            If (Not cabeceraMenu.Name.Equals("Logout") And
                                Not cabeceraMenu.Name.Equals("MiUsuario")) Then
                                cabeceraMenu.Enabled = False
                            End If

                            For Each itemMenu As ToolStripMenuItem In cabeceraMenu.DropDownItems
                                itemMenu.Enabled = False
                                For Each subItemMenu As ToolStripMenuItem In itemMenu.DropDownItems
                                    subItemMenu.Enabled = False
                                Next
                            Next
                        Next cabeceraMenu
                    End If
                    ' Buttons
                    If TypeOf ctrl Is Button Then
                        Dim boton As MyButton
                        boton = DirectCast(ctrl, MyButton)
                        If Not boton.Name.Contains("Cancelar") Then
                            ctrl.Enabled = False
                        End If
                    End If
                Next ctrl
            End If
        Next f
    End Sub

    Public Sub limpiarForm()
        For Each ctrl As Control In Me.Controls
            If (TypeOf ctrl Is MyTextBox) Then
                Dim c As MyTextBox
                c = DirectCast(ctrl, MyTextBox)
                c.Text = ""
            End If
            If (TypeOf ctrl Is MyDataGrid) Then
                Dim c As MyDataGrid
                c = DirectCast(ctrl, MyDataGrid)
                c.Rows.Clear()
            End If
        Next
    End Sub
End Class