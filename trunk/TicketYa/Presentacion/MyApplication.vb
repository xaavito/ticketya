Namespace My
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
            Dim frm As New Login
            If frm.ShowDialog = DialogResult.OK Then
                ret = True
            Else
                End
            End If
            Return ret
        End Function


        Public Sub HandlerException(ByVal ex As Exception)

            


        End Sub


        Public Sub ReloadLanguage()

            

        End Sub

    End Class
End Namespace