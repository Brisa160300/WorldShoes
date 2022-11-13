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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControlListaClientes = New System.Windows.Forms.TabControl()
        Me.TabPafeListaClientes = New System.Windows.Forms.TabPage()
        Me.dgvListarCliente = New System.Windows.Forms.DataGridView()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BSeleccionar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBoxClientes = New System.Windows.Forms.GroupBox()
        Me.ComboBoxBuscarDni = New System.Windows.Forms.ComboBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TabControlListaClientes.SuspendLayout()
        Me.TabPafeListaClientes.SuspendLayout()
        CType(Me.dgvListarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBoxClientes.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlListaClientes
        '
        Me.TabControlListaClientes.Controls.Add(Me.TabPafeListaClientes)
        Me.TabControlListaClientes.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TabControlListaClientes.Location = New System.Drawing.Point(2, 14)
        Me.TabControlListaClientes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControlListaClientes.Name = "TabControlListaClientes"
        Me.TabControlListaClientes.SelectedIndex = 0
        Me.TabControlListaClientes.Size = New System.Drawing.Size(718, 374)
        Me.TabControlListaClientes.TabIndex = 14
        '
        'TabPafeListaClientes
        '
        Me.TabPafeListaClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.TabPafeListaClientes.Controls.Add(Me.Panel3)
        Me.TabPafeListaClientes.Controls.Add(Me.dgvListarCliente)
        Me.TabPafeListaClientes.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TabPafeListaClientes.ForeColor = System.Drawing.Color.White
        Me.TabPafeListaClientes.Location = New System.Drawing.Point(4, 26)
        Me.TabPafeListaClientes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPafeListaClientes.Name = "TabPafeListaClientes"
        Me.TabPafeListaClientes.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPafeListaClientes.Size = New System.Drawing.Size(710, 344)
        Me.TabPafeListaClientes.TabIndex = 0
        Me.TabPafeListaClientes.Text = "Lista de Clientes"
        '
        'dgvListarCliente
        '
        Me.dgvListarCliente.AllowUserToAddRows = False
        Me.dgvListarCliente.AllowUserToDeleteRows = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgvListarCliente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvListarCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvListarCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListarCliente.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.dgvListarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvListarCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListarCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvListarCliente.ColumnHeadersHeight = 20
        Me.dgvListarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListarCliente.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvListarCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListarCliente.EnableHeadersVisualStyles = False
        Me.dgvListarCliente.Location = New System.Drawing.Point(2, 2)
        Me.dgvListarCliente.Name = "dgvListarCliente"
        Me.dgvListarCliente.ReadOnly = True
        Me.dgvListarCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.NavajoWhite
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListarCliente.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvListarCliente.RowHeadersWidth = 51
        Me.dgvListarCliente.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dgvListarCliente.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvListarCliente.Size = New System.Drawing.Size(706, 340)
        Me.dgvListarCliente.TabIndex = 7
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BCancelar.FlatAppearance.BorderSize = 2
        Me.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelar.Font = New System.Drawing.Font("Britannic Bold", 11.0!)
        Me.BCancelar.ForeColor = System.Drawing.Color.White
        Me.BCancelar.Location = New System.Drawing.Point(364, 14)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(97, 42)
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
        Me.BSeleccionar.Location = New System.Drawing.Point(261, 14)
        Me.BSeleccionar.Name = "BSeleccionar"
        Me.BSeleccionar.Size = New System.Drawing.Size(97, 42)
        Me.BSeleccionar.TabIndex = 27
        Me.BSeleccionar.Text = "Seleccionar"
        Me.BSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BSeleccionar.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBoxClientes)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(722, 100)
        Me.Panel1.TabIndex = 37
        '
        'GroupBoxClientes
        '
        Me.GroupBoxClientes.Controls.Add(Me.ComboBoxBuscarDni)
        Me.GroupBoxClientes.Controls.Add(Me.BBuscar)
        Me.GroupBoxClientes.Controls.Add(Me.TBBuscar)
        Me.GroupBoxClientes.Font = New System.Drawing.Font("Britannic Bold", 18.0!)
        Me.GroupBoxClientes.ForeColor = System.Drawing.Color.White
        Me.GroupBoxClientes.Location = New System.Drawing.Point(8, 26)
        Me.GroupBoxClientes.Name = "GroupBoxClientes"
        Me.GroupBoxClientes.Size = New System.Drawing.Size(702, 71)
        Me.GroupBoxClientes.TabIndex = 12
        Me.GroupBoxClientes.TabStop = False
        Me.GroupBoxClientes.Text = "Clientes"
        '
        'ComboBoxBuscarDni
        '
        Me.ComboBoxBuscarDni.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ComboBoxBuscarDni.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxBuscarDni.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.ComboBoxBuscarDni.FormattingEnabled = True
        Me.ComboBoxBuscarDni.Location = New System.Drawing.Point(422, 30)
        Me.ComboBoxBuscarDni.Name = "ComboBoxBuscarDni"
        Me.ComboBoxBuscarDni.Size = New System.Drawing.Size(70, 25)
        Me.ComboBoxBuscarDni.TabIndex = 10
        Me.ComboBoxBuscarDni.Text = "DNI"
        '
        'BBuscar
        '
        Me.BBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBuscar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.8!, System.Drawing.FontStyle.Bold)
        Me.BBuscar.ForeColor = System.Drawing.Color.White
        Me.BBuscar.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.search_3_32
        Me.BBuscar.Location = New System.Drawing.Point(654, 23)
        Me.BBuscar.Margin = New System.Windows.Forms.Padding(5)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(40, 40)
        Me.BBuscar.TabIndex = 2
        Me.BBuscar.UseVisualStyleBackColor = False
        '
        'TBBuscar
        '
        Me.TBBuscar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!)
        Me.TBBuscar.Location = New System.Drawing.Point(509, 31)
        Me.TBBuscar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TBBuscar.Name = "TBBuscar"
        Me.TBBuscar.Size = New System.Drawing.Size(136, 24)
        Me.TBBuscar.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel2.Controls.Add(Me.TabControlListaClientes)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 100)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(722, 388)
        Me.Panel2.TabIndex = 38
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Panel3.Controls.Add(Me.BCancelar)
        Me.Panel3.Controls.Add(Me.BSeleccionar)
        Me.Panel3.Location = New System.Drawing.Point(1, 277)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(709, 68)
        Me.Panel3.TabIndex = 28
        '
        'BuscarCli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(722, 488)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "BuscarCli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BuscarCli"
        Me.TabControlListaClientes.ResumeLayout(False)
        Me.TabPafeListaClientes.ResumeLayout(False)
        CType(Me.dgvListarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBoxClientes.ResumeLayout(False)
        Me.GroupBoxClientes.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlListaClientes As TabControl
    Friend WithEvents TabPafeListaClientes As TabPage
    Friend WithEvents BCancelar As Button
    Friend WithEvents BSeleccionar As Button
    Public WithEvents dgvListarCliente As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBoxClientes As GroupBox
    Friend WithEvents ComboBoxBuscarDni As ComboBox
    Friend WithEvents BBuscar As Button
    Friend WithEvents TBBuscar As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
