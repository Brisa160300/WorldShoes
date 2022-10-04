Public Class AñadirTalle
    Dim objNtalle = New NTalle
    Private Sub AñadirTalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNtalle.cargarGrid(dgvRegistroTalles)
    End Sub

    Private Sub BRegistrarTalle_Click(sender As Object, e As EventArgs) Handles BRegistrarTalle.Click
        If String.IsNullOrWhiteSpace(TBNombreTalle.Text) Then
            MsgBox("Debe Completar todos los campos", vbCritical, "Error")
        Else
            MsgBox("¿Desea añadir esta nuevo talle", vbQuestion + vbYesNo, "Confirmar Inserción")
            If vbYes Then
                If (objNtalle.agregar_talle(CInt(TBNombreTalle.Text))) Then
                    MsgBox("El talle: " + TBNombreTalle.Text + " se registró correctamente", vbOKOnly + MsgBoxStyle.Information, "Registro exitoso")
                    objNtalle.cargarGrid(dgvRegistroTalles)
                    MsgBox("se ha añadido correctamente el nuevo talle")
                Else
                    MsgBox("El talle: " + TBNombreTalle.Text + " ya existe", vbOKOnly + MsgBoxStyle.Critical, "Error de registro")
                    TBNombreTalle.Focus()
                End If
            End If
        End If
        TBNombreTalle.Clear()
    End Sub
    Private Sub TBNombreTalle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreTalle.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")
        End If
    End Sub
    Private Sub BCancelarTalle_Click(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub
End Class