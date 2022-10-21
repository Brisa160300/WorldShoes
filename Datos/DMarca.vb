Public Class DMarca
    Dim ctx As WorldShoes_Roman_RiosEntities = New WorldShoes_Roman_RiosEntities
    Function Dguardar_marca(omarca As Marcas) As Boolean
        Try
            ctx.Marcas.Add(omarca)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Function getMarcasAll() As List(Of Marcas)
        Dim listarMarca = (From m In ctx.Marcas Select m).ToList
        Return listarMarca
    End Function

    Function ModMarca(idmarca As Integer, descripcion As String) As Boolean
        Try
            Dim CategMod = (From c In ctx.Marcas Where c.id_Marca = idmarca
                            Select c).First
            CategMod.Descripcion = descripcion
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try

    End Function

    Function EliminarMarca(idMarca As Integer) As Boolean
        Try
            Dim MarcaDelete = (From c In ctx.Marcas Where c.id_Marca = idMarca
                               Select c).First
            MarcaDelete.Estado = 0
            ctx.SaveChanges()
            MsgBox("Se ha eliminado con exito", vbInformation, "Confirmar Eliminación")
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try

    End Function

    Function AltaMarca(idMarca As Integer) As Boolean
        Try
            Dim MarcaAlta = (From c In ctx.Marcas Where c.id_Marca = idMarca
                             Select c).First
            MarcaAlta.Estado = 1
            MsgBox("Se ha dado de alta con exito", vbInformation, "Confirmar Alta")
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try
    End Function
End Class
