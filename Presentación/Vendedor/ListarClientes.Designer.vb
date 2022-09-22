<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListarClientes
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
        Me.LTituloListarClientes = New System.Windows.Forms.Label()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridViewListarCliente = New System.Windows.Forms.DataGridView()
        Me.Colum_Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_DNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_FechaNaci = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_Localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PBListaClientes = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridViewListarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PBListaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LTituloListarClientes
        '
        Me.LTituloListarClientes.AutoSize = True
        Me.LTituloListarClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.8!, System.Drawing.FontStyle.Bold)
        Me.LTituloListarClientes.ForeColor = System.Drawing.Color.White
        Me.LTituloListarClientes.Location = New System.Drawing.Point(43, 60)
        Me.LTituloListarClientes.Name = "LTituloListarClientes"
        Me.LTituloListarClientes.Size = New System.Drawing.Size(139, 37)
        Me.LTituloListarClientes.TabIndex = 0
        Me.LTituloListarClientes.Text = "Clientes"
        '
        'BBuscar
        '
        Me.BBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.8!, System.Drawing.FontStyle.Bold)
        Me.BBuscar.Location = New System.Drawing.Point(467, 139)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(107, 57)
        Me.BBuscar.TabIndex = 2
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.8!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(590, 139)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 57)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.8!, System.Drawing.FontStyle.Bold)
        Me.Button3.Location = New System.Drawing.Point(717, 139)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 57)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Imprimir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridViewListarCliente
        '
        Me.DataGridViewListarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewListarCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Colum_Nombre, Me.Colum_Apellido, Me.Colum_DNI, Me.Colum_FechaNaci, Me.Colum_Telefono, Me.Colum_email, Me.Colum_Localidad})
        Me.DataGridViewListarCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewListarCliente.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewListarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewListarCliente.Name = "DataGridViewListarCliente"
        Me.DataGridViewListarCliente.RowHeadersWidth = 51
        Me.DataGridViewListarCliente.Size = New System.Drawing.Size(860, 291)
        Me.DataGridViewListarCliente.TabIndex = 5
        '
        'Colum_Nombre
        '
        Me.Colum_Nombre.HeaderText = "Nombre"
        Me.Colum_Nombre.MinimumWidth = 6
        Me.Colum_Nombre.Name = "Colum_Nombre"
        Me.Colum_Nombre.Width = 125
        '
        'Colum_Apellido
        '
        Me.Colum_Apellido.HeaderText = "Apellido"
        Me.Colum_Apellido.MinimumWidth = 6
        Me.Colum_Apellido.Name = "Colum_Apellido"
        Me.Colum_Apellido.Width = 125
        '
        'Colum_DNI
        '
        Me.Colum_DNI.HeaderText = "DNI"
        Me.Colum_DNI.MinimumWidth = 6
        Me.Colum_DNI.Name = "Colum_DNI"
        Me.Colum_DNI.Width = 125
        '
        'Colum_FechaNaci
        '
        Me.Colum_FechaNaci.HeaderText = "Fecha de Nacimiento"
        Me.Colum_FechaNaci.MinimumWidth = 6
        Me.Colum_FechaNaci.Name = "Colum_FechaNaci"
        Me.Colum_FechaNaci.Width = 125
        '
        'Colum_Telefono
        '
        Me.Colum_Telefono.HeaderText = "Telefono"
        Me.Colum_Telefono.MinimumWidth = 6
        Me.Colum_Telefono.Name = "Colum_Telefono"
        Me.Colum_Telefono.Width = 125
        '
        'Colum_email
        '
        Me.Colum_email.HeaderText = "E-mail"
        Me.Colum_email.MinimumWidth = 6
        Me.Colum_email.Name = "Colum_email"
        Me.Colum_email.Width = 125
        '
        'Colum_Localidad
        '
        Me.Colum_Localidad.HeaderText = "Localidad"
        Me.Colum_Localidad.MinimumWidth = 6
        Me.Colum_Localidad.Name = "Colum_Localidad"
        Me.Colum_Localidad.Width = 125
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGridViewListarCliente)
        Me.Panel1.Location = New System.Drawing.Point(1, 233)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(860, 291)
        Me.Panel1.TabIndex = 6
        '
        'PBListaClientes
        '
        Me.PBListaClientes.BackColor = System.Drawing.Color.White
        Me.PBListaClientes.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.iconlist
        Me.PBListaClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBListaClientes.Location = New System.Drawing.Point(197, 49)
        Me.PBListaClientes.Name = "PBListaClientes"
        Me.PBListaClientes.Size = New System.Drawing.Size(83, 69)
        Me.PBListaClientes.TabIndex = 7
        Me.PBListaClientes.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(293, 157)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(158, 22)
        Me.TextBox1.TabIndex = 8
        '
        'ListarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ClientSize = New System.Drawing.Size(862, 521)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PBListaClientes)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BBuscar)
        Me.Controls.Add(Me.LTituloListarClientes)
        Me.Name = "ListarClientes"
        Me.Text = "ListatClientes"
        CType(Me.DataGridViewListarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PBListaClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LTituloListarClientes As Label
    Friend WithEvents BBuscar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents DataGridViewListarCliente As DataGridView
    Friend WithEvents Colum_Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Colum_Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Colum_DNI As DataGridViewTextBoxColumn
    Friend WithEvents Colum_FechaNaci As DataGridViewTextBoxColumn
    Friend WithEvents Colum_Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Colum_email As DataGridViewTextBoxColumn
    Friend WithEvents Colum_Localidad As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PBListaClientes As PictureBox
    Friend WithEvents TextBox1 As TextBox
End Class
