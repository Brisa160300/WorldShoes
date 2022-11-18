Imports System.Data.SqlClient
Public Class Procedimientos
    Public Function MejoresProductos(fromDate As DateTime, toDate As DateTime) As DataTable
        Dim conexion = New SqlConnection("server=ABI\SQLEXPRESS;database=WorldShoes_Roman_Rios;integrated security = true")
        conexion.Open()
        Using command = New SqlCommand()
            command.Connection = conexion
            command.CommandText = "Top5ProductosVendidos"
            command.CommandType = CommandType.StoredProcedure
            Dim reader = command.ExecuteReader()
            Dim table = New DataTable()
            table.Load(reader)
            reader.Dispose()
            Return table
        End Using
    End Function
End Class
