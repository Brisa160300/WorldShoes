Public Class Reportes
    Private state As Integer
    Private px, py As Integer
    Private mover As Boolean

    Private Sub Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MinimumSize = New Size(900, 500)

    End Sub

    Private Sub BVentasHoy_Click(sender As Object, e As EventArgs) Handles BVentasHoy.Click
        AbrirFormulariosGerente(New ReporteHoy)
    End Sub

    Private Sub BVentas7dias_Click(sender As Object, e As EventArgs) Handles BVentas7dias.Click
        AbrirFormulariosGerente(New Reportes7dias)
    End Sub

    Private Sub BVentas30dias_Click(sender As Object, e As EventArgs) Handles BVentas30dias.Click
        AbrirFormulariosGerente(New Reportes30dias)
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
    Private Sub AbrirFormulariosGerente(formHijo As Form)
        If Not formActivo IsNot Nothing Then
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

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BVentas30dias.Click
    ' formHijo As ListarProductos = New ListarProductos
    'Not formActivo IsNot Nothing Then
    '     PanelFormGerente.Controls.Clear()
    '     formHijo.TopLevel = False
    '     formHijo.FormBorderStyle = FormBorderStyle.None
    '     formHijo.Dock = DockStyle.Fill
    '     formHijo.Visible = True
    '     formHijo.AutoScroll = True
    '    formHijo.VerticalScroll.Value = 0
    '    formHijo.VerticalScroll.Minimum = 0
    '    formHijo.VerticalScroll.Maximum = formHijo.Size.Height - 100
    '     formHijo.HorizontalScroll.Value = 0
    '     formHijo.HorizontalScroll.Minimum = 0
    '     formHijo.HorizontalScroll.Maximum = formHijo.Size.Width - 100
    '     PanelFormGerente.Controls.Add(formHijo)
    '    PanelFormGerente.Tag = formHijo
    '  PanelFormGerente.BringToFront()
    '  PanelFormGerente.AutoScroll = True
    '  formHijo.Show()

    ' If
    ' End Sub


    Private Sub BMinimizarMenu_Click(sender As Object, e As EventArgs) Handles BMinimizarMenu.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

End Class