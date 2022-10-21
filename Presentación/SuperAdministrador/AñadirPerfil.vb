Public Class AñadirPerfil
    Dim objNPerfil = New NPerfil
    Private Sub BVolver_Click(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub

    Private Sub BRegistrarPerfil_Click(sender As Object, e As EventArgs) Handles BRegistrarPerfil.Click
        If String.IsNullOrWhiteSpace(TBNombrePerfil.Text) Then
            MsgBox("Debe Completar todos los campos", vbCritical, "Error")
        Else
            MsgBox("¿Desea añadir esta nueva categoría?", vbQuestion + vbYesNo, "Confirmar Inserción")
            If vbYes Then
                If (objNPerfil.agregar_perfil(TBNombrePerfil.Text)) Then
                    MsgBox("El perfil: " + TBNombrePerfil.Text + " se registró correctamente", vbOKOnly + MsgBoxStyle.Information, "Registro exitoso")
                    objNPerfil.cargarGrid(dgvRegistroPerfil)
                    MsgBox("se ha añadido correctamente la nueva categoría")
                Else
                    MsgBox("El perfil: " + TBNombrePerfil.Text + " ya existe", vbOKOnly + MsgBoxStyle.Critical, "Error de registro")
                    TBNombrePerfil.Focus()
                End If
            End If
        End If
        TBNombrePerfil.Clear()
    End Sub


    Private Sub TBNombrePerfil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombrePerfil.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")
        End If
    End Sub

    Private Sub AñadirPerfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNPerfil.cargarGrid(dgvRegistroPerfil)
    End Sub
End Class