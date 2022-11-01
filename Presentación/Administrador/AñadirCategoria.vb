Public Class Añadir_Categoria
    Dim objNcategoria = New NCategoria
    Private Sub TBNombreCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreCategoria.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")
        End If
    End Sub

    Public Function EspacioEnBlanco() As Boolean
        Dim ask As Boolean = False
        Dim categ As String = TBNombreCategoria.Text.Trim
        If categ = "" Then
            ErrorProviderNomCateg.SetError(TBNombreCategoria, "Ingrese una categoria")
            ask = True
        End If
        Return ask
    End Function
    Private Sub BRegistrarCategoria_Click(sender As Object, e As EventArgs) Handles BRegistrarCategoria.Click
        ErrorProviderNomCateg.Clear()
        If EspacioEnBlanco() Then
            MsgBox("Debe Completar todos los campos", vbCritical, "Error")
        Else
            MsgBox("¿Desea añadir esta nueva categoría?", vbQuestion + vbYesNo, "Confirmar Inserción")
            If vbYes Then
                If (objNcategoria.agregar_categoria(TBNombreCategoria.Text)) Then
                    MsgBox("La categoría: " + TBNombreCategoria.Text + " se registró correctamente", vbOKOnly + MsgBoxStyle.Information, "Registro exitoso")
                    objNcategoria.cargarGrid(dgvRegistroCategoria)
                    MsgBox("se ha añadido correctamente la nueva categoría")
                Else
                    MsgBox("La categoría: " + TBNombreCategoria.Text + " ya existe", vbOKOnly + MsgBoxStyle.Critical, "Error de registro")
                    TBNombreCategoria.Focus()
                End If
            End If
        End If
        TBNombreCategoria.Clear()
    End Sub

    Private Sub Añadir_Categoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNcategoria.cargarGrid(dgvRegistroCategoria)
    End Sub

    Private Sub Volver_Click(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub
End Class