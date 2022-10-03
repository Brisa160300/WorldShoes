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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.PanelRegClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
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
        Me.PanelRegClientes.Location = New System.Drawing.Point(47, 112)
        Me.PanelRegClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelRegClientes.Name = "PanelRegClientes"
        Me.PanelRegClientes.Size = New System.Drawing.Size(436, 499)
        Me.PanelRegClientes.TabIndex = 0
        '
        'TBDireccion
        '
        Me.TBDireccion.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBDireccion.Location = New System.Drawing.Point(180, 299)
        Me.TBDireccion.Margin = New System.Windows.Forms.Padding(4)
        Me.TBDireccion.Name = "TBDireccion"
        Me.TBDireccion.Size = New System.Drawing.Size(161, 32)
        Me.TBDireccion.TabIndex = 17
        '
        'LDireccion
        '
        Me.LDireccion.AutoSize = True
        Me.LDireccion.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LDireccion.ForeColor = System.Drawing.Color.White
        Me.LDireccion.Location = New System.Drawing.Point(43, 302)
        Me.LDireccion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LDireccion.Name = "LDireccion"
        Me.LDireccion.Size = New System.Drawing.Size(110, 25)
        Me.LDireccion.TabIndex = 16
        Me.LDireccion.Text = "Direccion:"
        '
        'TBCorreoCliente
        '
        Me.TBCorreoCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBCorreoCliente.Location = New System.Drawing.Point(180, 345)
        Me.TBCorreoCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBCorreoCliente.Name = "TBCorreoCliente"
        Me.TBCorreoCliente.Size = New System.Drawing.Size(161, 32)
        Me.TBCorreoCliente.TabIndex = 15
        '
        'LCorreoCliente
        '
        Me.LCorreoCliente.AutoSize = True
        Me.LCorreoCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LCorreoCliente.ForeColor = System.Drawing.Color.White
        Me.LCorreoCliente.Location = New System.Drawing.Point(46, 348)
        Me.LCorreoCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LCorreoCliente.Name = "LCorreoCliente"
        Me.LCorreoCliente.Size = New System.Drawing.Size(78, 25)
        Me.LCorreoCliente.TabIndex = 14
        Me.LCorreoCliente.Text = "E-mail:"
        '
        'BRegistrarCliente
        '
        Me.BRegistrarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BRegistrarCliente.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BRegistrarCliente.FlatAppearance.BorderSize = 2
        Me.BRegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRegistrarCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BRegistrarCliente.ForeColor = System.Drawing.Color.White
        Me.BRegistrarCliente.Location = New System.Drawing.Point(180, 432)
        Me.BRegistrarCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.BRegistrarCliente.Name = "BRegistrarCliente"
        Me.BRegistrarCliente.Size = New System.Drawing.Size(112, 41)
        Me.BRegistrarCliente.TabIndex = 13
        Me.BRegistrarCliente.Text = "Registrar"
        Me.BRegistrarCliente.UseVisualStyleBackColor = False
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BCancelar.FlatAppearance.BorderSize = 2
        Me.BCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelar.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BCancelar.ForeColor = System.Drawing.Color.White
        Me.BCancelar.Location = New System.Drawing.Point(300, 432)
        Me.BCancelar.Margin = New System.Windows.Forms.Padding(4)
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
        Me.TBTelCliente.Location = New System.Drawing.Point(180, 250)
        Me.TBTelCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBTelCliente.Name = "TBTelCliente"
        Me.TBTelCliente.Size = New System.Drawing.Size(161, 32)
        Me.TBTelCliente.TabIndex = 10
        '
        'TBApellidoCliente
        '
        Me.TBApellidoCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBApellidoCliente.Location = New System.Drawing.Point(180, 157)
        Me.TBApellidoCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBApellidoCliente.Name = "TBApellidoCliente"
        Me.TBApellidoCliente.Size = New System.Drawing.Size(161, 32)
        Me.TBApellidoCliente.TabIndex = 8
        '
        'TBDniCliente
        '
        Me.TBDniCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBDniCliente.Location = New System.Drawing.Point(180, 204)
        Me.TBDniCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBDniCliente.Name = "TBDniCliente"
        Me.TBDniCliente.Size = New System.Drawing.Size(161, 32)
        Me.TBDniCliente.TabIndex = 7
        '
        'TBNombreCliente
        '
        Me.TBNombreCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBNombreCliente.Location = New System.Drawing.Point(180, 109)
        Me.TBNombreCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBNombreCliente.Name = "TBNombreCliente"
        Me.TBNombreCliente.Size = New System.Drawing.Size(161, 32)
        Me.TBNombreCliente.TabIndex = 6
        '
        'LApellidoCliente
        '
        Me.LApellidoCliente.AutoSize = True
        Me.LApellidoCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LApellidoCliente.ForeColor = System.Drawing.Color.White
        Me.LApellidoCliente.Location = New System.Drawing.Point(43, 160)
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
        Me.LTelCliente.Location = New System.Drawing.Point(43, 253)
        Me.LTelCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LTelCliente.Name = "LTelCliente"
        Me.LTelCliente.Size = New System.Drawing.Size(100, 25)
        Me.LTelCliente.TabIndex = 3
        Me.LTelCliente.Text = "Telefono:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(46, 207)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "DNI:"
        '
        'LNombreCliente
        '
        Me.LNombreCliente.AutoSize = True
        Me.LNombreCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LNombreCliente.ForeColor = System.Drawing.Color.White
        Me.LNombreCliente.Location = New System.Drawing.Point(43, 112)
        Me.LNombreCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LNombreCliente.Name = "LNombreCliente"
        Me.LNombreCliente.Size = New System.Drawing.Size(93, 25)
        Me.LNombreCliente.TabIndex = 0
        Me.LNombreCliente.Text = "Nombre:"
        '
        'LRegistroCliente
        '
        Me.LRegistroCliente.AutoSize = True
        Me.LRegistroCliente.BackColor = System.Drawing.Color.Transparent
        Me.LRegistroCliente.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LRegistroCliente.ForeColor = System.Drawing.Color.Transparent
        Me.LRegistroCliente.Location = New System.Drawing.Point(41, 56)
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
        Me.TabPageListaClientes.Size = New System.Drawing.Size(574, 467)
        Me.TabPageListaClientes.TabIndex = 0
        Me.TabPageListaClientes.Text = "Lista de Clientes"
        Me.TabPageListaClientes.UseVisualStyleBackColor = True
        '
        'DataGridViewRegistroClientes
        '
        Me.DataGridViewRegistroClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewRegistroClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewRegistroClientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.DataGridViewRegistroClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewRegistroClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewRegistroClientes.ColumnHeadersHeight = 20
        Me.DataGridViewRegistroClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewRegistroClientes.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewRegistroClientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewRegistroClientes.EnableHeadersVisualStyles = False
        Me.DataGridViewRegistroClientes.Location = New System.Drawing.Point(3, 3)
        Me.DataGridViewRegistroClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewRegistroClientes.Name = "DataGridViewRegistroClientes"
        Me.DataGridViewRegistroClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewRegistroClientes.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewRegistroClientes.RowHeadersWidth = 51
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewRegistroClientes.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewRegistroClientes.Size = New System.Drawing.Size(568, 461)
        Me.DataGridViewRegistroClientes.TabIndex = 2
        '
        'TabControlRegClientes
        '
        Me.TabControlRegClientes.Controls.Add(Me.TabPageListaClientes)
        Me.TabControlRegClientes.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlRegClientes.Location = New System.Drawing.Point(517, 112)
        Me.TabControlRegClientes.Name = "TabControlRegClientes"
        Me.TabControlRegClientes.SelectedIndex = 0
        Me.TabControlRegClientes.Size = New System.Drawing.Size(582, 499)
        Me.TabControlRegClientes.TabIndex = 4
        '
        'AñadirCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 656)
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
