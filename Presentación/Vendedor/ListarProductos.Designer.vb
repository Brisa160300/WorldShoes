<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListarProductos
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
        Me.TabControlListaProductos = New System.Windows.Forms.TabControl()
        Me.TabPageListaProducto = New System.Windows.Forms.TabPage()
        Me.dgvListaProductos = New System.Windows.Forms.DataGridView()
        Me.GroupBoxBuscarProducto = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LMarcas = New System.Windows.Forms.Label()
        Me.CBMarcas = New System.Windows.Forms.ComboBox()
        Me.CBCatProducto = New System.Windows.Forms.ComboBox()
        Me.BImprimriVentedores = New System.Windows.Forms.Button()
        Me.BBuscarProducto = New System.Windows.Forms.Button()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.TabControlListaProductos.SuspendLayout()
        Me.TabPageListaProducto.SuspendLayout()
        CType(Me.dgvListaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxBuscarProducto.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlListaProductos
        '
        Me.TabControlListaProductos.Controls.Add(Me.TabPageListaProducto)
        Me.TabControlListaProductos.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlListaProductos.Location = New System.Drawing.Point(28, 149)
        Me.TabControlListaProductos.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControlListaProductos.Name = "TabControlListaProductos"
        Me.TabControlListaProductos.SelectedIndex = 0
        Me.TabControlListaProductos.Size = New System.Drawing.Size(801, 294)
        Me.TabControlListaProductos.TabIndex = 16
        '
        'TabPageListaProducto
        '
        Me.TabPageListaProducto.Controls.Add(Me.dgvListaProductos)
        Me.TabPageListaProducto.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaProducto.ForeColor = System.Drawing.Color.White
        Me.TabPageListaProducto.Location = New System.Drawing.Point(4, 25)
        Me.TabPageListaProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPageListaProducto.Name = "TabPageListaProducto"
        Me.TabPageListaProducto.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPageListaProducto.Size = New System.Drawing.Size(793, 265)
        Me.TabPageListaProducto.TabIndex = 0
        Me.TabPageListaProducto.Text = "Lista de Producto"
        Me.TabPageListaProducto.UseVisualStyleBackColor = True
        '
        'dgvListaProductos
        '
        Me.dgvListaProductos.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvListaProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListaProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListaProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgvListaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListaProductos.ColumnHeadersHeight = 20
        Me.dgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvListaProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListaProductos.EnableHeadersVisualStyles = False
        Me.dgvListaProductos.Location = New System.Drawing.Point(2, 2)
        Me.dgvListaProductos.Name = "dgvListaProductos"
        Me.dgvListaProductos.ReadOnly = True
        Me.dgvListaProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.NavajoWhite
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListaProductos.RowHeadersWidth = 51
        Me.dgvListaProductos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvListaProductos.Size = New System.Drawing.Size(789, 261)
        Me.dgvListaProductos.TabIndex = 6
        '
        'GroupBoxBuscarProducto
        '
        Me.GroupBoxBuscarProducto.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxBuscarProducto.Controls.Add(Me.Label1)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.LMarcas)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.CBMarcas)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.CBCatProducto)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.BImprimriVentedores)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.BBuscarProducto)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.TBBuscar)
        Me.GroupBoxBuscarProducto.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.GroupBoxBuscarProducto.ForeColor = System.Drawing.Color.White
        Me.GroupBoxBuscarProducto.Location = New System.Drawing.Point(28, 41)
        Me.GroupBoxBuscarProducto.Name = "GroupBoxBuscarProducto"
        Me.GroupBoxBuscarProducto.Size = New System.Drawing.Size(801, 81)
        Me.GroupBoxBuscarProducto.TabIndex = 17
        Me.GroupBoxBuscarProducto.TabStop = False
        Me.GroupBoxBuscarProducto.Text = "Productos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(369, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Marcas:"
        '
        'LMarcas
        '
        Me.LMarcas.AutoSize = True
        Me.LMarcas.Font = New System.Drawing.Font("Britannic Bold", 11.0!)
        Me.LMarcas.ForeColor = System.Drawing.Color.White
        Me.LMarcas.Location = New System.Drawing.Point(233, 17)
        Me.LMarcas.Name = "LMarcas"
        Me.LMarcas.Size = New System.Drawing.Size(82, 16)
        Me.LMarcas.TabIndex = 36
        Me.LMarcas.Text = "Categorias:"
        '
        'CBMarcas
        '
        Me.CBMarcas.FormattingEnabled = True
        Me.CBMarcas.Location = New System.Drawing.Point(372, 35)
        Me.CBMarcas.Margin = New System.Windows.Forms.Padding(2)
        Me.CBMarcas.Name = "CBMarcas"
        Me.CBMarcas.Size = New System.Drawing.Size(121, 25)
        Me.CBMarcas.TabIndex = 29
        Me.CBMarcas.Text = "Marcas"
        '
        'CBCatProducto
        '
        Me.CBCatProducto.FormattingEnabled = True
        Me.CBCatProducto.Location = New System.Drawing.Point(236, 35)
        Me.CBCatProducto.Margin = New System.Windows.Forms.Padding(4, 2, 2, 2)
        Me.CBCatProducto.Name = "CBCatProducto"
        Me.CBCatProducto.Size = New System.Drawing.Size(121, 25)
        Me.CBCatProducto.TabIndex = 28
        Me.CBCatProducto.Text = "Categorias"
        '
        'BImprimriVentedores
        '
        Me.BImprimriVentedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BImprimriVentedores.FlatAppearance.BorderSize = 2
        Me.BImprimriVentedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BImprimriVentedores.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BImprimriVentedores.ForeColor = System.Drawing.Color.White
        Me.BImprimriVentedores.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.printer_4_32
        Me.BImprimriVentedores.Location = New System.Drawing.Point(735, 24)
        Me.BImprimriVentedores.Name = "BImprimriVentedores"
        Me.BImprimriVentedores.Size = New System.Drawing.Size(49, 41)
        Me.BImprimriVentedores.TabIndex = 26
        Me.BImprimriVentedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BImprimriVentedores.UseVisualStyleBackColor = False
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
        Me.BBuscarProducto.Location = New System.Drawing.Point(154, 30)
        Me.BBuscarProducto.Name = "BBuscarProducto"
        Me.BBuscarProducto.Size = New System.Drawing.Size(50, 35)
        Me.BBuscarProducto.TabIndex = 14
        Me.BBuscarProducto.UseVisualStyleBackColor = False
        '
        'TBBuscar
        '
        Me.TBBuscar.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBBuscar.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TBBuscar.Location = New System.Drawing.Point(17, 35)
        Me.TBBuscar.Name = "TBBuscar"
        Me.TBBuscar.Size = New System.Drawing.Size(131, 25)
        Me.TBBuscar.TabIndex = 6
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVolver.ForeColor = System.Drawing.Color.White
        Me.BVolver.Location = New System.Drawing.Point(731, 457)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(98, 42)
        Me.BVolver.TabIndex = 25
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'ListarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(862, 533)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.GroupBoxBuscarProducto)
        Me.Controls.Add(Me.TabControlListaProductos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ListarProductos"
        Me.Text = "ListarProductos"
        Me.TabControlListaProductos.ResumeLayout(False)
        Me.TabPageListaProducto.ResumeLayout(False)
        CType(Me.dgvListaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxBuscarProducto.ResumeLayout(False)
        Me.GroupBoxBuscarProducto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControlListaProductos As TabControl
    Friend WithEvents TabPageListaProducto As TabPage
    Friend WithEvents GroupBoxBuscarProducto As GroupBox
    Friend WithEvents BBuscarProducto As Button
    Friend WithEvents TBBuscar As TextBox
    Friend WithEvents BVolver As Button
    Friend WithEvents dgvListaProductos As DataGridView
    Friend WithEvents BImprimriVentedores As Button
    Friend WithEvents CBMarcas As ComboBox
    Friend WithEvents CBCatProducto As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LMarcas As Label
End Class
