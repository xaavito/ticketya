﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarIdiomaForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarIdiomaForm))
        Me.ExcepcionLabel = New System.Windows.Forms.Label()
        Me.MensajeBitacoraLabel = New System.Windows.Forms.Label()
        Me.ControlesLabel = New System.Windows.Forms.Label()
        Me.ExcepcionesDataGrid = New TicketYa.MyDataGrid()
        Me.CodigoColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MensajeColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdentificadorColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MensajesDataGrid = New TicketYa.MyDataGrid()
        Me.IdBaseColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MensajeColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.identificador = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ControlesDataGrid = New TicketYa.MyDataGrid()
        Me.FormularioColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ControlColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Mensaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Identificador2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idFormulario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idControl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdiomaLabel = New System.Windows.Forms.Label()
        Me.IdiomaTextBox = New TicketYa.MyTextBox()
        Me.GuardarIdiomaButton = New TicketYa.MyButton()
        Me.CancelarButton = New TicketYa.MyButton()
        CType(Me.ExcepcionesDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MensajesDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ControlesDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ExcepcionLabel
        '
        Me.ExcepcionLabel.AutoSize = True
        Me.ExcepcionLabel.Location = New System.Drawing.Point(219, 66)
        Me.ExcepcionLabel.Name = "ExcepcionLabel"
        Me.ExcepcionLabel.Size = New System.Drawing.Size(68, 13)
        Me.ExcepcionLabel.TabIndex = 0
        Me.ExcepcionLabel.Text = "Excepciones"
        '
        'MensajeBitacoraLabel
        '
        Me.MensajeBitacoraLabel.AutoSize = True
        Me.MensajeBitacoraLabel.Location = New System.Drawing.Point(208, 249)
        Me.MensajeBitacoraLabel.Name = "MensajeBitacoraLabel"
        Me.MensajeBitacoraLabel.Size = New System.Drawing.Size(89, 13)
        Me.MensajeBitacoraLabel.TabIndex = 1
        Me.MensajeBitacoraLabel.Text = "Mensaje Bitacora"
        '
        'ControlesLabel
        '
        Me.ControlesLabel.AutoSize = True
        Me.ControlesLabel.Location = New System.Drawing.Point(219, 438)
        Me.ControlesLabel.Name = "ControlesLabel"
        Me.ControlesLabel.Size = New System.Drawing.Size(51, 13)
        Me.ControlesLabel.TabIndex = 2
        Me.ControlesLabel.Text = "Controles"
        '
        'ExcepcionesDataGrid
        '
        Me.ExcepcionesDataGrid.AllowUserToAddRows = False
        Me.ExcepcionesDataGrid.AllowUserToDeleteRows = False
        Me.ExcepcionesDataGrid.AllowUserToResizeRows = False
        Me.ExcepcionesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ExcepcionesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ExcepcionesDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoColumn, Me.MensajeColumn, Me.IdentificadorColumn})
        Me.ExcepcionesDataGrid.Location = New System.Drawing.Point(9, 82)
        Me.ExcepcionesDataGrid.Name = "ExcepcionesDataGrid"
        Me.ExcepcionesDataGrid.ReadOnly = True
        Me.ExcepcionesDataGrid.RowHeadersVisible = False
        Me.ExcepcionesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ExcepcionesDataGrid.Size = New System.Drawing.Size(472, 150)
        Me.ExcepcionesDataGrid.TabIndex = 3
        '
        'CodigoColumn
        '
        Me.CodigoColumn.DataPropertyName = "codigo"
        Me.CodigoColumn.HeaderText = "Codigo"
        Me.CodigoColumn.Name = "CodigoColumn"
        Me.CodigoColumn.ReadOnly = True
        Me.CodigoColumn.Visible = False
        '
        'MensajeColumn
        '
        Me.MensajeColumn.DataPropertyName = "mensaje"
        Me.MensajeColumn.HeaderText = "Mensaje"
        Me.MensajeColumn.Name = "MensajeColumn"
        Me.MensajeColumn.ReadOnly = True
        '
        'IdentificadorColumn
        '
        Me.IdentificadorColumn.DataPropertyName = "identificador"
        Me.IdentificadorColumn.HeaderText = "Identificador"
        Me.IdentificadorColumn.Name = "IdentificadorColumn"
        Me.IdentificadorColumn.ReadOnly = True
        Me.IdentificadorColumn.Visible = False
        '
        'MensajesDataGrid
        '
        Me.MensajesDataGrid.AllowUserToAddRows = False
        Me.MensajesDataGrid.AllowUserToDeleteRows = False
        Me.MensajesDataGrid.AllowUserToResizeRows = False
        Me.MensajesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.MensajesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MensajesDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdBaseColumn, Me.MensajeColumn2, Me.identificador})
        Me.MensajesDataGrid.Location = New System.Drawing.Point(9, 265)
        Me.MensajesDataGrid.Name = "MensajesDataGrid"
        Me.MensajesDataGrid.ReadOnly = True
        Me.MensajesDataGrid.RowHeadersVisible = False
        Me.MensajesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MensajesDataGrid.Size = New System.Drawing.Size(472, 150)
        Me.MensajesDataGrid.TabIndex = 4
        '
        'IdBaseColumn
        '
        Me.IdBaseColumn.DataPropertyName = "idBase"
        Me.IdBaseColumn.HeaderText = "IdBase"
        Me.IdBaseColumn.Name = "IdBaseColumn"
        Me.IdBaseColumn.ReadOnly = True
        Me.IdBaseColumn.Visible = False
        '
        'MensajeColumn2
        '
        Me.MensajeColumn2.DataPropertyName = "mensaje"
        Me.MensajeColumn2.HeaderText = "Mensaje"
        Me.MensajeColumn2.Name = "MensajeColumn2"
        Me.MensajeColumn2.ReadOnly = True
        '
        'identificador
        '
        Me.identificador.DataPropertyName = "identificador"
        Me.identificador.HeaderText = "Identificador"
        Me.identificador.Name = "identificador"
        Me.identificador.ReadOnly = True
        Me.identificador.Visible = False
        '
        'ControlesDataGrid
        '
        Me.ControlesDataGrid.AllowUserToAddRows = False
        Me.ControlesDataGrid.AllowUserToDeleteRows = False
        Me.ControlesDataGrid.AllowUserToResizeRows = False
        Me.ControlesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ControlesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ControlesDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FormularioColumn, Me.ControlColumn, Me.Mensaje, Me.Identificador2, Me.idFormulario, Me.idControl})
        Me.ControlesDataGrid.Location = New System.Drawing.Point(9, 454)
        Me.ControlesDataGrid.Name = "ControlesDataGrid"
        Me.ControlesDataGrid.ReadOnly = True
        Me.ControlesDataGrid.RowHeadersVisible = False
        Me.ControlesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ControlesDataGrid.Size = New System.Drawing.Size(472, 152)
        Me.ControlesDataGrid.TabIndex = 5
        '
        'FormularioColumn
        '
        Me.FormularioColumn.DataPropertyName = "formulario"
        Me.FormularioColumn.HeaderText = "Formulario"
        Me.FormularioColumn.Name = "FormularioColumn"
        Me.FormularioColumn.ReadOnly = True
        '
        'ControlColumn
        '
        Me.ControlColumn.DataPropertyName = "control"
        Me.ControlColumn.HeaderText = "Control"
        Me.ControlColumn.Name = "ControlColumn"
        Me.ControlColumn.ReadOnly = True
        '
        'Mensaje
        '
        Me.Mensaje.DataPropertyName = "mensaje"
        Me.Mensaje.HeaderText = "Mensaje"
        Me.Mensaje.Name = "Mensaje"
        Me.Mensaje.ReadOnly = True
        '
        'Identificador2
        '
        Me.Identificador2.DataPropertyName = "identificador"
        Me.Identificador2.HeaderText = "Identificador"
        Me.Identificador2.Name = "Identificador2"
        Me.Identificador2.ReadOnly = True
        Me.Identificador2.Visible = False
        '
        'idFormulario
        '
        Me.idFormulario.DataPropertyName = "idFormulario"
        Me.idFormulario.HeaderText = "idFormulario"
        Me.idFormulario.Name = "idFormulario"
        Me.idFormulario.ReadOnly = True
        Me.idFormulario.Visible = False
        '
        'idControl
        '
        Me.idControl.DataPropertyName = "idControl"
        Me.idControl.HeaderText = "idControl"
        Me.idControl.Name = "idControl"
        Me.idControl.ReadOnly = True
        Me.idControl.Visible = False
        '
        'IdiomaLabel
        '
        Me.IdiomaLabel.AutoSize = True
        Me.IdiomaLabel.Location = New System.Drawing.Point(9, 13)
        Me.IdiomaLabel.Name = "IdiomaLabel"
        Me.IdiomaLabel.Size = New System.Drawing.Size(38, 13)
        Me.IdiomaLabel.TabIndex = 6
        Me.IdiomaLabel.Text = "Idioma"
        '
        'IdiomaTextBox
        '
        Me.IdiomaTextBox.alfanumerico = False
        Me.IdiomaTextBox.boton = Nothing
        Me.IdiomaTextBox.Location = New System.Drawing.Point(56, 10)
        Me.IdiomaTextBox.Name = "IdiomaTextBox"
        Me.IdiomaTextBox.sinEspacio = False
        Me.IdiomaTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdiomaTextBox.TabIndex = 7
        '
        'GuardarIdiomaButton
        '
        Me.GuardarIdiomaButton.Image = CType(resources.GetObject("GuardarIdiomaButton.Image"), System.Drawing.Image)
        Me.GuardarIdiomaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GuardarIdiomaButton.Location = New System.Drawing.Point(645, 635)
        Me.GuardarIdiomaButton.Name = "GuardarIdiomaButton"
        Me.GuardarIdiomaButton.Size = New System.Drawing.Size(80, 23)
        Me.GuardarIdiomaButton.TabIndex = 8
        Me.GuardarIdiomaButton.Text = "Guardar"
        Me.GuardarIdiomaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GuardarIdiomaButton.UseVisualStyleBackColor = True
        '
        'CancelarButton
        '
        Me.CancelarButton.Image = CType(resources.GetObject("CancelarButton.Image"), System.Drawing.Image)
        Me.CancelarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CancelarButton.Location = New System.Drawing.Point(775, 635)
        Me.CancelarButton.Name = "CancelarButton"
        Me.CancelarButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelarButton.TabIndex = 9
        Me.CancelarButton.Text = "Cancelar"
        Me.CancelarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CancelarButton.UseVisualStyleBackColor = True
        '
        'ModificarIdiomaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(879, 687)
        Me.Controls.Add(Me.CancelarButton)
        Me.Controls.Add(Me.GuardarIdiomaButton)
        Me.Controls.Add(Me.IdiomaTextBox)
        Me.Controls.Add(Me.IdiomaLabel)
        Me.Controls.Add(Me.ControlesDataGrid)
        Me.Controls.Add(Me.MensajesDataGrid)
        Me.Controls.Add(Me.ExcepcionesDataGrid)
        Me.Controls.Add(Me.ControlesLabel)
        Me.Controls.Add(Me.MensajeBitacoraLabel)
        Me.Controls.Add(Me.ExcepcionLabel)
        Me.Name = "ModificarIdiomaForm"
        Me.Text = "ModificarIdioma"
        CType(Me.ExcepcionesDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MensajesDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ControlesDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ExcepcionLabel As System.Windows.Forms.Label
    Friend WithEvents MensajeBitacoraLabel As System.Windows.Forms.Label
    Friend WithEvents ControlesLabel As System.Windows.Forms.Label
    Friend WithEvents IdiomaLabel As System.Windows.Forms.Label
    Friend WithEvents IdiomaTextBox As MyTextBox
    Friend WithEvents CodigoColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MensajeColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdentificadorColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdBaseColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MensajeColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents identificador As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FormularioColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ControlColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Mensaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Identificador2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idFormulario As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents idControl As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExcepcionesDataGrid As TicketYa.MyDataGrid
    Friend WithEvents MensajesDataGrid As TicketYa.MyDataGrid
    Friend WithEvents ControlesDataGrid As TicketYa.MyDataGrid
    Friend WithEvents GuardarIdiomaButton As TicketYa.MyButton
    Friend WithEvents CancelarButton As TicketYa.MyButton

End Class
