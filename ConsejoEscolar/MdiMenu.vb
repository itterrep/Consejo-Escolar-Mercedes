Imports System.Windows.Forms

Public Class MDIMenu

    Private Sub MDIMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Consejo escolar Mercedes - GiF Sys - " & Date.Today
        Me.ToolStripLabelUsuario.Text = usuarioGlobal
        If usuarioGlobal = "Admin" Then
        End If
    End Sub
   
    '--------------------------------------------------------------------------------------------------------
    'Botonera Izquierda
    Private Sub ComprasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComprasToolStripMenuItem.Click
        FrmEscuelas.MdiParent = Me
        FrmEscuelas.Show()
    End Sub

    Private Sub VentaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentaToolStripMenuItem.Click
        FrmCargaFacturas.MdiParent = Me
        FrmCargaFacturas.Show()
    End Sub

    Private Sub CajaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CajaToolStripMenuItem1.Click
        FrmCargaCargos.MdiParent = Me
        FrmCargaCargos.Show()
    End Sub

    Private Sub ProveedorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProveedorToolStripMenuItem1.Click
        frmProveedores.MdiParent = Me
        frmProveedores.Show()
        frmProveedores.BtnCopiar.Visible = True
    End Sub

    '--------------------------------------------------------------------------------------------------------
    'MisDatos
    Private Sub ConfiguraciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguraciónToolStripMenuItem.Click
        FrmMisDatos.MdiParent = Me
        FrmMisDatos.Show()
    End Sub

    '--------------------------------------------------------------------------------------------------------
    'ABM's
    Private Sub TurnoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TurnoToolStripMenuItem.Click
        FrmTurno.MdiParent = Me
        FrmTurno.Show()
    End Sub

    Private Sub TurnoComedorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TurnoComedorToolStripMenuItem.Click
        FrmTComedor.MdiParent = Me
        FrmTComedor.Show()
    End Sub

    Private Sub RubroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RubroToolStripMenuItem.Click
        FrmRubro.MdiParent = Me
        FrmRubro.Show()
    End Sub

    Private Sub DirectorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DirectorToolStripMenuItem.Click
        frmDirector.MdiParent = Me
        frmDirector.Show()
    End Sub

    Private Sub SecretarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecretarioToolStripMenuItem.Click
        FrmSecretario.MdiParent = Me
        FrmSecretario.Show()
    End Sub

    Private Sub AuxiliarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AuxiliarToolStripMenuItem.Click
        FrmAuxiliar.MdiParent = Me
        FrmAuxiliar.Show()
    End Sub

    Private Sub CargaDeCargosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CargaDeCargosToolStripMenuItem.Click
        FrmCargaCargos.MdiParent = Me
        FrmCargaCargos.Show()
    End Sub

    Private Sub EscuelasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EscuelasToolStripMenuItem.Click
        FrmEscuelas.MdiParent = Me
        FrmEscuelas.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click
        frmProveedores.MdiParent = Me
        frmProveedores.Show()
        frmProveedores.BtnCopiar.Visible = True
    End Sub

    '--------------------------------------------------------------------------------------------------------
    'Informes
    Private Sub StockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StockToolStripMenuItem.Click
        FrmInformeEscuelasTipo.MdiParent = Me
        FrmInformeEscuelasTipo.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem1.Click
        FrmInformeProveedores.MdiParent = Me
        FrmInformeProveedores.Show()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VentasToolStripMenuItem.Click
        FrmBusquedaFacturasDesdeHasta.MdiParent = Me
        FrmBusquedaFacturasDesdeHasta.Show()
    End Sub

    '--------------------------------------------------------------------------------------------------------
    'Busquedas
    Private Sub FacturasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturasToolStripMenuItem.Click
        FrmBusquedaFacturas.MdiParent = Me
        FrmBusquedaFacturas.Show()
    End Sub

    Private Sub EscuelasToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EscuelasToolStripMenuItem1.Click
        FrmBusquedaEscuelas.MdiParent = Me
        FrmBusquedaEscuelas.Show()
    End Sub

    '--------------------------------------------------------------------------------------------------------
    'Herramientas
    Private Sub CalculadoraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculadoraToolStripMenuItem.Click
        Dim d
        d = Shell("Calc.exe")
    End Sub

    Private Sub BackUpToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackUpToolStripMenuItem1.Click
        FrmBackUp.MdiParent = Me
        FrmBackUp.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuariosToolStripMenuItem1.Click
        LoginFormUsuarios.MdiParent = Me
        LoginFormUsuarios.Show()
    End Sub

    '--------------------------------------------------------------------------------------------------------
    'Ventanas
    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).WindowState = FormWindowState.Normal
        Next
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        For i As Integer = 0 To Me.MdiChildren.Length - 1
            Me.MdiChildren(i).WindowState = FormWindowState.Minimized
        Next
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer
    '--------------------------------------------------------------------------------------------------------
    'About
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        FrmAbout.MdiParent = Me
        FrmAbout.Show()
    End Sub
    '--------------------------------------------------------------------------------------------------------
    'Salir
    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim resultado As DialogResult = MessageBox.Show("Está seguro de salir?",
                                            "Atención", MessageBoxButtons.YesNo)
        If resultado = Windows.Forms.DialogResult.Yes Then
            'Deja el formulario activo 
            FrmLogin.Show()
            FrmLogin.UsernameTextBox.Focus()
            Me.Close()
        End If
    End Sub

End Class
