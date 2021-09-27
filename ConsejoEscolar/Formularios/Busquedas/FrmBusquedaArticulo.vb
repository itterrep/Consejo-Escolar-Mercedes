Public Class FrmBusquedaPersonas

    Dim dt As New DataTable
    Dim tabla As New DataTable
    Dim miDirector As New ClassDirector
    Dim miSecretario As New ClassSecretario
    Dim miAuxiliar As New ClassAuxiliar
    'conecto a base de datos
    Dim miGestionMySQL As New GestionMySQL

    Private Sub FrmBusquedaProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'recargar()
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        recargar()
    End Sub

    Private Sub Recargar()
        Dim Sql As String = LblTitulo.Text
        dt = miGestionMySQL.ConsultarTabla(Sql)
        DataGridViewPersonas.DataSource = dt
        DataGridViewPersonas.Columns(0).HeaderText = "Codigo"
        'cierro conexion
        miGestionMySQL.Dispose()
    End Sub

    Private Sub TxtPersonas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPersonas.TextChanged
        'uso funcion para buscar en tabla , columna y campo que return un Datatable 
        tabla = miGestionMySQL.Consulta(LblTitulo.Text)
        DataGridViewPersonas.DataSource = tabla
        'cierro conexion
        miGestionMySQL.Dispose()
    End Sub

    Private Sub BtnCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddDirector.Click

        If DataGridViewPersonas.RowCount > 0 Then
            If IsDBNull(DataGridViewPersonas.SelectedCells(0).Value) Then
                miDirector.IdDirector = ""
            Else
                miDirector.IdDirector = DataGridViewPersonas.SelectedCells(0).Value
            End If
            If IsDBNull(DataGridViewPersonas.SelectedCells(1).Value) Then
                miDirector.Nombre = ""
            Else
                miDirector.Nombre = DataGridViewPersonas.SelectedCells(1).Value
            End If
            If IsDBNull(DataGridViewPersonas.SelectedCells(2).Value) Then
                miDirector.Apellido = ""
            Else
                miDirector.Apellido = DataGridViewPersonas.SelectedCells(2).Value
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
            FrmCargaCargos.TxtDniDirector.Text = miDirector.IdDirector
            FrmCargaCargos.TxtNombreDirector.Text = miDirector.Nombre
            FrmCargaCargos.TxtApellidoDirector.Text = miDirector.Apellido
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If
        Me.Close()
    End Sub


    Private Sub BtnAddSecretario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddSecretario.Click
        If DataGridViewPersonas.RowCount > 0 Then
            If IsDBNull(DataGridViewPersonas.SelectedCells(0).Value) Then
                miSecretario.IdSecretario = ""
            Else
                miSecretario.IdSecretario = DataGridViewPersonas.SelectedCells(0).Value
            End If
            If IsDBNull(DataGridViewPersonas.SelectedCells(1).Value) Then
                miSecretario.Nombre = ""
            Else
                miSecretario.Nombre = DataGridViewPersonas.SelectedCells(1).Value
            End If
            If IsDBNull(DataGridViewPersonas.SelectedCells(2).Value) Then
                miSecretario.Apellido = ""
            Else
                miSecretario.Apellido = DataGridViewPersonas.SelectedCells(2).Value
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
            FrmCargaCargos.TxtDniSecretario.Text = miSecretario.IdSecretario
            FrmCargaCargos.TxtNombreSecretario.Text = miSecretario.Nombre
            FrmCargaCargos.TxtApellidoSecretario.Text = miSecretario.Apellido
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If
        Me.Close()
    End Sub

    Private Sub BtnAddAuxiliar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddAuxiliar.Click
        If DataGridViewPersonas.RowCount > 0 Then
            If IsDBNull(DataGridViewPersonas.SelectedCells(0).Value) Then
                miAuxiliar.IdAuxiliar = ""
            Else
                miAuxiliar.IdAuxiliar = DataGridViewPersonas.SelectedCells(0).Value
            End If
            If IsDBNull(DataGridViewPersonas.SelectedCells(1).Value) Then
                miAuxiliar.Nombre = ""
            Else
                miAuxiliar.Nombre = DataGridViewPersonas.SelectedCells(1).Value
            End If
            If IsDBNull(DataGridViewPersonas.SelectedCells(2).Value) Then
                miAuxiliar.Apellido = ""
            Else
                miAuxiliar.Apellido = DataGridViewPersonas.SelectedCells(2).Value
            End If
            Me.DialogResult = Windows.Forms.DialogResult.OK
            FrmCargaCargos.TxtDniAuxiliar.Text = miAuxiliar.IdAuxiliar
            FrmCargaCargos.TxtNombreauxiliar.Text = miAuxiliar.Nombre
            FrmCargaCargos.TxtApellidoAuxiliar.Text = miAuxiliar.Apellido
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If
        Me.Close()
    End Sub

End Class