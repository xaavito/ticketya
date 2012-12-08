Public Class GestorVentasBLL

    Shared Function generarVenta(ByVal venta As BE.VentaBE, ByVal listaVentas As List(Of BE.DetalleVentaBE), ByVal pago As Boolean)
        Dim result As Integer = Nothing
        Dim lista As List(Of BE.InforReservacion) = Nothing
        Dim texto As String = ""
        Try
            DAL.VentaDAL.checkearReservaPrevia(listaVentas)
        Catch ex As Excepciones.ReservasPreviaExcepcion
            If pago = False Then
                lista = DAL.VentaDAL.notificarMasDeUnaReserva(listaVentas)
                For Each info As BE.InforReservacion In lista
                    texto = "Querido usuario " + info.apellido.ToString + ", " + info.nombre.ToString + " su reserva para el show " + info.show.ToString +
                        " para el sector " + info.sector.ToString + " fecha " + info.fecha.ToString + " del dia " + info.fechaFecha.ToString + " fila: " + info.fila.ToString + " columna " + info.columna.ToString +
                        " ha sido reservada por otro usuario, por favor apresurece a pagar la reserva para hacerse de los tickets"
                    Utilitarios.Mailer.sendMail(info.mail, "Reserva realizada sobre sus asientos", texto)
                Next
            Else
                lista = DAL.VentaDAL.notificarReservaCaida(listaVentas)
                For Each info As BE.InforReservacion In lista
                    texto = "Querido usuario " + info.apellido.ToString + ", " + info.nombre.ToString + " su reserva para el show " + info.show.ToString +
                        " para el sector " + info.sector.ToString + " fecha " + info.fecha.ToString + " del dia " + info.fechaFecha.ToString + " fila: " + info.fila.ToString + " columna " + info.columna.ToString +
                        " ha sido cancelada debido a que otro usuario a concretado la compra por dichos asientos"
                    Utilitarios.Mailer.sendMail(info.mail, "Reserva Caida", texto)
                Next
            End If

        Catch ex As Excepciones.SinReservasExcepcion
            result = DAL.VentaDAL.generarVenta(venta, listaVentas, pago)
            Throw New Excepciones.VentaGeneradaExitosamente
        End Try
        
        Return result
    End Function


    Shared Function buscarVenta(ByVal p1 As Date, ByVal p2 As Date, ByVal p5 As Integer) As Object
        Return DAL.VentaDAL.buscarVenta(p1, p2, p5)
    End Function
End Class
