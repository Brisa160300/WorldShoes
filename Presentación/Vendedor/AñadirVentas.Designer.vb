<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AñadirVentas
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AñadirVentas))
        Me.TBVendedor = New System.Windows.Forms.TextBox()
        Me.LVendedor = New System.Windows.Forms.Label()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.LTotalVenta = New System.Windows.Forms.Label()
        Me.TBTotalVenta = New System.Windows.Forms.TextBox()
        Me.LTituloVentas = New System.Windows.Forms.Label()
        Me.GroupBoxProductos = New System.Windows.Forms.GroupBox()
        Me.Bconfmodificacion = New System.Windows.Forms.Button()
        Me.TBTalle = New System.Windows.Forms.TextBox()
        Me.AgregarProducto = New System.Windows.Forms.Button()
        Me.LTalle = New System.Windows.Forms.Label()
        Me.BBuscarProducto = New System.Windows.Forms.Button()
        Me.LStock = New System.Windows.Forms.Label()
        Me.TBStock = New System.Windows.Forms.TextBox()
        Me.TBCantidad = New System.Windows.Forms.TextBox()
        Me.TBCodigoProducto = New System.Windows.Forms.TextBox()
        Me.LCantidad = New System.Windows.Forms.Label()
        Me.LPrecio = New System.Windows.Forms.Label()
        Me.LProductoDescripcion = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TBPrecio = New System.Windows.Forms.TextBox()
        Me.GroupBoxDatosClientes = New System.Windows.Forms.GroupBox()
        Me.LDNI = New System.Windows.Forms.Label()
        Me.TBDniCliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBTelCli = New System.Windows.Forms.TextBox()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.TBApellido = New System.Windows.Forms.TextBox()
        Me.BuscarCliente = New System.Windows.Forms.Button()
        Me.TBNombreCliVenta = New System.Windows.Forms.TextBox()
        Me.LNombreCli = New System.Windows.Forms.Label()
        Me.LNombreCliente = New System.Windows.Forms.Label()
        Me.TBIdCliVenta = New System.Windows.Forms.TextBox()
        Me.LNumeroFactura = New System.Windows.Forms.Label()
        Me.TBNroFactura = New System.Windows.Forms.TextBox()
        Me.BEliminarProducto = New System.Windows.Forms.Button()
        Me.BModificarProducto = New System.Windows.Forms.Button()
        Me.dgvListaVentas = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ErrorProviderCantidad = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.GroupBoxProductos.SuspendLayout()
        Me.GroupBoxDatosClientes.SuspendLayout()
        CType(Me.dgvListaVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BGuardar.Text = "Confirmar"
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
        'TBTotalVenta
        '
        Me.TBTotalVenta.Enabled = False
        Me.TBTotalVenta.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBTotalVenta.Location = New System.Drawing.Point(130, 581)
        Me.TBTotalVenta.Margin = New System.Windows.Forms.Padding(5)
        Me.TBTotalVenta.Name = "TBTotalVenta"
        Me.TBTotalVenta.Size = New System.Drawing.Size(100, 30)
        Me.TBTotalVenta.TabIndex = 44
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
        Me.GroupBoxProductos.Controls.Add(Me.Bconfmodificacion)
        Me.GroupBoxProductos.Controls.Add(Me.TBTalle)
        Me.GroupBoxProductos.Controls.Add(Me.AgregarProducto)
        Me.GroupBoxProductos.Controls.Add(Me.LTalle)
        Me.GroupBoxProductos.Controls.Add(Me.BBuscarProducto)
        Me.GroupBoxProductos.Controls.Add(Me.LStock)
        Me.GroupBoxProductos.Controls.Add(Me.TBStock)
        Me.GroupBoxProductos.Controls.Add(Me.TBCantidad)
        Me.GroupBoxProductos.Controls.Add(Me.TBCodigoProducto)
        Me.GroupBoxProductos.Controls.Add(Me.LCantidad)
        Me.GroupBoxProductos.Controls.Add(Me.LPrecio)
        Me.GroupBoxProductos.Controls.Add(Me.LProductoDescripcion)
        Me.GroupBoxProductos.Controls.Add(Me.TextBox1)
        Me.GroupBoxProductos.Controls.Add(Me.TBPrecio)
        Me.GroupBoxProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBoxProductos.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.GroupBoxProductos.ForeColor = System.Drawing.Color.White
        Me.GroupBoxProductos.Location = New System.Drawing.Point(38, 250)
        Me.GroupBoxProductos.Margin = New System.Windows.Forms.Padding(0)
        Me.GroupBoxProductos.Name = "GroupBoxProductos"
        Me.GroupBoxProductos.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GroupBoxProductos.Size = New System.Drawing.Size(1058, 128)
        Me.GroupBoxProductos.TabIndex = 47
        Me.GroupBoxProductos.TabStop = False
        Me.GroupBoxProductos.Text = "Articulos"
        '
        'Bconfmodificacion
        '
        Me.Bconfmodificacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Bconfmodificacion.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Bconfmodificacion.FlatAppearance.BorderSize = 2
        Me.Bconfmodificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bconfmodificacion.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bconfmodificacion.ForeColor = System.Drawing.Color.White
        Me.Bconfmodificacion.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.plus_32
        Me.Bconfmodificacion.Location = New System.Drawing.Point(969, 56)
        Me.Bconfmodificacion.Margin = New System.Windows.Forms.Padding(5)
        Me.Bconfmodificacion.Name = "Bconfmodificacion"
        Me.Bconfmodificacion.Size = New System.Drawing.Size(65, 52)
        Me.Bconfmodificacion.TabIndex = 50
        Me.Bconfmodificacion.UseVisualStyleBackColor = False
        '
        'TBTalle
        '
        Me.TBTalle.Enabled = False
        Me.TBTalle.Location = New System.Drawing.Point(629, 71)
        Me.TBTalle.Margin = New System.Windows.Forms.Padding(5)
        Me.TBTalle.Name = "TBTalle"
        Me.TBTalle.Size = New System.Drawing.Size(133, 26)
        Me.TBTalle.TabIndex = 48
        '
        'AgregarProducto
        '
        Me.AgregarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AgregarProducto.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.AgregarProducto.FlatAppearance.BorderSize = 2
        Me.AgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AgregarProducto.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgregarProducto.ForeColor = System.Drawing.Color.White
        Me.AgregarProducto.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.plus_32
        Me.AgregarProducto.Location = New System.Drawing.Point(969, 56)
        Me.AgregarProducto.Margin = New System.Windows.Forms.Padding(5)
        Me.AgregarProducto.Name = "AgregarProducto"
        Me.AgregarProducto.Size = New System.Drawing.Size(65, 52)
        Me.AgregarProducto.TabIndex = 47
        Me.AgregarProducto.UseVisualStyleBackColor = False
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
        'TBCantidad
        '
        Me.TBCantidad.Location = New System.Drawing.Point(807, 70)
        Me.TBCantidad.Margin = New System.Windows.Forms.Padding(5)
        Me.TBCantidad.Name = "TBCantidad"
        Me.TBCantidad.Size = New System.Drawing.Size(138, 26)
        Me.TBCantidad.TabIndex = 7
        '
        'TBCodigoProducto
        '
        Me.TBCodigoProducto.Enabled = False
        Me.TBCodigoProducto.Location = New System.Drawing.Point(26, 71)
        Me.TBCodigoProducto.Margin = New System.Windows.Forms.Padding(5)
        Me.TBCodigoProducto.Name = "TBCodigoProducto"
        Me.TBCodigoProducto.Size = New System.Drawing.Size(143, 26)
        Me.TBCodigoProducto.TabIndex = 10
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
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.TextBox1.Location = New System.Drawing.Point(286, 74)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(18, 26)
        Me.TextBox1.TabIndex = 49
        Me.TextBox1.Text = "$"
        '
        'TBPrecio
        '
        Me.TBPrecio.Enabled = False
        Me.TBPrecio.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.TBPrecio.Location = New System.Drawing.Point(303, 74)
        Me.TBPrecio.Margin = New System.Windows.Forms.Padding(5)
        Me.TBPrecio.Name = "TBPrecio"
        Me.TBPrecio.Size = New System.Drawing.Size(116, 26)
        Me.TBPrecio.TabIndex = 17
        '
        'GroupBoxDatosClientes
        '
        Me.GroupBoxDatosClientes.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxDatosClientes.Controls.Add(Me.LDNI)
        Me.GroupBoxDatosClientes.Controls.Add(Me.TBDniCliente)
        Me.GroupBoxDatosClientes.Controls.Add(Me.Label2)
        Me.GroupBoxDatosClientes.Controls.Add(Me.TBTelCli)
        Me.GroupBoxDatosClientes.Controls.Add(Me.LApellido)
        Me.GroupBoxDatosClientes.Controls.Add(Me.TBApellido)
        Me.GroupBoxDatosClientes.Controls.Add(Me.BuscarCliente)
        Me.GroupBoxDatosClientes.Controls.Add(Me.TBNombreCliVenta)
        Me.GroupBoxDatosClientes.Controls.Add(Me.LNombreCli)
        Me.GroupBoxDatosClientes.Controls.Add(Me.LNombreCliente)
        Me.GroupBoxDatosClientes.Controls.Add(Me.TBIdCliVenta)
        Me.GroupBoxDatosClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBoxDatosClientes.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.GroupBoxDatosClientes.ForeColor = System.Drawing.Color.White
        Me.GroupBoxDatosClientes.Location = New System.Drawing.Point(38, 118)
        Me.GroupBoxDatosClientes.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GroupBoxDatosClientes.Name = "GroupBoxDatosClientes"
        Me.GroupBoxDatosClientes.Padding = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.GroupBoxDatosClientes.Size = New System.Drawing.Size(1058, 118)
        Me.GroupBoxDatosClientes.TabIndex = 48
        Me.GroupBoxDatosClientes.TabStop = False
        Me.GroupBoxDatosClientes.Text = "Cliente"
        '
        'LDNI
        '
        Me.LDNI.AutoSize = True
        Me.LDNI.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.LDNI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LDNI.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.LDNI.ForeColor = System.Drawing.Color.White
        Me.LDNI.Location = New System.Drawing.Point(798, 32)
        Me.LDNI.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LDNI.Name = "LDNI"
        Me.LDNI.Size = New System.Drawing.Size(35, 19)
        Me.LDNI.TabIndex = 26
        Me.LDNI.Text = "DNI"
        '
        'TBDniCliente
        '
        Me.TBDniCliente.Enabled = False
        Me.TBDniCliente.Location = New System.Drawing.Point(802, 67)
        Me.TBDniCliente.Margin = New System.Windows.Forms.Padding(5)
        Me.TBDniCliente.Name = "TBDniCliente"
        Me.TBDniCliente.Size = New System.Drawing.Size(143, 26)
        Me.TBDniCliente.TabIndex = 25
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
        'BuscarCliente
        '
        Me.BuscarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BuscarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BuscarCliente.FlatAppearance.BorderSize = 2
        Me.BuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BuscarCliente.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarCliente.ForeColor = System.Drawing.Color.White
        Me.BuscarCliente.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.search_3_32
        Me.BuscarCliente.Location = New System.Drawing.Point(192, 46)
        Me.BuscarCliente.Margin = New System.Windows.Forms.Padding(5)
        Me.BuscarCliente.Name = "BuscarCliente"
        Me.BuscarCliente.Size = New System.Drawing.Size(65, 52)
        Me.BuscarCliente.TabIndex = 20
        Me.BuscarCliente.UseVisualStyleBackColor = False
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
        Me.LNombreCliente.Size = New System.Drawing.Size(25, 19)
        Me.LNombreCliente.TabIndex = 18
        Me.LNombreCliente.Text = "ID"
        '
        'TBIdCliVenta
        '
        Me.TBIdCliVenta.Enabled = False
        Me.TBIdCliVenta.Location = New System.Drawing.Point(26, 61)
        Me.TBIdCliVenta.Margin = New System.Windows.Forms.Padding(5)
        Me.TBIdCliVenta.Name = "TBIdCliVenta"
        Me.TBIdCliVenta.Size = New System.Drawing.Size(143, 26)
        Me.TBIdCliVenta.TabIndex = 11
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
        'BEliminarProducto
        '
        Me.BEliminarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BEliminarProducto.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BEliminarProducto.FlatAppearance.BorderSize = 2
        Me.BEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEliminarProducto.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminarProducto.ForeColor = System.Drawing.Color.White
        Me.BEliminarProducto.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.trash_6_32
        Me.BEliminarProducto.Location = New System.Drawing.Point(1007, 472)
        Me.BEliminarProducto.Margin = New System.Windows.Forms.Padding(5)
        Me.BEliminarProducto.Name = "BEliminarProducto"
        Me.BEliminarProducto.Size = New System.Drawing.Size(65, 52)
        Me.BEliminarProducto.TabIndex = 49
        Me.BEliminarProducto.UseVisualStyleBackColor = False
        '
        'BModificarProducto
        '
        Me.BModificarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BModificarProducto.FlatAppearance.BorderSize = 2
        Me.BModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModificarProducto.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BModificarProducto.ForeColor = System.Drawing.Color.White
        Me.BModificarProducto.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.edit_12_32
        Me.BModificarProducto.Location = New System.Drawing.Point(1007, 410)
        Me.BModificarProducto.Margin = New System.Windows.Forms.Padding(5)
        Me.BModificarProducto.Name = "BModificarProducto"
        Me.BModificarProducto.Size = New System.Drawing.Size(65, 52)
        Me.BModificarProducto.TabIndex = 45
        Me.BModificarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BModificarProducto.UseVisualStyleBackColor = False
        '
        'dgvListaVentas
        '
        Me.dgvListaVentas.AllowUserToAddRows = False
        Me.dgvListaVentas.AllowUserToDeleteRows = False
        Me.dgvListaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListaVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListaVentas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgvListaVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column6, Me.Column5, Me.Column7})
        Me.dgvListaVentas.EnableHeadersVisualStyles = False
        Me.dgvListaVentas.Location = New System.Drawing.Point(38, 410)
        Me.dgvListaVentas.Name = "dgvListaVentas"
        Me.dgvListaVentas.ReadOnly = True
        Me.dgvListaVentas.RowHeadersWidth = 51
        Me.dgvListaVentas.RowTemplate.Height = 24
        Me.dgvListaVentas.Size = New System.Drawing.Size(944, 140)
        Me.dgvListaVentas.TabIndex = 55
        '
        'Column1
        '
        Me.Column1.HeaderText = "Codigo"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Descripcion"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Precio"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Cantidad"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Subtotal"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Talle"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Stock"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Visible = False
        '
        'ErrorProviderCantidad
        '
        Me.ErrorProviderCantidad.ContainerControl = Me
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TextBox2.Location = New System.Drawing.Point(107, 581)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(38, 30)
        Me.TextBox2.TabIndex = 50
        Me.TextBox2.Text = "$"
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'AñadirVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 656)
        Me.Controls.Add(Me.TBTotalVenta)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.dgvListaVentas)
        Me.Controls.Add(Me.TBVendedor)
        Me.Controls.Add(Me.LVendedor)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.LFecha)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.BEliminarProducto)
        Me.Controls.Add(Me.LTotalVenta)
        Me.Controls.Add(Me.BModificarProducto)
        Me.Controls.Add(Me.LTituloVentas)
        Me.Controls.Add(Me.GroupBoxProductos)
        Me.Controls.Add(Me.GroupBoxDatosClientes)
        Me.Controls.Add(Me.LNumeroFactura)
        Me.Controls.Add(Me.TBNroFactura)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AñadirVentas"
        Me.GroupBoxProductos.ResumeLayout(False)
        Me.GroupBoxProductos.PerformLayout()
        Me.GroupBoxDatosClientes.ResumeLayout(False)
        Me.GroupBoxDatosClientes.PerformLayout()
        CType(Me.dgvListaVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBVendedor As TextBox
    Friend WithEvents LVendedor As Label
    Friend WithEvents BGuardar As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents LFecha As Label
    Friend WithEvents BVolver As Button
    Friend WithEvents BEliminarProducto As Button
    Friend WithEvents LTotalVenta As Label
    Friend WithEvents TBTotalVenta As TextBox
    Friend WithEvents BModificarProducto As Button
    Friend WithEvents LTituloVentas As Label
    Friend WithEvents GroupBoxProductos As GroupBox
    Friend WithEvents LTalle As Label
    Friend WithEvents BBuscarProducto As Button
    Friend WithEvents LStock As Label
    Friend WithEvents TBStock As TextBox
    Friend WithEvents TBPrecio As TextBox
    Friend WithEvents TBCantidad As TextBox
    Friend WithEvents TBCodigoProducto As TextBox
    Friend WithEvents LCantidad As Label
    Friend WithEvents LPrecio As Label
    Friend WithEvents LProductoDescripcion As Label
    Friend WithEvents GroupBoxDatosClientes As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LApellido As Label
    Friend WithEvents BuscarCliente As Button
    Friend WithEvents LNombreCli As Label
    Friend WithEvents LNombreCliente As Label
    Friend WithEvents LNumeroFactura As Label
    Friend WithEvents TBNroFactura As TextBox
    Friend WithEvents LDNI As Label
    Friend WithEvents AgregarProducto As Button
    Public WithEvents TBTelCli As TextBox
    Public WithEvents TBApellido As TextBox
    Public WithEvents TBNombreCliVenta As TextBox
    Public WithEvents TBIdCliVenta As TextBox
    Public WithEvents TBDniCliente As TextBox
    Friend WithEvents TBTalle As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents dgvListaVentas As DataGridView
    Friend WithEvents ErrorProviderCantidad As ErrorProvider
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Bconfmodificacion As Button
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
