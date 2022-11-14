Public Class EVenta
    Private _id_factura As Integer
    Private _nombre_cliente As String
    Private _apellido_cliente As String
    Private _fecha_factura As Date
    Private _importe As Decimal
    Private _cantidadProductos As Integer

    Public Property Id_factura As Integer
        Get
            Return _id_factura
        End Get
        Set(value As Integer)
            _id_factura = value
        End Set
    End Property

    Public Property Nombre_cliente As String
        Get
            Return _nombre_cliente
        End Get
        Set(value As String)
            _nombre_cliente = value
        End Set
    End Property

    Public Property Apellido_cliente As String
        Get
            Return _apellido_cliente
        End Get
        Set(value As String)
            _apellido_cliente = value
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

    Public Property Importe As Decimal
        Get
            Return _importe
        End Get
        Set(value As Decimal)
            _importe = value
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
