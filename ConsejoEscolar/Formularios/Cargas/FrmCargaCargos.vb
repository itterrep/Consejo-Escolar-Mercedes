Public Class FrmCargaCargos
    Dim dtMitabla As New DataTable
    Dim dtTabla As New DataTable
    Dim miDirector As New ClassDirector
    Dim miSecretario As New ClassSecretario
    Dim MiAuxiliar As New ClassAuxiliar
    Dim miConexion As New GestionMySQL

    Private Sub FrmCargaCargos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InicioDirector()
        InicioSecretario()
        InicioAuxiliar()
        llenargridDirector()
        llenargridSecretario()
        llenargridAuxiliar()
        LimpiarDirector()
        LimpiarSecretario()
        LimpiarAuxiliar()
    End Sub

    'inicios
    Private Sub InicioDirector()
        tsbtnAgregarDirector.Enabled = True
        tsbtnEditarDirector.Enabled = False
        tsbtnEliminarDirector.Enabled = False
        tsbtnGuardarDirector.Enabled = False
        tsbtnCancelarDirector.Enabled = True
        llenarComboxTurnoDirector("turno", "turno", "turno")
        llenarComboxSituacionRevistaDirector("SituacionRevista", "SituacionRevista", "SituacionRevista")
    End Sub

    Private Sub InicioSecretario()
        tsbtnAgregarSecretario.Enabled = True
        tsbtnEditarSecretario.Enabled = False
        tsbtnEliminarSecretario.Enabled = False
        tsbtnGuardarSecretario.Enabled = False
        tsbtnCancelarSecretario.Enabled = True
        llenarComboxTurnoSecretario("turno", "turno", "turno")
        llenarComboxSituacionRevistaSecretario("SituacionRevista", "SituacionRevista", "SituacionRevista")
    End Sub

    Private Sub InicioAuxiliar()
        tsbtnAgregarAuxiliar.Enabled = True
        tsbtnEditarAuxiliar.Enabled = False
        tsbtnEliminarAuxiliar.Enabled = False
        tsbtnGuardarAuxiliar.Enabled = False
        tsbtnCancelarAuxiliar.Enabled = True
        llenarComboxTurnoAuxiliar("turno", "turno", "turno")
        llenarComboxSituacionRevistaAuxiliar("SituacionRevista", "SituacionRevista", "SituacionRevista")
    End Sub

    'lleno combobox
    Public Sub LlenarComboxTurnoDirector(ByVal tabla As String, ByVal display As String, ByVal value As String)
        Dim miGestionMySQLcomedor As New GestionMySQL
        Dim dt As DataTable
        dt = miGestionMySQLcomedor.ConsultarTabla("Turno")
        With CBTurnoDirector
            .DataSource = dt             ' DataSource = DataTable
            .DisplayMember = display           ' DisplayMember = "Nombre" Nombre del campo que quieres que muestre el combo.
            .ValueMember = value               ' ValueMembes = "ID" Nombre de campo que utilizaras como identificador
        End With
        miGestionMySQLcomedor.Dispose()
    End Sub

    Public Sub LlenarComboxTurnoSecretario(ByVal tabla As String, ByVal display As String, ByVal value As String)
        Dim miGestionMySQLcomedor As New GestionMySQL
        Dim dt As DataTable
        dt = miGestionMySQLcomedor.ConsultarTabla("Turno")
        With CBTurnoSecretario
            .DataSource = dt             ' DataSource = DataTable
            .DisplayMember = display           ' DisplayMember = "Nombre" Nombre del campo que quieres que muestre el combo.
            .ValueMember = value               ' ValueMembes = "ID" Nombre de campo que utilizaras como identificador
        End With
        miGestionMySQLcomedor.Dispose()
    End Sub

    Public Sub LlenarComboxTurnoAuxiliar(ByVal tabla As String, ByVal display As String, ByVal value As String)
        Dim miGestionMySQLcomedor As New GestionMySQL
        Dim dt As DataTable
        dt = miGestionMySQLcomedor.ConsultarTabla("Turno")
        With CBTurnoAuxiliar
            .DataSource = dt             ' DataSource = DataTable
            .DisplayMember = display           ' DisplayMember = "Nombre" Nombre del campo que quieres que muestre el combo.
            .ValueMember = value               ' ValueMembes = "ID" Nombre de campo que utilizaras como identificador
        End With
        miGestionMySQLcomedor.Dispose()
    End Sub

    Public Sub LlenarComboxSituacionRevistaDirector(ByVal tabla As String, ByVal display As String, ByVal value As String)
        Dim miGestionMySQLcomedor As New GestionMySQL
        Dim dt As DataTable
        dt = miGestionMySQLcomedor.ConsultarTabla("SituacionRevista")
        With CBSituacionRevistaDirector
            .DataSource = dt             ' DataSource = DataTable
            .DisplayMember = display           ' DisplayMember = "Nombre" Nombre del campo que quieres que muestre el combo.
            .ValueMember = value               ' ValueMembes = "ID" Nombre de campo que utilizaras como identificador
        End With
        miGestionMySQLcomedor.Dispose()
    End Sub

    Public Sub LlenarComboxSituacionRevistaSecretario(ByVal tabla As String, ByVal display As String, ByVal value As String)
        Dim miGestionMySQLcomedor As New GestionMySQL
        Dim dt As DataTable
        dt = miGestionMySQLcomedor.ConsultarTabla("SituacionRevista")
        With CBSituacionRevistaSecretario
            .DataSource = dt             ' DataSource = DataTable
            .DisplayMember = display           ' DisplayMember = "Nombre" Nombre del campo que quieres que muestre el combo.
            .ValueMember = value               ' ValueMembes = "ID" Nombre de campo que utilizaras como identificador
        End With
        miGestionMySQLcomedor.Dispose()
    End Sub

    Public Sub LlenarComboxSituacionRevistaAuxiliar(ByVal tabla As String, ByVal display As String, ByVal value As String)
        Dim miGestionMySQLcomedor As New GestionMySQL
        Dim dt As DataTable
        dt = miGestionMySQLcomedor.ConsultarTabla("SituacionRevista")
        With CBSituacionRevistaAuxiliar
            .DataSource = dt             ' DataSource = DataTable
            .DisplayMember = display           ' DisplayMember = "Nombre" Nombre del campo que quieres que muestre el combo.
            .ValueMember = value               ' ValueMembes = "ID" Nombre de campo que utilizaras como identificador
        End With
        miGestionMySQLcomedor.Dispose()
    End Sub

    'lleno datagrids
    Private Sub LlenargridDirector()
        'conecto a base de datos
        Dim miGestionMySQL As New GestionMySQL
        'uso la funcion Consultartabla() de la claseGestionMySQL 
        dtMitabla = miGestionMySQL.ConsultarTabla("VistaDirectorEscuelaTurno")
        'con el dt devuelto lleno el datagriedview
        DGVDirector.DataSource = dtMitabla
    End Sub

    Private Sub LlenargridSecretario()
        'conecto a base de datos
        Dim miGestionMySQL As New GestionMySQL
        'uso la funcion Consultartabla() de la claseGestionMySQL 
        dtMitabla = miGestionMySQL.ConsultarTabla("VistaSecretarioEscuelaTurno")
        'con el dt devuelto lleno el datagriedview
        DGVSecretario.DataSource = dtMitabla
    End Sub

    Private Sub LlenargridAuxiliar()
        'conecto a base de datos
        Dim miGestionMySQL As New GestionMySQL
        'uso la funcion Consultartabla() de la claseGestionMySQL 
        dtMitabla = miGestionMySQL.ConsultarTabla("VistaAuxiliarEscuelaTurno")
        'con el dt devuelto lleno el datagriedview
        DGVAuxiliar.DataSource = dtMitabla
    End Sub

    'limpio
    Private Sub LimpiarDirector()
        TxtDniDirector.Clear()
        TxtNombreDirector.Clear()
        TxtApellidoDirector.Clear()
        TxtCueDirector.Clear()
        TxtNombreCueDirector.Clear()
        llenargridDirector()
    End Sub

    Private Sub LimpiarSecretario()
        TxtDniSecretario.Clear()
        TxtNombreSecretario.Clear()
        TxtApellidoSecretario.Clear()
        TxtCueSecretario.Clear()
        TxtNombreCueSecretario.Clear()
        llenargridSecretario()
    End Sub

    Private Sub LimpiarAuxiliar()
        TxtDniAuxiliar.Clear()
        TxtNombreauxiliar.Clear()
        TxtApellidoAuxiliar.Clear()
        TxtCueAuxiliar.Clear()
        TxtNombreCueAuxiliar.Clear()
        llenargridAuxiliar()
    End Sub

    'TSB's
    'TsbAdd
    Private Sub TsbtnDirector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnAgregarDirector.Click
        tsbtnGuardarDirector.Enabled = True
        tsbtnCancelarDirector.Enabled = True
        tsbtnEditarDirector.Enabled = False
        tsbtnEditarDirector.Enabled = False
        BtnAddDirector.Enabled = True
        BtnAddCueDirector.Enabled = True
        TxtDniDirector.Enabled = True
        TxtNombreDirector.Enabled = True
        TxtApellidoDirector.Enabled = True
        TxtCueDirector.Enabled = True
        TxtNombreCueDirector.Enabled = True
        CBTurnoDirector.Enabled = True
        CBSituacionRevistaDirector.Enabled = True
        HabilitaTXTDirector()
    End Sub

    Private Sub TsbtnSecretario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnAgregarSecretario.Click
        tsbtnGuardarSecretario.Enabled = True
        tsbtnCancelarSecretario.Enabled = True
        tsbtnEditarSecretario.Enabled = False
        tsbtnEditarSecretario.Enabled = False
        HabilitaTXTSecretario()
        BtnAddSecretario.Enabled = True
        BtnAddCueSecretario.Enabled = True
        TxtDniSecretario.Enabled = True
        TxtNombreSecretario.Enabled = True
        TxtApellidoSecretario.Enabled = True
        TxtCueSecretario.Enabled = True
        TxtNombreCueSecretario.Enabled = True
        CBTurnoSecretario.Enabled = True
        CBSituacionRevistaSecretario.Enabled = True
        HabilitaTXTSecretario()
    End Sub

    Private Sub TsbtnAuxiliar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnAgregarAuxiliar.Click
        tsbtnGuardarAuxiliar.Enabled = True
        tsbtnCancelarAuxiliar.Enabled = True
        tsbtnEditarAuxiliar.Enabled = False
        tsbtnEditarAuxiliar.Enabled = False
        HabilitaTXTAuxiliar()
        BtnAddAuxiliar.Enabled = True
        BtnAddCueAuxiliar.Enabled = True
        TxtDniAuxiliar.Enabled = True
        TxtNombreauxiliar.Enabled = True
        TxtApellidoAuxiliar.Enabled = True
        TxtCueAuxiliar.Enabled = True
        TxtNombreCueAuxiliar.Enabled = True
        CBTurnoAuxiliar.Enabled = True
        CBSituacionRevistaAuxiliar.Enabled = True
        HabilitaTXTAuxiliar()
    End Sub

    'TsbEdit
    Private Sub TsbtnEditarDirector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEditarDirector.Click
        tsbtnAgregarDirector.Enabled = False
        tsbtnEliminarDirector.Enabled = False
        tsbtnGuardarDirector.Enabled = True
        HabilitaTXTDirector()
    End Sub

    Private Sub TsbtnEditarSecretario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEditarSecretario.Click
        tsbtnAgregarSecretario.Enabled = False
        tsbtnEliminarSecretario.Enabled = False
        tsbtnGuardarSecretario.Enabled = True
        HabilitaTXTSecretario()
    End Sub

    Private Sub TsbtnEditarAuxiliar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEditarAuxiliar.Click
        tsbtnAgregarAuxiliar.Enabled = False
        tsbtnEliminarAuxiliar.Enabled = False
        tsbtnGuardarAuxiliar.Enabled = True
        HabilitaTXTAuxiliar()
    End Sub

    'TsbDell
    Private Sub TsbtnEliminarDirector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEliminarDirector.Click

    End Sub

    Private Sub TsbtnEliminarSecretario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEliminarSecretario.Click

    End Sub

    Private Sub TsbtnEliminarAuxiliar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEliminarAuxiliar.Click

    End Sub

    'TsbSave
    Private Sub TsbtnGuardarDirector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnGuardarDirector.Click
        If TxtNombreDirector.Text IsNot "" And TxtNombreCueDirector.Text IsNot "" And CBTurnoDirector.Text IsNot "" And CBSituacionRevistaDirector.Text IsNot "" Then
            Dim miGestionMySQL As New GestionMySQL
            Dim sql As String
            Dim miDirector As New ClassDirector
            miDirector.IdEscuelaPersonal = Convert.ToInt16(LblIdEsculaDirectivoD.Text.Trim)
            miDirector.Cue = Me.TxtCueDirector.Text.Trim
            miDirector.IdDirector = Me.TxtDniDirector.Text.Trim
            miDirector.Turno = Me.CBTurnoDirector.Text.Trim
            miDirector.SitRev = Me.CBSituacionRevistaDirector.Text.Trim
            If tsbtnAgregarDirector.Enabled = True And tsbtnEditarDirector.Enabled = False Then
                Try
                    'idEscueelaDirectivo, Cue, IdDirectivo, Turno, TipoDirectivo, SituacionRevista
                    sql = "INSERT INTO EscuelaPersonal (Cue, IdDirectivo, Turno, TipoDirectivo, SituacionRevista)"
                    sql += "VALUES ('" & miDirector.Cue & "','" & miDirector.IdDirector & "','" & miDirector.Turno & "', 'Director','" & miDirector.SitRev & "')"
                    'MsgBox(sql)
                    miGestionMySQL.EjecutarSQL(sql)
                    miGestionMySQL.Dispose()
                    MsgBox("Los Datos Insertados Correctamente en la Base de Datos", MsgBoxStyle.Information, "Insertar Datos")
                Catch ex As Exception
                    MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
                End Try
            End If
            If tsbtnAgregarDirector.Enabled = False And tsbtnEditarDirector.Enabled = True Then
                Try
                    sql = "Update EscuelaPersonal SET "
                    sql += "Cue = '" & miDirector.Cue & "', "
                    sql += "IdDirectivo = '" & miDirector.IdDirector & "', "
                    sql += "Turno = '" & miDirector.Turno & "', "
                    sql += "TipoDirectivo = 'Director', "
                    sql += "SituacionRevista = '" & miDirector.SitRev & "'  "
                    sql += "WHERE idEscuelaPersonal = '" & miDirector.IdEscuelaPersonal & "'; "
                    'MsgBox(sql)
                    miGestionMySQL.EjecutarSQL(sql)
                    miGestionMySQL.Dispose()
                    MsgBox("Los Datos Actualizados Correctamente en la Base de Datos", MsgBoxStyle.Information, "Actualizar Datos")
                Catch ex As Exception
                    MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Actualizar Datos")
                End Try
            End If
        Else
            MsgBox("Ingrese los datos " & vbNewLine & " del Director")
            BtnAddDirector.Select()
        End If
        LimpiarDirector()
        LlenargridDirector()
        InicioDirector()
    End Sub

    Private Sub TsbtnGuardarSecretario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnGuardarSecretario.Click
        If TxtNombreSecretario.Text IsNot "" And TxtNombreCueSecretario.Text IsNot "" And CBTurnoSecretario.Text IsNot "" And CBSituacionRevistaSecretario.Text IsNot "" Then
            Dim miGestionMySQL As New GestionMySQL
            Dim sql As String
            Dim miSecretario As New ClassSecretario
            miSecretario.IdEscuelaPersonal = Convert.ToInt16(LblIdEsculaDirectivoD.Text)
            miSecretario.Cue = Me.TxtCueSecretario.Text.Trim
            miSecretario.IdSecretario = Me.TxtDniSecretario.Text.Trim
            miSecretario.Turno = Me.CBTurnoSecretario.Text.Trim
            miSecretario.SitRev = Me.CBSituacionRevistaSecretario.Text.Trim
            If tsbtnAgregarSecretario.Enabled = True And tsbtnEditarSecretario.Enabled = False Then
                Try
                    'idEscueelaDirectivo, Cue, IdDirectivo, Turno, TipoDirectivo, SituacionRevista
                    sql = "INSERT INTO EscuelaPersonal (Cue, IdDirectivo, Turno, TipoDirectivo, SituacionRevista)"
                    sql += "VALUES ('" & miSecretario.Cue & "','" & miSecretario.IdSecretario & "','" & miSecretario.Turno & "', 'Secretario','" & miSecretario.SitRev & "')"
                    'MsgBox(sql)
                    miGestionMySQL.EjecutarSQL(sql)
                    miGestionMySQL.Dispose()
                    MsgBox("Los Datos Insertados Correctamente en la Base de Datos", MsgBoxStyle.Information, "Insertar Datos")
                Catch ex As Exception
                    MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
                End Try
            End If
            If tsbtnAgregarSecretario.Enabled = False And tsbtnEditarSecretario.Enabled = True Then
                Try
                    sql = "Update EscuelaPersonal SET "
                    sql += "Cue = '" & miSecretario.Cue & "', "
                    sql += "IdDirectivo = '" & miSecretario.IdSecretario & "', "
                    sql += "Turno = '" & miSecretario.Turno & "', "
                    sql += "TipoDirectivo = 'Secretario', "
                    sql += "SituacionRevista = '" & miSecretario.SitRev & "'  "
                    sql += "WHERE idEscuelaPersonal = '" & miSecretario.IdEscuelaPersonal & "'; "
                    'MsgBox(sql)
                    miGestionMySQL.EjecutarSQL(sql)
                    miGestionMySQL.Dispose()
                    MsgBox("Los Datos Actualizados Correctamente en la Base de Datos", MsgBoxStyle.Information, "Actualizar Datos")
                Catch ex As Exception
                    MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Actualizar Datos")
                End Try
            End If
        Else
            MsgBox("Ingrese los datos " & vbNewLine & " del Secretario")
            BtnAddSecretario.Select()
        End If
        LimpiarSecretario()
        LlenargridSecretario()
        InicioSecretario()
    End Sub

    Private Sub TsbtnGuardarAuxiliar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnGuardarAuxiliar.Click
        If TxtNombreauxiliar.Text IsNot "" And TxtNombreCueAuxiliar.Text IsNot "" And CBTurnoAuxiliar.Text IsNot "" And CBSituacionRevistaAuxiliar.Text IsNot "" Then
            Dim miGestionMySQL As New GestionMySQL
            Dim sql As String
            Dim miAuxiliar As New ClassAuxiliar
            miAuxiliar.IdEscuelaPersonal = Convert.ToInt16(LblIdEsculaDirectivoA.Text.Trim)
            miAuxiliar.Cue = Me.TxtCueAuxiliar.Text.Trim
            miAuxiliar.IdAuxiliar = Me.TxtDniAuxiliar.Text.Trim
            miAuxiliar.Turno = Me.CBTurnoAuxiliar.Text.Trim
            miAuxiliar.SitRev = Me.CBSituacionRevistaAuxiliar.Text.Trim
            If tsbtnAgregarAuxiliar.Enabled = True And tsbtnEditarAuxiliar.Enabled = False Then
                Try
                    'idEscueelaDirectivo, Cue, IdDirectivo, Turno, TipoDirectivo, SituacionRevista
                    sql = "INSERT INTO EscuelaPersonal (Cue, IdDirectivo, Turno, TipoDirectivo, SituacionRevista)"
                    sql += "VALUES ('" & miAuxiliar.Cue & "','" & miAuxiliar.IdAuxiliar & "','" & miAuxiliar.Turno & "', 'Auxiliar','" & miAuxiliar.SitRev & "')"
                    'MsgBox(sql)
                    miGestionMySQL.EjecutarSQL(sql)
                    miGestionMySQL.Dispose()
                    MsgBox("Los Datos Insertados Correctamente en la Base de Datos", MsgBoxStyle.Information, "Insertar Datos")
                Catch ex As Exception
                    MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
                End Try
            End If
            If tsbtnAgregarAuxiliar.Enabled = False And tsbtnEditarAuxiliar.Enabled = True Then
                Try
                    sql = "Update EscuelaPersonal SET "
                    sql += "Cue = '" & miAuxiliar.Cue & "', "
                    sql += "IdDirectivo = '" & miAuxiliar.IdAuxiliar & "', "
                    sql += "Turno = '" & miAuxiliar.Turno & "', "
                    sql += "TipoDirectivo = 'Auxiliar', "
                    sql += "SituacionRevista = '" & miAuxiliar.SitRev & "'  "
                    sql += "WHERE idEscuelaPersonal = '" & miAuxiliar.IdEscuelaPersonal & "'; "
                    'MsgBox(sql)
                    miGestionMySQL.EjecutarSQL(sql)
                    miGestionMySQL.Dispose()
                    MsgBox("Los Datos Actualizados Correctamente en la Base de Datos", MsgBoxStyle.Information, "Actualizar Datos")
                Catch ex As Exception
                    MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Actualizar Datos")
                End Try
            End If
        Else
            MsgBox("Ingrese los datos " & vbNewLine & " del Auxiliar")
            BtnAddAuxiliar.Select()
        End If
        LimpiarAuxiliar()
        LlenargridAuxiliar()
        InicioAuxiliar()
    End Sub

    'TsbCancel
    Private Sub TtsbtnCancelarDirector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnCancelarDirector.Click
        LimpiarDirector()
        InicioDirector()
        InhabilitaTXTDirector()
    End Sub

    Private Sub TsbtnCancelarSecretario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnCancelarSecretario.Click
        LimpiarSecretario()
        InicioSecretario()
        InhabilitaTXTSecretario()
    End Sub

    Private Sub TsbtnCancelarAuxiliar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnCancelarAuxiliar.Click
        LimpiarAuxiliar()
        InicioAuxiliar()
        InhabilitaTXTAuxiliar()
    End Sub

    'TsbSearch
    Private Sub TsbtnBuscarDirector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnBuscarDirector.Click
        MsgBox("Para buscar un Director escriba el N° DNI en el recuadro", MsgBoxStyle.Information)
        TxtDniDirector.BackColor = Color.White
        TxtDniDirector.ReadOnly = False
        TxtDniDirector.Focus()
    End Sub

    Private Sub TsbtnBuscarSecretario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnBuscarSecretario.Click
        MsgBox("Para buscar un Secretario escriba el N° DNI en el recuadro", MsgBoxStyle.Information)
        TxtDniSecretario.BackColor = Color.White
        TxtDniSecretario.ReadOnly = False
        TxtDniSecretario.Focus()
    End Sub

    Private Sub TsbtnBuscarAuxiliar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnBuscarAuxiliar.Click
        MsgBox("Para buscar un Auxiliar escriba el N° DNI en el recuadro", MsgBoxStyle.Information)
        TxtDniAuxiliar.BackColor = Color.White
        TxtDniAuxiliar.ReadOnly = False
        TxtDniAuxiliar.Focus()
    End Sub

    Private Sub TxtDniDirector_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDniDirector.TextChanged
        Dim tabla As New DataTable
        'conecto a base de datos
        Dim miGestionMySQL As New GestionMySQL
        'uso la funcion buscar de la claseGestionMySQL 
        tabla = miGestionMySQL.BuscarenTablaEscribo("VistaDirectorEscuelaTurno", "DNI", TxtDniDirector.Text)
        'con el dt devuelto lleno el datagriedview
        DGVDirector.DataSource = tabla
    End Sub

    Private Sub TxtDniSecretario_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDniSecretario.TextChanged
        Dim tabla As New DataTable
        'conecto a base de datos
        Dim miGestionMySQL As New GestionMySQL
        'uso la funcion buscar de la claseGestionMySQL 
        tabla = miGestionMySQL.BuscarenTablaEscribo("VistaSecretarioEscuelaTurno", "DNI", TxtDniSecretario.Text)
        'con el dt devuelto lleno el datagriedview
        DGVSecretario.DataSource = tabla
    End Sub

    Private Sub TxtDniAuxiliar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDniAuxiliar.TextChanged
        Dim tabla As New DataTable
        'conecto a base de datos
        Dim miGestionMySQL As New GestionMySQL
        'uso la funcion buscar de la claseGestionMySQL 
        tabla = miGestionMySQL.BuscarenTablaEscribo("VistaAuxiliarEscuelaTurno", "DNI", TxtDniAuxiliar.Text)
        'con el dt devuelto lleno el datagriedview
        DGVAuxiliar.DataSource = tabla
    End Sub

    'Inhabilitar
    Private Sub InhabilitaTXTDirector()
        TxtDniDirector.BackColor = Color.LightGreen
        TxtNombreDirector.BackColor = Color.LightGreen
        TxtApellidoDirector.BackColor = Color.LightGreen
        TxtCueDirector.BackColor = Color.LightGreen
        TxtNombreCueDirector.BackColor = Color.LightGreen
        CBTurnoDirector.BackColor = Color.LightGreen
        CBSituacionRevistaDirector.BackColor = Color.LightGreen

        BtnAddDirector.Enabled = False
        BtnAddCueDirector.Enabled = False
    End Sub

    Private Sub InhabilitaTXTSecretario()
        TxtDniSecretario.BackColor = Color.LightGreen
        TxtNombreSecretario.BackColor = Color.LightGreen
        TxtApellidoSecretario.BackColor = Color.LightGreen
        TxtCueSecretario.BackColor = Color.LightGreen
        TxtNombreCueSecretario.BackColor = Color.LightGreen
        CBTurnoSecretario.BackColor = Color.LightGreen
        CBSituacionRevistaSecretario.BackColor = Color.LightGreen

        BtnAddSecretario.Enabled = False
        BtnAddCueSecretario.Enabled = False
    End Sub

    Private Sub InhabilitaTXTAuxiliar()
        TxtDniAuxiliar.BackColor = Color.LightGreen
        TxtNombreauxiliar.BackColor = Color.LightGreen
        TxtApellidoAuxiliar.BackColor = Color.LightGreen
        TxtCueAuxiliar.BackColor = Color.LightGreen
        TxtNombreCueAuxiliar.BackColor = Color.LightGreen
        CBTurnoAuxiliar.BackColor = Color.LightGreen
        CBSituacionRevistaAuxiliar.BackColor = Color.LightGreen

        BtnAddAuxiliar.Enabled = False
        BtnAddCueAuxiliar.Enabled = False
    End Sub

    'Habilitar
    Private Sub HabilitaTXTDirector()
        TxtDniDirector.BackColor = Color.White
        TxtNombreDirector.BackColor = Color.White
        TxtApellidoDirector.BackColor = Color.White
        TxtCueDirector.BackColor = Color.White
        TxtNombreCueDirector.BackColor = Color.White
        CBTurnoDirector.BackColor = Color.White
        CBSituacionRevistaDirector.BackColor = Color.White

        BtnAddDirector.Enabled = True
        BtnAddCueDirector.Enabled = True
    End Sub

    Private Sub HabilitaTXTSecretario()
        TxtDniSecretario.BackColor = Color.White
        TxtNombreSecretario.BackColor = Color.White
        TxtApellidoSecretario.BackColor = Color.White
        TxtCueSecretario.BackColor = Color.White
        TxtNombreCueSecretario.BackColor = Color.White
        CBTurnoSecretario.BackColor = Color.White
        CBSituacionRevistaSecretario.BackColor = Color.White

        BtnAddSecretario.Enabled = True
        BtnAddCueSecretario.Enabled = True
    End Sub

    Private Sub HabilitaTXTAuxiliar()
        TxtDniAuxiliar.BackColor = Color.White
        TxtNombreauxiliar.BackColor = Color.White
        TxtApellidoAuxiliar.BackColor = Color.White
        TxtCueAuxiliar.BackColor = Color.White
        TxtNombreCueAuxiliar.BackColor = Color.White
        CBTurnoAuxiliar.BackColor = Color.White
        CBSituacionRevistaAuxiliar.BackColor = Color.White

        BtnAddAuxiliar.Enabled = True
        BtnAddCueAuxiliar.Enabled = True
    End Sub

    'botones add
    Private Sub BtnAddDirector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddDirector.Click
        FrmBusquedaPersonas.MdiParent = MDIMenu
        FrmBusquedaPersonas.Show()
        FrmBusquedaPersonas.LblTitulo.Text = "Director"
        FrmBusquedaPersonas.btnAddDirector.Visible = True
    End Sub

    Private Sub BtnAddCue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddCueDirector.Click
        FrmBusquedaEscuelas.MdiParent = MDIMenu
        FrmBusquedaEscuelas.Show()
        FrmBusquedaEscuelas.BtnAddCueDirector.Visible = True
    End Sub

    Private Sub BtnAddSecretario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddSecretario.Click
        FrmBusquedaPersonas.MdiParent = MDIMenu
        FrmBusquedaPersonas.Show()
        FrmBusquedaPersonas.LblTitulo.Text = "Secretario"
        FrmBusquedaPersonas.BtnAddSecretario.Visible = True
    End Sub

    Private Sub BtnAddCueSecretario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddCueSecretario.Click
        FrmBusquedaEscuelas.MdiParent = MDIMenu
        FrmBusquedaEscuelas.Show()
        FrmBusquedaEscuelas.BtnAddCueSecretario.Visible = True
    End Sub

    Private Sub BtnAddAuxiliar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddAuxiliar.Click
        FrmBusquedaPersonas.MdiParent = MDIMenu
        FrmBusquedaPersonas.Show()
        FrmBusquedaPersonas.LblTitulo.Text = "Auxiliar"
        FrmBusquedaPersonas.BtnAddAuxiliar.Visible = True
    End Sub

    Private Sub BtnAddCueAuxiliar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddCueAuxiliar.Click
        FrmBusquedaEscuelas.MdiParent = MDIMenu
        FrmBusquedaEscuelas.Show()
        FrmBusquedaEscuelas.BtnAddCueAuxiliar.Visible = True
    End Sub

    'Botones Copiar
    Private Sub BtnCopiarDirector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCopiarDirector.Click
        If DGVDirector.RowCount > 0 Then
            miDirector.IdEscuelaPersonal = DGVDirector.SelectedCells(0).Value

            If IsDBNull(DGVDirector.SelectedCells(1).Value) Then
                miDirector.IdDirector = ""
            Else
                miDirector.IdDirector = DGVDirector.SelectedCells(1).Value
            End If

            If IsDBNull(DGVDirector.SelectedCells(2).Value) Then
                miDirector.Nombre = ""
            Else
                miDirector.Nombre = DGVDirector.SelectedCells(2).Value
            End If

            If IsDBNull(DGVDirector.SelectedCells(3).Value) Then
                miDirector.Apellido = ""
            Else
                miDirector.Apellido = DGVDirector.SelectedCells(3).Value
            End If

            If IsDBNull(DGVDirector.SelectedCells(4).Value) Then
                miDirector.Cue = ""
            Else
                miDirector.Cue = DGVDirector.SelectedCells(4).Value
            End If
            If IsDBNull(DGVDirector.SelectedCells(5).Value) Then
                miDirector.NombreCue = ""
            Else
                miDirector.NombreCue = DGVDirector.SelectedCells(5).Value
            End If

            If IsDBNull(DGVDirector.SelectedCells(6).Value) Then
                miDirector.Turno = ""
            Else
                miDirector.Turno = DGVDirector.SelectedCells(6).Value
            End If

            If IsDBNull(DGVDirector.SelectedCells(7).Value) Then
                miDirector.Turno = ""
            Else
                miDirector.SitRev = DGVDirector.SelectedCells(7).Value
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK

            Me.LblIdEsculaDirectivoD.Text = miDirector.IdEscuelaPersonal
            Me.TxtDniDirector.Text = miDirector.IdDirector
            Me.TxtNombreDirector.Text = miDirector.Nombre
            Me.TxtApellidoDirector.Text = miDirector.Apellido
            Me.TxtCueDirector.Text = miDirector.Cue
            Me.TxtNombreCueDirector.Text = miDirector.NombreCue
            Me.CBTurnoDirector.Text = miDirector.Turno
            Me.CBSituacionRevistaDirector.Text = miDirector.SitRev
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If

        'tsbtnEliminarDirector.Enabled = True
        tsbtnEditarDirector.Enabled = True
        tsbtnAgregarDirector.Enabled = False
    End Sub

    Private Sub BtnCopiarSecretario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCopiarSecretario.Click

        If DGVSecretario.RowCount > 0 Then
            miSecretario.IdEscuelaPersonal = DGVSecretario.SelectedCells(0).Value

            If IsDBNull(DGVSecretario.SelectedCells(1).Value) Then
                miSecretario.IdSecretario = ""
            Else
                miSecretario.IdSecretario = DGVSecretario.SelectedCells(1).Value
            End If

            If IsDBNull(DGVSecretario.SelectedCells(2).Value) Then
                miSecretario.Nombre = ""
            Else
                miSecretario.Nombre = DGVSecretario.SelectedCells(2).Value
            End If

            If IsDBNull(DGVSecretario.SelectedCells(3).Value) Then
                miSecretario.Apellido = ""
            Else
                miSecretario.Apellido = DGVSecretario.SelectedCells(3).Value
            End If

            If IsDBNull(DGVSecretario.SelectedCells(4).Value) Then
                miSecretario.Cue = ""
            Else
                miSecretario.Cue = DGVSecretario.SelectedCells(4).Value
            End If
            If IsDBNull(DGVSecretario.SelectedCells(5).Value) Then
                miSecretario.NombreCue = ""
            Else
                miSecretario.NombreCue = DGVSecretario.SelectedCells(5).Value
            End If

            If IsDBNull(DGVSecretario.SelectedCells(6).Value) Then
                miSecretario.Turno = ""
            Else
                miSecretario.Turno = DGVSecretario.SelectedCells(6).Value
            End If

            If IsDBNull(DGVSecretario.SelectedCells(7).Value) Then
                miSecretario.Turno = ""
            Else
                miSecretario.SitRev = DGVSecretario.SelectedCells(7).Value
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK

            Me.LblIdEsculaDirectivoD.Text = miSecretario.IdEscuelaPersonal
            Me.TxtDniSecretario.Text = miSecretario.IdSecretario
            Me.TxtNombreSecretario.Text = miSecretario.Nombre
            Me.TxtApellidoSecretario.Text = miSecretario.Apellido
            Me.TxtCueSecretario.Text = miSecretario.Cue
            Me.TxtNombreCueSecretario.Text = miSecretario.NombreCue
            Me.CBTurnoSecretario.Text = miSecretario.Turno
            Me.CBSituacionRevistaSecretario.Text = miSecretario.SitRev
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If

        'tsbtnEliminarSecretario.Enabled = True
        tsbtnEditarSecretario.Enabled = True
        tsbtnAgregarSecretario.Enabled = False

    End Sub

    Private Sub BtnCopiarAuxiliar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCopiarAuxiliar.Click
        If DGVAuxiliar.RowCount > 0 Then
            MiAuxiliar.IdEscuelaPersonal = DGVAuxiliar.SelectedCells(0).Value

            If IsDBNull(DGVAuxiliar.SelectedCells(1).Value) Then
                MiAuxiliar.IdAuxiliar = ""
            Else
                MiAuxiliar.IdAuxiliar = DGVAuxiliar.SelectedCells(1).Value
            End If

            If IsDBNull(DGVAuxiliar.SelectedCells(2).Value) Then
                MiAuxiliar.Nombre = ""
            Else
                MiAuxiliar.Nombre = DGVAuxiliar.SelectedCells(2).Value
            End If

            If IsDBNull(DGVAuxiliar.SelectedCells(3).Value) Then
                MiAuxiliar.Apellido = ""
            Else
                MiAuxiliar.Apellido = DGVAuxiliar.SelectedCells(3).Value
            End If

            If IsDBNull(DGVAuxiliar.SelectedCells(4).Value) Then
                MiAuxiliar.Cue = ""
            Else
                MiAuxiliar.Cue = DGVAuxiliar.SelectedCells(4).Value
            End If
            If IsDBNull(DGVAuxiliar.SelectedCells(5).Value) Then
                MiAuxiliar.NombreCue = ""
            Else
                MiAuxiliar.NombreCue = DGVAuxiliar.SelectedCells(5).Value
            End If

            If IsDBNull(DGVAuxiliar.SelectedCells(6).Value) Then
                MiAuxiliar.Turno = ""
            Else
                MiAuxiliar.Turno = DGVAuxiliar.SelectedCells(6).Value
            End If

            If IsDBNull(DGVAuxiliar.SelectedCells(7).Value) Then
                MiAuxiliar.Turno = ""
            Else
                MiAuxiliar.SitRev = DGVAuxiliar.SelectedCells(7).Value
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK

            Me.LblIdEsculaDirectivoD.Text = MiAuxiliar.IdEscuelaPersonal
            Me.TxtDniAuxiliar.Text = MiAuxiliar.IdAuxiliar
            Me.TxtNombreauxiliar.Text = MiAuxiliar.Nombre
            Me.TxtApellidoAuxiliar.Text = MiAuxiliar.Apellido
            Me.TxtCueAuxiliar.Text = MiAuxiliar.Cue
            Me.TxtNombreCueAuxiliar.Text = MiAuxiliar.NombreCue
            Me.CBTurnoAuxiliar.Text = MiAuxiliar.Turno
            Me.CBSituacionRevistaAuxiliar.Text = MiAuxiliar.SitRev
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If

        'tsbtnEliminarAuxiliar.Enabled = True
        tsbtnEditarAuxiliar.Enabled = True
        tsbtnAgregarAuxiliar.Enabled = False
    End Sub

    Private Sub CBTurnoAuxiliar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBTurnoAuxiliar.SelectedIndexChanged
        LblIdEsculaDirectivoA.Text = CBTurnoAuxiliar.Text
    End Sub
End Class