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

    Function ModCateg(idcateg As Integer, descripcion As String) As Boolean
        Try
            Dim CategMod = (From c In ctx.Categoria Where c.id_categoria = idcateg
                            Select c).First
            CategMod.descripcion_categoria = descripcion
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try

    End Function

    Function EliminarCateg(idcateg As Integer) As Boolean
        Try
            Dim CategMod = (From c In ctx.Categoria Where c.id_categoria = idcateg
                            Select c).First
            CategMod.id_estado_categoria = 0
            ctx.SaveChanges()
            MsgBox("Se ha eliminado con exito", vbInformation, "Confirmar Eliminación")
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try

    End Function

    Function AltaCateg(idcateg As Integer) As Boolean
        Try
            Dim CategMod = (From c In ctx.Categoria Where c.id_categoria = idcateg
                            Select c).First
            CategMod.id_estado_categoria = 1
            MsgBox("Se ha dado de alta con exito", vbInformation, "Confirmar Alta")
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try

    End Function
End Class
