<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarCliente
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabListaClientes = New System.Windows.Forms.TabControl()
        Me.TabPageListaTalle = New System.Windows.Forms.TabPage()
        Me.dgvRegistroClientes = New System.Windows.Forms.DataGridView()
        Me.GroupBoxGestionClientes = New System.Windows.Forms.GroupBox()
        Me.TBGestionClientes = New System.Windows.Forms.TextBox()
        Me.BEliminarCliente = New System.Windows.Forms.Button()
        Me.BModificarCliente = New System.Windows.Forms.Button()
        Me.BBuscarCliente = New System.Windows.Forms.Button()
        Me.TabListaClientes.SuspendLayout()
        Me.TabPageListaTalle.SuspendLayout()
        CType(Me.dgvRegistroClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxGestionClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabListaClientes
        '
        Me.TabListaClientes.Controls.Add(Me.TabPageListaTalle)
        Me.TabListaClientes.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabListaClientes.Location = New System.Drawing.Point(26, 177)
        Me.TabListaClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabListaClientes.Name = "TabListaClientes"
        Me.TabListaClientes.SelectedIndex = 0
        Me.TabListaClientes.Size = New System.Drawing.Size(1071, 438)
        Me.TabListaClientes.TabIndex = 22
        '
        'TabPageListaTalle
        '
        Me.TabPageListaTalle.Controls.Add(Me.dgvRegistroClientes)
        Me.TabPageListaTalle.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaTalle.ForeColor = System.Drawing.Color.White
        Me.TabPageListaTalle.Location = New System.Drawing.Point(4, 28)
        Me.TabPageListaTalle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaTalle.Name = "TabPageListaTalle"
        Me.TabPageListaTalle.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaTalle.Size = New System.Drawing.Size(1063, 406)
        Me.TabPageListaTalle.TabIndex = 0
        Me.TabPageListaTalle.Text = "Lista de Clientes"
        Me.TabPageListaTalle.UseVisualStyleBackColor = True
        '
        'dgvRegistroClientes
        '
        Me.dgvRegistroClientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgvRegistroClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvRegistroClientes.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvRegistroClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvRegistroClientes.Location = New System.Drawing.Point(3, 2)
        Me.dgvRegistroClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvRegistroClientes.Name = "dgvRegistroClientes"
        Me.dgvRegistroClientes.RowHeadersWidth = 51
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.dgvRegistroClientes.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvRegistroClientes.Size = New System.Drawing.Size(1057, 402)
        Me.dgvRegistroClientes.TabIndex = 2
        '
        'GroupBoxGestionClientes
        '
        Me.GroupBoxGestionClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBoxGestionClientes.Controls.Add(Me.BEliminarCliente)
        Me.GroupBoxGestionClientes.Controls.Add(Me.BModificarCliente)
        Me.GroupBoxGestionClientes.Controls.Add(Me.BBuscarCliente)
        Me.GroupBoxGestionClientes.Controls.Add(Me.TBGestionClientes)
        Me.GroupBoxGestionClientes.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.GroupBoxGestionClientes.ForeColor = System.Drawing.Color.White
        Me.GroupBoxGestionClientes.Location = New System.Drawing.Point(26, 44)
        Me.GroupBoxGestionClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxGestionClientes.Name = "GroupBoxGestionClientes"
        Me.GroupBoxGestionClientes.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxGestionClientes.Size = New System.Drawing.Size(1071, 100)
        Me.GroupBoxGestionClientes.TabIndex = 23
        Me.GroupBoxGestionClientes.TabStop = False
        Me.GroupBoxGestionClientes.Text = "Gestión de Clientes"
        '
        'TBGestionClientes
        '
        Me.TBGestionClientes.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBGestionClientes.Location = New System.Drawing.Point(27, 43)
        Me.TBGestionClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.TBGestionClientes.Name = "TBGestionClientes"
        Me.TBGestionClientes.Size = New System.Drawing.Size(173, 30)
        Me.TBGestionClientes.TabIndex = 6
        '
        'BEliminarCliente
        '
        Me.BEliminarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BEliminarCliente.FlatAppearance.BorderSize = 2
        Me.BEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEliminarCliente.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminarCliente.ForeColor = System.Drawing.Color.White
        Me.BEliminarCliente.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.trash_6_32
        Me.BEliminarCliente.Location = New System.Drawing.Point(980, 31)
        Me.BEliminarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.BEliminarCliente.Name = "BEliminarCliente"
        Me.BEliminarCliente.Size = New System.Drawing.Size(60, 50)
        Me.BEliminarCliente.TabIndex = 12
        Me.BEliminarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BEliminarCliente.UseVisualStyleBackColor = False
        '
        'BModificarCliente
        '
        Me.BModificarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BModificarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BModificarCliente.FlatAppearance.BorderSize = 2
        Me.BModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModificarCliente.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BModificarCliente.ForeColor = System.Drawing.Color.White
        Me.BModificarCliente.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.edit_12_32
        Me.BModificarCliente.Location = New System.Drawing.Point(912, 31)
        Me.BModificarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.BModificarCliente.Name = "BModificarCliente"
        Me.BModificarCliente.Size = New System.Drawing.Size(60, 50)
        Me.BModificarCliente.TabIndex = 13
        Me.BModificarCliente.UseVisualStyleBackColor = False
        '
        'BBuscarCliente
        '
        Me.BBuscarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BBuscarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BBuscarCliente.FlatAppearance.BorderSize = 2
        Me.BBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBuscarCliente.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscarCliente.ForeColor = System.Drawing.Color.White
        Me.BBuscarCliente.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.search_3_32
        Me.BBuscarCliente.Location = New System.Drawing.Point(208, 31)
        Me.BBuscarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.BBuscarCliente.Name = "BBuscarCliente"
        Me.BBuscarCliente.Size = New System.Drawing.Size(60, 50)
        Me.BBuscarCliente.TabIndex = 14
        Me.BBuscarCliente.UseVisualStyleBackColor = False
        '
        'GestionarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 656)
        Me.Controls.Add(Me.GroupBoxGestionClientes)
        Me.Controls.Add(Me.TabListaClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "GestionarCliente"
        Me.Text = "GestionarCliente"
        Me.TabListaClientes.ResumeLayout(False)
        Me.TabPageListaTalle.ResumeLayout(False)
        CType(Me.dgvRegistroClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxGestionClientes.ResumeLayout(False)
        Me.GroupBoxGestionClientes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabListaClientes As TabControl
    Friend WithEvents TabPageListaTalle As TabPage
    Friend WithEvents dgvRegistroClientes As DataGridView
    Friend WithEvents GroupBoxGestionClientes As GroupBox
    Friend WithEvents BEliminarCliente As Button
    Friend WithEvents BModificarCliente As Button
    Friend WithEvents BBuscarCliente As Button
    Friend WithEvents TBGestionClientes As TextBox
End Class
