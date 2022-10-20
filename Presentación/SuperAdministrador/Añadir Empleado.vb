Public Class Añadir_Empleado
    Private Sub BVolver_Click(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub

    Private objNEmpleado = New NEmpleado
    Public Function EspacioEnBlanco()
        Dim Ask As MsgBoxResult
        Dim nombre As String = TBNombreEmpleado.Text
        Dim apellido As String = TBApellidoEmpleado.Text
        Dim dni As String = TBDniEmpleado.Text
        Dim tel As String = TBTelEmpleado.Text
        Dim correo As String = TBCorreoEmpleado.Text


        If String.IsNullOrWhiteSpace(apellido) Or
           String.IsNullOrWhiteSpace(nombre) Or
           String.IsNullOrWhiteSpace(dni) Or
           String.IsNullOrWhiteSpace(tel) Or
           String.IsNullOrWhiteSpace(correo) Then
            Ask = MsgBox("Debe Completar todos los campos", vbCritical, "Error")
            Return Ask
        Else
            Return False
        End If
    End Function

    Private Sub BRegistrarEmpleado_Click(sender As Object, e As EventArgs) Handles BRegistrarEmpleado.Click
        Dim nombre As String = TBNombreEmpleado.Text
        Dim apellido As String = TBApellidoEmpleado.Text
        Dim dni As Integer = CInt(TBDniEmpleado.Text)
        Dim tel As ULong = CLng(TBTelEmpleado.Text)
        Dim direccion As String = TBDireccionEmpleado.Text
        Dim email As String = TBCorreoEmpleado.Text

        If EspacioEnBlanco() = False Then
            MsgBox("Seguro que desea insertar un nuevo Empleado?", vbQuestion + vbYesNo, "Confirmar Inserción")
            If vbYes Then

                If objNEmpleado.agregar_Empleado(nombre, apellido, dni, tel, direccion, email) Then
                    MsgBox("El Empleado: " + apellido + " " + nombre + " se registró correctamente", vbOKOnly + MsgBoxStyle.Information, "Registro exitoso")
                    objNEmpleado.cargarGrid(dgvEmpleados)
                    TBDniEmpleado.Clear()
                    TBNombreEmpleado.Clear()
                    TBApellidoEmpleado.Clear()
                    TBTelEmpleado.Clear()
                    TBDireccionEmpleado.Clear()
                    TBCorreoEmpleado.Clear()
                Else
                    MsgBox("El Empleado ya se encuentra registrado", vbOKOnly + MsgBoxStyle.Critical, "DNI duplicado")
                    TBDniEmpleado.Clear()
                    TBDniEmpleado.Focus()
                End If
            End If
        End If

    End Sub

    Private Sub TBVerficarLetra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreEmpleado.KeyPress, TBApellidoEmpleado.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")

        End If
    End Sub

    Private Sub TBVerificarNumeros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBTelEmpleado.KeyPress, TBDniEmpleado.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan caracteres númericos", vbCritical, "Error")
        End If
    End Sub

    Private Sub Añadir_Empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNEmpleado.cargarGrid(dgvEmpleados)
    End Sub
End Class