<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Añadir_Empleado
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BRegistrarCliente = New System.Windows.Forms.Button()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabControlListaEmpleados = New System.Windows.Forms.TabControl()
        Me.TabPageListaEmpleados = New System.Windows.Forms.TabPage()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDireccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.TabControlListaEmpleados.SuspendLayout()
        Me.TabPageListaEmpleados.SuspendLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel1.Controls.Add(Me.BRegistrarCliente)
        Me.Panel1.Controls.Add(Me.BVolver)
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBox6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TextBox7)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(58, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(450, 463)
        Me.Panel1.TabIndex = 11
        '
        'BRegistrarCliente
        '
        Me.BRegistrarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BRegistrarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BRegistrarCliente.FlatAppearance.BorderSize = 2
        Me.BRegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRegistrarCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BRegistrarCliente.ForeColor = System.Drawing.Color.White
        Me.BRegistrarCliente.Location = New System.Drawing.Point(281, 371)
        Me.BRegistrarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.BRegistrarCliente.Name = "BRegistrarCliente"
        Me.BRegistrarCliente.Size = New System.Drawing.Size(130, 52)
        Me.BRegistrarCliente.TabIndex = 43
        Me.BRegistrarCliente.Text = "Añadir"
        Me.BRegistrarCliente.UseVisualStyleBackColor = False
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVolver.ForeColor = System.Drawing.Color.White
        Me.BVolver.Location = New System.Drawing.Point(143, 371)
        Me.BVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(130, 52)
        Me.BVolver.TabIndex = 42
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TextBox5.Location = New System.Drawing.Point(189, 288)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(150, 32)
        Me.TextBox5.TabIndex = 41
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(48, 294)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 25)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "Email:"
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TextBox6.Location = New System.Drawing.Point(189, 236)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(150, 32)
        Me.TextBox6.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(48, 236)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 25)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Direccion:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(48, 173)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 25)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Telefono:"
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TextBox7.Location = New System.Drawing.Point(189, 173)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(150, 32)
        Me.TextBox7.TabIndex = 36
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TextBox4.Location = New System.Drawing.Point(189, 119)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(150, 32)
        Me.TextBox4.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(48, 122)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 25)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Apellido:"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TextBox3.Location = New System.Drawing.Point(189, 61)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(150, 32)
        Me.TextBox3.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(48, 61)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 25)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Nombre:"
        '
        'TabControlListaEmpleados
        '
        Me.TabControlListaEmpleados.Controls.Add(Me.TabPageListaEmpleados)
        Me.TabControlListaEmpleados.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlListaEmpleados.Location = New System.Drawing.Point(533, 90)
        Me.TabControlListaEmpleados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlListaEmpleados.Name = "TabControlListaEmpleados"
        Me.TabControlListaEmpleados.SelectedIndex = 0
        Me.TabControlListaEmpleados.Size = New System.Drawing.Size(555, 497)
        Me.TabControlListaEmpleados.TabIndex = 12
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
        Me.TabPageListaEmpleados.Size = New System.Drawing.Size(547, 465)
        Me.TabPageListaEmpleados.TabIndex = 0
        Me.TabPageListaEmpleados.Text = "Lista de Empleados"
        Me.TabPageListaEmpleados.UseVisualStyleBackColor = True
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.AllowUserToDeleteRows = False
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
        Me.dgvEmpleados.Size = New System.Drawing.Size(541, 461)
        Me.dgvEmpleados.TabIndex = 2
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 81
        '
        'ColumnNombre
        '
        Me.ColumnNombre.HeaderText = "Nombre"
        Me.ColumnNombre.MinimumWidth = 6
        Me.ColumnNombre.Name = "ColumnNombre"
        Me.ColumnNombre.ReadOnly = True
        Me.ColumnNombre.Width = 82
        '
        'ColumnApellido
        '
        Me.ColumnApellido.HeaderText = "Apellido"
        Me.ColumnApellido.MinimumWidth = 6
        Me.ColumnApellido.Name = "ColumnApellido"
        Me.ColumnApellido.ReadOnly = True
        Me.ColumnApellido.Width = 81
        '
        'ColumnTel
        '
        Me.ColumnTel.HeaderText = "Telefono"
        Me.ColumnTel.MinimumWidth = 6
        Me.ColumnTel.Name = "ColumnTel"
        Me.ColumnTel.ReadOnly = True
        Me.ColumnTel.Width = 81
        '
        'ColumnDireccion
        '
        Me.ColumnDireccion.HeaderText = "Direccion"
        Me.ColumnDireccion.MinimumWidth = 6
        Me.ColumnDireccion.Name = "ColumnDireccion"
        Me.ColumnDireccion.ReadOnly = True
        Me.ColumnDireccion.Width = 82
        '
        'ColumnEmail
        '
        Me.ColumnEmail.HeaderText = "E-mail"
        Me.ColumnEmail.MinimumWidth = 6
        Me.ColumnEmail.Name = "ColumnEmail"
        Me.ColumnEmail.ReadOnly = True
        Me.ColumnEmail.Width = 81
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(52, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 33)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Registrar Empleado:"
        '
        'Añadir_Empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 656)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControlListaEmpleados)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Añadir_Empleado"
        Me.Text = "Añadir_Empleado"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControlListaEmpleados.ResumeLayout(False)
        Me.TabPageListaEmpleados.ResumeLayout(False)
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BRegistrarCliente As Button
    Friend WithEvents BVolver As Button
    Friend WithEvents TabControlListaEmpleados As TabControl
    Friend WithEvents TabPageListaEmpleados As TabPage
    Friend WithEvents dgvEmpleados As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents ColumnNombre As DataGridViewTextBoxColumn
    Friend WithEvents ColumnApellido As DataGridViewTextBoxColumn
    Friend WithEvents ColumnTel As DataGridViewTextBoxColumn
    Friend WithEvents ColumnDireccion As DataGridViewTextBoxColumn
    Friend WithEvents ColumnEmail As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
