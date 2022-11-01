<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarEmpleado
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
        Me.LRegistroEmpleado = New System.Windows.Forms.Label()
        Me.PanelRegClientes = New System.Windows.Forms.Panel()
        Me.TBDireccionEmpleado = New System.Windows.Forms.TextBox()
        Me.LDireccionEmpleado = New System.Windows.Forms.Label()
        Me.TBCorreoEmpleado = New System.Windows.Forms.TextBox()
        Me.LCorreoEmpleado = New System.Windows.Forms.Label()
        Me.BModEmpleados = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.TBTelEmpleado = New System.Windows.Forms.TextBox()
        Me.TBApellidoEmpleado = New System.Windows.Forms.TextBox()
        Me.TBDniEmpleado = New System.Windows.Forms.TextBox()
        Me.TBNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.LApellidoEmpleado = New System.Windows.Forms.Label()
        Me.LTelEmpleado = New System.Windows.Forms.Label()
        Me.LDNIEmpleado = New System.Windows.Forms.Label()
        Me.LNombreEmpleado = New System.Windows.Forms.Label()
        Me.ErrorProviderNombre = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderApellido = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderDNI = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderTelefono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderDireccion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderEmail = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelRegClientes.SuspendLayout()
        CType(Me.ErrorProviderNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderApellido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderDNI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderTelefono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LRegistroEmpleado
        '
        Me.LRegistroEmpleado.AutoSize = True
        Me.LRegistroEmpleado.BackColor = System.Drawing.Color.Transparent
        Me.LRegistroEmpleado.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRegistroEmpleado.ForeColor = System.Drawing.Color.Transparent
        Me.LRegistroEmpleado.Location = New System.Drawing.Point(222, 34)
        Me.LRegistroEmpleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LRegistroEmpleado.Name = "LRegistroEmpleado"
        Me.LRegistroEmpleado.Size = New System.Drawing.Size(275, 33)
        Me.LRegistroEmpleado.TabIndex = 5
        Me.LRegistroEmpleado.Text = "Modificar Empleado"
        '
        'PanelRegClientes
        '
        Me.PanelRegClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PanelRegClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelRegClientes.Controls.Add(Me.TBDireccionEmpleado)
        Me.PanelRegClientes.Controls.Add(Me.LDireccionEmpleado)
        Me.PanelRegClientes.Controls.Add(Me.TBCorreoEmpleado)
        Me.PanelRegClientes.Controls.Add(Me.LCorreoEmpleado)
        Me.PanelRegClientes.Controls.Add(Me.BModEmpleados)
        Me.PanelRegClientes.Controls.Add(Me.BCancelar)
        Me.PanelRegClientes.Controls.Add(Me.TBTelEmpleado)
        Me.PanelRegClientes.Controls.Add(Me.TBApellidoEmpleado)
        Me.PanelRegClientes.Controls.Add(Me.TBDniEmpleado)
        Me.PanelRegClientes.Controls.Add(Me.TBNombreEmpleado)
        Me.PanelRegClientes.Controls.Add(Me.LApellidoEmpleado)
        Me.PanelRegClientes.Controls.Add(Me.LTelEmpleado)
        Me.PanelRegClientes.Controls.Add(Me.LDNIEmpleado)
        Me.PanelRegClientes.Controls.Add(Me.LNombreEmpleado)
        Me.PanelRegClientes.Location = New System.Drawing.Point(132, 97)
        Me.PanelRegClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelRegClientes.Name = "PanelRegClientes"
        Me.PanelRegClientes.Size = New System.Drawing.Size(436, 470)
        Me.PanelRegClientes.TabIndex = 4
        '
        'TBDireccionEmpleado
        '
        Me.TBDireccionEmpleado.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBDireccionEmpleado.Location = New System.Drawing.Point(181, 239)
        Me.TBDireccionEmpleado.Margin = New System.Windows.Forms.Padding(4)
        Me.TBDireccionEmpleado.Name = "TBDireccionEmpleado"
        Me.TBDireccionEmpleado.Size = New System.Drawing.Size(161, 32)
        Me.TBDireccionEmpleado.TabIndex = 17
        '
        'LDireccionEmpleado
        '
        Me.LDireccionEmpleado.AutoSize = True
        Me.LDireccionEmpleado.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LDireccionEmpleado.ForeColor = System.Drawing.Color.White
        Me.LDireccionEmpleado.Location = New System.Drawing.Point(44, 242)
        Me.LDireccionEmpleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LDireccionEmpleado.Name = "LDireccionEmpleado"
        Me.LDireccionEmpleado.Size = New System.Drawing.Size(110, 25)
        Me.LDireccionEmpleado.TabIndex = 16
        Me.LDireccionEmpleado.Text = "Direccion:"
        '
        'TBCorreoEmpleado
        '
        Me.TBCorreoEmpleado.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBCorreoEmpleado.Location = New System.Drawing.Point(181, 286)
        Me.TBCorreoEmpleado.Margin = New System.Windows.Forms.Padding(4)
        Me.TBCorreoEmpleado.Name = "TBCorreoEmpleado"
        Me.TBCorreoEmpleado.Size = New System.Drawing.Size(161, 32)
        Me.TBCorreoEmpleado.TabIndex = 15
        '
        'LCorreoEmpleado
        '
        Me.LCorreoEmpleado.AutoSize = True
        Me.LCorreoEmpleado.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LCorreoEmpleado.ForeColor = System.Drawing.Color.White
        Me.LCorreoEmpleado.Location = New System.Drawing.Point(47, 288)
        Me.LCorreoEmpleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LCorreoEmpleado.Name = "LCorreoEmpleado"
        Me.LCorreoEmpleado.Size = New System.Drawing.Size(78, 25)
        Me.LCorreoEmpleado.TabIndex = 14
        Me.LCorreoEmpleado.Text = "E-mail:"
        '
        'BModEmpleados
        '
        Me.BModEmpleados.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BModEmpleados.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BModEmpleados.FlatAppearance.BorderSize = 2
        Me.BModEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModEmpleados.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BModEmpleados.ForeColor = System.Drawing.Color.White
        Me.BModEmpleados.Location = New System.Drawing.Point(169, 372)
        Me.BModEmpleados.Margin = New System.Windows.Forms.Padding(4)
        Me.BModEmpleados.Name = "BModEmpleados"
        Me.BModEmpleados.Size = New System.Drawing.Size(124, 41)
        Me.BModEmpleados.TabIndex = 13
        Me.BModEmpleados.Text = "Modificar"
        Me.BModEmpleados.UseVisualStyleBackColor = False
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BCancelar.FlatAppearance.BorderSize = 2
        Me.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelar.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BCancelar.ForeColor = System.Drawing.Color.White
        Me.BCancelar.Location = New System.Drawing.Point(301, 372)
        Me.BCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(116, 41)
        Me.BCancelar.TabIndex = 12
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelar.UseVisualStyleBackColor = False
        '
        'TBTelEmpleado
        '
        Me.TBTelEmpleado.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBTelEmpleado.Location = New System.Drawing.Point(181, 190)
        Me.TBTelEmpleado.Margin = New System.Windows.Forms.Padding(4)
        Me.TBTelEmpleado.Name = "TBTelEmpleado"
        Me.TBTelEmpleado.Size = New System.Drawing.Size(161, 32)
        Me.TBTelEmpleado.TabIndex = 10
        '
        'TBApellidoEmpleado
        '
        Me.TBApellidoEmpleado.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBApellidoEmpleado.Location = New System.Drawing.Point(181, 97)
        Me.TBApellidoEmpleado.Margin = New System.Windows.Forms.Padding(4)
        Me.TBApellidoEmpleado.Name = "TBApellidoEmpleado"
        Me.TBApellidoEmpleado.Size = New System.Drawing.Size(161, 32)
        Me.TBApellidoEmpleado.TabIndex = 8
        '
        'TBDniEmpleado
        '
        Me.TBDniEmpleado.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBDniEmpleado.Location = New System.Drawing.Point(181, 144)
        Me.TBDniEmpleado.Margin = New System.Windows.Forms.Padding(4)
        Me.TBDniEmpleado.Name = "TBDniEmpleado"
        Me.TBDniEmpleado.Size = New System.Drawing.Size(161, 32)
        Me.TBDniEmpleado.TabIndex = 7
        '
        'TBNombreEmpleado
        '
        Me.TBNombreEmpleado.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBNombreEmpleado.Location = New System.Drawing.Point(181, 49)
        Me.TBNombreEmpleado.Margin = New System.Windows.Forms.Padding(4)
        Me.TBNombreEmpleado.Name = "TBNombreEmpleado"
        Me.TBNombreEmpleado.Size = New System.Drawing.Size(161, 32)
        Me.TBNombreEmpleado.TabIndex = 6
        '
        'LApellidoEmpleado
        '
        Me.LApellidoEmpleado.AutoSize = True
        Me.LApellidoEmpleado.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LApellidoEmpleado.ForeColor = System.Drawing.Color.White
        Me.LApellidoEmpleado.Location = New System.Drawing.Point(44, 100)
        Me.LApellidoEmpleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LApellidoEmpleado.Name = "LApellidoEmpleado"
        Me.LApellidoEmpleado.Size = New System.Drawing.Size(95, 25)
        Me.LApellidoEmpleado.TabIndex = 4
        Me.LApellidoEmpleado.Text = "Apellido:"
        '
        'LTelEmpleado
        '
        Me.LTelEmpleado.AutoSize = True
        Me.LTelEmpleado.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LTelEmpleado.ForeColor = System.Drawing.Color.White
        Me.LTelEmpleado.Location = New System.Drawing.Point(44, 193)
        Me.LTelEmpleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LTelEmpleado.Name = "LTelEmpleado"
        Me.LTelEmpleado.Size = New System.Drawing.Size(100, 25)
        Me.LTelEmpleado.TabIndex = 3
        Me.LTelEmpleado.Text = "Telefono:"
        '
        'LDNIEmpleado
        '
        Me.LDNIEmpleado.AutoSize = True
        Me.LDNIEmpleado.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LDNIEmpleado.ForeColor = System.Drawing.Color.White
        Me.LDNIEmpleado.Location = New System.Drawing.Point(47, 146)
        Me.LDNIEmpleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LDNIEmpleado.Name = "LDNIEmpleado"
        Me.LDNIEmpleado.Size = New System.Drawing.Size(52, 25)
        Me.LDNIEmpleado.TabIndex = 1
        Me.LDNIEmpleado.Text = "DNI:"
        '
        'LNombreEmpleado
        '
        Me.LNombreEmpleado.AutoSize = True
        Me.LNombreEmpleado.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LNombreEmpleado.ForeColor = System.Drawing.Color.White
        Me.LNombreEmpleado.Location = New System.Drawing.Point(44, 52)
        Me.LNombreEmpleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LNombreEmpleado.Name = "LNombreEmpleado"
        Me.LNombreEmpleado.Size = New System.Drawing.Size(93, 25)
        Me.LNombreEmpleado.TabIndex = 0
        Me.LNombreEmpleado.Text = "Nombre:"
        '
        'ErrorProviderNombre
        '
        Me.ErrorProviderNombre.ContainerControl = Me
        '
        'ErrorProviderApellido
        '
        Me.ErrorProviderApellido.ContainerControl = Me
        '
        'ErrorProviderDNI
        '
        Me.ErrorProviderDNI.ContainerControl = Me
        '
        'ErrorProviderTelefono
        '
        Me.ErrorProviderTelefono.ContainerControl = Me
        '
        'ErrorProviderDireccion
        '
        Me.ErrorProviderDireccion.ContainerControl = Me
        '
        'ErrorProviderEmail
        '
        Me.ErrorProviderEmail.ContainerControl = Me
        '
        'ModificarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(700, 601)
        Me.Controls.Add(Me.LRegistroEmpleado)
        Me.Controls.Add(Me.PanelRegClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModificarEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModificarEmpleado"
        Me.PanelRegClientes.ResumeLayout(False)
        Me.PanelRegClientes.PerformLayout()
        CType(Me.ErrorProviderNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderApellido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderDNI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderTelefono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderDireccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderEmail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LRegistroEmpleado As Label
    Friend WithEvents PanelRegClientes As Panel
    Friend WithEvents TBDireccionEmpleado As TextBox
    Friend WithEvents LDireccionEmpleado As Label
    Friend WithEvents TBCorreoEmpleado As TextBox
    Friend WithEvents LCorreoEmpleado As Label
    Friend WithEvents BModEmpleados As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents TBTelEmpleado As TextBox
    Friend WithEvents TBApellidoEmpleado As TextBox
    Friend WithEvents TBDniEmpleado As TextBox
    Friend WithEvents TBNombreEmpleado As TextBox
    Friend WithEvents LApellidoEmpleado As Label
    Friend WithEvents LTelEmpleado As Label
    Friend WithEvents LDNIEmpleado As Label
    Friend WithEvents LNombreEmpleado As Label
    Friend WithEvents ErrorProviderNombre As ErrorProvider
    Friend WithEvents ErrorProviderApellido As ErrorProvider
    Friend WithEvents ErrorProviderDNI As ErrorProvider
    Friend WithEvents ErrorProviderTelefono As ErrorProvider
    Friend WithEvents ErrorProviderDireccion As ErrorProvider
    Friend WithEvents ErrorProviderEmail As ErrorProvider
End Class
