Public Class FrmAnulaFactura

    Dim dtMitabla As New DataTable
    Dim dtMitabla2 As New DataTable
    Dim anularmiFactura As New ClassFactura
    Dim miConeccion As New GestionMySQL
    Dim tabla As New DataTable

    Private Sub FrmAnulaFactura_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        TxtProveedor.Text = Global_RazonSocialCliente
        LlenargridFactura()
    End Sub

    Private Sub LlenargridFactura()
        'conecto a base de datos
        Dim miGestionMySQL As New GestionMySQL
        'uso la funcion Consultartabla() de la claseGestionMySQL 
        'dtMitabla2 = miGestionMySQL.Anular_Factura_Detalle(Global_AnularFactura)
        'con el dt devuelto lleno el datagriedview
        DGVfacturas.DataSource = dtMitabla2

    End Sub

    Private Sub UpdateStock()
        Dim miFactura As New ClassFactura
        Dim miconexion As New GestionMySQL
        'Dim idVta As Integer

        'con este ciclo recorro el datagridview
        For Each row As DataGridViewRow In DGVfacturas.Rows
            '------TENGO QUE RESTAR LA CANTIDAD AL STOCK-->  Stock= stock - variable
            'idArticulo, Stock, StockMinimo
            Dim consultaMysql As String = ""
            consultaMysql = "Update stockarticulos SET "
            consultaMysql += "Stock = Stock +'" & row.Cells(0).Value & "' "
            consultaMysql += "WHERE idArticulo = '" & row.Cells(1).Value & "'; "
            Try
                miconexion.EjecutarSQL(consultaMysql)
                'MsgBox(consultaMysql)
                'MsgBox("Registro Guardado", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try
            '-----------------------------------------------------
        Next
        miconexion.Dispose()
        miconexion.Dispose()
        MsgBox("Registro Guardado", MsgBoxStyle.Information)


    End Sub

    Private Sub BtnAnularFactura_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtnAnularFactura.Click
        Dim resultado As DialogResult = MessageBox.Show("Está seguro de ANULAR LA Factura?", "Atención Anulación de Factura", MessageBoxButtons.YesNo)
        Dim miGestionMySQLClienteFactura As New GestionMySQL
        Dim miGestionMySQLFacturaArticulo As New GestionMySQL
        Dim miGestionMySQLFacturas As New GestionMySQL
        Dim sql As String = ""
        Dim sql1 As String = ""
        Dim sql2 As String = ""
        If resultado = Windows.Forms.DialogResult.Yes Then
            If DGVfacturas.RowCount > 0 Then
                'actualizamos stock
                UpdateStock()
                anularmiFactura.IdFactura = lblNumeroPedido.Text
                anularmiFactura.Monto = TxtTotal.Text
                Me.DialogResult = Windows.Forms.DialogResult.OK
                MsgBox("ANULAR Factura N°: " & anularmiFactura.IdFactura & vbNewLine &
                       "Total: $" & anularmiFactura.Monto)
                '---------------------------------------------------------------
                Try
                    sql = "DELETE FROM FacturaArticulos "
                    sql += "Where idFactura =" & anularmiFactura.IdFactura
                    miGestionMySQLFacturaArticulo.EjecutarSQL(sql)
                    miGestionMySQLFacturaArticulo.Dispose()
                    'MsgBox("Los Datos fueron eliminados de Base de Datos", MsgBoxStyle.Information, "Anular Factura Articulos")
                Catch ex As Exception
                    MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error Factura articulo")
                End Try
                '--- ---- ---- ---- --- ---- ---- ---- ---- ---- --- 
                Try
                    sql1 = "DELETE FROM ClienteFactura "
                    sql1 += "Where idFactura =" & anularmiFactura.IdFactura
                    miGestionMySQLClienteFactura.EjecutarSQL(sql1)
                    miGestionMySQLClienteFactura.Dispose()
                    'MsgBox("Los Datos fueron eliminados de Base de Datos", MsgBoxStyle.Information, "Anular Factura Cliente")
                Catch ex As Exception
                    MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error Cliente Factura")
                End Try
                '--- ---- ---- ---- --- ---- ---- ---- ---- ---- --- 
                Try
                    sql2 = "DELETE FROM Facturas "
                    sql2 += "Where idFacturas =" & anularmiFactura.IdFactura
                    miGestionMySQLFacturas.EjecutarSQL(sql2)
                    miGestionMySQLFacturas.Dispose()
                    MsgBox("Los Datos fueron eliminados de Base de Datos", MsgBoxStyle.Information, "Anular Factura")
                Catch ex As Exception
                    MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Error Anular Factura")
                End Try
                '---------------------------------------------------------------
                'frmCaja.MdiParent = MDIMenu
                'frmCaja.Show()
                'frmCaja.TxtImporte.Text = anularmiFactura.Importe
                'frmCaja.ComboBoxComprobante.Text = "No valido como factura"
                'frmCaja.TxtDescripcion.Text = "Factura-ANULADA"
                'frmCaja.Txtnumero.Text = anularmiFactura.IdFactura
                'frmCaja.BtnSALIDA.PerformClick()
                'frmCaja.BtnRegistrar.PerformClick()
            Else
                Me.DialogResult = Windows.Forms.DialogResult.Ignore
                MsgBox("Seleccione una Factura para ANULAR")
            End If
            Me.Close()
        End If
    End Sub

    Private Sub TxtRazonSocial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtProveedor.TextChanged
        'uso funcion para buscar en tabla , columna y campo que return un Datatable 
        tabla = miConeccion.BuscarenTablaEscribo("vistaFactura", "RazonSocial", TxtProveedor.Text)
        DGVfacturas.DataSource = tabla
        miConeccion.Dispose()
    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

End Class