Module Module_Variables_Globales

    'Usado para pasar de frmLogin-Usuario al MDIParent
    Public usuarioGlobal As String
    'Usado para pasar por parametro el numero del presupuesto e imprimir
    Public Global_numeroPresupuesto As Integer
    'Usado para asignar el idCompras 
    Public Global_numeroCompra As Integer
    Public Global_numeroVenta As Integer
    Public Global_numeroFactura As Integer
    '-------------caja-----
    Public Global_ultimoGrabado As Integer
    Public flag As String
    '---------------------
    Public GlobalDesdeVentas As Date
    Public GlobalHastaVentas As Date
    Public GlobalDesdeCaja As Date
    Public GlobalHastaCaja As Date

    'usado para anular una Venta
    Public Global_AnularFactura As Integer
    Public Global_RazonSocialCliente As String

    'Informe facturas x cue y fecha
    Public GlobalDesdeFacturaXCue As Date
    Public GlobalHastaFacturaXCue As Date
    Public GlobalCue As String
    Public GlobalNombEscuela As String
    Public GlobalRubro As String
    Public GlobalProveedor As String
    Public GlobalidProveedor As String
    Public GlobalTcuenta As String
    Public GlobalNombreEscuela As String
    Public GlobalTCuentaTitulo As String
    Public GlobalFacturado As String

    'Informe facturas x  fecha
    Public GlobalDesdeFacturaXFecha As Date
    Public GlobalHastaFacturaXFecha As Date




End Module
