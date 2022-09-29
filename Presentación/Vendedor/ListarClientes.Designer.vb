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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PBListaClientes = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridViewListarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PBListaClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LTituloListarClientes
        '
        Me.LTituloListarClientes.AutoSize = True
        Me.LTituloListarClientes.Font = New System.Drawing.Font("Britannic Bold", 18.0!)
        Me.LTituloListarClientes.ForeColor = System.Drawing.Color.White
        Me.LTituloListarClientes.Location = New System.Drawing.Point(13, 36)
        Me.LTituloListarClientes.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LTituloListarClientes.Name = "LTituloListarClientes"
        Me.LTituloListarClientes.Size = New System.Drawing.Size(97, 27)
        Me.LTituloListarClientes.TabIndex = 0
        Me.LTituloListarClientes.Text = "Clientes"
        '
        'BBuscar
        '
        Me.BBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.8!, System.Drawing.FontStyle.Bold)
        Me.BBuscar.ForeColor = System.Drawing.Color.White
        Me.BBuscar.Location = New System.Drawing.Point(281, 140)
        Me.BBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(98, 32)
        Me.BBuscar.TabIndex = 2
        Me.BBuscar.Text = "Buscar"
        Me.BBuscar.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.No
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.8!, System.Drawing.FontStyle.Bold)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(396, 140)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 32)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.8!, System.Drawing.FontStyle.Bold)
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(511, 140)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 32)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Imprimir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'DataGridViewListarCliente
        '
        Me.DataGridViewListarCliente.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.DataGridViewListarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridViewListarCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewListarCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewListarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewListarCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Colum_Nombre, Me.Colum_Apellido, Me.Colum_DNI, Me.Colum_FechaNaci, Me.Colum_Telefono, Me.Colum_email, Me.Colum_Localidad})
        Me.DataGridViewListarCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewListarCliente.EnableHeadersVisualStyles = False
        Me.DataGridViewListarCliente.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewListarCliente.Name = "DataGridViewListarCliente"
        Me.DataGridViewListarCliente.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewListarCliente.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewListarCliente.RowHeadersWidth = 51
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        Me.DataGridViewListarCliente.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewListarCliente.Size = New System.Drawing.Size(645, 236)
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
        Me.Panel1.Location = New System.Drawing.Point(1, 189)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(645, 236)
        Me.Panel1.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(73, 147)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 20)
        Me.TextBox1.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(15, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "DNI:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.LTituloListarClientes)
        Me.Panel2.Controls.Add(Me.PBListaClientes)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(646, 100)
        Me.Panel2.TabIndex = 10
        '
        'PBListaClientes
        '
        Me.PBListaClientes.BackColor = System.Drawing.Color.White
        Me.PBListaClientes.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.iconlist
        Me.PBListaClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBListaClientes.Location = New System.Drawing.Point(114, 24)
        Me.PBListaClientes.Margin = New System.Windows.Forms.Padding(2)
        Me.PBListaClientes.Name = "PBListaClientes"
        Me.PBListaClientes.Size = New System.Drawing.Size(40, 39)
        Me.PBListaClientes.TabIndex = 7
        Me.PBListaClientes.TabStop = False
        '
        'ListarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(646, 423)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BBuscar)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ListarClientes"
        Me.Text = "ListaClientes"
        CType(Me.DataGridViewListarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
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
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
End Class
