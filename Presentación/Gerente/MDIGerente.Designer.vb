<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIGerente
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ItemWorldShoes = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuInicio = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem16 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem19 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.BarraTitulo = New System.Windows.Forms.Panel()
        Me.IconExpandir = New FontAwesome.Sharp.IconButton()
        Me.IconMinimizar = New FontAwesome.Sharp.IconButton()
        Me.IconCerrar = New FontAwesome.Sharp.IconButton()
        Me.IconRestaurar = New FontAwesome.Sharp.IconButton()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.PanelContenedor.SuspendLayout()
        Me.BarraTitulo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.MenuStrip2)
        Me.Panel2.Location = New System.Drawing.Point(0, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(201, 591)
        Me.Panel2.TabIndex = 0
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.MenuStrip2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemWorldShoes, Me.MenuInicio, Me.ToolStripMenuItem16, Me.ToolStripMenuItem5, Me.ToolStripMenuItem19})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Padding = New System.Windows.Forms.Padding(8, 15, 0, 2)
        Me.MenuStrip2.Size = New System.Drawing.Size(212, 591)
        Me.MenuStrip2.TabIndex = 10
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ItemWorldShoes
        '
        Me.ItemWorldShoes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ItemWorldShoes.Font = New System.Drawing.Font("Britannic Bold", 15.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemWorldShoes.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ItemWorldShoes.MergeAction = System.Windows.Forms.MergeAction.Insert
        Me.ItemWorldShoes.Name = "ItemWorldShoes"
        Me.ItemWorldShoes.Padding = New System.Windows.Forms.Padding(5, 5, 5, 50)
        Me.ItemWorldShoes.Size = New System.Drawing.Size(155, 86)
        Me.ItemWorldShoes.Text = "World Shoes"
        Me.ItemWorldShoes.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'MenuInicio
        '
        Me.MenuInicio.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem12})
        Me.MenuInicio.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.MenuInicio.ForeColor = System.Drawing.Color.White
        Me.MenuInicio.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_casa_50__1_
        Me.MenuInicio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MenuInicio.Name = "MenuInicio"
        Me.MenuInicio.Padding = New System.Windows.Forms.Padding(18, 0, 18, 0)
        Me.MenuInicio.Size = New System.Drawing.Size(155, 76)
        Me.MenuInicio.Text = "&Inicio"
        Me.MenuInicio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.MenuInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(224, 26)
        Me.ToolStripMenuItem12.Text = "Menú Inicio"
        '
        'ToolStripMenuItem16
        '
        Me.ToolStripMenuItem16.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarProductosToolStripMenuItem, Me.ToolStripMenuItem17})
        Me.ToolStripMenuItem16.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.ToolStripMenuItem16.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem16.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_mujeres_vista_lateral_del_zapato_filled_50
        Me.ToolStripMenuItem16.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem16.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.ToolStripMenuItem16.Name = "ToolStripMenuItem16"
        Me.ToolStripMenuItem16.Padding = New System.Windows.Forms.Padding(18, 0, 18, 0)
        Me.ToolStripMenuItem16.Size = New System.Drawing.Size(155, 76)
        Me.ToolStripMenuItem16.Text = "&Productos"
        Me.ToolStripMenuItem16.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolStripMenuItem16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripMenuItem17
        '
        Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
        Me.ToolStripMenuItem17.Size = New System.Drawing.Size(243, 26)
        Me.ToolStripMenuItem17.Text = "Listar Productos"
        '
        'ToolStripMenuItem19
        '
        Me.ToolStripMenuItem19.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.ToolStripMenuItem19.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem19.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_cierre_de_sesión_redondeado_hacia_la_izquierda_50
        Me.ToolStripMenuItem19.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem19.Name = "ToolStripMenuItem19"
        Me.ToolStripMenuItem19.Padding = New System.Windows.Forms.Padding(18, 0, 18, 0)
        Me.ToolStripMenuItem19.Size = New System.Drawing.Size(155, 76)
        Me.ToolStripMenuItem19.Text = "Cerrar"
        Me.ToolStripMenuItem19.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolStripMenuItem19.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PanelContenedor.Controls.Add(Me.BarraTitulo)
        Me.PanelContenedor.Controls.Add(Me.Panel2)
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1300, 650)
        Me.PanelContenedor.TabIndex = 20
        '
        'BarraTitulo
        '
        Me.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BarraTitulo.Controls.Add(Me.IconExpandir)
        Me.BarraTitulo.Controls.Add(Me.IconMinimizar)
        Me.BarraTitulo.Controls.Add(Me.IconCerrar)
        Me.BarraTitulo.Controls.Add(Me.IconRestaurar)
        Me.BarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.BarraTitulo.Name = "BarraTitulo"
        Me.BarraTitulo.Size = New System.Drawing.Size(1300, 60)
        Me.BarraTitulo.TabIndex = 18
        '
        'IconExpandir
        '
        Me.IconExpandir.BackColor = System.Drawing.Color.Transparent
        Me.IconExpandir.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources._1492790945_39minimize_84242
        Me.IconExpandir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IconExpandir.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconExpandir.IconColor = System.Drawing.Color.Black
        Me.IconExpandir.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconExpandir.Location = New System.Drawing.Point(1089, -1)
        Me.IconExpandir.Name = "IconExpandir"
        Me.IconExpandir.Size = New System.Drawing.Size(53, 50)
        Me.IconExpandir.TabIndex = 20
        Me.IconExpandir.UseVisualStyleBackColor = False
        Me.IconExpandir.Visible = False
        '
        'IconMinimizar
        '
        Me.IconMinimizar.BackColor = System.Drawing.Color.Transparent
        Me.IconMinimizar.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.pngaaa_com_4979905
        Me.IconMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IconMinimizar.FlatAppearance.BorderSize = 0
        Me.IconMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconMinimizar.ForeColor = System.Drawing.Color.White
        Me.IconMinimizar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconMinimizar.IconColor = System.Drawing.Color.Black
        Me.IconMinimizar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconMinimizar.Location = New System.Drawing.Point(1210, 12)
        Me.IconMinimizar.Name = "IconMinimizar"
        Me.IconMinimizar.Size = New System.Drawing.Size(35, 35)
        Me.IconMinimizar.TabIndex = 19
        Me.IconMinimizar.UseVisualStyleBackColor = False
        '
        'IconCerrar
        '
        Me.IconCerrar.BackColor = System.Drawing.Color.Transparent
        Me.IconCerrar.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_cancelar_50
        Me.IconCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.IconCerrar.FlatAppearance.BorderSize = 0
        Me.IconCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconCerrar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconCerrar.IconColor = System.Drawing.Color.Black
        Me.IconCerrar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconCerrar.Location = New System.Drawing.Point(1253, 12)
        Me.IconCerrar.Name = "IconCerrar"
        Me.IconCerrar.Size = New System.Drawing.Size(35, 35)
        Me.IconCerrar.TabIndex = 18
        Me.IconCerrar.UseVisualStyleBackColor = False
        '
        'IconRestaurar
        '
        Me.IconRestaurar.BackColor = System.Drawing.Color.Transparent
        Me.IconRestaurar.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.icons8_estudio_visual_50
        Me.IconRestaurar.IconChar = FontAwesome.Sharp.IconChar.None
        Me.IconRestaurar.IconColor = System.Drawing.Color.Black
        Me.IconRestaurar.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconRestaurar.Location = New System.Drawing.Point(1030, -1)
        Me.IconRestaurar.Name = "IconRestaurar"
        Me.IconRestaurar.Size = New System.Drawing.Size(53, 50)
        Me.IconRestaurar.TabIndex = 21
        Me.IconRestaurar.UseVisualStyleBackColor = False
        Me.IconRestaurar.Visible = False
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem6})
        Me.ToolStripMenuItem5.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.ToolStripMenuItem5.ForeColor = System.Drawing.Color.White
        Me.ToolStripMenuItem5.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.iconventas
        Me.ToolStripMenuItem5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Padding = New System.Windows.Forms.Padding(18, 0, 18, 0)
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(195, 58)
        Me.ToolStripMenuItem5.Text = "&Visualizar Ventas"
        Me.ToolStripMenuItem5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(224, 26)
        Me.ToolStripMenuItem6.Text = "&Opciones"
        '
        'AgregarProductosToolStripMenuItem
        '
        Me.AgregarProductosToolStripMenuItem.Name = "AgregarProductosToolStripMenuItem"
        Me.AgregarProductosToolStripMenuItem.Size = New System.Drawing.Size(250, 26)
        Me.AgregarProductosToolStripMenuItem.Text = "Añadir Productos"
        '
        'MDIGerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1282, 603)
        Me.Controls.Add(Me.PanelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MDIGerente"
        Me.Text = "MDIGerente"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.PanelContenedor.ResumeLayout(False)
        Me.BarraTitulo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ItemWorldShoes As ToolStripMenuItem
    Friend WithEvents MenuInicio As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem16 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem17 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem19 As ToolStripMenuItem
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents BarraTitulo As Panel
    Friend WithEvents IconExpandir As FontAwesome.Sharp.IconButton
    Friend WithEvents IconMinimizar As FontAwesome.Sharp.IconButton
    Friend WithEvents IconCerrar As FontAwesome.Sharp.IconButton
    Friend WithEvents IconRestaurar As FontAwesome.Sharp.IconButton
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents AgregarProductosToolStripMenuItem As ToolStripMenuItem
End Class
