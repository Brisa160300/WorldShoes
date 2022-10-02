<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificarCliente
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
        Me.PanelModClientes = New System.Windows.Forms.Panel()
        Me.GroupBoxAdressCliente = New System.Windows.Forms.GroupBox()
        Me.TBTelCliente = New System.Windows.Forms.TextBox()
        Me.LTelCliente = New System.Windows.Forms.Label()
        Me.TBDireccion = New System.Windows.Forms.TextBox()
        Me.TBCorreoCliente = New System.Windows.Forms.TextBox()
        Me.LDireccion = New System.Windows.Forms.Label()
        Me.LCorreoCliente = New System.Windows.Forms.Label()
        Me.BCancelarModifCliente = New System.Windows.Forms.Button()
        Me.GroupBoxDatosCliente = New System.Windows.Forms.GroupBox()
        Me.LDni = New System.Windows.Forms.Label()
        Me.TBApellidoCliente = New System.Windows.Forms.TextBox()
        Me.LNombreCliente = New System.Windows.Forms.Label()
        Me.LApellidoCliente = New System.Windows.Forms.Label()
        Me.TBNombreCliente = New System.Windows.Forms.TextBox()
        Me.TBDniCliente = New System.Windows.Forms.TextBox()
        Me.BModificarCliente = New System.Windows.Forms.Button()
        Me.PanelModClientes.SuspendLayout()
        Me.GroupBoxAdressCliente.SuspendLayout()
        Me.GroupBoxDatosCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelModClientes
        '
        Me.PanelModClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PanelModClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelModClientes.Controls.Add(Me.GroupBoxAdressCliente)
        Me.PanelModClientes.Controls.Add(Me.BCancelarModifCliente)
        Me.PanelModClientes.Controls.Add(Me.GroupBoxDatosCliente)
        Me.PanelModClientes.Controls.Add(Me.BModificarCliente)
        Me.PanelModClientes.Location = New System.Drawing.Point(72, 54)
        Me.PanelModClientes.Margin = New System.Windows.Forms.Padding(5)
        Me.PanelModClientes.Name = "PanelModClientes"
        Me.PanelModClientes.Size = New System.Drawing.Size(973, 536)
        Me.PanelModClientes.TabIndex = 1
        '
        'GroupBoxAdressCliente
        '
        Me.GroupBoxAdressCliente.Controls.Add(Me.TBTelCliente)
        Me.GroupBoxAdressCliente.Controls.Add(Me.LTelCliente)
        Me.GroupBoxAdressCliente.Controls.Add(Me.TBDireccion)
        Me.GroupBoxAdressCliente.Controls.Add(Me.TBCorreoCliente)
        Me.GroupBoxAdressCliente.Controls.Add(Me.LDireccion)
        Me.GroupBoxAdressCliente.Controls.Add(Me.LCorreoCliente)
        Me.GroupBoxAdressCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.GroupBoxAdressCliente.ForeColor = System.Drawing.Color.White
        Me.GroupBoxAdressCliente.Location = New System.Drawing.Point(31, 224)
        Me.GroupBoxAdressCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxAdressCliente.Name = "GroupBoxAdressCliente"
        Me.GroupBoxAdressCliente.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxAdressCliente.Size = New System.Drawing.Size(911, 153)
        Me.GroupBoxAdressCliente.TabIndex = 20
        Me.GroupBoxAdressCliente.TabStop = False
        Me.GroupBoxAdressCliente.Text = "Direcciones"
        '
        'TBTelCliente
        '
        Me.TBTelCliente.Location = New System.Drawing.Point(20, 74)
        Me.TBTelCliente.Margin = New System.Windows.Forms.Padding(5)
        Me.TBTelCliente.Name = "TBTelCliente"
        Me.TBTelCliente.Size = New System.Drawing.Size(213, 30)
        Me.TBTelCliente.TabIndex = 10
        '
        'LTelCliente
        '
        Me.LTelCliente.AutoSize = True
        Me.LTelCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LTelCliente.ForeColor = System.Drawing.Color.White
        Me.LTelCliente.Location = New System.Drawing.Point(16, 48)
        Me.LTelCliente.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LTelCliente.Name = "LTelCliente"
        Me.LTelCliente.Size = New System.Drawing.Size(90, 22)
        Me.LTelCliente.TabIndex = 3
        Me.LTelCliente.Text = "Telefono:"
        '
        'TBDireccion
        '
        Me.TBDireccion.Location = New System.Drawing.Point(513, 74)
        Me.TBDireccion.Margin = New System.Windows.Forms.Padding(5)
        Me.TBDireccion.Name = "TBDireccion"
        Me.TBDireccion.Size = New System.Drawing.Size(213, 30)
        Me.TBDireccion.TabIndex = 17
        '
        'TBCorreoCliente
        '
        Me.TBCorreoCliente.Location = New System.Drawing.Point(267, 74)
        Me.TBCorreoCliente.Margin = New System.Windows.Forms.Padding(5)
        Me.TBCorreoCliente.Name = "TBCorreoCliente"
        Me.TBCorreoCliente.Size = New System.Drawing.Size(213, 30)
        Me.TBCorreoCliente.TabIndex = 15
        '
        'LDireccion
        '
        Me.LDireccion.AutoSize = True
        Me.LDireccion.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LDireccion.ForeColor = System.Drawing.Color.White
        Me.LDireccion.Location = New System.Drawing.Point(509, 48)
        Me.LDireccion.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LDireccion.Name = "LDireccion"
        Me.LDireccion.Size = New System.Drawing.Size(100, 22)
        Me.LDireccion.TabIndex = 16
        Me.LDireccion.Text = "Domicilio:"
        '
        'LCorreoCliente
        '
        Me.LCorreoCliente.AutoSize = True
        Me.LCorreoCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LCorreoCliente.ForeColor = System.Drawing.Color.White
        Me.LCorreoCliente.Location = New System.Drawing.Point(264, 48)
        Me.LCorreoCliente.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LCorreoCliente.Name = "LCorreoCliente"
        Me.LCorreoCliente.Size = New System.Drawing.Size(70, 22)
        Me.LCorreoCliente.TabIndex = 14
        Me.LCorreoCliente.Text = "E-mail:"
        '
        'BCancelarModifCliente
        '
        Me.BCancelarModifCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BCancelarModifCliente.FlatAppearance.BorderSize = 2
        Me.BCancelarModifCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelarModifCliente.Font = New System.Drawing.Font("Britannic Bold", 15.0!)
        Me.BCancelarModifCliente.ForeColor = System.Drawing.Color.White
        Me.BCancelarModifCliente.Location = New System.Drawing.Point(776, 424)
        Me.BCancelarModifCliente.Margin = New System.Windows.Forms.Padding(5)
        Me.BCancelarModifCliente.Name = "BCancelarModifCliente"
        Me.BCancelarModifCliente.Size = New System.Drawing.Size(166, 60)
        Me.BCancelarModifCliente.TabIndex = 12
        Me.BCancelarModifCliente.Text = "Cancelar"
        Me.BCancelarModifCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelarModifCliente.UseVisualStyleBackColor = False
        '
        'GroupBoxDatosCliente
        '
        Me.GroupBoxDatosCliente.Controls.Add(Me.LDni)
        Me.GroupBoxDatosCliente.Controls.Add(Me.TBApellidoCliente)
        Me.GroupBoxDatosCliente.Controls.Add(Me.LNombreCliente)
        Me.GroupBoxDatosCliente.Controls.Add(Me.LApellidoCliente)
        Me.GroupBoxDatosCliente.Controls.Add(Me.TBNombreCliente)
        Me.GroupBoxDatosCliente.Controls.Add(Me.TBDniCliente)
        Me.GroupBoxDatosCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.GroupBoxDatosCliente.ForeColor = System.Drawing.Color.White
        Me.GroupBoxDatosCliente.Location = New System.Drawing.Point(31, 68)
        Me.GroupBoxDatosCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxDatosCliente.Name = "GroupBoxDatosCliente"
        Me.GroupBoxDatosCliente.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxDatosCliente.Size = New System.Drawing.Size(911, 123)
        Me.GroupBoxDatosCliente.TabIndex = 19
        Me.GroupBoxDatosCliente.TabStop = False
        Me.GroupBoxDatosCliente.Text = "Datos Personales"
        '
        'LDni
        '
        Me.LDni.AutoSize = True
        Me.LDni.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LDni.ForeColor = System.Drawing.Color.White
        Me.LDni.Location = New System.Drawing.Point(509, 27)
        Me.LDni.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LDni.Name = "LDni"
        Me.LDni.Size = New System.Drawing.Size(46, 22)
        Me.LDni.TabIndex = 19
        Me.LDni.Text = "Dni:"
        '
        'TBApellidoCliente
        '
        Me.TBApellidoCliente.Location = New System.Drawing.Point(268, 66)
        Me.TBApellidoCliente.Margin = New System.Windows.Forms.Padding(5)
        Me.TBApellidoCliente.Name = "TBApellidoCliente"
        Me.TBApellidoCliente.Size = New System.Drawing.Size(213, 30)
        Me.TBApellidoCliente.TabIndex = 8
        '
        'LNombreCliente
        '
        Me.LNombreCliente.AutoSize = True
        Me.LNombreCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LNombreCliente.ForeColor = System.Drawing.Color.White
        Me.LNombreCliente.Location = New System.Drawing.Point(16, 38)
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
        Me.LApellidoCliente.Location = New System.Drawing.Point(264, 41)
        Me.LApellidoCliente.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LApellidoCliente.Name = "LApellidoCliente"
        Me.LApellidoCliente.Size = New System.Drawing.Size(86, 22)
        Me.LApellidoCliente.TabIndex = 4
        Me.LApellidoCliente.Text = "Apellido:"
        '
        'TBNombreCliente
        '
        Me.TBNombreCliente.Location = New System.Drawing.Point(20, 66)
        Me.TBNombreCliente.Margin = New System.Windows.Forms.Padding(5)
        Me.TBNombreCliente.Name = "TBNombreCliente"
        Me.TBNombreCliente.Size = New System.Drawing.Size(213, 30)
        Me.TBNombreCliente.TabIndex = 6
        '
        'TBDniCliente
        '
        Me.TBDniCliente.Location = New System.Drawing.Point(513, 66)
        Me.TBDniCliente.Margin = New System.Windows.Forms.Padding(5)
        Me.TBDniCliente.Name = "TBDniCliente"
        Me.TBDniCliente.Size = New System.Drawing.Size(213, 30)
        Me.TBDniCliente.TabIndex = 7
        '
        'BModificarCliente
        '
        Me.BModificarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BModificarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BModificarCliente.FlatAppearance.BorderSize = 2
        Me.BModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModificarCliente.Font = New System.Drawing.Font("Britannic Bold", 15.0!)
        Me.BModificarCliente.ForeColor = System.Drawing.Color.White
        Me.BModificarCliente.Location = New System.Drawing.Point(591, 424)
        Me.BModificarCliente.Margin = New System.Windows.Forms.Padding(5)
        Me.BModificarCliente.Name = "BModificarCliente"
        Me.BModificarCliente.Size = New System.Drawing.Size(166, 60)
        Me.BModificarCliente.TabIndex = 13
        Me.BModificarCliente.Text = "Modificar"
        Me.BModificarCliente.UseVisualStyleBackColor = False
        '
        'modificarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 656)
        Me.Controls.Add(Me.PanelModClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "modificarCliente"
        Me.Text = "modificarClientevb"
        Me.PanelModClientes.ResumeLayout(False)
        Me.GroupBoxAdressCliente.ResumeLayout(False)
        Me.GroupBoxAdressCliente.PerformLayout()
        Me.GroupBoxDatosCliente.ResumeLayout(False)
        Me.GroupBoxDatosCliente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelModClientes As Panel
    Friend WithEvents TBDireccion As TextBox
    Friend WithEvents LDireccion As Label
    Friend WithEvents TBCorreoCliente As TextBox
    Friend WithEvents LCorreoCliente As Label
    Friend WithEvents BModificarCliente As Button
    Friend WithEvents BCancelarModifCliente As Button
    Friend WithEvents TBTelCliente As TextBox
    Friend WithEvents TBApellidoCliente As TextBox
    Friend WithEvents TBDniCliente As TextBox
    Friend WithEvents TBNombreCliente As TextBox
    Friend WithEvents LApellidoCliente As Label
    Friend WithEvents LTelCliente As Label
    Friend WithEvents LNombreCliente As Label
    Friend WithEvents GroupBoxDatosCliente As GroupBox
    Friend WithEvents GroupBoxAdressCliente As GroupBox
    Friend WithEvents LDni As Label
End Class
