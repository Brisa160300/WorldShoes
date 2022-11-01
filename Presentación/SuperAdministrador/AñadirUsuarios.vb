Public Class añadirUsuarios
    Private objNUsuario = New NUsuario
    Private objNEmpleado = New NEmpleado
    Private objNPerfil = New NPerfil
    Private objDPerfil = New DPerfil

    Public Function EspacioEnBlanco() As Boolean
        Dim Ask As Boolean = False
        Dim nombre As String = TBNombreUsuario.Text.Trim
        Dim pass As String = TBContraseñaUsuario.Text.Trim
        Dim confpass As String = TBConfirmarPass.Text.Trim
        Dim empleado As String = TBEmpleado.Text.Trim
        Dim perfil As String = CBPerfil.SelectedValue
        If nombre = "" Then
            ErrorProviderNombre.SetError(TBNombreUsuario, "Ingrese un nombre de usuario")
            Ask = True
        ElseIf nombre.Length < 3 Then
            ErrorProviderNombre.SetError(TBNombreUsuario, "El nombre ingresado debe tener un minimo de 3 caracteres")
            Ask = True
        End If
        If pass = "" Then
            ErrorProviderPass.SetError(TBContraseñaUsuario, "Ingrese una contraseña")
            Ask = True
        ElseIf pass <> confpass Then
            ErrorProviderPass.SetError(TBContraseñaUsuario, "Las contraseñas no coinciden")
            ErrorProviderConfPass.SetError(TBConfirmarPass, "Las contraseñas no coinciden")
            Ask = True
        ElseIf pass.Length <> 8 Then
            ErrorProviderPass.SetError(TBContraseñaUsuario, "La contraseña debe debe tener 8 digitos")
            Ask = True
        End If
        If empleado = "" Then
            ErrorProviderEmpleado.SetError(TBEmpleado, "Seleccione un empleado de la lista de empleados")
            Ask = True
        End If
        If perfil = "" Then
            ErrorProviderPerfil.SetError(CBPerfil, "Seleccione un perfil")
            Ask = True
        End If
        Return Ask

    End Function

    Private Sub TBNombreUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreUsuario.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")

        End If
    End Sub

    Private Sub TBContraseñaUsuario_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan digitos numericos", vbCritical, "Error")
        End If

    End Sub

    Private Sub BRegistrarUsuario_Click(sender As Object, e As EventArgs) Handles BRegistrarUsuario.Click
        Dim ask As MsgBoxResult
        ErrorProviderNombre.Clear()
        ErrorProviderEmpleado.Clear()
        ErrorProviderPass.Clear()
        ErrorProviderConfPass.Clear()
        ErrorProviderPerfil.Clear()
        If EspacioEnBlanco() = False Then
            Dim nombre As String = TBNombreUsuario.Text
            Dim contraseña As String = TBContraseñaUsuario.Text
            Dim id_perfil As Integer = CBPerfil.SelectedValue
            Dim id_empleado As Integer = CInt(TBEmpleado.Text)
            ask = MsgBox("Esta seguro que desea registrar un nuevo usuario", vbYesNo + vbQuestion, "Confirmar nuevo usuario")
            If ask = vbYes Then
                If objNUsuario.agregar_Usuario(nombre, contraseña, id_perfil, id_empleado) Then
                    objNUsuario.cargarGrid(dgvListaUsuarios)
                    MsgBox("Registrado con exito", vbInformation)
                Else
                    MsgBox("El cliente ya se encuentra registrado", vbCritical, "Error")
                End If
            End If
        End If
    End Sub

    Private Sub BVolver_Click(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub

    Private Sub añadirUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNUsuario.cargarGrid(dgvListaUsuarios)
        objNUsuario.cargarComboxPerfiles(CBPerfil)
        objNEmpleado.cargarGrid(dgvEmpleados)
    End Sub

    Private Sub dgvEmpleados_DoubleClick(sender As Object, e As EventArgs) Handles dgvEmpleados.DoubleClick
        TBEmpleado.Text = dgvEmpleados.CurrentRow.Cells(0).Value.ToString

    End Sub
    Private Sub añadirUsuarios_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        dgvEmpleados.ClearSelection()
        TBEmpleado.Clear()
    End Sub

    Private Sub dgvEmpleados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleados.CellClick
        TBEmpleado.Text = dgvEmpleados.CurrentRow.Cells(0).Value.ToString
    End Sub

End Class