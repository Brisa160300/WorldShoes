Public Class MenuGerente
    Private state As Integer
    Private px, py As Integer
    Private mover As Boolean
    Private Sub MenuGerente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimumSize = New Size(900, 500)
        hideSubMenu()
    End Sub

    Private Sub hideSubMenu()
        PanelSubMenuFiltrarFecha.Visible = False
        PanelSubMenuVentasPor.Visible = False
    End Sub

    Private Sub showSubMenu(subMenu As Panel)
        If subMenu.Visible = False Then
            hideSubMenu()
            subMenu.Visible = True
        Else
            subMenu.Visible = False
        End If
    End Sub
    Private Sub BSalir_Click(sender As Object, e As EventArgs) Handles BSalir.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("¿Esta segruro de que quiere cerrar sesión?", vbExclamation + vbYesNo, "Cerrar Aplicación")
        If ask = vbYes Then
            Me.Close()
            Login.Show()
            Login.TBUsuario.Clear()
            Login.TBContraseña.Clear()
        End If

    End Sub

    Private Sub BCerrarMenuGerente_Click(sender As Object, e As EventArgs) Handles BCerrarMenuGerente.Click
        Dim ask As MsgBoxResult
        ask = MsgBox("¿Esta segruro de que quiere cerrar sesión?", vbExclamation + vbYesNo, "Cerrar Sesión")
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

    Private Sub PanelBarraMenuAdmin_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelBarraMenuAdmin.MouseDown
        px = e.X
        py = e.Y
        mover = True
    End Sub

    Private Sub PanelBarraMenuAdmin_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelBarraMenuAdmin.MouseUp
        mover = False
    End Sub

    Private Sub BReporteVenta_Click(sender As Object, e As EventArgs) Handles BReporteVenta.Click
        showSubMenu(PanelSubMenuVentasPor)
    End Sub

    Private Sub BReportesPorFecha_Click(sender As Object, e As EventArgs) Handles BReportesPorFecha.Click
        showSubMenu(PanelSubMenuFiltrarFecha)
    End Sub

    Private Sub BReportesHoy_Click(sender As Object, e As EventArgs) Handles BReportesHoy.Click
        AbrirFormulariosGerente(New ReportesDiarios)
    End Sub

    Private Sub PanelBarraMenuAdmin_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraMenuAdmin.MouseMove
        If mover Then
            Me.Location = Me.PointToScreen(New Point(MousePosition.X - Me.Location.X - px, MousePosition.Y - Me.Location.Y - py))

        End If
    End Sub

    Private formActivoVendedor As Form = Nothing

    Private Sub BReportesSemanal_Click(sender As Object, e As EventArgs) Handles BReportesSemanal.Click
        AbrirFormulariosGerente(New Reportes7dias)
    End Sub

    Private Sub BReportesMensual_Click(sender As Object, e As EventArgs) Handles BReportesMensual.Click
        AbrirFormulariosGerente(New Reportes30dias)
    End Sub

    Private Sub BVolver_Click(sender As Object, e As EventArgs) Handles BVolver.Click
        AbrirFormulariosGerente(New ReporteFiltradoFecha)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AbrirFormulariosGerente(New ProductosMasVendidos)
    End Sub
    Private Sub BVentasPorCategoria_Click(sender As Object, e As EventArgs) Handles BVentasPorCategoria.Click
        AbrirFormulariosGerente(New VentasPorCategoria)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        AbrirFormulariosGerente(New VentasPorMarca)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AbrirFormulariosGerente(New ReportePorVendedores)
    End Sub

    Private Sub AbrirFormulariosGerente(formHijo As Form)
        If Not formActivoVendedor IsNot Nothing Then
            PanelFormAdmnistrador.Controls.Clear()
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
            PanelFormAdmnistrador.AutoScroll = True
            PanelFormAdmnistrador.Controls.Add(formHijo)
            PanelFormAdmnistrador.Tag = formHijo
            PanelFormAdmnistrador.BringToFront()
            formHijo.Show()
            hideSubMenu()
        End If
    End Sub

End Class