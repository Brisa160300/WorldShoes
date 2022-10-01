<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarCliente
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabListaClientes = New System.Windows.Forms.TabControl()
        Me.TabPageListaTalle = New System.Windows.Forms.TabPage()
        Me.DataGridViewRegistroTalle = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBoxGestionClientes = New System.Windows.Forms.GroupBox()
        Me.BEliminarCliente = New System.Windows.Forms.Button()
        Me.BModificarCliente = New System.Windows.Forms.Button()
        Me.BBuscarCliente = New System.Windows.Forms.Button()
        Me.TBGestionClientes = New System.Windows.Forms.TextBox()
        Me.TabListaClientes.SuspendLayout()
        Me.TabPageListaTalle.SuspendLayout()
        CType(Me.DataGridViewRegistroTalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBoxGestionClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabListaClientes
        '
        Me.TabListaClientes.Controls.Add(Me.TabPageListaTalle)
        Me.TabListaClientes.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabListaClientes.Location = New System.Drawing.Point(14, 141)
        Me.TabListaClientes.Margin = New System.Windows.Forms.Padding(2)
        Me.TabListaClientes.Name = "TabListaClientes"
        Me.TabListaClientes.SelectedIndex = 0
        Me.TabListaClientes.Size = New System.Drawing.Size(772, 296)
        Me.TabListaClientes.TabIndex = 22
        '
        'TabPageListaTalle
        '
        Me.TabPageListaTalle.Controls.Add(Me.DataGridViewRegistroTalle)
        Me.TabPageListaTalle.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaTalle.ForeColor = System.Drawing.Color.White
        Me.TabPageListaTalle.Location = New System.Drawing.Point(4, 25)
        Me.TabPageListaTalle.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPageListaTalle.Name = "TabPageListaTalle"
        Me.TabPageListaTalle.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPageListaTalle.Size = New System.Drawing.Size(764, 267)
        Me.TabPageListaTalle.TabIndex = 0
        Me.TabPageListaTalle.Text = "Lista de Clientes"
        Me.TabPageListaTalle.UseVisualStyleBackColor = True
        '
        'DataGridViewRegistroTalle
        '
        Me.DataGridViewRegistroTalle.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.DataGridViewRegistroTalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewRegistroTalle.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewRegistroTalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewRegistroTalle.Location = New System.Drawing.Point(2, 2)
        Me.DataGridViewRegistroTalle.Name = "DataGridViewRegistroTalle"
        Me.DataGridViewRegistroTalle.RowHeadersWidth = 51
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewRegistroTalle.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewRegistroTalle.Size = New System.Drawing.Size(760, 263)
        Me.DataGridViewRegistroTalle.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBoxGestionClientes)
        Me.Panel1.Location = New System.Drawing.Point(14, 14)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(772, 111)
        Me.Panel1.TabIndex = 21
        '
        'GroupBoxGestionClientes
        '
        Me.GroupBoxGestionClientes.Controls.Add(Me.BEliminarCliente)
        Me.GroupBoxGestionClientes.Controls.Add(Me.BModificarCliente)
        Me.GroupBoxGestionClientes.Controls.Add(Me.BBuscarCliente)
        Me.GroupBoxGestionClientes.Controls.Add(Me.TBGestionClientes)
        Me.GroupBoxGestionClientes.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.GroupBoxGestionClientes.ForeColor = System.Drawing.Color.White
        Me.GroupBoxGestionClientes.Location = New System.Drawing.Point(6, 15)
        Me.GroupBoxGestionClientes.Name = "GroupBoxGestionClientes"
        Me.GroupBoxGestionClientes.Size = New System.Drawing.Size(747, 81)
        Me.GroupBoxGestionClientes.TabIndex = 16
        Me.GroupBoxGestionClientes.TabStop = False
        Me.GroupBoxGestionClientes.Text = "Gestión de Clientes"
        '
        'BEliminarCliente
        '
        Me.BEliminarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BEliminarCliente.FlatAppearance.BorderSize = 2
        Me.BEliminarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEliminarCliente.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminarCliente.ForeColor = System.Drawing.Color.White
        Me.BEliminarCliente.Location = New System.Drawing.Point(644, 34)
        Me.BEliminarCliente.Name = "BEliminarCliente"
        Me.BEliminarCliente.Size = New System.Drawing.Size(80, 26)
        Me.BEliminarCliente.TabIndex = 12
        Me.BEliminarCliente.Text = "Eliminar"
        Me.BEliminarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BEliminarCliente.UseVisualStyleBackColor = False
        '
        'BModificarCliente
        '
        Me.BModificarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BModificarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BModificarCliente.FlatAppearance.BorderSize = 2
        Me.BModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModificarCliente.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BModificarCliente.ForeColor = System.Drawing.Color.White
        Me.BModificarCliente.Location = New System.Drawing.Point(550, 34)
        Me.BModificarCliente.Name = "BModificarCliente"
        Me.BModificarCliente.Size = New System.Drawing.Size(79, 26)
        Me.BModificarCliente.TabIndex = 13
        Me.BModificarCliente.Text = "Modificar"
        Me.BModificarCliente.UseVisualStyleBackColor = False
        '
        'BBuscarCliente
        '
        Me.BBuscarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BBuscarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BBuscarCliente.FlatAppearance.BorderSize = 2
        Me.BBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBuscarCliente.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscarCliente.ForeColor = System.Drawing.Color.White
        Me.BBuscarCliente.Location = New System.Drawing.Point(157, 34)
        Me.BBuscarCliente.Name = "BBuscarCliente"
        Me.BBuscarCliente.Size = New System.Drawing.Size(72, 26)
        Me.BBuscarCliente.TabIndex = 14
        Me.BBuscarCliente.Text = "Buscar"
        Me.BBuscarCliente.UseVisualStyleBackColor = False
        '
        'TBGestionClientes
        '
        Me.TBGestionClientes.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBGestionClientes.Location = New System.Drawing.Point(20, 35)
        Me.TBGestionClientes.Name = "TBGestionClientes"
        Me.TBGestionClientes.Size = New System.Drawing.Size(131, 25)
        Me.TBGestionClientes.TabIndex = 6
        '
        'GestionarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabListaClientes)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "GestionarCliente"
        Me.Text = "GestionarCliente"
        Me.TabListaClientes.ResumeLayout(False)
        Me.TabPageListaTalle.ResumeLayout(False)
        CType(Me.DataGridViewRegistroTalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBoxGestionClientes.ResumeLayout(False)
        Me.GroupBoxGestionClientes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabListaClientes As TabControl
    Friend WithEvents TabPageListaTalle As TabPage
    Friend WithEvents DataGridViewRegistroTalle As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBoxGestionClientes As GroupBox
    Friend WithEvents BEliminarCliente As Button
    Friend WithEvents BModificarCliente As Button
    Friend WithEvents BBuscarCliente As Button
    Friend WithEvents TBGestionClientes As TextBox
End Class
