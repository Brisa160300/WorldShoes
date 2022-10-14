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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.PagPageVentasDiarias = New System.Windows.Forms.TabPage()
        Me.DataGridViewListaVentas = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridViewVentasNetas = New System.Windows.Forms.DataGridView()
        Me.ColumnaNumero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabControl.SuspendLayout()
        Me.PagPageVentasDiarias.SuspendLayout()
        CType(Me.DataGridViewListaVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewVentasNetas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(985, 352)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 46)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "$"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(784, 352)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 46)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Ventas Netas:"
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
        Me.PagPageVentasDiarias.Controls.Add(Me.DataGridViewListaVentas)
        Me.PagPageVentasDiarias.Location = New System.Drawing.Point(4, 29)
        Me.PagPageVentasDiarias.Name = "PagPageVentasDiarias"
        Me.PagPageVentasDiarias.Padding = New System.Windows.Forms.Padding(3)
        Me.PagPageVentasDiarias.Size = New System.Drawing.Size(1053, 180)
        Me.PagPageVentasDiarias.TabIndex = 0
        Me.PagPageVentasDiarias.Text = "Detalle de Ventas"
        Me.PagPageVentasDiarias.UseVisualStyleBackColor = True
        '
        'DataGridViewListaVentas
        '
        Me.DataGridViewListaVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewListaVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewListaVentas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.DataGridViewListaVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewListaVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewListaVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewListaVentas.ColumnHeadersHeight = 20
        Me.DataGridViewListaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridViewListaVentas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column5, Me.Column3, Me.DataGridViewTextBoxColumn1})
        Me.DataGridViewListaVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewListaVentas.EnableHeadersVisualStyles = False
        Me.DataGridViewListaVentas.Location = New System.Drawing.Point(3, 3)
        Me.DataGridViewListaVentas.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewListaVentas.Name = "DataGridViewListaVentas"
        Me.DataGridViewListaVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.NavajoWhite
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewListaVentas.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewListaVentas.RowHeadersWidth = 51
        Me.DataGridViewListaVentas.Size = New System.Drawing.Size(1047, 174)
        Me.DataGridViewListaVentas.TabIndex = 7
        '
        'Column1
        '
        Me.Column1.HeaderText = "N° Factura"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Fecha"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Cliente"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Productos"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1116, 501)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 52)
        Me.Button1.TabIndex = 82
        Me.Button1.Text = "Volver"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(769, 104)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(143, 30)
        Me.DateTimePicker2.TabIndex = 81
        Me.DateTimePicker2.Value = New Date(2022, 10, 7, 5, 3, 0, 0)
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(673, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 26)
        Me.Label4.TabIndex = 80
        Me.Label4.Text = "Hasta:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(519, 104)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(139, 30)
        Me.DateTimePicker1.TabIndex = 79
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
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
        Me.Label6.Text = "Reporte de Ventas"
        '
        'DataGridViewVentasNetas
        '
        Me.DataGridViewVentasNetas.AllowUserToDeleteRows = False
        Me.DataGridViewVentasNetas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewVentasNetas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewVentasNetas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DataGridViewVentasNetas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Britannic Bold", 10.2!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewVentasNetas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewVentasNetas.ColumnHeadersHeight = 20
        Me.DataGridViewVentasNetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridViewVentasNetas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnaNumero, Me.Column6, Me.Column7})
        Me.DataGridViewVentasNetas.EnableHeadersVisualStyles = False
        Me.DataGridViewVentasNetas.Location = New System.Drawing.Point(783, 169)
        Me.DataGridViewVentasNetas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridViewVentasNetas.Name = "DataGridViewVentasNetas"
        Me.DataGridViewVentasNetas.ReadOnly = True
        Me.DataGridViewVentasNetas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewVentasNetas.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewVentasNetas.RowHeadersWidth = 51
        Me.DataGridViewVentasNetas.RowTemplate.Height = 24
        Me.DataGridViewVentasNetas.Size = New System.Drawing.Size(309, 47)
        Me.DataGridViewVentasNetas.TabIndex = 77
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
        'ReportesDiarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1251, 656)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DataGridViewVentasNetas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReportesDiarios"
        Me.Text = "ReportesDiarios"
        Me.TabControl.ResumeLayout(False)
        Me.PagPageVentasDiarias.ResumeLayout(False)
        CType(Me.DataGridViewListaVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewVentasNetas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl As TabControl
    Friend WithEvents PagPageVentasDiarias As TabPage
    Friend WithEvents DataGridViewListaVentas As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridViewVentasNetas As DataGridView
    Friend WithEvents ColumnaNumero As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
End Class
