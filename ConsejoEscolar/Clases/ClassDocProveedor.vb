Public Class ClassDocProveedor
    'idDocProv, idProveedor, FormInsc, FotoDNI, ConstCUIT, ConstIBB, Form404, HabMuni, ProbEst, Otros, Fecha
    'Tabla documentacionproveedores
    Private _idDocProv As String
    Private _idProveedor As String
    Private _FormInsc As String
    Private _FotoDNI As String
    Private _ConstCUIT As String
    Private _ConstIBB As String
    Private _Form404 As String
    Private _HabMuni As String
    Private _ProbEst As String
    Private _Otros As String
    Private _Fecha As Date

    Public Property IdDocProv As String
        Get
            Return _idDocProv
        End Get
        Set(value As String)
            _idDocProv = value
        End Set
    End Property

    Public Property IdProveedor As String
        Get
            Return _idProveedor
        End Get
        Set(value As String)
            _idProveedor = value
        End Set
    End Property

    Public Property FormInsc As String
        Get
            Return _FormInsc
        End Get
        Set(value As String)
            _FormInsc = value
        End Set
    End Property

    Public Property FotoDNI As String
        Get
            Return _FotoDNI
        End Get
        Set(value As String)
            _FotoDNI = value
        End Set
    End Property

    Public Property ConstCUIT As String
        Get
            Return _ConstCUIT
        End Get
        Set(value As String)
            _ConstCUIT = value
        End Set
    End Property

    Public Property ConstIBB As String
        Get
            Return _ConstIBB
        End Get
        Set(value As String)
            _ConstIBB = value
        End Set
    End Property

    Public Property Form404 As String
        Get
            Return _Form404
        End Get
        Set(value As String)
            _Form404 = value
        End Set
    End Property

    Public Property HabMuni As String
        Get
            Return _HabMuni
        End Get
        Set(value As String)
            _HabMuni = value
        End Set
    End Property

    Public Property ProbEst As String
        Get
            Return _ProbEst
        End Get
        Set(value As String)
            _ProbEst = value
        End Set
    End Property

    Public Property Otros As String
        Get
            Return _Otros
        End Get
        Set(value As String)
            _Otros = value
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
End Class
