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
        Dim listarEmpleado = (From c In ctx.empleados Select c).ToList
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
            EmpMod.email = correo
            ctx.SaveChanges()
            Return True
        Catch ex As Exception
            MsgBox("No se han podido implementar los cambios", vbCritical, "Error")
            Return False
        End Try

    End Function
End Class

