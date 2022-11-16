<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionarUsuarios
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
        Me.GroupBoxGestionUsuarios = New System.Windows.Forms.GroupBox()
        Me.BBuscarUsuario = New System.Windows.Forms.Button()
        Me.TBGestionUsuario = New System.Windows.Forms.TextBox()
        Me.BEliminarUsuario = New System.Windows.Forms.Button()
        Me.BModificarUsuario = New System.Windows.Forms.Button()
        Me.TabListaClientes = New System.Windows.Forms.TabControl()
        Me.TabPageUsuarios = New System.Windows.Forms.TabPage()
        Me.dgvListaUsuarios = New System.Windows.Forms.DataGridView()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.BAltaUsuario = New System.Windows.Forms.Button()
        Me.GroupBoxGestionUsuarios.SuspendLayout()
        Me.TabListaClientes.SuspendLayout()
        Me.TabPageUsuarios.SuspendLayout()
        CType(Me.dgvListaUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxGestionUsuarios
        '
        Me.GroupBoxGestionUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBoxGestionUsuarios.Controls.Add(Me.BBuscarUsuario)
        Me.GroupBoxGestionUsuarios.Controls.Add(Me.TBGestionUsuario)
        Me.GroupBoxGestionUsuarios.Font = New System.Drawing.Font("Britannic Bold", 18.0!)
        Me.GroupBoxGestionUsuarios.ForeColor = System.Drawing.Color.White
        Me.GroupBoxGestionUsuarios.Location = New System.Drawing.Point(51, 49)
        Me.GroupBoxGestionUsuarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxGestionUsuarios.Name = "GroupBoxGestionUsuarios"
        Me.GroupBoxGestionUsuarios.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxGestionUsuarios.Size = New System.Drawing.Size(956, 100)
        Me.GroupBoxGestionUsuarios.TabIndex = 25
        Me.GroupBoxGestionUsuarios.TabStop = False
        Me.GroupBoxGestionUsuarios.Text = "Gestión de Usuarios"
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
        Me.BBuscarUsuario.Location = New System.Drawing.Point(876, 31)
        Me.BBuscarUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BBuscarUsuario.Name = "BBuscarUsuario"
        Me.BBuscarUsuario.Size = New System.Drawing.Size(60, 50)
        Me.BBuscarUsuario.TabIndex = 14
        Me.BBuscarUsuario.UseVisualStyleBackColor = False
        '
        'TBGestionUsuario
        '
        Me.TBGestionUsuario.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBGestionUsuario.Location = New System.Drawing.Point(685, 41)
        Me.TBGestionUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBGestionUsuario.Name = "TBGestionUsuario"
        Me.TBGestionUsuario.Size = New System.Drawing.Size(173, 30)
        Me.TBGestionUsuario.TabIndex = 6
        '
        'BEliminarUsuario
        '
        Me.BEliminarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BEliminarUsuario.FlatAppearance.BorderSize = 2
        Me.BEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEliminarUsuario.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminarUsuario.ForeColor = System.Drawing.Color.White
        Me.BEliminarUsuario.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.trash_6_32
        Me.BEliminarUsuario.Location = New System.Drawing.Point(1036, 351)
        Me.BEliminarUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BEliminarUsuario.Name = "BEliminarUsuario"
        Me.BEliminarUsuario.Size = New System.Drawing.Size(75, 62)
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
        Me.BModificarUsuario.Location = New System.Drawing.Point(1036, 262)
        Me.BModificarUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BModificarUsuario.Name = "BModificarUsuario"
        Me.BModificarUsuario.Size = New System.Drawing.Size(75, 62)
        Me.BModificarUsuario.TabIndex = 13
        Me.BModificarUsuario.Text = "z"
        Me.BModificarUsuario.UseVisualStyleBackColor = False
        '
        'TabListaClientes
        '
        Me.TabListaClientes.Controls.Add(Me.TabPageUsuarios)
        Me.TabListaClientes.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TabListaClientes.Location = New System.Drawing.Point(51, 175)
        Me.TabListaClientes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabListaClientes.Name = "TabListaClientes"
        Me.TabListaClientes.SelectedIndex = 0
        Me.TabListaClientes.Size = New System.Drawing.Size(956, 378)
        Me.TabListaClientes.TabIndex = 24
        '
        'TabPageUsuarios
        '
        Me.TabPageUsuarios.Controls.Add(Me.dgvListaUsuarios)
        Me.TabPageUsuarios.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageUsuarios.ForeColor = System.Drawing.Color.White
        Me.TabPageUsuarios.Location = New System.Drawing.Point(4, 31)
        Me.TabPageUsuarios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageUsuarios.Name = "TabPageUsuarios"
        Me.TabPageUsuarios.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageUsuarios.Size = New System.Drawing.Size(948, 343)
        Me.TabPageUsuarios.TabIndex = 0
        Me.TabPageUsuarios.Text = "Lista de Usuarios"
        Me.TabPageUsuarios.UseVisualStyleBackColor = True
        '
        'dgvListaUsuarios
        '
        Me.dgvListaUsuarios.AllowUserToAddRows = False
        Me.dgvListaUsuarios.AllowUserToDeleteRows = False
        Me.dgvListaUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvListaUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgvListaUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListaUsuarios.ColumnHeadersHeight = 20
        Me.dgvListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListaUsuarios.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListaUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListaUsuarios.EnableHeadersVisualStyles = False
        Me.dgvListaUsuarios.Location = New System.Drawing.Point(3, 2)
        Me.dgvListaUsuarios.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvListaUsuarios.MultiSelect = False
        Me.dgvListaUsuarios.Name = "dgvListaUsuarios"
        Me.dgvListaUsuarios.ReadOnly = True
        Me.dgvListaUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvListaUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.dgvListaUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListaUsuarios.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgvListaUsuarios.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgvListaUsuarios.Size = New System.Drawing.Size(942, 339)
        Me.dgvListaUsuarios.TabIndex = 2
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BVolver.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVolver.ForeColor = System.Drawing.Color.White
        Me.BVolver.Location = New System.Drawing.Point(875, 576)
        Me.BVolver.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(124, 54)
        Me.BVolver.TabIndex = 15
        Me.BVolver.Text = "Volver"
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'BAltaUsuario
        '
        Me.BAltaUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BAltaUsuario.FlatAppearance.BorderSize = 2
        Me.BAltaUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAltaUsuario.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAltaUsuario.ForeColor = System.Drawing.Color.White
        Me.BAltaUsuario.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.plus_32
        Me.BAltaUsuario.Location = New System.Drawing.Point(1036, 351)
        Me.BAltaUsuario.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BAltaUsuario.Name = "BAltaUsuario"
        Me.BAltaUsuario.Size = New System.Drawing.Size(75, 62)
        Me.BAltaUsuario.TabIndex = 26
        Me.BAltaUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BAltaUsuario.UseVisualStyleBackColor = False
        '
        'GestionarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1149, 656)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.BModificarUsuario)
        Me.Controls.Add(Me.GroupBoxGestionUsuarios)
        Me.Controls.Add(Me.TabListaClientes)
        Me.Controls.Add(Me.BEliminarUsuario)
        Me.Controls.Add(Me.BAltaUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "GestionarUsuarios"
        Me.Text = "GestionarUsuario"
        Me.GroupBoxGestionUsuarios.ResumeLayout(False)
        Me.GroupBoxGestionUsuarios.PerformLayout()
        Me.TabListaClientes.ResumeLayout(False)
        Me.TabPageUsuarios.ResumeLayout(False)
        CType(Me.dgvListaUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxGestionUsuarios As GroupBox
    Friend WithEvents BEliminarUsuario As Button
    Friend WithEvents BModificarUsuario As Button
    Friend WithEvents BBuscarUsuario As Button
    Friend WithEvents TBGestionUsuario As TextBox
    Friend WithEvents TabListaClientes As TabControl
    Friend WithEvents TabPageUsuarios As TabPage
    Friend WithEvents dgvListaUsuarios As DataGridView
    Friend WithEvents BVolver As Button
    Friend WithEvents BAltaUsuario As Button
End Class
