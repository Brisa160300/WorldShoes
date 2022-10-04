<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuV
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
        Me.PanelMenuLateral = New System.Windows.Forms.Panel()
        Me.PanelSubMenuFacturación = New System.Windows.Forms.Panel()
        Me.BListarVentas = New System.Windows.Forms.Button()
        Me.BNuevaVenta = New System.Windows.Forms.Button()
        Me.PanelSubMenuProductos = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelSubMenuClientes = New System.Windows.Forms.Panel()
        Me.BListaClientes = New System.Windows.Forms.Button()
        Me.BAñadirClientes = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.LIconMenu = New System.Windows.Forms.Label()
        Me.PanelBarraMenu = New System.Windows.Forms.Panel()
        Me.PanelFormVendedor = New System.Windows.Forms.Panel()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.BFacturación = New System.Windows.Forms.Button()
        Me.BProductos = New System.Windows.Forms.Button()
        Me.BClientes = New System.Windows.Forms.Button()
        Me.BMinimizarMenu = New System.Windows.Forms.Button()
        Me.BCerrarMenu = New System.Windows.Forms.Button()
        Me.BMaximizarMenu = New System.Windows.Forms.Button()
        Me.BRestaurarMenu = New System.Windows.Forms.Button()
        Me.PanelMenuLateral.SuspendLayout()
        Me.PanelSubMenuFacturación.SuspendLayout()
        Me.PanelSubMenuProductos.SuspendLayout()
        Me.PanelSubMenuClientes.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        Me.PanelBarraMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenuLateral
        '
        Me.PanelMenuLateral.AutoScroll = True
        Me.PanelMenuLateral.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelMenuLateral.Controls.Add(Me.BSalir)
        Me.PanelMenuLateral.Controls.Add(Me.PanelSubMenuFacturación)
        Me.PanelMenuLateral.Controls.Add(Me.BFacturación)
        Me.PanelMenuLateral.Controls.Add(Me.PanelSubMenuProductos)
        Me.PanelMenuLateral.Controls.Add(Me.BProductos)
        Me.PanelMenuLateral.Controls.Add(Me.PanelSubMenuClientes)
        Me.PanelMenuLateral.Controls.Add(Me.BClientes)
        Me.PanelMenuLateral.Controls.Add(Me.PanelLogo)
        Me.PanelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenuLateral.Location = New System.Drawing.Point(0, 94)
        Me.PanelMenuLateral.Name = "PanelMenuLateral"
        Me.PanelMenuLateral.Size = New System.Drawing.Size(250, 656)
        Me.PanelMenuLateral.TabIndex = 0
        '
        'PanelSubMenuFacturación
        '
        Me.PanelSubMenuFacturación.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelSubMenuFacturación.Controls.Add(Me.BListarVentas)
        Me.PanelSubMenuFacturación.Controls.Add(Me.BNuevaVenta)
        Me.PanelSubMenuFacturación.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuFacturación.ForeColor = System.Drawing.Color.Gainsboro
        Me.PanelSubMenuFacturación.Location = New System.Drawing.Point(0, 511)
        Me.PanelSubMenuFacturación.Name = "PanelSubMenuFacturación"
        Me.PanelSubMenuFacturación.Size = New System.Drawing.Size(229, 100)
        Me.PanelSubMenuFacturación.TabIndex = 13
        '
        'BListarVentas
        '
        Me.BListarVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BListarVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BListarVentas.FlatAppearance.BorderSize = 0
        Me.BListarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BListarVentas.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BListarVentas.ForeColor = System.Drawing.Color.Gainsboro
        Me.BListarVentas.Location = New System.Drawing.Point(0, 50)
        Me.BListarVentas.Name = "BListarVentas"
        Me.BListarVentas.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BListarVentas.Size = New System.Drawing.Size(229, 50)
        Me.BListarVentas.TabIndex = 0
        Me.BListarVentas.Text = "Listar Ventas"
        Me.BListarVentas.UseVisualStyleBackColor = False
        '
        'BNuevaVenta
        '
        Me.BNuevaVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.BNuevaVenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.BNuevaVenta.FlatAppearance.BorderSize = 0
        Me.BNuevaVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BNuevaVenta.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BNuevaVenta.ForeColor = System.Drawing.Color.Gainsboro
        Me.BNuevaVenta.Location = New System.Drawing.Point(0, 0)
        Me.BNuevaVenta.Name = "BNuevaVenta"
        Me.BNuevaVenta.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BNuevaVenta.Size = New System.Drawing.Size(229, 50)
        Me.BNuevaVenta.TabIndex = 0
        Me.BNuevaVenta.Text = "Nueva Venta"
        Me.BNuevaVenta.UseVisualStyleBackColor = False
        '
        'PanelSubMenuProductos
        '
        Me.PanelSubMenuProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelSubMenuProductos.Controls.Add(Me.Button1)
        Me.PanelSubMenuProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuProductos.ForeColor = System.Drawing.Color.Gainsboro
        Me.PanelSubMenuProductos.Location = New System.Drawing.Point(0, 386)
        Me.PanelSubMenuProductos.Name = "PanelSubMenuProductos"
        Me.PanelSubMenuProductos.Size = New System.Drawing.Size(229, 50)
        Me.PanelSubMenuProductos.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(229, 50)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Listar Productos"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PanelSubMenuClientes
        '
        Me.PanelSubMenuClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelSubMenuClientes.Controls.Add(Me.BListaClientes)
        Me.PanelSubMenuClientes.Controls.Add(Me.BAñadirClientes)
        Me.PanelSubMenuClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuClientes.ForeColor = System.Drawing.Color.Gainsboro
        Me.PanelSubMenuClientes.Location = New System.Drawing.Point(0, 211)
        Me.PanelSubMenuClientes.Name = "PanelSubMenuClientes"
        Me.PanelSubMenuClientes.Size = New System.Drawing.Size(229, 100)
        Me.PanelSubMenuClientes.TabIndex = 9
        '
        'BListaClientes
        '
        Me.BListaClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BListaClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BListaClientes.FlatAppearance.BorderSize = 0
        Me.BListaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BListaClientes.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BListaClientes.ForeColor = System.Drawing.Color.Gainsboro
        Me.BListaClientes.Location = New System.Drawing.Point(0, 50)
        Me.BListaClientes.Name = "BListaClientes"
        Me.BListaClientes.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BListaClientes.Size = New System.Drawing.Size(229, 50)
        Me.BListaClientes.TabIndex = 1
        Me.BListaClientes.Text = "Listar Clientes"
        Me.BListaClientes.UseVisualStyleBackColor = False
        '
        'BAñadirClientes
        '
        Me.BAñadirClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BAñadirClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BAñadirClientes.FlatAppearance.BorderSize = 0
        Me.BAñadirClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAñadirClientes.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BAñadirClientes.ForeColor = System.Drawing.Color.Gainsboro
        Me.BAñadirClientes.Location = New System.Drawing.Point(0, 0)
        Me.BAñadirClientes.Name = "BAñadirClientes"
        Me.BAñadirClientes.Padding = New System.Windows.Forms.Padding(35, 0, 0, 0)
        Me.BAñadirClientes.Size = New System.Drawing.Size(229, 50)
        Me.BAñadirClientes.TabIndex = 0
        Me.BAñadirClientes.Text = "Añadir Clientes"
        Me.BAñadirClientes.UseVisualStyleBackColor = False
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelLogo.Controls.Add(Me.LIconMenu)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(229, 136)
        Me.PanelLogo.TabIndex = 0
        '
        'LIconMenu
        '
        Me.LIconMenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LIconMenu.AutoSize = True
        Me.LIconMenu.Font = New System.Drawing.Font("Cooper Black", 18.0!)
        Me.LIconMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LIconMenu.Location = New System.Drawing.Point(32, 55)
        Me.LIconMenu.Name = "LIconMenu"
        Me.LIconMenu.Size = New System.Drawing.Size(198, 35)
        Me.LIconMenu.TabIndex = 0
        Me.LIconMenu.Text = "WorldShoes"
        Me.LIconMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelBarraMenu
        '
        Me.PanelBarraMenu.BackColor = System.Drawing.Color.Goldenrod
        Me.PanelBarraMenu.Controls.Add(Me.BMinimizarMenu)
        Me.PanelBarraMenu.Controls.Add(Me.BCerrarMenu)
        Me.PanelBarraMenu.Controls.Add(Me.BMaximizarMenu)
        Me.PanelBarraMenu.Controls.Add(Me.BRestaurarMenu)
        Me.PanelBarraMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraMenu.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelBarraMenu.Name = "PanelBarraMenu"
        Me.PanelBarraMenu.Size = New System.Drawing.Size(1400, 94)
        Me.PanelBarraMenu.TabIndex = 15
        '
        'PanelFormVendedor
        '
        Me.PanelFormVendedor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelFormVendedor.AutoScroll = True
        Me.PanelFormVendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelFormVendedor.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.logoWorldShoes_removebg_preview
        Me.PanelFormVendedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PanelFormVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelFormVendedor.Location = New System.Drawing.Point(250, 94)
        Me.PanelFormVendedor.Name = "PanelFormVendedor"
        Me.PanelFormVendedor.Size = New System.Drawing.Size(1150, 656)
        Me.PanelFormVendedor.TabIndex = 3
        '
        'BSalir
        '
        Me.BSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BSalir.FlatAppearance.BorderSize = 0
        Me.BSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BSalir.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BSalir.ForeColor = System.Drawing.Color.White
        Me.BSalir.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_cierre_de_sesión_redondeado_hacia_la_izquierda_50
        Me.BSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BSalir.Location = New System.Drawing.Point(0, 611)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.BSalir.Size = New System.Drawing.Size(229, 75)
        Me.BSalir.TabIndex = 14
        Me.BSalir.Text = "Cerrar Sesión"
        Me.BSalir.UseVisualStyleBackColor = False
        '
        'BFacturación
        '
        Me.BFacturación.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BFacturación.Dock = System.Windows.Forms.DockStyle.Top
        Me.BFacturación.FlatAppearance.BorderSize = 0
        Me.BFacturación.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BFacturación.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BFacturación.ForeColor = System.Drawing.Color.White
        Me.BFacturación.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_facturación_50
        Me.BFacturación.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BFacturación.Location = New System.Drawing.Point(0, 436)
        Me.BFacturación.Name = "BFacturación"
        Me.BFacturación.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.BFacturación.Size = New System.Drawing.Size(229, 75)
        Me.BFacturación.TabIndex = 12
        Me.BFacturación.Text = "Facturación"
        Me.BFacturación.UseVisualStyleBackColor = False
        '
        'BProductos
        '
        Me.BProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BProductos.FlatAppearance.BorderSize = 0
        Me.BProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BProductos.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BProductos.ForeColor = System.Drawing.Color.White
        Me.BProductos.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_mujeres_vista_lateral_del_zapato_filled_50
        Me.BProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BProductos.Location = New System.Drawing.Point(0, 311)
        Me.BProductos.Name = "BProductos"
        Me.BProductos.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.BProductos.Size = New System.Drawing.Size(229, 75)
        Me.BProductos.TabIndex = 10
        Me.BProductos.Text = "Productos"
        Me.BProductos.UseVisualStyleBackColor = False
        '
        'BClientes
        '
        Me.BClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BClientes.FlatAppearance.BorderSize = 0
        Me.BClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BClientes.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BClientes.ForeColor = System.Drawing.Color.White
        Me.BClientes.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_buscar_cliente_50
        Me.BClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BClientes.Location = New System.Drawing.Point(0, 136)
        Me.BClientes.Name = "BClientes"
        Me.BClientes.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.BClientes.Size = New System.Drawing.Size(229, 75)
        Me.BClientes.TabIndex = 8
        Me.BClientes.Text = "Clientes"
        Me.BClientes.UseVisualStyleBackColor = False
        '
        'BMinimizarMenu
        '
        Me.BMinimizarMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BMinimizarMenu.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.minimizar_blanco
        Me.BMinimizarMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BMinimizarMenu.FlatAppearance.BorderSize = 0
        Me.BMinimizarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BMinimizarMenu.Location = New System.Drawing.Point(1277, 24)
        Me.BMinimizarMenu.Name = "BMinimizarMenu"
        Me.BMinimizarMenu.Size = New System.Drawing.Size(33, 31)
        Me.BMinimizarMenu.TabIndex = 5
        Me.BMinimizarMenu.UseVisualStyleBackColor = True
        '
        'BCerrarMenu
        '
        Me.BCerrarMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BCerrarMenu.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.cerrarventana
        Me.BCerrarMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BCerrarMenu.FlatAppearance.BorderSize = 0
        Me.BCerrarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCerrarMenu.Location = New System.Drawing.Point(1355, 24)
        Me.BCerrarMenu.Name = "BCerrarMenu"
        Me.BCerrarMenu.Size = New System.Drawing.Size(33, 31)
        Me.BCerrarMenu.TabIndex = 4
        Me.BCerrarMenu.UseVisualStyleBackColor = True
        '
        'BMaximizarMenu
        '
        Me.BMaximizarMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BMaximizarMenu.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.maximizarBlanco
        Me.BMaximizarMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BMaximizarMenu.FlatAppearance.BorderSize = 0
        Me.BMaximizarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BMaximizarMenu.Location = New System.Drawing.Point(1316, 24)
        Me.BMaximizarMenu.Name = "BMaximizarMenu"
        Me.BMaximizarMenu.Size = New System.Drawing.Size(33, 31)
        Me.BMaximizarMenu.TabIndex = 6
        Me.BMaximizarMenu.UseVisualStyleBackColor = True
        '
        'BRestaurarMenu
        '
        Me.BRestaurarMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BRestaurarMenu.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.restaurarventana
        Me.BRestaurarMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BRestaurarMenu.FlatAppearance.BorderSize = 0
        Me.BRestaurarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRestaurarMenu.Location = New System.Drawing.Point(1316, 24)
        Me.BRestaurarMenu.Name = "BRestaurarMenu"
        Me.BRestaurarMenu.Size = New System.Drawing.Size(33, 31)
        Me.BRestaurarMenu.TabIndex = 7
        Me.BRestaurarMenu.UseVisualStyleBackColor = True
        '
        'MenuV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1400, 750)
        Me.Controls.Add(Me.PanelFormVendedor)
        Me.Controls.Add(Me.PanelMenuLateral)
        Me.Controls.Add(Me.PanelBarraMenu)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MenuV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelMenuLateral.ResumeLayout(False)
        Me.PanelSubMenuFacturación.ResumeLayout(False)
        Me.PanelSubMenuProductos.ResumeLayout(False)
        Me.PanelSubMenuClientes.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelLogo.PerformLayout()
        Me.PanelBarraMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenuLateral As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents BSalir As Button
    Friend WithEvents PanelSubMenuFacturación As Panel
    Friend WithEvents BListarVentas As Button
    Friend WithEvents BNuevaVenta As Button
    Friend WithEvents BFacturación As Button
    Friend WithEvents PanelSubMenuProductos As Panel
    Friend WithEvents BProductos As Button
    Friend WithEvents PanelSubMenuClientes As Panel
    Friend WithEvents BListaClientes As Button
    Friend WithEvents BAñadirClientes As Button
    Friend WithEvents BClientes As Button
    Friend WithEvents PanelFormVendedor As Panel
    Friend WithEvents LIconMenu As Label
    Friend WithEvents PanelBarraMenu As Panel
    Friend WithEvents BMinimizarMenu As Button
    Friend WithEvents BCerrarMenu As Button
    Friend WithEvents BMaximizarMenu As Button
    Friend WithEvents BRestaurarMenu As Button
    Friend WithEvents Button1 As Button
End Class
