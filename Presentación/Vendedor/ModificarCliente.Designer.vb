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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBApellidoCliente = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
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
        Me.PanelModClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.PanelModClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelModClientes.Controls.Add(Me.GroupBoxAdressCliente)
        Me.PanelModClientes.Controls.Add(Me.BCancelarModifCliente)
        Me.PanelModClientes.Controls.Add(Me.GroupBoxDatosCliente)
        Me.PanelModClientes.Controls.Add(Me.BModificarCliente)
        Me.PanelModClientes.Location = New System.Drawing.Point(49, 49)
        Me.PanelModClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelModClientes.Name = "PanelModClientes"
        Me.PanelModClientes.Size = New System.Drawing.Size(638, 306)
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
        Me.GroupBoxAdressCliente.Location = New System.Drawing.Point(23, 136)
        Me.GroupBoxAdressCliente.Name = "GroupBoxAdressCliente"
        Me.GroupBoxAdressCliente.Size = New System.Drawing.Size(596, 100)
        Me.GroupBoxAdressCliente.TabIndex = 20
        Me.GroupBoxAdressCliente.TabStop = False
        Me.GroupBoxAdressCliente.Text = "Direcciones"
        '
        'TBTelCliente
        '
        Me.TBTelCliente.Location = New System.Drawing.Point(15, 49)
        Me.TBTelCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBTelCliente.Name = "TBTelCliente"
        Me.TBTelCliente.Size = New System.Drawing.Size(161, 25)
        Me.TBTelCliente.TabIndex = 10
        '
        'LTelCliente
        '
        Me.LTelCliente.AutoSize = True
        Me.LTelCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LTelCliente.ForeColor = System.Drawing.Color.White
        Me.LTelCliente.Location = New System.Drawing.Point(12, 28)
        Me.LTelCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LTelCliente.Name = "LTelCliente"
        Me.LTelCliente.Size = New System.Drawing.Size(73, 17)
        Me.LTelCliente.TabIndex = 3
        Me.LTelCliente.Text = "Telefono:"
        '
        'TBDireccion
        '
        Me.TBDireccion.Location = New System.Drawing.Point(385, 49)
        Me.TBDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.TBDireccion.Name = "TBDireccion"
        Me.TBDireccion.Size = New System.Drawing.Size(161, 25)
        Me.TBDireccion.TabIndex = 17
        '
        'TBCorreoCliente
        '
        Me.TBCorreoCliente.Location = New System.Drawing.Point(200, 49)
        Me.TBCorreoCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBCorreoCliente.Name = "TBCorreoCliente"
        Me.TBCorreoCliente.Size = New System.Drawing.Size(161, 25)
        Me.TBCorreoCliente.TabIndex = 15
        '
        'LDireccion
        '
        Me.LDireccion.AutoSize = True
        Me.LDireccion.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LDireccion.ForeColor = System.Drawing.Color.White
        Me.LDireccion.Location = New System.Drawing.Point(382, 28)
        Me.LDireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LDireccion.Name = "LDireccion"
        Me.LDireccion.Size = New System.Drawing.Size(79, 17)
        Me.LDireccion.TabIndex = 16
        Me.LDireccion.Text = "Domicilio:"
        '
        'LCorreoCliente
        '
        Me.LCorreoCliente.AutoSize = True
        Me.LCorreoCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LCorreoCliente.ForeColor = System.Drawing.Color.White
        Me.LCorreoCliente.Location = New System.Drawing.Point(198, 28)
        Me.LCorreoCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LCorreoCliente.Name = "LCorreoCliente"
        Me.LCorreoCliente.Size = New System.Drawing.Size(55, 17)
        Me.LCorreoCliente.TabIndex = 14
        Me.LCorreoCliente.Text = "E-mail:"
        '
        'BCancelarModifCliente
        '
        Me.BCancelarModifCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BCancelarModifCliente.FlatAppearance.BorderSize = 2
        Me.BCancelarModifCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelarModifCliente.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelarModifCliente.ForeColor = System.Drawing.Color.White
        Me.BCancelarModifCliente.Location = New System.Drawing.Point(325, 258)
        Me.BCancelarModifCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.BCancelarModifCliente.Name = "BCancelarModifCliente"
        Me.BCancelarModifCliente.Size = New System.Drawing.Size(98, 32)
        Me.BCancelarModifCliente.TabIndex = 12
        Me.BCancelarModifCliente.Text = "Cancelar"
        Me.BCancelarModifCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelarModifCliente.UseVisualStyleBackColor = False
        '
        'GroupBoxDatosCliente
        '
        Me.GroupBoxDatosCliente.Controls.Add(Me.Label1)
        Me.GroupBoxDatosCliente.Controls.Add(Me.TBApellidoCliente)
        Me.GroupBoxDatosCliente.Controls.Add(Me.ComboBox1)
        Me.GroupBoxDatosCliente.Controls.Add(Me.LNombreCliente)
        Me.GroupBoxDatosCliente.Controls.Add(Me.LApellidoCliente)
        Me.GroupBoxDatosCliente.Controls.Add(Me.TBNombreCliente)
        Me.GroupBoxDatosCliente.Controls.Add(Me.TBDniCliente)
        Me.GroupBoxDatosCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.GroupBoxDatosCliente.ForeColor = System.Drawing.Color.White
        Me.GroupBoxDatosCliente.Location = New System.Drawing.Point(23, 9)
        Me.GroupBoxDatosCliente.Name = "GroupBoxDatosCliente"
        Me.GroupBoxDatosCliente.Size = New System.Drawing.Size(596, 100)
        Me.GroupBoxDatosCliente.TabIndex = 19
        Me.GroupBoxDatosCliente.TabStop = False
        Me.GroupBoxDatosCliente.Text = "Datos Personales"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(373, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 17)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Tipo de documento:"
        '
        'TBApellidoCliente
        '
        Me.TBApellidoCliente.Location = New System.Drawing.Point(201, 54)
        Me.TBApellidoCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBApellidoCliente.Name = "TBApellidoCliente"
        Me.TBApellidoCliente.Size = New System.Drawing.Size(161, 25)
        Me.TBApellidoCliente.TabIndex = 8
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"DNI", "OTRO"})
        Me.ComboBox1.Location = New System.Drawing.Point(376, 53)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(45, 25)
        Me.ComboBox1.TabIndex = 18
        '
        'LNombreCliente
        '
        Me.LNombreCliente.AutoSize = True
        Me.LNombreCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LNombreCliente.ForeColor = System.Drawing.Color.White
        Me.LNombreCliente.Location = New System.Drawing.Point(12, 31)
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
        Me.LApellidoCliente.Location = New System.Drawing.Point(198, 33)
        Me.LApellidoCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LApellidoCliente.Name = "LApellidoCliente"
        Me.LApellidoCliente.Size = New System.Drawing.Size(69, 17)
        Me.LApellidoCliente.TabIndex = 4
        Me.LApellidoCliente.Text = "Apellido:"
        '
        'TBNombreCliente
        '
        Me.TBNombreCliente.Location = New System.Drawing.Point(15, 54)
        Me.TBNombreCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBNombreCliente.Name = "TBNombreCliente"
        Me.TBNombreCliente.Size = New System.Drawing.Size(161, 25)
        Me.TBNombreCliente.TabIndex = 6
        '
        'TBDniCliente
        '
        Me.TBDniCliente.Location = New System.Drawing.Point(428, 54)
        Me.TBDniCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBDniCliente.Name = "TBDniCliente"
        Me.TBDniCliente.Size = New System.Drawing.Size(161, 25)
        Me.TBDniCliente.TabIndex = 7
        '
        'BModificarCliente
        '
        Me.BModificarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BModificarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BModificarCliente.FlatAppearance.BorderSize = 2
        Me.BModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModificarCliente.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BModificarCliente.ForeColor = System.Drawing.Color.White
        Me.BModificarCliente.Location = New System.Drawing.Point(206, 258)
        Me.BModificarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.BModificarCliente.Name = "BModificarCliente"
        Me.BModificarCliente.Size = New System.Drawing.Size(97, 32)
        Me.BModificarCliente.TabIndex = 13
        Me.BModificarCliente.Text = "Modificar"
        Me.BModificarCliente.UseVisualStyleBackColor = False
        '
        'modificarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(765, 402)
        Me.Controls.Add(Me.PanelModClientes)
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
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBoxDatosCliente As GroupBox
    Friend WithEvents GroupBoxAdressCliente As GroupBox
    Friend WithEvents Label1 As Label
End Class
