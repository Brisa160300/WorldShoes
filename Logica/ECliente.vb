Public Class ECliente
    Private _id_cliente As Integer
    Private _nombre As String
    Private _apellido As String
    Private _dni As Integer
    Private _telefono As ULong
    Private _direccion As String
    Private _correo As String
    Private _estado As String

    Public Property Id_cliente As Integer
        Get
            Return _id_cliente
        End Get
        Set(value As Integer)
            _id_cliente = value
        End Set
    End Property

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

    Public Property Dni As Integer
        Get
            Return _dni
        End Get
        Set(value As Integer)
            _dni = value
        End Set
    End Property

    Public Property Telefono As ULong
        Get
            Return _telefono
        End Get
        Set(value As ULong)
            _telefono = value
        End Set
    End Property

    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
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
End Class
