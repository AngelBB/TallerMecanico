<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Piezas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Piezas))
        Me.lbPiezas = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lb_pedidoPiezas = New System.Windows.Forms.Label()
        Me.cbTipoVehiculo = New System.Windows.Forms.ComboBox()
        Me.lbTipoVeh = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.btnPedir = New System.Windows.Forms.Button()
        Me.lbAtras = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lbPiezas
        '
        Me.lbPiezas.AutoSize = True
        Me.lbPiezas.Location = New System.Drawing.Point(17, 183)
        Me.lbPiezas.Name = "lbPiezas"
        Me.lbPiezas.Size = New System.Drawing.Size(144, 13)
        Me.lbPiezas.TabIndex = 0
        Me.lbPiezas.Text = "Piezas (separelas por comas)"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(167, 183)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(401, 71)
        Me.TextBox1.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.TextBox1, "Escriba las piezas a solicitar")
        '
        'lb_pedidoPiezas
        '
        Me.lb_pedidoPiezas.AutoSize = True
        Me.lb_pedidoPiezas.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold)
        Me.lb_pedidoPiezas.Location = New System.Drawing.Point(12, 9)
        Me.lb_pedidoPiezas.Name = "lb_pedidoPiezas"
        Me.lb_pedidoPiezas.Size = New System.Drawing.Size(254, 33)
        Me.lb_pedidoPiezas.TabIndex = 2
        Me.lb_pedidoPiezas.Text = "Pedido de piezas"
        '
        'cbTipoVehiculo
        '
        Me.cbTipoVehiculo.FormattingEnabled = True
        Me.cbTipoVehiculo.Items.AddRange(New Object() {"Coche", "Furgoneta", "Camion", "4x4"})
        Me.cbTipoVehiculo.Location = New System.Drawing.Point(167, 91)
        Me.cbTipoVehiculo.Name = "cbTipoVehiculo"
        Me.cbTipoVehiculo.Size = New System.Drawing.Size(121, 21)
        Me.cbTipoVehiculo.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.cbTipoVehiculo, "Escoge el tipo de vehiculo")
        '
        'lbTipoVeh
        '
        Me.lbTipoVeh.AutoSize = True
        Me.lbTipoVeh.Location = New System.Drawing.Point(78, 94)
        Me.lbTipoVeh.Name = "lbTipoVeh"
        Me.lbTipoVeh.Size = New System.Drawing.Size(71, 13)
        Me.lbTipoVeh.TabIndex = 4
        Me.lbTipoVeh.Text = "Tipo vehiculo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Nivel de urgencia"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Normal", "Alta", "Urgente"})
        Me.ComboBox2.Location = New System.Drawing.Point(167, 139)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.ComboBox2, "Nivel de urgencia del pedido")
        '
        'btnPedir
        '
        Me.btnPedir.FlatAppearance.BorderSize = 0
        Me.btnPedir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPedir.Image = CType(resources.GetObject("btnPedir.Image"), System.Drawing.Image)
        Me.btnPedir.Location = New System.Drawing.Point(419, 282)
        Me.btnPedir.Name = "btnPedir"
        Me.btnPedir.Size = New System.Drawing.Size(86, 67)
        Me.btnPedir.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnPedir, "Solicitar piezas")
        Me.btnPedir.UseVisualStyleBackColor = True
        '
        'lbAtras
        '
        Me.lbAtras.FlatAppearance.BorderSize = 0
        Me.lbAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lbAtras.Image = CType(resources.GetObject("lbAtras.Image"), System.Drawing.Image)
        Me.lbAtras.Location = New System.Drawing.Point(202, 282)
        Me.lbAtras.Name = "lbAtras"
        Me.lbAtras.Size = New System.Drawing.Size(86, 67)
        Me.lbAtras.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.lbAtras, "Volver al menú")
        Me.lbAtras.UseVisualStyleBackColor = True
        '
        'Piezas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 382)
        Me.Controls.Add(Me.lbAtras)
        Me.Controls.Add(Me.btnPedir)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.lbTipoVeh)
        Me.Controls.Add(Me.cbTipoVehiculo)
        Me.Controls.Add(Me.lb_pedidoPiezas)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lbPiezas)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Piezas"
        Me.Text = "Pedido de piezas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbPiezas As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lb_pedidoPiezas As System.Windows.Forms.Label
    Friend WithEvents cbTipoVehiculo As System.Windows.Forms.ComboBox
    Friend WithEvents lbTipoVeh As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents btnPedir As System.Windows.Forms.Button
    Friend WithEvents lbAtras As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
