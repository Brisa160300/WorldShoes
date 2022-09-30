<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarCategoria
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
        Me.TabControlRegVentas = New System.Windows.Forms.TabControl()
        Me.TabPageListaCategoria = New System.Windows.Forms.TabPage()
        Me.DataGridViewRegistroCategorias = New System.Windows.Forms.DataGridView()
        Me.BModificarCategoria = New System.Windows.Forms.Button()
        Me.BEliminarCategoria = New System.Windows.Forms.Button()
        Me.TBNombreCliente = New System.Windows.Forms.TextBox()
        Me.BBuscarCategoria = New System.Windows.Forms.Button()
        Me.TabControlRegVentas.SuspendLayout()
        Me.TabPageListaCategoria.SuspendLayout()
        CType(Me.DataGridViewRegistroCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControlRegVentas
        '
        Me.TabControlRegVentas.Controls.Add(Me.TabPageListaCategoria)
        Me.TabControlRegVentas.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlRegVentas.Location = New System.Drawing.Point(37, 22)
        Me.TabControlRegVentas.Name = "TabControlRegVentas"
        Me.TabControlRegVentas.SelectedIndex = 0
        Me.TabControlRegVentas.Size = New System.Drawing.Size(718, 522)
        Me.TabControlRegVentas.TabIndex = 6
        '
        'TabPageListaCategoria
        '
        Me.TabPageListaCategoria.Controls.Add(Me.DataGridViewRegistroCategorias)
        Me.TabPageListaCategoria.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaCategoria.ForeColor = System.Drawing.Color.White
        Me.TabPageListaCategoria.Location = New System.Drawing.Point(4, 28)
        Me.TabPageListaCategoria.Name = "TabPageListaCategoria"
        Me.TabPageListaCategoria.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageListaCategoria.Size = New System.Drawing.Size(710, 490)
        Me.TabPageListaCategoria.TabIndex = 0
        Me.TabPageListaCategoria.Text = "Lista de Categoria"
        Me.TabPageListaCategoria.UseVisualStyleBackColor = True
        '
        'DataGridViewRegistroCategorias
        '
        Me.DataGridViewRegistroCategorias.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.DataGridViewRegistroCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewRegistroCategorias.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewRegistroCategorias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewRegistroCategorias.Location = New System.Drawing.Point(3, 3)
        Me.DataGridViewRegistroCategorias.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewRegistroCategorias.Name = "DataGridViewRegistroCategorias"
        Me.DataGridViewRegistroCategorias.RowHeadersWidth = 51
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewRegistroCategorias.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewRegistroCategorias.Size = New System.Drawing.Size(704, 484)
        Me.DataGridViewRegistroCategorias.TabIndex = 2
        '
        'BModificarCategoria
        '
        Me.BModificarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BModificarCategoria.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BModificarCategoria.FlatAppearance.BorderSize = 2
        Me.BModificarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModificarCategoria.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BModificarCategoria.ForeColor = System.Drawing.Color.White
        Me.BModificarCategoria.Location = New System.Drawing.Point(802, 178)
        Me.BModificarCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.BModificarCategoria.Name = "BModificarCategoria"
        Me.BModificarCategoria.Size = New System.Drawing.Size(97, 32)
        Me.BModificarCategoria.TabIndex = 13
        Me.BModificarCategoria.Text = "Modificar"
        Me.BModificarCategoria.UseVisualStyleBackColor = False
        '
        'BEliminarCategoria
        '
        Me.BEliminarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BEliminarCategoria.FlatAppearance.BorderSize = 2
        Me.BEliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEliminarCategoria.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminarCategoria.ForeColor = System.Drawing.Color.White
        Me.BEliminarCategoria.Location = New System.Drawing.Point(801, 236)
        Me.BEliminarCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.BEliminarCategoria.Name = "BEliminarCategoria"
        Me.BEliminarCategoria.Size = New System.Drawing.Size(98, 32)
        Me.BEliminarCategoria.TabIndex = 12
        Me.BEliminarCategoria.Text = "Eliminar"
        Me.BEliminarCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BEliminarCategoria.UseVisualStyleBackColor = False
        '
        'TBNombreCliente
        '
        Me.TBNombreCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBNombreCliente.Location = New System.Drawing.Point(801, 104)
        Me.TBNombreCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBNombreCliente.Name = "TBNombreCliente"
        Me.TBNombreCliente.Size = New System.Drawing.Size(173, 30)
        Me.TBNombreCliente.TabIndex = 6
        '
        'BBuscarCategoria
        '
        Me.BBuscarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BBuscarCategoria.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BBuscarCategoria.FlatAppearance.BorderSize = 2
        Me.BBuscarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBuscarCategoria.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscarCategoria.ForeColor = System.Drawing.Color.White
        Me.BBuscarCategoria.Location = New System.Drawing.Point(982, 102)
        Me.BBuscarCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.BBuscarCategoria.Name = "BBuscarCategoria"
        Me.BBuscarCategoria.Size = New System.Drawing.Size(84, 32)
        Me.BBuscarCategoria.TabIndex = 14
        Me.BBuscarCategoria.Text = "Buscar"
        Me.BBuscarCategoria.UseVisualStyleBackColor = False
        '
        'GestionarCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1093, 556)
        Me.Controls.Add(Me.BBuscarCategoria)
        Me.Controls.Add(Me.TBNombreCliente)
        Me.Controls.Add(Me.BModificarCategoria)
        Me.Controls.Add(Me.BEliminarCategoria)
        Me.Controls.Add(Me.TabControlRegVentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GestionarCategoria"
        Me.Text = "GestionarCategoria"
        Me.TabControlRegVentas.ResumeLayout(False)
        Me.TabPageListaCategoria.ResumeLayout(False)
        CType(Me.DataGridViewRegistroCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControlRegVentas As TabControl
    Friend WithEvents TabPageListaCategoria As TabPage
    Friend WithEvents DataGridViewRegistroCategorias As DataGridView
    Friend WithEvents BModificarCategoria As Button
    Friend WithEvents BEliminarCategoria As Button
    Friend WithEvents TBNombreCliente As TextBox
    Friend WithEvents BBuscarCategoria As Button
End Class
