Public Class Reportes30dias
    Private objDfactura = New DFactura
    Dim total As Decimal = 0
    Dim cantidad As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Reportes30Dias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DTHasta.Value = Date.Today
        DTDesde.Value = PrimerDiaDelMes(DTHasta.Value.Date)
        Dim desde As Date = DTDesde.Value.Date
        Dim hasta As Date = DTHasta.Value.Date
        objDfactura.filtrarVentasAdminAll(desde, hasta, dgvListaVentas)
        If dgvListaVentas.Rows.Count > 0 Then
            For i = 0 To (dgvListaVentas.Rows().Count().ToString - 1)
                total = total + dgvListaVentas.Rows(i).Cells(7).Value.ToString
            Next
        End If
        LTotal.Text = total
        Dim ii = 1
        While ii <= DateTime.DaysInMonth(desde.Year, desde.Month) - 1

            ventasfechas(desde.AddDays(ii -1), ii)
            ii = ii + 1
        End While
        grafico()
    End Sub

    Private Function ventasfechas(fecha As Date, n As Integer)
        Dim totalxfecha As Decimal = 0
        For i = 0 To (dgvListaVentas.Rows().Count().ToString - 1)
            If dgvListaVentas.Rows(i).Cells(6).Value.ToString = fecha Then
                totalxfecha = totalxfecha + CDec(dgvListaVentas.Rows(i).Cells(7).Value.ToString)
            End If
        Next
        dgvVentasNetas.Rows.Add(n, fecha.ToShortDateString, totalxfecha)
        Return True
    End Function

    Function PrimerDiaDelMes(ByVal dtmFecha As Date) As Date
        PrimerDiaDelMes = DateSerial(Year(dtmFecha), Month(dtmFecha), 1)
    End Function

    Private Sub grafico()
        Dim cantidadElementos As Integer = dgvVentasNetas.Rows.Count
        Dim valorY As Decimal
        Dim fecha As Date
        ChartGrafico.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Column
        ChartGrafico.ChartAreas(0).BackColor = Color.Azure
        For i = 0 To cantidadElementos - 1
            fecha = dgvVentasNetas.Rows(i).Cells(1).Value.ToString()
            valorY = valorY + dgvVentasNetas.Rows(i).Cells(2).Value.ToString
            ChartGrafico.Series(0).Points.AddXY(i + 1, valorY)
            valorY = 0
        Next

    End Sub


End Class