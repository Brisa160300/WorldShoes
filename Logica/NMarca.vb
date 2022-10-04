Public Class NMarca
    Function agregar_marca(descripcion As String) As Boolean
        Dim omarca = New Marcas
        With omarca
            .Descripcion = descripcion
            .Estado = 1
        End With
        Dim objdmarca = New DMarca
        If objdmarca.Dguardar_marca(omarca) Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Sub cargarGrid(grid As DataGridView)
        Dim marc As DMarca = New DMarca
        grid.DataSource = marc.getmarcasAll()
        grid.Columns(0).HeaderText = "ID"
        grid.Columns(1).HeaderText = "Descripción"
        grid.Columns(2).HeaderText = "Estado"
        grid.Columns(3).Visible = False
        grid.ClearSelection()
    End Sub
End Class
