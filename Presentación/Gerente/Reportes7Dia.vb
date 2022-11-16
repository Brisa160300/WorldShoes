Public Class Reportes7Dia

    Private objDfactura = New DFactura
    Dim total As Decimal = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Reportes7Dia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTHasta.Value = Date.Today
        Dim fec As Date = Date.Today
        Dim hasta As Date = CDate(DTHasta.Value)
        Select Case Date.Today.DayOfWeek
            Case 1
                fec = Date.Today
            Case 2
                fec = fec.AddDays(-1)
            Case = 3
                fec = fec.AddDays(-2)
            Case = 4
                fec = fec.AddDays(-3)
            Case = 5
                fec = fec.AddDays(-4)
        End Select
        DTDesde.Value = fec
        'Dim dt As Date = Date.Now
        objDfactura.filtrarVentasAdminAll(fec, CDate(DTHasta.Value), dgvListaVentas)
        If dgvListaVentas.Rows.Count > 0 Then
            For i = 0 To (dgvListaVentas.Rows().Count().ToString - 1)
                total = total + dgvListaVentas.Rows(i).Cells(7).Value.ToString
            Next
        End If
        For i = 0 To DateDiff(DateInterval.Day, fec, hasta)
            hasta.AddDays(i - 5)
            Dim d = DateDiff(DateInterval.Day, fec, hasta)
            ventasfechas(hasta.AddDays(i - d), i + 1)
        Next
        LTotal.Text = total
        grafico()
    End Sub

    Private Sub grafico()
        Dim cantidadElementos As Integer = dgvVentasNetas.Rows.Count
        Dim valorY As Decimal
        Dim fecha As Date
        Dim fec As String = fecha.ToString("dd \de MMMM \de yyyy")
        ChartGrafico.Titles.Clear()
        ChartGrafico.Series.Clear()
        ChartGrafico.Series.Add("Ventas")
        ChartGrafico.Titles.Add("Ventas Semanales")
        ChartGrafico.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column
        ChartGrafico.ChartAreas(0).BackColor = Color.Azure
        'ChartGrafico.Series(0).IsValueShownAsLabel = True
        For i = 0 To cantidadElementos - 1
            fecha = dgvVentasNetas.Rows(i).Cells(1).Value.ToString()
            valorY = valorY + dgvVentasNetas.Rows(i).Cells(2).Value.ToString
            ChartGrafico.Series(0).Points.AddXY(fecha, valorY)
            valorY = 0
        Next



    End Sub
    Private Function ventasfechas(fecha As Date, n As Integer)
        Dim totalxfecha As Decimal = 0
        For i = 0 To (dgvListaVentas.Rows().Count().ToString - 1)
            If dgvListaVentas.Rows(i).Cells(6).Value.ToString = fecha Then
                totalxfecha = totalxfecha + CDec(dgvListaVentas.Rows(i).Cells(7).Value.ToString)
            End If
        Next
        dgvVentasNetas.Rows.Add(n, fecha, totalxfecha)
        Return True
    End Function


End Class