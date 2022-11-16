Public Class ETalle
    Private _id_talle As Integer
    Private _talle As Integer
    Private _estado As String

    Public Property Id_talle As Integer
        Get
            Return _id_talle
        End Get
        Set(value As Integer)
            _id_talle = value
        End Set
    End Property

    Public Property Talle As Integer
        Get
            Return _talle
        End Get
        Set(value As Integer)
            _talle = value
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
