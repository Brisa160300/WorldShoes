<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cuenta
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
        Me.Buton = New System.Windows.Forms.Button()
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.TBContraseña = New System.Windows.Forms.TextBox()
        Me.TBUsuario = New System.Windows.Forms.TextBox()
        Me.LContraseña = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Buton
        '
        Me.Buton.FlatAppearance.BorderSize = 3
        Me.Buton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Buton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Buton.Font = New System.Drawing.Font("Cooper Black", 15.0!)
        Me.Buton.ForeColor = System.Drawing.Color.DarkRed
        Me.Buton.Location = New System.Drawing.Point(302, 200)
        Me.Buton.Name = "Buton"
        Me.Buton.Size = New System.Drawing.Size(168, 61)
        Me.Buton.TabIndex = 12
        Me.Buton.Text = "Ingresar"
        Me.Buton.UseVisualStyleBackColor = True
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.Font = New System.Drawing.Font("Cooper Black", 15.0!)
        Me.LUsuario.ForeColor = System.Drawing.Color.Maroon
        Me.LUsuario.Location = New System.Drawing.Point(86, 134)
        Me.LUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(120, 29)
        Me.LUsuario.TabIndex = 13
        Me.LUsuario.Text = "Usuario:"
        '
        'TBContraseña
        '
        Me.TBContraseña.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.TBContraseña.ForeColor = System.Drawing.Color.Black
        Me.TBContraseña.Location = New System.Drawing.Point(270, 61)
        Me.TBContraseña.Margin = New System.Windows.Forms.Padding(4)
        Me.TBContraseña.Name = "TBContraseña"
        Me.TBContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBContraseña.Size = New System.Drawing.Size(168, 35)
        Me.TBContraseña.TabIndex = 16
        '
        'TBUsuario
        '
        Me.TBUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.TBUsuario.Location = New System.Drawing.Point(270, 134)
        Me.TBUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.TBUsuario.Name = "TBUsuario"
        Me.TBUsuario.Size = New System.Drawing.Size(166, 35)
        Me.TBUsuario.TabIndex = 15
        '
        'LContraseña
        '
        Me.LContraseña.AutoSize = True
        Me.LContraseña.Font = New System.Drawing.Font("Cooper Black", 15.0!)
        Me.LContraseña.ForeColor = System.Drawing.Color.Maroon
        Me.LContraseña.Location = New System.Drawing.Point(86, 67)
        Me.LContraseña.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LContraseña.Name = "LContraseña"
        Me.LContraseña.Size = New System.Drawing.Size(165, 29)
        Me.LContraseña.TabIndex = 14
        Me.LContraseña.Text = "Contraseña:"
        '
        'Cuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LUsuario)
        Me.Controls.Add(Me.TBContraseña)
        Me.Controls.Add(Me.TBUsuario)
        Me.Controls.Add(Me.LContraseña)
        Me.Controls.Add(Me.Buton)
        Me.Name = "Cuenta"
        Me.Text = "Cuenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Buton As Button
    Friend WithEvents LUsuario As Label
    Friend WithEvents TBContraseña As TextBox
    Friend WithEvents TBUsuario As TextBox
    Friend WithEvents LContraseña As Label
End Class
