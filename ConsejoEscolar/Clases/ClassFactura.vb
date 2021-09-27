Public Class ClassFactura

    'idFactura, Numero, Fecha, IdProveedor, Cue, Rubro, Monto

    'Tabla Factura
    Private _IdFactura As Integer
    Private _Numero As String
    Private _Fecha As Date
    Private _IdProveedor As Integer
    Private _Rubro As String
    Private _Cue As String
    Private _Monto As Decimal
    Private _Cuenta As String

    Public Property IdFactura As Integer
        Get
            Return _IdFactura
        End Get
        Set(value As Integer)
            _IdFactura = value
        End Set
    End Property

    Public Property Numero As String
        Get
            Return _Numero
        End Get
        Set(value As String)
            _Numero = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _Fecha
        End Get
        Set(value As Date)
            _Fecha = value
        End Set
    End Property

    Public Property IdProveedor As Integer
        Get
            Return _IdProveedor
        End Get
        Set(value As Integer)
            _IdProveedor = value
        End Set
    End Property

    Public Property Rubro As String
        Get
            Return _Rubro
        End Get
        Set(value As String)
            _Rubro = value
        End Set
    End Property

    Public Property Cue As String
        Get
            Return _Cue
        End Get
        Set(value As String)
            _Cue = value
        End Set
    End Property

    Public Property Monto As Decimal
        Get
            Return _Monto
        End Get
        Set(ByVal value As Decimal)
            _Monto = value
        End Set
    End Property

    Public Property Cuenta As String
        Get
            Return _Cuenta
        End Get
        Set(value As String)
            _Cuenta = value
        End Set
    End Property

End Class
