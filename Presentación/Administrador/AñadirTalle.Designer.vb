<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AñadirTalle
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LTalle = New System.Windows.Forms.Label()
        Me.PanelRegClientes = New System.Windows.Forms.Panel()
        Me.BRegistrarTalle = New System.Windows.Forms.Button()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.TBNombreTalle = New System.Windows.Forms.TextBox()
        Me.LNombreTalle = New System.Windows.Forms.Label()
        Me.TabControlRegVentas = New System.Windows.Forms.TabControl()
        Me.TabPageListaTalles = New System.Windows.Forms.TabPage()
        Me.dgvRegistroTalles = New System.Windows.Forms.DataGridView()
        Me.ErrorProviderTalle = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelRegClientes.SuspendLayout()
        Me.TabControlRegVentas.SuspendLayout()
        Me.TabPageListaTalles.SuspendLayout()
        CType(Me.dgvRegistroTalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderTalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LTalle
        '
        Me.LTalle.AutoSize = True
        Me.LTalle.BackColor = System.Drawing.Color.Transparent
        Me.LTalle.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTalle.ForeColor = System.Drawing.Color.Transparent
        Me.LTalle.Location = New System.Drawing.Point(29, 65)
        Me.LTalle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LTalle.Name = "LTalle"
        Me.LTalle.Size = New System.Drawing.Size(166, 33)
        Me.LTalle.TabIndex = 3
        Me.LTalle.Text = "Nuevo Talle"
        '
        'PanelRegClientes
        '
        Me.PanelRegClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PanelRegClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelRegClientes.Controls.Add(Me.BRegistrarTalle)
        Me.PanelRegClientes.Controls.Add(Me.BVolver)
        Me.PanelRegClientes.Controls.Add(Me.TBNombreTalle)
        Me.PanelRegClientes.Controls.Add(Me.LNombreTalle)
        Me.PanelRegClientes.Location = New System.Drawing.Point(35, 164)
        Me.PanelRegClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelRegClientes.Name = "PanelRegClientes"
        Me.PanelRegClientes.Size = New System.Drawing.Size(425, 222)
        Me.PanelRegClientes.TabIndex = 4
        '
        'BRegistrarTalle
        '
        Me.BRegistrarTalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BRegistrarTalle.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BRegistrarTalle.FlatAppearance.BorderSize = 2
        Me.BRegistrarTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRegistrarTalle.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BRegistrarTalle.ForeColor = System.Drawing.Color.White
        Me.BRegistrarTalle.Location = New System.Drawing.Point(130, 153)
        Me.BRegistrarTalle.Margin = New System.Windows.Forms.Padding(4)
        Me.BRegistrarTalle.Name = "BRegistrarTalle"
        Me.BRegistrarTalle.Size = New System.Drawing.Size(130, 52)
        Me.BRegistrarTalle.TabIndex = 13
        Me.BRegistrarTalle.Text = "Añadir"
        Me.BRegistrarTalle.UseVisualStyleBackColor = False
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVolver.ForeColor = System.Drawing.Color.White
        Me.BVolver.Location = New System.Drawing.Point(268, 153)
        Me.BVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(130, 52)
        Me.BVolver.TabIndex = 12
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'TBNombreTalle
        '
        Me.TBNombreTalle.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBNombreTalle.Location = New System.Drawing.Point(27, 71)
        Me.TBNombreTalle.Margin = New System.Windows.Forms.Padding(4)
        Me.TBNombreTalle.MaxLength = 2
        Me.TBNombreTalle.Name = "TBNombreTalle"
        Me.TBNombreTalle.Size = New System.Drawing.Size(371, 30)
        Me.TBNombreTalle.TabIndex = 6
        '
        'LNombreTalle
        '
        Me.LNombreTalle.AutoSize = True
        Me.LNombreTalle.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LNombreTalle.ForeColor = System.Drawing.Color.White
        Me.LNombreTalle.Location = New System.Drawing.Point(163, 21)
        Me.LNombreTalle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LNombreTalle.Name = "LNombreTalle"
        Me.LNombreTalle.Size = New System.Drawing.Size(117, 22)
        Me.LNombreTalle.TabIndex = 0
        Me.LNombreTalle.Text = "Descripcion"
        '
        'TabControlRegVentas
        '
        Me.TabControlRegVentas.Controls.Add(Me.TabPageListaTalles)
        Me.TabControlRegVentas.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlRegVentas.Location = New System.Drawing.Point(513, 103)
        Me.TabControlRegVentas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlRegVentas.Name = "TabControlRegVentas"
        Me.TabControlRegVentas.SelectedIndex = 0
        Me.TabControlRegVentas.Size = New System.Drawing.Size(584, 511)
        Me.TabControlRegVentas.TabIndex = 6
        '
        'TabPageListaTalles
        '
        Me.TabPageListaTalles.Controls.Add(Me.dgvRegistroTalles)
        Me.TabPageListaTalles.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaTalles.ForeColor = System.Drawing.Color.White
        Me.TabPageListaTalles.Location = New System.Drawing.Point(4, 28)
        Me.TabPageListaTalles.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaTalles.Name = "TabPageListaTalles"
        Me.TabPageListaTalles.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaTalles.Size = New System.Drawing.Size(576, 479)
        Me.TabPageListaTalles.TabIndex = 0
        Me.TabPageListaTalles.Text = "Lista de Talles"
        Me.TabPageListaTalles.UseVisualStyleBackColor = True
        '
        'dgvRegistroTalles
        '
        Me.dgvRegistroTalles.AllowUserToAddRows = False
        Me.dgvRegistroTalles.AllowUserToDeleteRows = False
        Me.dgvRegistroTalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRegistroTalles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvRegistroTalles.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgvRegistroTalles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRegistroTalles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRegistroTalles.ColumnHeadersHeight = 20
        Me.dgvRegistroTalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRegistroTalles.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRegistroTalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRegistroTalles.EnableHeadersVisualStyles = False
        Me.dgvRegistroTalles.Location = New System.Drawing.Point(3, 2)
        Me.dgvRegistroTalles.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvRegistroTalles.Name = "dgvRegistroTalles"
        Me.dgvRegistroTalles.ReadOnly = True
        Me.dgvRegistroTalles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvRegistroTalles.RowHeadersWidth = 51
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.dgvRegistroTalles.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRegistroTalles.Size = New System.Drawing.Size(570, 475)
        Me.dgvRegistroTalles.TabIndex = 2
        '
        'ErrorProviderTalle
        '
        Me.ErrorProviderTalle.ContainerControl = Me
        '
        'AñadirTalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1149, 656)
        Me.Controls.Add(Me.TabControlRegVentas)
        Me.Controls.Add(Me.PanelRegClientes)
        Me.Controls.Add(Me.LTalle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AñadirTalle"
        Me.Text = "AñadirTalle"
        Me.PanelRegClientes.ResumeLayout(False)
        Me.PanelRegClientes.PerformLayout()
        Me.TabControlRegVentas.ResumeLayout(False)
        Me.TabPageListaTalles.ResumeLayout(False)
        CType(Me.dgvRegistroTalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderTalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LTalle As Label
    Friend WithEvents PanelRegClientes As Panel
    Friend WithEvents BRegistrarTalle As Button
    Friend WithEvents BVolver As Button
    Friend WithEvents TBNombreTalle As TextBox
    Friend WithEvents LNombreTalle As Label
    Friend WithEvents TabControlRegVentas As TabControl
    Friend WithEvents TabPageListaTalles As TabPage
    Friend WithEvents dgvRegistroTalles As DataGridView
    Friend WithEvents ErrorProviderTalle As ErrorProvider
End Class
