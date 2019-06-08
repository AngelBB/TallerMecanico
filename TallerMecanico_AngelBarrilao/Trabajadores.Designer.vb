<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Trabajadores
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Trabajadores))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btAtras = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.tbDni = New System.Windows.Forms.TextBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbApellidos = New System.Windows.Forms.TextBox()
        Me.tbDireccion = New System.Windows.Forms.TextBox()
        Me.ComboBoxTipoMecanico = New System.Windows.Forms.ComboBox()
        Me.tbSalario = New System.Windows.Forms.TextBox()
        Me.lbDni = New System.Windows.Forms.Label()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.lbApellidos = New System.Windows.Forms.Label()
        Me.lbDir = New System.Windows.Forms.Label()
        Me.TipoMecanico = New System.Windows.Forms.Label()
        Me.Salario = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.tbTlf = New System.Windows.Forms.TextBox()
        Me.ComboBoxMecanico = New System.Windows.Forms.ComboBox()
        Me.btnNuevouser = New System.Windows.Forms.Button()
        Me.lbTelf = New System.Windows.Forms.Label()
        Me.lbMecanico = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Trabajadores"
        '
        'btAtras
        '
        Me.btAtras.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btAtras.FlatAppearance.BorderSize = 0
        Me.btAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btAtras.Image = CType(resources.GetObject("btAtras.Image"), System.Drawing.Image)
        Me.btAtras.Location = New System.Drawing.Point(486, 237)
        Me.btAtras.Name = "btAtras"
        Me.btAtras.Size = New System.Drawing.Size(60, 60)
        Me.btAtras.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.btAtras, "Volver al menu principal")
        Me.btAtras.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(383, 237)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(65, 60)
        Me.btnGuardar.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.btnGuardar, "Guardar cambios")
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'tbDni
        '
        Me.tbDni.Location = New System.Drawing.Point(110, 150)
        Me.tbDni.Name = "tbDni"
        Me.tbDni.Size = New System.Drawing.Size(100, 20)
        Me.tbDni.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.tbDni, "Dni")
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(110, 198)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(100, 20)
        Me.tbNombre.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.tbNombre, "nombre")
        '
        'tbApellidos
        '
        Me.tbApellidos.Location = New System.Drawing.Point(110, 246)
        Me.tbApellidos.Name = "tbApellidos"
        Me.tbApellidos.Size = New System.Drawing.Size(100, 20)
        Me.tbApellidos.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.tbApellidos, "Apellidos")
        '
        'tbDireccion
        '
        Me.tbDireccion.Location = New System.Drawing.Point(110, 291)
        Me.tbDireccion.Name = "tbDireccion"
        Me.tbDireccion.Size = New System.Drawing.Size(100, 20)
        Me.tbDireccion.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.tbDireccion, "Direccion")
        '
        'ComboBoxTipoMecanico
        '
        Me.ComboBoxTipoMecanico.FormattingEnabled = True
        Me.ComboBoxTipoMecanico.Location = New System.Drawing.Point(425, 150)
        Me.ComboBoxTipoMecanico.Name = "ComboBoxTipoMecanico"
        Me.ComboBoxTipoMecanico.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxTipoMecanico.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.ComboBoxTipoMecanico, "Tipo de mecanico")
        '
        'tbSalario
        '
        Me.tbSalario.Location = New System.Drawing.Point(425, 191)
        Me.tbSalario.Name = "tbSalario"
        Me.tbSalario.Size = New System.Drawing.Size(121, 20)
        Me.tbSalario.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.tbSalario, "Salario")
        '
        'lbDni
        '
        Me.lbDni.AutoSize = True
        Me.lbDni.Location = New System.Drawing.Point(31, 150)
        Me.lbDni.Name = "lbDni"
        Me.lbDni.Size = New System.Drawing.Size(23, 13)
        Me.lbDni.TabIndex = 8
        Me.lbDni.Text = "Dni"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(31, 201)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(44, 13)
        Me.lbNombre.TabIndex = 9
        Me.lbNombre.Text = "Nombre"
        '
        'lbApellidos
        '
        Me.lbApellidos.AutoSize = True
        Me.lbApellidos.Location = New System.Drawing.Point(31, 253)
        Me.lbApellidos.Name = "lbApellidos"
        Me.lbApellidos.Size = New System.Drawing.Size(49, 13)
        Me.lbApellidos.TabIndex = 10
        Me.lbApellidos.Text = "Apellidos"
        '
        'lbDir
        '
        Me.lbDir.AutoSize = True
        Me.lbDir.Location = New System.Drawing.Point(31, 298)
        Me.lbDir.Name = "lbDir"
        Me.lbDir.Size = New System.Drawing.Size(52, 13)
        Me.lbDir.TabIndex = 11
        Me.lbDir.Text = "Direccion"
        '
        'TipoMecanico
        '
        Me.TipoMecanico.AutoSize = True
        Me.TipoMecanico.Location = New System.Drawing.Point(341, 153)
        Me.TipoMecanico.Name = "TipoMecanico"
        Me.TipoMecanico.Size = New System.Drawing.Size(78, 13)
        Me.TipoMecanico.TabIndex = 12
        Me.TipoMecanico.Text = "Tipo Mecanico"
        '
        'Salario
        '
        Me.Salario.AutoSize = True
        Me.Salario.Location = New System.Drawing.Point(380, 194)
        Me.Salario.Name = "Salario"
        Me.Salario.Size = New System.Drawing.Size(39, 13)
        Me.Salario.TabIndex = 13
        Me.Salario.Text = "Salario"
        '
        'tbTlf
        '
        Me.tbTlf.Location = New System.Drawing.Point(425, 104)
        Me.tbTlf.Name = "tbTlf"
        Me.tbTlf.Size = New System.Drawing.Size(121, 20)
        Me.tbTlf.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.tbTlf, "Telefono")
        '
        'ComboBoxMecanico
        '
        Me.ComboBoxMecanico.FormattingEnabled = True
        Me.ComboBoxMecanico.Location = New System.Drawing.Point(18, 75)
        Me.ComboBoxMecanico.Name = "ComboBoxMecanico"
        Me.ComboBoxMecanico.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxMecanico.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.ComboBoxMecanico, "Seleeciona el mecanico a editar")
        '
        'btnNuevouser
        '
        Me.btnNuevouser.FlatAppearance.BorderSize = 0
        Me.btnNuevouser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevouser.Image = CType(resources.GetObject("btnNuevouser.Image"), System.Drawing.Image)
        Me.btnNuevouser.Location = New System.Drawing.Point(146, 65)
        Me.btnNuevouser.Name = "btnNuevouser"
        Me.btnNuevouser.Size = New System.Drawing.Size(64, 61)
        Me.btnNuevouser.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.btnNuevouser, "Dar de alta un nuevo mecanico")
        Me.btnNuevouser.UseVisualStyleBackColor = True
        '
        'lbTelf
        '
        Me.lbTelf.AutoSize = True
        Me.lbTelf.Location = New System.Drawing.Point(362, 111)
        Me.lbTelf.Name = "lbTelf"
        Me.lbTelf.Size = New System.Drawing.Size(49, 13)
        Me.lbTelf.TabIndex = 15
        Me.lbTelf.Text = "Telefono"
        '
        'lbMecanico
        '
        Me.lbMecanico.AutoSize = True
        Me.lbMecanico.Location = New System.Drawing.Point(15, 49)
        Me.lbMecanico.Name = "lbMecanico"
        Me.lbMecanico.Size = New System.Drawing.Size(148, 13)
        Me.lbMecanico.TabIndex = 17
        Me.lbMecanico.Text = "Selecciona Mecanico a editar"
        '
        'Trabajadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 382)
        Me.Controls.Add(Me.btnNuevouser)
        Me.Controls.Add(Me.lbMecanico)
        Me.Controls.Add(Me.ComboBoxMecanico)
        Me.Controls.Add(Me.btAtras)
        Me.Controls.Add(Me.lbTelf)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.tbTlf)
        Me.Controls.Add(Me.Salario)
        Me.Controls.Add(Me.TipoMecanico)
        Me.Controls.Add(Me.lbDir)
        Me.Controls.Add(Me.lbApellidos)
        Me.Controls.Add(Me.lbNombre)
        Me.Controls.Add(Me.lbDni)
        Me.Controls.Add(Me.tbSalario)
        Me.Controls.Add(Me.ComboBoxTipoMecanico)
        Me.Controls.Add(Me.tbDireccion)
        Me.Controls.Add(Me.tbApellidos)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.tbDni)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Trabajadores"
        Me.Text = "Trabajadores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btAtras As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents tbDni As System.Windows.Forms.TextBox
    Friend WithEvents tbNombre As System.Windows.Forms.TextBox
    Friend WithEvents tbApellidos As System.Windows.Forms.TextBox
    Friend WithEvents tbDireccion As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxTipoMecanico As System.Windows.Forms.ComboBox
    Friend WithEvents tbSalario As System.Windows.Forms.TextBox
    Friend WithEvents lbDni As System.Windows.Forms.Label
    Friend WithEvents lbNombre As System.Windows.Forms.Label
    Friend WithEvents lbApellidos As System.Windows.Forms.Label
    Friend WithEvents lbDir As System.Windows.Forms.Label
    Friend WithEvents TipoMecanico As System.Windows.Forms.Label
    Friend WithEvents Salario As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lbTelf As System.Windows.Forms.Label
    Friend WithEvents tbTlf As System.Windows.Forms.TextBox
    Friend WithEvents lbMecanico As System.Windows.Forms.Label
    Friend WithEvents ComboBoxMecanico As System.Windows.Forms.ComboBox
    Friend WithEvents btnNuevouser As System.Windows.Forms.Button
End Class
