Public Class FrmInformeProveedores
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
        <h3 class='text-center'> Listado de Proveedores </h3>
        <br>
        <div class='container'>
        <table class='table table-hover table-responsive table-condensed table-bordered'>
     <thead>
      <tr class='active'>
        <th>RazonSocial</th>
        <th>Domicilio</th>
        <th>Localidad</th>
        <th>TelFijo</th>
        <th>TelCelular</th>
        <th>CUIT</th>
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
        <footer>
            <div><p>Reporte generado by GiFSys</p></div>            
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

        Dim consulta As String
        consulta = "Select  RazonSocial, Domicilio, Localidad, TelFijo, TelCelular, CUIT FROM proveedores p Order by RazonSocial; "

        'MsgBox(consulta)
        dt = miGestionMySQL.Consulta(consulta)
        'cierro conexion
        miGestionMySQL.Dispose()

        'RazonSocial, Domicilio, Localidad, TelFijo, TelCelular, CUIT, Email
        Dim RazonSocial, Domicilio, Localidad, TelFijo, TelCelular, CUIT, Email As String
        Dim filahtml As String = ""

        For Each fila As DataRow In dt.Rows
            RazonSocial = "  " & fila("RazonSocial")
            Domicilio = "  " & fila("Domicilio") & "  "
            Localidad = "  " & fila("Localidad") & "  "
            TelFijo = "  " & fila("TelFijo") & "  "
            TelCelular = "  " & fila("TelCelular") & "  "
            CUIT = "  " & fila("CUIT") & "  "

            filahtml += " <tr>  <td> " & RazonSocial & " </td> <td> " & Domicilio & "  </td><td>" & Localidad & "</td>  <td>" & TelFijo & "</td> <td>" & TelCelular & "</td> <td>" & CUIT & "</td>  </tr>"
        Next
        RichTextBox1.Text = maquetaSuperior + filahtml + maquetaInferior
        WebBrowser1.DocumentText = RichTextBox1.Text
    End Sub

End Class