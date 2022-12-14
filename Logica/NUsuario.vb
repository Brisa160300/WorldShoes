Public Class NUsuario

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
        grid.Columns(0).Visible = False
        grid.Columns(1).Visible = False
        grid.Columns(2).HeaderText = "Nombre Usuario"
        grid.Columns(3).HeaderText = "Contraseña"
        grid.Columns(4).HeaderText = "Perfil Usuario"
        grid.Columns(5).HeaderText = "Estado"
        grid.Columns(6).HeaderText = "ID Empleado"
        grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        grid.ClearSelection()

    End Sub

    Public Sub cargarComboxPerfiles(combo As ComboBox)
        Dim perf As DPerfil = New DPerfil
        combo.DataSource = perf.getPerfilAll()
        combo.DisplayMember = "descripcion"
        combo.ValueMember = "id_perfil"
        combo.DropDownStyle = 2
        combo.SelectedValue = -1
        combo.FlatStyle = FlatStyle.Flat

    End Sub
    'cambio aca------------------------------------------------------------'
    Public Sub cargarComboxPerfiles2(combo As ComboBox, perfil As String)
        Dim perf As DPerfil = New DPerfil
        combo.DataSource = perf.getPerfilAll()
        combo.DisplayMember = "descripcion"
        combo.ValueMember = "id_perfil"
        combo.DropDownStyle = 2
        combo.SelectedValue = -1
        combo.FlatStyle = FlatStyle.Flat
        combo.SelectedIndex = combo.FindString(perfil)
    End Sub
    Public Sub cargarComboxDNI(combo As ComboBox)
        Dim user As DUsuario = New DUsuario
        combo.DataSource = user.getUsuariosAll()
        combo.DisplayMember = "dni"
        combo.ValueMember = "dni"
        combo.DropDownStyle = 2
        combo.SelectedValue = -1
        combo.FlatStyle = FlatStyle.Flat
    End Sub


End Class
