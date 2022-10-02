<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarProductos
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
        Me.TabListaCategorias = New System.Windows.Forms.TabControl()
        Me.TabPageListaTalle = New System.Windows.Forms.TabPage()
        Me.DataGridViewRegistroTalle = New System.Windows.Forms.DataGridView()
        Me.GroupBoxGestionProductos = New System.Windows.Forms.GroupBox()
        Me.BEliminarProducto = New System.Windows.Forms.Button()
        Me.BModificarProducto = New System.Windows.Forms.Button()
        Me.BBuscarProducto = New System.Windows.Forms.Button()
        Me.TBGestionProductos = New System.Windows.Forms.TextBox()
        Me.TabListaCategorias.SuspendLayout()
        Me.TabPageListaTalle.SuspendLayout()
        CType(Me.DataGridViewRegistroTalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxGestionProductos.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabListaCategorias
        '
        Me.TabListaCategorias.Controls.Add(Me.TabPageListaTalle)
        Me.TabListaCategorias.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabListaCategorias.Location = New System.Drawing.Point(29, 209)
        Me.TabListaCategorias.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabListaCategorias.Name = "TabListaCategorias"
        Me.TabListaCategorias.SelectedIndex = 0
        Me.TabListaCategorias.Size = New System.Drawing.Size(1055, 396)
        Me.TabListaCategorias.TabIndex = 20
        '
        'TabPageListaTalle
        '
        Me.TabPageListaTalle.Controls.Add(Me.DataGridViewRegistroTalle)
        Me.TabPageListaTalle.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaTalle.ForeColor = System.Drawing.Color.White
        Me.TabPageListaTalle.Location = New System.Drawing.Point(4, 28)
        Me.TabPageListaTalle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaTalle.Name = "TabPageListaTalle"
        Me.TabPageListaTalle.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaTalle.Size = New System.Drawing.Size(1047, 364)
        Me.TabPageListaTalle.TabIndex = 0
        Me.TabPageListaTalle.Text = "Lista de Productos"
        Me.TabPageListaTalle.UseVisualStyleBackColor = True
        '
        'DataGridViewRegistroTalle
        '
        Me.DataGridViewRegistroTalle.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.DataGridViewRegistroTalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewRegistroTalle.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewRegistroTalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewRegistroTalle.Location = New System.Drawing.Point(3, 2)
        Me.DataGridViewRegistroTalle.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewRegistroTalle.Name = "DataGridViewRegistroTalle"
        Me.DataGridViewRegistroTalle.RowHeadersWidth = 51
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewRegistroTalle.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewRegistroTalle.Size = New System.Drawing.Size(1041, 360)
        Me.DataGridViewRegistroTalle.TabIndex = 2
        '
        'GroupBoxGestionProductos
        '
        Me.GroupBoxGestionProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(21, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBoxGestionProductos.Controls.Add(Me.BEliminarProducto)
        Me.GroupBoxGestionProductos.Controls.Add(Me.BModificarProducto)
        Me.GroupBoxGestionProductos.Controls.Add(Me.BBuscarProducto)
        Me.GroupBoxGestionProductos.Controls.Add(Me.TBGestionProductos)
        Me.GroupBoxGestionProductos.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.GroupBoxGestionProductos.ForeColor = System.Drawing.Color.White
        Me.GroupBoxGestionProductos.Location = New System.Drawing.Point(29, 50)
        Me.GroupBoxGestionProductos.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxGestionProductos.Name = "GroupBoxGestionProductos"
        Me.GroupBoxGestionProductos.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxGestionProductos.Size = New System.Drawing.Size(1051, 117)
        Me.GroupBoxGestionProductos.TabIndex = 21
        Me.GroupBoxGestionProductos.TabStop = False
        Me.GroupBoxGestionProductos.Text = "Gestión de Productos"
        '
        'BEliminarProducto
        '
        Me.BEliminarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BEliminarProducto.FlatAppearance.BorderSize = 2
        Me.BEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEliminarProducto.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminarProducto.ForeColor = System.Drawing.Color.White
        Me.BEliminarProducto.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.trash_6_32
        Me.BEliminarProducto.Location = New System.Drawing.Point(966, 33)
        Me.BEliminarProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.BEliminarProducto.Name = "BEliminarProducto"
        Me.BEliminarProducto.Size = New System.Drawing.Size(65, 50)
        Me.BEliminarProducto.TabIndex = 12
        Me.BEliminarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BEliminarProducto.UseVisualStyleBackColor = False
        '
        'BModificarProducto
        '
        Me.BModificarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BModificarProducto.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BModificarProducto.FlatAppearance.BorderSize = 2
        Me.BModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModificarProducto.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BModificarProducto.ForeColor = System.Drawing.Color.White
        Me.BModificarProducto.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.edit_12_32
        Me.BModificarProducto.Location = New System.Drawing.Point(893, 33)
        Me.BModificarProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.BModificarProducto.Name = "BModificarProducto"
        Me.BModificarProducto.Size = New System.Drawing.Size(65, 50)
        Me.BModificarProducto.TabIndex = 13
        Me.BModificarProducto.UseVisualStyleBackColor = False
        '
        'BBuscarProducto
        '
        Me.BBuscarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BBuscarProducto.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BBuscarProducto.FlatAppearance.BorderSize = 2
        Me.BBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBuscarProducto.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscarProducto.ForeColor = System.Drawing.Color.White
        Me.BBuscarProducto.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.search_3_32
        Me.BBuscarProducto.Location = New System.Drawing.Point(208, 31)
        Me.BBuscarProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.BBuscarProducto.Name = "BBuscarProducto"
        Me.BBuscarProducto.Size = New System.Drawing.Size(65, 50)
        Me.BBuscarProducto.TabIndex = 14
        Me.BBuscarProducto.UseVisualStyleBackColor = False
        '
        'TBGestionProductos
        '
        Me.TBGestionProductos.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBGestionProductos.Location = New System.Drawing.Point(27, 43)
        Me.TBGestionProductos.Margin = New System.Windows.Forms.Padding(4)
        Me.TBGestionProductos.Name = "TBGestionProductos"
        Me.TBGestionProductos.Size = New System.Drawing.Size(173, 30)
        Me.TBGestionProductos.TabIndex = 6
        '
        'GestionarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 656)
        Me.Controls.Add(Me.GroupBoxGestionProductos)
        Me.Controls.Add(Me.TabListaCategorias)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "GestionarProductos"
        Me.Text = "GestionarProductos"
        Me.TabListaCategorias.ResumeLayout(False)
        Me.TabPageListaTalle.ResumeLayout(False)
        CType(Me.DataGridViewRegistroTalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxGestionProductos.ResumeLayout(False)
        Me.GroupBoxGestionProductos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabListaCategorias As TabControl
    Friend WithEvents TabPageListaTalle As TabPage
    Friend WithEvents DataGridViewRegistroTalle As DataGridView
    Friend WithEvents GroupBoxGestionProductos As GroupBox
    Friend WithEvents BEliminarProducto As Button
    Friend WithEvents BModificarProducto As Button
    Friend WithEvents BBuscarProducto As Button
    Friend WithEvents TBGestionProductos As TextBox
End Class
