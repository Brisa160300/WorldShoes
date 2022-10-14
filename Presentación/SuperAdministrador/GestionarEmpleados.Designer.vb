<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarEmpleados
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.TabControlListaEmpleados = New System.Windows.Forms.TabControl()
        Me.TabPageListaEmpleados = New System.Windows.Forms.TabPage()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnTel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnDireccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnEmail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBoxGestionUsuarios = New System.Windows.Forms.GroupBox()
        Me.BEliminarUsuario = New System.Windows.Forms.Button()
        Me.BModificarUsuario = New System.Windows.Forms.Button()
        Me.BBuscarUsuario = New System.Windows.Forms.Button()
        Me.TBGestionUsuario = New System.Windows.Forms.TextBox()
        Me.TabControlListaEmpleados.SuspendLayout()
        Me.TabPageListaEmpleados.SuspendLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxGestionUsuarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BVolver.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVolver.ForeColor = System.Drawing.Color.White
        Me.BVolver.Location = New System.Drawing.Point(980, 580)
        Me.BVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(130, 52)
        Me.BVolver.TabIndex = 21
        Me.BVolver.Text = "Volver"
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'TabControlListaEmpleados
        '
        Me.TabControlListaEmpleados.Controls.Add(Me.TabPageListaEmpleados)
        Me.TabControlListaEmpleados.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlListaEmpleados.Location = New System.Drawing.Point(43, 209)
        Me.TabControlListaEmpleados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlListaEmpleados.Name = "TabControlListaEmpleados"
        Me.TabControlListaEmpleados.SelectedIndex = 0
        Me.TabControlListaEmpleados.Size = New System.Drawing.Size(1071, 343)
        Me.TabControlListaEmpleados.TabIndex = 19
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
        Me.TabPageListaEmpleados.Size = New System.Drawing.Size(1063, 311)
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmpleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEmpleados.ColumnHeadersHeight = 20
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvEmpleados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.ColumnNombre, Me.ColumnApellido, Me.ColumnTel, Me.ColumnDireccion, Me.ColumnEmail})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEmpleados.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEmpleados.EnableHeadersVisualStyles = False
        Me.dgvEmpleados.Location = New System.Drawing.Point(3, 2)
        Me.dgvEmpleados.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.ReadOnly = True
        Me.dgvEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmpleados.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvEmpleados.RowHeadersWidth = 51
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.dgvEmpleados.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvEmpleados.Size = New System.Drawing.Size(1057, 307)
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
        'GroupBoxGestionUsuarios
        '
        Me.GroupBoxGestionUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBoxGestionUsuarios.Controls.Add(Me.BEliminarUsuario)
        Me.GroupBoxGestionUsuarios.Controls.Add(Me.BModificarUsuario)
        Me.GroupBoxGestionUsuarios.Controls.Add(Me.BBuscarUsuario)
        Me.GroupBoxGestionUsuarios.Controls.Add(Me.TBGestionUsuario)
        Me.GroupBoxGestionUsuarios.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.GroupBoxGestionUsuarios.ForeColor = System.Drawing.Color.White
        Me.GroupBoxGestionUsuarios.Location = New System.Drawing.Point(43, 51)
        Me.GroupBoxGestionUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxGestionUsuarios.Name = "GroupBoxGestionUsuarios"
        Me.GroupBoxGestionUsuarios.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxGestionUsuarios.Size = New System.Drawing.Size(1071, 100)
        Me.GroupBoxGestionUsuarios.TabIndex = 27
        Me.GroupBoxGestionUsuarios.TabStop = False
        Me.GroupBoxGestionUsuarios.Text = "Gestion de Empleados"
        '
        'BEliminarUsuario
        '
        Me.BEliminarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BEliminarUsuario.FlatAppearance.BorderSize = 2
        Me.BEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEliminarUsuario.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminarUsuario.ForeColor = System.Drawing.Color.White
        Me.BEliminarUsuario.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.trash_6_32
        Me.BEliminarUsuario.Location = New System.Drawing.Point(980, 31)
        Me.BEliminarUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.BEliminarUsuario.Name = "BEliminarUsuario"
        Me.BEliminarUsuario.Size = New System.Drawing.Size(60, 50)
        Me.BEliminarUsuario.TabIndex = 12
        Me.BEliminarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BEliminarUsuario.UseVisualStyleBackColor = False
        '
        'BModificarUsuario
        '
        Me.BModificarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BModificarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BModificarUsuario.FlatAppearance.BorderSize = 2
        Me.BModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModificarUsuario.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BModificarUsuario.ForeColor = System.Drawing.Color.White
        Me.BModificarUsuario.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.edit_12_32
        Me.BModificarUsuario.Location = New System.Drawing.Point(912, 31)
        Me.BModificarUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.BModificarUsuario.Name = "BModificarUsuario"
        Me.BModificarUsuario.Size = New System.Drawing.Size(60, 50)
        Me.BModificarUsuario.TabIndex = 13
        Me.BModificarUsuario.Text = "z"
        Me.BModificarUsuario.UseVisualStyleBackColor = False
        '
        'BBuscarUsuario
        '
        Me.BBuscarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BBuscarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BBuscarUsuario.FlatAppearance.BorderSize = 2
        Me.BBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBuscarUsuario.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscarUsuario.ForeColor = System.Drawing.Color.White
        Me.BBuscarUsuario.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.search_3_32
        Me.BBuscarUsuario.Location = New System.Drawing.Point(208, 31)
        Me.BBuscarUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.BBuscarUsuario.Name = "BBuscarUsuario"
        Me.BBuscarUsuario.Size = New System.Drawing.Size(60, 50)
        Me.BBuscarUsuario.TabIndex = 14
        Me.BBuscarUsuario.UseVisualStyleBackColor = False
        '
        'TBGestionUsuario
        '
        Me.TBGestionUsuario.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBGestionUsuario.Location = New System.Drawing.Point(27, 43)
        Me.TBGestionUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.TBGestionUsuario.Name = "TBGestionUsuario"
        Me.TBGestionUsuario.Size = New System.Drawing.Size(173, 30)
        Me.TBGestionUsuario.TabIndex = 6
        '
        'GestionarEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 656)
        Me.Controls.Add(Me.GroupBoxGestionUsuarios)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.TabControlListaEmpleados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "GestionarEmpleados"
        Me.Text = "GestionarEmpleados"
        Me.TabControlListaEmpleados.ResumeLayout(False)
        Me.TabPageListaEmpleados.ResumeLayout(False)
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxGestionUsuarios.ResumeLayout(False)
        Me.GroupBoxGestionUsuarios.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

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
    Friend WithEvents GroupBoxGestionUsuarios As GroupBox
    Friend WithEvents BEliminarUsuario As Button
    Friend WithEvents BModificarUsuario As Button
    Friend WithEvents BBuscarUsuario As Button
    Friend WithEvents TBGestionUsuario As TextBox
End Class
