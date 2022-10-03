Public Class AñadirMarca
    'Cambiar nombre del objeto objNcategoria
    Dim objNcategoria = New NCategoria
    Private Sub TBNombreMarca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreMarca.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")
        End If
    End Sub

    Private Sub BRegistrarMarca_Click(sender As Object, e As EventArgs) Handles BRegistrarMarca.Click
        If String.IsNullOrWhiteSpace(TBNombreMarca.Text) Then
            MsgBox("Debe Completar todos los campos", vbCritical, "Error")
        Else
            MsgBox("¿Desea añadir esta nueva marca?", vbQuestion + vbYesNo, "Confirmar Inserción")
            If vbYes Then
                If (objNcategoria.agregar_categoria(TBNombreMarca.Text)) Then
                    MsgBox("La marca: " + TBNombreMarca.Text + " se registró correctamente", vbOKOnly + MsgBoxStyle.Information, "Registro exitoso")
                    objNcategoria.cargarGrid(dgvRegistroMarca)
                    MsgBox("se ha añadido correctamente la nueva categoría")
                Else
                    MsgBox("La marca: " + TBNombreMarca.Text + " ya existe", vbOKOnly + MsgBoxStyle.Critical, "Error de registro")
                    TBNombreMarca.Focus()
                End If
            End If
        End If
        TBNombreMarca.Clear()
    End Sub

    'Cambiar nombre del objeto objNcategoria
    Private Sub Añadir_Marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNcategoria.cargarGrid(dgvRegistroMarca)
    End Sub

End Class