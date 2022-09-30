<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AñadirTalle
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
        Me.LTalle = New System.Windows.Forms.Label()
        Me.PanelRegClientes = New System.Windows.Forms.Panel()
        Me.BRegistrarTalle = New System.Windows.Forms.Button()
        Me.BCancelarTalle = New System.Windows.Forms.Button()
        Me.TBNombreCliente = New System.Windows.Forms.TextBox()
        Me.LNombreTalle = New System.Windows.Forms.Label()
        Me.TabControlRegVentas = New System.Windows.Forms.TabControl()
        Me.TabPageListaTalles = New System.Windows.Forms.TabPage()
        Me.DataGridViewRegistroTalles = New System.Windows.Forms.DataGridView()
        Me.PanelRegClientes.SuspendLayout()
        Me.TabControlRegVentas.SuspendLayout()
        Me.TabPageListaTalles.SuspendLayout()
        CType(Me.DataGridViewRegistroTalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LTalle
        '
        Me.LTalle.AutoSize = True
        Me.LTalle.BackColor = System.Drawing.Color.Transparent
        Me.LTalle.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTalle.ForeColor = System.Drawing.Color.Transparent
        Me.LTalle.Location = New System.Drawing.Point(29, 20)
        Me.LTalle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LTalle.Name = "LTalle"
        Me.LTalle.Size = New System.Drawing.Size(166, 33)
        Me.LTalle.TabIndex = 3
        Me.LTalle.Text = "Nuevo Talle"
        '
        'PanelRegClientes
        '
        Me.PanelRegClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.PanelRegClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelRegClientes.Controls.Add(Me.BRegistrarTalle)
        Me.PanelRegClientes.Controls.Add(Me.BCancelarTalle)
        Me.PanelRegClientes.Controls.Add(Me.TBNombreCliente)
        Me.PanelRegClientes.Controls.Add(Me.LNombreTalle)
        Me.PanelRegClientes.Location = New System.Drawing.Point(35, 84)
        Me.PanelRegClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelRegClientes.Name = "PanelRegClientes"
        Me.PanelRegClientes.Size = New System.Drawing.Size(425, 221)
        Me.PanelRegClientes.TabIndex = 4
        '
        'BRegistrarTalle
        '
        Me.BRegistrarTalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BRegistrarTalle.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BRegistrarTalle.FlatAppearance.BorderSize = 2
        Me.BRegistrarTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRegistrarTalle.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BRegistrarTalle.ForeColor = System.Drawing.Color.White
        Me.BRegistrarTalle.Location = New System.Drawing.Point(178, 155)
        Me.BRegistrarTalle.Margin = New System.Windows.Forms.Padding(4)
        Me.BRegistrarTalle.Name = "BRegistrarTalle"
        Me.BRegistrarTalle.Size = New System.Drawing.Size(97, 32)
        Me.BRegistrarTalle.TabIndex = 13
        Me.BRegistrarTalle.Text = "Registrar"
        Me.BRegistrarTalle.UseVisualStyleBackColor = False
        '
        'BCancelarTalle
        '
        Me.BCancelarTalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BCancelarTalle.FlatAppearance.BorderSize = 2
        Me.BCancelarTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelarTalle.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelarTalle.ForeColor = System.Drawing.Color.White
        Me.BCancelarTalle.Location = New System.Drawing.Point(300, 155)
        Me.BCancelarTalle.Margin = New System.Windows.Forms.Padding(4)
        Me.BCancelarTalle.Name = "BCancelarTalle"
        Me.BCancelarTalle.Size = New System.Drawing.Size(98, 32)
        Me.BCancelarTalle.TabIndex = 12
        Me.BCancelarTalle.Text = "Cancelar"
        Me.BCancelarTalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelarTalle.UseVisualStyleBackColor = False
        '
        'TBNombreCliente
        '
        Me.TBNombreCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBNombreCliente.Location = New System.Drawing.Point(27, 72)
        Me.TBNombreCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.TBNombreCliente.Name = "TBNombreCliente"
        Me.TBNombreCliente.Size = New System.Drawing.Size(371, 30)
        Me.TBNombreCliente.TabIndex = 6
        '
        'LNombreTalle
        '
        Me.LNombreTalle.AutoSize = True
        Me.LNombreTalle.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LNombreTalle.ForeColor = System.Drawing.Color.White
        Me.LNombreTalle.Location = New System.Drawing.Point(112, 28)
        Me.LNombreTalle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LNombreTalle.Name = "LNombreTalle"
        Me.LNombreTalle.Size = New System.Drawing.Size(153, 22)
        Me.LNombreTalle.TabIndex = 0
        Me.LNombreTalle.Text = "Nombre de Talle"
        '
        'TabControlRegVentas
        '
        Me.TabControlRegVentas.Controls.Add(Me.TabPageListaTalles)
        Me.TabControlRegVentas.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlRegVentas.Location = New System.Drawing.Point(511, 21)
        Me.TabControlRegVentas.Name = "TabControlRegVentas"
        Me.TabControlRegVentas.SelectedIndex = 0
        Me.TabControlRegVentas.Size = New System.Drawing.Size(515, 460)
        Me.TabControlRegVentas.TabIndex = 6
        '
        'TabPageListaTalles
        '
        Me.TabPageListaTalles.Controls.Add(Me.DataGridViewRegistroTalles)
        Me.TabPageListaTalles.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaTalles.ForeColor = System.Drawing.Color.White
        Me.TabPageListaTalles.Location = New System.Drawing.Point(4, 28)
        Me.TabPageListaTalles.Name = "TabPageListaTalles"
        Me.TabPageListaTalles.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageListaTalles.Size = New System.Drawing.Size(507, 428)
        Me.TabPageListaTalles.TabIndex = 0
        Me.TabPageListaTalles.Text = "Lista de Talles"
        Me.TabPageListaTalles.UseVisualStyleBackColor = True
        '
        'DataGridViewRegistroTalles
        '
        Me.DataGridViewRegistroTalles.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.DataGridViewRegistroTalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewRegistroTalles.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewRegistroTalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewRegistroTalles.Location = New System.Drawing.Point(3, 3)
        Me.DataGridViewRegistroTalles.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewRegistroTalles.Name = "DataGridViewRegistroTalles"
        Me.DataGridViewRegistroTalles.RowHeadersWidth = 51
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewRegistroTalles.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewRegistroTalles.Size = New System.Drawing.Size(501, 422)
        Me.DataGridViewRegistroTalles.TabIndex = 2
        '
        'AñadirTalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1093, 556)
        Me.Controls.Add(Me.TabControlRegVentas)
        Me.Controls.Add(Me.PanelRegClientes)
        Me.Controls.Add(Me.LTalle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AñadirTalle"
        Me.Text = "AñadirTalle"
        Me.PanelRegClientes.ResumeLayout(False)
        Me.PanelRegClientes.PerformLayout()
        Me.TabControlRegVentas.ResumeLayout(False)
        Me.TabPageListaTalles.ResumeLayout(False)
        CType(Me.DataGridViewRegistroTalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LTalle As Label
    Friend WithEvents PanelRegClientes As Panel
    Friend WithEvents BRegistrarTalle As Button
    Friend WithEvents BCancelarTalle As Button
    Friend WithEvents TBNombreCliente As TextBox
    Friend WithEvents LNombreTalle As Label
    Friend WithEvents TabControlRegVentas As TabControl
    Friend WithEvents TabPageListaTalles As TabPage
    Friend WithEvents DataGridViewRegistroTalles As DataGridView
End Class
