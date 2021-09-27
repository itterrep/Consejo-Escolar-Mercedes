<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaFacturas
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
        Me.TxtCue = New System.Windows.Forms.TextBox()
        Me.DGVfacturas = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtProveedor = New System.Windows.Forms.TextBox()
        Me.BtnAnularFactura = New System.Windows.Forms.Button()
        Me.CBTarea = New System.Windows.Forms.ComboBox()
        CType(Me.DGVfacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtCue
        '
        Me.TxtCue.Location = New System.Drawing.Point(170, 68)
        Me.TxtCue.Name = "TxtCue"
        Me.TxtCue.Size = New System.Drawing.Size(128, 20)
        Me.TxtCue.TabIndex = 50
        '
        'DGVfacturas
        '
        Me.DGVfacturas.AllowUserToAddRows = False
        Me.DGVfacturas.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DGVfacturas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVfacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVfacturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVfacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVfacturas.Location = New System.Drawing.Point(10, 99)
        Me.DGVfacturas.Name = "DGVfacturas"
        Me.DGVfacturas.ReadOnly = True
        Me.DGVfacturas.RowHeadersVisible = False
        Me.DGVfacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVfacturas.Size = New System.Drawing.Size(946, 410)
        Me.DGVfacturas.TabIndex = 49
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(10, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(891, 48)
        Me.Panel1.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(294, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(307, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Busqueda de Facturas"
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_refresh_48
        Me.btnRefresh.Location = New System.Drawing.Point(907, 9)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(48, 48)
        Me.btnRefresh.TabIndex = 51
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(141, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Cue"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(386, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Tarea"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(652, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Proveedor"
        '
        'TxtProveedor
        '
        Me.TxtProveedor.Location = New System.Drawing.Point(709, 68)
        Me.TxtProveedor.Name = "TxtProveedor"
        Me.TxtProveedor.Size = New System.Drawing.Size(246, 20)
        Me.TxtProveedor.TabIndex = 57
        '
        'BtnAnularFactura
        '
        Me.BtnAnularFactura.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnAnularFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnularFactura.Location = New System.Drawing.Point(355, 515)
        Me.BtnAnularFactura.Name = "BtnAnularFactura"
        Me.BtnAnularFactura.Size = New System.Drawing.Size(256, 31)
        Me.BtnAnularFactura.TabIndex = 59
        Me.BtnAnularFactura.Text = "Seleccionar Factura para ANULAR"
        Me.BtnAnularFactura.UseVisualStyleBackColor = False
        '
        'CBTarea
        '
        Me.CBTarea.BackColor = System.Drawing.Color.White
        Me.CBTarea.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBTarea.FormattingEnabled = True
        Me.CBTarea.Location = New System.Drawing.Point(424, 65)
        Me.CBTarea.Name = "CBTarea"
        Me.CBTarea.Size = New System.Drawing.Size(175, 25)
        Me.CBTarea.TabIndex = 139
        '
        'FrmBusquedaFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 554)
        Me.Controls.Add(Me.CBTarea)
        Me.Controls.Add(Me.BtnAnularFactura)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtProveedor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.TxtCue)
        Me.Controls.Add(Me.DGVfacturas)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.Name = "FrmBusquedaFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de venta"
        CType(Me.DGVfacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents TxtCue As System.Windows.Forms.TextBox
    Friend WithEvents DGVfacturas As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtProveedor As TextBox
    Friend WithEvents BtnAnularFactura As Button
    Friend WithEvents CBTarea As System.Windows.Forms.ComboBox
End Class
