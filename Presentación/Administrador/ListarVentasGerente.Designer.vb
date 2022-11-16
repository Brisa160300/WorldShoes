<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListarVentasGerente
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
        Me.BVolver = New System.Windows.Forms.Button()
        Me.GroupBoxBuscarProducto = New System.Windows.Forms.GroupBox()
        Me.BFiltrar = New System.Windows.Forms.Button()
        Me.DTFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BVerDetalle = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BBuscarVenta = New System.Windows.Forms.Button()
        Me.DTFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.TabControlListaProductos = New System.Windows.Forms.TabControl()
        Me.TabPageListaProducto = New System.Windows.Forms.TabPage()
        Me.dgvListaVentas = New System.Windows.Forms.DataGridView()
        Me.GroupBoxBuscarProducto.SuspendLayout()
        Me.TabControlListaProductos.SuspendLayout()
        Me.TabPageListaProducto.SuspendLayout()
        CType(Me.dgvListaVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVolver.ForeColor = System.Drawing.Color.White
        Me.BVolver.Location = New System.Drawing.Point(978, 564)
        Me.BVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(131, 52)
        Me.BVolver.TabIndex = 29
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'GroupBoxBuscarProducto
        '
        Me.GroupBoxBuscarProducto.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxBuscarProducto.Controls.Add(Me.BFiltrar)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.DTFechaFinal)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.Label2)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.BVerDetalle)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.Label1)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.BBuscarVenta)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.DTFechaInicio)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.TBBuscar)
        Me.GroupBoxBuscarProducto.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.GroupBoxBuscarProducto.ForeColor = System.Drawing.Color.White
        Me.GroupBoxBuscarProducto.Location = New System.Drawing.Point(40, 40)
        Me.GroupBoxBuscarProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxBuscarProducto.Name = "GroupBoxBuscarProducto"
        Me.GroupBoxBuscarProducto.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxBuscarProducto.Size = New System.Drawing.Size(1069, 110)
        Me.GroupBoxBuscarProducto.TabIndex = 28
        Me.GroupBoxBuscarProducto.TabStop = False
        Me.GroupBoxBuscarProducto.Text = "Ventas"
        '
        'BFiltrar
        '
        Me.BFiltrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BFiltrar.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BFiltrar.FlatAppearance.BorderSize = 2
        Me.BFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BFiltrar.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.BFiltrar.ForeColor = System.Drawing.Color.White
        Me.BFiltrar.Location = New System.Drawing.Point(299, 43)
        Me.BFiltrar.Margin = New System.Windows.Forms.Padding(4)
        Me.BFiltrar.Name = "BFiltrar"
        Me.BFiltrar.Size = New System.Drawing.Size(86, 47)
        Me.BFiltrar.TabIndex = 34
        Me.BFiltrar.Text = "Filtrar"
        Me.BFiltrar.UseVisualStyleBackColor = False
        '
        'DTFechaFinal
        '
        Me.DTFechaFinal.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.DTFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFechaFinal.Location = New System.Drawing.Point(172, 54)
        Me.DTFechaFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.DTFechaFinal.Name = "DTFechaFinal"
        Me.DTFechaFinal.Size = New System.Drawing.Size(119, 26)
        Me.DTFechaFinal.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(168, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 19)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Fecha Fin:"
        '
        'BVerDetalle
        '
        Me.BVerDetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BVerDetalle.FlatAppearance.BorderSize = 2
        Me.BVerDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVerDetalle.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVerDetalle.ForeColor = System.Drawing.Color.White
        Me.BVerDetalle.Location = New System.Drawing.Point(900, 39)
        Me.BVerDetalle.Margin = New System.Windows.Forms.Padding(4)
        Me.BVerDetalle.Name = "BVerDetalle"
        Me.BVerDetalle.Size = New System.Drawing.Size(148, 52)
        Me.BVerDetalle.TabIndex = 27
        Me.BVerDetalle.Text = "Ver Detalle"
        Me.BVerDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BVerDetalle.UseVisualStyleBackColor = False
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
        'DTFechaInicio
        '
        Me.DTFechaInicio.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.DTFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFechaInicio.Location = New System.Drawing.Point(27, 54)
        Me.DTFechaInicio.Margin = New System.Windows.Forms.Padding(4)
        Me.DTFechaInicio.Name = "DTFechaInicio"
        Me.DTFechaInicio.Size = New System.Drawing.Size(125, 26)
        Me.DTFechaInicio.TabIndex = 30
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
        Me.TabControlListaProductos.Location = New System.Drawing.Point(44, 173)
        Me.TabControlListaProductos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlListaProductos.Name = "TabControlListaProductos"
        Me.TabControlListaProductos.SelectedIndex = 0
        Me.TabControlListaProductos.Size = New System.Drawing.Size(1065, 359)
        Me.TabControlListaProductos.TabIndex = 27
        '
        'TabPageListaProducto
        '
        Me.TabPageListaProducto.Controls.Add(Me.dgvListaVentas)
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
        'dgvListaVentas
        '
        Me.dgvListaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvListaVentas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgvListaVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListaVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListaVentas.EnableHeadersVisualStyles = False
        Me.dgvListaVentas.Location = New System.Drawing.Point(3, 2)
        Me.dgvListaVentas.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvListaVentas.Name = "dgvListaVentas"
        Me.dgvListaVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.NavajoWhite
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListaVentas.RowHeadersWidth = 51
        Me.dgvListaVentas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvListaVentas.Size = New System.Drawing.Size(1051, 323)
        Me.dgvListaVentas.TabIndex = 5
        '
        'ListarVentasGerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1149, 656)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.GroupBoxBuscarProducto)
        Me.Controls.Add(Me.TabControlListaProductos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ListarVentasGerente"
        Me.Text = "ListarVentasGerente"
        Me.GroupBoxBuscarProducto.ResumeLayout(False)
        Me.GroupBoxBuscarProducto.PerformLayout()
        Me.TabControlListaProductos.ResumeLayout(False)
        Me.TabPageListaProducto.ResumeLayout(False)
        CType(Me.dgvListaVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BVolver As Button
    Friend WithEvents GroupBoxBuscarProducto As GroupBox
    Friend WithEvents BFiltrar As Button
    Friend WithEvents DTFechaFinal As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents BVerDetalle As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BBuscarVenta As Button
    Friend WithEvents DTFechaInicio As DateTimePicker
    Friend WithEvents TBBuscar As TextBox
    Friend WithEvents TabControlListaProductos As TabControl
    Friend WithEvents TabPageListaProducto As TabPage
    Friend WithEvents dgvListaVentas As DataGridView
End Class
