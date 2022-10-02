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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewListarCliente = New System.Windows.Forms.DataGridView()
        Me.Colum_Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_DNI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Colum_email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBBuscar = New System.Windows.Forms.TextBox()
        Me.ComboBoxBuscarDni = New System.Windows.Forms.ComboBox()
        Me.GroupBoxClientes = New System.Windows.Forms.GroupBox()
        Me.BBuscar = New System.Windows.Forms.Button()
        Me.TabControlListaClientes = New System.Windows.Forms.TabControl()
        Me.TabPafeListaClientes = New System.Windows.Forms.TabPage()
        Me.BEliminarClientes = New System.Windows.Forms.Button()
        Me.BImprimirClientes = New System.Windows.Forms.Button()
        CType(Me.DataGridViewListarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxClientes.SuspendLayout()
        Me.TabControlListaClientes.SuspendLayout()
        Me.TabPafeListaClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridViewListarCliente
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.DataGridViewListarCliente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewListarCliente.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewListarCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewListarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewListarCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Colum_Nombre, Me.Colum_Apellido, Me.Colum_DNI, Me.Colum_Telefono, Me.Colum_Direccion, Me.Colum_email})
        Me.DataGridViewListarCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewListarCliente.Location = New System.Drawing.Point(3, 3)
        Me.DataGridViewListarCliente.Margin = New System.Windows.Forms.Padding(5)
        Me.DataGridViewListarCliente.Name = "DataGridViewListarCliente"
        Me.DataGridViewListarCliente.RowHeadersWidth = 51
        Me.DataGridViewListarCliente.Size = New System.Drawing.Size(982, 363)
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
        'Colum_Telefono
        '
        Me.Colum_Telefono.HeaderText = "Telefono"
        Me.Colum_Telefono.MinimumWidth = 6
        Me.Colum_Telefono.Name = "Colum_Telefono"
        Me.Colum_Telefono.Width = 125
        '
        'Colum_Direccion
        '
        Me.Colum_Direccion.HeaderText = "Direccion"
        Me.Colum_Direccion.MinimumWidth = 6
        Me.Colum_Direccion.Name = "Colum_Direccion"
        Me.Colum_Direccion.Width = 125
        '
        'Colum_email
        '
        Me.Colum_email.HeaderText = "E-mail"
        Me.Colum_email.MinimumWidth = 6
        Me.Colum_email.Name = "Colum_email"
        Me.Colum_email.Width = 125
        '
        'TBBuscar
        '
        Me.TBBuscar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 11.0!)
        Me.TBBuscar.Location = New System.Drawing.Point(610, 59)
        Me.TBBuscar.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.TBBuscar.Name = "TBBuscar"
        Me.TBBuscar.Size = New System.Drawing.Size(290, 29)
        Me.TBBuscar.TabIndex = 8
        '
        'ComboBoxBuscarDni
        '
        Me.ComboBoxBuscarDni.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.ComboBoxBuscarDni.FormattingEnabled = True
        Me.ComboBoxBuscarDni.Location = New System.Drawing.Point(444, 59)
        Me.ComboBoxBuscarDni.Name = "ComboBoxBuscarDni"
        Me.ComboBoxBuscarDni.Size = New System.Drawing.Size(142, 30)
        Me.ComboBoxBuscarDni.TabIndex = 10
        Me.ComboBoxBuscarDni.Text = "DNI"
        '
        'GroupBoxClientes
        '
        Me.GroupBoxClientes.Controls.Add(Me.ComboBoxBuscarDni)
        Me.GroupBoxClientes.Controls.Add(Me.TBBuscar)
        Me.GroupBoxClientes.Controls.Add(Me.BBuscar)
        Me.GroupBoxClientes.Font = New System.Drawing.Font("Britannic Bold", 18.0!)
        Me.GroupBoxClientes.ForeColor = System.Drawing.Color.White
        Me.GroupBoxClientes.Location = New System.Drawing.Point(43, 36)
        Me.GroupBoxClientes.Name = "GroupBoxClientes"
        Me.GroupBoxClientes.Size = New System.Drawing.Size(996, 137)
        Me.GroupBoxClientes.TabIndex = 11
        Me.GroupBoxClientes.TabStop = False
        Me.GroupBoxClientes.Text = "Clientes"
        '
        'BBuscar
        '
        Me.BBuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBuscar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.8!, System.Drawing.FontStyle.Bold)
        Me.BBuscar.ForeColor = System.Drawing.Color.White
        Me.BBuscar.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.search_3_32
        Me.BBuscar.Location = New System.Drawing.Point(909, 49)
        Me.BBuscar.Margin = New System.Windows.Forms.Padding(5)
        Me.BBuscar.Name = "BBuscar"
        Me.BBuscar.Size = New System.Drawing.Size(50, 50)
        Me.BBuscar.TabIndex = 2
        Me.BBuscar.UseVisualStyleBackColor = False
        '
        'TabControlListaClientes
        '
        Me.TabControlListaClientes.Controls.Add(Me.TabPafeListaClientes)
        Me.TabControlListaClientes.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TabControlListaClientes.Location = New System.Drawing.Point(43, 212)
        Me.TabControlListaClientes.Name = "TabControlListaClientes"
        Me.TabControlListaClientes.SelectedIndex = 0
        Me.TabControlListaClientes.Size = New System.Drawing.Size(996, 404)
        Me.TabControlListaClientes.TabIndex = 12
        '
        'TabPafeListaClientes
        '
        Me.TabPafeListaClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.TabPafeListaClientes.Controls.Add(Me.DataGridViewListarCliente)
        Me.TabPafeListaClientes.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TabPafeListaClientes.ForeColor = System.Drawing.Color.White
        Me.TabPafeListaClientes.Location = New System.Drawing.Point(4, 31)
        Me.TabPafeListaClientes.Name = "TabPafeListaClientes"
        Me.TabPafeListaClientes.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPafeListaClientes.Size = New System.Drawing.Size(988, 369)
        Me.TabPafeListaClientes.TabIndex = 0
        Me.TabPafeListaClientes.Text = "Lista de Clientes"
        '
        'BEliminarClientes
        '
        Me.BEliminarClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BEliminarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEliminarClientes.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.8!, System.Drawing.FontStyle.Bold)
        Me.BEliminarClientes.ForeColor = System.Drawing.Color.White
        Me.BEliminarClientes.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.trash_6_32
        Me.BEliminarClientes.Location = New System.Drawing.Point(1062, 396)
        Me.BEliminarClientes.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BEliminarClientes.Name = "BEliminarClientes"
        Me.BEliminarClientes.Size = New System.Drawing.Size(60, 50)
        Me.BEliminarClientes.TabIndex = 3
        Me.BEliminarClientes.UseVisualStyleBackColor = False
        '
        'BImprimirClientes
        '
        Me.BImprimirClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BImprimirClientes.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.impresora
        Me.BImprimirClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BImprimirClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BImprimirClientes.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.8!, System.Drawing.FontStyle.Bold)
        Me.BImprimirClientes.ForeColor = System.Drawing.Color.White
        Me.BImprimirClientes.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.printer_4_32
        Me.BImprimirClientes.Location = New System.Drawing.Point(1062, 317)
        Me.BImprimirClientes.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.BImprimirClientes.Name = "BImprimirClientes"
        Me.BImprimirClientes.Size = New System.Drawing.Size(60, 50)
        Me.BImprimirClientes.TabIndex = 4
        Me.BImprimirClientes.UseVisualStyleBackColor = False
        '
        'ListarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 656)
        Me.Controls.Add(Me.BEliminarClientes)
        Me.Controls.Add(Me.BImprimirClientes)
        Me.Controls.Add(Me.TabControlListaClientes)
        Me.Controls.Add(Me.GroupBoxClientes)
        Me.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.75!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.Name = "ListarClientes"
        Me.Text = "5q2"
        CType(Me.DataGridViewListarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxClientes.ResumeLayout(False)
        Me.GroupBoxClientes.PerformLayout()
        Me.TabControlListaClientes.ResumeLayout(False)
        Me.TabPafeListaClientes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BBuscar As Button
    Friend WithEvents BEliminarClientes As Button
    Friend WithEvents BImprimirClientes As Button
    Friend WithEvents DataGridViewListarCliente As DataGridView
    Friend WithEvents TBBuscar As TextBox
    Friend WithEvents Colum_Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Colum_Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Colum_DNI As DataGridViewTextBoxColumn
    Friend WithEvents Colum_Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Colum_Direccion As DataGridViewTextBoxColumn
    Friend WithEvents Colum_email As DataGridViewTextBoxColumn
    Friend WithEvents ComboBoxBuscarDni As ComboBox
    Friend WithEvents GroupBoxClientes As GroupBox
    Friend WithEvents TabControlListaClientes As TabControl
    Friend WithEvents TabPafeListaClientes As TabPage
End Class
