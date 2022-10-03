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

    Function modcliente(idcli As Integer, nombre As String, apel As String, dni As Integer, tel As Integer,
                        domi As String, correo As String) As Boolean
        Try
            Dim cliMod = (From c In ctx.clientes Where c.Id_Cliente = idcli
                          Select c).First
            cliMod.Nombre = nombre
            cliMod.Apellido = apel
            cliMod.telefono = tel
            cliMod.Dni = dni
            cliMod.direccion = domi
            cliMod.email = correo
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try

    End Function
End Class
