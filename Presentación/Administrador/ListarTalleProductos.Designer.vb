<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListarTalleProductos
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
        Me.BVolver = New System.Windows.Forms.Button()
        Me.GroupBoxGestionProductos = New System.Windows.Forms.GroupBox()
        Me.LCatPro = New System.Windows.Forms.Label()
        Me.LMarcas = New System.Windows.Forms.Label()
        Me.CBMarca = New System.Windows.Forms.ComboBox()
        Me.CBCateg = New System.Windows.Forms.ComboBox()
        Me.BEliminarProducto = New System.Windows.Forms.Button()
        Me.BModificarProducto = New System.Windows.Forms.Button()
        Me.BBuscarProducto = New System.Windows.Forms.Button()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.BAltaProducto = New System.Windows.Forms.Button()
        Me.TabListaCategorias = New System.Windows.Forms.TabControl()
        Me.TabPageListaTalle = New System.Windows.Forms.TabPage()
        Me.dgvDetalleProductos = New System.Windows.Forms.DataGridView()
        Me.GroupBoxGestionProductos.SuspendLayout()
        Me.TabListaCategorias.SuspendLayout()
        Me.TabPageListaTalle.SuspendLayout()
        CType(Me.dgvDetalleProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVolver.ForeColor = System.Drawing.Color.White
        Me.BVolver.Location = New System.Drawing.Point(967, 567)
        Me.BVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(131, 50)
        Me.BVolver.TabIndex = 25
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'GroupBoxGestionProductos
        '
        Me.GroupBoxGestionProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBoxGestionProductos.Controls.Add(Me.LCatPro)
        Me.GroupBoxGestionProductos.Controls.Add(Me.LMarcas)
        Me.GroupBoxGestionProductos.Controls.Add(Me.CBMarca)
        Me.GroupBoxGestionProductos.Controls.Add(Me.CBCateg)
        Me.GroupBoxGestionProductos.Controls.Add(Me.BEliminarProducto)
        Me.GroupBoxGestionProductos.Controls.Add(Me.BModificarProducto)
        Me.GroupBoxGestionProductos.Controls.Add(Me.BBuscarProducto)
        Me.GroupBoxGestionProductos.Controls.Add(Me.TBBuscar)
        Me.GroupBoxGestionProductos.Controls.Add(Me.BAltaProducto)
        Me.GroupBoxGestionProductos.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.GroupBoxGestionProductos.ForeColor = System.Drawing.Color.White
        Me.GroupBoxGestionProductos.Location = New System.Drawing.Point(47, 39)
        Me.GroupBoxGestionProductos.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxGestionProductos.Name = "GroupBoxGestionProductos"
        Me.GroupBoxGestionProductos.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxGestionProductos.Size = New System.Drawing.Size(1051, 117)
        Me.GroupBoxGestionProductos.TabIndex = 24
        Me.GroupBoxGestionProductos.TabStop = False
        Me.GroupBoxGestionProductos.Text = "Gestión de Productos"
        '
        'LCatPro
        '
        Me.LCatPro.AutoSize = True
        Me.LCatPro.Font = New System.Drawing.Font("Britannic Bold", 11.0!)
        Me.LCatPro.ForeColor = System.Drawing.Color.White
        Me.LCatPro.Location = New System.Drawing.Point(320, 30)
        Me.LCatPro.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LCatPro.Name = "LCatPro"
        Me.LCatPro.Size = New System.Drawing.Size(98, 21)
        Me.LCatPro.TabIndex = 37
        Me.LCatPro.Text = "Categorias"
        '
        'LMarcas
        '
        Me.LMarcas.AutoSize = True
        Me.LMarcas.Font = New System.Drawing.Font("Britannic Bold", 11.0!)
        Me.LMarcas.ForeColor = System.Drawing.Color.White
        Me.LMarcas.Location = New System.Drawing.Point(501, 30)
        Me.LMarcas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LMarcas.Name = "LMarcas"
        Me.LMarcas.Size = New System.Drawing.Size(61, 21)
        Me.LMarcas.TabIndex = 36
        Me.LMarcas.Text = "Marca"
        '
        'CBMarca
        '
        Me.CBMarca.FormattingEnabled = True
        Me.CBMarca.Location = New System.Drawing.Point(507, 53)
        Me.CBMarca.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBMarca.Name = "CBMarca"
        Me.CBMarca.Size = New System.Drawing.Size(160, 30)
        Me.CBMarca.TabIndex = 31
        Me.CBMarca.Text = "Marcas"
        '
        'CBCateg
        '
        Me.CBCateg.FormattingEnabled = True
        Me.CBCateg.Location = New System.Drawing.Point(324, 53)
        Me.CBCateg.Margin = New System.Windows.Forms.Padding(5, 2, 3, 2)
        Me.CBCateg.Name = "CBCateg"
        Me.CBCateg.Size = New System.Drawing.Size(160, 30)
        Me.CBCateg.TabIndex = 30
        Me.CBCateg.Text = "Categorias"
        '
        'BEliminarProducto
        '
        Me.BEliminarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BEliminarProducto.FlatAppearance.BorderSize = 2
        Me.BEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEliminarProducto.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminarProducto.ForeColor = System.Drawing.Color.White
        Me.BEliminarProducto.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.trash_6_32
        Me.BEliminarProducto.Location = New System.Drawing.Point(965, 33)
        Me.BEliminarProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.BEliminarProducto.Name = "BEliminarProducto"
        Me.BEliminarProducto.Size = New System.Drawing.Size(65, 50)
        Me.BEliminarProducto.TabIndex = 12
        Me.BEliminarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BEliminarProducto.UseVisualStyleBackColor = False
        '
        'BModificarProducto
        '
        Me.BModificarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BModificarProducto.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BModificarProducto.FlatAppearance.BorderSize = 2
        Me.BModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModificarProducto.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BModificarProducto.ForeColor = System.Drawing.Color.White
        Me.BModificarProducto.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.edit_12_32
        Me.BModificarProducto.Location = New System.Drawing.Point(893, 33)
        Me.BModificarProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.BModificarProducto.Name = "BModificarProducto"
        Me.BModificarProducto.Size = New System.Drawing.Size(65, 50)
        Me.BModificarProducto.TabIndex = 13
        Me.BModificarProducto.UseVisualStyleBackColor = False
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
        Me.BBuscarProducto.Location = New System.Drawing.Point(208, 31)
        Me.BBuscarProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.BBuscarProducto.Name = "BBuscarProducto"
        Me.BBuscarProducto.Size = New System.Drawing.Size(65, 50)
        Me.BBuscarProducto.TabIndex = 14
        Me.BBuscarProducto.UseVisualStyleBackColor = False
        '
        'TBBuscar
        '
        Me.TBBuscar.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBBuscar.Location = New System.Drawing.Point(27, 43)
        Me.TBBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.TBBuscar.Name = "TBBuscar"
        Me.TBBuscar.Size = New System.Drawing.Size(173, 30)
        Me.TBBuscar.TabIndex = 6
        '
        'BAltaProducto
        '
        Me.BAltaProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BAltaProducto.FlatAppearance.BorderSize = 2
        Me.BAltaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAltaProducto.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAltaProducto.ForeColor = System.Drawing.Color.White
        Me.BAltaProducto.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.plus_32
        Me.BAltaProducto.Location = New System.Drawing.Point(965, 33)
        Me.BAltaProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.BAltaProducto.Name = "BAltaProducto"
        Me.BAltaProducto.Size = New System.Drawing.Size(65, 50)
        Me.BAltaProducto.TabIndex = 23
        Me.BAltaProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BAltaProducto.UseVisualStyleBackColor = False
        '
        'TabListaCategorias
        '
        Me.TabListaCategorias.Controls.Add(Me.TabPageListaTalle)
        Me.TabListaCategorias.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabListaCategorias.Location = New System.Drawing.Point(47, 198)
        Me.TabListaCategorias.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabListaCategorias.Name = "TabListaCategorias"
        Me.TabListaCategorias.SelectedIndex = 0
        Me.TabListaCategorias.Size = New System.Drawing.Size(1055, 353)
        Me.TabListaCategorias.TabIndex = 23
        '
        'TabPageListaTalle
        '
        Me.TabPageListaTalle.Controls.Add(Me.dgvDetalleProductos)
        Me.TabPageListaTalle.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaTalle.ForeColor = System.Drawing.Color.White
        Me.TabPageListaTalle.Location = New System.Drawing.Point(4, 28)
        Me.TabPageListaTalle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaTalle.Name = "TabPageListaTalle"
        Me.TabPageListaTalle.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaTalle.Size = New System.Drawing.Size(1047, 321)
        Me.TabPageListaTalle.TabIndex = 0
        Me.TabPageListaTalle.Text = "Lista de Productos"
        Me.TabPageListaTalle.UseVisualStyleBackColor = True
        '
        'dgvDetalleProductos
        '
        Me.dgvDetalleProductos.AllowUserToDeleteRows = False
        Me.dgvDetalleProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetalleProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvDetalleProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgvDetalleProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDetalleProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalleProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDetalleProductos.ColumnHeadersHeight = 20
        Me.dgvDetalleProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvDetalleProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDetalleProductos.EnableHeadersVisualStyles = False
        Me.dgvDetalleProductos.Location = New System.Drawing.Point(3, 2)
        Me.dgvDetalleProductos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvDetalleProductos.Name = "dgvDetalleProductos"
        Me.dgvDetalleProductos.ReadOnly = True
        Me.dgvDetalleProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.NavajoWhite
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalleProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvDetalleProductos.RowHeadersWidth = 51
        Me.dgvDetalleProductos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvDetalleProductos.Size = New System.Drawing.Size(1041, 317)
        Me.dgvDetalleProductos.TabIndex = 8
        '
        'ListarTalleProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1149, 656)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.GroupBoxGestionProductos)
        Me.Controls.Add(Me.TabListaCategorias)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ListarTalleProductos"
        Me.Text = "ListarTalleProductos"
        Me.GroupBoxGestionProductos.ResumeLayout(False)
        Me.GroupBoxGestionProductos.PerformLayout()
        Me.TabListaCategorias.ResumeLayout(False)
        Me.TabPageListaTalle.ResumeLayout(False)
        CType(Me.dgvDetalleProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BVolver As Button
    Friend WithEvents GroupBoxGestionProductos As GroupBox
    Friend WithEvents LCatPro As Label
    Friend WithEvents LMarcas As Label
    Friend WithEvents CBMarca As ComboBox
    Friend WithEvents CBCateg As ComboBox
    Friend WithEvents BEliminarProducto As Button
    Friend WithEvents BModificarProducto As Button
    Friend WithEvents BBuscarProducto As Button
    Friend WithEvents TBBuscar As TextBox
    Friend WithEvents BAltaProducto As Button
    Friend WithEvents TabListaCategorias As TabControl
    Friend WithEvents TabPageListaTalle As TabPage
    Friend WithEvents dgvDetalleProductos As DataGridView
End Class
