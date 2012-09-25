Public Class FabricaComponentesWeb
    Implements FabricaComponentes

    Public Sub fabricaBoton() Implements FabricaComponentes.fabricaBoton
        Dim boton As Boton = New BotonWEB()
        boton.crearBoton()
    End Sub

    Public Sub fabricaFormulario() Implements FabricaComponentes.fabricaFormulario
        Dim form As Formulario = New FormularioWeb()
        form.crearForm()
    End Sub
End Class
