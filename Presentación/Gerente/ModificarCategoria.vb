Public Class ModificarCategoria
    Private Sub ModificarCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BCancelarModifCategoria_Click(sender As Object, e As EventArgs) Handles BCancelarModifCategoria.Click
        Me.Close()
    End Sub

    Private Sub TBNombreCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBNombreCategoria.KeyPress

        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")
        End If
    End Sub
End Class