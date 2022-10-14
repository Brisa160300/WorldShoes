<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AñadirProducto
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewRegistroCategorias = New System.Windows.Forms.DataGridView()
        Me.TabControlListaProductos = New System.Windows.Forms.TabControl()
        Me.TabPageListaProducto = New System.Windows.Forms.TabPage()
        Me.DataGridViewListaProductos = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Talle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxCategoria = New System.Windows.Forms.ComboBox()
        Me.BAñadirProducto = New System.Windows.Forms.Button()
        Me.ComboBoxMarca = New System.Windows.Forms.ComboBox()
        Me.ComboBoxTalle = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBNombreProducto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBPrecio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBStock = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.LMarca = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewRegistroCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlListaProductos.SuspendLayout()
        Me.TabPageListaProducto.SuspendLayout()
        CType(Me.DataGridViewListaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewRegistroCategorias
        '
        Me.DataGridViewRegistroCategorias.AllowUserToAddRows = False
        Me.DataGridViewRegistroCategorias.AllowUserToDeleteRows = False
        Me.DataGridViewRegistroCategorias.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.DataGridViewRegistroCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewRegistroCategorias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewRegistroCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewRegistroCategorias.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewRegistroCategorias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewRegistroCategorias.EnableHeadersVisualStyles = False
        Me.DataGridViewRegistroCategorias.Location = New System.Drawing.Point(3, 2)
        Me.DataGridViewRegistroCategorias.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewRegistroCategorias.Name = "DataGridViewRegistroCategorias"
        Me.DataGridViewRegistroCategorias.ReadOnly = True
        Me.DataGridViewRegistroCategorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewRegistroCategorias.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewRegistroCategorias.RowHeadersWidth = 51
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewRegistroCategorias.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewRegistroCategorias.Size = New System.Drawing.Size(663, 485)
        Me.DataGridViewRegistroCategorias.TabIndex = 2
        '
        'TabControlListaProductos
        '
        Me.TabControlListaProductos.Controls.Add(Me.TabPageListaProducto)
        Me.TabControlListaProductos.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlListaProductos.Location = New System.Drawing.Point(424, 76)
        Me.TabControlListaProductos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlListaProductos.Name = "TabControlListaProductos"
        Me.TabControlListaProductos.SelectedIndex = 0
        Me.TabControlListaProductos.Size = New System.Drawing.Size(677, 521)
        Me.TabControlListaProductos.TabIndex = 14
        '
        'TabPageListaProducto
        '
        Me.TabPageListaProducto.Controls.Add(Me.DataGridViewListaProductos)
        Me.TabPageListaProducto.Controls.Add(Me.DataGridViewRegistroCategorias)
        Me.TabPageListaProducto.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaProducto.ForeColor = System.Drawing.Color.White
        Me.TabPageListaProducto.Location = New System.Drawing.Point(4, 28)
        Me.TabPageListaProducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaProducto.Name = "TabPageListaProducto"
        Me.TabPageListaProducto.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaProducto.Size = New System.Drawing.Size(669, 489)
        Me.TabPageListaProducto.TabIndex = 0
        Me.TabPageListaProducto.Text = "Lista de Producto"
        Me.TabPageListaProducto.UseVisualStyleBackColor = True
        '
        'DataGridViewListaProductos
        '
        Me.DataGridViewListaProductos.AllowUserToDeleteRows = False
        Me.DataGridViewListaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewListaProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewListaProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.DataGridViewListaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewListaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewListaProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewListaProductos.ColumnHeadersHeight = 20
        Me.DataGridViewListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridViewListaProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3, Me.Categoria, Me.Stock, Me.Column1, Me.Column4, Me.Talle})
        Me.DataGridViewListaProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewListaProductos.EnableHeadersVisualStyles = False
        Me.DataGridViewListaProductos.Location = New System.Drawing.Point(3, 2)
        Me.DataGridViewListaProductos.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewListaProductos.Name = "DataGridViewListaProductos"
        Me.DataGridViewListaProductos.ReadOnly = True
        Me.DataGridViewListaProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.NavajoWhite
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewListaProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewListaProductos.RowHeadersWidth = 51
        Me.DataGridViewListaProductos.Size = New System.Drawing.Size(663, 485)
        Me.DataGridViewListaProductos.TabIndex = 7
        '
        'Column2
        '
        Me.Column2.HeaderText = "ID"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Producto"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Categoria
        '
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.MinimumWidth = 6
        Me.Categoria.Name = "Categoria"
        Me.Categoria.ReadOnly = True
        '
        'Stock
        '
        Me.Stock.HeaderText = "Stock"
        Me.Stock.MinimumWidth = 6
        Me.Stock.Name = "Stock"
        Me.Stock.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "Marca"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Precio"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Talle
        '
        Me.Talle.HeaderText = "Talle"
        Me.Talle.MinimumWidth = 6
        Me.Talle.Name = "Talle"
        Me.Talle.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(49, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 33)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Añadir Producto: "
        '
        'ComboBoxCategoria
        '
        Me.ComboBoxCategoria.FormattingEnabled = True
        Me.ComboBoxCategoria.Location = New System.Drawing.Point(137, 105)
        Me.ComboBoxCategoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxCategoria.Name = "ComboBoxCategoria"
        Me.ComboBoxCategoria.Size = New System.Drawing.Size(175, 24)
        Me.ComboBoxCategoria.TabIndex = 15
        '
        'BAñadirProducto
        '
        Me.BAñadirProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BAñadirProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAñadirProducto.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BAñadirProducto.ForeColor = System.Drawing.Color.White
        Me.BAñadirProducto.Location = New System.Drawing.Point(192, 397)
        Me.BAñadirProducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BAñadirProducto.Name = "BAñadirProducto"
        Me.BAñadirProducto.Size = New System.Drawing.Size(120, 50)
        Me.BAñadirProducto.TabIndex = 2
        Me.BAñadirProducto.Text = "Añadir"
        Me.BAñadirProducto.UseVisualStyleBackColor = False
        '
        'ComboBoxMarca
        '
        Me.ComboBoxMarca.FormattingEnabled = True
        Me.ComboBoxMarca.Location = New System.Drawing.Point(137, 303)
        Me.ComboBoxMarca.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxMarca.Name = "ComboBoxMarca"
        Me.ComboBoxMarca.Size = New System.Drawing.Size(175, 24)
        Me.ComboBoxMarca.TabIndex = 14
        '
        'ComboBoxTalle
        '
        Me.ComboBoxTalle.FormattingEnabled = True
        Me.ComboBoxTalle.Location = New System.Drawing.Point(137, 255)
        Me.ComboBoxTalle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxTalle.Name = "ComboBoxTalle"
        Me.ComboBoxTalle.Size = New System.Drawing.Size(175, 24)
        Me.ComboBoxTalle.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(27, 257)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 22)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Talle: "
        '
        'TBNombreProducto
        '
        Me.TBNombreProducto.Location = New System.Drawing.Point(137, 57)
        Me.TBNombreProducto.Margin = New System.Windows.Forms.Padding(5)
        Me.TBNombreProducto.Name = "TBNombreProducto"
        Me.TBNombreProducto.Size = New System.Drawing.Size(175, 22)
        Me.TBNombreProducto.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(26, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(27, 207)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 22)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Precio: "
        '
        'TBPrecio
        '
        Me.TBPrecio.Location = New System.Drawing.Point(137, 207)
        Me.TBPrecio.Margin = New System.Windows.Forms.Padding(5)
        Me.TBPrecio.Name = "TBPrecio"
        Me.TBPrecio.Size = New System.Drawing.Size(175, 22)
        Me.TBPrecio.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(26, 156)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 22)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Stock:"
        '
        'TBStock
        '
        Me.TBStock.Location = New System.Drawing.Point(137, 156)
        Me.TBStock.Margin = New System.Windows.Forms.Padding(5)
        Me.TBStock.Name = "TBStock"
        Me.TBStock.Size = New System.Drawing.Size(175, 22)
        Me.TBStock.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel2.Controls.Add(Me.ComboBoxCategoria)
        Me.Panel2.Controls.Add(Me.BAñadirProducto)
        Me.Panel2.Controls.Add(Me.BVolver)
        Me.Panel2.Controls.Add(Me.ComboBoxMarca)
        Me.Panel2.Controls.Add(Me.LMarca)
        Me.Panel2.Controls.Add(Me.ComboBoxTalle)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.TBNombreProducto)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.TBPrecio)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TBStock)
        Me.Panel2.Location = New System.Drawing.Point(55, 127)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(339, 470)
        Me.Panel2.TabIndex = 13
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVolver.ForeColor = System.Drawing.Color.White
        Me.BVolver.Location = New System.Drawing.Point(33, 397)
        Me.BVolver.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(122, 50)
        Me.BVolver.TabIndex = 3
        Me.BVolver.Text = "Volver"
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'LMarca
        '
        Me.LMarca.AutoSize = True
        Me.LMarca.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LMarca.ForeColor = System.Drawing.Color.White
        Me.LMarca.Location = New System.Drawing.Point(29, 305)
        Me.LMarca.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LMarca.Name = "LMarca"
        Me.LMarca.Size = New System.Drawing.Size(78, 22)
        Me.LMarca.TabIndex = 13
        Me.LMarca.Text = "Marca: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(26, 105)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 22)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Categoría: "
        '
        'AñadirProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1149, 656)
        Me.Controls.Add(Me.TabControlListaProductos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AñadirProducto"
        Me.Text = "AñadirP"
        CType(Me.DataGridViewRegistroCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlListaProductos.ResumeLayout(False)
        Me.TabPageListaProducto.ResumeLayout(False)
        CType(Me.DataGridViewListaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewRegistroCategorias As DataGridView
    Friend WithEvents TabControlListaProductos As TabControl
    Friend WithEvents TabPageListaProducto As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxCategoria As ComboBox
    Friend WithEvents BAñadirProducto As Button
    Friend WithEvents ComboBoxMarca As ComboBox
    Friend WithEvents ComboBoxTalle As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TBNombreProducto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TBPrecio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBStock As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LMarca As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BVolver As Button
    Friend WithEvents DataGridViewListaProductos As DataGridView
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Categoria As DataGridViewTextBoxColumn
    Friend WithEvents Stock As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Talle As DataGridViewTextBoxColumn
End Class
