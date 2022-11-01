<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AñadirMarca
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControlRegCategoria = New System.Windows.Forms.TabControl()
        Me.TabPageListaCategoria = New System.Windows.Forms.TabPage()
        Me.dgvRegistroMarca = New System.Windows.Forms.DataGridView()
        Me.LMarca = New System.Windows.Forms.Label()
        Me.PanelRegClientes = New System.Windows.Forms.Panel()
        Me.BRegistrarMarca = New System.Windows.Forms.Button()
        Me.BVolve = New System.Windows.Forms.Button()
        Me.TBNombreMarca = New System.Windows.Forms.TextBox()
        Me.LNombreMarca = New System.Windows.Forms.Label()
        Me.ErrorProviderNomMarca = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControlRegCategoria.SuspendLayout()
        Me.TabPageListaCategoria.SuspendLayout()
        CType(Me.dgvRegistroMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRegClientes.SuspendLayout()
        CType(Me.ErrorProviderNomMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControlRegCategoria
        '
        Me.TabControlRegCategoria.Controls.Add(Me.TabPageListaCategoria)
        Me.TabControlRegCategoria.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlRegCategoria.Location = New System.Drawing.Point(497, 126)
        Me.TabControlRegCategoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlRegCategoria.Name = "TabControlRegCategoria"
        Me.TabControlRegCategoria.SelectedIndex = 0
        Me.TabControlRegCategoria.Size = New System.Drawing.Size(619, 482)
        Me.TabControlRegCategoria.TabIndex = 8
        '
        'TabPageListaCategoria
        '
        Me.TabPageListaCategoria.Controls.Add(Me.dgvRegistroMarca)
        Me.TabPageListaCategoria.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaCategoria.ForeColor = System.Drawing.Color.White
        Me.TabPageListaCategoria.Location = New System.Drawing.Point(4, 28)
        Me.TabPageListaCategoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaCategoria.Name = "TabPageListaCategoria"
        Me.TabPageListaCategoria.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaCategoria.Size = New System.Drawing.Size(611, 450)
        Me.TabPageListaCategoria.TabIndex = 0
        Me.TabPageListaCategoria.Text = "Lista de Marcas"
        Me.TabPageListaCategoria.UseVisualStyleBackColor = True
        '
        'dgvRegistroMarca
        '
        Me.dgvRegistroMarca.AllowUserToAddRows = False
        Me.dgvRegistroMarca.AllowUserToDeleteRows = False
        Me.dgvRegistroMarca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRegistroMarca.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvRegistroMarca.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dgvRegistroMarca.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRegistroMarca.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRegistroMarca.ColumnHeadersHeight = 20
        Me.dgvRegistroMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRegistroMarca.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRegistroMarca.EnableHeadersVisualStyles = False
        Me.dgvRegistroMarca.Location = New System.Drawing.Point(3, 2)
        Me.dgvRegistroMarca.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvRegistroMarca.Name = "dgvRegistroMarca"
        Me.dgvRegistroMarca.ReadOnly = True
        Me.dgvRegistroMarca.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRegistroMarca.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRegistroMarca.RowHeadersWidth = 51
        Me.dgvRegistroMarca.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvRegistroMarca.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvRegistroMarca.RowTemplate.Height = 24
        Me.dgvRegistroMarca.Size = New System.Drawing.Size(605, 446)
        Me.dgvRegistroMarca.TabIndex = 0
        '
        'LMarca
        '
        Me.LMarca.AutoSize = True
        Me.LMarca.BackColor = System.Drawing.Color.Transparent
        Me.LMarca.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LMarca.ForeColor = System.Drawing.Color.Transparent
        Me.LMarca.Location = New System.Drawing.Point(33, 47)
        Me.LMarca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LMarca.Name = "LMarca"
        Me.LMarca.Size = New System.Drawing.Size(185, 33)
        Me.LMarca.TabIndex = 7
        Me.LMarca.Text = "Nueva Marca"
        '
        'PanelRegClientes
        '
        Me.PanelRegClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PanelRegClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelRegClientes.Controls.Add(Me.BRegistrarMarca)
        Me.PanelRegClientes.Controls.Add(Me.BVolve)
        Me.PanelRegClientes.Controls.Add(Me.TBNombreMarca)
        Me.PanelRegClientes.Controls.Add(Me.LNombreMarca)
        Me.PanelRegClientes.Location = New System.Drawing.Point(39, 126)
        Me.PanelRegClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelRegClientes.Name = "PanelRegClientes"
        Me.PanelRegClientes.Size = New System.Drawing.Size(425, 222)
        Me.PanelRegClientes.TabIndex = 6
        '
        'BRegistrarMarca
        '
        Me.BRegistrarMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BRegistrarMarca.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BRegistrarMarca.FlatAppearance.BorderSize = 2
        Me.BRegistrarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRegistrarMarca.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BRegistrarMarca.ForeColor = System.Drawing.Color.White
        Me.BRegistrarMarca.Location = New System.Drawing.Point(268, 149)
        Me.BRegistrarMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.BRegistrarMarca.Name = "BRegistrarMarca"
        Me.BRegistrarMarca.Size = New System.Drawing.Size(130, 52)
        Me.BRegistrarMarca.TabIndex = 13
        Me.BRegistrarMarca.Text = "Añadir"
        Me.BRegistrarMarca.UseVisualStyleBackColor = False
        '
        'BVolve
        '
        Me.BVolve.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BVolve.FlatAppearance.BorderSize = 2
        Me.BVolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolve.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVolve.ForeColor = System.Drawing.Color.White
        Me.BVolve.Location = New System.Drawing.Point(116, 149)
        Me.BVolve.Margin = New System.Windows.Forms.Padding(4)
        Me.BVolve.Name = "BVolve"
        Me.BVolve.Size = New System.Drawing.Size(130, 52)
        Me.BVolve.TabIndex = 12
        Me.BVolve.Text = "Volver"
        Me.BVolve.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BVolve.UseVisualStyleBackColor = False
        '
        'TBNombreMarca
        '
        Me.TBNombreMarca.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBNombreMarca.Location = New System.Drawing.Point(27, 71)
        Me.TBNombreMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.TBNombreMarca.Name = "TBNombreMarca"
        Me.TBNombreMarca.Size = New System.Drawing.Size(371, 30)
        Me.TBNombreMarca.TabIndex = 6
        '
        'LNombreMarca
        '
        Me.LNombreMarca.AutoSize = True
        Me.LNombreMarca.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LNombreMarca.ForeColor = System.Drawing.Color.White
        Me.LNombreMarca.Location = New System.Drawing.Point(112, 28)
        Me.LNombreMarca.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LNombreMarca.Name = "LNombreMarca"
        Me.LNombreMarca.Size = New System.Drawing.Size(190, 22)
        Me.LNombreMarca.TabIndex = 0
        Me.LNombreMarca.Text = "Nombre de la Marca"
        '
        'ErrorProviderNomMarca
        '
        Me.ErrorProviderNomMarca.ContainerControl = Me
        '
        'AñadirMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1149, 656)
        Me.Controls.Add(Me.TabControlRegCategoria)
        Me.Controls.Add(Me.LMarca)
        Me.Controls.Add(Me.PanelRegClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AñadirMarca"
        Me.Text = "AñadirMarca"
        Me.TabControlRegCategoria.ResumeLayout(False)
        Me.TabPageListaCategoria.ResumeLayout(False)
        CType(Me.dgvRegistroMarca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRegClientes.ResumeLayout(False)
        Me.PanelRegClientes.PerformLayout()
        CType(Me.ErrorProviderNomMarca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControlRegCategoria As TabControl
    Friend WithEvents TabPageListaCategoria As TabPage
    Friend WithEvents dgvRegistroMarca As DataGridView
    Friend WithEvents LMarca As Label
    Friend WithEvents PanelRegClientes As Panel
    Friend WithEvents BRegistrarMarca As Button
    Friend WithEvents BVolve As Button
    Friend WithEvents TBNombreMarca As TextBox
    Friend WithEvents LNombreMarca As Label
    Friend WithEvents ErrorProviderNomMarca As ErrorProvider
End Class
