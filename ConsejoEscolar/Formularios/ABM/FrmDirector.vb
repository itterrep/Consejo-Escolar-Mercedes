Public Class FrmDirector
    Dim dtMitabla As New DataTable
    Dim dtTabla As New DataTable
    Dim miDirector As New ClassDirector

    Private Sub FrmClientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenargrid()
        Limpiar()
        Inicio()
    End Sub

    Private Sub Llenargrid()
        'conecto a base de datos
        Dim miGestionMySQL As New GestionMySQL
        'uso la funcion Consultartabla() de la claseGestionMySQL 
        dtMitabla = miGestionMySQL.ConsultarTabla("director")
        'con el dt devuelto lleno el datagriedview
        DGVDirector.DataSource = dtMitabla
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
            MsgBox("Ingrese los datos " & vbNewLine & " del Director")
            TxtApellido.Select()
        Else
            Dim miGestionMySQL As New GestionMySQL
            Dim sql As String

            miDirector.Nombre = Me.TxtNombre.Text.Trim
            miDirector.Apellido = Me.TxtApellido.Text.Trim
            miDirector.IdDirector = Me.TxtDNI.Text.Trim
            miDirector.TelFijo = Me.TxtTelFijo.Text.Trim
            miDirector.TelCelular = Me.TxtTelCelular.Text.Trim
            miDirector.Cuil = Me.TxtCuit.Text.Trim
            miDirector.Email = Me.TxtEmail.Text.Trim

            If tsbtnNew.Enabled = True And tsbtnEditar.Enabled = False Then

                Try
                    'idDirector, Nombre, Apellido, CUIL, Mail, Tel1, Tel2
                    sql = "INSERT INTO director (idDirector,Nombre, Apellido, Cuil, Email, TelFijo, TelCelular)"
                    sql += "VALUES ('" & miDirector.IdDirector & "','" & miDirector.Nombre & "','" & miDirector.Apellido & "', '" & miDirector.Cuil & "',"
                    sql += "'" & miDirector.Email & "', '" & miDirector.TelFijo & "','" & miDirector.TelCelular & "')"
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
                    sql = "Update director SET "
                    sql += "Nombre ='" & miDirector.Nombre & "', "
                    sql += "Apellido ='" & miDirector.Apellido & "', "
                    sql += "Cuil ='" & miDirector.Cuil & "', "
                    sql += "Email ='" & miDirector.Email & "', "
                    sql += "TelFijo ='" & miDirector.TelFijo & "', "
                    sql += "TelCelular ='" & miDirector.TelCelular & "' "
                    sql += "WHERE idDirector = " & miDirector.IdDirector & "; "
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
        MsgBox("Para buscar un Director escriba el N° DNI o el Apellido en el recuadro", MsgBoxStyle.Information)
        TxtApellido.BackColor = Color.White
        TxtApellido.ReadOnly = False
    End Sub

    Private Sub TxtApellido_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtApellido.TextChanged
        Dim tabla As New DataTable
        'conecto a base de datos
        Dim miGestionMySQL As New GestionMySQL
        'uso la funcion buscar de la claseGestionMySQL 
        tabla = miGestionMySQL.BuscarenTablaEscribo("Director", "Apellido", TxtApellido.Text)
        'con el dt devuelto lleno el datagriedview
        DGVDirector.DataSource = tabla

    End Sub

    Private Sub BtnCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCopiar.Click

        If DGVDirector.RowCount > 0 Then

            miDirector.IdDirector = DGVDirector.SelectedCells(0).Value

            If IsDBNull(DGVDirector.SelectedCells(1).Value) Then
                miDirector.Nombre = ""
            Else
                miDirector.Nombre = DGVDirector.SelectedCells(1).Value
            End If

            If IsDBNull(DGVDirector.SelectedCells(2).Value) Then
                miDirector.Apellido = ""
            Else
                miDirector.Apellido = DGVDirector.SelectedCells(2).Value
            End If

            If IsDBNull(DGVDirector.SelectedCells(5).Value) Then
                miDirector.TelFijo = ""
            Else
                miDirector.TelFijo = DGVDirector.SelectedCells(5).Value
            End If
            If IsDBNull(DGVDirector.SelectedCells(6).Value) Then
                miDirector.TelCelular = ""
            Else
                miDirector.TelCelular = DGVDirector.SelectedCells(6).Value
            End If

            If IsDBNull(DGVDirector.SelectedCells(4).Value) Then
                miDirector.Email = ""
            Else
                miDirector.Email = DGVDirector.SelectedCells(4).Value
            End If

            If IsDBNull(DGVDirector.SelectedCells(3).Value) Then
                miDirector.Cuil = ""
            Else
                miDirector.Cuil = DGVDirector.SelectedCells(3).Value
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK

            Me.TxtDNI.Text = miDirector.IdDirector
            Me.TxtNombre.Text = miDirector.Nombre
            Me.TxtApellido.Text = miDirector.Apellido
            Me.TxtTelFijo.Text = miDirector.TelFijo
            Me.TxtTelCelular.Text = miDirector.TelCelular
            Me.TxtEmail.Text = miDirector.Email
            Me.TxtCuit.Text = miDirector.Cuil

        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If

        'tsbtnEliminar.Enabled = True
        tsbtnEditar.Enabled = True
        tsbtnNew.Enabled = False

    End Sub

    Private Sub DGVClientes_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGVDirector.CellContentClick
        If DGVDirector.RowCount > 0 Then

            miDirector.IdDirector = DGVDirector.SelectedCells(0).Value

            If IsDBNull(DGVDirector.SelectedCells(1).Value) Then
                miDirector.Nombre = ""
            Else
                miDirector.Nombre = DGVDirector.SelectedCells(1).Value
            End If

            If IsDBNull(DGVDirector.SelectedCells(2).Value) Then
                miDirector.Apellido = ""
            Else
                miDirector.Apellido = DGVDirector.SelectedCells(2).Value
            End If

            If IsDBNull(DGVDirector.SelectedCells(5).Value) Then
                miDirector.TelFijo = ""
            Else
                miDirector.TelFijo = DGVDirector.SelectedCells(5).Value
            End If
            If IsDBNull(DGVDirector.SelectedCells(6).Value) Then
                miDirector.TelCelular = ""
            Else
                miDirector.TelCelular = DGVDirector.SelectedCells(6).Value
            End If

            If IsDBNull(DGVDirector.SelectedCells(4).Value) Then
                miDirector.Cuil = ""
            Else
                miDirector.Cuil = DGVDirector.SelectedCells(4).Value
            End If
            If IsDBNull(DGVDirector.SelectedCells(3).Value) Then
                miDirector.Email = ""
            Else
                miDirector.Email = DGVDirector.SelectedCells(3).Value
            End If


            Me.DialogResult = Windows.Forms.DialogResult.OK

            Me.TxtDNI.Text = miDirector.IdDirector
            Me.TxtNombre.Text = miDirector.Nombre
            Me.TxtApellido.Text = miDirector.Apellido
            Me.TxtTelFijo.Text = miDirector.TelFijo
            Me.TxtTelCelular.Text = miDirector.TelCelular
            Me.TxtCuit.Text = miDirector.Cuil
            Me.TxtEmail.Text = miDirector.Email

        Else
            Me.DialogResult = Windows.Forms.DialogResult.Ignore
        End If

        'tsbtnEliminar.Enabled = True
        tsbtnEditar.Enabled = True
        tsbtnNew.Enabled = False


    End Sub

End Class