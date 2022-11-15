<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionarProductos
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabListaCategorias = New System.Windows.Forms.TabControl()
        Me.TabPageListaTalle = New System.Windows.Forms.TabPage()
        Me.dgvListaProductos = New System.Windows.Forms.DataGridView()
        Me.GroupBoxGestionProductos = New System.Windows.Forms.GroupBox()
        Me.LCatPro = New System.Windows.Forms.Label()
        Me.LMarcas = New System.Windows.Forms.Label()
        Me.CBMarca = New System.Windows.Forms.ComboBox()
        Me.CBCateg = New System.Windows.Forms.ComboBox()
        Me.BEliminarProducto = New System.Windows.Forms.Button()
        Me.BModificarProducto = New System.Windows.Forms.Button()
        Me.BBuscarProducto = New System.Windows.Forms.Button()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.BAltaProducto = New System.Windows.Forms.Button()
        Me.TabListaCategorias.SuspendLayout()
        Me.TabPageListaTalle.SuspendLayout()
        CType(Me.dgvListaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxGestionProductos.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabListaCategorias
        '
        Me.TabListaCategorias.Controls.Add(Me.TabPageListaTalle)
        Me.TabListaCategorias.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabListaCategorias.Location = New System.Drawing.Point(22, 170)
        Me.TabListaCategorias.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabListaCategorias.Name = "TabListaCategorias"
        Me.TabListaCategorias.SelectedIndex = 0
        Me.TabListaCategorias.Size = New System.Drawing.Size(791, 287)
        Me.TabListaCategorias.TabIndex = 20
        '
        'TabPageListaTalle
        '
        Me.TabPageListaTalle.Controls.Add(Me.dgvListaProductos)
        Me.TabPageListaTalle.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaTalle.ForeColor = System.Drawing.Color.White
        Me.TabPageListaTalle.Location = New System.Drawing.Point(4, 25)
        Me.TabPageListaTalle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPageListaTalle.Name = "TabPageListaTalle"
        Me.TabPageListaTalle.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPageListaTalle.Size = New System.Drawing.Size(783, 258)
        Me.TabPageListaTalle.TabIndex = 0
        Me.TabPageListaTalle.Text = "Lista de Productos"
        Me.TabPageListaTalle.UseVisualStyleBackColor = True
        '
        'dgvListaProductos
        '
        Me.dgvListaProductos.AllowUserToDeleteRows = False
        Me.dgvListaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListaProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListaProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgvListaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvListaProductos.ColumnHeadersHeight = 20
        Me.dgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvListaProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListaProductos.EnableHeadersVisualStyles = False
        Me.dgvListaProductos.Location = New System.Drawing.Point(2, 2)
        Me.dgvListaProductos.Name = "dgvListaProductos"
        Me.dgvListaProductos.ReadOnly = True
        Me.dgvListaProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.NavajoWhite
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvListaProductos.RowHeadersWidth = 51
        Me.dgvListaProductos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvListaProductos.Size = New System.Drawing.Size(779, 254)
        Me.dgvListaProductos.TabIndex = 8
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
        Me.GroupBoxGestionProductos.Location = New System.Drawing.Point(22, 41)
        Me.GroupBoxGestionProductos.Name = "GroupBoxGestionProductos"
        Me.GroupBoxGestionProductos.Size = New System.Drawing.Size(788, 95)
        Me.GroupBoxGestionProductos.TabIndex = 21
        Me.GroupBoxGestionProductos.TabStop = False
        Me.GroupBoxGestionProductos.Text = "Gestión de Productos"
        '
        'LCatPro
        '
        Me.LCatPro.AutoSize = True
        Me.LCatPro.Font = New System.Drawing.Font("Britannic Bold", 11.0!)
        Me.LCatPro.ForeColor = System.Drawing.Color.White
        Me.LCatPro.Location = New System.Drawing.Point(240, 24)
        Me.LCatPro.Name = "LCatPro"
        Me.LCatPro.Size = New System.Drawing.Size(78, 16)
        Me.LCatPro.TabIndex = 37
        Me.LCatPro.Text = "Categorias"
        '
        'LMarcas
        '
        Me.LMarcas.AutoSize = True
        Me.LMarcas.Font = New System.Drawing.Font("Britannic Bold", 11.0!)
        Me.LMarcas.ForeColor = System.Drawing.Color.White
        Me.LMarcas.Location = New System.Drawing.Point(376, 24)
        Me.LMarcas.Name = "LMarcas"
        Me.LMarcas.Size = New System.Drawing.Size(48, 16)
        Me.LMarcas.TabIndex = 36
        Me.LMarcas.Text = "Marca"
        '
        'CBMarca
        '
        Me.CBMarca.FormattingEnabled = True
        Me.CBMarca.Location = New System.Drawing.Point(380, 43)
        Me.CBMarca.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CBMarca.Name = "CBMarca"
        Me.CBMarca.Size = New System.Drawing.Size(121, 25)
        Me.CBMarca.TabIndex = 31
        Me.CBMarca.Text = "Marcas"
        '
        'CBCateg
        '
        Me.CBCateg.FormattingEnabled = True
        Me.CBCateg.Location = New System.Drawing.Point(243, 43)
        Me.CBCateg.Margin = New System.Windows.Forms.Padding(4, 2, 2, 2)
        Me.CBCateg.Name = "CBCateg"
        Me.CBCateg.Size = New System.Drawing.Size(121, 25)
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
        Me.BEliminarProducto.Location = New System.Drawing.Point(724, 27)
        Me.BEliminarProducto.Name = "BEliminarProducto"
        Me.BEliminarProducto.Size = New System.Drawing.Size(49, 41)
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
        Me.BModificarProducto.Location = New System.Drawing.Point(670, 27)
        Me.BModificarProducto.Name = "BModificarProducto"
        Me.BModificarProducto.Size = New System.Drawing.Size(49, 41)
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
        Me.BBuscarProducto.Location = New System.Drawing.Point(156, 25)
        Me.BBuscarProducto.Name = "BBuscarProducto"
        Me.BBuscarProducto.Size = New System.Drawing.Size(49, 41)
        Me.BBuscarProducto.TabIndex = 14
        Me.BBuscarProducto.UseVisualStyleBackColor = False
        '
        'TBBuscar
        '
        Me.TBBuscar.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBBuscar.Location = New System.Drawing.Point(20, 35)
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
        Me.BVolver.Location = New System.Drawing.Point(712, 470)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(98, 41)
        Me.BVolver.TabIndex = 22
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'BAltaProducto
        '
        Me.BAltaProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BAltaProducto.FlatAppearance.BorderSize = 2
        Me.BAltaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAltaProducto.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAltaProducto.ForeColor = System.Drawing.Color.White
        Me.BAltaProducto.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.plus_32
        Me.BAltaProducto.Location = New System.Drawing.Point(724, 27)
        Me.BAltaProducto.Name = "BAltaProducto"
        Me.BAltaProducto.Size = New System.Drawing.Size(49, 41)
        Me.BAltaProducto.TabIndex = 23
        Me.BAltaProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BAltaProducto.UseVisualStyleBackColor = False
        '
        'GestionarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(862, 533)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.GroupBoxGestionProductos)
        Me.Controls.Add(Me.TabListaCategorias)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "GestionarProductos"
        Me.Text = "GestionarProductos"
        Me.TabListaCategorias.ResumeLayout(False)
        Me.TabPageListaTalle.ResumeLayout(False)
        CType(Me.dgvListaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxGestionProductos.ResumeLayout(False)
        Me.GroupBoxGestionProductos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabListaCategorias As TabControl
    Friend WithEvents TabPageListaTalle As TabPage
    Friend WithEvents GroupBoxGestionProductos As GroupBox
    Friend WithEvents BEliminarProducto As Button
    Friend WithEvents BModificarProducto As Button
    Friend WithEvents BBuscarProducto As Button
    Friend WithEvents TBBuscar As TextBox
    Friend WithEvents BVolver As Button
    Friend WithEvents dgvListaProductos As DataGridView
    Friend WithEvents CBMarca As ComboBox
    Friend WithEvents CBCateg As ComboBox
    Friend WithEvents LCatPro As Label
    Friend WithEvents LMarcas As Label
    Friend WithEvents BAltaProducto As Button
End Class
