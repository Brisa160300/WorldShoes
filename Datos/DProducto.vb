Imports System.Data.Sql
Imports System.Data.SqlClient
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
            If valor.Productos.id_estado_producto = 1 Then
                item.Estado = "Activo"
            Else
                item.Estado = "Inactivo"
            End If
            listaProductos.Add(item)
        Next
        Return listaProductos
    End Function

    Function getProductosAll() As List(Of EDetalleProducto)
        Dim listaTalle = (From tp In ctx.talle_producto Select tp).ToList
        Dim listaProductos = New List(Of EDetalleProducto)
        For Each valor In listaTalle
            Dim item As EDetalleProducto = New EDetalleProducto
            item.Codigo = valor.Productos.cod_producto
            item.Nombre = valor.Productos.nombre
            item.Descripcion_categoria = valor.Productos.Categoria.descripcion_categoria
            item.Precio = valor.Productos.precio
            item.Descripcion_marca = valor.Productos.Marcas.Descripcion
            item.Id_marca = valor.Productos.Marcas.id_Marca
            item.Id_categ = valor.Productos.Categoria.id_categoria
            If valor.Productos.id_estado_producto = 1 Then
                item.Estado = "Activo"
            Else
                item.Estado = "Inactivo"
            End If
            listaProductos.Add(item)
        Next
        Return listaProductos
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


    'Public Function buscarProductos(p_category As String, p_brand As String, ByVal grid As DataGridView)
    Public Function buscarProductos(p_nombre As String, ByVal grid As DataGridView)
        Try

            Dim objMostrar = (From q In ctx.Productos Where q.nombre.ToString.Contains(p_nombre) 'And q.id_marca.ToString.Contains(p_brand)'
                              Select Codigo = q.cod_producto, Nombre = q.nombre, CategoriaId = q.id_categoria, Stock = "",
                                           Precio = q.precio, Marca = q.id_marca, Estado = q.id_estado_producto, Talle = q.talle_producto).ToList
            grid.DataSource = objMostrar

            grid.Columns.Item(2).Visible = False
            grid.Columns.Item(3).Visible = False
            grid.Columns.Item(5).Visible = False
            grid.Columns.Item(6).Visible = False
            grid.Columns.Item(7).Visible = False

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class

