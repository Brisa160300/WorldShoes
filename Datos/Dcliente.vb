Imports System.Windows.Documents

Public Class Dcliente
    Dim ctx As WorldShoes_Roman_RiosEntities = New WorldShoes_Roman_RiosEntities
    Function Dguardar_cliente(ocliente As clientes) As Boolean
        Try
            ctx.clientes.Add(ocliente)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function getClientesAll() As List(Of clientes)
        Dim listarCliente = (From c In ctx.clientes
                             Select c).ToList
        Return listarCliente

    End Function



    Function clientesAll(grid As DataGridView)
        Dim lista = (From c In ctx.clientes
                     Select c).ToList
        Dim listaClientes = New List(Of ECliente)
        For Each valor In lista
            Dim item = New ECliente
            item.Id_cliente = valor.Id_Cliente
            item.Nombre = valor.Nombre
            item.Apellido = valor.Apellido
            item.Dni = valor.Dni
            item.Telefono = valor.telefono
            item.Direccion = valor.direccion
            item.Correo = valor.email
            If valor.id_estado_cliente = 1 Then
                item.Estado = "Activo"
            Else
                item.Estado = "Inactivo"
            End If
            listaClientes.Add(item)
        Next
        grid.DataSource = listaClientes
        grid.Columns(0).HeaderText = "ID"
        grid.Columns(6).HeaderText = "Correo Electronico"
        Return True
    End Function

    Function modcliente(idcli As Integer, nombre As String, apel As String, dni As Integer, tel As Integer,
                        domi As String, correo As String) As Boolean
        Try
            Dim cliMod = (From c In ctx.clientes Where c.Id_Cliente = idcli
                          Select c).First
            cliMod.Nombre = nombre
            cliMod.Apellido = apel
            cliMod.Dni = dni
            cliMod.telefono = tel
            cliMod.direccion = domi
            cliMod.email = correo
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try

    End Function

    Function EliminarCliente(idcli As Integer) As Boolean
        Try
            Dim cliDelete = (From c In ctx.clientes Where c.Id_Cliente = idcli
                             Select c).First
            cliDelete.id_estado_cliente = 0
            ctx.SaveChanges()
            MsgBox("Se ha eliminado con exito", vbInformation, "Confirmar Eliminación")
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try

    End Function

    Function AltaCliente(idcli As Integer) As Boolean
        Try
            Dim cliAlta = (From c In ctx.clientes Where c.Id_Cliente = idcli
                           Select c).First
            cliAlta.id_estado_cliente = 1
            MsgBox("Se ha dado de alta con exito", vbInformation, "Confirmar Alta")
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try

    End Function

    Public Function buscarClientes(p_busq As String, ByVal grid As DataGridView)
        Try
            Using Mostrar As New WorldShoes_Roman_RiosEntities
                Dim lista = (From q In Mostrar.clientes Where q.Dni.ToString.Contains(p_busq) Or q.Nombre.ToString.Contains(p_busq) Or q.Apellido.ToString.Contains(p_busq)
                             Select ID = q.Id_Cliente, Nombre = q.Nombre, Apellido = q.Apellido,
                                           DNI = q.Dni, Telefono = q.telefono,
                                           Dirección = q.direccion, q.email, Estado = q.id_estado_cliente).ToList
                Dim listaClientes = New List(Of ECliente)
                For Each valor In lista
                    Dim item = New ECliente
                    item.Id_cliente = valor.ID
                    item.Nombre = valor.Nombre
                    item.Apellido = valor.Apellido
                    item.Dni = valor.Dni
                    item.Telefono = valor.Telefono
                    item.Direccion = valor.Dirección
                    item.Correo = valor.email
                    If valor.Estado = 1 Then
                        item.Estado = "Activo"
                    Else
                        item.Estado = "Inactivo"
                    End If
                    listaClientes.Add(item)
                Next
                grid.DataSource = listaClientes
                grid.Columns(0).HeaderText = "ID"
                grid.Columns(6).HeaderText = "Correo Electronico"
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
