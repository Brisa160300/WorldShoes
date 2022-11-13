<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionarPerfiles
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.GroupBoxGestionPerfil = New System.Windows.Forms.GroupBox()
        Me.BEliminarPerfiles = New System.Windows.Forms.Button()
        Me.BModificarPerfiles = New System.Windows.Forms.Button()
        Me.BBuscarPerfil = New System.Windows.Forms.Button()
        Me.TBGestionPerfil = New System.Windows.Forms.TextBox()
        Me.BAltaPerfil = New System.Windows.Forms.Button()
        Me.TabListaPerfiles = New System.Windows.Forms.TabControl()
        Me.TabPagePerfiles = New System.Windows.Forms.TabPage()
        Me.dgvListaPerfiles = New System.Windows.Forms.DataGridView()
        Me.GroupBoxGestionPerfil.SuspendLayout()
        Me.TabListaPerfiles.SuspendLayout()
        Me.TabPagePerfiles.SuspendLayout()
        CType(Me.dgvListaPerfiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BVolver.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVolver.ForeColor = System.Drawing.Color.White
        Me.BVolver.Location = New System.Drawing.Point(756, 462)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(77, 42)
        Me.BVolver.TabIndex = 26
        Me.BVolver.Text = "Volver"
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'GroupBoxGestionPerfil
        '
        Me.GroupBoxGestionPerfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBoxGestionPerfil.Controls.Add(Me.BEliminarPerfiles)
        Me.GroupBoxGestionPerfil.Controls.Add(Me.BModificarPerfiles)
        Me.GroupBoxGestionPerfil.Controls.Add(Me.BBuscarPerfil)
        Me.GroupBoxGestionPerfil.Controls.Add(Me.TBGestionPerfil)
        Me.GroupBoxGestionPerfil.Controls.Add(Me.BAltaPerfil)
        Me.GroupBoxGestionPerfil.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.GroupBoxGestionPerfil.ForeColor = System.Drawing.Color.White
        Me.GroupBoxGestionPerfil.Location = New System.Drawing.Point(30, 29)
        Me.GroupBoxGestionPerfil.Name = "GroupBoxGestionPerfil"
        Me.GroupBoxGestionPerfil.Size = New System.Drawing.Size(803, 81)
        Me.GroupBoxGestionPerfil.TabIndex = 28
        Me.GroupBoxGestionPerfil.TabStop = False
        Me.GroupBoxGestionPerfil.Text = "Gestión de Perfiles"
        '
        'BEliminarPerfiles
        '
        Me.BEliminarPerfiles.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BEliminarPerfiles.FlatAppearance.BorderSize = 2
        Me.BEliminarPerfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEliminarPerfiles.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminarPerfiles.ForeColor = System.Drawing.Color.White
        Me.BEliminarPerfiles.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.trash_6_32
        Me.BEliminarPerfiles.Location = New System.Drawing.Point(735, 25)
        Me.BEliminarPerfiles.Name = "BEliminarPerfiles"
        Me.BEliminarPerfiles.Size = New System.Drawing.Size(45, 41)
        Me.BEliminarPerfiles.TabIndex = 12
        Me.BEliminarPerfiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BEliminarPerfiles.UseVisualStyleBackColor = False
        '
        'BModificarPerfiles
        '
        Me.BModificarPerfiles.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BModificarPerfiles.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BModificarPerfiles.FlatAppearance.BorderSize = 2
        Me.BModificarPerfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModificarPerfiles.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BModificarPerfiles.ForeColor = System.Drawing.Color.White
        Me.BModificarPerfiles.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.edit_12_32
        Me.BModificarPerfiles.Location = New System.Drawing.Point(684, 25)
        Me.BModificarPerfiles.Name = "BModificarPerfiles"
        Me.BModificarPerfiles.Size = New System.Drawing.Size(45, 41)
        Me.BModificarPerfiles.TabIndex = 13
        Me.BModificarPerfiles.Text = "z"
        Me.BModificarPerfiles.UseVisualStyleBackColor = False
        '
        'BBuscarPerfil
        '
        Me.BBuscarPerfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BBuscarPerfil.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BBuscarPerfil.FlatAppearance.BorderSize = 2
        Me.BBuscarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBuscarPerfil.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscarPerfil.ForeColor = System.Drawing.Color.White
        Me.BBuscarPerfil.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.search_3_32
        Me.BBuscarPerfil.Location = New System.Drawing.Point(156, 25)
        Me.BBuscarPerfil.Name = "BBuscarPerfil"
        Me.BBuscarPerfil.Size = New System.Drawing.Size(45, 41)
        Me.BBuscarPerfil.TabIndex = 14
        Me.BBuscarPerfil.UseVisualStyleBackColor = False
        '
        'TBGestionPerfil
        '
        Me.TBGestionPerfil.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBGestionPerfil.Location = New System.Drawing.Point(20, 35)
        Me.TBGestionPerfil.Name = "TBGestionPerfil"
        Me.TBGestionPerfil.Size = New System.Drawing.Size(131, 25)
        Me.TBGestionPerfil.TabIndex = 6
        '
        'BAltaPerfil
        '
        Me.BAltaPerfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BAltaPerfil.FlatAppearance.BorderSize = 2
        Me.BAltaPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BAltaPerfil.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAltaPerfil.ForeColor = System.Drawing.Color.White
        Me.BAltaPerfil.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.plus_32
        Me.BAltaPerfil.Location = New System.Drawing.Point(735, 25)
        Me.BAltaPerfil.Name = "BAltaPerfil"
        Me.BAltaPerfil.Size = New System.Drawing.Size(45, 41)
        Me.BAltaPerfil.TabIndex = 15
        Me.BAltaPerfil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BAltaPerfil.UseVisualStyleBackColor = False
        '
        'TabListaPerfiles
        '
        Me.TabListaPerfiles.Controls.Add(Me.TabPagePerfiles)
        Me.TabListaPerfiles.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabListaPerfiles.Location = New System.Drawing.Point(30, 135)
        Me.TabListaPerfiles.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabListaPerfiles.Name = "TabListaPerfiles"
        Me.TabListaPerfiles.SelectedIndex = 0
        Me.TabListaPerfiles.Size = New System.Drawing.Size(803, 307)
        Me.TabListaPerfiles.TabIndex = 27
        '
        'TabPagePerfiles
        '
        Me.TabPagePerfiles.Controls.Add(Me.dgvListaPerfiles)
        Me.TabPagePerfiles.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPagePerfiles.ForeColor = System.Drawing.Color.White
        Me.TabPagePerfiles.Location = New System.Drawing.Point(4, 25)
        Me.TabPagePerfiles.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPagePerfiles.Name = "TabPagePerfiles"
        Me.TabPagePerfiles.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPagePerfiles.Size = New System.Drawing.Size(795, 278)
        Me.TabPagePerfiles.TabIndex = 0
        Me.TabPagePerfiles.Text = "Lista de Perfiles"
        Me.TabPagePerfiles.UseVisualStyleBackColor = True
        '
        'dgvListaPerfiles
        '
        Me.dgvListaPerfiles.AllowUserToAddRows = False
        Me.dgvListaPerfiles.AllowUserToDeleteRows = False
        Me.dgvListaPerfiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvListaPerfiles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvListaPerfiles.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgvListaPerfiles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvListaPerfiles.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvListaPerfiles.ColumnHeadersHeight = 20
        Me.dgvListaPerfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvListaPerfiles.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvListaPerfiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListaPerfiles.EnableHeadersVisualStyles = False
        Me.dgvListaPerfiles.Location = New System.Drawing.Point(2, 2)
        Me.dgvListaPerfiles.Name = "dgvListaPerfiles"
        Me.dgvListaPerfiles.ReadOnly = True
        Me.dgvListaPerfiles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvListaPerfiles.RowHeadersWidth = 51
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.dgvListaPerfiles.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvListaPerfiles.Size = New System.Drawing.Size(791, 274)
        Me.dgvListaPerfiles.TabIndex = 2
        '
        'GestionarPerfiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(862, 533)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.GroupBoxGestionPerfil)
        Me.Controls.Add(Me.TabListaPerfiles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "GestionarPerfiles"
        Me.Text = "GestionarPerfiles"
        Me.GroupBoxGestionPerfil.ResumeLayout(False)
        Me.GroupBoxGestionPerfil.PerformLayout()
        Me.TabListaPerfiles.ResumeLayout(False)
        Me.TabPagePerfiles.ResumeLayout(False)
        CType(Me.dgvListaPerfiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BVolver As Button
    Friend WithEvents GroupBoxGestionPerfil As GroupBox
    Friend WithEvents BEliminarPerfiles As Button
    Friend WithEvents BModificarPerfiles As Button
    Friend WithEvents BBuscarPerfil As Button
    Friend WithEvents TBGestionPerfil As TextBox
    Friend WithEvents TabListaPerfiles As TabControl
    Friend WithEvents TabPagePerfiles As TabPage
    Friend WithEvents dgvListaPerfiles As DataGridView
    Friend WithEvents BAltaPerfil As Button
End Class
