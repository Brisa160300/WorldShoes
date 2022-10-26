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

    Function modempleado(idempleado As Integer, nombre As String, apel As String, dni As Integer, tel As Integer,
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
End Class

