<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCargaFacturas
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtNFactura = New System.Windows.Forms.TextBox()
        Me.TxtMonto = New System.Windows.Forms.TextBox()
        Me.TxtRazonSocial = New System.Windows.Forms.TextBox()
        Me.TxtProveedor = New System.Windows.Forms.TextBox()
        Me.DTFactura = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BtnAddCue = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnCargaFactura = New System.Windows.Forms.Button()
        Me.BtnProveedor = New System.Windows.Forms.Button()
        Me.CBRubro = New System.Windows.Forms.ComboBox()
        Me.BtnAddRubro = New System.Windows.Forms.Button()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtCue = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBCuenta = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(83, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Cod. Proveedor"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(257, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Razon Social del Proveedor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(74, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Cue"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(71, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 17)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Rubro"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(221, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 17)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Nº Factura"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(394, 85)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 17)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Monto"
        '
        'TxtNFactura
        '
        Me.TxtNFactura.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNFactura.Location = New System.Drawing.Point(180, 105)
        Me.TxtNFactura.Name = "TxtNFactura"
        Me.TxtNFactura.Size = New System.Drawing.Size(155, 25)
        Me.TxtNFactura.TabIndex = 23
        Me.TxtNFactura.Text = "0"
        Me.TxtNFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtMonto
        '
        Me.TxtMonto.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMonto.Location = New System.Drawing.Point(364, 105)
        Me.TxtMonto.Name = "TxtMonto"
        Me.TxtMonto.Size = New System.Drawing.Size(110, 25)
        Me.TxtMonto.TabIndex = 24
        Me.TxtMonto.Text = "0"
        Me.TxtMonto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtRazonSocial
        '
        Me.TxtRazonSocial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRazonSocial.Location = New System.Drawing.Point(201, 59)
        Me.TxtRazonSocial.Name = "TxtRazonSocial"
        Me.TxtRazonSocial.ReadOnly = True
        Me.TxtRazonSocial.Size = New System.Drawing.Size(293, 22)
        Me.TxtRazonSocial.TabIndex = 26
        '
        'TxtProveedor
        '
        Me.TxtProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProveedor.Location = New System.Drawing.Point(83, 59)
        Me.TxtProveedor.Name = "TxtProveedor"
        Me.TxtProveedor.ReadOnly = True
        Me.TxtProveedor.Size = New System.Drawing.Size(102, 22)
        Me.TxtProveedor.TabIndex = 27
        '
        'DTFactura
        '
        Me.DTFactura.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTFactura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFactura.Location = New System.Drawing.Point(61, 105)
        Me.DTFactura.Name = "DTFactura"
        Me.DTFactura.Size = New System.Drawing.Size(96, 25)
        Me.DTFactura.TabIndex = 40
        Me.DTFactura.Value = New Date(2017, 12, 16, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(180, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(175, 25)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Cargas de facturas"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(88, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 17)
        Me.Label10.TabIndex = 118
        Me.Label10.Text = "Fecha"
        '
        'BtnAddCue
        '
        Me.BtnAddCue.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_find_b2_36
        Me.BtnAddCue.Location = New System.Drawing.Point(26, 194)
        Me.BtnAddCue.Name = "BtnAddCue"
        Me.BtnAddCue.Size = New System.Drawing.Size(40, 40)
        Me.BtnAddCue.TabIndex = 112
        Me.BtnAddCue.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnClose.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_cancel_48
        Me.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClose.Location = New System.Drawing.Point(277, 248)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(170, 48)
        Me.BtnClose.TabIndex = 109
        Me.BtnClose.Text = "Cancelar"
        Me.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnCargaFactura
        '
        Me.BtnCargaFactura.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnCargaFactura.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCargaFactura.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_save_48
        Me.BtnCargaFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCargaFactura.Location = New System.Drawing.Point(88, 248)
        Me.BtnCargaFactura.Name = "BtnCargaFactura"
        Me.BtnCargaFactura.Size = New System.Drawing.Size(170, 48)
        Me.BtnCargaFactura.TabIndex = 108
        Me.BtnCargaFactura.Text = "Aceptar"
        Me.BtnCargaFactura.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCargaFactura.UseVisualStyleBackColor = True
        '
        'BtnProveedor
        '
        Me.BtnProveedor.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_find_b2_36
        Me.BtnProveedor.Location = New System.Drawing.Point(40, 39)
        Me.BtnProveedor.Name = "BtnProveedor"
        Me.BtnProveedor.Size = New System.Drawing.Size(40, 40)
        Me.BtnProveedor.TabIndex = 79
        Me.BtnProveedor.UseVisualStyleBackColor = True
        '
        'CBRubro
        '
        Me.CBRubro.BackColor = System.Drawing.SystemColors.Window
        Me.CBRubro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBRubro.FormattingEnabled = True
        Me.CBRubro.Location = New System.Drawing.Point(68, 156)
        Me.CBRubro.Name = "CBRubro"
        Me.CBRubro.Size = New System.Drawing.Size(216, 24)
        Me.CBRubro.TabIndex = 121
        '
        'BtnAddRubro
        '
        Me.BtnAddRubro.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_add2_36
        Me.BtnAddRubro.Location = New System.Drawing.Point(27, 142)
        Me.BtnAddRubro.Name = "BtnAddRubro"
        Me.BtnAddRubro.Size = New System.Drawing.Size(37, 37)
        Me.BtnAddRubro.TabIndex = 120
        Me.BtnAddRubro.UseVisualStyleBackColor = True
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(221, 210)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.ReadOnly = True
        Me.TxtNombre.Size = New System.Drawing.Size(288, 25)
        Me.TxtNombre.TabIndex = 123
        Me.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtCue
        '
        Me.TxtCue.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCue.Location = New System.Drawing.Point(70, 210)
        Me.TxtCue.Name = "TxtCue"
        Me.TxtCue.ReadOnly = True
        Me.TxtCue.Size = New System.Drawing.Size(145, 25)
        Me.TxtCue.TabIndex = 124
        Me.TxtCue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(218, 190)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 17)
        Me.Label1.TabIndex = 125
        Me.Label1.Text = "Nombre"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CBCuenta
        '
        Me.CBCuenta.BackColor = System.Drawing.SystemColors.Window
        Me.CBCuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBCuenta.FormattingEnabled = True
        Me.CBCuenta.Items.AddRange(New Object() {"Compensador", "CUFP"})
        Me.CBCuenta.Location = New System.Drawing.Point(290, 155)
        Me.CBCuenta.Name = "CBCuenta"
        Me.CBCuenta.Size = New System.Drawing.Size(219, 24)
        Me.CBCuenta.TabIndex = 127
        Me.CBCuenta.Text = "Compensador"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(293, 137)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 17)
        Me.Label9.TabIndex = 126
        Me.Label9.Text = "Cuenta"
        '
        'FrmCargaFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(534, 311)
        Me.Controls.Add(Me.CBCuenta)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtCue)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.CBRubro)
        Me.Controls.Add(Me.BtnAddRubro)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BtnAddCue)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnCargaFactura)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnProveedor)
        Me.Controls.Add(Me.DTFactura)
        Me.Controls.Add(Me.TxtProveedor)
        Me.Controls.Add(Me.TxtRazonSocial)
        Me.Controls.Add(Me.TxtMonto)
        Me.Controls.Add(Me.TxtNFactura)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.Name = "FrmCargaFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga de facturas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtNFactura As System.Windows.Forms.TextBox
    Friend WithEvents TxtMonto As System.Windows.Forms.TextBox
    Friend WithEvents TxtRazonSocial As System.Windows.Forms.TextBox
    Friend WithEvents TxtProveedor As System.Windows.Forms.TextBox
    Friend WithEvents DTFactura As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnProveedor As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnCargaFactura As System.Windows.Forms.Button
    Friend WithEvents BtnAddCue As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CBRubro As System.Windows.Forms.ComboBox
    Friend WithEvents BtnAddRubro As System.Windows.Forms.Button
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxtCue As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBCuenta As ComboBox
    Friend WithEvents Label9 As Label
End Class
