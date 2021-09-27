Imports Microsoft.Reporting.WinForms

Public Class FrmInformeEscuelasTipo

    Dim Tipoescuela As String

    Private Sub FrmInformeVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'consejoescolarDataSetEscuelasTipo.Get_EscuelasTipo' Puede moverla o quitarla según sea necesario.
        LlenarComboxEscuelas("Escuela", "Tipo", "Tipo")
    End Sub

    Public Sub LlenarComboxEscuelas(ByVal tabla As String, ByVal display As String, ByVal value As String)
        Dim miGestionMySQLcomedor As New GestionMySQL
        Dim dt As DataTable
        dt = miGestionMySQLcomedor.Consulta("SELECT tipo FROM escuela e GROUP BY Tipo order by tipo;")
        With CBEscuelas
            .DataSource = dt                   ' DataSource = DataTable
            .DisplayMember = display           ' DisplayMember = "Nombre" Nombre del campo que quieres que muestre el combo.
            .ValueMember = value               ' ValueMembes = "ID" Nombre de campo que utilizaras como identificador
        End With
        miGestionMySQLcomedor.Dispose()
    End Sub

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
        <h3 class='text-center'> Listado de Escuelas </h3>
        <br>
        <div class='container'>
        <table class='table table-hover'>
     <thead>
      <tr class='active'>
        <th>Cue</th>
        <th>Tipo</th>
        <th>Nombre</th>
        <th>Direccion</th>
        <th>Ciudad</th>
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

    Private Sub CBEscuelas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBEscuelas.SelectedIndexChanged
        Genera_Informe()
    End Sub

    Private Sub Genera_Informe()
        Dim consulta As String
        consulta = "SELECT Cue, Tipo, Nombre, Direccion, Ciudad FROM escuela e Where Tipo = '" & CBEscuelas.Text & "' order by Tipo,Nombre; "
        'MsgBox(consulta)

        dt = miGestionMySQL.Consulta(consulta)
        'cierro conexion
        miGestionMySQL.Dispose()

        'Cue, Tipo, Nombre, Direccion, Ciudad
        Dim Cue, Tipo, Nombre, Direccion, Ciudad As String
        Dim filahtml As String = ""

        For Each fila As DataRow In dt.Rows
            Cue = fila("Cue")
            Tipo = fila("Tipo")
            Nombre = "  " & fila("Nombre") & "  "
            Direccion = fila("Direccion")
            Ciudad = fila("Ciudad")

            filahtml += " <tr>  <td> " & Cue & " </td> <td> " & Tipo & "  </td><td>" & Nombre & "</td>  <td>" & Direccion & "</td>  <td>" & Ciudad & "</td> </tr>"
        Next
        RichTextBox1.Text = maquetaSuperior + filahtml + maquetaInferior
        WebBrowser1.DocumentText = RichTextBox1.Text
    End Sub

End Class