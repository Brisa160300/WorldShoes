<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AñadirCliente
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TBCorreoCliente = New System.Windows.Forms.TextBox()
        Me.LCorreoCliente = New System.Windows.Forms.Label()
        Me.BRegistrarCliente = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.DateTimeCliente = New System.Windows.Forms.DateTimePicker()
        Me.TBTelCliente = New System.Windows.Forms.TextBox()
        Me.TBLocalidadCliente = New System.Windows.Forms.TextBox()
        Me.TBApellidoCliente = New System.Windows.Forms.TextBox()
        Me.TBDniCliente = New System.Windows.Forms.TextBox()
        Me.TBNombreCliente = New System.Windows.Forms.TextBox()
        Me.LDateBdayCliente = New System.Windows.Forms.Label()
        Me.LApellidoCliente = New System.Windows.Forms.Label()
        Me.LTelCliente = New System.Windows.Forms.Label()
        Me.LLocalidadCliente = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LNombreCliente = New System.Windows.Forms.Label()
        Me.LRegistroCliente = New System.Windows.Forms.Label()
        Me.DataGridViewRegistroCliente = New System.Windows.Forms.DataGridView()
        Me.Colum_Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_DNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_FechaNaci = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_Localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BVolver = New FontAwesome.Sharp.IconButton()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridViewRegistroCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TBCorreoCliente)
        Me.Panel1.Controls.Add(Me.LCorreoCliente)
        Me.Panel1.Controls.Add(Me.BRegistrarCliente)
        Me.Panel1.Controls.Add(Me.BCancelar)
        Me.Panel1.Controls.Add(Me.DateTimeCliente)
        Me.Panel1.Controls.Add(Me.TBTelCliente)
        Me.Panel1.Controls.Add(Me.TBLocalidadCliente)
        Me.Panel1.Controls.Add(Me.TBApellidoCliente)
        Me.Panel1.Controls.Add(Me.TBDniCliente)
        Me.Panel1.Controls.Add(Me.TBNombreCliente)
        Me.Panel1.Controls.Add(Me.LDateBdayCliente)
        Me.Panel1.Controls.Add(Me.LApellidoCliente)
        Me.Panel1.Controls.Add(Me.LTelCliente)
        Me.Panel1.Controls.Add(Me.LLocalidadCliente)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.LNombreCliente)
        Me.Panel1.Location = New System.Drawing.Point(56, 82)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(672, 283)
        Me.Panel1.TabIndex = 0
        '
        'TBCorreoCliente
        '
        Me.TBCorreoCliente.Location = New System.Drawing.Point(384, 130)
        Me.TBCorreoCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBCorreoCliente.Name = "TBCorreoCliente"
        Me.TBCorreoCliente.Size = New System.Drawing.Size(172, 23)
        Me.TBCorreoCliente.TabIndex = 15
        '
        'LCorreoCliente
        '
        Me.LCorreoCliente.AutoSize = True
        Me.LCorreoCliente.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCorreoCliente.ForeColor = System.Drawing.Color.White
        Me.LCorreoCliente.Location = New System.Drawing.Point(325, 134)
        Me.LCorreoCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LCorreoCliente.Name = "LCorreoCliente"
        Me.LCorreoCliente.Size = New System.Drawing.Size(54, 16)
        Me.LCorreoCliente.TabIndex = 14
        Me.LCorreoCliente.Text = "E-mail:"
        '
        'BRegistrarCliente
        '
        Me.BRegistrarCliente.ForeColor = System.Drawing.Color.Black
        Me.BRegistrarCliente.Location = New System.Drawing.Point(505, 219)
        Me.BRegistrarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.BRegistrarCliente.Name = "BRegistrarCliente"
        Me.BRegistrarCliente.Size = New System.Drawing.Size(100, 28)
        Me.BRegistrarCliente.TabIndex = 13
        Me.BRegistrarCliente.Text = "Registrar"
        Me.BRegistrarCliente.UseVisualStyleBackColor = True
        '
        'BCancelar
        '
        Me.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BCancelar.ForeColor = System.Drawing.Color.Black
        Me.BCancelar.Location = New System.Drawing.Point(371, 219)
        Me.BCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(100, 28)
        Me.BCancelar.TabIndex = 12
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'DateTimeCliente
        '
        Me.DateTimeCliente.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeCliente.Location = New System.Drawing.Point(494, 84)
        Me.DateTimeCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimeCliente.Name = "DateTimeCliente"
        Me.DateTimeCliente.Size = New System.Drawing.Size(109, 23)
        Me.DateTimeCliente.TabIndex = 11
        '
        'TBTelCliente
        '
        Me.TBTelCliente.Location = New System.Drawing.Point(133, 130)
        Me.TBTelCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBTelCliente.Name = "TBTelCliente"
        Me.TBTelCliente.Size = New System.Drawing.Size(132, 23)
        Me.TBTelCliente.TabIndex = 10
        '
        'TBLocalidadCliente
        '
        Me.TBLocalidadCliente.Location = New System.Drawing.Point(133, 178)
        Me.TBLocalidadCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBLocalidadCliente.Name = "TBLocalidadCliente"
        Me.TBLocalidadCliente.Size = New System.Drawing.Size(132, 23)
        Me.TBLocalidadCliente.TabIndex = 9
        '
        'TBApellidoCliente
        '
        Me.TBApellidoCliente.Location = New System.Drawing.Point(425, 34)
        Me.TBApellidoCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBApellidoCliente.Name = "TBApellidoCliente"
        Me.TBApellidoCliente.Size = New System.Drawing.Size(178, 23)
        Me.TBApellidoCliente.TabIndex = 8
        '
        'TBDniCliente
        '
        Me.TBDniCliente.Location = New System.Drawing.Point(133, 84)
        Me.TBDniCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBDniCliente.Name = "TBDniCliente"
        Me.TBDniCliente.Size = New System.Drawing.Size(132, 23)
        Me.TBDniCliente.TabIndex = 7
        '
        'TBNombreCliente
        '
        Me.TBNombreCliente.Location = New System.Drawing.Point(133, 34)
        Me.TBNombreCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBNombreCliente.Name = "TBNombreCliente"
        Me.TBNombreCliente.Size = New System.Drawing.Size(168, 23)
        Me.TBNombreCliente.TabIndex = 6
        '
        'LDateBdayCliente
        '
        Me.LDateBdayCliente.AutoSize = True
        Me.LDateBdayCliente.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDateBdayCliente.ForeColor = System.Drawing.Color.White
        Me.LDateBdayCliente.Location = New System.Drawing.Point(325, 87)
        Me.LDateBdayCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LDateBdayCliente.Name = "LDateBdayCliente"
        Me.LDateBdayCliente.Size = New System.Drawing.Size(151, 16)
        Me.LDateBdayCliente.TabIndex = 5
        Me.LDateBdayCliente.Text = "Fecha de nacimiento:"
        '
        'LApellidoCliente
        '
        Me.LApellidoCliente.AutoSize = True
        Me.LApellidoCliente.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApellidoCliente.ForeColor = System.Drawing.Color.White
        Me.LApellidoCliente.Location = New System.Drawing.Point(325, 38)
        Me.LApellidoCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LApellidoCliente.Name = "LApellidoCliente"
        Me.LApellidoCliente.Size = New System.Drawing.Size(64, 16)
        Me.LApellidoCliente.TabIndex = 4
        Me.LApellidoCliente.Text = "Apellido:"
        '
        'LTelCliente
        '
        Me.LTelCliente.AutoSize = True
        Me.LTelCliente.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTelCliente.ForeColor = System.Drawing.Color.White
        Me.LTelCliente.Location = New System.Drawing.Point(36, 134)
        Me.LTelCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LTelCliente.Name = "LTelCliente"
        Me.LTelCliente.Size = New System.Drawing.Size(71, 16)
        Me.LTelCliente.TabIndex = 3
        Me.LTelCliente.Text = "Telefono:"
        '
        'LLocalidadCliente
        '
        Me.LLocalidadCliente.AutoSize = True
        Me.LLocalidadCliente.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLocalidadCliente.ForeColor = System.Drawing.Color.White
        Me.LLocalidadCliente.Location = New System.Drawing.Point(36, 181)
        Me.LLocalidadCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LLocalidadCliente.Name = "LLocalidadCliente"
        Me.LLocalidadCliente.Size = New System.Drawing.Size(75, 16)
        Me.LLocalidadCliente.TabIndex = 2
        Me.LLocalidadCliente.Text = "Localidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(36, 87)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "DNI:"
        '
        'LNombreCliente
        '
        Me.LNombreCliente.AutoSize = True
        Me.LNombreCliente.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNombreCliente.ForeColor = System.Drawing.Color.White
        Me.LNombreCliente.Location = New System.Drawing.Point(36, 38)
        Me.LNombreCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LNombreCliente.Name = "LNombreCliente"
        Me.LNombreCliente.Size = New System.Drawing.Size(63, 16)
        Me.LNombreCliente.TabIndex = 0
        Me.LNombreCliente.Text = "Nombre:"
        '
        'LRegistroCliente
        '
        Me.LRegistroCliente.AutoSize = True
        Me.LRegistroCliente.BackColor = System.Drawing.Color.Transparent
        Me.LRegistroCliente.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRegistroCliente.ForeColor = System.Drawing.Color.Black
        Me.LRegistroCliente.Location = New System.Drawing.Point(51, 39)
        Me.LRegistroCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LRegistroCliente.Name = "LRegistroCliente"
        Me.LRegistroCliente.Size = New System.Drawing.Size(171, 22)
        Me.LRegistroCliente.TabIndex = 1
        Me.LRegistroCliente.Text = "Registrar Cliente:"
        '
        'DataGridViewRegistroCliente
        '
        Me.DataGridViewRegistroCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewRegistroCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Colum_Nombre, Me.Colum_Apellido, Me.Colum_DNI, Me.Colum_FechaNaci, Me.Colum_Telefono, Me.Colum_email, Me.Colum_Localidad})
        Me.DataGridViewRegistroCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewRegistroCliente.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewRegistroCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewRegistroCliente.Name = "DataGridViewRegistroCliente"
        Me.DataGridViewRegistroCliente.Size = New System.Drawing.Size(805, 144)
        Me.DataGridViewRegistroCliente.TabIndex = 2
        '
        'Colum_Nombre
        '
        Me.Colum_Nombre.HeaderText = "Nombre"
        Me.Colum_Nombre.Name = "Colum_Nombre"
        '
        'Colum_Apellido
        '
        Me.Colum_Apellido.HeaderText = "Apellido"
        Me.Colum_Apellido.Name = "Colum_Apellido"
        '
        'Colum_DNI
        '
        Me.Colum_DNI.HeaderText = "DNI"
        Me.Colum_DNI.Name = "Colum_DNI"
        '
        'Colum_FechaNaci
        '
        Me.Colum_FechaNaci.HeaderText = "Fecha de Nacimiento"
        Me.Colum_FechaNaci.Name = "Colum_FechaNaci"
        '
        'Colum_Telefono
        '
        Me.Colum_Telefono.HeaderText = "Telefono"
        Me.Colum_Telefono.Name = "Colum_Telefono"
        '
        'Colum_email
        '
        Me.Colum_email.HeaderText = "E-mail"
        Me.Colum_email.Name = "Colum_email"
        '
        'Colum_Localidad
        '
        Me.Colum_Localidad.HeaderText = "Localidad"
        Me.Colum_Localidad.Name = "Colum_Localidad"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridViewRegistroCliente)
        Me.Panel2.Location = New System.Drawing.Point(3, 389)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(805, 144)
        Me.Panel2.TabIndex = 3
        '
        'BVolver
        '
        Me.BVolver.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_atrás_50
        Me.BVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BVolver.IconChar = FontAwesome.Sharp.IconChar.None
        Me.BVolver.IconColor = System.Drawing.Color.Black
        Me.BVolver.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.BVolver.IconSize = 30
        Me.BVolver.Location = New System.Drawing.Point(3, 1)
        Me.BVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(34, 30)
        Me.BVolver.TabIndex = 4
        Me.BVolver.UseVisualStyleBackColor = True
        '
        'AñadirCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(807, 521)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LRegistroCliente)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AñadirCliente"
        Me.Text = "AñadirCliente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridViewRegistroCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DateTimeCliente As DateTimePicker
    Friend WithEvents TBTelCliente As TextBox
    Friend WithEvents TBLocalidadCliente As TextBox
    Friend WithEvents TBApellidoCliente As TextBox
    Friend WithEvents TBDniCliente As TextBox
    Friend WithEvents TBNombreCliente As TextBox
    Friend WithEvents LDateBdayCliente As Label
    Friend WithEvents LApellidoCliente As Label
    Friend WithEvents LTelCliente As Label
    Friend WithEvents LLocalidadCliente As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LNombreCliente As Label
    Friend WithEvents LRegistroCliente As Label
    Friend WithEvents TBCorreoCliente As TextBox
    Friend WithEvents LCorreoCliente As Label
    Friend WithEvents BRegistrarCliente As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents DataGridViewRegistroCliente As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Colum_Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Colum_Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Colum_DNI As DataGridViewTextBoxColumn
    Friend WithEvents Colum_FechaNaci As DataGridViewTextBoxColumn
    Friend WithEvents Colum_Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Colum_email As DataGridViewTextBoxColumn
    Friend WithEvents Colum_Localidad As DataGridViewTextBoxColumn
    Friend WithEvents BVolver As FontAwesome.Sharp.IconButton
End Class
