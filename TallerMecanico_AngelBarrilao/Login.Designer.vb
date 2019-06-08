<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbUser = New System.Windows.Forms.Label()
        Me.tbUser = New System.Windows.Forms.TextBox()
        Me.tbPass = New System.Windows.Forms.TextBox()
        Me.btnAcceder = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(43, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contraseña"
        '
        'lbUser
        '
        Me.lbUser.AutoSize = True
        Me.lbUser.Location = New System.Drawing.Point(43, 37)
        Me.lbUser.Name = "lbUser"
        Me.lbUser.Size = New System.Drawing.Size(43, 13)
        Me.lbUser.TabIndex = 1
        Me.lbUser.Text = "Usuario"
        '
        'tbUser
        '
        Me.tbUser.Location = New System.Drawing.Point(46, 53)
        Me.tbUser.Name = "tbUser"
        Me.tbUser.Size = New System.Drawing.Size(100, 20)
        Me.tbUser.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.tbUser, "Introduce tu usuario")
        '
        'tbPass
        '
        Me.tbPass.Location = New System.Drawing.Point(46, 107)
        Me.tbPass.Name = "tbPass"
        Me.tbPass.Size = New System.Drawing.Size(100, 20)
        Me.tbPass.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.tbPass, "Introduce tu contraseña")
        '
        'btnAcceder
        '
        Me.btnAcceder.Location = New System.Drawing.Point(46, 144)
        Me.btnAcceder.Name = "btnAcceder"
        Me.btnAcceder.Size = New System.Drawing.Size(100, 23)
        Me.btnAcceder.TabIndex = 4
        Me.btnAcceder.Text = "&Acceder"
        Me.ToolTip1.SetToolTip(Me.btnAcceder, "Acceder a la aplicacion")
        Me.btnAcceder.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(190, 198)
        Me.Controls.Add(Me.btnAcceder)
        Me.Controls.Add(Me.tbPass)
        Me.Controls.Add(Me.tbUser)
        Me.Controls.Add(Me.lbUser)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbUser As System.Windows.Forms.Label
    Friend WithEvents tbUser As System.Windows.Forms.TextBox
    Friend WithEvents tbPass As System.Windows.Forms.TextBox
    Friend WithEvents btnAcceder As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
