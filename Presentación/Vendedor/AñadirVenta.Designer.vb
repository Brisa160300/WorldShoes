<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AñadirVenta
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
        Me.LTituloVentas = New System.Windows.Forms.Label()
        Me.LNumeroFactura = New System.Windows.Forms.Label()
        Me.LTotalVenta = New System.Windows.Forms.Label()
        Me.TBNombreCliente = New System.Windows.Forms.TextBox()
        Me.TBApellidoCliente = New System.Windows.Forms.TextBox()
        Me.GroupBoxProductos = New System.Windows.Forms.GroupBox()
        Me.BBuscarProducto = New System.Windows.Forms.Button()
        Me.LStock = New System.Windows.Forms.Label()
        Me.TBCorreoCliente = New System.Windows.Forms.TextBox()
        Me.TBPrecio = New System.Windows.Forms.TextBox()
        Me.TBDniCliente = New System.Windows.Forms.TextBox()
        Me.TBTelCliente = New System.Windows.Forms.TextBox()
        Me.LCantidad = New System.Windows.Forms.Label()
        Me.LPrecio = New System.Windows.Forms.Label()
        Me.LProductoDescripcion = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BBuscarCliente = New System.Windows.Forms.Button()
        Me.TBNombreCliVenta = New System.Windows.Forms.TextBox()
        Me.LNombreCli = New System.Windows.Forms.Label()
        Me.LNombreCliente = New System.Windows.Forms.Label()
        Me.TBDniCliVenta = New System.Windows.Forms.TextBox()
        Me.DataGridListaVentas = New System.Windows.Forms.DataGridView()
        Me.BModificarProducto = New System.Windows.Forms.Button()
        Me.BEliminarProducto = New System.Windows.Forms.Button()
        Me.BRegistraProducto = New System.Windows.Forms.Button()
        Me.GroupBoxProductos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridListaVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LTituloVentas
        '
        Me.LTituloVentas.AutoSize = True
        Me.LTituloVentas.BackColor = System.Drawing.Color.Transparent
        Me.LTituloVentas.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTituloVentas.ForeColor = System.Drawing.Color.Transparent
        Me.LTituloVentas.Location = New System.Drawing.Point(49, 39)
        Me.LTituloVentas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LTituloVentas.Name = "LTituloVentas"
        Me.LTituloVentas.Size = New System.Drawing.Size(177, 33)
        Me.LTituloVentas.TabIndex = 3
        Me.LTituloVentas.Text = "Nueva Venta"
        '
        'LNumeroFactura
        '
        Me.LNumeroFactura.AutoSize = True
        Me.LNumeroFactura.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.LNumeroFactura.ForeColor = System.Drawing.Color.White
        Me.LNumeroFactura.Location = New System.Drawing.Point(55, 96)
        Me.LNumeroFactura.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LNumeroFactura.Name = "LNumeroFactura"
        Me.LNumeroFactura.Size = New System.Drawing.Size(93, 19)
        Me.LNumeroFactura.TabIndex = 0
        Me.LNumeroFactura.Text = "N° Factura:"
        '
        'LTotalVenta
        '
        Me.LTotalVenta.AutoSize = True
        Me.LTotalVenta.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LTotalVenta.ForeColor = System.Drawing.Color.White
        Me.LTotalVenta.Location = New System.Drawing.Point(821, 594)
        Me.LTotalVenta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LTotalVenta.Name = "LTotalVenta"
        Me.LTotalVenta.Size = New System.Drawing.Size(59, 22)
        Me.LTotalVenta.TabIndex = 4
        Me.LTotalVenta.Text = "Total:"
        '
        'TBNombreCliente
        '
        Me.TBNombreCliente.CausesValidation = False
        Me.TBNombreCliente.Enabled = False
        Me.TBNombreCliente.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.TBNombreCliente.Location = New System.Drawing.Point(173, 96)
        Me.TBNombreCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBNombreCliente.Name = "TBNombreCliente"
        Me.TBNombreCliente.Size = New System.Drawing.Size(161, 26)
        Me.TBNombreCliente.TabIndex = 6
        '
        'TBApellidoCliente
        '
        Me.TBApellidoCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBApellidoCliente.Location = New System.Drawing.Point(888, 591)
        Me.TBApellidoCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBApellidoCliente.Name = "TBApellidoCliente"
        Me.TBApellidoCliente.Size = New System.Drawing.Size(99, 30)
        Me.TBApellidoCliente.TabIndex = 8
        Me.TBApellidoCliente.Text = "$"
        '
        'GroupBoxProductos
        '
        Me.GroupBoxProductos.Controls.Add(Me.BBuscarProducto)
        Me.GroupBoxProductos.Controls.Add(Me.LStock)
        Me.GroupBoxProductos.Controls.Add(Me.TBCorreoCliente)
        Me.GroupBoxProductos.Controls.Add(Me.TBPrecio)
        Me.GroupBoxProductos.Controls.Add(Me.TBDniCliente)
        Me.GroupBoxProductos.Controls.Add(Me.TBTelCliente)
        Me.GroupBoxProductos.Controls.Add(Me.LCantidad)
        Me.GroupBoxProductos.Controls.Add(Me.LPrecio)
        Me.GroupBoxProductos.Controls.Add(Me.LProductoDescripcion)
        Me.GroupBoxProductos.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.GroupBoxProductos.ForeColor = System.Drawing.Color.White
        Me.GroupBoxProductos.Location = New System.Drawing.Point(55, 262)
        Me.GroupBoxProductos.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBoxProductos.Name = "GroupBoxProductos"
        Me.GroupBoxProductos.Size = New System.Drawing.Size(1038, 133)
        Me.GroupBoxProductos.TabIndex = 18
        Me.GroupBoxProductos.TabStop = False
        Me.GroupBoxProductos.Text = "Articulos"
        '
        'BBuscarProducto
        '
        Me.BBuscarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BBuscarProducto.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BBuscarProducto.FlatAppearance.BorderSize = 2
        Me.BBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBuscarProducto.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscarProducto.ForeColor = System.Drawing.Color.White
        Me.BBuscarProducto.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.search_3_32
        Me.BBuscarProducto.Location = New System.Drawing.Point(200, 59)
        Me.BBuscarProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.BBuscarProducto.Name = "BBuscarProducto"
        Me.BBuscarProducto.Size = New System.Drawing.Size(52, 44)
        Me.BBuscarProducto.TabIndex = 14
        Me.BBuscarProducto.UseVisualStyleBackColor = False
        '
        'LStock
        '
        Me.LStock.AutoSize = True
        Me.LStock.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.LStock.ForeColor = System.Drawing.Color.White
        Me.LStock.Location = New System.Drawing.Point(451, 34)
        Me.LStock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(49, 19)
        Me.LStock.TabIndex = 14
        Me.LStock.Text = "Stock"
        '
        'TBCorreoCliente
        '
        Me.TBCorreoCliente.Enabled = False
        Me.TBCorreoCliente.Location = New System.Drawing.Point(455, 69)
        Me.TBCorreoCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBCorreoCliente.Name = "TBCorreoCliente"
        Me.TBCorreoCliente.Size = New System.Drawing.Size(161, 26)
        Me.TBCorreoCliente.TabIndex = 15
        '
        'TBPrecio
        '
        Me.TBPrecio.Enabled = False
        Me.TBPrecio.Location = New System.Drawing.Point(317, 71)
        Me.TBPrecio.Margin = New System.Windows.Forms.Padding(4)
        Me.TBPrecio.Name = "TBPrecio"
        Me.TBPrecio.Size = New System.Drawing.Size(116, 26)
        Me.TBPrecio.TabIndex = 17
        Me.TBPrecio.Text = "$"
        '
        'TBDniCliente
        '
        Me.TBDniCliente.Location = New System.Drawing.Point(639, 69)
        Me.TBDniCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBDniCliente.Name = "TBDniCliente"
        Me.TBDniCliente.Size = New System.Drawing.Size(110, 26)
        Me.TBDniCliente.TabIndex = 7
        '
        'TBTelCliente
        '
        Me.TBTelCliente.Location = New System.Drawing.Point(21, 71)
        Me.TBTelCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBTelCliente.Name = "TBTelCliente"
        Me.TBTelCliente.Size = New System.Drawing.Size(161, 26)
        Me.TBTelCliente.TabIndex = 10
        '
        'LCantidad
        '
        Me.LCantidad.AutoSize = True
        Me.LCantidad.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.LCantidad.ForeColor = System.Drawing.Color.White
        Me.LCantidad.Location = New System.Drawing.Point(635, 34)
        Me.LCantidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LCantidad.Name = "LCantidad"
        Me.LCantidad.Size = New System.Drawing.Size(75, 19)
        Me.LCantidad.TabIndex = 1
        Me.LCantidad.Text = "Cantidad"
        '
        'LPrecio
        '
        Me.LPrecio.AutoSize = True
        Me.LPrecio.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.LPrecio.ForeColor = System.Drawing.Color.White
        Me.LPrecio.Location = New System.Drawing.Point(313, 34)
        Me.LPrecio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LPrecio.Name = "LPrecio"
        Me.LPrecio.Size = New System.Drawing.Size(56, 19)
        Me.LPrecio.TabIndex = 16
        Me.LPrecio.Text = "Precio"
        '
        'LProductoDescripcion
        '
        Me.LProductoDescripcion.AutoSize = True
        Me.LProductoDescripcion.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.LProductoDescripcion.ForeColor = System.Drawing.Color.White
        Me.LProductoDescripcion.Location = New System.Drawing.Point(17, 34)
        Me.LProductoDescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LProductoDescripcion.Name = "LProductoDescripcion"
        Me.LProductoDescripcion.Size = New System.Drawing.Size(76, 19)
        Me.LProductoDescripcion.TabIndex = 3
        Me.LProductoDescripcion.Text = "Producto"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BBuscarCliente)
        Me.GroupBox1.Controls.Add(Me.TBNombreCliVenta)
        Me.GroupBox1.Controls.Add(Me.LNombreCli)
        Me.GroupBox1.Controls.Add(Me.LNombreCliente)
        Me.GroupBox1.Controls.Add(Me.TBDniCliVenta)
        Me.GroupBox1.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(55, 144)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1038, 102)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'BBuscarCliente
        '
        Me.BBuscarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BBuscarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BBuscarCliente.FlatAppearance.BorderSize = 2
        Me.BBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBuscarCliente.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscarCliente.ForeColor = System.Drawing.Color.White
        Me.BBuscarCliente.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.search_3_32
        Me.BBuscarCliente.Location = New System.Drawing.Point(200, 39)
        Me.BBuscarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.BBuscarCliente.Name = "BBuscarCliente"
        Me.BBuscarCliente.Size = New System.Drawing.Size(52, 44)
        Me.BBuscarCliente.TabIndex = 20
        Me.BBuscarCliente.UseVisualStyleBackColor = False
        '
        'TBNombreCliVenta
        '
        Me.TBNombreCliVenta.Enabled = False
        Me.TBNombreCliVenta.Location = New System.Drawing.Point(317, 49)
        Me.TBNombreCliVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.TBNombreCliVenta.Name = "TBNombreCliVenta"
        Me.TBNombreCliVenta.Size = New System.Drawing.Size(161, 26)
        Me.TBNombreCliVenta.TabIndex = 18
        '
        'LNombreCli
        '
        Me.LNombreCli.AutoSize = True
        Me.LNombreCli.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.LNombreCli.ForeColor = System.Drawing.Color.White
        Me.LNombreCli.Location = New System.Drawing.Point(313, 22)
        Me.LNombreCli.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LNombreCli.Name = "LNombreCli"
        Me.LNombreCli.Size = New System.Drawing.Size(66, 19)
        Me.LNombreCli.TabIndex = 19
        Me.LNombreCli.Text = "Nombre"
        '
        'LNombreCliente
        '
        Me.LNombreCliente.AutoSize = True
        Me.LNombreCliente.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.LNombreCliente.ForeColor = System.Drawing.Color.White
        Me.LNombreCliente.Location = New System.Drawing.Point(17, 26)
        Me.LNombreCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LNombreCliente.Name = "LNombreCliente"
        Me.LNombreCliente.Size = New System.Drawing.Size(35, 19)
        Me.LNombreCliente.TabIndex = 18
        Me.LNombreCliente.Text = "DNI"
        '
        'TBDniCliVenta
        '
        Me.TBDniCliVenta.Location = New System.Drawing.Point(21, 49)
        Me.TBDniCliVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.TBDniCliVenta.Name = "TBDniCliVenta"
        Me.TBDniCliVenta.Size = New System.Drawing.Size(161, 26)
        Me.TBDniCliVenta.TabIndex = 11
        '
        'DataGridListaVentas
        '
        Me.DataGridListaVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridListaVentas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.DataGridListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridListaVentas.Location = New System.Drawing.Point(55, 417)
        Me.DataGridListaVentas.Name = "DataGridListaVentas"
        Me.DataGridListaVentas.RowHeadersWidth = 51
        Me.DataGridListaVentas.RowTemplate.Height = 24
        Me.DataGridListaVentas.Size = New System.Drawing.Size(932, 157)
        Me.DataGridListaVentas.TabIndex = 20
        '
        'BModificarProducto
        '
        Me.BModificarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BModificarProducto.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BModificarProducto.FlatAppearance.BorderSize = 2
        Me.BModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModificarProducto.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BModificarProducto.ForeColor = System.Drawing.Color.White
        Me.BModificarProducto.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.trash_6_32
        Me.BModificarProducto.Location = New System.Drawing.Point(1013, 498)
        Me.BModificarProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.BModificarProducto.Name = "BModificarProducto"
        Me.BModificarProducto.Size = New System.Drawing.Size(55, 55)
        Me.BModificarProducto.TabIndex = 21
        Me.BModificarProducto.UseVisualStyleBackColor = False
        '
        'BEliminarProducto
        '
        Me.BEliminarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BEliminarProducto.FlatAppearance.BorderSize = 2
        Me.BEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEliminarProducto.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminarProducto.ForeColor = System.Drawing.Color.White
        Me.BEliminarProducto.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.edit_12_32
        Me.BEliminarProducto.Location = New System.Drawing.Point(1013, 430)
        Me.BEliminarProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.BEliminarProducto.Name = "BEliminarProducto"
        Me.BEliminarProducto.Size = New System.Drawing.Size(55, 55)
        Me.BEliminarProducto.TabIndex = 12
        Me.BEliminarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BEliminarProducto.UseVisualStyleBackColor = False
        '
        'BRegistraProducto
        '
        Me.BRegistraProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BRegistraProducto.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BRegistraProducto.FlatAppearance.BorderSize = 2
        Me.BRegistraProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRegistraProducto.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BRegistraProducto.ForeColor = System.Drawing.Color.White
        Me.BRegistraProducto.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.plus_32
        Me.BRegistraProducto.Location = New System.Drawing.Point(1013, 498)
        Me.BRegistraProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.BRegistraProducto.Name = "BRegistraProducto"
        Me.BRegistraProducto.Size = New System.Drawing.Size(55, 55)
        Me.BRegistraProducto.TabIndex = 13
        Me.BRegistraProducto.UseVisualStyleBackColor = False
        '
        'AñadirVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 656)
        Me.Controls.Add(Me.BModificarProducto)
        Me.Controls.Add(Me.LTotalVenta)
        Me.Controls.Add(Me.TBApellidoCliente)
        Me.Controls.Add(Me.BEliminarProducto)
        Me.Controls.Add(Me.BRegistraProducto)
        Me.Controls.Add(Me.DataGridListaVentas)
        Me.Controls.Add(Me.LTituloVentas)
        Me.Controls.Add(Me.GroupBoxProductos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LNumeroFactura)
        Me.Controls.Add(Me.TBNombreCliente)
        Me.Enabled = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "AñadirVenta"
        Me.Text = "RegistrarVenta"
        Me.GroupBoxProductos.ResumeLayout(False)
        Me.GroupBoxProductos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridListaVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LTituloVentas As Label
    Friend WithEvents LNumeroFactura As Label
    Friend WithEvents LTotalVenta As Label
    Friend WithEvents TBNombreCliente As TextBox
    Friend WithEvents TBApellidoCliente As TextBox
    Friend WithEvents BEliminarProducto As Button
    Friend WithEvents BRegistraProducto As Button
    Friend WithEvents GroupBoxProductos As GroupBox
    Friend WithEvents BBuscarProducto As Button
    Friend WithEvents LStock As Label
    Friend WithEvents TBCorreoCliente As TextBox
    Friend WithEvents TBPrecio As TextBox
    Friend WithEvents TBDniCliente As TextBox
    Friend WithEvents TBTelCliente As TextBox
    Friend WithEvents LCantidad As Label
    Friend WithEvents LPrecio As Label
    Friend WithEvents LProductoDescripcion As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TBNombreCliVenta As TextBox
    Friend WithEvents LNombreCli As Label
    Friend WithEvents LNombreCliente As Label
    Friend WithEvents TBDniCliVenta As TextBox
    Friend WithEvents DataGridListaVentas As DataGridView
    Friend WithEvents BModificarProducto As Button
    Friend WithEvents BBuscarCliente As Button
End Class
