<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListarVentas
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PBVentasVendedor = New System.Windows.Forms.PictureBox()
        Me.LVentasVendedor = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Colum_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_FechaVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_ClienteVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_ProductosVenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_CantidadProductos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_ImporteTotalFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_Vendedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BBuscarVentas = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PBVentasVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Colum_ID, Me.Colum_FechaVenta, Me.Colum_ClienteVenta, Me.Colum_ProductosVenta, Me.Colum_CantidadProductos, Me.Colum_ImporteTotalFactura, Me.Colum_Vendedor})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EnableHeadersVisualStyles = False
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(735, 280)
        Me.DataGridView1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PBVentasVendedor)
        Me.Panel1.Controls.Add(Me.LVentasVendedor)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(759, 100)
        Me.Panel1.TabIndex = 1
        '
        'PBVentasVendedor
        '
        Me.PBVentasVendedor.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.iconventas
        Me.PBVentasVendedor.Location = New System.Drawing.Point(92, 28)
        Me.PBVentasVendedor.Name = "PBVentasVendedor"
        Me.PBVentasVendedor.Size = New System.Drawing.Size(35, 35)
        Me.PBVentasVendedor.TabIndex = 1
        Me.PBVentasVendedor.TabStop = False
        '
        'LVentasVendedor
        '
        Me.LVentasVendedor.AutoSize = True
        Me.LVentasVendedor.Font = New System.Drawing.Font("Britannic Bold", 18.0!)
        Me.LVentasVendedor.ForeColor = System.Drawing.Color.White
        Me.LVentasVendedor.Location = New System.Drawing.Point(13, 36)
        Me.LVentasVendedor.Name = "LVentasVendedor"
        Me.LVentasVendedor.Size = New System.Drawing.Size(83, 27)
        Me.LVentasVendedor.TabIndex = 0
        Me.LVentasVendedor.Text = "Ventas"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Location = New System.Drawing.Point(12, 155)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(735, 280)
        Me.Panel2.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 115)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(577, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "Búscar..."
        '
        'Colum_ID
        '
        Me.Colum_ID.HeaderText = "Cod. Factura"
        Me.Colum_ID.Name = "Colum_ID"
        '
        'Colum_FechaVenta
        '
        Me.Colum_FechaVenta.HeaderText = "Fecha de Venta"
        Me.Colum_FechaVenta.Name = "Colum_FechaVenta"
        '
        'Colum_ClienteVenta
        '
        Me.Colum_ClienteVenta.HeaderText = "Cliente"
        Me.Colum_ClienteVenta.Name = "Colum_ClienteVenta"
        '
        'Colum_ProductosVenta
        '
        Me.Colum_ProductosVenta.HeaderText = "Productos"
        Me.Colum_ProductosVenta.Name = "Colum_ProductosVenta"
        '
        'Colum_CantidadProductos
        '
        Me.Colum_CantidadProductos.HeaderText = "Cantidad"
        Me.Colum_CantidadProductos.Name = "Colum_CantidadProductos"
        '
        'Colum_ImporteTotalFactura
        '
        Me.Colum_ImporteTotalFactura.HeaderText = "Importe Total"
        Me.Colum_ImporteTotalFactura.Name = "Colum_ImporteTotalFactura"
        '
        'Colum_Vendedor
        '
        Me.Colum_Vendedor.HeaderText = "Vendedor"
        Me.Colum_Vendedor.Name = "Colum_Vendedor"
        '
        'BBuscarVentas
        '
        Me.BBuscarVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BBuscarVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBuscarVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.8!, System.Drawing.FontStyle.Bold)
        Me.BBuscarVentas.ForeColor = System.Drawing.Color.White
        Me.BBuscarVentas.Location = New System.Drawing.Point(604, 108)
        Me.BBuscarVentas.Name = "BBuscarVentas"
        Me.BBuscarVentas.Size = New System.Drawing.Size(98, 32)
        Me.BBuscarVentas.TabIndex = 3
        Me.BBuscarVentas.Text = "Búscar"
        Me.BBuscarVentas.UseVisualStyleBackColor = False
        '
        'ListarVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(759, 454)
        Me.Controls.Add(Me.BBuscarVentas)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ListarVentas"
        Me.Text = "ListarVentas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PBVentasVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PBVentasVendedor As PictureBox
    Friend WithEvents LVentasVendedor As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Colum_ID As DataGridViewTextBoxColumn
    Friend WithEvents Colum_FechaVenta As DataGridViewTextBoxColumn
    Friend WithEvents Colum_ClienteVenta As DataGridViewTextBoxColumn
    Friend WithEvents Colum_ProductosVenta As DataGridViewTextBoxColumn
    Friend WithEvents Colum_CantidadProductos As DataGridViewTextBoxColumn
    Friend WithEvents Colum_ImporteTotalFactura As DataGridViewTextBoxColumn
    Friend WithEvents Colum_Vendedor As DataGridViewTextBoxColumn
    Friend WithEvents BBuscarVentas As Button
End Class
