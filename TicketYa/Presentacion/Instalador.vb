Imports System.ComponentModel
Imports System.Configuration.Install

Public Class Instalador
    Inherits Installer

    Public Sub New()
        MyBase.New()

        'El Diseñador de componentes requiere esta llamada.
        InitializeComponent()

        'Agregue el código de inicialización después de llamar a InitializeComponent

    End Sub
    Public Overrides Sub Commit(ByVal savedState As System.Collections.IDictionary)
        MyBase.Commit(savedState)
        'Dim pepe As New MyInstallerForm
        ' y aca no!
    End Sub

    Protected Overrides Sub OnAfterInstall(ByVal savedState As System.Collections.IDictionary)
        MyBase.OnAfterInstall(savedState)

        'me pa que va a aca mi codigo
    End Sub
End Class
