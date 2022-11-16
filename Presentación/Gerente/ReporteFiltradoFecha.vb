Public Class ReporteFiltradoFecha
    Public objDfactura = New DFactura
    Dim total As Decimal = 0
    Dim cantidad As Integer = 0
    Public fechas As String

    Private Sub ReportesFechas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'objDfactura.filtrarVentasAdminAll(DTDesde.Value, DTHasta.Value, dgvListaVentas)

    End Sub
    Public Sub cargargrid(fechas As String)
        If dgvListaVentas.Rows.Count > 0 Then
            For i = 0 To (dgvListaVentas.Rows().Count().ToString - 1)
                total = total + dgvListaVentas.Rows(i).Cells(7).Value.ToString
            Next
        End If
        LTotal.Text = total
        dgvVentasNetas.Rows.Add(1, fechas, total)
        dgvVentasNetas.ClearSelection()
    End Sub

    Public Sub grafico(des As Date, hast As Date)
        Dim cantidadElementos As Integer = dgvListaVentas.Rows.Count
        Dim valorY As Decimal
        ChartGrafico.Titles.Clear()
        ChartGrafico.Series.Clear()
        ChartGrafico.Series.Add("Ventas")
        ChartGrafico.Titles.Add("Ganancias desde")
        ChartGrafico.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column
        ChartGrafico.ChartAreas(0).BackColor = Color.Azure
        'ChartGrafico.Series(0).IsValueShownAsLabel = True
        For i = 0 To cantidadElementos - 1
            valorY = valorY + dgvListaVentas.Rows(i).Cells(7).Value.ToString
        Next
        Dim fec As String = des.ToString & " a " & hast.ToString
        ChartGrafico.Series(0).Points.AddXY(fec, valorY)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class