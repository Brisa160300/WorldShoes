Public Class DFactura
    Dim ctx As WorldShoes_Roman_RiosEntities = New WorldShoes_Roman_RiosEntities
    Function Dguardar_factura(ofactura As factura) As Boolean
        Try
            ctx.factura.Add(ofactura)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function getFacturaAll() As List(Of factura)
        Dim listarFactura = (From f In ctx.factura
                             Select f).ToList
        Return listarFactura
    End Function


    Function buscarfactura()
        Dim check = ctx.factura.Count()
        Return check
    End Function

    Function buscarfactura2()
        Dim idf = (From f In ctx.factura
                   Select f.id_factura).Max
        Return idf
    End Function

    Function getVentasVendedorAll(iduser As Integer) As List(Of EVenta)
        Dim listaVentas = (From f In ctx.factura Select f).ToList
        Dim lista = New List(Of EVenta)
        For Each valor In listaVentas
            If valor.id_usuario = iduser Then
                Dim item As EVenta = New EVenta
                item.Id_factura = valor.id_factura
                item.Nombre_cliente = valor.clientes.Nombre
                item.Apellido_cliente = valor.clientes.Apellido
                item.Fecha_factura = valor.fecha_factura
                item.Importe = valor.importe_factura
                item.CantidadProductos = valor.cantidad_factura
                lista.Add(item)
            End If
        Next
        Return lista
    End Function

    Function getVentasDetalle(nroFactura As Integer, grid As DataGridView)
        Try
            Dim listaVentasDetalle = (From q In ctx.detalles_factura Where q.id_factura = nroFactura Select Codigo = q.talle_producto.Productos.cod_producto,
                         Descripcion = q.talle_producto.Productos.nombre, Precio = q.importe_detalle,
                         Cantidad = q.cantidad_detalle, talle = q.talle_producto.talle.descripcion).ToList

            grid.DataSource = listaVentasDetalle
            grid.Columns(0).HeaderText = "N° Factura"
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Function buscarVentasAll(buscar As String, grid As DataGridView)
        Try
            Dim listaVentas = (From f In ctx.factura Where f.clientes.Nombre.ToString.Contains(buscar) Or f.clientes.Apellido.ToString.Contains(buscar) Or f.id_factura.ToString.Contains(buscar) Select f).ToList
            Dim lista = New List(Of EVentaAdmin)
            For Each valor In listaVentas
                Dim item = New EVentaAdmin
                item.Id_vendedor = valor.id_usuario
                item.Nombre_vendedor_ = valor.Usuarios.Nombre
                item.Apellido_vendedor_ = valor.Usuarios.empleados.apellido
                item.Id_factura = valor.id_factura
                item.Nombre_cliente = valor.clientes.Nombre
                item.Apellido_cliente = valor.clientes.Apellido
                item.Fecha_factura = valor.fecha_factura
                item.Importe = valor.importe_factura
                item.CantidadProductos = valor.cantidad_factura
                lista.Add(item)
            Next
            grid.DataSource = lista
            grid.Columns(0).HeaderText = "N° Factura"
            grid.Columns(1).HeaderText = "ID vendedor"
            grid.Columns(2).HeaderText = "Nombre Vendedor"
            grid.Columns(3).HeaderText = "Apellido Vendedor"
            grid.Columns(4).HeaderText = "Nombre Cliente"
            grid.Columns(5).HeaderText = "Apellido Cliente"
            grid.Columns(6).HeaderText = "Fecha"
            grid.Columns(7).HeaderText = "Importe"
            grid.Columns(8).HeaderText = "Cantidad"
            grid.ClearSelection()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function



    Function buscarVentasVendedorAll(iduser As Integer, buscar As String, grid As DataGridView)
        Try
            Dim listaVentas = (From f In ctx.factura Where f.clientes.Nombre.ToString.Contains(buscar) Or f.clientes.Apellido.ToString.Contains(buscar) Or f.id_factura.ToString.Contains(buscar) Select f).ToList
            Dim lista = New List(Of EVenta)
            For Each valor In listaVentas
                If valor.id_usuario = iduser Then
                    Dim item As EVenta = New EVenta
                    item.Id_factura = valor.id_factura
                    item.Nombre_cliente = valor.clientes.Nombre
                    item.Apellido_cliente = valor.clientes.Apellido
                    item.Fecha_factura = valor.fecha_factura
                    item.Importe = valor.importe_factura
                    item.CantidadProductos = valor.cantidad_factura
                    lista.Add(item)
                End If
            Next
            grid.DataSource = lista
            grid.Columns(0).HeaderText = "N° Factura"
            grid.Columns(1).HeaderText = "Nombre Cliente"
            grid.Columns(2).HeaderText = "Apellido Cliente"
            grid.Columns(3).HeaderText = "Fecha"
            grid.Columns(4).HeaderText = "Importe"
            grid.Columns(5).HeaderText = "Cantidad"
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Function getVentasAll() As List(Of EVentaAdmin)
        Dim listaVentas = (From f In ctx.factura Select f).ToList
        Dim lista = New List(Of EVentaAdmin)
        For Each valor In listaVentas
            Dim item = New EVentaAdmin
            item.Id_vendedor = valor.id_usuario
            item.Nombre_vendedor_ = valor.Usuarios.Nombre
            item.Apellido_vendedor_ = valor.Usuarios.empleados.apellido
            item.Id_factura = valor.id_factura
            item.Nombre_cliente = valor.clientes.Nombre
            item.Apellido_cliente = valor.clientes.Apellido
            item.Fecha_factura = valor.fecha_factura
            item.Importe = valor.importe_factura
            item.CantidadProductos = valor.cantidad_factura
            lista.Add(item)
        Next
        Return lista
    End Function


    Function filtrarVentasVendedorAll(iduser As Integer, fechaini As Date, fechafinal As Date, grid As DataGridView)
        Try
            Dim listaVentas = (From f In ctx.factura Where f.fecha_factura >= fechaini And f.fecha_factura <= fechafinal Select f).ToList
            Dim lista = New List(Of EVenta)
            For Each valor In listaVentas
                If valor.id_usuario = iduser Then
                    Dim item As EVenta = New EVenta
                    item.Id_factura = valor.id_factura
                    item.Nombre_cliente = valor.clientes.Nombre
                    item.Apellido_cliente = valor.clientes.Apellido
                    item.Fecha_factura = valor.fecha_factura
                    item.Importe = valor.importe_factura
                    item.CantidadProductos = valor.cantidad_factura
                    lista.Add(item)
                End If
            Next
            grid.DataSource = lista
            grid.Columns(0).HeaderText = "N° Factura"
            grid.Columns(1).HeaderText = "Nombre Cliente"
            grid.Columns(2).HeaderText = "Apellido Cliente"
            grid.Columns(3).HeaderText = "Fecha"
            grid.Columns(4).HeaderText = "Importe"
            grid.Columns(5).HeaderText = "Cantidad"
            grid.ClearSelection()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Function filtrarVentasAdminAll(fechaini As Date, fechafinal As Date, grid As DataGridView)
        Try
            Dim listaVentas = (From f In ctx.factura Where f.fecha_factura >= fechaini And f.fecha_factura <= fechafinal Select f).ToList
            Dim lista = New List(Of EVentaAdmin)
            For Each valor In listaVentas
                Dim item = New EVentaAdmin
                item.Id_vendedor = valor.id_usuario
                item.Nombre_vendedor_ = valor.Usuarios.Nombre
                item.Apellido_vendedor_ = valor.Usuarios.empleados.apellido
                item.Id_factura = valor.id_factura
                item.Nombre_cliente = valor.clientes.Nombre
                item.Apellido_cliente = valor.clientes.Apellido
                item.Fecha_factura = valor.fecha_factura
                item.Importe = valor.importe_factura
                item.CantidadProductos = valor.cantidad_factura
                lista.Add(item)
            Next
            grid.DataSource = lista
            grid.Columns(0).HeaderText = "N° Factura"
            grid.Columns(1).HeaderText = "ID vendedor"
            grid.Columns(2).HeaderText = "Nombre Vendedor"
            grid.Columns(3).HeaderText = "Apellido Vendedor"
            grid.Columns(4).HeaderText = "Nombre Cliente"
            grid.Columns(5).HeaderText = "Apellido Cliente"
            grid.Columns(6).HeaderText = "Fecha"
            grid.Columns(7).HeaderText = "Importe"
            grid.Columns(8).HeaderText = "Cantidad"
            grid.ClearSelection()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function
    Function filtrarVentasAll(iduser As Integer, fechaini As Date, fechafinal As Date, grid As DataGridView)
        Try
            Dim listaVentas = (From f In ctx.factura Where f.fecha_factura >= fechaini And f.fecha_factura <= fechafinal Select f).ToList
            Dim lista = New List(Of EVenta)
            For Each valor In listaVentas
                If valor.id_usuario = iduser Then
                    Dim item As EVenta = New EVenta
                    item.Id_factura = valor.id_factura
                    item.Nombre_cliente = valor.clientes.Nombre
                    item.Apellido_cliente = valor.clientes.Apellido
                    item.Fecha_factura = valor.fecha_factura
                    item.Importe = valor.importe_factura
                    item.CantidadProductos = valor.cantidad_factura
                    lista.Add(item)
                End If
            Next
            grid.DataSource = lista
            grid.Columns(0).HeaderText = "N° Factura"
            grid.Columns(1).HeaderText = "Nombre Cliente"
            grid.Columns(2).HeaderText = "Apellido Cliente"
            grid.Columns(3).HeaderText = "Fecha"
            grid.Columns(4).HeaderText = "Importe"
            grid.Columns(5).HeaderText = "Cantidad"
            grid.ClearSelection()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

End Class
