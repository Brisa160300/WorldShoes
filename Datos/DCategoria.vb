Public Class DCategoria
    Dim ctx As WorldShoes_Roman_RiosEntities = New WorldShoes_Roman_RiosEntities
    Function Dguardar_categoria(ocategoria As Categoria) As Boolean
        Try
            ctx.Categoria.Add(ocategoria)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Function getCategoriasAll() As List(Of Categoria)
        Dim listarCategoria = (From categ In ctx.Categoria Select categ).ToList
        Return listarCategoria
    End Function
End Class
