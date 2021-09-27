<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaFacturasDesdeHasta
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBusquedaFacturasDesdeHasta))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DGVfacturas = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnAddCue3 = New System.Windows.Forms.Button()
        Me.BtnAddCue1 = New System.Windows.Forms.Button()
        Me.BtnAddCue2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBCuenta = New System.Windows.Forms.ComboBox()
        Me.BtnActualizar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.LblCue = New System.Windows.Forms.Label()
        Me.LblNombescuela = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTPdesde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTPhasta = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBProveedor2 = New System.Windows.Forms.ComboBox()
        Me.CBCUE3 = New System.Windows.Forms.ComboBox()
        Me.CBRubro2 = New System.Windows.Forms.ComboBox()
        Me.CheckBCueyProveedor = New System.Windows.Forms.CheckBox()
        Me.CBCUE2 = New System.Windows.Forms.ComboBox()
        Me.CheckBCueyRubro = New System.Windows.Forms.CheckBox()
        Me.CBRubro = New System.Windows.Forms.ComboBox()
        Me.CBCUE = New System.Windows.Forms.ComboBox()
        Me.CBProveedor = New System.Windows.Forms.ComboBox()
        Me.CBAll = New System.Windows.Forms.ComboBox()
        Me.CheckBProveedor = New System.Windows.Forms.CheckBox()
        Me.CheckBCue = New System.Windows.Forms.CheckBox()
        Me.CheckBRubro = New System.Windows.Forms.CheckBox()
        Me.CheckBAll = New System.Windows.Forms.CheckBox()
        Me.SplContBotones = New System.Windows.Forms.SplitContainer()
        Me.BtnInfCaja = New System.Windows.Forms.Button()
        Me.BtnImprirFacturasXRubro = New System.Windows.Forms.Button()
        Me.BtnImprirFacturasXProveedor = New System.Windows.Forms.Button()
        Me.BtnImprirFacturasXCueProveedor = New System.Windows.Forms.Button()
        Me.BtnFacturasXfecha = New System.Windows.Forms.Button()
        Me.BtnImprirFacturasXCueRubro = New System.Windows.Forms.Button()
        Me.BtnImprirFacturasXCue = New System.Windows.Forms.Button()
        CType(Me.DGVfacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.SplContBotones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplContBotones.Panel1.SuspendLayout()
        Me.SplContBotones.Panel2.SuspendLayout()
        Me.SplContBotones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(311, 2)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(313, 20)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Busqueda de facturas por parametros"
        '
        'DGVfacturas
        '
        Me.DGVfacturas.AllowUserToAddRows = False
        Me.DGVfacturas.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DGVfacturas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVfacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVfacturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVfacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVfacturas.Location = New System.Drawing.Point(12, 240)
        Me.DGVfacturas.Name = "DGVfacturas"
        Me.DGVfacturas.ReadOnly = True
        Me.DGVfacturas.RowHeadersVisible = False
        Me.DGVfacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVfacturas.Size = New System.Drawing.Size(910, 300)
        Me.DGVfacturas.TabIndex = 57
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnAddCue3)
        Me.Panel1.Controls.Add(Me.BtnAddCue1)
        Me.Panel1.Controls.Add(Me.BtnAddCue2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.CBCuenta)
        Me.Panel1.Controls.Add(Me.BtnActualizar)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TxtTotal)
        Me.Panel1.Controls.Add(Me.LblCue)
        Me.Panel1.Controls.Add(Me.LblNombescuela)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.CBProveedor2)
        Me.Panel1.Controls.Add(Me.CBCUE3)
        Me.Panel1.Controls.Add(Me.CBRubro2)
        Me.Panel1.Controls.Add(Me.CheckBCueyProveedor)
        Me.Panel1.Controls.Add(Me.CBCUE2)
        Me.Panel1.Controls.Add(Me.CheckBCueyRubro)
        Me.Panel1.Controls.Add(Me.CBRubro)
        Me.Panel1.Controls.Add(Me.CBCUE)
        Me.Panel1.Controls.Add(Me.CBProveedor)
        Me.Panel1.Controls.Add(Me.CBAll)
        Me.Panel1.Controls.Add(Me.CheckBProveedor)
        Me.Panel1.Controls.Add(Me.CheckBCue)
        Me.Panel1.Controls.Add(Me.CheckBRubro)
        Me.Panel1.Controls.Add(Me.CheckBAll)
        Me.Panel1.Location = New System.Drawing.Point(12, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(910, 210)
        Me.Panel1.TabIndex = 55
        '
        'BtnAddCue3
        '
        Me.BtnAddCue3.Image = CType(resources.GetObject("BtnAddCue3.Image"), System.Drawing.Image)
        Me.BtnAddCue3.Location = New System.Drawing.Point(354, 128)
        Me.BtnAddCue3.Name = "BtnAddCue3"
        Me.BtnAddCue3.Size = New System.Drawing.Size(20, 20)
        Me.BtnAddCue3.TabIndex = 115
        Me.BtnAddCue3.UseVisualStyleBackColor = True
        '
        'BtnAddCue1
        '
        Me.BtnAddCue1.Image = CType(resources.GetObject("BtnAddCue1.Image"), System.Drawing.Image)
        Me.BtnAddCue1.Location = New System.Drawing.Point(148, 71)
        Me.BtnAddCue1.Name = "BtnAddCue1"
        Me.BtnAddCue1.Size = New System.Drawing.Size(20, 20)
        Me.BtnAddCue1.TabIndex = 114
        Me.BtnAddCue1.UseVisualStyleBackColor = True
        '
        'BtnAddCue2
        '
        Me.BtnAddCue2.Image = CType(resources.GetObject("BtnAddCue2.Image"), System.Drawing.Image)
        Me.BtnAddCue2.Location = New System.Drawing.Point(83, 127)
        Me.BtnAddCue2.Name = "BtnAddCue2"
        Me.BtnAddCue2.Size = New System.Drawing.Size(20, 20)
        Me.BtnAddCue2.TabIndex = 113
        Me.BtnAddCue2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Cuentas"
        '
        'CBCuenta
        '
        Me.CBCuenta.FormattingEnabled = True
        Me.CBCuenta.Items.AddRange(New Object() {"Todas", "Compensador", "CUFP"})
        Me.CBCuenta.Location = New System.Drawing.Point(92, 45)
        Me.CBCuenta.Name = "CBCuenta"
        Me.CBCuenta.Size = New System.Drawing.Size(624, 21)
        Me.CBCuenta.TabIndex = 39
        Me.CBCuenta.Text = "Todas"
        '
        'BtnActualizar
        '
        Me.BtnActualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizar.Location = New System.Drawing.Point(736, 171)
        Me.BtnActualizar.Name = "BtnActualizar"
        Me.BtnActualizar.Size = New System.Drawing.Size(161, 28)
        Me.BtnActualizar.TabIndex = 38
        Me.BtnActualizar.Text = "Actualizar"
        Me.BtnActualizar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(623, 117)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 16)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Monto total"
        '
        'TxtTotal
        '
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(593, 145)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtTotal.Size = New System.Drawing.Size(137, 29)
        Me.TxtTotal.TabIndex = 34
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblCue
        '
        Me.LblCue.AutoSize = True
        Me.LblCue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCue.Location = New System.Drawing.Point(28, 184)
        Me.LblCue.Name = "LblCue"
        Me.LblCue.Size = New System.Drawing.Size(257, 16)
        Me.LblCue.TabIndex = 33
        Me.LblCue.Text = "Nombre de escuela del Cue selecionado:"
        Me.LblCue.Visible = False
        '
        'LblNombescuela
        '
        Me.LblNombescuela.AutoSize = True
        Me.LblNombescuela.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombescuela.Location = New System.Drawing.Point(283, 184)
        Me.LblNombescuela.Name = "LblNombescuela"
        Me.LblNombescuela.Size = New System.Drawing.Size(0, 16)
        Me.LblNombescuela.TabIndex = 32
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.DTPdesde)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.DTPhasta)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(736, 45)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(161, 120)
        Me.Panel2.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 16)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Elija las fechas"
        '
        'DTPdesde
        '
        Me.DTPdesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPdesde.Location = New System.Drawing.Point(29, 48)
        Me.DTPdesde.Name = "DTPdesde"
        Me.DTPdesde.Size = New System.Drawing.Size(101, 20)
        Me.DTPdesde.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Hasta"
        '
        'DTPhasta
        '
        Me.DTPhasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPhasta.Location = New System.Drawing.Point(29, 90)
        Me.DTPhasta.Name = "DTPhasta"
        Me.DTPhasta.Size = New System.Drawing.Size(101, 20)
        Me.DTPhasta.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 16)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Desde"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(406, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 16)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Elija Reporte"
        '
        'CBProveedor2
        '
        Me.CBProveedor2.Enabled = False
        Me.CBProveedor2.FormattingEnabled = True
        Me.CBProveedor2.Location = New System.Drawing.Point(417, 153)
        Me.CBProveedor2.Name = "CBProveedor2"
        Me.CBProveedor2.Size = New System.Drawing.Size(162, 21)
        Me.CBProveedor2.TabIndex = 24
        '
        'CBCUE3
        '
        Me.CBCUE3.Enabled = False
        Me.CBCUE3.FormattingEnabled = True
        Me.CBCUE3.Location = New System.Drawing.Point(321, 153)
        Me.CBCUE3.Name = "CBCUE3"
        Me.CBCUE3.Size = New System.Drawing.Size(90, 21)
        Me.CBCUE3.TabIndex = 23
        '
        'CBRubro2
        '
        Me.CBRubro2.Enabled = False
        Me.CBRubro2.FormattingEnabled = True
        Me.CBRubro2.Location = New System.Drawing.Point(130, 153)
        Me.CBRubro2.Name = "CBRubro2"
        Me.CBRubro2.Size = New System.Drawing.Size(185, 21)
        Me.CBRubro2.TabIndex = 22
        '
        'CheckBCueyProveedor
        '
        Me.CheckBCueyProveedor.AutoSize = True
        Me.CheckBCueyProveedor.Location = New System.Drawing.Point(378, 130)
        Me.CheckBCueyProveedor.Name = "CheckBCueyProveedor"
        Me.CheckBCueyProveedor.Size = New System.Drawing.Size(127, 17)
        Me.CheckBCueyProveedor.TabIndex = 21
        Me.CheckBCueyProveedor.Text = "Por CUE y Proveedor"
        Me.CheckBCueyProveedor.UseVisualStyleBackColor = True
        '
        'CBCUE2
        '
        Me.CBCUE2.Enabled = False
        Me.CBCUE2.FormattingEnabled = True
        Me.CBCUE2.Location = New System.Drawing.Point(34, 153)
        Me.CBCUE2.Name = "CBCUE2"
        Me.CBCUE2.Size = New System.Drawing.Size(90, 21)
        Me.CBCUE2.TabIndex = 20
        '
        'CheckBCueyRubro
        '
        Me.CheckBCueyRubro.AutoSize = True
        Me.CheckBCueyRubro.Location = New System.Drawing.Point(109, 130)
        Me.CheckBCueyRubro.Name = "CheckBCueyRubro"
        Me.CheckBCueyRubro.Size = New System.Drawing.Size(107, 17)
        Me.CheckBCueyRubro.TabIndex = 19
        Me.CheckBCueyRubro.Text = "Por CUE y Rubro"
        Me.CheckBCueyRubro.UseVisualStyleBackColor = True
        '
        'CBRubro
        '
        Me.CBRubro.Enabled = False
        Me.CBRubro.FormattingEnabled = True
        Me.CBRubro.Location = New System.Drawing.Point(242, 94)
        Me.CBRubro.Name = "CBRubro"
        Me.CBRubro.Size = New System.Drawing.Size(185, 21)
        Me.CBRubro.TabIndex = 18
        '
        'CBCUE
        '
        Me.CBCUE.Enabled = False
        Me.CBCUE.FormattingEnabled = True
        Me.CBCUE.Location = New System.Drawing.Point(146, 94)
        Me.CBCUE.Name = "CBCUE"
        Me.CBCUE.Size = New System.Drawing.Size(90, 21)
        Me.CBCUE.TabIndex = 17
        '
        'CBProveedor
        '
        Me.CBProveedor.Enabled = False
        Me.CBProveedor.FormattingEnabled = True
        Me.CBProveedor.Location = New System.Drawing.Point(433, 94)
        Me.CBProveedor.Name = "CBProveedor"
        Me.CBProveedor.Size = New System.Drawing.Size(162, 21)
        Me.CBProveedor.TabIndex = 16
        '
        'CBAll
        '
        Me.CBAll.Enabled = False
        Me.CBAll.FormattingEnabled = True
        Me.CBAll.Location = New System.Drawing.Point(25, 94)
        Me.CBAll.Name = "CBAll"
        Me.CBAll.Size = New System.Drawing.Size(117, 21)
        Me.CBAll.TabIndex = 15
        '
        'CheckBProveedor
        '
        Me.CheckBProveedor.AutoSize = True
        Me.CheckBProveedor.Location = New System.Drawing.Point(452, 74)
        Me.CheckBProveedor.Name = "CheckBProveedor"
        Me.CheckBProveedor.Size = New System.Drawing.Size(94, 17)
        Me.CheckBProveedor.TabIndex = 14
        Me.CheckBProveedor.Text = "Por Proveedor"
        Me.CheckBProveedor.UseVisualStyleBackColor = True
        '
        'CheckBCue
        '
        Me.CheckBCue.AutoSize = True
        Me.CheckBCue.Location = New System.Drawing.Point(171, 74)
        Me.CheckBCue.Name = "CheckBCue"
        Me.CheckBCue.Size = New System.Drawing.Size(67, 17)
        Me.CheckBCue.TabIndex = 13
        Me.CheckBCue.Text = "Por CUE"
        Me.CheckBCue.UseVisualStyleBackColor = True
        '
        'CheckBRubro
        '
        Me.CheckBRubro.AutoSize = True
        Me.CheckBRubro.Location = New System.Drawing.Point(300, 74)
        Me.CheckBRubro.Name = "CheckBRubro"
        Me.CheckBRubro.Size = New System.Drawing.Size(69, 17)
        Me.CheckBRubro.TabIndex = 12
        Me.CheckBRubro.Text = "Por rubro"
        Me.CheckBRubro.UseVisualStyleBackColor = True
        '
        'CheckBAll
        '
        Me.CheckBAll.AutoSize = True
        Me.CheckBAll.Checked = True
        Me.CheckBAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBAll.Location = New System.Drawing.Point(29, 74)
        Me.CheckBAll.Name = "CheckBAll"
        Me.CheckBAll.Size = New System.Drawing.Size(113, 17)
        Me.CheckBAll.TabIndex = 11
        Me.CheckBAll.Text = "Todas las facturas"
        Me.CheckBAll.UseVisualStyleBackColor = True
        '
        'SplContBotones
        '
        Me.SplContBotones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplContBotones.Location = New System.Drawing.Point(0, 389)
        Me.SplContBotones.Name = "SplContBotones"
        '
        'SplContBotones.Panel1
        '
        Me.SplContBotones.Panel1.Controls.Add(Me.BtnInfCaja)
        '
        'SplContBotones.Panel2
        '
        Me.SplContBotones.Panel2.Controls.Add(Me.BtnImprirFacturasXRubro)
        Me.SplContBotones.Panel2.Controls.Add(Me.BtnImprirFacturasXProveedor)
        Me.SplContBotones.Panel2.Controls.Add(Me.BtnImprirFacturasXCueProveedor)
        Me.SplContBotones.Panel2.Controls.Add(Me.BtnFacturasXfecha)
        Me.SplContBotones.Panel2.Controls.Add(Me.BtnImprirFacturasXCueRubro)
        Me.SplContBotones.Panel2.Controls.Add(Me.BtnImprirFacturasXCue)
        Me.SplContBotones.Size = New System.Drawing.Size(934, 182)
        Me.SplContBotones.SplitterDistance = 422
        Me.SplContBotones.TabIndex = 61
        '
        'BtnInfCaja
        '
        Me.BtnInfCaja.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnInfCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInfCaja.Location = New System.Drawing.Point(0, 153)
        Me.BtnInfCaja.Name = "BtnInfCaja"
        Me.BtnInfCaja.Size = New System.Drawing.Size(422, 29)
        Me.BtnInfCaja.TabIndex = 55
        Me.BtnInfCaja.Text = "Buscar"
        Me.BtnInfCaja.UseVisualStyleBackColor = True
        '
        'BtnImprirFacturasXRubro
        '
        Me.BtnImprirFacturasXRubro.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnImprirFacturasXRubro.Enabled = False
        Me.BtnImprirFacturasXRubro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnImprirFacturasXRubro.Location = New System.Drawing.Point(0, 8)
        Me.BtnImprirFacturasXRubro.Name = "BtnImprirFacturasXRubro"
        Me.BtnImprirFacturasXRubro.Size = New System.Drawing.Size(508, 29)
        Me.BtnImprirFacturasXRubro.TabIndex = 65
        Me.BtnImprirFacturasXRubro.Text = "Imprimir facturas por Rubro"
        Me.BtnImprirFacturasXRubro.UseVisualStyleBackColor = True
        Me.BtnImprirFacturasXRubro.Visible = False
        '
        'BtnImprirFacturasXProveedor
        '
        Me.BtnImprirFacturasXProveedor.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnImprirFacturasXProveedor.Enabled = False
        Me.BtnImprirFacturasXProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnImprirFacturasXProveedor.Location = New System.Drawing.Point(0, 37)
        Me.BtnImprirFacturasXProveedor.Name = "BtnImprirFacturasXProveedor"
        Me.BtnImprirFacturasXProveedor.Size = New System.Drawing.Size(508, 29)
        Me.BtnImprirFacturasXProveedor.TabIndex = 64
        Me.BtnImprirFacturasXProveedor.Text = "Imprimir facturas por Proveedor"
        Me.BtnImprirFacturasXProveedor.UseVisualStyleBackColor = True
        Me.BtnImprirFacturasXProveedor.Visible = False
        '
        'BtnImprirFacturasXCueProveedor
        '
        Me.BtnImprirFacturasXCueProveedor.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnImprirFacturasXCueProveedor.Enabled = False
        Me.BtnImprirFacturasXCueProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnImprirFacturasXCueProveedor.Location = New System.Drawing.Point(0, 66)
        Me.BtnImprirFacturasXCueProveedor.Name = "BtnImprirFacturasXCueProveedor"
        Me.BtnImprirFacturasXCueProveedor.Size = New System.Drawing.Size(508, 29)
        Me.BtnImprirFacturasXCueProveedor.TabIndex = 63
        Me.BtnImprirFacturasXCueProveedor.Text = "Imprimir facturas por Cue y Proveedor"
        Me.BtnImprirFacturasXCueProveedor.UseVisualStyleBackColor = True
        Me.BtnImprirFacturasXCueProveedor.Visible = False
        '
        'BtnFacturasXfecha
        '
        Me.BtnFacturasXfecha.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnFacturasXfecha.Enabled = False
        Me.BtnFacturasXfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnFacturasXfecha.Location = New System.Drawing.Point(0, 95)
        Me.BtnFacturasXfecha.Name = "BtnFacturasXfecha"
        Me.BtnFacturasXfecha.Size = New System.Drawing.Size(508, 29)
        Me.BtnFacturasXfecha.TabIndex = 62
        Me.BtnFacturasXfecha.Text = "Imprimir facturas por fecha"
        Me.BtnFacturasXfecha.UseVisualStyleBackColor = True
        '
        'BtnImprirFacturasXCueRubro
        '
        Me.BtnImprirFacturasXCueRubro.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnImprirFacturasXCueRubro.Enabled = False
        Me.BtnImprirFacturasXCueRubro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnImprirFacturasXCueRubro.Location = New System.Drawing.Point(0, 124)
        Me.BtnImprirFacturasXCueRubro.Name = "BtnImprirFacturasXCueRubro"
        Me.BtnImprirFacturasXCueRubro.Size = New System.Drawing.Size(508, 29)
        Me.BtnImprirFacturasXCueRubro.TabIndex = 61
        Me.BtnImprirFacturasXCueRubro.Text = "Imprimir facturas por Cue y Rubro"
        Me.BtnImprirFacturasXCueRubro.UseVisualStyleBackColor = True
        Me.BtnImprirFacturasXCueRubro.Visible = False
        '
        'BtnImprirFacturasXCue
        '
        Me.BtnImprirFacturasXCue.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnImprirFacturasXCue.Enabled = False
        Me.BtnImprirFacturasXCue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BtnImprirFacturasXCue.Location = New System.Drawing.Point(0, 153)
        Me.BtnImprirFacturasXCue.Name = "BtnImprirFacturasXCue"
        Me.BtnImprirFacturasXCue.Size = New System.Drawing.Size(508, 29)
        Me.BtnImprirFacturasXCue.TabIndex = 60
        Me.BtnImprirFacturasXCue.Text = "Imprimir facturas por Cue"
        Me.BtnImprirFacturasXCue.UseVisualStyleBackColor = True
        Me.BtnImprirFacturasXCue.Visible = False
        '
        'FrmBusquedaFacturasDesdeHasta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 571)
        Me.Controls.Add(Me.DGVfacturas)
        Me.Controls.Add(Me.SplContBotones)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmBusquedaFacturasDesdeHasta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de  facturas Desde Hasta"
        CType(Me.DGVfacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.SplContBotones.Panel1.ResumeLayout(False)
        Me.SplContBotones.Panel2.ResumeLayout(False)
        CType(Me.SplContBotones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplContBotones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents DGVfacturas As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents CBCuenta As ComboBox
    Friend WithEvents BtnActualizar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents LblCue As Label
    Friend WithEvents LblNombescuela As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents DTPdesde As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents DTPhasta As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents CBProveedor2 As ComboBox
    Friend WithEvents CBCUE3 As ComboBox
    Friend WithEvents CBRubro2 As ComboBox
    Friend WithEvents CheckBCueyProveedor As CheckBox
    Friend WithEvents CBCUE2 As ComboBox
    Friend WithEvents CheckBCueyRubro As CheckBox
    Friend WithEvents CBRubro As ComboBox
    Friend WithEvents CBCUE As ComboBox
    Friend WithEvents CBProveedor As ComboBox
    Friend WithEvents CBAll As ComboBox
    Friend WithEvents CheckBProveedor As CheckBox
    Friend WithEvents CheckBCue As CheckBox
    Friend WithEvents CheckBRubro As CheckBox
    Friend WithEvents CheckBAll As CheckBox
    Friend WithEvents SplContBotones As SplitContainer
    Friend WithEvents BtnInfCaja As Button
    Friend WithEvents BtnFacturasXfecha As Button
    Friend WithEvents BtnImprirFacturasXCueRubro As Button
    Friend WithEvents BtnImprirFacturasXCue As Button
    Friend WithEvents BtnImprirFacturasXCueProveedor As Button
    Friend WithEvents BtnImprirFacturasXProveedor As Button
    Friend WithEvents BtnImprirFacturasXRubro As Button
    Friend WithEvents BtnAddCue3 As Button
    Friend WithEvents BtnAddCue1 As Button
    Friend WithEvents BtnAddCue2 As Button
End Class
