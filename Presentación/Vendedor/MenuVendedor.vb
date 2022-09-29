Imports System.Windows.Forms

Public Class MenuVendedor

    Private m_ChildFormNumber As Integer

    Private Sub AñadirClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirClienteToolStripMenuItem.Click
        MostrarSubMenuVendedor(New AñadirCliente)
    End Sub

    Private Sub ListarClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarClientesToolStripMenuItem.Click
        MostrarSubMenuVendedor(New ListarClientes)
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub MenuStripVendedor_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs)

    End Sub

    Private Sub ListarProductosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ListarProductos.MdiParent = Me
        ListarProductos.Show()
    End Sub

    Private Sub IconCerrarVendedor_Click(sender As Object, e As EventArgs) Handles IconCerrarVendedor.Click
        Application.Exit()
    End Sub

    Private Sub IconMinimizarVendedor_Click(sender As Object, e As EventArgs) Handles IconMinimizarVendedor.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnMaximizarVendedor_Click(sender As Object, e As EventArgs) Handles BtnMaximizarVendedor.Click
        BtnMaximizarVendedor.Visible = False
        BtnRestaurarWinVendedor.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BtnRestaurarWinVendedor_Click(sender As Object, e As EventArgs) Handles BtnRestaurarWinVendedor.Click
        BtnRestaurarWinVendedor.Visible = False
        BtnMaximizarVendedor.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Me.Close()
        Login.Show()
        Login.TBUsuario.Clear()
        Login.TBContraseña.Clear()
    End Sub

    Function MostrarSubMenuVendedor(submenu As Form) As Boolean
        PanelContenedorVendedor.Controls.Clear()
        Dim frmHijo As Form = TryCast(submenu, Form)
        frmHijo.TopMost = False
        frmHijo.Dock = DockStyle.Fill
        frmHijo.Visible = True
        frmHijo.TopLevel = False
        PanelContenedorVendedor.Controls.Add(frmHijo)
        PanelContenedorVendedor.Tag = frmHijo
        frmHijo.Show()
        'If Not PanelContenedorVendedor.Controls.Count > 0 Then
        '    PanelContenedorVendedor.Controls.RemoveAt(0)
        'End If
        Return True
    End Function

End Class
