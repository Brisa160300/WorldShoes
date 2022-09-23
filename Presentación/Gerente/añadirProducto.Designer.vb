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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TBNombreProducto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TBPrecio = New System.Windows.Forms.TextBox()
        Me.TBCateoriaProducto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TBStock = New System.Windows.Forms.TextBox()
        Me.BCancelProducto = New System.Windows.Forms.Button()
        Me.BAñadirProducto = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.BCancelProducto)
        Me.Panel1.Controls.Add(Me.BAñadirProducto)
        Me.Panel1.Location = New System.Drawing.Point(39, 45)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(724, 375)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 22)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Añadir Producto: "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.ComboBox1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.TBNombreProducto)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.TBPrecio)
        Me.Panel2.Controls.Add(Me.TBCateoriaProducto)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.TBStock)
        Me.Panel2.Location = New System.Drawing.Point(37, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(646, 285)
        Me.Panel2.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(23, 80)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Categoría: "
        '
        'TBNombreProducto
        '
        Me.TBNombreProducto.Location = New System.Drawing.Point(112, 13)
        Me.TBNombreProducto.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.TBNombreProducto.Name = "TBNombreProducto"
        Me.TBNombreProducto.Size = New System.Drawing.Size(196, 29)
        Me.TBNombreProducto.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(23, 21)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(23, 197)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 16)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Precio: "
        '
        'TBPrecio
        '
        Me.TBPrecio.Location = New System.Drawing.Point(112, 189)
        Me.TBPrecio.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.TBPrecio.Name = "TBPrecio"
        Me.TBPrecio.Size = New System.Drawing.Size(196, 29)
        Me.TBPrecio.TabIndex = 8
        '
        'TBCateoriaProducto
        '
        Me.TBCateoriaProducto.Location = New System.Drawing.Point(112, 72)
        Me.TBCateoriaProducto.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.TBCateoriaProducto.Name = "TBCateoriaProducto"
        Me.TBCateoriaProducto.Size = New System.Drawing.Size(196, 29)
        Me.TBCateoriaProducto.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(23, 138)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Stock:"
        '
        'TBStock
        '
        Me.TBStock.Location = New System.Drawing.Point(112, 130)
        Me.TBStock.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.TBStock.Name = "TBStock"
        Me.TBStock.Size = New System.Drawing.Size(196, 29)
        Me.TBStock.TabIndex = 7
        '
        'BCancelProducto
        '
        Me.BCancelProducto.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BCancelProducto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelProducto.Location = New System.Drawing.Point(583, 331)
        Me.BCancelProducto.Name = "BCancelProducto"
        Me.BCancelProducto.Size = New System.Drawing.Size(100, 28)
        Me.BCancelProducto.TabIndex = 3
        Me.BCancelProducto.Text = "Cancelar"
        Me.BCancelProducto.UseVisualStyleBackColor = True
        '
        'BAñadirProducto
        '
        Me.BAñadirProducto.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BAñadirProducto.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAñadirProducto.Location = New System.Drawing.Point(464, 331)
        Me.BAñadirProducto.Name = "BAñadirProducto"
        Me.BAñadirProducto.Size = New System.Drawing.Size(100, 28)
        Me.BAñadirProducto.TabIndex = 2
        Me.BAñadirProducto.Text = "Añadir"
        Me.BAñadirProducto.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("MS Reference Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(24, 247)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Talle: "
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(112, 239)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(73, 30)
        Me.ComboBox1.TabIndex = 11
        '
        'añadirProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 444)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "añadirProducto"
        Me.Text = "añadirProducto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TBPrecio As TextBox
    Friend WithEvents TBStock As TextBox
    Friend WithEvents TBCateoriaProducto As TextBox
    Friend WithEvents TBNombreProducto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BAñadirProducto As Button
    Friend WithEvents BCancelProducto As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label6 As Label
End Class
