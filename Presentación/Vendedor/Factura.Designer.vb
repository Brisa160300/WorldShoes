<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Factura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Factura))
        Me.LCantidad = New System.Windows.Forms.Label()
        Me.TBTotalVenta = New System.Windows.Forms.TextBox()
        Me.LTotalVenta = New System.Windows.Forms.Label()
        Me.TBCantidad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTFECHA = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBFactura = New System.Windows.Forms.TextBox()
        Me.TBVendedor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvVentas = New System.Windows.Forms.DataGridView()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TBCliente = New System.Windows.Forms.TextBox()
        Me.TBDireccion = New System.Windows.Forms.TextBox()
        Me.TBTelefono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BImprimir = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LCantidad
        '
        Me.LCantidad.AutoSize = True
        Me.LCantidad.BackColor = System.Drawing.Color.Transparent
        Me.LCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LCantidad.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LCantidad.ForeColor = System.Drawing.Color.Black
        Me.LCantidad.Location = New System.Drawing.Point(579, 543)
        Me.LCantidad.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LCantidad.Name = "LCantidad"
        Me.LCantidad.Size = New System.Drawing.Size(89, 22)
        Me.LCantidad.TabIndex = 1
        Me.LCantidad.Text = "Cantidad"
        '
        'TBTotalVenta
        '
        Me.TBTotalVenta.BackColor = System.Drawing.SystemColors.Window
        Me.TBTotalVenta.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBTotalVenta.Location = New System.Drawing.Point(687, 588)
        Me.TBTotalVenta.Margin = New System.Windows.Forms.Padding(5)
        Me.TBTotalVenta.Name = "TBTotalVenta"
        Me.TBTotalVenta.ReadOnly = True
        Me.TBTotalVenta.Size = New System.Drawing.Size(100, 30)
        Me.TBTotalVenta.TabIndex = 69
        '
        'LTotalVenta
        '
        Me.LTotalVenta.AutoSize = True
        Me.LTotalVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LTotalVenta.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LTotalVenta.ForeColor = System.Drawing.Color.Black
        Me.LTotalVenta.Location = New System.Drawing.Point(595, 591)
        Me.LTotalVenta.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LTotalVenta.Name = "LTotalVenta"
        Me.LTotalVenta.Size = New System.Drawing.Size(59, 22)
        Me.LTotalVenta.TabIndex = 68
        Me.LTotalVenta.Text = "Total:"
        '
        'TBCantidad
        '
        Me.TBCantidad.BackColor = System.Drawing.SystemColors.Window
        Me.TBCantidad.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBCantidad.Location = New System.Drawing.Point(687, 537)
        Me.TBCantidad.Margin = New System.Windows.Forms.Padding(5)
        Me.TBCantidad.Name = "TBCantidad"
        Me.TBCantidad.ReadOnly = True
        Me.TBCantidad.Size = New System.Drawing.Size(100, 30)
        Me.TBCantidad.TabIndex = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 20.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(219, 69)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 37)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "FACTURA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(188, 165)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 19)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(32, 229)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 19)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Direccion"
        '
        'DTFECHA
        '
        Me.DTFECHA.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.DTFECHA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTFECHA.Location = New System.Drawing.Point(358, 189)
        Me.DTFECHA.Margin = New System.Windows.Forms.Padding(4)
        Me.DTFECHA.Name = "DTFECHA"
        Me.DTFECHA.Size = New System.Drawing.Size(116, 26)
        Me.DTFECHA.TabIndex = 89
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(354, 166)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 19)
        Me.Label5.TabIndex = 88
        Me.Label5.Text = "Fecha"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(32, 165)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 19)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "N° Factura:"
        '
        'TBFactura
        '
        Me.TBFactura.BackColor = System.Drawing.SystemColors.Window
        Me.TBFactura.CausesValidation = False
        Me.TBFactura.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.TBFactura.Location = New System.Drawing.Point(36, 189)
        Me.TBFactura.Margin = New System.Windows.Forms.Padding(5)
        Me.TBFactura.Name = "TBFactura"
        Me.TBFactura.ReadOnly = True
        Me.TBFactura.Size = New System.Drawing.Size(116, 26)
        Me.TBFactura.TabIndex = 91
        '
        'TBVendedor
        '
        Me.TBVendedor.BackColor = System.Drawing.SystemColors.Window
        Me.TBVendedor.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.TBVendedor.Location = New System.Drawing.Point(358, 253)
        Me.TBVendedor.Margin = New System.Windows.Forms.Padding(5)
        Me.TBVendedor.Name = "TBVendedor"
        Me.TBVendedor.ReadOnly = True
        Me.TBVendedor.Size = New System.Drawing.Size(116, 26)
        Me.TBVendedor.TabIndex = 92
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(354, 229)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 19)
        Me.Label7.TabIndex = 93
        Me.Label7.Text = "Vendedor:"
        '
        'dgvVentas
        '
        Me.dgvVentas.AllowUserToAddRows = False
        Me.dgvVentas.AllowUserToDeleteRows = False
        Me.dgvVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12})
        Me.dgvVentas.EnableHeadersVisualStyles = False
        Me.dgvVentas.Location = New System.Drawing.Point(36, 334)
        Me.dgvVentas.Name = "dgvVentas"
        Me.dgvVentas.ReadOnly = True
        Me.dgvVentas.RowHeadersVisible = False
        Me.dgvVentas.RowHeadersWidth = 51
        Me.dgvVentas.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvVentas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvVentas.RowTemplate.Height = 24
        Me.dgvVentas.Size = New System.Drawing.Size(750, 178)
        Me.dgvVentas.TabIndex = 94
        '
        'Column7
        '
        Me.Column7.HeaderText = "Codigo"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "Descripcion"
        Me.Column8.MinimumWidth = 6
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "Precio"
        Me.Column9.MinimumWidth = 6
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "Cantidad"
        Me.Column10.MinimumWidth = 6
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "Talle"
        Me.Column11.MinimumWidth = 6
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        '
        'Column12
        '
        Me.Column12.HeaderText = "Subtotal"
        Me.Column12.MinimumWidth = 6
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox1.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.logoWorldShoes_removebg_preview1
        Me.PictureBox1.Location = New System.Drawing.Point(36, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(156, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 95
        Me.PictureBox1.TabStop = False
        '
        'TBCliente
        '
        Me.TBCliente.BackColor = System.Drawing.SystemColors.Window
        Me.TBCliente.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.TBCliente.Location = New System.Drawing.Point(192, 189)
        Me.TBCliente.Margin = New System.Windows.Forms.Padding(5)
        Me.TBCliente.Name = "TBCliente"
        Me.TBCliente.ReadOnly = True
        Me.TBCliente.Size = New System.Drawing.Size(116, 26)
        Me.TBCliente.TabIndex = 96
        '
        'TBDireccion
        '
        Me.TBDireccion.BackColor = System.Drawing.SystemColors.Window
        Me.TBDireccion.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.TBDireccion.Location = New System.Drawing.Point(36, 253)
        Me.TBDireccion.Margin = New System.Windows.Forms.Padding(5)
        Me.TBDireccion.Name = "TBDireccion"
        Me.TBDireccion.ReadOnly = True
        Me.TBDireccion.Size = New System.Drawing.Size(116, 26)
        Me.TBDireccion.TabIndex = 97
        '
        'TBTelefono
        '
        Me.TBTelefono.BackColor = System.Drawing.SystemColors.Window
        Me.TBTelefono.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.TBTelefono.Location = New System.Drawing.Point(192, 253)
        Me.TBTelefono.Margin = New System.Windows.Forms.Padding(5)
        Me.TBTelefono.Name = "TBTelefono"
        Me.TBTelefono.ReadOnly = True
        Me.TBTelefono.Size = New System.Drawing.Size(116, 26)
        Me.TBTelefono.TabIndex = 99
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(188, 229)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 19)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Telefono"
        '
        'BImprimir
        '
        Me.BImprimir.BackColor = System.Drawing.Color.Black
        Me.BImprimir.FlatAppearance.BorderSize = 2
        Me.BImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BImprimir.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BImprimir.ForeColor = System.Drawing.Color.Transparent
        Me.BImprimir.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.printer_4_32
        Me.BImprimir.Location = New System.Drawing.Point(721, 253)
        Me.BImprimir.Margin = New System.Windows.Forms.Padding(5)
        Me.BImprimir.Name = "BImprimir"
        Me.BImprimir.Size = New System.Drawing.Size(65, 52)
        Me.BImprimir.TabIndex = 100
        Me.BImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BImprimir.UseVisualStyleBackColor = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(817, 766)
        Me.Controls.Add(Me.BImprimir)
        Me.Controls.Add(Me.TBTelefono)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBDireccion)
        Me.Controls.Add(Me.TBCliente)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgvVentas)
        Me.Controls.Add(Me.TBVendedor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TBFactura)
        Me.Controls.Add(Me.DTFECHA)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBCantidad)
        Me.Controls.Add(Me.TBTotalVenta)
        Me.Controls.Add(Me.LTotalVenta)
        Me.Controls.Add(Me.LCantidad)
        Me.Name = "Factura"
        Me.Text = "Factura"
        CType(Me.dgvVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LCantidad As Label
    Friend WithEvents TBTotalVenta As TextBox
    Friend WithEvents LTotalVenta As Label
    Friend WithEvents TBCantidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DTFECHA As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TBFactura As TextBox
    Friend WithEvents TBVendedor As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvVentas As DataGridView
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TBCliente As TextBox
    Friend WithEvents TBDireccion As TextBox
    Friend WithEvents TBTelefono As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BImprimir As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
