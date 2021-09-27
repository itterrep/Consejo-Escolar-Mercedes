<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAnulaFactura
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DGVfacturas = New System.Windows.Forms.DataGridView()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtProveedor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNumeroPedido = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.BtnAnularFactura = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        CType(Me.DGVfacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DGVfacturas
        '
        Me.DGVfacturas.AllowUserToAddRows = False
        Me.DGVfacturas.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGVfacturas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVfacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVfacturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVfacturas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DGVfacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVfacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.Column2, Me.Column3, Me.Column4, Me.Importe})
        Me.DGVfacturas.Location = New System.Drawing.Point(3, 96)
        Me.DGVfacturas.Name = "DGVfacturas"
        Me.DGVfacturas.ReadOnly = True
        Me.DGVfacturas.RowHeadersVisible = False
        Me.DGVfacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVfacturas.Size = New System.Drawing.Size(716, 377)
        Me.DGVfacturas.TabIndex = 78
        '
        'Cantidad
        '
        Me.Cantidad.DataPropertyName = "Cantidad"
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Codigo"
        Me.Column2.HeaderText = "Codigo"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Detalle"
        Me.Column3.HeaderText = "Detalle"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "PrecioUnitario"
        Me.Column4.HeaderText = "P/Unit."
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Importe
        '
        Me.Importe.DataPropertyName = "Importe"
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        '
        'TxtProveedor
        '
        Me.TxtProveedor.Location = New System.Drawing.Point(19, 70)
        Me.TxtProveedor.MaxLength = 13
        Me.TxtProveedor.Name = "TxtProveedor"
        Me.TxtProveedor.Size = New System.Drawing.Size(250, 20)
        Me.TxtProveedor.TabIndex = 115
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(639, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 17)
        Me.Label6.TabIndex = 117
        Me.Label6.Text = "Fecha"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(615, 70)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(95, 20)
        Me.DateTimePicker1.TabIndex = 116
        Me.DateTimePicker1.Value = New Date(2013, 4, 28, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(363, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 16)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "Venta n°:"
        '
        'lblNumeroPedido
        '
        Me.lblNumeroPedido.AutoSize = True
        Me.lblNumeroPedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroPedido.Location = New System.Drawing.Point(438, 70)
        Me.lblNumeroPedido.Name = "lblNumeroPedido"
        Me.lblNumeroPedido.Size = New System.Drawing.Size(25, 16)
        Me.lblNumeroPedido.TabIndex = 119
        Me.lblNumeroPedido.Text = " n°"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 16)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "Proveedor:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(482, 489)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 29)
        Me.Label16.TabIndex = 122
        Me.Label16.Text = "Total: $"
        '
        'TxtTotal
        '
        Me.TxtTotal.Enabled = False
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(581, 486)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(138, 35)
        Me.TxtTotal.TabIndex = 121
        Me.TxtTotal.Text = "0"
        '
        'BtnAnularFactura
        '
        Me.BtnAnularFactura.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnAnularFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnularFactura.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_delete_36
        Me.BtnAnularFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAnularFactura.Location = New System.Drawing.Point(213, 479)
        Me.BtnAnularFactura.Name = "BtnAnularFactura"
        Me.BtnAnularFactura.Size = New System.Drawing.Size(255, 48)
        Me.BtnAnularFactura.TabIndex = 124
        Me.BtnAnularFactura.Text = "Anular Factura"
        Me.BtnAnularFactura.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Red
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(716, 42)
        Me.Panel1.TabIndex = 125
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(189, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(338, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ATENCION ANULAR FACTURA"
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_cancel_36
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(3, 479)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(172, 48)
        Me.BtnSalir.TabIndex = 126
        Me.BtnSalir.Text = "Cancelar"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'FrmAnulaFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 539)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnAnularFactura)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNumeroPedido)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TxtProveedor)
        Me.Controls.Add(Me.DGVfacturas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmAnulaFactura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Formulario para Anular una Factura"
        CType(Me.DGVfacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVfacturas As DataGridView
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Importe As DataGridViewTextBoxColumn
    Friend WithEvents TxtProveedor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNumeroPedido As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents BtnAnularFactura As Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
End Class
