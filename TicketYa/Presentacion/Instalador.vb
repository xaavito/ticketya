Imports System.ComponentModel
Imports System.Configuration.Install
Imports System.Configuration
Imports System.IO

Public Class Instalador
    Inherits Installer

    Public Sub New()
        MyBase.New()

    End Sub


    Private Sub Instalador_AfterInstall(sender As Object, e As System.Configuration.Install.InstallEventArgs) Handles Me.AfterInstall
        Dim TargetDirectory As String = Path.GetDirectoryName(Context.Parameters("AssemblyPath"))

        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(String.Format("{0}\TicketYa.exe", TargetDirectory))
        Dim dialog As New frmSQLConnectionDialog()
        dialog.ConnectionString = config.ConnectionStrings.ConnectionStrings("conn").ConnectionString
        dialog.RootPath = TargetDirectory + "\"

        If dialog.ShowDialog() = DialogResult.OK Then
            Dim CS As String = dialog.ConnectionString
            config.ConnectionStrings.ConnectionStrings("conn").ConnectionString = CS
            config.Save(ConfigurationSaveMode.Modified)
            ConfigurationManager.RefreshSection("connectionStrings")
        End If
    End Sub
End Class
