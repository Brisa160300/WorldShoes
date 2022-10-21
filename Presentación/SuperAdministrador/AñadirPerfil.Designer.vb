<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AñadirPerfil
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
        Me.TabControlRegPerfil = New System.Windows.Forms.TabControl()
        Me.TabPageListaPerfil = New System.Windows.Forms.TabPage()
        Me.dgvRegistroPerfil = New System.Windows.Forms.DataGridView()
        Me.LPerfil = New System.Windows.Forms.Label()
        Me.PanelRegClientes = New System.Windows.Forms.Panel()
        Me.BRegistrarPerfil = New System.Windows.Forms.Button()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.TBNombrePerfil = New System.Windows.Forms.TextBox()
        Me.LNombrePerfil = New System.Windows.Forms.Label()
        Me.TabControlRegPerfil.SuspendLayout()
        Me.TabPageListaPerfil.SuspendLayout()
        CType(Me.dgvRegistroPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRegClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlRegPerfil
        '
        Me.TabControlRegPerfil.Controls.Add(Me.TabPageListaPerfil)
        Me.TabControlRegPerfil.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlRegPerfil.Location = New System.Drawing.Point(498, 127)
        Me.TabControlRegPerfil.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlRegPerfil.Name = "TabControlRegPerfil"
        Me.TabControlRegPerfil.SelectedIndex = 0
        Me.TabControlRegPerfil.Size = New System.Drawing.Size(619, 482)
        Me.TabControlRegPerfil.TabIndex = 11
        '
        'TabPageListaPerfil
        '
        Me.TabPageListaPerfil.Controls.Add(Me.dgvRegistroPerfil)
        Me.TabPageListaPerfil.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaPerfil.ForeColor = System.Drawing.Color.White
        Me.TabPageListaPerfil.Location = New System.Drawing.Point(4, 28)
        Me.TabPageListaPerfil.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaPerfil.Name = "TabPageListaPerfil"
        Me.TabPageListaPerfil.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaPerfil.Size = New System.Drawing.Size(611, 450)
        Me.TabPageListaPerfil.TabIndex = 0
        Me.TabPageListaPerfil.Text = "Lista de Perfil"
        Me.TabPageListaPerfil.UseVisualStyleBackColor = True
        '
        'dgvRegistroPerfil
        '
        Me.dgvRegistroPerfil.AllowUserToAddRows = False
        Me.dgvRegistroPerfil.AllowUserToDeleteRows = False
        Me.dgvRegistroPerfil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvRegistroPerfil.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvRegistroPerfil.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.dgvRegistroPerfil.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRegistroPerfil.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRegistroPerfil.ColumnHeadersHeight = 20
        Me.dgvRegistroPerfil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvRegistroPerfil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRegistroPerfil.EnableHeadersVisualStyles = False
        Me.dgvRegistroPerfil.Location = New System.Drawing.Point(3, 2)
        Me.dgvRegistroPerfil.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvRegistroPerfil.Name = "dgvRegistroPerfil"
        Me.dgvRegistroPerfil.ReadOnly = True
        Me.dgvRegistroPerfil.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRegistroPerfil.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRegistroPerfil.RowHeadersWidth = 51
        Me.dgvRegistroPerfil.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvRegistroPerfil.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvRegistroPerfil.RowTemplate.Height = 24
        Me.dgvRegistroPerfil.Size = New System.Drawing.Size(605, 446)
        Me.dgvRegistroPerfil.TabIndex = 0
        '
        'LPerfil
        '
        Me.LPerfil.AutoSize = True
        Me.LPerfil.BackColor = System.Drawing.Color.Transparent
        Me.LPerfil.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPerfil.ForeColor = System.Drawing.Color.Transparent
        Me.LPerfil.Location = New System.Drawing.Point(34, 48)
        Me.LPerfil.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LPerfil.Name = "LPerfil"
        Me.LPerfil.Size = New System.Drawing.Size(174, 33)
        Me.LPerfil.TabIndex = 10
        Me.LPerfil.Text = "Nueva Perfil"
        '
        'PanelRegClientes
        '
        Me.PanelRegClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PanelRegClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelRegClientes.Controls.Add(Me.BRegistrarPerfil)
        Me.PanelRegClientes.Controls.Add(Me.BVolver)
        Me.PanelRegClientes.Controls.Add(Me.TBNombrePerfil)
        Me.PanelRegClientes.Controls.Add(Me.LNombrePerfil)
        Me.PanelRegClientes.Location = New System.Drawing.Point(40, 127)
        Me.PanelRegClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelRegClientes.Name = "PanelRegClientes"
        Me.PanelRegClientes.Size = New System.Drawing.Size(425, 222)
        Me.PanelRegClientes.TabIndex = 9
        '
        'BRegistrarPerfil
        '
        Me.BRegistrarPerfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BRegistrarPerfil.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BRegistrarPerfil.FlatAppearance.BorderSize = 2
        Me.BRegistrarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRegistrarPerfil.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BRegistrarPerfil.ForeColor = System.Drawing.Color.White
        Me.BRegistrarPerfil.Location = New System.Drawing.Point(268, 149)
        Me.BRegistrarPerfil.Margin = New System.Windows.Forms.Padding(4)
        Me.BRegistrarPerfil.Name = "BRegistrarPerfil"
        Me.BRegistrarPerfil.Size = New System.Drawing.Size(130, 52)
        Me.BRegistrarPerfil.TabIndex = 13
        Me.BRegistrarPerfil.Text = "Añadir"
        Me.BRegistrarPerfil.UseVisualStyleBackColor = False
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVolver.ForeColor = System.Drawing.Color.White
        Me.BVolver.Location = New System.Drawing.Point(116, 149)
        Me.BVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(130, 52)
        Me.BVolver.TabIndex = 12
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'TBNombrePerfil
        '
        Me.TBNombrePerfil.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBNombrePerfil.Location = New System.Drawing.Point(27, 71)
        Me.TBNombrePerfil.Margin = New System.Windows.Forms.Padding(4)
        Me.TBNombrePerfil.Name = "TBNombrePerfil"
        Me.TBNombrePerfil.Size = New System.Drawing.Size(371, 30)
        Me.TBNombrePerfil.TabIndex = 6
        '
        'LNombrePerfil
        '
        Me.LNombrePerfil.AutoSize = True
        Me.LNombrePerfil.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LNombrePerfil.ForeColor = System.Drawing.Color.White
        Me.LNombrePerfil.Location = New System.Drawing.Point(112, 28)
        Me.LNombrePerfil.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LNombrePerfil.Name = "LNombrePerfil"
        Me.LNombrePerfil.Size = New System.Drawing.Size(182, 22)
        Me.LNombrePerfil.TabIndex = 0
        Me.LNombrePerfil.Text = "Nombre de la Perfil"
        '
        'AñadirPerfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 656)
        Me.Controls.Add(Me.TabControlRegPerfil)
        Me.Controls.Add(Me.LPerfil)
        Me.Controls.Add(Me.PanelRegClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AñadirPerfil"
        Me.Text = "AñadirPerfil"
        Me.TabControlRegPerfil.ResumeLayout(False)
        Me.TabPageListaPerfil.ResumeLayout(False)
        CType(Me.dgvRegistroPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRegClientes.ResumeLayout(False)
        Me.PanelRegClientes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControlRegPerfil As TabControl
    Friend WithEvents TabPageListaPerfil As TabPage
    Friend WithEvents dgvRegistroPerfil As DataGridView
    Friend WithEvents LPerfil As Label
    Friend WithEvents PanelRegClientes As Panel
    Friend WithEvents BRegistrarPerfil As Button
    Friend WithEvents BVolver As Button
    Friend WithEvents TBNombrePerfil As TextBox
    Friend WithEvents LNombrePerfil As Label
End Class
