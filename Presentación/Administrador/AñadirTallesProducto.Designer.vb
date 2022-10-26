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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelRegClientes = New System.Windows.Forms.Panel()
        Me.BRegistrarTalle = New System.Windows.Forms.Button()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.TBNombreTalle = New System.Windows.Forms.TextBox()
        Me.LProducto = New System.Windows.Forms.Label()
        Me.LTalle = New System.Windows.Forms.Label()
        Me.TabPageListaProductos = New System.Windows.Forms.TabPage()
        Me.dgvListarProductos = New System.Windows.Forms.DataGridView()
        Me.TabControlProductos = New System.Windows.Forms.TabControl()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelRegClientes.SuspendLayout()
        Me.TabPageListaProductos.SuspendLayout()
        CType(Me.dgvListarProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlProductos.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelRegClientes
        '
        Me.PanelRegClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PanelRegClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelRegClientes.Controls.Add(Me.TextBox2)
        Me.PanelRegClientes.Controls.Add(Me.Label2)
        Me.PanelRegClientes.Controls.Add(Me.TextBox1)
        Me.PanelRegClientes.Controls.Add(Me.Label1)
        Me.PanelRegClientes.Controls.Add(Me.BRegistrarTalle)
        Me.PanelRegClientes.Controls.Add(Me.BVolver)
        Me.PanelRegClientes.Controls.Add(Me.TBNombreTalle)
        Me.PanelRegClientes.Controls.Add(Me.LProducto)
        Me.PanelRegClientes.Location = New System.Drawing.Point(46, 153)
        Me.PanelRegClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelRegClientes.Name = "PanelRegClientes"
        Me.PanelRegClientes.Size = New System.Drawing.Size(425, 325)
        Me.PanelRegClientes.TabIndex = 8
        '
        'BRegistrarTalle
        '
        Me.BRegistrarTalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BRegistrarTalle.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BRegistrarTalle.FlatAppearance.BorderSize = 2
        Me.BRegistrarTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRegistrarTalle.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BRegistrarTalle.ForeColor = System.Drawing.Color.White
        Me.BRegistrarTalle.Location = New System.Drawing.Point(121, 247)
        Me.BRegistrarTalle.Margin = New System.Windows.Forms.Padding(4)
        Me.BRegistrarTalle.Name = "BRegistrarTalle"
        Me.BRegistrarTalle.Size = New System.Drawing.Size(130, 52)
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
        Me.BVolver.Location = New System.Drawing.Point(268, 247)
        Me.BVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(130, 52)
        Me.BVolver.TabIndex = 12
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'TBNombreTalle
        '
        Me.TBNombreTalle.Enabled = False
        Me.TBNombreTalle.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBNombreTalle.Location = New System.Drawing.Point(168, 29)
        Me.TBNombreTalle.Margin = New System.Windows.Forms.Padding(4)
        Me.TBNombreTalle.Name = "TBNombreTalle"
        Me.TBNombreTalle.Size = New System.Drawing.Size(153, 30)
        Me.TBNombreTalle.TabIndex = 6
        '
        'LProducto
        '
        Me.LProducto.AutoSize = True
        Me.LProducto.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LProducto.ForeColor = System.Drawing.Color.White
        Me.LProducto.Location = New System.Drawing.Point(43, 32)
        Me.LProducto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LProducto.Name = "LProducto"
        Me.LProducto.Size = New System.Drawing.Size(91, 22)
        Me.LProducto.TabIndex = 0
        Me.LProducto.Text = "Producto"
        '
        'LTalle
        '
        Me.LTalle.AutoSize = True
        Me.LTalle.BackColor = System.Drawing.Color.Transparent
        Me.LTalle.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTalle.ForeColor = System.Drawing.Color.Transparent
        Me.LTalle.Location = New System.Drawing.Point(40, 46)
        Me.LTalle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LTalle.Name = "LTalle"
        Me.LTalle.Size = New System.Drawing.Size(517, 33)
        Me.LTalle.TabIndex = 7
        Me.LTalle.Text = "Agregar Talles a Productos Existentes"
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
        Me.TabPageListaProductos.Size = New System.Drawing.Size(576, 479)
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListarProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvListarProductos.ColumnHeadersHeight = 20
        Me.dgvListarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListarProductos.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvListarProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListarProductos.EnableHeadersVisualStyles = False
        Me.dgvListarProductos.Location = New System.Drawing.Point(3, 2)
        Me.dgvListarProductos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvListarProductos.Name = "dgvListarProductos"
        Me.dgvListarProductos.ReadOnly = True
        Me.dgvListarProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvListarProductos.RowHeadersWidth = 51
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        Me.dgvListarProductos.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvListarProductos.Size = New System.Drawing.Size(570, 475)
        Me.dgvListarProductos.TabIndex = 2
        '
        'TabControlProductos
        '
        Me.TabControlProductos.Controls.Add(Me.TabPageListaProductos)
        Me.TabControlProductos.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlProductos.Location = New System.Drawing.Point(524, 92)
        Me.TabControlProductos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlProductos.Name = "TabControlProductos"
        Me.TabControlProductos.SelectedIndex = 0
        Me.TabControlProductos.Size = New System.Drawing.Size(584, 511)
        Me.TabControlProductos.TabIndex = 9
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TextBox1.Location = New System.Drawing.Point(168, 82)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(153, 30)
        Me.TextBox1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(43, 85)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 22)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Producto"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TextBox2.Location = New System.Drawing.Point(168, 145)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(153, 30)
        Me.TextBox2.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(43, 148)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 22)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Producto"
        '
        'AñadirTallesProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1149, 656)
        Me.Controls.Add(Me.TabControlProductos)
        Me.Controls.Add(Me.PanelRegClientes)
        Me.Controls.Add(Me.LTalle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AñadirTallesProducto"
        Me.Text = "AñadirTallesProducto"
        Me.PanelRegClientes.ResumeLayout(False)
        Me.PanelRegClientes.PerformLayout()
        Me.TabPageListaProductos.ResumeLayout(False)
        CType(Me.dgvListarProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlProductos.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelRegClientes As Panel
    Friend WithEvents BRegistrarTalle As Button
    Friend WithEvents BVolver As Button
    Friend WithEvents TBNombreTalle As TextBox
    Friend WithEvents LProducto As Label
    Friend WithEvents LTalle As Label
    Friend WithEvents TabPageListaProductos As TabPage
    Friend WithEvents dgvListarProductos As DataGridView
    Friend WithEvents TabControlProductos As TabControl
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
