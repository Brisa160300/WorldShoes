Public Class NCliente
    Function agregar_cliente(nombre As String, apellido As String, dni As Integer, telefono As Integer, direccion As String, email As String) As Boolean
        Dim ocliente = New clientes
        With ocliente
            .Nombre = nombre
            .Apellido = apellido
            .Dni = dni
            .telefono = telefono
            .direccion = direccion
            .email = email
        End With
        Dim objdcliente = New Dcliente
        If objdcliente.Dguardar_cliente(ocliente) Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Sub cargarGrid(grid As DataGridView)
        Dim client As Dcliente = New Dcliente
        grid.DataSource = client.getClientesAll()
        grid.Columns(0).HeaderText = "ID"
        grid.Columns(1).HeaderText = "Nombre"
        grid.Columns(2).HeaderText = "Apellido"
        grid.Columns(3).HeaderText = "DNI"
        grid.Columns(4).HeaderText = "Telefono"
        grid.Columns(5).HeaderText = "Direccion"
        grid.Columns(6).HeaderText = "E-mail"
        grid.Columns(7).Visible = False
        grid.ClearSelection()

    End Sub
End Class
