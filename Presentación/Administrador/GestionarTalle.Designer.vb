<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionarTalle
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
        Me.TabGestionTalles = New System.Windows.Forms.TabControl()
        Me.TabPageListaTalle = New System.Windows.Forms.TabPage()
        Me.dgvRegTalles = New System.Windows.Forms.DataGridView()
        Me.GroupBoxGestionarTalles = New System.Windows.Forms.GroupBox()
        Me.BAltaTalle = New System.Windows.Forms.Button()
        Me.BBuscarTalle = New System.Windows.Forms.Button()
        Me.BModificarTalle = New System.Windows.Forms.Button()
        Me.TBBuscarTalle = New System.Windows.Forms.TextBox()
        Me.BEliminarTalle = New System.Windows.Forms.Button()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.TabGestionTalles.SuspendLayout()
        Me.TabPageListaTalle.SuspendLayout()
        CType(Me.dgvRegTalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxGestionarTalles.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabGestionTalles
        '
        Me.TabGestionTalles.Controls.Add(Me.TabPageListaTalle)
        Me.TabGestionTalles.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabGestionTalles.Location = New System.Drawing.Point(40, 220)
        Me.TabGestionTalles.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabGestionTalles.Name = "TabGestionTalles"
        Me.TabGestionTalles.SelectedIndex = 0
        Me.TabGestionTalles.Size = New System.Drawing.Size(1042, 345)
        Me.TabGestionTalles.TabIndex = 19
        '
        'TabPageListaTalle
        '
        Me.TabPageListaTalle.Controls.Add(Me.dgvRegTalles)
        Me.TabPageListaTalle.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaTalle.ForeColor = System.Drawing.Color.White
        Me.TabPageListaTalle.Location = New System.Drawing.Point(4, 28)
        Me.TabPageListaTalle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaTalle.Name = "TabPageListaTalle"
        Me.TabPageListaTalle.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaTalle.Size = New System.Drawing.Size(1034, 313)
        Me.TabPageListaTalle.TabIndex = 0
        Me.TabPageListaTalle.Text = "Lista de Talles"
        Me.TabPageListaTalle.UseVisualStyleBackColor = True
        '
        'dgvRegTalles
        '
        Me.dgvRegTalles.AllowUserToAddRows = False
        Me.dgvRegTalles.AllowUserToDeleteRows = False
        Me.dgvRegTalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRegTalles.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgvRegTalles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRegTalles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRegTalles.ColumnHeadersHeight = 29
        Me.dgvRegTalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRegTalles.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRegTalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRegTalles.EnableHeadersVisualStyles = False
        Me.dgvRegTalles.Location = New System.Drawing.Point(3, 2)
        Me.dgvRegTalles.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvRegTalles.Name = "dgvRegTalles"
        Me.dgvRegTalles.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRegTalles.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRegTalles.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.dgvRegTalles.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvRegTalles.Size = New System.Drawing.Size(1028, 309)
        Me.dgvRegTalles.TabIndex = 2
        '
        'GroupBoxGestionarTalles
        '
        Me.GroupBoxGestionarTalles.Controls.Add(Me.BBuscarTalle)
        Me.GroupBoxGestionarTalles.Controls.Add(Me.BModificarTalle)
        Me.GroupBoxGestionarTalles.Controls.Add(Me.TBBuscarTalle)
        Me.GroupBoxGestionarTalles.Controls.Add(Me.BEliminarTalle)
        Me.GroupBoxGestionarTalles.Controls.Add(Me.BAltaTalle)
        Me.GroupBoxGestionarTalles.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.GroupBoxGestionarTalles.ForeColor = System.Drawing.Color.White
        Me.GroupBoxGestionarTalles.Location = New System.Drawing.Point(40, 63)
        Me.GroupBoxGestionarTalles.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxGestionarTalles.Name = "GroupBoxGestionarTalles"
        Me.GroupBoxGestionarTalles.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxGestionarTalles.Size = New System.Drawing.Size(1042, 117)
        Me.GroupBoxGestionarTalles.TabIndex = 20
        Me.GroupBoxGestionarTalles.TabStop = False
        Me.GroupBoxGestionarTalles.Text = "Búsqueda de talles"
        '
        'BAltaTalle
        '
        Me.BAltaTalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BAltaTalle.FlatAppearance.BorderSize = 2
        Me.BAltaTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAltaTalle.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAltaTalle.ForeColor = System.Drawing.Color.White
        Me.BAltaTalle.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.plus_32
        Me.BAltaTalle.Location = New System.Drawing.Point(947, 33)
        Me.BAltaTalle.Margin = New System.Windows.Forms.Padding(4)
        Me.BAltaTalle.Name = "BAltaTalle"
        Me.BAltaTalle.Size = New System.Drawing.Size(65, 50)
        Me.BAltaTalle.TabIndex = 18
        Me.BAltaTalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BAltaTalle.UseVisualStyleBackColor = False
        '
        'BBuscarTalle
        '
        Me.BBuscarTalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BBuscarTalle.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BBuscarTalle.FlatAppearance.BorderSize = 2
        Me.BBuscarTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBuscarTalle.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscarTalle.ForeColor = System.Drawing.Color.White
        Me.BBuscarTalle.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.search_3_32
        Me.BBuscarTalle.Location = New System.Drawing.Point(208, 31)
        Me.BBuscarTalle.Margin = New System.Windows.Forms.Padding(4)
        Me.BBuscarTalle.Name = "BBuscarTalle"
        Me.BBuscarTalle.Size = New System.Drawing.Size(65, 50)
        Me.BBuscarTalle.TabIndex = 15
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
        Me.BModificarTalle.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.edit_12_32
        Me.BModificarTalle.Location = New System.Drawing.Point(874, 33)
        Me.BModificarTalle.Margin = New System.Windows.Forms.Padding(4)
        Me.BModificarTalle.Name = "BModificarTalle"
        Me.BModificarTalle.Size = New System.Drawing.Size(65, 50)
        Me.BModificarTalle.TabIndex = 16
        Me.BModificarTalle.UseVisualStyleBackColor = False
        '
        'TBBuscarTalle
        '
        Me.TBBuscarTalle.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBBuscarTalle.Location = New System.Drawing.Point(27, 43)
        Me.TBBuscarTalle.Margin = New System.Windows.Forms.Padding(4)
        Me.TBBuscarTalle.Name = "TBBuscarTalle"
        Me.TBBuscarTalle.Size = New System.Drawing.Size(173, 30)
        Me.TBBuscarTalle.TabIndex = 9
        '
        'BEliminarTalle
        '
        Me.BEliminarTalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BEliminarTalle.FlatAppearance.BorderSize = 2
        Me.BEliminarTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEliminarTalle.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminarTalle.ForeColor = System.Drawing.Color.White
        Me.BEliminarTalle.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.trash_6_32
        Me.BEliminarTalle.Location = New System.Drawing.Point(947, 33)
        Me.BEliminarTalle.Margin = New System.Windows.Forms.Padding(4)
        Me.BEliminarTalle.Name = "BEliminarTalle"
        Me.BEliminarTalle.Size = New System.Drawing.Size(65, 50)
        Me.BEliminarTalle.TabIndex = 17
        Me.BEliminarTalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BEliminarTalle.UseVisualStyleBackColor = False
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVolver.ForeColor = System.Drawing.Color.White
        Me.BVolver.Location = New System.Drawing.Point(952, 584)
        Me.BVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(130, 50)
        Me.BVolver.TabIndex = 23
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'GestionarTalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 656)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.GroupBoxGestionarTalles)
        Me.Controls.Add(Me.TabGestionTalles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "GestionarTalle"
        Me.Text = "GestionarTalle"
        Me.TabGestionTalles.ResumeLayout(False)
        Me.TabPageListaTalle.ResumeLayout(False)
        CType(Me.dgvRegTalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxGestionarTalles.ResumeLayout(False)
        Me.GroupBoxGestionarTalles.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabGestionTalles As TabControl
    Friend WithEvents TabPageListaTalle As TabPage
    Friend WithEvents dgvRegTalles As DataGridView
    Friend WithEvents GroupBoxGestionarTalles As GroupBox
    Friend WithEvents BBuscarTalle As Button
    Friend WithEvents BModificarTalle As Button
    Friend WithEvents TBBuscarTalle As TextBox
    Friend WithEvents BEliminarTalle As Button
    Friend WithEvents BVolver As Button
    Friend WithEvents BAltaTalle As Button
End Class
