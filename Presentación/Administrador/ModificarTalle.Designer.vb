<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarTalle
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
        Me.PanelModTalle = New System.Windows.Forms.Panel()
        Me.BCancelarModifTalle = New System.Windows.Forms.Button()
        Me.GroupBoxDatosCliente = New System.Windows.Forms.GroupBox()
        Me.TBModTalle = New System.Windows.Forms.TextBox()
        Me.LModTalle = New System.Windows.Forms.Label()
        Me.BModificarTalle = New System.Windows.Forms.Button()
        Me.ErrorProviderTalle = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PanelModTalle.SuspendLayout()
        Me.GroupBoxDatosCliente.SuspendLayout()
        CType(Me.ErrorProviderTalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelModTalle
        '
        Me.PanelModTalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PanelModTalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelModTalle.Controls.Add(Me.BCancelarModifTalle)
        Me.PanelModTalle.Controls.Add(Me.GroupBoxDatosCliente)
        Me.PanelModTalle.Controls.Add(Me.BModificarTalle)
        Me.PanelModTalle.Location = New System.Drawing.Point(79, 69)
        Me.PanelModTalle.Margin = New System.Windows.Forms.Padding(5)
        Me.PanelModTalle.Name = "PanelModTalle"
        Me.PanelModTalle.Size = New System.Drawing.Size(612, 372)
        Me.PanelModTalle.TabIndex = 4
        '
        'BCancelarModifTalle
        '
        Me.BCancelarModifTalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BCancelarModifTalle.FlatAppearance.BorderSize = 2
        Me.BCancelarModifTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelarModifTalle.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BCancelarModifTalle.ForeColor = System.Drawing.Color.White
        Me.BCancelarModifTalle.Location = New System.Drawing.Point(453, 295)
        Me.BCancelarModifTalle.Margin = New System.Windows.Forms.Padding(5)
        Me.BCancelarModifTalle.Name = "BCancelarModifTalle"
        Me.BCancelarModifTalle.Size = New System.Drawing.Size(131, 52)
        Me.BCancelarModifTalle.TabIndex = 12
        Me.BCancelarModifTalle.Text = "Cancelar"
        Me.BCancelarModifTalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelarModifTalle.UseVisualStyleBackColor = False
        '
        'GroupBoxDatosCliente
        '
        Me.GroupBoxDatosCliente.Controls.Add(Me.TBModTalle)
        Me.GroupBoxDatosCliente.Controls.Add(Me.LModTalle)
        Me.GroupBoxDatosCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.GroupBoxDatosCliente.ForeColor = System.Drawing.Color.White
        Me.GroupBoxDatosCliente.Location = New System.Drawing.Point(51, 22)
        Me.GroupBoxDatosCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxDatosCliente.Name = "GroupBoxDatosCliente"
        Me.GroupBoxDatosCliente.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxDatosCliente.Size = New System.Drawing.Size(473, 246)
        Me.GroupBoxDatosCliente.TabIndex = 19
        Me.GroupBoxDatosCliente.TabStop = False
        Me.GroupBoxDatosCliente.Text = "Modificar Talle"
        '
        'TBModTalle
        '
        Me.TBModTalle.Location = New System.Drawing.Point(127, 121)
        Me.TBModTalle.Margin = New System.Windows.Forms.Padding(4)
        Me.TBModTalle.Name = "TBModTalle"
        Me.TBModTalle.Size = New System.Drawing.Size(221, 30)
        Me.TBModTalle.TabIndex = 16
        '
        'LModTalle
        '
        Me.LModTalle.AutoSize = True
        Me.LModTalle.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LModTalle.ForeColor = System.Drawing.Color.White
        Me.LModTalle.Location = New System.Drawing.Point(123, 85)
        Me.LModTalle.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.LModTalle.Name = "LModTalle"
        Me.LModTalle.Size = New System.Drawing.Size(63, 22)
        Me.LModTalle.TabIndex = 15
        Me.LModTalle.Text = "Talle: "
        '
        'BModificarTalle
        '
        Me.BModificarTalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BModificarTalle.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BModificarTalle.FlatAppearance.BorderSize = 2
        Me.BModificarTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModificarTalle.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BModificarTalle.ForeColor = System.Drawing.Color.White
        Me.BModificarTalle.Location = New System.Drawing.Point(315, 295)
        Me.BModificarTalle.Margin = New System.Windows.Forms.Padding(5)
        Me.BModificarTalle.Name = "BModificarTalle"
        Me.BModificarTalle.Size = New System.Drawing.Size(131, 52)
        Me.BModificarTalle.TabIndex = 13
        Me.BModificarTalle.Text = "Modificar"
        Me.BModificarTalle.UseVisualStyleBackColor = False
        '
        'ErrorProviderTalle
        '
        Me.ErrorProviderTalle.ContainerControl = Me
        '
        'ModificarTalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(775, 500)
        Me.Controls.Add(Me.PanelModTalle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ModificarTalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModificarTalle"
        Me.PanelModTalle.ResumeLayout(False)
        Me.GroupBoxDatosCliente.ResumeLayout(False)
        Me.GroupBoxDatosCliente.PerformLayout()
        CType(Me.ErrorProviderTalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelModTalle As Panel
    Friend WithEvents BCancelarModifTalle As Button
    Friend WithEvents GroupBoxDatosCliente As GroupBox
    Friend WithEvents LModTalle As Label
    Friend WithEvents BModificarTalle As Button
    Friend WithEvents TBModTalle As TextBox
    Friend WithEvents ErrorProviderTalle As ErrorProvider
End Class
