<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarCategoria
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
        Me.components = New System.ComponentModel.Container()
        Me.PanelModCategoria = New System.Windows.Forms.Panel()
        Me.BCancelarModifCategoria = New System.Windows.Forms.Button()
        Me.GroupBoxDatosCliente = New System.Windows.Forms.GroupBox()
        Me.TBNombreCategoria = New System.Windows.Forms.TextBox()
        Me.LNombreCategoria = New System.Windows.Forms.Label()
        Me.BModificarCategoria = New System.Windows.Forms.Button()
        Me.ErrorProviderNomCateg = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelModCategoria.SuspendLayout()
        Me.GroupBoxDatosCliente.SuspendLayout()
        CType(Me.ErrorProviderNomCateg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelModCategoria
        '
        Me.PanelModCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PanelModCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelModCategoria.Controls.Add(Me.BCancelarModifCategoria)
        Me.PanelModCategoria.Controls.Add(Me.GroupBoxDatosCliente)
        Me.PanelModCategoria.Controls.Add(Me.BModificarCategoria)
        Me.PanelModCategoria.Location = New System.Drawing.Point(79, 69)
        Me.PanelModCategoria.Margin = New System.Windows.Forms.Padding(5)
        Me.PanelModCategoria.Name = "PanelModCategoria"
        Me.PanelModCategoria.Size = New System.Drawing.Size(611, 383)
        Me.PanelModCategoria.TabIndex = 3
        '
        'BCancelarModifCategoria
        '
        Me.BCancelarModifCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BCancelarModifCategoria.FlatAppearance.BorderSize = 2
        Me.BCancelarModifCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelarModifCategoria.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BCancelarModifCategoria.ForeColor = System.Drawing.Color.White
        Me.BCancelarModifCategoria.Location = New System.Drawing.Point(456, 307)
        Me.BCancelarModifCategoria.Margin = New System.Windows.Forms.Padding(5)
        Me.BCancelarModifCategoria.Name = "BCancelarModifCategoria"
        Me.BCancelarModifCategoria.Size = New System.Drawing.Size(130, 52)
        Me.BCancelarModifCategoria.TabIndex = 12
        Me.BCancelarModifCategoria.Text = "Cancelar"
        Me.BCancelarModifCategoria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelarModifCategoria.UseVisualStyleBackColor = False
        '
        'GroupBoxDatosCliente
        '
        Me.GroupBoxDatosCliente.Controls.Add(Me.TBNombreCategoria)
        Me.GroupBoxDatosCliente.Controls.Add(Me.LNombreCategoria)
        Me.GroupBoxDatosCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.GroupBoxDatosCliente.ForeColor = System.Drawing.Color.White
        Me.GroupBoxDatosCliente.Location = New System.Drawing.Point(51, 22)
        Me.GroupBoxDatosCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxDatosCliente.Name = "GroupBoxDatosCliente"
        Me.GroupBoxDatosCliente.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxDatosCliente.Size = New System.Drawing.Size(473, 246)
        Me.GroupBoxDatosCliente.TabIndex = 19
        Me.GroupBoxDatosCliente.TabStop = False
        Me.GroupBoxDatosCliente.Text = "Modificar Categoría"
        '
        'TBNombreCategoria
        '
        Me.TBNombreCategoria.Location = New System.Drawing.Point(139, 121)
        Me.TBNombreCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.TBNombreCategoria.Name = "TBNombreCategoria"
        Me.TBNombreCategoria.Size = New System.Drawing.Size(221, 30)
        Me.TBNombreCategoria.TabIndex = 16
        '
        'LNombreCategoria
        '
        Me.LNombreCategoria.AutoSize = True
        Me.LNombreCategoria.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LNombreCategoria.ForeColor = System.Drawing.Color.White
        Me.LNombreCategoria.Location = New System.Drawing.Point(135, 79)
        Me.LNombreCategoria.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.LNombreCategoria.Name = "LNombreCategoria"
        Me.LNombreCategoria.Size = New System.Drawing.Size(109, 22)
        Me.LNombreCategoria.TabIndex = 15
        Me.LNombreCategoria.Text = "Categoria: "
        '
        'BModificarCategoria
        '
        Me.BModificarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BModificarCategoria.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BModificarCategoria.FlatAppearance.BorderSize = 2
        Me.BModificarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModificarCategoria.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BModificarCategoria.ForeColor = System.Drawing.Color.White
        Me.BModificarCategoria.Location = New System.Drawing.Point(316, 307)
        Me.BModificarCategoria.Margin = New System.Windows.Forms.Padding(5)
        Me.BModificarCategoria.Name = "BModificarCategoria"
        Me.BModificarCategoria.Size = New System.Drawing.Size(130, 52)
        Me.BModificarCategoria.TabIndex = 13
        Me.BModificarCategoria.Text = "Modificar"
        Me.BModificarCategoria.UseVisualStyleBackColor = False
        '
        'ErrorProviderNomCateg
        '
        Me.ErrorProviderNomCateg.ContainerControl = Me
        '
        'ModificarCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(775, 500)
        Me.Controls.Add(Me.PanelModCategoria)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ModificarCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModificarCategoria"
        Me.PanelModCategoria.ResumeLayout(False)
        Me.GroupBoxDatosCliente.ResumeLayout(False)
        Me.GroupBoxDatosCliente.PerformLayout()
        CType(Me.ErrorProviderNomCateg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelModCategoria As Panel
    Friend WithEvents BCancelarModifCategoria As Button
    Friend WithEvents GroupBoxDatosCliente As GroupBox
    Friend WithEvents LNombreCategoria As Label
    Friend WithEvents BModificarCategoria As Button
    Friend WithEvents TBNombreCategoria As TextBox
    Friend WithEvents ErrorProviderNomCateg As ErrorProvider
End Class
