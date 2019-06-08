<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class facturas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(facturas))
        Me.Pestanis = New System.Windows.Forms.TabControl()
        Me.Entrantes = New System.Windows.Forms.TabPage()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CheckBoxEntradaActiva = New System.Windows.Forms.CheckBox()
        Me.lbImporteReparacion = New System.Windows.Forms.Label()
        Me.lbImporteFranc = New System.Windows.Forms.Label()
        Me.lbTarifa = New System.Windows.Forms.Label()
        Me.tbImporteReparacion = New System.Windows.Forms.TextBox()
        Me.TextBoxImporteFranquicia = New System.Windows.Forms.TextBox()
        Me.ComboBoxTarifa = New System.Windows.Forms.ComboBox()
        Me.CheckBoxRetiradaTaller = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePickerST = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerFF = New System.Windows.Forms.DateTimePicker()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbEstadoReparacion = New System.Windows.Forms.Label()
        Me.lbPeritaje = New System.Windows.Forms.Label()
        Me.tbPerit = New System.Windows.Forms.TextBox()
        Me.CheckBoxPER = New System.Windows.Forms.CheckBox()
        Me.lbFechaPeritaje = New System.Windows.Forms.Label()
        Me.DatePickerPeritaje = New System.Windows.Forms.DateTimePicker()
        Me.CheckBoxAutorizadoCliente = New System.Windows.Forms.CheckBox()
        Me.CheckBoxAut_aseguradora = New System.Windows.Forms.CheckBox()
        Me.tbPA = New System.Windows.Forms.TextBox()
        Me.lbPeritoAseguradora = New System.Windows.Forms.Label()
        Me.tbNp = New System.Windows.Forms.TextBox()
        Me.lbNumPoliza = New System.Windows.Forms.Label()
        Me.tbEA = New System.Windows.Forms.TextBox()
        Me.lbEmpresaAs = New System.Windows.Forms.Label()
        Me.tbAveria = New System.Windows.Forms.TextBox()
        Me.lbAveria = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbIdentidad = New System.Windows.Forms.Label()
        Me.tbIdentidad = New System.Windows.Forms.TextBox()
        Me.lbPropietario = New System.Windows.Forms.Label()
        Me.tbPropietario = New System.Windows.Forms.TextBox()
        Me.tbTlf = New System.Windows.Forms.TextBox()
        Me.txPersonaQT = New System.Windows.Forms.TextBox()
        Me.lbTlf = New System.Windows.Forms.Label()
        Me.lbPersonaTrae = New System.Windows.Forms.Label()
        Me.tbCodigoPostal = New System.Windows.Forms.TextBox()
        Me.lbDireccion = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbDireccion = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnAtras = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbCombustible = New System.Windows.Forms.ComboBox()
        Me.lbCombustible = New System.Windows.Forms.Label()
        Me.lbBastidor = New System.Windows.Forms.Label()
        Me.tbNumBastidor = New System.Windows.Forms.TextBox()
        Me.lbEstado = New System.Windows.Forms.Label()
        Me.tbEstado = New System.Windows.Forms.TextBox()
        Me.cbDeposito = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbObjetos = New System.Windows.Forms.TextBox()
        Me.lbObjetos = New System.Windows.Forms.Label()
        Me.lbKm = New System.Windows.Forms.Label()
        Me.tbKm = New System.Windows.Forms.TextBox()
        Me.tbColor = New System.Windows.Forms.TextBox()
        Me.lbColor = New System.Windows.Forms.Label()
        Me.lbModelo = New System.Windows.Forms.Label()
        Me.tbModelo = New System.Windows.Forms.TextBox()
        Me.lbMarca = New System.Windows.Forms.Label()
        Me.tbMarca = New System.Windows.Forms.TextBox()
        Me.tbMatricula = New System.Windows.Forms.TextBox()
        Me.lbMatricula = New System.Windows.Forms.Label()
        Me.lbFechaEntrada = New System.Windows.Forms.Label()
        Me.datePickerEntrada = New System.Windows.Forms.DateTimePicker()
        Me.tbEntradas = New System.Windows.Forms.TextBox()
        Me.lbNEntradas = New System.Windows.Forms.Label()
        Me.lbEntradasTaller = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Pestanis.SuspendLayout()
        Me.Entrantes.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pestanis
        '
        Me.Pestanis.Controls.Add(Me.Entrantes)
        Me.Pestanis.Location = New System.Drawing.Point(1, 2)
        Me.Pestanis.Name = "Pestanis"
        Me.Pestanis.SelectedIndex = 0
        Me.Pestanis.Size = New System.Drawing.Size(1125, 766)
        Me.Pestanis.TabIndex = 0
        '
        'Entrantes
        '
        Me.Entrantes.Controls.Add(Me.ComboBox1)
        Me.Entrantes.Controls.Add(Me.Label5)
        Me.Entrantes.Controls.Add(Me.CheckBoxEntradaActiva)
        Me.Entrantes.Controls.Add(Me.lbImporteReparacion)
        Me.Entrantes.Controls.Add(Me.lbImporteFranc)
        Me.Entrantes.Controls.Add(Me.lbTarifa)
        Me.Entrantes.Controls.Add(Me.tbImporteReparacion)
        Me.Entrantes.Controls.Add(Me.TextBoxImporteFranquicia)
        Me.Entrantes.Controls.Add(Me.ComboBoxTarifa)
        Me.Entrantes.Controls.Add(Me.CheckBoxRetiradaTaller)
        Me.Entrantes.Controls.Add(Me.Label4)
        Me.Entrantes.Controls.Add(Me.Label3)
        Me.Entrantes.Controls.Add(Me.DateTimePickerST)
        Me.Entrantes.Controls.Add(Me.DateTimePickerFF)
        Me.Entrantes.Controls.Add(Me.CheckBox1)
        Me.Entrantes.Controls.Add(Me.TextBox1)
        Me.Entrantes.Controls.Add(Me.lbEstadoReparacion)
        Me.Entrantes.Controls.Add(Me.lbPeritaje)
        Me.Entrantes.Controls.Add(Me.tbPerit)
        Me.Entrantes.Controls.Add(Me.CheckBoxPER)
        Me.Entrantes.Controls.Add(Me.lbFechaPeritaje)
        Me.Entrantes.Controls.Add(Me.DatePickerPeritaje)
        Me.Entrantes.Controls.Add(Me.CheckBoxAutorizadoCliente)
        Me.Entrantes.Controls.Add(Me.CheckBoxAut_aseguradora)
        Me.Entrantes.Controls.Add(Me.tbPA)
        Me.Entrantes.Controls.Add(Me.lbPeritoAseguradora)
        Me.Entrantes.Controls.Add(Me.tbNp)
        Me.Entrantes.Controls.Add(Me.lbNumPoliza)
        Me.Entrantes.Controls.Add(Me.tbEA)
        Me.Entrantes.Controls.Add(Me.lbEmpresaAs)
        Me.Entrantes.Controls.Add(Me.tbAveria)
        Me.Entrantes.Controls.Add(Me.lbAveria)
        Me.Entrantes.Controls.Add(Me.GroupBox3)
        Me.Entrantes.Controls.Add(Me.GroupBox2)
        Me.Entrantes.Controls.Add(Me.GroupBox1)
        Me.Entrantes.Controls.Add(Me.lbFechaEntrada)
        Me.Entrantes.Controls.Add(Me.datePickerEntrada)
        Me.Entrantes.Controls.Add(Me.tbEntradas)
        Me.Entrantes.Controls.Add(Me.lbNEntradas)
        Me.Entrantes.Controls.Add(Me.lbEntradasTaller)
        Me.Entrantes.Location = New System.Drawing.Point(4, 22)
        Me.Entrantes.Name = "Entrantes"
        Me.Entrantes.Padding = New System.Windows.Forms.Padding(3)
        Me.Entrantes.Size = New System.Drawing.Size(1117, 740)
        Me.Entrantes.TabIndex = 0
        Me.Entrantes.Text = "Entrantes"
        Me.Entrantes.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Vacio", "Lleno"})
        Me.ComboBox1.Location = New System.Drawing.Point(775, 13)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(100, 21)
        Me.ComboBox1.TabIndex = 46
        Me.ToolTip1.SetToolTip(Me.ComboBox1, "Indica el estado del depósito")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(709, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Mecácnico"
        '
        'CheckBoxEntradaActiva
        '
        Me.CheckBoxEntradaActiva.AutoSize = True
        Me.CheckBoxEntradaActiva.CheckAlign = System.Drawing.ContentAlignment.TopRight
        Me.CheckBoxEntradaActiva.Location = New System.Drawing.Point(890, 15)
        Me.CheckBoxEntradaActiva.Name = "CheckBoxEntradaActiva"
        Me.CheckBoxEntradaActiva.Size = New System.Drawing.Size(56, 17)
        Me.CheckBoxEntradaActiva.TabIndex = 45
        Me.CheckBoxEntradaActiva.Text = "Activa"
        Me.ToolTip1.SetToolTip(Me.CheckBoxEntradaActiva, "Entrada de taller activa")
        Me.CheckBoxEntradaActiva.UseVisualStyleBackColor = True
        '
        'lbImporteReparacion
        '
        Me.lbImporteReparacion.AutoSize = True
        Me.lbImporteReparacion.Location = New System.Drawing.Point(730, 679)
        Me.lbImporteReparacion.Name = "lbImporteReparacion"
        Me.lbImporteReparacion.Size = New System.Drawing.Size(100, 13)
        Me.lbImporteReparacion.TabIndex = 44
        Me.lbImporteReparacion.Text = "Importe Reparacion"
        Me.ToolTip1.SetToolTip(Me.lbImporteReparacion, "Importe Reparacion")
        '
        'lbImporteFranc
        '
        Me.lbImporteFranc.AutoSize = True
        Me.lbImporteFranc.Location = New System.Drawing.Point(736, 649)
        Me.lbImporteFranc.Name = "lbImporteFranc"
        Me.lbImporteFranc.Size = New System.Drawing.Size(94, 13)
        Me.lbImporteFranc.TabIndex = 43
        Me.lbImporteFranc.Text = "Importe Franquicia"
        Me.ToolTip1.SetToolTip(Me.lbImporteFranc, "Importe de la franquicia")
        '
        'lbTarifa
        '
        Me.lbTarifa.AutoSize = True
        Me.lbTarifa.Location = New System.Drawing.Point(791, 619)
        Me.lbTarifa.Name = "lbTarifa"
        Me.lbTarifa.Size = New System.Drawing.Size(34, 13)
        Me.lbTarifa.TabIndex = 42
        Me.lbTarifa.Text = "Tarifa"
        '
        'tbImporteReparacion
        '
        Me.tbImporteReparacion.Location = New System.Drawing.Point(835, 672)
        Me.tbImporteReparacion.Name = "tbImporteReparacion"
        Me.tbImporteReparacion.Size = New System.Drawing.Size(120, 20)
        Me.tbImporteReparacion.TabIndex = 34
        Me.ToolTip1.SetToolTip(Me.tbImporteReparacion, "Importe Reparacion")
        '
        'TextBoxImporteFranquicia
        '
        Me.TextBoxImporteFranquicia.Location = New System.Drawing.Point(835, 646)
        Me.TextBoxImporteFranquicia.Name = "TextBoxImporteFranquicia"
        Me.TextBoxImporteFranquicia.Size = New System.Drawing.Size(120, 20)
        Me.TextBoxImporteFranquicia.TabIndex = 33
        Me.ToolTip1.SetToolTip(Me.TextBoxImporteFranquicia, "Importe Franquicia")
        '
        'ComboBoxTarifa
        '
        Me.ComboBoxTarifa.FormattingEnabled = True
        Me.ComboBoxTarifa.Location = New System.Drawing.Point(835, 612)
        Me.ComboBoxTarifa.Name = "ComboBoxTarifa"
        Me.ComboBoxTarifa.Size = New System.Drawing.Size(120, 21)
        Me.ComboBoxTarifa.TabIndex = 32
        Me.ToolTip1.SetToolTip(Me.ComboBoxTarifa, "Tarifa")
        '
        'CheckBoxRetiradaTaller
        '
        Me.CheckBoxRetiradaTaller.AutoSize = True
        Me.CheckBoxRetiradaTaller.CheckAlign = System.Drawing.ContentAlignment.TopRight
        Me.CheckBoxRetiradaTaller.Location = New System.Drawing.Point(864, 588)
        Me.CheckBoxRetiradaTaller.Name = "CheckBoxRetiradaTaller"
        Me.CheckBoxRetiradaTaller.Size = New System.Drawing.Size(91, 17)
        Me.CheckBoxRetiradaTaller.TabIndex = 31
        Me.CheckBoxRetiradaTaller.Text = "Retirada taller"
        Me.ToolTip1.SetToolTip(Me.CheckBoxRetiradaTaller, "Retirada taller")
        Me.CheckBoxRetiradaTaller.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(745, 563)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Salida taller"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(745, 540)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Fecha finalizada"
        '
        'DateTimePickerST
        '
        Me.DateTimePickerST.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerST.Location = New System.Drawing.Point(835, 560)
        Me.DateTimePickerST.Name = "DateTimePickerST"
        Me.DateTimePickerST.Size = New System.Drawing.Size(120, 20)
        Me.DateTimePickerST.TabIndex = 30
        Me.ToolTip1.SetToolTip(Me.DateTimePickerST, "Retirada vehiculo")
        '
        'DateTimePickerFF
        '
        Me.DateTimePickerFF.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerFF.Location = New System.Drawing.Point(835, 534)
        Me.DateTimePickerFF.Name = "DateTimePickerFF"
        Me.DateTimePickerFF.Size = New System.Drawing.Size(120, 20)
        Me.DateTimePickerFF.TabIndex = 29
        Me.ToolTip1.SetToolTip(Me.DateTimePickerFF, "Fecha de finalizazion de la reparacion")
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.TopRight
        Me.CheckBox1.Location = New System.Drawing.Point(827, 505)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(128, 17)
        Me.CheckBox1.TabIndex = 28
        Me.CheckBox1.Text = "Reparacion finalizada"
        Me.ToolTip1.SetToolTip(Me.CheckBox1, "Reparacion finalizada")
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(719, 479)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(236, 20)
        Me.TextBox1.TabIndex = 27
        Me.ToolTip1.SetToolTip(Me.TextBox1, "codigoPostal")
        '
        'lbEstadoReparacion
        '
        Me.lbEstadoReparacion.AutoSize = True
        Me.lbEstadoReparacion.Location = New System.Drawing.Point(620, 479)
        Me.lbEstadoReparacion.Name = "lbEstadoReparacion"
        Me.lbEstadoReparacion.Size = New System.Drawing.Size(93, 13)
        Me.lbEstadoReparacion.TabIndex = 21
        Me.lbEstadoReparacion.Text = "Estado reparacion"
        '
        'lbPeritaje
        '
        Me.lbPeritaje.AutoSize = True
        Me.lbPeritaje.Location = New System.Drawing.Point(209, 646)
        Me.lbPeritaje.Name = "lbPeritaje"
        Me.lbPeritaje.Size = New System.Drawing.Size(42, 13)
        Me.lbPeritaje.TabIndex = 34
        Me.lbPeritaje.Text = "Peritaje"
        '
        'tbPerit
        '
        Me.tbPerit.Location = New System.Drawing.Point(212, 662)
        Me.tbPerit.Multiline = True
        Me.tbPerit.Name = "tbPerit"
        Me.tbPerit.Size = New System.Drawing.Size(320, 68)
        Me.tbPerit.TabIndex = 26
        Me.ToolTip1.SetToolTip(Me.tbPerit, "averia")
        '
        'CheckBoxPER
        '
        Me.CheckBoxPER.AutoSize = True
        Me.CheckBoxPER.Location = New System.Drawing.Point(451, 534)
        Me.CheckBoxPER.Name = "CheckBoxPER"
        Me.CheckBoxPER.Size = New System.Drawing.Size(65, 17)
        Me.CheckBoxPER.TabIndex = 22
        Me.CheckBoxPER.Text = "Peritado"
        Me.ToolTip1.SetToolTip(Me.CheckBoxPER, "Peritado")
        Me.CheckBoxPER.UseVisualStyleBackColor = True
        '
        'lbFechaPeritaje
        '
        Me.lbFechaPeritaje.AutoSize = True
        Me.lbFechaPeritaje.Location = New System.Drawing.Point(209, 534)
        Me.lbFechaPeritaje.Name = "lbFechaPeritaje"
        Me.lbFechaPeritaje.Size = New System.Drawing.Size(74, 13)
        Me.lbFechaPeritaje.TabIndex = 31
        Me.lbFechaPeritaje.Text = "Fecha peritaje"
        '
        'DatePickerPeritaje
        '
        Me.DatePickerPeritaje.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DatePickerPeritaje.Location = New System.Drawing.Point(319, 534)
        Me.DatePickerPeritaje.Name = "DatePickerPeritaje"
        Me.DatePickerPeritaje.Size = New System.Drawing.Size(120, 20)
        Me.DatePickerPeritaje.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.DatePickerPeritaje, "Fecha de peritaje")
        '
        'CheckBoxAutorizadoCliente
        '
        Me.CheckBoxAutorizadoCliente.AutoSize = True
        Me.CheckBoxAutorizadoCliente.Location = New System.Drawing.Point(212, 482)
        Me.CheckBoxAutorizadoCliente.Name = "CheckBoxAutorizadoCliente"
        Me.CheckBoxAutorizadoCliente.Size = New System.Drawing.Size(196, 17)
        Me.CheckBoxAutorizadoCliente.TabIndex = 19
        Me.CheckBoxAutorizadoCliente.Text = "Reparacion autorizada por el cliente"
        Me.ToolTip1.SetToolTip(Me.CheckBoxAutorizadoCliente, "Autorizado cliente")
        Me.CheckBoxAutorizadoCliente.UseVisualStyleBackColor = True
        '
        'CheckBoxAut_aseguradora
        '
        Me.CheckBoxAut_aseguradora.AutoSize = True
        Me.CheckBoxAut_aseguradora.Location = New System.Drawing.Point(212, 505)
        Me.CheckBoxAut_aseguradora.Name = "CheckBoxAut_aseguradora"
        Me.CheckBoxAut_aseguradora.Size = New System.Drawing.Size(224, 17)
        Me.CheckBoxAut_aseguradora.TabIndex = 20
        Me.CheckBoxAut_aseguradora.Text = "Reparacion autorizada por la aseguradora"
        Me.ToolTip1.SetToolTip(Me.CheckBoxAut_aseguradora, "Reparacion autorizada por la aseguradora")
        Me.CheckBoxAut_aseguradora.UseVisualStyleBackColor = True
        '
        'tbPA
        '
        Me.tbPA.Location = New System.Drawing.Point(320, 612)
        Me.tbPA.Name = "tbPA"
        Me.tbPA.Size = New System.Drawing.Size(120, 20)
        Me.tbPA.TabIndex = 25
        Me.ToolTip1.SetToolTip(Me.tbPA, "codigoPostal")
        '
        'lbPeritoAseguradora
        '
        Me.lbPeritoAseguradora.AutoSize = True
        Me.lbPeritoAseguradora.Location = New System.Drawing.Point(209, 612)
        Me.lbPeritoAseguradora.Name = "lbPeritoAseguradora"
        Me.lbPeritoAseguradora.Size = New System.Drawing.Size(97, 13)
        Me.lbPeritoAseguradora.TabIndex = 27
        Me.lbPeritoAseguradora.Text = "Perito Aseguradora"
        '
        'tbNp
        '
        Me.tbNp.Location = New System.Drawing.Point(319, 586)
        Me.tbNp.Name = "tbNp"
        Me.tbNp.Size = New System.Drawing.Size(120, 20)
        Me.tbNp.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.tbNp, "codigoPostal")
        '
        'lbNumPoliza
        '
        Me.lbNumPoliza.AutoSize = True
        Me.lbNumPoliza.Location = New System.Drawing.Point(209, 586)
        Me.lbNumPoliza.Name = "lbNumPoliza"
        Me.lbNumPoliza.Size = New System.Drawing.Size(89, 13)
        Me.lbNumPoliza.TabIndex = 25
        Me.lbNumPoliza.Text = "Numero de poliza"
        '
        'tbEA
        '
        Me.tbEA.Location = New System.Drawing.Point(319, 560)
        Me.tbEA.Name = "tbEA"
        Me.tbEA.Size = New System.Drawing.Size(120, 20)
        Me.tbEA.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.tbEA, "codigoPostal")
        '
        'lbEmpresaAs
        '
        Me.lbEmpresaAs.AutoSize = True
        Me.lbEmpresaAs.Location = New System.Drawing.Point(209, 560)
        Me.lbEmpresaAs.Name = "lbEmpresaAs"
        Me.lbEmpresaAs.Size = New System.Drawing.Size(110, 13)
        Me.lbEmpresaAs.TabIndex = 23
        Me.lbEmpresaAs.Text = "Empresa aseguradora"
        '
        'tbAveria
        '
        Me.tbAveria.Location = New System.Drawing.Point(16, 480)
        Me.tbAveria.Multiline = True
        Me.tbAveria.Name = "tbAveria"
        Me.tbAveria.Size = New System.Drawing.Size(174, 250)
        Me.tbAveria.TabIndex = 18
        Me.ToolTip1.SetToolTip(Me.tbAveria, "averia")
        '
        'lbAveria
        '
        Me.lbAveria.AutoSize = True
        Me.lbAveria.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAveria.Location = New System.Drawing.Point(13, 464)
        Me.lbAveria.Name = "lbAveria"
        Me.lbAveria.Size = New System.Drawing.Size(80, 13)
        Me.lbAveria.TabIndex = 21
        Me.lbAveria.Text = "Datos Averia"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lbIdentidad)
        Me.GroupBox3.Controls.Add(Me.tbIdentidad)
        Me.GroupBox3.Controls.Add(Me.lbPropietario)
        Me.GroupBox3.Controls.Add(Me.tbPropietario)
        Me.GroupBox3.Controls.Add(Me.tbTlf)
        Me.GroupBox3.Controls.Add(Me.txPersonaQT)
        Me.GroupBox3.Controls.Add(Me.lbTlf)
        Me.GroupBox3.Controls.Add(Me.lbPersonaTrae)
        Me.GroupBox3.Controls.Add(Me.tbCodigoPostal)
        Me.GroupBox3.Controls.Add(Me.lbDireccion)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.tbDireccion)
        Me.GroupBox3.Location = New System.Drawing.Point(0, 308)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(990, 137)
        Me.GroupBox3.TabIndex = 20
        Me.GroupBox3.TabStop = False
        '
        'lbIdentidad
        '
        Me.lbIdentidad.AutoSize = True
        Me.lbIdentidad.Location = New System.Drawing.Point(750, 80)
        Me.lbIdentidad.Name = "lbIdentidad"
        Me.lbIdentidad.Size = New System.Drawing.Size(47, 13)
        Me.lbIdentidad.TabIndex = 19
        Me.lbIdentidad.Text = "DNI/CIF"
        '
        'tbIdentidad
        '
        Me.tbIdentidad.Location = New System.Drawing.Point(835, 80)
        Me.tbIdentidad.Name = "tbIdentidad"
        Me.tbIdentidad.Size = New System.Drawing.Size(120, 20)
        Me.tbIdentidad.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.tbIdentidad, "DNI/CIF")
        '
        'lbPropietario
        '
        Me.lbPropietario.AutoSize = True
        Me.lbPropietario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPropietario.Location = New System.Drawing.Point(5, 33)
        Me.lbPropietario.Name = "lbPropietario"
        Me.lbPropietario.Size = New System.Drawing.Size(68, 13)
        Me.lbPropietario.TabIndex = 9
        Me.lbPropietario.Text = "Propietario"
        '
        'tbPropietario
        '
        Me.tbPropietario.Location = New System.Drawing.Point(95, 33)
        Me.tbPropietario.Name = "tbPropietario"
        Me.tbPropietario.Size = New System.Drawing.Size(240, 20)
        Me.tbPropietario.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.tbPropietario, "Propietario del vehiculo")
        '
        'tbTlf
        '
        Me.tbTlf.Location = New System.Drawing.Point(465, 80)
        Me.tbTlf.Name = "tbTlf"
        Me.tbTlf.Size = New System.Drawing.Size(120, 20)
        Me.tbTlf.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.tbTlf, "Telefono")
        '
        'txPersonaQT
        '
        Me.txPersonaQT.Location = New System.Drawing.Point(465, 33)
        Me.txPersonaQT.Name = "txPersonaQT"
        Me.txPersonaQT.Size = New System.Drawing.Size(240, 20)
        Me.txPersonaQT.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.txPersonaQT, "Persona que trae el vehiculo")
        '
        'lbTlf
        '
        Me.lbTlf.AutoSize = True
        Me.lbTlf.Location = New System.Drawing.Point(395, 80)
        Me.lbTlf.Name = "lbTlf"
        Me.lbTlf.Size = New System.Drawing.Size(19, 13)
        Me.lbTlf.TabIndex = 17
        Me.lbTlf.Text = "Tlf"
        '
        'lbPersonaTrae
        '
        Me.lbPersonaTrae.AutoSize = True
        Me.lbPersonaTrae.Location = New System.Drawing.Point(371, 36)
        Me.lbPersonaTrae.Name = "lbPersonaTrae"
        Me.lbPersonaTrae.Size = New System.Drawing.Size(88, 13)
        Me.lbPersonaTrae.TabIndex = 12
        Me.lbPersonaTrae.Text = "Persona que trae"
        '
        'tbCodigoPostal
        '
        Me.tbCodigoPostal.Location = New System.Drawing.Point(95, 80)
        Me.tbCodigoPostal.Name = "tbCodigoPostal"
        Me.tbCodigoPostal.Size = New System.Drawing.Size(120, 20)
        Me.tbCodigoPostal.TabIndex = 15
        Me.ToolTip1.SetToolTip(Me.tbCodigoPostal, "codigoPostal")
        '
        'lbDireccion
        '
        Me.lbDireccion.AutoSize = True
        Me.lbDireccion.Location = New System.Drawing.Point(745, 36)
        Me.lbDireccion.Name = "lbDireccion"
        Me.lbDireccion.Size = New System.Drawing.Size(52, 13)
        Me.lbDireccion.TabIndex = 13
        Me.lbDireccion.Text = "Direccion"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "C.Postal"
        '
        'tbDireccion
        '
        Me.tbDireccion.Location = New System.Drawing.Point(835, 36)
        Me.tbDireccion.Name = "tbDireccion"
        Me.tbDireccion.Size = New System.Drawing.Size(120, 20)
        Me.tbDireccion.TabIndex = 14
        Me.ToolTip1.SetToolTip(Me.tbDireccion, "direccion")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnBorrar)
        Me.GroupBox2.Controls.Add(Me.btnAtras)
        Me.GroupBox2.Controls.Add(Me.btnImprimir)
        Me.GroupBox2.Controls.Add(Me.btnGuardar)
        Me.GroupBox2.Location = New System.Drawing.Point(988, -12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(133, 752)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        '
        'btnBorrar
        '
        Me.btnBorrar.FlatAppearance.BorderSize = 0
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
        Me.btnBorrar.Location = New System.Drawing.Point(25, 400)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(89, 71)
        Me.btnBorrar.TabIndex = 37
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnAtras
        '
        Me.btnAtras.FlatAppearance.BorderSize = 0
        Me.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAtras.Image = CType(resources.GetObject("btnAtras.Image"), System.Drawing.Image)
        Me.btnAtras.Location = New System.Drawing.Point(25, 653)
        Me.btnAtras.Name = "btnAtras"
        Me.btnAtras.Size = New System.Drawing.Size(75, 60)
        Me.btnAtras.TabIndex = 38
        Me.btnAtras.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Image = CType(resources.GetObject("btnImprimir.Image"), System.Drawing.Image)
        Me.btnImprimir.Location = New System.Drawing.Point(25, 235)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(89, 85)
        Me.btnImprimir.TabIndex = 36
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.Location = New System.Drawing.Point(25, 59)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(89, 87)
        Me.btnGuardar.TabIndex = 35
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbCombustible)
        Me.GroupBox1.Controls.Add(Me.lbCombustible)
        Me.GroupBox1.Controls.Add(Me.lbBastidor)
        Me.GroupBox1.Controls.Add(Me.tbNumBastidor)
        Me.GroupBox1.Controls.Add(Me.lbEstado)
        Me.GroupBox1.Controls.Add(Me.tbEstado)
        Me.GroupBox1.Controls.Add(Me.cbDeposito)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tbObjetos)
        Me.GroupBox1.Controls.Add(Me.lbObjetos)
        Me.GroupBox1.Controls.Add(Me.lbKm)
        Me.GroupBox1.Controls.Add(Me.tbKm)
        Me.GroupBox1.Controls.Add(Me.tbColor)
        Me.GroupBox1.Controls.Add(Me.lbColor)
        Me.GroupBox1.Controls.Add(Me.lbModelo)
        Me.GroupBox1.Controls.Add(Me.tbModelo)
        Me.GroupBox1.Controls.Add(Me.lbMarca)
        Me.GroupBox1.Controls.Add(Me.tbMarca)
        Me.GroupBox1.Controls.Add(Me.tbMatricula)
        Me.GroupBox1.Controls.Add(Me.lbMatricula)
        Me.GroupBox1.Location = New System.Drawing.Point(-4, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1025, 267)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'cbCombustible
        '
        Me.cbCombustible.FormattingEnabled = True
        Me.cbCombustible.Items.AddRange(New Object() {"Gasolina", "Diesel", "Etanol", "Gas Natural", "Electricidad", "Hidrógeno", "GLP", "Biodiesel", "Metanol", "P-Serie"})
        Me.cbCombustible.Location = New System.Drawing.Point(344, 112)
        Me.cbCombustible.Name = "cbCombustible"
        Me.cbCombustible.Size = New System.Drawing.Size(100, 21)
        Me.cbCombustible.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.cbCombustible, "Tipo de combustible")
        '
        'lbCombustible
        '
        Me.lbCombustible.AutoSize = True
        Me.lbCombustible.Location = New System.Drawing.Point(258, 116)
        Me.lbCombustible.Name = "lbCombustible"
        Me.lbCombustible.Size = New System.Drawing.Size(64, 13)
        Me.lbCombustible.TabIndex = 19
        Me.lbCombustible.Text = "Combustible"
        '
        'lbBastidor
        '
        Me.lbBastidor.AutoSize = True
        Me.lbBastidor.Location = New System.Drawing.Point(17, 112)
        Me.lbBastidor.Name = "lbBastidor"
        Me.lbBastidor.Size = New System.Drawing.Size(84, 13)
        Me.lbBastidor.TabIndex = 17
        Me.lbBastidor.Text = "Numero bastidor"
        '
        'tbNumBastidor
        '
        Me.tbNumBastidor.Location = New System.Drawing.Point(107, 109)
        Me.tbNumBastidor.Name = "tbNumBastidor"
        Me.tbNumBastidor.Size = New System.Drawing.Size(137, 20)
        Me.tbNumBastidor.TabIndex = 9
        Me.ToolTip1.SetToolTip(Me.tbNumBastidor, "Bastidor vehículo")
        '
        'lbEstado
        '
        Me.lbEstado.AutoSize = True
        Me.lbEstado.Location = New System.Drawing.Point(17, 166)
        Me.lbEstado.Name = "lbEstado"
        Me.lbEstado.Size = New System.Drawing.Size(102, 13)
        Me.lbEstado.TabIndex = 15
        Me.lbEstado.Text = "Estado del vehículo"
        '
        'tbEstado
        '
        Me.tbEstado.Location = New System.Drawing.Point(17, 195)
        Me.tbEstado.Multiline = True
        Me.tbEstado.Name = "tbEstado"
        Me.tbEstado.Size = New System.Drawing.Size(942, 60)
        Me.tbEstado.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.tbEstado, "Estado del vehiculo")
        '
        'cbDeposito
        '
        Me.cbDeposito.FormattingEnabled = True
        Me.cbDeposito.Items.AddRange(New Object() {"Vacio", "Lleno"})
        Me.cbDeposito.Location = New System.Drawing.Point(344, 58)
        Me.cbDeposito.Name = "cbDeposito"
        Me.cbDeposito.Size = New System.Drawing.Size(100, 21)
        Me.cbDeposito.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.cbDeposito, "Indica el estado del depósito")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(273, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Depósito"
        '
        'tbObjetos
        '
        Me.tbObjetos.Location = New System.Drawing.Point(577, 58)
        Me.tbObjetos.Name = "tbObjetos"
        Me.tbObjetos.Size = New System.Drawing.Size(382, 20)
        Me.tbObjetos.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.tbObjetos, "Indica los objetos que se encuentren junto al vehículo")
        '
        'lbObjetos
        '
        Me.lbObjetos.AutoSize = True
        Me.lbObjetos.Location = New System.Drawing.Point(493, 64)
        Me.lbObjetos.Name = "lbObjetos"
        Me.lbObjetos.Size = New System.Drawing.Size(43, 13)
        Me.lbObjetos.TabIndex = 10
        Me.lbObjetos.Text = "Objetos"
        '
        'lbKm
        '
        Me.lbKm.AutoSize = True
        Me.lbKm.Location = New System.Drawing.Point(17, 61)
        Me.lbKm.Name = "lbKm"
        Me.lbKm.Size = New System.Drawing.Size(65, 13)
        Me.lbKm.TabIndex = 9
        Me.lbKm.Text = "Km actuales"
        '
        'tbKm
        '
        Me.tbKm.Location = New System.Drawing.Point(162, 59)
        Me.tbKm.Name = "tbKm"
        Me.tbKm.Size = New System.Drawing.Size(82, 20)
        Me.tbKm.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.tbKm, "Matricula del vehiculo")
        '
        'tbColor
        '
        Me.tbColor.Location = New System.Drawing.Point(849, 17)
        Me.tbColor.Name = "tbColor"
        Me.tbColor.Size = New System.Drawing.Size(110, 20)
        Me.tbColor.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.tbColor, "Color del vehiculo")
        '
        'lbColor
        '
        Me.lbColor.AutoSize = True
        Me.lbColor.Location = New System.Drawing.Point(798, 20)
        Me.lbColor.Name = "lbColor"
        Me.lbColor.Size = New System.Drawing.Size(31, 13)
        Me.lbColor.TabIndex = 7
        Me.lbColor.Text = "Color"
        '
        'lbModelo
        '
        Me.lbModelo.AutoSize = True
        Me.lbModelo.Location = New System.Drawing.Point(494, 20)
        Me.lbModelo.Name = "lbModelo"
        Me.lbModelo.Size = New System.Drawing.Size(42, 13)
        Me.lbModelo.TabIndex = 6
        Me.lbModelo.Text = "Modelo"
        '
        'tbModelo
        '
        Me.tbModelo.Location = New System.Drawing.Point(577, 20)
        Me.tbModelo.Name = "tbModelo"
        Me.tbModelo.Size = New System.Drawing.Size(184, 20)
        Me.tbModelo.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.tbModelo, "Modelo del vehiculo")
        '
        'lbMarca
        '
        Me.lbMarca.AutoSize = True
        Me.lbMarca.Location = New System.Drawing.Point(274, 20)
        Me.lbMarca.Name = "lbMarca"
        Me.lbMarca.Size = New System.Drawing.Size(37, 13)
        Me.lbMarca.TabIndex = 4
        Me.lbMarca.Text = "Marca"
        '
        'tbMarca
        '
        Me.tbMarca.Location = New System.Drawing.Point(344, 17)
        Me.tbMarca.Name = "tbMarca"
        Me.tbMarca.Size = New System.Drawing.Size(100, 20)
        Me.tbMarca.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.tbMarca, "Marca del vehiculo")
        '
        'tbMatricula
        '
        Me.tbMatricula.Location = New System.Drawing.Point(107, 20)
        Me.tbMatricula.Name = "tbMatricula"
        Me.tbMatricula.Size = New System.Drawing.Size(140, 20)
        Me.tbMatricula.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.tbMatricula, "Matricula del vehiculo")
        '
        'lbMatricula
        '
        Me.lbMatricula.AutoSize = True
        Me.lbMatricula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMatricula.Location = New System.Drawing.Point(17, 20)
        Me.lbMatricula.Name = "lbMatricula"
        Me.lbMatricula.Size = New System.Drawing.Size(61, 13)
        Me.lbMatricula.TabIndex = 0
        Me.lbMatricula.Text = "Matrícula"
        '
        'lbFechaEntrada
        '
        Me.lbFechaEntrada.AutoSize = True
        Me.lbFechaEntrada.Location = New System.Drawing.Point(462, 14)
        Me.lbFechaEntrada.Name = "lbFechaEntrada"
        Me.lbFechaEntrada.Size = New System.Drawing.Size(77, 13)
        Me.lbFechaEntrada.TabIndex = 6
        Me.lbFechaEntrada.Text = "Fecha Entrada"
        '
        'datePickerEntrada
        '
        Me.datePickerEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datePickerEntrada.Location = New System.Drawing.Point(545, 13)
        Me.datePickerEntrada.Name = "datePickerEntrada"
        Me.datePickerEntrada.Size = New System.Drawing.Size(110, 20)
        Me.datePickerEntrada.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.datePickerEntrada, "Escoge la fecha de entrada del vehiculo al taller")
        '
        'tbEntradas
        '
        Me.tbEntradas.Location = New System.Drawing.Point(319, 13)
        Me.tbEntradas.Name = "tbEntradas"
        Me.tbEntradas.Size = New System.Drawing.Size(100, 20)
        Me.tbEntradas.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.tbEntradas, "Numero de entrada")
        '
        'lbNEntradas
        '
        Me.lbNEntradas.AutoSize = True
        Me.lbNEntradas.Location = New System.Drawing.Point(249, 14)
        Me.lbNEntradas.Name = "lbNEntradas"
        Me.lbNEntradas.Size = New System.Drawing.Size(64, 13)
        Me.lbNEntradas.TabIndex = 3
        Me.lbNEntradas.Text = "Nº Entradas"
        '
        'lbEntradasTaller
        '
        Me.lbEntradasTaller.AutoSize = True
        Me.lbEntradasTaller.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEntradasTaller.Location = New System.Drawing.Point(7, 3)
        Me.lbEntradasTaller.Name = "lbEntradasTaller"
        Me.lbEntradasTaller.Size = New System.Drawing.Size(213, 31)
        Me.lbEntradasTaller.TabIndex = 2
        Me.lbEntradasTaller.Text = "Entradas Taller"
        '
        'facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 763)
        Me.Controls.Add(Me.Pestanis)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "facturas"
        Me.Text = "Facturas"
        Me.Pestanis.ResumeLayout(False)
        Me.Entrantes.ResumeLayout(False)
        Me.Entrantes.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Pestanis As System.Windows.Forms.TabControl
    Friend WithEvents Entrantes As System.Windows.Forms.TabPage
    Friend WithEvents lbEntradasTaller As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents lbFechaEntrada As System.Windows.Forms.Label
    Friend WithEvents datePickerEntrada As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbEntradas As System.Windows.Forms.TextBox
    Friend WithEvents lbNEntradas As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tbMatricula As System.Windows.Forms.TextBox
    Friend WithEvents lbMatricula As System.Windows.Forms.Label
    Friend WithEvents tbColor As System.Windows.Forms.TextBox
    Friend WithEvents lbColor As System.Windows.Forms.Label
    Friend WithEvents lbModelo As System.Windows.Forms.Label
    Friend WithEvents tbModelo As System.Windows.Forms.TextBox
    Friend WithEvents lbMarca As System.Windows.Forms.Label
    Friend WithEvents tbMarca As System.Windows.Forms.TextBox
    Friend WithEvents lbKm As System.Windows.Forms.Label
    Friend WithEvents tbKm As System.Windows.Forms.TextBox
    Friend WithEvents cbCombustible As System.Windows.Forms.ComboBox
    Friend WithEvents lbCombustible As System.Windows.Forms.Label
    Friend WithEvents lbBastidor As System.Windows.Forms.Label
    Friend WithEvents tbNumBastidor As System.Windows.Forms.TextBox
    Friend WithEvents lbEstado As System.Windows.Forms.Label
    Friend WithEvents tbEstado As System.Windows.Forms.TextBox
    Friend WithEvents cbDeposito As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbObjetos As System.Windows.Forms.TextBox
    Friend WithEvents lbObjetos As System.Windows.Forms.Label
    Friend WithEvents lbPersonaTrae As System.Windows.Forms.Label
    Friend WithEvents txPersonaQT As System.Windows.Forms.TextBox
    Friend WithEvents tbPropietario As System.Windows.Forms.TextBox
    Friend WithEvents lbPropietario As System.Windows.Forms.Label
    Friend WithEvents tbDireccion As System.Windows.Forms.TextBox
    Friend WithEvents lbDireccion As System.Windows.Forms.Label
    Friend WithEvents tbCodigoPostal As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbIdentidad As System.Windows.Forms.TextBox
    Friend WithEvents lbIdentidad As System.Windows.Forms.Label
    Friend WithEvents tbTlf As System.Windows.Forms.TextBox
    Friend WithEvents lbTlf As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tbPA As System.Windows.Forms.TextBox
    Friend WithEvents lbPeritoAseguradora As System.Windows.Forms.Label
    Friend WithEvents tbNp As System.Windows.Forms.TextBox
    Friend WithEvents lbNumPoliza As System.Windows.Forms.Label
    Friend WithEvents tbEA As System.Windows.Forms.TextBox
    Friend WithEvents lbEmpresaAs As System.Windows.Forms.Label
    Friend WithEvents tbAveria As System.Windows.Forms.TextBox
    Friend WithEvents lbAveria As System.Windows.Forms.Label
    Friend WithEvents lbPeritaje As System.Windows.Forms.Label
    Friend WithEvents tbPerit As System.Windows.Forms.TextBox
    Friend WithEvents CheckBoxPER As System.Windows.Forms.CheckBox
    Friend WithEvents lbFechaPeritaje As System.Windows.Forms.Label
    Friend WithEvents DatePickerPeritaje As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckBoxAutorizadoCliente As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxAut_aseguradora As System.Windows.Forms.CheckBox
    Friend WithEvents lbTarifa As System.Windows.Forms.Label
    Friend WithEvents tbImporteReparacion As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxImporteFranquicia As System.Windows.Forms.TextBox
    Friend WithEvents ComboBoxTarifa As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBoxRetiradaTaller As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerST As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePickerFF As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lbEstadoReparacion As System.Windows.Forms.Label
    Friend WithEvents lbImporteReparacion As System.Windows.Forms.Label
    Friend WithEvents lbImporteFranc As System.Windows.Forms.Label
    Friend WithEvents CheckBoxEntradaActiva As System.Windows.Forms.CheckBox
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnAtras As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
