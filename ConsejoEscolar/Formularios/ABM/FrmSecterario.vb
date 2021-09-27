Public Class FrmSecretario
    Dim dtMitabla As New DataTable
    Dim dtTabla As New DataTable
    Dim idSecretario As New ClassSecretario

    Private Sub FrmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenargrid()
        Limpiar()
        Inicio()
    End Sub

    Private Sub Llenargrid()
        'conecto a base de datos
        Dim miGestionMySQL As New GestionMySQL
        'uso la funcion Consultartabla() de la claseGestionMySQL 
        dtMitabla = miGestionMySQL.ConsultarTabla("secretario")
        'con el dt devuelto lleno el datagriedview
        DGVSecretario.DataSource = dtMitabla
    End Sub

    Private Sub Inicio()
        tsbtnNew.Enabled = True
        tsbtnEditar.Enabled = False
        tsbtnEliminar.Enabled = False
        tsbtnGuardar.Enabled = False
        tsbtnCancelar.Enabled = True
    End Sub

    Private Sub Limpiar()
        TxtApellido.Clear()
        TxtDNI.Clear()
        TxtNombre.Clear()
        TxtTelFijo.Clear()
        TxtTelCelular.Clear()
        TxtCuit.Text = "00-00000000-0"
        TxtEmail.Text = "@"
        InhabilitaTXT()
    End Sub

    Private Sub InhabilitaTXT()
        TxtApellido.BackColor = Color.LightGreen
        TxtNombre.BackColor = Color.LightGreen
        TxtDNI.BackColor = Color.LightGreen
        TxtTelFijo.BackColor = Color.LightGreen
        TxtTelCelular.BackColor = Color.LightGreen
        TxtCuit.BackColor = Color.LightGreen
        TxtEmail.BackColor = Color.LightGreen

        TxtApellido.ReadOnly = True
        TxtNombre.ReadOnly = True
        TxtDNI.ReadOnly = True
        TxtTelFijo.ReadOnly = True
        TxtTelCelular.ReadOnly = True
        TxtCuit.ReadOnly = True
        TxtEmail.ReadOnly = True
    End Sub

    Private Sub HabilitaTXT()
        TxtApellido.BackColor = Color.White
        TxtNombre.BackColor = Color.White
        TxtDNI.BackColor = Color.White
        TxtTelFijo.BackColor = Color.White
        TxtTelCelular.BackColor = Color.White
        TxtCuit.BackColor = Color.White
        TxtEmail.BackColor = Color.White

        TxtApellido.ReadOnly = False
        TxtNombre.ReadOnly = False
        TxtDNI.ReadOnly = False
        TxtTelFijo.ReadOnly = False
        TxtTelCelular.ReadOnly = False
        TxtCuit.ReadOnly = False
        TxtEmail.ReadOnly = False
    End Sub

    Private Sub TsbtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnNew.Click
        tsbtnGuardar.Enabled = True
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
        TxtDNI.BackColor = Color.LightGreen
        TxtDNI.ReadOnly = True
    End Sub

    'Private Sub tsbtnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnEliminar.Click

    '    'Dim consultaMysql As String = ""
    '    'Dim codigo As Integer

    '    'codigo = Me.TxtIdCliente.Text

    '    'If TxtIdCliente.Text = "0000" Then
    '    '    MsgBox("Seleccione Cliente para borrar")
    '    'Else
    '    '    Dim resultado As DialogResult = MessageBox.Show("Está seguro de Eliminar?",
    '    '                                            "Atención", MessageBoxButtons.YesNo)
    '    '    If resultado = Windows.Forms.DialogResult.Yes Then
    '    '        conectarDB()
    '    '        comand.CommandType = CommandType.Text
    '    '        comand.Connection = conexion

    '    '        consultaMysql = "DELETE FROM clientes WHERE idcliente =" + codigo.ToString

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

    '    'limpiar()
    '    'llenargrid()
    '    'inicio()

    'End Sub

    Private Sub TsbtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtnGuardar.Click

        If TxtApellido.Text = "" Then
            MsgBox("Ingrese los datos " & vbNewLine & " del Secretario")
            TxtApellido.Select()
        Else
            Dim miGestionMySQL As New GestionMySQL
            Dim sql As String

            idSecretario.Nombre = Me.TxtNombre.Text.Trim
            idSecretario.Apellido = Me.TxtApellido.Text.Trim
            idSecretario.IdSecretario = Me.TxtDNI.Text.Trim
            idSecretario.TelFijo = Me.TxtTelFijo.Text.Trim
            idSecretario.TelCelular = Me.TxtTelCelular.Text.Trim
            idSecretario.Cuil = Me.TxtCuit.Text.Trim
            idSecretario.Email = Me.TxtEmail.Text.Trim

            If tsbtnNew.Enabled = True And tsbtnEditar.Enabled = False Then

                Try
                    'idSecretario, Nombre, Apellido, CUIL, Mail, Tel1, Tel2
                    sql = "INSERT INTO secretario (idSecretario,Nombre, Apellido, Cuil, Email, TelFijo, TelCelular)"
                    sql += "VALUES ('" & idSecretario.IdSecretario & "','" & idSecretario.Nombre & "','" & idSecretario.Apellido & "', '" & idSecretario.Cuil & "',"
                    sql += "'" & idSecretario.Email & "', '" & idSecretario.TelFijo & "','" & idSecretario.TelCelular & "')"
                    MsgBox(sql)
                    miGestionMySQL.EjecutarSQL(sql)
                    miGestionMySQL.Dispose()

                    MsgBox("Los Datos Insertados Correctamente en la Base de Datos", MsgBoxStyle.Information, "Insertar Datos")

                Catch ex As Exception

                    MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")

                End Try
            End If

            If tsbtnNew.Enabled = False And tsbtnEditar.Enabled = True Then

                Try
                    sql = "Update secretario SET "
                    sql += "Nombre ='" & idSecretario.Nombre & "', "
                    sql += "Apellido ='" & idSecretario.Apellido & "', "
                    sql += "Cuil ='" & idSecretario.Cuil & "', "
                    sql += "Email ='" & idSecretario.Email & "', "
                    sql += "TelFijo ='" & idSecretario.TelFijo & "', "
                    sql += "TelCelular ='" & idSecretario.TelCelular & "' "
                    sql += "WHERE idSecretario = " & idSecretario.IdSecretario & "; "
                    MsgBox(sql)
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
        MsgBox("Para buscar un Secretario escriba el N° DNI o el Apellido en el recuadro", MsgBoxStyle.Information)
        TxtApellido.BackColor = Color.White
        TxtApellido.ReadOnly = False
    End Sub

    Private Sub TxtApellido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtApellido.TextChanged
        Dim tabla As New DataTable
        'conecto a base de datos
        Dim miGestionMySQL As New GestionMySQL
        'uso la funcion buscar de la claseGestionMySQL 
        tabla = miGestionMySQL.BuscarenTablaEscribo("Secretario", "Apellido", TxtApellido.Text)
        'con el dt devuelto lleno el datagriedview
        DGVSecretario.DataSource = tabla

    End Sub

    Private Sub BtnCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCopiar.Click

        If DGVSecretario.RowCount > 0 Then

            idSecretario.idSecretario = DGVSecretario.SelectedCells(0).Value

            If IsDBNull(DGVSecretario.SelectedCells(1).Value) Then
                idSecretario.Nombre = ""
            Else
                idSecretario.Nombre = DGVSecretario.SelectedCells(1).Value
            End If

            If IsDBNull(DGVSecretario.SelectedCells(2).Value) Then
                idSecretario.Apellido = ""
            Else
                idSecretario.Apellido = DGVSecretario.SelectedCells(2).Value
            End If

            If IsDBNull(DGVSecretario.SelectedCells(5).Value) Then
                idSecretario.TelFijo = ""
            Else
                idSecretario.TelFijo = DGVSecretario.SelectedCells(5).Value
            End If
            If IsDBNull(DGVSecretario.SelectedCells(6).Value) Then
                idSecretario.TelCelular = ""
            Else
                idSecretario.TelCelular = DGVSecretario.SelectedCells(6).Value
            End If

            If IsDBNull(DGVSecretario.SelectedCells(4).Value) Then
                idSecretario.Email = ""
            Else
                idSecretario.Email = DGVSecretario.SelectedCells(4).Value
            End If

            If IsDBNull(DGVSecretario.SelectedCells(3).Value) Then
                idSecretario.Cuil = ""
            Else
                idSecretario.Cuil = DGVSecretario.SelectedCells(3).Value
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK

            Me.TxtDNI.Text = idSecretario.idSecretario
            Me.TxtNombre.Text = idSecretario.Nombre
            Me.TxtApellido.Text = idSecretario.Apellido
            Me.TxtTelFijo.Text = idSecretario.TelFijo
            Me.TxtTelCelular.Text = idSecretario.TelCelular
            Me.TxtEmail.Text = idSecretario.Email
            Me.TxtCuit.Text = idSecretario.Cuil

        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If

        'tsbtnEliminar.Enabled = True
        tsbtnEditar.Enabled = True
        tsbtnNew.Enabled = False

    End Sub

    Private Sub DGVClientes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVSecretario.CellContentClick
        If DGVSecretario.RowCount > 0 Then

            idSecretario.idSecretario = DGVSecretario.SelectedCells(0).Value

            If IsDBNull(DGVSecretario.SelectedCells(1).Value) Then
                idSecretario.Nombre = ""
            Else
                idSecretario.Nombre = DGVSecretario.SelectedCells(1).Value
            End If

            If IsDBNull(DGVSecretario.SelectedCells(2).Value) Then
                idSecretario.Apellido = ""
            Else
                idSecretario.Apellido = DGVSecretario.SelectedCells(2).Value
            End If

            If IsDBNull(DGVSecretario.SelectedCells(5).Value) Then
                idSecretario.TelFijo = ""
            Else
                idSecretario.TelFijo = DGVSecretario.SelectedCells(5).Value
            End If
            If IsDBNull(DGVSecretario.SelectedCells(6).Value) Then
                idSecretario.TelCelular = ""
            Else
                idSecretario.TelCelular = DGVSecretario.SelectedCells(6).Value
            End If

            If IsDBNull(DGVSecretario.SelectedCells(4).Value) Then
                idSecretario.Cuil = ""
            Else
                idSecretario.Cuil = DGVSecretario.SelectedCells(4).Value
            End If
            If IsDBNull(DGVSecretario.SelectedCells(3).Value) Then
                idSecretario.Email = ""
            Else
                idSecretario.Email = DGVSecretario.SelectedCells(3).Value
            End If


            Me.DialogResult = Windows.Forms.DialogResult.OK

            Me.TxtDNI.Text = idSecretario.idSecretario
            Me.TxtNombre.Text = idSecretario.Nombre
            Me.TxtApellido.Text = idSecretario.Apellido
            Me.TxtTelFijo.Text = idSecretario.TelFijo
            Me.TxtTelCelular.Text = idSecretario.TelCelular
            Me.TxtCuit.Text = idSecretario.Cuil
            Me.TxtEmail.Text = idSecretario.Email

        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If

        'tsbtnEliminar.Enabled = True
        tsbtnEditar.Enabled = True
        tsbtnNew.Enabled = False


    End Sub

End Class