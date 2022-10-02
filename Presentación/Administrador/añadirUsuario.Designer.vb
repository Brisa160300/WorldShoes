<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class añadirUsuario
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
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControlRegUsuarios = New System.Windows.Forms.TabControl()
        Me.TabPageListaUsuarios = New System.Windows.Forms.TabPage()
        Me.DataGridViewRegistroClientes = New System.Windows.Forms.DataGridView()
        Me.LRegistroUsuario = New System.Windows.Forms.Label()
        Me.PanelRegUsuarios = New System.Windows.Forms.Panel()
        Me.BRegistrarCliente = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.TBApellidoCliente = New System.Windows.Forms.TextBox()
        Me.TBNombreCliente = New System.Windows.Forms.TextBox()
        Me.LApellidoCliente = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LNombreCliente = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TabControlRegUsuarios.SuspendLayout()
        Me.TabPageListaUsuarios.SuspendLayout()
        CType(Me.DataGridViewRegistroClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRegUsuarios.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlRegUsuarios
        '
        Me.TabControlRegUsuarios.Controls.Add(Me.TabPageListaUsuarios)
        Me.TabControlRegUsuarios.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlRegUsuarios.Location = New System.Drawing.Point(521, 75)
        Me.TabControlRegUsuarios.Name = "TabControlRegUsuarios"
        Me.TabControlRegUsuarios.SelectedIndex = 0
        Me.TabControlRegUsuarios.Size = New System.Drawing.Size(582, 499)
        Me.TabControlRegUsuarios.TabIndex = 7
        '
        'TabPageListaUsuarios
        '
        Me.TabPageListaUsuarios.Controls.Add(Me.DataGridViewRegistroClientes)
        Me.TabPageListaUsuarios.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaUsuarios.ForeColor = System.Drawing.Color.White
        Me.TabPageListaUsuarios.Location = New System.Drawing.Point(4, 28)
        Me.TabPageListaUsuarios.Name = "TabPageListaUsuarios"
        Me.TabPageListaUsuarios.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageListaUsuarios.Size = New System.Drawing.Size(574, 467)
        Me.TabPageListaUsuarios.TabIndex = 0
        Me.TabPageListaUsuarios.Text = "Lista de Usuarios"
        Me.TabPageListaUsuarios.UseVisualStyleBackColor = True
        '
        'DataGridViewRegistroClientes
        '
        Me.DataGridViewRegistroClientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.DataGridViewRegistroClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewRegistroClientes.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewRegistroClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewRegistroClientes.Location = New System.Drawing.Point(3, 3)
        Me.DataGridViewRegistroClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewRegistroClientes.Name = "DataGridViewRegistroClientes"
        Me.DataGridViewRegistroClientes.RowHeadersWidth = 51
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewRegistroClientes.RowsDefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewRegistroClientes.Size = New System.Drawing.Size(568, 461)
        Me.DataGridViewRegistroClientes.TabIndex = 2
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
        Me.PanelRegUsuarios.Controls.Add(Me.ComboBox1)
        Me.PanelRegUsuarios.Controls.Add(Me.BRegistrarCliente)
        Me.PanelRegUsuarios.Controls.Add(Me.BCancelar)
        Me.PanelRegUsuarios.Controls.Add(Me.TBApellidoCliente)
        Me.PanelRegUsuarios.Controls.Add(Me.TBNombreCliente)
        Me.PanelRegUsuarios.Controls.Add(Me.LApellidoCliente)
        Me.PanelRegUsuarios.Controls.Add(Me.Label3)
        Me.PanelRegUsuarios.Controls.Add(Me.LNombreCliente)
        Me.PanelRegUsuarios.Location = New System.Drawing.Point(61, 106)
        Me.PanelRegUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelRegUsuarios.Name = "PanelRegUsuarios"
        Me.PanelRegUsuarios.Size = New System.Drawing.Size(436, 441)
        Me.PanelRegUsuarios.TabIndex = 5
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
        Me.BRegistrarCliente.Size = New System.Drawing.Size(115, 40)
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
        Me.BCancelar.Size = New System.Drawing.Size(115, 40)
        Me.BCancelar.TabIndex = 12
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelar.UseVisualStyleBackColor = False
        '
        'TBApellidoCliente
        '
        Me.TBApellidoCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBApellidoCliente.Location = New System.Drawing.Point(180, 157)
        Me.TBApellidoCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBApellidoCliente.Name = "TBApellidoCliente"
        Me.TBApellidoCliente.Size = New System.Drawing.Size(161, 32)
        Me.TBApellidoCliente.TabIndex = 8
        '
        'TBNombreCliente
        '
        Me.TBNombreCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBNombreCliente.Location = New System.Drawing.Point(180, 109)
        Me.TBNombreCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBNombreCliente.Name = "TBNombreCliente"
        Me.TBNombreCliente.Size = New System.Drawing.Size(161, 32)
        Me.TBNombreCliente.TabIndex = 6
        '
        'LApellidoCliente
        '
        Me.LApellidoCliente.AutoSize = True
        Me.LApellidoCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LApellidoCliente.ForeColor = System.Drawing.Color.White
        Me.LApellidoCliente.Location = New System.Drawing.Point(43, 160)
        Me.LApellidoCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LApellidoCliente.Name = "LApellidoCliente"
        Me.LApellidoCliente.Size = New System.Drawing.Size(128, 25)
        Me.LApellidoCliente.TabIndex = 4
        Me.LApellidoCliente.Text = "Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(46, 207)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Perfil:"
        '
        'LNombreCliente
        '
        Me.LNombreCliente.AutoSize = True
        Me.LNombreCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LNombreCliente.ForeColor = System.Drawing.Color.White
        Me.LNombreCliente.Location = New System.Drawing.Point(43, 112)
        Me.LNombreCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LNombreCliente.Name = "LNombreCliente"
        Me.LNombreCliente.Size = New System.Drawing.Size(93, 25)
        Me.LNombreCliente.TabIndex = 0
        Me.LNombreCliente.Text = "Nombre:"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(180, 207)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(161, 33)
        Me.ComboBox1.TabIndex = 18
        '
        'añadirUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 632)
        Me.Controls.Add(Me.TabControlRegUsuarios)
        Me.Controls.Add(Me.LRegistroUsuario)
        Me.Controls.Add(Me.PanelRegUsuarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "añadirUsuario"
        Me.Text = "añadirUsuario"
        Me.TabControlRegUsuarios.ResumeLayout(False)
        Me.TabPageListaUsuarios.ResumeLayout(False)
        CType(Me.DataGridViewRegistroClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRegUsuarios.ResumeLayout(False)
        Me.PanelRegUsuarios.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControlRegUsuarios As TabControl
    Friend WithEvents TabPageListaUsuarios As TabPage
    Friend WithEvents DataGridViewRegistroClientes As DataGridView
    Friend WithEvents LRegistroUsuario As Label
    Friend WithEvents PanelRegUsuarios As Panel
    Friend WithEvents BRegistrarCliente As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents TBApellidoCliente As TextBox
    Friend WithEvents TBNombreCliente As TextBox
    Friend WithEvents LApellidoCliente As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LNombreCliente As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
