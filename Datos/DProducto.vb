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

    Function getProductossAll() As List(Of Productos)
        Dim listarProducto = (From c In ctx.Productos Select c).ToList
        Return listarProducto
    End Function

    Function modproducto(idprod As Integer, nombre As String, cateogria As String, stock As Integer, precio As Integer,
                        marca As String) As Boolean
        Try
            Dim proMod = (From c In ctx.Productos Where c.cod_producto = idprod
                          Select c).First
            proMod.nombre = nombre
            'proMod.Categoria = cateogria'
            proMod.stock = stock
            proMod.precio = precio
            proMod.id_marca = marca
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try

    End Function
End Class
