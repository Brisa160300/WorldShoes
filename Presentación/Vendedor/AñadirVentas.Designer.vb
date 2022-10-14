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
        Me.dgvListaVentas = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Talle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBVendedor = New System.Windows.Forms.TextBox()
        Me.LVendedor = New System.Windows.Forms.Label()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.BModificarProducto = New System.Windows.Forms.Button()
        Me.LTotalVenta = New System.Windows.Forms.Label()
        Me.TBApellidoCliente = New System.Windows.Forms.TextBox()
        Me.BEliminarProducto = New System.Windows.Forms.Button()
        Me.BRegistraProducto = New System.Windows.Forms.Button()
        Me.LTituloVentas = New System.Windows.Forms.Label()
        Me.GroupBoxProductos = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LTalle = New System.Windows.Forms.Label()
        Me.BBuscarProducto = New System.Windows.Forms.Button()
        Me.LStock = New System.Windows.Forms.Label()
        Me.TBStock = New System.Windows.Forms.TextBox()
        Me.TBPrecio = New System.Windows.Forms.TextBox()
        Me.TBCantidad = New System.Windows.Forms.TextBox()
        Me.TBProductoVenta = New System.Windows.Forms.TextBox()
        Me.LCantidad = New System.Windows.Forms.Label()
        Me.LPrecio = New System.Windows.Forms.Label()
        Me.LProductoDescripcion = New System.Windows.Forms.Label()
        Me.GroupBoxDatosClientes = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBTelCli = New System.Windows.Forms.TextBox()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.TBApellido = New System.Windows.Forms.TextBox()
        Me.BuscarProducto = New System.Windows.Forms.Button()
        Me.TBNombreCliVenta = New System.Windows.Forms.TextBox()
        Me.LNombreCli = New System.Windows.Forms.Label()
        Me.LNombreCliente = New System.Windows.Forms.Label()
        Me.TBDniCliVenta = New System.Windows.Forms.TextBox()
        Me.LNumeroFactura = New System.Windows.Forms.Label()
        Me.TBNroFactura = New System.Windows.Forms.TextBox()
        CType(Me.dgvListaVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxProductos.SuspendLayout()
        Me.GroupBoxDatosClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvListaVentas
        '
        Me.dgvListaVentas.AllowUserToDeleteRows = False
        Me.dgvListaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListaVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListaVentas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgvListaVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListaVentas.ColumnHeadersHeight = 20
        Me.dgvListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvListaVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Descripcion, Me.Precio, Me.Cantidad, Me.Talle})
        Me.dgvListaVentas.EnableHeadersVisualStyles = False
        Me.dgvListaVentas.Location = New System.Drawing.Point(39, 400)
        Me.dgvListaVentas.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.dgvListaVentas.Name = "dgvListaVentas"
        Me.dgvListaVentas.ReadOnly = True
        Me.dgvListaVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListaVentas.RowHeadersWidth = 51
        Me.dgvListaVentas.RowTemplate.Height = 24
        Me.dgvListaVentas.Size = New System.Drawing.Size(944, 140)
        Me.dgvListaVentas.TabIndex = 55
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.MinimumWidth = 6
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.MinimumWidth = 6
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.MinimumWidth = 6
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Talle
        '
        Me.Talle.HeaderText = "Talle"
        Me.Talle.MinimumWidth = 6
        Me.Talle.Name = "Talle"
        Me.Talle.ReadOnly = True
        '
        'TBVendedor
        '
        Me.TBVendedor.Enabled = False
        Me.TBVendedor.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.TBVendedor.Location = New System.Drawing.Point(667, 64)
        Me.TBVendedor.Margin = New System.Windows.Forms.Padding(5)
        Me.TBVendedor.Name = "TBVendedor"
        Me.TBVendedor.Size = New System.Drawing.Size(131, 26)
        Me.TBVendedor.TabIndex = 43
        '
        'LVendedor
        '
        Me.LVendedor.AutoSize = True
        Me.LVendedor.BackColor = System.Drawing.Color.Transparent
        Me.LVendedor.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.LVendedor.ForeColor = System.Drawing.Color.White
        Me.LVendedor.Location = New System.Drawing.Point(570, 67)
        Me.LVendedor.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LVendedor.Name = "LVendedor"
        Me.LVendedor.Size = New System.Drawing.Size(83, 19)
        Me.LVendedor.TabIndex = 54
        Me.LVendedor.Text = "Vendedor:"
        '
        'BGuardar
        '
        Me.BGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BGuardar.FlatAppearance.BorderSize = 2
        Me.BGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BGuardar.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BGuardar.ForeColor = System.Drawing.Color.White
        Me.BGuardar.Location = New System.Drawing.Point(694, 566)
        Me.BGuardar.Margin = New System.Windows.Forms.Padding(5)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(145, 51)
        Me.BGuardar.TabIndex = 53
        Me.BGuardar.Text = "Guardar"
        Me.BGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BGuardar.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(398, 66)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(129, 26)
        Me.DateTimePicker1.TabIndex = 52
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.BackColor = System.Drawing.Color.Transparent
        Me.LFecha.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.LFecha.ForeColor = System.Drawing.Color.White
        Me.LFecha.Location = New System.Drawing.Point(319, 67)
        Me.LFecha.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(57, 19)
        Me.LFecha.TabIndex = 51
        Me.LFecha.Text = "Fecha:"
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVolver.ForeColor = System.Drawing.Color.White
        Me.BVolver.Location = New System.Drawing.Point(859, 566)
        Me.BVolver.Margin = New System.Windows.Forms.Padding(5)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(126, 51)
        Me.BVolver.TabIndex = 50
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
        Me.BModificarProducto.Location = New System.Drawing.Point(1016, 509)
        Me.BModificarProducto.Margin = New System.Windows.Forms.Padding(5)
        Me.BModificarProducto.Name = "BModificarProducto"
        Me.BModificarProducto.Size = New System.Drawing.Size(65, 52)
        Me.BModificarProducto.TabIndex = 49
        Me.BModificarProducto.UseVisualStyleBackColor = False
        '
        'LTotalVenta
        '
        Me.LTotalVenta.AutoSize = True
        Me.LTotalVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LTotalVenta.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LTotalVenta.ForeColor = System.Drawing.Color.White
        Me.LTotalVenta.Location = New System.Drawing.Point(38, 584)
        Me.LTotalVenta.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LTotalVenta.Name = "LTotalVenta"
        Me.LTotalVenta.Size = New System.Drawing.Size(59, 22)
        Me.LTotalVenta.TabIndex = 41
        Me.LTotalVenta.Text = "Total:"
        '
        'TBApellidoCliente
        '
        Me.TBApellidoCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBApellidoCliente.Location = New System.Drawing.Point(107, 581)
        Me.TBApellidoCliente.Margin = New System.Windows.Forms.Padding(5)
        Me.TBApellidoCliente.Name = "TBApellidoCliente"
        Me.TBApellidoCliente.Size = New System.Drawing.Size(123, 30)
        Me.TBApellidoCliente.TabIndex = 44
        Me.TBApellidoCliente.Text = "$"
        '
        'BEliminarProducto
        '
        Me.BEliminarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BEliminarProducto.FlatAppearance.BorderSize = 2
        Me.BEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEliminarProducto.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminarProducto.ForeColor = System.Drawing.Color.White
        Me.BEliminarProducto.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.edit_12_32
        Me.BEliminarProducto.Location = New System.Drawing.Point(1016, 436)
        Me.BEliminarProducto.Margin = New System.Windows.Forms.Padding(5)
        Me.BEliminarProducto.Name = "BEliminarProducto"
        Me.BEliminarProducto.Size = New System.Drawing.Size(65, 52)
        Me.BEliminarProducto.TabIndex = 45
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
        Me.BRegistraProducto.Location = New System.Drawing.Point(1016, 509)
        Me.BRegistraProducto.Margin = New System.Windows.Forms.Padding(5)
        Me.BRegistraProducto.Name = "BRegistraProducto"
        Me.BRegistraProducto.Size = New System.Drawing.Size(65, 52)
        Me.BRegistraProducto.TabIndex = 46
        Me.BRegistraProducto.UseVisualStyleBackColor = False
        '
        'LTituloVentas
        '
        Me.LTituloVentas.AutoSize = True
        Me.LTituloVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.LTituloVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LTituloVentas.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTituloVentas.ForeColor = System.Drawing.Color.White
        Me.LTituloVentas.Location = New System.Drawing.Point(36, 22)
        Me.LTituloVentas.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LTituloVentas.Name = "LTituloVentas"
        Me.LTituloVentas.Size = New System.Drawing.Size(177, 33)
        Me.LTituloVentas.TabIndex = 40
        Me.LTituloVentas.Text = "Nueva Venta"
        '
        'GroupBoxProductos
        '
        Me.GroupBoxProductos.Controls.Add(Me.ComboBox1)
        Me.GroupBoxProductos.Controls.Add(Me.LTalle)
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
        Me.GroupBoxProductos.Location = New System.Drawing.Point(38, 250)
        Me.GroupBoxProductos.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBoxProductos.Name = "GroupBoxProductos"
        Me.GroupBoxProductos.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GroupBoxProductos.Size = New System.Drawing.Size(1043, 128)
        Me.GroupBoxProductos.TabIndex = 47
        Me.GroupBoxProductos.TabStop = False
        Me.GroupBoxProductos.Text = "Articulos"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(628, 70)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(133, 27)
        Me.ComboBox1.TabIndex = 25
        '
        'LTalle
        '
        Me.LTalle.AutoSize = True
        Me.LTalle.BackColor = System.Drawing.Color.Transparent
        Me.LTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LTalle.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.LTalle.ForeColor = System.Drawing.Color.White
        Me.LTalle.Location = New System.Drawing.Point(625, 42)
        Me.LTalle.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LTalle.Name = "LTalle"
        Me.LTalle.Size = New System.Drawing.Size(45, 19)
        Me.LTalle.TabIndex = 19
        Me.LTalle.Text = "Talle"
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
        Me.BBuscarProducto.Location = New System.Drawing.Point(192, 57)
        Me.BBuscarProducto.Margin = New System.Windows.Forms.Padding(5)
        Me.BBuscarProducto.Name = "BBuscarProducto"
        Me.BBuscarProducto.Size = New System.Drawing.Size(65, 52)
        Me.BBuscarProducto.TabIndex = 14
        Me.BBuscarProducto.UseVisualStyleBackColor = False
        '
        'LStock
        '
        Me.LStock.AutoSize = True
        Me.LStock.BackColor = System.Drawing.Color.Transparent
        Me.LStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LStock.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.LStock.ForeColor = System.Drawing.Color.White
        Me.LStock.Location = New System.Drawing.Point(460, 42)
        Me.LStock.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LStock.Name = "LStock"
        Me.LStock.Size = New System.Drawing.Size(49, 19)
        Me.LStock.TabIndex = 14
        Me.LStock.Text = "Stock"
        '
        'TBStock
        '
        Me.TBStock.Enabled = False
        Me.TBStock.Location = New System.Drawing.Point(464, 71)
        Me.TBStock.Margin = New System.Windows.Forms.Padding(5)
        Me.TBStock.Name = "TBStock"
        Me.TBStock.Size = New System.Drawing.Size(133, 26)
        Me.TBStock.TabIndex = 15
        '
        'TBPrecio
        '
        Me.TBPrecio.Enabled = False
        Me.TBPrecio.Location = New System.Drawing.Point(286, 71)
        Me.TBPrecio.Margin = New System.Windows.Forms.Padding(5)
        Me.TBPrecio.Name = "TBPrecio"
        Me.TBPrecio.Size = New System.Drawing.Size(133, 26)
        Me.TBPrecio.TabIndex = 17
        Me.TBPrecio.Text = "$"
        '
        'TBCantidad
        '
        Me.TBCantidad.Location = New System.Drawing.Point(807, 70)
        Me.TBCantidad.Margin = New System.Windows.Forms.Padding(5)
        Me.TBCantidad.Name = "TBCantidad"
        Me.TBCantidad.Size = New System.Drawing.Size(138, 26)
        Me.TBCantidad.TabIndex = 7
        '
        'TBProductoVenta
        '
        Me.TBProductoVenta.Enabled = False
        Me.TBProductoVenta.Location = New System.Drawing.Point(26, 71)
        Me.TBProductoVenta.Margin = New System.Windows.Forms.Padding(5)
        Me.TBProductoVenta.Name = "TBProductoVenta"
        Me.TBProductoVenta.Size = New System.Drawing.Size(143, 26)
        Me.TBProductoVenta.TabIndex = 10
        '
        'LCantidad
        '
        Me.LCantidad.AutoSize = True
        Me.LCantidad.BackColor = System.Drawing.Color.Transparent
        Me.LCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LCantidad.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.LCantidad.ForeColor = System.Drawing.Color.White
        Me.LCantidad.Location = New System.Drawing.Point(805, 42)
        Me.LCantidad.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
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
        Me.LPrecio.Location = New System.Drawing.Point(282, 42)
        Me.LPrecio.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
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
        Me.LProductoDescripcion.Location = New System.Drawing.Point(21, 42)
        Me.LProductoDescripcion.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LProductoDescripcion.Name = "LProductoDescripcion"
        Me.LProductoDescripcion.Size = New System.Drawing.Size(60, 19)
        Me.LProductoDescripcion.TabIndex = 3
        Me.LProductoDescripcion.Text = "Codigo"
        '
        'GroupBoxDatosClientes
        '
        Me.GroupBoxDatosClientes.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxDatosClientes.Controls.Add(Me.Label2)
        Me.GroupBoxDatosClientes.Controls.Add(Me.TBTelCli)
        Me.GroupBoxDatosClientes.Controls.Add(Me.LApellido)
        Me.GroupBoxDatosClientes.Controls.Add(Me.TBApellido)
        Me.GroupBoxDatosClientes.Controls.Add(Me.BuscarProducto)
        Me.GroupBoxDatosClientes.Controls.Add(Me.TBNombreCliVenta)
        Me.GroupBoxDatosClientes.Controls.Add(Me.LNombreCli)
        Me.GroupBoxDatosClientes.Controls.Add(Me.LNombreCliente)
        Me.GroupBoxDatosClientes.Controls.Add(Me.TBDniCliVenta)
        Me.GroupBoxDatosClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBoxDatosClientes.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.GroupBoxDatosClientes.ForeColor = System.Drawing.Color.White
        Me.GroupBoxDatosClientes.Location = New System.Drawing.Point(38, 118)
        Me.GroupBoxDatosClientes.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GroupBoxDatosClientes.Name = "GroupBoxDatosClientes"
        Me.GroupBoxDatosClientes.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GroupBoxDatosClientes.Size = New System.Drawing.Size(1043, 118)
        Me.GroupBoxDatosClientes.TabIndex = 48
        Me.GroupBoxDatosClientes.TabStop = False
        Me.GroupBoxDatosClientes.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(624, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 19)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Telefono"
        '
        'TBTelCli
        '
        Me.TBTelCli.Enabled = False
        Me.TBTelCli.Location = New System.Drawing.Point(629, 67)
        Me.TBTelCli.Margin = New System.Windows.Forms.Padding(5)
        Me.TBTelCli.Name = "TBTelCli"
        Me.TBTelCli.Size = New System.Drawing.Size(133, 26)
        Me.TBTelCli.TabIndex = 23
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.LApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LApellido.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.LApellido.ForeColor = System.Drawing.Color.White
        Me.LApellido.Location = New System.Drawing.Point(459, 32)
        Me.LApellido.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(68, 19)
        Me.LApellido.TabIndex = 22
        Me.LApellido.Text = "Apellido"
        '
        'TBApellido
        '
        Me.TBApellido.Enabled = False
        Me.TBApellido.Location = New System.Drawing.Point(463, 67)
        Me.TBApellido.Margin = New System.Windows.Forms.Padding(5)
        Me.TBApellido.Name = "TBApellido"
        Me.TBApellido.Size = New System.Drawing.Size(133, 26)
        Me.TBApellido.TabIndex = 21
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
        Me.BuscarProducto.Location = New System.Drawing.Point(192, 46)
        Me.BuscarProducto.Margin = New System.Windows.Forms.Padding(5)
        Me.BuscarProducto.Name = "BuscarProducto"
        Me.BuscarProducto.Size = New System.Drawing.Size(65, 52)
        Me.BuscarProducto.TabIndex = 20
        Me.BuscarProducto.UseVisualStyleBackColor = False
        '
        'TBNombreCliVenta
        '
        Me.TBNombreCliVenta.Enabled = False
        Me.TBNombreCliVenta.Location = New System.Drawing.Point(286, 67)
        Me.TBNombreCliVenta.Margin = New System.Windows.Forms.Padding(5)
        Me.TBNombreCliVenta.Name = "TBNombreCliVenta"
        Me.TBNombreCliVenta.Size = New System.Drawing.Size(133, 26)
        Me.TBNombreCliVenta.TabIndex = 18
        '
        'LNombreCli
        '
        Me.LNombreCli.AutoSize = True
        Me.LNombreCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.LNombreCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LNombreCli.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.LNombreCli.ForeColor = System.Drawing.Color.White
        Me.LNombreCli.Location = New System.Drawing.Point(281, 32)
        Me.LNombreCli.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
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
        Me.LNombreCliente.Location = New System.Drawing.Point(21, 32)
        Me.LNombreCliente.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LNombreCliente.Name = "LNombreCliente"
        Me.LNombreCliente.Size = New System.Drawing.Size(35, 19)
        Me.LNombreCliente.TabIndex = 18
        Me.LNombreCliente.Text = "DNI"
        '
        'TBDniCliVenta
        '
        Me.TBDniCliVenta.Enabled = False
        Me.TBDniCliVenta.Location = New System.Drawing.Point(26, 61)
        Me.TBDniCliVenta.Margin = New System.Windows.Forms.Padding(5)
        Me.TBDniCliVenta.Name = "TBDniCliVenta"
        Me.TBDniCliVenta.Size = New System.Drawing.Size(143, 26)
        Me.TBDniCliVenta.TabIndex = 11
        '
        'LNumeroFactura
        '
        Me.LNumeroFactura.AutoSize = True
        Me.LNumeroFactura.BackColor = System.Drawing.Color.Transparent
        Me.LNumeroFactura.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.LNumeroFactura.ForeColor = System.Drawing.Color.White
        Me.LNumeroFactura.Location = New System.Drawing.Point(38, 73)
        Me.LNumeroFactura.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LNumeroFactura.Name = "LNumeroFactura"
        Me.LNumeroFactura.Size = New System.Drawing.Size(93, 19)
        Me.LNumeroFactura.TabIndex = 39
        Me.LNumeroFactura.Text = "N° Factura:"
        '
        'TBNroFactura
        '
        Me.TBNroFactura.CausesValidation = False
        Me.TBNroFactura.Enabled = False
        Me.TBNroFactura.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.TBNroFactura.Location = New System.Drawing.Point(141, 69)
        Me.TBNroFactura.Margin = New System.Windows.Forms.Padding(5)
        Me.TBNroFactura.Name = "TBNroFactura"
        Me.TBNroFactura.Size = New System.Drawing.Size(123, 26)
        Me.TBNroFactura.TabIndex = 42
        '
        'AñadirVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 656)
        Me.Controls.Add(Me.dgvListaVentas)
        Me.Controls.Add(Me.TBVendedor)
        Me.Controls.Add(Me.LVendedor)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.LFecha)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.BModificarProducto)
        Me.Controls.Add(Me.LTotalVenta)
        Me.Controls.Add(Me.TBApellidoCliente)
        Me.Controls.Add(Me.BEliminarProducto)
        Me.Controls.Add(Me.BRegistraProducto)
        Me.Controls.Add(Me.LTituloVentas)
        Me.Controls.Add(Me.GroupBoxProductos)
        Me.Controls.Add(Me.GroupBoxDatosClientes)
        Me.Controls.Add(Me.LNumeroFactura)
        Me.Controls.Add(Me.TBNroFactura)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AñadirVentas"
        Me.Text = "ListarV"
        CType(Me.dgvListaVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxProductos.ResumeLayout(False)
        Me.GroupBoxProductos.PerformLayout()
        Me.GroupBoxDatosClientes.ResumeLayout(False)
        Me.GroupBoxDatosClientes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvListaVentas As DataGridView
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Talle As DataGridViewTextBoxColumn
    Friend WithEvents TBVendedor As TextBox
    Friend WithEvents LVendedor As Label
    Friend WithEvents BGuardar As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents LFecha As Label
    Friend WithEvents BVolver As Button
    Friend WithEvents BModificarProducto As Button
    Friend WithEvents LTotalVenta As Label
    Friend WithEvents TBApellidoCliente As TextBox
    Friend WithEvents BEliminarProducto As Button
    Friend WithEvents BRegistraProducto As Button
    Friend WithEvents LTituloVentas As Label
    Friend WithEvents GroupBoxProductos As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents LTalle As Label
    Friend WithEvents BBuscarProducto As Button
    Friend WithEvents LStock As Label
    Friend WithEvents TBStock As TextBox
    Friend WithEvents TBPrecio As TextBox
    Friend WithEvents TBCantidad As TextBox
    Friend WithEvents TBProductoVenta As TextBox
    Friend WithEvents LCantidad As Label
    Friend WithEvents LPrecio As Label
    Friend WithEvents LProductoDescripcion As Label
    Friend WithEvents GroupBoxDatosClientes As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBTelCli As TextBox
    Friend WithEvents LApellido As Label
    Friend WithEvents TBApellido As TextBox
    Friend WithEvents BuscarProducto As Button
    Friend WithEvents TBNombreCliVenta As TextBox
    Friend WithEvents LNombreCli As Label
    Friend WithEvents LNombreCliente As Label
    Friend WithEvents TBDniCliVenta As TextBox
    Friend WithEvents LNumeroFactura As Label
    Friend WithEvents TBNroFactura As TextBox
End Class
