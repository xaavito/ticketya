Imports System.Text.RegularExpressions

Public Class MyTextBox
    Inherits TextBox

    Dim errorProvider As New ErrorProvider
    Dim hasExistingErrorOnSpace As Boolean = False
    Dim hasExistingErrorOnAlfanumerico As Boolean = False
    Dim hasExistingErrorOnText As Boolean = False
    Dim hasExistingErrorOnNumber As Boolean = False
    Dim hasExistingErrorOnNothing As Boolean = False

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

    Private _numerico As Boolean
    Public Property numerico() As Boolean
        Get
            Return _numerico
        End Get
        Set(ByVal value As Boolean)
            _numerico = value
        End Set
    End Property

    Private _texto As Boolean
    Public Property texto() As Boolean
        Get
            Return _texto
        End Get
        Set(ByVal value As Boolean)
            _texto = value
        End Set
    End Property


    Private _nada As Boolean
    Public Property nada() As Boolean
        Get
            Return _nada
        End Get
        Set(ByVal value As Boolean)
            _nada = value
        End Set
    End Property


    'Private _isFecha As Boolean
    'Public Property isFecha() As Boolean
    '    Get
    '        Return _isFecha
    '    End Get
    '    Set(ByVal value As Boolean)
    '        _isFecha = value
    '    End Set
    'End Property

    Public Sub sinEspacios()
        If Regex.IsMatch(Me.Text, "\s") And Me.Text.Length > 0 Then
            errorProvider.SetError(Me, "No debe tener espacios")
            hasExistingErrorOnSpace = True
            Return
        Else
            hasExistingErrorOnSpace = False
        End If
        hasExistingErrorOnSpace = False
    End Sub

    Public Sub soloTexto()
        If Not String.IsNullOrEmpty(Me.Text) Then
            If Not Regex.IsMatch(Me.Text, "^[A-Za-z]*$") Then
                errorProvider.SetError(Me, "Debe ser solo texto")
                hasExistingErrorOnText = True
                Return
            Else
                hasExistingErrorOnText = False
            End If
        End If
        hasExistingErrorOnText = False
    End Sub

    Public Sub soloNumeros()
        If Not String.IsNullOrEmpty(Me.Text) Then
            If Not Regex.IsMatch(Me.Text, "^[0-9]*$") Then
                errorProvider.SetError(Me, "Debe ser solo numero")
                hasExistingErrorOnNumber = True
                Return
            Else
                hasExistingErrorOnNumber = False
            End If
        End If
        hasExistingErrorOnNumber = False
    End Sub

    Public Sub esAlfanumerico()
        If Not String.IsNullOrEmpty(Me.Text) Then
            If Not Regex.IsMatch(Me.Text, "^[A-Z0-9 a-z]*$") Then
                errorProvider.SetError(Me, "Debe tener un valor")
                hasExistingErrorOnAlfanumerico = True
                Return
            Else
                hasExistingErrorOnAlfanumerico = False
            End If
        End If
        hasExistingErrorOnAlfanumerico = False
    End Sub


    Private Sub tieneAlgo()
        'If String.IsNullOrEmpty(Me.Text) Then
        '    hasExistingErrorOnNothing = True
        '    Return
        'Else
        '    hasExistingErrorOnNothing = False
        'End If
        'hasExistingErrorOnNothing = False
    End Sub

    Protected Overrides Sub OnKeyUp(ByVal e As KeyEventArgs)
        logica()
    End Sub

    Private Sub checkFixedError()
        If (hasExistingErrorOnAlfanumerico = False And hasExistingErrorOnSpace = False And
            hasExistingErrorOnText = False And hasExistingErrorOnNumber = False And hasExistingErrorOnNothing = False) Then
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


    Protected Overrides Sub OnGotFocus(ByVal e As System.EventArgs)
        logica()
    End Sub

    Private Sub logica()
        If sinEspacio = True Then
            sinEspacios()
        End If

        If alfanumerico = True Then
            esAlfanumerico()
        End If

        If texto = True Then
            soloTexto()
        End If

        If numerico = True Then
            soloNumeros()
        End If

        If nada = False Then
            tieneAlgo()
        End If

        'If isFecha = True Then
        '    esfecha()
        'End If

        checkFixedError()
    End Sub

    Public Function esVacio() As Boolean
        If String.IsNullOrWhiteSpace(Me.Text) Or String.IsNullOrEmpty(Me.Text) Then
            Return True
        End If
        Return False
    End Function

    'Private Sub esfecha()
    '    Me.m()
    '    Throw (New NotImplementedException)
    'End Sub

End Class
