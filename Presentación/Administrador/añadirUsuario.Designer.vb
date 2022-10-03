<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class añadirUsuario
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
        Me.TabControlRegUsuarios = New System.Windows.Forms.TabControl()
        Me.TabPageListaUsuarios = New System.Windows.Forms.TabPage()
        Me.dgvListaUsuarios = New System.Windows.Forms.DataGridView()
        Me.LRegistroUsuario = New System.Windows.Forms.Label()
        Me.PanelRegUsuarios = New System.Windows.Forms.Panel()
        Me.ComboBoxPerfiles = New System.Windows.Forms.ComboBox()
        Me.BRegistrarCliente = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.TBContraseñaUsuario = New System.Windows.Forms.TextBox()
        Me.TBNombreUsuario = New System.Windows.Forms.TextBox()
        Me.LContraseñaUsuario = New System.Windows.Forms.Label()
        Me.LPerfilUsuario = New System.Windows.Forms.Label()
        Me.LNombreUsuario = New System.Windows.Forms.Label()
        Me.TabControlRegUsuarios.SuspendLayout()
        Me.TabPageListaUsuarios.SuspendLayout()
        CType(Me.dgvListaUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRegUsuarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlRegUsuarios
        '
        Me.TabControlRegUsuarios.Controls.Add(Me.TabPageListaUsuarios)
        Me.TabControlRegUsuarios.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlRegUsuarios.Location = New System.Drawing.Point(593, 68)
        Me.TabControlRegUsuarios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlRegUsuarios.Name = "TabControlRegUsuarios"
        Me.TabControlRegUsuarios.SelectedIndex = 0
        Me.TabControlRegUsuarios.Size = New System.Drawing.Size(474, 498)
        Me.TabControlRegUsuarios.TabIndex = 7
        '
        'TabPageListaUsuarios
        '
        Me.TabPageListaUsuarios.Controls.Add(Me.dgvListaUsuarios)
        Me.TabPageListaUsuarios.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaUsuarios.ForeColor = System.Drawing.Color.White
        Me.TabPageListaUsuarios.Location = New System.Drawing.Point(4, 28)
        Me.TabPageListaUsuarios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaUsuarios.Name = "TabPageListaUsuarios"
        Me.TabPageListaUsuarios.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaUsuarios.Size = New System.Drawing.Size(466, 466)
        Me.TabPageListaUsuarios.TabIndex = 0
        Me.TabPageListaUsuarios.Text = "Lista de Usuarios"
        Me.TabPageListaUsuarios.UseVisualStyleBackColor = True
        '
        'dgvListaUsuarios
        '
        Me.dgvListaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListaUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
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
        Me.dgvListaUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvListaUsuarios.Name = "dgvListaUsuarios"
        Me.dgvListaUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaUsuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListaUsuarios.RowHeadersWidth = 51
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.dgvListaUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvListaUsuarios.Size = New System.Drawing.Size(460, 462)
        Me.dgvListaUsuarios.TabIndex = 2
        '
        'LRegistroUsuario
        '
        Me.LRegistroUsuario.AutoSize = True
        Me.LRegistroUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LRegistroUsuario.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRegistroUsuario.ForeColor = System.Drawing.Color.Transparent
        Me.LRegistroUsuario.Location = New System.Drawing.Point(55, 44)
        Me.LRegistroUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LRegistroUsuario.Name = "LRegistroUsuario"
        Me.LRegistroUsuario.Size = New System.Drawing.Size(250, 33)
        Me.LRegistroUsuario.TabIndex = 6
        Me.LRegistroUsuario.Text = "Registrar Usuario"
        '
        'PanelRegUsuarios
        '
        Me.PanelRegUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PanelRegUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelRegUsuarios.Controls.Add(Me.ComboBoxPerfiles)
        Me.PanelRegUsuarios.Controls.Add(Me.BRegistrarCliente)
        Me.PanelRegUsuarios.Controls.Add(Me.BCancelar)
        Me.PanelRegUsuarios.Controls.Add(Me.TBContraseñaUsuario)
        Me.PanelRegUsuarios.Controls.Add(Me.TBNombreUsuario)
        Me.PanelRegUsuarios.Controls.Add(Me.LContraseñaUsuario)
        Me.PanelRegUsuarios.Controls.Add(Me.LPerfilUsuario)
        Me.PanelRegUsuarios.Controls.Add(Me.LNombreUsuario)
        Me.PanelRegUsuarios.Location = New System.Drawing.Point(61, 106)
        Me.PanelRegUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelRegUsuarios.Name = "PanelRegUsuarios"
        Me.PanelRegUsuarios.Size = New System.Drawing.Size(436, 441)
        Me.PanelRegUsuarios.TabIndex = 5
        '
        'ComboBoxPerfiles
        '
        Me.ComboBoxPerfiles.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.ComboBoxPerfiles.FormattingEnabled = True
        Me.ComboBoxPerfiles.Items.AddRange(New Object() {"Vendedor", "Gerente"})
        Me.ComboBoxPerfiles.Location = New System.Drawing.Point(180, 207)
        Me.ComboBoxPerfiles.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxPerfiles.Name = "ComboBoxPerfiles"
        Me.ComboBoxPerfiles.Size = New System.Drawing.Size(161, 33)
        Me.ComboBoxPerfiles.TabIndex = 18
        '
        'BRegistrarCliente
        '
        Me.BRegistrarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BRegistrarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BRegistrarCliente.FlatAppearance.BorderSize = 2
        Me.BRegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRegistrarCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BRegistrarCliente.ForeColor = System.Drawing.Color.White
        Me.BRegistrarCliente.Location = New System.Drawing.Point(147, 329)
        Me.BRegistrarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.BRegistrarCliente.Name = "BRegistrarCliente"
        Me.BRegistrarCliente.Size = New System.Drawing.Size(115, 39)
        Me.BRegistrarCliente.TabIndex = 13
        Me.BRegistrarCliente.Text = "Registrar"
        Me.BRegistrarCliente.UseVisualStyleBackColor = False
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BCancelar.FlatAppearance.BorderSize = 2
        Me.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelar.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BCancelar.ForeColor = System.Drawing.Color.White
        Me.BCancelar.Location = New System.Drawing.Point(280, 331)
        Me.BCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(115, 39)
        Me.BCancelar.TabIndex = 12
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelar.UseVisualStyleBackColor = False
        '
        'TBContraseñaUsuario
        '
        Me.TBContraseñaUsuario.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBContraseñaUsuario.Location = New System.Drawing.Point(180, 158)
        Me.TBContraseñaUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.TBContraseñaUsuario.Name = "TBContraseñaUsuario"
        Me.TBContraseñaUsuario.Size = New System.Drawing.Size(161, 32)
        Me.TBContraseñaUsuario.TabIndex = 8
        '
        'TBNombreUsuario
        '
        Me.TBNombreUsuario.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBNombreUsuario.Location = New System.Drawing.Point(180, 110)
        Me.TBNombreUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.TBNombreUsuario.Name = "TBNombreUsuario"
        Me.TBNombreUsuario.Size = New System.Drawing.Size(161, 32)
        Me.TBNombreUsuario.TabIndex = 6
        '
        'LContraseñaUsuario
        '
        Me.LContraseñaUsuario.AutoSize = True
        Me.LContraseñaUsuario.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LContraseñaUsuario.ForeColor = System.Drawing.Color.White
        Me.LContraseñaUsuario.Location = New System.Drawing.Point(43, 160)
        Me.LContraseñaUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LContraseñaUsuario.Name = "LContraseñaUsuario"
        Me.LContraseñaUsuario.Size = New System.Drawing.Size(128, 25)
        Me.LContraseñaUsuario.TabIndex = 4
        Me.LContraseñaUsuario.Text = "Contraseña:"
        '
        'LPerfilUsuario
        '
        Me.LPerfilUsuario.AutoSize = True
        Me.LPerfilUsuario.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LPerfilUsuario.ForeColor = System.Drawing.Color.White
        Me.LPerfilUsuario.Location = New System.Drawing.Point(45, 207)
        Me.LPerfilUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LPerfilUsuario.Name = "LPerfilUsuario"
        Me.LPerfilUsuario.Size = New System.Drawing.Size(70, 25)
        Me.LPerfilUsuario.TabIndex = 1
        Me.LPerfilUsuario.Text = "Perfil:"
        '
        'LNombreUsuario
        '
        Me.LNombreUsuario.AutoSize = True
        Me.LNombreUsuario.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LNombreUsuario.ForeColor = System.Drawing.Color.White
        Me.LNombreUsuario.Location = New System.Drawing.Point(43, 112)
        Me.LNombreUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LNombreUsuario.Name = "LNombreUsuario"
        Me.LNombreUsuario.Size = New System.Drawing.Size(93, 25)
        Me.LNombreUsuario.TabIndex = 0
        Me.LNombreUsuario.Text = "Nombre:"
        '
        'añadirUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1149, 633)
        Me.Controls.Add(Me.TabControlRegUsuarios)
        Me.Controls.Add(Me.LRegistroUsuario)
        Me.Controls.Add(Me.PanelRegUsuarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "añadirUsuario"
        Me.Text = "añadirUsuario"
        Me.TabControlRegUsuarios.ResumeLayout(False)
        Me.TabPageListaUsuarios.ResumeLayout(False)
        CType(Me.dgvListaUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRegUsuarios.ResumeLayout(False)
        Me.PanelRegUsuarios.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControlRegUsuarios As TabControl
    Friend WithEvents TabPageListaUsuarios As TabPage
    Friend WithEvents dgvListaUsuarios As DataGridView
    Friend WithEvents LRegistroUsuario As Label
    Friend WithEvents PanelRegUsuarios As Panel
    Friend WithEvents BRegistrarCliente As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents TBContraseñaUsuario As TextBox
    Friend WithEvents TBNombreUsuario As TextBox
    Friend WithEvents LContraseñaUsuario As Label
    Friend WithEvents LPerfilUsuario As Label
    Friend WithEvents LNombreUsuario As Label
    Friend WithEvents ComboBoxPerfiles As ComboBox
End Class
