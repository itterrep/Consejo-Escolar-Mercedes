Public Class FrmInformeFacturasXCueProveedor
    Public Desde As Date = GlobalDesdeFacturaXFecha
    Public Hasta As Date = GlobalHastaFacturaXFecha
    Public TCuenta As String = GlobalTcuenta
    Public T1 As String
    Dim TCue As String = GlobalCue
    Dim NombreCue As String = GlobalNombreEscuela
    Dim TProveedor As String = GlobalProveedor

    Dim dt As New DataTable
    Dim tabla As New DataTable
    Dim Articulo As New ClassArticulo
    'conecto a base de datos
    Dim miGestionMySQL As New GestionMySQL

    Dim maquetaSuperior As String = "<!DOCTYPE html>
    <html lang='es'>
    <head>
   <meta charset='utf-8'>
   <meta name='viewport' content='width=device-width, initial-scale=1, shrink-to-fit=no'>
    <!-- Latest compiled and minified CSS -->
    <link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css'>
 
  </head>
     <body>
        <h3 class='text-center'> Listado de facturas desde " & GlobalDesdeFacturaXFecha & " hasta " & GlobalHastaFacturaXFecha & " de las cuentas " & GlobalTCuentaTitulo & "</h3>
        <br>
        <h3 class='text-center'> De la escuela " & NombreCue & " CUE Nº " & TCue & " y Proveedor " & TProveedor & " </h3>
        <br>
        <div class='container'>
        <table class='table table-hover'>
     <thead>
      <tr class='active'>
        <th>Fecha</th>
        <th>Numero</th>
        <th> Proveedor </th>
        <th>  Cue  </th>
        <th>  Nombre  </th>
        <th>Rubro</th>
        <th>Monto</th>
        <th>Cuenta</th>
       </tr>
    </thead>
    <tbody>"

    ' filas del grid van aca ****
    Dim maquetaInferior As String = "
    </tbody>
    </table>
    </div> 
    </body>

<!--bootom-->
    <div  class='fixed-bottom'>
    <h3 class='text-center'> Monto total facturado " & GlobalFacturado & "</h3>
    </div>
    
    <div>
        <footer>
            <div><h4 class='text-left'>Reporte generado by GiFSys</h4></div>            
        </footer>   
    </div>
  </html>"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Genera_Informe()
    End Sub

    Private Sub BtnEjecutar_Click(sender As Object, e As EventArgs)
        WebBrowser1.DocumentText = RichTextBox1.Text
    End Sub

    Private Sub Genera_Informe()
        If GlobalTcuenta = "Todas" Then
            TCuenta = "%C%"
        End If
        Dim consulta As String
        consulta = "SELECT f.Fecha, f.Numero, p.RazonSocial, f.Cue, e.Nombre, f.Rubro, f.Monto, f.cuenta "
        consulta += " FROM factura f"
        consulta += " inner join proveedores p on f.idProveedor = p.idProveedor"
        consulta += " inner join escuela e on e.cue = f.cue"
        consulta += " where f.fecha >= STR_TO_DATE('" & Desde & "' ,'%d/%m/%Y')  and f.fecha <= STR_TO_DATE('" & Hasta & "' ,'%d/%m/%Y')"
        consulta += " and f.Cue = '" & TCue & "'"
        consulta += " and p.RazonSocial = '" & TProveedor & "'"
        consulta += " and f.Cuenta like '" & TCuenta & "'"
        consulta += " order by f.Fecha;"

        'MsgBox(consulta)
        dt = miGestionMySQL.Consulta(consulta)
        'cierro conexion
        miGestionMySQL.Dispose()

        'Fecha, Numero, RazonSocial, Cue, Nombre, Rubro, Monto, cuenta
        Dim Fecha, Numero, RazonSocial, Cue, Nombre, Rubro, Monto, cuenta As String
        Dim filahtml As String = ""

        For Each fila As DataRow In dt.Rows
            Fecha = fila("Fecha")
            Numero = fila("Numero")
            RazonSocial = "  " & fila("RazonSocial") & "  "
            Cue = fila("Cue")
            Nombre = fila("Nombre")
            Rubro = fila("Rubro")
            Monto = " " & fila("Monto")
            cuenta = " " & fila("Cuenta")

            filahtml += " <tr>  <td> " & Fecha & " </td> <td> " & Numero & "  </td><td>" & RazonSocial & "</td>  <td>" & Cue & "</td>  <td>" & Nombre & "</td> <td>" & Rubro & "</td> <td>" & Monto & "</td> <td>" & cuenta & "</td> </tr>"
        Next
        RichTextBox1.Text = maquetaSuperior + filahtml + maquetaInferior
        WebBrowser1.DocumentText = RichTextBox1.Text
    End Sub
End Class