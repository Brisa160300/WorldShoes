Public Class EDetalleProducto
    Private _codigo As Integer
    Private _nombre As String
    Private _descripcion_categoria As String
    Private _precio As Integer
    Private _descripcion_marca As String
    Private _estado As String
    Private _id_marca As Integer
    Private _id_categ As Integer

    Public Property Codigo As Integer
        Get
            Return _codigo
        End Get
        Set(value As Integer)
            _codigo = value
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

    Public Property Descripcion_categoria As String
        Get
            Return _descripcion_categoria
        End Get
        Set(value As String)
            _descripcion_categoria = value
        End Set
    End Property

    Public Property Precio As Integer
        Get
            Return _precio
        End Get
        Set(value As Integer)
            _precio = value
        End Set
    End Property

    Public Property Descripcion_marca As String
        Get
            Return _descripcion_marca
        End Get
        Set(value As String)
            _descripcion_marca = value
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

    Public Property Id_marca As Integer
        Get
            Return _id_marca
        End Get
        Set(value As Integer)
            _id_marca = value
        End Set
    End Property

    Public Property Id_categ As Integer
        Get
            Return _id_categ
        End Get
        Set(value As Integer)
            _id_categ = value
        End Set
    End Property
End Class
