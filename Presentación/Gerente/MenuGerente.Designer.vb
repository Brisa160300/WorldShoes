<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuGerente
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
        Me.PanelBarraMenuAdmin = New System.Windows.Forms.Panel()
        Me.BMaximizarMenuGerente = New System.Windows.Forms.Button()
        Me.BMinimizarMenuGerente = New System.Windows.Forms.Button()
        Me.BCerrarMenuGerente = New System.Windows.Forms.Button()
        Me.BRestaurarMenuGerente = New System.Windows.Forms.Button()
        Me.PanelIconMenuGerente = New System.Windows.Forms.Panel()
        Me.PanelLogo = New System.Windows.Forms.Panel()
        Me.LIconMenu = New System.Windows.Forms.Label()
        Me.LIconMenuAdmin = New System.Windows.Forms.Label()
        Me.BReportesHoy = New System.Windows.Forms.Button()
        Me.BReportesSemanal = New System.Windows.Forms.Button()
        Me.BReportesMensual = New System.Windows.Forms.Button()
        Me.PanelSubMenuVentasPor = New System.Windows.Forms.Panel()
        Me.BVentasPorVendedor = New System.Windows.Forms.Button()
        Me.BVentasPorMarca = New System.Windows.Forms.Button()
        Me.BVentasPorCategoria = New System.Windows.Forms.Button()
        Me.PanelMenuLateral = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BReportesPorFecha = New System.Windows.Forms.Button()
        Me.BReporteVenta = New System.Windows.Forms.Button()
        Me.BSalir = New System.Windows.Forms.Button()
        Me.PanelFormAdmnistrador = New System.Windows.Forms.Panel()
        Me.PanelBarraMenuAdmin.SuspendLayout()
        Me.PanelIconMenuGerente.SuspendLayout()
        Me.PanelLogo.SuspendLayout()
        Me.PanelSubMenuVentasPor.SuspendLayout()
        Me.PanelMenuLateral.SuspendLayout()
        Me.SuspendLayout()
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
        Me.PanelBarraMenuAdmin.Margin = New System.Windows.Forms.Padding(5, 2, 5, 2)
        Me.PanelBarraMenuAdmin.Name = "PanelBarraMenuAdmin"
        Me.PanelBarraMenuAdmin.Size = New System.Drawing.Size(1400, 94)
        Me.PanelBarraMenuAdmin.TabIndex = 22
        '
        'BMaximizarMenuGerente
        '
        Me.BMaximizarMenuGerente.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BMaximizarMenuGerente.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.maximizarBlanco
        Me.BMaximizarMenuGerente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BMaximizarMenuGerente.FlatAppearance.BorderSize = 0
        Me.BMaximizarMenuGerente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BMaximizarMenuGerente.Location = New System.Drawing.Point(1316, 24)
        Me.BMaximizarMenuGerente.Margin = New System.Windows.Forms.Padding(5)
        Me.BMaximizarMenuGerente.Name = "BMaximizarMenuGerente"
        Me.BMaximizarMenuGerente.Size = New System.Drawing.Size(33, 31)
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
        Me.BMinimizarMenuGerente.Location = New System.Drawing.Point(1277, 24)
        Me.BMinimizarMenuGerente.Margin = New System.Windows.Forms.Padding(5)
        Me.BMinimizarMenuGerente.Name = "BMinimizarMenuGerente"
        Me.BMinimizarMenuGerente.Size = New System.Drawing.Size(33, 31)
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
        Me.BCerrarMenuGerente.Location = New System.Drawing.Point(1355, 24)
        Me.BCerrarMenuGerente.Margin = New System.Windows.Forms.Padding(5)
        Me.BCerrarMenuGerente.Name = "BCerrarMenuGerente"
        Me.BCerrarMenuGerente.Size = New System.Drawing.Size(33, 31)
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
        Me.BRestaurarMenuGerente.Location = New System.Drawing.Point(1316, 24)
        Me.BRestaurarMenuGerente.Margin = New System.Windows.Forms.Padding(5)
        Me.BRestaurarMenuGerente.Name = "BRestaurarMenuGerente"
        Me.BRestaurarMenuGerente.Size = New System.Drawing.Size(33, 31)
        Me.BRestaurarMenuGerente.TabIndex = 7
        Me.BRestaurarMenuGerente.UseVisualStyleBackColor = True
        '
        'PanelIconMenuGerente
        '
        Me.PanelIconMenuGerente.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelIconMenuGerente.Controls.Add(Me.PanelLogo)
        Me.PanelIconMenuGerente.Controls.Add(Me.LIconMenuAdmin)
        Me.PanelIconMenuGerente.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelIconMenuGerente.Location = New System.Drawing.Point(0, 0)
        Me.PanelIconMenuGerente.Margin = New System.Windows.Forms.Padding(5)
        Me.PanelIconMenuGerente.Name = "PanelIconMenuGerente"
        Me.PanelIconMenuGerente.Size = New System.Drawing.Size(249, 136)
        Me.PanelIconMenuGerente.TabIndex = 0
        '
        'PanelLogo
        '
        Me.PanelLogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelLogo.Controls.Add(Me.LIconMenu)
        Me.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLogo.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogo.Name = "PanelLogo"
        Me.PanelLogo.Size = New System.Drawing.Size(249, 136)
        Me.PanelLogo.TabIndex = 1
        '
        'LIconMenu
        '
        Me.LIconMenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LIconMenu.AutoSize = True
        Me.LIconMenu.Font = New System.Drawing.Font("Cooper Black", 18.0!)
        Me.LIconMenu.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LIconMenu.Location = New System.Drawing.Point(32, 55)
        Me.LIconMenu.Name = "LIconMenu"
        Me.LIconMenu.Size = New System.Drawing.Size(198, 35)
        Me.LIconMenu.TabIndex = 0
        Me.LIconMenu.Text = "WorldShoes"
        Me.LIconMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LIconMenuAdmin
        '
        Me.LIconMenuAdmin.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LIconMenuAdmin.AutoSize = True
        Me.LIconMenuAdmin.Font = New System.Drawing.Font("Cooper Black", 18.0!)
        Me.LIconMenuAdmin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LIconMenuAdmin.Location = New System.Drawing.Point(46, 58)
        Me.LIconMenuAdmin.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.LIconMenuAdmin.Name = "LIconMenuAdmin"
        Me.LIconMenuAdmin.Size = New System.Drawing.Size(198, 35)
        Me.LIconMenuAdmin.TabIndex = 0
        Me.LIconMenuAdmin.Text = "WorldShoes"
        Me.LIconMenuAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BReportesHoy
        '
        Me.BReportesHoy.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BReportesHoy.Dock = System.Windows.Forms.DockStyle.Top
        Me.BReportesHoy.FlatAppearance.BorderSize = 0
        Me.BReportesHoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BReportesHoy.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BReportesHoy.ForeColor = System.Drawing.Color.White
        Me.BReportesHoy.Location = New System.Drawing.Point(0, 136)
        Me.BReportesHoy.Margin = New System.Windows.Forms.Padding(5)
        Me.BReportesHoy.Name = "BReportesHoy"
        Me.BReportesHoy.Size = New System.Drawing.Size(249, 62)
        Me.BReportesHoy.TabIndex = 22
        Me.BReportesHoy.Text = "Diario"
        Me.BReportesHoy.UseVisualStyleBackColor = False
        '
        'BReportesSemanal
        '
        Me.BReportesSemanal.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BReportesSemanal.Dock = System.Windows.Forms.DockStyle.Top
        Me.BReportesSemanal.FlatAppearance.BorderSize = 0
        Me.BReportesSemanal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BReportesSemanal.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BReportesSemanal.ForeColor = System.Drawing.Color.White
        Me.BReportesSemanal.Location = New System.Drawing.Point(0, 198)
        Me.BReportesSemanal.Margin = New System.Windows.Forms.Padding(5)
        Me.BReportesSemanal.Name = "BReportesSemanal"
        Me.BReportesSemanal.Size = New System.Drawing.Size(249, 62)
        Me.BReportesSemanal.TabIndex = 23
        Me.BReportesSemanal.Text = "Semanal"
        Me.BReportesSemanal.UseVisualStyleBackColor = False
        '
        'BReportesMensual
        '
        Me.BReportesMensual.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BReportesMensual.Dock = System.Windows.Forms.DockStyle.Top
        Me.BReportesMensual.FlatAppearance.BorderSize = 0
        Me.BReportesMensual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BReportesMensual.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BReportesMensual.ForeColor = System.Drawing.Color.White
        Me.BReportesMensual.Location = New System.Drawing.Point(0, 260)
        Me.BReportesMensual.Margin = New System.Windows.Forms.Padding(5)
        Me.BReportesMensual.Name = "BReportesMensual"
        Me.BReportesMensual.Size = New System.Drawing.Size(249, 62)
        Me.BReportesMensual.TabIndex = 24
        Me.BReportesMensual.Text = "Mensual"
        Me.BReportesMensual.UseVisualStyleBackColor = False
        '
        'PanelSubMenuVentasPor
        '
        Me.PanelSubMenuVentasPor.BackColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.PanelSubMenuVentasPor.Controls.Add(Me.BVentasPorVendedor)
        Me.PanelSubMenuVentasPor.Controls.Add(Me.BVentasPorMarca)
        Me.PanelSubMenuVentasPor.Controls.Add(Me.BVentasPorCategoria)
        Me.PanelSubMenuVentasPor.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSubMenuVentasPor.ForeColor = System.Drawing.Color.Gainsboro
        Me.PanelSubMenuVentasPor.Location = New System.Drawing.Point(0, 397)
        Me.PanelSubMenuVentasPor.Margin = New System.Windows.Forms.Padding(5)
        Me.PanelSubMenuVentasPor.Name = "PanelSubMenuVentasPor"
        Me.PanelSubMenuVentasPor.Size = New System.Drawing.Size(249, 184)
        Me.PanelSubMenuVentasPor.TabIndex = 26
        '
        'BVentasPorVendedor
        '
        Me.BVentasPorVendedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BVentasPorVendedor.Dock = System.Windows.Forms.DockStyle.Top
        Me.BVentasPorVendedor.FlatAppearance.BorderSize = 0
        Me.BVentasPorVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVentasPorVendedor.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVentasPorVendedor.ForeColor = System.Drawing.Color.Gainsboro
        Me.BVentasPorVendedor.Location = New System.Drawing.Point(0, 124)
        Me.BVentasPorVendedor.Margin = New System.Windows.Forms.Padding(5)
        Me.BVentasPorVendedor.Name = "BVentasPorVendedor"
        Me.BVentasPorVendedor.Size = New System.Drawing.Size(249, 62)
        Me.BVentasPorVendedor.TabIndex = 3
        Me.BVentasPorVendedor.Text = "Ventas Por Vendedor"
        Me.BVentasPorVendedor.UseVisualStyleBackColor = False
        '
        'BVentasPorMarca
        '
        Me.BVentasPorMarca.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BVentasPorMarca.Dock = System.Windows.Forms.DockStyle.Top
        Me.BVentasPorMarca.FlatAppearance.BorderSize = 0
        Me.BVentasPorMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVentasPorMarca.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVentasPorMarca.ForeColor = System.Drawing.Color.Gainsboro
        Me.BVentasPorMarca.Location = New System.Drawing.Point(0, 62)
        Me.BVentasPorMarca.Margin = New System.Windows.Forms.Padding(5)
        Me.BVentasPorMarca.Name = "BVentasPorMarca"
        Me.BVentasPorMarca.Size = New System.Drawing.Size(249, 62)
        Me.BVentasPorMarca.TabIndex = 2
        Me.BVentasPorMarca.Text = "Ventas Por Marca"
        Me.BVentasPorMarca.UseVisualStyleBackColor = False
        '
        'BVentasPorCategoria
        '
        Me.BVentasPorCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.BVentasPorCategoria.Dock = System.Windows.Forms.DockStyle.Top
        Me.BVentasPorCategoria.FlatAppearance.BorderSize = 0
        Me.BVentasPorCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVentasPorCategoria.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVentasPorCategoria.ForeColor = System.Drawing.Color.Gainsboro
        Me.BVentasPorCategoria.Location = New System.Drawing.Point(0, 0)
        Me.BVentasPorCategoria.Margin = New System.Windows.Forms.Padding(5)
        Me.BVentasPorCategoria.Name = "BVentasPorCategoria"
        Me.BVentasPorCategoria.Size = New System.Drawing.Size(249, 62)
        Me.BVentasPorCategoria.TabIndex = 1
        Me.BVentasPorCategoria.Text = "Ventas Por Categoria"
        Me.BVentasPorCategoria.UseVisualStyleBackColor = False
        '
        'PanelMenuLateral
        '
        Me.PanelMenuLateral.AutoScroll = True
        Me.PanelMenuLateral.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelMenuLateral.Controls.Add(Me.Button1)
        Me.PanelMenuLateral.Controls.Add(Me.BReportesPorFecha)
        Me.PanelMenuLateral.Controls.Add(Me.PanelSubMenuVentasPor)
        Me.PanelMenuLateral.Controls.Add(Me.BReporteVenta)
        Me.PanelMenuLateral.Controls.Add(Me.BReportesMensual)
        Me.PanelMenuLateral.Controls.Add(Me.BReportesSemanal)
        Me.PanelMenuLateral.Controls.Add(Me.BReportesHoy)
        Me.PanelMenuLateral.Controls.Add(Me.BSalir)
        Me.PanelMenuLateral.Controls.Add(Me.PanelIconMenuGerente)
        Me.PanelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenuLateral.Location = New System.Drawing.Point(0, 94)
        Me.PanelMenuLateral.Margin = New System.Windows.Forms.Padding(5)
        Me.PanelMenuLateral.Name = "PanelMenuLateral"
        Me.PanelMenuLateral.Size = New System.Drawing.Size(270, 656)
        Me.PanelMenuLateral.TabIndex = 23
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.ventas
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 656)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(249, 75)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Productos Mas Vendidos"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BReportesPorFecha
        '
        Me.BReportesPorFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BReportesPorFecha.Dock = System.Windows.Forms.DockStyle.Top
        Me.BReportesPorFecha.FlatAppearance.BorderSize = 0
        Me.BReportesPorFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BReportesPorFecha.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BReportesPorFecha.ForeColor = System.Drawing.Color.White
        Me.BReportesPorFecha.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.ventas
        Me.BReportesPorFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BReportesPorFecha.Location = New System.Drawing.Point(0, 581)
        Me.BReportesPorFecha.Margin = New System.Windows.Forms.Padding(5)
        Me.BReportesPorFecha.Name = "BReportesPorFecha"
        Me.BReportesPorFecha.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.BReportesPorFecha.Size = New System.Drawing.Size(249, 75)
        Me.BReportesPorFecha.TabIndex = 27
        Me.BReportesPorFecha.Text = "Reportes Historicos"
        Me.BReportesPorFecha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BReportesPorFecha.UseVisualStyleBackColor = False
        '
        'BReporteVenta
        '
        Me.BReporteVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.BReporteVenta.Dock = System.Windows.Forms.DockStyle.Top
        Me.BReporteVenta.FlatAppearance.BorderSize = 0
        Me.BReporteVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BReporteVenta.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BReporteVenta.ForeColor = System.Drawing.Color.White
        Me.BReporteVenta.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.ventas
        Me.BReporteVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BReporteVenta.Location = New System.Drawing.Point(0, 322)
        Me.BReporteVenta.Margin = New System.Windows.Forms.Padding(5)
        Me.BReporteVenta.Name = "BReporteVenta"
        Me.BReporteVenta.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
        Me.BReporteVenta.Size = New System.Drawing.Size(249, 75)
        Me.BReporteVenta.TabIndex = 16
        Me.BReporteVenta.Text = "Ventas Por"
        Me.BReporteVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BReporteVenta.UseVisualStyleBackColor = False
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
        Me.BSalir.Location = New System.Drawing.Point(0, 731)
        Me.BSalir.Margin = New System.Windows.Forms.Padding(5)
        Me.BSalir.Name = "BSalir"
        Me.BSalir.Padding = New System.Windows.Forms.Padding(8, 0, 0, 0)
        Me.BSalir.Size = New System.Drawing.Size(249, 75)
        Me.BSalir.TabIndex = 14
        Me.BSalir.Text = "Cerrar Sesión"
        Me.BSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BSalir.UseVisualStyleBackColor = False
        '
        'PanelFormAdmnistrador
        '
        Me.PanelFormAdmnistrador.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelFormAdmnistrador.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.PanelFormAdmnistrador.BackgroundImage = Global.Proyecto_RiosyRoman.My.Resources.Resources.logoWorldShoes_removebg_preview
        Me.PanelFormAdmnistrador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PanelFormAdmnistrador.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelFormAdmnistrador.Location = New System.Drawing.Point(271, 94)
        Me.PanelFormAdmnistrador.Margin = New System.Windows.Forms.Padding(5)
        Me.PanelFormAdmnistrador.Name = "PanelFormAdmnistrador"
        Me.PanelFormAdmnistrador.Size = New System.Drawing.Size(1130, 656)
        Me.PanelFormAdmnistrador.TabIndex = 24
        '
        'MenuGerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1400, 750)
        Me.Controls.Add(Me.PanelFormAdmnistrador)
        Me.Controls.Add(Me.PanelMenuLateral)
        Me.Controls.Add(Me.PanelBarraMenuAdmin)
        Me.Font = New System.Drawing.Font("Britannic Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MenuGerente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuGerente"
        Me.PanelBarraMenuAdmin.ResumeLayout(False)
        Me.PanelIconMenuGerente.ResumeLayout(False)
        Me.PanelIconMenuGerente.PerformLayout()
        Me.PanelLogo.ResumeLayout(False)
        Me.PanelLogo.PerformLayout()
        Me.PanelSubMenuVentasPor.ResumeLayout(False)
        Me.PanelMenuLateral.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBarraMenuAdmin As Panel
    Friend WithEvents BMaximizarMenuGerente As Button
    Friend WithEvents BMinimizarMenuGerente As Button
    Friend WithEvents BCerrarMenuGerente As Button
    Friend WithEvents BRestaurarMenuGerente As Button
    Friend WithEvents PanelIconMenuGerente As Panel
    Friend WithEvents LIconMenuAdmin As Label
    Friend WithEvents BSalir As Button
    Friend WithEvents BReportesHoy As Button
    Friend WithEvents BReportesSemanal As Button
    Friend WithEvents BReportesMensual As Button
    Friend WithEvents BReporteVenta As Button
    Friend WithEvents PanelSubMenuVentasPor As Panel
    Friend WithEvents BVentasPorMarca As Button
    Friend WithEvents BVentasPorCategoria As Button
    Friend WithEvents BReportesPorFecha As Button
    Friend WithEvents PanelMenuLateral As Panel
    Friend WithEvents PanelFormAdmnistrador As Panel
    Friend WithEvents PanelLogo As Panel
    Friend WithEvents LIconMenu As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BVentasPorVendedor As Button
End Class
