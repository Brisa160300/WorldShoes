Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections


Public Class ProductosMasVendidos
    Dim objDProductos = New DProducto
    Dim conexion = New SqlConnection("server=.\SQLEXPRESS;database=WorldShoes_Roman_Rios;integrated security = true")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader


    Dim productosList = New ArrayList
    Dim cantProdList = New ArrayList
    Private Sub graficarProductos()
        cmd = New SqlCommand("Top5ProductosVendidos", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        conexion.open()
        dr = cmd.ExecuteReader()
        While (dr.Read())
            'productosList.add(dr.GetString(0))
            'cantProdList.add(dr.GetInt32(1))
            ChartGrafico.Series(0).Points.AddXY(dr.GetString(0), dr.GetInt32(1))
        End While
        'ChartGrafico.Titles.Add("TOP 5 PRODUCTOS MAS VENDIDOS")
        dr.Close()
        conexion.close()
    End Sub


    Private Sub cargarGridVentas()
        cmd = New SqlCommand("MostrarTop5Vendidos", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        conexion.open()
        dr = cmd.ExecuteReader()
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim Data As DataTable = New DataTable()
        dr.Close()
        da.Fill(Data)
        da.Dispose()

        conexion.Close()

        dgvVentasProductos.DataSource = Data
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ProductosMasVendidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        graficarProductos()
        cargarGridVentas()
        'objDProductos.DetalleProductosAdmin(dgvVentasProductos)
    End Sub

End Class