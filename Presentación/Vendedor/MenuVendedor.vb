Imports System.Windows.Forms

Public Class MenuVendedor

    Private m_ChildFormNumber As Integer

    Private Sub AñadirClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirClienteToolStripMenuItem.Click
        AñadirCliente.MdiParent = Me
        AñadirCliente.Show()
    End Sub
    Private Sub ListarClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarClientesToolStripMenuItem.Click
        ListarClientes.MdiParent = Me
        ListarClientes.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click

    End Sub

    Private Sub MenuStripVendedor_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStripVendedor.ItemClicked

    End Sub

    Private Sub ListarProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarProductosToolStripMenuItem.Click
        ListarProductos.MdiParent = Me
        ListarProductos.Show()
    End Sub
End Class
