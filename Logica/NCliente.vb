Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox

Public Class NCliente
    Function agregar_cliente(nombre As String, apellido As String, dni As Integer, telefono As ULong, direccion As String, email As String)
        Dim ocliente = New clientes
        With ocliente
            .Nombre = nombre
            .Apellido = apellido
            .Dni = dni
            .telefono = telefono
            .direccion = direccion
            .email = email
            .id_estado_cliente = 1
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
        grid.Columns(6).HeaderText = "Correo Electronico"
        grid.ClearSelection()
    End Sub

    Public Sub cargarComboxDNI(combo As ComboBox)
        Dim user As Dcliente = New Dcliente
        combo.DataSource = user.getClientesAll()
        combo.DisplayMember = "Dni"
        combo.ValueMember = "Dni"
        combo.DropDownStyle = 2
        combo.SelectedValue = -1
    End Sub


End Class
