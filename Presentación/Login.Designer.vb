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
        Me.PanelBarraMenuLogin = New System.Windows.Forms.Panel()
        Me.IconMinimizarLogin = New FontAwesome.Sharp.IconButton()
        Me.IconCerrarLogin = New FontAwesome.Sharp.IconButton()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBarraMenuLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LUsuario.ForeColor = System.Drawing.Color.White
        Me.LUsuario.Location = New System.Drawing.Point(747, 229)
        Me.LUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(92, 25)
        Me.LUsuario.TabIndex = 1
        Me.LUsuario.Text = "Usuario:"
        '
        'LContraseña
        '
        Me.LContraseña.AutoSize = True
        Me.LContraseña.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LContraseña.ForeColor = System.Drawing.Color.White
        Me.LContraseña.Location = New System.Drawing.Point(747, 320)
        Me.LContraseña.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LContraseña.Name = "LContraseña"
        Me.LContraseña.Size = New System.Drawing.Size(128, 25)
        Me.LContraseña.TabIndex = 2
        Me.LContraseña.Text = "Contraseña:"
        '
        'TBUsuario
        '
        Me.TBUsuario.Location = New System.Drawing.Point(972, 231)
        Me.TBUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.TBUsuario.Name = "TBUsuario"
        Me.TBUsuario.Size = New System.Drawing.Size(166, 22)
        Me.TBUsuario.TabIndex = 7
        '
        'TBContraseña
        '
        Me.TBContraseña.ForeColor = System.Drawing.Color.Transparent
        Me.TBContraseña.Location = New System.Drawing.Point(972, 322)
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
        Me.PictureBox1.Location = New System.Drawing.Point(289, 179)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(294, 281)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'BLogin
        '
        Me.BLogin.FlatAppearance.BorderSize = 3
        Me.BLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLogin.Font = New System.Drawing.Font("Britannic Bold", 15.5!)
        Me.BLogin.ForeColor = System.Drawing.Color.White
        Me.BLogin.Location = New System.Drawing.Point(847, 438)
        Me.BLogin.Name = "BLogin"
        Me.BLogin.Size = New System.Drawing.Size(168, 61)
        Me.BLogin.TabIndex = 11
        Me.BLogin.Text = "Ingresar"
        Me.BLogin.UseVisualStyleBackColor = True
        '
        'LTituloLogin
        '
        Me.LTituloLogin.AutoSize = True
        Me.LTituloLogin.Font = New System.Drawing.Font("Britannic Bold", 25.0!)
        Me.LTituloLogin.ForeColor = System.Drawing.Color.White
        Me.LTituloLogin.Location = New System.Drawing.Point(281, 89)
        Me.LTituloLogin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LTituloLogin.Name = "LTituloLogin"
        Me.LTituloLogin.Size = New System.Drawing.Size(277, 47)
        Me.LTituloLogin.TabIndex = 12
        Me.LTituloLogin.Text = "Iniciar Sesion"
        '
        'PanelBarraMenuLogin
        '
        Me.PanelBarraMenuLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.PanelBarraMenuLogin.Controls.Add(Me.IconMinimizarLogin)
        Me.PanelBarraMenuLogin.Controls.Add(Me.IconCerrarLogin)
        Me.PanelBarraMenuLogin.Location = New System.Drawing.Point(-1, 0)
        Me.PanelBarraMenuLogin.Name = "PanelBarraMenuLogin"
        Me.PanelBarraMenuLogin.Size = New System.Drawing.Size(1300, 45)
        Me.PanelBarraMenuLogin.TabIndex = 15
        '
        'IconMinimizarLogin
        '
        Me.IconMinimizarLogin.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.pngaaa_com_4979905
        Me.IconMinimizarLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IconMinimizarLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconMinimizarLogin.FlatAppearance.BorderSize = 0
        Me.IconMinimizarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconMinimizarLogin.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconMinimizarLogin.IconColor = System.Drawing.Color.Black
        Me.IconMinimizarLogin.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconMinimizarLogin.Location = New System.Drawing.Point(1213, 7)
        Me.IconMinimizarLogin.Name = "IconMinimizarLogin"
        Me.IconMinimizarLogin.Size = New System.Drawing.Size(35, 35)
        Me.IconMinimizarLogin.TabIndex = 1
        Me.IconMinimizarLogin.UseVisualStyleBackColor = True
        '
        'IconCerrarLogin
        '
        Me.IconCerrarLogin.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_cancelar_501
        Me.IconCerrarLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IconCerrarLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconCerrarLogin.FlatAppearance.BorderSize = 0
        Me.IconCerrarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconCerrarLogin.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconCerrarLogin.IconColor = System.Drawing.Color.Black
        Me.IconCerrarLogin.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCerrarLogin.Location = New System.Drawing.Point(1254, 7)
        Me.IconCerrarLogin.Name = "IconCerrarLogin"
        Me.IconCerrarLogin.Size = New System.Drawing.Size(35, 35)
        Me.IconCerrarLogin.TabIndex = 0
        Me.IconCerrarLogin.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1300, 650)
        Me.Controls.Add(Me.PanelBarraMenuLogin)
        Me.Controls.Add(Me.LTituloLogin)
        Me.Controls.Add(Me.BLogin)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TBContraseña)
        Me.Controls.Add(Me.TBUsuario)
        Me.Controls.Add(Me.LContraseña)
        Me.Controls.Add(Me.LUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBarraMenuLogin.ResumeLayout(False)
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
    Friend WithEvents PanelBarraMenuLogin As Panel
    Friend WithEvents IconMinimizarLogin As FontAwesome.Sharp.IconButton
    Friend WithEvents IconCerrarLogin As FontAwesome.Sharp.IconButton
End Class
