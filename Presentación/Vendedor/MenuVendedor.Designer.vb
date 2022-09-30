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
        Me.MenuStripVendedor2 = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanelVendedor = New System.Windows.Forms.FlowLayoutPanel()
        Me.PanelBarraMenuVendedor = New System.Windows.Forms.Panel()
        Me.BMinimizarMenuVendedor = New System.Windows.Forms.Button()
        Me.BCerrarMenuVendedor = New System.Windows.Forms.Button()
        Me.BMaximizarMenuVendedor = New System.Windows.Forms.Button()
        Me.BRestaurarMenuVendedor = New System.Windows.Forms.Button()
        Me.MenuStripVendedor2.SuspendLayout()
        Me.PanelBarraMenuVendedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripVendedor2
        '
        Me.MenuStripVendedor2.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.MenuStripVendedor2.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStripVendedor2.GripMargin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.MenuStripVendedor2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStripVendedor2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.FacturaciónToolStripMenuItem, Me.CerrarToolStripMenuItem})
        Me.MenuStripVendedor2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripVendedor2.Name = "MenuStripVendedor2"
        Me.MenuStripVendedor2.Size = New System.Drawing.Size(193, 650)
        Me.MenuStripVendedor2.TabIndex = 9
        Me.MenuStripVendedor2.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.Font = New System.Drawing.Font("Cooper Black", 15.0!)
        Me.InicioToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.InicioToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 130, 0, 10)
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(180, 33)
        Me.InicioToolStripMenuItem.Text = "World Shoes"
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
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(180, 39)
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
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(180, 39)
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
        Me.FacturaciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevaVentaToolStripMenuItem, Me.ListarVentasToolStripMenuItem})
        Me.FacturaciónToolStripMenuItem.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.FacturaciónToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FacturaciónToolStripMenuItem.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_facturación_50
        Me.FacturaciónToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FacturaciónToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.FacturaciónToolStripMenuItem.Name = "FacturaciónToolStripMenuItem"
        Me.FacturaciónToolStripMenuItem.Padding = New System.Windows.Forms.Padding(18, 5, 18, 5)
        Me.FacturaciónToolStripMenuItem.Size = New System.Drawing.Size(180, 39)
        Me.FacturaciónToolStripMenuItem.Text = "&Facturación"
        Me.FacturaciónToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NuevaVentaToolStripMenuItem
        '
        Me.NuevaVentaToolStripMenuItem.Name = "NuevaVentaToolStripMenuItem"
        Me.NuevaVentaToolStripMenuItem.Size = New System.Drawing.Size(224, 30)
        Me.NuevaVentaToolStripMenuItem.Text = "Nueva Venta"
        '
        'ListarVentasToolStripMenuItem
        '
        Me.ListarVentasToolStripMenuItem.Name = "ListarVentasToolStripMenuItem"
        Me.ListarVentasToolStripMenuItem.Size = New System.Drawing.Size(224, 30)
        Me.ListarVentasToolStripMenuItem.Text = "Listar Ventas"
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
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(180, 39)
        Me.CerrarToolStripMenuItem.Text = "Salir"
        Me.CerrarToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 178)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(7, 42)
        Me.Panel3.TabIndex = 25
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 228)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(7, 42)
        Me.Panel2.TabIndex = 26
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 278)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(7, 42)
        Me.Panel4.TabIndex = 27
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(0, 328)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(7, 42)
        Me.Panel5.TabIndex = 26
        '
        'FlowLayoutPanelVendedor
        '
        Me.FlowLayoutPanelVendedor.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanelVendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.FlowLayoutPanelVendedor.Location = New System.Drawing.Point(193, 92)
        Me.FlowLayoutPanelVendedor.Name = "FlowLayoutPanelVendedor"
        Me.FlowLayoutPanelVendedor.Size = New System.Drawing.Size(1107, 565)
        Me.FlowLayoutPanelVendedor.TabIndex = 23
        '
        'PanelBarraMenuVendedor
        '
        Me.PanelBarraMenuVendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.PanelBarraMenuVendedor.Controls.Add(Me.BMinimizarMenuVendedor)
        Me.PanelBarraMenuVendedor.Controls.Add(Me.BCerrarMenuVendedor)
        Me.PanelBarraMenuVendedor.Controls.Add(Me.BMaximizarMenuVendedor)
        Me.PanelBarraMenuVendedor.Controls.Add(Me.BRestaurarMenuVendedor)
        Me.PanelBarraMenuVendedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraMenuVendedor.Name = "PanelBarraMenuVendedor"
        Me.PanelBarraMenuVendedor.Size = New System.Drawing.Size(1300, 94)
        Me.PanelBarraMenuVendedor.TabIndex = 31
        '
        'BMinimizarMenuVendedor
        '
        Me.BMinimizarMenuVendedor.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.minimizar_blanco
        Me.BMinimizarMenuVendedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BMinimizarMenuVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BMinimizarMenuVendedor.Location = New System.Drawing.Point(1216, 12)
        Me.BMinimizarMenuVendedor.Name = "BMinimizarMenuVendedor"
        Me.BMinimizarMenuVendedor.Size = New System.Drawing.Size(33, 31)
        Me.BMinimizarMenuVendedor.TabIndex = 1
        Me.BMinimizarMenuVendedor.UseVisualStyleBackColor = True
        '
        'BCerrarMenuVendedor
        '
        Me.BCerrarMenuVendedor.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.cerrarventana
        Me.BCerrarMenuVendedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BCerrarMenuVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCerrarMenuVendedor.Location = New System.Drawing.Point(1255, 12)
        Me.BCerrarMenuVendedor.Name = "BCerrarMenuVendedor"
        Me.BCerrarMenuVendedor.Size = New System.Drawing.Size(33, 31)
        Me.BCerrarMenuVendedor.TabIndex = 0
        Me.BCerrarMenuVendedor.UseVisualStyleBackColor = True
        '
        'BMaximizarMenuVendedor
        '
        Me.BMaximizarMenuVendedor.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.maximizarBlanco
        Me.BMaximizarMenuVendedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BMaximizarMenuVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BMaximizarMenuVendedor.Location = New System.Drawing.Point(1216, 12)
        Me.BMaximizarMenuVendedor.Name = "BMaximizarMenuVendedor"
        Me.BMaximizarMenuVendedor.Size = New System.Drawing.Size(33, 31)
        Me.BMaximizarMenuVendedor.TabIndex = 2
        Me.BMaximizarMenuVendedor.UseVisualStyleBackColor = True
        '
        'BRestaurarMenuVendedor
        '
        Me.BRestaurarMenuVendedor.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.restaurarventana
        Me.BRestaurarMenuVendedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BRestaurarMenuVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRestaurarMenuVendedor.Location = New System.Drawing.Point(1216, 12)
        Me.BRestaurarMenuVendedor.Name = "BRestaurarMenuVendedor"
        Me.BRestaurarMenuVendedor.Size = New System.Drawing.Size(33, 31)
        Me.BRestaurarMenuVendedor.TabIndex = 3
        Me.BRestaurarMenuVendedor.UseVisualStyleBackColor = True
        '
        'MenuVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1300, 650)
        Me.Controls.Add(Me.MenuStripVendedor2)
        Me.Controls.Add(Me.PanelBarraMenuVendedor)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.FlowLayoutPanelVendedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MenuVendedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuVendedor2"
        Me.MenuStripVendedor2.ResumeLayout(False)
        Me.MenuStripVendedor2.PerformLayout()
        Me.PanelBarraMenuVendedor.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStripVendedor2 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñadirClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevaVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents FlowLayoutPanelVendedor As FlowLayoutPanel
    Friend WithEvents PanelBarraMenuVendedor As Panel
    Friend WithEvents BCerrarMenuVendedor As Button
    Friend WithEvents BMinimizarMenuVendedor As Button
    Friend WithEvents BRestaurarMenuVendedor As Button
    Friend WithEvents BMaximizarMenuVendedor As Button
End Class
