Public Class FabricaComponentesVB
    Implements FabricaComponentes


    Public Sub fabricaBoton() Implements FabricaComponentes.fabricaBoton
        Dim bot As Boton = New BotonVB
        bot.crearBoton()
    End Sub

    Public Sub fabricaFormulario() Implements FabricaComponentes.fabricaFormulario
        Dim form As Formulario = New FormularioVB
        form.crearForm()
    End Sub
End Class
