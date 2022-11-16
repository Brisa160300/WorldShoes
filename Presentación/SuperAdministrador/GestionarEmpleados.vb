Public Class GestionarEmpleados
    Private objNEmpleado As NEmpleado = New NEmpleado
    Private objDEmpleado As DEmpleado = New DEmpleado
    Private Sub GestionarEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        objNEmpleado.cargarGrid(dgvEmpleados)
    End Sub

    Private Sub BModificarEmpleado_Click(sender As Object, e As EventArgs) Handles BModificarEmpleado.Click
        If (dgvEmpleados.SelectedRows.Count > 0) Or (dgvEmpleados.SelectedCells.Count > 0) Then
            Dim frm As New ModificarEmpleado
            frm.fila = dgvEmpleados.CurrentRow.Cells(0).Value.ToString
            frm.TBNombreEmpleado.Text = dgvEmpleados.CurrentRow.Cells(1).Value.ToString
            frm.TBApellidoEmpleado.Text = dgvEmpleados.CurrentRow.Cells(2).Value.ToString
            frm.TBDniEmpleado.Text = dgvEmpleados.CurrentRow.Cells(3).Value
            frm.TBTelEmpleado.Text = dgvEmpleados.CurrentRow.Cells(4).Value
            frm.TBDireccionEmpleado.Text = dgvEmpleados.CurrentRow.Cells(5).Value
            frm.TBCorreoEmpleado.Text = dgvEmpleados.CurrentRow.Cells(6).Value
            frm.ShowInTaskbar = False
            frm.ShowDialog()
            objNEmpleado.cargarGrid(dgvEmpleados)
        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If
    End Sub

    Private Sub BVolver_Click(sender As Object, e As EventArgs) Handles BVolver.Click
        Me.Close()
    End Sub

    Private Sub BAltaEmpleado_Click(sender As Object, e As EventArgs) Handles BAltaEmpleado.Click
        If (dgvEmpleados.SelectedRows.Count > 0) Or (dgvEmpleados.SelectedCells.Count > 0) Then
            Dim ask As MsgBoxResult = MsgBox("Seguro desea dar de alta a este empleado?", vbExclamation + vbYesNo)
            If ask = vbYes Then
                objDEmpleado.AltaEmpleado(CInt(dgvEmpleados.CurrentRow.Cells(0).Value.ToString))
                objNEmpleado.cargarGrid(dgvEmpleados)
            End If
        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If
    End Sub

    Private Sub BEliminarUsuario_Click(sender As Object, e As EventArgs) Handles BEliminarUsuario.Click
        If (dgvEmpleados.SelectedRows.Count > 0) Or (dgvEmpleados.SelectedCells.Count > 0) Then
            Dim ask As MsgBoxResult = MsgBox("Seguro desea eliminar esta registro", vbExclamation + vbYesNo)
            If ask = vbYes Then
                objDEmpleado.EliminarEmpleado(CInt(dgvEmpleados.CurrentRow.Cells(0).Value.ToString))
                objNEmpleado.cargarGrid(dgvEmpleados)
            End If
        Else
            MsgBox("Por favor seleccione una fila", vbExclamation)
        End If
    End Sub

    Private Sub dgvEmpleados_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpleados.CellClick
        Dim fil As Integer = dgvEmpleados.CurrentRow.Index
        If dgvEmpleados.Rows(fil).Cells(7).Value = "Activo" Then
            BEliminarUsuario.Visible = True
            BAltaEmpleado.Visible = False
        Else
            BEliminarUsuario.Visible = False
            BAltaEmpleado.Visible = True
        End If
    End Sub

End Class