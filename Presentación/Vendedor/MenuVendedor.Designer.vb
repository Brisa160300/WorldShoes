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
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenúInicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AñadirClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStripVendedor.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStripVendedor
        '
        Me.MenuStripVendedor.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.MenuStripVendedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStripVendedor.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStripVendedor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.FacturaciónToolStripMenuItem, Me.CerrarToolStripMenuItem})
        Me.MenuStripVendedor.Location = New System.Drawing.Point(0, 0)
        Me.MenuStripVendedor.Name = "MenuStripVendedor"
        Me.MenuStripVendedor.Size = New System.Drawing.Size(115, 450)
        Me.MenuStripVendedor.TabIndex = 0
        Me.MenuStripVendedor.Text = "MenuStripVendedor"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenúInicioToolStripMenuItem})
        Me.InicioToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.InicioToolStripMenuItem.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_casa_50__1_
        Me.InicioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Padding = New System.Windows.Forms.Padding(18, 0, 18, 0)
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(102, 69)
        Me.InicioToolStripMenuItem.Text = "&Inicio"
        Me.InicioToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.InicioToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'MenúInicioToolStripMenuItem
        '
        Me.MenúInicioToolStripMenuItem.Name = "MenúInicioToolStripMenuItem"
        Me.MenúInicioToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MenúInicioToolStripMenuItem.Text = "Menú Inicio"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AñadirClienteToolStripMenuItem, Me.ListarClientesToolStripMenuItem})
        Me.ClientesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ClientesToolStripMenuItem.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_buscar_cliente_50
        Me.ClientesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Padding = New System.Windows.Forms.Padding(18, 0, 18, 0)
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(102, 69)
        Me.ClientesToolStripMenuItem.Text = "&Clientes"
        Me.ClientesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ClientesToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'AñadirClienteToolStripMenuItem
        '
        Me.AñadirClienteToolStripMenuItem.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_añadir_usuario_masculino_50
        Me.AñadirClienteToolStripMenuItem.Name = "AñadirClienteToolStripMenuItem"
        Me.AñadirClienteToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.AñadirClienteToolStripMenuItem.Text = "Añadir Cliente"
        '
        'ListarClientesToolStripMenuItem
        '
        Me.ListarClientesToolStripMenuItem.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_libreta_de_direcciones_2_50
        Me.ListarClientesToolStripMenuItem.Name = "ListarClientesToolStripMenuItem"
        Me.ListarClientesToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.ListarClientesToolStripMenuItem.Text = "Listar Clientes"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListarProductosToolStripMenuItem})
        Me.ProductosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ProductosToolStripMenuItem.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_mujeres_vista_lateral_del_zapato_filled_50
        Me.ProductosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ProductosToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Padding = New System.Windows.Forms.Padding(18, 0, 18, 0)
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(102, 69)
        Me.ProductosToolStripMenuItem.Text = "&Productos"
        Me.ProductosToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ProductosToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ListarProductosToolStripMenuItem
        '
        Me.ListarProductosToolStripMenuItem.Name = "ListarProductosToolStripMenuItem"
        Me.ListarProductosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ListarProductosToolStripMenuItem.Text = "Listar Productos"
        '
        'FacturaciónToolStripMenuItem
        '
        Me.FacturaciónToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FacturaciónToolStripMenuItem.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_facturación_50
        Me.FacturaciónToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FacturaciónToolStripMenuItem.Name = "FacturaciónToolStripMenuItem"
        Me.FacturaciónToolStripMenuItem.Padding = New System.Windows.Forms.Padding(18, 0, 18, 0)
        Me.FacturaciónToolStripMenuItem.Size = New System.Drawing.Size(102, 69)
        Me.FacturaciónToolStripMenuItem.Text = "&Facturación"
        Me.FacturaciónToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.FacturaciónToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'CerrarToolStripMenuItem
        '
        Me.CerrarToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CerrarToolStripMenuItem.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_cierre_de_sesión_redondeado_hacia_la_izquierda_50
        Me.CerrarToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        Me.CerrarToolStripMenuItem.Padding = New System.Windows.Forms.Padding(18, 0, 18, 0)
        Me.CerrarToolStripMenuItem.Size = New System.Drawing.Size(102, 69)
        Me.CerrarToolStripMenuItem.Text = "Cerrar"
        Me.CerrarToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CerrarToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'MenuVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStripVendedor)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStripVendedor
        Me.Name = "MenuVendedor"
        Me.Text = "MenuVendedor"
        Me.MenuStripVendedor.ResumeLayout(False)
        Me.MenuStripVendedor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStripVendedor As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenúInicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AñadirClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
End Class
