<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCargaCargos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnSeleccionar = New System.Windows.Forms.Button()
        Me.BrnAgregaArticulo = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TPAuxiliar = New System.Windows.Forms.TabPage()
        Me.BtnCopiarAuxiliar = New System.Windows.Forms.Button()
        Me.DGVAuxiliar = New System.Windows.Forms.DataGridView()
        Me.TSAuxiliar = New System.Windows.Forms.ToolStrip()
        Me.tsbtnAgregarAuxiliar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnEditarAuxiliar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnEliminarAuxiliar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnGuardarAuxiliar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnCancelarAuxiliar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnBuscarAuxiliar = New System.Windows.Forms.ToolStripButton()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.CBSituacionRevistaAuxiliar = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.CBTurnoAuxiliar = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblIdEsculaDirectivoA = New System.Windows.Forms.Label()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtCueAuxiliar = New System.Windows.Forms.TextBox()
        Me.TxtNombreCueAuxiliar = New System.Windows.Forms.TextBox()
        Me.BtnAddCueAuxiliar = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TxtApellidoAuxiliar = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtDniAuxiliar = New System.Windows.Forms.TextBox()
        Me.TxtNombreauxiliar = New System.Windows.Forms.TextBox()
        Me.BtnAddAuxiliar = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TPSecretario = New System.Windows.Forms.TabPage()
        Me.BtnCopiarSecretario = New System.Windows.Forms.Button()
        Me.DGVSecretario = New System.Windows.Forms.DataGridView()
        Me.TSSecretario = New System.Windows.Forms.ToolStrip()
        Me.tsbtnAgregarSecretario = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnEditarSecretario = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnEliminarSecretario = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnGuardarSecretario = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnCancelarSecretario = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnBuscarSecretario = New System.Windows.Forms.ToolStripButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CBSituacionRevistaSecretario = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.CBTurnoSecretario = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblIdEsculaDirectivoS = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtCueSecretario = New System.Windows.Forms.TextBox()
        Me.TxtNombreCueSecretario = New System.Windows.Forms.TextBox()
        Me.BtnAddCueSecretario = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TxtApellidoSecretario = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtDniSecretario = New System.Windows.Forms.TextBox()
        Me.TxtNombreSecretario = New System.Windows.Forms.TextBox()
        Me.BtnAddSecretario = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TPDirector = New System.Windows.Forms.TabPage()
        Me.BtnCopiarDirector = New System.Windows.Forms.Button()
        Me.DGVDirector = New System.Windows.Forms.DataGridView()
        Me.TSDirector = New System.Windows.Forms.ToolStrip()
        Me.tsbtnAgregarDirector = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnEditarDirector = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnEliminarDirector = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnGuardarDirector = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnCancelarDirector = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnBuscarDirector = New System.Windows.Forms.ToolStripButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CBSituacionRevistaDirector = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.CBTurnoDirector = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblIdEsculaDirectivoD = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCueDirector = New System.Windows.Forms.TextBox()
        Me.TxtNombreCueDirector = New System.Windows.Forms.TextBox()
        Me.BtnAddCueDirector = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TxtApellidoDirector = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtDniDirector = New System.Windows.Forms.TextBox()
        Me.TxtNombreDirector = New System.Windows.Forms.TextBox()
        Me.BtnAddDirector = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabCargaTareas = New System.Windows.Forms.TabControl()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.TPAuxiliar.SuspendLayout()
        CType(Me.DGVAuxiliar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TSAuxiliar.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.TPSecretario.SuspendLayout()
        CType(Me.DGVSecretario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TSSecretario.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.TPDirector.SuspendLayout()
        CType(Me.DGVDirector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TSDirector.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabCargaTareas.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnSeleccionar
        '
        Me.BtnSeleccionar.Location = New System.Drawing.Point(585, 533)
        Me.BtnSeleccionar.Name = "BtnSeleccionar"
        Me.BtnSeleccionar.Size = New System.Drawing.Size(112, 29)
        Me.BtnSeleccionar.TabIndex = 36
        Me.BtnSeleccionar.Text = "Seleccionar"
        Me.BtnSeleccionar.UseVisualStyleBackColor = True
        Me.BtnSeleccionar.Visible = False
        '
        'BrnAgregaArticulo
        '
        Me.BrnAgregaArticulo.Location = New System.Drawing.Point(404, 533)
        Me.BrnAgregaArticulo.Name = "BrnAgregaArticulo"
        Me.BrnAgregaArticulo.Size = New System.Drawing.Size(112, 29)
        Me.BrnAgregaArticulo.TabIndex = 44
        Me.BrnAgregaArticulo.Text = "Seleccionar"
        Me.BrnAgregaArticulo.UseVisualStyleBackColor = True
        Me.BrnAgregaArticulo.Visible = False
        '
        'TPAuxiliar
        '
        Me.TPAuxiliar.Controls.Add(Me.BtnCopiarAuxiliar)
        Me.TPAuxiliar.Controls.Add(Me.DGVAuxiliar)
        Me.TPAuxiliar.Controls.Add(Me.TSAuxiliar)
        Me.TPAuxiliar.Controls.Add(Me.Panel7)
        Me.TPAuxiliar.Controls.Add(Me.Panel8)
        Me.TPAuxiliar.Controls.Add(Me.Panel9)
        Me.TPAuxiliar.Location = New System.Drawing.Point(4, 25)
        Me.TPAuxiliar.Name = "TPAuxiliar"
        Me.TPAuxiliar.Padding = New System.Windows.Forms.Padding(3)
        Me.TPAuxiliar.Size = New System.Drawing.Size(1096, 542)
        Me.TPAuxiliar.TabIndex = 2
        Me.TPAuxiliar.Text = "Auxiliar"
        Me.TPAuxiliar.UseVisualStyleBackColor = True
        '
        'BtnCopiarAuxiliar
        '
        Me.BtnCopiarAuxiliar.Location = New System.Drawing.Point(800, 110)
        Me.BtnCopiarAuxiliar.Name = "BtnCopiarAuxiliar"
        Me.BtnCopiarAuxiliar.Size = New System.Drawing.Size(125, 35)
        Me.BtnCopiarAuxiliar.TabIndex = 149
        Me.BtnCopiarAuxiliar.Text = "Copiar Selección"
        Me.BtnCopiarAuxiliar.UseVisualStyleBackColor = True
        '
        'DGVAuxiliar
        '
        Me.DGVAuxiliar.AllowUserToAddRows = False
        Me.DGVAuxiliar.AllowUserToDeleteRows = False
        Me.DGVAuxiliar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVAuxiliar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVAuxiliar.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DGVAuxiliar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVAuxiliar.Location = New System.Drawing.Point(5, 165)
        Me.DGVAuxiliar.Name = "DGVAuxiliar"
        Me.DGVAuxiliar.ReadOnly = True
        Me.DGVAuxiliar.RowHeadersVisible = False
        Me.DGVAuxiliar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVAuxiliar.Size = New System.Drawing.Size(1000, 370)
        Me.DGVAuxiliar.TabIndex = 148
        '
        'TSAuxiliar
        '
        Me.TSAuxiliar.BackColor = System.Drawing.Color.Gray
        Me.TSAuxiliar.Dock = System.Windows.Forms.DockStyle.Right
        Me.TSAuxiliar.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSAuxiliar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TSAuxiliar.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.TSAuxiliar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnAgregarAuxiliar, Me.ToolStripSeparator5, Me.tsbtnEditarAuxiliar, Me.ToolStripSeparator4, Me.tsbtnEliminarAuxiliar, Me.ToolStripSeparator1, Me.tsbtnGuardarAuxiliar, Me.ToolStripSeparator2, Me.tsbtnCancelarAuxiliar, Me.ToolStripSeparator3, Me.tsbtnBuscarAuxiliar})
        Me.TSAuxiliar.Location = New System.Drawing.Point(1016, 3)
        Me.TSAuxiliar.Name = "TSAuxiliar"
        Me.TSAuxiliar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TSAuxiliar.Size = New System.Drawing.Size(77, 536)
        Me.TSAuxiliar.TabIndex = 147
        Me.TSAuxiliar.Text = "ToolStrip1"
        '
        'tsbtnAgregarAuxiliar
        '
        Me.tsbtnAgregarAuxiliar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnAgregarAuxiliar.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_add_72
        Me.tsbtnAgregarAuxiliar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnAgregarAuxiliar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnAgregarAuxiliar.Name = "tsbtnAgregarAuxiliar"
        Me.tsbtnAgregarAuxiliar.Size = New System.Drawing.Size(74, 76)
        Me.tsbtnAgregarAuxiliar.Text = "Nuevo"
        Me.tsbtnAgregarAuxiliar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(74, 6)
        '
        'tsbtnEditarAuxiliar
        '
        Me.tsbtnEditarAuxiliar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnEditarAuxiliar.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_edit_72
        Me.tsbtnEditarAuxiliar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnEditarAuxiliar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEditarAuxiliar.Name = "tsbtnEditarAuxiliar"
        Me.tsbtnEditarAuxiliar.Size = New System.Drawing.Size(74, 76)
        Me.tsbtnEditarAuxiliar.Text = "Editar"
        Me.tsbtnEditarAuxiliar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(74, 6)
        '
        'tsbtnEliminarAuxiliar
        '
        Me.tsbtnEliminarAuxiliar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnEliminarAuxiliar.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_delete_72
        Me.tsbtnEliminarAuxiliar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnEliminarAuxiliar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEliminarAuxiliar.Name = "tsbtnEliminarAuxiliar"
        Me.tsbtnEliminarAuxiliar.Size = New System.Drawing.Size(74, 76)
        Me.tsbtnEliminarAuxiliar.Text = "Eliminar"
        Me.tsbtnEliminarAuxiliar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(74, 6)
        '
        'tsbtnGuardarAuxiliar
        '
        Me.tsbtnGuardarAuxiliar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnGuardarAuxiliar.Enabled = False
        Me.tsbtnGuardarAuxiliar.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_save_72
        Me.tsbtnGuardarAuxiliar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnGuardarAuxiliar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnGuardarAuxiliar.Name = "tsbtnGuardarAuxiliar"
        Me.tsbtnGuardarAuxiliar.Size = New System.Drawing.Size(74, 76)
        Me.tsbtnGuardarAuxiliar.Text = "Guardar"
        Me.tsbtnGuardarAuxiliar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(74, 6)
        '
        'tsbtnCancelarAuxiliar
        '
        Me.tsbtnCancelarAuxiliar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnCancelarAuxiliar.Enabled = False
        Me.tsbtnCancelarAuxiliar.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_cancel_72
        Me.tsbtnCancelarAuxiliar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnCancelarAuxiliar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCancelarAuxiliar.Name = "tsbtnCancelarAuxiliar"
        Me.tsbtnCancelarAuxiliar.Size = New System.Drawing.Size(74, 76)
        Me.tsbtnCancelarAuxiliar.Text = "Cancelar"
        Me.tsbtnCancelarAuxiliar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(74, 6)
        '
        'tsbtnBuscarAuxiliar
        '
        Me.tsbtnBuscarAuxiliar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnBuscarAuxiliar.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_find_72
        Me.tsbtnBuscarAuxiliar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnBuscarAuxiliar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnBuscarAuxiliar.Name = "tsbtnBuscarAuxiliar"
        Me.tsbtnBuscarAuxiliar.Size = New System.Drawing.Size(74, 76)
        Me.tsbtnBuscarAuxiliar.Text = "Buscar"
        Me.tsbtnBuscarAuxiliar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.CBSituacionRevistaAuxiliar)
        Me.Panel7.Controls.Add(Me.Label22)
        Me.Panel7.Controls.Add(Me.CBTurnoAuxiliar)
        Me.Panel7.Controls.Add(Me.Label5)
        Me.Panel7.Controls.Add(Me.LblIdEsculaDirectivoA)
        Me.Panel7.Location = New System.Drawing.Point(317, 86)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(375, 70)
        Me.Panel7.TabIndex = 146
        '
        'CBSituacionRevistaAuxiliar
        '
        Me.CBSituacionRevistaAuxiliar.BackColor = System.Drawing.Color.LightGreen
        Me.CBSituacionRevistaAuxiliar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBSituacionRevistaAuxiliar.FormattingEnabled = True
        Me.CBSituacionRevistaAuxiliar.Location = New System.Drawing.Point(190, 35)
        Me.CBSituacionRevistaAuxiliar.Name = "CBSituacionRevistaAuxiliar"
        Me.CBSituacionRevistaAuxiliar.Size = New System.Drawing.Size(175, 25)
        Me.CBSituacionRevistaAuxiliar.TabIndex = 140
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(195, 11)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(129, 17)
        Me.Label22.TabIndex = 139
        Me.Label22.Text = "Situacion de revista"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CBTurnoAuxiliar
        '
        Me.CBTurnoAuxiliar.BackColor = System.Drawing.Color.LightGreen
        Me.CBTurnoAuxiliar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBTurnoAuxiliar.FormattingEnabled = True
        Me.CBTurnoAuxiliar.Location = New System.Drawing.Point(9, 35)
        Me.CBTurnoAuxiliar.Name = "CBTurnoAuxiliar"
        Me.CBTurnoAuxiliar.Size = New System.Drawing.Size(175, 25)
        Me.CBTurnoAuxiliar.TabIndex = 138
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "Turno"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblIdEsculaDirectivoA
        '
        Me.LblIdEsculaDirectivoA.AutoSize = True
        Me.LblIdEsculaDirectivoA.Location = New System.Drawing.Point(24, 39)
        Me.LblIdEsculaDirectivoA.Name = "LblIdEsculaDirectivoA"
        Me.LblIdEsculaDirectivoA.Size = New System.Drawing.Size(15, 16)
        Me.LblIdEsculaDirectivoA.TabIndex = 153
        Me.LblIdEsculaDirectivoA.Text = "0"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Label6)
        Me.Panel8.Controls.Add(Me.Label17)
        Me.Panel8.Controls.Add(Me.TxtCueAuxiliar)
        Me.Panel8.Controls.Add(Me.TxtNombreCueAuxiliar)
        Me.Panel8.Controls.Add(Me.BtnAddCueAuxiliar)
        Me.Panel8.Controls.Add(Me.Label18)
        Me.Panel8.Location = New System.Drawing.Point(505, 10)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(500, 70)
        Me.Panel8.TabIndex = 145
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 17)
        Me.Label6.TabIndex = 137
        Me.Label6.Text = "Escuela"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(201, 21)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 17)
        Me.Label17.TabIndex = 130
        Me.Label17.Text = "Nombre"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCueAuxiliar
        '
        Me.TxtCueAuxiliar.BackColor = System.Drawing.Color.LightGreen
        Me.TxtCueAuxiliar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCueAuxiliar.Location = New System.Drawing.Point(53, 41)
        Me.TxtCueAuxiliar.Name = "TxtCueAuxiliar"
        Me.TxtCueAuxiliar.ReadOnly = True
        Me.TxtCueAuxiliar.Size = New System.Drawing.Size(145, 25)
        Me.TxtCueAuxiliar.TabIndex = 129
        Me.TxtCueAuxiliar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNombreCueAuxiliar
        '
        Me.TxtNombreCueAuxiliar.BackColor = System.Drawing.Color.LightGreen
        Me.TxtNombreCueAuxiliar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreCueAuxiliar.Location = New System.Drawing.Point(204, 41)
        Me.TxtNombreCueAuxiliar.Name = "TxtNombreCueAuxiliar"
        Me.TxtNombreCueAuxiliar.ReadOnly = True
        Me.TxtNombreCueAuxiliar.Size = New System.Drawing.Size(288, 25)
        Me.TxtNombreCueAuxiliar.TabIndex = 128
        Me.TxtNombreCueAuxiliar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnAddCueAuxiliar
        '
        Me.BtnAddCueAuxiliar.Enabled = False
        Me.BtnAddCueAuxiliar.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_find_b2_36
        Me.BtnAddCueAuxiliar.Location = New System.Drawing.Point(9, 25)
        Me.BtnAddCueAuxiliar.Name = "BtnAddCueAuxiliar"
        Me.BtnAddCueAuxiliar.Size = New System.Drawing.Size(40, 40)
        Me.BtnAddCueAuxiliar.TabIndex = 127
        Me.BtnAddCueAuxiliar.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(57, 21)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(31, 17)
        Me.Label18.TabIndex = 126
        Me.Label18.Text = "Cue"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.Label27)
        Me.Panel9.Controls.Add(Me.TxtApellidoAuxiliar)
        Me.Panel9.Controls.Add(Me.Label19)
        Me.Panel9.Controls.Add(Me.Label20)
        Me.Panel9.Controls.Add(Me.TxtDniAuxiliar)
        Me.Panel9.Controls.Add(Me.TxtNombreauxiliar)
        Me.Panel9.Controls.Add(Me.BtnAddAuxiliar)
        Me.Panel9.Controls.Add(Me.Label21)
        Me.Panel9.Location = New System.Drawing.Point(5, 10)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(500, 70)
        Me.Panel9.TabIndex = 144
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(318, 21)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(60, 17)
        Me.Label27.TabIndex = 140
        Me.Label27.Text = "Apellido"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtApellidoAuxiliar
        '
        Me.TxtApellidoAuxiliar.BackColor = System.Drawing.Color.LightGreen
        Me.TxtApellidoAuxiliar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellidoAuxiliar.Location = New System.Drawing.Point(315, 41)
        Me.TxtApellidoAuxiliar.Name = "TxtApellidoAuxiliar"
        Me.TxtApellidoAuxiliar.ReadOnly = True
        Me.TxtApellidoAuxiliar.Size = New System.Drawing.Size(180, 25)
        Me.TxtApellidoAuxiliar.TabIndex = 139
        Me.TxtApellidoAuxiliar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(222, 2)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 17)
        Me.Label19.TabIndex = 136
        Me.Label19.Text = "Auxiliar"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(135, 21)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(58, 17)
        Me.Label20.TabIndex = 135
        Me.Label20.Text = "Nombre"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtDniAuxiliar
        '
        Me.TxtDniAuxiliar.BackColor = System.Drawing.Color.LightGreen
        Me.TxtDniAuxiliar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDniAuxiliar.Location = New System.Drawing.Point(48, 41)
        Me.TxtDniAuxiliar.Name = "TxtDniAuxiliar"
        Me.TxtDniAuxiliar.ReadOnly = True
        Me.TxtDniAuxiliar.Size = New System.Drawing.Size(80, 25)
        Me.TxtDniAuxiliar.TabIndex = 134
        Me.TxtDniAuxiliar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNombreauxiliar
        '
        Me.TxtNombreauxiliar.BackColor = System.Drawing.Color.LightGreen
        Me.TxtNombreauxiliar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreauxiliar.Location = New System.Drawing.Point(132, 41)
        Me.TxtNombreauxiliar.Name = "TxtNombreauxiliar"
        Me.TxtNombreauxiliar.ReadOnly = True
        Me.TxtNombreauxiliar.Size = New System.Drawing.Size(180, 25)
        Me.TxtNombreauxiliar.TabIndex = 133
        Me.TxtNombreauxiliar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnAddAuxiliar
        '
        Me.BtnAddAuxiliar.Enabled = False
        Me.BtnAddAuxiliar.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_find_b2_36
        Me.BtnAddAuxiliar.Location = New System.Drawing.Point(5, 27)
        Me.BtnAddAuxiliar.Name = "BtnAddAuxiliar"
        Me.BtnAddAuxiliar.Size = New System.Drawing.Size(40, 40)
        Me.BtnAddAuxiliar.TabIndex = 132
        Me.BtnAddAuxiliar.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(57, 21)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(32, 17)
        Me.Label21.TabIndex = 131
        Me.Label21.Text = "DNI"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TPSecretario
        '
        Me.TPSecretario.Controls.Add(Me.BtnCopiarSecretario)
        Me.TPSecretario.Controls.Add(Me.DGVSecretario)
        Me.TPSecretario.Controls.Add(Me.TSSecretario)
        Me.TPSecretario.Controls.Add(Me.Panel4)
        Me.TPSecretario.Controls.Add(Me.Panel5)
        Me.TPSecretario.Controls.Add(Me.Panel6)
        Me.TPSecretario.Location = New System.Drawing.Point(4, 25)
        Me.TPSecretario.Name = "TPSecretario"
        Me.TPSecretario.Padding = New System.Windows.Forms.Padding(3)
        Me.TPSecretario.Size = New System.Drawing.Size(1096, 542)
        Me.TPSecretario.TabIndex = 1
        Me.TPSecretario.Text = "Secretario"
        Me.TPSecretario.UseVisualStyleBackColor = True
        '
        'BtnCopiarSecretario
        '
        Me.BtnCopiarSecretario.Location = New System.Drawing.Point(800, 110)
        Me.BtnCopiarSecretario.Name = "BtnCopiarSecretario"
        Me.BtnCopiarSecretario.Size = New System.Drawing.Size(125, 35)
        Me.BtnCopiarSecretario.TabIndex = 150
        Me.BtnCopiarSecretario.Text = "Copiar Selección"
        Me.BtnCopiarSecretario.UseVisualStyleBackColor = True
        '
        'DGVSecretario
        '
        Me.DGVSecretario.AllowUserToAddRows = False
        Me.DGVSecretario.AllowUserToDeleteRows = False
        Me.DGVSecretario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVSecretario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVSecretario.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DGVSecretario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSecretario.Location = New System.Drawing.Point(5, 165)
        Me.DGVSecretario.Name = "DGVSecretario"
        Me.DGVSecretario.ReadOnly = True
        Me.DGVSecretario.RowHeadersVisible = False
        Me.DGVSecretario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVSecretario.Size = New System.Drawing.Size(1000, 370)
        Me.DGVSecretario.TabIndex = 149
        '
        'TSSecretario
        '
        Me.TSSecretario.BackColor = System.Drawing.Color.Gray
        Me.TSSecretario.Dock = System.Windows.Forms.DockStyle.Right
        Me.TSSecretario.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSSecretario.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TSSecretario.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.TSSecretario.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnAgregarSecretario, Me.ToolStripSeparator6, Me.tsbtnEditarSecretario, Me.ToolStripSeparator7, Me.tsbtnEliminarSecretario, Me.ToolStripSeparator8, Me.tsbtnGuardarSecretario, Me.ToolStripSeparator9, Me.tsbtnCancelarSecretario, Me.ToolStripSeparator10, Me.tsbtnBuscarSecretario})
        Me.TSSecretario.Location = New System.Drawing.Point(1016, 3)
        Me.TSSecretario.Name = "TSSecretario"
        Me.TSSecretario.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TSSecretario.Size = New System.Drawing.Size(77, 536)
        Me.TSSecretario.TabIndex = 144
        Me.TSSecretario.Text = "ToolStrip1"
        '
        'tsbtnAgregarSecretario
        '
        Me.tsbtnAgregarSecretario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnAgregarSecretario.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_add_72
        Me.tsbtnAgregarSecretario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnAgregarSecretario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnAgregarSecretario.Name = "tsbtnAgregarSecretario"
        Me.tsbtnAgregarSecretario.Size = New System.Drawing.Size(74, 76)
        Me.tsbtnAgregarSecretario.Text = "Nuevo"
        Me.tsbtnAgregarSecretario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(74, 6)
        '
        'tsbtnEditarSecretario
        '
        Me.tsbtnEditarSecretario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnEditarSecretario.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_edit_72
        Me.tsbtnEditarSecretario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnEditarSecretario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEditarSecretario.Name = "tsbtnEditarSecretario"
        Me.tsbtnEditarSecretario.Size = New System.Drawing.Size(74, 76)
        Me.tsbtnEditarSecretario.Text = "Editar"
        Me.tsbtnEditarSecretario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(74, 6)
        '
        'tsbtnEliminarSecretario
        '
        Me.tsbtnEliminarSecretario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnEliminarSecretario.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_delete_72
        Me.tsbtnEliminarSecretario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnEliminarSecretario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEliminarSecretario.Name = "tsbtnEliminarSecretario"
        Me.tsbtnEliminarSecretario.Size = New System.Drawing.Size(74, 76)
        Me.tsbtnEliminarSecretario.Text = "Eliminar"
        Me.tsbtnEliminarSecretario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(74, 6)
        '
        'tsbtnGuardarSecretario
        '
        Me.tsbtnGuardarSecretario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnGuardarSecretario.Enabled = False
        Me.tsbtnGuardarSecretario.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_save_72
        Me.tsbtnGuardarSecretario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnGuardarSecretario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnGuardarSecretario.Name = "tsbtnGuardarSecretario"
        Me.tsbtnGuardarSecretario.Size = New System.Drawing.Size(74, 76)
        Me.tsbtnGuardarSecretario.Text = "Guardar"
        Me.tsbtnGuardarSecretario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(74, 6)
        '
        'tsbtnCancelarSecretario
        '
        Me.tsbtnCancelarSecretario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnCancelarSecretario.Enabled = False
        Me.tsbtnCancelarSecretario.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_cancel_72
        Me.tsbtnCancelarSecretario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnCancelarSecretario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCancelarSecretario.Name = "tsbtnCancelarSecretario"
        Me.tsbtnCancelarSecretario.Size = New System.Drawing.Size(74, 76)
        Me.tsbtnCancelarSecretario.Text = "Cancelar"
        Me.tsbtnCancelarSecretario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(74, 6)
        '
        'tsbtnBuscarSecretario
        '
        Me.tsbtnBuscarSecretario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnBuscarSecretario.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_find_72
        Me.tsbtnBuscarSecretario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnBuscarSecretario.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnBuscarSecretario.Name = "tsbtnBuscarSecretario"
        Me.tsbtnBuscarSecretario.Size = New System.Drawing.Size(74, 76)
        Me.tsbtnBuscarSecretario.Text = "Buscar"
        Me.tsbtnBuscarSecretario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.CBSituacionRevistaSecretario)
        Me.Panel4.Controls.Add(Me.Label23)
        Me.Panel4.Controls.Add(Me.CBTurnoSecretario)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.LblIdEsculaDirectivoS)
        Me.Panel4.Location = New System.Drawing.Point(317, 86)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(375, 70)
        Me.Panel4.TabIndex = 143
        '
        'CBSituacionRevistaSecretario
        '
        Me.CBSituacionRevistaSecretario.BackColor = System.Drawing.Color.LightGreen
        Me.CBSituacionRevistaSecretario.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBSituacionRevistaSecretario.FormattingEnabled = True
        Me.CBSituacionRevistaSecretario.Location = New System.Drawing.Point(190, 35)
        Me.CBSituacionRevistaSecretario.Name = "CBSituacionRevistaSecretario"
        Me.CBSituacionRevistaSecretario.Size = New System.Drawing.Size(175, 25)
        Me.CBSituacionRevistaSecretario.TabIndex = 142
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(195, 11)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(129, 17)
        Me.Label23.TabIndex = 141
        Me.Label23.Text = "Situacion de revista"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CBTurnoSecretario
        '
        Me.CBTurnoSecretario.BackColor = System.Drawing.Color.LightGreen
        Me.CBTurnoSecretario.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBTurnoSecretario.FormattingEnabled = True
        Me.CBTurnoSecretario.Location = New System.Drawing.Point(9, 35)
        Me.CBTurnoSecretario.Name = "CBTurnoSecretario"
        Me.CBTurnoSecretario.Size = New System.Drawing.Size(175, 25)
        Me.CBTurnoSecretario.TabIndex = 138
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 17)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "Turno"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblIdEsculaDirectivoS
        '
        Me.LblIdEsculaDirectivoS.AutoSize = True
        Me.LblIdEsculaDirectivoS.Location = New System.Drawing.Point(23, 39)
        Me.LblIdEsculaDirectivoS.Name = "LblIdEsculaDirectivoS"
        Me.LblIdEsculaDirectivoS.Size = New System.Drawing.Size(15, 16)
        Me.LblIdEsculaDirectivoS.TabIndex = 152
        Me.LblIdEsculaDirectivoS.Text = "0"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Label12)
        Me.Panel5.Controls.Add(Me.TxtCueSecretario)
        Me.Panel5.Controls.Add(Me.TxtNombreCueSecretario)
        Me.Panel5.Controls.Add(Me.BtnAddCueSecretario)
        Me.Panel5.Controls.Add(Me.Label13)
        Me.Panel5.Location = New System.Drawing.Point(505, 10)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(500, 70)
        Me.Panel5.TabIndex = 142
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 137
        Me.Label3.Text = "Escuela"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(201, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 17)
        Me.Label12.TabIndex = 130
        Me.Label12.Text = "Nombre"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCueSecretario
        '
        Me.TxtCueSecretario.BackColor = System.Drawing.Color.LightGreen
        Me.TxtCueSecretario.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCueSecretario.Location = New System.Drawing.Point(53, 41)
        Me.TxtCueSecretario.Name = "TxtCueSecretario"
        Me.TxtCueSecretario.ReadOnly = True
        Me.TxtCueSecretario.Size = New System.Drawing.Size(145, 25)
        Me.TxtCueSecretario.TabIndex = 129
        Me.TxtCueSecretario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNombreCueSecretario
        '
        Me.TxtNombreCueSecretario.BackColor = System.Drawing.Color.LightGreen
        Me.TxtNombreCueSecretario.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreCueSecretario.Location = New System.Drawing.Point(204, 41)
        Me.TxtNombreCueSecretario.Name = "TxtNombreCueSecretario"
        Me.TxtNombreCueSecretario.ReadOnly = True
        Me.TxtNombreCueSecretario.Size = New System.Drawing.Size(288, 25)
        Me.TxtNombreCueSecretario.TabIndex = 128
        Me.TxtNombreCueSecretario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnAddCueSecretario
        '
        Me.BtnAddCueSecretario.Enabled = False
        Me.BtnAddCueSecretario.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_find_b2_36
        Me.BtnAddCueSecretario.Location = New System.Drawing.Point(9, 25)
        Me.BtnAddCueSecretario.Name = "BtnAddCueSecretario"
        Me.BtnAddCueSecretario.Size = New System.Drawing.Size(40, 40)
        Me.BtnAddCueSecretario.TabIndex = 127
        Me.BtnAddCueSecretario.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(57, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 17)
        Me.Label13.TabIndex = 126
        Me.Label13.Text = "Cue"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label26)
        Me.Panel6.Controls.Add(Me.TxtApellidoSecretario)
        Me.Panel6.Controls.Add(Me.Label14)
        Me.Panel6.Controls.Add(Me.Label15)
        Me.Panel6.Controls.Add(Me.TxtDniSecretario)
        Me.Panel6.Controls.Add(Me.TxtNombreSecretario)
        Me.Panel6.Controls.Add(Me.BtnAddSecretario)
        Me.Panel6.Controls.Add(Me.Label16)
        Me.Panel6.Location = New System.Drawing.Point(5, 10)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(500, 70)
        Me.Panel6.TabIndex = 141
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(318, 21)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(60, 17)
        Me.Label26.TabIndex = 140
        Me.Label26.Text = "Apellido"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtApellidoSecretario
        '
        Me.TxtApellidoSecretario.BackColor = System.Drawing.Color.LightGreen
        Me.TxtApellidoSecretario.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellidoSecretario.Location = New System.Drawing.Point(315, 41)
        Me.TxtApellidoSecretario.Name = "TxtApellidoSecretario"
        Me.TxtApellidoSecretario.ReadOnly = True
        Me.TxtApellidoSecretario.Size = New System.Drawing.Size(180, 25)
        Me.TxtApellidoSecretario.TabIndex = 139
        Me.TxtApellidoSecretario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(216, 2)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 17)
        Me.Label14.TabIndex = 136
        Me.Label14.Text = "Secretario"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(135, 21)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 17)
        Me.Label15.TabIndex = 135
        Me.Label15.Text = "Nombre"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtDniSecretario
        '
        Me.TxtDniSecretario.BackColor = System.Drawing.Color.LightGreen
        Me.TxtDniSecretario.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDniSecretario.Location = New System.Drawing.Point(48, 41)
        Me.TxtDniSecretario.Name = "TxtDniSecretario"
        Me.TxtDniSecretario.ReadOnly = True
        Me.TxtDniSecretario.Size = New System.Drawing.Size(80, 25)
        Me.TxtDniSecretario.TabIndex = 134
        Me.TxtDniSecretario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNombreSecretario
        '
        Me.TxtNombreSecretario.BackColor = System.Drawing.Color.LightGreen
        Me.TxtNombreSecretario.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreSecretario.Location = New System.Drawing.Point(132, 41)
        Me.TxtNombreSecretario.Name = "TxtNombreSecretario"
        Me.TxtNombreSecretario.ReadOnly = True
        Me.TxtNombreSecretario.Size = New System.Drawing.Size(180, 25)
        Me.TxtNombreSecretario.TabIndex = 133
        Me.TxtNombreSecretario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnAddSecretario
        '
        Me.BtnAddSecretario.Enabled = False
        Me.BtnAddSecretario.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_find_b2_36
        Me.BtnAddSecretario.Location = New System.Drawing.Point(5, 27)
        Me.BtnAddSecretario.Name = "BtnAddSecretario"
        Me.BtnAddSecretario.Size = New System.Drawing.Size(40, 40)
        Me.BtnAddSecretario.TabIndex = 132
        Me.BtnAddSecretario.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(57, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 17)
        Me.Label16.TabIndex = 131
        Me.Label16.Text = "DNI"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TPDirector
        '
        Me.TPDirector.Controls.Add(Me.BtnCopiarDirector)
        Me.TPDirector.Controls.Add(Me.DGVDirector)
        Me.TPDirector.Controls.Add(Me.TSDirector)
        Me.TPDirector.Controls.Add(Me.Panel3)
        Me.TPDirector.Controls.Add(Me.Panel2)
        Me.TPDirector.Controls.Add(Me.Panel1)
        Me.TPDirector.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TPDirector.Location = New System.Drawing.Point(4, 25)
        Me.TPDirector.Name = "TPDirector"
        Me.TPDirector.Padding = New System.Windows.Forms.Padding(3)
        Me.TPDirector.Size = New System.Drawing.Size(1096, 542)
        Me.TPDirector.TabIndex = 0
        Me.TPDirector.Text = "Director"
        Me.TPDirector.UseVisualStyleBackColor = True
        '
        'BtnCopiarDirector
        '
        Me.BtnCopiarDirector.Location = New System.Drawing.Point(800, 110)
        Me.BtnCopiarDirector.Name = "BtnCopiarDirector"
        Me.BtnCopiarDirector.Size = New System.Drawing.Size(125, 35)
        Me.BtnCopiarDirector.TabIndex = 150
        Me.BtnCopiarDirector.Text = "Copiar Selección"
        Me.BtnCopiarDirector.UseVisualStyleBackColor = True
        '
        'DGVDirector
        '
        Me.DGVDirector.AllowUserToAddRows = False
        Me.DGVDirector.AllowUserToDeleteRows = False
        Me.DGVDirector.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVDirector.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVDirector.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DGVDirector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVDirector.Location = New System.Drawing.Point(5, 165)
        Me.DGVDirector.Name = "DGVDirector"
        Me.DGVDirector.ReadOnly = True
        Me.DGVDirector.RowHeadersVisible = False
        Me.DGVDirector.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVDirector.Size = New System.Drawing.Size(1000, 370)
        Me.DGVDirector.TabIndex = 149
        '
        'TSDirector
        '
        Me.TSDirector.BackColor = System.Drawing.Color.Gray
        Me.TSDirector.Dock = System.Windows.Forms.DockStyle.Right
        Me.TSDirector.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSDirector.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TSDirector.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.TSDirector.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnAgregarDirector, Me.ToolStripSeparator11, Me.tsbtnEditarDirector, Me.ToolStripSeparator12, Me.tsbtnEliminarDirector, Me.ToolStripSeparator13, Me.tsbtnGuardarDirector, Me.ToolStripSeparator14, Me.tsbtnCancelarDirector, Me.ToolStripSeparator15, Me.tsbtnBuscarDirector})
        Me.TSDirector.Location = New System.Drawing.Point(1016, 3)
        Me.TSDirector.Name = "TSDirector"
        Me.TSDirector.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TSDirector.Size = New System.Drawing.Size(77, 536)
        Me.TSDirector.TabIndex = 141
        Me.TSDirector.Text = "ToolStrip1"
        '
        'tsbtnAgregarDirector
        '
        Me.tsbtnAgregarDirector.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnAgregarDirector.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_add_72
        Me.tsbtnAgregarDirector.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnAgregarDirector.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnAgregarDirector.Name = "tsbtnAgregarDirector"
        Me.tsbtnAgregarDirector.Size = New System.Drawing.Size(74, 76)
        Me.tsbtnAgregarDirector.Text = "Nuevo"
        Me.tsbtnAgregarDirector.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(74, 6)
        '
        'tsbtnEditarDirector
        '
        Me.tsbtnEditarDirector.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnEditarDirector.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_edit_72
        Me.tsbtnEditarDirector.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnEditarDirector.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEditarDirector.Name = "tsbtnEditarDirector"
        Me.tsbtnEditarDirector.Size = New System.Drawing.Size(74, 76)
        Me.tsbtnEditarDirector.Text = "Editar"
        Me.tsbtnEditarDirector.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(74, 6)
        '
        'tsbtnEliminarDirector
        '
        Me.tsbtnEliminarDirector.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnEliminarDirector.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_delete_72
        Me.tsbtnEliminarDirector.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnEliminarDirector.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnEliminarDirector.Name = "tsbtnEliminarDirector"
        Me.tsbtnEliminarDirector.Size = New System.Drawing.Size(74, 76)
        Me.tsbtnEliminarDirector.Text = "Eliminar"
        Me.tsbtnEliminarDirector.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(74, 6)
        '
        'tsbtnGuardarDirector
        '
        Me.tsbtnGuardarDirector.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnGuardarDirector.Enabled = False
        Me.tsbtnGuardarDirector.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_save_72
        Me.tsbtnGuardarDirector.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnGuardarDirector.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnGuardarDirector.Name = "tsbtnGuardarDirector"
        Me.tsbtnGuardarDirector.Size = New System.Drawing.Size(74, 76)
        Me.tsbtnGuardarDirector.Text = "Guardar"
        Me.tsbtnGuardarDirector.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(74, 6)
        '
        'tsbtnCancelarDirector
        '
        Me.tsbtnCancelarDirector.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnCancelarDirector.Enabled = False
        Me.tsbtnCancelarDirector.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_cancel_72
        Me.tsbtnCancelarDirector.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnCancelarDirector.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCancelarDirector.Name = "tsbtnCancelarDirector"
        Me.tsbtnCancelarDirector.Size = New System.Drawing.Size(74, 76)
        Me.tsbtnCancelarDirector.Text = "Cancelar"
        Me.tsbtnCancelarDirector.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(74, 6)
        '
        'tsbtnBuscarDirector
        '
        Me.tsbtnBuscarDirector.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnBuscarDirector.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_find_72
        Me.tsbtnBuscarDirector.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbtnBuscarDirector.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnBuscarDirector.Name = "tsbtnBuscarDirector"
        Me.tsbtnBuscarDirector.Size = New System.Drawing.Size(74, 76)
        Me.tsbtnBuscarDirector.Text = "Buscar"
        Me.tsbtnBuscarDirector.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.CBSituacionRevistaDirector)
        Me.Panel3.Controls.Add(Me.Label24)
        Me.Panel3.Controls.Add(Me.CBTurnoDirector)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.LblIdEsculaDirectivoD)
        Me.Panel3.Location = New System.Drawing.Point(317, 86)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(375, 70)
        Me.Panel3.TabIndex = 140
        '
        'CBSituacionRevistaDirector
        '
        Me.CBSituacionRevistaDirector.BackColor = System.Drawing.Color.LightGreen
        Me.CBSituacionRevistaDirector.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBSituacionRevistaDirector.FormattingEnabled = True
        Me.CBSituacionRevistaDirector.Location = New System.Drawing.Point(190, 35)
        Me.CBSituacionRevistaDirector.Name = "CBSituacionRevistaDirector"
        Me.CBSituacionRevistaDirector.Size = New System.Drawing.Size(175, 25)
        Me.CBSituacionRevistaDirector.TabIndex = 144
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(195, 11)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(129, 17)
        Me.Label24.TabIndex = 143
        Me.Label24.Text = "Situacion de revista"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CBTurnoDirector
        '
        Me.CBTurnoDirector.BackColor = System.Drawing.Color.LightGreen
        Me.CBTurnoDirector.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBTurnoDirector.FormattingEnabled = True
        Me.CBTurnoDirector.Location = New System.Drawing.Point(9, 35)
        Me.CBTurnoDirector.Name = "CBTurnoDirector"
        Me.CBTurnoDirector.Size = New System.Drawing.Size(175, 25)
        Me.CBTurnoDirector.TabIndex = 138
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 17)
        Me.Label11.TabIndex = 137
        Me.Label11.Text = "Turno"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblIdEsculaDirectivoD
        '
        Me.LblIdEsculaDirectivoD.AutoSize = True
        Me.LblIdEsculaDirectivoD.Location = New System.Drawing.Point(13, 39)
        Me.LblIdEsculaDirectivoD.Name = "LblIdEsculaDirectivoD"
        Me.LblIdEsculaDirectivoD.Size = New System.Drawing.Size(15, 16)
        Me.LblIdEsculaDirectivoD.TabIndex = 151
        Me.LblIdEsculaDirectivoD.Text = "0"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TxtCueDirector)
        Me.Panel2.Controls.Add(Me.TxtNombreCueDirector)
        Me.Panel2.Controls.Add(Me.BtnAddCueDirector)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(505, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(500, 70)
        Me.Panel2.TabIndex = 139
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(13, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 17)
        Me.Label10.TabIndex = 137
        Me.Label10.Text = "Escuela"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(201, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "Nombre"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtCueDirector
        '
        Me.TxtCueDirector.BackColor = System.Drawing.Color.LightGreen
        Me.TxtCueDirector.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCueDirector.Location = New System.Drawing.Point(53, 41)
        Me.TxtCueDirector.Name = "TxtCueDirector"
        Me.TxtCueDirector.ReadOnly = True
        Me.TxtCueDirector.Size = New System.Drawing.Size(145, 25)
        Me.TxtCueDirector.TabIndex = 129
        Me.TxtCueDirector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNombreCueDirector
        '
        Me.TxtNombreCueDirector.BackColor = System.Drawing.Color.LightGreen
        Me.TxtNombreCueDirector.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreCueDirector.Location = New System.Drawing.Point(204, 41)
        Me.TxtNombreCueDirector.Name = "TxtNombreCueDirector"
        Me.TxtNombreCueDirector.ReadOnly = True
        Me.TxtNombreCueDirector.Size = New System.Drawing.Size(288, 25)
        Me.TxtNombreCueDirector.TabIndex = 128
        Me.TxtNombreCueDirector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnAddCueDirector
        '
        Me.BtnAddCueDirector.Enabled = False
        Me.BtnAddCueDirector.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_find_b2_36
        Me.BtnAddCueDirector.Location = New System.Drawing.Point(9, 25)
        Me.BtnAddCueDirector.Name = "BtnAddCueDirector"
        Me.BtnAddCueDirector.Size = New System.Drawing.Size(40, 40)
        Me.BtnAddCueDirector.TabIndex = 127
        Me.BtnAddCueDirector.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(57, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 17)
        Me.Label4.TabIndex = 126
        Me.Label4.Text = "Cue"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label25)
        Me.Panel1.Controls.Add(Me.TxtApellidoDirector)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TxtDniDirector)
        Me.Panel1.Controls.Add(Me.TxtNombreDirector)
        Me.Panel1.Controls.Add(Me.BtnAddDirector)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(5, 10)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 70)
        Me.Panel1.TabIndex = 138
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(318, 21)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(60, 17)
        Me.Label25.TabIndex = 138
        Me.Label25.Text = "Apellido"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtApellidoDirector
        '
        Me.TxtApellidoDirector.BackColor = System.Drawing.Color.LightGreen
        Me.TxtApellidoDirector.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtApellidoDirector.Location = New System.Drawing.Point(315, 41)
        Me.TxtApellidoDirector.Name = "TxtApellidoDirector"
        Me.TxtApellidoDirector.ReadOnly = True
        Me.TxtApellidoDirector.Size = New System.Drawing.Size(180, 25)
        Me.TxtApellidoDirector.TabIndex = 137
        Me.TxtApellidoDirector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(221, 2)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 17)
        Me.Label9.TabIndex = 136
        Me.Label9.Text = "Director"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(135, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 17)
        Me.Label7.TabIndex = 135
        Me.Label7.Text = "Nombre"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtDniDirector
        '
        Me.TxtDniDirector.BackColor = System.Drawing.Color.LightGreen
        Me.TxtDniDirector.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDniDirector.Location = New System.Drawing.Point(48, 41)
        Me.TxtDniDirector.Name = "TxtDniDirector"
        Me.TxtDniDirector.ReadOnly = True
        Me.TxtDniDirector.Size = New System.Drawing.Size(80, 25)
        Me.TxtDniDirector.TabIndex = 134
        Me.TxtDniDirector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNombreDirector
        '
        Me.TxtNombreDirector.BackColor = System.Drawing.Color.LightGreen
        Me.TxtNombreDirector.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombreDirector.Location = New System.Drawing.Point(132, 41)
        Me.TxtNombreDirector.Name = "TxtNombreDirector"
        Me.TxtNombreDirector.ReadOnly = True
        Me.TxtNombreDirector.Size = New System.Drawing.Size(180, 25)
        Me.TxtNombreDirector.TabIndex = 133
        Me.TxtNombreDirector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnAddDirector
        '
        Me.BtnAddDirector.Enabled = False
        Me.BtnAddDirector.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_find_b2_36
        Me.BtnAddDirector.Location = New System.Drawing.Point(5, 27)
        Me.BtnAddDirector.Name = "BtnAddDirector"
        Me.BtnAddDirector.Size = New System.Drawing.Size(40, 40)
        Me.BtnAddDirector.TabIndex = 132
        Me.BtnAddDirector.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(57, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 17)
        Me.Label8.TabIndex = 131
        Me.Label8.Text = "DNI"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabCargaTareas
        '
        Me.TabCargaTareas.Controls.Add(Me.TPDirector)
        Me.TabCargaTareas.Controls.Add(Me.TPSecretario)
        Me.TabCargaTareas.Controls.Add(Me.TPAuxiliar)
        Me.TabCargaTareas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabCargaTareas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabCargaTareas.Location = New System.Drawing.Point(0, 0)
        Me.TabCargaTareas.Name = "TabCargaTareas"
        Me.TabCargaTareas.SelectedIndex = 0
        Me.TabCargaTareas.Size = New System.Drawing.Size(1104, 571)
        Me.TabCargaTareas.TabIndex = 53
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_refresh_48
        Me.BtnRefresh.Location = New System.Drawing.Point(524, 523)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(48, 48)
        Me.BtnRefresh.TabIndex = 37
        Me.BtnRefresh.UseVisualStyleBackColor = True
        '
        'FrmCargaCargos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1104, 571)
        Me.Controls.Add(Me.TabCargaTareas)
        Me.Controls.Add(Me.BrnAgregaArticulo)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.BtnSeleccionar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCargaCargos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga de Cargos"
        Me.TPAuxiliar.ResumeLayout(False)
        Me.TPAuxiliar.PerformLayout()
        CType(Me.DGVAuxiliar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TSAuxiliar.ResumeLayout(False)
        Me.TSAuxiliar.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.TPSecretario.ResumeLayout(False)
        Me.TPSecretario.PerformLayout()
        CType(Me.DGVSecretario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TSSecretario.ResumeLayout(False)
        Me.TSSecretario.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.TPDirector.ResumeLayout(False)
        Me.TPDirector.PerformLayout()
        CType(Me.DGVDirector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TSDirector.ResumeLayout(False)
        Me.TSDirector.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabCargaTareas.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BtnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents BtnRefresh As System.Windows.Forms.Button
    Friend WithEvents BrnAgregaArticulo As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TPAuxiliar As System.Windows.Forms.TabPage
    Friend WithEvents TPSecretario As System.Windows.Forms.TabPage
    Friend WithEvents TPDirector As System.Windows.Forms.TabPage
    Friend WithEvents TabCargaTareas As System.Windows.Forms.TabControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtCueDirector As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombreCueDirector As System.Windows.Forms.TextBox
    Friend WithEvents BtnAddCueDirector As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtDniDirector As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombreDirector As System.Windows.Forms.TextBox
    Friend WithEvents BtnAddDirector As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents CBSituacionRevistaAuxiliar As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents CBTurnoAuxiliar As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtCueAuxiliar As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombreCueAuxiliar As System.Windows.Forms.TextBox
    Friend WithEvents BtnAddCueAuxiliar As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Panel9 As System.Windows.Forms.Panel
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents TxtDniAuxiliar As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombreauxiliar As System.Windows.Forms.TextBox
    Friend WithEvents BtnAddAuxiliar As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents CBTurnoSecretario As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtCueSecretario As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombreCueSecretario As System.Windows.Forms.TextBox
    Friend WithEvents BtnAddCueSecretario As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtDniSecretario As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombreSecretario As System.Windows.Forms.TextBox
    Friend WithEvents BtnAddSecretario As System.Windows.Forms.Button
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CBTurnoDirector As System.Windows.Forms.ComboBox
    Friend WithEvents TSAuxiliar As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnAgregarAuxiliar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnEditarAuxiliar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnEliminarAuxiliar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnGuardarAuxiliar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnCancelarAuxiliar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnBuscarAuxiliar As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSSecretario As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnAgregarSecretario As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnEditarSecretario As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnEliminarSecretario As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnGuardarSecretario As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnCancelarSecretario As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnBuscarSecretario As System.Windows.Forms.ToolStripButton
    Friend WithEvents TSDirector As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbtnAgregarDirector As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnEditarDirector As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnEliminarDirector As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnGuardarDirector As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnCancelarDirector As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator15 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbtnBuscarDirector As System.Windows.Forms.ToolStripButton
    Friend WithEvents DGVAuxiliar As System.Windows.Forms.DataGridView
    Friend WithEvents DGVSecretario As System.Windows.Forms.DataGridView
    Friend WithEvents DGVDirector As System.Windows.Forms.DataGridView
    Friend WithEvents CBSituacionRevistaSecretario As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents CBSituacionRevistaDirector As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents BtnCopiarAuxiliar As System.Windows.Forms.Button
    Friend WithEvents BtnCopiarSecretario As System.Windows.Forms.Button
    Friend WithEvents BtnCopiarDirector As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents TxtApellidoDirector As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents TxtApellidoAuxiliar As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents TxtApellidoSecretario As System.Windows.Forms.TextBox
    Friend WithEvents LblIdEsculaDirectivoD As System.Windows.Forms.Label
    Friend WithEvents LblIdEsculaDirectivoS As System.Windows.Forms.Label
    Friend WithEvents LblIdEsculaDirectivoA As System.Windows.Forms.Label
End Class
