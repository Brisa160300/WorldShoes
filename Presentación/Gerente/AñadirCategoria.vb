Public Class Añadir_Categoria
    'Dim objNcategory = New Ncategory
    Private Sub TBNombreCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreCategoria.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")
        End If
    End Sub

    Private Sub BRegistrarCategoria_Click(sender As Object, e As EventArgs) Handles BRegistrarCategoria.Click
        If String.IsNullOrWhiteSpace(TBNombreCategoria.Text) Then
            MsgBox("Debe Completar todos los campos", vbCritical, "Error")
        Else
            MsgBox("¿Desea añadir esta nueva categoría?", vbQuestion + vbYesNo, "Confirmar Inserción")
            If vbYes Then
                ' If (objNcategory.agregar_cliente(nombre, apellido, CInt(dni), CInt(tel), direccion, email)) Then
                'MsgBox("La categoría: " + TBNombreCategoria.Text + " se registró correctamente", vbOKOnly + MsgBoxStyle.Information, "Registro exitoso")
                ' objNcategory.cargarGrid(DataGridViewRegistroCategorias)
                MsgBox("se ha añadido correctamente la nueva categoría")
            Else
                MsgBox("La categoría: " + TBNombreCategoria.Text + " ya existe", vbOKOnly + MsgBoxStyle.Critical, "Error de registro")
                'TBDniCliente.Focus()
            End If
        End If
        TBNombreCategoria.Clear()
    End Sub
End Class