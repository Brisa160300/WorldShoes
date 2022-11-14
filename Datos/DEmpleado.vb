Public Class DEmpleado
    Dim ctx As WorldShoes_Roman_RiosEntities = New WorldShoes_Roman_RiosEntities
    Function Dguardar_empleado(oempleados As empleados) As Boolean
        Try
            ctx.empleados.Add(oempleados)
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Function getEmpleadosAll() As List(Of empleados)
        Dim listarEmpleado = (From e In ctx.empleados Select e).ToList
        Return listarEmpleado
    End Function

    Function modempleado(idempleado As Integer, nombre As String, apel As String, dni As Integer, tel As Long,
                        domi As String, correo As String) As Boolean
        Try
            Dim EmpMod = (From e In ctx.empleados Where e.Id_empleado = idempleado
                          Select e).First
            EmpMod.nombre = nombre
            EmpMod.apellido = apel
            EmpMod.dni = dni
            EmpMod.telefono = tel
            EmpMod.direccion = domi
            EmpMod.correo = correo
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try

    End Function

    Function AltaEmpleado(idempleado As Integer) As Boolean
        Try
            Dim cliAlta = (From e In ctx.empleados Where e.Id_empleado = idempleado
                           Select e).First
            cliAlta.estado_empleado = 1
            MsgBox("Se ha dado de alta con exito", vbInformation, "Confirmar Alta")
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try

    End Function

    Function EliminarEmpleado(idempleado As Integer) As Boolean
        Try
            Dim cliDelete = (From e In ctx.empleados Where e.Id_empleado = idempleado
                             Select e).First
            cliDelete.estado_empleado = 0
            ctx.SaveChanges()
            MsgBox("Se ha eliminado con exito", vbInformation, "Confirmar Eliminación")
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try

    End Function

    Public Function buscarEmpleado(p_busq As String, ByVal grid As DataGridView)
        Try
            Using Mostrar As New WorldShoes_Roman_RiosEntities
                Dim objMostrar = (From q In Mostrar.empleados Where q.dni.ToString.Contains(p_busq) Or q.nombre.ToString.Contains(p_busq) Or q.apellido.ToString.Contains(p_busq)
                                  Select q).ToList
                grid.DataSource = objMostrar
                grid.Columns(0).HeaderText = "ID"
                grid.Columns(1).HeaderText = "Nombre"
                grid.Columns(2).HeaderText = "Apellido"
                grid.Columns(3).HeaderText = "DNI"
                grid.Columns(4).HeaderText = "Telefono"
                grid.Columns(5).HeaderText = "Direccion"
                grid.Columns(6).HeaderText = "Correo Electronico"
                grid.Columns(5).HeaderText = "Correo Electronico"
                grid.ClearSelection()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class

