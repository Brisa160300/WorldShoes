<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductosMasVendidos
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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.PagPageVentasDiarias = New System.Windows.Forms.TabPage()
        Me.dgvVentasProductos = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ChartGrafico = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabControl.SuspendLayout()
        Me.PagPageVentasDiarias.SuspendLayout()
        CType(Me.dgvVentasProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartGrafico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.PagPageVentasDiarias)
        Me.TabControl.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.Location = New System.Drawing.Point(57, 329)
        Me.TabControl.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(796, 124)
        Me.TabControl.TabIndex = 99
        '
        'PagPageVentasDiarias
        '
        Me.PagPageVentasDiarias.Controls.Add(Me.dgvVentasProductos)
        Me.PagPageVentasDiarias.Location = New System.Drawing.Point(4, 25)
        Me.PagPageVentasDiarias.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PagPageVentasDiarias.Name = "PagPageVentasDiarias"
        Me.PagPageVentasDiarias.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PagPageVentasDiarias.Size = New System.Drawing.Size(788, 95)
        Me.PagPageVentasDiarias.TabIndex = 0
        Me.PagPageVentasDiarias.Text = "TOP"
        Me.PagPageVentasDiarias.UseVisualStyleBackColor = True
        '
        'dgvVentasProductos
        '
        Me.dgvVentasProductos.AllowUserToAddRows = False
        Me.dgvVentasProductos.AllowUserToDeleteRows = False
        Me.dgvVentasProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVentasProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvVentasProductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgvVentasProductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvVentasProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVentasProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvVentasProductos.ColumnHeadersHeight = 20
        Me.dgvVentasProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvVentasProductos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvVentasProductos.EnableHeadersVisualStyles = False
        Me.dgvVentasProductos.Location = New System.Drawing.Point(2, 2)
        Me.dgvVentasProductos.Name = "dgvVentasProductos"
        Me.dgvVentasProductos.ReadOnly = True
        Me.dgvVentasProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.NavajoWhite
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVentasProductos.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvVentasProductos.RowHeadersWidth = 51
        Me.dgvVentasProductos.Size = New System.Drawing.Size(784, 91)
        Me.dgvVentasProductos.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(778, 471)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 42)
        Me.Button1.TabIndex = 98
        Me.Button1.Text = "Volver"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(324, 20)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(281, 37)
        Me.Label6.TabIndex = 91
        Me.Label6.Text = "Reporte Más Vendidos"
        '
        'ChartGrafico
        '
        Me.ChartGrafico.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        ChartArea3.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea3.AxisX.TitleFont = New System.Drawing.Font("Britannic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea3.Name = "ChartArea1"
        Me.ChartGrafico.ChartAreas.Add(ChartArea3)
        Legend3.BackColor = System.Drawing.Color.Transparent
        Legend3.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend3.ForeColor = System.Drawing.Color.White
        Legend3.IsTextAutoFit = False
        Legend3.Name = "Legend1"
        Me.ChartGrafico.Legends.Add(Legend3)
        Me.ChartGrafico.Location = New System.Drawing.Point(250, 89)
        Me.ChartGrafico.Name = "ChartGrafico"
        Me.ChartGrafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Me.ChartGrafico.RightToLeft = System.Windows.Forms.RightToLeft.No
        Series3.ChartArea = "ChartArea1"
        Series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series3.IsValueShownAsLabel = True
        Series3.LabelForeColor = System.Drawing.Color.White
        Series3.Legend = "Legend1"
        Series3.Name = "Productos Mas Vendidos"
        Series3.XValueMember = "65"
        Series3.YValueMembers = "0"
        Me.ChartGrafico.Series.Add(Series3)
        Me.ChartGrafico.Size = New System.Drawing.Size(472, 235)
        Me.ChartGrafico.TabIndex = 92
        Title3.Font = New System.Drawing.Font("Britannic Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title3.ForeColor = System.Drawing.Color.White
        Title3.Name = "titulo"
        Title3.Text = "TOP 5 PRODUCTOS MAS VENDIDOS"
        Me.ChartGrafico.Titles.Add(Title3)
        '
        'ProductosMasVendidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(938, 533)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ChartGrafico)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "ProductosMasVendidos"
        Me.Text = "ProductosMasVendidos"
        Me.TabControl.ResumeLayout(False)
        Me.PagPageVentasDiarias.ResumeLayout(False)
        CType(Me.dgvVentasProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartGrafico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl As TabControl
    Friend WithEvents PagPageVentasDiarias As TabPage
    Friend WithEvents dgvVentasProductos As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents ChartGrafico As DataVisualization.Charting.Chart
End Class
