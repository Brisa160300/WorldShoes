<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class añadirProducto
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
        Me.BAñadirProducto = New System.Windows.Forms.Button()
        Me.BCancelProducto = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TBCodigoProducto = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.LCodigoProducto = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBNombreProducto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBPrecio = New System.Windows.Forms.TextBox()
        Me.TBCateoriaProducto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBStock = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBMarcaProducto = New System.Windows.Forms.TextBox()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BAñadirProducto
        '
        Me.BAñadirProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BAñadirProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAñadirProducto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAñadirProducto.ForeColor = System.Drawing.Color.White
        Me.BAñadirProducto.Location = New System.Drawing.Point(649, 400)
        Me.BAñadirProducto.Name = "BAñadirProducto"
        Me.BAñadirProducto.Size = New System.Drawing.Size(100, 28)
        Me.BAñadirProducto.TabIndex = 2
        Me.BAñadirProducto.Text = "Añadir"
        Me.BAñadirProducto.UseVisualStyleBackColor = False
        '
        'BCancelProducto
        '
        Me.BCancelProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BCancelProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelProducto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelProducto.ForeColor = System.Drawing.Color.White
        Me.BCancelProducto.Location = New System.Drawing.Point(529, 400)
        Me.BCancelProducto.Name = "BCancelProducto"
        Me.BCancelProducto.Size = New System.Drawing.Size(100, 28)
        Me.BCancelProducto.TabIndex = 3
        Me.BCancelProducto.Text = "Cancelar"
        Me.BCancelProducto.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TBMarcaProducto)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.TBCodigoProducto)
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.LCodigoProducto)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.TBNombreProducto)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.TBPrecio)
        Me.Panel2.Controls.Add(Me.TBCateoriaProducto)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TBStock)
        Me.Panel2.Location = New System.Drawing.Point(57, 133)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(692, 250)
        Me.Panel2.TabIndex = 10
        '
        'TBCodigoProducto
        '
        Me.TBCodigoProducto.Location = New System.Drawing.Point(125, 39)
        Me.TBCodigoProducto.Name = "TBCodigoProducto"
        Me.TBCodigoProducto.Size = New System.Drawing.Size(196, 29)
        Me.TBCodigoProducto.TabIndex = 12
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(453, 138)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(73, 30)
        Me.ComboBox1.TabIndex = 11
        '
        'LCodigoProducto
        '
        Me.LCodigoProducto.AutoSize = True
        Me.LCodigoProducto.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LCodigoProducto.ForeColor = System.Drawing.Color.White
        Me.LCodigoProducto.Location = New System.Drawing.Point(37, 46)
        Me.LCodigoProducto.Name = "LCodigoProducto"
        Me.LCodigoProducto.Size = New System.Drawing.Size(63, 17)
        Me.LCodigoProducto.TabIndex = 11
        Me.LCodigoProducto.Text = "Código:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(365, 145)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Talle: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(36, 145)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Categoría: "
        '
        'TBNombreProducto
        '
        Me.TBNombreProducto.Location = New System.Drawing.Point(125, 89)
        Me.TBNombreProducto.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.TBNombreProducto.Name = "TBNombreProducto"
        Me.TBNombreProducto.Size = New System.Drawing.Size(196, 29)
        Me.TBNombreProducto.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(36, 96)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(365, 96)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Precio: "
        '
        'TBPrecio
        '
        Me.TBPrecio.Location = New System.Drawing.Point(453, 89)
        Me.TBPrecio.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.TBPrecio.Name = "TBPrecio"
        Me.TBPrecio.Size = New System.Drawing.Size(196, 29)
        Me.TBPrecio.TabIndex = 8
        '
        'TBCateoriaProducto
        '
        Me.TBCateoriaProducto.Location = New System.Drawing.Point(125, 138)
        Me.TBCateoriaProducto.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.TBCateoriaProducto.Name = "TBCateoriaProducto"
        Me.TBCateoriaProducto.Size = New System.Drawing.Size(196, 29)
        Me.TBCateoriaProducto.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(365, 45)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Stock:"
        '
        'TBStock
        '
        Me.TBStock.Location = New System.Drawing.Point(453, 38)
        Me.TBStock.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.TBStock.Name = "TBStock"
        Me.TBStock.Size = New System.Drawing.Size(196, 29)
        Me.TBStock.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 36)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(200, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Añadir Producto: "
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(807, 100)
        Me.Panel1.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(37, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Marca:"
        '
        'TBMarcaProducto
        '
        Me.TBMarcaProducto.Location = New System.Drawing.Point(125, 188)
        Me.TBMarcaProducto.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.TBMarcaProducto.Name = "TBMarcaProducto"
        Me.TBMarcaProducto.Size = New System.Drawing.Size(196, 29)
        Me.TBMarcaProducto.TabIndex = 14
        '
        'añadirProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(807, 452)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BCancelProducto)
        Me.Controls.Add(Me.BAñadirProducto)
        Me.Controls.Add(Me.Panel2)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "añadirProducto"
        Me.Text = "añadirProducto"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BAñadirProducto As Button
    Friend WithEvents BCancelProducto As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TBNombreProducto As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TBPrecio As TextBox
    Friend WithEvents TBCateoriaProducto As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TBStock As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBCodigoProducto As TextBox
    Friend WithEvents LCodigoProducto As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TBMarcaProducto As TextBox
    Friend WithEvents Label7 As Label
End Class
