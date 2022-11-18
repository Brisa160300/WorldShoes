Imports System.Data.SqlClient
Public Class Conexion

    Protected Function GetConnection() As SqlConnection
        Return New SqlConnection("Server=(local); DataBase=WorldShoes_Roman_Rios; integrated security=true")
    End Function

End Class

