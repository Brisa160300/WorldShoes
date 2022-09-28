Public Class Dcliente
    Dim ctx As WorldShoes_Roman_RiosEntities = New WorldShoes_Roman_RiosEntities
    Function Dguardar_cliente(ocliente As clientes) As Boolean
        Try
            ctx.clientes.Add(ocliente)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Function getClientesAll() As List(Of clientes)
        Dim listarCliente = (From c In ctx.clientes Select c).ToList
        Return listarCliente
    End Function

End Class
