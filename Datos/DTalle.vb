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
End Class