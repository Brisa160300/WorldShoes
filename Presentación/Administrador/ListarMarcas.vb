Public Class ListarMarcas
    Private objNMarca = New NMarca
    Private objDMarca = New DMarca
    Private Sub BVolver_Click(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub

    Private Sub ListarMarcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not dgvListaMarca.Rows.Count > 0 Then
            BEliminarMarca.Enabled = True
            BEditarMarca.Enabled = True
        Else
            BEliminarMarca.Enabled = False
            BEditarMarca.Enabled = False
        End If
        objNMarca.cargarGrid(dgvListaMarca)
        dgvListaMarca.ClearSelection()
    End Sub

    Private Sub BEditarMarca_Click(sender As Object, e As EventArgs) Handles BEditarMarca.Click
        If (dgvListaMarca.SelectedRows.Count > 0) Or (dgvListaMarca.SelectedCells.Count > 0) Then
            Dim frmEdit As New ModificarMarca
            frmEdit.fila = dgvListaMarca.CurrentRow.Cells(0).Value.ToString
            frmEdit.TBModMarca.Text = dgvListaMarca.CurrentRow.Cells(1).Value.ToString
            frmEdit.ShowInTaskbar = False
            frmEdit.ShowDialog()
            objNMarca.cargarGrid(dgvListaMarca)

        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If
    End Sub

    Private Sub BEliminarMarca_Click(sender As Object, e As EventArgs) Handles BEliminarMarca.Click
        If (dgvListaMarca.SelectedRows.Count > 0) Or (dgvListaMarca.SelectedCells.Count > 0) Then
            Dim ask As MsgBoxResult = MsgBox("Seguro desea eliminar esta registro", vbExclamation + vbYesNo)
            If ask = vbYes Then
                objDMarca.EliminarMarca(CInt(dgvListaMarca.CurrentRow.Cells(0).Value.ToString))
                objNMarca.cargarGrid(dgvListaMarca)
            End If
        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If
    End Sub

    Private Sub BAltaMarca_Click(sender As Object, e As EventArgs) Handles BAltaMarca.Click
        If (dgvListaMarca.SelectedRows.Count > 0) Or (dgvListaMarca.SelectedCells.Count > 0) Then
            Dim ask As MsgBoxResult = MsgBox("Seguro desea dar de alta esta marca", vbExclamation + vbYesNo)
            If ask = vbYes Then
                objDMarca.AltaMarca(CInt(dgvListaMarca.CurrentRow.Cells(0).Value.ToString))
                objNMarca.cargarGrid(dgvListaMarca)
                BEliminarMarca.Visible = True
                BAltaMarca.Visible = False
            End If
        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If
    End Sub

    Private Sub dgvListaMarca_Click(sender As Object, e As EventArgs) Handles dgvListaMarca.Click
        Dim fil As Integer = dgvListaMarca.CurrentRow.Index
        Dim codigo As Integer = dgvListaMarca.Rows(fil).Cells(2).Value
        If codigo = 1 Then
            BEliminarMarca.Visible = True
            BAltaMarca.Visible = False
        Else
            BEliminarMarca.Visible = False
            BAltaMarca.Visible = True
        End If
    End Sub
End Class