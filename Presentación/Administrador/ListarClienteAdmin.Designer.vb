<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ListarClienteAdmin
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
        Me.BVolver = New System.Windows.Forms.Button()
        Me.BEditarCliente = New System.Windows.Forms.Button()
        Me.BImprimirClientes = New System.Windows.Forms.Button()
        Me.TabControlListaClientes = New System.Windows.Forms.TabControl()
        Me.TabPafeListaClientes = New System.Windows.Forms.TabPage()
        Me.dgvListarClientes = New System.Windows.Forms.DataGridView()
        Me.GroupBoxClientes = New System.Windows.Forms.GroupBox()
        Me.ComboBoxBuscarDni = New System.Windows.Forms.ComboBox()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.TabControlListaClientes.SuspendLayout()
        Me.TabPafeListaClientes.SuspendLayout()
        CType(Me.dgvListarClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVolver.ForeColor = System.Drawing.Color.White
        Me.BVolver.Location = New System.Drawing.Point(902, 564)
        Me.BVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(130, 52)
        Me.BVolver.TabIndex = 30
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
        Me.BEditarCliente.Location = New System.Drawing.Point(1055, 381)
        Me.BEditarCliente.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BEditarCliente.Name = "BEditarCliente"
        Me.BEditarCliente.Size = New System.Drawing.Size(60, 50)
        Me.BEditarCliente.TabIndex = 29
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
        Me.BImprimirClientes.Location = New System.Drawing.Point(1055, 310)
        Me.BImprimirClientes.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BImprimirClientes.Name = "BImprimirClientes"
        Me.BImprimirClientes.Size = New System.Drawing.Size(60, 50)
        Me.BImprimirClientes.TabIndex = 26
        Me.BImprimirClientes.UseVisualStyleBackColor = False
        Me.BImprimirClientes.Visible = False
        '
        'TabControlListaClientes
        '
        Me.TabControlListaClientes.Controls.Add(Me.TabPafeListaClientes)
        Me.TabControlListaClientes.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TabControlListaClientes.Location = New System.Drawing.Point(36, 217)
        Me.TabControlListaClientes.Name = "TabControlListaClientes"
        Me.TabControlListaClientes.SelectedIndex = 0
        Me.TabControlListaClientes.Size = New System.Drawing.Size(996, 330)
        Me.TabControlListaClientes.TabIndex = 28
        '
        'TabPafeListaClientes
        '
        Me.TabPafeListaClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.TabPafeListaClientes.Controls.Add(Me.dgvListarClientes)
        Me.TabPafeListaClientes.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TabPafeListaClientes.ForeColor = System.Drawing.Color.White
        Me.TabPafeListaClientes.Location = New System.Drawing.Point(4, 31)
        Me.TabPafeListaClientes.Name = "TabPafeListaClientes"
        Me.TabPafeListaClientes.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPafeListaClientes.Size = New System.Drawing.Size(988, 295)
        Me.TabPafeListaClientes.TabIndex = 0
        Me.TabPafeListaClientes.Text = "Lista de Clientes"
        '
        'dgvListarClientes
        '
        Me.dgvListarClientes.AllowUserToAddRows = False
        Me.dgvListarClientes.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.dgvListarClientes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListarClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListarClientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgvListarClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListarClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListarClientes.ColumnHeadersHeight = 29
        Me.dgvListarClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListarClientes.EnableHeadersVisualStyles = False
        Me.dgvListarClientes.Location = New System.Drawing.Point(3, 3)
        Me.dgvListarClientes.Margin = New System.Windows.Forms.Padding(5)
        Me.dgvListarClientes.Name = "dgvListarClientes"
        Me.dgvListarClientes.ReadOnly = True
        Me.dgvListarClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListarClientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListarClientes.RowHeadersWidth = 51
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgvListarClientes.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvListarClientes.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.dgvListarClientes.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvListarClientes.Size = New System.Drawing.Size(982, 289)
        Me.dgvListarClientes.TabIndex = 5
        '
        'GroupBoxClientes
        '
        Me.GroupBoxClientes.Controls.Add(Me.ComboBoxBuscarDni)
        Me.GroupBoxClientes.Controls.Add(Me.TBBuscar)
        Me.GroupBoxClientes.Controls.Add(Me.BBuscar)
        Me.GroupBoxClientes.Font = New System.Drawing.Font("Britannic Bold", 18.0!)
        Me.GroupBoxClientes.ForeColor = System.Drawing.Color.White
        Me.GroupBoxClientes.Location = New System.Drawing.Point(36, 41)
        Me.GroupBoxClientes.Name = "GroupBoxClientes"
        Me.GroupBoxClientes.Size = New System.Drawing.Size(996, 137)
        Me.GroupBoxClientes.TabIndex = 27
        Me.GroupBoxClientes.TabStop = False
        Me.GroupBoxClientes.Text = "Clientes"
        '
        'ComboBoxBuscarDni
        '
        Me.ComboBoxBuscarDni.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.ComboBoxBuscarDni.FormattingEnabled = True
        Me.ComboBoxBuscarDni.Location = New System.Drawing.Point(444, 59)
        Me.ComboBoxBuscarDni.Name = "ComboBoxBuscarDni"
        Me.ComboBoxBuscarDni.Size = New System.Drawing.Size(142, 30)
        Me.ComboBoxBuscarDni.TabIndex = 10
        Me.ComboBoxBuscarDni.Text = "DNI"
        '
        'TBBuscar
        '
        Me.TBBuscar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!)
        Me.TBBuscar.Location = New System.Drawing.Point(610, 59)
        Me.TBBuscar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TBBuscar.Name = "TBBuscar"
        Me.TBBuscar.Size = New System.Drawing.Size(290, 29)
        Me.TBBuscar.TabIndex = 8
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
        'BEliminar
        '
        Me.BEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BEliminar.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.impresora
        Me.BEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEliminar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.8!, System.Drawing.FontStyle.Bold)
        Me.BEliminar.ForeColor = System.Drawing.Color.White
        Me.BEliminar.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.trash_6_32
        Me.BEliminar.Location = New System.Drawing.Point(1055, 451)
        Me.BEliminar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(60, 50)
        Me.BEliminar.TabIndex = 31
        Me.BEliminar.UseVisualStyleBackColor = False
        '
        'Modificar_Clientes_Adminvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 656)
        Me.Controls.Add(Me.BEliminar)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.BEditarCliente)
        Me.Controls.Add(Me.BImprimirClientes)
        Me.Controls.Add(Me.TabControlListaClientes)
        Me.Controls.Add(Me.GroupBoxClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Modificar_Clientes_Adminvb"
        Me.TabControlListaClientes.ResumeLayout(False)
        Me.TabPafeListaClientes.ResumeLayout(False)
        CType(Me.dgvListarClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxClientes.ResumeLayout(False)
        Me.GroupBoxClientes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BVolver As Button
    Friend WithEvents BEditarCliente As Button
    Friend WithEvents BImprimirClientes As Button
    Friend WithEvents TabControlListaClientes As TabControl
    Friend WithEvents TabPafeListaClientes As TabPage
    Friend WithEvents dgvListarClientes As DataGridView
    Friend WithEvents GroupBoxClientes As GroupBox
    Friend WithEvents ComboBoxBuscarDni As ComboBox
    Friend WithEvents TBBuscar As TextBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents BEliminar As Button
End Class
