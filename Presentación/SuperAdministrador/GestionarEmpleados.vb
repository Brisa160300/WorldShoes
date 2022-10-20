Public Class GestionarEmpleados
    Dim objNEmpleado As NEmpleado = New NEmpleado
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
End Class