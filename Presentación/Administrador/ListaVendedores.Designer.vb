<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListaVendedores
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBoxBuscarVenta = New System.Windows.Forms.GroupBox()
        Me.BImprimriVentedores = New System.Windows.Forms.Button()
        Me.BBuscarVendedor = New System.Windows.Forms.Button()
        Me.TBBuscarVendedor = New System.Windows.Forms.TextBox()
        Me.TabControlListaProductos = New System.Windows.Forms.TabControl()
        Me.TabPageListaProducto = New System.Windows.Forms.TabPage()
        Me.DataGridViewListaVentas = New System.Windows.Forms.DataGridView()
        Me.GroupBoxBuscarVenta.SuspendLayout()
        Me.TabControlListaProductos.SuspendLayout()
        Me.TabPageListaProducto.SuspendLayout()
        CType(Me.DataGridViewListaVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxBuscarVenta
        '
        Me.GroupBoxBuscarVenta.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxBuscarVenta.Controls.Add(Me.BImprimriVentedores)
        Me.GroupBoxBuscarVenta.Controls.Add(Me.BBuscarVendedor)
        Me.GroupBoxBuscarVenta.Controls.Add(Me.TBBuscarVendedor)
        Me.GroupBoxBuscarVenta.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.GroupBoxBuscarVenta.ForeColor = System.Drawing.Color.White
        Me.GroupBoxBuscarVenta.Location = New System.Drawing.Point(28, 41)
        Me.GroupBoxBuscarVenta.Name = "GroupBoxBuscarVenta"
        Me.GroupBoxBuscarVenta.Size = New System.Drawing.Size(801, 81)
        Me.GroupBoxBuscarVenta.TabIndex = 21
        Me.GroupBoxBuscarVenta.TabStop = False
        Me.GroupBoxBuscarVenta.Text = "Vendedores"
        '
        'BImprimriVentedores
        '
        Me.BImprimriVentedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BImprimriVentedores.FlatAppearance.BorderSize = 2
        Me.BImprimriVentedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BImprimriVentedores.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BImprimriVentedores.ForeColor = System.Drawing.Color.White
        Me.BImprimriVentedores.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.printer_4_32
        Me.BImprimriVentedores.Location = New System.Drawing.Point(734, 25)
        Me.BImprimriVentedores.Name = "BImprimriVentedores"
        Me.BImprimriVentedores.Size = New System.Drawing.Size(49, 41)
        Me.BImprimriVentedores.TabIndex = 19
        Me.BImprimriVentedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BImprimriVentedores.UseVisualStyleBackColor = False
        '
        'BBuscarVendedor
        '
        Me.BBuscarVendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BBuscarVendedor.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BBuscarVendedor.FlatAppearance.BorderSize = 2
        Me.BBuscarVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBuscarVendedor.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscarVendedor.ForeColor = System.Drawing.Color.White
        Me.BBuscarVendedor.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.search_3_32
        Me.BBuscarVendedor.Location = New System.Drawing.Point(153, 25)
        Me.BBuscarVendedor.Name = "BBuscarVendedor"
        Me.BBuscarVendedor.Size = New System.Drawing.Size(49, 41)
        Me.BBuscarVendedor.TabIndex = 14
        Me.BBuscarVendedor.UseVisualStyleBackColor = False
        '
        'TBBuscarVendedor
        '
        Me.TBBuscarVendedor.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBBuscarVendedor.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TBBuscarVendedor.Location = New System.Drawing.Point(17, 35)
        Me.TBBuscarVendedor.Name = "TBBuscarVendedor"
        Me.TBBuscarVendedor.Size = New System.Drawing.Size(131, 25)
        Me.TBBuscarVendedor.TabIndex = 6
        '
        'TabControlListaProductos
        '
        Me.TabControlListaProductos.Controls.Add(Me.TabPageListaProducto)
        Me.TabControlListaProductos.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlListaProductos.Location = New System.Drawing.Point(31, 149)
        Me.TabControlListaProductos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControlListaProductos.Name = "TabControlListaProductos"
        Me.TabControlListaProductos.SelectedIndex = 0
        Me.TabControlListaProductos.Size = New System.Drawing.Size(801, 343)
        Me.TabControlListaProductos.TabIndex = 20
        '
        'TabPageListaProducto
        '
        Me.TabPageListaProducto.Controls.Add(Me.DataGridViewListaVentas)
        Me.TabPageListaProducto.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaProducto.ForeColor = System.Drawing.Color.White
        Me.TabPageListaProducto.Location = New System.Drawing.Point(4, 25)
        Me.TabPageListaProducto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPageListaProducto.Name = "TabPageListaProducto"
        Me.TabPageListaProducto.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPageListaProducto.Size = New System.Drawing.Size(793, 314)
        Me.TabPageListaProducto.TabIndex = 0
        Me.TabPageListaProducto.Text = "Lista de Vendedores"
        Me.TabPageListaProducto.UseVisualStyleBackColor = True
        '
        'DataGridViewListaVentas
        '
        Me.DataGridViewListaVentas.AllowUserToAddRows = False
        Me.DataGridViewListaVentas.AllowUserToDeleteRows = False
        Me.DataGridViewListaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewListaVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewListaVentas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.DataGridViewListaVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewListaVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewListaVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewListaVentas.ColumnHeadersHeight = 20
        Me.DataGridViewListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridViewListaVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewListaVentas.EnableHeadersVisualStyles = False
        Me.DataGridViewListaVentas.Location = New System.Drawing.Point(2, 2)
        Me.DataGridViewListaVentas.Name = "DataGridViewListaVentas"
        Me.DataGridViewListaVentas.ReadOnly = True
        Me.DataGridViewListaVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewListaVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewListaVentas.RowHeadersWidth = 51
        Me.DataGridViewListaVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridViewListaVentas.Size = New System.Drawing.Size(789, 310)
        Me.DataGridViewListaVentas.TabIndex = 5
        '
        'ListaVendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(862, 533)
        Me.Controls.Add(Me.GroupBoxBuscarVenta)
        Me.Controls.Add(Me.TabControlListaProductos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "ListaVendedores"
        Me.Text = "ListaVendedores"
        Me.GroupBoxBuscarVenta.ResumeLayout(False)
        Me.GroupBoxBuscarVenta.PerformLayout()
        Me.TabControlListaProductos.ResumeLayout(False)
        Me.TabPageListaProducto.ResumeLayout(False)
        CType(Me.DataGridViewListaVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxBuscarVenta As GroupBox
    Friend WithEvents BBuscarVendedor As Button
    Friend WithEvents TBBuscarVendedor As TextBox
    Friend WithEvents TabControlListaProductos As TabControl
    Friend WithEvents TabPageListaProducto As TabPage
    Friend WithEvents DataGridViewListaVentas As DataGridView
    Friend WithEvents BImprimriVentedores As Button
End Class
