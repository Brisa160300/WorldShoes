<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListarClientes
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvListarClientes = New System.Windows.Forms.DataGridView()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.ComboBoxBuscarDni = New System.Windows.Forms.ComboBox()
        Me.GroupBoxClientes = New System.Windows.Forms.GroupBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.TabControlListaClientes = New System.Windows.Forms.TabControl()
        Me.TabPafeListaClientes = New System.Windows.Forms.TabPage()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.BEditarCliente = New System.Windows.Forms.Button()
        Me.BImprimirClientes = New System.Windows.Forms.Button()
        CType(Me.dgvListarClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxClientes.SuspendLayout()
        Me.TabControlListaClientes.SuspendLayout()
        Me.TabPafeListaClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvListarClientes
        '
        Me.dgvListarClientes.AllowUserToAddRows = False
        Me.dgvListarClientes.AllowUserToDeleteRows = False
        Me.dgvListarClientes.AllowUserToOrderColumns = True
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgvListarClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvListarClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListarClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListarClientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgvListarClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListarClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvListarClientes.ColumnHeadersHeight = 29
        Me.dgvListarClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListarClientes.EnableHeadersVisualStyles = False
        Me.dgvListarClientes.Location = New System.Drawing.Point(3, 3)
        Me.dgvListarClientes.Margin = New System.Windows.Forms.Padding(5)
        Me.dgvListarClientes.Name = "dgvListarClientes"
        Me.dgvListarClientes.ReadOnly = True
        Me.dgvListarClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListarClientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvListarClientes.RowHeadersWidth = 51
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        Me.dgvListarClientes.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvListarClientes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.dgvListarClientes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvListarClientes.Size = New System.Drawing.Size(982, 294)
        Me.dgvListarClientes.TabIndex = 5
        '
        'TBBuscar
        '
        Me.TBBuscar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!)
        Me.TBBuscar.Location = New System.Drawing.Point(610, 59)
        Me.TBBuscar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TBBuscar.Name = "TBBuscar"
        Me.TBBuscar.Size = New System.Drawing.Size(290, 24)
        Me.TBBuscar.TabIndex = 8
        '
        'ComboBoxBuscarDni
        '
        Me.ComboBoxBuscarDni.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxBuscarDni.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxBuscarDni.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.ComboBoxBuscarDni.FormattingEnabled = True
        Me.ComboBoxBuscarDni.Location = New System.Drawing.Point(444, 59)
        Me.ComboBoxBuscarDni.Name = "ComboBoxBuscarDni"
        Me.ComboBoxBuscarDni.Size = New System.Drawing.Size(142, 25)
        Me.ComboBoxBuscarDni.TabIndex = 10
        Me.ComboBoxBuscarDni.Text = "DNI"
        '
        'GroupBoxClientes
        '
        Me.GroupBoxClientes.Controls.Add(Me.ComboBoxBuscarDni)
        Me.GroupBoxClientes.Controls.Add(Me.TBBuscar)
        Me.GroupBoxClientes.Controls.Add(Me.BBuscar)
        Me.GroupBoxClientes.Font = New System.Drawing.Font("Britannic Bold", 18.0!)
        Me.GroupBoxClientes.ForeColor = System.Drawing.Color.White
        Me.GroupBoxClientes.Location = New System.Drawing.Point(43, 36)
        Me.GroupBoxClientes.Name = "GroupBoxClientes"
        Me.GroupBoxClientes.Size = New System.Drawing.Size(996, 137)
        Me.GroupBoxClientes.TabIndex = 11
        Me.GroupBoxClientes.TabStop = False
        Me.GroupBoxClientes.Text = "Clientes"
        '
        'BBuscar
        '
        Me.BBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBuscar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.8!, System.Drawing.FontStyle.Bold)
        Me.BBuscar.ForeColor = System.Drawing.Color.White
        Me.BBuscar.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.search_3_32
        Me.BBuscar.Location = New System.Drawing.Point(909, 49)
        Me.BBuscar.Margin = New System.Windows.Forms.Padding(5)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(50, 50)
        Me.BBuscar.TabIndex = 2
        Me.BBuscar.UseVisualStyleBackColor = False
        '
        'TabControlListaClientes
        '
        Me.TabControlListaClientes.Controls.Add(Me.TabPafeListaClientes)
        Me.TabControlListaClientes.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TabControlListaClientes.Location = New System.Drawing.Point(43, 212)
        Me.TabControlListaClientes.Name = "TabControlListaClientes"
        Me.TabControlListaClientes.SelectedIndex = 0
        Me.TabControlListaClientes.Size = New System.Drawing.Size(996, 330)
        Me.TabControlListaClientes.TabIndex = 12
        '
        'TabPafeListaClientes
        '
        Me.TabPafeListaClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.TabPafeListaClientes.Controls.Add(Me.dgvListarClientes)
        Me.TabPafeListaClientes.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TabPafeListaClientes.ForeColor = System.Drawing.Color.White
        Me.TabPafeListaClientes.Location = New System.Drawing.Point(4, 26)
        Me.TabPafeListaClientes.Name = "TabPafeListaClientes"
        Me.TabPafeListaClientes.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPafeListaClientes.Size = New System.Drawing.Size(988, 300)
        Me.TabPafeListaClientes.TabIndex = 0
        Me.TabPafeListaClientes.Text = "Lista de Clientes"
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVolver.ForeColor = System.Drawing.Color.White
        Me.BVolver.Location = New System.Drawing.Point(909, 570)
        Me.BVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(130, 52)
        Me.BVolver.TabIndex = 25
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'BEditarCliente
        '
        Me.BEditarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BEditarCliente.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.impresora
        Me.BEditarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEditarCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.8!, System.Drawing.FontStyle.Bold)
        Me.BEditarCliente.ForeColor = System.Drawing.Color.White
        Me.BEditarCliente.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.edit_12_32
        Me.BEditarCliente.Location = New System.Drawing.Point(1062, 376)
        Me.BEditarCliente.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BEditarCliente.Name = "BEditarCliente"
        Me.BEditarCliente.Size = New System.Drawing.Size(60, 50)
        Me.BEditarCliente.TabIndex = 13
        Me.BEditarCliente.UseVisualStyleBackColor = False
        '
        'BImprimirClientes
        '
        Me.BImprimirClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BImprimirClientes.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.impresora
        Me.BImprimirClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BImprimirClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BImprimirClientes.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.8!, System.Drawing.FontStyle.Bold)
        Me.BImprimirClientes.ForeColor = System.Drawing.Color.White
        Me.BImprimirClientes.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.printer_4_32
        Me.BImprimirClientes.Location = New System.Drawing.Point(1062, 305)
        Me.BImprimirClientes.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BImprimirClientes.Name = "BImprimirClientes"
        Me.BImprimirClientes.Size = New System.Drawing.Size(60, 50)
        Me.BImprimirClientes.TabIndex = 4
        Me.BImprimirClientes.UseVisualStyleBackColor = False
        Me.BImprimirClientes.Visible = False
        '
        'ListarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 656)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.BEditarCliente)
        Me.Controls.Add(Me.BImprimirClientes)
        Me.Controls.Add(Me.TabControlListaClientes)
        Me.Controls.Add(Me.GroupBoxClientes)
        Me.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Name = "ListarClientes"
        Me.Text = "5q2"
        CType(Me.dgvListarClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxClientes.ResumeLayout(False)
        Me.GroupBoxClientes.PerformLayout()
        Me.TabControlListaClientes.ResumeLayout(False)
        Me.TabPafeListaClientes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BBuscar As Button
    Friend WithEvents BImprimirClientes As Button
    Friend WithEvents dgvListarClientes As DataGridView
    Friend WithEvents TBBuscar As TextBox
    Friend WithEvents ComboBoxBuscarDni As ComboBox
    Friend WithEvents GroupBoxClientes As GroupBox
    Friend WithEvents TabControlListaClientes As TabControl
    Friend WithEvents TabPafeListaClientes As TabPage
    Friend WithEvents BEditarCliente As Button
    Friend WithEvents BVolver As Button
End Class
