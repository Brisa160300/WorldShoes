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
        Me.PanelBarraMenu = New System.Windows.Forms.Panel()
        Me.IconMinimizar = New FontAwesome.Sharp.IconButton()
        Me.IconCerrar = New FontAwesome.Sharp.IconButton()
        Me.MenuStripVendedor = New System.Windows.Forms.MenuStrip()
        Me.Inicio = New FontAwesome.Sharp.IconMenuItem()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenúInicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelBarraMenu.SuspendLayout()
        Me.MenuStripVendedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBarraMenu
        '
        Me.PanelBarraMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.PanelBarraMenu.Controls.Add(Me.IconMinimizar)
        Me.PanelBarraMenu.Controls.Add(Me.IconCerrar)
        Me.PanelBarraMenu.Location = New System.Drawing.Point(1, -1)
        Me.PanelBarraMenu.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelBarraMenu.Name = "PanelBarraMenu"
        Me.PanelBarraMenu.Size = New System.Drawing.Size(960, 37)
        Me.PanelBarraMenu.TabIndex = 12
        '
        'IconMinimizar
        '
        Me.IconMinimizar.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.pngaaa_com_4979905
        Me.IconMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IconMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconMinimizar.FlatAppearance.BorderSize = 0
        Me.IconMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconMinimizar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconMinimizar.IconColor = System.Drawing.Color.Black
        Me.IconMinimizar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconMinimizar.Location = New System.Drawing.Point(895, 6)
        Me.IconMinimizar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.IconMinimizar.Name = "IconMinimizar"
        Me.IconMinimizar.Size = New System.Drawing.Size(26, 28)
        Me.IconMinimizar.TabIndex = 1
        Me.IconMinimizar.UseVisualStyleBackColor = True
        '
        'IconCerrar
        '
        Me.IconCerrar.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_cancelar_501
        Me.IconCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IconCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconCerrar.FlatAppearance.BorderSize = 0
        Me.IconCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconCerrar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconCerrar.IconColor = System.Drawing.Color.Black
        Me.IconCerrar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCerrar.Location = New System.Drawing.Point(926, 6)
        Me.IconCerrar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.IconCerrar.Name = "IconCerrar"
        Me.IconCerrar.Size = New System.Drawing.Size(26, 28)
        Me.IconCerrar.TabIndex = 0
        Me.IconCerrar.UseVisualStyleBackColor = True
        '
        'MenuStripVendedor
        '
        Me.MenuStripVendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.MenuStripVendedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStripVendedor.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStripVendedor.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStripVendedor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Inicio, Me.InicioToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.FacturaciónToolStripMenuItem, Me.CerrarToolStripMenuItem})
        Me.MenuStripVendedor.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripVendedor.Name = "MenuStripVendedor"
        Me.MenuStripVendedor.Padding = New System.Windows.Forms.Padding(6, 49, 0, 2)
        Me.MenuStripVendedor.Size = New System.Drawing.Size(162, 490)
        Me.MenuStripVendedor.TabIndex = 14
        Me.MenuStripVendedor.Text = "MenuStripVendedor"
        '
        'Inicio
        '
        Me.Inicio.Font = New System.Drawing.Font("Britannic Bold", 15.2!)
        Me.Inicio.ForeColor = System.Drawing.Color.White
        Me.Inicio.IconChar = FontAwesome.Sharp.IconChar.None
        Me.Inicio.IconColor = System.Drawing.Color.Black
        Me.Inicio.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Inicio.Name = "Inicio"
        Me.Inicio.Size = New System.Drawing.Size(149, 27)
        Me.Inicio.Text = "World Shoes"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenúInicioToolStripMenuItem})
        Me.InicioToolStripMenuItem.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.InicioToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.InicioToolStripMenuItem.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_casa_50__1_
        Me.InicioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Padding = New System.Windows.Forms.Padding(18, 0, 18, 0)
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(149, 74)
        Me.InicioToolStripMenuItem.Text = "&Inicio"
        Me.InicioToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.InicioToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'MenúInicioToolStripMenuItem
        '
        Me.MenúInicioToolStripMenuItem.Name = "MenúInicioToolStripMenuItem"
        Me.MenúInicioToolStripMenuItem.Size = New System.Drawing.Size(170, 24)
        Me.MenúInicioToolStripMenuItem.Text = "Menú Inicio"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirClienteToolStripMenuItem, Me.ListarClientesToolStripMenuItem})
        Me.ClientesToolStripMenuItem.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.ClientesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ClientesToolStripMenuItem.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_buscar_cliente_50
        Me.ClientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Padding = New System.Windows.Forms.Padding(18, 0, 18, 0)
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(149, 74)
        Me.ClientesToolStripMenuItem.Text = "&Clientes"
        Me.ClientesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ClientesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AñadirClienteToolStripMenuItem
        '
        Me.AñadirClienteToolStripMenuItem.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.AñadirClienteToolStripMenuItem.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_añadir_usuario_masculino_50
        Me.AñadirClienteToolStripMenuItem.Name = "AñadirClienteToolStripMenuItem"
        Me.AñadirClienteToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.AñadirClienteToolStripMenuItem.Text = "Añadir Cliente"
        '
        'ListarClientesToolStripMenuItem
        '
        Me.ListarClientesToolStripMenuItem.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.ListarClientesToolStripMenuItem.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_libreta_de_direcciones_2_50
        Me.ListarClientesToolStripMenuItem.Name = "ListarClientesToolStripMenuItem"
        Me.ListarClientesToolStripMenuItem.Size = New System.Drawing.Size(194, 24)
        Me.ListarClientesToolStripMenuItem.Text = "Listar Clientes"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListarProductosToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.ProductosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ProductosToolStripMenuItem.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_mujeres_vista_lateral_del_zapato_filled_50
        Me.ProductosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ProductosToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Padding = New System.Windows.Forms.Padding(18, 0, 18, 0)
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(149, 74)
        Me.ProductosToolStripMenuItem.Text = "&Productos"
        Me.ProductosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ProductosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ListarProductosToolStripMenuItem
        '
        Me.ListarProductosToolStripMenuItem.Name = "ListarProductosToolStripMenuItem"
        Me.ListarProductosToolStripMenuItem.Size = New System.Drawing.Size(213, 24)
        Me.ListarProductosToolStripMenuItem.Text = "Listar Productos"
        '
        'FacturaciónToolStripMenuItem
        '
        Me.FacturaciónToolStripMenuItem.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.FacturaciónToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FacturaciónToolStripMenuItem.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_facturación_50
        Me.FacturaciónToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FacturaciónToolStripMenuItem.Name = "FacturaciónToolStripMenuItem"
        Me.FacturaciónToolStripMenuItem.Padding = New System.Windows.Forms.Padding(18, 0, 18, 0)
        Me.FacturaciónToolStripMenuItem.Size = New System.Drawing.Size(149, 74)
        Me.FacturaciónToolStripMenuItem.Text = "&Facturación"
        Me.FacturaciónToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.FacturaciónToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.CerrarToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CerrarToolStripMenuItem.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_cierre_de_sesión_redondeado_hacia_la_izquierda_50
        Me.CerrarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Padding = New System.Windows.Forms.Padding(18, 0, 18, 0)
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(149, 74)
        Me.CerrarToolStripMenuItem.Text = "Salir"
        Me.CerrarToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CerrarToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelContenedor.Location = New System.Drawing.Point(144, 35)
        Me.PanelContenedor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(817, 455)
        Me.PanelContenedor.TabIndex = 20
        '
        'MenuVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(962, 490)
        Me.Controls.Add(Me.PanelContenedor)
        Me.Controls.Add(Me.PanelBarraMenu)
        Me.Controls.Add(Me.MenuStripVendedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Name = "MenuVendedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuVendedor"
        Me.PanelBarraMenu.ResumeLayout(False)
        Me.MenuStripVendedor.ResumeLayout(False)
        Me.MenuStripVendedor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelBarraMenu As Panel
    Friend WithEvents IconMinimizar As FontAwesome.Sharp.IconButton
    Friend WithEvents IconCerrar As FontAwesome.Sharp.IconButton
    Friend WithEvents MenuStripVendedor As MenuStrip
    Friend WithEvents Inicio As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenúInicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñadirClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelContenedor As Panel
End Class
