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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.Inicio = New FontAwesome.Sharp.IconMenuItem()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.PanelBarraMenu = New System.Windows.Forms.Panel()
        Me.IconMinimizar = New FontAwesome.Sharp.IconButton()
        Me.IconCerrar = New FontAwesome.Sharp.IconButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.PanelBarraMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.MenuStrip.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Inicio, Me.FileMenu, Me.ProductosToolStripMenuItem, Me.ToolsMenu, Me.CerrarMenu, Me.CategoriasToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(8, 60, 0, 2)
        Me.MenuStrip.Size = New System.Drawing.Size(225, 577)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'Inicio
        '
        Me.Inicio.Font = New System.Drawing.Font("Britannic Bold", 15.2!)
        Me.Inicio.ForeColor = System.Drawing.Color.White
        Me.Inicio.IconChar = FontAwesome.Sharp.IconChar.None
        Me.Inicio.IconColor = System.Drawing.Color.Black
        Me.Inicio.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.Inicio.Name = "Inicio"
        Me.Inicio.Size = New System.Drawing.Size(208, 33)
        Me.Inicio.Text = "World Shoes"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.ToolStripSeparator4, Me.ToolStripSeparator5})
        Me.FileMenu.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.FileMenu.ForeColor = System.Drawing.Color.White
        Me.FileMenu.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_casa_50__1_1
        Me.FileMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Padding = New System.Windows.Forms.Padding(18, 0, 18, 0)
        Me.FileMenu.Size = New System.Drawing.Size(208, 79)
        Me.FileMenu.Text = "&Inicio"
        Me.FileMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(71, 6)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(71, 6)
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(71, 6)
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirProductosToolStripMenuItem, Me.ListarProductosToolStripMenuItem})
        Me.ProductosToolStripMenuItem.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.ProductosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ProductosToolStripMenuItem.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_mujeres_vista_lateral_del_zapato_filled_50
        Me.ProductosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ProductosToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Padding = New System.Windows.Forms.Padding(18, 0, 18, 0)
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(208, 79)
        Me.ProductosToolStripMenuItem.Text = "&Productos"
        Me.ProductosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ProductosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AñadirProductosToolStripMenuItem
        '
        Me.AñadirProductosToolStripMenuItem.Name = "AñadirProductosToolStripMenuItem"
        Me.AñadirProductosToolStripMenuItem.Size = New System.Drawing.Size(296, 30)
        Me.AñadirProductosToolStripMenuItem.Text = "Añadir Productos"
        '
        'ListarProductosToolStripMenuItem
        '
        Me.ListarProductosToolStripMenuItem.Name = "ListarProductosToolStripMenuItem"
        Me.ListarProductosToolStripMenuItem.Size = New System.Drawing.Size(296, 30)
        Me.ListarProductosToolStripMenuItem.Text = "Gestionar Productos"
        '
        'ToolsMenu
        '
        Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.ToolsMenu.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.ToolsMenu.ForeColor = System.Drawing.Color.White
        Me.ToolsMenu.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.iconventas
        Me.ToolsMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Padding = New System.Windows.Forms.Padding(18, 0, 18, 0)
        Me.ToolsMenu.Size = New System.Drawing.Size(208, 61)
        Me.ToolsMenu.Text = "&Visualizar Ventas"
        Me.ToolsMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(262, 30)
        Me.OptionsToolStripMenuItem.Text = "Gestionar Ventas"
        '
        'CerrarMenu
        '
        Me.CerrarMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator8})
        Me.CerrarMenu.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.CerrarMenu.ForeColor = System.Drawing.Color.White
        Me.CerrarMenu.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_cierre_de_sesión_redondeado_hacia_la_izquierda_50
        Me.CerrarMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CerrarMenu.Name = "CerrarMenu"
        Me.CerrarMenu.Padding = New System.Windows.Forms.Padding(18, 0, 18, 0)
        Me.CerrarMenu.Size = New System.Drawing.Size(208, 79)
        Me.CerrarMenu.Text = "Sali&r"
        Me.CerrarMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(71, 6)
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.CategoriasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Padding = New System.Windows.Forms.Padding(5, 2, 5, 2)
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(208, 33)
        Me.CategoriasToolStripMenuItem.Text = "Categorias"
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 577)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1282, 26)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(54, 20)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'PanelBarraMenu
        '
        Me.PanelBarraMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.PanelBarraMenu.Controls.Add(Me.IconMinimizar)
        Me.PanelBarraMenu.Controls.Add(Me.IconCerrar)
        Me.PanelBarraMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraMenu.Name = "PanelBarraMenu"
        Me.PanelBarraMenu.Size = New System.Drawing.Size(1280, 45)
        Me.PanelBarraMenu.TabIndex = 13
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
        Me.IconMinimizar.Location = New System.Drawing.Point(1193, 7)
        Me.IconMinimizar.Name = "IconMinimizar"
        Me.IconMinimizar.Size = New System.Drawing.Size(35, 35)
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
        Me.IconCerrar.Location = New System.Drawing.Point(1234, 7)
        Me.IconCerrar.Name = "IconCerrar"
        Me.IconCerrar.Size = New System.Drawing.Size(35, 35)
        Me.IconCerrar.TabIndex = 0
        Me.IconCerrar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(228, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1052, 533)
        Me.Panel1.TabIndex = 15
        '
        'MenuGerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1282, 603)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelBarraMenu)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MenuGerente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuGerente"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.PanelBarraMenu.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CerrarMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelBarraMenu As Panel
    Friend WithEvents IconMinimizar As FontAwesome.Sharp.IconButton
    Friend WithEvents IconCerrar As FontAwesome.Sharp.IconButton
    Friend WithEvents Inicio As FontAwesome.Sharp.IconMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñadirProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
End Class
