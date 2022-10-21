Public Class EProducto
    Private _nombre As String
    Private _descripcion_categoria As String
    Private _stock As Integer
    Private _precio As Integer
    Private _descripcion_marca As String
    Private _estado As String

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

    Public Property Stock As Integer
        Get
            Return _stock
        End Get
        Set(value As Integer)
            _stock = value
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
End Class
