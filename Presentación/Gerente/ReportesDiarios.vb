Public Class ReportesDiarios
    Private objDfactura = New DFactura
    Dim total As Decimal = 0
    Dim cantidad As Integer = 0

    Private Sub ReportesDiarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTHasta.Value = Date.Today
        DTDesde.Value = Date.Today
        objDfactura.filtrarVentasAdminAll(CDate(DTDesde.Value), CDate(DTHasta.Value), dgvListaVentas)
        LTotal.Text = 0
        If dgvListaVentas.Rows.Count > 0 Then

            For i = 0 To (dgvListaVentas.Rows().Count().ToString - 1)
                total = total + dgvListaVentas.Rows(i).Cells(7).Value.ToString
                cantidad = cantidad + dgvListaVentas.Rows(i).Cells(8).Value.ToString
            Next
        End If
        LTotal.Text = total
        dgvVentasNetas.Rows.Add(1, CStr(DTHasta.Value), total)
        dgvVentasNetas.ClearSelection()
        grafico()



    End Sub


    Private Sub grafico()
        Dim cantidadElementos As Integer = dgvListaVentas.Rows.Count
        Dim valorY As Decimal
        Dim fecha As Date = Date.Today
        ChartGrafico.Titles.Clear()
        ChartGrafico.Series.Clear()
        ChartGrafico.Series.Add("Ventas")
        ChartGrafico.Titles.Add("Ventas Diarias")
        ChartGrafico.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column
        ChartGrafico.ChartAreas(0).BackColor = Color.Azure
        'ChartGrafico.Series(0).IsValueShownAsLabel = True
        For i = 0 To cantidadElementos - 1
            valorY = valorY + dgvListaVentas.Rows(i).Cells(7).Value.ToString
        Next
        Dim fec As String = fecha.ToString("dd \de MMMM \de yyyy")
        ChartGrafico.Series(0).Points.AddXY(fec, valorY)

    End Sub
    Private Sub BVolver_Click_1(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub

End Class