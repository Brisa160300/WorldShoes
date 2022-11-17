<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportePorVendedores
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.PagPageVentasDiarias = New System.Windows.Forms.TabPage()
        Me.dgvListaVentas = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BBuscarProducto = New System.Windows.Forms.Button()
        Me.CBPeriodo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DTHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DTDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl.SuspendLayout()
        Me.PagPageVentasDiarias.SuspendLayout()
        CType(Me.dgvListaVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.PagPageVentasDiarias)
        Me.TabControl.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.Location = New System.Drawing.Point(24, 176)
        Me.TabControl.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(796, 330)
        Me.TabControl.TabIndex = 100
        '
        'PagPageVentasDiarias
        '
        Me.PagPageVentasDiarias.Controls.Add(Me.dgvListaVentas)
        Me.PagPageVentasDiarias.Location = New System.Drawing.Point(4, 25)
        Me.PagPageVentasDiarias.Margin = New System.Windows.Forms.Padding(2)
        Me.PagPageVentasDiarias.Name = "PagPageVentasDiarias"
        Me.PagPageVentasDiarias.Padding = New System.Windows.Forms.Padding(2)
        Me.PagPageVentasDiarias.Size = New System.Drawing.Size(788, 301)
        Me.PagPageVentasDiarias.TabIndex = 0
        Me.PagPageVentasDiarias.Text = "Ventas"
        Me.PagPageVentasDiarias.UseVisualStyleBackColor = True
        '
        'dgvListaVentas
        '
        Me.dgvListaVentas.AllowUserToAddRows = False
        Me.dgvListaVentas.AllowUserToDeleteRows = False
        Me.dgvListaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListaVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListaVentas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgvListaVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListaVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListaVentas.EnableHeadersVisualStyles = False
        Me.dgvListaVentas.Location = New System.Drawing.Point(2, 2)
        Me.dgvListaVentas.Name = "dgvListaVentas"
        Me.dgvListaVentas.ReadOnly = True
        Me.dgvListaVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.NavajoWhite
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvListaVentas.RowHeadersWidth = 51
        Me.dgvListaVentas.Size = New System.Drawing.Size(784, 297)
        Me.dgvListaVentas.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(839, 309)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 42)
        Me.Button1.TabIndex = 99
        Me.Button1.Text = "Volver"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(353, 28)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(248, 37)
        Me.Label6.TabIndex = 98
        Me.Label6.Text = "Ventas Por Vendedor"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BBuscarProducto)
        Me.GroupBox1.Controls.Add(Me.CBPeriodo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.DTHasta)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DTDesde)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(24, 76)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(793, 81)
        Me.GroupBox1.TabIndex = 101
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar Busqueda"
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
        Me.BBuscarProducto.Location = New System.Drawing.Point(716, 22)
        Me.BBuscarProducto.Name = "BBuscarProducto"
        Me.BBuscarProducto.Size = New System.Drawing.Size(49, 41)
        Me.BBuscarProducto.TabIndex = 93
        Me.BBuscarProducto.UseVisualStyleBackColor = False
        '
        'CBPeriodo
        '
        Me.CBPeriodo.DisplayMember = "Ultima Semana, Ultimos Mes, Ultimo 3 Mese"
        Me.CBPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBPeriodo.FormattingEnabled = True
        Me.CBPeriodo.Items.AddRange(New Object() {"La ultima semana", "El ultimo mes", "Los ultimos 3meses"})
        Me.CBPeriodo.Location = New System.Drawing.Point(160, 37)
        Me.CBPeriodo.Margin = New System.Windows.Forms.Padding(2)
        Me.CBPeriodo.Name = "CBPeriodo"
        Me.CBPeriodo.Size = New System.Drawing.Size(139, 24)
        Me.CBPeriodo.TabIndex = 92
        Me.CBPeriodo.ValueMember = "1,2,3"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 21)
        Me.Label2.TabIndex = 91
        Me.Label2.Text = "Periodo de Tiempo"
        '
        'DTHasta
        '
        Me.DTHasta.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTHasta.Location = New System.Drawing.Point(570, 32)
        Me.DTHasta.Margin = New System.Windows.Forms.Padding(2)
        Me.DTHasta.Name = "DTHasta"
        Me.DTHasta.Size = New System.Drawing.Size(119, 25)
        Me.DTHasta.TabIndex = 81
        Me.DTHasta.Value = New Date(2022, 10, 14, 5, 3, 0, 0)
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(325, 35)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 21)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Desde:"
        '
        'DTDesde
        '
        Me.DTDesde.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTDesde.Location = New System.Drawing.Point(393, 34)
        Me.DTDesde.Margin = New System.Windows.Forms.Padding(2)
        Me.DTDesde.Name = "DTDesde"
        Me.DTDesde.Size = New System.Drawing.Size(105, 25)
        Me.DTDesde.TabIndex = 79
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(509, 35)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 21)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Hasta:"
        '
        'ReportePorVendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(938, 533)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ReportePorVendedores"
        Me.Text = "ReportePorVendedores"
        Me.TabControl.ResumeLayout(False)
        Me.PagPageVentasDiarias.ResumeLayout(False)
        CType(Me.dgvListaVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl As TabControl
    Friend WithEvents PagPageVentasDiarias As TabPage
    Friend WithEvents dgvListaVentas As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BBuscarProducto As Button
    Friend WithEvents CBPeriodo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DTHasta As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents DTDesde As DateTimePicker
    Friend WithEvents Label4 As Label
End Class
