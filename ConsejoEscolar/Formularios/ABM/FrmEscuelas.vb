Public Class FrmEscuelas
    Dim dtEscuela As New DataTable
    Dim dtTabla As New DataTable
    Dim miEscuela As New ClassEscuela

    Private Sub FrmEscuelas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Limpiar()
        Inicio()
        llenargrid()
    End Sub

    Private Sub Llenargrid()
        'conecto a base de datos
        Dim miGestionMySQL As New GestionMySQL
        'uso la funcion Consultartabla() de la claseGestionMySQL 
        dtEscuela = miGestionMySQL.ConsultarTabla("Escuela")
        'con el dt devuelto lleno el datagriedview
        DGVEscuela.DataSource = dtEscuela
    End Sub

    Private Sub Inicio()
        tsbtnNew.Enabled = True
        tsbtnEditar.Enabled = False
        tsbtnEliminar.Enabled = False
        tsbtnGuardar.Enabled = False
        tsbtnCancelar.Enabled = True
        TxtIdCue.Select()
        LlenarComboxComedor("tcomedor", "comedor", "comedor")
    End Sub

    Private Sub Limpiar()
        TxtIdCue.Text = ""
        TxtTipo.Text = ""
        TxtNombre.Clear()
        TxtDomicilio.Clear()
        TxtCiudad.Text = "Mercedes"
        TxtTelFijo.Clear()
        TxtTelCelular.Clear()
        TxtEmail.Text = "@"
        TxtCantSecc.Clear()
        TxtMatricula.Clear()
        CBComedor.Text = ""
        TxtCupo.Clear()
        CBCooperadora.Text = ""
        DTPultAsamblea.Value = Today
        LblFechaAsamblea.Text = ""
        InHabilitaTXT()
    End Sub

    Private Sub InhabilitaTXT()
        TxtIdCue.BackColor = Color.LightGreen
        TxtTipo.BackColor = Color.LightGreen
        TxtNombre.BackColor = Color.LightGreen
        TxtDomicilio.BackColor = Color.LightGreen
        TxtCiudad.BackColor = Color.LightGreen
        TxtTelFijo.BackColor = Color.LightGreen
        TxtTelCelular.BackColor = Color.LightGreen
        TxtEmail.BackColor = Color.LightGreen
        TxtCantSecc.BackColor = Color.LightGreen
        TxtMatricula.BackColor = Color.LightGreen
        CBComedor.BackColor = Color.LightGreen
        TxtCupo.BackColor = Color.LightGreen
        CBCooperadora.BackColor = Color.LightGreen
        DTPultAsamblea.BackColor = Color.LightGreen

        TxtIdCue.ReadOnly = True
        TxtTipo.ReadOnly = True
        TxtNombre.ReadOnly = True
        TxtDomicilio.ReadOnly = True
        TxtCiudad.ReadOnly = True
        TxtTelFijo.ReadOnly = True
        TxtTelCelular.ReadOnly = True
        TxtEmail.ReadOnly = True
        TxtCantSecc.ReadOnly = True
        TxtMatricula.ReadOnly = True
        CBComedor.Enabled = False
        TxtCupo.ReadOnly = True
        CBCooperadora.Enabled = False
        DTPultAsamblea.Enabled = False

    End Sub

    Private Sub HabilitaTXT()
        TxtIdCue.BackColor = Color.White
        TxtTipo.BackColor = Color.White
        TxtNombre.BackColor = Color.White
        TxtDomicilio.BackColor = Color.White
        TxtCiudad.BackColor = Color.White
        TxtTelFijo.BackColor = Color.White
        TxtTelCelular.BackColor = Color.White
        TxtEmail.BackColor = Color.White
        TxtCantSecc.BackColor = Color.White
        TxtMatricula.BackColor = Color.White
        CBComedor.BackColor = Color.White
        TxtCupo.BackColor = Color.White
        CBCooperadora.BackColor = Color.White
        DTPultAsamblea.BackColor = Color.White

        TxtIdCue.ReadOnly = False
        TxtTipo.ReadOnly = False
        TxtNombre.ReadOnly = False
        TxtDomicilio.ReadOnly = False
        TxtCiudad.ReadOnly = False
        TxtTelFijo.ReadOnly = False
        TxtTelCelular.ReadOnly = False
        TxtEmail.ReadOnly = False
        TxtCantSecc.ReadOnly = False
        TxtMatricula.ReadOnly = False
        CBComedor.Enabled = True
        TxtCupo.ReadOnly = False
        CBCooperadora.Enabled = True
        DTPultAsamblea.Enabled = True
    End Sub

    Private Sub TsbtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnNew.Click
        tsbtnGuardar.Enabled = True
        TxtIdCue.Enabled = True
        tsbtnCancelar.Enabled = True
        tsbtnEditar.Enabled = False
        tsbtnEditar.Enabled = False
        HabilitaTXT()
    End Sub

    Private Sub TsbtnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEditar.Click
        tsbtnNew.Enabled = False
        tsbtnEliminar.Enabled = False
        tsbtnGuardar.Enabled = True
        HabilitaTXT()
    End Sub

    Private Sub TsbtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEliminar.Click

        '    'Dim consultaMysql As String = ""
        '    'Dim codigo As Integer

        '    'codigo = Me.TxtIdCue.Text

        '    'If TxtIdCue.Text = "0000" Then
        '    '    MsgBox("Seleccione Escuela para borrar")
        '    'Else
        '    '    Dim resultado As DialogResult = MessageBox.Show("Está seguro de Eliminar?",
        '    '                                            "Atención", MessageBoxButtons.YesNo)
        '    '    If resultado = Windows.Forms.DialogResult.Yes Then
        '    '        conectarDB()
        '    '        comand.CommandType = CommandType.Text
        '    '        comand.Connection = conexion

        '    '        consultaMysql = "DELETE FROM escuela WHERE IdCue =" + codigo.ToString

        '    '        comand.CommandText = consultaMysql

        '    '        Try
        '    '            comand.ExecuteNonQuery()
        '    '            MsgBox("Registro Eliminado", MsgBoxStyle.Information)
        '    '        Catch ex As Exception
        '    '            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        '    '        End Try

        '    '        conexion.Close()
        '    '    End If
        '    'End If

        Limpiar()
        Llenargrid()
        Inicio()

    End Sub

    Private Sub TsbtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnGuardar.Click
        If TxtIdCue.Text = "" Then
            MsgBox("Ingrese los datos " & vbNewLine & " del Escuela")
            TxtIdCue.Select()
        Else
            Dim miGestionMySQL As New GestionMySQL
            Dim sql As String
            miEscuela.IdCue = Me.TxtIdCue.Text.Trim
            miEscuela.Tipo = Me.TxtTipo.Text.Trim
            miEscuela.Nombre = Me.TxtNombre.Text.Trim
            miEscuela.Direccion = Me.TxtDomicilio.Text.Trim
            miEscuela.Ciudad = Me.TxtCiudad.Text.Trim
            miEscuela.TelFijo = Me.TxtTelFijo.Text.Trim
            miEscuela.TelCelular = Me.TxtTelCelular.Text.Trim
            miEscuela.Email = Me.TxtEmail.Text.Trim
            miEscuela.CantSecc = Me.TxtCantSecc.Text.Trim
            miEscuela.Matricula = Me.TxtMatricula.Text.Trim
            miEscuela.Comedor = Me.CBComedor.Text.Trim
            miEscuela.Cupo = Me.TxtCupo.Text.Trim
            miEscuela.Cooperadora = Me.CBCooperadora.Text.Trim
            miEscuela.FechaAsamblea = LblFechaAsamblea.Text.Trim
            MsgBox(miEscuela.FechaAsamblea)
            If tsbtnNew.Enabled = True And tsbtnEditar.Enabled = False Then
                'Cue, Tipo, Nombre, Direccion, Ciudad, Tel1, Tel2, Email, CantSecc, Matricula, Comedor, Cupo, Cooperadora, FechaAsamblea     
                Try
                    sql = "INSERT INTO Escuela (Cue, Tipo, Nombre, Direccion, Ciudad, Tel1, Tel2, Email,CantSecc, Matricula, Comedor, Cupo, Cooperadora, FechaAsamblea) VALUES "
                    sql += " ('" & miEscuela.IdCue & "','" & miEscuela.Tipo & "','" & miEscuela.Nombre & "','" & miEscuela.Direccion & "','" & miEscuela.Ciudad & "', "
                    sql += "'" & miEscuela.TelFijo & "','" & miEscuela.TelCelular & "','" & miEscuela.Email & "','" & miEscuela.CantSecc & "','" & miEscuela.Matricula & "', "
                    sql += "'" & miEscuela.Comedor & "','" & miEscuela.Cupo & "','" & miEscuela.Cooperadora & "', STR_TO_DATE('" & miEscuela.FechaAsamblea & "' ,'%d/%m/%Y'));"
                    'MsgBox(sql)
                    miGestionMySQL.EjecutarSQL(sql)
                    miGestionMySQL.Dispose()
                    MsgBox("Los Datos Insertados Correctamente en la Base de Datos", MsgBoxStyle.Information, "Insertar Datos")
                Catch ex As Exception
                    MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
                End Try

            End If

            If tsbtnNew.Enabled = False And tsbtnEditar.Enabled = True Then
                Try
                    sql = "Update Escuela SET "
                    sql += "Tipo ='" & miEscuela.Tipo & "', "
                    sql += "Nombre ='" & miEscuela.Nombre & "', "
                    sql += "Direccion = '" & miEscuela.Direccion & "', "
                    sql += "Ciudad = '" & miEscuela.Ciudad & "', "
                    sql += "Tel1 ='" & miEscuela.TelFijo & "', "
                    sql += "Tel2 ='" & miEscuela.TelCelular & "', "
                    sql += "Email ='" & miEscuela.Email & "', "
                    sql += "CantSecc = '" & miEscuela.CantSecc & "', "
                    sql += "Matricula ='" & miEscuela.Matricula & "', "
                    sql += "Comedor ='" & miEscuela.Comedor & "', "
                    sql += "Cupo ='" & miEscuela.Cupo & "', "
                    sql += "Cooperadora ='" & miEscuela.Cooperadora & "', "
                    sql += "FechaAsamblea = STR_TO_DATE('" & miEscuela.FechaAsamblea & "' ,'%d/%m/%Y')"
                    sql += "WHERE Cue = '" & miEscuela.IdCue & "'; "
                    'MsgBox(sql)
                    miGestionMySQL.EjecutarSQL(sql)
                    miGestionMySQL.Dispose()
                    MsgBox("Los Datos Actualizados Correctamente en la Base de Datos", MsgBoxStyle.Information, "Actualizar Datos")
                Catch ex As Exception
                    MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Actualizar Datos")
                End Try
            End If
        End If
        Limpiar()
        Llenargrid()
        Inicio()
    End Sub

    Private Sub TsbtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnCancelar.Click
        Limpiar()
        Inicio()
    End Sub

    Private Sub TsbtnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnBuscar.Click
        MsgBox("Para buscar un Escuela escriba el N° Cue en el recuadro", MsgBoxStyle.Information)
        TxtIdCue.BackColor = Color.White
        TxtIdCue.ReadOnly = False
        TxtIdCue.Focus()
    End Sub

    Private Sub TxtIdCue_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtIdCue.TextChanged
        Dim tabla As New DataTable
        'conecto a base de datos
        Dim miGestionMySQL As New GestionMySQL
        'uso la funcion buscar de la claseGestionMySQL 
        tabla = miGestionMySQL.BuscarenTablaEscribo("Escuela", "Cue", TxtIdCue.Text)
        'con el dt devuelto lleno el datagriedview
        DGVEscuela.DataSource = tabla
    End Sub

    Private Sub BtnCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCopiar.Click
        'Cue, Tipo, Nombre, Direccion, Ciudad, Tel1, Tel2, Email, CantSecc, Matricula, Comedor, Cupo

        If DGVEscuela.RowCount > 0 Then

            miEscuela.IdCue = DGVEscuela.SelectedCells(0).Value

            If IsDBNull(DGVEscuela.SelectedCells(1).Value) Then
                miEscuela.Tipo = ""
            Else
                miEscuela.Tipo = DGVEscuela.SelectedCells(1).Value
            End If
            If IsDBNull(DGVEscuela.SelectedCells(2).Value) Then
                miEscuela.Nombre = ""
            Else
                miEscuela.Nombre = DGVEscuela.SelectedCells(2).Value
            End If
            If IsDBNull(DGVEscuela.SelectedCells(3).Value) Then
                miEscuela.Direccion = ""
            Else
                miEscuela.Direccion = DGVEscuela.SelectedCells(3).Value
            End If
            If IsDBNull(DGVEscuela.SelectedCells(4).Value) Then
                miEscuela.Ciudad = ""
            Else
                miEscuela.Ciudad = DGVEscuela.SelectedCells(4).Value
            End If
            If IsDBNull(DGVEscuela.SelectedCells(5).Value) Then
                miEscuela.TelFijo = ""
            Else
                miEscuela.TelFijo = DGVEscuela.SelectedCells(5).Value
            End If
            If IsDBNull(DGVEscuela.SelectedCells(6).Value) Then
                miEscuela.TelCelular = ""
            Else
                miEscuela.TelCelular = DGVEscuela.SelectedCells(6).Value
            End If
            If IsDBNull(DGVEscuela.SelectedCells(7).Value) Then
                miEscuela.Email = ""
            Else
                miEscuela.Email = DGVEscuela.SelectedCells(7).Value
            End If
            If IsDBNull(DGVEscuela.SelectedCells(8).Value) Then
                miEscuela.CantSecc = ""
            Else
                miEscuela.CantSecc = DGVEscuela.SelectedCells(8).Value
            End If
            If IsDBNull(DGVEscuela.SelectedCells(9).Value) Then
                miEscuela.Matricula = ""
            Else
                miEscuela.Matricula = DGVEscuela.SelectedCells(9).Value
            End If
            If IsDBNull(DGVEscuela.SelectedCells(10).Value) Then
                miEscuela.Comedor = ""
            Else
                miEscuela.Comedor = DGVEscuela.SelectedCells(10).Value
            End If
            If IsDBNull(DGVEscuela.SelectedCells(11).Value) Then
                miEscuela.Cupo = ""
            Else
                miEscuela.Cupo = DGVEscuela.SelectedCells(11).Value
            End If
            If IsDBNull(DGVEscuela.SelectedCells(12).Value) Then
                miEscuela.Cooperadora = ""
            Else
                miEscuela.Cooperadora = DGVEscuela.SelectedCells(12).Value
            End If
            If IsDBNull(DGVEscuela.SelectedCells(13).Value) Then
                miEscuela.FechaAsamblea = Nothing
            Else
                miEscuela.FechaAsamblea = DGVEscuela.SelectedCells(13).Value
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK

            Me.TxtIdCue.Text = miEscuela.IdCue
            Me.TxtTipo.Text = miEscuela.Tipo
            Me.TxtNombre.Text = miEscuela.Nombre
            Me.TxtDomicilio.Text = miEscuela.Direccion
            Me.TxtCiudad.Text = miEscuela.ciudad
            Me.TxtTelFijo.Text = miEscuela.TelFijo
            Me.TxtTelCelular.Text = miEscuela.TelCelular
            Me.TxtCantSecc.Text = Convert.ToInt16(miEscuela.CantSecc)
            Me.TxtMatricula.Text = Convert.ToInt16(miEscuela.Matricula)
            Me.CBComedor.Text = miEscuela.Comedor
            Me.TxtCupo.Text = Convert.ToInt16(miEscuela.Cupo)
            Me.TxtEmail.Text = miEscuela.Email
            Me.CBCooperadora.Text = miEscuela.Cooperadora
            Me.LblFechaAsamblea.Text = miEscuela.FechaAsamblea
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If

        'tsbtnEliminar.Enabled = True
        tsbtnEditar.Enabled = True
        tsbtnNew.Enabled = False
    End Sub

    Private Sub DGVescuela_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVEscuela.CellContentClick
        'Cue, Tipo, Nombre, Direccion, Ciudad, Tel1, Tel2, Email, CantSecc, Matricula, Comedor, Cupo

        If DGVEscuela.RowCount > 0 Then

            miEscuela.IdCue = DGVEscuela.SelectedCells(0).Value

            If IsDBNull(DGVEscuela.SelectedCells(1).Value) Then
                miEscuela.Tipo = ""
            Else
                miEscuela.Tipo = DGVEscuela.SelectedCells(1).Value
            End If
            If IsDBNull(DGVEscuela.SelectedCells(2).Value) Then
                miEscuela.Nombre = ""
            Else
                miEscuela.Nombre = DGVEscuela.SelectedCells(2).Value
            End If
            If IsDBNull(DGVEscuela.SelectedCells(3).Value) Then
                miEscuela.Direccion = ""
            Else
                miEscuela.Direccion = DGVEscuela.SelectedCells(3).Value
            End If
            If IsDBNull(DGVEscuela.SelectedCells(4).Value) Then
                miEscuela.Ciudad = ""
            Else
                miEscuela.Ciudad = DGVEscuela.SelectedCells(4).Value
            End If
            If IsDBNull(DGVEscuela.SelectedCells(5).Value) Then
                miEscuela.TelFijo = ""
            Else
                miEscuela.TelFijo = DGVEscuela.SelectedCells(5).Value
            End If
            If IsDBNull(DGVEscuela.SelectedCells(6).Value) Then
                miEscuela.TelCelular = ""
            Else
                miEscuela.TelCelular = DGVEscuela.SelectedCells(6).Value
            End If
            If IsDBNull(DGVEscuela.SelectedCells(7).Value) Then
                miEscuela.Email = ""
            Else
                miEscuela.Email = DGVEscuela.SelectedCells(7).Value
            End If
            If IsDBNull(DGVEscuela.SelectedCells(8).Value) Then
                miEscuela.CantSecc = ""
            Else
                miEscuela.CantSecc = DGVEscuela.SelectedCells(8).Value
            End If
            If IsDBNull(DGVEscuela.SelectedCells(9).Value) Then
                miEscuela.Matricula = ""
            Else
                miEscuela.Matricula = DGVEscuela.SelectedCells(9).Value
            End If
            If IsDBNull(DGVEscuela.SelectedCells(10).Value) Then
                miEscuela.Comedor = ""
            Else
                miEscuela.Comedor = DGVEscuela.SelectedCells(10).Value
            End If
            If IsDBNull(DGVEscuela.SelectedCells(11).Value) Then
                miEscuela.Cupo = ""
            Else
                miEscuela.Cupo = DGVEscuela.SelectedCells(11).Value
            End If
            If IsDBNull(DGVEscuela.SelectedCells(12).Value) Then
                miEscuela.Cooperadora = ""
            Else
                miEscuela.Cooperadora = DGVEscuela.SelectedCells(12).Value
            End If
            If IsDBNull(DGVEscuela.SelectedCells(13).Value) Then
                miEscuela.FechaAsamblea = Nothing
            Else
                miEscuela.FechaAsamblea = DGVEscuela.SelectedCells(13).Value
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK

            Me.TxtIdCue.Text = miEscuela.IdCue
            Me.TxtTipo.Text = miEscuela.Tipo
            Me.TxtNombre.Text = miEscuela.Nombre
            Me.TxtDomicilio.Text = miEscuela.Direccion
            Me.TxtCiudad.Text = miEscuela.Ciudad
            Me.TxtTelFijo.Text = miEscuela.TelFijo
            Me.TxtTelCelular.Text = miEscuela.TelCelular
            Me.TxtCantSecc.Text = Convert.ToInt16(miEscuela.CantSecc)
            Me.TxtMatricula.Text = Convert.ToInt16(miEscuela.Matricula)
            Me.CBComedor.Text = miEscuela.Comedor
            Me.TxtCupo.Text = Convert.ToInt16(miEscuela.Cupo)
            Me.TxtEmail.Text = miEscuela.Email
            Me.CBCooperadora.Text = miEscuela.Cooperadora
            Me.LblFechaAsamblea.Text = miEscuela.FechaAsamblea
        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If

        'tsbtnEliminar.Enabled = True
        tsbtnEditar.Enabled = True
        tsbtnNew.Enabled = False
    End Sub

    Private Sub TxtIdCue_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim tabla As New DataTable
        Dim miGestionMysql As New GestionMySQL
        tabla = miGestionMysql.BuscarenTablaEscribo("Escuela", "IdCue", TxtIdCue.Text)
        DGVEscuela.DataSource = tabla
    End Sub

    Public Sub LlenarComboxComedor(ByVal tabla As String, ByVal display As String, ByVal value As String)
        Dim miGestionMySQLcomedor As New GestionMySQL
        Dim dt As DataTable
        dt = miGestionMySQLcomedor.ConsultarTabla("Tcomedor")
        With CBComedor
            .DataSource = dt             ' DataSource = DataTable
            .DisplayMember = display           ' DisplayMember = "Nombre" Nombre del campo que quieres que muestre el combo.
            .ValueMember = value               ' ValueMembes = "ID" Nombre de campo que utilizaras como identificador
        End With
        miGestionMySQLcomedor.Dispose()
    End Sub

    Private Sub CBCooperadora_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CBCooperadora.SelectedIndexChanged
        If CBCooperadora.Text = "" Or CBCooperadora.Text = "No" Then
            LblFechaAsamblea.Text = "01/01/1810"
        ElseIf CBCooperadora.Text IsNot "" Then
            LblFechaAsamblea.Text = DTPultAsamblea.Text
        End If
    End Sub

    'Private Sub LblFechaAsamblea_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LblFechaAsamblea.TextChanged
    '    DTPultAsamblea.Text = LblFechaAsamblea.Text
    'End Sub
End Class