﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GestionarUsuarios
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBoxGestionUsuarios = New System.Windows.Forms.GroupBox()
        Me.BEliminarUsuario = New System.Windows.Forms.Button()
        Me.BModificarUsuario = New System.Windows.Forms.Button()
        Me.BBuscarUsuario = New System.Windows.Forms.Button()
        Me.TBGestionUsuario = New System.Windows.Forms.TextBox()
        Me.TabListaClientes = New System.Windows.Forms.TabControl()
        Me.TabPageUsuarios = New System.Windows.Forms.TabPage()
        Me.DataGridViewListaUsuarios = New System.Windows.Forms.DataGridView()
        Me.GroupBoxGestionUsuarios.SuspendLayout()
        Me.TabListaClientes.SuspendLayout()
        Me.TabPageUsuarios.SuspendLayout()
        CType(Me.DataGridViewListaUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxGestionUsuarios
        '
        Me.GroupBoxGestionUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.GroupBoxGestionUsuarios.Controls.Add(Me.BEliminarUsuario)
        Me.GroupBoxGestionUsuarios.Controls.Add(Me.BModificarUsuario)
        Me.GroupBoxGestionUsuarios.Controls.Add(Me.BBuscarUsuario)
        Me.GroupBoxGestionUsuarios.Controls.Add(Me.TBGestionUsuario)
        Me.GroupBoxGestionUsuarios.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.GroupBoxGestionUsuarios.ForeColor = System.Drawing.Color.White
        Me.GroupBoxGestionUsuarios.Location = New System.Drawing.Point(30, 55)
        Me.GroupBoxGestionUsuarios.Name = "GroupBoxGestionUsuarios"
        Me.GroupBoxGestionUsuarios.Size = New System.Drawing.Size(803, 81)
        Me.GroupBoxGestionUsuarios.TabIndex = 25
        Me.GroupBoxGestionUsuarios.TabStop = False
        Me.GroupBoxGestionUsuarios.Text = "Gestión de Usuarios"
        '
        'BEliminarUsuario
        '
        Me.BEliminarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BEliminarUsuario.FlatAppearance.BorderSize = 2
        Me.BEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BEliminarUsuario.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminarUsuario.ForeColor = System.Drawing.Color.White
        Me.BEliminarUsuario.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.trash_6_32
        Me.BEliminarUsuario.Location = New System.Drawing.Point(735, 25)
        Me.BEliminarUsuario.Name = "BEliminarUsuario"
        Me.BEliminarUsuario.Size = New System.Drawing.Size(45, 41)
        Me.BEliminarUsuario.TabIndex = 12
        Me.BEliminarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BEliminarUsuario.UseVisualStyleBackColor = False
        '
        'BModificarUsuario
        '
        Me.BModificarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BModificarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BModificarUsuario.FlatAppearance.BorderSize = 2
        Me.BModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModificarUsuario.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BModificarUsuario.ForeColor = System.Drawing.Color.White
        Me.BModificarUsuario.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.edit_12_32
        Me.BModificarUsuario.Location = New System.Drawing.Point(684, 25)
        Me.BModificarUsuario.Name = "BModificarUsuario"
        Me.BModificarUsuario.Size = New System.Drawing.Size(45, 41)
        Me.BModificarUsuario.TabIndex = 13
        Me.BModificarUsuario.UseVisualStyleBackColor = False
        '
        'BBuscarUsuario
        '
        Me.BBuscarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BBuscarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BBuscarUsuario.FlatAppearance.BorderSize = 2
        Me.BBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BBuscarUsuario.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBuscarUsuario.ForeColor = System.Drawing.Color.White
        Me.BBuscarUsuario.Image = Global.Proyecto_RiosyRoman.My.Resources.Resources.search_3_32
        Me.BBuscarUsuario.Location = New System.Drawing.Point(156, 25)
        Me.BBuscarUsuario.Name = "BBuscarUsuario"
        Me.BBuscarUsuario.Size = New System.Drawing.Size(45, 41)
        Me.BBuscarUsuario.TabIndex = 14
        Me.BBuscarUsuario.UseVisualStyleBackColor = False
        '
        'TBGestionUsuario
        '
        Me.TBGestionUsuario.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.TBGestionUsuario.Location = New System.Drawing.Point(20, 35)
        Me.TBGestionUsuario.Name = "TBGestionUsuario"
        Me.TBGestionUsuario.Size = New System.Drawing.Size(131, 25)
        Me.TBGestionUsuario.TabIndex = 6
        '
        'TabListaClientes
        '
        Me.TabListaClientes.Controls.Add(Me.TabPageUsuarios)
        Me.TabListaClientes.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabListaClientes.Location = New System.Drawing.Point(30, 163)
        Me.TabListaClientes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabListaClientes.Name = "TabListaClientes"
        Me.TabListaClientes.SelectedIndex = 0
        Me.TabListaClientes.Size = New System.Drawing.Size(803, 310)
        Me.TabListaClientes.TabIndex = 24
        '
        'TabPageUsuarios
        '
        Me.TabPageUsuarios.Controls.Add(Me.DataGridViewListaUsuarios)
        Me.TabPageUsuarios.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageUsuarios.ForeColor = System.Drawing.Color.White
        Me.TabPageUsuarios.Location = New System.Drawing.Point(4, 25)
        Me.TabPageUsuarios.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPageUsuarios.Name = "TabPageUsuarios"
        Me.TabPageUsuarios.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPageUsuarios.Size = New System.Drawing.Size(795, 281)
        Me.TabPageUsuarios.TabIndex = 0
        Me.TabPageUsuarios.Text = "Lista de Usuarios"
        Me.TabPageUsuarios.UseVisualStyleBackColor = True
        '
        'DataGridViewListaUsuarios
        '
        Me.DataGridViewListaUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewListaUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewListaUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.DataGridViewListaUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewListaUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewListaUsuarios.ColumnHeadersHeight = 20
        Me.DataGridViewListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewListaUsuarios.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewListaUsuarios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewListaUsuarios.EnableHeadersVisualStyles = False
        Me.DataGridViewListaUsuarios.Location = New System.Drawing.Point(2, 2)
        Me.DataGridViewListaUsuarios.Name = "DataGridViewListaUsuarios"
        Me.DataGridViewListaUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridViewListaUsuarios.RowHeadersWidth = 51
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        Me.DataGridViewListaUsuarios.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewListaUsuarios.Size = New System.Drawing.Size(791, 277)
        Me.DataGridViewListaUsuarios.TabIndex = 2
        '
        'GestionarUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(862, 514)
        Me.Controls.Add(Me.GroupBoxGestionUsuarios)
        Me.Controls.Add(Me.TabListaClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "GestionarUsuarios"
        Me.Text = "GestionarUsuario"
        Me.GroupBoxGestionUsuarios.ResumeLayout(False)
        Me.GroupBoxGestionUsuarios.PerformLayout()
        Me.TabListaClientes.ResumeLayout(False)
        Me.TabPageUsuarios.ResumeLayout(False)
        CType(Me.DataGridViewListaUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxGestionUsuarios As GroupBox
    Friend WithEvents BEliminarUsuario As Button
    Friend WithEvents BModificarUsuario As Button
    Friend WithEvents BBuscarUsuario As Button
    Friend WithEvents TBGestionUsuario As TextBox
    Friend WithEvents TabListaClientes As TabControl
    Friend WithEvents TabPageUsuarios As TabPage
    Friend WithEvents DataGridViewListaUsuarios As DataGridView
End Class
