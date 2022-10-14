Public Class ListarVentasGerente
    Private Sub BVerDetalle_Click(sender As Object, e As EventArgs) Handles BVerDetalle.Click
        Dim frm As DetalleVenta = New DetalleVenta
        frm.ShowInTaskbar = False
        frm.ShowDialog()
    End Sub
End Class