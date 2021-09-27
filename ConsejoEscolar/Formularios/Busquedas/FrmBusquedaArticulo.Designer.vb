<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaPersonas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBusquedaPersonas))
        Me.TxtPersonas = New System.Windows.Forms.TextBox()
        Me.DataGridViewPersonas = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblTitulo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAddDirector = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.BtnAddAuxiliar = New System.Windows.Forms.Button()
        Me.BtnAddSecretario = New System.Windows.Forms.Button()
        CType(Me.DataGridViewPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtPersonas
        '
        Me.TxtPersonas.Location = New System.Drawing.Point(282, 60)
        Me.TxtPersonas.Name = "TxtPersonas"
        Me.TxtPersonas.Size = New System.Drawing.Size(246, 20)
        Me.TxtPersonas.TabIndex = 50
        '
        'DataGridViewPersonas
        '
        Me.DataGridViewPersonas.AllowUserToAddRows = False
        Me.DataGridViewPersonas.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DataGridViewPersonas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewPersonas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPersonas.Location = New System.Drawing.Point(10, 93)
        Me.DataGridViewPersonas.Name = "DataGridViewPersonas"
        Me.DataGridViewPersonas.ReadOnly = True
        Me.DataGridViewPersonas.RowHeadersVisible = False
        Me.DataGridViewPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewPersonas.Size = New System.Drawing.Size(804, 416)
        Me.DataGridViewPersonas.TabIndex = 49
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.LblTitulo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(9, 9)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(750, 38)
        Me.Panel1.TabIndex = 48
        '
        'LblTitulo
        '
        Me.LblTitulo.AutoSize = True
        Me.LblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitulo.Location = New System.Drawing.Point(427, 0)
        Me.LblTitulo.Name = "LblTitulo"
        Me.LblTitulo.Size = New System.Drawing.Size(0, 31)
        Me.LblTitulo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(244, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Busqueda de "
        '
        'btnAddDirector
        '
        Me.btnAddDirector.Image = CType(resources.GetObject("btnAddDirector.Image"), System.Drawing.Image)
        Me.btnAddDirector.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddDirector.Location = New System.Drawing.Point(534, 52)
        Me.btnAddDirector.Name = "btnAddDirector"
        Me.btnAddDirector.Size = New System.Drawing.Size(89, 36)
        Me.btnAddDirector.TabIndex = 52
        Me.btnAddDirector.Text = "Copiar"
        Me.btnAddDirector.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAddDirector.UseVisualStyleBackColor = True
        Me.btnAddDirector.Visible = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_refresh_48
        Me.btnRefresh.Location = New System.Drawing.Point(766, 8)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(48, 48)
        Me.btnRefresh.TabIndex = 51
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'BtnAddAuxiliar
        '
        Me.BtnAddAuxiliar.Image = CType(resources.GetObject("BtnAddAuxiliar.Image"), System.Drawing.Image)
        Me.BtnAddAuxiliar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddAuxiliar.Location = New System.Drawing.Point(629, 52)
        Me.BtnAddAuxiliar.Name = "BtnAddAuxiliar"
        Me.BtnAddAuxiliar.Size = New System.Drawing.Size(89, 36)
        Me.BtnAddAuxiliar.TabIndex = 53
        Me.BtnAddAuxiliar.Text = "Copiar"
        Me.BtnAddAuxiliar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddAuxiliar.UseVisualStyleBackColor = True
        Me.BtnAddAuxiliar.Visible = False
        '
        'BtnAddSecretario
        '
        Me.BtnAddSecretario.Image = CType(resources.GetObject("BtnAddSecretario.Image"), System.Drawing.Image)
        Me.BtnAddSecretario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAddSecretario.Location = New System.Drawing.Point(187, 52)
        Me.BtnAddSecretario.Name = "BtnAddSecretario"
        Me.BtnAddSecretario.Size = New System.Drawing.Size(89, 36)
        Me.BtnAddSecretario.TabIndex = 54
        Me.BtnAddSecretario.Text = "Copiar"
        Me.BtnAddSecretario.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAddSecretario.UseVisualStyleBackColor = True
        Me.BtnAddSecretario.Visible = False
        '
        'FrmBusquedaPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 521)
        Me.Controls.Add(Me.BtnAddSecretario)
        Me.Controls.Add(Me.BtnAddAuxiliar)
        Me.Controls.Add(Me.btnAddDirector)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.TxtPersonas)
        Me.Controls.Add(Me.DataGridViewPersonas)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = False
        Me.Name = "FrmBusquedaPersonas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda"
        CType(Me.DataGridViewPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddDirector As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents TxtPersonas As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewPersonas As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnAddAuxiliar As System.Windows.Forms.Button
    Friend WithEvents BtnAddSecretario As System.Windows.Forms.Button
    Friend WithEvents LblTitulo As System.Windows.Forms.Label
End Class
