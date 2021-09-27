<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIMenu
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIMenu))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ABMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TurnoComedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RubroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.DirectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecretarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AuxiliarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CargaDeCargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.EscuelasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.InformesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrangeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculadoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackUpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EscuelasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSLusuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripLabelUsuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanelIzq = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ComprasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CajaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.PanelIzq.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.ABMToolStripMenuItem, Me.InformesToolStripMenuItem, Me.SalirToolStripMenuItem, Me.HelpMenu, Me.WindowsMenu, Me.ToolsMenu, Me.BuscarVentasToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1184, 44)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.ConfiguraciónToolStripMenuItem, Me.ToolStripSeparator9})
        Me.FileMenu.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_Archivo_36
        Me.FileMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(111, 40)
        Me.FileMenu.Text = "&Archivo"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(248, 6)
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(251, 26)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración Mis Datos"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(248, 6)
        '
        'ABMToolStripMenuItem
        '
        Me.ABMToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TurnoToolStripMenuItem, Me.TurnoComedorToolStripMenuItem, Me.RubroToolStripMenuItem, Me.ToolStripSeparator4, Me.DirectorToolStripMenuItem, Me.SecretarioToolStripMenuItem, Me.AuxiliarToolStripMenuItem, Me.CargaDeCargosToolStripMenuItem, Me.ToolStripSeparator6, Me.EscuelasToolStripMenuItem, Me.ToolStripSeparator7, Me.ProveedoresToolStripMenuItem, Me.ToolStripSeparator5})
        Me.ABMToolStripMenuItem.Image = Global.ConsejoEscolar.My.Resources.Resources.Bl_ABM_36
        Me.ABMToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ABMToolStripMenuItem.Name = "ABMToolStripMenuItem"
        Me.ABMToolStripMenuItem.Size = New System.Drawing.Size(91, 40)
        Me.ABMToolStripMenuItem.Text = "A&BM"
        '
        'TurnoToolStripMenuItem
        '
        Me.TurnoToolStripMenuItem.Name = "TurnoToolStripMenuItem"
        Me.TurnoToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.TurnoToolStripMenuItem.Text = "Turno"
        '
        'TurnoComedorToolStripMenuItem
        '
        Me.TurnoComedorToolStripMenuItem.Name = "TurnoComedorToolStripMenuItem"
        Me.TurnoComedorToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.TurnoComedorToolStripMenuItem.Text = "Turno comedor"
        '
        'RubroToolStripMenuItem
        '
        Me.RubroToolStripMenuItem.Name = "RubroToolStripMenuItem"
        Me.RubroToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.RubroToolStripMenuItem.Text = "Rubro"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(192, 6)
        '
        'DirectorToolStripMenuItem
        '
        Me.DirectorToolStripMenuItem.Name = "DirectorToolStripMenuItem"
        Me.DirectorToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.DirectorToolStripMenuItem.Text = "Director"
        '
        'SecretarioToolStripMenuItem
        '
        Me.SecretarioToolStripMenuItem.Name = "SecretarioToolStripMenuItem"
        Me.SecretarioToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.SecretarioToolStripMenuItem.Text = "Secretario"
        '
        'AuxiliarToolStripMenuItem
        '
        Me.AuxiliarToolStripMenuItem.Name = "AuxiliarToolStripMenuItem"
        Me.AuxiliarToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.AuxiliarToolStripMenuItem.Text = "Auxiliar"
        '
        'CargaDeCargosToolStripMenuItem
        '
        Me.CargaDeCargosToolStripMenuItem.Name = "CargaDeCargosToolStripMenuItem"
        Me.CargaDeCargosToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.CargaDeCargosToolStripMenuItem.Text = "Carga de Cargos"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(192, 6)
        '
        'EscuelasToolStripMenuItem
        '
        Me.EscuelasToolStripMenuItem.Name = "EscuelasToolStripMenuItem"
        Me.EscuelasToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.EscuelasToolStripMenuItem.Text = "Escuelas"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(192, 6)
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.ProveedoresToolStripMenuItem.Text = "&Proveedores"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(192, 6)
        '
        'InformesToolStripMenuItem
        '
        Me.InformesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StockToolStripMenuItem, Me.ProveedoresToolStripMenuItem1, Me.VentasToolStripMenuItem})
        Me.InformesToolStripMenuItem.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_edit_36
        Me.InformesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.InformesToolStripMenuItem.Name = "InformesToolStripMenuItem"
        Me.InformesToolStripMenuItem.Size = New System.Drawing.Size(120, 40)
        Me.InformesToolStripMenuItem.Text = "&Informes"
        '
        'StockToolStripMenuItem
        '
        Me.StockToolStripMenuItem.Name = "StockToolStripMenuItem"
        Me.StockToolStripMenuItem.Size = New System.Drawing.Size(336, 26)
        Me.StockToolStripMenuItem.Text = "Escuelas por tipo"
        '
        'ProveedoresToolStripMenuItem1
        '
        Me.ProveedoresToolStripMenuItem1.Name = "ProveedoresToolStripMenuItem1"
        Me.ProveedoresToolStripMenuItem1.Size = New System.Drawing.Size(336, 26)
        Me.ProveedoresToolStripMenuItem1.Text = "&Proveedores"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(336, 26)
        Me.VentasToolStripMenuItem.Text = "&Facturas con parametros desde hasta"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.SalirToolStripMenuItem.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_exit_36
        Me.SalirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(89, 40)
        Me.SalirToolStripMenuItem.Text = "&Salir"
        '
        'HelpMenu
        '
        Me.HelpMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpMenu.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_help_36
        Me.HelpMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(102, 40)
        Me.HelpMenu.Text = "Ay&uda"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(156, 26)
        Me.AboutToolStripMenuItem.Text = "&Acerca de..."
        '
        'WindowsMenu
        '
        Me.WindowsMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem, Me.ArrangeIconsToolStripMenuItem, Me.ToolStripSeparator1})
        Me.WindowsMenu.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_window_36
        Me.WindowsMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(121, 40)
        Me.WindowsMenu.Text = "&Ventanas"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
        Me.CascadeToolStripMenuItem.Text = "&Cascada"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
        Me.TileVerticalToolStripMenuItem.Text = "&Maximizar"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
        Me.TileHorizontalToolStripMenuItem.Text = "M&inimizar"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
        Me.CloseAllToolStripMenuItem.Text = "C&errar todo"
        '
        'ArrangeIconsToolStripMenuItem
        '
        Me.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        Me.ArrangeIconsToolStripMenuItem.Size = New System.Drawing.Size(198, 26)
        Me.ArrangeIconsToolStripMenuItem.Text = "&Organizar iconos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(195, 6)
        '
        'ToolsMenu
        '
        Me.ToolsMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculadoraToolStripMenuItem, Me.BackUpToolStripMenuItem1, Me.UsuariosToolStripMenuItem1})
        Me.ToolsMenu.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_Tools_36
        Me.ToolsMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Size = New System.Drawing.Size(152, 40)
        Me.ToolsMenu.Text = "&Herramientas"
        '
        'CalculadoraToolStripMenuItem
        '
        Me.CalculadoraToolStripMenuItem.Name = "CalculadoraToolStripMenuItem"
        Me.CalculadoraToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.CalculadoraToolStripMenuItem.Text = "&Calculadora"
        '
        'BackUpToolStripMenuItem1
        '
        Me.BackUpToolStripMenuItem1.Name = "BackUpToolStripMenuItem1"
        Me.BackUpToolStripMenuItem1.Size = New System.Drawing.Size(162, 26)
        Me.BackUpToolStripMenuItem1.Text = "&Back Up"
        '
        'UsuariosToolStripMenuItem1
        '
        Me.UsuariosToolStripMenuItem1.Name = "UsuariosToolStripMenuItem1"
        Me.UsuariosToolStripMenuItem1.Size = New System.Drawing.Size(162, 26)
        Me.UsuariosToolStripMenuItem1.Text = "&Usuarios"
        '
        'BuscarVentasToolStripMenuItem
        '
        Me.BuscarVentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturasToolStripMenuItem, Me.EscuelasToolStripMenuItem1})
        Me.BuscarVentasToolStripMenuItem.Image = Global.ConsejoEscolar.My.Resources.Resources.BI_find_b2_36
        Me.BuscarVentasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BuscarVentasToolStripMenuItem.Name = "BuscarVentasToolStripMenuItem"
        Me.BuscarVentasToolStripMenuItem.Size = New System.Drawing.Size(108, 40)
        Me.BuscarVentasToolStripMenuItem.Text = "Buscar "
        Me.BuscarVentasToolStripMenuItem.ToolTipText = "Busca para imprimir"
        '
        'FacturasToolStripMenuItem
        '
        Me.FacturasToolStripMenuItem.Name = "FacturasToolStripMenuItem"
        Me.FacturasToolStripMenuItem.Size = New System.Drawing.Size(138, 26)
        Me.FacturasToolStripMenuItem.Text = "Facturas"
        '
        'EscuelasToolStripMenuItem1
        '
        Me.EscuelasToolStripMenuItem1.Name = "EscuelasToolStripMenuItem1"
        Me.EscuelasToolStripMenuItem1.Size = New System.Drawing.Size(138, 26)
        Me.EscuelasToolStripMenuItem1.Text = "Escuelas"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel, Me.TSSLusuario, Me.ToolStripLabelUsuario})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 689)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1184, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(63, 17)
        Me.ToolStripStatusLabel.Text = "Sesion -ID:"
        '
        'TSSLusuario
        '
        Me.TSSLusuario.Name = "TSSLusuario"
        Me.TSSLusuario.Size = New System.Drawing.Size(50, 17)
        Me.TSSLusuario.Text = "Usuario:"
        '
        'ToolStripLabelUsuario
        '
        Me.ToolStripLabelUsuario.Name = "ToolStripLabelUsuario"
        Me.ToolStripLabelUsuario.Size = New System.Drawing.Size(0, 17)
        '
        'PanelIzq
        '
        Me.PanelIzq.Controls.Add(Me.MenuStrip1)
        Me.PanelIzq.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelIzq.Location = New System.Drawing.Point(0, 44)
        Me.PanelIzq.Name = "PanelIzq"
        Me.PanelIzq.Size = New System.Drawing.Size(138, 645)
        Me.PanelIzq.TabIndex = 9
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprasToolStripMenuItem, Me.VentaToolStripMenuItem, Me.CajaToolStripMenuItem1, Me.ProveedorToolStripMenuItem1})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.MenuStrip1.Size = New System.Drawing.Size(138, 645)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ComprasToolStripMenuItem
        '
        Me.ComprasToolStripMenuItem.Image = Global.ConsejoEscolar.My.Resources.Resources.escuela
        Me.ComprasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ComprasToolStripMenuItem.Name = "ComprasToolStripMenuItem"
        Me.ComprasToolStripMenuItem.Size = New System.Drawing.Size(131, 110)
        Me.ComprasToolStripMenuItem.Text = "Escuelas"
        Me.ComprasToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'VentaToolStripMenuItem
        '
        Me.VentaToolStripMenuItem.Image = Global.ConsejoEscolar.My.Resources.Resources.CargaFactura
        Me.VentaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.VentaToolStripMenuItem.Name = "VentaToolStripMenuItem"
        Me.VentaToolStripMenuItem.Size = New System.Drawing.Size(131, 110)
        Me.VentaToolStripMenuItem.Text = "Carga de Facturas"
        Me.VentaToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CajaToolStripMenuItem1
        '
        Me.CajaToolStripMenuItem1.Image = Global.ConsejoEscolar.My.Resources.Resources.CargaCargos
        Me.CajaToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CajaToolStripMenuItem1.Name = "CajaToolStripMenuItem1"
        Me.CajaToolStripMenuItem1.Size = New System.Drawing.Size(131, 110)
        Me.CajaToolStripMenuItem1.Text = "Carga cargos"
        Me.CajaToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ProveedorToolStripMenuItem1
        '
        Me.ProveedorToolStripMenuItem1.Image = Global.ConsejoEscolar.My.Resources.Resources.Proveedor
        Me.ProveedorToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ProveedorToolStripMenuItem1.Name = "ProveedorToolStripMenuItem1"
        Me.ProveedorToolStripMenuItem1.Size = New System.Drawing.Size(131, 108)
        Me.ProveedorToolStripMenuItem1.Text = "Proveedores"
        Me.ProveedorToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'MDIMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1184, 711)
        Me.Controls.Add(Me.PanelIzq)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Consejo Escolar Mercedes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.PanelIzq.ResumeLayout(False)
        Me.PanelIzq.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrangeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ABMToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackUpToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PanelIzq As System.Windows.Forms.Panel
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents VentaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CajaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TSSLusuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripLabelUsuario As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StockToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BuscarVentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculadoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DirectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TurnoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RubroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TurnoComedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EscuelasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SecretarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AuxiliarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CargaDeCargosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EscuelasToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedorToolStripMenuItem1 As ToolStripMenuItem
End Class
