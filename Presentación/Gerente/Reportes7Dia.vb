Public Class Reportes7Dia

    Private objDfactura = New DFactura
    Dim total As Decimal = 0
    Dim cantidad As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Reportes7Dia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DTHasta.Value = Date.Today
        Dim fec As Date = Date.Today
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
        LTotal.Text = 0
        'Dim dt As Date = Date.Now
        objDfactura.filtrarVentasAdminAll(CDate(DTDesde.Value), CDate(DTHasta.Value), dgvListaVentas)
        If dgvListaVentas.Rows.Count > 0 Then
            Dim totalxfecha As Decimal
            Dim fechagird As Date
            For i = 0 To (dgvListaVentas.Rows().Count().ToString - 1)
                total = total + dgvListaVentas.Rows(i).Cells(7).Value.ToString
                cantidad = cantidad + dgvListaVentas.Rows(i).Cells(8).Value.ToString
                'If dgvListaVentas.Rows(i).Cells(6).Value.ToString = dgvListaVentas.Rows(i - 1).Cells(6).Value.ToString Then
                '    totalxfecha = totalxfecha + CDec(dgvListaVentas.Rows(i).Cells(7).Value.ToString)
                '    fechagird = CDate(dgvListaVentas.Rows(i).Cells(6).Value.ToString)


                'End If
            Next
        End If
        LTotal.Text = total
    End Sub

End Class