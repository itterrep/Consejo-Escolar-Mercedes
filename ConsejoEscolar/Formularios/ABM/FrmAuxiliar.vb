Public Class FrmAuxiliar
    Dim dtMitabla As New DataTable
    Dim dtTabla As New DataTable
    Dim idAuxiliar As New ClassAuxiliar

    Private Sub FrmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenargrid()
        Limpiar()
        Inicio()
    End Sub

    Private Sub Llenargrid()
        'conecto a base de datos
        Dim miGestionMySQL As New GestionMySQL
        'uso la funcion Consultartabla() de la claseGestionMySQL 
        dtMitabla = miGestionMySQL.ConsultarTabla("Auxiliar")
        'con el dt devuelto lleno el datagriedview
        DGVAuxiliar.DataSource = dtMitabla
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
            MsgBox("Ingrese los datos " & vbNewLine & " del Auxiliar")
            TxtApellido.Select()
        Else
            Dim miGestionMySQL As New GestionMySQL
            Dim sql As String

            idAuxiliar.Nombre = Me.TxtNombre.Text.Trim
            idAuxiliar.Apellido = Me.TxtApellido.Text.Trim
            idAuxiliar.IdAuxiliar = Me.TxtDNI.Text.Trim
            idAuxiliar.TelFijo = Me.TxtTelFijo.Text.Trim
            idAuxiliar.TelCelular = Me.TxtTelCelular.Text.Trim
            idAuxiliar.Cuil = Me.TxtCuit.Text.Trim
            idAuxiliar.Email = Me.TxtEmail.Text.Trim

            If tsbtnNew.Enabled = True And tsbtnEditar.Enabled = False Then

                Try
                    'idAuxiliar, Nombre, Apellido, CUIL, Mail, Tel1, Tel2
                    sql = "INSERT INTO Auxiliar (idAuxiliar,Nombre, Apellido, Cuil, Email, TelFijo, TelCelular)"
                    sql += "VALUES ('" & idAuxiliar.IdAuxiliar & "','" & idAuxiliar.Nombre & "','" & idAuxiliar.Apellido & "', '" & idAuxiliar.Cuil & "',"
                    sql += "'" & idAuxiliar.Email & "', '" & idAuxiliar.TelFijo & "','" & idAuxiliar.TelCelular & "')"
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
                    sql = "Update Auxiliar SET "
                    sql += "Nombre ='" & idAuxiliar.Nombre & "', "
                    sql += "Apellido ='" & idAuxiliar.Apellido & "', "
                    sql += "Cuil ='" & idAuxiliar.Cuil & "', "
                    sql += "Email ='" & idAuxiliar.Email & "', "
                    sql += "TelFijo ='" & idAuxiliar.TelFijo & "', "
                    sql += "TelCelular ='" & idAuxiliar.TelCelular & "' "
                    sql += "WHERE idAuxiliar = " & idAuxiliar.IdAuxiliar & "; "
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
        MsgBox("Para buscar un Auxiliar escriba el N° DNI o el Apellido en el recuadro", MsgBoxStyle.Information)
        TxtApellido.BackColor = Color.White
        TxtApellido.ReadOnly = False
    End Sub

    Private Sub TxtApellido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtApellido.TextChanged
        Dim tabla As New DataTable
        'conecto a base de datos
        Dim miGestionMySQL As New GestionMySQL
        'uso la funcion buscar de la claseGestionMySQL 
        tabla = miGestionMySQL.BuscarenTablaEscribo("Auxiliar", "Apellido", TxtApellido.Text)
        'con el dt devuelto lleno el datagriedview
        DGVAuxiliar.DataSource = tabla

    End Sub

    Private Sub BtnCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCopiar.Click

        If DGVAuxiliar.RowCount > 0 Then

            idAuxiliar.idAuxiliar = DGVAuxiliar.SelectedCells(0).Value

            If IsDBNull(DGVAuxiliar.SelectedCells(1).Value) Then
                idAuxiliar.Nombre = ""
            Else
                idAuxiliar.Nombre = DGVAuxiliar.SelectedCells(1).Value
            End If

            If IsDBNull(DGVAuxiliar.SelectedCells(2).Value) Then
                idAuxiliar.Apellido = ""
            Else
                idAuxiliar.Apellido = DGVAuxiliar.SelectedCells(2).Value
            End If

            If IsDBNull(DGVAuxiliar.SelectedCells(5).Value) Then
                idAuxiliar.TelFijo = ""
            Else
                idAuxiliar.TelFijo = DGVAuxiliar.SelectedCells(5).Value
            End If
            If IsDBNull(DGVAuxiliar.SelectedCells(6).Value) Then
                idAuxiliar.TelCelular = ""
            Else
                idAuxiliar.TelCelular = DGVAuxiliar.SelectedCells(6).Value
            End If

            If IsDBNull(DGVAuxiliar.SelectedCells(4).Value) Then
                idAuxiliar.Email = ""
            Else
                idAuxiliar.Email = DGVAuxiliar.SelectedCells(4).Value
            End If

            If IsDBNull(DGVAuxiliar.SelectedCells(3).Value) Then
                idAuxiliar.Cuil = ""
            Else
                idAuxiliar.Cuil = DGVAuxiliar.SelectedCells(3).Value
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK

            Me.TxtDNI.Text = idAuxiliar.idAuxiliar
            Me.TxtNombre.Text = idAuxiliar.Nombre
            Me.TxtApellido.Text = idAuxiliar.Apellido
            Me.TxtTelFijo.Text = idAuxiliar.TelFijo
            Me.TxtTelCelular.Text = idAuxiliar.TelCelular
            Me.TxtEmail.Text = idAuxiliar.Email
            Me.TxtCuit.Text = idAuxiliar.Cuil

        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If

        'tsbtnEliminar.Enabled = True
        tsbtnEditar.Enabled = True
        tsbtnNew.Enabled = False

    End Sub

    Private Sub DGVClientes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVAuxiliar.CellContentClick
        If DGVAuxiliar.RowCount > 0 Then

            idAuxiliar.idAuxiliar = DGVAuxiliar.SelectedCells(0).Value

            If IsDBNull(DGVAuxiliar.SelectedCells(1).Value) Then
                idAuxiliar.Nombre = ""
            Else
                idAuxiliar.Nombre = DGVAuxiliar.SelectedCells(1).Value
            End If

            If IsDBNull(DGVAuxiliar.SelectedCells(2).Value) Then
                idAuxiliar.Apellido = ""
            Else
                idAuxiliar.Apellido = DGVAuxiliar.SelectedCells(2).Value
            End If

            If IsDBNull(DGVAuxiliar.SelectedCells(5).Value) Then
                idAuxiliar.TelFijo = ""
            Else
                idAuxiliar.TelFijo = DGVAuxiliar.SelectedCells(5).Value
            End If
            If IsDBNull(DGVAuxiliar.SelectedCells(6).Value) Then
                idAuxiliar.TelCelular = ""
            Else
                idAuxiliar.TelCelular = DGVAuxiliar.SelectedCells(6).Value
            End If

            If IsDBNull(DGVAuxiliar.SelectedCells(4).Value) Then
                idAuxiliar.Cuil = ""
            Else
                idAuxiliar.Cuil = DGVAuxiliar.SelectedCells(4).Value
            End If
            If IsDBNull(DGVAuxiliar.SelectedCells(3).Value) Then
                idAuxiliar.Email = ""
            Else
                idAuxiliar.Email = DGVAuxiliar.SelectedCells(3).Value
            End If


            Me.DialogResult = Windows.Forms.DialogResult.OK

            Me.TxtDNI.Text = idAuxiliar.idAuxiliar
            Me.TxtNombre.Text = idAuxiliar.Nombre
            Me.TxtApellido.Text = idAuxiliar.Apellido
            Me.TxtTelFijo.Text = idAuxiliar.TelFijo
            Me.TxtTelCelular.Text = idAuxiliar.TelCelular
            Me.TxtCuit.Text = idAuxiliar.Cuil
            Me.TxtEmail.Text = idAuxiliar.Email

        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If

        'tsbtnEliminar.Enabled = True
        tsbtnEditar.Enabled = True
        tsbtnNew.Enabled = False


    End Sub

End Class