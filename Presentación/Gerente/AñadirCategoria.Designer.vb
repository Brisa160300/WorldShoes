<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Añadir_Categoria
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
        Me.TBNombreCategoria = New System.Windows.Forms.TextBox()
        Me.LNombreCategoria = New System.Windows.Forms.Label()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.BRegistrarCategoria = New System.Windows.Forms.Button()
        Me.PanelRegClientes = New System.Windows.Forms.Panel()
        Me.TabPageListaCategoria = New System.Windows.Forms.TabPage()
        Me.dgvRegistroCategoria = New System.Windows.Forms.DataGridView()
        Me.TabControlRegCategoria = New System.Windows.Forms.TabControl()
        Me.PanelRegClientes.SuspendLayout()
        Me.TabPageListaCategoria.SuspendLayout()
        CType(Me.dgvRegistroCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlRegCategoria.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBNombreCategoria
        '
        Me.TBNombreCategoria.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBNombreCategoria.Location = New System.Drawing.Point(27, 71)
        Me.TBNombreCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.TBNombreCategoria.Name = "TBNombreCategoria"
        Me.TBNombreCategoria.Size = New System.Drawing.Size(371, 30)
        Me.TBNombreCategoria.TabIndex = 6
        '
        'LNombreCategoria
        '
        Me.LNombreCategoria.AutoSize = True
        Me.LNombreCategoria.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LNombreCategoria.ForeColor = System.Drawing.Color.White
        Me.LNombreCategoria.Location = New System.Drawing.Point(112, 28)
        Me.LNombreCategoria.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LNombreCategoria.Name = "LNombreCategoria"
        Me.LNombreCategoria.Size = New System.Drawing.Size(199, 22)
        Me.LNombreCategoria.TabIndex = 0
        Me.LNombreCategoria.Text = "Nombre de Categoria"
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.BackColor = System.Drawing.Color.Transparent
        Me.LCategoria.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCategoria.ForeColor = System.Drawing.Color.Transparent
        Me.LCategoria.Location = New System.Drawing.Point(29, 49)
        Me.LCategoria.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(231, 33)
        Me.LCategoria.TabIndex = 2
        Me.LCategoria.Text = "Nueva Categoria"
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVolver.ForeColor = System.Drawing.Color.White
        Me.BVolver.Location = New System.Drawing.Point(95, 142)
        Me.BVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(130, 52)
        Me.BVolver.TabIndex = 12
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'BRegistrarCategoria
        '
        Me.BRegistrarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BRegistrarCategoria.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BRegistrarCategoria.FlatAppearance.BorderSize = 2
        Me.BRegistrarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRegistrarCategoria.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BRegistrarCategoria.ForeColor = System.Drawing.Color.White
        Me.BRegistrarCategoria.Location = New System.Drawing.Point(233, 142)
        Me.BRegistrarCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.BRegistrarCategoria.Name = "BRegistrarCategoria"
        Me.BRegistrarCategoria.Size = New System.Drawing.Size(130, 52)
        Me.BRegistrarCategoria.TabIndex = 13
        Me.BRegistrarCategoria.Text = "Añadir"
        Me.BRegistrarCategoria.UseVisualStyleBackColor = False
        '
        'PanelRegClientes
        '
        Me.PanelRegClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PanelRegClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelRegClientes.Controls.Add(Me.BRegistrarCategoria)
        Me.PanelRegClientes.Controls.Add(Me.BVolver)
        Me.PanelRegClientes.Controls.Add(Me.TBNombreCategoria)
        Me.PanelRegClientes.Controls.Add(Me.LNombreCategoria)
        Me.PanelRegClientes.Location = New System.Drawing.Point(35, 128)
        Me.PanelRegClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelRegClientes.Name = "PanelRegClientes"
        Me.PanelRegClientes.Size = New System.Drawing.Size(425, 222)
        Me.PanelRegClientes.TabIndex = 1
        '
        'TabPageListaCategoria
        '
        Me.TabPageListaCategoria.Controls.Add(Me.dgvRegistroCategoria)
        Me.TabPageListaCategoria.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaCategoria.ForeColor = System.Drawing.Color.White
        Me.TabPageListaCategoria.Location = New System.Drawing.Point(4, 28)
        Me.TabPageListaCategoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaCategoria.Name = "TabPageListaCategoria"
        Me.TabPageListaCategoria.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaCategoria.Size = New System.Drawing.Size(611, 450)
        Me.TabPageListaCategoria.TabIndex = 0
        Me.TabPageListaCategoria.Text = "Lista de Categoria"
        Me.TabPageListaCategoria.UseVisualStyleBackColor = True
        '
        'dgvRegistroCategoria
        '
        Me.dgvRegistroCategoria.AllowUserToAddRows = False
        Me.dgvRegistroCategoria.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvRegistroCategoria.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRegistroCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRegistroCategoria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvRegistroCategoria.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dgvRegistroCategoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRegistroCategoria.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRegistroCategoria.ColumnHeadersHeight = 20
        Me.dgvRegistroCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRegistroCategoria.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRegistroCategoria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRegistroCategoria.EnableHeadersVisualStyles = False
        Me.dgvRegistroCategoria.Location = New System.Drawing.Point(3, 2)
        Me.dgvRegistroCategoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvRegistroCategoria.Name = "dgvRegistroCategoria"
        Me.dgvRegistroCategoria.ReadOnly = True
        Me.dgvRegistroCategoria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRegistroCategoria.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvRegistroCategoria.RowHeadersWidth = 51
        Me.dgvRegistroCategoria.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvRegistroCategoria.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgvRegistroCategoria.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvRegistroCategoria.RowTemplate.Height = 24
        Me.dgvRegistroCategoria.Size = New System.Drawing.Size(605, 446)
        Me.dgvRegistroCategoria.TabIndex = 0
        '
        'TabControlRegCategoria
        '
        Me.TabControlRegCategoria.Controls.Add(Me.TabPageListaCategoria)
        Me.TabControlRegCategoria.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlRegCategoria.Location = New System.Drawing.Point(493, 128)
        Me.TabControlRegCategoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlRegCategoria.Name = "TabControlRegCategoria"
        Me.TabControlRegCategoria.SelectedIndex = 0
        Me.TabControlRegCategoria.Size = New System.Drawing.Size(619, 482)
        Me.TabControlRegCategoria.TabIndex = 5
        '
        'Añadir_Categoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1149, 656)
        Me.Controls.Add(Me.TabControlRegCategoria)
        Me.Controls.Add(Me.LCategoria)
        Me.Controls.Add(Me.PanelRegClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Añadir_Categoria"
        Me.Text = "Añadir_Categoria"
        Me.PanelRegClientes.ResumeLayout(False)
        Me.PanelRegClientes.PerformLayout()
        Me.TabPageListaCategoria.ResumeLayout(False)
        CType(Me.dgvRegistroCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlRegCategoria.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBNombreCategoria As TextBox
    Friend WithEvents LNombreCategoria As Label
    Friend WithEvents LCategoria As Label
    Friend WithEvents BVolver As Button
    Friend WithEvents BRegistrarCategoria As Button
    Friend WithEvents PanelRegClientes As Panel
    Friend WithEvents TabPageListaCategoria As TabPage
    Friend WithEvents dgvRegistroCategoria As DataGridView
    Friend WithEvents TabControlRegCategoria As TabControl
End Class
