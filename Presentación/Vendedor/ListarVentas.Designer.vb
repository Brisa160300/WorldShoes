<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListarVentas
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
        Me.GroupBoxBuscarProducto = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BBuscarVenta = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.TabControlListaProductos = New System.Windows.Forms.TabControl()
        Me.TabPageListaProducto = New System.Windows.Forms.TabPage()
        Me.DataGridViewListaVentas = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.GroupBoxBuscarProducto.SuspendLayout()
        Me.TabControlListaProductos.SuspendLayout()
        Me.TabPageListaProducto.SuspendLayout()
        CType(Me.DataGridViewListaVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxBuscarProducto
        '
        Me.GroupBoxBuscarProducto.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxBuscarProducto.Controls.Add(Me.DateTimePicker2)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.Label2)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.Button1)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.Label1)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.BBuscarVenta)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.DateTimePicker1)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.TBBuscar)
        Me.GroupBoxBuscarProducto.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.GroupBoxBuscarProducto.ForeColor = System.Drawing.Color.White
        Me.GroupBoxBuscarProducto.Location = New System.Drawing.Point(37, 50)
        Me.GroupBoxBuscarProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxBuscarProducto.Name = "GroupBoxBuscarProducto"
        Me.GroupBoxBuscarProducto.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxBuscarProducto.Size = New System.Drawing.Size(1069, 110)
        Me.GroupBoxBuscarProducto.TabIndex = 19
        Me.GroupBoxBuscarProducto.TabStop = False
        Me.GroupBoxBuscarProducto.Text = "Ventas"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(197, 54)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(119, 26)
        Me.DateTimePicker2.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(193, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 19)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Fecha Fin:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(900, 39)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 52)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Ver Detalle"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(23, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 19)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Fecha Inicio:"
        '
        'BBuscarVenta
        '
        Me.BBuscarVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BBuscarVenta.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BBuscarVenta.FlatAppearance.BorderSize = 2
        Me.BBuscarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBuscarVenta.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscarVenta.ForeColor = System.Drawing.Color.White
        Me.BBuscarVenta.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.search_3_32
        Me.BBuscarVenta.Location = New System.Drawing.Point(750, 44)
        Me.BBuscarVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.BBuscarVenta.Name = "BBuscarVenta"
        Me.BBuscarVenta.Size = New System.Drawing.Size(67, 47)
        Me.BBuscarVenta.TabIndex = 14
        Me.BBuscarVenta.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(27, 54)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(125, 26)
        Me.DateTimePicker1.TabIndex = 30
        '
        'TBBuscar
        '
        Me.TBBuscar.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBBuscar.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TBBuscar.Location = New System.Drawing.Point(569, 52)
        Me.TBBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.TBBuscar.Name = "TBBuscar"
        Me.TBBuscar.Size = New System.Drawing.Size(173, 32)
        Me.TBBuscar.TabIndex = 6
        '
        'TabControlListaProductos
        '
        Me.TabControlListaProductos.Controls.Add(Me.TabPageListaProducto)
        Me.TabControlListaProductos.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlListaProductos.Location = New System.Drawing.Point(41, 183)
        Me.TabControlListaProductos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlListaProductos.Name = "TabControlListaProductos"
        Me.TabControlListaProductos.SelectedIndex = 0
        Me.TabControlListaProductos.Size = New System.Drawing.Size(1065, 359)
        Me.TabControlListaProductos.TabIndex = 18
        '
        'TabPageListaProducto
        '
        Me.TabPageListaProducto.Controls.Add(Me.DataGridViewListaVentas)
        Me.TabPageListaProducto.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaProducto.ForeColor = System.Drawing.Color.White
        Me.TabPageListaProducto.Location = New System.Drawing.Point(4, 28)
        Me.TabPageListaProducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaProducto.Name = "TabPageListaProducto"
        Me.TabPageListaProducto.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaProducto.Size = New System.Drawing.Size(1057, 327)
        Me.TabPageListaProducto.TabIndex = 0
        Me.TabPageListaProducto.Text = "Lista de Ventas"
        Me.TabPageListaProducto.UseVisualStyleBackColor = True
        '
        'DataGridViewListaVentas
        '
        Me.DataGridViewListaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewListaVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewListaVentas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.DataGridViewListaVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewListaVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewListaVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewListaVentas.ColumnHeadersHeight = 20
        Me.DataGridViewListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridViewListaVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column5, Me.Column3, Me.Column6})
        Me.DataGridViewListaVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewListaVentas.EnableHeadersVisualStyles = False
        Me.DataGridViewListaVentas.Location = New System.Drawing.Point(3, 2)
        Me.DataGridViewListaVentas.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewListaVentas.Name = "DataGridViewListaVentas"
        Me.DataGridViewListaVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.NavajoWhite
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewListaVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewListaVentas.RowHeadersWidth = 51
        Me.DataGridViewListaVentas.Size = New System.Drawing.Size(1051, 323)
        Me.DataGridViewListaVentas.TabIndex = 5
        '
        'Column1
        '
        Me.Column1.HeaderText = "N° Factura"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Fecha"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Cliente"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Cantidad"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Total"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVolver.ForeColor = System.Drawing.Color.White
        Me.BVolver.Location = New System.Drawing.Point(975, 574)
        Me.BVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(131, 52)
        Me.BVolver.TabIndex = 26
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'ListarVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1149, 656)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.GroupBoxBuscarProducto)
        Me.Controls.Add(Me.TabControlListaProductos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ListarVentas"
        Me.Text = "ListarVentas"
        Me.GroupBoxBuscarProducto.ResumeLayout(False)
        Me.GroupBoxBuscarProducto.PerformLayout()
        Me.TabControlListaProductos.ResumeLayout(False)
        Me.TabPageListaProducto.ResumeLayout(False)
        CType(Me.DataGridViewListaVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxBuscarProducto As GroupBox
    Friend WithEvents BBuscarVenta As Button
    Friend WithEvents TBBuscar As TextBox
    Friend WithEvents TabControlListaProductos As TabControl
    Friend WithEvents TabPageListaProducto As TabPage
    Friend WithEvents DataGridViewListaVentas As DataGridView
    Friend WithEvents BVolver As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
