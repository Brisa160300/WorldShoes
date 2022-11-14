Imports System.Text.RegularExpressions

Public Class NProducto
    Function agregar_producto(codigo As Integer, nombre As String, categoria As Integer, precio As Decimal, marca As Integer)
        Dim oproducto = New Productos
        With oproducto
            .cod_producto = codigo
            .nombre = nombre
            .id_categoria = categoria
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
        grid.DataSource = prod.getProductosDetallesAll()
        grid.Columns(2).HeaderText = "Categoria"
        grid.Columns(5).HeaderText = "Marca"
        grid.Columns(6).Visible = False
        grid.Columns(7).HeaderText = "Talle"
        grid.Columns(8).Visible = False
        grid.Columns(9).Visible = False
        grid.Columns(10).Visible = False
        grid.Columns(11).Visible = False
        grid.ClearSelection()
    End Sub

    'Public Sub cargarGrid2(grid As DataGridView)
    '    Dim prod As DProducto = New DProducto
    '    grid.DataSource = prod.getProductosAll()
    '    grid.Columns(0).HeaderText = "ID"
    '    grid.Columns(1).HeaderText = "Nombre"
    '    grid.Columns(2).HeaderText = "Categoria"
    '    grid.Columns(3).HeaderText = "Precio"
    '    grid.Columns(4).HeaderText = "Marca"
    '    grid.Columns(5).HeaderText = "Estado"
    '    grid.Columns(6).Visible = False
    '    grid.Columns(7).Visible = False
    '    grid.ClearSelection()

    'End Sub

    Public Sub cargarComboxCateg(combo As ComboBox)
        Dim categ As DCategoria = New DCategoria
        combo.DataSource = categ.getCategoriasAll()
        combo.DisplayMember = "descripcion_categoria"
        combo.ValueMember = "id_categoria"
        combo.DropDownStyle = 2
        combo.SelectedValue = -1
        If combo.SelectedValue = 0 Then
            combo.SelectedValue = -1
        End If
    End Sub



    Public Sub cargarComboxTalle(combo As ComboBox)
        Dim tal As DTalle = New DTalle
        combo.DataSource = tal.getTallesAll()
        combo.DisplayMember = "descripcion"
        combo.ValueMember = "id_talle"
        combo.SelectedValue = -1
        combo.DropDownStyle = 2
        If combo.SelectedValue = 0 Then
            combo.SelectedValue = -1
        End If
    End Sub

    Public Sub cargarComboxMarca(combo As ComboBox)
        Dim marc As DMarca = New DMarca
        combo.DataSource = marc.getMarcasAll()
        combo.DisplayMember = "Descripcion"
        combo.ValueMember = "id_Marca"
        combo.SelectedValue = -1
        combo.DropDownStyle = 2
    End Sub
    Public Sub cargarComboxMarca2(combo As ComboBox, marca As String)
        Dim marc As DMarca = New DMarca
        combo.DataSource = marc.getMarcasAll()
        combo.DisplayMember = "Descripcion"
        combo.ValueMember = "id_Marca"
        combo.DropDownStyle = 2
        combo.SelectedIndex = combo.FindString(marca)

    End Sub

    Public Sub cargarComboxCateg2(combo As ComboBox, ctg As String)
        Dim categ As DCategoria = New DCategoria
        combo.DataSource = categ.getCategoriasAll()
        combo.DisplayMember = "descripcion_categoria"
        combo.ValueMember = "id_categoria"
        combo.DropDownStyle = 2
        combo.SelectedIndex = combo.FindString(ctg)
    End Sub
End Class
