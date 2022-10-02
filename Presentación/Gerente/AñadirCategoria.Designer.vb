<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Añadir_Categoria
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
        Me.TBNombreCategoria = New System.Windows.Forms.TextBox()
        Me.LNombreCategoria = New System.Windows.Forms.Label()
        Me.LCategoria = New System.Windows.Forms.Label()
        Me.TabControlRegVentas = New System.Windows.Forms.TabControl()
        Me.TabPageListaCategoria = New System.Windows.Forms.TabPage()
        Me.DataGridViewRegistroCategorias = New System.Windows.Forms.DataGridView()
        Me.BCancelarCategoria = New System.Windows.Forms.Button()
        Me.BRegistrarCategoria = New System.Windows.Forms.Button()
        Me.PanelRegClientes = New System.Windows.Forms.Panel()
        Me.TabControlRegVentas.SuspendLayout()
        Me.TabPageListaCategoria.SuspendLayout()
        CType(Me.DataGridViewRegistroCategorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelRegClientes.SuspendLayout()
        Me.SuspendLayout()
        '
        'TBNombreCategoria
        '
        Me.TBNombreCategoria.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBNombreCategoria.Location = New System.Drawing.Point(27, 71)
        Me.TBNombreCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.TBNombreCategoria.Name = "TBNombreCategoria"
        Me.TBNombreCategoria.Size = New System.Drawing.Size(371, 30)
        Me.TBNombreCategoria.TabIndex = 6
        '
        'LNombreCategoria
        '
        Me.LNombreCategoria.AutoSize = True
        Me.LNombreCategoria.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LNombreCategoria.ForeColor = System.Drawing.Color.White
        Me.LNombreCategoria.Location = New System.Drawing.Point(112, 28)
        Me.LNombreCategoria.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LNombreCategoria.Name = "LNombreCategoria"
        Me.LNombreCategoria.Size = New System.Drawing.Size(199, 22)
        Me.LNombreCategoria.TabIndex = 0
        Me.LNombreCategoria.Text = "Nombre de Categoria"
        '
        'LCategoria
        '
        Me.LCategoria.AutoSize = True
        Me.LCategoria.BackColor = System.Drawing.Color.Transparent
        Me.LCategoria.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCategoria.ForeColor = System.Drawing.Color.Transparent
        Me.LCategoria.Location = New System.Drawing.Point(29, 49)
        Me.LCategoria.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LCategoria.Name = "LCategoria"
        Me.LCategoria.Size = New System.Drawing.Size(231, 33)
        Me.LCategoria.TabIndex = 2
        Me.LCategoria.Text = "Nueva Categoria"
        '
        'TabControlRegVentas
        '
        Me.TabControlRegVentas.Controls.Add(Me.TabPageListaCategoria)
        Me.TabControlRegVentas.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlRegVentas.Location = New System.Drawing.Point(493, 128)
        Me.TabControlRegVentas.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlRegVentas.Name = "TabControlRegVentas"
        Me.TabControlRegVentas.SelectedIndex = 0
        Me.TabControlRegVentas.Size = New System.Drawing.Size(619, 482)
        Me.TabControlRegVentas.TabIndex = 5
        '
        'TabPageListaCategoria
        '
        Me.TabPageListaCategoria.Controls.Add(Me.DataGridViewRegistroCategorias)
        Me.TabPageListaCategoria.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaCategoria.ForeColor = System.Drawing.Color.White
        Me.TabPageListaCategoria.Location = New System.Drawing.Point(4, 28)
        Me.TabPageListaCategoria.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaCategoria.Name = "TabPageListaCategoria"
        Me.TabPageListaCategoria.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaCategoria.Size = New System.Drawing.Size(611, 450)
        Me.TabPageListaCategoria.TabIndex = 0
        Me.TabPageListaCategoria.Text = "Lista de Categoria"
        Me.TabPageListaCategoria.UseVisualStyleBackColor = True
        '
        'DataGridViewRegistroCategorias
        '
        Me.DataGridViewRegistroCategorias.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.DataGridViewRegistroCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewRegistroCategorias.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewRegistroCategorias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewRegistroCategorias.Location = New System.Drawing.Point(3, 2)
        Me.DataGridViewRegistroCategorias.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridViewRegistroCategorias.Name = "DataGridViewRegistroCategorias"
        Me.DataGridViewRegistroCategorias.RowHeadersWidth = 51
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewRegistroCategorias.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewRegistroCategorias.Size = New System.Drawing.Size(605, 446)
        Me.DataGridViewRegistroCategorias.TabIndex = 2
        '
        'BCancelarCategoria
        '
        Me.BCancelarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BCancelarCategoria.FlatAppearance.BorderSize = 2
        Me.BCancelarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelarCategoria.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelarCategoria.ForeColor = System.Drawing.Color.White
        Me.BCancelarCategoria.Location = New System.Drawing.Point(300, 155)
        Me.BCancelarCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.BCancelarCategoria.Name = "BCancelarCategoria"
        Me.BCancelarCategoria.Size = New System.Drawing.Size(99, 32)
        Me.BCancelarCategoria.TabIndex = 12
        Me.BCancelarCategoria.Text = "Cancelar"
        Me.BCancelarCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelarCategoria.UseVisualStyleBackColor = False
        '
        'BRegistrarCategoria
        '
        Me.BRegistrarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BRegistrarCategoria.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BRegistrarCategoria.FlatAppearance.BorderSize = 2
        Me.BRegistrarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRegistrarCategoria.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BRegistrarCategoria.ForeColor = System.Drawing.Color.White
        Me.BRegistrarCategoria.Location = New System.Drawing.Point(179, 155)
        Me.BRegistrarCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.BRegistrarCategoria.Name = "BRegistrarCategoria"
        Me.BRegistrarCategoria.Size = New System.Drawing.Size(97, 32)
        Me.BRegistrarCategoria.TabIndex = 13
        Me.BRegistrarCategoria.Text = "Registrar"
        Me.BRegistrarCategoria.UseVisualStyleBackColor = False
        '
        'PanelRegClientes
        '
        Me.PanelRegClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PanelRegClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelRegClientes.Controls.Add(Me.BRegistrarCategoria)
        Me.PanelRegClientes.Controls.Add(Me.BCancelarCategoria)
        Me.PanelRegClientes.Controls.Add(Me.TBNombreCategoria)
        Me.PanelRegClientes.Controls.Add(Me.LNombreCategoria)
        Me.PanelRegClientes.Location = New System.Drawing.Point(35, 128)
        Me.PanelRegClientes.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelRegClientes.Name = "PanelRegClientes"
        Me.PanelRegClientes.Size = New System.Drawing.Size(425, 222)
        Me.PanelRegClientes.TabIndex = 1
        '
        'Añadir_Categoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 656)
        Me.Controls.Add(Me.TabControlRegVentas)
        Me.Controls.Add(Me.LCategoria)
        Me.Controls.Add(Me.PanelRegClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Añadir_Categoria"
        Me.Text = "Añadir_Categoria"
        Me.TabControlRegVentas.ResumeLayout(False)
        Me.TabPageListaCategoria.ResumeLayout(False)
        CType(Me.DataGridViewRegistroCategorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelRegClientes.ResumeLayout(False)
        Me.PanelRegClientes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TBNombreCategoria As TextBox
    Friend WithEvents LNombreCategoria As Label
    Friend WithEvents LCategoria As Label
    Friend WithEvents TabControlRegVentas As TabControl
    Friend WithEvents TabPageListaCategoria As TabPage
    Friend WithEvents DataGridViewRegistroCategorias As DataGridView
    Friend WithEvents BCancelarCategoria As Button
    Friend WithEvents BRegistrarCategoria As Button
    Friend WithEvents PanelRegClientes As Panel
End Class
