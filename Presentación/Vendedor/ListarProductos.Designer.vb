<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListarProductos
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
        Me.DataGridViewListaProductos = New System.Windows.Forms.DataGridView()
        Me.Colum_Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_DNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_FechaNaci = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControlListaProductos = New System.Windows.Forms.TabControl()
        Me.TabPageListaProducto = New System.Windows.Forms.TabPage()
        Me.GroupBoxBuscarProducto = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TBGestionCategoria = New System.Windows.Forms.TextBox()
        CType(Me.DataGridViewListaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlListaProductos.SuspendLayout()
        Me.TabPageListaProducto.SuspendLayout()
        Me.GroupBoxBuscarProducto.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewListaProductos
        '
        Me.DataGridViewListaProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.DataGridViewListaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewListaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewListaProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewListaProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Colum_Nombre, Me.Colum_Apellido, Me.Colum_DNI, Me.Colum_FechaNaci, Me.Colum_Telefono})
        Me.DataGridViewListaProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewListaProductos.EnableHeadersVisualStyles = False
        Me.DataGridViewListaProductos.Location = New System.Drawing.Point(3, 2)
        Me.DataGridViewListaProductos.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewListaProductos.Name = "DataGridViewListaProductos"
        Me.DataGridViewListaProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DataGridViewListaProductos.RowHeadersWidth = 51
        Me.DataGridViewListaProductos.Size = New System.Drawing.Size(1054, 386)
        Me.DataGridViewListaProductos.TabIndex = 5
        '
        'Colum_Nombre
        '
        Me.Colum_Nombre.HeaderText = "Codigo"
        Me.Colum_Nombre.MinimumWidth = 6
        Me.Colum_Nombre.Name = "Colum_Nombre"
        Me.Colum_Nombre.Width = 125
        '
        'Colum_Apellido
        '
        Me.Colum_Apellido.HeaderText = "Nombre"
        Me.Colum_Apellido.MinimumWidth = 6
        Me.Colum_Apellido.Name = "Colum_Apellido"
        Me.Colum_Apellido.Width = 125
        '
        'Colum_DNI
        '
        Me.Colum_DNI.HeaderText = "Categoria"
        Me.Colum_DNI.MinimumWidth = 6
        Me.Colum_DNI.Name = "Colum_DNI"
        Me.Colum_DNI.Width = 125
        '
        'Colum_FechaNaci
        '
        Me.Colum_FechaNaci.HeaderText = "Stock"
        Me.Colum_FechaNaci.MinimumWidth = 6
        Me.Colum_FechaNaci.Name = "Colum_FechaNaci"
        Me.Colum_FechaNaci.Width = 125
        '
        'Colum_Telefono
        '
        Me.Colum_Telefono.HeaderText = "Precio"
        Me.Colum_Telefono.MinimumWidth = 6
        Me.Colum_Telefono.Name = "Colum_Telefono"
        Me.Colum_Telefono.Width = 125
        '
        'TabControlListaProductos
        '
        Me.TabControlListaProductos.Controls.Add(Me.TabPageListaProducto)
        Me.TabControlListaProductos.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlListaProductos.Location = New System.Drawing.Point(37, 183)
        Me.TabControlListaProductos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlListaProductos.Name = "TabControlListaProductos"
        Me.TabControlListaProductos.SelectedIndex = 0
        Me.TabControlListaProductos.Size = New System.Drawing.Size(1068, 422)
        Me.TabControlListaProductos.TabIndex = 16
        '
        'TabPageListaProducto
        '
        Me.TabPageListaProducto.Controls.Add(Me.DataGridViewListaProductos)
        Me.TabPageListaProducto.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaProducto.ForeColor = System.Drawing.Color.White
        Me.TabPageListaProducto.Location = New System.Drawing.Point(4, 28)
        Me.TabPageListaProducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaProducto.Name = "TabPageListaProducto"
        Me.TabPageListaProducto.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaProducto.Size = New System.Drawing.Size(1060, 390)
        Me.TabPageListaProducto.TabIndex = 0
        Me.TabPageListaProducto.Text = "Lista de Producto"
        Me.TabPageListaProducto.UseVisualStyleBackColor = True
        '
        'GroupBoxBuscarProducto
        '
        Me.GroupBoxBuscarProducto.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxBuscarProducto.Controls.Add(Me.Button1)
        Me.GroupBoxBuscarProducto.Controls.Add(Me.TBGestionCategoria)
        Me.GroupBoxBuscarProducto.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.GroupBoxBuscarProducto.ForeColor = System.Drawing.Color.White
        Me.GroupBoxBuscarProducto.Location = New System.Drawing.Point(37, 50)
        Me.GroupBoxBuscarProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxBuscarProducto.Name = "GroupBoxBuscarProducto"
        Me.GroupBoxBuscarProducto.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxBuscarProducto.Size = New System.Drawing.Size(1068, 100)
        Me.GroupBoxBuscarProducto.TabIndex = 17
        Me.GroupBoxBuscarProducto.TabStop = False
        Me.GroupBoxBuscarProducto.Text = "Productos"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.search_3_32
        Me.Button1.Location = New System.Drawing.Point(204, 37)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(66, 43)
        Me.Button1.TabIndex = 14
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TBGestionCategoria
        '
        Me.TBGestionCategoria.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBGestionCategoria.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TBGestionCategoria.Location = New System.Drawing.Point(23, 43)
        Me.TBGestionCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.TBGestionCategoria.Name = "TBGestionCategoria"
        Me.TBGestionCategoria.Size = New System.Drawing.Size(173, 30)
        Me.TBGestionCategoria.TabIndex = 6
        Me.TBGestionCategoria.Text = "Búsqueda"
        '
        'ListarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 656)
        Me.Controls.Add(Me.GroupBoxBuscarProducto)
        Me.Controls.Add(Me.TabControlListaProductos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ListarProductos"
        Me.Text = "ListarProductos"
        CType(Me.DataGridViewListaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlListaProductos.ResumeLayout(False)
        Me.TabPageListaProducto.ResumeLayout(False)
        Me.GroupBoxBuscarProducto.ResumeLayout(False)
        Me.GroupBoxBuscarProducto.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewListaProductos As DataGridView
    Friend WithEvents TabControlListaProductos As TabControl
    Friend WithEvents TabPageListaProducto As TabPage
    Friend WithEvents GroupBoxBuscarProducto As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TBGestionCategoria As TextBox
    Friend WithEvents Colum_Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Colum_Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Colum_DNI As DataGridViewTextBoxColumn
    Friend WithEvents Colum_FechaNaci As DataGridViewTextBoxColumn
    Friend WithEvents Colum_Telefono As DataGridViewTextBoxColumn
End Class
