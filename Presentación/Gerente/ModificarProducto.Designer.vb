<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarProducto
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
        Me.BCancelarModifCliente = New System.Windows.Forms.Button()
        Me.BModificarProducto = New System.Windows.Forms.Button()
        Me.GroupBoxDatosCliente = New System.Windows.Forms.GroupBox()
        Me.TBStockProducto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CBTalleProducto = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TBPrecioProducto = New System.Windows.Forms.TextBox()
        Me.TBNombreProducto = New System.Windows.Forms.TextBox()
        Me.LMarca = New System.Windows.Forms.Label()
        Me.CBMarcaProducto = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBCategoriaProducto = New System.Windows.Forms.ComboBox()
        Me.PanelModClientes.SuspendLayout()
        Me.GroupBoxDatosCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelModClientes
        '
        Me.PanelModClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PanelModClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelModClientes.Controls.Add(Me.BCancelarModifCliente)
        Me.PanelModClientes.Controls.Add(Me.BModificarProducto)
        Me.PanelModClientes.Controls.Add(Me.GroupBoxDatosCliente)
        Me.PanelModClientes.Location = New System.Drawing.Point(55, 38)
        Me.PanelModClientes.Margin = New System.Windows.Forms.Padding(5)
        Me.PanelModClientes.Name = "PanelModClientes"
        Me.PanelModClientes.Size = New System.Drawing.Size(678, 450)
        Me.PanelModClientes.TabIndex = 2
        '
        'BCancelarModifCliente
        '
        Me.BCancelarModifCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BCancelarModifCliente.FlatAppearance.BorderSize = 2
        Me.BCancelarModifCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelarModifCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BCancelarModifCliente.ForeColor = System.Drawing.Color.White
        Me.BCancelarModifCliente.Location = New System.Drawing.Point(515, 370)
        Me.BCancelarModifCliente.Margin = New System.Windows.Forms.Padding(5)
        Me.BCancelarModifCliente.Name = "BCancelarModifCliente"
        Me.BCancelarModifCliente.Size = New System.Drawing.Size(130, 52)
        Me.BCancelarModifCliente.TabIndex = 14
        Me.BCancelarModifCliente.Text = "Cancelar"
        Me.BCancelarModifCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelarModifCliente.UseVisualStyleBackColor = False
        '
        'BModificarProducto
        '
        Me.BModificarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BModificarProducto.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BModificarProducto.FlatAppearance.BorderSize = 2
        Me.BModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModificarProducto.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BModificarProducto.ForeColor = System.Drawing.Color.White
        Me.BModificarProducto.Location = New System.Drawing.Point(375, 370)
        Me.BModificarProducto.Margin = New System.Windows.Forms.Padding(5)
        Me.BModificarProducto.Name = "BModificarProducto"
        Me.BModificarProducto.Size = New System.Drawing.Size(130, 52)
        Me.BModificarProducto.TabIndex = 15
        Me.BModificarProducto.Text = "Modificar"
        Me.BModificarProducto.UseVisualStyleBackColor = False
        '
        'GroupBoxDatosCliente
        '
        Me.GroupBoxDatosCliente.Controls.Add(Me.TBStockProducto)
        Me.GroupBoxDatosCliente.Controls.Add(Me.Label4)
        Me.GroupBoxDatosCliente.Controls.Add(Me.CBTalleProducto)
        Me.GroupBoxDatosCliente.Controls.Add(Me.Label5)
        Me.GroupBoxDatosCliente.Controls.Add(Me.Label6)
        Me.GroupBoxDatosCliente.Controls.Add(Me.TBPrecioProducto)
        Me.GroupBoxDatosCliente.Controls.Add(Me.TBNombreProducto)
        Me.GroupBoxDatosCliente.Controls.Add(Me.LMarca)
        Me.GroupBoxDatosCliente.Controls.Add(Me.CBMarcaProducto)
        Me.GroupBoxDatosCliente.Controls.Add(Me.Label3)
        Me.GroupBoxDatosCliente.Controls.Add(Me.Label2)
        Me.GroupBoxDatosCliente.Controls.Add(Me.CBCategoriaProducto)
        Me.GroupBoxDatosCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.GroupBoxDatosCliente.ForeColor = System.Drawing.Color.White
        Me.GroupBoxDatosCliente.Location = New System.Drawing.Point(45, 28)
        Me.GroupBoxDatosCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxDatosCliente.Name = "GroupBoxDatosCliente"
        Me.GroupBoxDatosCliente.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxDatosCliente.Size = New System.Drawing.Size(600, 313)
        Me.GroupBoxDatosCliente.TabIndex = 19
        Me.GroupBoxDatosCliente.TabStop = False
        Me.GroupBoxDatosCliente.Text = "Modificar Producto"
        '
        'TBStockProducto
        '
        Me.TBStockProducto.Location = New System.Drawing.Point(330, 221)
        Me.TBStockProducto.Margin = New System.Windows.Forms.Padding(5)
        Me.TBStockProducto.Name = "TBStockProducto"
        Me.TBStockProducto.Size = New System.Drawing.Size(213, 30)
        Me.TBStockProducto.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(326, 195)
        Me.Label4.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 22)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Stock:"
        '
        'CBTalleProducto
        '
        Me.CBTalleProducto.FormattingEnabled = True
        Me.CBTalleProducto.Items.AddRange(New Object() {"DNI", "OTRO"})
        Me.CBTalleProducto.Location = New System.Drawing.Point(330, 91)
        Me.CBTalleProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.CBTalleProducto.Name = "CBTalleProducto"
        Me.CBTalleProducto.Size = New System.Drawing.Size(213, 30)
        Me.CBTalleProducto.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(326, 130)
        Me.Label5.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 22)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Precio: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(326, 63)
        Me.Label6.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 22)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Talle: "
        '
        'TBPrecioProducto
        '
        Me.TBPrecioProducto.Location = New System.Drawing.Point(330, 155)
        Me.TBPrecioProducto.Margin = New System.Windows.Forms.Padding(5)
        Me.TBPrecioProducto.Name = "TBPrecioProducto"
        Me.TBPrecioProducto.Size = New System.Drawing.Size(213, 30)
        Me.TBPrecioProducto.TabIndex = 15
        '
        'TBNombreProducto
        '
        Me.TBNombreProducto.Location = New System.Drawing.Point(72, 219)
        Me.TBNombreProducto.Margin = New System.Windows.Forms.Padding(5)
        Me.TBNombreProducto.Name = "TBNombreProducto"
        Me.TBNombreProducto.Size = New System.Drawing.Size(213, 30)
        Me.TBNombreProducto.TabIndex = 8
        '
        'LMarca
        '
        Me.LMarca.AutoSize = True
        Me.LMarca.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LMarca.ForeColor = System.Drawing.Color.White
        Me.LMarca.Location = New System.Drawing.Point(68, 131)
        Me.LMarca.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.LMarca.Name = "LMarca"
        Me.LMarca.Size = New System.Drawing.Size(78, 22)
        Me.LMarca.TabIndex = 20
        Me.LMarca.Text = "Marca: "
        '
        'CBMarcaProducto
        '
        Me.CBMarcaProducto.FormattingEnabled = True
        Me.CBMarcaProducto.Items.AddRange(New Object() {"DNI", "OTRO"})
        Me.CBMarcaProducto.Location = New System.Drawing.Point(69, 155)
        Me.CBMarcaProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.CBMarcaProducto.Name = "CBMarcaProducto"
        Me.CBMarcaProducto.Size = New System.Drawing.Size(213, 30)
        Me.CBMarcaProducto.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(65, 63)
        Me.Label3.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 22)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Categoría: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(69, 191)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 22)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nombre:"
        '
        'CBCategoriaProducto
        '
        Me.CBCategoriaProducto.FormattingEnabled = True
        Me.CBCategoriaProducto.Items.AddRange(New Object() {"DNI", "OTRO"})
        Me.CBCategoriaProducto.Location = New System.Drawing.Point(69, 91)
        Me.CBCategoriaProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.CBCategoriaProducto.Name = "CBCategoriaProducto"
        Me.CBCategoriaProducto.Size = New System.Drawing.Size(213, 30)
        Me.CBCategoriaProducto.TabIndex = 18
        '
        'ModificarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(781, 525)
        Me.Controls.Add(Me.PanelModClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ModificarProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModificarProducto"
        Me.PanelModClientes.ResumeLayout(False)
        Me.GroupBoxDatosCliente.ResumeLayout(False)
        Me.GroupBoxDatosCliente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelModClientes As Panel
    Friend WithEvents TBStockProducto As TextBox
    Friend WithEvents TBPrecioProducto As TextBox
    Friend WithEvents GroupBoxDatosCliente As GroupBox
    Friend WithEvents TBNombreProducto As TextBox
    Friend WithEvents CBCategoriaProducto As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CBTalleProducto As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LMarca As Label
    Friend WithEvents CBMarcaProducto As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BCancelarModifCliente As Button
    Friend WithEvents BModificarProducto As Button
End Class
