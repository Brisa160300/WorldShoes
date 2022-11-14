Public Class ListarVentas
    Private objNfactura = New NFactura
    Private objDFactura = New DFactura
    Public idVendedor As Integer
    Private Sub TBBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBBuscar.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan caracteres númericos", vbCritical, "Error")
        End If
    End Sub

    Private Sub BVolver_Click(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub

    Private Sub BVerDetalle_Click(sender As Object, e As EventArgs) Handles BVerDetalle.Click
        If (dgvListaVentas.SelectedRows.Count > 0) Or (dgvListaVentas.SelectedCells.Count > 0) Then
            Dim frmEdit As DetalleVenta = New DetalleVenta
            frmEdit.nroFactura = CInt(dgvListaVentas.CurrentRow.Cells(0).Value.ToString)
            frmEdit.ShowInTaskbar = False
            frmEdit.ShowDialog()

        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If

    End Sub

    Private Sub TBBuscar_TextChanged(sender As Object, e As EventArgs) Handles TBBuscar.TextChanged

    End Sub

    Private Sub ListarVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNfactura.cargarGridVendedor(dgvListaVentas, 1)
    End Sub

    Private Sub BBuscarVenta_Click(sender As Object, e As EventArgs) Handles BBuscarVenta.Click
        If TBBuscar.Text = "" Then
            objNfactura.cargarGridVendedor(dgvListaVentas, 1)
        Else
            objDFactura.buscarVentasVendedorAll(idVendedor, TBBuscar.Text, dgvListaVentas)
            TBBuscar.Clear()
        End If
    End Sub

    Private Sub BFiltrar_Click(sender As Object, e As EventArgs) Handles BFiltrar.Click
        Dim fechaIni As Date = CDate(DTFechaInicio.Value.Date)
        Dim fechaFin As Date = CDate(DTFechaFinal.Value.Date)
        objDFactura.filtrarVentasVendedorAll(idVendedor, fechaIni, fechaFin, dgvListaVentas)
    End Sub
    Private Sub GroupBoxBuscarProducto_Click(sender As Object, e As EventArgs) Handles GroupBoxBuscarProducto.Click
        objNfactura.cargarGridVendedor(dgvListaVentas, 1)
    End Sub
End Class