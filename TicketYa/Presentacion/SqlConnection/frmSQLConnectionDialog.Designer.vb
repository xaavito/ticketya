<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSQLConnectionDialog
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSQLConnectionDialog))
        Me.lbServidor = New System.Windows.Forms.Label()
        Me.cbServidor = New System.Windows.Forms.ComboBox()
        Me.btnRefrescar = New System.Windows.Forms.Button()
        Me.rbAutenticacionWin = New System.Windows.Forms.RadioButton()
        Me.rbAutenticacionSql = New System.Windows.Forms.RadioButton()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.lbClave = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnProbar = New System.Windows.Forms.Button()
        Me.cbBase = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbBase = New System.Windows.Forms.Label()
        Me.btnNueva = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbServidor
        '
        Me.lbServidor.AutoSize = True
        Me.lbServidor.Location = New System.Drawing.Point(7, 6)
        Me.lbServidor.Name = "lbServidor"
        Me.lbServidor.Size = New System.Drawing.Size(103, 13)
        Me.lbServidor.TabIndex = 0
        Me.lbServidor.Text = "Nombre del Servidor"
        '
        'cbServidor
        '
        Me.cbServidor.FormattingEnabled = True
        Me.cbServidor.Location = New System.Drawing.Point(10, 23)
        Me.cbServidor.Name = "cbServidor"
        Me.cbServidor.Size = New System.Drawing.Size(232, 21)
        Me.cbServidor.TabIndex = 1
        '
        'btnRefrescar
        '
        Me.btnRefrescar.Location = New System.Drawing.Point(248, 21)
        Me.btnRefrescar.Name = "btnRefrescar"
        Me.btnRefrescar.Size = New System.Drawing.Size(82, 23)
        Me.btnRefrescar.TabIndex = 2
        Me.btnRefrescar.Text = "Refrescar"
        '
        'rbAutenticacionWin
        '
        Me.rbAutenticacionWin.AutoSize = True
        Me.rbAutenticacionWin.Checked = True
        Me.rbAutenticacionWin.Location = New System.Drawing.Point(13, 20)
        Me.rbAutenticacionWin.Name = "rbAutenticacionWin"
        Me.rbAutenticacionWin.Size = New System.Drawing.Size(177, 17)
        Me.rbAutenticacionWin.TabIndex = 3
        Me.rbAutenticacionWin.TabStop = True
        Me.rbAutenticacionWin.Text = "Usar Autenticacion de Windows"
        Me.rbAutenticacionWin.UseVisualStyleBackColor = True
        '
        'rbAutenticacionSql
        '
        Me.rbAutenticacionSql.AutoSize = True
        Me.rbAutenticacionSql.Location = New System.Drawing.Point(13, 42)
        Me.rbAutenticacionSql.Name = "rbAutenticacionSql"
        Me.rbAutenticacionSql.Size = New System.Drawing.Size(188, 17)
        Me.rbAutenticacionSql.TabIndex = 4
        Me.rbAutenticacionSql.Text = "Usar Autenticacion de SQL Server"
        Me.rbAutenticacionSql.UseVisualStyleBackColor = True
        '
        'txtUsuario
        '
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(81, 72)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(212, 20)
        Me.txtUsuario.TabIndex = 7
        '
        'txtClave
        '
        Me.txtClave.Enabled = False
        Me.txtClave.Location = New System.Drawing.Point(81, 98)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtClave.Size = New System.Drawing.Size(212, 20)
        Me.txtClave.TabIndex = 8
        '
        'lbUsuario
        '
        Me.lbUsuario.AutoSize = True
        Me.lbUsuario.Location = New System.Drawing.Point(32, 75)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lbUsuario.TabIndex = 9
        Me.lbUsuario.Text = "Usuario"
        '
        'lbClave
        '
        Me.lbClave.AutoSize = True
        Me.lbClave.Location = New System.Drawing.Point(41, 101)
        Me.lbClave.Name = "lbClave"
        Me.lbClave.Size = New System.Drawing.Size(34, 13)
        Me.lbClave.TabIndex = 10
        Me.lbClave.Text = "Clave"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(6, 322)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(82, 23)
        Me.btnAceptar.TabIndex = 25
        Me.btnAceptar.Tag = ""
        Me.btnAceptar.Text = "Aceptar"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(94, 322)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(82, 23)
        Me.btnCancelar.TabIndex = 24
        Me.btnCancelar.Text = "Cancelar"
        '
        'btnProbar
        '
        Me.btnProbar.Location = New System.Drawing.Point(248, 322)
        Me.btnProbar.Name = "btnProbar"
        Me.btnProbar.Size = New System.Drawing.Size(82, 23)
        Me.btnProbar.TabIndex = 26
        Me.btnProbar.Text = "Probar"
        '
        'cbBase
        '
        Me.cbBase.FormattingEnabled = True
        Me.cbBase.Location = New System.Drawing.Point(6, 45)
        Me.cbBase.Name = "cbBase"
        Me.cbBase.Size = New System.Drawing.Size(216, 21)
        Me.cbBase.TabIndex = 27
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lbBase)
        Me.GroupBox1.Controls.Add(Me.btnNueva)
        Me.GroupBox1.Controls.Add(Me.cbBase)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 195)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(317, 108)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Base de Datos"
        '
        'lbBase
        '
        Me.lbBase.AutoSize = True
        Me.lbBase.Location = New System.Drawing.Point(3, 29)
        Me.lbBase.Name = "lbBase"
        Me.lbBase.Size = New System.Drawing.Size(100, 13)
        Me.lbBase.TabIndex = 36
        Me.lbBase.Text = "Seleccionar la base"
        '
        'btnNueva
        '
        Me.btnNueva.Location = New System.Drawing.Point(235, 43)
        Me.btnNueva.Name = "btnNueva"
        Me.btnNueva.Size = New System.Drawing.Size(76, 23)
        Me.btnNueva.TabIndex = 35
        Me.btnNueva.Text = "Nueva"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtClave)
        Me.GroupBox2.Controls.Add(Me.txtUsuario)
        Me.GroupBox2.Controls.Add(Me.rbAutenticacionWin)
        Me.GroupBox2.Controls.Add(Me.lbUsuario)
        Me.GroupBox2.Controls.Add(Me.lbClave)
        Me.GroupBox2.Controls.Add(Me.rbAutenticacionSql)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(317, 128)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Autenticación"
        '
        'frmSQLConnectionDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 357)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnProbar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnRefrescar)
        Me.Controls.Add(Me.cbServidor)
        Me.Controls.Add(Me.lbServidor)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmSQLConnectionDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Diálogo de Conexión"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbServidor As System.Windows.Forms.Label
    Friend WithEvents cbServidor As System.Windows.Forms.ComboBox
    Friend WithEvents btnRefrescar As System.Windows.Forms.Button
    Friend WithEvents rbAutenticacionWin As System.Windows.Forms.RadioButton
    Friend WithEvents rbAutenticacionSql As System.Windows.Forms.RadioButton
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents lbUsuario As System.Windows.Forms.Label
    Friend WithEvents lbClave As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnProbar As System.Windows.Forms.Button
    Friend WithEvents cbBase As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnNueva As System.Windows.Forms.Button
    Friend WithEvents lbBase As System.Windows.Forms.Label
End Class
