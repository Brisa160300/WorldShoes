<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class añadirUsuarios
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TBEmpleado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TBNombreUsuario = New System.Windows.Forms.TextBox()
        Me.CBPerfil = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBContraseñaUsuario = New System.Windows.Forms.TextBox()
        Me.TBConfirmarPass = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.TabControlRegUsuarios = New System.Windows.Forms.TabControl()
        Me.TabPageListaUsuarios = New System.Windows.Forms.TabPage()
        Me.dgvListaUsuarios = New System.Windows.Forms.DataGridView()
        Me.BRegistrarUsuario = New System.Windows.Forms.Button()
        Me.LRegistroUsuario = New System.Windows.Forms.Label()
        Me.TabControlListaEmpleados = New System.Windows.Forms.TabControl()
        Me.TabPageListaEmpleados = New System.Windows.Forms.TabPage()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.ErrorProviderNombre = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderEmpleado = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderConfPass = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderPerfil = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderPass = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox3.SuspendLayout()
        Me.TabControlRegUsuarios.SuspendLayout()
        Me.TabPageListaUsuarios.SuspendLayout()
        CType(Me.dgvListaUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlListaEmpleados.SuspendLayout()
        Me.TabPageListaEmpleados.SuspendLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderConfPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderPass, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TBEmpleado)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.TBNombreUsuario)
        Me.GroupBox3.Controls.Add(Me.CBPerfil)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.TBContraseñaUsuario)
        Me.GroupBox3.Controls.Add(Me.TBConfirmarPass)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(53, 92)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(401, 286)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Nuevo Usuario"
        '
        'TBEmpleado
        '
        Me.TBEmpleado.Enabled = False
        Me.TBEmpleado.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBEmpleado.Location = New System.Drawing.Point(226, 233)
        Me.TBEmpleado.Margin = New System.Windows.Forms.Padding(4)
        Me.TBEmpleado.Name = "TBEmpleado"
        Me.TBEmpleado.Size = New System.Drawing.Size(150, 27)
        Me.TBEmpleado.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 236)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 20)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "ID de Empleado:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(17, 144)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(195, 20)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Confirmar Contraseña:"
        '
        'TBNombreUsuario
        '
        Me.TBNombreUsuario.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBNombreUsuario.Location = New System.Drawing.Point(226, 42)
        Me.TBNombreUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.TBNombreUsuario.MaxLength = 50
        Me.TBNombreUsuario.Name = "TBNombreUsuario"
        Me.TBNombreUsuario.Size = New System.Drawing.Size(150, 27)
        Me.TBNombreUsuario.TabIndex = 20
        '
        'CBPerfil
        '
        Me.CBPerfil.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBPerfil.FormattingEnabled = True
        Me.CBPerfil.Location = New System.Drawing.Point(226, 188)
        Me.CBPerfil.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CBPerfil.Name = "CBPerfil"
        Me.CBPerfil.Size = New System.Drawing.Size(150, 28)
        Me.CBPerfil.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(17, 45)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(169, 20)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Nombre de Usuario:"
        '
        'TBContraseñaUsuario
        '
        Me.TBContraseñaUsuario.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBContraseñaUsuario.Location = New System.Drawing.Point(226, 88)
        Me.TBContraseñaUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.TBContraseñaUsuario.MaxLength = 8
        Me.TBContraseñaUsuario.Name = "TBContraseñaUsuario"
        Me.TBContraseñaUsuario.Size = New System.Drawing.Size(150, 27)
        Me.TBContraseñaUsuario.TabIndex = 6
        '
        'TBConfirmarPass
        '
        Me.TBConfirmarPass.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBConfirmarPass.Location = New System.Drawing.Point(226, 141)
        Me.TBConfirmarPass.Margin = New System.Windows.Forms.Padding(4)
        Me.TBConfirmarPass.MaxLength = 8
        Me.TBConfirmarPass.Name = "TBConfirmarPass"
        Me.TBConfirmarPass.Size = New System.Drawing.Size(150, 27)
        Me.TBConfirmarPass.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(17, 191)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 20)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Perfil:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(17, 91)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 20)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Contraseña:"
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BVolver.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.BVolver.ForeColor = System.Drawing.Color.White
        Me.BVolver.Location = New System.Drawing.Point(963, 549)
        Me.BVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(134, 52)
        Me.BVolver.TabIndex = 28
        Me.BVolver.Text = "Volver"
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'TabControlRegUsuarios
        '
        Me.TabControlRegUsuarios.Controls.Add(Me.TabPageListaUsuarios)
        Me.TabControlRegUsuarios.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlRegUsuarios.Location = New System.Drawing.Point(53, 402)
        Me.TabControlRegUsuarios.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlRegUsuarios.Name = "TabControlRegUsuarios"
        Me.TabControlRegUsuarios.SelectedIndex = 0
        Me.TabControlRegUsuarios.Size = New System.Drawing.Size(887, 230)
        Me.TabControlRegUsuarios.TabIndex = 25
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
        Me.TabPageListaUsuarios.Size = New System.Drawing.Size(879, 198)
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
        Me.dgvListaUsuarios.Size = New System.Drawing.Size(873, 194)
        Me.dgvListaUsuarios.TabIndex = 2
        '
        'BRegistrarUsuario
        '
        Me.BRegistrarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BRegistrarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BRegistrarUsuario.FlatAppearance.BorderSize = 2
        Me.BRegistrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRegistrarUsuario.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.BRegistrarUsuario.ForeColor = System.Drawing.Color.White
        Me.BRegistrarUsuario.Location = New System.Drawing.Point(963, 479)
        Me.BRegistrarUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.BRegistrarUsuario.Name = "BRegistrarUsuario"
        Me.BRegistrarUsuario.Size = New System.Drawing.Size(134, 51)
        Me.BRegistrarUsuario.TabIndex = 27
        Me.BRegistrarUsuario.Text = "Registrar"
        Me.BRegistrarUsuario.UseVisualStyleBackColor = False
        '
        'LRegistroUsuario
        '
        Me.LRegistroUsuario.AutoSize = True
        Me.LRegistroUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LRegistroUsuario.Font = New System.Drawing.Font("Britannic Bold", 17.0!)
        Me.LRegistroUsuario.ForeColor = System.Drawing.Color.Transparent
        Me.LRegistroUsuario.Location = New System.Drawing.Point(443, 26)
        Me.LRegistroUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LRegistroUsuario.Name = "LRegistroUsuario"
        Me.LRegistroUsuario.Size = New System.Drawing.Size(240, 32)
        Me.LRegistroUsuario.TabIndex = 24
        Me.LRegistroUsuario.Text = "Registrar Usuario"
        '
        'TabControlListaEmpleados
        '
        Me.TabControlListaEmpleados.Controls.Add(Me.TabPageListaEmpleados)
        Me.TabControlListaEmpleados.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlListaEmpleados.Location = New System.Drawing.Point(480, 78)
        Me.TabControlListaEmpleados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlListaEmpleados.Name = "TabControlListaEmpleados"
        Me.TabControlListaEmpleados.SelectedIndex = 0
        Me.TabControlListaEmpleados.Size = New System.Drawing.Size(624, 304)
        Me.TabControlListaEmpleados.TabIndex = 30
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
        Me.TabPageListaEmpleados.Size = New System.Drawing.Size(616, 272)
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
        Me.dgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmpleados.Size = New System.Drawing.Size(610, 268)
        Me.dgvEmpleados.TabIndex = 2
        '
        'ErrorProviderNombre
        '
        Me.ErrorProviderNombre.ContainerControl = Me
        '
        'ErrorProviderEmpleado
        '
        Me.ErrorProviderEmpleado.ContainerControl = Me
        '
        'ErrorProviderConfPass
        '
        Me.ErrorProviderConfPass.ContainerControl = Me
        '
        'ErrorProviderPerfil
        '
        Me.ErrorProviderPerfil.ContainerControl = Me
        '
        'ErrorProviderPass
        '
        Me.ErrorProviderPass.ContainerControl = Me
        '
        'añadirUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 656)
        Me.Controls.Add(Me.TabControlListaEmpleados)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.TabControlRegUsuarios)
        Me.Controls.Add(Me.BRegistrarUsuario)
        Me.Controls.Add(Me.LRegistroUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "añadirUsuarios"
        Me.Text = "AñadirUsuarios"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabControlRegUsuarios.ResumeLayout(False)
        Me.TabPageListaUsuarios.ResumeLayout(False)
        CType(Me.dgvListaUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlListaEmpleados.ResumeLayout(False)
        Me.TabPageListaEmpleados.ResumeLayout(False)
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderConfPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderPass, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TBNombreUsuario As TextBox
    Friend WithEvents CBPerfil As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TBContraseñaUsuario As TextBox
    Friend WithEvents TBConfirmarPass As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BVolver As Button
    Friend WithEvents TabControlRegUsuarios As TabControl
    Friend WithEvents TabPageListaUsuarios As TabPage
    Friend WithEvents dgvListaUsuarios As DataGridView
    Friend WithEvents BRegistrarUsuario As Button
    Friend WithEvents LRegistroUsuario As Label
    Friend WithEvents TabControlListaEmpleados As TabControl
    Friend WithEvents TabPageListaEmpleados As TabPage
    Friend WithEvents dgvEmpleados As DataGridView
    Friend WithEvents TBEmpleado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProviderNombre As ErrorProvider
    Friend WithEvents ErrorProviderEmpleado As ErrorProvider
    Friend WithEvents ErrorProviderConfPass As ErrorProvider
    Friend WithEvents ErrorProviderPerfil As ErrorProvider
    Friend WithEvents ErrorProviderPass As ErrorProvider
End Class
