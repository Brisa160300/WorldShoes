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
        Me.BLogin = New System.Windows.Forms.Button()
        Me.LTituloLogin = New System.Windows.Forms.Label()
        Me.PanelBarraMenuLogin = New System.Windows.Forms.Panel()
        Me.IconMaximizar = New FontAwesome.Sharp.IconButton()
        Me.IconMinimizarLogin = New FontAwesome.Sharp.IconButton()
        Me.IconCerrarLogin = New FontAwesome.Sharp.IconButton()
        Me.IconRestaurarWin = New FontAwesome.Sharp.IconButton()
        Me.PanelContenedorLogin = New System.Windows.Forms.Panel()
        Me.PictureBoxContraseña = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelBarraMenuLogin.SuspendLayout()
        Me.PanelContenedorLogin.SuspendLayout()
        CType(Me.PictureBoxContraseña, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LUsuario
        '
        Me.LUsuario.AutoSize = True
        Me.LUsuario.Font = New System.Drawing.Font("Cooper Black", 15.0!)
        Me.LUsuario.ForeColor = System.Drawing.Color.White
        Me.LUsuario.Location = New System.Drawing.Point(481, 272)
        Me.LUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(120, 29)
        Me.LUsuario.TabIndex = 1
        Me.LUsuario.Text = "Usuario:"
        '
        'LContraseña
        '
        Me.LContraseña.AutoSize = True
        Me.LContraseña.Font = New System.Drawing.Font("Cooper Black", 15.0!)
        Me.LContraseña.ForeColor = System.Drawing.Color.White
        Me.LContraseña.Location = New System.Drawing.Point(481, 258)
        Me.LContraseña.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LContraseña.Name = "LContraseña"
        Me.LContraseña.Size = New System.Drawing.Size(165, 29)
        Me.LContraseña.TabIndex = 2
        Me.LContraseña.Text = "Contraseña:"
        '
        'TBUsuario
        '
        Me.TBUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.TBUsuario.Location = New System.Drawing.Point(705, 180)
        Me.TBUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.TBUsuario.Name = "TBUsuario"
        Me.TBUsuario.Size = New System.Drawing.Size(166, 35)
        Me.TBUsuario.TabIndex = 7
        '
        'TBContraseña
        '
        Me.TBContraseña.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.TBContraseña.ForeColor = System.Drawing.Color.Black
        Me.TBContraseña.Location = New System.Drawing.Point(705, 257)
        Me.TBContraseña.Margin = New System.Windows.Forms.Padding(4)
        Me.TBContraseña.Name = "TBContraseña"
        Me.TBContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBContraseña.Size = New System.Drawing.Size(168, 35)
        Me.TBContraseña.TabIndex = 8
        '
        'BLogin
        '
        Me.BLogin.FlatAppearance.BorderSize = 3
        Me.BLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLogin.Font = New System.Drawing.Font("Cooper Black", 15.0!)
        Me.BLogin.ForeColor = System.Drawing.Color.White
        Me.BLogin.Location = New System.Drawing.Point(583, 341)
        Me.BLogin.Name = "BLogin"
        Me.BLogin.Size = New System.Drawing.Size(168, 61)
        Me.BLogin.TabIndex = 11
        Me.BLogin.Text = "Ingresar"
        Me.BLogin.UseVisualStyleBackColor = True
        '
        'LTituloLogin
        '
        Me.LTituloLogin.AutoSize = True
        Me.LTituloLogin.Font = New System.Drawing.Font("Cooper Black", 25.0!)
        Me.LTituloLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LTituloLogin.Location = New System.Drawing.Point(114, 35)
        Me.LTituloLogin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LTituloLogin.Name = "LTituloLogin"
        Me.LTituloLogin.Size = New System.Drawing.Size(313, 49)
        Me.LTituloLogin.TabIndex = 12
        Me.LTituloLogin.Text = "Iniciar Sesion"
        Me.LTituloLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PanelBarraMenuLogin
        '
        Me.PanelBarraMenuLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.PanelBarraMenuLogin.Controls.Add(Me.IconMaximizar)
        Me.PanelBarraMenuLogin.Controls.Add(Me.IconMinimizarLogin)
        Me.PanelBarraMenuLogin.Controls.Add(Me.IconCerrarLogin)
        Me.PanelBarraMenuLogin.Controls.Add(Me.IconRestaurarWin)
        Me.PanelBarraMenuLogin.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraMenuLogin.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraMenuLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelBarraMenuLogin.Name = "PanelBarraMenuLogin"
        Me.PanelBarraMenuLogin.Size = New System.Drawing.Size(1076, 94)
        Me.PanelBarraMenuLogin.TabIndex = 14
        '
        'IconMaximizar
        '
        Me.IconMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconMaximizar.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.maximizarBlanco
        Me.IconMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IconMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconMaximizar.FlatAppearance.BorderSize = 0
        Me.IconMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconMaximizar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconMaximizar.IconColor = System.Drawing.Color.Black
        Me.IconMaximizar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconMaximizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconMaximizar.Location = New System.Drawing.Point(984, 14)
        Me.IconMaximizar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconMaximizar.Name = "IconMaximizar"
        Me.IconMaximizar.Size = New System.Drawing.Size(33, 31)
        Me.IconMaximizar.TabIndex = 2
        Me.IconMaximizar.UseVisualStyleBackColor = True
        '
        'IconMinimizarLogin
        '
        Me.IconMinimizarLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconMinimizarLogin.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.minimizar_blanco
        Me.IconMinimizarLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IconMinimizarLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconMinimizarLogin.FlatAppearance.BorderSize = 0
        Me.IconMinimizarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconMinimizarLogin.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconMinimizarLogin.IconColor = System.Drawing.Color.Black
        Me.IconMinimizarLogin.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconMinimizarLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconMinimizarLogin.Location = New System.Drawing.Point(945, 14)
        Me.IconMinimizarLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconMinimizarLogin.Name = "IconMinimizarLogin"
        Me.IconMinimizarLogin.Size = New System.Drawing.Size(33, 31)
        Me.IconMinimizarLogin.TabIndex = 1
        Me.IconMinimizarLogin.UseVisualStyleBackColor = True
        '
        'IconCerrarLogin
        '
        Me.IconCerrarLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconCerrarLogin.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.cerrarventana
        Me.IconCerrarLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IconCerrarLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconCerrarLogin.FlatAppearance.BorderSize = 0
        Me.IconCerrarLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconCerrarLogin.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconCerrarLogin.IconColor = System.Drawing.Color.Black
        Me.IconCerrarLogin.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCerrarLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconCerrarLogin.Location = New System.Drawing.Point(1023, 14)
        Me.IconCerrarLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconCerrarLogin.Name = "IconCerrarLogin"
        Me.IconCerrarLogin.Size = New System.Drawing.Size(33, 31)
        Me.IconCerrarLogin.TabIndex = 0
        Me.IconCerrarLogin.UseVisualStyleBackColor = True
        '
        'IconRestaurarWin
        '
        Me.IconRestaurarWin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IconRestaurarWin.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.restaurarventana
        Me.IconRestaurarWin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IconRestaurarWin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IconRestaurarWin.FlatAppearance.BorderSize = 0
        Me.IconRestaurarWin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconRestaurarWin.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconRestaurarWin.IconColor = System.Drawing.Color.Black
        Me.IconRestaurarWin.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconRestaurarWin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IconRestaurarWin.Location = New System.Drawing.Point(984, 14)
        Me.IconRestaurarWin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.IconRestaurarWin.Name = "IconRestaurarWin"
        Me.IconRestaurarWin.Size = New System.Drawing.Size(33, 31)
        Me.IconRestaurarWin.TabIndex = 3
        Me.IconRestaurarWin.UseVisualStyleBackColor = True
        '
        'PanelContenedorLogin
        '
        Me.PanelContenedorLogin.Controls.Add(Me.PictureBoxContraseña)
        Me.PanelContenedorLogin.Controls.Add(Me.BLogin)
        Me.PanelContenedorLogin.Controls.Add(Me.TBContraseña)
        Me.PanelContenedorLogin.Controls.Add(Me.TBUsuario)
        Me.PanelContenedorLogin.Controls.Add(Me.LContraseña)
        Me.PanelContenedorLogin.Controls.Add(Me.PictureBox1)
        Me.PanelContenedorLogin.Controls.Add(Me.LTituloLogin)
        Me.PanelContenedorLogin.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelContenedorLogin.Location = New System.Drawing.Point(0, 93)
        Me.PanelContenedorLogin.Name = "PanelContenedorLogin"
        Me.PanelContenedorLogin.Size = New System.Drawing.Size(1076, 557)
        Me.PanelContenedorLogin.TabIndex = 15
        '
        'PictureBoxContraseña
        '
        Me.PictureBoxContraseña.BackColor = System.Drawing.Color.White
        Me.PictureBoxContraseña.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.ojo_cerrado
        Me.PictureBoxContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxContraseña.Location = New System.Drawing.Point(833, 262)
        Me.PictureBoxContraseña.Name = "PictureBoxContraseña"
        Me.PictureBoxContraseña.Size = New System.Drawing.Size(40, 30)
        Me.PictureBoxContraseña.TabIndex = 15
        Me.PictureBoxContraseña.TabStop = False
        Me.PictureBoxContraseña.Tag = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.icon_user1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(100, 121)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(304, 281)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1076, 650)
        Me.Controls.Add(Me.PanelBarraMenuLogin)
        Me.Controls.Add(Me.LUsuario)
        Me.Controls.Add(Me.PanelContenedorLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.PanelBarraMenuLogin.ResumeLayout(False)
        Me.PanelContenedorLogin.ResumeLayout(False)
        Me.PanelContenedorLogin.PerformLayout()
        CType(Me.PictureBoxContraseña, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PanelBarraMenuLogin As Panel
    Friend WithEvents IconMaximizar As FontAwesome.Sharp.IconButton
    Friend WithEvents IconMinimizarLogin As FontAwesome.Sharp.IconButton
    Friend WithEvents IconCerrarLogin As FontAwesome.Sharp.IconButton
    Friend WithEvents IconRestaurarWin As FontAwesome.Sharp.IconButton
    Friend WithEvents PanelContenedorLogin As Panel
    Friend WithEvents PictureBoxContraseña As PictureBox
End Class
