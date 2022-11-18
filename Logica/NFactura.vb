Imports System.Windows.Media

Public Class NFactura

    Function agregar_factura(iduser As Integer, idcli As Integer, cantidad As Integer, importe As Decimal, dgv As DataGridView)
        Dim objdfacturadetalle = New DFacturaDetalle
        Dim objdfactura = New DFactura
        Dim dgvConStock As DataGridView = dgv
        Dim i As Integer
        Dim resultado As Boolean = True
        Dim ofactura = New factura
        Dim objdtalleProd = New DTalle_Producto
        Dim cantidadsolicitada As Integer
        Dim codigo As Integer
        Dim talledesc As Integer
        Dim objdtalle = New DTalle
        Dim talleid As Integer
        With ofactura
            .id_usuario = iduser
            .id_cliente = idcli
            .fecha_factura = Date.Now
            .cantidad_factura = cantidad
            .importe_factura = importe
        End With
        For i = 0 To (dgv.Rows().Count().ToString - 1)
            Dim odetalle = New detalles_factura
            cantidadsolicitada = dgv.Item(3, i).Value
            codigo = dgv.Item(0, i).Value
            talledesc = dgv.Item(5, i).Value
            talleid = objdtalle.getTallesId(talledesc)
            'row = dgv.Rows(i)

            If objdtalleProd.validarStock(codigo, talleid, cantidadsolicitada) Then
                resultado = False
                MsgBox("No hay stock disponible, para el producto" + " " + dgv.Item(1, i).Value.ToString + " En el talle: " + dgv.Item(5, i).Value.ToString)
                'Abrir factura'
                Return False
                Exit Function
            End If
        Next
        If resultado = True Then
            If objdfactura.Dguardar_factura(ofactura) Then
                For i = 0 To (dgv.Rows.Count() - 1)
                    codigo = CInt(dgv.Item(0, i).Value.ToString)
                    talledesc = CInt(dgv.Item(5, i).Value.ToString)
                    talleid = objdtalle.getTallesId(talledesc)
                    Dim idtalleprod As Integer = objdtalleProd.talleProd(codigo, talleid)
                    cantidadsolicitada = CInt(dgv.Item(3, i).Value.ToString)
                    Dim precioUnit As Decimal = CDec(dgv.Item(2, i).Value.ToString)
                    Dim odetalle = New detalles_factura
                    'row = dgv.Rows(i)
                    With odetalle
                        .id_factura = ofactura.id_factura
                        .id_talle_prod = talleid 'id talle producto'
                        .cantidad_detalle = cantidadsolicitada ' cantidad de productos'
                        .importe_detalle = precioUnit 'precio unitario del producto'
                    End With
                    Dim d As String = odetalle.id_talle_prod.ToString
                    If objdfacturadetalle.Dguardar_facturaDetalle(odetalle) Then
                        Dim objDTalle_Prod = New DTalle_Producto
                        objDTalle_Prod.ActualizarStock(idtalleprod, cantidadsolicitada)
                    End If
                Next
                Return True
            Else
                Return False
            End If
        End If
        Return False
    End Function


    Public Sub cargarGridVendedor(grid As DataGridView, iduser As Integer)
        Dim vent As DFactura = New DFactura
        grid.DataSource = vent.getVentasVendedorAll(iduser)
        grid.Columns(0).HeaderText = "N° Factura"
        grid.Columns(1).HeaderText = "Nombre Cliente"
        grid.Columns(2).HeaderText = "Apellido Cliente"
        grid.Columns(3).HeaderText = "Fecha"
        grid.Columns(4).HeaderText = "Importe"
        grid.Columns(5).HeaderText = "Cantidad"
        grid.ClearSelection()
    End Sub
    Public Sub cargarGrid(grid As DataGridView)
        Dim vent As DFactura = New DFactura
        grid.DataSource = vent.getVentasAll()
        grid.Columns(0).HeaderText = "N° Factura"
        grid.Columns(1).Visible = False
        grid.Columns(2).HeaderText = "Nombre Vendedor"
        grid.Columns(3).HeaderText = "Apellido Vendedor"
        grid.Columns(4).HeaderText = "Nombre Cliente"
        grid.Columns(5).HeaderText = "Apellido Cliente"
        grid.Columns(6).HeaderText = "Fecha"
        grid.Columns(7).HeaderText = "Importe"
        grid.Columns(8).HeaderText = "Cantidad"
        grid.ClearSelection()
    End Sub
End Class
