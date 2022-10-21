<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarPerfiles
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
        Me.GroupBoxDatosPerfil = New System.Windows.Forms.GroupBox()
        Me.TBModPerfil = New System.Windows.Forms.TextBox()
        Me.LModPerfil = New System.Windows.Forms.Label()
        Me.BModificarPerfil = New System.Windows.Forms.Button()
        Me.PanelModMarca.SuspendLayout()
        Me.GroupBoxDatosPerfil.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelModMarca
        '
        Me.PanelModMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PanelModMarca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelModMarca.Controls.Add(Me.BCancelarModifCliente)
        Me.PanelModMarca.Controls.Add(Me.GroupBoxDatosPerfil)
        Me.PanelModMarca.Controls.Add(Me.BModificarPerfil)
        Me.PanelModMarca.Location = New System.Drawing.Point(81, 64)
        Me.PanelModMarca.Margin = New System.Windows.Forms.Padding(5)
        Me.PanelModMarca.Name = "PanelModMarca"
        Me.PanelModMarca.Size = New System.Drawing.Size(612, 372)
        Me.PanelModMarca.TabIndex = 6
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
        'GroupBoxDatosPerfil
        '
        Me.GroupBoxDatosPerfil.Controls.Add(Me.TBModPerfil)
        Me.GroupBoxDatosPerfil.Controls.Add(Me.LModPerfil)
        Me.GroupBoxDatosPerfil.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.GroupBoxDatosPerfil.ForeColor = System.Drawing.Color.White
        Me.GroupBoxDatosPerfil.Location = New System.Drawing.Point(51, 22)
        Me.GroupBoxDatosPerfil.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxDatosPerfil.Name = "GroupBoxDatosPerfil"
        Me.GroupBoxDatosPerfil.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxDatosPerfil.Size = New System.Drawing.Size(473, 246)
        Me.GroupBoxDatosPerfil.TabIndex = 19
        Me.GroupBoxDatosPerfil.TabStop = False
        Me.GroupBoxDatosPerfil.Text = "Modificar Perfil"
        '
        'TBModPerfil
        '
        Me.TBModPerfil.Location = New System.Drawing.Point(127, 121)
        Me.TBModPerfil.Margin = New System.Windows.Forms.Padding(4)
        Me.TBModPerfil.Name = "TBModPerfil"
        Me.TBModPerfil.Size = New System.Drawing.Size(221, 30)
        Me.TBModPerfil.TabIndex = 16
        '
        'LModPerfil
        '
        Me.LModPerfil.AutoSize = True
        Me.LModPerfil.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LModPerfil.ForeColor = System.Drawing.Color.White
        Me.LModPerfil.Location = New System.Drawing.Point(123, 85)
        Me.LModPerfil.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.LModPerfil.Name = "LModPerfil"
        Me.LModPerfil.Size = New System.Drawing.Size(70, 22)
        Me.LModPerfil.TabIndex = 15
        Me.LModPerfil.Text = "Perfil: "
        '
        'BModificarPerfil
        '
        Me.BModificarPerfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BModificarPerfil.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BModificarPerfil.FlatAppearance.BorderSize = 2
        Me.BModificarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModificarPerfil.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BModificarPerfil.ForeColor = System.Drawing.Color.White
        Me.BModificarPerfil.Location = New System.Drawing.Point(315, 296)
        Me.BModificarPerfil.Margin = New System.Windows.Forms.Padding(5)
        Me.BModificarPerfil.Name = "BModificarPerfil"
        Me.BModificarPerfil.Size = New System.Drawing.Size(130, 52)
        Me.BModificarPerfil.TabIndex = 13
        Me.BModificarPerfil.Text = "Modificar"
        Me.BModificarPerfil.UseVisualStyleBackColor = False
        '
        'ModificarPerfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(775, 500)
        Me.Controls.Add(Me.PanelModMarca)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModificarPerfiles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ModificarPerfiles"
        Me.PanelModMarca.ResumeLayout(False)
        Me.GroupBoxDatosPerfil.ResumeLayout(False)
        Me.GroupBoxDatosPerfil.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelModMarca As Panel
    Friend WithEvents BCancelarModifCliente As Button
    Friend WithEvents GroupBoxDatosPerfil As GroupBox
    Friend WithEvents TBModPerfil As TextBox
    Friend WithEvents LModPerfil As Label
    Friend WithEvents BModificarPerfil As Button
End Class
