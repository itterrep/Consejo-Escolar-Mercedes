<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocProv
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
        Me.CB1 = New System.Windows.Forms.CheckBox()
        Me.CB2 = New System.Windows.Forms.CheckBox()
        Me.CB3 = New System.Windows.Forms.CheckBox()
        Me.CB4 = New System.Windows.Forms.CheckBox()
        Me.CB5 = New System.Windows.Forms.CheckBox()
        Me.CB6 = New System.Windows.Forms.CheckBox()
        Me.CB7 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtProveedor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CB8 = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.BtnGrabar = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CB1
        '
        Me.CB1.AutoSize = True
        Me.CB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB1.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.CB1.Location = New System.Drawing.Point(48, 7)
        Me.CB1.Name = "CB1"
        Me.CB1.Size = New System.Drawing.Size(233, 21)
        Me.CB1.TabIndex = 0
        Me.CB1.Text = "Formulario Inscripción al consejo"
        Me.CB1.UseVisualStyleBackColor = True
        '
        'CB2
        '
        Me.CB2.AutoSize = True
        Me.CB2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB2.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.CB2.Location = New System.Drawing.Point(48, 32)
        Me.CB2.Name = "CB2"
        Me.CB2.Size = New System.Drawing.Size(116, 21)
        Me.CB2.TabIndex = 1
        Me.CB2.Text = "Fotocopia DNI"
        Me.CB2.UseVisualStyleBackColor = True
        '
        'CB3
        '
        Me.CB3.AutoSize = True
        Me.CB3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB3.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.CB3.Location = New System.Drawing.Point(48, 57)
        Me.CB3.Name = "CB3"
        Me.CB3.Size = New System.Drawing.Size(132, 21)
        Me.CB3.TabIndex = 2
        Me.CB3.Text = "Constancia CUIT"
        Me.CB3.UseVisualStyleBackColor = True
        '
        'CB4
        '
        Me.CB4.AutoSize = True
        Me.CB4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB4.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.CB4.Location = New System.Drawing.Point(48, 82)
        Me.CB4.Name = "CB4"
        Me.CB4.Size = New System.Drawing.Size(122, 21)
        Me.CB4.TabIndex = 3
        Me.CB4.Text = "Constancia IBB"
        Me.CB4.UseVisualStyleBackColor = True
        '
        'CB5
        '
        Me.CB5.AutoSize = True
        Me.CB5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB5.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.CB5.Location = New System.Drawing.Point(48, 107)
        Me.CB5.Name = "CB5"
        Me.CB5.Size = New System.Drawing.Size(122, 21)
        Me.CB5.TabIndex = 4
        Me.CB5.Text = "Formulario 404"
        Me.CB5.UseVisualStyleBackColor = True
        '
        'CB6
        '
        Me.CB6.AutoSize = True
        Me.CB6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB6.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.CB6.Location = New System.Drawing.Point(48, 132)
        Me.CB6.Name = "CB6"
        Me.CB6.Size = New System.Drawing.Size(163, 21)
        Me.CB6.TabIndex = 5
        Me.CB6.Text = "Habilitación Municipal"
        Me.CB6.UseVisualStyleBackColor = True
        '
        'CB7
        '
        Me.CB7.AutoSize = True
        Me.CB7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB7.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.CB7.Location = New System.Drawing.Point(48, 157)
        Me.CB7.Name = "CB7"
        Me.CB7.Size = New System.Drawing.Size(200, 21)
        Me.CB7.TabIndex = 6
        Me.CB7.Text = "Proveedores del estado BA"
        Me.CB7.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(387, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Documentación presentada por el proveedor"
        '
        'TxtProveedor
        '
        Me.TxtProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtProveedor.Location = New System.Drawing.Point(19, 61)
        Me.TxtProveedor.Name = "TxtProveedor"
        Me.TxtProveedor.ReadOnly = True
        Me.TxtProveedor.Size = New System.Drawing.Size(102, 22)
        Me.TxtProveedor.TabIndex = 81
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Cod. Proveedor"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CB8)
        Me.Panel1.Controls.Add(Me.CB7)
        Me.Panel1.Controls.Add(Me.CB6)
        Me.Panel1.Controls.Add(Me.CB5)
        Me.Panel1.Controls.Add(Me.CB4)
        Me.Panel1.Controls.Add(Me.CB3)
        Me.Panel1.Controls.Add(Me.CB2)
        Me.Panel1.Controls.Add(Me.CB1)
        Me.Panel1.Location = New System.Drawing.Point(19, 89)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(396, 210)
        Me.Panel1.TabIndex = 83
        '
        'CB8
        '
        Me.CB8.AutoSize = True
        Me.CB8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB8.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.CB8.Location = New System.Drawing.Point(48, 182)
        Me.CB8.Name = "CB8"
        Me.CB8.Size = New System.Drawing.Size(142, 21)
        Me.CB8.TabIndex = 7
        Me.CB8.Text = "Otros (ver legajo )"
        Me.CB8.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(245, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 127
        Me.Label3.Text = "Nombre"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtNombre
        '
        Me.TxtNombre.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(133, 59)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.ReadOnly = True
        Me.TxtNombre.Size = New System.Drawing.Size(282, 25)
        Me.TxtNombre.TabIndex = 126
        Me.TxtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnGrabar
        '
        Me.BtnGrabar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGrabar.Location = New System.Drawing.Point(0, 332)
        Me.BtnGrabar.Name = "BtnGrabar"
        Me.BtnGrabar.Size = New System.Drawing.Size(434, 29)
        Me.BtnGrabar.TabIndex = 128
        Me.BtnGrabar.Text = "Grabar"
        Me.BtnGrabar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGrabar.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(69, 303)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(296, 26)
        Me.DateTimePicker1.TabIndex = 129
        '
        'FrmDocProv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 361)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.BtnGrabar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TxtProveedor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDocProv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Documentación Proveedores"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CB1 As CheckBox
    Friend WithEvents CB2 As CheckBox
    Friend WithEvents CB3 As CheckBox
    Friend WithEvents CB4 As CheckBox
    Friend WithEvents CB5 As CheckBox
    Friend WithEvents CB6 As CheckBox
    Friend WithEvents CB7 As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtProveedor As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents BtnGrabar As Button
    Friend WithEvents CB8 As CheckBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
