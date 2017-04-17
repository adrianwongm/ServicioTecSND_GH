Public Class Empleado

    ''' <summary> 
    ''' 'Campo de Nombres
    ''' </summary>
    Private _Nombres As String
    Public Property Nombres() As String
        Get
            Return _Nombres
        End Get
        Set(ByVal value As String)
            _Nombres = value
        End Set
    End Property

    Private _Apellidos As String
    Public Property Apellidos() As String
        Get
            Return _Apellidos
        End Get
        Set(ByVal value As String)
            _Apellidos = value
        End Set
    End Property

    Private _NumeroIdentificacion As String
    Public Property NumeroIdentificacion() As String
        Get
            Return _NumeroIdentificacion
        End Get
        Set(ByVal value As String)
            _NumeroIdentificacion = value
        End Set
    End Property

    Private _ID As Integer
    Public Property ID() As Integer
        Get
            Return _ID
        End Get
        Set(ByVal value As Integer)
            _ID = value
        End Set
    End Property

    Private _ID_Cargo As Integer
    Public Property ID_Cargo() As Integer
        Get
            Return _ID_Cargo
        End Get
        Set(ByVal value As Integer)
            _ID_Cargo = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Nombres & " - " & Apellidos
    End Function
End Class
