Public Class FrmCargaFacturas
    Dim dtTabla As New DataTable
    Dim tabla As New DataTable
    Dim miCompra As New ClassCompra

    Private Sub FrmCompras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        inicio()
        TxtProveedor.Select()
        llenarComboxRubro("rubro", "Rubro", "Rubro")
    End Sub

    Private Sub Inicio()
        TxtProveedor.Select()
        DTFactura.Value = Today
        TxtProveedor.Text = 1
    End Sub

    Public Sub LlenarComboxRubro(ByVal tabla As String, ByVal display As String, ByVal value As String)
        Dim miGestionMySQLRubro As New GestionMySQL
        Dim dtRubros As New DataTable
        dtRubros = miGestionMySQLRubro.ConsultarTabla("rubro")
        With CBRubro
            .DataSource = dtRubros              ' DataSource = DataTable
            .DisplayMember = display           ' DisplayMember = "Nombre" Nombre del campo que quieres que muestre el combo.
            .ValueMember = value               ' ValueMembes = "ID" Nombre de campo que utilizaras como identificador
        End With
        miGestionMySQLRubro.Dispose()
    End Sub

    Private Sub BtnProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnProveedor.Click
        frmProveedores.MdiParent = MDIMenu
        frmProveedores.Show()
        frmProveedores.BtnAgregaProveedor.Visible = True
    End Sub

    Private Sub BtnAddRubro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddRubro.Click
        FrmRubro.MdiParent = MDIMenu
        FrmRubro.Show()
    End Sub

    Private Sub BtnAddCue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddCue.Click
        FrmBusquedaEscuelas.MdiParent = MDIMenu
        FrmBusquedaEscuelas.Show()
        FrmBusquedaEscuelas.btnCopiarEscuelas.Visible = True
    End Sub

    Private Sub BtnCargaFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCargaFactura.Click
        Dim MiConexion As New GestionMySQL
        Dim miFactura As New ClassFactura
        Dim sql As String
        'idFactura, Numero, Fecha, IdProveedor, Cue, Rubro, Monto
        miFactura.Numero = TxtNFactura.Text.Trim
        miFactura.Fecha = DTFactura.Value
        miFactura.IdProveedor = TxtProveedor.Text.Trim
        miFactura.cue = TxtCue.Text.Trim
        miFactura.Rubro = CBRubro.Text.Trim
        miFactura.Monto = TxtMonto.Text
        miFactura.Cuenta = CBCuenta.Text.Trim

        If TxtRazonSocial.Text IsNot "" And TxtNFactura.Text = "0" And TxtMonto.Text = "0" And TxtProveedor.Text IsNot "" And TxtNombre.Text IsNot "" Then
            MsgBox("Faltan datos para cargar la Factra")
        Else
            Try
                sql = "INSERT INTO Factura (Numero, Fecha, IdProveedor, Cue, Rubro, Monto,Cuenta) "
                sql += "VALUES ('" & miFactura.Numero & "', STR_TO_DATE('" & miFactura.Fecha & "','%d/%m/%Y'),"
                sql += "'" & miFactura.IdProveedor & "','" & miFactura.Cue & "','" & miFactura.Rubro & "'," & Replace(miFactura.Monto, ",", ".") & ",'" & miFactura.Cuenta & "')"
                'MsgBox(sql)
                MiConexion.EjecutarSQL(sql)
                MiConexion.Dispose()
                MsgBox("Registro Guardado", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox(ex.ToString, MsgBoxStyle.Critical)
            End Try

            Me.Close()
        End If
    End Sub

    Private Sub TxtMonto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMonto.KeyPress
        If ((e.KeyChar = "."c) OrElse (e.KeyChar = ","c)) Then
            ' Obtenemos el carácter separador decimal existente
            ' actualmente en la configuración regional de Windows.
            ' 
            e.KeyChar = _
                Threading.Thread.CurrentThread. _
                CurrentCulture.NumberFormat.NumberDecimalSeparator.Chars(0)
        End If
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

End Class