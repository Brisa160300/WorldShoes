Public Class datos_factura
    Private _id_factura As Integer
    Private _cliente As String
    Private _fecha_factura As Date
    Private _id_producto As Integer
    Private _nombreProducto As String
    Private _talle As String
    Private _precio As Decimal
    Private _cantidadProductos As Integer

    Public Property Id_factura As Integer
        Get
            Return _id_factura
        End Get
        Set(value As Integer)
            _id_factura = value
        End Set
    End Property

    Public Property Cliente As String
        Get
            Return _cliente
        End Get
        Set(value As String)
            _cliente = value
        End Set
    End Property

    Public Property Fecha_factura As Date
        Get
            Return _fecha_factura
        End Get
        Set(value As Date)
            _fecha_factura = value
        End Set
    End Property

    Public Property Id_producto As Integer
        Get
            Return _id_producto
        End Get
        Set(value As Integer)
            _id_producto = value
        End Set
    End Property

    Public Property NombreProducto As String
        Get
            Return _nombreProducto
        End Get
        Set(value As String)
            _nombreProducto = value
        End Set
    End Property

    Public Property Talle As String
        Get
            Return _talle
        End Get
        Set(value As String)
            _talle = value
        End Set
    End Property

    Public Property Precio As Decimal
        Get
            Return _precio
        End Get
        Set(value As Decimal)
            _precio = value
        End Set
    End Property

    Public Property CantidadProductos As Integer
        Get
            Return _cantidadProductos
        End Get
        Set(value As Integer)
            _cantidadProductos = value
        End Set
    End Property
End Class
