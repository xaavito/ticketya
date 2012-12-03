Imports System.Globalization

Public Class MyMaskedTextBox
    Inherits MaskedTextBox

    Public Sub New()
        Me.Mask = "00/00/0000"
        Me.Width = 66
    End Sub

    Public Function getDateTime() As Date
        Try
            Return Date.ParseExact(Me.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture)
        Catch ex As Exception
            Return Date.ParseExact("01/01/2500", "dd/MM/yyyy", CultureInfo.InvariantCulture)
        End Try
    End Function
End Class
