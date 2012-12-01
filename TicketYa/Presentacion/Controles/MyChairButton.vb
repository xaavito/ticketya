Public Class MyChairButton
    Inherits Button

    Dim grid As MyDataGrid

    Dim miSilla As BE.SillaBE

    Public Sub New(ByVal silla As BE.SillaBE)
        Me.Text = ""
        Me.miSilla = silla

        If Me.miSilla.estado.descripcion = 1 Then
            Me.Image = TicketYa.My.Resources.Resources.chair_icon_libre
        ElseIf Me.miSilla.estado.descripcion = 2 Then
            Me.Image = TicketYa.My.Resources.Resources.chair_icon_resevada
        ElseIf Me.miSilla.estado.descripcion = 3 Then
            Me.Image = TicketYa.My.Resources.Resources.chair_icon_ocupada
        End If
    End Sub

    Private Sub MyChairButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Try
            If Me.miSilla.estado.descripcion = 1 Then
                Me.Image = TicketYa.My.Resources.Resources.chair_icon_resevada
                addToForm()
            ElseIf Me.miSilla.estado.descripcion = 2 Then
                addToForm()
                Throw New Excepciones.SillaYaReservadaExcepcion
            ElseIf Me.miSilla.estado.descripcion = 3 Then
                Throw New Excepciones.SillaYaVendidaExcepcion
            End If
        Catch ex As Excepciones.SillaYaReservadaExcepcion
            My.Application.manejarExcepcion(ex)
        Catch ex As Excepciones.SillaYaVendidaExcepcion
            My.Application.manejarExcepcion(ex)
        End Try

    End Sub

    Public Sub addParent(ByVal parent As MyDataGrid)
        Me.grid = parent
    End Sub

    Private Sub addToForm()
        Me.grid.Rows.Add(New String() {Me.miSilla.identificador, Me.miSilla.sector.fecha.show.identificador, Me.miSilla.sector.fecha.identificador, Me.miSilla.sector.fecha.show.descripcion, Me.miSilla.sector.fecha.descripcion, Me.miSilla.fila, Me.miSilla.columna, Me.miSilla.sector.valor})
    End Sub
End Class
