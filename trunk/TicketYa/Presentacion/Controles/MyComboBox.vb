Public Class MyComboBox
    Inherits ComboBox


    Private _emptyItem As BE.PersistibleBE
    Public Property emptyItem() As BE.PersistibleBE
        Get
            Return _emptyItem
        End Get
        Set(ByVal value As BE.PersistibleBE)
            _emptyItem = value
        End Set
    End Property


    Private _lista As List(Of BE.PersistibleBE)
    Public Property lista() As List(Of BE.PersistibleBE)
        Get
            Return _lista
        End Get
        Set(ByVal value As List(Of BE.PersistibleBE))
            _lista = value
        End Set
    End Property


    Public Sub New()
        Me.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
    End Sub

    Public Sub datos()
        Me.Items.Add(Me.emptyItem)
        Me.Items.AddRange(Me.lista.ToArray)
        Me.SelectedIndex = 0
    End Sub

End Class
