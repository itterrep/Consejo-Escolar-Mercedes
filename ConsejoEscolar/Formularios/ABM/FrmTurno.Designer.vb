<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTurno
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
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.BtnGraba = New System.Windows.Forms.Button()
        Me.BtnBorra = New System.Windows.Forms.Button()
        Me.ListBox = New System.Windows.Forms.ListBox()
        Me.TxtItem = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_add2_36
        Me.BtnAgregar.Location = New System.Drawing.Point(14, 33)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(55, 55)
        Me.BtnAgregar.TabIndex = 0
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'BtnGraba
        '
        Me.BtnGraba.Enabled = False
        Me.BtnGraba.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_disk_36
        Me.BtnGraba.Location = New System.Drawing.Point(14, 88)
        Me.BtnGraba.Name = "BtnGraba"
        Me.BtnGraba.Size = New System.Drawing.Size(55, 55)
        Me.BtnGraba.TabIndex = 1
        Me.BtnGraba.Text = "Grabar"
        Me.BtnGraba.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnGraba.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnGraba.UseVisualStyleBackColor = True
        '
        'BtnBorra
        '
        Me.BtnBorra.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_delete_36
        Me.BtnBorra.Location = New System.Drawing.Point(14, 143)
        Me.BtnBorra.Name = "BtnBorra"
        Me.BtnBorra.Size = New System.Drawing.Size(55, 55)
        Me.BtnBorra.TabIndex = 2
        Me.BtnBorra.Text = "Borrar"
        Me.BtnBorra.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BtnBorra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BtnBorra.UseVisualStyleBackColor = True
        '
        'ListBox
        '
        Me.ListBox.FormattingEnabled = True
        Me.ListBox.Location = New System.Drawing.Point(77, 33)
        Me.ListBox.Name = "ListBox"
        Me.ListBox.Size = New System.Drawing.Size(260, 173)
        Me.ListBox.TabIndex = 3
        '
        'TxtItem
        '
        Me.TxtItem.BackColor = System.Drawing.Color.LightGreen
        Me.TxtItem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtItem.Location = New System.Drawing.Point(77, 6)
        Me.TxtItem.Name = "TxtItem"
        Me.TxtItem.ReadOnly = True
        Me.TxtItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtItem.Size = New System.Drawing.Size(260, 20)
        Me.TxtItem.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnAgregar)
        Me.Panel1.Controls.Add(Me.TxtItem)
        Me.Panel1.Controls.Add(Me.BtnGraba)
        Me.Panel1.Controls.Add(Me.ListBox)
        Me.Panel1.Controls.Add(Me.BtnBorra)
        Me.Panel1.Location = New System.Drawing.Point(12, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(350, 210)
        Me.Panel1.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Turno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 2)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(285, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Altas, bajas y modificación de Turno"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnCerrar.Location = New System.Drawing.Point(0, 248)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(374, 23)
        Me.BtnCerrar.TabIndex = 8
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'FrmTurno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 271)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTurno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABM Turno"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAgregar As System.Windows.Forms.Button
    Friend WithEvents BtnGraba As System.Windows.Forms.Button
    Friend WithEvents BtnBorra As System.Windows.Forms.Button
    Friend WithEvents ListBox As System.Windows.Forms.ListBox
    Friend WithEvents TxtItem As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BtnCerrar As System.Windows.Forms.Button
End Class
