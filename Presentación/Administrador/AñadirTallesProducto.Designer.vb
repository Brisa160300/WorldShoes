<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AñadirTallesProducto
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelRegClientes = New System.Windows.Forms.Panel()
        Me.CBTalle = New System.Windows.Forms.ComboBox()
        Me.TBCantidadProducto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LCantidad = New System.Windows.Forms.Label()
        Me.TBCodProducto = New System.Windows.Forms.TextBox()
        Me.LProducto = New System.Windows.Forms.Label()
        Me.BRegistrarTalle = New System.Windows.Forms.Button()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.LTalle = New System.Windows.Forms.Label()
        Me.TabPageListaProductos = New System.Windows.Forms.TabPage()
        Me.dgvListarProductos = New System.Windows.Forms.DataGridView()
        Me.TabControlProductos = New System.Windows.Forms.TabControl()
        Me.TabControlRegUsuarios = New System.Windows.Forms.TabControl()
        Me.TabPageListaUsuarios = New System.Windows.Forms.TabPage()
        Me.dgvDetalleProductos = New System.Windows.Forms.DataGridView()
        Me.ErrorPProd = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorPTalle = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorPCant = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelRegClientes.SuspendLayout()
        Me.TabPageListaProductos.SuspendLayout()
        CType(Me.dgvListarProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlProductos.SuspendLayout()
        Me.TabControlRegUsuarios.SuspendLayout()
        Me.TabPageListaUsuarios.SuspendLayout()
        CType(Me.dgvDetalleProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorPProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorPTalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorPCant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelRegClientes
        '
        Me.PanelRegClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PanelRegClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelRegClientes.Controls.Add(Me.CBTalle)
        Me.PanelRegClientes.Controls.Add(Me.TBCantidadProducto)
        Me.PanelRegClientes.Controls.Add(Me.Label2)
        Me.PanelRegClientes.Controls.Add(Me.LCantidad)
        Me.PanelRegClientes.Controls.Add(Me.TBCodProducto)
        Me.PanelRegClientes.Controls.Add(Me.LProducto)
        Me.PanelRegClientes.Location = New System.Drawing.Point(45, 125)
        Me.PanelRegClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelRegClientes.Name = "PanelRegClientes"
        Me.PanelRegClientes.Size = New System.Drawing.Size(346, 266)
        Me.PanelRegClientes.TabIndex = 8
        '
        'CBTalle
        '
        Me.CBTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBTalle.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.CBTalle.FormattingEnabled = True
        Me.CBTalle.Location = New System.Drawing.Point(140, 126)
        Me.CBTalle.Margin = New System.Windows.Forms.Padding(4)
        Me.CBTalle.Name = "CBTalle"
        Me.CBTalle.Size = New System.Drawing.Size(177, 30)
        Me.CBTalle.TabIndex = 18
        '
        'TBCantidadProducto
        '
        Me.TBCantidadProducto.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBCantidadProducto.Location = New System.Drawing.Point(140, 186)
        Me.TBCantidadProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.TBCantidadProducto.Name = "TBCantidadProducto"
        Me.TBCantidadProducto.Size = New System.Drawing.Size(177, 30)
        Me.TBCantidadProducto.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(27, 126)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 22)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Talle:"
        '
        'LCantidad
        '
        Me.LCantidad.AutoSize = True
        Me.LCantidad.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LCantidad.ForeColor = System.Drawing.Color.White
        Me.LCantidad.Location = New System.Drawing.Point(27, 190)
        Me.LCantidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LCantidad.Name = "LCantidad"
        Me.LCantidad.Size = New System.Drawing.Size(65, 22)
        Me.LCantidad.TabIndex = 14
        Me.LCantidad.Text = "Stock:"
        '
        'TBCodProducto
        '
        Me.TBCodProducto.Enabled = False
        Me.TBCodProducto.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBCodProducto.Location = New System.Drawing.Point(140, 56)
        Me.TBCodProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.TBCodProducto.Name = "TBCodProducto"
        Me.TBCodProducto.Size = New System.Drawing.Size(177, 30)
        Me.TBCodProducto.TabIndex = 6
        '
        'LProducto
        '
        Me.LProducto.AutoSize = True
        Me.LProducto.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LProducto.ForeColor = System.Drawing.Color.White
        Me.LProducto.Location = New System.Drawing.Point(27, 60)
        Me.LProducto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LProducto.Name = "LProducto"
        Me.LProducto.Size = New System.Drawing.Size(97, 22)
        Me.LProducto.TabIndex = 0
        Me.LProducto.Text = "Producto:"
        '
        'BRegistrarTalle
        '
        Me.BRegistrarTalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BRegistrarTalle.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BRegistrarTalle.FlatAppearance.BorderSize = 2
        Me.BRegistrarTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRegistrarTalle.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BRegistrarTalle.ForeColor = System.Drawing.Color.White
        Me.BRegistrarTalle.Location = New System.Drawing.Point(953, 460)
        Me.BRegistrarTalle.Margin = New System.Windows.Forms.Padding(4)
        Me.BRegistrarTalle.Name = "BRegistrarTalle"
        Me.BRegistrarTalle.Size = New System.Drawing.Size(131, 52)
        Me.BRegistrarTalle.TabIndex = 13
        Me.BRegistrarTalle.Text = "Añadir"
        Me.BRegistrarTalle.UseVisualStyleBackColor = False
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVolver.ForeColor = System.Drawing.Color.White
        Me.BVolver.Location = New System.Drawing.Point(953, 540)
        Me.BVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(131, 52)
        Me.BVolver.TabIndex = 12
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'LTalle
        '
        Me.LTalle.AutoSize = True
        Me.LTalle.BackColor = System.Drawing.Color.Transparent
        Me.LTalle.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTalle.ForeColor = System.Drawing.Color.Transparent
        Me.LTalle.Location = New System.Drawing.Point(46, 27)
        Me.LTalle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LTalle.Name = "LTalle"
        Me.LTalle.Size = New System.Drawing.Size(498, 33)
        Me.LTalle.TabIndex = 7
        Me.LTalle.Text = "Añadir Talles a Productos Existentes"
        '
        'TabPageListaProductos
        '
        Me.TabPageListaProductos.Controls.Add(Me.dgvListarProductos)
        Me.TabPageListaProductos.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaProductos.ForeColor = System.Drawing.Color.White
        Me.TabPageListaProductos.Location = New System.Drawing.Point(4, 28)
        Me.TabPageListaProductos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaProductos.Name = "TabPageListaProductos"
        Me.TabPageListaProductos.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaProductos.Size = New System.Drawing.Size(647, 266)
        Me.TabPageListaProductos.TabIndex = 0
        Me.TabPageListaProductos.Text = "Lista de Productos"
        Me.TabPageListaProductos.UseVisualStyleBackColor = True
        '
        'dgvListarProductos
        '
        Me.dgvListarProductos.AllowUserToAddRows = False
        Me.dgvListarProductos.AllowUserToDeleteRows = False
        Me.dgvListarProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListarProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListarProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgvListarProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListarProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListarProductos.ColumnHeadersHeight = 20
        Me.dgvListarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListarProductos.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListarProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListarProductos.EnableHeadersVisualStyles = False
        Me.dgvListarProductos.Location = New System.Drawing.Point(3, 2)
        Me.dgvListarProductos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvListarProductos.Name = "dgvListarProductos"
        Me.dgvListarProductos.ReadOnly = True
        Me.dgvListarProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvListarProductos.RowHeadersWidth = 51
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.dgvListarProductos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListarProductos.Size = New System.Drawing.Size(641, 262)
        Me.dgvListarProductos.TabIndex = 2
        '
        'TabControlProductos
        '
        Me.TabControlProductos.Controls.Add(Me.TabPageListaProductos)
        Me.TabControlProductos.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlProductos.Location = New System.Drawing.Point(429, 93)
        Me.TabControlProductos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlProductos.Name = "TabControlProductos"
        Me.TabControlProductos.SelectedIndex = 0
        Me.TabControlProductos.Size = New System.Drawing.Size(655, 298)
        Me.TabControlProductos.TabIndex = 9
        '
        'TabControlRegUsuarios
        '
        Me.TabControlRegUsuarios.Controls.Add(Me.TabPageListaUsuarios)
        Me.TabControlRegUsuarios.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlRegUsuarios.Location = New System.Drawing.Point(45, 412)
        Me.TabControlRegUsuarios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlRegUsuarios.Name = "TabControlRegUsuarios"
        Me.TabControlRegUsuarios.SelectedIndex = 0
        Me.TabControlRegUsuarios.Size = New System.Drawing.Size(887, 215)
        Me.TabControlRegUsuarios.TabIndex = 26
        '
        'TabPageListaUsuarios
        '
        Me.TabPageListaUsuarios.Controls.Add(Me.dgvDetalleProductos)
        Me.TabPageListaUsuarios.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaUsuarios.ForeColor = System.Drawing.Color.White
        Me.TabPageListaUsuarios.Location = New System.Drawing.Point(4, 28)
        Me.TabPageListaUsuarios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaUsuarios.Name = "TabPageListaUsuarios"
        Me.TabPageListaUsuarios.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaUsuarios.Size = New System.Drawing.Size(879, 183)
        Me.TabPageListaUsuarios.TabIndex = 0
        Me.TabPageListaUsuarios.Text = "Detalle Productos"
        Me.TabPageListaUsuarios.UseVisualStyleBackColor = True
        '
        'dgvDetalleProductos
        '
        Me.dgvDetalleProductos.AllowUserToAddRows = False
        Me.dgvDetalleProductos.AllowUserToDeleteRows = False
        Me.dgvDetalleProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvDetalleProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgvDetalleProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalleProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvDetalleProductos.ColumnHeadersHeight = 20
        Me.dgvDetalleProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDetalleProductos.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDetalleProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDetalleProductos.EnableHeadersVisualStyles = False
        Me.dgvDetalleProductos.Location = New System.Drawing.Point(3, 2)
        Me.dgvDetalleProductos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvDetalleProductos.Name = "dgvDetalleProductos"
        Me.dgvDetalleProductos.ReadOnly = True
        Me.dgvDetalleProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDetalleProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvDetalleProductos.RowHeadersWidth = 51
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black
        Me.dgvDetalleProductos.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvDetalleProductos.Size = New System.Drawing.Size(873, 179)
        Me.dgvDetalleProductos.TabIndex = 2
        '
        'ErrorPProd
        '
        Me.ErrorPProd.ContainerControl = Me
        '
        'ErrorPTalle
        '
        Me.ErrorPTalle.ContainerControl = Me
        '
        'ErrorPCant
        '
        Me.ErrorPCant.ContainerControl = Me
        '
        'AñadirTallesProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1149, 656)
        Me.Controls.Add(Me.TabControlRegUsuarios)
        Me.Controls.Add(Me.TabControlProductos)
        Me.Controls.Add(Me.PanelRegClientes)
        Me.Controls.Add(Me.LTalle)
        Me.Controls.Add(Me.BRegistrarTalle)
        Me.Controls.Add(Me.BVolver)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AñadirTallesProducto"
        Me.Text = "AñadirTallesProducto"
        Me.PanelRegClientes.ResumeLayout(False)
        Me.PanelRegClientes.PerformLayout()
        Me.TabPageListaProductos.ResumeLayout(False)
        CType(Me.dgvListarProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlProductos.ResumeLayout(False)
        Me.TabControlRegUsuarios.ResumeLayout(False)
        Me.TabPageListaUsuarios.ResumeLayout(False)
        CType(Me.dgvDetalleProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorPProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorPTalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorPCant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelRegClientes As Panel
    Friend WithEvents BRegistrarTalle As Button
    Friend WithEvents BVolver As Button
    Friend WithEvents TBCodProducto As TextBox
    Friend WithEvents LProducto As Label
    Friend WithEvents LTalle As Label
    Friend WithEvents TabPageListaProductos As TabPage
    Friend WithEvents dgvListarProductos As DataGridView
    Friend WithEvents TabControlProductos As TabControl
    Friend WithEvents Label2 As Label
    Friend WithEvents LCantidad As Label
    Friend WithEvents TBCantidadProducto As TextBox
    Friend WithEvents CBTalle As ComboBox
    Friend WithEvents TabControlRegUsuarios As TabControl
    Friend WithEvents TabPageListaUsuarios As TabPage
    Friend WithEvents dgvDetalleProductos As DataGridView
    Friend WithEvents ErrorPProd As ErrorProvider
    Friend WithEvents ErrorPTalle As ErrorProvider
    Friend WithEvents ErrorPCant As ErrorProvider
End Class
