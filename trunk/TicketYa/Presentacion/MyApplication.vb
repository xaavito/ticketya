Imports System.Configuration

Namespace My

    Partial Friend Class MyApplication
        Dim frm As New LoginForm

        Protected Overrides Function OnStartup(ByVal eventArgs As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) As Boolean

            Dim Splash As New Intro()
            Splash.Name = "TicketYa"
            'Splash.ProductVersion
            Splash.Show()

            Dim auth As Boolean = False
            Do Until auth = True
                auth = formLogin()
            Loop

            Splash.Close()

            Return MyBase.OnStartup(eventArgs)
        End Function

        Private Function formLogin() As Boolean
            Dim ret As Boolean = False

            If frm.ShowDialog = DialogResult.OK Then
                Try
                    BLL.Actual.usuario = BLL.SeguridadBLL.doLogin(frm.UserTextBox.Text, frm.PassTextBox.Text)
                    ret = True
                    Try
                        BLL.BitacoraBLL.setBitacora(BLL.Actual.usuario, frm.UserTextBox.Text, Utilitarios.Enumeradores.Bitacora.LogueoExitoso)
                    Catch excep As Excepciones.InsertExcepcion
                        Application.manejarExcepcion(excep)
                    End Try
                Catch ex As Excepciones.UsuarioNoEncontradoExcepcion
                    Try
                        BLL.BitacoraBLL.setBitacora(Nothing, frm.UserTextBox.Text + "," + frm.PassTextBox.Text, Utilitarios.Enumeradores.Bitacora.LogueoFallido)
                    Catch excep As Excepciones.InsertExcepcion
                        Application.manejarExcepcion(excep)
                    End Try
                    Application.manejarExcepcion(ex)
                Catch ex As Excepciones.IdiomaNoEncontradoExcepcion
                    Application.manejarExcepcion(ex)
                    ret = True
                Catch ex As Excepciones.PermisoNoEncontradoExcepcion
                    Application.manejarExcepcion(ex)
                    ret = True
                Catch ex As Excepciones.FamiliaNoEncontradaExcepcion
                    Application.manejarExcepcion(ex)
                    ret = True
                Catch ex As Excepciones.ConexionImposibleExcepcion
                    Application.manejarExcepcion(ex)
                Catch ex As Exception
                    Application.manejarExcepcion(ex)
                End Try
            Else
                Environment.Exit(1)
            End If
            Return ret
        End Function


        Public Sub manejarExcepcion(ByVal ex As Exception)
            If (TypeOf ex Is Excepciones.ExceptionManager) Then
                Dim excep = DirectCast(ex, Excepciones.ExceptionManager)
                Try
                    MsgBox(BLL.ExcepcionBLL.buscarExcepcion(excep.codigo), excep.tipo)
                Catch e As Excepciones.ExcepcionNoEncontradaExcepcion
                    Application.manejarExcepcion(e)
                End Try
            End If
        End Sub

        Public Sub cambiarIdioma()
            For Each f As BaseForm In My.Application.OpenForms
                f.setIdioma()
            Next
        End Sub
    End Class
End Namespace