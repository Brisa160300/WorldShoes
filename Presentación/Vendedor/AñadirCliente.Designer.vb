<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AñadirCliente
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
        Me.PanelRegClientes = New System.Windows.Forms.Panel()
        Me.TBDireccion = New System.Windows.Forms.TextBox()
        Me.LDireccion = New System.Windows.Forms.Label()
        Me.TBCorreoCliente = New System.Windows.Forms.TextBox()
        Me.LCorreoCliente = New System.Windows.Forms.Label()
        Me.BRegistrarCliente = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.TBTelCliente = New System.Windows.Forms.TextBox()
        Me.TBApellidoCliente = New System.Windows.Forms.TextBox()
        Me.TBDniCliente = New System.Windows.Forms.TextBox()
        Me.TBNombreCliente = New System.Windows.Forms.TextBox()
        Me.LApellidoCliente = New System.Windows.Forms.Label()
        Me.LTelCliente = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LNombreCliente = New System.Windows.Forms.Label()
        Me.LRegistroCliente = New System.Windows.Forms.Label()
        Me.TabPageListaClientes = New System.Windows.Forms.TabPage()
        Me.DataGridViewRegistroClientes = New System.Windows.Forms.DataGridView()
        Me.TabControlRegClientes = New System.Windows.Forms.TabControl()
        Me.PanelRegClientes.SuspendLayout()
        Me.TabPageListaClientes.SuspendLayout()
        CType(Me.DataGridViewRegistroClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControlRegClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelRegClientes
        '
        Me.PanelRegClientes.BackColor = System.Drawing.Color.Black
        Me.PanelRegClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelRegClientes.Controls.Add(Me.TBDireccion)
        Me.PanelRegClientes.Controls.Add(Me.LDireccion)
        Me.PanelRegClientes.Controls.Add(Me.TBCorreoCliente)
        Me.PanelRegClientes.Controls.Add(Me.LCorreoCliente)
        Me.PanelRegClientes.Controls.Add(Me.BRegistrarCliente)
        Me.PanelRegClientes.Controls.Add(Me.BCancelar)
        Me.PanelRegClientes.Controls.Add(Me.TBTelCliente)
        Me.PanelRegClientes.Controls.Add(Me.TBApellidoCliente)
        Me.PanelRegClientes.Controls.Add(Me.TBDniCliente)
        Me.PanelRegClientes.Controls.Add(Me.TBNombreCliente)
        Me.PanelRegClientes.Controls.Add(Me.LApellidoCliente)
        Me.PanelRegClientes.Controls.Add(Me.LTelCliente)
        Me.PanelRegClientes.Controls.Add(Me.Label3)
        Me.PanelRegClientes.Controls.Add(Me.LNombreCliente)
        Me.PanelRegClientes.Location = New System.Drawing.Point(13, 91)
        Me.PanelRegClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelRegClientes.Name = "PanelRegClientes"
        Me.PanelRegClientes.Size = New System.Drawing.Size(430, 439)
        Me.PanelRegClientes.TabIndex = 0
        '
        'TBDireccion
        '
        Me.TBDireccion.Location = New System.Drawing.Point(150, 216)
        Me.TBDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.TBDireccion.Name = "TBDireccion"
        Me.TBDireccion.Size = New System.Drawing.Size(131, 27)
        Me.TBDireccion.TabIndex = 17
        '
        'LDireccion
        '
        Me.LDireccion.AutoSize = True
        Me.LDireccion.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LDireccion.ForeColor = System.Drawing.Color.White
        Me.LDireccion.Location = New System.Drawing.Point(36, 216)
        Me.LDireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LDireccion.Name = "LDireccion"
        Me.LDireccion.Size = New System.Drawing.Size(102, 22)
        Me.LDireccion.TabIndex = 16
        Me.LDireccion.Text = "Direccion:"
        '
        'TBCorreoCliente
        '
        Me.TBCorreoCliente.Location = New System.Drawing.Point(149, 268)
        Me.TBCorreoCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBCorreoCliente.Name = "TBCorreoCliente"
        Me.TBCorreoCliente.Size = New System.Drawing.Size(131, 27)
        Me.TBCorreoCliente.TabIndex = 15
        '
        'LCorreoCliente
        '
        Me.LCorreoCliente.AutoSize = True
        Me.LCorreoCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LCorreoCliente.ForeColor = System.Drawing.Color.White
        Me.LCorreoCliente.Location = New System.Drawing.Point(40, 273)
        Me.LCorreoCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LCorreoCliente.Name = "LCorreoCliente"
        Me.LCorreoCliente.Size = New System.Drawing.Size(70, 22)
        Me.LCorreoCliente.TabIndex = 14
        Me.LCorreoCliente.Text = "E-mail:"
        '
        'BRegistrarCliente
        '
        Me.BRegistrarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BRegistrarCliente.FlatAppearance.BorderSize = 2
        Me.BRegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRegistrarCliente.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BRegistrarCliente.ForeColor = System.Drawing.Color.White
        Me.BRegistrarCliente.Location = New System.Drawing.Point(41, 336)
        Me.BRegistrarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.BRegistrarCliente.Name = "BRegistrarCliente"
        Me.BRegistrarCliente.Size = New System.Drawing.Size(113, 46)
        Me.BRegistrarCliente.TabIndex = 13
        Me.BRegistrarCliente.Text = "Registrar"
        Me.BRegistrarCliente.UseVisualStyleBackColor = True
        '
        'BCancelar
        '
        Me.BCancelar.FlatAppearance.BorderSize = 2
        Me.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelar.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelar.ForeColor = System.Drawing.Color.White
        Me.BCancelar.Location = New System.Drawing.Point(166, 336)
        Me.BCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(115, 48)
        Me.BCancelar.TabIndex = 12
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'TBTelCliente
        '
        Me.TBTelCliente.Location = New System.Drawing.Point(149, 156)
        Me.TBTelCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBTelCliente.Name = "TBTelCliente"
        Me.TBTelCliente.Size = New System.Drawing.Size(132, 27)
        Me.TBTelCliente.TabIndex = 10
        '
        'TBApellidoCliente
        '
        Me.TBApellidoCliente.Location = New System.Drawing.Point(147, 66)
        Me.TBApellidoCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBApellidoCliente.Name = "TBApellidoCliente"
        Me.TBApellidoCliente.Size = New System.Drawing.Size(133, 27)
        Me.TBApellidoCliente.TabIndex = 8
        '
        'TBDniCliente
        '
        Me.TBDniCliente.Location = New System.Drawing.Point(148, 107)
        Me.TBDniCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBDniCliente.Name = "TBDniCliente"
        Me.TBDniCliente.Size = New System.Drawing.Size(132, 27)
        Me.TBDniCliente.TabIndex = 7
        '
        'TBNombreCliente
        '
        Me.TBNombreCliente.Location = New System.Drawing.Point(147, 22)
        Me.TBNombreCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBNombreCliente.Name = "TBNombreCliente"
        Me.TBNombreCliente.Size = New System.Drawing.Size(132, 27)
        Me.TBNombreCliente.TabIndex = 6
        '
        'LApellidoCliente
        '
        Me.LApellidoCliente.AutoSize = True
        Me.LApellidoCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LApellidoCliente.ForeColor = System.Drawing.Color.White
        Me.LApellidoCliente.Location = New System.Drawing.Point(40, 67)
        Me.LApellidoCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LApellidoCliente.Name = "LApellidoCliente"
        Me.LApellidoCliente.Size = New System.Drawing.Size(86, 22)
        Me.LApellidoCliente.TabIndex = 4
        Me.LApellidoCliente.Text = "Apellido:"
        '
        'LTelCliente
        '
        Me.LTelCliente.AutoSize = True
        Me.LTelCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LTelCliente.ForeColor = System.Drawing.Color.White
        Me.LTelCliente.Location = New System.Drawing.Point(37, 161)
        Me.LTelCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LTelCliente.Name = "LTelCliente"
        Me.LTelCliente.Size = New System.Drawing.Size(90, 22)
        Me.LTelCliente.TabIndex = 3
        Me.LTelCliente.Text = "Telefono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(40, 112)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 22)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "DNI:"
        '
        'LNombreCliente
        '
        Me.LNombreCliente.AutoSize = True
        Me.LNombreCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LNombreCliente.ForeColor = System.Drawing.Color.White
        Me.LNombreCliente.Location = New System.Drawing.Point(39, 22)
        Me.LNombreCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LNombreCliente.Name = "LNombreCliente"
        Me.LNombreCliente.Size = New System.Drawing.Size(85, 22)
        Me.LNombreCliente.TabIndex = 0
        Me.LNombreCliente.Text = "Nombre:"
        '
        'LRegistroCliente
        '
        Me.LRegistroCliente.AutoSize = True
        Me.LRegistroCliente.BackColor = System.Drawing.Color.Transparent
        Me.LRegistroCliente.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRegistroCliente.ForeColor = System.Drawing.Color.Transparent
        Me.LRegistroCliente.Location = New System.Drawing.Point(109, 28)
        Me.LRegistroCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LRegistroCliente.Name = "LRegistroCliente"
        Me.LRegistroCliente.Size = New System.Drawing.Size(239, 33)
        Me.LRegistroCliente.TabIndex = 1
        Me.LRegistroCliente.Text = "Registrar Cliente"
        '
        'TabPageListaClientes
        '
        Me.TabPageListaClientes.Controls.Add(Me.DataGridViewRegistroClientes)
        Me.TabPageListaClientes.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaClientes.ForeColor = System.Drawing.Color.White
        Me.TabPageListaClientes.Location = New System.Drawing.Point(4, 28)
        Me.TabPageListaClientes.Name = "TabPageListaClientes"
        Me.TabPageListaClientes.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageListaClientes.Size = New System.Drawing.Size(604, 501)
        Me.TabPageListaClientes.TabIndex = 0
        Me.TabPageListaClientes.Text = "Lista de Clientes"
        Me.TabPageListaClientes.UseVisualStyleBackColor = True
        '
        'DataGridViewRegistroClientes
        '
        Me.DataGridViewRegistroClientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(1, Byte), Integer))
        Me.DataGridViewRegistroClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRegistroClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewRegistroClientes.Location = New System.Drawing.Point(3, 3)
        Me.DataGridViewRegistroClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewRegistroClientes.Name = "DataGridViewRegistroClientes"
        Me.DataGridViewRegistroClientes.RowHeadersWidth = 51
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewRegistroClientes.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewRegistroClientes.Size = New System.Drawing.Size(598, 495)
        Me.DataGridViewRegistroClientes.TabIndex = 2
        '
        'TabControlRegClientes
        '
        Me.TabControlRegClientes.Controls.Add(Me.TabPageListaClientes)
        Me.TabControlRegClientes.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlRegClientes.Location = New System.Drawing.Point(472, 28)
        Me.TabControlRegClientes.Name = "TabControlRegClientes"
        Me.TabControlRegClientes.SelectedIndex = 0
        Me.TabControlRegClientes.Size = New System.Drawing.Size(612, 533)
        Me.TabControlRegClientes.TabIndex = 4
        '
        'AñadirCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1081, 562)
        Me.Controls.Add(Me.TabControlRegClientes)
        Me.Controls.Add(Me.LRegistroCliente)
        Me.Controls.Add(Me.PanelRegClientes)
        Me.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(228, 41)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AñadirCliente"
        Me.Text = "AñadirCliente"
        Me.PanelRegClientes.ResumeLayout(False)
        Me.PanelRegClientes.PerformLayout()
        Me.TabPageListaClientes.ResumeLayout(False)
        CType(Me.DataGridViewRegistroClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControlRegClientes.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelRegClientes As Panel
    Friend WithEvents TBTelCliente As TextBox
    Friend WithEvents TBApellidoCliente As TextBox
    Friend WithEvents TBDniCliente As TextBox
    Friend WithEvents TBNombreCliente As TextBox
    Friend WithEvents LApellidoCliente As Label
    Friend WithEvents LTelCliente As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LNombreCliente As Label
    Friend WithEvents LRegistroCliente As Label
    Friend WithEvents TBCorreoCliente As TextBox
    Friend WithEvents LCorreoCliente As Label
    Friend WithEvents BRegistrarCliente As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents TabPageListaClientes As TabPage
    Friend WithEvents DataGridViewRegistroClientes As DataGridView
    Friend WithEvents TabControlRegClientes As TabControl
    Friend WithEvents TBDireccion As TextBox
    Friend WithEvents LDireccion As Label
End Class
