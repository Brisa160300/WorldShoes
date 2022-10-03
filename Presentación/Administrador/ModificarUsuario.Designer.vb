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
        Me.PanelModUsuarios = New System.Windows.Forms.Panel()
        Me.BCancelarModifCliente = New System.Windows.Forms.Button()
        Me.GroupBoxDatosCliente = New System.Windows.Forms.GroupBox()
        Me.ComboBoxPerfil = New System.Windows.Forms.ComboBox()
        Me.LDni = New System.Windows.Forms.Label()
        Me.TBContraseñaUsuario = New System.Windows.Forms.TextBox()
        Me.LNombreCliente = New System.Windows.Forms.Label()
        Me.LApellidoCliente = New System.Windows.Forms.Label()
        Me.TBNombreUsuario = New System.Windows.Forms.TextBox()
        Me.BModificarCliente = New System.Windows.Forms.Button()
        Me.LModUsuario = New System.Windows.Forms.Label()
        Me.PanelModUsuarios.SuspendLayout()
        Me.GroupBoxDatosCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelModUsuarios
        '
        Me.PanelModUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PanelModUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelModUsuarios.Controls.Add(Me.BCancelarModifCliente)
        Me.PanelModUsuarios.Controls.Add(Me.GroupBoxDatosCliente)
        Me.PanelModUsuarios.Controls.Add(Me.BModificarCliente)
        Me.PanelModUsuarios.Location = New System.Drawing.Point(72, 110)
        Me.PanelModUsuarios.Margin = New System.Windows.Forms.Padding(5)
        Me.PanelModUsuarios.Name = "PanelModUsuarios"
        Me.PanelModUsuarios.Size = New System.Drawing.Size(605, 481)
        Me.PanelModUsuarios.TabIndex = 1
        '
        'BCancelarModifCliente
        '
        Me.BCancelarModifCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BCancelarModifCliente.FlatAppearance.BorderSize = 2
        Me.BCancelarModifCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelarModifCliente.Font = New System.Drawing.Font("Britannic Bold", 15.0!)
        Me.BCancelarModifCliente.ForeColor = System.Drawing.Color.White
        Me.BCancelarModifCliente.Location = New System.Drawing.Point(388, 391)
        Me.BCancelarModifCliente.Margin = New System.Windows.Forms.Padding(5)
        Me.BCancelarModifCliente.Name = "BCancelarModifCliente"
        Me.BCancelarModifCliente.Size = New System.Drawing.Size(140, 50)
        Me.BCancelarModifCliente.TabIndex = 12
        Me.BCancelarModifCliente.Text = "Cancelar"
        Me.BCancelarModifCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelarModifCliente.UseVisualStyleBackColor = False
        '
        'GroupBoxDatosCliente
        '
        Me.GroupBoxDatosCliente.Controls.Add(Me.ComboBoxPerfil)
        Me.GroupBoxDatosCliente.Controls.Add(Me.LDni)
        Me.GroupBoxDatosCliente.Controls.Add(Me.TBContraseñaUsuario)
        Me.GroupBoxDatosCliente.Controls.Add(Me.TBNombreUsuario)
        Me.GroupBoxDatosCliente.Controls.Add(Me.LNombreCliente)
        Me.GroupBoxDatosCliente.Controls.Add(Me.LApellidoCliente)
        Me.GroupBoxDatosCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.GroupBoxDatosCliente.ForeColor = System.Drawing.Color.White
        Me.GroupBoxDatosCliente.Location = New System.Drawing.Point(85, 48)
        Me.GroupBoxDatosCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxDatosCliente.Name = "GroupBoxDatosCliente"
        Me.GroupBoxDatosCliente.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxDatosCliente.Size = New System.Drawing.Size(443, 315)
        Me.GroupBoxDatosCliente.TabIndex = 19
        Me.GroupBoxDatosCliente.TabStop = False
        Me.GroupBoxDatosCliente.Text = "Modificar Datos"
        '
        'ComboBoxPerfil
        '
        Me.ComboBoxPerfil.FormattingEnabled = True
        Me.ComboBoxPerfil.Items.AddRange(New Object() {"Vendedor", "Gerente"})
        Me.ComboBoxPerfil.Location = New System.Drawing.Point(131, 251)
        Me.ComboBoxPerfil.Name = "ComboBoxPerfil"
        Me.ComboBoxPerfil.Size = New System.Drawing.Size(213, 30)
        Me.ComboBoxPerfil.TabIndex = 20
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LDni.ForeColor = System.Drawing.Color.White
        Me.LDni.Location = New System.Drawing.Point(127, 226)
        Me.LDni.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(58, 22)
        Me.LDni.TabIndex = 19
        Me.LDni.Text = "Perfil"
        '
        'TBContraseñaUsuario
        '
        Me.TBContraseñaUsuario.Location = New System.Drawing.Point(131, 168)
        Me.TBContraseñaUsuario.Margin = New System.Windows.Forms.Padding(5)
        Me.TBContraseñaUsuario.Name = "TBContraseñaUsuario"
        Me.TBContraseñaUsuario.Size = New System.Drawing.Size(213, 30)
        Me.TBContraseñaUsuario.TabIndex = 8
        '
        'LNombreCliente
        '
        Me.LNombreCliente.AutoSize = True
        Me.LNombreCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LNombreCliente.ForeColor = System.Drawing.Color.White
        Me.LNombreCliente.Location = New System.Drawing.Point(127, 57)
        Me.LNombreCliente.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LNombreCliente.Name = "LNombreCliente"
        Me.LNombreCliente.Size = New System.Drawing.Size(85, 22)
        Me.LNombreCliente.TabIndex = 0
        Me.LNombreCliente.Text = "Nombre:"
        '
        'LApellidoCliente
        '
        Me.LApellidoCliente.AutoSize = True
        Me.LApellidoCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LApellidoCliente.ForeColor = System.Drawing.Color.White
        Me.LApellidoCliente.Location = New System.Drawing.Point(127, 141)
        Me.LApellidoCliente.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LApellidoCliente.Name = "LApellidoCliente"
        Me.LApellidoCliente.Size = New System.Drawing.Size(118, 22)
        Me.LApellidoCliente.TabIndex = 4
        Me.LApellidoCliente.Text = "Contraseña:"
        '
        'TBNombreUsuario
        '
        Me.TBNombreUsuario.Location = New System.Drawing.Point(131, 84)
        Me.TBNombreUsuario.Margin = New System.Windows.Forms.Padding(5)
        Me.TBNombreUsuario.Name = "TBNombreUsuario"
        Me.TBNombreUsuario.Size = New System.Drawing.Size(213, 30)
        Me.TBNombreUsuario.TabIndex = 6
        '
        'BModificarCliente
        '
        Me.BModificarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BModificarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BModificarCliente.FlatAppearance.BorderSize = 2
        Me.BModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModificarCliente.Font = New System.Drawing.Font("Britannic Bold", 15.0!)
        Me.BModificarCliente.ForeColor = System.Drawing.Color.White
        Me.BModificarCliente.Location = New System.Drawing.Point(235, 391)
        Me.BModificarCliente.Margin = New System.Windows.Forms.Padding(5)
        Me.BModificarCliente.Name = "BModificarCliente"
        Me.BModificarCliente.Size = New System.Drawing.Size(143, 50)
        Me.BModificarCliente.TabIndex = 13
        Me.BModificarCliente.Text = "Modificar"
        Me.BModificarCliente.UseVisualStyleBackColor = False
        '
        'LModUsuario
        '
        Me.LModUsuario.AutoSize = True
        Me.LModUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LModUsuario.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LModUsuario.ForeColor = System.Drawing.Color.Transparent
        Me.LModUsuario.Location = New System.Drawing.Point(67, 39)
        Me.LModUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LModUsuario.Name = "LModUsuario"
        Me.LModUsuario.Size = New System.Drawing.Size(241, 33)
        Me.LModUsuario.TabIndex = 2
        Me.LModUsuario.Text = "Modifcar Usuario"
        '
        'ModificarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 631)
        Me.Controls.Add(Me.LModUsuario)
        Me.Controls.Add(Me.PanelModUsuarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ModificarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "modificarClientevb"
        Me.PanelModUsuarios.ResumeLayout(False)
        Me.GroupBoxDatosCliente.ResumeLayout(False)
        Me.GroupBoxDatosCliente.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelModUsuarios As Panel
    Friend WithEvents BModificarCliente As Button
    Friend WithEvents BCancelarModifCliente As Button
    Friend WithEvents TBContraseñaUsuario As TextBox
    Friend WithEvents TBNombreUsuario As TextBox
    Friend WithEvents LApellidoCliente As Label
    Friend WithEvents LNombreCliente As Label
    Friend WithEvents GroupBoxDatosCliente As GroupBox
    Friend WithEvents LDni As Label
    Friend WithEvents LModUsuario As Label
    Friend WithEvents ComboBoxPerfil As ComboBox
End Class
