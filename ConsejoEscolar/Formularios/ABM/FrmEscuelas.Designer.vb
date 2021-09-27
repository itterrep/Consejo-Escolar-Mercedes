<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEscuelas
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
        Me.TSClientes = New System.Windows.Forms.ToolStrip()
        Me.tsbtnNew = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnEditar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnCancelar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnBuscar = New System.Windows.Forms.ToolStripButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.DGVEscuela = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMatricula = New System.Windows.Forms.TextBox()
        Me.TxtTelFijo = New System.Windows.Forms.TextBox()
        Me.TxtDomicilio = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtIdCue = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtCantSecc = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtTelCelular = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtCupo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CBComedor = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PanelDatos = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DTPultAsamblea = New System.Windows.Forms.DateTimePicker()
        Me.CBCooperadora = New System.Windows.Forms.ComboBox()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LblFechaAsamblea = New System.Windows.Forms.Label()
        Me.TxtCiudad = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTipo = New System.Windows.Forms.TextBox()
        Me.BtnCopiar = New System.Windows.Forms.Button()
        Me.TSClientes.SuspendLayout()
        CType(Me.DGVEscuela, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'TSClientes
        '
        Me.TSClientes.BackColor = System.Drawing.Color.Gray
        Me.TSClientes.Dock = System.Windows.Forms.DockStyle.Right
        Me.TSClientes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSClientes.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TSClientes.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.TSClientes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnNew, Me.ToolStripSeparator5, Me.tsbtnEditar, Me.ToolStripSeparator4, Me.tsbtnEliminar, Me.ToolStripSeparator1, Me.tsbtnGuardar, Me.ToolStripSeparator2, Me.tsbtnCancelar, Me.ToolStripSeparator3, Me.tsbtnBuscar})
        Me.TSClientes.Location = New System.Drawing.Point(893, 0)
        Me.TSClientes.Name = "TSClientes"
        Me.TSClientes.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TSClientes.Size = New System.Drawing.Size(77, 521)
        Me.TSClientes.TabIndex = 11
        Me.TSClientes.Text = "ToolStrip1"
        '
        'tsbtnNew
        '
        Me.tsbtnNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnNew.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_add_72
        Me.tsbtnNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnNew.Name = "tsbtnNew"
        Me.tsbtnNew.Size = New System.Drawing.Size(74, 76)
        Me.tsbtnNew.Text = "Nuevo"
        Me.tsbtnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(74, 6)
        '
        'tsbtnEditar
        '
        Me.tsbtnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnEditar.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_edit_72
        Me.tsbtnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEditar.Name = "tsbtnEditar"
        Me.tsbtnEditar.Size = New System.Drawing.Size(74, 76)
        Me.tsbtnEditar.Text = "Editar"
        Me.tsbtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(74, 6)
        '
        'tsbtnEliminar
        '
        Me.tsbtnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnEliminar.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_delete_72
        Me.tsbtnEliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEliminar.Name = "tsbtnEliminar"
        Me.tsbtnEliminar.Size = New System.Drawing.Size(74, 76)
        Me.tsbtnEliminar.Text = "Eliminar"
        Me.tsbtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(74, 6)
        '
        'tsbtnGuardar
        '
        Me.tsbtnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnGuardar.Enabled = False
        Me.tsbtnGuardar.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_save_72
        Me.tsbtnGuardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnGuardar.Name = "tsbtnGuardar"
        Me.tsbtnGuardar.Size = New System.Drawing.Size(74, 76)
        Me.tsbtnGuardar.Text = "Guardar"
        Me.tsbtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(74, 6)
        '
        'tsbtnCancelar
        '
        Me.tsbtnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnCancelar.Enabled = False
        Me.tsbtnCancelar.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_cancel_72
        Me.tsbtnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCancelar.Name = "tsbtnCancelar"
        Me.tsbtnCancelar.Size = New System.Drawing.Size(74, 76)
        Me.tsbtnCancelar.Text = "Cancelar"
        Me.tsbtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(74, 6)
        '
        'tsbtnBuscar
        '
        Me.tsbtnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnBuscar.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_find_72
        Me.tsbtnBuscar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnBuscar.Name = "tsbtnBuscar"
        Me.tsbtnBuscar.Size = New System.Drawing.Size(74, 76)
        Me.tsbtnBuscar.Text = "Buscar"
        Me.tsbtnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(396, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Correo @"
        '
        'TxtEmail
        '
        Me.TxtEmail.BackColor = System.Drawing.Color.LightGreen
        Me.TxtEmail.Location = New System.Drawing.Point(297, 137)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.ReadOnly = True
        Me.TxtEmail.Size = New System.Drawing.Size(250, 20)
        Me.TxtEmail.TabIndex = 7
        '
        'DGVEscuela
        '
        Me.DGVEscuela.AllowUserToAddRows = False
        Me.DGVEscuela.AllowUserToDeleteRows = False
        Me.DGVEscuela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVEscuela.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVEscuela.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DGVEscuela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVEscuela.Location = New System.Drawing.Point(7, 204)
        Me.DGVEscuela.Name = "DGVEscuela"
        Me.DGVEscuela.ReadOnly = True
        Me.DGVEscuela.RowHeadersVisible = False
        Me.DGVEscuela.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVEscuela.Size = New System.Drawing.Size(875, 305)
        Me.DGVEscuela.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(200, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Matricula"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Telefono Fijo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(98, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Domicilio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(323, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "CUE"
        '
        'TxtMatricula
        '
        Me.TxtMatricula.BackColor = System.Drawing.Color.LightGreen
        Me.TxtMatricula.Location = New System.Drawing.Point(165, 33)
        Me.TxtMatricula.MaxLength = 13
        Me.TxtMatricula.Name = "TxtMatricula"
        Me.TxtMatricula.ReadOnly = True
        Me.TxtMatricula.Size = New System.Drawing.Size(120, 20)
        Me.TxtMatricula.TabIndex = 10
        '
        'TxtTelFijo
        '
        Me.TxtTelFijo.BackColor = System.Drawing.Color.LightGreen
        Me.TxtTelFijo.Location = New System.Drawing.Point(9, 137)
        Me.TxtTelFijo.Name = "TxtTelFijo"
        Me.TxtTelFijo.ReadOnly = True
        Me.TxtTelFijo.Size = New System.Drawing.Size(140, 20)
        Me.TxtTelFijo.TabIndex = 5
        '
        'TxtDomicilio
        '
        Me.TxtDomicilio.BackColor = System.Drawing.Color.LightGreen
        Me.TxtDomicilio.Location = New System.Drawing.Point(10, 98)
        Me.TxtDomicilio.Name = "TxtDomicilio"
        Me.TxtDomicilio.ReadOnly = True
        Me.TxtDomicilio.Size = New System.Drawing.Size(281, 20)
        Me.TxtDomicilio.TabIndex = 3
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.LightGreen
        Me.TxtNombre.Location = New System.Drawing.Point(237, 59)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.ReadOnly = True
        Me.TxtNombre.Size = New System.Drawing.Size(310, 20)
        Me.TxtNombre.TabIndex = 2
        '
        'TxtIdCue
        '
        Me.TxtIdCue.BackColor = System.Drawing.Color.LightGreen
        Me.TxtIdCue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdCue.Location = New System.Drawing.Point(71, 8)
        Me.TxtIdCue.Name = "TxtIdCue"
        Me.TxtIdCue.ReadOnly = True
        Me.TxtIdCue.Size = New System.Drawing.Size(146, 26)
        Me.TxtIdCue.TabIndex = 0
        Me.TxtIdCue.Text = "00000000"
        Me.TxtIdCue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(275, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(338, 24)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Altas, bajas y modificación de Escuelas"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(38, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 13)
        Me.Label10.TabIndex = 45
        Me.Label10.Text = "Cant. de Secciones"
        '
        'TxtCantSecc
        '
        Me.TxtCantSecc.BackColor = System.Drawing.Color.LightGreen
        Me.TxtCantSecc.Location = New System.Drawing.Point(28, 33)
        Me.TxtCantSecc.Name = "TxtCantSecc"
        Me.TxtCantSecc.ReadOnly = True
        Me.TxtCantSecc.Size = New System.Drawing.Size(120, 20)
        Me.TxtCantSecc.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(181, 121)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 13)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Telefono Celular"
        '
        'TxtTelCelular
        '
        Me.TxtTelCelular.BackColor = System.Drawing.Color.LightGreen
        Me.TxtTelCelular.Location = New System.Drawing.Point(153, 137)
        Me.TxtTelCelular.Name = "TxtTelCelular"
        Me.TxtTelCelular.ReadOnly = True
        Me.TxtTelCelular.Size = New System.Drawing.Size(140, 20)
        Me.TxtTelCelular.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(258, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 13)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "Cupo"
        '
        'TxtCupo
        '
        Me.TxtCupo.BackColor = System.Drawing.Color.LightGreen
        Me.TxtCupo.Location = New System.Drawing.Point(240, 72)
        Me.TxtCupo.Name = "TxtCupo"
        Me.TxtCupo.ReadOnly = True
        Me.TxtCupo.Size = New System.Drawing.Size(68, 20)
        Me.TxtCupo.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(131, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 64
        Me.Label8.Text = "Tipo"
        '
        'CBComedor
        '
        Me.CBComedor.BackColor = System.Drawing.Color.LightGreen
        Me.CBComedor.Enabled = False
        Me.CBComedor.FormattingEnabled = True
        Me.CBComedor.Location = New System.Drawing.Point(4, 71)
        Me.CBComedor.Name = "CBComedor"
        Me.CBComedor.Size = New System.Drawing.Size(230, 21)
        Me.CBComedor.TabIndex = 11
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(67, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 13)
        Me.Label15.TabIndex = 67
        Me.Label15.Text = "Comedor"
        '
        'PanelDatos
        '
        Me.PanelDatos.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PanelDatos.Controls.Add(Me.Label11)
        Me.PanelDatos.Controls.Add(Me.CBComedor)
        Me.PanelDatos.Controls.Add(Me.Label13)
        Me.PanelDatos.Controls.Add(Me.Label15)
        Me.PanelDatos.Controls.Add(Me.DTPultAsamblea)
        Me.PanelDatos.Controls.Add(Me.Label14)
        Me.PanelDatos.Controls.Add(Me.CBCooperadora)
        Me.PanelDatos.Controls.Add(Me.TxtCupo)
        Me.PanelDatos.Controls.Add(Me.Label10)
        Me.PanelDatos.Controls.Add(Me.TxtCantSecc)
        Me.PanelDatos.Controls.Add(Me.Label5)
        Me.PanelDatos.Controls.Add(Me.TxtMatricula)
        Me.PanelDatos.Controls.Add(Me.ShapeContainer1)
        Me.PanelDatos.Controls.Add(Me.LblFechaAsamblea)
        Me.PanelDatos.Location = New System.Drawing.Point(553, 47)
        Me.PanelDatos.Name = "PanelDatos"
        Me.PanelDatos.Size = New System.Drawing.Size(329, 148)
        Me.PanelDatos.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(46, 103)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 70
        Me.Label11.Text = "Cooperadora"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(170, 103)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(115, 13)
        Me.Label13.TabIndex = 69
        Me.Label13.Text = "Fecha ultima asamblea"
        '
        'DTPultAsamblea
        '
        Me.DTPultAsamblea.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPultAsamblea.Location = New System.Drawing.Point(172, 119)
        Me.DTPultAsamblea.Name = "DTPultAsamblea"
        Me.DTPultAsamblea.Size = New System.Drawing.Size(100, 20)
        Me.DTPultAsamblea.TabIndex = 14
        '
        'CBCooperadora
        '
        Me.CBCooperadora.BackColor = System.Drawing.Color.LightGreen
        Me.CBCooperadora.Enabled = False
        Me.CBCooperadora.FormattingEnabled = True
        Me.CBCooperadora.Items.AddRange(New Object() {"SI", "No"})
        Me.CBCooperadora.Location = New System.Drawing.Point(44, 119)
        Me.CBCooperadora.Name = "CBCooperadora"
        Me.CBCooperadora.Size = New System.Drawing.Size(73, 21)
        Me.CBCooperadora.TabIndex = 13
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(329, 148)
        Me.ShapeContainer1.TabIndex = 72
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 10
        Me.LineShape1.X2 = 315
        Me.LineShape1.Y1 = 100
        Me.LineShape1.Y2 = 100
        '
        'LblFechaAsamblea
        '
        Me.LblFechaAsamblea.AutoSize = True
        Me.LblFechaAsamblea.Location = New System.Drawing.Point(189, 122)
        Me.LblFechaAsamblea.Name = "LblFechaAsamblea"
        Me.LblFechaAsamblea.Size = New System.Drawing.Size(45, 13)
        Me.LblFechaAsamblea.TabIndex = 73
        Me.LblFechaAsamblea.Text = "Label16"
        '
        'TxtCiudad
        '
        Me.TxtCiudad.BackColor = System.Drawing.Color.LightGreen
        Me.TxtCiudad.Location = New System.Drawing.Point(297, 98)
        Me.TxtCiudad.Name = "TxtCiudad"
        Me.TxtCiudad.ReadOnly = True
        Me.TxtCiudad.Size = New System.Drawing.Size(250, 20)
        Me.TxtCiudad.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(385, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Ciudad"
        '
        'TxtTipo
        '
        Me.TxtTipo.BackColor = System.Drawing.Color.LightGreen
        Me.TxtTipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTipo.Location = New System.Drawing.Point(10, 59)
        Me.TxtTipo.Name = "TxtTipo"
        Me.TxtTipo.ReadOnly = True
        Me.TxtTipo.Size = New System.Drawing.Size(221, 20)
        Me.TxtTipo.TabIndex = 1
        '
        'BtnCopiar
        '
        Me.BtnCopiar.Image = Global.ConsejoEscolar.My.Resources.Resources.Bl_seleccionar48
        Me.BtnCopiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCopiar.Location = New System.Drawing.Point(9, 163)
        Me.BtnCopiar.Name = "BtnCopiar"
        Me.BtnCopiar.Size = New System.Drawing.Size(135, 35)
        Me.BtnCopiar.TabIndex = 14
        Me.BtnCopiar.Text = "Copiar Selección"
        Me.BtnCopiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCopiar.UseVisualStyleBackColor = True
        '
        'FrmEscuelas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(970, 521)
        Me.Controls.Add(Me.TxtTipo)
        Me.Controls.Add(Me.PanelDatos)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtTelCelular)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BtnCopiar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtCiudad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.DGVEscuela)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTelFijo)
        Me.Controls.Add(Me.TxtDomicilio)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtIdCue)
        Me.Controls.Add(Me.TSClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmEscuelas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM-Escuelas"
        Me.TSClientes.ResumeLayout(False)
        Me.TSClientes.PerformLayout()
        CType(Me.DGVEscuela, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDatos.ResumeLayout(False)
        Me.PanelDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TSClientes As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnNew As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnEditar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnEliminar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnGuardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnCancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnBuscar As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents DGVEscuela As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtMatricula As System.Windows.Forms.TextBox
    Friend WithEvents TxtTelFijo As System.Windows.Forms.TextBox
    Friend WithEvents TxtDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdCue As System.Windows.Forms.TextBox
    Friend WithEvents BtnCopiar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtCantSecc As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtTelCelular As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtCupo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CBComedor As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents PanelDatos As System.Windows.Forms.Panel
    Friend WithEvents TxtCiudad As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtTipo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DTPultAsamblea As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBCooperadora As System.Windows.Forms.ComboBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LblFechaAsamblea As System.Windows.Forms.Label
End Class
