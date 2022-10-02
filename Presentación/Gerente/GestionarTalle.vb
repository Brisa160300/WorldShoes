Public Class GestionarTalle
    Private Sub BModificarTalle_Click(sender As Object, e As EventArgs) Handles BModificarTalle.Click
        Dim frm As New ModificarTalle
        frm.ShowInTaskbar = False
        frm.ShowDialog()
    End Sub

End Class