<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuVendedor
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
        Me.MenuStripVendedor = New System.Windows.Forms.MenuStrip()
        Me.Inicio = New FontAwesome.Sharp.IconMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelContenedorVendedor = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PanelBarraMenu = New System.Windows.Forms.Panel()
        Me.BtnMaximizarVendedor = New FontAwesome.Sharp.IconButton()
        Me.IconMinimizarVendedor = New FontAwesome.Sharp.IconButton()
        Me.IconCerrarVendedor = New FontAwesome.Sharp.IconButton()
        Me.BtnRestaurarWinVendedor = New FontAwesome.Sharp.IconButton()
        Me.MenuStripVendedor.SuspendLayout()
        Me.PanelBarraMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripVendedor
        '
        Me.MenuStripVendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.MenuStripVendedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStripVendedor.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStripVendedor.GripMargin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.MenuStripVendedor.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStripVendedor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Inicio, Me.ClientesToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.FacturaciónToolStripMenuItem, Me.CerrarToolStripMenuItem})
        Me.MenuStripVendedor.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripVendedor.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.MenuStripVendedor.Name = "MenuStripVendedor"
        Me.MenuStripVendedor.Padding = New System.Windows.Forms.Padding(8, 60, 0, 2)
        Me.MenuStripVendedor.Size = New System.Drawing.Size(207, 650)
        Me.MenuStripVendedor.TabIndex = 14
        Me.MenuStripVendedor.Text = "MenuStripVendedor"
        '
        'Inicio
        '
        Me.Inicio.Font = New System.Drawing.Font("Cooper Black", 15.0!)
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
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirClienteToolStripMenuItem, Me.ListarClientesToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.ClientesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ClientesToolStripMenuItem.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_buscar_cliente_50
        Me.ClientesToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ClientesToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Padding = New System.Windows.Forms.Padding(18, 5, 18, 5)
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(190, 39)
        Me.ClientesToolStripMenuItem.Text = "&Clientes"
        Me.ClientesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AñadirClienteToolStripMenuItem
        '
        Me.AñadirClienteToolStripMenuItem.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.AñadirClienteToolStripMenuItem.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_añadir_usuario_masculino_50
        Me.AñadirClienteToolStripMenuItem.Name = "AñadirClienteToolStripMenuItem"
        Me.AñadirClienteToolStripMenuItem.Size = New System.Drawing.Size(236, 30)
        Me.AñadirClienteToolStripMenuItem.Text = "Añadir Cliente"
        '
        'ListarClientesToolStripMenuItem
        '
        Me.ListarClientesToolStripMenuItem.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.ListarClientesToolStripMenuItem.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_libreta_de_direcciones_2_50
        Me.ListarClientesToolStripMenuItem.Name = "ListarClientesToolStripMenuItem"
        Me.ListarClientesToolStripMenuItem.Size = New System.Drawing.Size(236, 30)
        Me.ListarClientesToolStripMenuItem.Text = "Listar Clientes"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListarProductosToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.ProductosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ProductosToolStripMenuItem.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_mujeres_vista_lateral_del_zapato_filled_50
        Me.ProductosToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProductosToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Padding = New System.Windows.Forms.Padding(18, 5, 18, 5)
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(190, 39)
        Me.ProductosToolStripMenuItem.Text = "&Productos"
        Me.ProductosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ListarProductosToolStripMenuItem
        '
        Me.ListarProductosToolStripMenuItem.Name = "ListarProductosToolStripMenuItem"
        Me.ListarProductosToolStripMenuItem.Size = New System.Drawing.Size(258, 30)
        Me.ListarProductosToolStripMenuItem.Text = "Listar Productos"
        '
        'FacturaciónToolStripMenuItem
        '
        Me.FacturaciónToolStripMenuItem.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.FacturaciónToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FacturaciónToolStripMenuItem.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_facturación_50
        Me.FacturaciónToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FacturaciónToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.FacturaciónToolStripMenuItem.Name = "FacturaciónToolStripMenuItem"
        Me.FacturaciónToolStripMenuItem.Padding = New System.Windows.Forms.Padding(18, 5, 18, 5)
        Me.FacturaciónToolStripMenuItem.Size = New System.Drawing.Size(190, 39)
        Me.FacturaciónToolStripMenuItem.Text = "&Facturación"
        Me.FacturaciónToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.CerrarToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CerrarToolStripMenuItem.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_cierre_de_sesión_redondeado_hacia_la_izquierda_50
        Me.CerrarToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CerrarToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Padding = New System.Windows.Forms.Padding(18, 5, 18, 5)
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(190, 39)
        Me.CerrarToolStripMenuItem.Text = "Salir"
        Me.CerrarToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelContenedorVendedor
        '
        Me.PanelContenedorVendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.PanelContenedorVendedor.Location = New System.Drawing.Point(207, 92)
        Me.PanelContenedorVendedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelContenedorVendedor.Name = "PanelContenedorVendedor"
        Me.PanelContenedorVendedor.Size = New System.Drawing.Size(1093, 562)
        Me.PanelContenedorVendedor.TabIndex = 20
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(0, 142)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(7, 42)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 192)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(7, 42)
        Me.Panel2.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 242)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(7, 42)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 292)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(7, 42)
        Me.Panel4.TabIndex = 2
        '
        'PanelBarraMenu
        '
        Me.PanelBarraMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.PanelBarraMenu.Controls.Add(Me.BtnMaximizarVendedor)
        Me.PanelBarraMenu.Controls.Add(Me.IconMinimizarVendedor)
        Me.PanelBarraMenu.Controls.Add(Me.IconCerrarVendedor)
        Me.PanelBarraMenu.Controls.Add(Me.BtnRestaurarWinVendedor)
        Me.PanelBarraMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraMenu.Location = New System.Drawing.Point(207, 0)
        Me.PanelBarraMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelBarraMenu.Name = "PanelBarraMenu"
        Me.PanelBarraMenu.Size = New System.Drawing.Size(1093, 94)
        Me.PanelBarraMenu.TabIndex = 22
        '
        'BtnMaximizarVendedor
        '
        Me.BtnMaximizarVendedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMaximizarVendedor.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.maximizarBlanco
        Me.BtnMaximizarVendedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnMaximizarVendedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMaximizarVendedor.FlatAppearance.BorderSize = 0
        Me.BtnMaximizarVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMaximizarVendedor.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnMaximizarVendedor.IconColor = System.Drawing.Color.Black
        Me.BtnMaximizarVendedor.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnMaximizarVendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnMaximizarVendedor.Location = New System.Drawing.Point(1001, 14)
        Me.BtnMaximizarVendedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnMaximizarVendedor.Name = "BtnMaximizarVendedor"
        Me.BtnMaximizarVendedor.Size = New System.Drawing.Size(33, 31)
        Me.BtnMaximizarVendedor.TabIndex = 2
        Me.BtnMaximizarVendedor.UseVisualStyleBackColor = True
        '
        'IconMinimizarVendedor
        '
        Me.IconMinimizarVendedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconMinimizarVendedor.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.minimizar_blanco
        Me.IconMinimizarVendedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IconMinimizarVendedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconMinimizarVendedor.FlatAppearance.BorderSize = 0
        Me.IconMinimizarVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconMinimizarVendedor.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconMinimizarVendedor.IconColor = System.Drawing.Color.Black
        Me.IconMinimizarVendedor.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconMinimizarVendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconMinimizarVendedor.Location = New System.Drawing.Point(962, 14)
        Me.IconMinimizarVendedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconMinimizarVendedor.Name = "IconMinimizarVendedor"
        Me.IconMinimizarVendedor.Size = New System.Drawing.Size(33, 31)
        Me.IconMinimizarVendedor.TabIndex = 1
        Me.IconMinimizarVendedor.UseVisualStyleBackColor = True
        '
        'IconCerrarVendedor
        '
        Me.IconCerrarVendedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconCerrarVendedor.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.cerrarventana
        Me.IconCerrarVendedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IconCerrarVendedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconCerrarVendedor.FlatAppearance.BorderSize = 0
        Me.IconCerrarVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconCerrarVendedor.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconCerrarVendedor.IconColor = System.Drawing.Color.Black
        Me.IconCerrarVendedor.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCerrarVendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconCerrarVendedor.Location = New System.Drawing.Point(1040, 14)
        Me.IconCerrarVendedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconCerrarVendedor.Name = "IconCerrarVendedor"
        Me.IconCerrarVendedor.Size = New System.Drawing.Size(33, 31)
        Me.IconCerrarVendedor.TabIndex = 0
        Me.IconCerrarVendedor.UseVisualStyleBackColor = True
        '
        'BtnRestaurarWinVendedor
        '
        Me.BtnRestaurarWinVendedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRestaurarWinVendedor.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.restaurarventana
        Me.BtnRestaurarWinVendedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnRestaurarWinVendedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRestaurarWinVendedor.FlatAppearance.BorderSize = 0
        Me.BtnRestaurarWinVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRestaurarWinVendedor.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BtnRestaurarWinVendedor.IconColor = System.Drawing.Color.Black
        Me.BtnRestaurarWinVendedor.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BtnRestaurarWinVendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRestaurarWinVendedor.Location = New System.Drawing.Point(1001, 14)
        Me.BtnRestaurarWinVendedor.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnRestaurarWinVendedor.Name = "BtnRestaurarWinVendedor"
        Me.BtnRestaurarWinVendedor.Size = New System.Drawing.Size(33, 31)
        Me.BtnRestaurarWinVendedor.TabIndex = 3
        Me.BtnRestaurarWinVendedor.UseVisualStyleBackColor = True
        '
        'MenuVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1300, 650)
        Me.Controls.Add(Me.PanelBarraMenu)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelContenedorVendedor)
        Me.Controls.Add(Me.MenuStripVendedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MenuVendedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuVendedor"
        Me.MenuStripVendedor.ResumeLayout(False)
        Me.MenuStripVendedor.PerformLayout()
        Me.PanelBarraMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStripVendedor As MenuStrip
    Friend WithEvents Inicio As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñadirClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelContenedorVendedor As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents PanelBarraMenu As Panel
    Friend WithEvents BtnMaximizarVendedor As FontAwesome.Sharp.IconButton
    Friend WithEvents IconMinimizarVendedor As FontAwesome.Sharp.IconButton
    Friend WithEvents IconCerrarVendedor As FontAwesome.Sharp.IconButton
    Friend WithEvents BtnRestaurarWinVendedor As FontAwesome.Sharp.IconButton
End Class
