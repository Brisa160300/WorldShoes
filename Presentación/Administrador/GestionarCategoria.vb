Public Class GestionarCategoria
    Dim objNCategoria = New NCategoria
    Dim objDCategoria = New DCategoria
    Private Sub BEditarCategoria_Click(sender As Object, e As EventArgs) Handles BEditarCategoria.Click
        If (dgvListarCategorias.SelectedRows.Count > 0) Or (dgvListarCategorias.SelectedCells.Count > 0) Then
            Dim frmEdit As New ModificarCategoria
            frmEdit.fila = dgvListarCategorias.CurrentRow.Cells(0).Value.ToString
            frmEdit.TBNombreCategoria.Text = dgvListarCategorias.CurrentRow.Cells(1).Value.ToString
            frmEdit.ShowInTaskbar = False
            frmEdit.ShowDialog()
            objNCategoria.cargarGrid(dgvListarCategorias)

        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If
    End Sub

    Private Sub TBGestionCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBGestionCategoria.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) Then
            e.Handled = True
            MsgBox("Solo se aceptan letras", vbCritical, "Error")

        End If
    End Sub
    Private Sub GestionarCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not dgvListarCategorias.Rows.Count > 0 Then
            BEliminarCategoria.Enabled = True
            BEditarCategoria.Enabled = True
        Else
            BEliminarCategoria.Enabled = False
            BEditarCategoria.Enabled = False
        End If

        objNCategoria.cargarGrid(dgvListarCategorias)
    End Sub

    Private Sub BVolver_Click(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub

    Private Sub BEliminarCategoria_Click(sender As Object, e As EventArgs) Handles BEliminarCategoria.Click
        If (dgvListarCategorias.SelectedRows.Count > 0) Or (dgvListarCategorias.SelectedCells.Count > 0) Then
            Dim ask As MsgBoxResult = MsgBox("Seguro desea eliminar esta registro", vbExclamation + vbYesNo)
            If ask = vbYes Then
                objDCategoria.EliminarCateg(CInt(dgvListarCategorias.CurrentRow.Cells(0).Value.ToString))
                objNCategoria.cargarGrid(dgvListarCategorias)
            End If

        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If
    End Sub

    Private Sub dgvListarCategorias_Click(sender As Object, e As EventArgs) Handles dgvListarCategorias.Click
        Dim fil As Integer = dgvListarCategorias.CurrentRow.Index
        Dim codigo As Integer = dgvListarCategorias.Rows(fil).Cells(2).Value
        If codigo = 1 Then
            BEliminarCategoria.Visible = True
            BAltaCategoria.Visible = False
        Else
            BEliminarCategoria.Visible = False
            BAltaCategoria.Visible = True
        End If
    End Sub

    Private Sub BAltaCategoria_Click(sender As Object, e As EventArgs) Handles BAltaCategoria.Click
        Dim ask As MsgBoxResult = MsgBox("Seguro desea agregar esta registro", vbExclamation + vbYesNo)
        If ask = vbYes Then
            If objDCategoria.AltaCateg(CInt(dgvListarCategorias.CurrentRow.Cells(0).Value.ToString)) Then
                objNCategoria.cargarGrid(dgvListarCategorias)
                BEliminarCategoria.Visible = True
                BAltaCategoria.Visible = False
            Else
                MsgBox("No se pudo dar de alta la categoria", vbExclamation, "Error")
            End If


        End If
    End Sub

End Class