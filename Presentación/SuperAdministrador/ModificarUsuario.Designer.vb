<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarUsuario
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
        Me.components = New System.ComponentModel.Container()
        Me.PanelModUsuarios = New System.Windows.Forms.Panel()
        Me.BCancelarModifCliente = New System.Windows.Forms.Button()
        Me.GroupBoxDatosCliente = New System.Windows.Forms.GroupBox()
        Me.TBConfirmarPass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBPerfil = New System.Windows.Forms.ComboBox()
        Me.LDni = New System.Windows.Forms.Label()
        Me.TBContraseñaUsuario = New System.Windows.Forms.TextBox()
        Me.TBNombreUsuario = New System.Windows.Forms.TextBox()
        Me.LNombreCliente = New System.Windows.Forms.Label()
        Me.LApellidoCliente = New System.Windows.Forms.Label()
        Me.BModificarUsuario = New System.Windows.Forms.Button()
        Me.LModUsuario = New System.Windows.Forms.Label()
        Me.ErrorProviderPass = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderPerfil = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderConfPass = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderEmpleado = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderNombre = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelModUsuarios.SuspendLayout()
        Me.GroupBoxDatosCliente.SuspendLayout()
        CType(Me.ErrorProviderPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderPerfil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderConfPass, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelModUsuarios
        '
        Me.PanelModUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PanelModUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelModUsuarios.Controls.Add(Me.BCancelarModifCliente)
        Me.PanelModUsuarios.Controls.Add(Me.GroupBoxDatosCliente)
        Me.PanelModUsuarios.Controls.Add(Me.BModificarUsuario)
        Me.PanelModUsuarios.Location = New System.Drawing.Point(55, 67)
        Me.PanelModUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelModUsuarios.Name = "PanelModUsuarios"
        Me.PanelModUsuarios.Size = New System.Drawing.Size(454, 409)
        Me.PanelModUsuarios.TabIndex = 1
        '
        'BCancelarModifCliente
        '
        Me.BCancelarModifCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BCancelarModifCliente.FlatAppearance.BorderSize = 2
        Me.BCancelarModifCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelarModifCliente.Font = New System.Drawing.Font("Britannic Bold", 15.0!)
        Me.BCancelarModifCliente.ForeColor = System.Drawing.Color.White
        Me.BCancelarModifCliente.Location = New System.Drawing.Point(291, 350)
        Me.BCancelarModifCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.BCancelarModifCliente.Name = "BCancelarModifCliente"
        Me.BCancelarModifCliente.Size = New System.Drawing.Size(105, 41)
        Me.BCancelarModifCliente.TabIndex = 12
        Me.BCancelarModifCliente.Text = "Cancelar"
        Me.BCancelarModifCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelarModifCliente.UseVisualStyleBackColor = False
        '
        'GroupBoxDatosCliente
        '
        Me.GroupBoxDatosCliente.Controls.Add(Me.TBConfirmarPass)
        Me.GroupBoxDatosCliente.Controls.Add(Me.Label2)
        Me.GroupBoxDatosCliente.Controls.Add(Me.CBPerfil)
        Me.GroupBoxDatosCliente.Controls.Add(Me.LDni)
        Me.GroupBoxDatosCliente.Controls.Add(Me.TBContraseñaUsuario)
        Me.GroupBoxDatosCliente.Controls.Add(Me.TBNombreUsuario)
        Me.GroupBoxDatosCliente.Controls.Add(Me.LNombreCliente)
        Me.GroupBoxDatosCliente.Controls.Add(Me.LApellidoCliente)
        Me.GroupBoxDatosCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.GroupBoxDatosCliente.ForeColor = System.Drawing.Color.White
        Me.GroupBoxDatosCliente.Location = New System.Drawing.Point(64, 16)
        Me.GroupBoxDatosCliente.Name = "GroupBoxDatosCliente"
        Me.GroupBoxDatosCliente.Size = New System.Drawing.Size(332, 321)
        Me.GroupBoxDatosCliente.TabIndex = 19
        Me.GroupBoxDatosCliente.TabStop = False
        Me.GroupBoxDatosCliente.Text = "Modificar Datos"
        '
        'TBConfirmarPass
        '
        Me.TBConfirmarPass.Location = New System.Drawing.Point(98, 197)
        Me.TBConfirmarPass.Margin = New System.Windows.Forms.Padding(4)
        Me.TBConfirmarPass.Name = "TBConfirmarPass"
        Me.TBConfirmarPass.Size = New System.Drawing.Size(161, 25)
        Me.TBConfirmarPass.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(95, 176)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 17)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Confirmar Contraseña:"
        '
        'CBPerfil
        '
        Me.CBPerfil.FormattingEnabled = True
        Me.CBPerfil.Items.AddRange(New Object() {"Vendedor", "Gerente"})
        Me.CBPerfil.Location = New System.Drawing.Point(98, 255)
        Me.CBPerfil.Margin = New System.Windows.Forms.Padding(2)
        Me.CBPerfil.Name = "CBPerfil"
        Me.CBPerfil.Size = New System.Drawing.Size(161, 25)
        Me.CBPerfil.TabIndex = 20
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LDni.ForeColor = System.Drawing.Color.White
        Me.LDni.Location = New System.Drawing.Point(95, 235)
        Me.LDni.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(46, 17)
        Me.LDni.TabIndex = 19
        Me.LDni.Text = "Perfil"
        '
        'TBContraseñaUsuario
        '
        Me.TBContraseñaUsuario.Location = New System.Drawing.Point(98, 139)
        Me.TBContraseñaUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.TBContraseñaUsuario.Name = "TBContraseñaUsuario"
        Me.TBContraseñaUsuario.Size = New System.Drawing.Size(161, 25)
        Me.TBContraseñaUsuario.TabIndex = 8
        '
        'TBNombreUsuario
        '
        Me.TBNombreUsuario.Location = New System.Drawing.Point(98, 80)
        Me.TBNombreUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.TBNombreUsuario.Name = "TBNombreUsuario"
        Me.TBNombreUsuario.Size = New System.Drawing.Size(161, 25)
        Me.TBNombreUsuario.TabIndex = 6
        '
        'LNombreCliente
        '
        Me.LNombreCliente.AutoSize = True
        Me.LNombreCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LNombreCliente.ForeColor = System.Drawing.Color.White
        Me.LNombreCliente.Location = New System.Drawing.Point(95, 58)
        Me.LNombreCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LNombreCliente.Name = "LNombreCliente"
        Me.LNombreCliente.Size = New System.Drawing.Size(69, 17)
        Me.LNombreCliente.TabIndex = 0
        Me.LNombreCliente.Text = "Nombre:"
        '
        'LApellidoCliente
        '
        Me.LApellidoCliente.AutoSize = True
        Me.LApellidoCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LApellidoCliente.ForeColor = System.Drawing.Color.White
        Me.LApellidoCliente.Location = New System.Drawing.Point(95, 117)
        Me.LApellidoCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LApellidoCliente.Name = "LApellidoCliente"
        Me.LApellidoCliente.Size = New System.Drawing.Size(94, 17)
        Me.LApellidoCliente.TabIndex = 4
        Me.LApellidoCliente.Text = "Contraseña:"
        '
        'BModificarUsuario
        '
        Me.BModificarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BModificarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BModificarUsuario.FlatAppearance.BorderSize = 2
        Me.BModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModificarUsuario.Font = New System.Drawing.Font("Britannic Bold", 15.0!)
        Me.BModificarUsuario.ForeColor = System.Drawing.Color.White
        Me.BModificarUsuario.Location = New System.Drawing.Point(176, 350)
        Me.BModificarUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.BModificarUsuario.Name = "BModificarUsuario"
        Me.BModificarUsuario.Size = New System.Drawing.Size(107, 41)
        Me.BModificarUsuario.TabIndex = 13
        Me.BModificarUsuario.Text = "Modificar"
        Me.BModificarUsuario.UseVisualStyleBackColor = False
        '
        'LModUsuario
        '
        Me.LModUsuario.AutoSize = True
        Me.LModUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LModUsuario.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LModUsuario.ForeColor = System.Drawing.Color.Transparent
        Me.LModUsuario.Location = New System.Drawing.Point(50, 26)
        Me.LModUsuario.Name = "LModUsuario"
        Me.LModUsuario.Size = New System.Drawing.Size(196, 27)
        Me.LModUsuario.TabIndex = 2
        Me.LModUsuario.Text = "Modifcar Usuario"
        '
        'ErrorProviderPass
        '
        Me.ErrorProviderPass.ContainerControl = Me
        '
        'ErrorProviderPerfil
        '
        Me.ErrorProviderPerfil.ContainerControl = Me
        '
        'ErrorProviderConfPass
        '
        Me.ErrorProviderConfPass.ContainerControl = Me
        '
        'ErrorProviderEmpleado
        '
        Me.ErrorProviderEmpleado.ContainerControl = Me
        '
        'ErrorProviderNombre
        '
        Me.ErrorProviderNombre.ContainerControl = Me
        '
        'ModificarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 514)
        Me.Controls.Add(Me.LModUsuario)
        Me.Controls.Add(Me.PanelModUsuarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModificarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "modificarClientevb"
        Me.PanelModUsuarios.ResumeLayout(False)
        Me.GroupBoxDatosCliente.ResumeLayout(False)
        Me.GroupBoxDatosCliente.PerformLayout()
        CType(Me.ErrorProviderPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderPerfil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderConfPass, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderNombre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelModUsuarios As Panel
    Friend WithEvents BModificarUsuario As Button
    Friend WithEvents BCancelarModifCliente As Button
    Friend WithEvents LApellidoCliente As Label
    Friend WithEvents LNombreCliente As Label
    Friend WithEvents GroupBoxDatosCliente As GroupBox
    Friend WithEvents LDni As Label
    Friend WithEvents LModUsuario As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ErrorProviderPass As ErrorProvider
    Friend WithEvents ErrorProviderPerfil As ErrorProvider
    Friend WithEvents ErrorProviderConfPass As ErrorProvider
    Friend WithEvents ErrorProviderEmpleado As ErrorProvider
    Friend WithEvents ErrorProviderNombre As ErrorProvider
    Public WithEvents TBContraseñaUsuario As TextBox
    Public WithEvents TBNombreUsuario As TextBox
    Public WithEvents CBPerfil As ComboBox
    Public WithEvents TBConfirmarPass As TextBox
End Class
