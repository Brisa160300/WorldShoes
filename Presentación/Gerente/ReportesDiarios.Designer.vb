<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportesDiarios
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.PagPageVentasDiarias = New System.Windows.Forms.TabPage()
        Me.dgvListaVentas = New System.Windows.Forms.DataGridView()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.DTHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvVentasNetas = New System.Windows.Forms.DataGridView()
        Me.ColumnaNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LTotal = New System.Windows.Forms.Label()
        Me.ChartGrafico = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabControl.SuspendLayout()
        Me.PagPageVentasDiarias.SuspendLayout()
        CType(Me.dgvListaVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVentasNetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartGrafico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(763, 358)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(222, 46)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Ventas Netas: $"
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.PagPageVentasDiarias)
        Me.TabControl.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.Location = New System.Drawing.Point(35, 407)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1061, 213)
        Me.TabControl.TabIndex = 83
        '
        'PagPageVentasDiarias
        '
        Me.PagPageVentasDiarias.Controls.Add(Me.dgvListaVentas)
        Me.PagPageVentasDiarias.Location = New System.Drawing.Point(4, 29)
        Me.PagPageVentasDiarias.Name = "PagPageVentasDiarias"
        Me.PagPageVentasDiarias.Padding = New System.Windows.Forms.Padding(3)
        Me.PagPageVentasDiarias.Size = New System.Drawing.Size(1053, 180)
        Me.PagPageVentasDiarias.TabIndex = 0
        Me.PagPageVentasDiarias.Text = "Detalle de Ventas"
        Me.PagPageVentasDiarias.UseVisualStyleBackColor = True
        '
        'dgvListaVentas
        '
        Me.dgvListaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListaVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListaVentas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgvListaVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListaVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListaVentas.ColumnHeadersHeight = 20
        Me.dgvListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvListaVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListaVentas.EnableHeadersVisualStyles = False
        Me.dgvListaVentas.Location = New System.Drawing.Point(3, 3)
        Me.dgvListaVentas.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvListaVentas.Name = "dgvListaVentas"
        Me.dgvListaVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.NavajoWhite
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListaVentas.RowHeadersWidth = 51
        Me.dgvListaVentas.Size = New System.Drawing.Size(1047, 174)
        Me.dgvListaVentas.TabIndex = 7
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVolver.ForeColor = System.Drawing.Color.White
        Me.BVolver.Location = New System.Drawing.Point(1116, 501)
        Me.BVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(100, 52)
        Me.BVolver.TabIndex = 82
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'DTHasta
        '
        Me.DTHasta.Enabled = False
        Me.DTHasta.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTHasta.Location = New System.Drawing.Point(769, 104)
        Me.DTHasta.Name = "DTHasta"
        Me.DTHasta.Size = New System.Drawing.Size(143, 30)
        Me.DTHasta.TabIndex = 81
        Me.DTHasta.Value = New Date(2022, 10, 7, 5, 3, 0, 0)
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(673, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 26)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Hasta:"
        '
        'DTDesde
        '
        Me.DTDesde.Enabled = False
        Me.DTDesde.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTDesde.Location = New System.Drawing.Point(519, 104)
        Me.DTDesde.Name = "DTDesde"
        Me.DTDesde.Size = New System.Drawing.Size(139, 30)
        Me.DTDesde.TabIndex = 79
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(427, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 26)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Desde:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(513, 37)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(261, 46)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Reporte de Diario"
        '
        'dgvVentasNetas
        '
        Me.dgvVentasNetas.AllowUserToAddRows = False
        Me.dgvVentasNetas.AllowUserToDeleteRows = False
        Me.dgvVentasNetas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVentasNetas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvVentasNetas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dgvVentasNetas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Britannic Bold", 10.2!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVentasNetas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvVentasNetas.ColumnHeadersHeight = 20
        Me.dgvVentasNetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvVentasNetas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnaNumero, Me.Column6, Me.Column7})
        Me.dgvVentasNetas.Enabled = False
        Me.dgvVentasNetas.EnableHeadersVisualStyles = False
        Me.dgvVentasNetas.Location = New System.Drawing.Point(780, 169)
        Me.dgvVentasNetas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvVentasNetas.Name = "dgvVentasNetas"
        Me.dgvVentasNetas.ReadOnly = True
        Me.dgvVentasNetas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVentasNetas.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvVentasNetas.RowHeadersWidth = 51
        Me.dgvVentasNetas.RowTemplate.Height = 24
        Me.dgvVentasNetas.Size = New System.Drawing.Size(309, 47)
        Me.dgvVentasNetas.TabIndex = 77
        '
        'ColumnaNumero
        '
        Me.ColumnaNumero.HeaderText = "N°"
        Me.ColumnaNumero.MinimumWidth = 6
        Me.ColumnaNumero.Name = "ColumnaNumero"
        Me.ColumnaNumero.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Fecha"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Ventas Netas"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.Captura_de_pantalla__360_
        Me.PictureBox1.Location = New System.Drawing.Point(35, 155)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(618, 226)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 86
        Me.PictureBox1.TabStop = False
        '
        'LTotal
        '
        Me.LTotal.Font = New System.Drawing.Font("Britannic Bold", 18.0!)
        Me.LTotal.ForeColor = System.Drawing.SystemColors.Window
        Me.LTotal.Location = New System.Drawing.Point(980, 358)
        Me.LTotal.Name = "LTotal"
        Me.LTotal.Size = New System.Drawing.Size(136, 46)
        Me.LTotal.TabIndex = 87
        '
        'ChartGrafico
        '
        ChartArea1.Name = "ChartArea1"
        Me.ChartGrafico.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.ChartGrafico.Legends.Add(Legend1)
        Me.ChartGrafico.Location = New System.Drawing.Point(31, 155)
        Me.ChartGrafico.Name = "ChartGrafico"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.ChartGrafico.Series.Add(Series1)
        Me.ChartGrafico.Size = New System.Drawing.Size(622, 226)
        Me.ChartGrafico.TabIndex = 88
        Me.ChartGrafico.Text = "Chart1"
        '
        'ReportesDiarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1251, 656)
        Me.Controls.Add(Me.ChartGrafico)
        Me.Controls.Add(Me.LTotal)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.DTHasta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DTDesde)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvVentasNetas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReportesDiarios"
        Me.Text = "ReportesDiarios"
        Me.TabControl.ResumeLayout(False)
        Me.PagPageVentasDiarias.ResumeLayout(False)
        CType(Me.dgvListaVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVentasNetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartGrafico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl As TabControl
    Friend WithEvents PagPageVentasDiarias As TabPage
    Friend WithEvents dgvListaVentas As DataGridView
    Friend WithEvents BVolver As Button
    Friend WithEvents DTHasta As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents DTDesde As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvVentasNetas As DataGridView
    Friend WithEvents ColumnaNumero As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LTotal As Label
    Friend WithEvents ChartGrafico As DataVisualization.Charting.Chart
End Class
