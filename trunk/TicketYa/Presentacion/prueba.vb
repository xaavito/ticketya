Public Class prueba

    Public Sub New()
        Dim myAssembly As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        Dim types As Type() = myAssembly.GetTypes()
        For Each myType In types
            ' mytype
            If myType.BaseType.FullName = "System.Windows.Forms.Form" Then
                MessageBox.Show(myType.Name)
            End If
        Next
    End Sub

    
End Class
