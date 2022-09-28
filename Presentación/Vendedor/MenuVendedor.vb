Imports System.Windows.Forms

Public Class MenuVendedor

    Private m_ChildFormNumber As Integer

    Private Sub AñadirClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirClienteToolStripMenuItem.Click
        Dim frmRegCliente As New AñadirCliente
        Dim prueba As New form()
        frmRegCliente.TopMost = False
        frmRegCliente.Dock = DockStyle.Fill
        'frmRegCliente.WindowState = FormWindowState.Maximized
        frmRegCliente.Visible = True
        frmRegCliente.TopLevel = False
        PanelContenedor.Controls.Add(frmRegCliente)
        frmRegCliente.Show()



        'If PanelContenedor.Controls.Count > 0 Then
        '    PanelContenedor.Controls.RemoveAt(0)
        '    frmRegCliente.Dock = DockStyle.Fill
        '    PanelContenedor.Controls.Add(frmRegCliente)
        '    PanelContenedor.Tag = frmRegCliente
        '    frmRegCliente.MdiParent = Me
        '    frmRegCliente.Show()
        '    FModUsuario.Show()
        '    FModUsuario.MdiParent = Me
        '    HideSubMenu()
        'End If
    End Sub

    Private Sub ListarClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirClienteToolStripMenuItem.Click
        'ListarClientes.MdiParent = Me
        'ListarClientes.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStripVendedor_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub ListarProductosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ListarProductos.MdiParent = Me
        ListarProductos.Show()
    End Sub

    Private Sub IconCerrar_Click(sender As Object, e As EventArgs) Handles IconCerrar.Click
        Application.Exit()
    End Sub

    Private Sub IconMinimizar_Click(sender As Object, e As EventArgs) Handles IconMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class
