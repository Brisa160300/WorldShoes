<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetalleVenta
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvListaVentas = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Talle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabDetalleVenta = New System.Windows.Forms.TabControl()
        Me.TabPageDetalleVenta = New System.Windows.Forms.TabPage()
        Me.BCancelar = New System.Windows.Forms.Button()
        CType(Me.dgvListaVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabDetalleVenta.SuspendLayout()
        Me.TabPageDetalleVenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvListaVentas
        '
        Me.dgvListaVentas.AllowUserToDeleteRows = False
        Me.dgvListaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListaVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListaVentas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgvListaVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListaVentas.ColumnHeadersHeight = 20
        Me.dgvListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvListaVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Descripcion, Me.Precio, Me.Cantidad, Me.Talle})
        Me.dgvListaVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListaVentas.EnableHeadersVisualStyles = False
        Me.dgvListaVentas.Location = New System.Drawing.Point(3, 3)
        Me.dgvListaVentas.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.dgvListaVentas.Name = "dgvListaVentas"
        Me.dgvListaVentas.ReadOnly = True
        Me.dgvListaVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvListaVentas.RowHeadersWidth = 51
        Me.dgvListaVentas.RowTemplate.Height = 24
        Me.dgvListaVentas.Size = New System.Drawing.Size(1015, 365)
        Me.dgvListaVentas.TabIndex = 56
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.MinimumWidth = 6
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.MinimumWidth = 6
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.MinimumWidth = 6
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Talle
        '
        Me.Talle.HeaderText = "Talle"
        Me.Talle.MinimumWidth = 6
        Me.Talle.Name = "Talle"
        Me.Talle.ReadOnly = True
        '
        'TabDetalleVenta
        '
        Me.TabDetalleVenta.Controls.Add(Me.TabPageDetalleVenta)
        Me.TabDetalleVenta.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabDetalleVenta.Location = New System.Drawing.Point(28, 50)
        Me.TabDetalleVenta.Name = "TabDetalleVenta"
        Me.TabDetalleVenta.SelectedIndex = 0
        Me.TabDetalleVenta.Size = New System.Drawing.Size(1029, 403)
        Me.TabDetalleVenta.TabIndex = 57
        '
        'TabPageDetalleVenta
        '
        Me.TabPageDetalleVenta.Controls.Add(Me.dgvListaVentas)
        Me.TabPageDetalleVenta.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageDetalleVenta.Location = New System.Drawing.Point(4, 28)
        Me.TabPageDetalleVenta.Name = "TabPageDetalleVenta"
        Me.TabPageDetalleVenta.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageDetalleVenta.Size = New System.Drawing.Size(1021, 371)
        Me.TabPageDetalleVenta.TabIndex = 0
        Me.TabPageDetalleVenta.Text = "Detalle de Venta"
        Me.TabPageDetalleVenta.UseVisualStyleBackColor = True
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BCancelar.FlatAppearance.BorderSize = 2
        Me.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelar.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BCancelar.ForeColor = System.Drawing.Color.White
        Me.BCancelar.Location = New System.Drawing.Point(894, 484)
        Me.BCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(160, 52)
        Me.BCancelar.TabIndex = 58
        Me.BCancelar.Text = "Volver"
        Me.BCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelar.UseVisualStyleBackColor = False
        '
        'DetalleVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1098, 581)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.TabDetalleVenta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DetalleVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DetalleVenta"
        CType(Me.dgvListaVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabDetalleVenta.ResumeLayout(False)
        Me.TabPageDetalleVenta.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvListaVentas As DataGridView
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Talle As DataGridViewTextBoxColumn
    Friend WithEvents TabDetalleVenta As TabControl
    Friend WithEvents TabPageDetalleVenta As TabPage
    Friend WithEvents BCancelar As Button
End Class
