<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BackupDatabase
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
        Me.BRestaurar = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BResguardar = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BRestaurar
        '
        Me.BRestaurar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BRestaurar.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BRestaurar.ForeColor = System.Drawing.Color.White
        Me.BRestaurar.Location = New System.Drawing.Point(325, 84)
        Me.BRestaurar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BRestaurar.Name = "BRestaurar"
        Me.BRestaurar.Size = New System.Drawing.Size(131, 52)
        Me.BRestaurar.TabIndex = 27
        Me.BRestaurar.Text = "Restaurar"
        Me.BRestaurar.UseVisualStyleBackColor = False
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BCancelar.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelar.ForeColor = System.Drawing.Color.White
        Me.BCancelar.Location = New System.Drawing.Point(525, 84)
        Me.BCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(131, 52)
        Me.BCancelar.TabIndex = 20
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = False
        '
        'BResguardar
        '
        Me.BResguardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BResguardar.Font = New System.Drawing.Font("Britannic Bold", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BResguardar.ForeColor = System.Drawing.Color.White
        Me.BResguardar.Location = New System.Drawing.Point(120, 84)
        Me.BResguardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BResguardar.Name = "BResguardar"
        Me.BResguardar.Size = New System.Drawing.Size(131, 52)
        Me.BResguardar.TabIndex = 19
        Me.BResguardar.Text = "Resguardar"
        Me.BResguardar.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.Panel2.Controls.Add(Me.BRestaurar)
        Me.Panel2.Controls.Add(Me.BCancelar)
        Me.Panel2.Controls.Add(Me.BResguardar)
        Me.Panel2.Location = New System.Drawing.Point(189, 288)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(793, 217)
        Me.Panel2.TabIndex = 30
        '
        'BackupDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1149, 656)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "BackupDatabase"
        Me.Text = "BackupDatabase"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BRestaurar As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents BResguardar As Button
    Friend WithEvents Panel2 As Panel
End Class
