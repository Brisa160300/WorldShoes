<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListarProductos
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PBListaClientes = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGridViewListarCliente = New System.Windows.Forms.DataGridView()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.LTituloListarProductos = New System.Windows.Forms.Label()
        Me.Colum_Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_DNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_FechaNaci = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_Localidad = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.PBListaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewListarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(527, 131)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(158, 22)
        Me.TextBox1.TabIndex = 15
        '
        'PBListaClientes
        '
        Me.PBListaClientes.BackColor = System.Drawing.Color.Transparent
        Me.PBListaClientes.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_mujeres_vista_lateral_del_zapato_filled_50
        Me.PBListaClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBListaClientes.Location = New System.Drawing.Point(220, 12)
        Me.PBListaClientes.Name = "PBListaClientes"
        Me.PBListaClientes.Size = New System.Drawing.Size(83, 69)
        Me.PBListaClientes.TabIndex = 14
        Me.PBListaClientes.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridViewListarCliente)
        Me.Panel1.Location = New System.Drawing.Point(1, 207)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(860, 291)
        Me.Panel1.TabIndex = 13
        '
        'DataGridViewListarCliente
        '
        Me.DataGridViewListarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewListarCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Colum_Nombre, Me.Colum_Apellido, Me.Colum_DNI, Me.Colum_FechaNaci, Me.Colum_Telefono, Me.Colum_Localidad})
        Me.DataGridViewListarCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewListarCliente.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewListarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewListarCliente.Name = "DataGridViewListarCliente"
        Me.DataGridViewListarCliente.RowHeadersWidth = 51
        Me.DataGridViewListarCliente.Size = New System.Drawing.Size(860, 291)
        Me.DataGridViewListarCliente.TabIndex = 5
        '
        'BBuscar
        '
        Me.BBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.8!, System.Drawing.FontStyle.Bold)
        Me.BBuscar.Location = New System.Drawing.Point(716, 113)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(107, 57)
        Me.BBuscar.TabIndex = 10
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'LTituloListarProductos
        '
        Me.LTituloListarProductos.AutoSize = True
        Me.LTituloListarProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.8!, System.Drawing.FontStyle.Bold)
        Me.LTituloListarProductos.ForeColor = System.Drawing.Color.White
        Me.LTituloListarProductos.Location = New System.Drawing.Point(43, 34)
        Me.LTituloListarProductos.Name = "LTituloListarProductos"
        Me.LTituloListarProductos.Size = New System.Drawing.Size(171, 37)
        Me.LTituloListarProductos.TabIndex = 9
        Me.LTituloListarProductos.Text = "Productos"
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
        'Colum_Localidad
        '
        Me.Colum_Localidad.HeaderText = "Imagen"
        Me.Colum_Localidad.MinimumWidth = 6
        Me.Colum_Localidad.Name = "Colum_Localidad"
        Me.Colum_Localidad.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Colum_Localidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Colum_Localidad.Width = 125
        '
        'ListarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ClientSize = New System.Drawing.Size(862, 521)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PBListaClientes)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BBuscar)
        Me.Controls.Add(Me.LTituloListarProductos)
        Me.Name = "ListarProductos"
        Me.Text = "ListarProductos"
        CType(Me.PBListaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGridViewListarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PBListaClientes As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridViewListarCliente As DataGridView
    Friend WithEvents BBuscar As Button
    Friend WithEvents LTituloListarProductos As Label
    Friend WithEvents Colum_Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Colum_Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Colum_DNI As DataGridViewTextBoxColumn
    Friend WithEvents Colum_FechaNaci As DataGridViewTextBoxColumn
    Friend WithEvents Colum_Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Colum_Localidad As DataGridViewImageColumn
End Class
