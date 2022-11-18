Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fo = New Factura
        fo.TBCliente.Text = CStr(TBApellido.Text & " " & TBNombreCliVenta.Text)
        fo.TBTotalVenta.Text = TBTotalVenta.Text
        fo.Show()
    End Sub
End Class