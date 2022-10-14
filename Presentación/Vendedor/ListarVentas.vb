Public Class ListarVentas
    Private Sub TBBuscar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBBuscar.KeyPress

        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan caracteres númericos", vbCritical, "Error")
        End If
    End Sub

    Private Sub BVolver_Click(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As DetalleVenta = New DetalleVenta
        frm.ShowInTaskbar = False
        frm.ShowDialog()
    End Sub
End Class