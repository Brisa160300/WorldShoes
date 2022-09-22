<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.LContraseña = New System.Windows.Forms.Label()
        Me.TBUsuario = New System.Windows.Forms.TextBox()
        Me.TBContraseña = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BLogin = New System.Windows.Forms.Button()
        Me.LTituloLogin = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUsuario.ForeColor = System.Drawing.Color.White
        Me.LUsuario.Location = New System.Drawing.Point(533, 176)
        Me.LUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(90, 22)
        Me.LUsuario.TabIndex = 1
        Me.LUsuario.Text = "Usuario:"
        '
        'LContraseña
        '
        Me.LContraseña.AutoSize = True
        Me.LContraseña.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LContraseña.ForeColor = System.Drawing.Color.White
        Me.LContraseña.Location = New System.Drawing.Point(533, 256)
        Me.LContraseña.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LContraseña.Name = "LContraseña"
        Me.LContraseña.Size = New System.Drawing.Size(126, 22)
        Me.LContraseña.TabIndex = 2
        Me.LContraseña.Text = "Contraseña:"
        '
        'TBUsuario
        '
        Me.TBUsuario.Location = New System.Drawing.Point(696, 176)
        Me.TBUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.TBUsuario.Name = "TBUsuario"
        Me.TBUsuario.Size = New System.Drawing.Size(166, 22)
        Me.TBUsuario.TabIndex = 7
        '
        'TBContraseña
        '
        Me.TBContraseña.ForeColor = System.Drawing.Color.Transparent
        Me.TBContraseña.Location = New System.Drawing.Point(696, 256)
        Me.TBContraseña.Margin = New System.Windows.Forms.Padding(4)
        Me.TBContraseña.Name = "TBContraseña"
        Me.TBContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBContraseña.Size = New System.Drawing.Size(168, 22)
        Me.TBContraseña.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.icon_user1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(128, 136)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(294, 281)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'BLogin
        '
        Me.BLogin.Font = New System.Drawing.Font("MS Reference Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLogin.Location = New System.Drawing.Point(599, 331)
        Me.BLogin.Name = "BLogin"
        Me.BLogin.Size = New System.Drawing.Size(168, 61)
        Me.BLogin.TabIndex = 11
        Me.BLogin.Text = "Iniciar Sesion"
        Me.BLogin.UseVisualStyleBackColor = True
        '
        'LTituloLogin
        '
        Me.LTituloLogin.AutoSize = True
        Me.LTituloLogin.Font = New System.Drawing.Font("MS Reference Sans Serif", 18.5!, System.Drawing.FontStyle.Bold)
        Me.LTituloLogin.ForeColor = System.Drawing.Color.White
        Me.LTituloLogin.Location = New System.Drawing.Point(145, 51)
        Me.LTituloLogin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LTituloLogin.Name = "LTituloLogin"
        Me.LTituloLogin.Size = New System.Drawing.Size(259, 39)
        Me.LTituloLogin.TabIndex = 12
        Me.LTituloLogin.Text = "Iniciar Sesion:"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.LTituloLogin)
        Me.Controls.Add(Me.BLogin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TBContraseña)
        Me.Controls.Add(Me.TBUsuario)
        Me.Controls.Add(Me.LContraseña)
        Me.Controls.Add(Me.LUsuario)
        Me.KeyPreview = True
        Me.Name = "Login"
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LUsuario As Label
    Friend WithEvents LContraseña As Label
    Friend WithEvents TBUsuario As TextBox
    Friend WithEvents TBContraseña As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BLogin As Button
    Friend WithEvents LTituloLogin As Label
End Class
