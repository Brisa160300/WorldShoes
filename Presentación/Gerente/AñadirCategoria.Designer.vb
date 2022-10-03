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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TBNombreCategoria = New System.Windows.Forms.TextBox()
        Me.LNombreCategoria = New System.Windows.Forms.Label()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.BCancelarCategoria = New System.Windows.Forms.Button()
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
        Me.TBNombreCategoria.Location = New System.Drawing.Point(20, 58)
        Me.TBNombreCategoria.Name = "TBNombreCategoria"
        Me.TBNombreCategoria.Size = New System.Drawing.Size(279, 25)
        Me.TBNombreCategoria.TabIndex = 6
        '
        'LNombreCategoria
        '
        Me.LNombreCategoria.AutoSize = True
        Me.LNombreCategoria.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LNombreCategoria.ForeColor = System.Drawing.Color.White
        Me.LNombreCategoria.Location = New System.Drawing.Point(84, 23)
        Me.LNombreCategoria.Name = "LNombreCategoria"
        Me.LNombreCategoria.Size = New System.Drawing.Size(159, 17)
        Me.LNombreCategoria.TabIndex = 0
        Me.LNombreCategoria.Text = "Nombre de Categoria"
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.BackColor = System.Drawing.Color.Transparent
        Me.LCategoria.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCategoria.ForeColor = System.Drawing.Color.Transparent
        Me.LCategoria.Location = New System.Drawing.Point(22, 40)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(186, 27)
        Me.LCategoria.TabIndex = 2
        Me.LCategoria.Text = "Nueva Categoria"
        '
        'BCancelarCategoria
        '
        Me.BCancelarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BCancelarCategoria.FlatAppearance.BorderSize = 2
        Me.BCancelarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelarCategoria.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelarCategoria.ForeColor = System.Drawing.Color.White
        Me.BCancelarCategoria.Location = New System.Drawing.Point(225, 126)
        Me.BCancelarCategoria.Name = "BCancelarCategoria"
        Me.BCancelarCategoria.Size = New System.Drawing.Size(74, 26)
        Me.BCancelarCategoria.TabIndex = 12
        Me.BCancelarCategoria.Text = "Cancelar"
        Me.BCancelarCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelarCategoria.UseVisualStyleBackColor = False
        '
        'BRegistrarCategoria
        '
        Me.BRegistrarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BRegistrarCategoria.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BRegistrarCategoria.FlatAppearance.BorderSize = 2
        Me.BRegistrarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRegistrarCategoria.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BRegistrarCategoria.ForeColor = System.Drawing.Color.White
        Me.BRegistrarCategoria.Location = New System.Drawing.Point(134, 126)
        Me.BRegistrarCategoria.Name = "BRegistrarCategoria"
        Me.BRegistrarCategoria.Size = New System.Drawing.Size(73, 26)
        Me.BRegistrarCategoria.TabIndex = 13
        Me.BRegistrarCategoria.Text = "Registrar"
        Me.BRegistrarCategoria.UseVisualStyleBackColor = False
        '
        'PanelRegClientes
        '
        Me.PanelRegClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PanelRegClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelRegClientes.Controls.Add(Me.BRegistrarCategoria)
        Me.PanelRegClientes.Controls.Add(Me.BCancelarCategoria)
        Me.PanelRegClientes.Controls.Add(Me.TBNombreCategoria)
        Me.PanelRegClientes.Controls.Add(Me.LNombreCategoria)
        Me.PanelRegClientes.Location = New System.Drawing.Point(26, 104)
        Me.PanelRegClientes.Name = "PanelRegClientes"
        Me.PanelRegClientes.Size = New System.Drawing.Size(319, 180)
        Me.PanelRegClientes.TabIndex = 1
        '
        'TabPageListaCategoria
        '
        Me.TabPageListaCategoria.Controls.Add(Me.dgvRegistroCategoria)
        Me.TabPageListaCategoria.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaCategoria.ForeColor = System.Drawing.Color.White
        Me.TabPageListaCategoria.Location = New System.Drawing.Point(4, 25)
        Me.TabPageListaCategoria.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPageListaCategoria.Name = "TabPageListaCategoria"
        Me.TabPageListaCategoria.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPageListaCategoria.Size = New System.Drawing.Size(456, 363)
        Me.TabPageListaCategoria.TabIndex = 0
        Me.TabPageListaCategoria.Text = "Lista de Categoria"
        Me.TabPageListaCategoria.UseVisualStyleBackColor = True
        '
        'dgvRegistroCategoria
        '
        Me.dgvRegistroCategoria.AllowUserToDeleteRows = False
        Me.dgvRegistroCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRegistroCategoria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvRegistroCategoria.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dgvRegistroCategoria.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRegistroCategoria.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRegistroCategoria.ColumnHeadersHeight = 20
        Me.dgvRegistroCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRegistroCategoria.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRegistroCategoria.EnableHeadersVisualStyles = False
        Me.dgvRegistroCategoria.Location = New System.Drawing.Point(2, 2)
        Me.dgvRegistroCategoria.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvRegistroCategoria.Name = "dgvRegistroCategoria"
        Me.dgvRegistroCategoria.ReadOnly = True
        Me.dgvRegistroCategoria.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRegistroCategoria.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvRegistroCategoria.RowHeadersWidth = 51
        Me.dgvRegistroCategoria.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvRegistroCategoria.RowTemplate.Height = 24
        Me.dgvRegistroCategoria.Size = New System.Drawing.Size(452, 359)
        Me.dgvRegistroCategoria.TabIndex = 0
        '
        'TabControlRegCategoria
        '
        Me.TabControlRegCategoria.Controls.Add(Me.TabPageListaCategoria)
        Me.TabControlRegCategoria.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlRegCategoria.Location = New System.Drawing.Point(370, 104)
        Me.TabControlRegCategoria.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControlRegCategoria.Name = "TabControlRegCategoria"
        Me.TabControlRegCategoria.SelectedIndex = 0
        Me.TabControlRegCategoria.Size = New System.Drawing.Size(464, 392)
        Me.TabControlRegCategoria.TabIndex = 5
        '
        'Añadir_Categoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(862, 533)
        Me.Controls.Add(Me.TabControlRegCategoria)
        Me.Controls.Add(Me.LCategoria)
        Me.Controls.Add(Me.PanelRegClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
    Friend WithEvents BCancelarCategoria As Button
    Friend WithEvents BRegistrarCategoria As Button
    Friend WithEvents PanelRegClientes As Panel
    Friend WithEvents TabPageListaCategoria As TabPage
    Friend WithEvents dgvRegistroCategoria As DataGridView
    Friend WithEvents TabControlRegCategoria As TabControl
End Class
