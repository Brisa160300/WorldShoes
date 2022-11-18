Imports System.Data
Imports System.Data.SqlClient
Imports System.Collections
Public Class ReporteFiltradoFecha
    Private objDfactura = New DFactura
    Dim total As Decimal = 0
    Dim cantidad As Integer = 0

    Dim conexion = New SqlConnection("server=ABI\SQLEXPRESS;database=WorldShoes_Roman_Rios;integrated security = true")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub ReportesFiltradoFecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim desde As Date = DTDesde.Value.Date
        Dim hasta As Date = DTHasta.Value.Date
        If cargarGridVentas(desde, hasta) Then
            totalRecaudada()
            cargarGridVentasNetas(desde, hasta)
            grafico()
        End If

        'grafico()
    End Sub

    Private Function cargarGridVentas(desde As Date, hasta As Date)
        cmd = New SqlCommand("VentasFiltradas", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@desde", desde)
        cmd.Parameters.AddWithValue("@hasta", hasta)
        conexion.open()
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader()
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim Data As DataTable = New DataTable()
        dr.Close()
        da.Fill(Data)
        da.Dispose()
        conexion.Close()
        dgvListaVentas.DataSource = Data
        Return True
    End Function

    Private Sub cargarGridVentasNetas(desde As Date, hasta As Date)
        cmd = New SqlCommand("VentasNetas", conexion)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.AddWithValue("@desde", desde)
        cmd.Parameters.AddWithValue("@hasta", hasta)
        conexion.open()
        cmd.ExecuteNonQuery()
        dr = cmd.ExecuteReader()
        Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
        Dim Data As DataTable = New DataTable()
        dr.Close()
        da.Fill(Data)
        da.Dispose()
        conexion.Close()
        dgvVentasNetas.DataSource = Data
    End Sub

    Private Function ventasfechas(fecha As Date)
        Dim totalxfecha As Decimal = 0
        For i = 0 To (dgvListaVentas.Rows().Count().ToString - 1)
            If dgvListaVentas.Rows(i).Cells(3).Value.ToString = fecha Then
                totalxfecha = totalxfecha + CDec(dgvListaVentas.Rows(i).Cells(4).Value.ToString)
            End If
        Next
        Return totalxfecha
    End Function

    Private Function totalRecaudada()
        If dgvListaVentas.Rows.Count > 0 Then
            For i = 0 To (dgvListaVentas.Rows().Count().ToString - 1)
                total = total + dgvListaVentas.Rows(i).Cells(4).Value.ToString
            Next
        End If
        LTotal.Text = total
        total = 0
        Return True
    End Function

    Private Sub grafico()
        ChartGrafico.Series.Clear()
        ChartGrafico.Series.Add("Ventas")
        Dim cantidadElementos As Integer = dgvVentasNetas.Rows.Count
        Dim valorY As Decimal
        Dim fecha As Date
        Dim f As String
        ChartGrafico.Series("Ventas").ChartType = DataVisualization.Charting.SeriesChartType.Column
        For i = 0 To cantidadElementos - 1
            fecha = dgvVentasNetas.Rows(i).Cells(1).Value.ToString()
            f = fecha.ToShortDateString
            valorY = valorY + dgvVentasNetas.Rows(i).Cells(2).Value.ToString
            ChartGrafico.Series(0).Points.AddXY(f, valorY)
            valorY = 0
        Next

    End Sub

    Private Sub DTHasta_ValueChanged(sender As Object, e As EventArgs) Handles DTHasta.ValueChanged
        Dim desde As Date = DTDesde.Value.Date
        Dim hasta As Date = DTHasta.Value.Date
        If cargarGridVentas(desde, hasta) Then
            totalRecaudada()
            cargarGridVentasNetas(desde, hasta)
            grafico()
        End If

    End Sub

    Private Sub DTDesde_ValueChanged(sender As Object, e As EventArgs) Handles DTDesde.ValueChanged
        Dim desde As Date = DTDesde.Value.Date
        Dim hasta As Date = DTHasta.Value.Date
        If cargarGridVentas(desde, hasta) Then
            totalRecaudada()
            cargarGridVentasNetas(desde, hasta)
            grafico()
        End If
    End Sub
End Class