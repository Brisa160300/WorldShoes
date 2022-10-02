Imports System.Windows.Forms

Public Class MenuGerente
    Dim state As Integer
    Dim px, py As Integer
    Dim mover As Boolean

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    'Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
    '    Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    'End Sub

    'Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    'End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub AddProducto_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub AñadirProductoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        añadirProducto.MdiParent = Me
        añadirProducto.Show()
    End Sub


    Private Sub BCerrarMenuGerente_Click(sender As Object, e As EventArgs) Handles BCerrarMenuGerente.Click
        Me.Close()
        Login.Show()
        Login.TBUsuario.Clear()
        Login.TBContraseña.Clear()
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

    Private Sub PanelBarraMenu_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelBarraMenu.MouseMove
        If mover Then
            Me.Location = Me.PointToScreen(New Point(MousePosition.X - Me.Location.X - px, MousePosition.Y - Me.Location.Y - py))

        End If
    End Sub

    Private Sub AñadirCategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirCategoriaToolStripMenuItem.Click
        MostrarSubMenuVendedor(New Añadir_Categoria)
    End Sub

    Private Sub GestionarCategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GestionarCategoriaToolStripMenuItem.Click
        MostrarSubMenuVendedor(New GestionarCategoria)
    End Sub

    Private Sub ToolsMenu_Click(sender As Object, e As EventArgs) Handles ToolsMenu.Click
        MostrarSubMenuVendedor(New GestionarVentas)
    End Sub

    Private Sub ListarProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarProductosToolStripMenuItem.Click
        MostrarSubMenuVendedor(New GestionarProductos)
    End Sub

    Private Sub AñadirProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AñadirProductosToolStripMenuItem.Click
        MostrarSubMenuVendedor(New añadirProducto)
    End Sub

    Function MostrarSubMenuVendedor(submenu As Form) As Boolean
        FlowPanelGerente.Controls.Clear()
        Dim frmHijo As Form = TryCast(submenu, Form)
        frmHijo.TopMost = False
        frmHijo.Dock = DockStyle.None
        frmHijo.Visible = True
        frmHijo.TopLevel = False

        FlowPanelGerente.AutoScroll = True
        FlowPanelGerente.Controls.Add(frmHijo)
        FlowPanelGerente.Tag = frmHijo
        frmHijo.BringToFront()
        frmHijo.Show()
        'If Not PanelContenedorVendedor.Controls.Count > 0 Then
        '    PanelContenedorVendedor.Controls.RemoveAt(0)
        'End If
        Return True
    End Function

End Class
