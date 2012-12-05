<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerarPromocionForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenerarPromocionForm))
        Me.DescripcionLabel = New System.Windows.Forms.Label()
        Me.DescripcionTextBox = New TicketYa.MyTextBox()
        Me.DesdeLabel = New System.Windows.Forms.Label()
        Me.HastaLabel = New System.Windows.Forms.Label()
        Me.DescuentoTextBox = New TicketYa.MyTextBox()
        Me.DescuentoLabel = New System.Windows.Forms.Label()
        Me.GenerarPromocionButton = New TicketYa.MyButton()
        Me.SectorLabel = New System.Windows.Forms.Label()
        Me.SectorComboBox = New TicketYa.MyComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ShowLabel = New System.Windows.Forms.Label()
        Me.FechaComboBox = New TicketYa.MyComboBox()
        Me.ShowComboBox = New TicketYa.MyComboBox()
        Me.DesdeTextBox = New TicketYa.MyMaskedTextBox()
        Me.HastaTextBox = New TicketYa.MyMaskedTextBox()
        Me.TipoLabel = New System.Windows.Forms.Label()
        Me.TipoDescuentoComboBox = New TicketYa.MyComboBox()
        Me.SuspendLayout()
        '
        'DescripcionLabel
        '
        Me.DescripcionLabel.AutoSize = True
        Me.DescripcionLabel.Location = New System.Drawing.Point(12, 19)
        Me.DescripcionLabel.Name = "DescripcionLabel"
        Me.DescripcionLabel.Size = New System.Drawing.Size(63, 13)
        Me.DescripcionLabel.TabIndex = 0
        Me.DescripcionLabel.Text = "Descripcion"
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.alfanumerico = False
        Me.DescripcionTextBox.boton = Nothing
        Me.DescripcionTextBox.Location = New System.Drawing.Point(79, 16)
        Me.DescripcionTextBox.nada = False
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.numerico = False
        Me.DescripcionTextBox.sinEspacio = False
        Me.DescripcionTextBox.Size = New System.Drawing.Size(127, 20)
        Me.DescripcionTextBox.TabIndex = 1
        Me.DescripcionTextBox.texto = False
        '
        'DesdeLabel
        '
        Me.DesdeLabel.AutoSize = True
        Me.DesdeLabel.Location = New System.Drawing.Point(12, 45)
        Me.DesdeLabel.Name = "DesdeLabel"
        Me.DesdeLabel.Size = New System.Drawing.Size(38, 13)
        Me.DesdeLabel.TabIndex = 2
        Me.DesdeLabel.Text = "Desde"
        '
        'HastaLabel
        '
        Me.HastaLabel.AutoSize = True
        Me.HastaLabel.Location = New System.Drawing.Point(12, 71)
        Me.HastaLabel.Name = "HastaLabel"
        Me.HastaLabel.Size = New System.Drawing.Size(35, 13)
        Me.HastaLabel.TabIndex = 4
        Me.HastaLabel.Text = "Hasta"
        '
        'DescuentoTextBox
        '
        Me.DescuentoTextBox.alfanumerico = False
        Me.DescuentoTextBox.boton = Nothing
        Me.DescuentoTextBox.Location = New System.Drawing.Point(79, 97)
        Me.DescuentoTextBox.nada = False
        Me.DescuentoTextBox.Name = "DescuentoTextBox"
        Me.DescuentoTextBox.numerico = False
        Me.DescuentoTextBox.sinEspacio = False
        Me.DescuentoTextBox.Size = New System.Drawing.Size(127, 20)
        Me.DescuentoTextBox.TabIndex = 9
        Me.DescuentoTextBox.texto = False
        '
        'DescuentoLabel
        '
        Me.DescuentoLabel.AutoSize = True
        Me.DescuentoLabel.Location = New System.Drawing.Point(12, 99)
        Me.DescuentoLabel.Name = "DescuentoLabel"
        Me.DescuentoLabel.Size = New System.Drawing.Size(59, 13)
        Me.DescuentoLabel.TabIndex = 8
        Me.DescuentoLabel.Text = "Descuento"
        '
        'GenerarPromocionButton
        '
        Me.GenerarPromocionButton.Image = CType(resources.GetObject("GenerarPromocionButton.Image"), System.Drawing.Image)
        Me.GenerarPromocionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GenerarPromocionButton.Location = New System.Drawing.Point(255, 14)
        Me.GenerarPromocionButton.Name = "GenerarPromocionButton"
        Me.GenerarPromocionButton.Size = New System.Drawing.Size(75, 23)
        Me.GenerarPromocionButton.TabIndex = 10
        Me.GenerarPromocionButton.Text = "Generar"
        Me.GenerarPromocionButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GenerarPromocionButton.UseVisualStyleBackColor = True
        '
        'SectorLabel
        '
        Me.SectorLabel.AutoSize = True
        Me.SectorLabel.Location = New System.Drawing.Point(12, 208)
        Me.SectorLabel.Name = "SectorLabel"
        Me.SectorLabel.Size = New System.Drawing.Size(38, 13)
        Me.SectorLabel.TabIndex = 38
        Me.SectorLabel.Text = "Sector"
        '
        'SectorComboBox
        '
        Me.SectorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SectorComboBox.emptyItem = Nothing
        Me.SectorComboBox.FormattingEnabled = True
        Me.SectorComboBox.lista = Nothing
        Me.SectorComboBox.Location = New System.Drawing.Point(79, 205)
        Me.SectorComboBox.Name = "SectorComboBox"
        Me.SectorComboBox.Size = New System.Drawing.Size(205, 21)
        Me.SectorComboBox.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Fecha"
        '
        'ShowLabel
        '
        Me.ShowLabel.AutoSize = True
        Me.ShowLabel.Location = New System.Drawing.Point(12, 156)
        Me.ShowLabel.Name = "ShowLabel"
        Me.ShowLabel.Size = New System.Drawing.Size(34, 13)
        Me.ShowLabel.TabIndex = 35
        Me.ShowLabel.Text = "Show"
        '
        'FechaComboBox
        '
        Me.FechaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FechaComboBox.emptyItem = Nothing
        Me.FechaComboBox.FormattingEnabled = True
        Me.FechaComboBox.lista = Nothing
        Me.FechaComboBox.Location = New System.Drawing.Point(79, 178)
        Me.FechaComboBox.Name = "FechaComboBox"
        Me.FechaComboBox.Size = New System.Drawing.Size(205, 21)
        Me.FechaComboBox.TabIndex = 34
        '
        'ShowComboBox
        '
        Me.ShowComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ShowComboBox.emptyItem = Nothing
        Me.ShowComboBox.FormattingEnabled = True
        Me.ShowComboBox.lista = Nothing
        Me.ShowComboBox.Location = New System.Drawing.Point(79, 153)
        Me.ShowComboBox.Name = "ShowComboBox"
        Me.ShowComboBox.Size = New System.Drawing.Size(205, 21)
        Me.ShowComboBox.TabIndex = 33
        '
        'DesdeTextBox
        '
        Me.DesdeTextBox.Location = New System.Drawing.Point(79, 42)
        Me.DesdeTextBox.Mask = "00/00/0000"
        Me.DesdeTextBox.Name = "DesdeTextBox"
        Me.DesdeTextBox.Size = New System.Drawing.Size(66, 20)
        Me.DesdeTextBox.TabIndex = 39
        '
        'HastaTextBox
        '
        Me.HastaTextBox.Location = New System.Drawing.Point(79, 69)
        Me.HastaTextBox.Mask = "00/00/0000"
        Me.HastaTextBox.Name = "HastaTextBox"
        Me.HastaTextBox.Size = New System.Drawing.Size(66, 20)
        Me.HastaTextBox.TabIndex = 40
        '
        'TipoLabel
        '
        Me.TipoLabel.AutoSize = True
        Me.TipoLabel.Location = New System.Drawing.Point(12, 126)
        Me.TipoLabel.Name = "TipoLabel"
        Me.TipoLabel.Size = New System.Drawing.Size(28, 13)
        Me.TipoLabel.TabIndex = 41
        Me.TipoLabel.Text = "Tipo"
        '
        'TipoDescuentoComboBox
        '
        Me.TipoDescuentoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TipoDescuentoComboBox.emptyItem = Nothing
        Me.TipoDescuentoComboBox.FormattingEnabled = True
        Me.TipoDescuentoComboBox.lista = Nothing
        Me.TipoDescuentoComboBox.Location = New System.Drawing.Point(79, 123)
        Me.TipoDescuentoComboBox.Name = "TipoDescuentoComboBox"
        Me.TipoDescuentoComboBox.Size = New System.Drawing.Size(127, 21)
        Me.TipoDescuentoComboBox.TabIndex = 42
        '
        'GenerarPromocionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(385, 274)
        Me.Controls.Add(Me.TipoDescuentoComboBox)
        Me.Controls.Add(Me.TipoLabel)
        Me.Controls.Add(Me.HastaTextBox)
        Me.Controls.Add(Me.DesdeTextBox)
        Me.Controls.Add(Me.SectorLabel)
        Me.Controls.Add(Me.SectorComboBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ShowLabel)
        Me.Controls.Add(Me.FechaComboBox)
        Me.Controls.Add(Me.ShowComboBox)
        Me.Controls.Add(Me.GenerarPromocionButton)
        Me.Controls.Add(Me.DescuentoTextBox)
        Me.Controls.Add(Me.DescuentoLabel)
        Me.Controls.Add(Me.HastaLabel)
        Me.Controls.Add(Me.DesdeLabel)
        Me.Controls.Add(Me.DescripcionTextBox)
        Me.Controls.Add(Me.DescripcionLabel)
        Me.Name = "GenerarPromocionForm"
        Me.Text = "Generar Promocion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DescripcionLabel As System.Windows.Forms.Label
    Friend WithEvents DescripcionTextBox As TicketYa.MyTextBox
    Friend WithEvents DesdeLabel As System.Windows.Forms.Label
    Friend WithEvents HastaLabel As System.Windows.Forms.Label
    Friend WithEvents DescuentoTextBox As TicketYa.MyTextBox
    Friend WithEvents DescuentoLabel As System.Windows.Forms.Label
    Friend WithEvents GenerarPromocionButton As TicketYa.MyButton
    Friend WithEvents SectorLabel As System.Windows.Forms.Label
    Friend WithEvents SectorComboBox As TicketYa.MyComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ShowLabel As System.Windows.Forms.Label
    Friend WithEvents FechaComboBox As TicketYa.MyComboBox
    Friend WithEvents ShowComboBox As TicketYa.MyComboBox
    Friend WithEvents DesdeTextBox As TicketYa.MyMaskedTextBox
    Friend WithEvents HastaTextBox As TicketYa.MyMaskedTextBox
    Friend WithEvents TipoLabel As System.Windows.Forms.Label
    Friend WithEvents TipoDescuentoComboBox As TicketYa.MyComboBox

End Class
