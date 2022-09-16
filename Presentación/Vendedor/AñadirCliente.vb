Public Class AñadirCliente

    Public Function EspacioEnBlanco()
        Dim Ask As MsgBoxResult
        Dim nombre As String = TBNombreCliente.Text
        Dim apellido As String = TBApellidoCliente.Text
        Dim dni As String = TBDniCliente.Text
        'Dim fechaNacimiento = DateTimeCliente
        Dim tel As String = TBTelCliente.Text
        Dim correo As String = TBCorreoCliente.Text
        Dim localidad As String = TBLocalidadCliente.Text


        If String.IsNullOrWhiteSpace(apellido) Or
           String.IsNullOrWhiteSpace(nombre) Or
           String.IsNullOrWhiteSpace(dni) Or
           String.IsNullOrWhiteSpace(tel) Or
           String.IsNullOrWhiteSpace(correo) Or
           String.IsNullOrWhiteSpace(localidad) Then
            Ask = MsgBox("Debe Completar todos los campos", vbCritical, "Error")
            Return Ask
        Else
            Return False
        End If
    End Function


    Private Sub BRegistrarCliente_Click(sender As Object, e As EventArgs) Handles BRegistrarCliente.Click

        If EspacioEnBlanco() = False Then
            MsgBox("Seguro que desea insertar un nuevo Cliente?", vbQuestion + vbYesNo, "Confirmar Inserción")
            If vbYes Then
                MsgBox("El Cliente: " + TBApellidoCliente.Text + " " + TBNombreCliente.Text + " se insertó correctamente", vbInformation, "Guardar")
            End If
        End If
    End Sub

    Private Sub TBNombreCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreCliente.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")
        End If
    End Sub

    Private Sub TBDniCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBTelCliente.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan caracteres númericos", vbCritical, "Error")
        End If
    End Sub

    Private Sub BCancelar_Click(sender As Object, e As EventArgs)

        If EspacioEnBlanco() = False Then
            MsgBox("¿Realmente desea cancelar la operación de registro?", vbExclamation + vbYesNo + vbDefaultButton2, "Confirmar Eliminación")
            If vbYes Then
                MenuVendedor.Show()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub BVolver_Click(sender As Object, e As EventArgs) Handles BVolver.Click
        MenuVendedor.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridViewRegistroCliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewRegistroCliente.CellContentClick

    End Sub
End Class