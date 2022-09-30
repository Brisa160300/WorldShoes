<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuGerente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirCategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GestionarCategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PanelBarraMenu = New System.Windows.Forms.Panel()
        Me.BMinimizarMenuGerente = New System.Windows.Forms.Button()
        Me.BCerrarMenuGerente = New System.Windows.Forms.Button()
        Me.BMaximizarMenuGerente = New System.Windows.Forms.Button()
        Me.BRestaurarMenuGerente = New System.Windows.Forms.Button()
        Me.FlowPanelGerente = New System.Windows.Forms.FlowLayoutPanel()
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
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.ToolsMenu, Me.CategoriasToolStripMenuItem, Me.CerrarMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(8, 60, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(193, 650)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Font = New System.Drawing.Font("Cooper Black", 15.0!)
        Me.InicioToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.InicioToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 90, 0, 10)
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(176, 33)
        Me.InicioToolStripMenuItem.Text = "World Shoes"
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
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(176, 39)
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
        Me.ToolsMenu.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.ToolsMenu.ForeColor = System.Drawing.Color.White
        Me.ToolsMenu.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.ventas
        Me.ToolsMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolsMenu.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Padding = New System.Windows.Forms.Padding(18, 5, 18, 5)
        Me.ToolsMenu.Size = New System.Drawing.Size(176, 39)
        Me.ToolsMenu.Text = "&Ventas"
        Me.ToolsMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirCategoriaToolStripMenuItem, Me.GestionarCategoriaToolStripMenuItem})
        Me.CategoriasToolStripMenuItem.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.CategoriasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CategoriasToolStripMenuItem.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_categorizar_50
        Me.CategoriasToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CategoriasToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Padding = New System.Windows.Forms.Padding(5, 2, 5, 2)
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(176, 33)
        Me.CategoriasToolStripMenuItem.Text = "&Categorias"
        Me.CategoriasToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AñadirCategoriaToolStripMenuItem
        '
        Me.AñadirCategoriaToolStripMenuItem.Name = "AñadirCategoriaToolStripMenuItem"
        Me.AñadirCategoriaToolStripMenuItem.Size = New System.Drawing.Size(292, 30)
        Me.AñadirCategoriaToolStripMenuItem.Text = "Añadir Categoria"
        '
        'GestionarCategoriaToolStripMenuItem
        '
        Me.GestionarCategoriaToolStripMenuItem.Name = "GestionarCategoriaToolStripMenuItem"
        Me.GestionarCategoriaToolStripMenuItem.Size = New System.Drawing.Size(292, 30)
        Me.GestionarCategoriaToolStripMenuItem.Text = "Gestionar Categoria"
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
        Me.CerrarMenu.Size = New System.Drawing.Size(176, 39)
        Me.CerrarMenu.Text = "&Salir"
        Me.CerrarMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(221, 6)
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
        'PanelBarraMenu
        '
        Me.PanelBarraMenu.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PanelBarraMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.PanelBarraMenu.Controls.Add(Me.BMinimizarMenuGerente)
        Me.PanelBarraMenu.Controls.Add(Me.BCerrarMenuGerente)
        Me.PanelBarraMenu.Controls.Add(Me.BMaximizarMenuGerente)
        Me.PanelBarraMenu.Controls.Add(Me.BRestaurarMenuGerente)
        Me.PanelBarraMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelBarraMenu.Name = "PanelBarraMenu"
        Me.PanelBarraMenu.Size = New System.Drawing.Size(1300, 94)
        Me.PanelBarraMenu.TabIndex = 13
        '
        'BMinimizarMenuGerente
        '
        Me.BMinimizarMenuGerente.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.minimizar_blanco
        Me.BMinimizarMenuGerente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BMinimizarMenuGerente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BMinimizarMenuGerente.Location = New System.Drawing.Point(1216, 12)
        Me.BMinimizarMenuGerente.Name = "BMinimizarMenuGerente"
        Me.BMinimizarMenuGerente.Size = New System.Drawing.Size(33, 31)
        Me.BMinimizarMenuGerente.TabIndex = 5
        Me.BMinimizarMenuGerente.UseVisualStyleBackColor = True
        '
        'BCerrarMenuGerente
        '
        Me.BCerrarMenuGerente.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.cerrarventana
        Me.BCerrarMenuGerente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BCerrarMenuGerente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCerrarMenuGerente.Location = New System.Drawing.Point(1255, 12)
        Me.BCerrarMenuGerente.Name = "BCerrarMenuGerente"
        Me.BCerrarMenuGerente.Size = New System.Drawing.Size(33, 31)
        Me.BCerrarMenuGerente.TabIndex = 4
        Me.BCerrarMenuGerente.UseVisualStyleBackColor = True
        '
        'BMaximizarMenuGerente
        '
        Me.BMaximizarMenuGerente.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.maximizarBlanco
        Me.BMaximizarMenuGerente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BMaximizarMenuGerente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BMaximizarMenuGerente.Location = New System.Drawing.Point(1216, 12)
        Me.BMaximizarMenuGerente.Name = "BMaximizarMenuGerente"
        Me.BMaximizarMenuGerente.Size = New System.Drawing.Size(33, 31)
        Me.BMaximizarMenuGerente.TabIndex = 6
        Me.BMaximizarMenuGerente.UseVisualStyleBackColor = True
        '
        'BRestaurarMenuGerente
        '
        Me.BRestaurarMenuGerente.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.restaurarventana
        Me.BRestaurarMenuGerente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BRestaurarMenuGerente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRestaurarMenuGerente.Location = New System.Drawing.Point(1216, 12)
        Me.BRestaurarMenuGerente.Name = "BRestaurarMenuGerente"
        Me.BRestaurarMenuGerente.Size = New System.Drawing.Size(33, 31)
        Me.BRestaurarMenuGerente.TabIndex = 7
        Me.BRestaurarMenuGerente.UseVisualStyleBackColor = True
        '
        'FlowPanelGerente
        '
        Me.FlowPanelGerente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowPanelGerente.AutoScroll = True
        Me.FlowPanelGerente.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.FlowPanelGerente.Location = New System.Drawing.Point(194, 94)
        Me.FlowPanelGerente.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowPanelGerente.Name = "FlowPanelGerente"
        Me.FlowPanelGerente.Size = New System.Drawing.Size(1106, 556)
        Me.FlowPanelGerente.TabIndex = 20
        '
        'MenuGerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1300, 650)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelBarraMenu)
        Me.Controls.Add(Me.FlowPanelGerente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
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
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñadirProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents AñadirCategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GestionarCategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelBarraMenu As Panel
    Friend WithEvents FlowPanelGerente As FlowLayoutPanel
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BMinimizarMenuGerente As Button
    Friend WithEvents BCerrarMenuGerente As Button
    Friend WithEvents BMaximizarMenuGerente As Button
    Friend WithEvents BRestaurarMenuGerente As Button
End Class
