<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionarVentas
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabControlGestionVentas = New System.Windows.Forms.TabControl()
        Me.TabPageListaTalle = New System.Windows.Forms.TabPage()
        Me.DataGridViewRegistroTalle = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBoxBuscarVenta = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BModVenta = New System.Windows.Forms.Button()
        Me.TBBuscarVenta = New System.Windows.Forms.TextBox()
        Me.BEliminarVenta = New System.Windows.Forms.Button()
        Me.TabControlGestionVentas.SuspendLayout()
        Me.TabPageListaTalle.SuspendLayout()
        CType(Me.DataGridViewRegistroTalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBoxBuscarVenta.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlGestionVentas
        '
        Me.TabControlGestionVentas.Controls.Add(Me.TabPageListaTalle)
        Me.TabControlGestionVentas.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlGestionVentas.Location = New System.Drawing.Point(21, 137)
        Me.TabControlGestionVentas.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControlGestionVentas.Name = "TabControlGestionVentas"
        Me.TabControlGestionVentas.SelectedIndex = 0
        Me.TabControlGestionVentas.Size = New System.Drawing.Size(772, 281)
        Me.TabControlGestionVentas.TabIndex = 8
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
        Me.TabPageListaTalle.Size = New System.Drawing.Size(764, 252)
        Me.TabPageListaTalle.TabIndex = 0
        Me.TabPageListaTalle.Text = "Lista de Ventas"
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
        Me.DataGridViewRegistroTalle.Size = New System.Drawing.Size(760, 248)
        Me.DataGridViewRegistroTalle.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBoxBuscarVenta)
        Me.Panel1.Location = New System.Drawing.Point(21, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(772, 111)
        Me.Panel1.TabIndex = 23
        '
        'GroupBoxBuscarVenta
        '
        Me.GroupBoxBuscarVenta.Controls.Add(Me.Button1)
        Me.GroupBoxBuscarVenta.Controls.Add(Me.BModVenta)
        Me.GroupBoxBuscarVenta.Controls.Add(Me.TBBuscarVenta)
        Me.GroupBoxBuscarVenta.Controls.Add(Me.BEliminarVenta)
        Me.GroupBoxBuscarVenta.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.GroupBoxBuscarVenta.ForeColor = System.Drawing.Color.White
        Me.GroupBoxBuscarVenta.Location = New System.Drawing.Point(6, 15)
        Me.GroupBoxBuscarVenta.Name = "GroupBoxBuscarVenta"
        Me.GroupBoxBuscarVenta.Size = New System.Drawing.Size(747, 81)
        Me.GroupBoxBuscarVenta.TabIndex = 18
        Me.GroupBoxBuscarVenta.TabStop = False
        Me.GroupBoxBuscarVenta.Text = "Búscar Venta"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(157, 34)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 26)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BModVenta
        '
        Me.BModVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BModVenta.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BModVenta.FlatAppearance.BorderSize = 2
        Me.BModVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModVenta.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BModVenta.ForeColor = System.Drawing.Color.White
        Me.BModVenta.Location = New System.Drawing.Point(550, 34)
        Me.BModVenta.Name = "BModVenta"
        Me.BModVenta.Size = New System.Drawing.Size(79, 26)
        Me.BModVenta.TabIndex = 16
        Me.BModVenta.Text = "Modificar"
        Me.BModVenta.UseVisualStyleBackColor = False
        '
        'TBBuscarVenta
        '
        Me.TBBuscarVenta.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBBuscarVenta.Location = New System.Drawing.Point(20, 35)
        Me.TBBuscarVenta.Name = "TBBuscarVenta"
        Me.TBBuscarVenta.Size = New System.Drawing.Size(131, 25)
        Me.TBBuscarVenta.TabIndex = 9
        '
        'BEliminarVenta
        '
        Me.BEliminarVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BEliminarVenta.FlatAppearance.BorderSize = 2
        Me.BEliminarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEliminarVenta.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminarVenta.ForeColor = System.Drawing.Color.White
        Me.BEliminarVenta.Location = New System.Drawing.Point(644, 34)
        Me.BEliminarVenta.Name = "BEliminarVenta"
        Me.BEliminarVenta.Size = New System.Drawing.Size(80, 26)
        Me.BEliminarVenta.TabIndex = 17
        Me.BEliminarVenta.Text = "Eliminar"
        Me.BEliminarVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BEliminarVenta.UseVisualStyleBackColor = False
        '
        'GestionarVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(804, 429)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControlGestionVentas)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "GestionarVentas"
        Me.Text = "Buscar Venta"
        Me.TabControlGestionVentas.ResumeLayout(False)
        Me.TabPageListaTalle.ResumeLayout(False)
        CType(Me.DataGridViewRegistroTalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBoxBuscarVenta.ResumeLayout(False)
        Me.GroupBoxBuscarVenta.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControlGestionVentas As TabControl
    Friend WithEvents TabPageListaTalle As TabPage
    Friend WithEvents DataGridViewRegistroTalle As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBoxBuscarVenta As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BModVenta As Button
    Friend WithEvents TBBuscarVenta As TextBox
    Friend WithEvents BEliminarVenta As Button
End Class
