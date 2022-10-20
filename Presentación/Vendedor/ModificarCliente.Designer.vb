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
        Me.PanelRegClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'LRegistroCliente
        '
        Me.LRegistroCliente.AutoSize = True
        Me.LRegistroCliente.BackColor = System.Drawing.Color.Transparent
        Me.LRegistroCliente.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRegistroCliente.ForeColor = System.Drawing.Color.Transparent
        Me.LRegistroCliente.Location = New System.Drawing.Point(221, 27)
        Me.LRegistroCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LRegistroCliente.Name = "LRegistroCliente"
        Me.LRegistroCliente.Size = New System.Drawing.Size(238, 33)
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
        Me.PanelRegClientes.Location = New System.Drawing.Point(131, 90)
        Me.PanelRegClientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelRegClientes.Name = "PanelRegClientes"
        Me.PanelRegClientes.Size = New System.Drawing.Size(436, 470)
        Me.PanelRegClientes.TabIndex = 2
        '
        'TBDireccion
        '
        Me.TBDireccion.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBDireccion.Location = New System.Drawing.Point(181, 239)
        Me.TBDireccion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBDireccion.Name = "TBDireccion"
        Me.TBDireccion.Size = New System.Drawing.Size(161, 32)
        Me.TBDireccion.TabIndex = 17
        '
        'LDireccion
        '
        Me.LDireccion.AutoSize = True
        Me.LDireccion.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LDireccion.ForeColor = System.Drawing.Color.White
        Me.LDireccion.Location = New System.Drawing.Point(44, 242)
        Me.LDireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LDireccion.Name = "LDireccion"
        Me.LDireccion.Size = New System.Drawing.Size(110, 25)
        Me.LDireccion.TabIndex = 16
        Me.LDireccion.Text = "Direccion:"
        '
        'TBCorreoCliente
        '
        Me.TBCorreoCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBCorreoCliente.Location = New System.Drawing.Point(181, 286)
        Me.TBCorreoCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBCorreoCliente.Name = "TBCorreoCliente"
        Me.TBCorreoCliente.Size = New System.Drawing.Size(161, 32)
        Me.TBCorreoCliente.TabIndex = 15
        '
        'LCorreoCliente
        '
        Me.LCorreoCliente.AutoSize = True
        Me.LCorreoCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LCorreoCliente.ForeColor = System.Drawing.Color.White
        Me.LCorreoCliente.Location = New System.Drawing.Point(47, 288)
        Me.LCorreoCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LCorreoCliente.Name = "LCorreoCliente"
        Me.LCorreoCliente.Size = New System.Drawing.Size(78, 25)
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
        Me.BModCliente.Location = New System.Drawing.Point(169, 372)
        Me.BModCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BModCliente.Name = "BModCliente"
        Me.BModCliente.Size = New System.Drawing.Size(124, 41)
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
        Me.BCancelar.Location = New System.Drawing.Point(301, 372)
        Me.BCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(116, 41)
        Me.BCancelar.TabIndex = 12
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelar.UseVisualStyleBackColor = False
        '
        'TBTelCliente
        '
        Me.TBTelCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBTelCliente.Location = New System.Drawing.Point(181, 190)
        Me.TBTelCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBTelCliente.Name = "TBTelCliente"
        Me.TBTelCliente.Size = New System.Drawing.Size(161, 32)
        Me.TBTelCliente.TabIndex = 10
        '
        'TBApellidoCliente
        '
        Me.TBApellidoCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBApellidoCliente.Location = New System.Drawing.Point(181, 97)
        Me.TBApellidoCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBApellidoCliente.Name = "TBApellidoCliente"
        Me.TBApellidoCliente.Size = New System.Drawing.Size(161, 32)
        Me.TBApellidoCliente.TabIndex = 8
        '
        'TBDniCliente
        '
        Me.TBDniCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBDniCliente.Location = New System.Drawing.Point(181, 144)
        Me.TBDniCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBDniCliente.Name = "TBDniCliente"
        Me.TBDniCliente.Size = New System.Drawing.Size(161, 32)
        Me.TBDniCliente.TabIndex = 7
        '
        'TBNombreCliente
        '
        Me.TBNombreCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBNombreCliente.Location = New System.Drawing.Point(181, 49)
        Me.TBNombreCliente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TBNombreCliente.Name = "TBNombreCliente"
        Me.TBNombreCliente.Size = New System.Drawing.Size(161, 32)
        Me.TBNombreCliente.TabIndex = 6
        '
        'LApellidoCliente
        '
        Me.LApellidoCliente.AutoSize = True
        Me.LApellidoCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LApellidoCliente.ForeColor = System.Drawing.Color.White
        Me.LApellidoCliente.Location = New System.Drawing.Point(44, 100)
        Me.LApellidoCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LApellidoCliente.Name = "LApellidoCliente"
        Me.LApellidoCliente.Size = New System.Drawing.Size(95, 25)
        Me.LApellidoCliente.TabIndex = 4
        Me.LApellidoCliente.Text = "Apellido:"
        '
        'LTelCliente
        '
        Me.LTelCliente.AutoSize = True
        Me.LTelCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LTelCliente.ForeColor = System.Drawing.Color.White
        Me.LTelCliente.Location = New System.Drawing.Point(44, 193)
        Me.LTelCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LTelCliente.Name = "LTelCliente"
        Me.LTelCliente.Size = New System.Drawing.Size(100, 25)
        Me.LTelCliente.TabIndex = 3
        Me.LTelCliente.Text = "Telefono:"
        '
        'LDNI
        '
        Me.LDNI.AutoSize = True
        Me.LDNI.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LDNI.ForeColor = System.Drawing.Color.White
        Me.LDNI.Location = New System.Drawing.Point(47, 146)
        Me.LDNI.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LDNI.Name = "LDNI"
        Me.LDNI.Size = New System.Drawing.Size(52, 25)
        Me.LDNI.TabIndex = 1
        Me.LDNI.Text = "DNI:"
        '
        'LNombreCliente
        '
        Me.LNombreCliente.AutoSize = True
        Me.LNombreCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LNombreCliente.ForeColor = System.Drawing.Color.White
        Me.LNombreCliente.Location = New System.Drawing.Point(44, 52)
        Me.LNombreCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LNombreCliente.Name = "LNombreCliente"
        Me.LNombreCliente.Size = New System.Drawing.Size(93, 25)
        Me.LNombreCliente.TabIndex = 0
        Me.LNombreCliente.Text = "Nombre:"
        '
        'ModificarClienteGerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 601)
        Me.Controls.Add(Me.LRegistroCliente)
        Me.Controls.Add(Me.PanelRegClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ModificarClienteGerente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModificarCliente"
        Me.PanelRegClientes.ResumeLayout(False)
        Me.PanelRegClientes.PerformLayout()
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
End Class
