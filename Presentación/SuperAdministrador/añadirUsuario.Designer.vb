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
        Me.LRegistroUsuario = New System.Windows.Forms.Label()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.BRegistrarCliente = New System.Windows.Forms.Button()
        Me.TabPageListaUsuarios = New System.Windows.Forms.TabPage()
        Me.dgvListaUsuarios = New System.Windows.Forms.DataGridView()
        Me.ColumnNombreUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnContraseña = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColumnPerfil = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControlRegUsuarios = New System.Windows.Forms.TabControl()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BBuscarProducto = New System.Windows.Forms.Button()
        Me.TBGestionProductos = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBNombreUsuario = New System.Windows.Forms.TextBox()
        Me.ComboBoxPerfil = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBContraseñaUsuario = New System.Windows.Forms.TextBox()
        Me.TBConfirmarPass = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TabPageListaUsuarios.SuspendLayout()
        CType(Me.dgvListaUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlRegUsuarios.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'LRegistroUsuario
        '
        Me.LRegistroUsuario.AutoSize = True
        Me.LRegistroUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LRegistroUsuario.Font = New System.Drawing.Font("Britannic Bold", 17.0!)
        Me.LRegistroUsuario.ForeColor = System.Drawing.Color.Transparent
        Me.LRegistroUsuario.Location = New System.Drawing.Point(428, 20)
        Me.LRegistroUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LRegistroUsuario.Name = "LRegistroUsuario"
        Me.LRegistroUsuario.Size = New System.Drawing.Size(241, 32)
        Me.LRegistroUsuario.TabIndex = 6
        Me.LRegistroUsuario.Text = "Registrar Usuario"
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BVolver.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.BVolver.ForeColor = System.Drawing.Color.White
        Me.BVolver.Location = New System.Drawing.Point(948, 543)
        Me.BVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(112, 52)
        Me.BVolver.TabIndex = 16
        Me.BVolver.Text = "Volver"
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'BRegistrarCliente
        '
        Me.BRegistrarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BRegistrarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BRegistrarCliente.FlatAppearance.BorderSize = 2
        Me.BRegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRegistrarCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.BRegistrarCliente.ForeColor = System.Drawing.Color.White
        Me.BRegistrarCliente.Location = New System.Drawing.Point(948, 473)
        Me.BRegistrarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.BRegistrarCliente.Name = "BRegistrarCliente"
        Me.BRegistrarCliente.Size = New System.Drawing.Size(109, 51)
        Me.BRegistrarCliente.TabIndex = 13
        Me.BRegistrarCliente.Text = "Registrar"
        Me.BRegistrarCliente.UseVisualStyleBackColor = False
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
        Me.TabPageListaUsuarios.Size = New System.Drawing.Size(854, 198)
        Me.TabPageListaUsuarios.TabIndex = 0
        Me.TabPageListaUsuarios.Text = "Lista de Usuarios"
        Me.TabPageListaUsuarios.UseVisualStyleBackColor = True
        '
        'dgvListaUsuarios
        '
        Me.dgvListaUsuarios.AllowUserToAddRows = False
        Me.dgvListaUsuarios.AllowUserToDeleteRows = False
        Me.dgvListaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
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
        Me.dgvListaUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnNombreUsuario, Me.ColumnContraseña, Me.ColumnPerfil, Me.Column1})
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
        Me.dgvListaUsuarios.ReadOnly = True
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
        Me.dgvListaUsuarios.Size = New System.Drawing.Size(848, 194)
        Me.dgvListaUsuarios.TabIndex = 2
        '
        'ColumnNombreUsuario
        '
        Me.ColumnNombreUsuario.HeaderText = "Nombre de Usuario"
        Me.ColumnNombreUsuario.MinimumWidth = 6
        Me.ColumnNombreUsuario.Name = "ColumnNombreUsuario"
        Me.ColumnNombreUsuario.ReadOnly = True
        '
        'ColumnContraseña
        '
        Me.ColumnContraseña.HeaderText = "Contraseña"
        Me.ColumnContraseña.MinimumWidth = 6
        Me.ColumnContraseña.Name = "ColumnContraseña"
        Me.ColumnContraseña.ReadOnly = True
        '
        'ColumnPerfil
        '
        Me.ColumnPerfil.HeaderText = "Perfil"
        Me.ColumnPerfil.MinimumWidth = 6
        Me.ColumnPerfil.Name = "ColumnPerfil"
        Me.ColumnPerfil.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID de Empleado"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'TabControlRegUsuarios
        '
        Me.TabControlRegUsuarios.Controls.Add(Me.TabPageListaUsuarios)
        Me.TabControlRegUsuarios.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlRegUsuarios.Location = New System.Drawing.Point(61, 395)
        Me.TabControlRegUsuarios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlRegUsuarios.Name = "TabControlRegUsuarios"
        Me.TabControlRegUsuarios.SelectedIndex = 0
        Me.TabControlRegUsuarios.Size = New System.Drawing.Size(862, 230)
        Me.TabControlRegUsuarios.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.BBuscarProducto)
        Me.GroupBox1.Controls.Add(Me.TBGestionProductos)
        Me.GroupBox1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(60, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1000, 180)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de Empleado"
        '
        'TextBox5
        '
        Me.TextBox5.Enabled = False
        Me.TextBox5.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(754, 126)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(150, 27)
        Me.TextBox5.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(749, 101)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 21)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Email:"
        '
        'TextBox6
        '
        Me.TextBox6.Enabled = False
        Me.TextBox6.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(530, 126)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(150, 27)
        Me.TextBox6.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(525, 101)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 21)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Direccion:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(305, 101)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 21)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Telefono:"
        '
        'TextBox7
        '
        Me.TextBox7.Enabled = False
        Me.TextBox7.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(310, 126)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(150, 27)
        Me.TextBox7.TabIndex = 26
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(753, 57)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(150, 27)
        Me.TextBox4.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(749, 32)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 21)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Apellido:"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(529, 57)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(150, 27)
        Me.TextBox3.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(525, 32)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 21)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(305, 32)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 21)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "ID:"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(309, 57)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(150, 27)
        Me.TextBox2.TabIndex = 17
        '
        'BBuscarProducto
        '
        Me.BBuscarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BBuscarProducto.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BBuscarProducto.FlatAppearance.BorderSize = 2
        Me.BBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBuscarProducto.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscarProducto.ForeColor = System.Drawing.Color.White
        Me.BBuscarProducto.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.search_3_32
        Me.BBuscarProducto.Location = New System.Drawing.Point(199, 74)
        Me.BBuscarProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.BBuscarProducto.Name = "BBuscarProducto"
        Me.BBuscarProducto.Size = New System.Drawing.Size(65, 50)
        Me.BBuscarProducto.TabIndex = 16
        Me.BBuscarProducto.UseVisualStyleBackColor = False
        '
        'TBGestionProductos
        '
        Me.TBGestionProductos.Enabled = False
        Me.TBGestionProductos.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBGestionProductos.Location = New System.Drawing.Point(18, 86)
        Me.TBGestionProductos.Margin = New System.Windows.Forms.Padding(4)
        Me.TBGestionProductos.Name = "TBGestionProductos"
        Me.TBGestionProductos.Size = New System.Drawing.Size(173, 27)
        Me.TBGestionProductos.TabIndex = 15
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TBNombreUsuario)
        Me.GroupBox3.Controls.Add(Me.ComboBoxPerfil)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TBContraseñaUsuario)
        Me.GroupBox3.Controls.Add(Me.TBConfirmarPass)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(61, 253)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(999, 123)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Nuevo Usuario"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(524, 23)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 21)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Confirmar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(524, 44)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 21)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Contraseña:"
        '
        'TBNombreUsuario
        '
        Me.TBNombreUsuario.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNombreUsuario.Location = New System.Drawing.Point(33, 66)
        Me.TBNombreUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.TBNombreUsuario.Name = "TBNombreUsuario"
        Me.TBNombreUsuario.Size = New System.Drawing.Size(188, 27)
        Me.TBNombreUsuario.TabIndex = 20
        '
        'ComboBoxPerfil
        '
        Me.ComboBoxPerfil.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBoxPerfil.FormattingEnabled = True
        Me.ComboBoxPerfil.Items.AddRange(New Object() {"Vendedor", "Gerente"})
        Me.ComboBoxPerfil.Location = New System.Drawing.Point(750, 64)
        Me.ComboBoxPerfil.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ComboBoxPerfil.Name = "ComboBoxPerfil"
        Me.ComboBoxPerfil.Size = New System.Drawing.Size(150, 28)
        Me.ComboBoxPerfil.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(29, 44)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(175, 21)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Nombre de Usuario:"
        '
        'TBContraseñaUsuario
        '
        Me.TBContraseñaUsuario.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBContraseñaUsuario.Location = New System.Drawing.Point(306, 66)
        Me.TBContraseñaUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.TBContraseñaUsuario.Name = "TBContraseñaUsuario"
        Me.TBContraseñaUsuario.Size = New System.Drawing.Size(150, 27)
        Me.TBContraseñaUsuario.TabIndex = 6
        '
        'TBConfirmarPass
        '
        Me.TBConfirmarPass.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBConfirmarPass.Location = New System.Drawing.Point(526, 66)
        Me.TBConfirmarPass.Margin = New System.Windows.Forms.Padding(4)
        Me.TBConfirmarPass.Name = "TBConfirmarPass"
        Me.TBConfirmarPass.Size = New System.Drawing.Size(150, 27)
        Me.TBConfirmarPass.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(746, 44)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 21)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Perfil:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(302, 44)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 21)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Contraseña:"
        '
        'añadirUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 656)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.TabControlRegUsuarios)
        Me.Controls.Add(Me.BRegistrarCliente)
        Me.Controls.Add(Me.LRegistroUsuario)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "añadirUsuario"
        Me.Text = "añadirUsuario"
        Me.TabPageListaUsuarios.ResumeLayout(False)
        CType(Me.dgvListaUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlRegUsuarios.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LRegistroUsuario As Label
    Friend WithEvents BRegistrarCliente As Button
    Friend WithEvents BVolver As Button
    Friend WithEvents TabPageListaUsuarios As TabPage
    Friend WithEvents TabControlRegUsuarios As TabControl
    Friend WithEvents dgvListaUsuarios As DataGridView
    Friend WithEvents ColumnNombreUsuario As DataGridViewTextBoxColumn
    Friend WithEvents ColumnContraseña As DataGridViewTextBoxColumn
    Friend WithEvents ColumnPerfil As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
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
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BBuscarProducto As Button
    Friend WithEvents TBGestionProductos As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TBNombreUsuario As TextBox
    Friend WithEvents ComboBoxPerfil As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TBContraseñaUsuario As TextBox
    Friend WithEvents TBConfirmarPass As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
End Class
