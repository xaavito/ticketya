Imports Patrones

Public Class Principal
    Dim listaLibros As New ListaConcreta(Of Libro)

    Dim iteradorConcreto As IteradorConcreto(Of Libro)

    Public Sub New()

        InitializeComponent()

        Debug.Print("+++++++++++++++++++PATRONES DE COMPORTAMIENTO+++++++++++++++++++++++")
        ' Comportamiento
        Debug.Print("********************ITERATOR******************")
        Iterator()
        Debug.Print("*******************TEMPLATE METHOD**************")
        TemplateMethod()
        Debug.Print("*****************MEMENTO******************")
        Memento()
        Debug.Print("****************STARTEGY********************")
        Strategy()
        Debug.Print("***************OBSERVER**********************")
        Observer()
        Debug.Print("***************COMMAND*******************")
        CommandPattern()
        Debug.Print("+++++++++++++++++++FIN PATRONES DE COMPORTAMIENTO+++++++++++++++++++++++")

        Debug.Print("+++++++++++++++++++PATRONES DE CREACION+++++++++++++++++++++++")
        Debug.Print("****************ABSTRACT FACTORY*******************")

        ' Creacionales
        AbstractFactory()
        Debug.Print("*****************BUILDER******************")
        Builder()
        Debug.Print("****************FACTORY METHOD********************")
        'Factory()
        FactoryMethod()
        Debug.Print("****************PROTOTYPE******************")
        Protoype()
        Debug.Print("******************SINGLETON*******************")
        SingletonPattern()
        Debug.Print("+++++++++++++++++++FIN PATRONES DE CREACION+++++++++++++++++++++++")


    End Sub

    Private Sub Iterator()
        Dim libro As New Libro
        libro.codigo = "1"
        libro.nombre = "uno"
        listaLibros.add(libro)

        Dim libro1 As New Libro
        libro1.codigo = "2"
        libro1.nombre = "Dos"
        listaLibros.add(libro1)

        Dim libro2 As New Libro
        libro2.codigo = "3"
        libro2.nombre = "tres"
        listaLibros.add(libro2)

        iteradorConcreto = listaLibros.crearIterador()

        Debug.Print("Codigo Primero")
        Debug.Print(iteradorConcreto.primero().codigo)

        Debug.Print("Tiene Mas")
        Debug.Print(iteradorConcreto.tieneMas)

        Debug.Print("proximo")
        Debug.Print(iteradorConcreto.proximo().codigo)
    End Sub

    Private Sub TemplateMethod()
        Dim automatico As New AutomovilAutomatico
        Dim manual As New AutoManual
    End Sub

    Private Sub Memento()
        Dim orig As New Creador
        Dim cons As New Conserje

        orig.setEstado("Estado 1")
        cons.add(orig.crearMemento)
        orig.setEstado("Estado 2")
        orig.establecerMemento(cons.obtener(0))
    End Sub

    Private Sub Strategy()
        Dim estrategy1 As New Contexto(1)
        estrategy1.dibujar()

        Dim estrategy2 As New Contexto(2)
        estrategy2.dibujar()
    End Sub

    Private Sub Observer()
        Dim fact1 As New FacturaAYSA
        Dim obs As New PagoMisCuentasSinVencer
        Dim obs2 As New PagoMisCuentasVencidas

        fact1.agregar(obs)
        fact1.agregar(obs2)
        fact1.llegoCarta()

        Dim fact2 As New FacturaGas
        fact2.agregar(obs)
        fact2.agregar(obs2)
        fact2.llegoCarta()

        Dim fact3 As New FacturaCable
        fact3.agregar(obs)
        fact3.agregar(obs2)
        fact3.llegoCarta()

        fact3.remover(obs2)
        fact3.llegoCarta()

    End Sub

    Private Sub CommandPattern()
        Dim tele As New Televisor
        Dim prenderCommand As New Prender(tele)
        Dim apagarCommand As New Apagar(tele)

        Dim cr As New ControlRemoto
        cr.guardarYEjecutar(prenderCommand)
        cr.guardarYEjecutar(apagarCommand)
    End Sub

    Private Sub AbstractFactory()
        Dim fact As FabricaComponentes = New FabricaComponentesWeb
        fact.fabricaBoton()
        fact.fabricaFormulario()

        fact = New FabricaComponentesVB
        fact.fabricaBoton()
        fact.fabricaFormulario()

    End Sub

    Private Sub Builder()
        Dim sg3 As Constructor
        Dim iPhone As Constructor
        Dim director As New Director
        sg3 = New Samsung
        director.setConstructor(sg3)
        director.construirCelular()
        iPhone = New Apple
        director.setConstructor(iPhone)
        director.construirCelular()
    End Sub

    'Private Sub Factory()
    '    Throw New NotImplementedException
    'End Sub

    Private Sub FactoryMethod()
        Dim prod As ProductoAbstracto
        Dim creador As CreadorAbstracto
        creador = New CreadorConcretoA
        prod = creador.crearProducto()
        prod.operacionX()

        creador = New CreadorConcretoB
        prod = creador.crearProducto()
        prod.operacionX()
    End Sub

    Private Sub Protoype()
        Dim prod As PrototipoAbstracto
        Dim prodClone As PrototipoAbstracto
        prod = New PrototipoConcretoA
        prodClone = prod.clonar()

        prod = New PrototipoConcretoB
        prodClone = prod.clonar()

    End Sub

    Private Sub SingletonPattern()
        Dim sing As Singleton
        sing = Singleton.getInstance()
        Debug.Print("Por defecto viene 0 en el id")
        Debug.Print(sing.getId)

        sing = Singleton.getInstance()
        Debug.Print("pido otra instancia, pero es la misma...")
        Debug.Print(sing.getId)

        Debug.Print("Seteo 6 en el id de mi singleton")
        sing.setId(6)
        sing = Singleton.getInstance()
        Debug.Print("Pido una instancia, que es la misma, por ende deberia imprimir 6")
        Debug.Print(sing.getId)
    End Sub

End Class
