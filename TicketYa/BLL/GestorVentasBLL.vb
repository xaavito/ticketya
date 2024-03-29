﻿Imports System.Threading
Public Class GestorVentasBLL
    Shared texto As String = ""
    Shared asunto As String = ""
    Shared mail As String = ""

    Shared Function generarVenta(ByVal venta As BE.VentaBE, ByVal listaVentas As List(Of BE.DetalleVentaBE), ByVal pago As Boolean)
        Dim result As Integer = Nothing
        Dim lista As List(Of BE.InforReservacion) = Nothing
        
        Dim t As Thread
        Try
            DAL.VentaDAL.checkearReservaPrevia(listaVentas)
        Catch ex As Excepciones.ReservasPreviaExcepcion
            If pago = False Then
                lista = DAL.VentaDAL.notificarMasDeUnaReserva(listaVentas)
                asunto = "Reserva realizada sobre sus asientos"
                For Each info As BE.InforReservacion In lista
                    texto = "Querido usuario " + info.apellido.ToString + ", " + info.nombre.ToString + " su reserva para el show " + info.show.ToString +
                        " para el sector " + info.sector.ToString + " fecha " + info.fecha.ToString + " del dia " + info.fechaFecha.ToString + " fila: " + info.fila.ToString + " columna " + info.columna.ToString +
                        " ha sido reservada por otro usuario, por favor apresurece a pagar la reserva para hacerse de los tickets"
                    mail = info.mail
                    t = New Thread(AddressOf EnviarMail)
                    t.Start()
                Next
            Else
                lista = DAL.VentaDAL.notificarReservaCaida(listaVentas)
                asunto = "Reserva caida"
                For Each info As BE.InforReservacion In lista
                    texto = "Querido usuario " + info.apellido.ToString + ", " + info.nombre.ToString + " su reserva para el show " + info.show.ToString +
                        " para el sector " + info.sector.ToString + " fecha " + info.fecha.ToString + " del dia " + info.fechaFecha.ToString + " fila: " + info.fila.ToString + " columna " + info.columna.ToString +
                        " ha sido cancelada debido a que otro usuario a concretado la compra por dichos asientos"
                    mail = info.mail
                    t = New Thread(AddressOf EnviarMail)
                    t.Start()
                Next
            End If

        Catch ex As Excepciones.SinReservasExcepcion
            'do nada
        End Try
        result = DAL.VentaDAL.generarVenta(venta, listaVentas, pago)
        If pago = True Then
            DAL.VentaDAL.generarPreferencias(venta, listaVentas)
        End If

        Throw New Excepciones.VentaGeneradaExitosamente

        Return result
    End Function


    Shared Function buscarVenta(ByVal p1 As Date, ByVal p2 As Date, ByVal p5 As Integer) As Object
        Return DAL.VentaDAL.buscarVenta(p1, p2, p5)
    End Function

    Private Shared Sub EnviarMail()
        Utilitarios.Mailer.sendMail(mail, asunto, texto)
    End Sub

End Class
