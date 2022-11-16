Public Class EPerfil
    Private _id_perfil As Integer
    Private _descripcion As String
    Private _estado As String

    Public Property Id_perfil As Integer
        Get
            Return _id_perfil
        End Get
        Set(value As Integer)
            _id_perfil = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
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