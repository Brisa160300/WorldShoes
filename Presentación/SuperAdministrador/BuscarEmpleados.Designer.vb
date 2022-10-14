<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarEmpleados
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControlListaEmpleados = New System.Windows.Forms.TabControl()
        Me.TabPageListaEmpleados = New System.Windows.Forms.TabPage()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDireccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.BRegistrarCliente = New System.Windows.Forms.Button()
        Me.TabControlListaEmpleados.SuspendLayout()
        Me.TabPageListaEmpleados.SuspendLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControlListaEmpleados
        '
        Me.TabControlListaEmpleados.Controls.Add(Me.TabPageListaEmpleados)
        Me.TabControlListaEmpleados.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlListaEmpleados.Location = New System.Drawing.Point(34, 38)
        Me.TabControlListaEmpleados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlListaEmpleados.Name = "TabControlListaEmpleados"
        Me.TabControlListaEmpleados.SelectedIndex = 0
        Me.TabControlListaEmpleados.Size = New System.Drawing.Size(879, 395)
        Me.TabControlListaEmpleados.TabIndex = 9
        '
        'TabPageListaEmpleados
        '
        Me.TabPageListaEmpleados.Controls.Add(Me.dgvEmpleados)
        Me.TabPageListaEmpleados.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaEmpleados.ForeColor = System.Drawing.Color.White
        Me.TabPageListaEmpleados.Location = New System.Drawing.Point(4, 28)
        Me.TabPageListaEmpleados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaEmpleados.Name = "TabPageListaEmpleados"
        Me.TabPageListaEmpleados.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaEmpleados.Size = New System.Drawing.Size(871, 363)
        Me.TabPageListaEmpleados.TabIndex = 0
        Me.TabPageListaEmpleados.Text = "Lista de Empleados"
        Me.TabPageListaEmpleados.UseVisualStyleBackColor = True
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.AllowUserToDeleteRows = False
        Me.dgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgvEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmpleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvEmpleados.ColumnHeadersHeight = 20
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.ColumnNombre, Me.ColumnApellido, Me.ColumnTel, Me.ColumnDireccion, Me.ColumnEmail})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEmpleados.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEmpleados.EnableHeadersVisualStyles = False
        Me.dgvEmpleados.Location = New System.Drawing.Point(3, 2)
        Me.dgvEmpleados.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.ReadOnly = True
        Me.dgvEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmpleados.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvEmpleados.RowHeadersWidth = 51
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
        Me.dgvEmpleados.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvEmpleados.Size = New System.Drawing.Size(865, 359)
        Me.dgvEmpleados.TabIndex = 2
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        '
        'ColumnNombre
        '
        Me.ColumnNombre.HeaderText = "Nombre"
        Me.ColumnNombre.MinimumWidth = 6
        Me.ColumnNombre.Name = "ColumnNombre"
        Me.ColumnNombre.ReadOnly = True
        '
        'ColumnApellido
        '
        Me.ColumnApellido.HeaderText = "Apellido"
        Me.ColumnApellido.MinimumWidth = 6
        Me.ColumnApellido.Name = "ColumnApellido"
        Me.ColumnApellido.ReadOnly = True
        '
        'ColumnTel
        '
        Me.ColumnTel.HeaderText = "Telefono"
        Me.ColumnTel.MinimumWidth = 6
        Me.ColumnTel.Name = "ColumnTel"
        Me.ColumnTel.ReadOnly = True
        '
        'ColumnDireccion
        '
        Me.ColumnDireccion.HeaderText = "Direccion"
        Me.ColumnDireccion.MinimumWidth = 6
        Me.ColumnDireccion.Name = "ColumnDireccion"
        Me.ColumnDireccion.ReadOnly = True
        '
        'ColumnEmail
        '
        Me.ColumnEmail.HeaderText = "E-mail"
        Me.ColumnEmail.MinimumWidth = 6
        Me.ColumnEmail.Name = "ColumnEmail"
        Me.ColumnEmail.ReadOnly = True
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BVolver.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVolver.ForeColor = System.Drawing.Color.White
        Me.BVolver.Location = New System.Drawing.Point(783, 454)
        Me.BVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(130, 52)
        Me.BVolver.TabIndex = 18
        Me.BVolver.Text = "Volver"
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'BRegistrarCliente
        '
        Me.BRegistrarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BRegistrarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BRegistrarCliente.FlatAppearance.BorderSize = 2
        Me.BRegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRegistrarCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BRegistrarCliente.ForeColor = System.Drawing.Color.White
        Me.BRegistrarCliente.Location = New System.Drawing.Point(585, 455)
        Me.BRegistrarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.BRegistrarCliente.Name = "BRegistrarCliente"
        Me.BRegistrarCliente.Size = New System.Drawing.Size(160, 51)
        Me.BRegistrarCliente.TabIndex = 17
        Me.BRegistrarCliente.Text = "Seleccionar"
        Me.BRegistrarCliente.UseVisualStyleBackColor = False
        '
        'BuscarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(958, 533)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.BRegistrarCliente)
        Me.Controls.Add(Me.TabControlListaEmpleados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BuscarEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "BuscarEmpleados"
        Me.TabControlListaEmpleados.ResumeLayout(False)
        Me.TabPageListaEmpleados.ResumeLayout(False)
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlListaEmpleados As TabControl
    Friend WithEvents TabPageListaEmpleados As TabPage
    Friend WithEvents dgvEmpleados As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents ColumnNombre As DataGridViewTextBoxColumn
    Friend WithEvents ColumnApellido As DataGridViewTextBoxColumn
    Friend WithEvents ColumnTel As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDireccion As DataGridViewTextBoxColumn
    Friend WithEvents ColumnEmail As DataGridViewTextBoxColumn
    Friend WithEvents BVolver As Button
    Friend WithEvents BRegistrarCliente As Button
End Class
