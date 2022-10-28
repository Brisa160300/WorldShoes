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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelRegClientes = New System.Windows.Forms.Panel()
        Me.CBTalleProducto = New System.Windows.Forms.ComboBox()
        Me.TBCantidadProducto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LCantidad = New System.Windows.Forms.Label()
        Me.BRegistrarTalle = New System.Windows.Forms.Button()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.TBCodProducto = New System.Windows.Forms.TextBox()
        Me.LProducto = New System.Windows.Forms.Label()
        Me.LTalle = New System.Windows.Forms.Label()
        Me.TabPageListaProductos = New System.Windows.Forms.TabPage()
        Me.dgvListarProductos = New System.Windows.Forms.DataGridView()
        Me.TabControlProductos = New System.Windows.Forms.TabControl()
        Me.TabControlRegUsuarios = New System.Windows.Forms.TabControl()
        Me.TabPageListaUsuarios = New System.Windows.Forms.TabPage()
        Me.dgvDetalleProductos = New System.Windows.Forms.DataGridView()
        Me.PanelRegClientes.SuspendLayout()
        Me.TabPageListaProductos.SuspendLayout()
        CType(Me.dgvListarProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlProductos.SuspendLayout()
        Me.TabControlRegUsuarios.SuspendLayout()
        Me.TabPageListaUsuarios.SuspendLayout()
        CType(Me.dgvDetalleProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelRegClientes
        '
        Me.PanelRegClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PanelRegClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelRegClientes.Controls.Add(Me.CBTalleProducto)
        Me.PanelRegClientes.Controls.Add(Me.TBCantidadProducto)
        Me.PanelRegClientes.Controls.Add(Me.Label2)
        Me.PanelRegClientes.Controls.Add(Me.LCantidad)
        Me.PanelRegClientes.Controls.Add(Me.BRegistrarTalle)
        Me.PanelRegClientes.Controls.Add(Me.BVolver)
        Me.PanelRegClientes.Controls.Add(Me.TBCodProducto)
        Me.PanelRegClientes.Controls.Add(Me.LProducto)
        Me.PanelRegClientes.Location = New System.Drawing.Point(34, 77)
        Me.PanelRegClientes.Name = "PanelRegClientes"
        Me.PanelRegClientes.Size = New System.Drawing.Size(319, 243)
        Me.PanelRegClientes.TabIndex = 8
        '
        'CBTalleProducto
        '
        Me.CBTalleProducto.FormattingEnabled = True
        Me.CBTalleProducto.Location = New System.Drawing.Point(117, 74)
        Me.CBTalleProducto.Name = "CBTalleProducto"
        Me.CBTalleProducto.Size = New System.Drawing.Size(134, 21)
        Me.CBTalleProducto.TabIndex = 18
        '
        'TBCantidadProducto
        '
        Me.TBCantidadProducto.Enabled = False
        Me.TBCantidadProducto.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBCantidadProducto.Location = New System.Drawing.Point(117, 123)
        Me.TBCantidadProducto.Name = "TBCantidadProducto"
        Me.TBCantidadProducto.Size = New System.Drawing.Size(134, 25)
        Me.TBCantidadProducto.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(32, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Talle:"
        '
        'LCantidad
        '
        Me.LCantidad.AutoSize = True
        Me.LCantidad.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LCantidad.ForeColor = System.Drawing.Color.White
        Me.LCantidad.Location = New System.Drawing.Point(32, 126)
        Me.LCantidad.Name = "LCantidad"
        Me.LCantidad.Size = New System.Drawing.Size(75, 17)
        Me.LCantidad.TabIndex = 14
        Me.LCantidad.Text = "Cantidad:"
        '
        'BRegistrarTalle
        '
        Me.BRegistrarTalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BRegistrarTalle.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BRegistrarTalle.FlatAppearance.BorderSize = 2
        Me.BRegistrarTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRegistrarTalle.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BRegistrarTalle.ForeColor = System.Drawing.Color.White
        Me.BRegistrarTalle.Location = New System.Drawing.Point(84, 177)
        Me.BRegistrarTalle.Name = "BRegistrarTalle"
        Me.BRegistrarTalle.Size = New System.Drawing.Size(98, 42)
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
        Me.BVolver.Location = New System.Drawing.Point(207, 177)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(98, 42)
        Me.BVolver.TabIndex = 12
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'TBCodProducto
        '
        Me.TBCodProducto.Enabled = False
        Me.TBCodProducto.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBCodProducto.Location = New System.Drawing.Point(117, 17)
        Me.TBCodProducto.Name = "TBCodProducto"
        Me.TBCodProducto.Size = New System.Drawing.Size(134, 25)
        Me.TBCodProducto.TabIndex = 6
        '
        'LProducto
        '
        Me.LProducto.AutoSize = True
        Me.LProducto.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LProducto.ForeColor = System.Drawing.Color.White
        Me.LProducto.Location = New System.Drawing.Point(32, 20)
        Me.LProducto.Name = "LProducto"
        Me.LProducto.Size = New System.Drawing.Size(79, 17)
        Me.LProducto.TabIndex = 0
        Me.LProducto.Text = "Producto:"
        '
        'LTalle
        '
        Me.LTalle.AutoSize = True
        Me.LTalle.BackColor = System.Drawing.Color.Transparent
        Me.LTalle.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTalle.ForeColor = System.Drawing.Color.Transparent
        Me.LTalle.Location = New System.Drawing.Point(29, 21)
        Me.LTalle.Name = "LTalle"
        Me.LTalle.Size = New System.Drawing.Size(400, 27)
        Me.LTalle.TabIndex = 7
        Me.LTalle.Text = "Añadir Talles a Productos Existentes"
        '
        'TabPageListaProductos
        '
        Me.TabPageListaProductos.Controls.Add(Me.dgvListarProductos)
        Me.TabPageListaProductos.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaProductos.ForeColor = System.Drawing.Color.White
        Me.TabPageListaProductos.Location = New System.Drawing.Point(4, 25)
        Me.TabPageListaProductos.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPageListaProductos.Name = "TabPageListaProductos"
        Me.TabPageListaProductos.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPageListaProductos.Size = New System.Drawing.Size(460, 218)
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
        Me.dgvListarProductos.Location = New System.Drawing.Point(2, 2)
        Me.dgvListarProductos.Name = "dgvListarProductos"
        Me.dgvListarProductos.ReadOnly = True
        Me.dgvListarProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvListarProductos.RowHeadersWidth = 51
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.dgvListarProductos.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListarProductos.Size = New System.Drawing.Size(456, 214)
        Me.dgvListarProductos.TabIndex = 2
        '
        'TabControlProductos
        '
        Me.TabControlProductos.Controls.Add(Me.TabPageListaProductos)
        Me.TabControlProductos.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlProductos.Location = New System.Drawing.Point(383, 77)
        Me.TabControlProductos.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControlProductos.Name = "TabControlProductos"
        Me.TabControlProductos.SelectedIndex = 0
        Me.TabControlProductos.Size = New System.Drawing.Size(468, 247)
        Me.TabControlProductos.TabIndex = 9
        '
        'TabControlRegUsuarios
        '
        Me.TabControlRegUsuarios.Controls.Add(Me.TabPageListaUsuarios)
        Me.TabControlRegUsuarios.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlRegUsuarios.Location = New System.Drawing.Point(34, 335)
        Me.TabControlRegUsuarios.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControlRegUsuarios.Name = "TabControlRegUsuarios"
        Me.TabControlRegUsuarios.SelectedIndex = 0
        Me.TabControlRegUsuarios.Size = New System.Drawing.Size(665, 187)
        Me.TabControlRegUsuarios.TabIndex = 26
        '
        'TabPageListaUsuarios
        '
        Me.TabPageListaUsuarios.Controls.Add(Me.dgvDetalleProductos)
        Me.TabPageListaUsuarios.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaUsuarios.ForeColor = System.Drawing.Color.White
        Me.TabPageListaUsuarios.Location = New System.Drawing.Point(4, 25)
        Me.TabPageListaUsuarios.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPageListaUsuarios.Name = "TabPageListaUsuarios"
        Me.TabPageListaUsuarios.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPageListaUsuarios.Size = New System.Drawing.Size(657, 158)
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
        Me.dgvDetalleProductos.Location = New System.Drawing.Point(2, 2)
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
        Me.dgvDetalleProductos.Size = New System.Drawing.Size(653, 154)
        Me.dgvDetalleProductos.TabIndex = 2
        '
        'AñadirTallesProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(862, 533)
        Me.Controls.Add(Me.TabControlRegUsuarios)
        Me.Controls.Add(Me.TabControlProductos)
        Me.Controls.Add(Me.PanelRegClientes)
        Me.Controls.Add(Me.LTalle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents CBTalleProducto As ComboBox
    Friend WithEvents TabControlRegUsuarios As TabControl
    Friend WithEvents TabPageListaUsuarios As TabPage
    Friend WithEvents dgvDetalleProductos As DataGridView
End Class
