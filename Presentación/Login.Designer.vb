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
        Me.PanelBarraMenuLogin = New System.Windows.Forms.Panel()
        Me.BMinimizarMenu = New System.Windows.Forms.Button()
        Me.BCerrarMenu = New System.Windows.Forms.Button()
        Me.BMaximizarMenu = New System.Windows.Forms.Button()
        Me.BRestaurarMenu = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LUsuario = New System.Windows.Forms.Label()
        Me.PictureBoxContraseña = New System.Windows.Forms.PictureBox()
        Me.BLogin = New System.Windows.Forms.Button()
        Me.TBContraseña = New System.Windows.Forms.TextBox()
        Me.TBUsuario = New System.Windows.Forms.TextBox()
        Me.LContraseña = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LTituloLogin = New System.Windows.Forms.Label()
        Me.PanelBarraMenuLogin.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBoxContraseña, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelBarraMenuLogin
        '
        Me.PanelBarraMenuLogin.BackColor = System.Drawing.Color.Goldenrod
        Me.PanelBarraMenuLogin.Controls.Add(Me.BMinimizarMenu)
        Me.PanelBarraMenuLogin.Controls.Add(Me.BCerrarMenu)
        Me.PanelBarraMenuLogin.Controls.Add(Me.BMaximizarMenu)
        Me.PanelBarraMenuLogin.Controls.Add(Me.BRestaurarMenu)
        Me.PanelBarraMenuLogin.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraMenuLogin.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraMenuLogin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelBarraMenuLogin.Name = "PanelBarraMenuLogin"
        Me.PanelBarraMenuLogin.Size = New System.Drawing.Size(1000, 94)
        Me.PanelBarraMenuLogin.TabIndex = 18
        '
        'BMinimizarMenu
        '
        Me.BMinimizarMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BMinimizarMenu.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.minimizar_blanco
        Me.BMinimizarMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BMinimizarMenu.FlatAppearance.BorderSize = 0
        Me.BMinimizarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BMinimizarMenu.Location = New System.Drawing.Point(877, 24)
        Me.BMinimizarMenu.Name = "BMinimizarMenu"
        Me.BMinimizarMenu.Size = New System.Drawing.Size(33, 31)
        Me.BMinimizarMenu.TabIndex = 5
        Me.BMinimizarMenu.UseVisualStyleBackColor = True
        '
        'BCerrarMenu
        '
        Me.BCerrarMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BCerrarMenu.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.cerrarventana
        Me.BCerrarMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BCerrarMenu.FlatAppearance.BorderSize = 0
        Me.BCerrarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCerrarMenu.Location = New System.Drawing.Point(955, 24)
        Me.BCerrarMenu.Name = "BCerrarMenu"
        Me.BCerrarMenu.Size = New System.Drawing.Size(33, 31)
        Me.BCerrarMenu.TabIndex = 4
        Me.BCerrarMenu.UseVisualStyleBackColor = True
        '
        'BMaximizarMenu
        '
        Me.BMaximizarMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BMaximizarMenu.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.maximizarBlanco
        Me.BMaximizarMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BMaximizarMenu.FlatAppearance.BorderSize = 0
        Me.BMaximizarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BMaximizarMenu.Location = New System.Drawing.Point(916, 24)
        Me.BMaximizarMenu.Name = "BMaximizarMenu"
        Me.BMaximizarMenu.Size = New System.Drawing.Size(33, 31)
        Me.BMaximizarMenu.TabIndex = 6
        Me.BMaximizarMenu.UseVisualStyleBackColor = True
        '
        'BRestaurarMenu
        '
        Me.BRestaurarMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BRestaurarMenu.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.restaurarventana
        Me.BRestaurarMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BRestaurarMenu.FlatAppearance.BorderSize = 0
        Me.BRestaurarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRestaurarMenu.Location = New System.Drawing.Point(916, 24)
        Me.BRestaurarMenu.Name = "BRestaurarMenu"
        Me.BRestaurarMenu.Size = New System.Drawing.Size(33, 31)
        Me.BRestaurarMenu.TabIndex = 7
        Me.BRestaurarMenu.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LUsuario)
        Me.Panel1.Controls.Add(Me.PictureBoxContraseña)
        Me.Panel1.Controls.Add(Me.BLogin)
        Me.Panel1.Controls.Add(Me.TBContraseña)
        Me.Panel1.Controls.Add(Me.TBUsuario)
        Me.Panel1.Controls.Add(Me.LContraseña)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.LTituloLogin)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 94)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 556)
        Me.Panel1.TabIndex = 19
        '
        'LUsuario
        '
        Me.LUsuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LUsuario.AutoSize = True
        Me.LUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.LUsuario.Font = New System.Drawing.Font("Cooper Black", 15.0!)
        Me.LUsuario.ForeColor = System.Drawing.Color.White
        Me.LUsuario.Location = New System.Drawing.Point(501, 223)
        Me.LUsuario.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LUsuario.Name = "LUsuario"
        Me.LUsuario.Size = New System.Drawing.Size(120, 29)
        Me.LUsuario.TabIndex = 16
        Me.LUsuario.Text = "Usuario:"
        '
        'PictureBoxContraseña
        '
        Me.PictureBoxContraseña.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBoxContraseña.BackColor = System.Drawing.Color.White
        Me.PictureBoxContraseña.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.ojo_cerrado
        Me.PictureBoxContraseña.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxContraseña.Location = New System.Drawing.Point(811, 299)
        Me.PictureBoxContraseña.Name = "PictureBoxContraseña"
        Me.PictureBoxContraseña.Size = New System.Drawing.Size(41, 29)
        Me.PictureBoxContraseña.TabIndex = 23
        Me.PictureBoxContraseña.TabStop = False
        Me.PictureBoxContraseña.Tag = ""
        '
        'BLogin
        '
        Me.BLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BLogin.FlatAppearance.BorderSize = 3
        Me.BLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BLogin.Font = New System.Drawing.Font("Cooper Black", 15.0!)
        Me.BLogin.ForeColor = System.Drawing.Color.White
        Me.BLogin.Location = New System.Drawing.Point(595, 402)
        Me.BLogin.Name = "BLogin"
        Me.BLogin.Size = New System.Drawing.Size(168, 61)
        Me.BLogin.TabIndex = 21
        Me.BLogin.Text = "Ingresar"
        Me.BLogin.UseVisualStyleBackColor = True
        '
        'TBContraseña
        '
        Me.TBContraseña.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBContraseña.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.TBContraseña.ForeColor = System.Drawing.Color.Black
        Me.TBContraseña.Location = New System.Drawing.Point(684, 296)
        Me.TBContraseña.Margin = New System.Windows.Forms.Padding(4)
        Me.TBContraseña.Name = "TBContraseña"
        Me.TBContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBContraseña.Size = New System.Drawing.Size(168, 35)
        Me.TBContraseña.TabIndex = 19
        '
        'TBUsuario
        '
        Me.TBUsuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TBUsuario.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!)
        Me.TBUsuario.Location = New System.Drawing.Point(686, 223)
        Me.TBUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.TBUsuario.Name = "TBUsuario"
        Me.TBUsuario.Size = New System.Drawing.Size(166, 35)
        Me.TBUsuario.TabIndex = 18
        '
        'LContraseña
        '
        Me.LContraseña.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LContraseña.AutoSize = True
        Me.LContraseña.Font = New System.Drawing.Font("Cooper Black", 15.0!)
        Me.LContraseña.ForeColor = System.Drawing.Color.White
        Me.LContraseña.Location = New System.Drawing.Point(501, 299)
        Me.LContraseña.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LContraseña.Name = "LContraseña"
        Me.LContraseña.Size = New System.Drawing.Size(165, 29)
        Me.LContraseña.TabIndex = 17
        Me.LContraseña.Text = "Contraseña:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.icon_user1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(153, 182)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(304, 281)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'LTituloLogin
        '
        Me.LTituloLogin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LTituloLogin.AutoSize = True
        Me.LTituloLogin.Font = New System.Drawing.Font("Britannic Bold", 28.0!)
        Me.LTituloLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LTituloLogin.Location = New System.Drawing.Point(148, 94)
        Me.LTituloLogin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LTituloLogin.Name = "LTituloLogin"
        Me.LTituloLogin.Size = New System.Drawing.Size(309, 52)
        Me.LTituloLogin.TabIndex = 22
        Me.LTituloLogin.Text = "Iniciar Sesion"
        Me.LTituloLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1000, 650)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelBarraMenuLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.PanelBarraMenuLogin.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBoxContraseña, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelBarraMenuLogin As Panel
    Friend WithEvents BMinimizarMenu As Button
    Friend WithEvents BCerrarMenu As Button
    Friend WithEvents BMaximizarMenu As Button
    Friend WithEvents BRestaurarMenu As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LUsuario As Label
    Friend WithEvents PictureBoxContraseña As PictureBox
    Friend WithEvents BLogin As Button
    Friend WithEvents TBContraseña As TextBox
    Friend WithEvents TBUsuario As TextBox
    Friend WithEvents LContraseña As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LTituloLogin As Label
End Class
