Public Class Reportes30dias


    Private objDfactura = New DFactura
    Dim total As Decimal = 0
    Dim cantidad As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Reportes30Dia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            For i = 0 To (dgvListaVentas.Rows().Count().ToString - 1)
                total = total + dgvListaVentas.Rows(i).Cells(7).Value.ToString
                cantidad = cantidad + dgvListaVentas.Rows(i).Cells(8).Value.ToString
            Next
        End If
        LTotal.Text = total
        'dgvVentasNetas.Rows.Add(1, CStr(DTHasta.Value), total)
        'dgvVentasNetas.ClearSelection()
    End Sub
End Class