Public Class EUsuario
    Private _nombre As String
    Private _apellido As String
    Private _nombreUsuario As String
    Private _pass As String
    Private _descripcion_perfil As String
    Private _estado As String
    Private _id_usuario As Integer

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Public Property NombreUsuario As String
        Get
            Return _nombreUsuario
        End Get
        Set(value As String)
            _nombreUsuario = value
        End Set
    End Property

    Public Property Pass As String
        Get
            Return _pass
        End Get
        Set(value As String)
            _pass = value
        End Set
    End Property

    Public Property Descripcion_perfil As String
        Get
            Return _descripcion_perfil
        End Get
        Set(value As String)
            _descripcion_perfil = value
        End Set
    End Property

    Public Property Estado As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property

    Public Property Id_usuario As Integer
        Get
            Return _id_usuario
        End Get
        Set(value As Integer)
            _id_usuario = value
        End Set
    End Property
End Class
