<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes7Dia
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
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.LTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.PagPageVentasDiarias = New System.Windows.Forms.TabPage()
        Me.dgvListaVentas = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DTHasta = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgvVentasNetas = New System.Windows.Forms.DataGridView()
        Me.ColumnaNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChartGrafico = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.PagPageVentasDiarias.SuspendLayout()
        CType(Me.dgvListaVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvVentasNetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ChartGrafico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LTotal
        '
        Me.LTotal.Font = New System.Drawing.Font("Britannic Bold", 18.0!)
        Me.LTotal.ForeColor = System.Drawing.SystemColors.Window
        Me.LTotal.Location = New System.Drawing.Point(723, 301)
        Me.LTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LTotal.Name = "LTotal"
        Me.LTotal.Size = New System.Drawing.Size(102, 37)
        Me.LTotal.TabIndex = 101
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(552, 301)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 37)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Ventas Netas: $"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.Captura_de_pantalla__356_
        Me.PictureBox1.Location = New System.Drawing.Point(29, 138)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(464, 184)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 99
        Me.PictureBox1.TabStop = False
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.PagPageVentasDiarias)
        Me.TabControl.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl.Location = New System.Drawing.Point(26, 332)
        Me.TabControl.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(796, 173)
        Me.TabControl.TabIndex = 98
        '
        'PagPageVentasDiarias
        '
        Me.PagPageVentasDiarias.Controls.Add(Me.dgvListaVentas)
        Me.PagPageVentasDiarias.Location = New System.Drawing.Point(4, 25)
        Me.PagPageVentasDiarias.Margin = New System.Windows.Forms.Padding(2)
        Me.PagPageVentasDiarias.Name = "PagPageVentasDiarias"
        Me.PagPageVentasDiarias.Padding = New System.Windows.Forms.Padding(2)
        Me.PagPageVentasDiarias.Size = New System.Drawing.Size(788, 144)
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
        Me.dgvListaVentas.Location = New System.Drawing.Point(2, 2)
        Me.dgvListaVentas.Name = "dgvListaVentas"
        Me.dgvListaVentas.ReadOnly = True
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
        Me.dgvListaVentas.Size = New System.Drawing.Size(784, 140)
        Me.dgvListaVentas.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(837, 408)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 42)
        Me.Button1.TabIndex = 97
        Me.Button1.Text = "Volver"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DTHasta
        '
        Me.DTHasta.Enabled = False
        Me.DTHasta.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTHasta.Location = New System.Drawing.Point(577, 85)
        Me.DTHasta.Margin = New System.Windows.Forms.Padding(2)
        Me.DTHasta.Name = "DTHasta"
        Me.DTHasta.Size = New System.Drawing.Size(108, 25)
        Me.DTHasta.TabIndex = 96
        Me.DTHasta.Value = New Date(2022, 10, 14, 5, 3, 0, 0)
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(505, 85)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 21)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Hasta:"
        '
        'DTDesde
        '
        Me.DTDesde.Enabled = False
        Me.DTDesde.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTDesde.Location = New System.Drawing.Point(389, 85)
        Me.DTDesde.Margin = New System.Windows.Forms.Padding(2)
        Me.DTDesde.Name = "DTDesde"
        Me.DTDesde.Size = New System.Drawing.Size(105, 25)
        Me.DTDesde.TabIndex = 94
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(320, 85)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 21)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "Desde:"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(376, 29)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(233, 37)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "Reporte Semanal"
        '
        'dgvVentasNetas
        '
        Me.dgvVentasNetas.AllowUserToAddRows = False
        Me.dgvVentasNetas.AllowUserToDeleteRows = False
        Me.dgvVentasNetas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvVentasNetas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvVentasNetas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dgvVentasNetas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvVentasNetas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Britannic Bold", 10.2!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvVentasNetas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvVentasNetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVentasNetas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnaNumero, Me.Column6, Me.Column7})
        Me.dgvVentasNetas.EnableHeadersVisualStyles = False
        Me.dgvVentasNetas.Location = New System.Drawing.Point(565, 138)
        Me.dgvVentasNetas.Margin = New System.Windows.Forms.Padding(2)
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
        Me.dgvVentasNetas.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvVentasNetas.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvVentasNetas.RowTemplate.Height = 24
        Me.dgvVentasNetas.Size = New System.Drawing.Size(257, 119)
        Me.dgvVentasNetas.TabIndex = 92
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
        'ChartGrafico
        '
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Britannic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX.TitleForeColor = System.Drawing.Color.White
        ChartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount
        ChartArea1.AxisY.TitleFont = New System.Drawing.Font("Britannic Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.TitleForeColor = System.Drawing.Color.White
        ChartArea1.Name = "ChartArea1"
        Me.ChartGrafico.ChartAreas.Add(ChartArea1)
        Legend1.BackColor = System.Drawing.Color.White
        Legend1.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Me.ChartGrafico.Legends.Add(Legend1)
        Me.ChartGrafico.Location = New System.Drawing.Point(26, 138)
        Me.ChartGrafico.Name = "ChartGrafico"
        Me.ChartGrafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Me.ChartGrafico.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChartGrafico.Size = New System.Drawing.Size(472, 184)
        Me.ChartGrafico.TabIndex = 102
        Title1.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.Name = "Title1"
        Title1.Text = "Ventas Diarias"
        Me.ChartGrafico.Titles.Add(Title1)
        '
        'Reportes7Dia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(938, 533)
        Me.Controls.Add(Me.ChartGrafico)
        Me.Controls.Add(Me.LTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DTHasta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DTDesde)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvVentasNetas)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Reportes7Dia"
        Me.Text = "Reportes7Dia"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.PagPageVentasDiarias.ResumeLayout(False)
        CType(Me.dgvListaVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvVentasNetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ChartGrafico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabControl As TabControl
    Friend WithEvents PagPageVentasDiarias As TabPage
    Friend WithEvents dgvListaVentas As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents DTHasta As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents DTDesde As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dgvVentasNetas As DataGridView
    Friend WithEvents ColumnaNumero As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents ChartGrafico As DataVisualization.Charting.Chart
End Class
