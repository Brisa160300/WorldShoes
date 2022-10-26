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

    Function getProductossAll() As List(Of EProducto)
        Dim listaTalle = (From t In ctx.talle_producto Select t).ToList
        Dim listaProductos = New List(Of EProducto)
        For Each valor In listaTalle
            Dim item As EProducto = New EProducto
            item.Nombre = valor.Productos.nombre
            item.Descripcion_categoria = valor.Productos.Categoria.descripcion_categoria
            item.Stock = valor.Productos.stock
            item.Precio = valor.Productos.precio
            item.Descripcion_marca = valor.Productos.Marcas.Descripcion
            item.Descripcion_talle = valor.talle.descripcion
            If valor.Productos.id_estado_producto = 1 Then
                item.Estado = "Activo"
            Else
                item.Estado = "Inactivo"
            End If

            listaProductos.Add(item)
        Next
        Return listaProductos
    End Function

    Function modproducto(idprod As Integer, nombre As String, categoria As String, stock As Integer, precio As Integer,
                        marca As String) As Boolean
        Try
            Dim proMod = (From p In ctx.Productos Where p.cod_producto = idprod
                          Select p).First
            proMod.nombre = nombre
            proMod.id_categoria = categoria
            proMod.stock = stock
            proMod.precio = precio
            proMod.id_marca = marca
            proMod.id_estado_producto = 1
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
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
End Class
