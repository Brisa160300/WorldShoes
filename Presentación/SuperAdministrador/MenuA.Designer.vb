<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MenuA
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
        Me.PanelMenuLateral = New System.Windows.Forms.Panel()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.PanelSubMenuUsuarios = New System.Windows.Forms.Panel()
        Me.BGestionarUsuarios = New System.Windows.Forms.Button()
        Me.BAñadirUsuario = New System.Windows.Forms.Button()
        Me.BUsuarios = New System.Windows.Forms.Button()
        Me.PanelIconMenuGerente = New System.Windows.Forms.Panel()
        Me.LIconMenuAdmin = New System.Windows.Forms.Label()
        Me.PanelFormAdmnistrador = New System.Windows.Forms.Panel()
        Me.PanelBarraMenuAdmin = New System.Windows.Forms.Panel()
        Me.BMaximizarMenuGerente = New System.Windows.Forms.Button()
        Me.BMinimizarMenuGerente = New System.Windows.Forms.Button()
        Me.BCerrarMenuGerente = New System.Windows.Forms.Button()
        Me.BRestaurarMenuGerente = New System.Windows.Forms.Button()
        Me.PanelMenuLateral.SuspendLayout()
        Me.PanelSubMenuUsuarios.SuspendLayout()
        Me.PanelIconMenuGerente.SuspendLayout()
        Me.PanelBarraMenuAdmin.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenuLateral
        '
        Me.PanelMenuLateral.AutoScroll = True
        Me.PanelMenuLateral.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelMenuLateral.Controls.Add(Me.BSalir)
        Me.PanelMenuLateral.Controls.Add(Me.PanelSubMenuUsuarios)
        Me.PanelMenuLateral.Controls.Add(Me.BUsuarios)
        Me.PanelMenuLateral.Controls.Add(Me.PanelIconMenuGerente)
        Me.PanelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenuLateral.Location = New System.Drawing.Point(0, 118)
        Me.PanelMenuLateral.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelMenuLateral.Name = "PanelMenuLateral"
        Me.PanelMenuLateral.Size = New System.Drawing.Size(250, 632)
        Me.PanelMenuLateral.TabIndex = 19
        '
        'BSalir
        '
        Me.BSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BSalir.FlatAppearance.BorderSize = 0
        Me.BSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BSalir.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BSalir.ForeColor = System.Drawing.Color.White
        Me.BSalir.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_cierre_de_sesión_redondeado_hacia_la_izquierda_50
        Me.BSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BSalir.Location = New System.Drawing.Point(0, 538)
        Me.BSalir.Margin = New System.Windows.Forms.Padding(4)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.BSalir.Size = New System.Drawing.Size(250, 94)
        Me.BSalir.TabIndex = 14
        Me.BSalir.Text = "Cerrar Sesión"
        Me.BSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BSalir.UseVisualStyleBackColor = False
        '
        'PanelSubMenuUsuarios
        '
        Me.PanelSubMenuUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelSubMenuUsuarios.Controls.Add(Me.BGestionarUsuarios)
        Me.PanelSubMenuUsuarios.Controls.Add(Me.BAñadirUsuario)
        Me.PanelSubMenuUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuUsuarios.ForeColor = System.Drawing.Color.Gainsboro
        Me.PanelSubMenuUsuarios.Location = New System.Drawing.Point(0, 264)
        Me.PanelSubMenuUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelSubMenuUsuarios.Name = "PanelSubMenuUsuarios"
        Me.PanelSubMenuUsuarios.Size = New System.Drawing.Size(250, 120)
        Me.PanelSubMenuUsuarios.TabIndex = 9
        '
        'BGestionarUsuarios
        '
        Me.BGestionarUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BGestionarUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.BGestionarUsuarios.FlatAppearance.BorderSize = 0
        Me.BGestionarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BGestionarUsuarios.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BGestionarUsuarios.ForeColor = System.Drawing.Color.Gainsboro
        Me.BGestionarUsuarios.Location = New System.Drawing.Point(0, 60)
        Me.BGestionarUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.BGestionarUsuarios.Name = "BGestionarUsuarios"
        Me.BGestionarUsuarios.Padding = New System.Windows.Forms.Padding(44, 0, 0, 0)
        Me.BGestionarUsuarios.Size = New System.Drawing.Size(250, 60)
        Me.BGestionarUsuarios.TabIndex = 1
        Me.BGestionarUsuarios.Text = "Listar Usuarios"
        Me.BGestionarUsuarios.UseVisualStyleBackColor = False
        '
        'BAñadirUsuario
        '
        Me.BAñadirUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BAñadirUsuario.Dock = System.Windows.Forms.DockStyle.Top
        Me.BAñadirUsuario.FlatAppearance.BorderSize = 0
        Me.BAñadirUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAñadirUsuario.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BAñadirUsuario.ForeColor = System.Drawing.Color.Gainsboro
        Me.BAñadirUsuario.Location = New System.Drawing.Point(0, 0)
        Me.BAñadirUsuario.Margin = New System.Windows.Forms.Padding(4)
        Me.BAñadirUsuario.Name = "BAñadirUsuario"
        Me.BAñadirUsuario.Padding = New System.Windows.Forms.Padding(44, 0, 0, 0)
        Me.BAñadirUsuario.Size = New System.Drawing.Size(250, 60)
        Me.BAñadirUsuario.TabIndex = 0
        Me.BAñadirUsuario.Text = "Nuevo Usuario"
        Me.BAñadirUsuario.UseVisualStyleBackColor = False
        '
        'BUsuarios
        '
        Me.BUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.BUsuarios.FlatAppearance.BorderSize = 0
        Me.BUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BUsuarios.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BUsuarios.ForeColor = System.Drawing.Color.White
        Me.BUsuarios.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.user_32
        Me.BUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BUsuarios.Location = New System.Drawing.Point(0, 170)
        Me.BUsuarios.Margin = New System.Windows.Forms.Padding(4)
        Me.BUsuarios.Name = "BUsuarios"
        Me.BUsuarios.Padding = New System.Windows.Forms.Padding(6, 0, 0, 0)
        Me.BUsuarios.Size = New System.Drawing.Size(250, 94)
        Me.BUsuarios.TabIndex = 10
        Me.BUsuarios.Text = "Usuarios"
        Me.BUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BUsuarios.UseVisualStyleBackColor = False
        '
        'PanelIconMenuGerente
        '
        Me.PanelIconMenuGerente.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelIconMenuGerente.Controls.Add(Me.LIconMenuAdmin)
        Me.PanelIconMenuGerente.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelIconMenuGerente.Location = New System.Drawing.Point(0, 0)
        Me.PanelIconMenuGerente.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelIconMenuGerente.Name = "PanelIconMenuGerente"
        Me.PanelIconMenuGerente.Size = New System.Drawing.Size(250, 170)
        Me.PanelIconMenuGerente.TabIndex = 0
        '
        'LIconMenuAdmin
        '
        Me.LIconMenuAdmin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LIconMenuAdmin.AutoSize = True
        Me.LIconMenuAdmin.Font = New System.Drawing.Font("Cooper Black", 18.0!)
        Me.LIconMenuAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LIconMenuAdmin.Location = New System.Drawing.Point(40, 69)
        Me.LIconMenuAdmin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LIconMenuAdmin.Name = "LIconMenuAdmin"
        Me.LIconMenuAdmin.Size = New System.Drawing.Size(198, 35)
        Me.LIconMenuAdmin.TabIndex = 0
        Me.LIconMenuAdmin.Text = "WorldShoes"
        Me.LIconMenuAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelFormAdmnistrador
        '
        Me.PanelFormAdmnistrador.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelFormAdmnistrador.AutoScroll = True
        Me.PanelFormAdmnistrador.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelFormAdmnistrador.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.logoWorldShoes_removebg_preview
        Me.PanelFormAdmnistrador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PanelFormAdmnistrador.Location = New System.Drawing.Point(250, 118)
        Me.PanelFormAdmnistrador.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelFormAdmnistrador.Name = "PanelFormAdmnistrador"
        Me.PanelFormAdmnistrador.Size = New System.Drawing.Size(1150, 632)
        Me.PanelFormAdmnistrador.TabIndex = 20
        '
        'PanelBarraMenuAdmin
        '
        Me.PanelBarraMenuAdmin.BackColor = System.Drawing.Color.Goldenrod
        Me.PanelBarraMenuAdmin.Controls.Add(Me.BMaximizarMenuGerente)
        Me.PanelBarraMenuAdmin.Controls.Add(Me.BMinimizarMenuGerente)
        Me.PanelBarraMenuAdmin.Controls.Add(Me.BCerrarMenuGerente)
        Me.PanelBarraMenuAdmin.Controls.Add(Me.BRestaurarMenuGerente)
        Me.PanelBarraMenuAdmin.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraMenuAdmin.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraMenuAdmin.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.PanelBarraMenuAdmin.Name = "PanelBarraMenuAdmin"
        Me.PanelBarraMenuAdmin.Size = New System.Drawing.Size(1400, 118)
        Me.PanelBarraMenuAdmin.TabIndex = 21
        '
        'BMaximizarMenuGerente
        '
        Me.BMaximizarMenuGerente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BMaximizarMenuGerente.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.maximizarBlanco
        Me.BMaximizarMenuGerente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BMaximizarMenuGerente.FlatAppearance.BorderSize = 0
        Me.BMaximizarMenuGerente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BMaximizarMenuGerente.Location = New System.Drawing.Point(1295, 30)
        Me.BMaximizarMenuGerente.Margin = New System.Windows.Forms.Padding(4)
        Me.BMaximizarMenuGerente.Name = "BMaximizarMenuGerente"
        Me.BMaximizarMenuGerente.Size = New System.Drawing.Size(41, 39)
        Me.BMaximizarMenuGerente.TabIndex = 6
        Me.BMaximizarMenuGerente.UseVisualStyleBackColor = True
        '
        'BMinimizarMenuGerente
        '
        Me.BMinimizarMenuGerente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BMinimizarMenuGerente.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.minimizar_blanco
        Me.BMinimizarMenuGerente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BMinimizarMenuGerente.FlatAppearance.BorderSize = 0
        Me.BMinimizarMenuGerente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BMinimizarMenuGerente.Location = New System.Drawing.Point(1246, 30)
        Me.BMinimizarMenuGerente.Margin = New System.Windows.Forms.Padding(4)
        Me.BMinimizarMenuGerente.Name = "BMinimizarMenuGerente"
        Me.BMinimizarMenuGerente.Size = New System.Drawing.Size(41, 39)
        Me.BMinimizarMenuGerente.TabIndex = 5
        Me.BMinimizarMenuGerente.UseVisualStyleBackColor = True
        '
        'BCerrarMenuGerente
        '
        Me.BCerrarMenuGerente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BCerrarMenuGerente.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.cerrarventana
        Me.BCerrarMenuGerente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BCerrarMenuGerente.FlatAppearance.BorderSize = 0
        Me.BCerrarMenuGerente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCerrarMenuGerente.Location = New System.Drawing.Point(1344, 30)
        Me.BCerrarMenuGerente.Margin = New System.Windows.Forms.Padding(4)
        Me.BCerrarMenuGerente.Name = "BCerrarMenuGerente"
        Me.BCerrarMenuGerente.Size = New System.Drawing.Size(41, 39)
        Me.BCerrarMenuGerente.TabIndex = 4
        Me.BCerrarMenuGerente.UseVisualStyleBackColor = True
        '
        'BRestaurarMenuGerente
        '
        Me.BRestaurarMenuGerente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BRestaurarMenuGerente.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.restaurarventana
        Me.BRestaurarMenuGerente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BRestaurarMenuGerente.FlatAppearance.BorderSize = 0
        Me.BRestaurarMenuGerente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRestaurarMenuGerente.Location = New System.Drawing.Point(1295, 30)
        Me.BRestaurarMenuGerente.Margin = New System.Windows.Forms.Padding(4)
        Me.BRestaurarMenuGerente.Name = "BRestaurarMenuGerente"
        Me.BRestaurarMenuGerente.Size = New System.Drawing.Size(41, 39)
        Me.BRestaurarMenuGerente.TabIndex = 7
        Me.BRestaurarMenuGerente.UseVisualStyleBackColor = True
        '
        'MenuA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1400, 750)
        Me.Controls.Add(Me.PanelFormAdmnistrador)
        Me.Controls.Add(Me.PanelMenuLateral)
        Me.Controls.Add(Me.PanelBarraMenuAdmin)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MenuA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuA"
        Me.PanelMenuLateral.ResumeLayout(False)
        Me.PanelSubMenuUsuarios.ResumeLayout(False)
        Me.PanelIconMenuGerente.ResumeLayout(False)
        Me.PanelIconMenuGerente.PerformLayout()
        Me.PanelBarraMenuAdmin.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BMaximizarMenuGerente As Button
    Friend WithEvents BMinimizarMenuGerente As Button
    Friend WithEvents BCerrarMenuGerente As Button
    Friend WithEvents BSalir As Button
    Friend WithEvents BUsuarios As Button
    Friend WithEvents BRestaurarMenuGerente As Button
    Friend WithEvents PanelMenuLateral As Panel
    Friend WithEvents PanelSubMenuUsuarios As Panel
    Friend WithEvents BGestionarUsuarios As Button
    Friend WithEvents BAñadirUsuario As Button
    Friend WithEvents PanelIconMenuGerente As Panel
    Friend WithEvents PanelFormAdmnistrador As Panel
    Friend WithEvents PanelBarraMenuAdmin As Panel
    Friend WithEvents LIconMenuAdmin As Label
End Class
