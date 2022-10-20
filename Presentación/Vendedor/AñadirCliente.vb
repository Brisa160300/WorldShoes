Public Class AñadirCliente
    Dim objNcliente = New NCliente
    Public Function EspacioEnBlanco()
        Dim Ask As MsgBoxResult
        Dim nombre As String = TBNombreCliente.Text
        Dim apellido As String = TBApellidoCliente.Text
        Dim dni As String = TBDniCliente.Text
        Dim tel As String = TBTelCliente.Text
        Dim correo As String = TBCorreoCliente.Text


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


    Private Sub BRegistrarCliente_Click(sender As Object, e As EventArgs) Handles BRegistrarCliente.Click
        Dim nombre As String = TBNombreCliente.Text
        Dim apellido As String = TBApellidoCliente.Text
        Dim dni As Integer = CInt(TBDniCliente.Text)
        Dim tel As ULong = CULng(TBTelCliente.Text)
        Dim direccion As String = TBDireccion.Text
        Dim email As String = TBCorreoCliente.Text

        If EspacioEnBlanco() = False Then
            MsgBox("Seguro que desea insertar un nuevo Cliente?", vbQuestion + vbYesNo, "Confirmar Inserción")
            If vbYes Then

                If objNcliente.agregar_cliente(nombre, apellido, dni, tel, direccion, email) Then
                    MsgBox("El Cliente: " + apellido + " " + nombre + " se registró correctamente", vbOKOnly + MsgBoxStyle.Information, "Registro exitoso")
                    objNcliente.cargarGrid(DataGridViewRegistroClientes)
                    TBDniCliente.Clear()
                    TBNombreCliente.Clear()
                    TBApellidoCliente.Clear()
                    TBTelCliente.Clear()
                    TBDireccion.Clear()
                    TBCorreoCliente.Clear()
                Else
                    MsgBox("El cliente ya se encuentra registrado", vbOKOnly + MsgBoxStyle.Critical, "DNI duplicado")
                    TBDniCliente.Clear()
                    TBDniCliente.Focus()
                End If
            End If
        End If

    End Sub

    Private Sub TBNombreCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreCliente.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")

        End If
    End Sub

    Private Sub TBDniCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBTelCliente.KeyPress, TBDniCliente.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan caracteres númericos", vbCritical, "Error")
        End If
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs)

        If EspacioEnBlanco() = False Then
            MsgBox("¿Realmente desea cancelar la operación de registro?", vbExclamation + vbYesNo + vbDefaultButton2, "Confirmar Eliminación")
            If vbYes Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub TBApellidoCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBApellidoCliente.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")
        End If
    End Sub

    Private Sub AñadirCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNcliente.cargarGrid(DataGridViewRegistroClientes)
    End Sub

    Private Sub BCancelar_Click_1(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub

End Class