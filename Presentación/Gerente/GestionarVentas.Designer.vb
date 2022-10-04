<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionarVentas
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
        Me.TabControlGestionVentas = New System.Windows.Forms.TabControl()
        Me.TabPageListaTalle = New System.Windows.Forms.TabPage()
        Me.DataGridViewRegistroVentas = New System.Windows.Forms.DataGridView()
        Me.GroupBoxBuscarVenta = New System.Windows.Forms.GroupBox()
        Me.BBuscarVenta = New System.Windows.Forms.Button()
        Me.BModVenta = New System.Windows.Forms.Button()
        Me.TBBuscarVenta = New System.Windows.Forms.TextBox()
        Me.BEliminarVenta = New System.Windows.Forms.Button()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.TabControlGestionVentas.SuspendLayout()
        Me.TabPageListaTalle.SuspendLayout()
        CType(Me.DataGridViewRegistroVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxBuscarVenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlGestionVentas
        '
        Me.TabControlGestionVentas.Controls.Add(Me.TabPageListaTalle)
        Me.TabControlGestionVentas.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlGestionVentas.Location = New System.Drawing.Point(28, 201)
        Me.TabControlGestionVentas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlGestionVentas.Name = "TabControlGestionVentas"
        Me.TabControlGestionVentas.SelectedIndex = 0
        Me.TabControlGestionVentas.Size = New System.Drawing.Size(1056, 356)
        Me.TabControlGestionVentas.TabIndex = 8
        '
        'TabPageListaTalle
        '
        Me.TabPageListaTalle.Controls.Add(Me.DataGridViewRegistroVentas)
        Me.TabPageListaTalle.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaTalle.ForeColor = System.Drawing.Color.White
        Me.TabPageListaTalle.Location = New System.Drawing.Point(4, 28)
        Me.TabPageListaTalle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaTalle.Name = "TabPageListaTalle"
        Me.TabPageListaTalle.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaTalle.Size = New System.Drawing.Size(1048, 324)
        Me.TabPageListaTalle.TabIndex = 0
        Me.TabPageListaTalle.Text = "Lista de Ventas"
        Me.TabPageListaTalle.UseVisualStyleBackColor = True
        '
        'DataGridViewRegistroVentas
        '
        Me.DataGridViewRegistroVentas.AllowUserToAddRows = False
        Me.DataGridViewRegistroVentas.AllowUserToDeleteRows = False
        Me.DataGridViewRegistroVentas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.DataGridViewRegistroVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewRegistroVentas.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewRegistroVentas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewRegistroVentas.Location = New System.Drawing.Point(3, 2)
        Me.DataGridViewRegistroVentas.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewRegistroVentas.Name = "DataGridViewRegistroVentas"
        Me.DataGridViewRegistroVentas.ReadOnly = True
        Me.DataGridViewRegistroVentas.RowHeadersWidth = 51
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewRegistroVentas.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewRegistroVentas.Size = New System.Drawing.Size(1042, 320)
        Me.DataGridViewRegistroVentas.TabIndex = 2
        '
        'GroupBoxBuscarVenta
        '
        Me.GroupBoxBuscarVenta.Controls.Add(Me.BBuscarVenta)
        Me.GroupBoxBuscarVenta.Controls.Add(Me.BModVenta)
        Me.GroupBoxBuscarVenta.Controls.Add(Me.TBBuscarVenta)
        Me.GroupBoxBuscarVenta.Controls.Add(Me.BEliminarVenta)
        Me.GroupBoxBuscarVenta.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.GroupBoxBuscarVenta.ForeColor = System.Drawing.Color.White
        Me.GroupBoxBuscarVenta.Location = New System.Drawing.Point(28, 46)
        Me.GroupBoxBuscarVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxBuscarVenta.Name = "GroupBoxBuscarVenta"
        Me.GroupBoxBuscarVenta.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxBuscarVenta.Size = New System.Drawing.Size(1056, 117)
        Me.GroupBoxBuscarVenta.TabIndex = 19
        Me.GroupBoxBuscarVenta.TabStop = False
        Me.GroupBoxBuscarVenta.Text = "Búscar Venta"
        '
        'BBuscarVenta
        '
        Me.BBuscarVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BBuscarVenta.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BBuscarVenta.FlatAppearance.BorderSize = 2
        Me.BBuscarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBuscarVenta.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscarVenta.ForeColor = System.Drawing.Color.White
        Me.BBuscarVenta.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.search_3_32
        Me.BBuscarVenta.Location = New System.Drawing.Point(208, 33)
        Me.BBuscarVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.BBuscarVenta.Name = "BBuscarVenta"
        Me.BBuscarVenta.Size = New System.Drawing.Size(65, 50)
        Me.BBuscarVenta.TabIndex = 15
        Me.BBuscarVenta.UseVisualStyleBackColor = False
        '
        'BModVenta
        '
        Me.BModVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BModVenta.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BModVenta.FlatAppearance.BorderSize = 2
        Me.BModVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModVenta.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BModVenta.ForeColor = System.Drawing.Color.White
        Me.BModVenta.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.edit_12_32
        Me.BModVenta.Location = New System.Drawing.Point(888, 33)
        Me.BModVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.BModVenta.Name = "BModVenta"
        Me.BModVenta.Size = New System.Drawing.Size(65, 50)
        Me.BModVenta.TabIndex = 16
        Me.BModVenta.UseVisualStyleBackColor = False
        '
        'TBBuscarVenta
        '
        Me.TBBuscarVenta.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBBuscarVenta.Location = New System.Drawing.Point(27, 43)
        Me.TBBuscarVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.TBBuscarVenta.Name = "TBBuscarVenta"
        Me.TBBuscarVenta.Size = New System.Drawing.Size(173, 30)
        Me.TBBuscarVenta.TabIndex = 9
        '
        'BEliminarVenta
        '
        Me.BEliminarVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BEliminarVenta.FlatAppearance.BorderSize = 2
        Me.BEliminarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEliminarVenta.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminarVenta.ForeColor = System.Drawing.Color.White
        Me.BEliminarVenta.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.trash_6_32
        Me.BEliminarVenta.Location = New System.Drawing.Point(970, 33)
        Me.BEliminarVenta.Margin = New System.Windows.Forms.Padding(4)
        Me.BEliminarVenta.Name = "BEliminarVenta"
        Me.BEliminarVenta.Size = New System.Drawing.Size(65, 50)
        Me.BEliminarVenta.TabIndex = 17
        Me.BEliminarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BEliminarVenta.UseVisualStyleBackColor = False
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVolver.ForeColor = System.Drawing.Color.White
        Me.BVolver.Location = New System.Drawing.Point(954, 574)
        Me.BVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(130, 50)
        Me.BVolver.TabIndex = 24
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'GestionarVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 656)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.GroupBoxBuscarVenta)
        Me.Controls.Add(Me.TabControlGestionVentas)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "GestionarVentas"
        Me.Text = "Buscar Venta"
        Me.TabControlGestionVentas.ResumeLayout(False)
        Me.TabPageListaTalle.ResumeLayout(False)
        CType(Me.DataGridViewRegistroVentas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxBuscarVenta.ResumeLayout(False)
        Me.GroupBoxBuscarVenta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlGestionVentas As TabControl
    Friend WithEvents TabPageListaTalle As TabPage
    Friend WithEvents DataGridViewRegistroVentas As DataGridView
    Friend WithEvents GroupBoxBuscarVenta As GroupBox
    Friend WithEvents BBuscarVenta As Button
    Friend WithEvents BModVenta As Button
    Friend WithEvents TBBuscarVenta As TextBox
    Friend WithEvents BEliminarVenta As Button
    Friend WithEvents BVolver As Button
End Class
