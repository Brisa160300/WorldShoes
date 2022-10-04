<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListarMarcas
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBoxBuscarMarcas = New System.Windows.Forms.GroupBox()
        Me.BEliminarMarca = New System.Windows.Forms.Button()
        Me.BEditarMarca = New System.Windows.Forms.Button()
        Me.BBuscarMarca = New System.Windows.Forms.Button()
        Me.TBBuscarMarca = New System.Windows.Forms.TextBox()
        Me.TabControlListaProductos = New System.Windows.Forms.TabControl()
        Me.TabPageListaProducto = New System.Windows.Forms.TabPage()
        Me.dgvListaMarca = New System.Windows.Forms.DataGridView()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.GroupBoxBuscarMarcas.SuspendLayout()
        Me.TabControlListaProductos.SuspendLayout()
        Me.TabPageListaProducto.SuspendLayout()
        CType(Me.dgvListaMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxBuscarMarcas
        '
        Me.GroupBoxBuscarMarcas.BackColor = System.Drawing.Color.Transparent
        Me.GroupBoxBuscarMarcas.Controls.Add(Me.BEliminarMarca)
        Me.GroupBoxBuscarMarcas.Controls.Add(Me.BEditarMarca)
        Me.GroupBoxBuscarMarcas.Controls.Add(Me.BBuscarMarca)
        Me.GroupBoxBuscarMarcas.Controls.Add(Me.TBBuscarMarca)
        Me.GroupBoxBuscarMarcas.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.GroupBoxBuscarMarcas.ForeColor = System.Drawing.Color.White
        Me.GroupBoxBuscarMarcas.Location = New System.Drawing.Point(39, 50)
        Me.GroupBoxBuscarMarcas.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxBuscarMarcas.Name = "GroupBoxBuscarMarcas"
        Me.GroupBoxBuscarMarcas.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxBuscarMarcas.Size = New System.Drawing.Size(1068, 100)
        Me.GroupBoxBuscarMarcas.TabIndex = 23
        Me.GroupBoxBuscarMarcas.TabStop = False
        Me.GroupBoxBuscarMarcas.Text = "Marcas"
        '
        'BEliminarMarca
        '
        Me.BEliminarMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BEliminarMarca.FlatAppearance.BorderSize = 2
        Me.BEliminarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEliminarMarca.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminarMarca.ForeColor = System.Drawing.Color.White
        Me.BEliminarMarca.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.trash_6_32
        Me.BEliminarMarca.Location = New System.Drawing.Point(988, 30)
        Me.BEliminarMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.BEliminarMarca.Name = "BEliminarMarca"
        Me.BEliminarMarca.Size = New System.Drawing.Size(65, 50)
        Me.BEliminarMarca.TabIndex = 15
        Me.BEliminarMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BEliminarMarca.UseVisualStyleBackColor = False
        '
        'BEditarMarca
        '
        Me.BEditarMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BEditarMarca.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BEditarMarca.FlatAppearance.BorderSize = 2
        Me.BEditarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEditarMarca.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEditarMarca.ForeColor = System.Drawing.Color.White
        Me.BEditarMarca.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.edit_12_32
        Me.BEditarMarca.Location = New System.Drawing.Point(915, 30)
        Me.BEditarMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.BEditarMarca.Name = "BEditarMarca"
        Me.BEditarMarca.Size = New System.Drawing.Size(65, 50)
        Me.BEditarMarca.TabIndex = 16
        Me.BEditarMarca.UseVisualStyleBackColor = False
        '
        'BBuscarMarca
        '
        Me.BBuscarMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BBuscarMarca.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BBuscarMarca.FlatAppearance.BorderSize = 2
        Me.BBuscarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBuscarMarca.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscarMarca.ForeColor = System.Drawing.Color.White
        Me.BBuscarMarca.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.search_3_32
        Me.BBuscarMarca.Location = New System.Drawing.Point(204, 30)
        Me.BBuscarMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.BBuscarMarca.Name = "BBuscarMarca"
        Me.BBuscarMarca.Size = New System.Drawing.Size(65, 50)
        Me.BBuscarMarca.TabIndex = 14
        Me.BBuscarMarca.UseVisualStyleBackColor = False
        '
        'TBBuscarMarca
        '
        Me.TBBuscarMarca.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBBuscarMarca.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TBBuscarMarca.Location = New System.Drawing.Point(23, 43)
        Me.TBBuscarMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.TBBuscarMarca.Name = "TBBuscarMarca"
        Me.TBBuscarMarca.Size = New System.Drawing.Size(173, 30)
        Me.TBBuscarMarca.TabIndex = 6
        '
        'TabControlListaProductos
        '
        Me.TabControlListaProductos.Controls.Add(Me.TabPageListaProducto)
        Me.TabControlListaProductos.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlListaProductos.Location = New System.Drawing.Point(43, 183)
        Me.TabControlListaProductos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlListaProductos.Name = "TabControlListaProductos"
        Me.TabControlListaProductos.SelectedIndex = 0
        Me.TabControlListaProductos.Size = New System.Drawing.Size(1068, 354)
        Me.TabControlListaProductos.TabIndex = 22
        '
        'TabPageListaProducto
        '
        Me.TabPageListaProducto.Controls.Add(Me.dgvListaMarca)
        Me.TabPageListaProducto.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaProducto.ForeColor = System.Drawing.Color.White
        Me.TabPageListaProducto.Location = New System.Drawing.Point(4, 28)
        Me.TabPageListaProducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaProducto.Name = "TabPageListaProducto"
        Me.TabPageListaProducto.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaProducto.Size = New System.Drawing.Size(1060, 322)
        Me.TabPageListaProducto.TabIndex = 0
        Me.TabPageListaProducto.Text = "Lista de Marcas"
        Me.TabPageListaProducto.UseVisualStyleBackColor = True
        '
        'dgvListaMarca
        '
        Me.dgvListaMarca.AllowUserToAddRows = False
        Me.dgvListaMarca.AllowUserToDeleteRows = False
        Me.dgvListaMarca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListaMarca.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListaMarca.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgvListaMarca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListaMarca.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaMarca.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListaMarca.ColumnHeadersHeight = 20
        Me.dgvListaMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvListaMarca.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListaMarca.EnableHeadersVisualStyles = False
        Me.dgvListaMarca.Location = New System.Drawing.Point(3, 2)
        Me.dgvListaMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvListaMarca.Name = "dgvListaMarca"
        Me.dgvListaMarca.ReadOnly = True
        Me.dgvListaMarca.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaMarca.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvListaMarca.RowHeadersWidth = 51
        Me.dgvListaMarca.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvListaMarca.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvListaMarca.Size = New System.Drawing.Size(1054, 318)
        Me.dgvListaMarca.TabIndex = 5
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVolver.ForeColor = System.Drawing.Color.White
        Me.BVolver.Location = New System.Drawing.Point(981, 571)
        Me.BVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(130, 50)
        Me.BVolver.TabIndex = 25
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'ListarMarcas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1149, 656)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.GroupBoxBuscarMarcas)
        Me.Controls.Add(Me.TabControlListaProductos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ListarMarcas"
        Me.Text = "ListarMarcas"
        Me.GroupBoxBuscarMarcas.ResumeLayout(False)
        Me.GroupBoxBuscarMarcas.PerformLayout()
        Me.TabControlListaProductos.ResumeLayout(False)
        Me.TabPageListaProducto.ResumeLayout(False)
        CType(Me.dgvListaMarca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxBuscarMarcas As GroupBox
    Friend WithEvents BBuscarMarca As Button
    Friend WithEvents TBBuscarMarca As TextBox
    Friend WithEvents TabControlListaProductos As TabControl
    Friend WithEvents TabPageListaProducto As TabPage
    Friend WithEvents dgvListaMarca As DataGridView
    Friend WithEvents BVolver As Button
    Friend WithEvents BEliminarMarca As Button
    Friend WithEvents BEditarMarca As Button
End Class
