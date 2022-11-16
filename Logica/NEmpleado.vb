Public Class NEmpleado
    Function agregar_Empleado(nombre As String, apellido As String, dni As Integer, telefono As ULong, direccion As String, email As String)
        Dim oEmpleado = New empleados
        With oEmpleado
            .nombre = nombre
            .apellido = apellido
            .dni = dni
            .telefono = telefono
            .direccion = direccion
            .correo = email
            .estado_empleado = 1
        End With
        Dim objdEmpleado = New DEmpleado
        If objdEmpleado.Dguardar_empleado(oEmpleado) Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Sub cargarGrid(grid As DataGridView)
        Dim emplead As DEmpleado = New DEmpleado
        grid.DataSource = emplead.getEmpleadosEstadoAll()
        grid.Columns(0).HeaderText = "ID"
        grid.Columns(1).HeaderText = "Nombre"
        grid.Columns(2).HeaderText = "Apellido"
        grid.Columns(3).HeaderText = "DNI"
        grid.Columns(4).HeaderText = "Telefono"
        grid.Columns(5).HeaderText = "Direccion"
        grid.Columns(6).HeaderText = "Correo Electronico"
        grid.Columns(7).HeaderText = "Estado"
        grid.ClearSelection()
    End Sub
End Class
