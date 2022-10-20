<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarMarca
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
        Me.PanelModMarca = New System.Windows.Forms.Panel()
        Me.BCancelarModifCliente = New System.Windows.Forms.Button()
        Me.GroupBoxDatosMarca = New System.Windows.Forms.GroupBox()
        Me.TBModMarca = New System.Windows.Forms.TextBox()
        Me.LModMarca = New System.Windows.Forms.Label()
        Me.BModificarMarca = New System.Windows.Forms.Button()
        Me.PanelModMarca.SuspendLayout()
        Me.GroupBoxDatosMarca.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelModMarca
        '
        Me.PanelModMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PanelModMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelModMarca.Controls.Add(Me.BCancelarModifCliente)
        Me.PanelModMarca.Controls.Add(Me.GroupBoxDatosMarca)
        Me.PanelModMarca.Controls.Add(Me.BModificarMarca)
        Me.PanelModMarca.Location = New System.Drawing.Point(81, 64)
        Me.PanelModMarca.Margin = New System.Windows.Forms.Padding(5)
        Me.PanelModMarca.Name = "PanelModMarca"
        Me.PanelModMarca.Size = New System.Drawing.Size(612, 372)
        Me.PanelModMarca.TabIndex = 5
        '
        'BCancelarModifCliente
        '
        Me.BCancelarModifCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BCancelarModifCliente.FlatAppearance.BorderSize = 2
        Me.BCancelarModifCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelarModifCliente.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BCancelarModifCliente.ForeColor = System.Drawing.Color.White
        Me.BCancelarModifCliente.Location = New System.Drawing.Point(454, 296)
        Me.BCancelarModifCliente.Margin = New System.Windows.Forms.Padding(5)
        Me.BCancelarModifCliente.Name = "BCancelarModifCliente"
        Me.BCancelarModifCliente.Size = New System.Drawing.Size(130, 52)
        Me.BCancelarModifCliente.TabIndex = 12
        Me.BCancelarModifCliente.Text = "Cancelar"
        Me.BCancelarModifCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelarModifCliente.UseVisualStyleBackColor = False
        '
        'GroupBoxDatosMarca
        '
        Me.GroupBoxDatosMarca.Controls.Add(Me.TBModMarca)
        Me.GroupBoxDatosMarca.Controls.Add(Me.LModMarca)
        Me.GroupBoxDatosMarca.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.GroupBoxDatosMarca.ForeColor = System.Drawing.Color.White
        Me.GroupBoxDatosMarca.Location = New System.Drawing.Point(51, 22)
        Me.GroupBoxDatosMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxDatosMarca.Name = "GroupBoxDatosMarca"
        Me.GroupBoxDatosMarca.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxDatosMarca.Size = New System.Drawing.Size(473, 246)
        Me.GroupBoxDatosMarca.TabIndex = 19
        Me.GroupBoxDatosMarca.TabStop = False
        Me.GroupBoxDatosMarca.Text = "Modificar Marca"
        '
        'TBModMarca
        '
        Me.TBModMarca.Location = New System.Drawing.Point(127, 121)
        Me.TBModMarca.Margin = New System.Windows.Forms.Padding(4)
        Me.TBModMarca.Name = "TBModMarca"
        Me.TBModMarca.Size = New System.Drawing.Size(221, 30)
        Me.TBModMarca.TabIndex = 16
        '
        'LModMarca
        '
        Me.LModMarca.AutoSize = True
        Me.LModMarca.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LModMarca.ForeColor = System.Drawing.Color.White
        Me.LModMarca.Location = New System.Drawing.Point(123, 85)
        Me.LModMarca.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.LModMarca.Name = "LModMarca"
        Me.LModMarca.Size = New System.Drawing.Size(78, 22)
        Me.LModMarca.TabIndex = 15
        Me.LModMarca.Text = "Marca: "
        '
        'BModificarMarca
        '
        Me.BModificarMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BModificarMarca.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BModificarMarca.FlatAppearance.BorderSize = 2
        Me.BModificarMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModificarMarca.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BModificarMarca.ForeColor = System.Drawing.Color.White
        Me.BModificarMarca.Location = New System.Drawing.Point(315, 296)
        Me.BModificarMarca.Margin = New System.Windows.Forms.Padding(5)
        Me.BModificarMarca.Name = "BModificarMarca"
        Me.BModificarMarca.Size = New System.Drawing.Size(130, 52)
        Me.BModificarMarca.TabIndex = 13
        Me.BModificarMarca.Text = "Modificar"
        Me.BModificarMarca.UseVisualStyleBackColor = False
        '
        'ModificarMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(775, 500)
        Me.Controls.Add(Me.PanelModMarca)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModificarMarca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModificarMarca"
        Me.PanelModMarca.ResumeLayout(False)
        Me.GroupBoxDatosMarca.ResumeLayout(False)
        Me.GroupBoxDatosMarca.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelModMarca As Panel
    Friend WithEvents BCancelarModifCliente As Button
    Friend WithEvents GroupBoxDatosMarca As GroupBox
    Friend WithEvents TBModMarca As TextBox
    Friend WithEvents LModMarca As Label
    Friend WithEvents BModificarMarca As Button
End Class
