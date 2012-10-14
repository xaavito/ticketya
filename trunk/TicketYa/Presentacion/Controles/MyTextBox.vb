Imports System.Text.RegularExpressions

Public Class MyTextBox
    Inherits TextBox

    Dim errorProvider As New ErrorProvider

    Private _sinEspacio As Boolean
    Public Property sinEspacio() As Boolean
        Get
            Return _sinEspacio
        End Get
        Set(ByVal value As Boolean)
            _sinEspacio = value
        End Set
    End Property


    Private _alfanumerico As Boolean
    Public Property alfanumerico() As Boolean
        Get
            Return _alfanumerico
        End Get
        Set(ByVal value As Boolean)
            _alfanumerico = value
        End Set
    End Property

    Public Sub SinEspacios()
        If Regex.IsMatch(Me.Text, "\s") Then
            'Throw New EspacioEnBlancoExcepcion
            errorProvider.SetError(Me, "No debe tener espacios")
        End If

    End Sub

    Public Sub esAlfanumerico()
        If Not String.IsNullOrEmpty(Me.Text) Then
            If Not Regex.IsMatch(Me.Text, "^[A-Z0-9 a-z]*$") Then
                errorProvider.SetError(Me, "Debe tener un valor")
                'Throw New StringAlfanumericoExcepcion
            End If
        End If
    End Sub

    Protected Overrides Sub OnKeyUp(ByVal e As KeyEventArgs)
        If sinEspacio = True Then
            SinEspacios()
        End If

        If alfanumerico = True Then
            esAlfanumerico()
        End If
    End Sub
End Class
