Imports System.Data.Entity.Core.Common.EntitySql
Imports System.Text.RegularExpressions

Public Class AñadirVentas
    Private objNfactura = New NFactura
    Private objDfactura = New DFactura
    Private objNcliente = New Dcliente
    Private descripcionProd As String
    Public idUsuario As Integer
    Dim modprod As Boolean = False
    Public prodtotal As Integer = 0
    Dim cantidadVenta As Integer = 0
    Private printLine As Integer = 0
    Private contador As Integer = 0
    Private posicion_encabezado As Integer = Me.Top
    Public Function EspacioEnBlanco() As Boolean
        Dim ask As MsgBoxResult = False
        Dim idcliente As String = TBIdCliVenta.Text
        If String.IsNullOrWhiteSpace(idcliente) Then
            MsgBox("Debe Completar todos los campos", vbCritical, "Error")
            ask = True
        ElseIf dgvListaVentas.Rows.Count() = 0 Then
            MsgBox("Debe añadir un producto", vbCritical, "Error")
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
            descripcionProd = frm.dgvListaProductos.CurrentRow.Cells(1).Value.ToString
            TBPrecio.Text = frm.dgvListaProductos.CurrentRow.Cells(4).Value.ToString
            TBStock.Text = frm.dgvListaProductos.CurrentRow.Cells(3).Value.ToString
            TBTalle.Text = frm.dgvListaProductos.CurrentRow.Cells(6).Value.ToString
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
                If objNfactura.agregar_factura(CInt(TBVendedor.Text), CInt(TBIdCliVenta.Text), cantidadVenta, CDec(TBTotalVenta.Text), dgvListaVentas) Then
                    MsgBox("Se completo la venta", vbExclamation, "Venta confirmada")
                    TBIdCliVenta.Clear()
                    TBNombreCliVenta.Clear()
                    TBApellido.Clear()
                    TBTelCli.Clear()
                    TBDniCliente.Clear()
                    TBTotalVenta.Text = 0
                    cantidadVenta = 0
                    dgvListaVentas.Rows.Clear()
                    TBNroFactura.Text = objDfactura.buscarfactura2() + 1
                End If
            End If
        End If
    End Sub




    Private Sub BVolver_Click_1(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub

    Private Sub AñadirVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TBVendedor.Text = idUsuario
        Bconfmodificacion.Visible = False
        If objDfactura.buscarfactura() = 0 Then
            TBNroFactura.Text = 1
        Else
            TBNroFactura.Text = objDfactura.buscarfactura2() + 1
        End If
        TBTotalVenta.Text = 0
        AgregarProducto.Enabled = False
        dgvListaVentas.ClearSelection()
        TBCantidad.Enabled = False
    End Sub

    Private Sub validar()
        If TBCodigoProducto.Text <> String.Empty Or TBCantidad.Text <> String.Empty Then
            AgregarProducto.Enabled = True
        End If
    End Sub


    Private Sub AgregarProducto_Click(sender As Object, e As EventArgs) Handles AgregarProducto.Click
        Dim codigo As Integer = CInt(TBCodigoProducto.Text)
        Dim precio As Decimal = CDec(TBPrecio.Text)
        Dim cantidad As Integer = CInt(TBCantidad.Text)
        Dim talle As Integer = CInt(TBTalle.Text)
        Dim cantfila As Integer = dgvListaVentas.Rows.Count() - 1
        Dim stock As Integer = CInt(TBStock.Text)
        Dim i As Integer
        Dim res As Boolean = True
        For i = 0 To cantfila
            If dgvListaVentas.Item(0, i).Value = codigo And dgvListaVentas.Item(5, i).Value = talle Then
                cantidadVenta = cantidadVenta - dgvListaVentas.Item(3, i).Value
                dgvListaVentas.Item(3, i).Value = dgvListaVentas.Item(3, i).Value + CInt(TBCantidad.Text)
                cantidadVenta = cantidadVenta + dgvListaVentas.Item(3, i).Value
                dgvListaVentas.Item(4, i).Value = dgvListaVentas.Item(4, i).Value + precio
                TBTotalVenta.Text = CDec(TBTotalVenta.Text) + dgvListaVentas.Item(2, i).Value
                res = False
            End If
        Next
        If res = True Then
            cantidadVenta = cantidadVenta + cantidad
            Dim subtotal As Decimal = precio * cantidad
            TBTotalVenta.Text = CDec(TBTotalVenta.Text) + subtotal
            dgvListaVentas.Rows.Add(codigo, descripcionProd, precio, cantidad, subtotal, talle, stock)
            dgvListaVentas.ClearSelection()
        End If
        TBCodigoProducto.Clear()
        TBPrecio.Clear()
        TBStock.Clear()
        TBTalle.Clear()
        TBCantidad.Clear()
    End Sub

    Private Sub BModificarProducto_Click(sender As Object, e As EventArgs) Handles BModificarProducto.Click
        Bconfmodificacion.Visible = True
        If (dgvListaVentas.SelectedRows.Count > 0) Or (dgvListaVentas.SelectedCells.Count > 0) Then
            modprod = True
            TBCodigoProducto.Text = dgvListaVentas.CurrentRow.Cells(0).Value.ToString
            TBPrecio.Text = dgvListaVentas.CurrentRow.Cells(2).Value.ToString
            TBCantidad.Text = dgvListaVentas.CurrentRow.Cells(3).Value.ToString
            TBTalle.Text = dgvListaVentas.CurrentRow.Cells(5).Value.ToString
            TBStock.Text = dgvListaVentas.CurrentRow.Cells(6).Value.ToString
            'dgvListaVentas.Rows.Remove(dgvListaVentas.CurrentRow)
        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If
    End Sub

    Private Sub BEliminarProducto_Click_1(sender As Object, e As EventArgs) Handles BEliminarProducto.Click
        If (dgvListaVentas.SelectedRows.Count > 0) Or (dgvListaVentas.SelectedCells.Count > 0) Then
            TBTotalVenta.Text = CDec(TBTotalVenta.Text) - CDec(dgvListaVentas.CurrentRow.Cells(4).Value.ToString)
            dgvListaVentas.Rows.Remove(dgvListaVentas.CurrentRow)
        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If
    End Sub

    Private Sub TBCantidad_TextChanged(sender As Object, e As EventArgs) Handles TBCantidad.TextChanged
        If Not TBCantidad.Text = "" Then
            AgregarProducto.Enabled = True
        Else
            AgregarProducto.Enabled = False
        End If
    End Sub

    Private Sub TBCodigoProducto_TextChanged(sender As Object, e As EventArgs) Handles TBCodigoProducto.TextChanged
        If TBCodigoProducto.Text = "" Then
            TBCantidad.Enabled = False
        Else
            TBCantidad.Enabled = True
        End If
    End Sub

    Private Sub Bconfmodificacion_Click(sender As Object, e As EventArgs) Handles Bconfmodificacion.Click
        Dim fila = dgvListaVentas.CurrentRow()
        Dim codigo As Integer = CInt(TBCodigoProducto.Text)
        Dim precio As Decimal = CDec(TBPrecio.Text)
        Dim cantidad As Integer = CInt(TBCantidad.Text)
        Dim talle As Integer = CInt(TBTalle.Text)
        Dim cantfila As Integer = dgvListaVentas.Rows.Count() - 1
        Dim stock As Integer = CInt(TBStock.Text)
        Dim i As Integer
        Dim res As Boolean = True
        For i = 0 To cantfila
            If dgvListaVentas.Item(0, i).Value = codigo And dgvListaVentas.Item(5, i).Value = talle And modprod = True Then
                Dim subtotactual As Decimal = CDec(dgvListaVentas.Item(4, i).Value.ToString)
                TBTotalVenta.Text = CDec(TBTotalVenta.Text) - subtotactual
                Dim subtotal As Decimal = precio * cantidad
                TBTotalVenta.Text = CDec(TBTotalVenta.Text) + subtotal
                dgvListaVentas.Item(4, i).Value = subtotal
                cantidadVenta = cantidadVenta - dgvListaVentas.Item(3, i).Value
                dgvListaVentas.Item(3, i).Value = CInt(TBCantidad.Text)
                cantidadVenta = cantidadVenta + dgvListaVentas.Item(3, i).Value
                modprod = False
                Bconfmodificacion.Visible = False
            End If
        Next
        TBCodigoProducto.Clear()
        TBPrecio.Clear()
        TBStock.Clear()
        TBTalle.Clear()
        TBCantidad.Clear()
    End Sub

End Class