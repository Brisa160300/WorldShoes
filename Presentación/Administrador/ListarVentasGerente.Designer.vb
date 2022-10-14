<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListarVentasGerente
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBoxBuscarProducto = New System.Windows.Forms.GroupBox()
        Me.TabControlListaProductos = New System.Windows.Forms.TabControl()
        Me.TabPageListaProducto = New System.Windows.Forms.TabPage()
        Me.DataGridViewListaVentas = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BVerDetalle = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.BImprimirVentas = New System.Windows.Forms.Button()
        Me.BBuscarVenta = New System.Windows.Forms.Button()
        Me.GroupBoxBuscarProducto.SuspendLayout()
        Me.TabControlListaProductos.SuspendLayout()
        Me.TabPageListaProducto.SuspendLayout()
        CType(Me.DataGridViewListaVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxBuscarProducto
        '
        Me.GroupBoxBuscarProducto.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxBuscarProducto.Controls.Add(Me.DateTimePicker2)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.Label2)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.BImprimirVentas)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.BVerDetalle)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.Label1)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.BBuscarVenta)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.DateTimePicker1)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.TBBuscar)
        Me.GroupBoxBuscarProducto.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.GroupBoxBuscarProducto.ForeColor = System.Drawing.Color.White
        Me.GroupBoxBuscarProducto.Location = New System.Drawing.Point(38, 32)
        Me.GroupBoxBuscarProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxBuscarProducto.Name = "GroupBoxBuscarProducto"
        Me.GroupBoxBuscarProducto.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxBuscarProducto.Size = New System.Drawing.Size(1068, 119)
        Me.GroupBoxBuscarProducto.TabIndex = 21
        Me.GroupBoxBuscarProducto.TabStop = False
        Me.GroupBoxBuscarProducto.Text = "Ventas"
        '
        'TabControlListaProductos
        '
        Me.TabControlListaProductos.Controls.Add(Me.TabPageListaProducto)
        Me.TabControlListaProductos.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlListaProductos.Location = New System.Drawing.Point(42, 184)
        Me.TabControlListaProductos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlListaProductos.Name = "TabControlListaProductos"
        Me.TabControlListaProductos.SelectedIndex = 0
        Me.TabControlListaProductos.Size = New System.Drawing.Size(1068, 422)
        Me.TabControlListaProductos.TabIndex = 20
        '
        'TabPageListaProducto
        '
        Me.TabPageListaProducto.Controls.Add(Me.DataGridView1)
        Me.TabPageListaProducto.Controls.Add(Me.DataGridViewListaVentas)
        Me.TabPageListaProducto.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaProducto.ForeColor = System.Drawing.Color.White
        Me.TabPageListaProducto.Location = New System.Drawing.Point(4, 28)
        Me.TabPageListaProducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaProducto.Name = "TabPageListaProducto"
        Me.TabPageListaProducto.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaProducto.Size = New System.Drawing.Size(1060, 390)
        Me.TabPageListaProducto.TabIndex = 0
        Me.TabPageListaProducto.Text = "Lista de Ventas"
        Me.TabPageListaProducto.UseVisualStyleBackColor = True
        '
        'DataGridViewListaVentas
        '
        Me.DataGridViewListaVentas.AllowUserToAddRows = False
        Me.DataGridViewListaVentas.AllowUserToDeleteRows = False
        Me.DataGridViewListaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewListaVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewListaVentas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.DataGridViewListaVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewListaVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewListaVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewListaVentas.ColumnHeadersHeight = 20
        Me.DataGridViewListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridViewListaVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewListaVentas.EnableHeadersVisualStyles = False
        Me.DataGridViewListaVentas.Location = New System.Drawing.Point(3, 2)
        Me.DataGridViewListaVentas.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewListaVentas.Name = "DataGridViewListaVentas"
        Me.DataGridViewListaVentas.ReadOnly = True
        Me.DataGridViewListaVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewListaVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewListaVentas.RowHeadersWidth = 51
        Me.DataGridViewListaVentas.Size = New System.Drawing.Size(1054, 386)
        Me.DataGridViewListaVentas.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeight = 20
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column5, Me.Column3, Me.Column6})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(3, 2)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.NavajoWhite
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.Size = New System.Drawing.Size(1054, 386)
        Me.DataGridView1.TabIndex = 6
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
        'DateTimePicker2
        '
        Me.DateTimePicker2.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(185, 60)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(119, 26)
        Me.DateTimePicker2.TabIndex = 40
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(181, 37)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 19)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Fecha Fin:"
        '
        'BVerDetalle
        '
        Me.BVerDetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BVerDetalle.FlatAppearance.BorderSize = 2
        Me.BVerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVerDetalle.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVerDetalle.ForeColor = System.Drawing.Color.White
        Me.BVerDetalle.Location = New System.Drawing.Point(816, 40)
        Me.BVerDetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.BVerDetalle.Name = "BVerDetalle"
        Me.BVerDetalle.Size = New System.Drawing.Size(148, 52)
        Me.BVerDetalle.TabIndex = 36
        Me.BVerDetalle.Text = "Ver Detalle"
        Me.BVerDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BVerDetalle.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(11, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 19)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Fecha Inicio:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(15, 60)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(125, 26)
        Me.DateTimePicker1.TabIndex = 37
        '
        'TBBuscar
        '
        Me.TBBuscar.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBBuscar.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TBBuscar.Location = New System.Drawing.Point(482, 54)
        Me.TBBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.TBBuscar.Name = "TBBuscar"
        Me.TBBuscar.Size = New System.Drawing.Size(227, 32)
        Me.TBBuscar.TabIndex = 34
        '
        'BImprimirVentas
        '
        Me.BImprimirVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BImprimirVentas.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BImprimirVentas.FlatAppearance.BorderSize = 2
        Me.BImprimirVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BImprimirVentas.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BImprimirVentas.ForeColor = System.Drawing.Color.White
        Me.BImprimirVentas.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.printer_4_32
        Me.BImprimirVentas.Location = New System.Drawing.Point(986, 40)
        Me.BImprimirVentas.Margin = New System.Windows.Forms.Padding(4)
        Me.BImprimirVentas.Name = "BImprimirVentas"
        Me.BImprimirVentas.Size = New System.Drawing.Size(65, 52)
        Me.BImprimirVentas.TabIndex = 15
        Me.BImprimirVentas.UseVisualStyleBackColor = False
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
        Me.BBuscarVenta.Location = New System.Drawing.Point(728, 43)
        Me.BBuscarVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.BBuscarVenta.Name = "BBuscarVenta"
        Me.BBuscarVenta.Size = New System.Drawing.Size(67, 47)
        Me.BBuscarVenta.TabIndex = 35
        Me.BBuscarVenta.UseVisualStyleBackColor = False
        '
        'ListarVentasGerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1149, 656)
        Me.Controls.Add(Me.GroupBoxBuscarProducto)
        Me.Controls.Add(Me.TabControlListaProductos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ListarVentasGerente"
        Me.Text = "ListarVentasGerente"
        Me.GroupBoxBuscarProducto.ResumeLayout(False)
        Me.GroupBoxBuscarProducto.PerformLayout()
        Me.TabControlListaProductos.ResumeLayout(False)
        Me.TabPageListaProducto.ResumeLayout(False)
        CType(Me.DataGridViewListaVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxBuscarProducto As GroupBox
    Friend WithEvents BImprimirVentas As Button
    Friend WithEvents TabControlListaProductos As TabControl
    Friend WithEvents TabPageListaProducto As TabPage
    Friend WithEvents DataGridViewListaVentas As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents BVerDetalle As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BBuscarVenta As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TBBuscar As TextBox
End Class
