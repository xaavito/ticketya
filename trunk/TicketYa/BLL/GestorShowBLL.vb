Imports System.Threading

Public Class GestorShowBLL

    Shared asunto As String
    Shared texto As String
    Shared mail As String

    Shared Function eliminarShow(ByVal show As BE.ShowBE)
        Try
            DAL.ShowDAL.checkVentasAsignadas(show)
        Catch ex As Excepciones.ShowTieneFechasAsociadosExcepcion
            Throw New Excepciones.ShowTieneFechasAsociadosExcepcion
        End Try

        Return DAL.ShowDAL.eliminarShow(show.identificador)

    End Function

    Shared Function buscarShow(ByVal p1 As String) As Object
        Return DAL.ShowDAL.buscarShow(p1)
    End Function

    Shared Function altaShow(ByVal p1 As String, ByVal p2 As BE.TipoShowBE, ByVal p3 As BE.SedeBE) As Boolean
        Dim lista As List(Of BE.UsuarioBE)
        Dim t As Thread
        Try
            Return DAL.ShowDAL.altaShow(p1,
                                        p2.identificador,
                                        p3.identificador)
        Catch ex As Excepciones.ShowCreadoExistosamenteExcepcion
            lista = DAL.VentaDAL.checkPreferencias(p2)
            asunto = "Reserva realizada sobre sus asientos"
            For Each info As BE.UsuarioBE In lista
                texto = "Querido usuario " + info.apellido.ToString + ", " + info.nombre.ToString + " su reserva para el show " + info.show.ToString +
                    " para el sector " + info.sector.ToString + " fecha " + info.fecha.ToString + " del dia " + info.fechaFecha.ToString + " fila: " + info.fila.ToString + " columna " + info.columna.ToString +
                    " ha sido reservada por otro usuario, por favor apresurece a pagar la reserva para hacerse de los tickets"
                mail = info.mail
                t = New Thread(AddressOf EnviarMail)
                t.Start()
            Next
            Throw New Excepciones.ShowCreadoExistosamenteExcepcion
        End Try
    End Function

    Shared Function buscarTipoShow(ByVal p1 As String) As Object
        Return DAL.ShowDAL.buscarTipoShow(p1)
    End Function

    Shared Function modificarShow(ByVal p1 As Integer, ByVal p2 As String, ByVal p3 As Integer, ByVal p4 As Integer)
        Return DAL.ShowDAL.modificarShow(p1, p2, p3, p4)
    End Function

    Shared Function modificarFecha(ByVal p1 As Integer, ByVal p2 As String, ByVal p3 As Integer, ByVal p4 As Date)
        Return DAL.ShowDAL.modificarFecha(p1, p2, p3, p4)
    End Function

    Private Shared Sub EnviarMail()
        Utilitarios.Mailer.sendMail(mail, asunto, texto)
    End Sub

End Class
