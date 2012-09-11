﻿Namespace My
    Partial Friend Class MyApplication

        Protected Overrides Function OnStartup(ByVal eventArgs As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) As Boolean
            Dim Splash As New Intro()
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
            Dim frm As New LoginForm
            If frm.ShowDialog = DialogResult.OK Then
                Try
                    BLL.Actual.usuario = BLL.SeguridadBLL.doLogin(frm.UserTextBox.Text, frm.PassTextBox.Text)
                    ret = True
                Catch ex As Excepciones.UsuarioNoEncontradoExcepcion
                    Application.HandlerException(ex)
                Catch ex As Exception
                    Application.HandlerException(ex)
                End Try
            End If
            Return ret
        End Function


        Public Sub HandlerException(ByVal ex As Exception)
            If (TypeOf ex Is Excepciones.ExceptionManager) Then
                Dim excep = DirectCast(ex, Excepciones.ExceptionManager)
                MsgBox(excep.mensaje, excep.tipo)
            End If
        End Sub
    End Class
End Namespace