<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reportes
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
        Me.PanelBarraMenu = New System.Windows.Forms.Panel()
        Me.BMinimizarMenu = New System.Windows.Forms.Button()
        Me.BCerrarMenu = New System.Windows.Forms.Button()
        Me.BMaximizarMenu = New System.Windows.Forms.Button()
        Me.BRestaurarMenu = New System.Windows.Forms.Button()
        Me.PanelMenuLateral = New System.Windows.Forms.Panel()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.BVentas30dias = New System.Windows.Forms.Button()
        Me.PanelSubMenuClientes = New System.Windows.Forms.Panel()
        Me.BVentas7dias = New System.Windows.Forms.Button()
        Me.BVentasHoy = New System.Windows.Forms.Button()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.PBReportesVentasLogo = New System.Windows.Forms.PictureBox()
        Me.LIconMenu = New System.Windows.Forms.Label()
        Me.PanelFormGerente = New System.Windows.Forms.Panel()
        Me.PanelBarraMenu.SuspendLayout()
        Me.PanelMenuLateral.SuspendLayout()
        Me.PanelSubMenuClientes.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        CType(Me.PBReportesVentasLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelBarraMenu
        '
        Me.PanelBarraMenu.BackColor = System.Drawing.Color.Goldenrod
        Me.PanelBarraMenu.Controls.Add(Me.BMinimizarMenu)
        Me.PanelBarraMenu.Controls.Add(Me.BCerrarMenu)
        Me.PanelBarraMenu.Controls.Add(Me.BMaximizarMenu)
        Me.PanelBarraMenu.Controls.Add(Me.BRestaurarMenu)
        Me.PanelBarraMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraMenu.Margin = New System.Windows.Forms.Padding(4, 2, 4, 2)
        Me.PanelBarraMenu.Name = "PanelBarraMenu"
        Me.PanelBarraMenu.Size = New System.Drawing.Size(1400, 116)
        Me.PanelBarraMenu.TabIndex = 16
        '
        'BMinimizarMenu
        '
        Me.BMinimizarMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BMinimizarMenu.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.minimizar_blanco
        Me.BMinimizarMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BMinimizarMenu.FlatAppearance.BorderSize = 0
        Me.BMinimizarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BMinimizarMenu.Location = New System.Drawing.Point(1233, 37)
        Me.BMinimizarMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BMinimizarMenu.Name = "BMinimizarMenu"
        Me.BMinimizarMenu.Size = New System.Drawing.Size(44, 38)
        Me.BMinimizarMenu.TabIndex = 9
        Me.BMinimizarMenu.UseVisualStyleBackColor = True
        '
        'BCerrarMenu
        '
        Me.BCerrarMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BCerrarMenu.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.cerrarventana
        Me.BCerrarMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BCerrarMenu.FlatAppearance.BorderSize = 0
        Me.BCerrarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCerrarMenu.Location = New System.Drawing.Point(1337, 37)
        Me.BCerrarMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BCerrarMenu.Name = "BCerrarMenu"
        Me.BCerrarMenu.Size = New System.Drawing.Size(44, 38)
        Me.BCerrarMenu.TabIndex = 8
        Me.BCerrarMenu.UseVisualStyleBackColor = True
        '
        'BMaximizarMenu
        '
        Me.BMaximizarMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BMaximizarMenu.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.maximizarBlanco
        Me.BMaximizarMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BMaximizarMenu.FlatAppearance.BorderSize = 0
        Me.BMaximizarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BMaximizarMenu.Location = New System.Drawing.Point(1285, 37)
        Me.BMaximizarMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BMaximizarMenu.Name = "BMaximizarMenu"
        Me.BMaximizarMenu.Size = New System.Drawing.Size(44, 38)
        Me.BMaximizarMenu.TabIndex = 10
        Me.BMaximizarMenu.UseVisualStyleBackColor = True
        '
        'BRestaurarMenu
        '
        Me.BRestaurarMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BRestaurarMenu.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.restaurarventana
        Me.BRestaurarMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BRestaurarMenu.FlatAppearance.BorderSize = 0
        Me.BRestaurarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRestaurarMenu.Location = New System.Drawing.Point(1285, 37)
        Me.BRestaurarMenu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BRestaurarMenu.Name = "BRestaurarMenu"
        Me.BRestaurarMenu.Size = New System.Drawing.Size(44, 38)
        Me.BRestaurarMenu.TabIndex = 11
        Me.BRestaurarMenu.UseVisualStyleBackColor = True
        '
        'PanelMenuLateral
        '
        Me.PanelMenuLateral.AutoScroll = True
        Me.PanelMenuLateral.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelMenuLateral.Controls.Add(Me.BSalir)
        Me.PanelMenuLateral.Controls.Add(Me.BVentas30dias)
        Me.PanelMenuLateral.Controls.Add(Me.PanelSubMenuClientes)
        Me.PanelMenuLateral.Controls.Add(Me.BVentasHoy)
        Me.PanelMenuLateral.Controls.Add(Me.PanelLogo)
        Me.PanelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenuLateral.Location = New System.Drawing.Point(0, 116)
        Me.PanelMenuLateral.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelMenuLateral.Name = "PanelMenuLateral"
        Me.PanelMenuLateral.Size = New System.Drawing.Size(333, 634)
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
        Me.BSalir.Location = New System.Drawing.Point(0, 542)
        Me.BSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.BSalir.Size = New System.Drawing.Size(333, 92)
        Me.BSalir.TabIndex = 15
        Me.BSalir.Text = "Cerrar Sesión"
        Me.BSalir.UseVisualStyleBackColor = False
        '
        'BVentas30dias
        '
        Me.BVentas30dias.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BVentas30dias.Dock = System.Windows.Forms.DockStyle.Top
        Me.BVentas30dias.FlatAppearance.BorderSize = 0
        Me.BVentas30dias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVentas30dias.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVentas30dias.ForeColor = System.Drawing.Color.White
        Me.BVentas30dias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BVentas30dias.Location = New System.Drawing.Point(0, 354)
        Me.BVentas30dias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BVentas30dias.Name = "BVentas30dias"
        Me.BVentas30dias.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.BVentas30dias.Size = New System.Drawing.Size(333, 92)
        Me.BVentas30dias.TabIndex = 10
        Me.BVentas30dias.Text = "Últimos 30 Días"
        Me.BVentas30dias.UseVisualStyleBackColor = False
        '
        'PanelSubMenuClientes
        '
        Me.PanelSubMenuClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelSubMenuClientes.Controls.Add(Me.BVentas7dias)
        Me.PanelSubMenuClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuClientes.ForeColor = System.Drawing.Color.Gainsboro
        Me.PanelSubMenuClientes.Location = New System.Drawing.Point(0, 259)
        Me.PanelSubMenuClientes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelSubMenuClientes.Name = "PanelSubMenuClientes"
        Me.PanelSubMenuClientes.Size = New System.Drawing.Size(333, 95)
        Me.PanelSubMenuClientes.TabIndex = 9
        '
        'BVentas7dias
        '
        Me.BVentas7dias.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BVentas7dias.Dock = System.Windows.Forms.DockStyle.Top
        Me.BVentas7dias.FlatAppearance.BorderSize = 0
        Me.BVentas7dias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVentas7dias.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVentas7dias.ForeColor = System.Drawing.Color.White
        Me.BVentas7dias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BVentas7dias.Location = New System.Drawing.Point(0, 0)
        Me.BVentas7dias.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BVentas7dias.Name = "BVentas7dias"
        Me.BVentas7dias.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.BVentas7dias.Size = New System.Drawing.Size(333, 92)
        Me.BVentas7dias.TabIndex = 9
        Me.BVentas7dias.Text = "Últimos 7 Días"
        Me.BVentas7dias.UseVisualStyleBackColor = False
        '
        'BVentasHoy
        '
        Me.BVentasHoy.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BVentasHoy.Dock = System.Windows.Forms.DockStyle.Top
        Me.BVentasHoy.FlatAppearance.BorderSize = 0
        Me.BVentasHoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVentasHoy.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVentasHoy.ForeColor = System.Drawing.Color.White
        Me.BVentasHoy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BVentasHoy.Location = New System.Drawing.Point(0, 167)
        Me.BVentasHoy.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BVentasHoy.Name = "BVentasHoy"
        Me.BVentasHoy.Padding = New System.Windows.Forms.Padding(7, 0, 0, 0)
        Me.BVentasHoy.Size = New System.Drawing.Size(333, 92)
        Me.BVentasHoy.TabIndex = 8
        Me.BVentasHoy.Text = "Hoy"
        Me.BVentasHoy.UseVisualStyleBackColor = False
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelLogo.Controls.Add(Me.PBReportesVentasLogo)
        Me.PanelLogo.Controls.Add(Me.LIconMenu)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(333, 167)
        Me.PanelLogo.TabIndex = 0
        '
        'PBReportesVentasLogo
        '
        Me.PBReportesVentasLogo.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.ventas
        Me.PBReportesVentasLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PBReportesVentasLogo.Location = New System.Drawing.Point(113, 16)
        Me.PBReportesVentasLogo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PBReportesVentasLogo.Name = "PBReportesVentasLogo"
        Me.PBReportesVentasLogo.Size = New System.Drawing.Size(80, 74)
        Me.PBReportesVentasLogo.TabIndex = 0
        Me.PBReportesVentasLogo.TabStop = False
        '
        'LIconMenu
        '
        Me.LIconMenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LIconMenu.AutoSize = True
        Me.LIconMenu.Font = New System.Drawing.Font("Cooper Black", 15.0!)
        Me.LIconMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LIconMenu.Location = New System.Drawing.Point(16, 94)
        Me.LIconMenu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LIconMenu.Name = "LIconMenu"
        Me.LIconMenu.Size = New System.Drawing.Size(270, 29)
        Me.LIconMenu.TabIndex = 0
        Me.LIconMenu.Text = "Reportes por Fechas"
        Me.LIconMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PanelFormGerente
        '
        Me.PanelFormGerente.AutoScroll = True
        Me.PanelFormGerente.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelFormGerente.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.logoWorldShoes_removebg_preview
        Me.PanelFormGerente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PanelFormGerente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelFormGerente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormGerente.Location = New System.Drawing.Point(0, 116)
        Me.PanelFormGerente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelFormGerente.Name = "PanelFormGerente"
        Me.PanelFormGerente.Size = New System.Drawing.Size(1400, 634)
        Me.PanelFormGerente.TabIndex = 18
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1400, 750)
        Me.Controls.Add(Me.PanelMenuLateral)
        Me.Controls.Add(Me.PanelFormGerente)
        Me.Controls.Add(Me.PanelBarraMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Reportes"
        Me.Text = "Reportes"
        Me.PanelBarraMenu.ResumeLayout(False)
        Me.PanelMenuLateral.ResumeLayout(False)
        Me.PanelSubMenuClientes.ResumeLayout(False)
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelLogo.PerformLayout()
        CType(Me.PBReportesVentasLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBarraMenu As Panel
    Friend WithEvents PanelFormGerente As Panel
    Friend WithEvents PanelMenuLateral As Panel
    Friend WithEvents PanelSubMenuClientes As Panel
    Friend WithEvents BVentas7dias As Button
    Friend WithEvents BVentasHoy As Button
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents LIconMenu As Label
    Friend WithEvents BVentas30dias As Button
    Friend WithEvents BMinimizarMenu As Button
    Friend WithEvents BCerrarMenu As Button
    Friend WithEvents BMaximizarMenu As Button
    Friend WithEvents BRestaurarMenu As Button
    Friend WithEvents BSalir As Button
    Friend WithEvents PBReportesVentasLogo As PictureBox
End Class
