Public Class FrmBusquedaFacturas

    Dim dt As New DataTable
    Dim tabla As New DataTable
    Dim anularmiFactura As New ClassFactura
    Dim miConeccion As New GestionMySQL

    Private Sub FrmBusquedaProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicio()
    End Sub

    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        inicio()
    End Sub

    Private Sub Inicio()
        LlenarDatagrid()
        llenarComboxTareas("Rubro", "rubro", "rubro")
        CBTarea.Text = ""
    End Sub

    Private Sub Limpiar()
        TxtProveedor.Clear()
        TxtCue.Clear()
        CBTarea.Text = ""
    End Sub

    Private Sub LlenarDatagrid()
        dt = miConeccion.ConsultarTabla("vistaFactura")
        DGVfacturas.DataSource = dt
        DGVfacturas.Columns(0).HeaderText = "IdFactura"
        'cierro conexion
        miConeccion.Dispose()
    End Sub

    Private Sub TxtCue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtCue.TextChanged
        CBTarea.Text = ""
        TxtProveedor.Text = ""
        'uso funcion para buscar en tabla , columna y campo que return un Datatable 
        tabla = miConeccion.BuscarenTablaEscribo("vistaFactura", "cue", TxtCue.Text)
        DGVfacturas.DataSource = tabla
        'cierro conexion
        miConeccion.Dispose()
    End Sub

    Private Sub CBTarea_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CBTarea.TextChanged
        TxtProveedor.Text = ""
        TxtCue.Text = ""
        'uso funcion para buscar en tabla , columna y campo que return un Datatable 
        tabla = miConeccion.BuscarenTablaEscribo("vistaFactura", "Rubro", CBTarea.Text)
        DGVfacturas.DataSource = tabla
        'cierro conexion
        miConeccion.Dispose()
    End Sub

    Private Sub TxtAProveedor_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles TxtProveedor.TextChanged
        CBTarea.Text = ""
        TxtCue.Text = ""
        'uso funcion para buscar en tabla , columna y campo que return un Datatable 
        tabla = miConeccion.BuscarenTablaEscribo("vistaFactura", "RazonSocial", TxtProveedor.Text)
        DGVfacturas.DataSource = tabla
        miConeccion.Dispose()
    End Sub

    Public Sub LlenarComboxTareas(ByVal tabla As String, ByVal display As String, ByVal value As String)
        Dim miGestionMySQLcomedor As New GestionMySQL
        Dim dt As DataTable
        dt = miGestionMySQLcomedor.ConsultarTabla("Rubro")
        With CBTarea
            .DataSource = dt             ' DataSource = DataTable
            .DisplayMember = display           ' DisplayMember = "Nombre" Nombre del campo que quieres que muestre el combo.
            .ValueMember = value               ' ValueMembes = "ID" Nombre de campo que utilizaras como identificador
        End With
        miGestionMySQLcomedor.Dispose()
    End Sub

    Private Sub BtnAnularFactura_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnAnularFactura.Click
        Dim conexionAnular As New GestionMySQL
        If DGVfacturas.RowCount > 0 Then
            If IsDBNull(DGVfacturas.SelectedCells(0).Value) Then
                anularmiFactura.IdFactura = "0"
            Else
                anularmiFactura.IdFactura = DGVfacturas.SelectedCells(0).Value
                'MsgBox(anularmiFactura.IdFactura)
            End If
        End If
        Dim sql As String = ""
        If anularmiFactura.IdFactura = "0" Then
            MsgBox("Seleccione Factura para borrar")
        Else
            Dim resultado As DialogResult = MessageBox.Show("Está seguro de Eliminar?",
                                                    "Atención", MessageBoxButtons.YesNo)
            If resultado = Windows.Forms.DialogResult.Yes Then
                Try
                    sql = "DELETE FROM factura WHERE idfactura = " + Convert.ToString(anularmiFactura.IdFactura)
                    'MsgBox(sql)
                    conexionAnular.EjecutarSQL(sql)
                    conexionAnular.Dispose()
                    MsgBox("La factura fue borrada correctamente en la Base de Datos", MsgBoxStyle.Information, "Insertar Datos")
                Catch ex As Exception
                    MsgBox(ex.ToString, MsgBoxStyle.Critical)
                End Try
            End If
        End If
        limpiar()
        LlenarDatagrid()
        Inicio()
    End Sub

End Class