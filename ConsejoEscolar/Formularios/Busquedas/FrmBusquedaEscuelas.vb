Public Class FrmBusquedaEscuelas

    Dim dt As New DataTable
    Dim tabla As New DataTable
    Dim miescuela As New ClassEscuela
    'conecto a base de datos
    Dim miGestionMySQL As New GestionMySQL

    Private Sub FrmBusquedaEscuelas_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Iniciar()
    End Sub

    Private Sub Iniciar()
        dt = miGestionMySQL.Consulta("SELECT CUE, Tipo, Nombre, Direccion, Tel1, Tel2 FROM escuela order by tipo, Nombre")
        DataGridViewEscuelas.DataSource = dt
        TxtEscuelas.Text = ""
    End Sub

    Private Sub Txtescuelas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtescuelas.TextChanged
        'uso funcion para buscar en tabla , columna y campo que return un Datatable 
        tabla = miGestionMySQL.BuscarenTablaEscriboOrdenEscuela(TxtEscuelas.Text)
        DataGridViewEscuelas.DataSource = tabla
        'cierro conexion
        miGestionMySQL.Dispose()
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Iniciar()
    End Sub

    Private Sub BtnAddCueDirector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddCueDirector.Click
        If DataGridViewEscuelas.RowCount > 0 Then
            miescuela.IdCue = DataGridViewEscuelas.SelectedCells(0).Value
            miescuela.Nombre = DataGridViewEscuelas.SelectedCells(2).Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
            FrmCargaCargos.TxtCueDirector.Text = miescuela.IdCue
            FrmCargaCargos.TxtNombreCueDirector.Text = miescuela.Nombre
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If
        Me.Close()
    End Sub

    Private Sub BtnAddCueSecretario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddCueSecretario.Click
        If DataGridViewEscuelas.RowCount > 0 Then
            miescuela.IdCue = DataGridViewEscuelas.SelectedCells(0).Value
            miescuela.Nombre = DataGridViewEscuelas.SelectedCells(2).Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
            FrmCargaCargos.TxtCueSecretario.Text = miescuela.IdCue
            FrmCargaCargos.TxtNombreCueSecretario.Text = miescuela.Nombre
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If
        Me.Close()
    End Sub

    Private Sub BtnAddCueAuxiliar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddCueAuxiliar.Click
        If DataGridViewEscuelas.RowCount > 0 Then
            miescuela.IdCue = DataGridViewEscuelas.SelectedCells(0).Value
            miescuela.Nombre = DataGridViewEscuelas.SelectedCells(2).Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
            FrmCargaCargos.TxtCueAuxiliar.Text = miescuela.IdCue
            FrmCargaCargos.TxtNombreCueAuxiliar.Text = miescuela.Nombre
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If
        Me.Close()
    End Sub

    Private Sub BtnCopiarEscuelas_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopiarEscuelas.Click
        If DataGridViewEscuelas.RowCount > 0 Then
            miescuela.IdCue = DataGridViewEscuelas.SelectedCells(0).Value
            miescuela.Nombre = DataGridViewEscuelas.SelectedCells(2).Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
            FrmCargaFacturas.TxtCue.Text = miescuela.IdCue
            FrmCargaFacturas.TxtNombre.Text = miescuela.Nombre
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If
        Me.Close()
    End Sub

    Private Sub BtnAddCueFactura1_Click(sender As Object, e As EventArgs) Handles BtnAddCueFactura1.Click
        If DataGridViewEscuelas.RowCount > 0 Then
            miescuela.IdCue = DataGridViewEscuelas.SelectedCells(0).Value
            miescuela.Nombre = DataGridViewEscuelas.SelectedCells(2).Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
            FrmBusquedaFacturasDesdeHasta.CBCUE.Text = miescuela.IdCue
            FrmBusquedaFacturasDesdeHasta.LblCue.Text = miescuela.Nombre
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If
        Me.Close()
    End Sub

    Private Sub BtnAddCueFactura2_Click(sender As Object, e As EventArgs) Handles BtnAddCueFactura2.Click
        If DataGridViewEscuelas.RowCount > 0 Then
            miescuela.IdCue = DataGridViewEscuelas.SelectedCells(0).Value
            miescuela.Nombre = DataGridViewEscuelas.SelectedCells(2).Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
            FrmBusquedaFacturasDesdeHasta.CBCUE2.Text = miescuela.IdCue
            FrmBusquedaFacturasDesdeHasta.LblCue.Text = miescuela.Nombre
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If
        Me.Close()
    End Sub

    Private Sub BtnAddCueFactura3_Click(sender As Object, e As EventArgs) Handles BtnAddCueFactura3.Click
        If DataGridViewEscuelas.RowCount > 0 Then
            miescuela.IdCue = DataGridViewEscuelas.SelectedCells(0).Value
            miescuela.Nombre = DataGridViewEscuelas.SelectedCells(2).Value
            Me.DialogResult = Windows.Forms.DialogResult.OK
            FrmBusquedaFacturasDesdeHasta.CBCUE3.Text = miescuela.IdCue
            FrmBusquedaFacturasDesdeHasta.LblCue.Text = miescuela.Nombre
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If
        Me.Close()
    End Sub

End Class