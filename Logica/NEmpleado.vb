Public Class NEmpleado
    Function agregar_Empleado(nombre As String, apellido As String, dni As Integer, telefono As Integer, direccion As String, email As String)
        Dim oEmpleado = New Empleados
        With oEmpleado
            .Nombre = nombre
            .Apellido = apellido
            .Dni = dni
            .telefono = telefono
            .direccion = direccion
            .correo = email
            .estado_empleado = 1
        End With
        Dim objdEmpleado = New DEmpleado
        If objdEmpleado.Dguardar_Empleado(oEmpleado) Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Sub cargarGrid(grid As DataGridView)
        Dim emplead As DEmpleado = New DEmpleado
        grid.DataSource = emplead.getEmpleadosAll()
        grid.Columns(0).HeaderText = "ID"
        grid.Columns(1).HeaderText = "Nombre"
        grid.Columns(2).HeaderText = "Apellido"
        grid.Columns(3).HeaderText = "DNI"
        grid.Columns(4).HeaderText = "Telefono"
        grid.Columns(5).HeaderText = "Direccion"
        grid.Columns(6).HeaderText = "Correo Electronico"
        grid.Columns(7).Visible = False
        grid.Columns(8).Visible = False
        grid.ClearSelection()

    End Sub
End Class
