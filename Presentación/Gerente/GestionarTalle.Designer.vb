<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarTalle
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
        Me.TBBuscarTalle = New System.Windows.Forms.TextBox()
        Me.BBuscarTalle = New System.Windows.Forms.Button()
        Me.BModificarTalle = New System.Windows.Forms.Button()
        Me.BEliminarTalle = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TabGestionTalles = New System.Windows.Forms.TabControl()
        Me.TabPageListaTalle = New System.Windows.Forms.TabPage()
        Me.DataGridViewRegistroTalle = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.TabGestionTalles.SuspendLayout()
        Me.TabPageListaTalle.SuspendLayout()
        CType(Me.DataGridViewRegistroTalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBBuscarTalle
        '
        Me.TBBuscarTalle.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBBuscarTalle.Location = New System.Drawing.Point(20, 35)
        Me.TBBuscarTalle.Name = "TBBuscarTalle"
        Me.TBBuscarTalle.Size = New System.Drawing.Size(131, 25)
        Me.TBBuscarTalle.TabIndex = 9
        '
        'BBuscarTalle
        '
        Me.BBuscarTalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BBuscarTalle.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BBuscarTalle.FlatAppearance.BorderSize = 2
        Me.BBuscarTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBuscarTalle.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscarTalle.ForeColor = System.Drawing.Color.White
        Me.BBuscarTalle.Location = New System.Drawing.Point(157, 34)
        Me.BBuscarTalle.Name = "BBuscarTalle"
        Me.BBuscarTalle.Size = New System.Drawing.Size(72, 26)
        Me.BBuscarTalle.TabIndex = 15
        Me.BBuscarTalle.Text = "Buscar"
        Me.BBuscarTalle.UseVisualStyleBackColor = False
        '
        'BModificarTalle
        '
        Me.BModificarTalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BModificarTalle.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BModificarTalle.FlatAppearance.BorderSize = 2
        Me.BModificarTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModificarTalle.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BModificarTalle.ForeColor = System.Drawing.Color.White
        Me.BModificarTalle.Location = New System.Drawing.Point(550, 34)
        Me.BModificarTalle.Name = "BModificarTalle"
        Me.BModificarTalle.Size = New System.Drawing.Size(79, 26)
        Me.BModificarTalle.TabIndex = 16
        Me.BModificarTalle.Text = "Modificar"
        Me.BModificarTalle.UseVisualStyleBackColor = False
        '
        'BEliminarTalle
        '
        Me.BEliminarTalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BEliminarTalle.FlatAppearance.BorderSize = 2
        Me.BEliminarTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEliminarTalle.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminarTalle.ForeColor = System.Drawing.Color.White
        Me.BEliminarTalle.Location = New System.Drawing.Point(644, 34)
        Me.BEliminarTalle.Name = "BEliminarTalle"
        Me.BEliminarTalle.Size = New System.Drawing.Size(80, 26)
        Me.BEliminarTalle.TabIndex = 17
        Me.BEliminarTalle.Text = "Eliminar"
        Me.BEliminarTalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BEliminarTalle.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BBuscarTalle)
        Me.GroupBox1.Controls.Add(Me.BModificarTalle)
        Me.GroupBox1.Controls.Add(Me.TBBuscarTalle)
        Me.GroupBox1.Controls.Add(Me.BEliminarTalle)
        Me.GroupBox1.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(6, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(747, 81)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Búsqueda de talles"
        '
        'TabGestionTalles
        '
        Me.TabGestionTalles.Controls.Add(Me.TabPageListaTalle)
        Me.TabGestionTalles.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabGestionTalles.Location = New System.Drawing.Point(22, 151)
        Me.TabGestionTalles.Margin = New System.Windows.Forms.Padding(2)
        Me.TabGestionTalles.Name = "TabGestionTalles"
        Me.TabGestionTalles.SelectedIndex = 0
        Me.TabGestionTalles.Size = New System.Drawing.Size(772, 296)
        Me.TabGestionTalles.TabIndex = 19
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
        Me.TabPageListaTalle.Text = "Lista de Talles"
        Me.TabPageListaTalle.UseVisualStyleBackColor = True
        '
        'DataGridViewRegistroTalle
        '
        Me.DataGridViewRegistroTalle.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.DataGridViewRegistroTalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewRegistroTalle.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewRegistroTalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewRegistroTalle.Location = New System.Drawing.Point(2, 2)
        Me.DataGridViewRegistroTalle.Name = "DataGridViewRegistroTalle"
        Me.DataGridViewRegistroTalle.RowHeadersWidth = 51
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewRegistroTalle.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewRegistroTalle.Size = New System.Drawing.Size(760, 263)
        Me.DataGridViewRegistroTalle.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(22, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(772, 111)
        Me.Panel1.TabIndex = 20
        '
        'GestionarTalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(820, 468)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabGestionTalles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "GestionarTalle"
        Me.Text = "GestionarTalle"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabGestionTalles.ResumeLayout(False)
        Me.TabPageListaTalle.ResumeLayout(False)
        CType(Me.DataGridViewRegistroTalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TBBuscarTalle As TextBox
    Friend WithEvents BBuscarTalle As Button
    Friend WithEvents BModificarTalle As Button
    Friend WithEvents BEliminarTalle As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TabGestionTalles As TabControl
    Friend WithEvents TabPageListaTalle As TabPage
    Friend WithEvents DataGridViewRegistroTalle As DataGridView
    Friend WithEvents Panel1 As Panel
End Class
