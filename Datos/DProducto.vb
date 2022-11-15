Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Windows.Media

Public Class DProducto
    Dim ctx As WorldShoes_Roman_RiosEntities = New WorldShoes_Roman_RiosEntities

    Function Dguardar_producto(oproducto As Productos) As Boolean
        Try
            ctx.Productos.Add(oproducto)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function getProductosDetallesAll() As List(Of EProducto)
        Dim listaTalle = (From tp In ctx.talle_producto Select tp).ToList
        Dim listaProductos = New List(Of EProducto)
        For Each valor In listaTalle
            If valor.estado_talle_producto = 1 Then
                Dim item As EProducto = New EProducto
                item.Codigo = valor.Productos.cod_producto
                item.Nombre = valor.Productos.nombre
                item.Descripcion_categoria = valor.Productos.Categoria.descripcion_categoria
                item.Stock = valor.cantidad_talle
                item.Precio = valor.Productos.precio
                item.Descripcion_marca = valor.Productos.Marcas.Descripcion
                item.Descripcion_talle = valor.talle.descripcion
                item.Id_marca = valor.Productos.Marcas.id_Marca
                item.Id_talle = valor.talle.id_talle
                item.Id_categ = valor.Productos.Categoria.id_categoria
                item.Id_talle_prod = valor.id_talle_prod
                If valor.estado_talle_producto = 1 Then
                    item.Estado = "Activo"
                Else
                    item.Estado = "Inactivo"
                End If
                listaProductos.Add(item)
            End If
        Next
        Return listaProductos
    End Function

    Function getProductosAll(grid As DataGridView)

        Try
            Dim listaProductos = (From p In ctx.Productos
                                  Order By p.cod_producto
                                  Select Codigo = p.cod_producto,
                                                  Descripcion = p.nombre,
                                                  Categoria = p.Categoria.descripcion_categoria,
                                                  Precio = p.precio, Marca = p.Marcas.Descripcion, Estado = p.id_estado_producto
                                                  ).ToList
            grid.DataSource = listaProductos
            grid.Columns(5).Visible = False
            grid.ClearSelection()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Function getProductosVendedorAll(grid As DataGridView)
        Try
            Dim objMostrar = (From tp In ctx.talle_producto Select tp).ToList
            Dim listaProductos = New List(Of EProducto)
            For Each valor In objMostrar
                If valor.estado_talle_producto = 1 Then
                    Dim item As EProducto = New EProducto
                    item.Codigo = valor.Productos.cod_producto
                    item.Nombre = valor.Productos.nombre
                    item.Descripcion_categoria = valor.Productos.Categoria.descripcion_categoria
                    item.Stock = valor.cantidad_talle
                    item.Precio = valor.Productos.precio
                    item.Descripcion_marca = valor.Productos.Marcas.Descripcion
                    item.Descripcion_talle = valor.talle.descripcion
                    item.Id_marca = valor.Productos.Marcas.id_Marca
                    item.Id_talle = valor.talle.id_talle
                    item.Id_categ = valor.Productos.Categoria.id_categoria
                    item.Id_talle_prod = valor.id_talle_prod
                    If valor.estado_talle_producto = 1 Then
                        item.Estado = "Activo"
                    Else
                        item.Estado = "Inactivo"
                    End If
                    listaProductos.Add(item)
                End If
            Next
            grid.DataSource = listaProductos
            grid.Columns(2).HeaderText = "Categoria"
            grid.Columns(5).HeaderText = "Marca"
            grid.Columns(6).HeaderText = "Talle"
            grid.Columns(7).HeaderText = "Estado"
            grid.Columns(8).Visible = False
            grid.Columns(9).Visible = False
            grid.Columns(10).Visible = False
            grid.Columns(11).Visible = False
            grid.ClearSelection()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Function modProducto(codigo As Integer, nombre As String, categ As Integer, precio As Decimal, marca As Integer) As Boolean
        Try
            Dim pMod = (From p In ctx.Productos Where p.cod_producto = codigo
                        Select p).First
            pMod.nombre = nombre
            pMod.id_categoria = categ
            pMod.precio = precio
            pMod.id_marca = marca
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try

    End Function


    Function DetalleProductosAdmin(grid As DataGridView)
        Try
            Dim listaTalle = (From tp In ctx.talle_producto Order By tp.cod_producto Select tp).ToList
            Dim listaProductos = New List(Of EProducto)
            For Each valor In listaTalle
                If valor.estado_talle_producto = 1 Then
                    Dim item As EProducto = New EProducto
                    item.Codigo = valor.Productos.cod_producto
                    item.Nombre = valor.Productos.nombre
                    item.Descripcion_categoria = valor.Productos.Categoria.descripcion_categoria
                    item.Stock = valor.cantidad_talle
                    item.Precio = valor.Productos.precio
                    item.Descripcion_marca = valor.Productos.Marcas.Descripcion
                    item.Descripcion_talle = valor.talle.descripcion
                    item.Id_marca = valor.Productos.Marcas.id_Marca
                    item.Id_talle = valor.talle.id_talle
                    item.Id_categ = valor.Productos.Categoria.id_categoria
                    item.Id_talle_prod = valor.id_talle_prod
                    If valor.estado_talle_producto = 1 Then
                        item.Estado = "Activo"
                    Else
                        item.Estado = "Inactivo"
                    End If
                    listaProductos.Add(item)
                End If
            Next
            grid.DataSource = listaProductos
            grid.Columns(2).HeaderText = "Categoria"
            grid.Columns(5).HeaderText = "Marca"
            grid.Columns(6).HeaderText = "Talle"
            grid.Columns(7).Visible = False
            grid.Columns(8).Visible = False
            grid.Columns(9).Visible = False
            grid.Columns(10).Visible = False
            grid.Columns(11).Visible = False
            grid.ClearSelection()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Function EliminarProducto(codProd As Integer) As Boolean
        Try
            Dim cliDelete = (From p In ctx.Productos Where p.cod_producto = codProd
                             Select p).First
            cliDelete.id_estado_producto = 0
            ctx.SaveChanges()
            MsgBox("Se ha eliminado con exito", vbInformation, "Confirmar Eliminación")
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try

    End Function

    Function AltaProducto(codProd As Integer) As Boolean
        Try
            Dim cliAlta = (From p In ctx.Productos Where p.cod_producto = codProd
                           Select p).First
            cliAlta.id_estado_producto = 1
            MsgBox("Se ha dado de alta con exito", vbInformation, "Confirmar Alta")
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try

    End Function

    Public Function buscarProductos(p_nombre As String, ByVal grid As DataGridView)
        Try
            Dim objMostrar = (From tp In ctx.talle_producto Where tp.cod_producto.ToString.Contains(p_nombre) Or tp.Productos.Categoria.descripcion_categoria.ToString.Contains(p_nombre) Or tp.Productos.Marcas.Descripcion.ToString.Contains(p_nombre) Or tp.Productos.nombre.ToString.Contains(p_nombre)
                              Select tp).ToList
            Dim listaProductos = New List(Of EProducto)
            For Each valor In objMostrar
                If valor.estado_talle_producto = 1 Then
                    Dim item As EProducto = New EProducto
                    item.Codigo = valor.Productos.cod_producto
                    item.Nombre = valor.Productos.nombre
                    item.Descripcion_categoria = valor.Productos.Categoria.descripcion_categoria
                    item.Stock = valor.cantidad_talle
                    item.Precio = valor.Productos.precio
                    item.Descripcion_marca = valor.Productos.Marcas.Descripcion
                    item.Descripcion_talle = valor.talle.descripcion
                    item.Id_marca = valor.Productos.Marcas.id_Marca
                    item.Id_talle = valor.talle.id_talle
                    item.Id_categ = valor.Productos.Categoria.id_categoria
                    item.Id_talle_prod = valor.id_talle_prod
                    If valor.estado_talle_producto = 1 Then
                        item.Estado = "Activo"
                    Else
                        item.Estado = "Inactivo"
                    End If
                    listaProductos.Add(item)
                End If
            Next
            grid.DataSource = listaProductos
            grid.Columns(2).HeaderText = "Categoria"
            grid.Columns(5).HeaderText = "Marca"
            grid.Columns(6).HeaderText = "Talle"
            grid.Columns(7).HeaderText = "Estado"
            grid.Columns(8).Visible = False
            grid.Columns(9).Visible = False
            grid.Columns(10).Visible = False
            grid.Columns(11).Visible = False
            grid.ClearSelection()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function buscarProductosDetalleAdmin(p_nombre As String, ByVal grid As DataGridView)
        Try
            Dim objMostrar = (From tp In ctx.talle_producto Where tp.cod_producto = p_nombre
                              Select tp).ToList
            Dim listaProductos = New List(Of EProducto)
            For Each valor In objMostrar
                If valor.estado_talle_producto = 1 Then
                    Dim item As EProducto = New EProducto
                    item.Codigo = valor.Productos.cod_producto
                    item.Nombre = valor.Productos.nombre
                    item.Descripcion_categoria = valor.Productos.Categoria.descripcion_categoria
                    item.Stock = valor.cantidad_talle
                    item.Precio = valor.Productos.precio
                    item.Descripcion_marca = valor.Productos.Marcas.Descripcion
                    item.Descripcion_talle = valor.talle.descripcion
                    item.Id_marca = valor.Productos.Marcas.id_Marca
                    item.Id_talle = valor.talle.id_talle
                    item.Id_categ = valor.Productos.Categoria.id_categoria
                    item.Id_talle_prod = valor.id_talle_prod
                    If valor.estado_talle_producto = 1 Then
                        item.Estado = "Activo"
                    Else
                        item.Estado = "Inactivo"
                    End If
                    listaProductos.Add(item)
                End If
            Next
            grid.DataSource = listaProductos
            grid.Columns(2).HeaderText = "Categoria"
            grid.Columns(5).HeaderText = "Marca"
            grid.Columns(6).HeaderText = "Talle"
            grid.Columns(7).HeaderText = "Estado"
            grid.Columns(8).Visible = False
            grid.Columns(9).Visible = False
            grid.Columns(10).Visible = False
            grid.Columns(11).Visible = False
            grid.ClearSelection()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function buscarProductosGeneralAdmin(p_nombre As String, ByVal grid As DataGridView)
        Try
            Dim listaProductos = (From p In ctx.Productos Where p.cod_producto.ToString.Contains(p_nombre) Or p.Categoria.descripcion_categoria.ToString.Contains(p_nombre) Or p.Marcas.Descripcion.ToString.Contains(p_nombre) Or p.nombre.ToString.Contains(p_nombre)
                                  Select Codigo = p.cod_producto,
                                                  Descripcion = p.nombre,
                                                  Categoria = p.Categoria.descripcion_categoria,
                                                  Precio = p.precio, Marca = p.Marcas.Descripcion
                                                  ).ToList
            grid.DataSource = listaProductos
            grid.ClearSelection()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class

