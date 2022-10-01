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
        Me.PanelModCategoria = New System.Windows.Forms.Panel()
        Me.BCancelarModifCliente = New System.Windows.Forms.Button()
        Me.GroupBoxDatosCliente = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BModificarCategoria = New System.Windows.Forms.Button()
        Me.TBModCategoria = New System.Windows.Forms.TextBox()
        Me.PanelModCategoria.SuspendLayout()
        Me.GroupBoxDatosCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelModCategoria
        '
        Me.PanelModCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.PanelModCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelModCategoria.Controls.Add(Me.BCancelarModifCliente)
        Me.PanelModCategoria.Controls.Add(Me.GroupBoxDatosCliente)
        Me.PanelModCategoria.Controls.Add(Me.BModificarCategoria)
        Me.PanelModCategoria.Location = New System.Drawing.Point(59, 56)
        Me.PanelModCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelModCategoria.Name = "PanelModCategoria"
        Me.PanelModCategoria.Size = New System.Drawing.Size(435, 275)
        Me.PanelModCategoria.TabIndex = 3
        '
        'BCancelarModifCliente
        '
        Me.BCancelarModifCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BCancelarModifCliente.FlatAppearance.BorderSize = 2
        Me.BCancelarModifCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelarModifCliente.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelarModifCliente.ForeColor = System.Drawing.Color.White
        Me.BCancelarModifCliente.Location = New System.Drawing.Point(295, 225)
        Me.BCancelarModifCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.BCancelarModifCliente.Name = "BCancelarModifCliente"
        Me.BCancelarModifCliente.Size = New System.Drawing.Size(98, 32)
        Me.BCancelarModifCliente.TabIndex = 12
        Me.BCancelarModifCliente.Text = "Cancelar"
        Me.BCancelarModifCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelarModifCliente.UseVisualStyleBackColor = False
        '
        'GroupBoxDatosCliente
        '
        Me.GroupBoxDatosCliente.Controls.Add(Me.TBModCategoria)
        Me.GroupBoxDatosCliente.Controls.Add(Me.Label3)
        Me.GroupBoxDatosCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.GroupBoxDatosCliente.ForeColor = System.Drawing.Color.White
        Me.GroupBoxDatosCliente.Location = New System.Drawing.Point(38, 18)
        Me.GroupBoxDatosCliente.Name = "GroupBoxDatosCliente"
        Me.GroupBoxDatosCliente.Size = New System.Drawing.Size(355, 200)
        Me.GroupBoxDatosCliente.TabIndex = 19
        Me.GroupBoxDatosCliente.TabStop = False
        Me.GroupBoxDatosCliente.Text = "Categoría"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(92, 69)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 17)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Categoría: "
        '
        'BModificarCategoria
        '
        Me.BModificarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BModificarCategoria.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BModificarCategoria.FlatAppearance.BorderSize = 2
        Me.BModificarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModificarCategoria.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BModificarCategoria.ForeColor = System.Drawing.Color.White
        Me.BModificarCategoria.Location = New System.Drawing.Point(178, 225)
        Me.BModificarCategoria.Margin = New System.Windows.Forms.Padding(4)
        Me.BModificarCategoria.Name = "BModificarCategoria"
        Me.BModificarCategoria.Size = New System.Drawing.Size(97, 32)
        Me.BModificarCategoria.TabIndex = 13
        Me.BModificarCategoria.Text = "Modificar"
        Me.BModificarCategoria.UseVisualStyleBackColor = False
        '
        'TBModCategoria
        '
        Me.TBModCategoria.Location = New System.Drawing.Point(95, 98)
        Me.TBModCategoria.Name = "TBModCategoria"
        Me.TBModCategoria.Size = New System.Drawing.Size(167, 25)
        Me.TBModCategoria.TabIndex = 16
        '
        'ModificarCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(568, 379)
        Me.Controls.Add(Me.PanelModCategoria)
        Me.Name = "ModificarCategoria"
        Me.Text = "ModificarCategoria"
        Me.PanelModCategoria.ResumeLayout(False)
        Me.GroupBoxDatosCliente.ResumeLayout(False)
        Me.GroupBoxDatosCliente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelModCategoria As Panel
    Friend WithEvents BCancelarModifCliente As Button
    Friend WithEvents GroupBoxDatosCliente As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BModificarCategoria As Button
    Friend WithEvents TBModCategoria As TextBox
End Class
