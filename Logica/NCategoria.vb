Public Class NCategoria
    Function agregar_categoria(descripcion_categoria As String) As Boolean
        Dim ocategoria = New Categoria
        With ocategoria
            .descripcion_categoria = descripcion_categoria
            .id_estado_categoria = 1
        End With
        Dim objdcategoria = New DCategoria
        If objdcategoria.Dguardar_categoria(ocategoria) Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Sub cargarGrid(grid As DataGridView)
        Dim categ As DCategoria = New DCategoria
        grid.DataSource = categ.getCategoriasAll()
        grid.Columns(0).HeaderText = "ID"
        grid.Columns(1).HeaderText = "Descripción"
        grid.Columns(2).HeaderText = "Estado"
        grid.Columns(3).Visible = False
        grid.ClearSelection()

    End Sub

End Class
