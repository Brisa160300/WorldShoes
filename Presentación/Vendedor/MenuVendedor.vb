Imports System.Windows.Forms

Public Class MenuVendedor

    Dim state As Integer
    Dim px, py As Integer
    Dim mover As Boolean
    Private m_ChildFormNumber As Integer

    Private Sub AñadirClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirClienteToolStripMenuItem.Click
        MostrarSubMenuVendedor(New AñadirCliente)
    End Sub

    Private Sub ListarClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarClientesToolStripMenuItem.Click
        MostrarSubMenuVendedor(New ListarClientes)
    End Sub

    Private Sub ListarProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarProductosToolStripMenuItem.Click
        MostrarSubMenuVendedor(New ListarProductos)
    End Sub

    Private Sub BMinimizarMenuVendedor_Click(sender As Object, e As EventArgs) Handles BMinimizarMenuVendedor.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BMaximizarMenuVendedor_Click(sender As Object, e As EventArgs) Handles BMaximizarMenuVendedor.Click
        Me.WindowState = FormWindowState.Maximized
        BMaximizarMenuVendedor.Visible = False
        BRestaurarMenuVendedor.Visible = True
    End Sub

    Private Sub BRestaurarMenuVendedor_Click(sender As Object, e As EventArgs) Handles BRestaurarMenuVendedor.Click
        BRestaurarMenuVendedor.Visible = False
        BMaximizarMenuVendedor.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub BCerrarMenuVendedor_Click(sender As Object, e As EventArgs) Handles BCerrarMenuVendedor.Click
        Application.Exit()
    End Sub

    Private Sub NuevaVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevaVentaToolStripMenuItem.Click
        MostrarSubMenuVendedor(New AñadirVenta)
    End Sub

    Private Sub ListarVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarVentasToolStripMenuItem.Click
        MostrarSubMenuVendedor(New ListarVentas)
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        Login.Show()
        Login.TBUsuario.Clear()
        Login.TBContraseña.Clear()
        Me.Close()
    End Sub

    Function MostrarSubMenuVendedor(submenu As Form) As Boolean
        If Not FlowLayoutPanelVendedor.Controls.Count > 0 Then
            FlowLayoutPanelVendedor.Controls.Clear()
            Dim frmHijo As Form = TryCast(submenu, Form)
            frmHijo.TopMost = False
            frmHijo.Dock = DockStyle.None
            frmHijo.Visible = True
            frmHijo.TopLevel = False
            FlowLayoutPanelVendedor.Controls.Add(frmHijo)
            FlowLayoutPanelVendedor.Tag = frmHijo
            frmHijo.Size = New Size(1107, 565)
            FlowLayoutPanelVendedor.AutoScroll = True
            frmHijo.BringToFront()
            frmHijo.Show()
            'If Not PanelContenedorVendedor.Controls.Count > 0 Then
            '    PanelContenedorVendedor.Controls.RemoveAt(0)
            'End If
        End If
        Return True
    End Function

    Private Sub PanelBarraMenuVendedor_MouseDown(sender As Object, e As MouseEventArgs)
        px = e.X
        py = e.Y
        mover = True
    End Sub

    Private Sub PanelBarraMenuVendedor_MouseUp(sender As Object, e As MouseEventArgs)
        mover = False
    End Sub

    Private Sub PanelBarraMenuVendedor_MouseMove(sender As Object, e As MouseEventArgs)
        If mover Then
            Me.Location = Me.PointToScreen(New Point(MousePosition.X - Me.Location.X - px, MousePosition.Y - Me.Location.Y - py))

        End If
    End Sub
End Class
