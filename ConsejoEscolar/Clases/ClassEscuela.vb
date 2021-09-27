Public Class ClassEscuela
    'Cue, Tipo, Nombre, Direccion, Tel1, Tel2, CantSecc, Matricula, Comedor, Cupo, Email

    Private _idCue As String
    Private _Tipo As String
    Private _Nombre As String
    Private _Direccion As String
    Private _Ciudad As String
    Private _TelFijo As String
    Private _TelCelular As String
    Private _CantSecc As Integer
    Private _Matricula As Integer
    Private _Comedor As String
    Private _Cupo As Integer
    Private _Email As String
    Private _Cooperadora As String
    Private _FechaAsamblea As Date

    Public Property IdCue As String
        Get
            Return _idCue
        End Get
        Set(value As String)
            _idCue = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return _Tipo
        End Get
        Set(value As String)
            _Tipo = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _Direccion
        End Get
        Set(value As String)
            _Direccion = value
        End Set
    End Property

    Public Property Ciudad As String
        Get
            Return _Ciudad
        End Get
        Set(ByVal value As String)
            _Ciudad = value
        End Set
    End Property

    Public Property TelFijo As String
        Get
            Return _TelFijo
        End Get
        Set(value As String)
            _TelFijo = value
        End Set
    End Property

    Public Property TelCelular As String
        Get
            Return _TelCelular
        End Get
        Set(value As String)
            _TelCelular = value
        End Set
    End Property

    Public Property CantSecc As Integer
        Get
            Return _CantSecc
        End Get
        Set(value As Integer)
            _CantSecc = value
        End Set
    End Property

    Public Property Matricula As Integer
        Get
            Return _Matricula
        End Get
        Set(value As Integer)
            _Matricula = value
        End Set
    End Property

    Public Property Comedor As String
        Get
            Return _Comedor
        End Get
        Set(value As String)
            _Comedor = value
        End Set
    End Property

    Public Property Cupo As Integer
        Get
            Return _Cupo
        End Get
        Set(value As Integer)
            _Cupo = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
        End Set
    End Property

    Public Property Cooperadora As String
        Get
            Return _Cooperadora
        End Get
        Set(ByVal value As String)
            _Cooperadora = value
        End Set
    End Property

    Public Property FechaAsamblea As Date
        Get
            Return _FechaAsamblea
        End Get
        Set(ByVal value As Date)
            _FechaAsamblea = value
        End Set
    End Property

End Class
