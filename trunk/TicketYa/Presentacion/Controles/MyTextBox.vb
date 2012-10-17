Imports System.Text.RegularExpressions

Public Class MyTextBox
    Inherits TextBox

    Dim errorProvider As New ErrorProvider
    Dim hasExistingErrorOnSpace As Boolean = False
    Dim hasExistingErrorOnAlfanumerico As Boolean = False

    Private _boton As Button
    Public Property boton() As Button
        Get
            Return _boton
        End Get
        Set(ByVal value As Button)
            _boton = value
        End Set
    End Property

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
        If Regex.IsMatch(Me.Text, "\s") And Me.Text.Length > 0 Then
            errorProvider.SetError(Me, "No debe tener espacios")
            hasExistingErrorOnSpace = True
        Else
            hasExistingErrorOnSpace = False
        End If
    End Sub

    Public Sub esAlfanumerico()
        If Not String.IsNullOrEmpty(Me.Text) Then
            If Not Regex.IsMatch(Me.Text, "^[A-Z0-9 a-z]*$") Then
                errorProvider.SetError(Me, "Debe tener un valor")
                hasExistingErrorOnAlfanumerico = True
            Else
                hasExistingErrorOnAlfanumerico = False
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

        checkFixedError()
    End Sub

    Private Sub checkFixedError()
        If (hasExistingErrorOnAlfanumerico = False And hasExistingErrorOnSpace = False) Then
            errorProvider.Clear()

            If Not boton Is Nothing Then
                boton.Enabled = True
            End If
        Else
            If Not boton Is Nothing Then
                boton.Enabled = False
            End If
        End If
    End Sub

End Class
