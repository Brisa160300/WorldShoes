Public Class AñadirMarca

    Dim objNMarca = New NTalle
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
                If (objNMarca.agregar_Marca(TBNombreMarca.Text)) Then
                    MsgBox("La marca: " + TBNombreMarca.Text + " se registró correctamente", vbOKOnly + MsgBoxStyle.Information, "Registro exitoso")
                    objNMarca.cargarGrid(dgvRegistroMarca)
                    MsgBox("se ha añadido correctamente la nueva categoría")
                Else
                    MsgBox("La marca: " + TBNombreMarca.Text + " ya existe", vbOKOnly + MsgBoxStyle.Critical, "Error de registro")
                    TBNombreMarca.Focus()
                End If
            End If
        End If
        TBNombreMarca.Clear()
    End Sub

    Private Sub Añadir_Marca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNMarca.cargarGrid(dgvRegistroMarca)
    End Sub

    Private Sub BVolve_Click(sender As Object, e As EventArgs) Handles BVolve.Click
        Me.Close()
    End Sub
End Class