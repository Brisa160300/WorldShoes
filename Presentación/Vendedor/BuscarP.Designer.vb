<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BuscarP
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
        Me.TabControlListaProductos = New System.Windows.Forms.TabControl()
        Me.TabPageListaProducto = New System.Windows.Forms.TabPage()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BSeleccionar = New System.Windows.Forms.Button()
        Me.dgvListaProductos = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBoxProductos = New System.Windows.Forms.GroupBox()
        Me.LCatPro = New System.Windows.Forms.Label()
        Me.LMarcas = New System.Windows.Forms.Label()
        Me.CBCatProducto = New System.Windows.Forms.ComboBox()
        Me.BBuscarProducto = New System.Windows.Forms.Button()
        Me.CBMarcas = New System.Windows.Forms.ComboBox()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControlListaProductos.SuspendLayout()
        Me.TabPageListaProducto.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvListaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBoxProductos.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlListaProductos
        '
        Me.TabControlListaProductos.Controls.Add(Me.TabPageListaProducto)
        Me.TabControlListaProductos.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlListaProductos.Location = New System.Drawing.Point(0, 14)
        Me.TabControlListaProductos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControlListaProductos.Name = "TabControlListaProductos"
        Me.TabControlListaProductos.SelectedIndex = 0
        Me.TabControlListaProductos.Size = New System.Drawing.Size(722, 374)
        Me.TabControlListaProductos.TabIndex = 18
        '
        'TabPageListaProducto
        '
        Me.TabPageListaProducto.Controls.Add(Me.Panel3)
        Me.TabPageListaProducto.Controls.Add(Me.dgvListaProductos)
        Me.TabPageListaProducto.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaProducto.ForeColor = System.Drawing.Color.White
        Me.TabPageListaProducto.Location = New System.Drawing.Point(4, 25)
        Me.TabPageListaProducto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPageListaProducto.Name = "TabPageListaProducto"
        Me.TabPageListaProducto.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPageListaProducto.Size = New System.Drawing.Size(714, 345)
        Me.TabPageListaProducto.TabIndex = 0
        Me.TabPageListaProducto.Text = "Lista de Productos"
        Me.TabPageListaProducto.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Panel3.Controls.Add(Me.BCancelar)
        Me.Panel3.Controls.Add(Me.BSeleccionar)
        Me.Panel3.Location = New System.Drawing.Point(2, 274)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(710, 69)
        Me.Panel3.TabIndex = 9
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BCancelar.FlatAppearance.BorderSize = 2
        Me.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelar.Font = New System.Drawing.Font("Britannic Bold", 11.0!)
        Me.BCancelar.ForeColor = System.Drawing.Color.White
        Me.BCancelar.Location = New System.Drawing.Point(363, 17)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(97, 42)
        Me.BCancelar.TabIndex = 34
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelar.UseVisualStyleBackColor = False
        '
        'BSeleccionar
        '
        Me.BSeleccionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BSeleccionar.FlatAppearance.BorderSize = 2
        Me.BSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BSeleccionar.Font = New System.Drawing.Font("Britannic Bold", 11.0!)
        Me.BSeleccionar.ForeColor = System.Drawing.Color.White
        Me.BSeleccionar.Location = New System.Drawing.Point(260, 17)
        Me.BSeleccionar.Name = "BSeleccionar"
        Me.BSeleccionar.Size = New System.Drawing.Size(97, 42)
        Me.BSeleccionar.TabIndex = 35
        Me.BSeleccionar.Text = "Seleccionar"
        Me.BSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BSeleccionar.UseVisualStyleBackColor = False
        '
        'dgvListaProductos
        '
        Me.dgvListaProductos.AllowUserToDeleteRows = False
        Me.dgvListaProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListaProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.dgvListaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvListaProductos.ColumnHeadersHeight = 20
        Me.dgvListaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvListaProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvListaProductos.EnableHeadersVisualStyles = False
        Me.dgvListaProductos.Location = New System.Drawing.Point(2, 2)
        Me.dgvListaProductos.Name = "dgvListaProductos"
        Me.dgvListaProductos.ReadOnly = True
        Me.dgvListaProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.NavajoWhite
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvListaProductos.RowHeadersWidth = 51
        Me.dgvListaProductos.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvListaProductos.Size = New System.Drawing.Size(710, 341)
        Me.dgvListaProductos.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBoxProductos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(722, 100)
        Me.Panel1.TabIndex = 36
        '
        'GroupBoxProductos
        '
        Me.GroupBoxProductos.Controls.Add(Me.LCatPro)
        Me.GroupBoxProductos.Controls.Add(Me.LMarcas)
        Me.GroupBoxProductos.Controls.Add(Me.CBCatProducto)
        Me.GroupBoxProductos.Controls.Add(Me.BBuscarProducto)
        Me.GroupBoxProductos.Controls.Add(Me.CBMarcas)
        Me.GroupBoxProductos.Controls.Add(Me.TBBuscar)
        Me.GroupBoxProductos.Font = New System.Drawing.Font("Britannic Bold", 18.0!)
        Me.GroupBoxProductos.ForeColor = System.Drawing.Color.White
        Me.GroupBoxProductos.Location = New System.Drawing.Point(8, 19)
        Me.GroupBoxProductos.Name = "GroupBoxProductos"
        Me.GroupBoxProductos.Size = New System.Drawing.Size(702, 81)
        Me.GroupBoxProductos.TabIndex = 12
        Me.GroupBoxProductos.TabStop = False
        Me.GroupBoxProductos.Text = "Productos"
        '
        'LCatPro
        '
        Me.LCatPro.AutoSize = True
        Me.LCatPro.Font = New System.Drawing.Font("Britannic Bold", 11.0!)
        Me.LCatPro.ForeColor = System.Drawing.Color.White
        Me.LCatPro.Location = New System.Drawing.Point(347, 19)
        Me.LCatPro.Name = "LCatPro"
        Me.LCatPro.Size = New System.Drawing.Size(82, 16)
        Me.LCatPro.TabIndex = 35
        Me.LCatPro.Text = "Categorias:"
        '
        'LMarcas
        '
        Me.LMarcas.AutoSize = True
        Me.LMarcas.Font = New System.Drawing.Font("Britannic Bold", 11.0!)
        Me.LMarcas.ForeColor = System.Drawing.Color.White
        Me.LMarcas.Location = New System.Drawing.Point(218, 19)
        Me.LMarcas.Name = "LMarcas"
        Me.LMarcas.Size = New System.Drawing.Size(59, 16)
        Me.LMarcas.TabIndex = 34
        Me.LMarcas.Text = "Marcas:"
        '
        'CBCatProducto
        '
        Me.CBCatProducto.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.CBCatProducto.FormattingEnabled = True
        Me.CBCatProducto.Location = New System.Drawing.Point(350, 37)
        Me.CBCatProducto.Margin = New System.Windows.Forms.Padding(4, 2, 2, 2)
        Me.CBCatProducto.Name = "CBCatProducto"
        Me.CBCatProducto.Size = New System.Drawing.Size(113, 25)
        Me.CBCatProducto.TabIndex = 32
        Me.CBCatProducto.Text = "Categorias"
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
        Me.BBuscarProducto.Location = New System.Drawing.Point(647, 29)
        Me.BBuscarProducto.Name = "BBuscarProducto"
        Me.BBuscarProducto.Size = New System.Drawing.Size(41, 38)
        Me.BBuscarProducto.TabIndex = 31
        Me.BBuscarProducto.UseVisualStyleBackColor = False
        '
        'CBMarcas
        '
        Me.CBMarcas.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.CBMarcas.FormattingEnabled = True
        Me.CBMarcas.Location = New System.Drawing.Point(221, 37)
        Me.CBMarcas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CBMarcas.Name = "CBMarcas"
        Me.CBMarcas.Size = New System.Drawing.Size(113, 25)
        Me.CBMarcas.TabIndex = 33
        Me.CBMarcas.Text = "Marcas"
        '
        'TBBuscar
        '
        Me.TBBuscar.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBBuscar.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TBBuscar.Location = New System.Drawing.Point(512, 37)
        Me.TBBuscar.Name = "TBBuscar"
        Me.TBBuscar.Size = New System.Drawing.Size(131, 25)
        Me.TBBuscar.TabIndex = 30
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel2.Controls.Add(Me.TabControlListaProductos)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(722, 388)
        Me.Panel2.TabIndex = 37
        '
        'BuscarP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(722, 488)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "BuscarP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BuscarP"
        Me.TabControlListaProductos.ResumeLayout(False)
        Me.TabPageListaProducto.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvListaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBoxProductos.ResumeLayout(False)
        Me.GroupBoxProductos.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlListaProductos As TabControl
    Friend WithEvents TabPageListaProducto As TabPage
    Friend WithEvents BCancelar As Button
    Friend WithEvents BSeleccionar As Button
    Public WithEvents dgvListaProductos As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GroupBoxProductos As GroupBox
    Friend WithEvents CBCatProducto As ComboBox
    Friend WithEvents BBuscarProducto As Button
    Friend WithEvents CBMarcas As ComboBox
    Friend WithEvents TBBuscar As TextBox
    Friend WithEvents LCatPro As Label
    Friend WithEvents LMarcas As Label
End Class
