<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarTalle
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControlRegVentas = New System.Windows.Forms.TabControl()
        Me.TabPageListaTalle = New System.Windows.Forms.TabPage()
        Me.DataGridViewRegistroTalle = New System.Windows.Forms.DataGridView()
        Me.LBuscarCategoria = New System.Windows.Forms.Label()
        Me.TBNombreCliente = New System.Windows.Forms.TextBox()
        Me.BBuscarTalle = New System.Windows.Forms.Button()
        Me.BModificarTalle = New System.Windows.Forms.Button()
        Me.BEliminarTalle = New System.Windows.Forms.Button()
        Me.TabControlRegVentas.SuspendLayout()
        Me.TabPageListaTalle.SuspendLayout()
        CType(Me.DataGridViewRegistroTalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControlRegVentas
        '
        Me.TabControlRegVentas.Controls.Add(Me.TabPageListaTalle)
        Me.TabControlRegVentas.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlRegVentas.Location = New System.Drawing.Point(29, 12)
        Me.TabControlRegVentas.Name = "TabControlRegVentas"
        Me.TabControlRegVentas.SelectedIndex = 0
        Me.TabControlRegVentas.Size = New System.Drawing.Size(718, 522)
        Me.TabControlRegVentas.TabIndex = 7
        '
        'TabPageListaTalle
        '
        Me.TabPageListaTalle.Controls.Add(Me.DataGridViewRegistroTalle)
        Me.TabPageListaTalle.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaTalle.ForeColor = System.Drawing.Color.White
        Me.TabPageListaTalle.Location = New System.Drawing.Point(4, 28)
        Me.TabPageListaTalle.Name = "TabPageListaTalle"
        Me.TabPageListaTalle.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageListaTalle.Size = New System.Drawing.Size(710, 490)
        Me.TabPageListaTalle.TabIndex = 0
        Me.TabPageListaTalle.Text = "Lista de Talles"
        Me.TabPageListaTalle.UseVisualStyleBackColor = True
        '
        'DataGridViewRegistroTalle
        '
        Me.DataGridViewRegistroTalle.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.DataGridViewRegistroTalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewRegistroTalle.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewRegistroTalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewRegistroTalle.Location = New System.Drawing.Point(3, 3)
        Me.DataGridViewRegistroTalle.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewRegistroTalle.Name = "DataGridViewRegistroTalle"
        Me.DataGridViewRegistroTalle.RowHeadersWidth = 51
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewRegistroTalle.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewRegistroTalle.Size = New System.Drawing.Size(704, 484)
        Me.DataGridViewRegistroTalle.TabIndex = 2
        '
        'LBuscarCategoria
        '
        Me.LBuscarCategoria.AutoSize = True
        Me.LBuscarCategoria.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LBuscarCategoria.ForeColor = System.Drawing.Color.White
        Me.LBuscarCategoria.Location = New System.Drawing.Point(797, 50)
        Me.LBuscarCategoria.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBuscarCategoria.Name = "LBuscarCategoria"
        Me.LBuscarCategoria.Size = New System.Drawing.Size(74, 22)
        Me.LBuscarCategoria.TabIndex = 8
        Me.LBuscarCategoria.Text = "Buscar"
        '
        'TBNombreCliente
        '
        Me.TBNombreCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBNombreCliente.Location = New System.Drawing.Point(801, 104)
        Me.TBNombreCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBNombreCliente.Name = "TBNombreCliente"
        Me.TBNombreCliente.Size = New System.Drawing.Size(173, 30)
        Me.TBNombreCliente.TabIndex = 9
        '
        'BBuscarTalle
        '
        Me.BBuscarTalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BBuscarTalle.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BBuscarTalle.FlatAppearance.BorderSize = 2
        Me.BBuscarTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBuscarTalle.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscarTalle.ForeColor = System.Drawing.Color.White
        Me.BBuscarTalle.Location = New System.Drawing.Point(982, 102)
        Me.BBuscarTalle.Margin = New System.Windows.Forms.Padding(4)
        Me.BBuscarTalle.Name = "BBuscarTalle"
        Me.BBuscarTalle.Size = New System.Drawing.Size(84, 32)
        Me.BBuscarTalle.TabIndex = 15
        Me.BBuscarTalle.Text = "Buscar"
        Me.BBuscarTalle.UseVisualStyleBackColor = False
        '
        'BModificarTalle
        '
        Me.BModificarTalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BModificarTalle.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BModificarTalle.FlatAppearance.BorderSize = 2
        Me.BModificarTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModificarTalle.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BModificarTalle.ForeColor = System.Drawing.Color.White
        Me.BModificarTalle.Location = New System.Drawing.Point(802, 178)
        Me.BModificarTalle.Margin = New System.Windows.Forms.Padding(4)
        Me.BModificarTalle.Name = "BModificarTalle"
        Me.BModificarTalle.Size = New System.Drawing.Size(97, 32)
        Me.BModificarTalle.TabIndex = 16
        Me.BModificarTalle.Text = "Modificar"
        Me.BModificarTalle.UseVisualStyleBackColor = False
        '
        'BEliminarTalle
        '
        Me.BEliminarTalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BEliminarTalle.FlatAppearance.BorderSize = 2
        Me.BEliminarTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEliminarTalle.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminarTalle.ForeColor = System.Drawing.Color.White
        Me.BEliminarTalle.Location = New System.Drawing.Point(801, 236)
        Me.BEliminarTalle.Margin = New System.Windows.Forms.Padding(4)
        Me.BEliminarTalle.Name = "BEliminarTalle"
        Me.BEliminarTalle.Size = New System.Drawing.Size(98, 32)
        Me.BEliminarTalle.TabIndex = 17
        Me.BEliminarTalle.Text = "Eliminar"
        Me.BEliminarTalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BEliminarTalle.UseVisualStyleBackColor = False
        '
        'GestionarTalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1093, 556)
        Me.Controls.Add(Me.BEliminarTalle)
        Me.Controls.Add(Me.BModificarTalle)
        Me.Controls.Add(Me.BBuscarTalle)
        Me.Controls.Add(Me.TBNombreCliente)
        Me.Controls.Add(Me.LBuscarCategoria)
        Me.Controls.Add(Me.TabControlRegVentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GestionarTalle"
        Me.Text = "GestionarTalle"
        Me.TabControlRegVentas.ResumeLayout(False)
        Me.TabPageListaTalle.ResumeLayout(False)
        CType(Me.DataGridViewRegistroTalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControlRegVentas As TabControl
    Friend WithEvents TabPageListaTalle As TabPage
    Friend WithEvents DataGridViewRegistroTalle As DataGridView
    Friend WithEvents LBuscarCategoria As Label
    Friend WithEvents TBNombreCliente As TextBox
    Friend WithEvents BBuscarTalle As Button
    Friend WithEvents BModificarTalle As Button
    Friend WithEvents BEliminarTalle As Button
End Class
