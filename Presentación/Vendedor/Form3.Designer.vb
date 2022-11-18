<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.TBVendedor = New System.Windows.Forms.TextBox()
        Me.LVendedor = New System.Windows.Forms.Label()
        Me.LApellido = New System.Windows.Forms.Label()
        Me.TBApellido = New System.Windows.Forms.TextBox()
        Me.TBNombreCliVenta = New System.Windows.Forms.TextBox()
        Me.LNombreCli = New System.Windows.Forms.Label()
        Me.TBTotalVenta = New System.Windows.Forms.TextBox()
        Me.LTotalVenta = New System.Windows.Forms.Label()
        Me.LNumeroFactura = New System.Windows.Forms.Label()
        Me.TBNroFactura = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TBVendedor
        '
        Me.TBVendedor.Enabled = False
        Me.TBVendedor.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.TBVendedor.Location = New System.Drawing.Point(724, 72)
        Me.TBVendedor.Margin = New System.Windows.Forms.Padding(5)
        Me.TBVendedor.Name = "TBVendedor"
        Me.TBVendedor.Size = New System.Drawing.Size(131, 26)
        Me.TBVendedor.TabIndex = 62
        '
        'LVendedor
        '
        Me.LVendedor.AutoSize = True
        Me.LVendedor.BackColor = System.Drawing.Color.Transparent
        Me.LVendedor.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.LVendedor.ForeColor = System.Drawing.Color.White
        Me.LVendedor.Location = New System.Drawing.Point(627, 75)
        Me.LVendedor.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LVendedor.Name = "LVendedor"
        Me.LVendedor.Size = New System.Drawing.Size(83, 19)
        Me.LVendedor.TabIndex = 64
        Me.LVendedor.Text = "Vendedor:"
        '
        'LApellido
        '
        Me.LApellido.AutoSize = True
        Me.LApellido.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.LApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LApellido.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.LApellido.ForeColor = System.Drawing.Color.White
        Me.LApellido.Location = New System.Drawing.Point(422, 48)
        Me.LApellido.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LApellido.Name = "LApellido"
        Me.LApellido.Size = New System.Drawing.Size(68, 19)
        Me.LApellido.TabIndex = 58
        Me.LApellido.Text = "Apellido"
        '
        'TBApellido
        '
        Me.TBApellido.Location = New System.Drawing.Point(426, 72)
        Me.TBApellido.Margin = New System.Windows.Forms.Padding(5)
        Me.TBApellido.Name = "TBApellido"
        Me.TBApellido.Size = New System.Drawing.Size(133, 22)
        Me.TBApellido.TabIndex = 57
        '
        'TBNombreCliVenta
        '
        Me.TBNombreCliVenta.Location = New System.Drawing.Point(271, 89)
        Me.TBNombreCliVenta.Margin = New System.Windows.Forms.Padding(5)
        Me.TBNombreCliVenta.Name = "TBNombreCliVenta"
        Me.TBNombreCliVenta.Size = New System.Drawing.Size(133, 22)
        Me.TBNombreCliVenta.TabIndex = 55
        '
        'LNombreCli
        '
        Me.LNombreCli.AutoSize = True
        Me.LNombreCli.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.LNombreCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LNombreCli.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.LNombreCli.ForeColor = System.Drawing.Color.White
        Me.LNombreCli.Location = New System.Drawing.Point(295, 48)
        Me.LNombreCli.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LNombreCli.Name = "LNombreCli"
        Me.LNombreCli.Size = New System.Drawing.Size(66, 19)
        Me.LNombreCli.TabIndex = 56
        Me.LNombreCli.Text = "Nombre"
        '
        'TBTotalVenta
        '
        Me.TBTotalVenta.Enabled = False
        Me.TBTotalVenta.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBTotalVenta.Location = New System.Drawing.Point(178, 770)
        Me.TBTotalVenta.Margin = New System.Windows.Forms.Padding(5)
        Me.TBTotalVenta.Name = "TBTotalVenta"
        Me.TBTotalVenta.Size = New System.Drawing.Size(100, 30)
        Me.TBTotalVenta.TabIndex = 63
        '
        'LTotalVenta
        '
        Me.LTotalVenta.AutoSize = True
        Me.LTotalVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LTotalVenta.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LTotalVenta.ForeColor = System.Drawing.Color.White
        Me.LTotalVenta.Location = New System.Drawing.Point(86, 773)
        Me.LTotalVenta.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LTotalVenta.Name = "LTotalVenta"
        Me.LTotalVenta.Size = New System.Drawing.Size(59, 22)
        Me.LTotalVenta.TabIndex = 60
        Me.LTotalVenta.Text = "Total:"
        '
        'LNumeroFactura
        '
        Me.LNumeroFactura.AutoSize = True
        Me.LNumeroFactura.BackColor = System.Drawing.Color.Transparent
        Me.LNumeroFactura.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.LNumeroFactura.ForeColor = System.Drawing.Color.White
        Me.LNumeroFactura.Location = New System.Drawing.Point(36, 72)
        Me.LNumeroFactura.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LNumeroFactura.Name = "LNumeroFactura"
        Me.LNumeroFactura.Size = New System.Drawing.Size(93, 19)
        Me.LNumeroFactura.TabIndex = 59
        Me.LNumeroFactura.Text = "N° Factura:"
        '
        'TBNroFactura
        '
        Me.TBNroFactura.CausesValidation = False
        Me.TBNroFactura.Enabled = False
        Me.TBNroFactura.Font = New System.Drawing.Font("Britannic Bold", 10.0!)
        Me.TBNroFactura.Location = New System.Drawing.Point(127, 149)
        Me.TBNroFactura.Margin = New System.Windows.Forms.Padding(5)
        Me.TBNroFactura.Name = "TBNroFactura"
        Me.TBNroFactura.Size = New System.Drawing.Size(123, 26)
        Me.TBNroFactura.TabIndex = 61
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(595, 366)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 65
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(955, 522)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TBVendedor)
        Me.Controls.Add(Me.LVendedor)
        Me.Controls.Add(Me.LApellido)
        Me.Controls.Add(Me.TBApellido)
        Me.Controls.Add(Me.TBNombreCliVenta)
        Me.Controls.Add(Me.LNombreCli)
        Me.Controls.Add(Me.TBTotalVenta)
        Me.Controls.Add(Me.LTotalVenta)
        Me.Controls.Add(Me.LNumeroFactura)
        Me.Controls.Add(Me.TBNroFactura)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TBVendedor As TextBox
    Friend WithEvents LVendedor As Label
    Friend WithEvents LApellido As Label
    Public WithEvents TBApellido As TextBox
    Public WithEvents TBNombreCliVenta As TextBox
    Friend WithEvents LNombreCli As Label
    Friend WithEvents TBTotalVenta As TextBox
    Friend WithEvents LTotalVenta As Label
    Friend WithEvents LNumeroFactura As Label
    Friend WithEvents TBNroFactura As TextBox
    Friend WithEvents Button1 As Button
End Class
