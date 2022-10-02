Public Class GestionarCategoria
    Private Sub BEditarCategoria_Click(sender As Object, e As EventArgs) Handles BEditarCategoria.Click
        Dim frm As New ModificarCategoria
        frm.ShowInTaskbar = False
        frm.ShowDialog()
    End Sub

    Private Sub BEliminarCategoria_Click(sender As Object, e As EventArgs) Handles BEliminarCategoria.Click

    End Sub
End Class