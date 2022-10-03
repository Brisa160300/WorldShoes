<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionarCategoria
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabListaCategorias = New System.Windows.Forms.TabControl()
        Me.TabPageListaTalle = New System.Windows.Forms.TabPage()
        Me.dgvListarCategorias = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BEliminarCategoria = New System.Windows.Forms.Button()
        Me.BEditarCategoria = New System.Windows.Forms.Button()
        Me.BBuscarCategoria = New System.Windows.Forms.Button()
        Me.TBGestionCategoria = New System.Windows.Forms.TextBox()
        Me.TabListaCategorias.SuspendLayout()
        Me.TabPageListaTalle.SuspendLayout()
        CType(Me.dgvListarCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabListaCategorias
        '
        Me.TabListaCategorias.Controls.Add(Me.TabPageListaTalle)
        Me.TabListaCategorias.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabListaCategorias.Location = New System.Drawing.Point(28, 183)
        Me.TabListaCategorias.Margin = New System.Windows.Forms.Padding(2)
        Me.TabListaCategorias.Name = "TabListaCategorias"
        Me.TabListaCategorias.SelectedIndex = 0
        Me.TabListaCategorias.Size = New System.Drawing.Size(796, 316)
        Me.TabListaCategorias.TabIndex = 18
        '
        'TabPageListaTalle
        '
        Me.TabPageListaTalle.Controls.Add(Me.dgvListarCategorias)
        Me.TabPageListaTalle.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaTalle.ForeColor = System.Drawing.Color.White
        Me.TabPageListaTalle.Location = New System.Drawing.Point(4, 25)
        Me.TabPageListaTalle.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPageListaTalle.Name = "TabPageListaTalle"
        Me.TabPageListaTalle.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPageListaTalle.Size = New System.Drawing.Size(788, 287)
        Me.TabPageListaTalle.TabIndex = 0
        Me.TabPageListaTalle.Text = "Lista de Categorias"
        Me.TabPageListaTalle.UseVisualStyleBackColor = True
        '
        'dgvListarCategorias
        '
        Me.dgvListarCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListarCategorias.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListarCategorias.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgvListarCategorias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListarCategorias.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListarCategorias.ColumnHeadersHeight = 20
        Me.dgvListarCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListarCategorias.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListarCategorias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListarCategorias.EnableHeadersVisualStyles = False
        Me.dgvListarCategorias.Location = New System.Drawing.Point(2, 2)
        Me.dgvListarCategorias.Name = "dgvListarCategorias"
        Me.dgvListarCategorias.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListarCategorias.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListarCategorias.RowHeadersWidth = 51
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.dgvListarCategorias.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvListarCategorias.Size = New System.Drawing.Size(784, 283)
        Me.dgvListarCategorias.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BEliminarCategoria)
        Me.GroupBox1.Controls.Add(Me.BEditarCategoria)
        Me.GroupBox1.Controls.Add(Me.BBuscarCategoria)
        Me.GroupBox1.Controls.Add(Me.TBGestionCategoria)
        Me.GroupBox1.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(28, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(796, 95)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestión de Categoría"
        '
        'BEliminarCategoria
        '
        Me.BEliminarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BEliminarCategoria.FlatAppearance.BorderSize = 2
        Me.BEliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEliminarCategoria.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminarCategoria.ForeColor = System.Drawing.Color.White
        Me.BEliminarCategoria.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.trash_6_32
        Me.BEliminarCategoria.Location = New System.Drawing.Point(730, 27)
        Me.BEliminarCategoria.Name = "BEliminarCategoria"
        Me.BEliminarCategoria.Size = New System.Drawing.Size(49, 41)
        Me.BEliminarCategoria.TabIndex = 12
        Me.BEliminarCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BEliminarCategoria.UseVisualStyleBackColor = False
        '
        'BEditarCategoria
        '
        Me.BEditarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BEditarCategoria.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BEditarCategoria.FlatAppearance.BorderSize = 2
        Me.BEditarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEditarCategoria.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEditarCategoria.ForeColor = System.Drawing.Color.White
        Me.BEditarCategoria.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.edit_12_32
        Me.BEditarCategoria.Location = New System.Drawing.Point(675, 27)
        Me.BEditarCategoria.Name = "BEditarCategoria"
        Me.BEditarCategoria.Size = New System.Drawing.Size(49, 41)
        Me.BEditarCategoria.TabIndex = 13
        Me.BEditarCategoria.UseVisualStyleBackColor = False
        '
        'BBuscarCategoria
        '
        Me.BBuscarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BBuscarCategoria.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BBuscarCategoria.FlatAppearance.BorderSize = 2
        Me.BBuscarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBuscarCategoria.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscarCategoria.ForeColor = System.Drawing.Color.White
        Me.BBuscarCategoria.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.search_3_32
        Me.BBuscarCategoria.Location = New System.Drawing.Point(156, 27)
        Me.BBuscarCategoria.Name = "BBuscarCategoria"
        Me.BBuscarCategoria.Size = New System.Drawing.Size(49, 41)
        Me.BBuscarCategoria.TabIndex = 14
        Me.BBuscarCategoria.UseVisualStyleBackColor = False
        '
        'TBGestionCategoria
        '
        Me.TBGestionCategoria.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBGestionCategoria.Location = New System.Drawing.Point(20, 35)
        Me.TBGestionCategoria.Name = "TBGestionCategoria"
        Me.TBGestionCategoria.Size = New System.Drawing.Size(131, 25)
        Me.TBGestionCategoria.TabIndex = 6
        '
        'GestionarCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(862, 533)
        Me.Controls.Add(Me.TabListaCategorias)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "GestionarCategoria"
        Me.Text = "GestionarCategoria"
        Me.TabListaCategorias.ResumeLayout(False)
        Me.TabPageListaTalle.ResumeLayout(False)
        CType(Me.dgvListarCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabListaCategorias As TabControl
    Friend WithEvents TabPageListaTalle As TabPage
    Friend WithEvents dgvListarCategorias As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BEliminarCategoria As Button
    Friend WithEvents BEditarCategoria As Button
    Friend WithEvents BBuscarCategoria As Button
    Friend WithEvents TBGestionCategoria As TextBox
End Class
