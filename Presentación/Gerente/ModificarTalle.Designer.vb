﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarTalle
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
        Me.PanelModTalle = New System.Windows.Forms.Panel()
        Me.BCancelarModifCliente = New System.Windows.Forms.Button()
        Me.GroupBoxDatosCliente = New System.Windows.Forms.GroupBox()
        Me.LModTalle = New System.Windows.Forms.Label()
        Me.BModificarTalle = New System.Windows.Forms.Button()
        Me.TBModTalle = New System.Windows.Forms.TextBox()
        Me.PanelModTalle.SuspendLayout()
        Me.GroupBoxDatosCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelModTalle
        '
        Me.PanelModTalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(88, Byte), Integer))
        Me.PanelModTalle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PanelModTalle.Controls.Add(Me.BCancelarModifCliente)
        Me.PanelModTalle.Controls.Add(Me.GroupBoxDatosCliente)
        Me.PanelModTalle.Controls.Add(Me.BModificarTalle)
        Me.PanelModTalle.Location = New System.Drawing.Point(59, 56)
        Me.PanelModTalle.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelModTalle.Name = "PanelModTalle"
        Me.PanelModTalle.Size = New System.Drawing.Size(435, 275)
        Me.PanelModTalle.TabIndex = 4
        '
        'BCancelarModifCliente
        '
        Me.BCancelarModifCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BCancelarModifCliente.FlatAppearance.BorderSize = 2
        Me.BCancelarModifCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BCancelarModifCliente.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelarModifCliente.ForeColor = System.Drawing.Color.White
        Me.BCancelarModifCliente.Location = New System.Drawing.Point(295, 225)
        Me.BCancelarModifCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.BCancelarModifCliente.Name = "BCancelarModifCliente"
        Me.BCancelarModifCliente.Size = New System.Drawing.Size(98, 32)
        Me.BCancelarModifCliente.TabIndex = 12
        Me.BCancelarModifCliente.Text = "Cancelar"
        Me.BCancelarModifCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BCancelarModifCliente.UseVisualStyleBackColor = False
        '
        'GroupBoxDatosCliente
        '
        Me.GroupBoxDatosCliente.Controls.Add(Me.TBModTalle)
        Me.GroupBoxDatosCliente.Controls.Add(Me.LModTalle)
        Me.GroupBoxDatosCliente.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.GroupBoxDatosCliente.ForeColor = System.Drawing.Color.White
        Me.GroupBoxDatosCliente.Location = New System.Drawing.Point(38, 18)
        Me.GroupBoxDatosCliente.Name = "GroupBoxDatosCliente"
        Me.GroupBoxDatosCliente.Size = New System.Drawing.Size(355, 200)
        Me.GroupBoxDatosCliente.TabIndex = 19
        Me.GroupBoxDatosCliente.TabStop = False
        Me.GroupBoxDatosCliente.Text = "Modificar Talle"
        '
        'LModTalle
        '
        Me.LModTalle.AutoSize = True
        Me.LModTalle.Font = New System.Drawing.Font("Britannic Bold", 12.0!)
        Me.LModTalle.ForeColor = System.Drawing.Color.White
        Me.LModTalle.Location = New System.Drawing.Point(92, 69)
        Me.LModTalle.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LModTalle.Name = "LModTalle"
        Me.LModTalle.Size = New System.Drawing.Size(50, 17)
        Me.LModTalle.TabIndex = 15
        Me.LModTalle.Text = "Talle: "
        '
        'BModificarTalle
        '
        Me.BModificarTalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BModificarTalle.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BModificarTalle.FlatAppearance.BorderSize = 2
        Me.BModificarTalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BModificarTalle.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BModificarTalle.ForeColor = System.Drawing.Color.White
        Me.BModificarTalle.Location = New System.Drawing.Point(178, 225)
        Me.BModificarTalle.Margin = New System.Windows.Forms.Padding(4)
        Me.BModificarTalle.Name = "BModificarTalle"
        Me.BModificarTalle.Size = New System.Drawing.Size(97, 32)
        Me.BModificarTalle.TabIndex = 13
        Me.BModificarTalle.Text = "Modificar"
        Me.BModificarTalle.UseVisualStyleBackColor = False
        '
        'TBModTalle
        '
        Me.TBModTalle.Location = New System.Drawing.Point(95, 98)
        Me.TBModTalle.Name = "TBModTalle"
        Me.TBModTalle.Size = New System.Drawing.Size(167, 25)
        Me.TBModTalle.TabIndex = 16
        '
        'ModificarTalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(568, 379)
        Me.Controls.Add(Me.PanelModTalle)
        Me.Name = "ModificarTalle"
        Me.Text = "ModificarTalle"
        Me.PanelModTalle.ResumeLayout(False)
        Me.GroupBoxDatosCliente.ResumeLayout(False)
        Me.GroupBoxDatosCliente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelModTalle As Panel
    Friend WithEvents BCancelarModifCliente As Button
    Friend WithEvents GroupBoxDatosCliente As GroupBox
    Friend WithEvents LModTalle As Label
    Friend WithEvents BModificarTalle As Button
    Friend WithEvents TBModTalle As TextBox
End Class
