﻿Public Class NUsuario

    Function agregar_Usuario(nombre As String, contraseña As String, id_perfil As Integer, id_empleado As Integer)
        Dim ousuario = New Usuarios
        With ousuario
            .Nombre = nombre
            .Contraseña = contraseña
            .id_Perfil = id_perfil
            .id_empleado = id_empleado
            .estado_usuario = 1
        End With
        Dim objDUsuario = New DUsuario
        If objDUsuario.Dguardar_usuario(ousuario) Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Sub cargarGrid(grid As DataGridView)
        Dim user As DUsuario = New DUsuario
        grid.DataSource = user.getUsuariosAll()
        grid.Columns(0).HeaderText = "Nombre Empleado"
        grid.Columns(1).HeaderText = "Apellido Empleado"
        grid.Columns(2).HeaderText = "Nombre de Usuario"
        grid.Columns(3).HeaderText = "Contraseña"
        grid.Columns(4).HeaderText = "Perfil"
        grid.Columns(5).HeaderText = "Estado"
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader
        grid.ClearSelection()

    End Sub

    Public Sub cargarComboxPerfiles(combo As ComboBox)
        Dim perf As DPerfil = New DPerfil
        combo.DataSource = perf.getPerfilAll()
        combo.DisplayMember = "Descripcion"
        combo.ValueMember = "id_Perfil"
        combo.SelectedValue = -1

    End Sub
End Class
