<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerarVentaForm
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
        Me.ApellidoLabel = New System.Windows.Forms.Label()
        Me.ApellidoTextBox = New TicketYa.MyTextBox()
        Me.NombreTextBox = New TicketYa.MyTextBox()
        Me.CompradoresComboBox = New TicketYa.MyComboBox()
        Me.CompradorGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumeroCompradorTextBox = New TicketYa.MyTextBox()
        Me.NombreLabel = New System.Windows.Forms.Label()
        Me.ShowGroupBox = New System.Windows.Forms.GroupBox()
        Me.FechaLabel = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FechasComboBox = New TicketYa.MyComboBox()
        Me.MyTextBox3 = New TicketYa.MyTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SectorComboBox = New TicketYa.MyComboBox()
        Me.SectorLabel = New System.Windows.Forms.Label()
        Me.BuscarShowButton = New TicketYa.MyButton()
        Me.NuevoCompradorButton = New TicketYa.MyButton()
        Me.BuscarCompradorButton = New TicketYa.MyButton()
        Me.CompradorGroupBox.SuspendLayout()
        Me.ShowGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ApellidoLabel
        '
        Me.ApellidoLabel.AutoSize = True
        Me.ApellidoLabel.Location = New System.Drawing.Point(8, 18)
        Me.ApellidoLabel.Name = "ApellidoLabel"
        Me.ApellidoLabel.Size = New System.Drawing.Size(44, 13)
        Me.ApellidoLabel.TabIndex = 1
        Me.ApellidoLabel.Text = "Apellido"
        '
        'ApellidoTextBox
        '
        Me.ApellidoTextBox.alfanumerico = False
        Me.ApellidoTextBox.boton = Nothing
        Me.ApellidoTextBox.Location = New System.Drawing.Point(81, 15)
        Me.ApellidoTextBox.nada = False
        Me.ApellidoTextBox.Name = "ApellidoTextBox"
        Me.ApellidoTextBox.numerico = False
        Me.ApellidoTextBox.sinEspacio = False
        Me.ApellidoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ApellidoTextBox.TabIndex = 2
        Me.ApellidoTextBox.texto = False
        '
        'NombreTextBox
        '
        Me.NombreTextBox.alfanumerico = False
        Me.NombreTextBox.boton = Nothing
        Me.NombreTextBox.Location = New System.Drawing.Point(81, 45)
        Me.NombreTextBox.nada = False
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.numerico = False
        Me.NombreTextBox.sinEspacio = False
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NombreTextBox.TabIndex = 3
        Me.NombreTextBox.texto = False
        '
        'CompradoresComboBox
        '
        Me.CompradoresComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CompradoresComboBox.emptyItem = Nothing
        Me.CompradoresComboBox.FormattingEnabled = True
        Me.CompradoresComboBox.lista = Nothing
        Me.CompradoresComboBox.Location = New System.Drawing.Point(428, 15)
        Me.CompradoresComboBox.Name = "CompradoresComboBox"
        Me.CompradoresComboBox.Size = New System.Drawing.Size(205, 21)
        Me.CompradoresComboBox.TabIndex = 4
        '
        'CompradorGroupBox
        '
        Me.CompradorGroupBox.Controls.Add(Me.Label1)
        Me.CompradorGroupBox.Controls.Add(Me.NumeroCompradorTextBox)
        Me.CompradorGroupBox.Controls.Add(Me.NombreLabel)
        Me.CompradorGroupBox.Controls.Add(Me.NuevoCompradorButton)
        Me.CompradorGroupBox.Controls.Add(Me.BuscarCompradorButton)
        Me.CompradorGroupBox.Controls.Add(Me.ApellidoLabel)
        Me.CompradorGroupBox.Controls.Add(Me.CompradoresComboBox)
        Me.CompradorGroupBox.Controls.Add(Me.ApellidoTextBox)
        Me.CompradorGroupBox.Controls.Add(Me.NombreTextBox)
        Me.CompradorGroupBox.Location = New System.Drawing.Point(4, 12)
        Me.CompradorGroupBox.Name = "CompradorGroupBox"
        Me.CompradorGroupBox.Size = New System.Drawing.Size(765, 70)
        Me.CompradorGroupBox.TabIndex = 6
        Me.CompradorGroupBox.TabStop = False
        Me.CompradorGroupBox.Text = "Comprador"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(183, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "N° Comprador"
        '
        'NumeroCompradorTextBox
        '
        Me.NumeroCompradorTextBox.alfanumerico = False
        Me.NumeroCompradorTextBox.boton = Nothing
        Me.NumeroCompradorTextBox.Location = New System.Drawing.Point(267, 15)
        Me.NumeroCompradorTextBox.nada = False
        Me.NumeroCompradorTextBox.Name = "NumeroCompradorTextBox"
        Me.NumeroCompradorTextBox.numerico = False
        Me.NumeroCompradorTextBox.sinEspacio = False
        Me.NumeroCompradorTextBox.Size = New System.Drawing.Size(100, 20)
        Me.NumeroCompradorTextBox.TabIndex = 8
        Me.NumeroCompradorTextBox.texto = False
        '
        'NombreLabel
        '
        Me.NombreLabel.AutoSize = True
        Me.NombreLabel.Location = New System.Drawing.Point(8, 48)
        Me.NombreLabel.Name = "NombreLabel"
        Me.NombreLabel.Size = New System.Drawing.Size(44, 13)
        Me.NombreLabel.TabIndex = 6
        Me.NombreLabel.Text = "Nombre"
        '
        'ShowGroupBox
        '
        Me.ShowGroupBox.Controls.Add(Me.FechaLabel)
        Me.ShowGroupBox.Controls.Add(Me.Label3)
        Me.ShowGroupBox.Controls.Add(Me.BuscarShowButton)
        Me.ShowGroupBox.Controls.Add(Me.FechasComboBox)
        Me.ShowGroupBox.Controls.Add(Me.MyTextBox3)
        Me.ShowGroupBox.Location = New System.Drawing.Point(4, 88)
        Me.ShowGroupBox.Name = "ShowGroupBox"
        Me.ShowGroupBox.Size = New System.Drawing.Size(765, 70)
        Me.ShowGroupBox.TabIndex = 9
        Me.ShowGroupBox.TabStop = False
        Me.ShowGroupBox.Text = "Show"
        '
        'FechaLabel
        '
        Me.FechaLabel.AutoSize = True
        Me.FechaLabel.Location = New System.Drawing.Point(372, 22)
        Me.FechaLabel.Name = "FechaLabel"
        Me.FechaLabel.Size = New System.Drawing.Size(37, 13)
        Me.FechaLabel.TabIndex = 7
        Me.FechaLabel.Text = "Fecha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nombre"
        '
        'FechasComboBox
        '
        Me.FechasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.FechasComboBox.emptyItem = Nothing
        Me.FechasComboBox.FormattingEnabled = True
        Me.FechasComboBox.lista = Nothing
        Me.FechasComboBox.Location = New System.Drawing.Point(428, 19)
        Me.FechasComboBox.Name = "FechasComboBox"
        Me.FechasComboBox.Size = New System.Drawing.Size(205, 21)
        Me.FechasComboBox.TabIndex = 4
        '
        'MyTextBox3
        '
        Me.MyTextBox3.alfanumerico = False
        Me.MyTextBox3.boton = Nothing
        Me.MyTextBox3.Location = New System.Drawing.Point(81, 20)
        Me.MyTextBox3.nada = False
        Me.MyTextBox3.Name = "MyTextBox3"
        Me.MyTextBox3.numerico = False
        Me.MyTextBox3.sinEspacio = False
        Me.MyTextBox3.Size = New System.Drawing.Size(100, 20)
        Me.MyTextBox3.TabIndex = 3
        Me.MyTextBox3.texto = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SectorComboBox)
        Me.GroupBox1.Controls.Add(Me.SectorLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 164)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(765, 202)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sector"
        '
        'SectorComboBox
        '
        Me.SectorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SectorComboBox.emptyItem = Nothing
        Me.SectorComboBox.FormattingEnabled = True
        Me.SectorComboBox.lista = Nothing
        Me.SectorComboBox.Location = New System.Drawing.Point(81, 17)
        Me.SectorComboBox.Name = "SectorComboBox"
        Me.SectorComboBox.Size = New System.Drawing.Size(175, 21)
        Me.SectorComboBox.TabIndex = 1
        '
        'SectorLabel
        '
        Me.SectorLabel.AutoSize = True
        Me.SectorLabel.Location = New System.Drawing.Point(8, 20)
        Me.SectorLabel.Name = "SectorLabel"
        Me.SectorLabel.Size = New System.Drawing.Size(38, 13)
        Me.SectorLabel.TabIndex = 0
        Me.SectorLabel.Text = "Sector"
        '
        'BuscarShowButton
        '
        Me.BuscarShowButton.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarShowButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BuscarShowButton.Location = New System.Drawing.Point(276, 19)
        Me.BuscarShowButton.Name = "BuscarShowButton"
        Me.BuscarShowButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarShowButton.TabIndex = 5
        Me.BuscarShowButton.Text = "Buscar"
        Me.BuscarShowButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BuscarShowButton.UseVisualStyleBackColor = True
        '
        'NuevoCompradorButton
        '
        Me.NuevoCompradorButton.Image = Global.TicketYa.My.Resources.Resources.nuevo
        Me.NuevoCompradorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.NuevoCompradorButton.Location = New System.Drawing.Point(675, 10)
        Me.NuevoCompradorButton.Name = "NuevoCompradorButton"
        Me.NuevoCompradorButton.Size = New System.Drawing.Size(75, 23)
        Me.NuevoCompradorButton.TabIndex = 0
        Me.NuevoCompradorButton.Text = "Nuevo"
        Me.NuevoCompradorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NuevoCompradorButton.UseVisualStyleBackColor = True
        '
        'BuscarCompradorButton
        '
        Me.BuscarCompradorButton.Image = Global.TicketYa.My.Resources.Resources.buscar
        Me.BuscarCompradorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BuscarCompradorButton.Location = New System.Drawing.Point(276, 43)
        Me.BuscarCompradorButton.Name = "BuscarCompradorButton"
        Me.BuscarCompradorButton.Size = New System.Drawing.Size(75, 23)
        Me.BuscarCompradorButton.TabIndex = 5
        Me.BuscarCompradorButton.Text = "Buscar"
        Me.BuscarCompradorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BuscarCompradorButton.UseVisualStyleBackColor = True
        '
        'GenerarVentaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(781, 446)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ShowGroupBox)
        Me.Controls.Add(Me.CompradorGroupBox)
        Me.Name = "GenerarVentaForm"
        Me.Text = "Generar Venta"
        Me.CompradorGroupBox.ResumeLayout(False)
        Me.CompradorGroupBox.PerformLayout()
        Me.ShowGroupBox.ResumeLayout(False)
        Me.ShowGroupBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NuevoCompradorButton As TicketYa.MyButton
    Friend WithEvents ApellidoLabel As System.Windows.Forms.Label
    Friend WithEvents ApellidoTextBox As TicketYa.MyTextBox
    Friend WithEvents NombreTextBox As TicketYa.MyTextBox
    Friend WithEvents CompradoresComboBox As TicketYa.MyComboBox
    Friend WithEvents BuscarCompradorButton As TicketYa.MyButton
    Friend WithEvents CompradorGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents NombreLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumeroCompradorTextBox As TicketYa.MyTextBox
    Friend WithEvents ShowGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BuscarShowButton As TicketYa.MyButton
    Friend WithEvents FechasComboBox As TicketYa.MyComboBox
    Friend WithEvents MyTextBox3 As TicketYa.MyTextBox
    Friend WithEvents FechaLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SectorComboBox As TicketYa.MyComboBox
    Friend WithEvents SectorLabel As System.Windows.Forms.Label

End Class
