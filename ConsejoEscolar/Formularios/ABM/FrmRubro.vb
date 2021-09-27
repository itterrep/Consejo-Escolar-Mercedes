Public Class FrmRubro
    Dim miConexion As New GestionMySQL
    Dim Dt As New DataTable

    Private Sub FrmMarcaModelo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenarLista("rubro", "Rubro")
    End Sub

    Private Sub LlenarLista(ByVal tabla As String, ByVal display As String)
        Dt = miConexion.ConsultarTabla("rubro")
        With ListBox
            .DataSource = Dt
            .DisplayMember = display
        End With
    End Sub

    Private Sub Inicio()
        TxtItem.ReadOnly = True
        TxtItem.BackColor = Color.LightGreen
        TxtItem.Clear()
        BtnGraba.Enabled = False
        LlenarLista("rubro", "Rubro")
    End Sub

    Private Sub BtnAgrega_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        TxtItem.Clear()
        TxtItem.ReadOnly = False
        TxtItem.BackColor = Color.White
        BtnGraba.Enabled = True
        BtnAgregar.Enabled = False
    End Sub

    Private Sub ListBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox.SelectedIndexChanged
        Dim Lista As String
        Lista = ListBox.Text
        TxtItem.Text = Lista
    End Sub

    Private Sub BtnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCerrar.Click
        Me.Close()
        FrmCargaFacturas.llenarComboxRubro("rubro", "Rubro", "Rubro")
    End Sub

    Private Sub BtnGrabaMarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGraba.Click
        Dim miConexion As New GestionMySQL
        Dim item As String = TxtItem.Text
        Dim sql As String
        Try
            sql = "INSERT INTO rubro "
            sql += "VALUES ('" & item & "')"
            miConexion.EjecutarSQL(sql)
            miConexion.Dispose()
        Catch ex As Exception
            MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
        End Try

        item = ListBox.Text
        TxtItem.Text = item
        inicio()
        BtnAgregar.Enabled = True
    End Sub

    Private Sub BtnBorraMarca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBorra.Click
        Dim miConexion As New GestionMySQL
        Dim item As String = TxtItem.Text
        Dim sql As String
        Try
            sql = "DELETE FROM rubro "
            sql += "WHERE Rubro= '" & item & "'"
            miConexion.EjecutarSQL(sql)
            miConexion.Dispose()
        Catch ex As Exception
            MsgBox("Error: " & vbNewLine & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
        End Try
        item = ListBox.Text
        TxtItem.Text = item
        inicio()
    End Sub

End Class