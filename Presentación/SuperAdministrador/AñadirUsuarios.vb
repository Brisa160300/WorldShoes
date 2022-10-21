Public Class añadirUsuarios
    Private objNUsuario = New NUsuario
    Private objNEmpleado = New NEmpleado
    Private objNPerfil = New NPerfil
    Private objDPerfil = New DPerfil

    Public Function EspacioEnBlanco() As Boolean
        Dim Ask As MsgBoxResult
        Dim Ask1 As MsgBoxResult
        Dim nombre As String = TBNombreUsuario.Text
        Dim pass As String = TBContraseñaUsuario.Text
        Dim confpass As String = TBConfirmarPass.Text
        Dim empleado As String = TBEmpleado.Text
        If String.IsNullOrWhiteSpace(nombre) Or String.IsNullOrWhiteSpace(pass) Or String.IsNullOrWhiteSpace(confpass) Or String.IsNullOrWhiteSpace(empleado) Then
            Ask = MsgBox("Debe Completar todos los campos", vbCritical, "Error")
            Return True
        ElseIf Not TBContraseñaUsuario.Text.Count = 8 Then
            Ask1 = MsgBox("sLa contraseña debe ser de 8 caracteres", vbExclamation, "Contraseña invalida")
            TBContraseñaUsuario.Focus()
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub TBNombreUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreUsuario.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")

        End If
    End Sub

    Private Sub TBContraseñaUsuario_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            If TBContraseñaUsuario.Text.Count > 7 Then
                e.Handled = True
                MsgBox("La contraseña solo puede tener 8 digitios")
            End If
        End If

    End Sub

    Private Sub BRegistrarUsuario_Click(sender As Object, e As EventArgs) Handles BRegistrarUsuario.Click
        Dim ask As MsgBoxResult
        If EspacioEnBlanco() = False Then
            Dim nombre As String = TBNombreUsuario.Text
            Dim contraseña As String = TBContraseñaUsuario.Text
            Dim confcontraseña As String = TBConfirmarPass.Text
            Dim id_perfil As Integer = CBPerfil.SelectedValue
            Dim id_empleado As Integer = CInt(TBEmpleado.Text)
            MsgBox(id_perfil)
            If contraseña <> confcontraseña Then
                MsgBox("Las contraseñas no coinciden")
                TBConfirmarPass.Clear()
                TBContraseñaUsuario.Clear()
                TBContraseñaUsuario.Focus()
            Else
                ask = MsgBox("Esta seguro que desea registrar un nuevo usuario", vbYesNo + vbQuestion, "Confirmar nuevo usuario")
                If ask = vbYes Then
                    If objNUsuario.agregar_Usuario(nombre, contraseña, id_perfil, id_empleado) Then
                        objNUsuario.cargarGrid(dgvListaUsuarios)
                        MsgBox("Registrado con exito", vbInformation)
                    Else
                        MsgBox("No se pudo realizar el registro", vbCritical, "Error")
                    End If
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