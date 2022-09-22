Public Class MenuV
    Private Sub AñadirClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirClienteToolStripMenuItem.Click
        AñadirCliente.MdiParent = Me
        AñadirCliente.Show()

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click

    End Sub

    Private Sub MenuStripVendedor_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStripVendedor.ItemClicked

    End Sub
End Class