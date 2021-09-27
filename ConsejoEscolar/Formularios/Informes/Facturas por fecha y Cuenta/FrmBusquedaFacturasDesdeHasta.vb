Public Class FrmBusquedaFacturasDesdeHasta
    Public value As String
    Public cuenta As String = "%C%"

    Private Sub FrmDesdeHasta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Inicio()
    End Sub

    Private Sub BtnActualizar_Click(sender As Object, e As EventArgs) Handles BtnActualizar.Click
        Inicio()
    End Sub

    Private Sub Inicio()
        InHabilitarCB()
        BlanqueoFecha()
        CheckBAll.Checked = True
        DGVfacturas.DataSource = Nothing
        TxtTotal.Text = ""
        CBCuenta.SelectedItem = "Todas"
        BtnFacturasXfecha.Enabled = False
        BtnFacturasXfecha.Visible = True
    End Sub

    Private Sub BlanqueoFecha()
        DTPdesde.Value = Today
        DTPhasta.Value = Today
    End Sub

    Private Sub InHabilitarCB()
        CBCUE.Enabled = False
        CBRubro.Enabled = False
        CBProveedor.Enabled = False
        CBCUE2.Enabled = False
        CBCUE3.Enabled = False
        CBRubro2.Enabled = False
        CBProveedor2.Enabled = False
        CBCUE.Text = ""
        CBRubro.Text = ""
        CBProveedor.Text = ""
        CBCUE2.Text = ""
        CBCUE3.Text = ""
        CBRubro2.Text = ""
        CBProveedor2.Text = ""
        BtnAddCue1.Enabled = False
        BtnAddCue2.Enabled = False
        BtnAddCue3.Enabled = False
        BlanqueoFecha()
    End Sub

    Private Sub Clear()
        TxtTotal.Clear()
        LblNombescuela.Text = ""
        BtnImprirFacturasXCue.Visible = False
        BtnImprirFacturasXCueRubro.Visible = False
        BtnInfCaja.Visible = True
        BtnFacturasXfecha.Enabled = False
        BtnImprirFacturasXCue.Enabled = False
        BtnImprirFacturasXRubro.Enabled = False
        BtnImprirFacturasXProveedor.Enabled = False
        BtnImprirFacturasXCueRubro.Enabled = False
        BtnImprirFacturasXCueProveedor.Enabled = False
        InHabilitarCB()

    End Sub

    'Selecciono que cuenta voy a consultar

    Private Sub CBCuenta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBCuenta.SelectedIndexChanged
        If CBCuenta.SelectedItem = "Todas" Then
            cuenta = "%C%"
        Else
            If CBCuenta.SelectedItem = "Compensador" Then
                cuenta = "Compensador"
            End If
            If CBCuenta.SelectedItem = "CUFP" Then
                cuenta = "CUFP"
            End If
        End If

    End Sub

    'Controlo el panel de seleccion de datos

    Private Sub CheckBAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBAll.CheckedChanged
        If CheckBAll.Checked = True Then
            CheckBCue.Checked = False
            CheckBRubro.Checked = False
            CheckBProveedor.Checked = False
            CheckBCueyRubro.Checked = False
            CheckBCueyProveedor.Checked = False
            InHabilitarCB()
            BtnFacturasXfecha.Visible = True
            BtnImprirFacturasXCue.Visible = False
            BtnImprirFacturasXRubro.Visible = False
            BtnImprirFacturasXProveedor.Visible = False
            BtnImprirFacturasXCueRubro.Visible = False
            BtnImprirFacturasXCueProveedor.Visible = False
            value = "All"
        Else
            Clear()
        End If
    End Sub

    Private Sub CheckBCue_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBCue.CheckedChanged
        If CheckBCue.Checked = True Then
            CheckBAll.Checked = False
            CheckBRubro.Checked = False
            CheckBProveedor.Checked = False
            CheckBCueyRubro.Checked = False
            CheckBCueyProveedor.Checked = False
            InHabilitarCB()
            BtnFacturasXfecha.Visible = False
            BtnImprirFacturasXCue.Visible = True
            BtnImprirFacturasXRubro.Visible = False
            BtnImprirFacturasXProveedor.Visible = False
            BtnImprirFacturasXCueRubro.Visible = False
            BtnImprirFacturasXCueProveedor.Visible = False
            CBCUE.Enabled = True
            LlenoCBCue("Escuela", "Cue", "Cue")
            value = "Cue"
            BtnAddCue1.Enabled = True
        Else
            Clear()
        End If
    End Sub

    Private Sub CheckBRubro_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBRubro.CheckedChanged

        If CheckBRubro.Checked = True Then
            CheckBAll.Checked = False
            CheckBCue.Checked = False
            CheckBProveedor.Checked = False
            CheckBCueyRubro.Checked = False
            CheckBCueyProveedor.Checked = False
            InHabilitarCB()
            BtnFacturasXfecha.Visible = False
            BtnImprirFacturasXCue.Visible = False
            BtnImprirFacturasXRubro.Visible = True
            BtnImprirFacturasXProveedor.Visible = False
            BtnImprirFacturasXCueRubro.Visible = False
            BtnImprirFacturasXCueProveedor.Visible = False
            CBRubro.Enabled = True
            LlenoCBRubro("Rubro", "Rubro", "Rubro")
            value = "Rubro"
        Else
            Clear()
        End If

    End Sub

    Private Sub CheckBProveedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBProveedor.CheckedChanged
        If CheckBProveedor.Checked = True Then
            CheckBAll.Checked = False
            CheckBCue.Checked = False
            CheckBRubro.Checked = False
            CheckBCueyRubro.Checked = False
            CheckBCueyProveedor.Checked = False
            InHabilitarCB()
            BtnFacturasXfecha.Visible = False
            BtnImprirFacturasXCue.Visible = False
            BtnImprirFacturasXRubro.Visible = False
            BtnImprirFacturasXProveedor.Visible = True
            BtnImprirFacturasXCueRubro.Visible = False
            BtnImprirFacturasXCueProveedor.Visible = False
            CBProveedor.Enabled = True
            LlenoCBProveedor("Proveedores", "RazonSocial", "RazonSocial")
            value = "Proveedor"
        Else
            Clear()
        End If
    End Sub

    Private Sub CheckBCueyRubro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBCueyRubro.CheckedChanged
        If CheckBCueyRubro.Checked = True Then
            CheckBAll.Checked = False
            CheckBCue.Checked = False
            CheckBRubro.Checked = False
            CheckBProveedor.Checked = False
            CheckBCueyProveedor.Checked = False
            InHabilitarCB()
            BtnFacturasXfecha.Visible = False
            BtnImprirFacturasXCue.Visible = False
            BtnImprirFacturasXRubro.Visible = False
            BtnImprirFacturasXProveedor.Visible = False
            BtnImprirFacturasXCueRubro.Visible = True
            BtnImprirFacturasXCueProveedor.Visible = False
            CBCUE2.Enabled = True
            CBRubro2.Enabled = True
            LlenoCBRubro2("Rubro", "Rubro", "Rubro")
            LlenoCBCue2("Escuela", "Cue", "Cue")
            value = "CueRubro"
            BtnAddCue2.Enabled = True
        Else
            Clear()
        End If
    End Sub

    Private Sub CheckBCueyProveedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBCueyProveedor.CheckedChanged
        If CheckBCueyProveedor.Checked = True Then
            CheckBAll.Checked = False
            CheckBCue.Checked = False
            CheckBRubro.Checked = False
            CheckBProveedor.Checked = False
            CheckBCueyRubro.Checked = False
            InHabilitarCB()
            BtnFacturasXfecha.Visible = False
            BtnImprirFacturasXCue.Visible = False
            BtnImprirFacturasXRubro.Visible = False
            BtnImprirFacturasXProveedor.Visible = False
            BtnImprirFacturasXCueRubro.Visible = False
            BtnImprirFacturasXCueProveedor.Visible = True
            CBCUE3.Enabled = True
            CBProveedor2.Enabled = True
            LlenoCBCue3("Escuela", "Cue", "Cue")
            LlenoCBProveedor2("Proveedores", "RazonSocial", "RazonSocial")
            value = "CueProveedor"
            BtnAddCue3.Enabled = True
        Else
            Clear()
        End If
    End Sub

    'Lleno ComboBox

    Private Sub LlenoCBRubro(ByVal tabla As String, ByVal display As String, ByVal value As String)
        Dim miGestionMySQLcomedor As New GestionMySQL
        Dim dt As DataTable
        dt = miGestionMySQLcomedor.ConsultarTabla("rubro")
        With CBRubro
            .DataSource = dt                   ' DataSource = DataTable
            .DisplayMember = display           ' DisplayMember = "Nombre" Nombre del campo que quieres que muestre el combo.
            .ValueMember = value               ' ValueMembes = "ID" Nombre de campo que utilizaras como identificador
        End With
        miGestionMySQLcomedor.Dispose()
    End Sub

    Private Sub LlenoCBRubro2(ByVal tabla As String, ByVal display As String, ByVal value As String)
        Dim miGestionMySQLcomedor As New GestionMySQL
        Dim dt As DataTable
        dt = miGestionMySQLcomedor.ConsultarTablaLLenoCB("rubro", "rubro")
        With CBRubro2
            .DataSource = dt                   ' DataSource = DataTable
            .DisplayMember = display           ' DisplayMember = "Nombre" Nombre del campo que quieres que muestre el combo.
            .ValueMember = value               ' ValueMembes = "ID" Nombre de campo que utilizaras como identificador
        End With
        miGestionMySQLcomedor.Dispose()
    End Sub

    Private Sub LlenoCBProveedor(ByVal tabla As String, ByVal display As String, ByVal value As String)
        Dim miGestionMySQLcomedor As New GestionMySQL
        Dim dt As DataTable
        dt = miGestionMySQLcomedor.ConsultarTablaLLenoCB("proveedores", "RazonSocial")
        With CBProveedor
            .DataSource = dt                   ' DataSource = DataTable
            .DisplayMember = display           ' DisplayMember = "Nombre" Nombre del campo que quieres que muestre el combo.
            .ValueMember = value               ' ValueMembes = "ID" Nombre de campo que utilizaras como identificador
        End With
        miGestionMySQLcomedor.Dispose()
    End Sub

    Private Sub LlenoCBProveedor2(ByVal tabla As String, ByVal display As String, ByVal value As String)
        Dim miGestionMySQLcomedor As New GestionMySQL
        Dim dt As DataTable
        dt = miGestionMySQLcomedor.ConsultarTablaLLenoCB("proveedores", "RazonSocial")
        With CBProveedor2
            .DataSource = dt                   ' DataSource = DataTable
            .DisplayMember = display           ' DisplayMember = "Nombre" Nombre del campo que quieres que muestre el combo.
            .ValueMember = value               ' ValueMembes = "ID" Nombre de campo que utilizaras como identificador
        End With
        miGestionMySQLcomedor.Dispose()
    End Sub

    Private Sub LlenoCBCue(ByVal tabla As String, ByVal display As String, ByVal value As String)
        Dim miGestionMySQLcomedor As New GestionMySQL
        Dim dt As DataTable
        dt = miGestionMySQLcomedor.ConsultarTabla("escuela")
        With CBCUE
            .DataSource = dt                   ' DataSource = DataTable
            .DisplayMember = display           ' DisplayMember = "Nombre" Nombre del campo que quieres que muestre el combo.
            .ValueMember = value               ' ValueMembes = "ID" Nombre de campo que utilizaras como identificador
        End With
        miGestionMySQLcomedor.Dispose()
    End Sub

    Private Sub LlenoCBCue2(ByVal tabla As String, ByVal display As String, ByVal value As String)
        Dim miGestionMySQLcomedor As New GestionMySQL
        Dim dt As DataTable
        dt = miGestionMySQLcomedor.ConsultarTabla("escuela")
        With CBCUE2
            .DataSource = dt                   ' DataSource = DataTable
            .DisplayMember = display           ' DisplayMember = "Nombre" Nombre del campo que quieres que muestre el combo.
            .ValueMember = value               ' ValueMembes = "ID" Nombre de campo que utilizaras como identificador
        End With
        miGestionMySQLcomedor.Dispose()
    End Sub

    Private Sub LlenoCBCue3(ByVal tabla As String, ByVal display As String, ByVal value As String)
        Dim miGestionMySQLcomedor As New GestionMySQL
        Dim dt As DataTable
        dt = miGestionMySQLcomedor.ConsultarTabla("escuela")
        With CBCUE3
            .DataSource = dt                   ' DataSource = DataTable
            .DisplayMember = display           ' DisplayMember = "Nombre" Nombre del campo que quieres que muestre el combo.
            .ValueMember = value               ' ValueMembes = "ID" Nombre de campo que utilizaras como identificador
        End With
        miGestionMySQLcomedor.Dispose()
    End Sub

    'Valido que el rango de fechas sea correcto

    Private Sub DTPhasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPhasta.ValueChanged
        If DTPdesde.Value > DTPhasta.Value Then
            MsgBox("El rango de fechas seleccionadas no es correcto")
        End If
    End Sub

    Private Sub DTPdesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTPdesde.ValueChanged
        If DTPdesde.Value > DTPhasta.Value Then
            MsgBox("El rango de fechas seleccionadas no es correcto")
        End If
    End Sub

    'Busco y lleno del datagrid

    Private Sub BtnInfCaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnInfCaja.Click
        Dim desde As Date = DTPdesde.Value
        Dim hasta As Date = DTPhasta.Value
        Dim cue As String = ""
        Dim rubro As String = ""
        Dim proveedor As String = ""

        Select Case value
            Case "All"
                Llenargrid("get_facturaxfechaAll(STR_TO_DATE('" & desde & "','%d/%m/%Y'), STR_TO_DATE('" & hasta & "','%d/%m/%Y'),'" & cuenta & "')")
                BtnFacturasXfecha.Enabled = True
            Case "Cue"
                cue = CBCUE.Text
                Llenargrid("get_facturaxfechaCue(STR_TO_DATE('" & desde & "','%d/%m/%Y'), STR_TO_DATE('" & hasta & "','%d/%m/%Y'), '" & cue & "','" & cuenta & "')")
                BtnImprirFacturasXCue.Enabled = True
            Case "Proveedor"
                proveedor = CBProveedor.Text
                Llenargrid("get_facturaxfechaProveedor(STR_TO_DATE('" & desde & "','%d/%m/%Y'), STR_TO_DATE('" & hasta & "','%d/%m/%Y'), '" & proveedor & "','" & cuenta & "')")
                BtnImprirFacturasXProveedor.Enabled = True
            Case "Rubro"
                rubro = CBRubro.Text
                Llenargrid("get_facturaxfechaRubro(STR_TO_DATE('" & desde & "','%d/%m/%Y'), STR_TO_DATE('" & hasta & "','%d/%m/%Y'), '" & rubro & "','" & cuenta & "')")
                BtnImprirFacturasXRubro.Enabled = True
            Case "CueRubro"
                cue = CBCUE2.Text
                rubro = CBRubro2.Text
                Llenargrid("get_facturaxfechaCueRubro(STR_TO_DATE('" & desde & "','%d/%m/%Y'), STR_TO_DATE('" & hasta & "','%d/%m/%Y'), '" & cue & "','" & rubro & "','" & cuenta & "')")
                BtnImprirFacturasXCueRubro.Enabled = True
            Case "CueProveedor"
                cue = CBCUE3.Text
                proveedor = CBProveedor2.Text
                Llenargrid("get_facturaxfechaCueProveedor(STR_TO_DATE('" & desde & "','%d/%m/%Y'), STR_TO_DATE('" & hasta & "','%d/%m/%Y'), '" & cue & "','" & proveedor & "','" & cuenta & "')")
                BtnImprirFacturasXCueProveedor.Enabled = True
        End Select
        GlobalDesdeFacturaXCue = desde
        GlobalHastaFacturaXCue = hasta
        GlobalCue = cue
        GlobalNombEscuela = LblNombescuela.Text
        GlobalRubro = rubro
        GlobalProveedor = proveedor
        Sumacolumnadatagrid()

        If CBCuenta.Text = "Todas" Then
            GlobalTCuentaTitulo = "Compensador y CUFP"
        ElseIf CBCuenta.Text = "Compensador" Then
            GlobalTCuentaTitulo = "Compensador"
        ElseIf CBCuenta.Text = "CUFP" Then
            GlobalTCuentaTitulo = "CUFP"
        Else
            GlobalTCuentaTitulo = ""
        End If

        GlobalFacturado = TxtTotal.Text

        'T1 = "Informe de facturas desde: " & desde & " Hasta: " & hasta & " de Cuenta: " & TCuenta


    End Sub

    Private Sub Llenargrid(ByVal vista As String)
        Dim dtMitabla As New DataTable
        'conecto a base de datos
        Dim miGestionMySQL As New GestionMySQL
        'uso la funcion Consultartabla() de la claseGestionMySQL 
        dtMitabla = miGestionMySQL.ConsultarProcedimiento(vista)
        'con el dt devuelto lleno el datagriedview
        DGVfacturas.DataSource = dtMitabla
    End Sub

    Private Sub CBCUE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBCUE.SelectedIndexChanged
        Dim dtMitabla As New DataTable
        'conecto a base de datos
        Dim miGestionMySQL As New GestionMySQL
        'uso la funcion Consultartabla() de la claseGestionMySQL 
        dtMitabla = miGestionMySQL.ConsultarNombreEscuela(CBCUE.Text)
        For Each MiDataRow As DataRow In dtMitabla.Rows
            LblNombescuela.Text = MiDataRow("nombre")
            miGestionMySQL.Dispose()
        Next
    End Sub

    Private Sub CBCUE2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBCUE2.SelectedIndexChanged
        Dim dtMitabla As New DataTable
        'conecto a base de datos
        Dim miGestionMySQL As New GestionMySQL
        'uso la funcion Consultartabla() de la claseGestionMySQL 
        dtMitabla = miGestionMySQL.ConsultarNombreEscuela(CBCUE2.Text)
        For Each MiDataRow As DataRow In dtMitabla.Rows
            LblNombescuela.Text = MiDataRow("nombre")
        Next
        miGestionMySQL.Dispose()
    End Sub

    Private Sub CBCUE3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBCUE3.SelectedIndexChanged
        Dim dtMitabla As New DataTable
        'conecto a base de datos
        Dim miGestionMySQL As New GestionMySQL
        'uso la funcion Consultartabla() de la claseGestionMySQL 
        dtMitabla = miGestionMySQL.ConsultarNombreEscuela(CBCUE3.Text)
        For Each MiDataRow As DataRow In dtMitabla.Rows
            LblNombescuela.Text = MiDataRow("nombre")
        Next
        miGestionMySQL.Dispose()
    End Sub

    Private Sub Sumacolumnadatagrid()
        Try
            Dim Total As Double = 0
            Dim Col As DataGridViewRow = New DataGridViewRow()
            For Each Col In DGVfacturas.Rows
                Total += Convert.ToDouble(Col.Cells("Monto").Value)
            Next
            TxtTotal.Text = Total.ToString("C")
        Catch ex As Exception
        End Try
    End Sub

    'Botones

    Private Sub BtnFacturasXfecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFacturasXfecha.Click
        GlobalDesdeFacturaXFecha = DTPdesde.Value
        GlobalHastaFacturaXFecha = DTPhasta.Value
        GlobalTcuenta = CBCuenta.Text
        FrmInformeFacturasXfecha.MdiParent = MDIMenu
        FrmInformeFacturasXfecha.Show()
        BtnFacturasXfecha.Visible = False
        Inicio()
    End Sub

    Private Sub BtnImprirFacturasXCue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprirFacturasXCue.Click
        GlobalDesdeFacturaXFecha = DTPdesde.Value
        GlobalHastaFacturaXFecha = DTPhasta.Value
        GlobalTcuenta = CBCuenta.Text
        GlobalCue = CBCUE.Text
        GlobalNombreEscuela = LblNombescuela.Text
        FrmInformeFacturasXCue.MdiParent = MDIMenu
        FrmInformeFacturasXCue.Show()
        BtnImprirFacturasXCue.Visible = False
        Inicio()
    End Sub

    Private Sub BtnImprirFacturasXRubro_Click(sender As Object, e As EventArgs) Handles BtnImprirFacturasXRubro.Click
        GlobalDesdeFacturaXFecha = DTPdesde.Value
        GlobalHastaFacturaXFecha = DTPhasta.Value
        GlobalTcuenta = CBCuenta.Text
        GlobalRubro = CBRubro.Text
        FrmInformeFacturasXRubro.MdiParent = MDIMenu
        FrmInformeFacturasXRubro.Show()
        BtnImprirFacturasXRubro.Visible = False
        Inicio()
    End Sub

    Private Sub BtnImprirFacturasXProveedor_Click(sender As Object, e As EventArgs) Handles BtnImprirFacturasXProveedor.Click
        GlobalDesdeFacturaXFecha = DTPdesde.Value
        GlobalHastaFacturaXFecha = DTPhasta.Value
        GlobalTcuenta = CBCuenta.Text
        GlobalProveedor = CBProveedor.Text
        FrmInformeFacturasXProveedor.MdiParent = MDIMenu
        FrmInformeFacturasXProveedor.Show()
        BtnImprirFacturasXProveedor.Visible = False
        Inicio()
    End Sub

    Private Sub BtnImprirFacturasXCueRubro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnImprirFacturasXCueRubro.Click
        GlobalDesdeFacturaXFecha = DTPdesde.Value
        GlobalHastaFacturaXFecha = DTPhasta.Value
        GlobalTcuenta = CBCuenta.Text
        GlobalProveedor = CBCUE2.Text
        GlobalRubro = CBRubro2.Text
        FrmInformeFacturasXCueRubro.MdiParent = MDIMenu
        FrmInformeFacturasXCueRubro.Show()
        BtnImprirFacturasXCueRubro.Visible = False
        Inicio()
    End Sub

    Private Sub BtnImprirFacturasXCueProveedor_Click(sender As Object, e As EventArgs) Handles BtnImprirFacturasXCueProveedor.Click

        GlobalDesdeFacturaXFecha = DTPdesde.Value
        GlobalHastaFacturaXFecha = DTPhasta.Value
        GlobalRubro = CBCUE3.Text
        GlobalTcuenta = CBCuenta.Text
        GlobalProveedor = CBProveedor2.Text
        FrmInformeFacturasXCueProveedor.MdiParent = MDIMenu
        FrmInformeFacturasXCueProveedor.Show()
        BtnImprirFacturasXCueProveedor.Visible = False
        Inicio()
    End Sub

    Private Sub BtnAddCue1_Click(sender As Object, e As EventArgs) Handles BtnAddCue1.Click
        FrmBusquedaEscuelas.MdiParent = MDIMenu
        FrmBusquedaEscuelas.Show()
        FrmBusquedaEscuelas.BtnAddCueFactura1.Visible = True
    End Sub

    Private Sub BtnAddCue2_Click(sender As Object, e As EventArgs) Handles BtnAddCue2.Click
        FrmBusquedaEscuelas.MdiParent = MDIMenu
        FrmBusquedaEscuelas.Show()
        FrmBusquedaEscuelas.BtnAddCueFactura2.Visible = True
    End Sub

    Private Sub BtnAddCue3_Click(sender As Object, e As EventArgs) Handles BtnAddCue3.Click
        FrmBusquedaEscuelas.MdiParent = MDIMenu
        FrmBusquedaEscuelas.Show()
        FrmBusquedaEscuelas.BtnAddCueFactura3.Visible = True
    End Sub
End Class