<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerarSectorForm
    Inherits TicketYa.BaseForm

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ShowComboBox = New TicketYa.MyComboBox()
        Me.FechaLabel = New System.Windows.Forms.Label()
        Me.ShowLabel = New System.Windows.Forms.Label()
        Me.NombreTextBox = New TicketYa.MyTextBox()
        Me.NombreLabel = New System.Windows.Forms.Label()
        Me.AltaSectorButton = New TicketYa.MyButton()
        Me.FechaComboBox = New TicketYa.MyComboBox()
        Me.TipoSectorComboBox = New TicketYa.MyComboBox()
        Me.TipoSectorLabel = New System.Windows.Forms.Label()
        Me.FilasTextBox = New TicketYa.MyTextBox()
        Me.FilaLabel = New System.Windows.Forms.Label()
        Me.ColumnasTextBox = New TicketYa.MyTextBox()
        Me.ColumnaLabel = New System.Windows.Forms.Label()
        Me.PrecioTextBox = New TicketYa.MyTextBox()
        Me.PrecioLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ShowComboBox
        '
        Me.ShowComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ShowComboBox.emptyItem = Nothing
        Me.ShowComboBox.FormattingEnabled = True
        Me.ShowComboBox.lista = Nothing
        Me.ShowComboBox.Location = New System.Drawing.Point(97, 37)
        Me.ShowComboBox.Name = "ShowComboBox"
        Me.ShowComboBox.Size = New System.Drawing.Size(169, 21)
        Me.ShowComboBox.TabIndex = 37
        '
        'FechaLabel
        '
        Me.FechaLabel.AutoSize = True
        Me.FechaLabel.Location = New System.Drawing.Point(18, 67)
        Me.FechaLabel.Name = "FechaLabel"
        Me.FechaLabel.Size = New System.Drawing.Size(37, 13)
        Me.FechaLabel.TabIndex = 35
        Me.FechaLabel.Text = "Fecha"
        '
        'ShowLabel
        '
        Me.ShowLabel.AutoSize = True
        Me.ShowLabel.Location = New System.Drawing.Point(18, 41)
        Me.ShowLabel.Name = "ShowLabel"
        Me.ShowLabel.Size = New System.Drawing.Size(34, 13)
        Me.ShowLabel.TabIndex = 34
        Me.ShowLabel.Text = "Show"
        '
        'NombreTextBox
        '
        Me.NombreTextBox.alfanumerico = False
        Me.NombreTextBox.boton = Nothing
        Me.NombreTextBox.Location = New System.Drawing.Point(97, 12)
        Me.NombreTextBox.mail = False
        Me.NombreTextBox.nada = False
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.numerico = False
        Me.NombreTextBox.sinEspacio = False
        Me.NombreTextBox.Size = New System.Drawing.Size(169, 20)
        Me.NombreTextBox.TabIndex = 33
        Me.NombreTextBox.texto = False
        '
        'NombreLabel
        '
        Me.NombreLabel.AutoSize = True
        Me.NombreLabel.Location = New System.Drawing.Point(18, 15)
        Me.NombreLabel.Name = "NombreLabel"
        Me.NombreLabel.Size = New System.Drawing.Size(44, 13)
        Me.NombreLabel.TabIndex = 32
        Me.NombreLabel.Text = "Nombre"
        '
        'AltaSectorButton
        '
        Me.AltaSectorButton.Image = Global.TicketYa.My.Resources.Resources.aceptar
        Me.AltaSectorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AltaSectorButton.Location = New System.Drawing.Point(321, 12)
        Me.AltaSectorButton.Name = "AltaSectorButton"
        Me.AltaSectorButton.Size = New System.Drawing.Size(75, 23)
        Me.AltaSectorButton.TabIndex = 36
        Me.AltaSectorButton.Text = "Generar"
        Me.AltaSectorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AltaSectorButton.UseVisualStyleBackColor = True
        '
        'FechaComboBox
        '
        Me.FechaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FechaComboBox.emptyItem = Nothing
        Me.FechaComboBox.FormattingEnabled = True
        Me.FechaComboBox.lista = Nothing
        Me.FechaComboBox.Location = New System.Drawing.Point(97, 64)
        Me.FechaComboBox.Name = "FechaComboBox"
        Me.FechaComboBox.Size = New System.Drawing.Size(169, 21)
        Me.FechaComboBox.TabIndex = 38
        '
        'TipoSectorComboBox
        '
        Me.TipoSectorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TipoSectorComboBox.emptyItem = Nothing
        Me.TipoSectorComboBox.FormattingEnabled = True
        Me.TipoSectorComboBox.lista = Nothing
        Me.TipoSectorComboBox.Location = New System.Drawing.Point(97, 91)
        Me.TipoSectorComboBox.Name = "TipoSectorComboBox"
        Me.TipoSectorComboBox.Size = New System.Drawing.Size(169, 21)
        Me.TipoSectorComboBox.TabIndex = 40
        '
        'TipoSectorLabel
        '
        Me.TipoSectorLabel.AutoSize = True
        Me.TipoSectorLabel.Location = New System.Drawing.Point(18, 94)
        Me.TipoSectorLabel.Name = "TipoSectorLabel"
        Me.TipoSectorLabel.Size = New System.Drawing.Size(28, 13)
        Me.TipoSectorLabel.TabIndex = 39
        Me.TipoSectorLabel.Text = "Tipo"
        '
        'FilasTextBox
        '
        Me.FilasTextBox.alfanumerico = False
        Me.FilasTextBox.boton = Nothing
        Me.FilasTextBox.Location = New System.Drawing.Point(97, 118)
        Me.FilasTextBox.mail = False
        Me.FilasTextBox.nada = False
        Me.FilasTextBox.Name = "FilasTextBox"
        Me.FilasTextBox.numerico = False
        Me.FilasTextBox.sinEspacio = False
        Me.FilasTextBox.Size = New System.Drawing.Size(48, 20)
        Me.FilasTextBox.TabIndex = 42
        Me.FilasTextBox.texto = False
        '
        'FilaLabel
        '
        Me.FilaLabel.AutoSize = True
        Me.FilaLabel.Location = New System.Drawing.Point(18, 121)
        Me.FilaLabel.Name = "FilaLabel"
        Me.FilaLabel.Size = New System.Drawing.Size(28, 13)
        Me.FilaLabel.TabIndex = 41
        Me.FilaLabel.Text = "Filas"
        '
        'ColumnasTextBox
        '
        Me.ColumnasTextBox.alfanumerico = False
        Me.ColumnasTextBox.boton = Nothing
        Me.ColumnasTextBox.Location = New System.Drawing.Point(218, 118)
        Me.ColumnasTextBox.mail = False
        Me.ColumnasTextBox.nada = False
        Me.ColumnasTextBox.Name = "ColumnasTextBox"
        Me.ColumnasTextBox.numerico = False
        Me.ColumnasTextBox.sinEspacio = False
        Me.ColumnasTextBox.Size = New System.Drawing.Size(48, 20)
        Me.ColumnasTextBox.TabIndex = 44
        Me.ColumnasTextBox.texto = False
        '
        'ColumnaLabel
        '
        Me.ColumnaLabel.AutoSize = True
        Me.ColumnaLabel.Location = New System.Drawing.Point(151, 121)
        Me.ColumnaLabel.Name = "ColumnaLabel"
        Me.ColumnaLabel.Size = New System.Drawing.Size(53, 13)
        Me.ColumnaLabel.TabIndex = 43
        Me.ColumnaLabel.Text = "Columnas"
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.alfanumerico = False
        Me.PrecioTextBox.boton = Nothing
        Me.PrecioTextBox.Location = New System.Drawing.Point(97, 144)
        Me.PrecioTextBox.mail = False
        Me.PrecioTextBox.nada = False
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.numerico = False
        Me.PrecioTextBox.sinEspacio = False
        Me.PrecioTextBox.Size = New System.Drawing.Size(48, 20)
        Me.PrecioTextBox.TabIndex = 46
        Me.PrecioTextBox.texto = False
        '
        'PrecioLabel
        '
        Me.PrecioLabel.AutoSize = True
        Me.PrecioLabel.Location = New System.Drawing.Point(18, 147)
        Me.PrecioLabel.Name = "PrecioLabel"
        Me.PrecioLabel.Size = New System.Drawing.Size(37, 13)
        Me.PrecioLabel.TabIndex = 45
        Me.PrecioLabel.Text = "Precio"
        '
        'GenerarSectorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(415, 184)
        Me.Controls.Add(Me.PrecioTextBox)
        Me.Controls.Add(Me.PrecioLabel)
        Me.Controls.Add(Me.ColumnasTextBox)
        Me.Controls.Add(Me.ColumnaLabel)
        Me.Controls.Add(Me.FilasTextBox)
        Me.Controls.Add(Me.FilaLabel)
        Me.Controls.Add(Me.TipoSectorComboBox)
        Me.Controls.Add(Me.TipoSectorLabel)
        Me.Controls.Add(Me.FechaComboBox)
        Me.Controls.Add(Me.ShowComboBox)
        Me.Controls.Add(Me.AltaSectorButton)
        Me.Controls.Add(Me.FechaLabel)
        Me.Controls.Add(Me.ShowLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(Me.NombreLabel)
        Me.Name = "GenerarSectorForm"
        Me.Text = "Generar Sector"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ShowComboBox As TicketYa.MyComboBox
    Friend WithEvents AltaSectorButton As TicketYa.MyButton
    Friend WithEvents FechaLabel As System.Windows.Forms.Label
    Friend WithEvents ShowLabel As System.Windows.Forms.Label
    Friend WithEvents NombreTextBox As TicketYa.MyTextBox
    Friend WithEvents NombreLabel As System.Windows.Forms.Label
    Friend WithEvents FechaComboBox As TicketYa.MyComboBox
    Friend WithEvents TipoSectorComboBox As TicketYa.MyComboBox
    Friend WithEvents TipoSectorLabel As System.Windows.Forms.Label
    Friend WithEvents FilasTextBox As TicketYa.MyTextBox
    Friend WithEvents FilaLabel As System.Windows.Forms.Label
    Friend WithEvents ColumnasTextBox As TicketYa.MyTextBox
    Friend WithEvents ColumnaLabel As System.Windows.Forms.Label
    Friend WithEvents PrecioTextBox As TicketYa.MyTextBox
    Friend WithEvents PrecioLabel As System.Windows.Forms.Label

End Class
