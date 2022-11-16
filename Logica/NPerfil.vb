Public Class NPerfil
    Function agregar_perfil(descripcion As String) As Boolean
        Dim operfil = New Perfiles
        With operfil
            .Descripcion = descripcion
            .estado_perfil = 1
        End With
        Dim objdperfil = New DPerfil
        If objdperfil.Dguardar_perfil(operfil) Then
            Return True
        Else
            Return False
        End If

    End Function
    Public Sub cargarGrid(grid As DataGridView)
        Dim perf As DPerfil = New DPerfil
        grid.DataSource = perf.getPerfilAll()
        grid.Columns(0).HeaderText = "ID"
        grid.ClearSelection()
    End Sub
End Class

