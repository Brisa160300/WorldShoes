<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AñadirProducto
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
        Me.DataGridViewRegistroCategorias = New System.Windows.Forms.DataGridView()
        Me.TabControlListaProductos = New System.Windows.Forms.TabControl()
        Me.TabPageListaProducto = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxCategoria = New System.Windows.Forms.ComboBox()
        Me.BAñadirProducto = New System.Windows.Forms.Button()
        Me.ComboBoxMarca = New System.Windows.Forms.ComboBox()
        Me.TBCodigoProducto = New System.Windows.Forms.TextBox()
        Me.ComboBoxTalle = New System.Windows.Forms.ComboBox()
        Me.LCodigoProducto = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBNombreProducto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBPrecio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBStock = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BCancelProducto = New System.Windows.Forms.Button()
        Me.LMarca = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridViewRegistroCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlListaProductos.SuspendLayout()
        Me.TabPageListaProducto.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewRegistroCategorias
        '
        Me.DataGridViewRegistroCategorias.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.DataGridViewRegistroCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewRegistroCategorias.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewRegistroCategorias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewRegistroCategorias.Location = New System.Drawing.Point(3, 3)
        Me.DataGridViewRegistroCategorias.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewRegistroCategorias.Name = "DataGridViewRegistroCategorias"
        Me.DataGridViewRegistroCategorias.RowHeadersWidth = 51
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewRegistroCategorias.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewRegistroCategorias.Size = New System.Drawing.Size(663, 483)
        Me.DataGridViewRegistroCategorias.TabIndex = 2
        '
        'TabControlListaProductos
        '
        Me.TabControlListaProductos.Controls.Add(Me.TabPageListaProducto)
        Me.TabControlListaProductos.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlListaProductos.Location = New System.Drawing.Point(424, 76)
        Me.TabControlListaProductos.Name = "TabControlListaProductos"
        Me.TabControlListaProductos.SelectedIndex = 0
        Me.TabControlListaProductos.Size = New System.Drawing.Size(677, 521)
        Me.TabControlListaProductos.TabIndex = 14
        '
        'TabPageListaProducto
        '
        Me.TabPageListaProducto.Controls.Add(Me.DataGridViewRegistroCategorias)
        Me.TabPageListaProducto.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaProducto.ForeColor = System.Drawing.Color.White
        Me.TabPageListaProducto.Location = New System.Drawing.Point(4, 28)
        Me.TabPageListaProducto.Name = "TabPageListaProducto"
        Me.TabPageListaProducto.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageListaProducto.Size = New System.Drawing.Size(669, 489)
        Me.TabPageListaProducto.TabIndex = 0
        Me.TabPageListaProducto.Text = "Lista de Producto"
        Me.TabPageListaProducto.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(49, 49)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 33)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Añadir Producto: "
        '
        'ComboBoxCategoria
        '
        Me.ComboBoxCategoria.FormattingEnabled = True
        Me.ComboBoxCategoria.Location = New System.Drawing.Point(132, 121)
        Me.ComboBoxCategoria.Name = "ComboBoxCategoria"
        Me.ComboBoxCategoria.Size = New System.Drawing.Size(174, 24)
        Me.ComboBoxCategoria.TabIndex = 15
        '
        'BAñadirProducto
        '
        Me.BAñadirProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BAñadirProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAñadirProducto.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.BAñadirProducto.ForeColor = System.Drawing.Color.White
        Me.BAñadirProducto.Location = New System.Drawing.Point(46, 411)
        Me.BAñadirProducto.Name = "BAñadirProducto"
        Me.BAñadirProducto.Size = New System.Drawing.Size(120, 36)
        Me.BAñadirProducto.TabIndex = 2
        Me.BAñadirProducto.Text = "Añadir"
        Me.BAñadirProducto.UseVisualStyleBackColor = False
        '
        'ComboBoxMarca
        '
        Me.ComboBoxMarca.FormattingEnabled = True
        Me.ComboBoxMarca.Location = New System.Drawing.Point(132, 319)
        Me.ComboBoxMarca.Name = "ComboBoxMarca"
        Me.ComboBoxMarca.Size = New System.Drawing.Size(174, 24)
        Me.ComboBoxMarca.TabIndex = 14
        '
        'TBCodigoProducto
        '
        Me.TBCodigoProducto.Location = New System.Drawing.Point(132, 23)
        Me.TBCodigoProducto.Name = "TBCodigoProducto"
        Me.TBCodigoProducto.Size = New System.Drawing.Size(174, 22)
        Me.TBCodigoProducto.TabIndex = 12
        '
        'ComboBoxTalle
        '
        Me.ComboBoxTalle.FormattingEnabled = True
        Me.ComboBoxTalle.Location = New System.Drawing.Point(132, 271)
        Me.ComboBoxTalle.Name = "ComboBoxTalle"
        Me.ComboBoxTalle.Size = New System.Drawing.Size(174, 24)
        Me.ComboBoxTalle.TabIndex = 11
        '
        'LCodigoProducto
        '
        Me.LCodigoProducto.AutoSize = True
        Me.LCodigoProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.LCodigoProducto.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LCodigoProducto.ForeColor = System.Drawing.Color.White
        Me.LCodigoProducto.Location = New System.Drawing.Point(22, 30)
        Me.LCodigoProducto.Name = "LCodigoProducto"
        Me.LCodigoProducto.Size = New System.Drawing.Size(78, 22)
        Me.LCodigoProducto.TabIndex = 11
        Me.LCodigoProducto.Text = "Código:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(22, 279)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 22)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Talle: "
        '
        'TBNombreProducto
        '
        Me.TBNombreProducto.Location = New System.Drawing.Point(132, 73)
        Me.TBNombreProducto.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.TBNombreProducto.Name = "TBNombreProducto"
        Me.TBNombreProducto.Size = New System.Drawing.Size(174, 22)
        Me.TBNombreProducto.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 22)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(22, 230)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 22)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Precio: "
        '
        'TBPrecio
        '
        Me.TBPrecio.Location = New System.Drawing.Point(132, 223)
        Me.TBPrecio.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.TBPrecio.Name = "TBPrecio"
        Me.TBPrecio.Size = New System.Drawing.Size(174, 22)
        Me.TBPrecio.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(22, 179)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 22)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Stock:"
        '
        'TBStock
        '
        Me.TBStock.Location = New System.Drawing.Point(132, 172)
        Me.TBStock.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.TBStock.Name = "TBStock"
        Me.TBStock.Size = New System.Drawing.Size(174, 22)
        Me.TBStock.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel2.Controls.Add(Me.ComboBoxCategoria)
        Me.Panel2.Controls.Add(Me.BAñadirProducto)
        Me.Panel2.Controls.Add(Me.BCancelProducto)
        Me.Panel2.Controls.Add(Me.ComboBoxMarca)
        Me.Panel2.Controls.Add(Me.LMarca)
        Me.Panel2.Controls.Add(Me.TBCodigoProducto)
        Me.Panel2.Controls.Add(Me.ComboBoxTalle)
        Me.Panel2.Controls.Add(Me.LCodigoProducto)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.TBNombreProducto)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.TBPrecio)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TBStock)
        Me.Panel2.Location = New System.Drawing.Point(55, 127)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(338, 470)
        Me.Panel2.TabIndex = 13
        '
        'BCancelProducto
        '
        Me.BCancelProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BCancelProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelProducto.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.BCancelProducto.ForeColor = System.Drawing.Color.White
        Me.BCancelProducto.Location = New System.Drawing.Point(185, 411)
        Me.BCancelProducto.Name = "BCancelProducto"
        Me.BCancelProducto.Size = New System.Drawing.Size(121, 36)
        Me.BCancelProducto.TabIndex = 3
        Me.BCancelProducto.Text = "Cancelar"
        Me.BCancelProducto.UseVisualStyleBackColor = False
        '
        'LMarca
        '
        Me.LMarca.AutoSize = True
        Me.LMarca.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LMarca.ForeColor = System.Drawing.Color.White
        Me.LMarca.Location = New System.Drawing.Point(24, 333)
        Me.LMarca.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LMarca.Name = "LMarca"
        Me.LMarca.Size = New System.Drawing.Size(78, 22)
        Me.LMarca.TabIndex = 13
        Me.LMarca.Text = "Marca: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(21, 129)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 22)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Categoría: "
        '
        'AñadirProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 656)
        Me.Controls.Add(Me.TabControlListaProductos)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AñadirProducto"
        Me.Text = "AñadirP"
        CType(Me.DataGridViewRegistroCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlListaProductos.ResumeLayout(False)
        Me.TabPageListaProducto.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridViewRegistroCategorias As DataGridView
    Friend WithEvents TabControlListaProductos As TabControl
    Friend WithEvents TabPageListaProducto As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxCategoria As ComboBox
    Friend WithEvents BAñadirProducto As Button
    Friend WithEvents ComboBoxMarca As ComboBox
    Friend WithEvents TBCodigoProducto As TextBox
    Friend WithEvents ComboBoxTalle As ComboBox
    Friend WithEvents LCodigoProducto As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TBNombreProducto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TBPrecio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBStock As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BCancelProducto As Button
    Friend WithEvents LMarca As Label
    Friend WithEvents Label3 As Label
End Class
