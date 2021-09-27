Public Class FrmDocProv

    Dim dtMiTabla As New DataTable
    Dim miProveedor As New ClassProveedor
    Dim miDocProveedor As New ClassDocProveedor
    Dim idProveedor As String = GlobalidProveedor

    Private Sub FrmDocProv_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChequeoEstado()
    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click
        Grabar()
        frmProveedores.Limpiar()
        frmProveedores.Llenargrid()
        frmProveedores.BtnDocEntregada.Enabled = False
    End Sub

    'Chequeo cuando inicio y cargo los checkbox si son true
    Private Sub ChequeoEstado()

        Dim MiConexion As New GestionMySQL
        Dim dtDP As New DataTable

        'idDocProv, idProveedor, FormInsc, FotoDNI, ConstCUIT, ConstIBB, Form404, HabMuni, ProbEst, Otros, Fecha

        'chequeo info desde base de datos y lo paso a la clase miDocProveedor

        miDocProveedor.IdProveedor = GlobalidProveedor

        'MsgBox(miDocProveedor.IdProveedor)

        dtDP = MiConexion.CargoDataEnDocumentacioProveedor(miDocProveedor.IdProveedor)

        For Each row As DataRow In dtDP.Rows

            If row("FormInsc") = "0" Then
                miDocProveedor.FormInsc = 0
            Else
                miDocProveedor.FormInsc = 1
            End If

            If row("FotoDNI") = "0" Then
                miDocProveedor.FotoDNI = 0
            Else
                miDocProveedor.FotoDNI = 1
            End If

            If row("ConstCUIT") = "0" Then
                miDocProveedor.ConstCUIT = 0
            Else
                miDocProveedor.ConstCUIT = 1
            End If

            If row("ConstIBB") = "0" Then
                miDocProveedor.ConstIBB = 0
            Else
                miDocProveedor.ConstIBB = 1
            End If

            If row("Form404") = "0" Then
                miDocProveedor.Form404 = 0
            Else
                miDocProveedor.Form404 = 1
            End If

            If row("HabMuni") = "0" Then
                miDocProveedor.HabMuni = 0
            Else
                miDocProveedor.HabMuni = 1
            End If

            If row("ProbEst") = "0" Then
                miDocProveedor.ProbEst = 0
            Else
                miDocProveedor.ProbEst = 1
            End If

            If row("Otros") = "0" Then
                miDocProveedor.Otros = 0
            Else
                miDocProveedor.Otros = 1
            End If

            miDocProveedor.Fecha = row("Fecha")

        Next

        'Chequeo la clase y cargo info en los checkbox

        If miDocProveedor.FormInsc = 0 Then
            CB1.Checked = False
        Else
            CB1.Checked = True
        End If

        If miDocProveedor.FotoDNI = 0 Then
            CB2.Checked = False
        Else
            CB2.Checked = True
        End If

        If miDocProveedor.ConstCUIT = 0 Then
            CB3.Checked = False
        Else
            CB3.Checked = True
        End If

        If miDocProveedor.ConstIBB = 0 Then
            CB4.Checked = False
        Else
            CB4.Checked = True
        End If

        If miDocProveedor.Form404 = 0 Then
            CB5.Checked = False
        Else
            CB5.Checked = True
        End If

        If miDocProveedor.HabMuni = 0 Then
            CB6.Checked = False
        Else
            CB6.Checked = True
        End If

        If miDocProveedor.ProbEst = 0 Then
            CB7.Checked = False
        Else
            CB7.Checked = True
        End If

        If miDocProveedor.Otros = 0 Then
            CB8.Checked = False
        Else
            CB8.Checked = True
        End If

        DateTimePicker1.Value = miDocProveedor.Fecha


    End Sub

    Private Sub Grabar()

        Dim MiConexion As New GestionMySQL
        Dim sql As String

        'idDocProv, idProveedor, FormInsc, FotoDNI, ConstCUIT, ConstIBB, Form404, HabMuni, ProbEst, Otros, Fecha
        miDocProveedor.IdProveedor = TxtProveedor.Text.Trim

        If CB1.Checked = True Then
            miDocProveedor.FormInsc = True
        Else
            miDocProveedor.FormInsc = False
        End If

        If CB2.Checked = True Then
            miDocProveedor.FotoDNI = True
        Else
            miDocProveedor.FotoDNI = False
        End If

        If CB3.Checked = True Then
            miDocProveedor.ConstCUIT = True
        Else
            miDocProveedor.ConstCUIT = False
        End If

        If CB4.Checked = True Then
            miDocProveedor.ConstIBB = True
        Else
            miDocProveedor.ConstIBB = False
        End If

        If CB5.Checked = True Then
            miDocProveedor.Form404 = True
        Else
            miDocProveedor.Form404 = False
        End If

        If CB6.Checked = True Then
            miDocProveedor.HabMuni = True
        Else
            miDocProveedor.HabMuni = False
        End If

        If CB7.Checked = True Then
            miDocProveedor.ProbEst = True
        Else
            miDocProveedor.ProbEst = False
        End If

        If CB8.Checked = True Then
            miDocProveedor.Otros = True
        Else
            miDocProveedor.Otros = False
        End If

        miDocProveedor.Fecha = Today()

        Try
            sql = "Update documentacionproveedores set forminsc = " & miDocProveedor.FormInsc
            sql += ", FotoDNI = " & miDocProveedor.FotoDNI & ", ConstCUIT = " & miDocProveedor.ConstCUIT
            sql += ", ConstIBB = " & miDocProveedor.ConstIBB & ", Form404 = " & miDocProveedor.Form404 & ", "
            sql += " HabMuni = " & miDocProveedor.HabMuni & ", ProbEst = " & miDocProveedor.ProbEst & ","
            sql += " Otros = " & miDocProveedor.Otros & ", Fecha = STR_TO_DATE('" & miDocProveedor.Fecha & "','%d/%m/%Y') "
            sql += "where idProveedor = " & miDocProveedor.IdProveedor & ";"
            'MsgBox(sql)
            MiConexion.EjecutarSQL(sql)
            MiConexion.Dispose()
            MsgBox("Registro Guardado", MsgBoxStyle.Information)

        Catch ex As Exception

            MsgBox(ex.ToString, MsgBoxStyle.Critical)

        End Try

        Me.Close()
    End Sub

End Class