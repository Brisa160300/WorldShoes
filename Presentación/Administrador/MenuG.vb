Public Class MenuG
    Private state As Integer
    Private px, py As Integer
    Private mover As Boolean

    Private Sub G_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimumSize = New Size(900, 500)
        hideSubMenu()
    End Sub

    Private Sub hideSubMenu()
        PanelSubMenuProductosGerente.Visible = False
        PanelSubMenuCategorias.Visible = False
        PanelSubMenuVentasGerente.Visible = False
        PanelSubMenuMarcas.Visible = False
        PanelSubMenuTalles.Visible = False
        PanelSubMenuClientes.Visible = False

    End Sub

    Private Sub showSubMenu(subMenu As Panel)
        If subMenu.Visible = False Then
            hideSubMenu()
            subMenu.Visible = True
        Else
            subMenu.Visible = False
        End If
    End Sub

    Private Sub BProductosGerente_Click(sender As Object, e As EventArgs) Handles BProductosGerente.Click
        showSubMenu(PanelSubMenuProductosGerente)
    End Sub
    Private Sub BAñadirProductosGerente_Click(sender As Object, e As EventArgs) Handles BAñadirProductoGerente.Click
        AbrirFormulariosGerente(New AñadirProducto)
    End Sub

    Private Sub BGestionarProductosGerente_Click(sender As Object, e As EventArgs) Handles BGestionarProductosGerente.Click
        AbrirFormulariosGerente(New GestionarProductos)
    End Sub

    Private Sub BVentasGerente_Click(sender As Object, e As EventArgs) Handles BVentasGerente.Click
        showSubMenu(PanelSubMenuVentasGerente)
    End Sub

    Private Sub BListarVentasGerente_Click(sender As Object, e As EventArgs) Handles BListarVentasGerente.Click
        AbrirFormulariosGerente(New ListarVentasGerente)
    End Sub
    Private Sub BListarVendedoresGerente_Click(sender As Object, e As EventArgs) 
        AbrirFormulariosGerente(New ListaVendedores)
    End Sub

    Private Sub BCategoriasGerente_Click(sender As Object, e As EventArgs) Handles BCategoriasGerente.Click
        showSubMenu(PanelSubMenuCategorias)
    End Sub

    Private Sub BTalles_Click(sender As Object, e As EventArgs) Handles BTalles.Click

        showSubMenu(PanelSubMenuTalles)
    End Sub

    Private Sub BMarcas_Click(sender As Object, e As EventArgs) Handles BMarcas.Click
        showSubMenu(PanelSubMenuMarcas)
    End Sub



    Private formActivoGerente As Form = Nothing
    Private Sub AbrirFormulariosGerente(formHijo As Form)
        If Not formActivoGerente IsNot Nothing Then
            PanelFormGerente.Controls.Clear()
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
            PanelFormGerente.Controls.Add(formHijo)
            PanelFormGerente.Tag = formHijo
            PanelFormGerente.BringToFront()
            PanelFormGerente.AutoScroll = True
            formHijo.Show()
            hideSubMenu()

        End If
    End Sub


    Private Sub BAñadirCategoria_Click(sender As Object, e As EventArgs) Handles BAñadirCategoria.Click
        AbrirFormulariosGerente(New Añadir_Categoria)
    End Sub

    Private Sub BGestionarCategorias_Click(sender As Object, e As EventArgs) Handles BGestionarCategorias.Click
        AbrirFormulariosGerente(New GestionarCategoria)
    End Sub

    Private Sub BAñadirTalle_Click(sender As Object, e As EventArgs) Handles BAñadirTalle.Click
        AbrirFormulariosGerente(New AñadirTalle)
    End Sub

    Private Sub BGestionarTalles_Click(sender As Object, e As EventArgs) Handles BGestionarTalles.Click
        AbrirFormulariosGerente(New GestionarTalle)
    End Sub

    Private Sub BAñadirMarca_Click(sender As Object, e As EventArgs) Handles BAñadirMarca.Click
        AbrirFormulariosGerente(New AñadirMarca)
    End Sub

    Private Sub BGestionarMarcas_Click(sender As Object, e As EventArgs) Handles BGestionarMarcas.Click
        AbrirFormulariosGerente(New ListarMarcas)
    End Sub



    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("¿Esta seguro de que quiere cerrar sesión?", vbExclamation + vbYesNo, "Cerrar Aplicación")
        If ask = vbYes Then
            Me.Close()
            Login.Show()
            Login.TBUsuario.Clear()
            Login.TBContraseña.Clear()
        End If

    End Sub

    Private Sub BCerrarMenuGerente_Click(sender As Object, e As EventArgs) Handles BCerrarMenuGerente.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("¿Esta segruro de que quiere cerrar la aplicación?", vbExclamation + vbYesNo, "Cerrar Aplicación")
        If ask = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub BMaximizarMenuGerente_Click(sender As Object, e As EventArgs) Handles BMaximizarMenuGerente.Click
        BMaximizarMenuGerente.Visible = False
        BRestaurarMenuGerente.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BRestaurarMenuGerente_Click(sender As Object, e As EventArgs) Handles BRestaurarMenuGerente.Click
        BRestaurarMenuGerente.Visible = False
        BMaximizarMenuGerente.Visible = True
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub BMinimizarMenuGerente_Click(sender As Object, e As EventArgs) Handles BMinimizarMenuGerente.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PanelBarraMenu_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelBarraMenu.MouseDown
        px = e.X
        py = e.Y
        mover = True
    End Sub

    Private Sub PanelBarraMenu_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelBarraMenu.MouseUp
        mover = False
    End Sub

    Private Sub BListaClientes_Click(sender As Object, e As EventArgs) Handles BListaClientes.Click
        AbrirFormulariosGerente(New GestionarClientesAdministrador)
    End Sub

    Private Sub BClientes_Click(sender As Object, e As EventArgs) Handles BClientes.Click
        showSubMenu(PanelSubMenuClientes)
    End Sub

    Private Sub BAñadirTalleProducto_Click(sender As Object, e As EventArgs) Handles BAñadirTalleProducto.Click
        AbrirFormulariosGerente(New AñadirTallesProducto)
    End Sub

    Private Sub BModificar_Click(sender As Object, e As EventArgs)
        AbrirFormulariosGerente(New ListarTalleProductos)
    End Sub

    Private Sub PanelBarraMenu_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraMenu.MouseMove
        If mover Then
            Me.Location = Me.PointToScreen(New Point(MousePosition.X - Me.Location.X - px, MousePosition.Y - Me.Location.Y - py))

        End If
    End Sub

End Class