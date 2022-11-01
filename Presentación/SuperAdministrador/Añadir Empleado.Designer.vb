<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Añadir_Empleado
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TBDniEmpleado = New System.Windows.Forms.TextBox()
        Me.LDniEmpleado = New System.Windows.Forms.Label()
        Me.BRegistrarEmpleado = New System.Windows.Forms.Button()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.TBCorreoEmpleado = New System.Windows.Forms.TextBox()
        Me.LCorreoEmpleado = New System.Windows.Forms.Label()
        Me.TBDireccionEmpleado = New System.Windows.Forms.TextBox()
        Me.LDireccionEmpleado = New System.Windows.Forms.Label()
        Me.LTelEmpleado = New System.Windows.Forms.Label()
        Me.TBTelEmpleado = New System.Windows.Forms.TextBox()
        Me.TBApellidoEmpleado = New System.Windows.Forms.TextBox()
        Me.LApellidoEmpleado = New System.Windows.Forms.Label()
        Me.TBNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.LNombreEmpleado = New System.Windows.Forms.Label()
        Me.TabControlListaEmpleados = New System.Windows.Forms.TabControl()
        Me.TabPageListaEmpleados = New System.Windows.Forms.TabPage()
        Me.dgvEmpleados = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProviderNombre = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderApellido = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderDNI = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderTelefono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderDireccion = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProviderEmail = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        Me.TabControlListaEmpleados.SuspendLayout()
        Me.TabPageListaEmpleados.SuspendLayout()
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderApellido, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderDNI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderTelefono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderDireccion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProviderEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TBDniEmpleado)
        Me.Panel1.Controls.Add(Me.LDniEmpleado)
        Me.Panel1.Controls.Add(Me.BRegistrarEmpleado)
        Me.Panel1.Controls.Add(Me.BVolver)
        Me.Panel1.Controls.Add(Me.TBCorreoEmpleado)
        Me.Panel1.Controls.Add(Me.LCorreoEmpleado)
        Me.Panel1.Controls.Add(Me.TBDireccionEmpleado)
        Me.Panel1.Controls.Add(Me.LDireccionEmpleado)
        Me.Panel1.Controls.Add(Me.LTelEmpleado)
        Me.Panel1.Controls.Add(Me.TBTelEmpleado)
        Me.Panel1.Controls.Add(Me.TBApellidoEmpleado)
        Me.Panel1.Controls.Add(Me.LApellidoEmpleado)
        Me.Panel1.Controls.Add(Me.TBNombreEmpleado)
        Me.Panel1.Controls.Add(Me.LNombreEmpleado)
        Me.Panel1.Location = New System.Drawing.Point(58, 118)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(450, 481)
        Me.Panel1.TabIndex = 11
        '
        'TBDniEmpleado
        '
        Me.TBDniEmpleado.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBDniEmpleado.Location = New System.Drawing.Point(189, 175)
        Me.TBDniEmpleado.Margin = New System.Windows.Forms.Padding(4)
        Me.TBDniEmpleado.Name = "TBDniEmpleado"
        Me.TBDniEmpleado.Size = New System.Drawing.Size(150, 32)
        Me.TBDniEmpleado.TabIndex = 45
        '
        'LDniEmpleado
        '
        Me.LDniEmpleado.AutoSize = True
        Me.LDniEmpleado.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LDniEmpleado.ForeColor = System.Drawing.Color.White
        Me.LDniEmpleado.Location = New System.Drawing.Point(48, 178)
        Me.LDniEmpleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LDniEmpleado.Name = "LDniEmpleado"
        Me.LDniEmpleado.Size = New System.Drawing.Size(52, 25)
        Me.LDniEmpleado.TabIndex = 44
        Me.LDniEmpleado.Text = "DNI:"
        '
        'BRegistrarEmpleado
        '
        Me.BRegistrarEmpleado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BRegistrarEmpleado.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BRegistrarEmpleado.FlatAppearance.BorderSize = 2
        Me.BRegistrarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BRegistrarEmpleado.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BRegistrarEmpleado.ForeColor = System.Drawing.Color.White
        Me.BRegistrarEmpleado.Location = New System.Drawing.Point(281, 397)
        Me.BRegistrarEmpleado.Margin = New System.Windows.Forms.Padding(4)
        Me.BRegistrarEmpleado.Name = "BRegistrarEmpleado"
        Me.BRegistrarEmpleado.Size = New System.Drawing.Size(130, 52)
        Me.BRegistrarEmpleado.TabIndex = 43
        Me.BRegistrarEmpleado.Text = "Añadir"
        Me.BRegistrarEmpleado.UseVisualStyleBackColor = False
        '
        'BVolver
        '
        Me.BVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BVolver.FlatAppearance.BorderSize = 2
        Me.BVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BVolver.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.BVolver.ForeColor = System.Drawing.Color.White
        Me.BVolver.Location = New System.Drawing.Point(143, 397)
        Me.BVolver.Margin = New System.Windows.Forms.Padding(4)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(130, 52)
        Me.BVolver.TabIndex = 42
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BVolver.UseVisualStyleBackColor = False
        '
        'TBCorreoEmpleado
        '
        Me.TBCorreoEmpleado.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBCorreoEmpleado.Location = New System.Drawing.Point(189, 332)
        Me.TBCorreoEmpleado.Margin = New System.Windows.Forms.Padding(4)
        Me.TBCorreoEmpleado.Name = "TBCorreoEmpleado"
        Me.TBCorreoEmpleado.Size = New System.Drawing.Size(150, 32)
        Me.TBCorreoEmpleado.TabIndex = 41
        '
        'LCorreoEmpleado
        '
        Me.LCorreoEmpleado.AutoSize = True
        Me.LCorreoEmpleado.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LCorreoEmpleado.ForeColor = System.Drawing.Color.White
        Me.LCorreoEmpleado.Location = New System.Drawing.Point(48, 335)
        Me.LCorreoEmpleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LCorreoEmpleado.Name = "LCorreoEmpleado"
        Me.LCorreoEmpleado.Size = New System.Drawing.Size(72, 25)
        Me.LCorreoEmpleado.TabIndex = 40
        Me.LCorreoEmpleado.Text = "Email:"
        '
        'TBDireccionEmpleado
        '
        Me.TBDireccionEmpleado.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBDireccionEmpleado.Location = New System.Drawing.Point(189, 276)
        Me.TBDireccionEmpleado.Margin = New System.Windows.Forms.Padding(4)
        Me.TBDireccionEmpleado.Name = "TBDireccionEmpleado"
        Me.TBDireccionEmpleado.Size = New System.Drawing.Size(150, 32)
        Me.TBDireccionEmpleado.TabIndex = 39
        '
        'LDireccionEmpleado
        '
        Me.LDireccionEmpleado.AutoSize = True
        Me.LDireccionEmpleado.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LDireccionEmpleado.ForeColor = System.Drawing.Color.White
        Me.LDireccionEmpleado.Location = New System.Drawing.Point(48, 279)
        Me.LDireccionEmpleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LDireccionEmpleado.Name = "LDireccionEmpleado"
        Me.LDireccionEmpleado.Size = New System.Drawing.Size(110, 25)
        Me.LDireccionEmpleado.TabIndex = 38
        Me.LDireccionEmpleado.Text = "Direccion:"
        '
        'LTelEmpleado
        '
        Me.LTelEmpleado.AutoSize = True
        Me.LTelEmpleado.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LTelEmpleado.ForeColor = System.Drawing.Color.White
        Me.LTelEmpleado.Location = New System.Drawing.Point(48, 229)
        Me.LTelEmpleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LTelEmpleado.Name = "LTelEmpleado"
        Me.LTelEmpleado.Size = New System.Drawing.Size(100, 25)
        Me.LTelEmpleado.TabIndex = 37
        Me.LTelEmpleado.Text = "Telefono:"
        '
        'TBTelEmpleado
        '
        Me.TBTelEmpleado.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBTelEmpleado.Location = New System.Drawing.Point(189, 226)
        Me.TBTelEmpleado.Margin = New System.Windows.Forms.Padding(4)
        Me.TBTelEmpleado.Name = "TBTelEmpleado"
        Me.TBTelEmpleado.Size = New System.Drawing.Size(150, 32)
        Me.TBTelEmpleado.TabIndex = 36
        '
        'TBApellidoEmpleado
        '
        Me.TBApellidoEmpleado.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBApellidoEmpleado.Location = New System.Drawing.Point(189, 119)
        Me.TBApellidoEmpleado.Margin = New System.Windows.Forms.Padding(4)
        Me.TBApellidoEmpleado.Name = "TBApellidoEmpleado"
        Me.TBApellidoEmpleado.Size = New System.Drawing.Size(150, 32)
        Me.TBApellidoEmpleado.TabIndex = 35
        '
        'LApellidoEmpleado
        '
        Me.LApellidoEmpleado.AutoSize = True
        Me.LApellidoEmpleado.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LApellidoEmpleado.ForeColor = System.Drawing.Color.White
        Me.LApellidoEmpleado.Location = New System.Drawing.Point(48, 122)
        Me.LApellidoEmpleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LApellidoEmpleado.Name = "LApellidoEmpleado"
        Me.LApellidoEmpleado.Size = New System.Drawing.Size(95, 25)
        Me.LApellidoEmpleado.TabIndex = 34
        Me.LApellidoEmpleado.Text = "Apellido:"
        '
        'TBNombreEmpleado
        '
        Me.TBNombreEmpleado.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.TBNombreEmpleado.Location = New System.Drawing.Point(189, 61)
        Me.TBNombreEmpleado.Margin = New System.Windows.Forms.Padding(4)
        Me.TBNombreEmpleado.Name = "TBNombreEmpleado"
        Me.TBNombreEmpleado.Size = New System.Drawing.Size(150, 32)
        Me.TBNombreEmpleado.TabIndex = 33
        '
        'LNombreEmpleado
        '
        Me.LNombreEmpleado.AutoSize = True
        Me.LNombreEmpleado.Font = New System.Drawing.Font("Britannic Bold", 13.0!)
        Me.LNombreEmpleado.ForeColor = System.Drawing.Color.White
        Me.LNombreEmpleado.Location = New System.Drawing.Point(48, 61)
        Me.LNombreEmpleado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LNombreEmpleado.Name = "LNombreEmpleado"
        Me.LNombreEmpleado.Size = New System.Drawing.Size(93, 25)
        Me.LNombreEmpleado.TabIndex = 32
        Me.LNombreEmpleado.Text = "Nombre:"
        '
        'TabControlListaEmpleados
        '
        Me.TabControlListaEmpleados.Controls.Add(Me.TabPageListaEmpleados)
        Me.TabControlListaEmpleados.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControlListaEmpleados.Location = New System.Drawing.Point(533, 90)
        Me.TabControlListaEmpleados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControlListaEmpleados.Name = "TabControlListaEmpleados"
        Me.TabControlListaEmpleados.SelectedIndex = 0
        Me.TabControlListaEmpleados.Size = New System.Drawing.Size(555, 497)
        Me.TabControlListaEmpleados.TabIndex = 12
        '
        'TabPageListaEmpleados
        '
        Me.TabPageListaEmpleados.Controls.Add(Me.dgvEmpleados)
        Me.TabPageListaEmpleados.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPageListaEmpleados.ForeColor = System.Drawing.Color.White
        Me.TabPageListaEmpleados.Location = New System.Drawing.Point(4, 28)
        Me.TabPageListaEmpleados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaEmpleados.Name = "TabPageListaEmpleados"
        Me.TabPageListaEmpleados.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPageListaEmpleados.Size = New System.Drawing.Size(547, 465)
        Me.TabPageListaEmpleados.TabIndex = 0
        Me.TabPageListaEmpleados.Text = "Lista de Empleados"
        Me.TabPageListaEmpleados.UseVisualStyleBackColor = True
        '
        'dgvEmpleados
        '
        Me.dgvEmpleados.AllowUserToAddRows = False
        Me.dgvEmpleados.AllowUserToDeleteRows = False
        Me.dgvEmpleados.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.dgvEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmpleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEmpleados.ColumnHeadersHeight = 20
        Me.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEmpleados.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEmpleados.EnableHeadersVisualStyles = False
        Me.dgvEmpleados.Location = New System.Drawing.Point(3, 2)
        Me.dgvEmpleados.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvEmpleados.Name = "dgvEmpleados"
        Me.dgvEmpleados.ReadOnly = True
        Me.dgvEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Britannic Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmpleados.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvEmpleados.RowHeadersWidth = 51
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        Me.dgvEmpleados.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvEmpleados.Size = New System.Drawing.Size(541, 461)
        Me.dgvEmpleados.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Britannic Bold", 18.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(52, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 33)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Registrar Empleado:"
        '
        'ErrorProviderNombre
        '
        Me.ErrorProviderNombre.ContainerControl = Me
        '
        'ErrorProviderApellido
        '
        Me.ErrorProviderApellido.ContainerControl = Me
        '
        'ErrorProviderDNI
        '
        Me.ErrorProviderDNI.ContainerControl = Me
        '
        'ErrorProviderTelefono
        '
        Me.ErrorProviderTelefono.ContainerControl = Me
        '
        'ErrorProviderDireccion
        '
        Me.ErrorProviderDireccion.ContainerControl = Me
        '
        'ErrorProviderEmail
        '
        Me.ErrorProviderEmail.ContainerControl = Me
        '
        'Añadir_Empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1150, 656)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControlListaEmpleados)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Añadir_Empleado"
        Me.Text = "Añadir_Empleado"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControlListaEmpleados.ResumeLayout(False)
        Me.TabPageListaEmpleados.ResumeLayout(False)
        CType(Me.dgvEmpleados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderApellido, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderDNI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderTelefono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderDireccion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProviderEmail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TBCorreoEmpleado As TextBox
    Friend WithEvents LCorreoEmpleado As Label
    Friend WithEvents TBDireccionEmpleado As TextBox
    Friend WithEvents LDireccionEmpleado As Label
    Friend WithEvents LTelEmpleado As Label
    Friend WithEvents TBTelEmpleado As TextBox
    Friend WithEvents TBApellidoEmpleado As TextBox
    Friend WithEvents LApellidoEmpleado As Label
    Friend WithEvents TBNombreEmpleado As TextBox
    Friend WithEvents LNombreEmpleado As Label
    Friend WithEvents BRegistrarEmpleado As Button
    Friend WithEvents BVolver As Button
    Friend WithEvents TabControlListaEmpleados As TabControl
    Friend WithEvents TabPageListaEmpleados As TabPage
    Friend WithEvents dgvEmpleados As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TBDniEmpleado As TextBox
    Friend WithEvents LDniEmpleado As Label
    Friend WithEvents ErrorProviderNombre As ErrorProvider
    Friend WithEvents ErrorProviderApellido As ErrorProvider
    Friend WithEvents ErrorProviderDNI As ErrorProvider
    Friend WithEvents ErrorProviderTelefono As ErrorProvider
    Friend WithEvents ErrorProviderDireccion As ErrorProvider
    Friend WithEvents ErrorProviderEmail As ErrorProvider
End Class
