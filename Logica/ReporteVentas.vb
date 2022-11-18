Public Class ReporteVentas
    'Attributes
    Private _reportDate As DateTime
    Private _startDate As DateTime
    Private _endDAte As DateTime
    Private _listBestProducts As List(Of BestProductos)
    Private _total As Double

    'Propiertes
    Public Property ReportDate As Date
        Get
            Return _reportDate
        End Get
        Set(value As Date)
            _reportDate = value
        End Set
    End Property

    Public Property StartDate As Date
        Get
            Return _startDate
        End Get
        Set(value As Date)
            _startDate = value
        End Set
    End Property

    Public Property EndDAte As Date
        Get
            Return _endDAte
        End Get
        Set(value As Date)
            _endDAte = value
        End Set
    End Property

    Public Property ListBestProducts As List(Of BestProductos)
        Get
            Return _listBestProducts
        End Get
        Set(value As List(Of BestProductos))
            _listBestProducts = value
        End Set
    End Property

    Public Property Total As Double
        Get
            Return _total
        End Get
        Set(value As Double)
            _total = value
        End Set
    End Property


    'Constructors

    'Methods
    Public Sub GetBestSellingProductsReport(fromDate As DateTime, toDate As DateTime)
            'implement dates
            ReportDate = Date.Now()
            StartDate = fromDate
            EndDAte = toDate
        'Create list best selling products
        ListBestProducts = New List(Of BestProductos)()
        Dim orderDao = New Procedimientos
        Dim resultTable = orderDao.MejoresProductos(fromDate, toDate)

        For Each row As DataRow In resultTable.Rows
            Dim bestProductModel = New BestProductos() With
                {
            .ProductId = Convert.ToInt32(row(0)),
            .ProductName = Convert.ToString(row(1)),
            .Price = Convert.ToDouble(row(2)),
            .Quantity = Convert.ToInt32(row(3)),
            .Amount = Convert.ToDouble(row(4))
            }
            ListBestProducts.Add(bestProductModel)
            Total += Convert.ToDouble(row(4))
        Next
    End Sub

    End Class