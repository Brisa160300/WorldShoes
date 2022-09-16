Public Class MenuVendedor
    Private Sub AñadirClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirClienteToolStripMenuItem.Click
        AñadirCliente.MdiParent = Me
        AñadirCliente.Show()

    End Sub


End Class