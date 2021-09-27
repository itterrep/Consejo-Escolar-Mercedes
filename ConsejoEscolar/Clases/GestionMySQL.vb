Imports MySql.Data.MySqlClient

Public Class GestionMySQL
    Private miConexion As New MySqlConnection
    Private miComando As New MySqlCommand

    Public Sub New()
        Try
            'local
            miConexion.ConnectionString = ("Server=localhost;Port=3307;Database=ConsejoEscolar;User=GiFSys;Password=GiFSys1502;")
            'remota
            'miConexion.ConnectionString = ("Server=192.168.200.4;Port=3307;Database=ConsejoEscolar;User=GiFSys;Password=GiFSys1502;")

            miConexion.Open()
            miComando.Connection = miConexion
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Public Sub EjecutarSQL(ByVal SentenciaSQL As String)
        miComando.CommandText = SentenciaSQL
        miComando.ExecuteNonQuery()
    End Sub

    Public Sub Dispose()
        miConexion.Close()
        miConexion.Dispose()
        miComando.Dispose()
    End Sub
    '----------------------------------------------------------------------------------
    Public Function Consulta(ByVal sql As String) As DataTable
        Dim dt As New DataTable
        Dim strMysql As String = sql
        'MsgBox(strMysql)
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)
        adaptador.Fill(dt)
        miConexion.Close()
        Return dt
    End Function

    Public Function ConsultarTabla(ByVal tabla As String) As DataTable
        Dim dt As New DataTable
        Dim strMysql As String = "SELECT * FROM " + tabla
        'MsgBox(strMysql)
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)
        adaptador.Fill(dt)
        miConexion.Close()
        Return dt
    End Function

    Public Function BuscarenTablaEscribo(ByVal tabla As String, ByVal columna As String, ByVal campo As String) As DataTable
        Dim dt As New DataTable
        Dim strMysql As String = "SELECT * FROM " & tabla & " WHERE " & columna & " LIKE '" & campo & "%'"
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)
        adaptador.Fill(dt)
        miConexion.Close()
        Return dt
    End Function

    Public Function BuscarenTablaEscriboOrden(ByVal tabla As String, ByVal columna As String, ByVal campo As String, ByVal orden As String) As DataTable
        Dim dt As New DataTable
        Dim strMysql As String = "SELECT * FROM " & tabla & " WHERE " & columna & " LIKE '" & campo & "%' order by " & orden
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)
        adaptador.Fill(dt)
        miConexion.Close()
        Return dt
    End Function

    Public Function BuscarenTablaEscriboOrdenEscuela(ByVal campo As String) As DataTable
        Dim dt As New DataTable
        Dim strMysql As String = "SELECT CUE, Tipo, Nombre, Direccion, Tel1, Tel2 FROM escuela WHERE nombre LIKE '%" & campo & "%' order by Tipo, Nombre"
        'MsgBox(strMysql)
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)
        adaptador.Fill(dt)
        miConexion.Close()
        Return dt
    End Function

    Public Function BuscarenTablaEscriboCue(ByVal tabla As String, ByVal columna As String, ByVal campo As String) As DataTable
        Dim dt As New DataTable
        Dim strMysql As String = "SELECT Cue, Tipo, Nombre, Direccion FROM " & tabla & " WHERE " & columna & " LIKE '" & campo & "%'"
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)
        adaptador.Fill(dt)
        miConexion.Close()
        Return dt
    End Function

    Public Function ConsultarProcedimiento(ByVal tabla As String) As DataTable
        Dim dt As New DataTable
        Dim strMysql As String = "Call " + tabla
        'MsgBox(strMysql)
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)
        adaptador.Fill(dt)
        miConexion.Close()
        Return dt
    End Function

    Public Function ConsultarNombreEscuela(ByVal cue As String) As DataTable
        Dim dt As New DataTable
        Dim strMysql As String = "SELECT Nombre FROM escuela where cue = '" & cue & "'"
        'MsgBox(strMysql)
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)
        adaptador.Fill(dt)
        miConexion.Close()
        Return dt
    End Function

    Public Function ConsultarNombreProveedor(ByVal idProveedor As String) As DataTable
        Dim dt As New DataTable
        Dim strMysql As String = "SELECT RazonSocial FROM proveedores where idProveedor =  " & idProveedor
        'MsgBox(strMysql)
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)
        adaptador.Fill(dt)
        miConexion.Close()
        Return dt
    End Function

    Public Function ConsultarEstadoFactura(ByVal idEstadoFactura As String) As DataTable
        Dim dt As New DataTable
        Dim strMysql1 As String = "SELECT Estado FROM factura where idFactura = " & idEstadoFactura
        'MsgBox(strMysql1)
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql1, miConexion)
        adaptador.Fill(dt)
        miConexion.Close()
        Return dt
    End Function

    Public Function ConsultarTablaLLenoCB(ByVal tabla As String, ByVal orden As String) As DataTable
        Dim dt As New DataTable
        Dim strMysql As String = "SELECT * FROM " + tabla + " order by " + orden
        'MsgBox(strMysql)
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)
        adaptador.Fill(dt)
        miConexion.Close()
        Return dt
    End Function

    Public Function CargoDataEnDocumentacioProveedor(ByVal IDP As String) As DataTable
        Dim dt As New DataTable
        Dim strMysql As String
        strMysql = "SELECT * FROM documentacionproveedores where idProveedor = " & IDP & "; "
        'MsgBox(strMysql)
        Dim adaptador As New MySql.Data.MySqlClient.MySqlDataAdapter(strMysql, miConexion)
        adaptador.Fill(dt)
        miConexion.Close()
        Return dt
    End Function

End Class
