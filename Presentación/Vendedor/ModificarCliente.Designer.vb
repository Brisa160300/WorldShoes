<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarClienteGerente
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
        Me.LRegistroCliente = New System.Windows.Forms.Label()
        Me.PanelRegClientes = New System.Windows.Forms.Panel()
        Me.TBDireccion = New System.Windows.Forms.TextBox()
        Me.LDireccion = New System.Windows.Forms.Label()
        Me.TBCorreoCliente = New System.Windows.Forms.TextBox()
        Me.LCorreoCliente = New System.Windows.Forms.Label()
        Me.BModCliente = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.TBTelCliente = New System.Windows.Forms.TextBox()
        Me.TBApellidoCliente = New System.Windows.Forms.TextBox()
        Me.TBDniCliente = New System.Windows.Forms.TextBox()
        Me.TBNombreCliente = New System.Windows.Forms.TextBox()
        Me.LApellidoCliente = New System.Windows.Forms.Label()
        Me.LTelCliente = New System.Windows.Forms.Label()
        Me.LDNI = New System.Windows.Forms.Label()
        Me.LNombreCliente = New System.Windows.Forms.Label()
        Me.ErrorProviderEmail = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderDireccion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderTelefono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderDNI = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderApellido = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderNombre = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelRegClientes.SuspendLayout()
        CType(Me.ErrorProviderEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderTelefono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderDNI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderApellido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LRegistroCliente
        '
        Me.LRegistroCliente.AutoSize = True
        Me.LRegistroCliente.BackColor = System.Drawing.Color.Transparent
        Me.LRegistroCliente.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRegistroCliente.ForeColor = System.Drawing.Color.Transparent
        Me.LRegistroCliente.Location = New System.Drawing.Point(166, 22)
        Me.LRegistroCliente.Name = "LRegistroCliente"
        Me.LRegistroCliente.Size = New System.Drawing.Size(194, 27)
        Me.LRegistroCliente.TabIndex = 3
        Me.LRegistroCliente.Text = "Modificar Cliente"
        '
        'PanelRegClientes
        '
        Me.PanelRegClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PanelRegClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelRegClientes.Controls.Add(Me.TBDireccion)
        Me.PanelRegClientes.Controls.Add(Me.LDireccion)
        Me.PanelRegClientes.Controls.Add(Me.TBCorreoCliente)
        Me.PanelRegClientes.Controls.Add(Me.LCorreoCliente)
        Me.PanelRegClientes.Controls.Add(Me.BModCliente)
        Me.PanelRegClientes.Controls.Add(Me.BCancelar)
        Me.PanelRegClientes.Controls.Add(Me.TBTelCliente)
        Me.PanelRegClientes.Controls.Add(Me.TBApellidoCliente)
        Me.PanelRegClientes.Controls.Add(Me.TBDniCliente)
        Me.PanelRegClientes.Controls.Add(Me.TBNombreCliente)
        Me.PanelRegClientes.Controls.Add(Me.LApellidoCliente)
        Me.PanelRegClientes.Controls.Add(Me.LTelCliente)
        Me.PanelRegClientes.Controls.Add(Me.LDNI)
        Me.PanelRegClientes.Controls.Add(Me.LNombreCliente)
        Me.PanelRegClientes.Location = New System.Drawing.Point(98, 73)
        Me.PanelRegClientes.Name = "PanelRegClientes"
        Me.PanelRegClientes.Size = New System.Drawing.Size(327, 368)
        Me.PanelRegClientes.TabIndex = 2
        '
        'TBDireccion
        '
        Me.TBDireccion.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBDireccion.Location = New System.Drawing.Point(136, 194)
        Me.TBDireccion.Name = "TBDireccion"
        Me.TBDireccion.Size = New System.Drawing.Size(122, 27)
        Me.TBDireccion.TabIndex = 17
        '
        'LDireccion
        '
        Me.LDireccion.AutoSize = True
        Me.LDireccion.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LDireccion.ForeColor = System.Drawing.Color.White
        Me.LDireccion.Location = New System.Drawing.Point(33, 197)
        Me.LDireccion.Name = "LDireccion"
        Me.LDireccion.Size = New System.Drawing.Size(91, 20)
        Me.LDireccion.TabIndex = 16
        Me.LDireccion.Text = "Direccion:"
        '
        'TBCorreoCliente
        '
        Me.TBCorreoCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBCorreoCliente.Location = New System.Drawing.Point(136, 232)
        Me.TBCorreoCliente.Name = "TBCorreoCliente"
        Me.TBCorreoCliente.Size = New System.Drawing.Size(122, 27)
        Me.TBCorreoCliente.TabIndex = 15
        '
        'LCorreoCliente
        '
        Me.LCorreoCliente.AutoSize = True
        Me.LCorreoCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LCorreoCliente.ForeColor = System.Drawing.Color.White
        Me.LCorreoCliente.Location = New System.Drawing.Point(35, 234)
        Me.LCorreoCliente.Name = "LCorreoCliente"
        Me.LCorreoCliente.Size = New System.Drawing.Size(64, 20)
        Me.LCorreoCliente.TabIndex = 14
        Me.LCorreoCliente.Text = "E-mail:"
        '
        'BModCliente
        '
        Me.BModCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BModCliente.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BModCliente.FlatAppearance.BorderSize = 2
        Me.BModCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BModCliente.ForeColor = System.Drawing.Color.White
        Me.BModCliente.Location = New System.Drawing.Point(127, 302)
        Me.BModCliente.Name = "BModCliente"
        Me.BModCliente.Size = New System.Drawing.Size(93, 33)
        Me.BModCliente.TabIndex = 13
        Me.BModCliente.Text = "Modificar"
        Me.BModCliente.UseVisualStyleBackColor = False
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BCancelar.FlatAppearance.BorderSize = 2
        Me.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelar.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BCancelar.ForeColor = System.Drawing.Color.White
        Me.BCancelar.Location = New System.Drawing.Point(226, 302)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(87, 33)
        Me.BCancelar.TabIndex = 12
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelar.UseVisualStyleBackColor = False
        '
        'TBTelCliente
        '
        Me.TBTelCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBTelCliente.Location = New System.Drawing.Point(136, 154)
        Me.TBTelCliente.Name = "TBTelCliente"
        Me.TBTelCliente.Size = New System.Drawing.Size(122, 27)
        Me.TBTelCliente.TabIndex = 10
        '
        'TBApellidoCliente
        '
        Me.TBApellidoCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBApellidoCliente.Location = New System.Drawing.Point(136, 79)
        Me.TBApellidoCliente.Name = "TBApellidoCliente"
        Me.TBApellidoCliente.Size = New System.Drawing.Size(122, 27)
        Me.TBApellidoCliente.TabIndex = 8
        '
        'TBDniCliente
        '
        Me.TBDniCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBDniCliente.Location = New System.Drawing.Point(136, 117)
        Me.TBDniCliente.Name = "TBDniCliente"
        Me.TBDniCliente.Size = New System.Drawing.Size(122, 27)
        Me.TBDniCliente.TabIndex = 7
        '
        'TBNombreCliente
        '
        Me.TBNombreCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBNombreCliente.Location = New System.Drawing.Point(136, 40)
        Me.TBNombreCliente.Name = "TBNombreCliente"
        Me.TBNombreCliente.Size = New System.Drawing.Size(122, 27)
        Me.TBNombreCliente.TabIndex = 6
        '
        'LApellidoCliente
        '
        Me.LApellidoCliente.AutoSize = True
        Me.LApellidoCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LApellidoCliente.ForeColor = System.Drawing.Color.White
        Me.LApellidoCliente.Location = New System.Drawing.Point(33, 81)
        Me.LApellidoCliente.Name = "LApellidoCliente"
        Me.LApellidoCliente.Size = New System.Drawing.Size(78, 20)
        Me.LApellidoCliente.TabIndex = 4
        Me.LApellidoCliente.Text = "Apellido:"
        '
        'LTelCliente
        '
        Me.LTelCliente.AutoSize = True
        Me.LTelCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LTelCliente.ForeColor = System.Drawing.Color.White
        Me.LTelCliente.Location = New System.Drawing.Point(33, 157)
        Me.LTelCliente.Name = "LTelCliente"
        Me.LTelCliente.Size = New System.Drawing.Size(82, 20)
        Me.LTelCliente.TabIndex = 3
        Me.LTelCliente.Text = "Telefono:"
        '
        'LDNI
        '
        Me.LDNI.AutoSize = True
        Me.LDNI.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LDNI.ForeColor = System.Drawing.Color.White
        Me.LDNI.Location = New System.Drawing.Point(35, 119)
        Me.LDNI.Name = "LDNI"
        Me.LDNI.Size = New System.Drawing.Size(43, 20)
        Me.LDNI.TabIndex = 1
        Me.LDNI.Text = "DNI:"
        '
        'LNombreCliente
        '
        Me.LNombreCliente.AutoSize = True
        Me.LNombreCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LNombreCliente.ForeColor = System.Drawing.Color.White
        Me.LNombreCliente.Location = New System.Drawing.Point(33, 42)
        Me.LNombreCliente.Name = "LNombreCliente"
        Me.LNombreCliente.Size = New System.Drawing.Size(77, 20)
        Me.LNombreCliente.TabIndex = 0
        Me.LNombreCliente.Text = "Nombre:"
        '
        'ErrorProviderEmail
        '
        Me.ErrorProviderEmail.ContainerControl = Me
        '
        'ErrorProviderDireccion
        '
        Me.ErrorProviderDireccion.ContainerControl = Me
        '
        'ErrorProviderTelefono
        '
        Me.ErrorProviderTelefono.ContainerControl = Me
        '
        'ErrorProviderDNI
        '
        Me.ErrorProviderDNI.ContainerControl = Me
        '
        'ErrorProviderApellido
        '
        Me.ErrorProviderApellido.ContainerControl = Me
        '
        'ErrorProviderNombre
        '
        Me.ErrorProviderNombre.ContainerControl = Me
        '
        'ModificarClienteGerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(525, 488)
        Me.Controls.Add(Me.LRegistroCliente)
        Me.Controls.Add(Me.PanelRegClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ModificarClienteGerente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModificarCliente"
        Me.PanelRegClientes.ResumeLayout(False)
        Me.PanelRegClientes.PerformLayout()
        CType(Me.ErrorProviderEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderDireccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderTelefono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderDNI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderApellido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderNombre, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LRegistroCliente As Label
    Friend WithEvents PanelRegClientes As Panel
    Friend WithEvents TBDireccion As TextBox
    Friend WithEvents LDireccion As Label
    Friend WithEvents TBCorreoCliente As TextBox
    Friend WithEvents LCorreoCliente As Label
    Friend WithEvents BModCliente As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents TBTelCliente As TextBox
    Friend WithEvents TBApellidoCliente As TextBox
    Friend WithEvents TBDniCliente As TextBox
    Friend WithEvents TBNombreCliente As TextBox
    Friend WithEvents LApellidoCliente As Label
    Friend WithEvents LTelCliente As Label
    Friend WithEvents LDNI As Label
    Friend WithEvents LNombreCliente As Label
    Friend WithEvents ErrorProviderEmail As ErrorProvider
    Friend WithEvents ErrorProviderDireccion As ErrorProvider
    Friend WithEvents ErrorProviderTelefono As ErrorProvider
    Friend WithEvents ErrorProviderDNI As ErrorProvider
    Friend WithEvents ErrorProviderApellido As ErrorProvider
    Friend WithEvents ErrorProviderNombre As ErrorProvider
End Class
