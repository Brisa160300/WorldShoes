Imports System.Data.Entity.Core.Common.EntitySql
Imports System.Text.RegularExpressions

Public Class AñadirVentas
    Private objNfactura = New NFactura
    Private objNcliente = New Dcliente
    Private descripcionProd As String
    Public Function EspacioEnBlanco() As Boolean
        Dim ask As MsgBoxResult = False
        Dim idcliente As String = TBIdCliVenta.Text
        Dim codigo As String = TBCodigoProducto.Text
        Dim cantidad As String = TBCantidad.Text
        If String.IsNullOrWhiteSpace(idcliente) Or
           String.IsNullOrWhiteSpace(codigo) Or
           String.IsNullOrWhiteSpace(cantidad) Then
            MsgBox("Debe Completar todos los campos", vbCritical, "Error")
            ask = True
        End If
        Return ask
    End Function

    Private Sub Cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBCantidad.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan caracteres númericos", vbCritical, "Error")
        End If
    End Sub

    Private Sub BVolver_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub



    Private Sub BBuscarProducto_Click(sender As Object, e As EventArgs) Handles BBuscarProducto.Click
        Dim frm As BuscarP = New BuscarP
        frm.ShowInTaskbar = False
        frm.ShowDialog(Me)
        If frm.result = False Then
            TBCodigoProducto.Text = frm.dgvListaProductos.CurrentRow.Cells(0).Value.ToString
            TBPrecio.Text = frm.dgvListaProductos.CurrentRow.Cells(4).Value.ToString
            TBStock.Text = frm.dgvListaProductos.CurrentRow.Cells(3).Value.ToString
            TBTalle.Text = frm.dgvListaProductos.CurrentRow.Cells(3).Value.ToString
            descripcionProd = frm.dgvListaProductos.CurrentRow.Cells(2).Value.ToString
        End If
        frm.Close()

    End Sub

    Private Sub BuscarCliente_Click(sender As Object, e As EventArgs) Handles BuscarCliente.Click
        Dim frm As BuscarCli = New BuscarCli
        frm.ShowInTaskbar = False
        frm.ShowDialog(Me)
        If frm.result = False Then
            TBIdCliVenta.Text = frm.dgvListarCliente.CurrentRow.Cells(0).Value.ToString
            TBNombreCliVenta.Text = frm.dgvListarCliente.CurrentRow.Cells(1).Value.ToString
            TBApellido.Text = frm.dgvListarCliente.CurrentRow.Cells(2).Value.ToString
            TBTelCli.Text = frm.dgvListarCliente.CurrentRow.Cells(4).Value.ToString
            TBDniCliente.Text = frm.dgvListarCliente.CurrentRow.Cells(3).Value.ToString
        End If
        frm.Close()
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        Dim ask As MsgBoxResult
        If EspacioEnBlanco() = False Then
            ask = MsgBox("Desea confirmar la venta", vbYesNo + vbQuestion, "Confirmar venta?")
            If ask = vbYes Then
                If objNfactura.agregar_factura(CInt(TBVendedor.Text), CInt(TBIdCliVenta.Text), CInt(TBCantidad.Text), CDec(TBTotalVenta.Text), dgvListaVentas) Then
                    MsgBox("Se completo la venta", vbExclamation, "Venta confirmada")
                Else
                    MsgBox("Algunos de los articulos seleccionados no cuentan con stock disponible")
                End If
            End If
        End If
    End Sub


    Private Sub BVolver_Click_1(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub

    Private Sub AñadirVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AgregarProducto.Enabled = False
        dgvListaVentas.ClearSelection()
    End Sub

    Private Sub TBCodigoProducto_TextChanged(sender As Object, e As EventArgs) Handles TBCodigoProducto.TextChanged
        AgregarProducto.Enabled = True
    End Sub

    Private Sub AgregarProducto_Click(sender As Object, e As EventArgs) Handles AgregarProducto.Click
        If TBCantidad.Text = "" Then
            ErrorProviderCantidad.SetError(TBCantidad, "Debe especificar una cantidad")
        Else
            Dim codigo As Integer = CInt(TBCodigoProducto.Text)
            Dim precio As Decimal = CDec(TBPrecio.Text)
            Dim cantidad As Integer = CInt(TBCantidad.Text)
            Dim talle As Integer = CInt(TBTalle.Text)
            dgvListaVentas.Rows.Add(TBCodigoProducto.Text, descripcionProd, TBPrecio.Text, TBCantidad.Text, TBTalle.Text)
            dgvListaVentas.ClearSelection()
        End If
    End Sub
End Class