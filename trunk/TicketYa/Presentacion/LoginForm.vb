Imports System.Reflection

Public Class LoginForm
    Inherits BaseForm

    Public Sub Start()
        Me.StartPosition = FormStartPosition.CenterScreen
        Dim idiomas As List(Of BE.IdiomaBE) = Nothing

        Try
            idiomas = BLL.GestorIdiomaBLL.listarIdiomas("")
        Catch ex As Excepciones.BitacoraNoEncontradaExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Excepciones.NoHayMensajesExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Excepciones.ExcepcionNoEncontradaExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Excepciones.ConexionImposibleExcepcion
            My.Application.manejarExcepcion(ex)
            Environment.Exit(1)
        Catch ex As Exception
            My.Application.manejarExcepcion(ex)
        End Try

        IdiomaComboBox.DataSource = idiomas
        IdiomaComboBox.DisplayMember = "descripcion"
        IdiomaComboBox.ValueMember = "identificador"

        UserTextBox.sinEspacio = True
        UserTextBox.alfanumerico = True
        UserTextBox.nada = False
        UserTextBox.boton = AceptarButton

        PassTextBox.sinEspacio = True
        PassTextBox.alfanumerico = True
        PassTextBox.nada = False
        PassTextBox.boton = AceptarButton

        'Dim myAssembly As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        'Dim types As Type() = myAssembly.GetTypes()
        'For Each myType In types
        '    ' mytype
        '    If myType.BaseType.FullName = "TicketYa.BaseForm" Then
        '        'Debug.Print("-----" + myType.Name)
        '        Dim form As BaseForm
        '        form = Activator.CreateInstance(myType)
        '        Debug.Print("----------------------------Form: " + form.Name + " --------------------------------")
        '        For Each ctrl As Control In form.Controls
        '            If TypeOf ctrl Is MenuStrip Then
        '                Dim menu As MenuStrip
        '                menu = DirectCast(ctrl, MenuStrip)
        '                For Each cabeceraMenu As ToolStripMenuItem In menu.Items
        '                    For Each itemMenu As ToolStripMenuItem In cabeceraMenu.DropDownItems
        '                        Debug.Print("Item menu: " + itemMenu.Name)
        '                        'Next
        '                    Next
        '                    'If cabeceraMenu.Name.Equals(mens.control) Then
        '                    Debug.Print("Cabecera menu: " + cabeceraMenu.Name)
        '                    'cabeceraMenu.Text = mens.mensaje
        '                    'End If
        '                Next cabeceraMenu
        '            End If
        '            If (TypeOf ctrl Is Label Or
        '                TypeOf ctrl Is Button)  Then
        '                Debug.Print("Boton o label: " + ctrl.Name)
        '            End If

        '            If (TypeOf ctrl Is DataGridView) Then
        '                Dim dataGrid As DataGridView
        '                dataGrid = DirectCast(ctrl, DataGridView)
        '                For Each col As DataGridViewColumn In dataGrid.Columns
        '                    'Debug.Print(col.Name)
        '                    Debug.Print("Columna: " + col.Name)
        '                Next
        '            End If
        '        Next
        '        'form = CType(myType, BaseForm)
        '        'GetMethods, GetFields, GetProperties, GetEvents, GetConstructors, GetInterfaces
        '        'Dim Members = myType.GetMembers

        '        'For Each item As MemberInfo In Members
        '        'Debug.Print(item.ToString)
        '        'Next
        '    End If
        'Next
    End Sub

    Private Sub AceptarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AceptarButton.Click
        If (Not String.IsNullOrEmpty(UserTextBox.Text) And Not String.IsNullOrEmpty(PassTextBox.Text)) Then
            Me.Close()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            'Utilitarios.Mailer.sendMail()
        End If
    End Sub

    Private Sub CancelarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarButton.Click
        Me.Close()
    End Sub

    Private Sub IdiomaComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdiomaComboBox.SelectedIndexChanged
        BLL.Actual.idioma = DirectCast(IdiomaComboBox.SelectedItem, BE.IdiomaBE)
        Me.setIdioma()
    End Sub

    Private Sub Login_FormClosed(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.FormClosing
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class
