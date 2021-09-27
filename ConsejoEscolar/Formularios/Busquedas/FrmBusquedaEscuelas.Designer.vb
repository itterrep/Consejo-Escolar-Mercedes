<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaEscuelas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBusquedaEscuelas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridViewEscuelas = New System.Windows.Forms.DataGridView()
        Me.TxtEscuelas = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnCopiarEscuelas = New System.Windows.Forms.Button()
        Me.BtnAddCueAuxiliar = New System.Windows.Forms.Button()
        Me.BtnAddCueSecretario = New System.Windows.Forms.Button()
        Me.BtnAddCueDirector = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAddCueFactura1 = New System.Windows.Forms.Button()
        Me.BtnAddCueFactura2 = New System.Windows.Forms.Button()
        Me.BtnAddCueFactura3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewEscuelas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(8, 7)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(742, 42)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(237, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(311, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Busqueda de Escuelas"
        '
        'DataGridViewEscuelas
        '
        Me.DataGridViewEscuelas.AllowUserToAddRows = False
        Me.DataGridViewEscuelas.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridViewEscuelas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewEscuelas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewEscuelas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewEscuelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewEscuelas.Location = New System.Drawing.Point(5, 99)
        Me.DataGridViewEscuelas.Name = "DataGridViewEscuelas"
        Me.DataGridViewEscuelas.ReadOnly = True
        Me.DataGridViewEscuelas.RowHeadersVisible = False
        Me.DataGridViewEscuelas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewEscuelas.Size = New System.Drawing.Size(804, 363)
        Me.DataGridViewEscuelas.TabIndex = 1
        '
        'TxtEscuelas
        '
        Me.TxtEscuelas.Location = New System.Drawing.Point(302, 70)
        Me.TxtEscuelas.Name = "TxtEscuelas"
        Me.TxtEscuelas.Size = New System.Drawing.Size(211, 20)
        Me.TxtEscuelas.TabIndex = 1
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_refresh_48
        Me.btnRefresh.Location = New System.Drawing.Point(761, 7)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(48, 48)
        Me.btnRefresh.TabIndex = 39
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnCopiarEscuelas
        '
        Me.btnCopiarEscuelas.Image = CType(resources.GetObject("btnCopiarEscuelas.Image"), System.Drawing.Image)
        Me.btnCopiarEscuelas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCopiarEscuelas.Location = New System.Drawing.Point(531, 55)
        Me.btnCopiarEscuelas.Name = "btnCopiarEscuelas"
        Me.btnCopiarEscuelas.Size = New System.Drawing.Size(89, 38)
        Me.btnCopiarEscuelas.TabIndex = 48
        Me.btnCopiarEscuelas.Text = "Copiar"
        Me.btnCopiarEscuelas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCopiarEscuelas.UseVisualStyleBackColor = True
        Me.btnCopiarEscuelas.Visible = False
        '
        'BtnAddCueAuxiliar
        '
        Me.BtnAddCueAuxiliar.Image = CType(resources.GetObject("BtnAddCueAuxiliar.Image"), System.Drawing.Image)
        Me.BtnAddCueAuxiliar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddCueAuxiliar.Location = New System.Drawing.Point(531, 55)
        Me.BtnAddCueAuxiliar.Name = "BtnAddCueAuxiliar"
        Me.BtnAddCueAuxiliar.Size = New System.Drawing.Size(89, 38)
        Me.BtnAddCueAuxiliar.TabIndex = 49
        Me.BtnAddCueAuxiliar.Text = "Copiar"
        Me.BtnAddCueAuxiliar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddCueAuxiliar.UseVisualStyleBackColor = True
        Me.BtnAddCueAuxiliar.Visible = False
        '
        'BtnAddCueSecretario
        '
        Me.BtnAddCueSecretario.Image = CType(resources.GetObject("BtnAddCueSecretario.Image"), System.Drawing.Image)
        Me.BtnAddCueSecretario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddCueSecretario.Location = New System.Drawing.Point(531, 55)
        Me.BtnAddCueSecretario.Name = "BtnAddCueSecretario"
        Me.BtnAddCueSecretario.Size = New System.Drawing.Size(89, 38)
        Me.BtnAddCueSecretario.TabIndex = 50
        Me.BtnAddCueSecretario.Text = "Copiar"
        Me.BtnAddCueSecretario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddCueSecretario.UseVisualStyleBackColor = True
        Me.BtnAddCueSecretario.Visible = False
        '
        'BtnAddCueDirector
        '
        Me.BtnAddCueDirector.Image = CType(resources.GetObject("BtnAddCueDirector.Image"), System.Drawing.Image)
        Me.BtnAddCueDirector.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddCueDirector.Location = New System.Drawing.Point(531, 55)
        Me.BtnAddCueDirector.Name = "BtnAddCueDirector"
        Me.BtnAddCueDirector.Size = New System.Drawing.Size(89, 38)
        Me.BtnAddCueDirector.TabIndex = 51
        Me.BtnAddCueDirector.Text = "Copiar"
        Me.BtnAddCueDirector.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddCueDirector.UseVisualStyleBackColor = True
        Me.BtnAddCueDirector.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(374, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Nombre "
        '
        'BtnAddCueFactura1
        '
        Me.BtnAddCueFactura1.Image = CType(resources.GetObject("BtnAddCueFactura1.Image"), System.Drawing.Image)
        Me.BtnAddCueFactura1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddCueFactura1.Location = New System.Drawing.Point(192, 55)
        Me.BtnAddCueFactura1.Name = "BtnAddCueFactura1"
        Me.BtnAddCueFactura1.Size = New System.Drawing.Size(89, 38)
        Me.BtnAddCueFactura1.TabIndex = 53
        Me.BtnAddCueFactura1.Text = "Copiar"
        Me.BtnAddCueFactura1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddCueFactura1.UseVisualStyleBackColor = True
        Me.BtnAddCueFactura1.Visible = False
        '
        'BtnAddCueFactura2
        '
        Me.BtnAddCueFactura2.Image = CType(resources.GetObject("BtnAddCueFactura2.Image"), System.Drawing.Image)
        Me.BtnAddCueFactura2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddCueFactura2.Location = New System.Drawing.Point(192, 55)
        Me.BtnAddCueFactura2.Name = "BtnAddCueFactura2"
        Me.BtnAddCueFactura2.Size = New System.Drawing.Size(89, 38)
        Me.BtnAddCueFactura2.TabIndex = 54
        Me.BtnAddCueFactura2.Text = "Copiar"
        Me.BtnAddCueFactura2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddCueFactura2.UseVisualStyleBackColor = True
        Me.BtnAddCueFactura2.Visible = False
        '
        'BtnAddCueFactura3
        '
        Me.BtnAddCueFactura3.Image = CType(resources.GetObject("BtnAddCueFactura3.Image"), System.Drawing.Image)
        Me.BtnAddCueFactura3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddCueFactura3.Location = New System.Drawing.Point(192, 55)
        Me.BtnAddCueFactura3.Name = "BtnAddCueFactura3"
        Me.BtnAddCueFactura3.Size = New System.Drawing.Size(89, 38)
        Me.BtnAddCueFactura3.TabIndex = 55
        Me.BtnAddCueFactura3.Text = "Copiar"
        Me.BtnAddCueFactura3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddCueFactura3.UseVisualStyleBackColor = True
        Me.BtnAddCueFactura3.Visible = False
        '
        'FrmBusquedaEscuelas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(814, 471)
        Me.Controls.Add(Me.BtnAddCueFactura3)
        Me.Controls.Add(Me.BtnAddCueFactura2)
        Me.Controls.Add(Me.BtnAddCueFactura1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnAddCueDirector)
        Me.Controls.Add(Me.BtnAddCueSecretario)
        Me.Controls.Add(Me.BtnAddCueAuxiliar)
        Me.Controls.Add(Me.btnCopiarEscuelas)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.TxtEscuelas)
        Me.Controls.Add(Me.DataGridViewEscuelas)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "FrmBusquedaEscuelas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de Escuelas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridViewEscuelas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridViewEscuelas As System.Windows.Forms.DataGridView
    Friend WithEvents TxtEscuelas As System.Windows.Forms.TextBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnCopiarEscuelas As System.Windows.Forms.Button
    Friend WithEvents BtnAddCueAuxiliar As System.Windows.Forms.Button
    Friend WithEvents BtnAddCueSecretario As System.Windows.Forms.Button
    Friend WithEvents BtnAddCueDirector As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BtnAddCueFactura1 As Button
    Friend WithEvents BtnAddCueFactura2 As Button
    Friend WithEvents BtnAddCueFactura3 As Button
End Class
