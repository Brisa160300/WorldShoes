Public Class DetalleVenta
    Public nroFactura As Integer
    Private objDFactura = New DFactura
    Private Sub BCancelar_Click(sender As Object, e As EventArgs) Handles BCancelar.Click
        Me.Close()
    End Sub

    Private Sub DetalleVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objDFactura.getVentasDetalle(nroFactura, dgvListaVentas)
    End Sub
End Class