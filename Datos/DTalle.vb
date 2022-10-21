Public Class DTalle
    Dim ctx As WorldShoes_Roman_RiosEntities = New WorldShoes_Roman_RiosEntities
    Function Dguardar_talle(otalle As talle) As Boolean
        Try
            ctx.talle.Add(otalle)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Function getTallesAll() As List(Of talle)
        Dim listartalle = (From t In ctx.talle Select t).ToList
        Return listartalle
    End Function

    Function modTalle(idtalle As Integer, descripcion As String) As Boolean
        Try
            Dim TalleMod = (From c In ctx.talle Where c.id_talle = idtalle
                            Select c).First
            TalleMod.descripcion = descripcion
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try

    End Function

    Function EliminarTalle(idtalle As Integer) As Boolean
        Try
            Dim talleDelete = (From c In ctx.talle Where c.id_talle = idtalle
                               Select c).First
            talleDelete.estado_talle = 0
            ctx.SaveChanges()
            MsgBox("Se ha eliminado con exito", vbInformation, "Confirmar Eliminación")
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try

    End Function

    Function Altatalle(idtalle As Integer) As Boolean
        Try
            Dim talleAlta = (From c In ctx.talle Where c.id_talle = idtalle
                             Select c).First
            talleAlta.estado_talle = 1
            MsgBox("Se ha dado de alta con exito", vbInformation, "Confirmar Alta")
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try

    End Function
End Class