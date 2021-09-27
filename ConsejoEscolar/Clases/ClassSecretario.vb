Public Class ClassSecretario
    'idDirector, Nombre, Apellido, CUIL, Mail, Tel1, Tel2
    Private _idSecretario As String
    Private _Nombre As String
    Private _Apellido As String
    Private _TelFijo As String
    Private _TelCelular As String
    Private _Email As String
    Private _Cuil As String

    'Tabla AuxiliarSitRev
    Private _SitRev As String
    Private _Cue As String
    Private _Turno As String
    Private _NombreCue As String
    Private _IdEscuelaPersonal As Integer

    Public Property IdSecretario As String
        Get
            Return _idSecretario
        End Get
        Set(ByVal value As String)
            _idSecretario = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return _Apellido
        End Get
        Set(ByVal value As String)
            _Apellido = value
        End Set
    End Property

    Public Property TelFijo As String
        Get
            Return _TelFijo
        End Get
        Set(ByVal value As String)
            _TelFijo = value
        End Set
    End Property

    Public Property TelCelular As String
        Get
            Return _TelCelular
        End Get
        Set(ByVal value As String)
            _TelCelular = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(ByVal value As String)
            _Email = value
        End Set
    End Property

    Public Property Cuil As String
        Get
            Return _Cuil
        End Get
        Set(ByVal value As String)
            _Cuil = value
        End Set
    End Property

    Public Property SitRev As String
        Get
            Return _SitRev
        End Get
        Set(ByVal value As String)
            _SitRev = value
        End Set
    End Property


    Public Property Cue As String
        Get
            Return _Cue
        End Get
        Set(ByVal value As String)
            _Cue = value
        End Set
    End Property

    Public Property NombreCue As String
        Get
            Return _NombreCue
        End Get
        Set(ByVal value As String)
            _NombreCue = value
        End Set
    End Property

    Public Property Turno As String
        Get
            Return _Turno
        End Get
        Set(ByVal value As String)
            _Turno = value
        End Set
    End Property

    Public Property IdEscuelaPersonal As Integer
        Get
            Return _IdEscuelaPersonal
        End Get
        Set(ByVal value As Integer)
            _IdEscuelaPersonal = value
        End Set
    End Property
End Class
