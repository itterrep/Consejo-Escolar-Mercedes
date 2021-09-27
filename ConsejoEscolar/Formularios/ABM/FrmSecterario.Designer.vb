<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSecretario
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
        Me.DGVSecretario = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCuit = New System.Windows.Forms.TextBox()
        Me.TxtTelFijo = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.BtnCopiar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtTelCelular = New System.Windows.Forms.TextBox()
        Me.TxtDNI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TSClientes.SuspendLayout()
        CType(Me.DGVSecretario, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TSClientes.Location = New System.Drawing.Point(567, 0)
        Me.TSClientes.Name = "TSClientes"
        Me.TSClientes.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.TSClientes.Size = New System.Drawing.Size(77, 517)
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
        Me.Label6.Location = New System.Drawing.Point(299, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Correo @"
        '
        'TxtEmail
        '
        Me.TxtEmail.BackColor = System.Drawing.Color.LightGreen
        Me.TxtEmail.Location = New System.Drawing.Point(302, 100)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.ReadOnly = True
        Me.TxtEmail.Size = New System.Drawing.Size(250, 20)
        Me.TxtEmail.TabIndex = 10
        '
        'DGVSecretario
        '
        Me.DGVSecretario.AllowUserToAddRows = False
        Me.DGVSecretario.AllowUserToDeleteRows = False
        Me.DGVSecretario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVSecretario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVSecretario.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DGVSecretario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSecretario.Location = New System.Drawing.Point(13, 167)
        Me.DGVSecretario.Name = "DGVSecretario"
        Me.DGVSecretario.ReadOnly = True
        Me.DGVSecretario.RowHeadersVisible = False
        Me.DGVSecretario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVSecretario.Size = New System.Drawing.Size(541, 338)
        Me.DGVSecretario.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "CUIT /CUIL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Telefono Fijo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(277, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Nombre"
        '
        'TxtCuit
        '
        Me.TxtCuit.BackColor = System.Drawing.Color.LightGreen
        Me.TxtCuit.Location = New System.Drawing.Point(13, 139)
        Me.TxtCuit.MaxLength = 13
        Me.TxtCuit.Name = "TxtCuit"
        Me.TxtCuit.ReadOnly = True
        Me.TxtCuit.Size = New System.Drawing.Size(264, 20)
        Me.TxtCuit.TabIndex = 11
        '
        'TxtTelFijo
        '
        Me.TxtTelFijo.BackColor = System.Drawing.Color.LightGreen
        Me.TxtTelFijo.Location = New System.Drawing.Point(13, 100)
        Me.TxtTelFijo.Name = "TxtTelFijo"
        Me.TxtTelFijo.ReadOnly = True
        Me.TxtTelFijo.Size = New System.Drawing.Size(140, 20)
        Me.TxtTelFijo.TabIndex = 8
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.Color.LightGreen
        Me.TxtNombre.Location = New System.Drawing.Point(280, 59)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.ReadOnly = True
        Me.TxtNombre.Size = New System.Drawing.Size(273, 20)
        Me.TxtNombre.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(47, 13)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Apellido "
        '
        'TxtApellido
        '
        Me.TxtApellido.BackColor = System.Drawing.Color.LightGreen
        Me.TxtApellido.Location = New System.Drawing.Point(13, 59)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.ReadOnly = True
        Me.TxtApellido.Size = New System.Drawing.Size(264, 20)
        Me.TxtApellido.TabIndex = 1
        '
        'BtnCopiar
        '
        Me.BtnCopiar.Location = New System.Drawing.Point(427, 126)
        Me.BtnCopiar.Name = "BtnCopiar"
        Me.BtnCopiar.Size = New System.Drawing.Size(125, 35)
        Me.BtnCopiar.TabIndex = 10
        Me.BtnCopiar.Text = "Copiar Selección"
        Me.BtnCopiar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(143, 5)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(350, 24)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Altas, bajas y modificación del Secretario"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(165, 84)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 13)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Telefono Celular"
        '
        'TxtTelCelular
        '
        Me.TxtTelCelular.BackColor = System.Drawing.Color.LightGreen
        Me.TxtTelCelular.Location = New System.Drawing.Point(157, 100)
        Me.TxtTelCelular.Name = "TxtTelCelular"
        Me.TxtTelCelular.ReadOnly = True
        Me.TxtTelCelular.Size = New System.Drawing.Size(140, 20)
        Me.TxtTelCelular.TabIndex = 9
        '
        'TxtDNI
        '
        Me.TxtDNI.BackColor = System.Drawing.Color.LightGreen
        Me.TxtDNI.Location = New System.Drawing.Point(282, 139)
        Me.TxtDNI.MaxLength = 13
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.ReadOnly = True
        Me.TxtDNI.Size = New System.Drawing.Size(139, 20)
        Me.TxtDNI.TabIndex = 50
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(285, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "DNI"
        '
        'FrmSecretario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(644, 517)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtDNI)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtTelCelular)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BtnCopiar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.DGVSecretario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtCuit)
        Me.Controls.Add(Me.TxtTelFijo)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TSClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSecretario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM-Secretario"
        Me.TSClientes.ResumeLayout(False)
        Me.TSClientes.PerformLayout()
        CType(Me.DGVSecretario, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DGVSecretario As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtCuit As System.Windows.Forms.TextBox
    Friend WithEvents TxtTelFijo As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtApellido As System.Windows.Forms.TextBox
    Friend WithEvents BtnCopiar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtTelCelular As System.Windows.Forms.TextBox
    Friend WithEvents TxtDNI As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
