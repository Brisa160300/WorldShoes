<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AñadirVentas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LTotalVenta = New System.Windows.Forms.Label()
        Me.TBApellidoCliente = New System.Windows.Forms.TextBox()
        Me.DataGridListaVentas = New System.Windows.Forms.DataGridView()
        Me.LTituloVentas = New System.Windows.Forms.Label()
        Me.GroupBoxProductos = New System.Windows.Forms.GroupBox()
        Me.LStock = New System.Windows.Forms.Label()
        Me.TBStock = New System.Windows.Forms.TextBox()
        Me.TBPrecio = New System.Windows.Forms.TextBox()
        Me.TBCantidad = New System.Windows.Forms.TextBox()
        Me.TBProductoVenta = New System.Windows.Forms.TextBox()
        Me.LCantidad = New System.Windows.Forms.Label()
        Me.LPrecio = New System.Windows.Forms.Label()
        Me.LProductoDescripcion = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TBNombreCliVenta = New System.Windows.Forms.TextBox()
        Me.LNombreCli = New System.Windows.Forms.Label()
        Me.LNombreCliente = New System.Windows.Forms.Label()
        Me.TBDniCliVenta = New System.Windows.Forms.TextBox()
        Me.LNumeroFactura = New System.Windows.Forms.Label()
        Me.TBNroFactura = New System.Windows.Forms.TextBox()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.BModificarProducto = New System.Windows.Forms.Button()
        Me.BEliminarProducto = New System.Windows.Forms.Button()
        Me.BRegistraProducto = New System.Windows.Forms.Button()
        Me.BBuscarProducto = New System.Windows.Forms.Button()
        Me.BuscarProducto = New System.Windows.Forms.Button()
        CType(Me.DataGridListaVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxProductos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LTotalVenta
        '
        Me.LTotalVenta.AutoSize = True
        Me.LTotalVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LTotalVenta.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LTotalVenta.ForeColor = System.Drawing.Color.White
        Me.LTotalVenta.Location = New System.Drawing.Point(59, 595)
        Me.LTotalVenta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LTotalVenta.Name = "LTotalVenta"
        Me.LTotalVenta.Size = New System.Drawing.Size(59, 22)
        Me.LTotalVenta.TabIndex = 24
        Me.LTotalVenta.Text = "Total:"
        '
        'TBApellidoCliente
        '
        Me.TBApellidoCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBApellidoCliente.Location = New System.Drawing.Point(131, 592)
        Me.TBApellidoCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBApellidoCliente.Name = "TBApellidoCliente"
        Me.TBApellidoCliente.Size = New System.Drawing.Size(99, 30)
        Me.TBApellidoCliente.TabIndex = 26
        Me.TBApellidoCliente.Text = "$"
        '
        'DataGridListaVentas
        '
        Me.DataGridListaVentas.AllowUserToAddRows = False
        Me.DataGridListaVentas.AllowUserToDeleteRows = False
        Me.DataGridListaVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridListaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridListaVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridListaVentas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.DataGridListaVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.2!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridListaVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridListaVentas.ColumnHeadersHeight = 20
        Me.DataGridListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridListaVentas.EnableHeadersVisualStyles = False
        Me.DataGridListaVentas.Location = New System.Drawing.Point(59, 415)
        Me.DataGridListaVentas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridListaVentas.Name = "DataGridListaVentas"
        Me.DataGridListaVentas.ReadOnly = True
        Me.DataGridListaVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridListaVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridListaVentas.RowHeadersWidth = 51
        Me.DataGridListaVentas.RowTemplate.Height = 24
        Me.DataGridListaVentas.Size = New System.Drawing.Size(951, 158)
        Me.DataGridListaVentas.TabIndex = 31
        '
        'LTituloVentas
        '
        Me.LTituloVentas.AutoSize = True
        Me.LTituloVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.LTituloVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LTituloVentas.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTituloVentas.ForeColor = System.Drawing.Color.White
        Me.LTituloVentas.Location = New System.Drawing.Point(53, 37)
        Me.LTituloVentas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LTituloVentas.Name = "LTituloVentas"
        Me.LTituloVentas.Size = New System.Drawing.Size(177, 33)
        Me.LTituloVentas.TabIndex = 23
        Me.LTituloVentas.Text = "Nueva Venta"
        '
        'GroupBoxProductos
        '
        Me.GroupBoxProductos.Controls.Add(Me.BBuscarProducto)
        Me.GroupBoxProductos.Controls.Add(Me.LStock)
        Me.GroupBoxProductos.Controls.Add(Me.TBStock)
        Me.GroupBoxProductos.Controls.Add(Me.TBPrecio)
        Me.GroupBoxProductos.Controls.Add(Me.TBCantidad)
        Me.GroupBoxProductos.Controls.Add(Me.TBProductoVenta)
        Me.GroupBoxProductos.Controls.Add(Me.LCantidad)
        Me.GroupBoxProductos.Controls.Add(Me.LPrecio)
        Me.GroupBoxProductos.Controls.Add(Me.LProductoDescripcion)
        Me.GroupBoxProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBoxProductos.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.GroupBoxProductos.ForeColor = System.Drawing.Color.White
        Me.GroupBoxProductos.Location = New System.Drawing.Point(59, 260)
        Me.GroupBoxProductos.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBoxProductos.Name = "GroupBoxProductos"
        Me.GroupBoxProductos.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBoxProductos.Size = New System.Drawing.Size(1037, 133)
        Me.GroupBoxProductos.TabIndex = 29
        Me.GroupBoxProductos.TabStop = False
        Me.GroupBoxProductos.Text = "Articulos"
        '
        'LStock
        '
        Me.LStock.AutoSize = True
        Me.LStock.BackColor = System.Drawing.Color.Transparent
        Me.LStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LStock.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.LStock.ForeColor = System.Drawing.Color.White
        Me.LStock.Location = New System.Drawing.Point(451, 34)
        Me.LStock.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(49, 19)
        Me.LStock.TabIndex = 14
        Me.LStock.Text = "Stock"
        '
        'TBStock
        '
        Me.TBStock.Location = New System.Drawing.Point(455, 69)
        Me.TBStock.Margin = New System.Windows.Forms.Padding(4)
        Me.TBStock.Name = "TBStock"
        Me.TBStock.Size = New System.Drawing.Size(161, 26)
        Me.TBStock.TabIndex = 15
        '
        'TBPrecio
        '
        Me.TBPrecio.Location = New System.Drawing.Point(317, 71)
        Me.TBPrecio.Margin = New System.Windows.Forms.Padding(4)
        Me.TBPrecio.Name = "TBPrecio"
        Me.TBPrecio.Size = New System.Drawing.Size(116, 26)
        Me.TBPrecio.TabIndex = 17
        Me.TBPrecio.Text = "$"
        '
        'TBCantidad
        '
        Me.TBCantidad.Location = New System.Drawing.Point(639, 69)
        Me.TBCantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.TBCantidad.Name = "TBCantidad"
        Me.TBCantidad.Size = New System.Drawing.Size(111, 26)
        Me.TBCantidad.TabIndex = 7
        '
        'TBProductoVenta
        '
        Me.TBProductoVenta.Location = New System.Drawing.Point(21, 71)
        Me.TBProductoVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.TBProductoVenta.Name = "TBProductoVenta"
        Me.TBProductoVenta.Size = New System.Drawing.Size(161, 26)
        Me.TBProductoVenta.TabIndex = 10
        '
        'LCantidad
        '
        Me.LCantidad.AutoSize = True
        Me.LCantidad.BackColor = System.Drawing.Color.Transparent
        Me.LCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
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
        Me.LPrecio.BackColor = System.Drawing.Color.Transparent
        Me.LPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
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
        Me.LProductoDescripcion.BackColor = System.Drawing.Color.Transparent
        Me.LProductoDescripcion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
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
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BuscarProducto)
        Me.GroupBox1.Controls.Add(Me.TBNombreCliVenta)
        Me.GroupBox1.Controls.Add(Me.LNombreCli)
        Me.GroupBox1.Controls.Add(Me.LNombreCliente)
        Me.GroupBox1.Controls.Add(Me.TBDniCliVenta)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(59, 142)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(1037, 102)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
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
        Me.LNombreCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.LNombreCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
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
        Me.LNombreCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.LNombreCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
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
        'LNumeroFactura
        '
        Me.LNumeroFactura.AutoSize = True
        Me.LNumeroFactura.BackColor = System.Drawing.Color.Transparent
        Me.LNumeroFactura.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.LNumeroFactura.ForeColor = System.Drawing.Color.White
        Me.LNumeroFactura.Location = New System.Drawing.Point(59, 94)
        Me.LNumeroFactura.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LNumeroFactura.Name = "LNumeroFactura"
        Me.LNumeroFactura.Size = New System.Drawing.Size(93, 19)
        Me.LNumeroFactura.TabIndex = 22
        Me.LNumeroFactura.Text = "N° Factura:"
        '
        'TBNroFactura
        '
        Me.TBNroFactura.CausesValidation = False
        Me.TBNroFactura.Enabled = False
        Me.TBNroFactura.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.TBNroFactura.Location = New System.Drawing.Point(177, 94)
        Me.TBNroFactura.Margin = New System.Windows.Forms.Padding(4)
        Me.TBNroFactura.Name = "TBNroFactura"
        Me.TBNroFactura.Size = New System.Drawing.Size(161, 26)
        Me.TBNroFactura.TabIndex = 25
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVolver.ForeColor = System.Drawing.Color.White
        Me.BVolver.Location = New System.Drawing.Point(1032, 592)
        Me.BVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(101, 41)
        Me.BVolver.TabIndex = 33
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BVolver.UseVisualStyleBackColor = False
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
        Me.BModificarProducto.Location = New System.Drawing.Point(1032, 491)
        Me.BModificarProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.BModificarProducto.Name = "BModificarProducto"
        Me.BModificarProducto.Size = New System.Drawing.Size(55, 55)
        Me.BModificarProducto.TabIndex = 32
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
        Me.BEliminarProducto.Location = New System.Drawing.Point(1032, 428)
        Me.BEliminarProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.BEliminarProducto.Name = "BEliminarProducto"
        Me.BEliminarProducto.Size = New System.Drawing.Size(55, 55)
        Me.BEliminarProducto.TabIndex = 27
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
        Me.BRegistraProducto.Location = New System.Drawing.Point(1032, 491)
        Me.BRegistraProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.BRegistraProducto.Name = "BRegistraProducto"
        Me.BRegistraProducto.Size = New System.Drawing.Size(55, 55)
        Me.BRegistraProducto.TabIndex = 28
        Me.BRegistraProducto.UseVisualStyleBackColor = False
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
        'BuscarProducto
        '
        Me.BuscarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BuscarProducto.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BuscarProducto.FlatAppearance.BorderSize = 2
        Me.BuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BuscarProducto.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarProducto.ForeColor = System.Drawing.Color.White
        Me.BuscarProducto.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.search_3_32
        Me.BuscarProducto.Location = New System.Drawing.Point(200, 39)
        Me.BuscarProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.BuscarProducto.Name = "BuscarProducto"
        Me.BuscarProducto.Size = New System.Drawing.Size(52, 44)
        Me.BuscarProducto.TabIndex = 20
        Me.BuscarProducto.UseVisualStyleBackColor = False
        '
        'AñadirVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1149, 656)
        Me.Controls.Add(Me.BVolver)
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
        Me.Controls.Add(Me.TBNroFactura)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AñadirVentas"
        Me.Text = "ListarV"
        CType(Me.DataGridListaVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxProductos.ResumeLayout(False)
        Me.GroupBoxProductos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BModificarProducto As Button
    Friend WithEvents LTotalVenta As Label
    Friend WithEvents TBApellidoCliente As TextBox
    Friend WithEvents BEliminarProducto As Button
    Friend WithEvents BRegistraProducto As Button
    Friend WithEvents DataGridListaVentas As DataGridView
    Friend WithEvents LTituloVentas As Label
    Friend WithEvents GroupBoxProductos As GroupBox
    Friend WithEvents BBuscarProducto As Button
    Friend WithEvents LStock As Label
    Friend WithEvents TBStock As TextBox
    Friend WithEvents TBPrecio As TextBox
    Friend WithEvents TBCantidad As TextBox
    Friend WithEvents TBProductoVenta As TextBox
    Friend WithEvents LCantidad As Label
    Friend WithEvents LPrecio As Label
    Friend WithEvents LProductoDescripcion As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BuscarProducto As Button
    Friend WithEvents TBNombreCliVenta As TextBox
    Friend WithEvents LNombreCli As Label
    Friend WithEvents LNombreCliente As Label
    Friend WithEvents TBDniCliVenta As TextBox
    Friend WithEvents LNumeroFactura As Label
    Friend WithEvents TBNroFactura As TextBox
    Friend WithEvents BVolver As Button
End Class
