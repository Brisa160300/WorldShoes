Public Class MenuV

    Private state As Integer
    Private px, py As Integer
    Private mover As Boolean

    Private Sub MenuV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimumSize = New Size(900, 500)
        hideSubMenu()

    End Sub

    Private Sub hideSubMenu()
        PanelSubMenuClientes.Visible = False
        PanelSubMenuProductos.Visible = False
        PanelSubMenuFacturación.Visible = False
    End Sub

    Private Sub showSubMenu(subMenu As Panel)
        If subMenu.Visible = False Then
            hideSubMenu()
            subMenu.Visible = True
        Else
            subMenu.Visible = False
        End If
    End Sub

    Private Sub BClientes_Click(sender As Object, e As EventArgs) Handles BClientes.Click
        showSubMenu(PanelSubMenuClientes)
    End Sub

    Private Sub BAñadirClientes_Click(sender As Object, e As EventArgs) Handles BAñadirClientes.Click
        AbrirFormulariosVendedor(New AñadirCliente)
    End Sub

    Private Sub BListaClientes_Click(sender As Object, e As EventArgs) Handles BListaClientes.Click
        AbrirFormulariosVendedor(New ListarClientes)
    End Sub

    Private Sub BProductos_Click(sender As Object, e As EventArgs) Handles BProductos.Click
        showSubMenu(PanelSubMenuProductos)
    End Sub

    Private Sub BListProductos_Click(sender As Object, e As EventArgs)
        AbrirFormulariosVendedor(New ListarProductos)
    End Sub
    Private Sub BFacturación_Click(sender As Object, e As EventArgs) Handles BFacturación.Click
        showSubMenu(PanelSubMenuFacturación)
    End Sub
    Private Sub BNuevaVenta_Click(sender As Object, e As EventArgs) Handles BNuevaVenta.Click
        AbrirFormulariosVendedor(New AñadirVentas)
    End Sub

    Private Sub BListarVentas_Click(sender As Object, e As EventArgs) Handles BListarVentas.Click
        AbrirFormulariosVendedor(New ListarVentas)
    End Sub

    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("¿Esta segruro de que quiere cerrar sesión?", vbExclamation + vbYesNo, "Cerrar Sesión")
        If ask = vbYes Then
            Me.Close()
            Login.Show()
            Login.TBUsuario.Clear()
            Login.TBContraseña.Clear()
        End If

    End Sub

    Private formActivo As Form = Nothing
    Private Sub AbrirFormulariosVendedor(formHijo As Form)
        If Not formActivo IsNot Nothing Then
            PanelFormVendedor.Controls.Clear()
            formHijo.TopLevel = False
            formHijo.FormBorderStyle = FormBorderStyle.None
            formHijo.Dock = DockStyle.Fill
            formHijo.Visible = True
            formHijo.AutoScroll = True
            formHijo.VerticalScroll.Value = 0
            formHijo.VerticalScroll.Minimum = 0
            formHijo.VerticalScroll.Maximum = formHijo.Size.Height - 100
            formHijo.HorizontalScroll.Value = 0
            formHijo.HorizontalScroll.Minimum = 0
            formHijo.HorizontalScroll.Maximum = formHijo.Size.Width - 100
            PanelFormVendedor.Controls.Add(formHijo)
            PanelFormVendedor.Tag = formHijo
            PanelFormVendedor.BringToFront()
            PanelFormVendedor.AutoScroll = True
            formHijo.Show()
            hideSubMenu()

        End If
    End Sub

    Private Sub BCerrarMenu_Click(sender As Object, e As EventArgs) Handles BCerrarMenu.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("¿Esta segruro de que quiere cerrar la Aplicación?", vbExclamation + vbYesNo, "Cerrar Aplicación")
        If ask = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub BMaximizarMenu_Click(sender As Object, e As EventArgs) Handles BMaximizarMenu.Click
        BMaximizarMenu.Visible = False
        BRestaurarMenu.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BRestaurarMenu_Click(sender As Object, e As EventArgs) Handles BRestaurarMenu.Click
        BRestaurarMenu.Visible = False
        BMaximizarMenu.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim formHijo As ListarProductos = New ListarProductos
        If Not formActivo IsNot Nothing Then
            PanelFormVendedor.Controls.Clear()
            formHijo.TopLevel = False
            formHijo.FormBorderStyle = FormBorderStyle.None
            formHijo.Dock = DockStyle.Fill
            formHijo.Visible = True
            formHijo.AutoScroll = True
            formHijo.VerticalScroll.Value = 0
            formHijo.VerticalScroll.Minimum = 0
            formHijo.VerticalScroll.Maximum = formHijo.Size.Height - 100
            formHijo.HorizontalScroll.Value = 0
            formHijo.HorizontalScroll.Minimum = 0
            formHijo.HorizontalScroll.Maximum = formHijo.Size.Width - 100
            PanelFormVendedor.Controls.Add(formHijo)
            PanelFormVendedor.Tag = formHijo
            PanelFormVendedor.BringToFront()
            PanelFormVendedor.AutoScroll = True
            formHijo.Show()
            hideSubMenu()

        End If
    End Sub


    Private Sub BMinimizarMenu_Click(sender As Object, e As EventArgs) Handles BMinimizarMenu.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

End Class