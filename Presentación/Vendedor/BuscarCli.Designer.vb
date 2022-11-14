<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BuscarCli
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BSeleccionar = New System.Windows.Forms.Button()
        Me.dgvListarCliente = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBoxClientes = New System.Windows.Forms.GroupBox()
        Me.LDni = New System.Windows.Forms.Label()
        Me.CBBuscar = New System.Windows.Forms.ComboBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControlListaClientes = New System.Windows.Forms.TabControl()
        Me.TabPafeListaClientes = New System.Windows.Forms.TabPage()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvListarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBoxClientes.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControlListaClientes.SuspendLayout()
        Me.TabPafeListaClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Panel3.Controls.Add(Me.BCancelar)
        Me.Panel3.Controls.Add(Me.BSeleccionar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 394)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(983, 84)
        Me.Panel3.TabIndex = 28
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BCancelar.FlatAppearance.BorderSize = 2
        Me.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelar.Font = New System.Drawing.Font("Britannic Bold", 11.0!)
        Me.BCancelar.ForeColor = System.Drawing.Color.White
        Me.BCancelar.Location = New System.Drawing.Point(485, 17)
        Me.BCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(129, 52)
        Me.BCancelar.TabIndex = 26
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelar.UseVisualStyleBackColor = False
        '
        'BSeleccionar
        '
        Me.BSeleccionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BSeleccionar.FlatAppearance.BorderSize = 2
        Me.BSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BSeleccionar.Font = New System.Drawing.Font("Britannic Bold", 11.0!)
        Me.BSeleccionar.ForeColor = System.Drawing.Color.White
        Me.BSeleccionar.Location = New System.Drawing.Point(348, 17)
        Me.BSeleccionar.Margin = New System.Windows.Forms.Padding(4)
        Me.BSeleccionar.Name = "BSeleccionar"
        Me.BSeleccionar.Size = New System.Drawing.Size(129, 52)
        Me.BSeleccionar.TabIndex = 27
        Me.BSeleccionar.Text = "Seleccionar"
        Me.BSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BSeleccionar.UseVisualStyleBackColor = False
        '
        'dgvListarCliente
        '
        Me.dgvListarCliente.AllowUserToAddRows = False
        Me.dgvListarCliente.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvListarCliente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvListarCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvListarCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListarCliente.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.dgvListarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListarCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListarCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvListarCliente.ColumnHeadersHeight = 20
        Me.dgvListarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListarCliente.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvListarCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListarCliente.EnableHeadersVisualStyles = False
        Me.dgvListarCliente.Location = New System.Drawing.Point(3, 2)
        Me.dgvListarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvListarCliente.Name = "dgvListarCliente"
        Me.dgvListarCliente.ReadOnly = True
        Me.dgvListarCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.NavajoWhite
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListarCliente.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvListarCliente.RowHeadersWidth = 51
        Me.dgvListarCliente.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgvListarCliente.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvListarCliente.Size = New System.Drawing.Size(943, 343)
        Me.dgvListarCliente.TabIndex = 7
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBoxClientes)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(983, 123)
        Me.Panel1.TabIndex = 37
        '
        'GroupBoxClientes
        '
        Me.GroupBoxClientes.Controls.Add(Me.LDni)
        Me.GroupBoxClientes.Controls.Add(Me.CBBuscar)
        Me.GroupBoxClientes.Controls.Add(Me.BBuscar)
        Me.GroupBoxClientes.Controls.Add(Me.TBBuscar)
        Me.GroupBoxClientes.Font = New System.Drawing.Font("Britannic Bold", 18.0!)
        Me.GroupBoxClientes.ForeColor = System.Drawing.Color.White
        Me.GroupBoxClientes.Location = New System.Drawing.Point(11, 13)
        Me.GroupBoxClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxClientes.Name = "GroupBoxClientes"
        Me.GroupBoxClientes.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxClientes.Size = New System.Drawing.Size(957, 106)
        Me.GroupBoxClientes.TabIndex = 12
        Me.GroupBoxClientes.TabStop = False
        Me.GroupBoxClientes.Text = "Clientes"
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Font = New System.Drawing.Font("Britannic Bold", 11.0!)
        Me.LDni.ForeColor = System.Drawing.Color.White
        Me.LDni.Location = New System.Drawing.Point(536, 23)
        Me.LDni.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(39, 21)
        Me.LDni.TabIndex = 36
        Me.LDni.Text = "DNI"
        '
        'CBBuscar
        '
        Me.CBBuscar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CBBuscar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CBBuscar.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.CBBuscar.FormattingEnabled = True
        Me.CBBuscar.Location = New System.Drawing.Point(540, 48)
        Me.CBBuscar.Margin = New System.Windows.Forms.Padding(4)
        Me.CBBuscar.Name = "CBBuscar"
        Me.CBBuscar.Size = New System.Drawing.Size(152, 30)
        Me.CBBuscar.TabIndex = 10
        Me.CBBuscar.Text = "DNI"
        '
        'BBuscar
        '
        Me.BBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBuscar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.8!, System.Drawing.FontStyle.Bold)
        Me.BBuscar.ForeColor = System.Drawing.Color.White
        Me.BBuscar.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.search_3_32
        Me.BBuscar.Location = New System.Drawing.Point(893, 38)
        Me.BBuscar.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(53, 49)
        Me.BBuscar.TabIndex = 2
        Me.BBuscar.UseVisualStyleBackColor = False
        '
        'TBBuscar
        '
        Me.TBBuscar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!)
        Me.TBBuscar.Location = New System.Drawing.Point(701, 48)
        Me.TBBuscar.Margin = New System.Windows.Forms.Padding(5, 2, 5, 2)
        Me.TBBuscar.Name = "TBBuscar"
        Me.TBBuscar.Size = New System.Drawing.Size(180, 29)
        Me.TBBuscar.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel2.Controls.Add(Me.TabControlListaClientes)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 123)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(983, 478)
        Me.Panel2.TabIndex = 38
        '
        'TabControlListaClientes
        '
        Me.TabControlListaClientes.Controls.Add(Me.TabPafeListaClientes)
        Me.TabControlListaClientes.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TabControlListaClientes.Location = New System.Drawing.Point(11, 6)
        Me.TabControlListaClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlListaClientes.Name = "TabControlListaClientes"
        Me.TabControlListaClientes.SelectedIndex = 0
        Me.TabControlListaClientes.Size = New System.Drawing.Size(957, 382)
        Me.TabControlListaClientes.TabIndex = 14
        '
        'TabPafeListaClientes
        '
        Me.TabPafeListaClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.TabPafeListaClientes.Controls.Add(Me.dgvListarCliente)
        Me.TabPafeListaClientes.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TabPafeListaClientes.ForeColor = System.Drawing.Color.White
        Me.TabPafeListaClientes.Location = New System.Drawing.Point(4, 31)
        Me.TabPafeListaClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPafeListaClientes.Name = "TabPafeListaClientes"
        Me.TabPafeListaClientes.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPafeListaClientes.Size = New System.Drawing.Size(949, 347)
        Me.TabPafeListaClientes.TabIndex = 0
        Me.TabPafeListaClientes.Text = "Lista de Clientes"
        '
        'BuscarCli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(983, 601)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "BuscarCli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BuscarCli"
        Me.Panel3.ResumeLayout(False)
        CType(Me.dgvListarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBoxClientes.ResumeLayout(False)
        Me.GroupBoxClientes.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.TabControlListaClientes.ResumeLayout(False)
        Me.TabPafeListaClientes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BCancelar As Button
    Friend WithEvents BSeleccionar As Button
    Public WithEvents dgvListarCliente As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBoxClientes As GroupBox
    Friend WithEvents CBBuscar As ComboBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents TBBuscar As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TabControlListaClientes As TabControl
    Friend WithEvents TabPafeListaClientes As TabPage
    Friend WithEvents LDni As Label
End Class
