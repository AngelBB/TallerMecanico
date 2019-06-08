<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.lbMenuGestion = New System.Windows.Forms.Label()
        Me.btn_informes = New System.Windows.Forms.Button()
        Me.btn_trabajadores = New System.Windows.Forms.Button()
        Me.btn_piezas = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lbMenuGestion
        '
        Me.lbMenuGestion.AutoSize = True
        Me.lbMenuGestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMenuGestion.Location = New System.Drawing.Point(224, 9)
        Me.lbMenuGestion.Name = "lbMenuGestion"
        Me.lbMenuGestion.Size = New System.Drawing.Size(247, 33)
        Me.lbMenuGestion.TabIndex = 0
        Me.lbMenuGestion.Text = "Panel de gestión"
        '
        'btn_informes
        '
        Me.btn_informes.FlatAppearance.BorderSize = 0
        Me.btn_informes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_informes.Image = CType(resources.GetObject("btn_informes.Image"), System.Drawing.Image)
        Me.btn_informes.Location = New System.Drawing.Point(120, 147)
        Me.btn_informes.Name = "btn_informes"
        Me.btn_informes.Size = New System.Drawing.Size(125, 117)
        Me.btn_informes.TabIndex = 0
        Me.btn_informes.Text = "&Facturas"
        Me.btn_informes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.btn_informes, "Ver los informes y pedidos ")
        Me.btn_informes.UseVisualStyleBackColor = True
        '
        'btn_trabajadores
        '
        Me.btn_trabajadores.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_trabajadores.FlatAppearance.BorderSize = 0
        Me.btn_trabajadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_trabajadores.Image = CType(resources.GetObject("btn_trabajadores.Image"), System.Drawing.Image)
        Me.btn_trabajadores.Location = New System.Drawing.Point(268, 147)
        Me.btn_trabajadores.Name = "btn_trabajadores"
        Me.btn_trabajadores.Size = New System.Drawing.Size(125, 117)
        Me.btn_trabajadores.TabIndex = 1
        Me.btn_trabajadores.Text = "&Trabajadores"
        Me.btn_trabajadores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.btn_trabajadores, "Administra los trabajadores")
        Me.btn_trabajadores.UseVisualStyleBackColor = False
        '
        'btn_piezas
        '
        Me.btn_piezas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btn_piezas.FlatAppearance.BorderSize = 0
        Me.btn_piezas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_piezas.Image = CType(resources.GetObject("btn_piezas.Image"), System.Drawing.Image)
        Me.btn_piezas.Location = New System.Drawing.Point(426, 147)
        Me.btn_piezas.Name = "btn_piezas"
        Me.btn_piezas.Size = New System.Drawing.Size(125, 120)
        Me.btn_piezas.TabIndex = 2
        Me.btn_piezas.Text = "&Pedido de piezas"
        Me.btn_piezas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.btn_piezas, "Pide piezas al almacen")
        Me.btn_piezas.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_salir.FlatAppearance.BorderSize = 0
        Me.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_salir.Image = CType(resources.GetObject("btn_salir.Image"), System.Drawing.Image)
        Me.btn_salir.Location = New System.Drawing.Point(12, 347)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(78, 75)
        Me.btn_salir.TabIndex = 3
        Me.btn_salir.Text = "&Salir"
        Me.btn_salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolTip1.SetToolTip(Me.btn_salir, "Salir de la aplicacion")
        Me.btn_salir.UseVisualStyleBackColor = False
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 434)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.btn_piezas)
        Me.Controls.Add(Me.btn_trabajadores)
        Me.Controls.Add(Me.btn_informes)
        Me.Controls.Add(Me.lbMenuGestion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MenuPrincipal"
        Me.Text = "Menú principal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbMenuGestion As System.Windows.Forms.Label
    Friend WithEvents btn_informes As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btn_trabajadores As System.Windows.Forms.Button
    Friend WithEvents btn_piezas As System.Windows.Forms.Button
    Friend WithEvents btn_salir As System.Windows.Forms.Button
End Class
