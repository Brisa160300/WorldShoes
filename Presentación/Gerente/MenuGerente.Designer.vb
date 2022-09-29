<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuGerente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.Inicio = New FontAwesome.Sharp.IconMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.PanelBarraMenu = New System.Windows.Forms.Panel()
        Me.BtnMaximizar = New FontAwesome.Sharp.IconButton()
        Me.BtnMinimizar = New FontAwesome.Sharp.IconButton()
        Me.BtnCerrar = New FontAwesome.Sharp.IconButton()
        Me.BtnRestaurarWin = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PanelContenedorGerente = New System.Windows.Forms.Panel()
        Me.MenuStrip.SuspendLayout()
        Me.PanelBarraMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.MenuStrip.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip.GripMargin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Inicio, Me.ProductosToolStripMenuItem, Me.ToolsMenu, Me.CategoriasToolStripMenuItem, Me.CerrarMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(8, 60, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(207, 650)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'Inicio
        '
        Me.Inicio.Font = New System.Drawing.Font("Cooper Black", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Inicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Inicio.IconChar = FontAwesome.Sharp.IconChar.None
        Me.Inicio.IconColor = System.Drawing.Color.Black
        Me.Inicio.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Inicio.Margin = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.Inicio.Name = "Inicio"
        Me.Inicio.Padding = New System.Windows.Forms.Padding(0, 10, 4, 10)
        Me.Inicio.Size = New System.Drawing.Size(190, 53)
        Me.Inicio.Text = "World Shoes"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirProductosToolStripMenuItem, Me.ListarProductosToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.ProductosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ProductosToolStripMenuItem.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_mujeres_vista_lateral_del_zapato_filled_50
        Me.ProductosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProductosToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Padding = New System.Windows.Forms.Padding(18, 5, 18, 5)
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(190, 39)
        Me.ProductosToolStripMenuItem.Text = "&Productos"
        Me.ProductosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'AñadirProductosToolStripMenuItem
        '
        Me.AñadirProductosToolStripMenuItem.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.AñadirProductosToolStripMenuItem.Name = "AñadirProductosToolStripMenuItem"
        Me.AñadirProductosToolStripMenuItem.Size = New System.Drawing.Size(280, 26)
        Me.AñadirProductosToolStripMenuItem.Text = "Añadir Productos"
        '
        'ListarProductosToolStripMenuItem
        '
        Me.ListarProductosToolStripMenuItem.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.ListarProductosToolStripMenuItem.Name = "ListarProductosToolStripMenuItem"
        Me.ListarProductosToolStripMenuItem.Size = New System.Drawing.Size(280, 26)
        Me.ListarProductosToolStripMenuItem.Text = "Gestionar Productos"
        '
        'ToolsMenu
        '
        Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.ToolsMenu.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.ToolsMenu.ForeColor = System.Drawing.Color.White
        Me.ToolsMenu.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.ventas
        Me.ToolsMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolsMenu.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Padding = New System.Windows.Forms.Padding(18, 5, 18, 5)
        Me.ToolsMenu.Size = New System.Drawing.Size(190, 39)
        Me.ToolsMenu.Text = "&Ventas"
        Me.ToolsMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(262, 30)
        Me.OptionsToolStripMenuItem.Text = "Gestionar Ventas"
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.CategoriasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CategoriasToolStripMenuItem.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_categorizar_50
        Me.CategoriasToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CategoriasToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Padding = New System.Windows.Forms.Padding(5, 2, 5, 2)
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(190, 33)
        Me.CategoriasToolStripMenuItem.Text = "&Categorias"
        Me.CategoriasToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CerrarMenu
        '
        Me.CerrarMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator8})
        Me.CerrarMenu.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.CerrarMenu.ForeColor = System.Drawing.Color.White
        Me.CerrarMenu.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_cierre_de_sesión_redondeado_hacia_la_izquierda_50
        Me.CerrarMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CerrarMenu.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.CerrarMenu.Name = "CerrarMenu"
        Me.CerrarMenu.Padding = New System.Windows.Forms.Padding(18, 5, 18, 5)
        Me.CerrarMenu.Size = New System.Drawing.Size(190, 39)
        Me.CerrarMenu.Text = "&Salir"
        Me.CerrarMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(71, 6)
        '
        'PanelBarraMenu
        '
        Me.PanelBarraMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.PanelBarraMenu.Controls.Add(Me.BtnMaximizar)
        Me.PanelBarraMenu.Controls.Add(Me.BtnMinimizar)
        Me.PanelBarraMenu.Controls.Add(Me.BtnCerrar)
        Me.PanelBarraMenu.Controls.Add(Me.BtnRestaurarWin)
        Me.PanelBarraMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraMenu.Location = New System.Drawing.Point(207, 0)
        Me.PanelBarraMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelBarraMenu.Name = "PanelBarraMenu"
        Me.PanelBarraMenu.Size = New System.Drawing.Size(1093, 94)
        Me.PanelBarraMenu.TabIndex = 13
        '
        'BtnMaximizar
        '
        Me.BtnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMaximizar.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.maximizarBlanco
        Me.BtnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMaximizar.FlatAppearance.BorderSize = 0
        Me.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMaximizar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnMaximizar.IconColor = System.Drawing.Color.Black
        Me.BtnMaximizar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnMaximizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnMaximizar.Location = New System.Drawing.Point(1001, 14)
        Me.BtnMaximizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnMaximizar.Name = "BtnMaximizar"
        Me.BtnMaximizar.Size = New System.Drawing.Size(33, 31)
        Me.BtnMaximizar.TabIndex = 2
        Me.BtnMaximizar.UseVisualStyleBackColor = True
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimizar.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.minimizar_blanco
        Me.BtnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMinimizar.FlatAppearance.BorderSize = 0
        Me.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimizar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnMinimizar.IconColor = System.Drawing.Color.Black
        Me.BtnMinimizar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnMinimizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnMinimizar.Location = New System.Drawing.Point(962, 14)
        Me.BtnMinimizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.Size = New System.Drawing.Size(33, 31)
        Me.BtnMinimizar.TabIndex = 1
        Me.BtnMinimizar.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.cerrarventana
        Me.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnCerrar.IconColor = System.Drawing.Color.Black
        Me.BtnCerrar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCerrar.Location = New System.Drawing.Point(1040, 14)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(33, 31)
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnRestaurarWin
        '
        Me.BtnRestaurarWin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRestaurarWin.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.restaurarventana
        Me.BtnRestaurarWin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnRestaurarWin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRestaurarWin.FlatAppearance.BorderSize = 0
        Me.BtnRestaurarWin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRestaurarWin.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnRestaurarWin.IconColor = System.Drawing.Color.Black
        Me.BtnRestaurarWin.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnRestaurarWin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRestaurarWin.Location = New System.Drawing.Point(1001, 14)
        Me.BtnRestaurarWin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnRestaurarWin.Name = "BtnRestaurarWin"
        Me.BtnRestaurarWin.Size = New System.Drawing.Size(33, 31)
        Me.BtnRestaurarWin.TabIndex = 3
        Me.BtnRestaurarWin.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 142)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(7, 42)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 191)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(7, 42)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 240)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(7, 42)
        Me.Panel3.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 289)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(7, 42)
        Me.Panel4.TabIndex = 1
        '
        'PanelContenedorGerente
        '
        Me.PanelContenedorGerente.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.PanelContenedorGerente.Location = New System.Drawing.Point(207, 92)
        Me.PanelContenedorGerente.Name = "PanelContenedorGerente"
        Me.PanelContenedorGerente.Size = New System.Drawing.Size(1093, 558)
        Me.PanelContenedorGerente.TabIndex = 17
        '
        'MenuGerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 650)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelBarraMenu)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.PanelContenedorGerente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MenuGerente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuGerente"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.PanelBarraMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CerrarMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelBarraMenu As Panel
    Friend WithEvents BtnMinimizar As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnCerrar As FontAwesome.Sharp.IconButton
    Friend WithEvents Inicio As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñadirProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnMaximizar As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnRestaurarWin As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PanelContenedorGerente As Panel
End Class
