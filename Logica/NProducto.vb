Public Class NProducto
    Function agregar_producto(codigo As Integer, nombre As String, categoria As Integer, stock As Integer, precio As Integer, marca As Integer)
        Dim oproducto = New Productos
        With oproducto
            .cod_producto = codigo
            .nombre = nombre
            .id_categoria = categoria
            .stock = stock
            .precio = precio
            .id_marca = marca
            .id_estado_producto = 1
        End With
        Dim objdproducto = New DProducto
        If objdproducto.Dguardar_producto(oproducto) Then

            Return True
        Else
            Return False
        End If

    End Function

    Public Sub cargarGrid(grid As DataGridView)
        Dim prod As DProducto = New DProducto
        grid.DataSource = prod.getProductossAll()
        grid.ClearSelection()

    End Sub

    Public Sub cargarComboxCateg(combo As ComboBox)
        Dim categ As DCategoria = New DCategoria
        combo.DataSource = categ.getCategoriasAll()
        combo.DisplayMember = "descripcion_categoria"
        combo.ValueMember = "id_categoria"
        combo.SelectedValue = -1

    End Sub

    Public Sub cargarComboxTalle(combo As ComboBox)
        Dim tal As DTalle = New DTalle
        combo.DataSource = tal.getTallesAll()
        combo.DisplayMember = "descripcion"
        combo.ValueMember = "id_talle"
        combo.SelectedValue = -1

    End Sub

    Public Sub cargarComboxMarca(combo As ComboBox)
        Dim marc As DMarca = New DMarca
        combo.DataSource = marc.getMarcasAll()
        combo.DisplayMember = "Descripcion"
        combo.ValueMember = "id_Marca"
        combo.SelectedValue = -1

    End Sub
End Class
