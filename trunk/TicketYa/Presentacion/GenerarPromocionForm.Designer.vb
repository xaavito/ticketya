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
        Me.MyTextBox2 = New TicketYa.MyTextBox()
        Me.DesdeLabel = New System.Windows.Forms.Label()
        Me.MyTextBox3 = New TicketYa.MyTextBox()
        Me.HastaLabel = New System.Windows.Forms.Label()
        Me.ShowLabel = New System.Windows.Forms.Label()
        Me.MyComboBox1 = New TicketYa.MyComboBox()
        Me.MyTextBox4 = New TicketYa.MyTextBox()
        Me.DescuentoLabel = New System.Windows.Forms.Label()
        Me.GenerarPromocionButton = New TicketYa.MyButton()
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
        Me.DescripcionTextBox.Location = New System.Drawing.Point(81, 16)
        Me.DescripcionTextBox.nada = False
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.numerico = False
        Me.DescripcionTextBox.sinEspacio = False
        Me.DescripcionTextBox.Size = New System.Drawing.Size(127, 20)
        Me.DescripcionTextBox.TabIndex = 1
        Me.DescripcionTextBox.texto = False
        '
        'MyTextBox2
        '
        Me.MyTextBox2.alfanumerico = False
        Me.MyTextBox2.boton = Nothing
        Me.MyTextBox2.Location = New System.Drawing.Point(81, 42)
        Me.MyTextBox2.nada = False
        Me.MyTextBox2.Name = "MyTextBox2"
        Me.MyTextBox2.numerico = False
        Me.MyTextBox2.sinEspacio = False
        Me.MyTextBox2.Size = New System.Drawing.Size(127, 20)
        Me.MyTextBox2.TabIndex = 3
        Me.MyTextBox2.texto = False
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
        'MyTextBox3
        '
        Me.MyTextBox3.alfanumerico = False
        Me.MyTextBox3.boton = Nothing
        Me.MyTextBox3.Location = New System.Drawing.Point(81, 71)
        Me.MyTextBox3.nada = False
        Me.MyTextBox3.Name = "MyTextBox3"
        Me.MyTextBox3.numerico = False
        Me.MyTextBox3.sinEspacio = False
        Me.MyTextBox3.Size = New System.Drawing.Size(127, 20)
        Me.MyTextBox3.TabIndex = 5
        Me.MyTextBox3.texto = False
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
        'ShowLabel
        '
        Me.ShowLabel.AutoSize = True
        Me.ShowLabel.Location = New System.Drawing.Point(12, 99)
        Me.ShowLabel.Name = "ShowLabel"
        Me.ShowLabel.Size = New System.Drawing.Size(34, 13)
        Me.ShowLabel.TabIndex = 6
        Me.ShowLabel.Text = "Show"
        '
        'MyComboBox1
        '
        Me.MyComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MyComboBox1.emptyItem = Nothing
        Me.MyComboBox1.FormattingEnabled = True
        Me.MyComboBox1.lista = Nothing
        Me.MyComboBox1.Location = New System.Drawing.Point(81, 97)
        Me.MyComboBox1.Name = "MyComboBox1"
        Me.MyComboBox1.Size = New System.Drawing.Size(127, 21)
        Me.MyComboBox1.TabIndex = 7
        '
        'MyTextBox4
        '
        Me.MyTextBox4.alfanumerico = False
        Me.MyTextBox4.boton = Nothing
        Me.MyTextBox4.Location = New System.Drawing.Point(81, 124)
        Me.MyTextBox4.nada = False
        Me.MyTextBox4.Name = "MyTextBox4"
        Me.MyTextBox4.numerico = False
        Me.MyTextBox4.sinEspacio = False
        Me.MyTextBox4.Size = New System.Drawing.Size(127, 20)
        Me.MyTextBox4.TabIndex = 9
        Me.MyTextBox4.texto = False
        '
        'DescuentoLabel
        '
        Me.DescuentoLabel.AutoSize = True
        Me.DescuentoLabel.Location = New System.Drawing.Point(12, 126)
        Me.DescuentoLabel.Name = "DescuentoLabel"
        Me.DescuentoLabel.Size = New System.Drawing.Size(59, 13)
        Me.DescuentoLabel.TabIndex = 8
        Me.DescuentoLabel.Text = "Descuento"
        '
        'GenerarPromocionButton
        '
        Me.GenerarPromocionButton.Image = CType(resources.GetObject("GenerarPromocionButton.Image"), System.Drawing.Image)
        Me.GenerarPromocionButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GenerarPromocionButton.Location = New System.Drawing.Point(276, 16)
        Me.GenerarPromocionButton.Name = "GenerarPromocionButton"
        Me.GenerarPromocionButton.Size = New System.Drawing.Size(75, 23)
        Me.GenerarPromocionButton.TabIndex = 10
        Me.GenerarPromocionButton.Text = "Generar"
        Me.GenerarPromocionButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GenerarPromocionButton.UseVisualStyleBackColor = True
        '
        'GenerarPromocionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(397, 178)
        Me.Controls.Add(Me.GenerarPromocionButton)
        Me.Controls.Add(Me.MyTextBox4)
        Me.Controls.Add(Me.DescuentoLabel)
        Me.Controls.Add(Me.MyComboBox1)
        Me.Controls.Add(Me.ShowLabel)
        Me.Controls.Add(Me.MyTextBox3)
        Me.Controls.Add(Me.HastaLabel)
        Me.Controls.Add(Me.MyTextBox2)
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
    Friend WithEvents MyTextBox2 As TicketYa.MyTextBox
    Friend WithEvents DesdeLabel As System.Windows.Forms.Label
    Friend WithEvents MyTextBox3 As TicketYa.MyTextBox
    Friend WithEvents HastaLabel As System.Windows.Forms.Label
    Friend WithEvents ShowLabel As System.Windows.Forms.Label
    Friend WithEvents MyComboBox1 As TicketYa.MyComboBox
    Friend WithEvents MyTextBox4 As TicketYa.MyTextBox
    Friend WithEvents DescuentoLabel As System.Windows.Forms.Label
    Friend WithEvents GenerarPromocionButton As TicketYa.MyButton

End Class
